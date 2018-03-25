using PoeHUD.Models.Enums;
using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class Inventory : RemoteMemoryObject
    {
        public long ItemCount => M.ReadLong(Address + 0x410, 0x638, 0x50);//This one is correct
        public long TotalBoxesInInventoryRow => M.ReadInt(Address + 0x410, 0x638, 0x0C);

        private InventoryType GetInvType()
        {
        // For Poe MemoryLeak bug where ChildCount of PlayerInventory keep
        // Increasing on Area/Map Change. Ref:
        // http://www.ownedcore.com/forums/mmo/path-of-exile/poe-bots-programs/511580-poehud-overlay-updated-362.html#post3718876
        // Orriginal Value of ChildCount should be 0x18
            for (int j = 1; j < InventoryList.InventoryCount; j++)
                if (Game.IngameState.IngameUi.InventoryPanel[(InventoryIndex)j].Address == Address)
                    return InventoryType.PlayerInventory;

            switch (this.AsObject<Element>().Parent.ChildCount)
            {
                case 0x6f:
                    return InventoryType.EssenceStash;
                case 0x36:
                    return InventoryType.CurrencyStash;
                case 0x1C:
                    return InventoryType.FragmentStash;
                case 0x05:
                    if (this.AsObject<Element>().Parent.Children[0].ChildCount == 9)
                        return InventoryType.MapStash;
                    return InventoryType.DivinationStash;
                case 0x01:
                    // Normal Stash and Quad Stash is same.
                    if (TotalBoxesInInventoryRow == 24)
                    {
                        return InventoryType.QuadStash;
                    }
                    return InventoryType.NormalStash;
                default:
                    return InventoryType.InvalidInventory;
            }
        }
        public InventoryType InvType => GetInvType();

        private Element getInventoryElement()
        {
            switch(InvType)
            {
                case InventoryType.PlayerInventory:
                case InventoryType.NormalStash:
                case InventoryType.QuadStash:
                    return this.AsObject<Element>();
                case InventoryType.CurrencyStash:
                case InventoryType.EssenceStash:
                case InventoryType.FragmentStash:
                    return this.AsObject<Element>().Parent;
                case InventoryType.DivinationStash:
                    return GetObject<Element>(M.ReadLong(Address + Element.OffsetBuffers + 0x24, 0x08));
                case InventoryType.MapStash:
                    return this.AsObject<Element>().Parent.Children[3];
                default:
                    return null;
            }
        }
        public Element InventoryUiElement => getInventoryElement();

        // Shows Item details of visible inventory/stashes
        public List<NormalInventoryItem> VisibleInventoryItems
        {
            get
            {
                var InvRoot = InventoryUiElement;
                if (InvRoot == null || InvRoot.Address == 0x00)
                    return null;
                else if (!InvRoot.IsVisible)
                    return null;

                var list = new List<NormalInventoryItem>();
                switch (InvType)
                {
                    case InventoryType.PlayerInventory:
                    case InventoryType.NormalStash:
                    case InventoryType.QuadStash:
                        foreach (var item in InvRoot.Children)
                        {
                            list.Add(item.AsObject<NormalInventoryItem>());
                        }
                        break;
                    case InventoryType.CurrencyStash:
                        foreach (var item in InvRoot.Children)
                        {
                            if (item.ChildCount > 0)
                                list.Add(item.Children[0].AsObject<CurrencyInventoryItem>());
                        }
                        break;
                    case InventoryType.EssenceStash:
                        foreach (var item in InvRoot.Children)
                        {
                            if (item.ChildCount > 0)
                                list.Add(item.Children[0].AsObject<EssenceInventoryItem>());
                        }
                        break;
                    case InventoryType.FragmentStash:
                        foreach (var item in InvRoot.Children)
                        {
                            if (item.ChildCount > 0)
                                list.Add(item.Children[0].AsObject<FragmentInventoryItem>());
                        }
                        break;
                    case InventoryType.DivinationStash:
                        foreach (var item in InvRoot.Children)
                        {
                            // Divination Stash tab isn't loaded.
                            if (item.ChildCount < 2)
                                return null;

                            if (item.Children[1].ChildCount > 0)
                                list.Add(item.Children[1].Children[0].AsObject<DivinationInventoryItem>());
                        }
                        break;
                    case InventoryType.MapStash:
                        foreach (var subInventories in InvRoot.Children)
                        {
                            // VisibleInventoryItems would only be found in Visible Sub Inventory :p
                            if (!subInventories.IsVisible)
                                continue;

                            // All empty sub Inventories have full ChildCount (72) but all childcount have 0 items.
                            if (subInventories.ChildCount == 72 && subInventories.Children[0].AsObject<NormalInventoryItem>().Item.Address == 0x00)
                                continue;

                            foreach (var item in subInventories.Children)
                            {
                                list.Add(item.AsObject<NormalInventoryItem>());
                            }
                        }
                        break;
                }
                return list;
            }
        }

        // Works even if inventory is currently not in view.
        // As long as game have fetched inventory data from Server.
        // Will return the item based on x,y format.
        // Give more controll to user what to do with
        // dublicate items (items taking more than 1 slot)
        // or slots where items doesn't exists (return null).
        public Entity this[int x, int y, int xLength]
        {
            get
            {
                long invAddr = M.ReadLong(Address + 0x410, 0x638, 0x30);
                y = y * xLength;
                long itmAddr = M.ReadLong(invAddr + ((x + y) * 8));
                if (itmAddr <= 0)
                    return null;
                return ReadObject<Entity>(itmAddr);
            }
        }
    }
}
