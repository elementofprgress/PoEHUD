﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeHUD.Hud.Settings;
using PoeHUD.Controllers;
using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Poe.Components;
using SharpDX;
using PoeHUD.Hud;

namespace PoeHUD.Controllers
{
    public class StashTabController
    {
        public static Action<StashTabNode, int> OnStashTabMoveRegistered = delegate { };
        public static Action<StashTabNode, string> OnStashTabRenameRegistered = delegate { };

        public StashTabController()
        {
            GameController.Instance.Area.OnAreaChange += Area_OnAreaChange;
            CheckCacheStashTabs();
        }
        private void Area_OnAreaChange(AreaController obj) => CheckCacheStashTabs();

        //private string League;
        //private string PlayerName;
        private void CheckCacheStashTabs()
        {
            //Fixed a bug when server stash tabs change their position on area change
            /*
            var serverData = GameController.Instance.Game.IngameState.ServerData;
            var playerName = GameController.Instance.Player.GetComponent<Player>().PlayerName;
            var league = serverData.League;

            //We gonna check everything, fx if player have multiple accounts. Also will called once at start
            if (League != league || PlayerName != playerName)
            {
                League = league;
                PlayerName = playerName;

                CacheStashTabs(GameController.Instance.Game.IngameState.ServerData.PlayerStashTabs);
                UpdateRegisteredStashTabNodes();
            }
            */
            CacheStashTabs(GameController.Instance.Game.IngameState.ServerData.PlayerStashTabs);
            UpdateRegisteredStashTabNodes();
        }

        private static List<StashTabNode> CachedStashTabs = new List<StashTabNode>();
        internal static string[] StashTabNames = new string[0];

        //We are not going to iterate throught all subscribed settings stash nodes,
        //so let's detect changes in cached tabs and then apply cahnges to subscribed nodes
        private static void CacheStashTabs(List<ServerStashTab> playerStashTabs)
        {
            CachedStashTabs.Clear();
            StashTabNames = new string[playerStashTabs.Count];

            bool upgradeStashTabFix = false;
            string upgradeStashTabFixName = "???";

            for (int i = 0; i < playerStashTabs.Count; i++)
            {      
                var serverTab = playerStashTabs[i];
                var serverTabVisibleIndex = serverTab.VisibleIndex;
                string serverTabName = serverTab.Name;

                //After upgrading stash tab the VisibleIndex of new tab will be out of range (poe added one more tab (premium) and deleted the old one but not fix the index)
                upgradeStashTabFix = serverTabVisibleIndex >= playerStashTabs.Count;
                if (upgradeStashTabFix)
                {
                    upgradeStashTabFixName = serverTabName;
                    DebugPlug.DebugPlugin.LogMsg($"StashTabController: You just purcased a stash tab {serverTabName}. Move this tab once to fix poe bug with stash tab or restart poe.", 20, Color.Red);
                }
                else
                {
                    StashTabNames[serverTabVisibleIndex] = serverTabName;
                }

                CachedStashTabs.Add(new StashTabNode(serverTab, i));
            }

            if(upgradeStashTabFix)
            {
                //imgui can throw error if some item in list is null (not tested, but happen)
                for (int i = 0; i < StashTabNames.Length; i++)
                {
                    if (string.IsNullOrEmpty(StashTabNames[i]))
                        StashTabNames[i] = upgradeStashTabFixName;
                }
            }
        }

        public static StashTabNode GetStashTabNodeByVisibleIndex(int visibleIndex)
        {
            return CachedStashTabs.Find(x => x.VisibleIndex == visibleIndex);
        }

        #region Nodes Register
        private static readonly List<StashTabNode> SubscribedNodes = new List<StashTabNode>();
        public static void RegisterStashNode(StashTabNode node)
        {
            if (node == null)
            {
                DebugPlug.DebugPlugin.LogMsg($"StashTabController: You are trying to register null StashTabNode", 4, Color.Yellow);
                return;
            }

            if (SubscribedNodes.Contains(node))
            {
                DebugPlug.DebugPlugin.LogMsg($"StashTabController: StashTabNode is already registered (TabName: {node.Name}, VisibleIndex: {node.VisibleIndex})", 4, Color.Yellow);
                return;
            }
            SubscribedNodes.Add(node);
            UpdateRegisteredNode(node);
        }

        public static void UnregisterStashNode(StashTabNode node)
        {
            SubscribedNodes.Remove(node);
        }
        #endregion

        public void CheckStashTabsLoop()
        {
            if (!GameController.Instance.InGame)
                return;

            if (!GameController.Instance.Area.CurrentArea.IsHideout && !GameController.Instance.Area.CurrentArea.IsTown)
                return;

            if (!GameController.Instance.Game.IngameState.IngameUi.OpenLeftPanel.IsVisible)
                return;

            var serverStashTabs = GameController.Instance.Game.IngameState.ServerData.PlayerStashTabs;
            var serverTabsCount = serverStashTabs.Count;
            var cachedTabsCount = CachedStashTabs.Count;

            if (serverTabsCount != cachedTabsCount)
            {
                CacheStashTabs(serverStashTabs);
                cachedTabsCount = CachedStashTabs.Count;
            }

            StashTabNames = new string[serverTabsCount];

            for (int i = 0; i < serverTabsCount; i++)
            {
                var serverTab = serverStashTabs[i];
                var cachedTab = CachedStashTabs[i];
                var serverTabName = serverTab.Name;
                var serverTabVisibleIndex = serverTab.VisibleIndex;

                StashTabNames[serverTabVisibleIndex] = serverTabName;
                
                if (cachedTab.Name != serverTabName)
                {
                    StashTabRenameRegistered(cachedTab, serverTabName);
                    cachedTab.Name = serverTabName;
                }
                else if (cachedTab.VisibleIndex != serverTabVisibleIndex)
                {
                    StashTabMoveRegistered(cachedTab, serverTabVisibleIndex);
                    cachedTab.VisibleIndex = serverTabVisibleIndex;
                }       
            }
        }

        private void StashTabMoveRegistered(StashTabNode tab, int newVisibleIndex)
        {
            if(MainMenuWindow.Settings.DeveloperMode.Value)
                DebugPlug.DebugPlugin.LogMsg($"StashTabMoveRegistered: Name: {tab.Name} ({tab.VisibleIndex} -> {newVisibleIndex})", 2);

            SubscribedNodes.Where(x => x.Exist && x.Id == tab.Id).ToList().ForEach(x => x.VisibleIndex = newVisibleIndex);

            try { OnStashTabMoveRegistered(tab, newVisibleIndex); }
            catch (Exception ex)
            {
                DebugPlug.DebugPlugin.LogMsg($"StashTabController: Error in OnStashTabMoveRegistered event: {ex.Message}", 5);
            }
        }
        private void StashTabRenameRegistered(StashTabNode tab, string newName)
        {
            if (MainMenuWindow.Settings.DeveloperMode.Value)
                DebugPlug.DebugPlugin.LogMsg($"StashTabRenameRegistered: Name: {tab.Name} {tab.Name} -> {newName}", 2);

           SubscribedNodes.Where(x => x.Exist && x.Id == tab.Id).ToList().ForEach(x => x.Name = newName);

            try { OnStashTabRenameRegistered(tab, newName); }
            catch (Exception ex)
            {
                DebugPlug.DebugPlugin.LogMsg($"StashTabController: Error in OnStashTabRenameRegistered event: {ex.Message}", 5);
            }
        }

        //This thing will be called on start and after player change his account or league
        private void UpdateRegisteredStashTabNodes()
        {
            foreach (var node in SubscribedNodes)
            {
                UpdateRegisteredNode(node);
            }
        }

        public static void UpdateRegisteredNode(StashTabNode node)
        {
            StashTabNode foundNode = null;
            bool foundMulptiple = false;
            List<StashTabNode> searchResults = new List<StashTabNode>();

            if (node.Name == StashTabNode.EMPTYNAME)
                goto NotFound;
            searchResults = CachedStashTabs.Where(x => x.Name == node.Name).ToList();

            if (searchResults.Count > 1)
                searchResults = searchResults.Where(x => !x.IsRemoveOnly).ToList();//For same names on standard

            if (searchResults.Count == 0)
                goto NotFound;
            if (searchResults.Count == 1)
            {
                foundNode = searchResults[0];
                goto Found;
            }

            foundMulptiple = true;

            var searchResults2 = searchResults.Where(x => x.VisibleIndex == node.VisibleIndex).ToList();
            if (searchResults2.Count == 1)
            {
                foundNode = searchResults2[0];
                goto Found;
            }

            searchResults2 = searchResults.Where(x => x.Id == node.Id).ToList();//will work on same league/account
            if (searchResults2.Count == 1)
            {
                foundNode = searchResults2[0];
                goto Found;
            }
            else
                goto NotFound;

            Found:
            node.Id = foundNode.Id;
            node.VisibleIndex = foundNode.VisibleIndex;
            node.IsRemoveOnly = foundNode.IsRemoveOnly;
            node.Exist = true;
            return;

            NotFound:
            if (node.Name != StashTabNode.EMPTYNAME)
            {
                if(foundMulptiple)
                    DebugPlug.DebugPlugin.LogMsg($"StashTabController: Found multiple stash tabs ({searchResults.Count}) with name: {node.Name}. Can't select single one due to differend positions. It will be ignored in all plugins using this tab.", 5);
                else
                    DebugPlug.DebugPlugin.LogMsg($"StashTabController: Can't find stash tab with name: {node.Name}. It will be ignored in all plugins using this tab.", 5);
            }
            node.Id = -1;
            node.Exist = false;
            return;
        }
    }
}