﻿using System.ComponentModel;

namespace PoeHUD.Models.Enums
{
    public enum GameStat
    {
        [Description("Level")]
        Level = 1,
        [Description("Item Drop Slots")]
        ItemDropSlots = 2,
        [Description("Main Hand Weapon Type")]
        MainHandWeaponType = 3,
        [Description("Off Hand Weapon Type")]
        OffHandWeaponType = 4,
        [Description("Current Endurance Charges")]
        CurrentEnduranceCharges = 5,
        [Description("Current Frenzy Charges")]
        CurrentFrenzyCharges = 6,
        [Description("Current Power Charges")]
        CurrentPowerCharges = 7,
        [Description("Cannot Have Life Leeched From")]
        CannotHaveLifeLeechedFrom = 8,
        [Description("Cannot Have Mana Leeched From")]
        CannotHaveManaLeechedFrom = 9,
        [Description("Monster Slain Experience +%")]
        MonsterSlainExperiencePosPct = 10,
        [Description("Monster Dropped Item Rarity +%")]
        MonsterDroppedItemRarityPosPct = 11,
        [Description("Monster Dropped Item Quantity +%")]
        MonsterDroppedItemQuantityPosPct = 12,
        [Description("Local Flask Life To Recover")]
        LocalFlaskLifeToRecover = 13,
        [Description("Local Flask Life To Recover +%")]
        LocalFlaskLifeToRecoverPosPct = 14,
        [Description("Local Flask Mana To Recover")]
        LocalFlaskManaToRecover = 15,
        [Description("Local Flask Mana To Recover +%")]
        LocalFlaskManaToRecoverPosPct = 16,
        [Description("Local Flask Recovery Speed +%")]
        LocalFlaskRecoverySpeedPosPct = 17,
        [Description("Local Flask Deciseconds To Recover")]
        LocalFlaskDecisecondsToRecover = 18,
        [Description("Local Extra Max Charges")]
        LocalExtraMaxCharges = 19,
        [Description("Shield Block %")]
        ShieldBlockPct = 20,
        [Description("Blocking Blocks Spells %")]
        BlockingBlocksSpellsPct = 21,
        [Description("Block While Dual Wielding %")]
        BlockWhileDualWieldingPct = 22,
        [Description("Block Recovery +%")]
        BlockRecoveryPosPct = 23,
        [Description("Shield Armour +%")]
        ShieldArmourPosPct = 24,
        [Description("Damage +%")]
        DamagePosPct = 25,
        [Description("Spell Damage +%")]
        SpellDamagePosPct = 26,
        [Description("Physical Damage +%")]
        PhysicalDamagePosPct = 27,
        [Description("Local Physical Damage +%")]
        LocalPhysicalDamagePosPct = 28,
        [Description("Global Minimum Added Physical Damage")]
        GlobalMinimumAddedPhysicalDamage = 29,
        [Description("Global Maximum Added Physical Damage")]
        GlobalMaximumAddedPhysicalDamage = 30,
        [Description("Attack Minimum Added Physical Damage")]
        AttackMinimumAddedPhysicalDamage = 31,
        [Description("Attack Maximum Added Physical Damage")]
        AttackMaximumAddedPhysicalDamage = 32,
        [Description("Local Minimum Added Physical Damage")]
        LocalMinimumAddedPhysicalDamage = 33,
        [Description("Local Maximum Added Physical Damage")]
        LocalMaximumAddedPhysicalDamage = 34,
        [Description("Physical Axe Damage +%")]
        PhysicalAxeDamagePosPct = 35,
        [Description("Physical Staff Damage +%")]
        PhysicalStaffDamagePosPct = 36,
        [Description("Physical Claw Damage +%")]
        PhysicalClawDamagePosPct = 37,
        [Description("Physical Dagger Damage +%")]
        PhysicalDaggerDamagePosPct = 38,
        [Description("Physical Mace Damage +%")]
        PhysicalMaceDamagePosPct = 39,
        [Description("Physical Bow Damage +%")]
        PhysicalBowDamagePosPct = 40,
        [Description("Physical Sword Damage +%")]
        PhysicalSwordDamagePosPct = 41,
        [Description("Physical Wand Damage +%")]
        PhysicalWandDamagePosPct = 42,
        [Description("Fire Damage +%")]
        FireDamagePosPct = 43,
        [Description("Global Minimum Added Fire Damage")]
        GlobalMinimumAddedFireDamage = 44,
        [Description("Global Maximum Added Fire Damage")]
        GlobalMaximumAddedFireDamage = 45,
        [Description("Attack Minimum Added Fire Damage")]
        AttackMinimumAddedFireDamage = 46,
        [Description("Attack Maximum Added Fire Damage")]
        AttackMaximumAddedFireDamage = 47,
        [Description("Local Minimum Added Fire Damage")]
        LocalMinimumAddedFireDamage = 48,
        [Description("Local Maximum Added Fire Damage")]
        LocalMaximumAddedFireDamage = 49,
        [Description("Cold Damage +%")]
        ColdDamagePosPct = 50,
        [Description("Global Minimum Added Cold Damage")]
        GlobalMinimumAddedColdDamage = 51,
        [Description("Global Maximum Added Cold Damage")]
        GlobalMaximumAddedColdDamage = 52,
        [Description("Attack Minimum Added Cold Damage")]
        AttackMinimumAddedColdDamage = 53,
        [Description("Attack Maximum Added Cold Damage")]
        AttackMaximumAddedColdDamage = 54,
        [Description("Local Minimum Added Cold Damage")]
        LocalMinimumAddedColdDamage = 55,
        [Description("Local Maximum Added Cold Damage")]
        LocalMaximumAddedColdDamage = 56,
        [Description("Lightning Damage +%")]
        LightningDamagePosPct = 57,
        [Description("Global Minimum Added Lightning Damage")]
        GlobalMinimumAddedLightningDamage = 58,
        [Description("Global Maximum Added Lightning Damage")]
        GlobalMaximumAddedLightningDamage = 59,
        [Description("Attack Minimum Added Lightning Damage")]
        AttackMinimumAddedLightningDamage = 60,
        [Description("Attack Maximum Added Lightning Damage")]
        AttackMaximumAddedLightningDamage = 61,
        [Description("Local Minimum Added Lightning Damage")]
        LocalMinimumAddedLightningDamage = 62,
        [Description("Local Maximum Added Lightning Damage")]
        LocalMaximumAddedLightningDamage = 63,
        [Description("Chaos Damage +%")]
        ChaosDamagePosPct = 64,
        [Description("Global Minimum Added Chaos Damage")]
        GlobalMinimumAddedChaosDamage = 65,
        [Description("Global Maximum Added Chaos Damage")]
        GlobalMaximumAddedChaosDamage = 66,
        [Description("Attack Minimum Added Chaos Damage")]
        AttackMinimumAddedChaosDamage = 67,
        [Description("Attack Maximum Added Chaos Damage")]
        AttackMaximumAddedChaosDamage = 68,
        [Description("Local Minimum Added Chaos Damage")]
        LocalMinimumAddedChaosDamage = 69,
        [Description("Local Maximum Added Chaos Damage")]
        LocalMaximumAddedChaosDamage = 70,
        [Description("Attack Speed +%")]
        AttackSpeedPosPct = 71,
        [Description("Local Attack Speed +%")]
        LocalAttackSpeedPosPct = 72,
        [Description("Melee Attack Speed +%")]
        MeleeAttackSpeedPosPct = 73,
        [Description("Attack Speed While Dual Wielding +%")]
        AttackSpeedWhileDualWieldingPosPct = 74,
        [Description("Axe Attack Speed +%")]
        AxeAttackSpeedPosPct = 75,
        [Description("Staff Attack Speed +%")]
        StaffAttackSpeedPosPct = 76,
        [Description("Claw Attack Speed +%")]
        ClawAttackSpeedPosPct = 77,
        [Description("Dagger Attack Speed +%")]
        DaggerAttackSpeedPosPct = 78,
        [Description("Mace Attack Speed +%")]
        MaceAttackSpeedPosPct = 79,
        [Description("Bow Attack Speed +%")]
        BowAttackSpeedPosPct = 80,
        [Description("Sword Attack Speed +%")]
        SwordAttackSpeedPosPct = 81,
        [Description("Wand Attack Speed +%")]
        WandAttackSpeedPosPct = 82,
        [Description("Shield Attack Speed +%")]
        ShieldAttackSpeedPosPct = 83,
        [Description("Accuracy Rating")]
        AccuracyRating = 84,
        [Description("Accuracy Rating +%")]
        AccuracyRatingPosPct = 85,
        [Description("Accuracy Rating While Dual Wielding +%")]
        AccuracyRatingWhileDualWieldingPosPct = 86,
        [Description("Axe Accuracy Rating +%")]
        AxeAccuracyRatingPosPct = 87,
        [Description("Staff Accuracy Rating +%")]
        StaffAccuracyRatingPosPct = 88,
        [Description("Claw Accuracy Rating +%")]
        ClawAccuracyRatingPosPct = 89,
        [Description("Dagger Accuracy Rating +%")]
        DaggerAccuracyRatingPosPct = 90,
        [Description("Mace Accuracy Rating +%")]
        MaceAccuracyRatingPosPct = 91,
        [Description("Bow Accuracy Rating +%")]
        BowAccuracyRatingPosPct = 92,
        [Description("Sword Accuracy Rating +%")]
        SwordAccuracyRatingPosPct = 93,
        [Description("Wand Accuracy Rating +%")]
        WandAccuracyRatingPosPct = 94,
        [Description("Poison On Critical Strike With Dagger")]
        PoisonOnCriticalStrikeWithDagger = 95,
        [Description("Base Critical Strike Multiplier +")]
        BaseCriticalStrikeMultiplierPos = 96,
        [Description("Critical Strike Multiplier With Dagger +")]
        CriticalStrikeMultiplierWithDaggerPos = 97,
        [Description("Base Self Critical Strike Multiplier -%")]
        BaseSelfCriticalStrikeMultiplierNegPct = 98,
        [Description("Self Critical Strike Multiplier -% Per Endurance Charge")]
        SelfCriticalStrikeMultiplierNegPctPerEnduranceCharge = 99,
        [Description("Old Do Not Use Local Life Leech From Physical Damage %")]
        OldDoNotUseLocalLifeLeechFromPhysicalDamagePct = 100,
        [Description("Old Do Not Use Local Mana Leech From Physical Damage %")]
        OldDoNotUseLocalManaLeechFromPhysicalDamagePct = 101,
        [Description("Old Do Not Use Life Leech From Physical Damage %")]
        OldDoNotUseLifeLeechFromPhysicalDamagePct = 102,
        [Description("Old Do Not Use Mana Leech From Physical Damage %")]
        OldDoNotUseManaLeechFromPhysicalDamagePct = 103,
        [Description("Old Do Not Use Life Leech From Physical Damage With Claw %")]
        OldDoNotUseLifeLeechFromPhysicalDamageWithClawPct = 104,
        [Description("Base Life Gained On Enemy Death")]
        BaseLifeGainedOnEnemyDeath = 105,
        [Description("Life Leech From Any Damage Permyriad")]
        LifeLeechFromAnyDamagePermyriad = 106,
        [Description("Mana Leech From Any Damage Permyriad")]
        ManaLeechFromAnyDamagePermyriad = 107,
        [Description("Base Mana Gained On Enemy Death")]
        BaseManaGainedOnEnemyDeath = 108,
        [Description("Base Stun Threshold Reduction +%")]
        BaseStunThresholdReductionPosPct = 109,
        [Description("While Using Mace Stun Threshold Reduction +%")]
        WhileUsingMaceStunThresholdReductionPosPct = 110,
        [Description("Global Knockback")]
        GlobalKnockback = 111,
        [Description("Knockback With Bow")]
        KnockbackWithBow = 112,
        [Description("Knockback With Staff")]
        KnockbackWithStaff = 113,
        [Description("Knockback With Wand")]
        KnockbackWithWand = 114,
        [Description("Local Knockback")]
        LocalKnockback = 115,
        [Description("Maximum Physical Damage Reduction %")]
        MaximumPhysicalDamageReductionPct = 116,
        [Description("Base Physical Damage Reduction Rating")]
        BasePhysicalDamageReductionRating = 117,
        [Description("Physical Damage Reduction Rating +%")]
        PhysicalDamageReductionRatingPosPct = 118,
        [Description("Local Physical Damage Reduction Rating +%")]
        LocalPhysicalDamageReductionRatingPosPct = 119,
        [Description("Base Evasion Rating")]
        BaseEvasionRating = 120,
        [Description("Evasion Rating +%")]
        EvasionRatingPosPct = 121,
        [Description("Local Evasion Rating +%")]
        LocalEvasionRatingPosPct = 122,
        [Description("Evasion Rating +% Per Frenzy Charge")]
        EvasionRatingPosPctPerFrenzyCharge = 123,
        [Description("Base Maximum Life")]
        BaseMaximumLife = 124,
        [Description("Maximum Life +%")]
        MaximumLifePosPct = 125,
        [Description("Base Life Regeneration Rate Per Minute")]
        BaseLifeRegenerationRatePerMinute = 126,
        [Description("Life Regeneration Rate Per Minute % Per Endurance Charge")]
        LifeRegenerationRatePerMinutePctPerEnduranceCharge = 127,
        [Description("Base Maximum Mana")]
        BaseMaximumMana = 128,
        [Description("Maximum Mana +%")]
        MaximumManaPosPct = 129,
        [Description("Mana Regeneration Rate Per Minute %")]
        ManaRegenerationRatePerMinutePct = 130,
        [Description("Mana Regeneration Rate +%")]
        ManaRegenerationRatePosPct = 131,
        [Description("Base Mana Regeneration Rate Per Minute")]
        BaseManaRegenerationRatePerMinute = 132,
        [Description("Mana Regeneration Rate Per Minute % Per Power Charge")]
        ManaRegenerationRatePerMinutePctPerPowerCharge = 133,
        [Description("Base Maximum Energy Shield")]
        BaseMaximumEnergyShield = 134,
        [Description("Maximum Energy Shield +%")]
        MaximumEnergyShieldPosPct = 135,
        [Description("Local Energy Shield")]
        LocalEnergyShield = 136,
        [Description("Local Energy Shield +%")]
        LocalEnergyShieldPosPct = 137,
        [Description("Energy Shield Recharge Rate Per Minute %")]
        EnergyShieldRechargeRatePerMinutePct = 138,
        [Description("Energy Shield Recharge Rate +%")]
        EnergyShieldRechargeRatePosPct = 139,
        [Description("Energy Shield Delay -%")]
        EnergyShieldDelayNegPct = 140,
        [Description("Cannot Be Damaged")]
        CannotBeDamaged = 141,
        [Description("Base Resist All Elements %")]
        BaseResistAllElementsPct = 142,
        [Description("Resist All Elements % Per Endurance Charge")]
        ResistAllElementsPctPerEnduranceCharge = 143,
        [Description("Maximum Fire Damage Resistance %")]
        MaximumFireDamageResistancePct = 144,
        [Description("Base Fire Damage Resistance %")]
        BaseFireDamageResistancePct = 145,
        [Description("Maximum Cold Damage Resistance %")]
        MaximumColdDamageResistancePct = 146,
        [Description("Base Cold Damage Resistance %")]
        BaseColdDamageResistancePct = 147,
        [Description("Maximum Lightning Damage Resistance %")]
        MaximumLightningDamageResistancePct = 148,
        [Description("Base Lightning Damage Resistance %")]
        BaseLightningDamageResistancePct = 149,
        [Description("Maximum Chaos Damage Resistance %")]
        MaximumChaosDamageResistancePct = 150,
        [Description("Base Chaos Damage Resistance %")]
        BaseChaosDamageResistancePct = 151,
        [Description("Base Item Found Quantity +%")]
        BaseItemFoundQuantityPosPct = 152,
        [Description("Chest Item Quantity +%")]
        ChestItemQuantityPosPct = 153,
        [Description("Base Item Found Rarity +%")]
        BaseItemFoundRarityPosPct = 154,
        [Description("Chest Item Rarity +%")]
        ChestItemRarityPosPct = 155,
        [Description("Item Found Quality +%")]
        ItemFoundQualityPosPct = 156,
        [Description("Item Found Relevancy +%")]
        ItemFoundRelevancyPosPct = 157,
        [Description("Experience Gain +%")]
        ExperienceGainPosPct = 158,
        [Description("Experience Loss On Death -%")]
        ExperienceLossOnDeathNegPct = 159,
        [Description("Minion Maximum Life +%")]
        MinionMaximumLifePosPct = 160,
        [Description("Base Spectre Maximum Life +%")]
        BaseSpectreMaximumLifePosPct = 161,
        [Description("Base Zombie Maximum Life +%")]
        BaseZombieMaximumLifePosPct = 162,
        [Description("Base Fire Elemental Maximum Life +%")]
        BaseFireElementalMaximumLifePosPct = 163,
        [Description("Base Raven Maximum Life +%")]
        BaseRavenMaximumLifePosPct = 164,
        [Description("Base Number Of Spectres Allowed")]
        BaseNumberOfSpectresAllowed = 165,
        [Description("Base Number Of Zombies Allowed")]
        BaseNumberOfZombiesAllowed = 166,
        [Description("Totem Life +%")]
        TotemLifePosPct = 167,
        [Description("Totem Range +%")]
        TotemRangePosPct = 168,
        [Description("Buff Duration +%")]
        BuffDurationPosPct = 169,
        [Description("Buff Affects Party")]
        BuffAffectsParty = 170,
        [Description("Buff Party Effect Radius +%")]
        BuffPartyEffectRadiusPosPct = 171,
        [Description("Do Not Chain")]
        DoNotChain = 172,
        [Description("Number Of Additional Projectiles In Chain")]
        NumberOfAdditionalProjectilesInChain = 173,
        [Description("Number Of Additional Projectiles")]
        NumberOfAdditionalProjectiles = 174,
        [Description("Base Number Of Additional Arrows")]
        BaseNumberOfAdditionalArrows = 175,
        [Description("Base Projectile Speed +%")]
        BaseProjectileSpeedPosPct = 176,
        [Description("Base Arrow Speed +%")]
        BaseArrowSpeedPosPct = 177,
        [Description("Projectile Homing Magnitude")]
        ProjectileHomingMagnitude = 178,
        [Description("Base Movement Velocity +%")]
        BaseMovementVelocityPosPct = 179,
        [Description("Movement Velocity +% Per Frenzy Charge")]
        MovementVelocityPosPctPerFrenzyCharge = 180,
        [Description("Max Endurance Charges")]
        MaxEnduranceCharges = 181,
        [Description("Max Frenzy Charges")]
        MaxFrenzyCharges = 182,
        [Description("Max Power Charges")]
        MaxPowerCharges = 183,
        [Description("Add Endurance Charge On Critical Strike")]
        AddEnduranceChargeOnCriticalStrike = 184,
        [Description("Add Frenzy Charge On Critical Strike")]
        AddFrenzyChargeOnCriticalStrike = 185,
        [Description("Add Power Charge On Critical Strike")]
        AddPowerChargeOnCriticalStrike = 186,
        [Description("Add Endurance Charge On Skill Hit %")]
        AddEnduranceChargeOnSkillHitPct = 187,
        [Description("Add Frenzy Charge On Skill Hit %")]
        AddFrenzyChargeOnSkillHitPct = 188,
        [Description("Add Power Charge On Skill Hit %")]
        AddPowerChargeOnSkillHitPct = 189,
        [Description("Add Endurance Charge On Enemy Critical Strike")]
        AddEnduranceChargeOnEnemyCriticalStrike = 190,
        [Description("Add Endurance Charge On Status Ailment")]
        AddEnduranceChargeOnStatusAilment = 191,
        [Description("Base Avoid Chill %")]
        BaseAvoidChillPct = 192,
        [Description("Base Avoid Freeze %")]
        BaseAvoidFreezePct = 193,
        [Description("Base Avoid Ignite %")]
        BaseAvoidIgnitePct = 194,
        [Description("Base Avoid Shock %")]
        BaseAvoidShockPct = 195,
        [Description("Avoid Stun %")]
        AvoidStunPct = 196,
        [Description("Always Ignite")]
        AlwaysIgnite = 197,
        [Description("Always Shock")]
        AlwaysShock = 198,
        [Description("Always Stun")]
        AlwaysStun = 199,
        [Description("Always Freeze")]
        AlwaysFreeze = 200,
        [Description("Chill Duration +%")]
        ChillDurationPosPct = 201,
        [Description("Shock Duration +%")]
        ShockDurationPosPct = 202,
        [Description("Freeze Duration +%")]
        FreezeDurationPosPct = 203,
        [Description("Ignite Duration +%")]
        IgniteDurationPosPct = 204,
        [Description("Stun Duration +%")]
        StunDurationPosPct = 205,
        [Description("Base Self Chill Duration -%")]
        BaseSelfChillDurationNegPct = 206,
        [Description("Base Self Shock Duration -%")]
        BaseSelfShockDurationNegPct = 207,
        [Description("Base Self Freeze Duration -%")]
        BaseSelfFreezeDurationNegPct = 208,
        [Description("Base Self Ignite Duration -%")]
        BaseSelfIgniteDurationNegPct = 209,
        [Description("Chance Per Second Of Fire Spreading Between Enemies %")]
        ChancePerSecondOfFireSpreadingBetweenEnemiesPct = 210,
        [Description("Burn Damage +%")]
        BurnDamagePosPct = 211,
        [Description("Active Skill Level +")]
        ActiveSkillLevelPos = 212,
        [Description("Gem Experience Gain +%")]
        GemExperienceGainPosPct = 213,
        [Description("Skill Area Of Effect +%")]
        SkillAreaOfEffectPosPct = 214,
        [Description("Base Mana Cost -%")]
        BaseManaCostNegPct = 215,
        [Description("Skill Repeat Count")]
        SkillRepeatCount = 216,
        [Description("Skill Effect Duration +%")]
        SkillEffectDurationPosPct = 217,
        [Description("Base Cast Speed +%")]
        BaseCastSpeedPosPct = 218,
        [Description("Cast Speed +% Per Power Charge")]
        CastSpeedPosPctPerPowerCharge = 219,
        [Description("Skill Cooldown -%")]
        SkillCooldownNegPct = 220,
        [Description("Avoid Interruption While Casting %")]
        AvoidInterruptionWhileCastingPct = 221,
        [Description("Base Attack Repeat Count")]
        BaseAttackRepeatCount = 222,
        [Description("Base Stun Recovery +%")]
        BaseStunRecoveryPosPct = 223,
        [Description("Stun Recovery +% Per Frenzy Charge")]
        StunRecoveryPosPctPerFrenzyCharge = 224,
        [Description("While Using Sword Reduce Enemy Block %")]
        WhileUsingSwordReduceEnemyBlockPct = 225,
        [Description("Prevent Monster Heal")]
        PreventMonsterHeal = 226,
        [Description("Prevent Monster Heal Duration +%")]
        PreventMonsterHealDurationPosPct = 227,
        [Description("Chest Trap Defuse %")]
        ChestTrapDefusePct = 228,
        [Description("Enemies Chill As Unfrozen")]
        EnemiesChillAsUnfrozen = 229,
        [Description("Shocks Enemies That Hit Actor While Actor Is Casting")]
        ShocksEnemiesThatHitActorWhileActorIsCasting = 230,
        [Description("Local Is Max Quality")]
        LocalIsMaxQuality = 231,
        [Description("Local Disable Gem Experience Gain")]
        LocalDisableGemExperienceGain = 232,
        [Description("Local Gem Experience Gain +%")]
        LocalGemExperienceGainPosPct = 233,
        [Description("Local Extra Socket")]
        LocalExtraSocket = 234,
        [Description("Local Level Requirement -")]
        LocalLevelRequirementNeg = 235,
        [Description("Local Attribute Requirements +%")]
        LocalAttributeRequirementsPosPct = 236,
        [Description("Local All Sockets Are White")]
        LocalAllSocketsAreWhite = 237,
        [Description("Local Quantity Of Sockets +%")]
        LocalQuantityOfSocketsPosPct = 238,
        [Description("Local Connectivity Of Sockets +%")]
        LocalConnectivityOfSocketsPosPct = 239,
        [Description("Local Gem Level +")]
        LocalGemLevelPos = 240,
        [Description("Block %")]
        BlockPct = 241,
        [Description("Physical Damage Reduction Rating")]
        PhysicalDamageReductionRating = 242,
        [Description("Spell Block %")]
        SpellBlockPct = 243,
        [Description("Movement Velocity +%")]
        MovementVelocityPosPct = 244,
        [Description("Is Dual Wielding")]
        IsDualWielding = 245,
        [Description("Maximum Life")]
        MaximumLife = 246,
        [Description("Maximum Mana")]
        MaximumMana = 247,
        [Description("Maximum Energy Shield")]
        MaximumEnergyShield = 248,
        [Description("Life Regeneration Rate Per Minute")]
        LifeRegenerationRatePerMinute = 249,
        [Description("Mana Regeneration Rate Per Minute")]
        ManaRegenerationRatePerMinute = 250,
        [Description("Energy Shield Recharge Rate Per Minute")]
        EnergyShieldRechargeRatePerMinute = 251,
        [Description("Spell Minimum Cold Damage")]
        SpellMinimumColdDamage = 252,
        [Description("Spell Maximum Cold Damage")]
        SpellMaximumColdDamage = 253,
        [Description("Spell Minimum Fire Damage")]
        SpellMinimumFireDamage = 254,
        [Description("Spell Maximum Fire Damage")]
        SpellMaximumFireDamage = 255,
        [Description("Spell Minimum Lightning Damage")]
        SpellMinimumLightningDamage = 256,
        [Description("Spell Minimum Chaos Damage")]
        SpellMinimumChaosDamage = 257,
        [Description("Spell Maximum Lightning Damage")]
        SpellMaximumLightningDamage = 258,
        [Description("Spell Maximum Chaos Damage")]
        SpellMaximumChaosDamage = 259,
        [Description("Spell Minimum Physical Damage")]
        SpellMinimumPhysicalDamage = 260,
        [Description("Spell Maximum Physical Damage")]
        SpellMaximumPhysicalDamage = 261,
        [Description("Main Hand Minimum Cold Damage")]
        MainHandMinimumColdDamage = 262,
        [Description("Main Hand Maximum Cold Damage")]
        MainHandMaximumColdDamage = 263,
        [Description("Off Hand Minimum Cold Damage")]
        OffHandMinimumColdDamage = 264,
        [Description("Off Hand Maximum Cold Damage")]
        OffHandMaximumColdDamage = 265,
        [Description("Main Hand Minimum Fire Damage")]
        MainHandMinimumFireDamage = 266,
        [Description("Main Hand Maximum Fire Damage")]
        MainHandMaximumFireDamage = 267,
        [Description("Off Hand Minimum Fire Damage")]
        OffHandMinimumFireDamage = 268,
        [Description("Off Hand Maximum Fire Damage")]
        OffHandMaximumFireDamage = 269,
        [Description("Main Hand Minimum Lightning Damage")]
        MainHandMinimumLightningDamage = 270,
        [Description("Main Hand Maximum Lightning Damage")]
        MainHandMaximumLightningDamage = 271,
        [Description("Off Hand Minimum Lightning Damage")]
        OffHandMinimumLightningDamage = 272,
        [Description("Off Hand Maximum Lightning Damage")]
        OffHandMaximumLightningDamage = 273,
        [Description("Main Hand Minimum Chaos Damage")]
        MainHandMinimumChaosDamage = 274,
        [Description("Main Hand Maximum Chaos Damage")]
        MainHandMaximumChaosDamage = 275,
        [Description("Off Hand Minimum Chaos Damage")]
        OffHandMinimumChaosDamage = 276,
        [Description("Off Hand Maximum Chaos Damage")]
        OffHandMaximumChaosDamage = 277,
        [Description("Main Hand Minimum Physical Damage")]
        MainHandMinimumPhysicalDamage = 278,
        [Description("Main Hand Maximum Physical Damage")]
        MainHandMaximumPhysicalDamage = 279,
        [Description("Off Hand Minimum Physical Damage")]
        OffHandMinimumPhysicalDamage = 280,
        [Description("Off Hand Maximum Physical Damage")]
        OffHandMaximumPhysicalDamage = 281,
        [Description("Stun Recovery +%")]
        StunRecoveryPosPct = 282,
        [Description("Evasion Rating")]
        EvasionRating = 283,
        [Description("Main Hand Reduce Enemy Block %")]
        MainHandReduceEnemyBlockPct = 284,
        [Description("Off Hand Reduce Enemy Block %")]
        OffHandReduceEnemyBlockPct = 285,
        [Description("Main Hand Critical Strike Multiplier +")]
        MainHandCriticalStrikeMultiplierPos = 286,
        [Description("Off Hand Critical Strike Multiplier +")]
        OffHandCriticalStrikeMultiplierPos = 287,
        [Description("Self Critical Strike Multiplier +%")]
        SelfCriticalStrikeMultiplierPosPct = 288,
        [Description("Main Hand Knockback")]
        MainHandKnockback = 289,
        [Description("Off Hand Knockback")]
        OffHandKnockback = 290,
        [Description("Main Hand Accuracy Rating")]
        MainHandAccuracyRating = 291,
        [Description("Off Hand Accuracy Rating")]
        OffHandAccuracyRating = 292,
        [Description("Main Hand Attack Speed +%")]
        MainHandAttackSpeedPosPct = 293,
        [Description("Off Hand Attack Speed +%")]
        OffHandAttackSpeedPosPct = 294,
        [Description("Cast Speed +%")]
        CastSpeedPosPct = 295,
        [Description("Spectre Maximum Life +%")]
        SpectreMaximumLifePosPct = 296,
        [Description("Zombie Maximum Life +%")]
        ZombieMaximumLifePosPct = 297,
        [Description("Fire Elemental Maximum Life +%")]
        FireElementalMaximumLifePosPct = 298,
        [Description("Raven Maximum Life +%")]
        RavenMaximumLifePosPct = 299,
        [Description("Number Of Additional Arrows")]
        NumberOfAdditionalArrows = 300,
        [Description("Arrow Speed +%")]
        ArrowSpeedPosPct = 301,
        [Description("Main Hand Stun Threshold Reduction +%")]
        MainHandStunThresholdReductionPosPct = 302,
        [Description("Off Hand Stun Threshold Reduction +%")]
        OffHandStunThresholdReductionPosPct = 303,
        [Description("Main Hand Life Leech From Physical Attack Damage Permyriad")]
        MainHandLifeLeechFromPhysicalAttackDamagePermyriad = 304,
        [Description("Off Hand Life Leech From Physical Attack Damage Permyriad")]
        OffHandLifeLeechFromPhysicalAttackDamagePermyriad = 305,
        [Description("Main Hand Mana Leech From Physical Attack Damage Permyriad")]
        MainHandManaLeechFromPhysicalAttackDamagePermyriad = 306,
        [Description("Off Hand Mana Leech From Physical Attack Damage Permyriad")]
        OffHandManaLeechFromPhysicalAttackDamagePermyriad = 307,
        [Description("Cold Damage Resistance %")]
        ColdDamageResistancePct = 308,
        [Description("Fire Damage Resistance %")]
        FireDamageResistancePct = 309,
        [Description("Lightning Damage Resistance %")]
        LightningDamageResistancePct = 310,
        [Description("Chaos Damage Resistance %")]
        ChaosDamageResistancePct = 311,
        [Description("Resist All Elements %")]
        ResistAllElementsPct = 312,
        [Description("Trap Duration +%")]
        TrapDurationPosPct = 313,
        [Description("Trap Trigger Radius +%")]
        TrapTriggerRadiusPosPct = 314,
        [Description("Trap Throwing Speed +%")]
        TrapThrowingSpeedPosPct = 315,
        [Description("Monster Response Time Ms")]
        MonsterResponseTimeMs = 316,
        [Description("Skill Internal Monster Responsiveness +%")]
        SkillInternalMonsterResponsivenessPosPct = 317,
        [Description("Endurance Charges Granted Per One Hundred Nearby Enemies During Endurance Warcry")]
        EnduranceChargesGrantedPerOneHundredNearbyEnemiesDuringEnduranceWarcry = 318,
        [Description("Skill Range +%")]
        SkillRangePosPct = 319,
        [Description("Gem Level +")]
        GemLevelPos = 320,
        [Description("Skill Visual Scale +%")]
        SkillVisualScalePosPct = 321,
        [Description("Imp Variation")]
        ImpVariation = 322,
        [Description("Main Hand Base Weapon Attack Duration Ms")]
        MainHandBaseWeaponAttackDurationMs = 323,
        [Description("Off Hand Base Weapon Attack Duration Ms")]
        OffHandBaseWeaponAttackDurationMs = 324,
        [Description("Main Hand Minimum Attack Distance")]
        MainHandMinimumAttackDistance = 325,
        [Description("Off Hand Minimum Attack Distance")]
        OffHandMinimumAttackDistance = 326,
        [Description("Main Hand Base Maximum Attack Distance")]
        MainHandBaseMaximumAttackDistance = 327,
        [Description("Off Hand Base Maximum Attack Distance")]
        OffHandBaseMaximumAttackDistance = 328,
        [Description("Main Hand Quality")]
        MainHandQuality = 329,
        [Description("Off Hand Quality")]
        OffHandQuality = 330,
        [Description("Base Spell Critical Strike Multiplier +")]
        BaseSpellCriticalStrikeMultiplierPos = 331,
        [Description("Spell Critical Strike Multiplier +")]
        SpellCriticalStrikeMultiplierPos = 332,
        [Description("Is Trap")]
        IsTrap = 333,
        [Description("Weapon Elemental Damage +%")]
        WeaponElementalDamagePosPct = 334,
        [Description("Staff Stun Duration +%")]
        StaffStunDurationPosPct = 335,
        [Description("Two Handed Melee Physical Damage +%")]
        TwoHandedMeleePhysicalDamagePosPct = 336,
        [Description("Two Handed Melee Stun Duration +%")]
        TwoHandedMeleeStunDurationPosPct = 337,
        [Description("Two Handed Melee Attack Speed +%")]
        TwoHandedMeleeAttackSpeedPosPct = 338,
        [Description("Two Handed Melee Accuracy Rating +%")]
        TwoHandedMeleeAccuracyRatingPosPct = 339,
        [Description("Physical Damage While Dual Wielding +%")]
        PhysicalDamageWhileDualWieldingPosPct = 340,
        [Description("One Handed Melee Physical Damage +%")]
        OneHandedMeleePhysicalDamagePosPct = 341,
        [Description("One Handed Melee Attack Speed +%")]
        OneHandedMeleeAttackSpeedPosPct = 342,
        [Description("One Handed Melee Accuracy Rating +%")]
        OneHandedMeleeAccuracyRatingPosPct = 343,
        [Description("Base Stun Duration +%")]
        BaseStunDurationPosPct = 344,
        [Description("Bow Stun Duration +%")]
        BowStunDurationPosPct = 345,
        [Description("Base Life Gain Per Target")]
        BaseLifeGainPerTarget = 346,
        [Description("Corpse Explosion Monster Life %")]
        CorpseExplosionMonsterLifePct = 347,
        [Description("Skill Level")]
        SkillLevel = 348,
        [Description("Action Speed -%")]
        ActionSpeedNegPct = 349,
        [Description("Skill Art Variation")]
        SkillArtVariation = 350,
        [Description("Always Crit")]
        AlwaysCrit = 351,
        [Description("Damage Infusion %")]
        DamageInfusionPct = 352,
        [Description("Chaos Damage Taken Per Minute")]
        ChaosDamageTakenPerMinute = 353,
        [Description("Base Fire Damage To Deal Per Minute")]
        BaseFireDamageToDealPerMinute = 354,
        [Description("Add Frenzy Charge On Kill")]
        AddFrenzyChargeOnKill = 355,
        [Description("Base Fire Damage To Deal To Nearby Per Minute")]
        BaseFireDamageToDealToNearbyPerMinute = 356,
        [Description("Base Physical Damage Taken Per Minute")]
        BasePhysicalDamageTakenPerMinute = 357,
        [Description("Spell Minimum Base Lightning Damage Per Power Charge")]
        SpellMinimumBaseLightningDamagePerPowerCharge = 358,
        [Description("Spell Maximum Base Lightning Damage Per Power Charge")]
        SpellMaximumBaseLightningDamagePerPowerCharge = 359,
        [Description("Base Skill Effect Duration")]
        BaseSkillEffectDuration = 360,
        [Description("Skill Effect Duration")]
        SkillEffectDuration = 361,
        [Description("Buff Effect Duration")]
        BuffEffectDuration = 362,
        [Description("Buff Effect Duration +% Per Endurance Charge")]
        BuffEffectDurationPosPctPerEnduranceCharge = 363,
        [Description("Local Base Evasion Rating")]
        LocalBaseEvasionRating = 364,
        [Description("Local Base Physical Damage Reduction Rating")]
        LocalBasePhysicalDamageReductionRating = 365,
        [Description("Base Attack Speed +% Per Frenzy Charge")]
        BaseAttackSpeedPosPctPerFrenzyCharge = 366,
        [Description("Physical Damage +% Per Frenzy Charge")]
        PhysicalDamagePosPctPerFrenzyCharge = 367,
        [Description("Is Player")]
        IsPlayer = 368,
        [Description("Life Per Level")]
        LifePerLevel = 369,
        [Description("Mana Per Level")]
        ManaPerLevel = 370,
        [Description("Backstab Damage +%")]
        BackstabDamagePosPct = 371,
        [Description("Additional Player Bonus Maximum Life +% Final")]
        AdditionalPlayerBonusMaximumLifePosPctFinal = 372,
        [Description("Intermediary Maximum Life")]
        IntermediaryMaximumLife = 373,
        [Description("Local Flask Armour +% While Healing")]
        LocalFlaskArmourPosPctWhileHealing = 374,
        [Description("Local Flask Evasion +% While Healing")]
        LocalFlaskEvasionPosPctWhileHealing = 375,
        [Description("Local Flask Energy Shield +% While Healing")]
        LocalFlaskEnergyShieldPosPctWhileHealing = 376,
        [Description("Local Flask Movement Speed +% While Healing")]
        LocalFlaskMovementSpeedPosPctWhileHealing = 377,
        [Description("Local Flask Stun Recovery +% While Healing")]
        LocalFlaskStunRecoveryPosPctWhileHealing = 378,
        [Description("Local Flask Resistances +% While Healing")]
        LocalFlaskResistancesPosPctWhileHealing = 379,
        [Description("Old Do Not Use Local Flask Life Leech % While Healing")]
        OldDoNotUseLocalFlaskLifeLeechPctWhileHealing = 380,
        [Description("Old Do Not Use Local Flask Mana Leech % While Healing")]
        OldDoNotUseLocalFlaskManaLeechPctWhileHealing = 381,
        [Description("Local Flask Adds Knockback While Healing")]
        LocalFlaskAddsKnockbackWhileHealing = 382,
        [Description("Local Flask Removes % Of Mana Recovery From Life On Use")]
        LocalFlaskRemovesPctOfManaRecoveryFromLifeOnUse = 383,
        [Description("Local Flask Removes % Of Life Recovery From Mana On Use")]
        LocalFlaskRemovesPctOfLifeRecoveryFromManaOnUse = 384,
        [Description("Local Flask Removes % Of Life Recovery From Life On Use")]
        LocalFlaskRemovesPctOfLifeRecoveryFromLifeOnUse = 385,
        [Description("Local Flask Amount To Recover +% When On Low Life")]
        LocalFlaskAmountToRecoverPosPctWhenOnLowLife = 386,
        [Description("Local Flask Recover Instantly When On Low Life")]
        LocalFlaskRecoverInstantlyWhenOnLowLife = 387,
        [Description("Local Flask Recovery Amount % To Recover Instantly")]
        LocalFlaskRecoveryAmountPctToRecoverInstantly = 388,
        [Description("Local Flask Dispels Burning")]
        LocalFlaskDispelsBurning = 389,
        [Description("Local Flask Dispels Freeze And Chill")]
        LocalFlaskDispelsFreezeAndChill = 390,
        [Description("Local Max Charges +%")]
        LocalMaxChargesPosPct = 391,
        [Description("Local Charges Added +%")]
        LocalChargesAddedPosPct = 392,
        [Description("Local Flask Amount To Recover +%")]
        LocalFlaskAmountToRecoverPosPct = 393,
        [Description("Local Flask Recovers Instantly")]
        LocalFlaskRecoversInstantly = 394,
        [Description("Local Flask Minion Heal %")]
        LocalFlaskMinionHealPct = 395,
        [Description("Local Recharge On Crit")]
        LocalRechargeOnCrit = 396,
        [Description("Local Recharge On Take Crit")]
        LocalRechargeOnTakeCrit = 397,
        [Description("Local Critical Strike Multiplier +")]
        LocalCriticalStrikeMultiplierPos = 398,
        [Description("Local Flask Prevents Death While Healing")]
        LocalFlaskPreventsDeathWhileHealing = 399,
        [Description("Cannot Die")]
        CannotDie = 400,
        [Description("Flask Life To Recover +%")]
        FlaskLifeToRecoverPosPct = 401,
        [Description("Flask Mana To Recover +%")]
        FlaskManaToRecoverPosPct = 402,
        [Description("Flask Recovery Speed +%")]
        FlaskRecoverySpeedPosPct = 403,
        [Description("Knockback Distance +%")]
        KnockbackDistancePosPct = 404,
        [Description("Weapon Fire Damage +%")]
        WeaponFireDamagePosPct = 405,
        [Description("Weapon Cold Damage +%")]
        WeaponColdDamagePosPct = 406,
        [Description("Weapon Lightning Damage +%")]
        WeaponLightningDamagePosPct = 407,
        [Description("Weapon Chaos Damage +%")]
        WeaponChaosDamagePosPct = 408,
        [Description("Spell Elemental Damage +%")]
        SpellElementalDamagePosPct = 409,
        [Description("Resist All Elements +% While Holding Shield")]
        ResistAllElementsPosPctWhileHoldingShield = 410,
        [Description("Staff Block %")]
        StaffBlockPct = 411,
        [Description("Attack Minimum Added Lightning Damage With Wand")]
        AttackMinimumAddedLightningDamageWithWand = 412,
        [Description("Attack Maximum Added Lightning Damage With Wand")]
        AttackMaximumAddedLightningDamageWithWand = 413,
        [Description("Attack Minimum Added Fire Damage With Wand")]
        AttackMinimumAddedFireDamageWithWand = 414,
        [Description("Attack Maximum Added Fire Damage With Wand")]
        AttackMaximumAddedFireDamageWithWand = 415,
        [Description("Attack Minimum Added Cold Damage With Wand")]
        AttackMinimumAddedColdDamageWithWand = 416,
        [Description("Attack Maximum Added Cold Damage With Wand")]
        AttackMaximumAddedColdDamageWithWand = 417,
        [Description("Wand Elemental Damage +%")]
        WandElementalDamagePosPct = 418,
        [Description("Chance To Gain Endurance Charge On Block %")]
        ChanceToGainEnduranceChargeOnBlockPct = 419,
        [Description("Endurance Charge Duration +%")]
        EnduranceChargeDurationPosPct = 420,
        [Description("Share Endurance Charges With Party Within Distance")]
        ShareEnduranceChargesWithPartyWithinDistance = 421,
        [Description("Add Frenzy Charge On Enemy Block")]
        AddFrenzyChargeOnEnemyBlock = 422,
        [Description("Base Frenzy Charge Duration +%")]
        BaseFrenzyChargeDurationPosPct = 423,
        [Description("Share Frenzy Charges With Party Within Distance")]
        ShareFrenzyChargesWithPartyWithinDistance = 424,
        [Description("Add Power Charge On Minion Death")]
        AddPowerChargeOnMinionDeath = 425,
        [Description("Skill Area Of Effect +% Per Power Charge")]
        SkillAreaOfEffectPosPctPerPowerCharge = 426,
        [Description("Spell Damage +% Per Power Charge")]
        SpellDamagePosPctPerPowerCharge = 427,
        [Description("Wand Damage +% Per Power Charge")]
        WandDamagePosPctPerPowerCharge = 428,
        [Description("Power Charge Duration +%")]
        PowerChargeDurationPosPct = 429,
        [Description("Share Power Charges With Party Within Distance")]
        SharePowerChargesWithPartyWithinDistance = 430,
        [Description("Minions Explode On Low Life Maximum Life % To Deal")]
        MinionsExplodeOnLowLifeMaximumLifePctToDeal = 431,
        [Description("Totem Duration +%")]
        TotemDurationPosPct = 432,
        [Description("Buff Effect On Self +%")]
        BuffEffectOnSelfPosPct = 433,
        [Description("Add Power Charge When Interrupted While Casting")]
        AddPowerChargeWhenInterruptedWhileCasting = 434,
        [Description("Add Power Charge When Kill Shocked Enemy")]
        AddPowerChargeWhenKillShockedEnemy = 435,
        [Description("Base Skill Area Of Effect +%")]
        BaseSkillAreaOfEffectPosPct = 436,
        [Description("Casting Spell")]
        CastingSpell = 437,
        [Description("Avoid Interruption %")]
        AvoidInterruptionPct = 438,
        [Description("Shocks Enemies That Hit Actor")]
        ShocksEnemiesThatHitActor = 439,
        [Description("Add Power Charge When Interrupted")]
        AddPowerChargeWhenInterrupted = 440,
        [Description("Attack Minimum Base Fire Damage For Elemental Hit")]
        AttackMinimumBaseFireDamageForElementalHit = 441,
        [Description("Attack Maximum Base Fire Damage For Elemental Hit")]
        AttackMaximumBaseFireDamageForElementalHit = 442,
        [Description("Attack Minimum Base Cold Damage For Elemental Hit")]
        AttackMinimumBaseColdDamageForElementalHit = 443,
        [Description("Attack Maximum Base Cold Damage For Elemental Hit")]
        AttackMaximumBaseColdDamageForElementalHit = 444,
        [Description("Attack Minimum Base Lightning Damage For Elemental Hit")]
        AttackMinimumBaseLightningDamageForElementalHit = 445,
        [Description("Attack Maximum Base Lightning Damage For Elemental Hit")]
        AttackMaximumBaseLightningDamageForElementalHit = 446,
        [Description("Additional Physical Damage Reduction %")]
        AdditionalPhysicalDamageReductionPct = 447,
        [Description("Physical Damage Reduction % Per Endurance Charge")]
        PhysicalDamageReductionPctPerEnduranceCharge = 448,
        [Description("Physical Damage % To Add As Fire")]
        PhysicalDamagePctToAddAsFire = 449,
        [Description("Physical Damage % To Add As Cold")]
        PhysicalDamagePctToAddAsCold = 450,
        [Description("Physical Damage % To Add As Lightning")]
        PhysicalDamagePctToAddAsLightning = 451,
        [Description("Physical Damage % To Add As Chaos")]
        PhysicalDamagePctToAddAsChaos = 452,
        [Description("Life Regeneration Rate Per Minute %")]
        LifeRegenerationRatePerMinutePct = 453,
        [Description("Base Chaos Damage % Of Maximum Life Taken Per Minute")]
        BaseChaosDamagePctOfMaximumLifeTakenPerMinute = 454,
        [Description("Base Chaos Damage Taken Per Minute")]
        BaseChaosDamageTakenPerMinute = 455,
        [Description("Add Level X Blood Rage On Kill")]
        AddLevelXBloodRageOnKill = 456,
        [Description("Base Chance To Freeze %")]
        BaseChanceToFreezePct = 457,
        [Description("Display Mana Cost Reduction %")]
        DisplayManaCostReductionPct = 458,
        [Description("Display Minion Monster Level")]
        DisplayMinionMonsterLevel = 459,
        [Description("Display Minion Monster Type")]
        DisplayMinionMonsterType = 460,
        [Description("Monster Slain Flask Charges Granted +%")]
        MonsterSlainFlaskChargesGrantedPosPct = 461,
        [Description("Charges Gained +%")]
        ChargesGainedPosPct = 462,
        [Description("Global Knockback On Crit")]
        GlobalKnockbackOnCrit = 463,
        [Description("Dummy Stat Display Nothing")]
        DummyStatDisplayNothing = 464,
        [Description("Shield Charge Extra Distance")]
        ShieldChargeExtraDistance = 465,
        [Description("Shield Charge End Slide Distance")]
        ShieldChargeEndSlideDistance = 466,
        [Description("Main Hand Knockback On Crit")]
        MainHandKnockbackOnCrit = 467,
        [Description("Off Hand Knockback On Crit")]
        OffHandKnockbackOnCrit = 468,
        [Description("Knockback On Crit With Staff")]
        KnockbackOnCritWithStaff = 469,
        [Description("Knockback On Crit With Bow")]
        KnockbackOnCritWithBow = 470,
        [Description("Knockback On Crit With Wand")]
        KnockbackOnCritWithWand = 471,
        [Description("Shield Charge Stun Duration +% Maximum")]
        ShieldChargeStunDurationPosPctMaximum = 472,
        [Description("Shield Charge Knockback Distance +% Maximum")]
        ShieldChargeKnockbackDistancePosPctMaximum = 473,
        [Description("Shield Charge Damage +% Maximum")]
        ShieldChargeDamagePosPctMaximum = 474,
        [Description("Spell Minimum Base Fire Damage Per Endurance Charge")]
        SpellMinimumBaseFireDamagePerEnduranceCharge = 475,
        [Description("Spell Maximum Base Fire Damage Per Endurance Charge")]
        SpellMaximumBaseFireDamagePerEnduranceCharge = 476,
        [Description("Spell Minimum Base Cold Damage Per Frenzy Charge")]
        SpellMinimumBaseColdDamagePerFrenzyCharge = 477,
        [Description("Spell Maximum Base Cold Damage Per Frenzy Charge")]
        SpellMaximumBaseColdDamagePerFrenzyCharge = 478,
        [Description("Base Damage Taken +%")]
        BaseDamageTakenPosPct = 479,
        [Description("Is Shocked")]
        IsShocked = 480,
        [Description("Base Global Chance To Knockback %")]
        BaseGlobalChanceToKnockbackPct = 481,
        [Description("Main Hand Chance To Knockback %")]
        MainHandChanceToKnockbackPct = 482,
        [Description("Off Hand Chance To Knockback %")]
        OffHandChanceToKnockbackPct = 483,
        [Description("Base Physical Damage % To Convert To Fire")]
        BasePhysicalDamagePctToConvertToFire = 484,
        [Description("Base Physical Damage % To Convert To Cold")]
        BasePhysicalDamagePctToConvertToCold = 485,
        [Description("Base Physical Damage % To Convert To Lightning")]
        BasePhysicalDamagePctToConvertToLightning = 486,
        [Description("Base Physical Damage % To Convert To Chaos")]
        BasePhysicalDamagePctToConvertToChaos = 487,
        [Description("Elemental Damage +%")]
        ElementalDamagePosPct = 488,
        [Description("Mana Regeneration Rate +% Per Power Charge")]
        ManaRegenerationRatePosPctPerPowerCharge = 489,
        [Description("Minion Damage +%")]
        MinionDamagePosPct = 490,
        [Description("Shield Maximum Energy Shield +%")]
        ShieldMaximumEnergyShieldPosPct = 491,
        [Description("Melee Physical Damage +%")]
        MeleePhysicalDamagePosPct = 492,
        [Description("Maximum Block %")]
        MaximumBlockPct = 493,
        [Description("Shield Physical Damage Reduction Rating +%")]
        ShieldPhysicalDamageReductionRatingPosPct = 494,
        [Description("Shield Evasion Rating +%")]
        ShieldEvasionRatingPosPct = 495,
        [Description("Base Shield Evasion Rating")]
        BaseShieldEvasionRating = 496,
        [Description("Base Shield Physical Damage Reduction Rating")]
        BaseShieldPhysicalDamageReductionRating = 497,
        [Description("Base Shield Maximum Energy Shield")]
        BaseShieldMaximumEnergyShield = 498,
        [Description("Ranged Weapon Physical Damage +%")]
        RangedWeaponPhysicalDamagePosPct = 499,
        [Description("Projectile Damage +%")]
        ProjectileDamagePosPct = 500,
        [Description("Base Is Projectile")]
        BaseIsProjectile = 501,
        [Description("Base Cast Speed +% Per Frenzy Charge")]
        BaseCastSpeedPosPctPerFrenzyCharge = 502,
        [Description("Sword Accuracy Rating")]
        SwordAccuracyRating = 503,
        [Description("Bow Accuracy Rating")]
        BowAccuracyRating = 504,
        [Description("Dagger Accuracy Rating")]
        DaggerAccuracyRating = 505,
        [Description("Axe Accuracy Rating")]
        AxeAccuracyRating = 506,
        [Description("Claw Accuracy Rating")]
        ClawAccuracyRating = 507,
        [Description("Staff Accuracy Rating")]
        StaffAccuracyRating = 508,
        [Description("Mace Accuracy Rating")]
        MaceAccuracyRating = 509,
        [Description("Wand Accuracy Rating")]
        WandAccuracyRating = 510,
        [Description("Wall Expand Delay Ms")]
        WallExpandDelayMs = 511,
        [Description("Wall Maximum Length")]
        WallMaximumLength = 512,
        [Description("Main Hand Poison On Critical Strike")]
        MainHandPoisonOnCriticalStrike = 513,
        [Description("Off Hand Poison On Critical Strike")]
        OffHandPoisonOnCriticalStrike = 514,
        [Description("Current Viper Strike Orbs")]
        CurrentViperStrikeOrbs = 515,
        [Description("Max Viper Strike Orbs")]
        MaxViperStrikeOrbs = 516,
        [Description("Monster Chance To Not Flee %")]
        MonsterChanceToNotFleePct = 517,
        [Description("Local Socketed Fire Gem Level +")]
        LocalSocketedFireGemLevelPos = 518,
        [Description("Local Socketed Cold Gem Level +")]
        LocalSocketedColdGemLevelPos = 519,
        [Description("Local Socketed Lightning Gem Level +")]
        LocalSocketedLightningGemLevelPos = 520,
        [Description("Local Socketed Chaos Gem Level +")]
        LocalSocketedChaosGemLevelPos = 521,
        [Description("Local Socketed Projectile Gem Level +")]
        LocalSocketedProjectileGemLevelPos = 522,
        [Description("Local Socketed Spell Gem Level +")]
        LocalSocketedSpellGemLevelPos = 523,
        [Description("Local Socketed Melee Gem Level +")]
        LocalSocketedMeleeGemLevelPos = 524,
        [Description("Local Socketed Bow Gem Level +")]
        LocalSocketedBowGemLevelPos = 525,
        [Description("Local Socketed Minion Gem Level +")]
        LocalSocketedMinionGemLevelPos = 526,
        [Description("Local Socketed Gem Level +")]
        LocalSocketedGemLevelPos = 527,
        [Description("Base Killed Monster Dropped Item Rarity +%")]
        BaseKilledMonsterDroppedItemRarityPosPct = 528,
        [Description("Base Killed Monster Dropped Item Quantity +%")]
        BaseKilledMonsterDroppedItemQuantityPosPct = 529,
        [Description("Current Fuse Arrow Orbs")]
        CurrentFuseArrowOrbs = 530,
        [Description("Max Fuse Arrow Orbs")]
        MaxFuseArrowOrbs = 531,
        [Description("Minimum Fire Damage Per Fuse Arrow Orb")]
        MinimumFireDamagePerFuseArrowOrb = 532,
        [Description("Maximum Fire Damage Per Fuse Arrow Orb")]
        MaximumFireDamagePerFuseArrowOrb = 533,
        [Description("Buff Time Passed -%")]
        BuffTimePassedNegPct = 534,
        [Description("Chance To Be Shocked %")]
        ChanceToBeShockedPct = 535,
        [Description("Chance To Be Chilled %")]
        ChanceToBeChilledPct = 536,
        [Description("Chance To Be Frozen %")]
        ChanceToBeFrozenPct = 537,
        [Description("Chance To Be Ignited %")]
        ChanceToBeIgnitedPct = 538,
        [Description("Life Leech On Any Damage When Hit Permyriad")]
        LifeLeechOnAnyDamageWhenHitPermyriad = 539,
        [Description("Mana Leech On Any Damage When Hit Permyriad")]
        ManaLeechOnAnyDamageWhenHitPermyriad = 540,
        [Description("Chance To Grant Power Charge On Death %")]
        ChanceToGrantPowerChargeOnDeathPct = 541,
        [Description("Physical Damage Dealt Applied To Self %")]
        PhysicalDamageDealtAppliedToSelfPct = 542,
        [Description("Additional Chance To Take Critical Strike %")]
        AdditionalChanceToTakeCriticalStrikePct = 543,
        [Description("Chance To Be Knocked Back %")]
        ChanceToBeKnockedBackPct = 544,
        [Description("Degen Effect +%")]
        DegenEffectPosPct = 545,
        [Description("Chance To Be Stunned %")]
        ChanceToBeStunnedPct = 546,
        [Description("Chance To Grant Endurance Charge On Death %")]
        ChanceToGrantEnduranceChargeOnDeathPct = 547,
        [Description("Physical Damage Taken +%")]
        PhysicalDamageTakenPosPct = 548,
        [Description("Fuse Arrow Explosion Radius + Per Fuse Arrow Orb")]
        FuseArrowExplosionRadiusPosPerFuseArrowOrb = 549,
        [Description("Base Number Of Skeletons Allowed")]
        BaseNumberOfSkeletonsAllowed = 550,
        [Description("Number Of Melee Skeletons To Summon")]
        NumberOfMeleeSkeletonsToSummon = 551,
        [Description("Main Hand Critical Strike Chance")]
        MainHandCriticalStrikeChance = 552,
        [Description("Off Hand Critical Strike Chance")]
        OffHandCriticalStrikeChance = 553,
        [Description("Spell Critical Strike Chance")]
        SpellCriticalStrikeChance = 554,
        [Description("Local Critical Strike Chance")]
        LocalCriticalStrikeChance = 555,
        [Description("Base Spell Critical Strike Chance")]
        BaseSpellCriticalStrikeChance = 556,
        [Description("Critical Strike Chance +%")]
        CriticalStrikeChancePosPct = 557,
        [Description("Critical Strike Chance +% Per Power Charge")]
        CriticalStrikeChancePosPctPerPowerCharge = 558,
        [Description("Spell Critical Strike Chance +%")]
        SpellCriticalStrikeChancePosPct = 559,
        [Description("Local Critical Strike Chance +%")]
        LocalCriticalStrikeChancePosPct = 560,
        [Description("Dagger Critical Strike Chance +%")]
        DaggerCriticalStrikeChancePosPct = 561,
        [Description("Bow Critical Strike Chance +%")]
        BowCriticalStrikeChancePosPct = 562,
        [Description("Claw Critical Strike Chance +%")]
        ClawCriticalStrikeChancePosPct = 563,
        [Description("Base Life Recovery Per Minute")]
        BaseLifeRecoveryPerMinute = 564,
        [Description("Base Mana Recovery Per Minute")]
        BaseManaRecoveryPerMinute = 565,
        [Description("Maximum Life % To Add To Maximum Energy Shield")]
        MaximumLifePctToAddToMaximumEnergyShield = 566,
        [Description("Physical Damage Taken % To Deal To Attacker")]
        PhysicalDamageTakenPctToDealToAttacker = 567,
        [Description("Elemental Damage Taken % To Deal To Attacker")]
        ElementalDamageTakenPctToDealToAttacker = 568,
        [Description("Base Skeleton Maximum Life +%")]
        BaseSkeletonMaximumLifePosPct = 569,
        [Description("Skeleton Maximum Life +%")]
        SkeletonMaximumLifePosPct = 570,
        [Description("Additional Base Critical Strike Chance")]
        AdditionalBaseCriticalStrikeChance = 571,
        [Description("Accuracy Rating Per Level")]
        AccuracyRatingPerLevel = 572,
        [Description("Evasion Rating Per Level")]
        EvasionRatingPerLevel = 573,
        [Description("Local Accuracy Rating")]
        LocalAccuracyRating = 574,
        [Description("Strength")]
        Strength = 575,
        [Description("Base Strength")]
        BaseStrength = 576,
        [Description("Additional Strength")]
        AdditionalStrength = 577,
        [Description("Intelligence")]
        Intelligence = 578,
        [Description("Base Intelligence")]
        BaseIntelligence = 579,
        [Description("Additional Intelligence")]
        AdditionalIntelligence = 580,
        [Description("Dexterity")]
        Dexterity = 581,
        [Description("Base Dexterity")]
        BaseDexterity = 582,
        [Description("Additional Dexterity")]
        AdditionalDexterity = 583,
        [Description("On Low Life")]
        OnLowLife = 584,
        [Description("On Full Life")]
        OnFullLife = 585,
        [Description("Damage +% When On Low Life")]
        DamagePosPctWhenOnLowLife = 586,
        [Description("Damage +% When On Full Life")]
        DamagePosPctWhenOnFullLife = 587,
        [Description("Cast Speed +% When On Low Life")]
        CastSpeedPosPctWhenOnLowLife = 588,
        [Description("Cast Speed +% When On Full Life")]
        CastSpeedPosPctWhenOnFullLife = 589,
        [Description("Attack Speed +% When On Low Life")]
        AttackSpeedPosPctWhenOnLowLife = 590,
        [Description("Attack Speed +% When On Full Life")]
        AttackSpeedPosPctWhenOnFullLife = 591,
        [Description("Kill Enemy On Hit If Under 10% Life")]
        KillEnemyOnHitIfUnder10PctLife = 592,
        [Description("Reduce Enemy Cold Resistance %")]
        ReduceEnemyColdResistancePct = 593,
        [Description("Reduce Enemy Fire Resistance %")]
        ReduceEnemyFireResistancePct = 594,
        [Description("Reduce Enemy Lightning Resistance %")]
        ReduceEnemyLightningResistancePct = 595,
        [Description("Base Reduce Enemy Fire Resistance %")]
        BaseReduceEnemyFireResistancePct = 596,
        [Description("Base Reduce Enemy Cold Resistance %")]
        BaseReduceEnemyColdResistancePct = 597,
        [Description("Base Reduce Enemy Lightning Resistance %")]
        BaseReduceEnemyLightningResistancePct = 598,
        [Description("Reduce Enemy Elemental Resistance %")]
        ReduceEnemyElementalResistancePct = 599,
        [Description("Reduce Enemy Chaos Resistance %")]
        ReduceEnemyChaosResistancePct = 600,
        [Description("Life Leech On Physical Damage When Hit By Attack %")]
        LifeLeechOnPhysicalDamageWhenHitByAttackPct = 601,
        [Description("Mana Leech On Physical Damage When Hit By Attack %")]
        ManaLeechOnPhysicalDamageWhenHitByAttackPct = 602,
        [Description("Add Endurance Charge On Melee Critical Strike")]
        AddEnduranceChargeOnMeleeCriticalStrike = 603,
        [Description("Add Frenzy Charge On Melee Critical Strike")]
        AddFrenzyChargeOnMeleeCriticalStrike = 604,
        [Description("Add Power Charge On Melee Critical Strike")]
        AddPowerChargeOnMeleeCriticalStrike = 605,
        [Description("Life Leech Speed +%")]
        LifeLeechSpeedPosPct = 606,
        [Description("Mana Leech Speed +%")]
        ManaLeechSpeedPosPct = 607,
        [Description("Base Number Of Converted Allowed")]
        BaseNumberOfConvertedAllowed = 608,
        [Description("Additional All Attributes")]
        AdditionalAllAttributes = 609,
        [Description("Base Critical Strike Multiplier")]
        BaseCriticalStrikeMultiplier = 610,
        [Description("Main Hand Critical Strike Multiplier")]
        MainHandCriticalStrikeMultiplier = 611,
        [Description("Off Hand Critical Strike Multiplier")]
        OffHandCriticalStrikeMultiplier = 612,
        [Description("Spell Critical Strike Multiplier")]
        SpellCriticalStrikeMultiplier = 613,
        [Description("Base Cold Damage % To Convert To Fire")]
        BaseColdDamagePctToConvertToFire = 614,
        [Description("Base Chance To Ignite %")]
        BaseChanceToIgnitePct = 615,
        [Description("Fire Storm Fireball Delay Ms")]
        FireStormFireballDelayMs = 616,
        [Description("One Handed Melee Critical Strike Chance +%")]
        OneHandedMeleeCriticalStrikeChancePosPct = 617,
        [Description("Axe Critical Strike Multiplier +")]
        AxeCriticalStrikeMultiplierPos = 618,
        [Description("Sword Critical Strike Multiplier +")]
        SwordCriticalStrikeMultiplierPos = 619,
        [Description("Bow Critical Strike Multiplier +")]
        BowCriticalStrikeMultiplierPos = 620,
        [Description("Minion Movement Speed +%")]
        MinionMovementSpeedPosPct = 621,
        [Description("Is Area Damage")]
        IsAreaDamage = 622,
        [Description("Area Damage +%")]
        AreaDamagePosPct = 623,
        [Description("Avoid All Elemental Status %")]
        AvoidAllElementalStatusPct = 624,
        [Description("Self Elemental Status Duration -%")]
        SelfElementalStatusDurationNegPct = 625,
        [Description("One Handed Melee Critical Strike Multiplier +")]
        OneHandedMeleeCriticalStrikeMultiplierPos = 626,
        [Description("Two Handed Melee Critical Strike Chance +%")]
        TwoHandedMeleeCriticalStrikeChancePosPct = 627,
        [Description("Two Handed Melee Critical Strike Multiplier +")]
        TwoHandedMeleeCriticalStrikeMultiplierPos = 628,
        [Description("Shield Charge Continue Past Target")]
        ShieldChargeContinuePastTarget = 629,
        [Description("Avoid Chill %")]
        AvoidChillPct = 630,
        [Description("Avoid Freeze %")]
        AvoidFreezePct = 631,
        [Description("Avoid Ignite %")]
        AvoidIgnitePct = 632,
        [Description("Avoid Shock %")]
        AvoidShockPct = 633,
        [Description("Self Chill Duration -%")]
        SelfChillDurationNegPct = 634,
        [Description("Self Shock Duration -%")]
        SelfShockDurationNegPct = 635,
        [Description("Self Freeze Duration -%")]
        SelfFreezeDurationNegPct = 636,
        [Description("Self Ignite Duration -%")]
        SelfIgniteDurationNegPct = 637,
        [Description("Active Skill Damage +% Final")]
        ActiveSkillDamagePosPctFinal = 638,
        [Description("Phase Run Melee Physical Damage +% Final")]
        PhaseRunMeleePhysicalDamagePosPctFinal = 639,
        [Description("Active Skill Physical Damage +% Final")]
        ActiveSkillPhysicalDamagePosPctFinal = 640,
        [Description("Active Skill Elemental Damage +% Final")]
        ActiveSkillElementalDamagePosPctFinal = 641,
        [Description("Active Skill Fire Damage +% Final")]
        ActiveSkillFireDamagePosPctFinal = 642,
        [Description("Active Skill Cold Damage +% Final")]
        ActiveSkillColdDamagePosPctFinal = 643,
        [Description("Active Skill Lightning Damage +% Final")]
        ActiveSkillLightningDamagePosPctFinal = 644,
        [Description("Active Skill Chaos Damage +% Final")]
        ActiveSkillChaosDamagePosPctFinal = 645,
        [Description("Support Melee Physical Damage +% Final")]
        SupportMeleePhysicalDamagePosPctFinal = 646,
        [Description("Support Weapon Elemental Damage +% Final")]
        SupportWeaponElementalDamagePosPctFinal = 647,
        [Description("Support Area Concentrate Area Damage +% Final")]
        SupportAreaConcentrateAreaDamagePosPctFinal = 648,
        [Description("Active Skill Attack Damage +% Final")]
        ActiveSkillAttackDamagePosPctFinal = 649,
        [Description("Active Skill Spell Damage +% Final")]
        ActiveSkillSpellDamagePosPctFinal = 650,
        [Description("Support Multiple Projectile Damage +% Final")]
        SupportMultipleProjectileDamagePosPctFinal = 651,
        [Description("Enfeeble Damage +% Final")]
        EnfeebleDamagePosPctFinal = 652,
        [Description("Main Hand Weapon Minimum Physical Damage")]
        MainHandWeaponMinimumPhysicalDamage = 653,
        [Description("Main Hand Weapon Maximum Physical Damage")]
        MainHandWeaponMaximumPhysicalDamage = 654,
        [Description("Off Hand Weapon Minimum Physical Damage")]
        OffHandWeaponMinimumPhysicalDamage = 655,
        [Description("Off Hand Weapon Maximum Physical Damage")]
        OffHandWeaponMaximumPhysicalDamage = 656,
        [Description("Active Skill Minion Life +% Final")]
        ActiveSkillMinionLifePosPctFinal = 657,
        [Description("Active Skill Minion Damage +% Final")]
        ActiveSkillMinionDamagePosPctFinal = 658,
        [Description("Max Life +% Final For Minion")]
        MaxLifePosPctFinalForMinion = 659,
        [Description("Damage +% Final For Minion")]
        DamagePosPctFinalForMinion = 660,
        [Description("Strength Per Level")]
        StrengthPerLevel = 661,
        [Description("Dexterity Per Level")]
        DexterityPerLevel = 662,
        [Description("Intelligence Per Level")]
        IntelligencePerLevel = 663,
        [Description("Critical Strike Chance While Dual Wielding +%")]
        CriticalStrikeChanceWhileDualWieldingPosPct = 664,
        [Description("Critical Strike Multiplier While Dual Wielding +")]
        CriticalStrikeMultiplierWhileDualWieldingPos = 665,
        [Description("Mace Critical Strike Multiplier +")]
        MaceCriticalStrikeMultiplierPos = 666,
        [Description("Base Chance To Shock %")]
        BaseChanceToShockPct = 667,
        [Description("Spell Maximum Action Distance +%")]
        SpellMaximumActionDistancePosPct = 668,
        [Description("Local Accuracy Rating +%")]
        LocalAccuracyRatingPosPct = 669,
        [Description("Display Skill Increased Item Quantity +%")]
        DisplaySkillIncreasedItemQuantityPosPct = 670,
        [Description("Display Skill Increased Item Rarity +%")]
        DisplaySkillIncreasedItemRarityPosPct = 671,
        [Description("Wand Physical Damage % To Add As Fire")]
        WandPhysicalDamagePctToAddAsFire = 672,
        [Description("Wand Physical Damage % To Add As Cold")]
        WandPhysicalDamagePctToAddAsCold = 673,
        [Description("Wand Physical Damage % To Add As Lightning")]
        WandPhysicalDamagePctToAddAsLightning = 674,
        [Description("Main Hand Minimum Total Damage")]
        MainHandMinimumTotalDamage = 675,
        [Description("Main Hand Maximum Total Damage")]
        MainHandMaximumTotalDamage = 676,
        [Description("Off Hand Minimum Total Damage")]
        OffHandMinimumTotalDamage = 677,
        [Description("Off Hand Maximum Total Damage")]
        OffHandMaximumTotalDamage = 678,
        [Description("Spell Minimum Total Damage")]
        SpellMinimumTotalDamage = 679,
        [Description("Spell Maximum Total Damage")]
        SpellMaximumTotalDamage = 680,
        [Description("Main Hand Chance To Hit %")]
        MainHandChanceToHitPct = 681,
        [Description("Off Hand Chance To Hit %")]
        OffHandChanceToHitPct = 682,
        [Description("Hundred Times Attacks Per Second")]
        HundredTimesAttacksPerSecond = 683,
        [Description("Hundred Times Damage Per Second")]
        HundredTimesDamagePerSecond = 684,
        [Description("Chance To Evade %")]
        ChanceToEvadePct = 685,
        [Description("Base Spell Cast Time Ms")]
        BaseSpellCastTimeMs = 686,
        [Description("Hundred Times Casts Per Second")]
        HundredTimesCastsPerSecond = 687,
        [Description("Global Hit Causes Monster Flee %")]
        GlobalHitCausesMonsterFleePct = 688,
        [Description("Local Hit Causes Monster Flee %")]
        LocalHitCausesMonsterFleePct = 689,
        [Description("Main Hand Hit Causes Monster Flee %")]
        MainHandHitCausesMonsterFleePct = 690,
        [Description("Off Hand Hit Causes Monster Flee %")]
        OffHandHitCausesMonsterFleePct = 691,
        [Description("Global Always Hit")]
        GlobalAlwaysHit = 692,
        [Description("Main Hand Always Hit")]
        MainHandAlwaysHit = 693,
        [Description("Off Hand Always Hit")]
        OffHandAlwaysHit = 694,
        [Description("Local Always Hit")]
        LocalAlwaysHit = 695,
        [Description("Explode On Low Life % Maximum Life To Deal")]
        ExplodeOnLowLifePctMaximumLifeToDeal = 696,
        [Description("Curses Never Expire")]
        CursesNeverExpire = 697,
        [Description("Chance To Dodge %")]
        ChanceToDodgePct = 698,
        [Description("No Physical Damage Reduction Rating")]
        NoPhysicalDamageReductionRating = 699,
        [Description("No Energy Shield")]
        NoEnergyShield = 700,
        [Description("Keystone Iron Reflexes")]
        KeystoneIronReflexes = 701,
        [Description("Global Cannot Crit")]
        GlobalCannotCrit = 702,
        [Description("Convert All Physical Damage To Fire")]
        ConvertAllPhysicalDamageToFire = 703,
        [Description("Base Cannot Evade")]
        BaseCannotEvade = 704,
        [Description("Chaos Immunity")]
        ChaosImmunity = 705,
        [Description("Keystone Chaos Inoculation")]
        KeystoneChaosInoculation = 706,
        [Description("Mana % To Add As Energy Shield")]
        ManaPctToAddAsEnergyShield = 707,
        [Description("No Mana")]
        NoMana = 708,
        [Description("Base Use Life In Place Of Mana")]
        BaseUseLifeInPlaceOfMana = 709,
        [Description("Base Cannot Be Stunned")]
        BaseCannotBeStunned = 710,
        [Description("Ignore Armour Movement Penalties")]
        IgnoreArmourMovementPenalties = 711,
        [Description("Base Buff Duration Ms + Per Endurance Charge")]
        BaseBuffDurationMsPosPerEnduranceCharge = 712,
        [Description("Secondary Minimum Physical Damage")]
        SecondaryMinimumPhysicalDamage = 713,
        [Description("Secondary Maximum Physical Damage")]
        SecondaryMaximumPhysicalDamage = 714,
        [Description("Secondary Minimum Cold Damage")]
        SecondaryMinimumColdDamage = 715,
        [Description("Secondary Maximum Cold Damage")]
        SecondaryMaximumColdDamage = 716,
        [Description("Secondary Minimum Fire Damage")]
        SecondaryMinimumFireDamage = 717,
        [Description("Secondary Maximum Fire Damage")]
        SecondaryMaximumFireDamage = 718,
        [Description("Secondary Minimum Lightning Damage")]
        SecondaryMinimumLightningDamage = 719,
        [Description("Secondary Maximum Lightning Damage")]
        SecondaryMaximumLightningDamage = 720,
        [Description("Secondary Minimum Chaos Damage")]
        SecondaryMinimumChaosDamage = 721,
        [Description("Secondary Maximum Chaos Damage")]
        SecondaryMaximumChaosDamage = 722,
        [Description("Secondary Critical Strike Multiplier")]
        SecondaryCriticalStrikeMultiplier = 723,
        [Description("Secondary Critical Strike Chance")]
        SecondaryCriticalStrikeChance = 724,
        [Description("Physical Immunity")]
        PhysicalImmunity = 725,
        [Description("Base Actor Scale +%")]
        BaseActorScalePosPct = 726,
        [Description("Display Estimated Physical Damage Reduciton %")]
        DisplayEstimatedPhysicalDamageReducitonPct = 727,
        [Description("Curse Count")]
        CurseCount = 728,
        [Description("Number Of Additional Curses Allowed")]
        NumberOfAdditionalCursesAllowed = 729,
        [Description("Melee Knockback")]
        MeleeKnockback = 730,
        [Description("Total Number Of Projectiles To Fire")]
        TotalNumberOfProjectilesToFire = 731,
        [Description("Total Number Of Arrows To Fire")]
        TotalNumberOfArrowsToFire = 732,
        [Description("Number Of Zombies Allowed")]
        NumberOfZombiesAllowed = 733,
        [Description("Number Of Spectres Allowed")]
        NumberOfSpectresAllowed = 734,
        [Description("Number Of Converted Allowed")]
        NumberOfConvertedAllowed = 735,
        [Description("Number Of Skeletons Allowed")]
        NumberOfSkeletonsAllowed = 736,
        [Description("From Armour Movement Speed +%")]
        FromArmourMovementSpeedPosPct = 737,
        [Description("Active Skill Minion Energy Shield +% Final")]
        ActiveSkillMinionEnergyShieldPosPctFinal = 738,
        [Description("Energy Shield +% Final For Minion")]
        EnergyShieldPosPctFinalForMinion = 739,
        [Description("Projectile Damage Taken +%")]
        ProjectileDamageTakenPosPct = 740,
        [Description("Fire Shield Damage Threshold")]
        FireShieldDamageThreshold = 741,
        [Description("Support Multiple Projectiles Critical Strike Chance +% Final")]
        SupportMultipleProjectilesCriticalStrikeChancePosPctFinal = 742,
        [Description("Display Monster Wealth Mod")]
        DisplayMonsterWealthMod = 743,
        [Description("Local Armour And Energy Shield +%")]
        LocalArmourAndEnergyShieldPosPct = 744,
        [Description("Local Armour And Evasion +%")]
        LocalArmourAndEvasionPosPct = 745,
        [Description("Local Evasion And Energy Shield +%")]
        LocalEvasionAndEnergyShieldPosPct = 746,
        [Description("Local Armour And Evasion And Energy Shield +%")]
        LocalArmourAndEvasionAndEnergyShieldPosPct = 747,
        [Description("Flask Charges Used +%")]
        FlaskChargesUsedPosPct = 748,
        [Description("Flask Duration +%")]
        FlaskDurationPosPct = 749,
        [Description("Flask Life Recovery Rate +%")]
        FlaskLifeRecoveryRatePosPct = 750,
        [Description("Flask Mana Recovery Rate +%")]
        FlaskManaRecoveryRatePosPct = 751,
        [Description("Minions Get Shield Stats Instead Of You")]
        MinionsGetShieldStatsInsteadOfYou = 752,
        [Description("Cannot Resist Cold Damage")]
        CannotResistColdDamage = 753,
        [Description("Add Power Charge On Kill")]
        AddPowerChargeOnKill = 754,
        [Description("Immune To Curses")]
        ImmuneToCurses = 755,
        [Description("Monster Grants Frenzy Charges To Allies Within Distance On Death")]
        MonsterGrantsFrenzyChargesToAlliesWithinDistanceOnDeath = 756,
        [Description("Dual Wield Or Shield Block %")]
        DualWieldOrShieldBlockPct = 757,
        [Description("Gain Frenzy Charge For Each Quarter Life Removed")]
        GainFrenzyChargeForEachQuarterLifeRemoved = 758,
        [Description("Monster Life Thresholds Passed")]
        MonsterLifeThresholdsPassed = 759,
        [Description("Chaos Inoculation Keystone Energy Shield +% Final")]
        ChaosInoculationKeystoneEnergyShieldPosPctFinal = 760,
        [Description("Pain Attunement Keystone Spell Damage +% Final")]
        PainAttunementKeystoneSpellDamagePosPctFinal = 761,
        [Description("Keystone Elemental Equilibrium")]
        KeystoneElementalEquilibrium = 762,
        [Description("Evasion Rating + When On Low Life")]
        EvasionRatingPosWhenOnLowLife = 763,
        [Description("Life Regeneration Rate Per Minute % When On Low Life")]
        LifeRegenerationRatePerMinutePctWhenOnLowLife = 764,
        [Description("Local Socketed Strength Gem Level +")]
        LocalSocketedStrengthGemLevelPos = 765,
        [Description("Local Socketed Dexterity Gem Level +")]
        LocalSocketedDexterityGemLevelPos = 766,
        [Description("Local Socketed Intelligence Gem Level +")]
        LocalSocketedIntelligenceGemLevelPos = 767,
        [Description("Maximum Physical Damage To Return To Melee Attacker")]
        MaximumPhysicalDamageToReturnToMeleeAttacker = 768,
        [Description("Maximum Fire Damage To Return To Melee Attacker")]
        MaximumFireDamageToReturnToMeleeAttacker = 769,
        [Description("Maximum Cold Damage To Return To Melee Attacker")]
        MaximumColdDamageToReturnToMeleeAttacker = 770,
        [Description("Maximum Lightning Damage To Return To Melee Attacker")]
        MaximumLightningDamageToReturnToMeleeAttacker = 771,
        [Description("Maximum Chaos Damage To Return To Melee Attacker")]
        MaximumChaosDamageToReturnToMeleeAttacker = 772,
        [Description("Minimum Physical Damage To Return To Melee Attacker")]
        MinimumPhysicalDamageToReturnToMeleeAttacker = 773,
        [Description("Minimum Fire Damage To Return To Melee Attacker")]
        MinimumFireDamageToReturnToMeleeAttacker = 774,
        [Description("Minimum Cold Damage To Return To Melee Attacker")]
        MinimumColdDamageToReturnToMeleeAttacker = 775,
        [Description("Minimum Lightning Damage To Return To Melee Attacker")]
        MinimumLightningDamageToReturnToMeleeAttacker = 776,
        [Description("Minimum Chaos Damage To Return To Melee Attacker")]
        MinimumChaosDamageToReturnToMeleeAttacker = 777,
        [Description("Physical Damage Taken When Hit By Attack")]
        PhysicalDamageTakenWhenHitByAttack = 778,
        [Description("Fire Damage Taken When Hit By Attack")]
        FireDamageTakenWhenHitByAttack = 779,
        [Description("Cold Damage Taken When Hit By Attack")]
        ColdDamageTakenWhenHitByAttack = 780,
        [Description("Lightning Damage Taken When Hit By Attack")]
        LightningDamageTakenWhenHitByAttack = 781,
        [Description("Chaos Damage Taken When Hit By Attack")]
        ChaosDamageTakenWhenHitByAttack = 782,
        [Description("Mana Cost +% When On Low Life")]
        ManaCostPosPctWhenOnLowLife = 783,
        [Description("Elemental Resistance % When On Low Life")]
        ElementalResistancePctWhenOnLowLife = 784,
        [Description("Local Has No Sockets")]
        LocalHasNoSockets = 785,
        [Description("Local All Sockets Linked")]
        LocalAllSocketsLinked = 786,
        [Description("Movement Velocity +% When On Low Life")]
        MovementVelocityPosPctWhenOnLowLife = 787,
        [Description("Mana Cost +%")]
        ManaCostPosPct = 788,
        [Description("Keystone Acrobatics")]
        KeystoneAcrobatics = 789,
        [Description("Keystone Pain Attunement")]
        KeystonePainAttunement = 790,
        [Description("Item Found Quantity +% When On Low Life")]
        ItemFoundQuantityPosPctWhenOnLowLife = 791,
        [Description("Item Found Rarity +% When On Low Life")]
        ItemFoundRarityPosPctWhenOnLowLife = 792,
        [Description("Item Found Quantity +%")]
        ItemFoundQuantityPosPct = 793,
        [Description("Item Found Rarity +%")]
        ItemFoundRarityPosPct = 794,
        [Description("Active Skill Projectile Damage +% Final")]
        ActiveSkillProjectileDamagePosPctFinal = 795,
        [Description("Bonus Damage +% From Strength")]
        BonusDamagePosPctFromStrength = 796,
        [Description("Keystone Strong Bowman")]
        KeystoneStrongBowman = 797,
        [Description("Monster Projectile Variation")]
        MonsterProjectileVariation = 798,
        [Description("Keystone Point Blank")]
        KeystonePointBlank = 799,
        [Description("Damage +% Final From Distance")]
        DamagePosPctFinalFromDistance = 800,
        [Description("Keystone Conduit")]
        KeystoneConduit = 801,
        [Description("Movement Velocity +% When On Full Life")]
        MovementVelocityPosPctWhenOnFullLife = 802,
        [Description("Show Number Of Projectiles")]
        ShowNumberOfProjectiles = 803,
        [Description("Lightning Arrow Maximum Number Of Extra Targets")]
        LightningArrowMaximumNumberOfExtraTargets = 804,
        [Description("Main Hand Local Physical Damage +%")]
        MainHandLocalPhysicalDamagePosPct = 805,
        [Description("Main Hand Local Minimum Added Physical Damage")]
        MainHandLocalMinimumAddedPhysicalDamage = 806,
        [Description("Main Hand Local Maximum Added Physical Damage")]
        MainHandLocalMaximumAddedPhysicalDamage = 807,
        [Description("Main Hand Local Minimum Added Fire Damage")]
        MainHandLocalMinimumAddedFireDamage = 808,
        [Description("Main Hand Local Maximum Added Fire Damage")]
        MainHandLocalMaximumAddedFireDamage = 809,
        [Description("Main Hand Local Minimum Added Cold Damage")]
        MainHandLocalMinimumAddedColdDamage = 810,
        [Description("Main Hand Local Maximum Added Cold Damage")]
        MainHandLocalMaximumAddedColdDamage = 811,
        [Description("Main Hand Local Minimum Added Lightning Damage")]
        MainHandLocalMinimumAddedLightningDamage = 812,
        [Description("Main Hand Local Maximum Added Lightning Damage")]
        MainHandLocalMaximumAddedLightningDamage = 813,
        [Description("Main Hand Local Minimum Added Chaos Damage")]
        MainHandLocalMinimumAddedChaosDamage = 814,
        [Description("Main Hand Local Maximum Added Chaos Damage")]
        MainHandLocalMaximumAddedChaosDamage = 815,
        [Description("Main Hand Local Attack Speed +%")]
        MainHandLocalAttackSpeedPosPct = 816,
        [Description("Old Do Not Use Main Hand Local Life Leech From Physical Damage %")]
        OldDoNotUseMainHandLocalLifeLeechFromPhysicalDamagePct = 817,
        [Description("Old Do Not Use Main Hand Local Mana Leech From Physical Damage %")]
        OldDoNotUseMainHandLocalManaLeechFromPhysicalDamagePct = 818,
        [Description("Main Hand Local Knockback")]
        MainHandLocalKnockback = 819,
        [Description("Main Hand Local Critical Strike Multiplier +")]
        MainHandLocalCriticalStrikeMultiplierPos = 820,
        [Description("Main Hand Local Critical Strike Chance")]
        MainHandLocalCriticalStrikeChance = 821,
        [Description("Main Hand Local Critical Strike Chance +%")]
        MainHandLocalCriticalStrikeChancePosPct = 822,
        [Description("Main Hand Local Accuracy Rating")]
        MainHandLocalAccuracyRating = 823,
        [Description("Main Hand Local Accuracy Rating +%")]
        MainHandLocalAccuracyRatingPosPct = 824,
        [Description("Main Hand Local Hit Causes Monster Flee %")]
        MainHandLocalHitCausesMonsterFleePct = 825,
        [Description("Main Hand Local Always Hit")]
        MainHandLocalAlwaysHit = 826,
        [Description("Off Hand Local Physical Damage +%")]
        OffHandLocalPhysicalDamagePosPct = 827,
        [Description("Off Hand Local Minimum Added Physical Damage")]
        OffHandLocalMinimumAddedPhysicalDamage = 828,
        [Description("Off Hand Local Maximum Added Physical Damage")]
        OffHandLocalMaximumAddedPhysicalDamage = 829,
        [Description("Off Hand Local Minimum Added Fire Damage")]
        OffHandLocalMinimumAddedFireDamage = 830,
        [Description("Off Hand Local Maximum Added Fire Damage")]
        OffHandLocalMaximumAddedFireDamage = 831,
        [Description("Off Hand Local Minimum Added Cold Damage")]
        OffHandLocalMinimumAddedColdDamage = 832,
        [Description("Off Hand Local Maximum Added Cold Damage")]
        OffHandLocalMaximumAddedColdDamage = 833,
        [Description("Off Hand Local Minimum Added Lightning Damage")]
        OffHandLocalMinimumAddedLightningDamage = 834,
        [Description("Off Hand Local Maximum Added Lightning Damage")]
        OffHandLocalMaximumAddedLightningDamage = 835,
        [Description("Off Hand Local Minimum Added Chaos Damage")]
        OffHandLocalMinimumAddedChaosDamage = 836,
        [Description("Off Hand Local Maximum Added Chaos Damage")]
        OffHandLocalMaximumAddedChaosDamage = 837,
        [Description("Off Hand Local Attack Speed +%")]
        OffHandLocalAttackSpeedPosPct = 838,
        [Description("Old Do Not Use Off Hand Local Life Leech From Physical Damage %")]
        OldDoNotUseOffHandLocalLifeLeechFromPhysicalDamagePct = 839,
        [Description("Old Do Not Use Off Hand Local Mana Leech From Physical Damage %")]
        OldDoNotUseOffHandLocalManaLeechFromPhysicalDamagePct = 840,
        [Description("Off Hand Local Knockback")]
        OffHandLocalKnockback = 841,
        [Description("Off Hand Local Critical Strike Multiplier +")]
        OffHandLocalCriticalStrikeMultiplierPos = 842,
        [Description("Off Hand Local Critical Strike Chance")]
        OffHandLocalCriticalStrikeChance = 843,
        [Description("Off Hand Local Critical Strike Chance +%")]
        OffHandLocalCriticalStrikeChancePosPct = 844,
        [Description("Off Hand Local Accuracy Rating")]
        OffHandLocalAccuracyRating = 845,
        [Description("Off Hand Local Accuracy Rating +%")]
        OffHandLocalAccuracyRatingPosPct = 846,
        [Description("Off Hand Local Hit Causes Monster Flee %")]
        OffHandLocalHitCausesMonsterFleePct = 847,
        [Description("Off Hand Local Always Hit")]
        OffHandLocalAlwaysHit = 848,
        [Description("Acrobatics Additional Chance To Dodge %")]
        AcrobaticsAdditionalChanceToDodgePct = 849,
        [Description("Keystone Phase Acrobatics")]
        KeystonePhaseAcrobatics = 850,
        [Description("Chance To Dodge Spells %")]
        ChanceToDodgeSpellsPct = 851,
        [Description("Phase Acrobatics Additional Chance To Dodge Spells %")]
        PhaseAcrobaticsAdditionalChanceToDodgeSpellsPct = 852,
        [Description("Number Of Inca Minions Allowed")]
        NumberOfIncaMinionsAllowed = 853,
        [Description("Curse Cast Speed +%")]
        CurseCastSpeedPosPct = 854,
        [Description("Chance To Evade Projectile Attacks +%")]
        ChanceToEvadeProjectileAttacksPosPct = 855,
        [Description("Keystone Projectile Evasion")]
        KeystoneProjectileEvasion = 856,
        [Description("Elemental Status Effect Aura Radius")]
        ElementalStatusEffectAuraRadius = 857,
        [Description("Support Lesser Multiple Projectile Damage +% Final")]
        SupportLesserMultipleProjectileDamagePosPctFinal = 858,
        [Description("Use Life In Place Of Mana")]
        UseLifeInPlaceOfMana = 859,
        [Description("Keystone Blood Magic")]
        KeystoneBloodMagic = 860,
        [Description("Base Mana Reservation +%")]
        BaseManaReservationPosPct = 861,
        [Description("Base Aura Area Of Effect +%")]
        BaseAuraAreaOfEffectPosPct = 862,
        [Description("Physical Attack Damage Taken +")]
        PhysicalAttackDamageTakenPos = 863,
        [Description("Physical Ranged Attack Damage Taken +")]
        PhysicalRangedAttackDamageTakenPos = 864,
        [Description("Block % To Apply To Spells While On Low Life")]
        BlockPctToApplyToSpellsWhileOnLowLife = 865,
        [Description("Display What Elemental Proliferation Does")]
        DisplayWhatElementalProliferationDoes = 866,
        [Description("Skill Can Fire Arrows")]
        SkillCanFireArrows = 867,
        [Description("Skill Can Fire Wand Projectiles")]
        SkillCanFireWandProjectiles = 868,
        [Description("Local Additional Block Chance %")]
        LocalAdditionalBlockChancePct = 869,
        [Description("Keystone Minion Instability")]
        KeystoneMinionInstability = 870,
        [Description("Strong Casting")]
        StrongCasting = 871,
        [Description("Support Damage While On Full Life +% Final")]
        SupportDamageWhileOnFullLifePosPctFinal = 872,
        [Description("Is Totem")]
        IsTotem = 873,
        [Description("Monster Base Type Attack Cast Speed +% And Damage -% Final")]
        MonsterBaseTypeAttackCastSpeedPosPctAndDamageNegPctFinal = 874,
        [Description("Monster Rarity Attack Cast Speed +% And Damage -% Final")]
        MonsterRarityAttackCastSpeedPosPctAndDamageNegPctFinal = 875,
        [Description("Monster Attack Cast Speed +% And Damage -% Final")]
        MonsterAttackCastSpeedPosPctAndDamageNegPctFinal = 876,
        [Description("Cast Speed +% Granted From Skill")]
        CastSpeedPosPctGrantedFromSkill = 877,
        [Description("Is Hidden Monster")]
        IsHiddenMonster = 878,
        [Description("Base Totem Duration")]
        BaseTotemDuration = 879,
        [Description("Totem Duration")]
        TotemDuration = 880,
        [Description("Base Totem Range")]
        BaseTotemRange = 881,
        [Description("Totem Range")]
        TotemRange = 882,
        [Description("Immune To Auras From Other Entities")]
        ImmuneToAurasFromOtherEntities = 883,
        [Description("Totem Support Gem Level")]
        TotemSupportGemLevel = 884,
        [Description("Base Number Of Totems Allowed")]
        BaseNumberOfTotemsAllowed = 885,
        [Description("Base Trap Duration")]
        BaseTrapDuration = 886,
        [Description("Trap Duration")]
        TrapDuration = 887,
        [Description("Base Number Of Traps Allowed")]
        BaseNumberOfTrapsAllowed = 888,
        [Description("Monster Flurry")]
        MonsterFlurry = 889,
        [Description("Number Of Insects Allowed")]
        NumberOfInsectsAllowed = 890,
        [Description("Is Remote Mine")]
        IsRemoteMine = 891,
        [Description("Base Number Of Remote Mines Allowed")]
        BaseNumberOfRemoteMinesAllowed = 892,
        [Description("Base Mine Duration")]
        BaseMineDuration = 893,
        [Description("Mine Duration")]
        MineDuration = 894,
        [Description("Nonlethal Fire Damage Taken Per Minute")]
        NonlethalFireDamageTakenPerMinute = 895,
        [Description("Base Nonlethal Fire Damage % Of Maximum Life Taken Per Minute")]
        BaseNonlethalFireDamagePctOfMaximumLifeTakenPerMinute = 896,
        [Description("Righteous Fire Spell Damage +% Final")]
        RighteousFireSpellDamagePosPctFinal = 897,
        [Description("Base Righteous Fire % Of Max Life To Deal To Nearby Per Minute")]
        BaseRighteousFirePctOfMaxLifeToDealToNearbyPerMinute = 898,
        [Description("Totem Level")]
        TotemLevel = 899,
        [Description("Base Active Skill Totem Level")]
        BaseActiveSkillTotemLevel = 900,
        [Description("Alternate Minion")]
        AlternateMinion = 901,
        [Description("Corpse Consumption Life To Gain")]
        CorpseConsumptionLifeToGain = 902,
        [Description("Support Totem Damage +% Final")]
        SupportTotemDamagePosPctFinal = 903,
        [Description("Freeze Mine Damage To Freeze As Though Dealing")]
        FreezeMineDamageToFreezeAsThoughDealing = 904,
        [Description("Monster No Drops Or Experience")]
        MonsterNoDropsOrExperience = 905,
        [Description("Active Skill Gem Added Damage Effectiveness +% Final")]
        ActiveSkillGemAddedDamageEffectivenessPosPctFinal = 906,
        [Description("Monster Gain Frenzy Charge On Kin Death")]
        MonsterGainFrenzyChargeOnKinDeath = 907,
        [Description("Monster Ground Fire On Death % Max Damage To Deal Per Minute")]
        MonsterGroundFireOnDeathPctMaxDamageToDealPerMinute = 908,
        [Description("Monster Ground Fire On Death Base Area Of Effect Radius")]
        MonsterGroundFireOnDeathBaseAreaOfEffectRadius = 909,
        [Description("Monster Ground Effect On Death Base Duration Ms")]
        MonsterGroundEffectOnDeathBaseDurationMs = 910,
        [Description("Monster Ground Fire On Death Duration Ms")]
        MonsterGroundFireOnDeathDurationMs = 911,
        [Description("Curse On Hit % Vulnerability")]
        CurseOnHitPctVulnerability = 912,
        [Description("Curse On Hit % Temporal Chains")]
        CurseOnHitPctTemporalChains = 913,
        [Description("Support Gem Mine Damage +% Final")]
        SupportGemMineDamagePosPctFinal = 914,
        [Description("Undead Description")]
        UndeadDescription = 915,
        [Description("Monster Casts Firestorm Text")]
        MonsterCastsFirestormText = 916,
        [Description("Monster Casts Puncture Text")]
        MonsterCastsPunctureText = 917,
        [Description("Monster Casts Coldsnap Text")]
        MonsterCastsColdsnapText = 918,
        [Description("Monster Casts Assassins Mark Curse Text")]
        MonsterCastsAssassinsMarkCurseText = 919,
        [Description("Monster Casts Elementral Weakness Curse Text")]
        MonsterCastsElementralWeaknessCurseText = 920,
        [Description("Monster Casts Enfeeble Curse Text")]
        MonsterCastsEnfeebleCurseText = 921,
        [Description("Monster Casts Fireball Text")]
        MonsterCastsFireballText = 922,
        [Description("Monster Casts Ice Nova Text")]
        MonsterCastsIceNovaText = 923,
        [Description("Monster Casts Ice Spear Text")]
        MonsterCastsIceSpearText = 924,
        [Description("Monster Casts Molten Shell Text")]
        MonsterCastsMoltenShellText = 925,
        [Description("Monster Casts Projectile Vulnerability Curse Text")]
        MonsterCastsProjectileVulnerabilityCurseText = 926,
        [Description("Monster Casts Shock Nova Text")]
        MonsterCastsShockNovaText = 927,
        [Description("Monster Casts Spark Text")]
        MonsterCastsSparkText = 928,
        [Description("Monster Casts Vulnerability Curse Text")]
        MonsterCastsVulnerabilityCurseText = 929,
        [Description("Monster Casts Warlords Mark Curse Text")]
        MonsterCastsWarlordsMarkCurseText = 930,
        [Description("Monster Detonates Corpses Text")]
        MonsterDetonatesCorpsesText = 931,
        [Description("Monster Explodes On Its Target Text")]
        MonsterExplodesOnItsTargetText = 932,
        [Description("Monster Fires A Rain Of Arrows Text")]
        MonsterFiresARainOfArrowsText = 933,
        [Description("Monster Fires Burning Arrows Text")]
        MonsterFiresBurningArrowsText = 934,
        [Description("Monster Fires Explosive Arrows Text")]
        MonsterFiresExplosiveArrowsText = 935,
        [Description("Monster Fires Lightning Arrows Text")]
        MonsterFiresLightningArrowsText = 936,
        [Description("Monster Fires Caustic Arrows Text")]
        MonsterFiresCausticArrowsText = 937,
        [Description("Monster Fires Split Arrows Text")]
        MonsterFiresSplitArrowsText = 938,
        [Description("Monster Leaps Onto Enemies Text")]
        MonsterLeapsOntoEnemiesText = 939,
        [Description("Monster Raises Undead Text")]
        MonsterRaisesUndeadText = 940,
        [Description("Monster Summons Exploding Spawn Text")]
        MonsterSummonsExplodingSpawnText = 941,
        [Description("Monster Summons Monkeys From Nearby Trees Text")]
        MonsterSummonsMonkeysFromNearbyTreesText = 942,
        [Description("Monster Summons Skeletons Text")]
        MonsterSummonsSkeletonsText = 943,
        [Description("Monster Summons Spawn Text")]
        MonsterSummonsSpawnText = 944,
        [Description("Monster Uses Enduring Cry Text")]
        MonsterUsesEnduringCryText = 945,
        [Description("Monster Uses Flicker Strike Text")]
        MonsterUsesFlickerStrikeText = 946,
        [Description("Monster Uses Glacial Hammer Text")]
        MonsterUsesGlacialHammerText = 947,
        [Description("Monster Uses Ground Slam Text")]
        MonsterUsesGroundSlamText = 948,
        [Description("Monster Uses Lightning Strike Text")]
        MonsterUsesLightningStrikeText = 949,
        [Description("Monster Uses Phase Run Text")]
        MonsterUsesPhaseRunText = 950,
        [Description("Monster Casts Shield Charge Text")]
        MonsterCastsShieldChargeText = 951,
        [Description("Monster Casts Mass Frenzy Text")]
        MonsterCastsMassFrenzyText = 952,
        [Description("Monster Casts Temporal Chains Text")]
        MonsterCastsTemporalChainsText = 953,
        [Description("Monster Casts Frenzy Text")]
        MonsterCastsFrenzyText = 954,
        [Description("Monster Casts Viper Strike Text")]
        MonsterCastsViperStrikeText = 955,
        [Description("Monster Casts Elemental Hit Text")]
        MonsterCastsElementalHitText = 956,
        [Description("Cannot Block Attacks")]
        CannotBlockAttacks = 957,
        [Description("Attack Block %")]
        AttackBlockPct = 958,
        [Description("Local Weapon Uses Both Hands")]
        LocalWeaponUsesBothHands = 959,
        [Description("Base Maximum Fire Damage Resistance %")]
        BaseMaximumFireDamageResistancePct = 960,
        [Description("Base Maximum Cold Damage Resistance %")]
        BaseMaximumColdDamageResistancePct = 961,
        [Description("Base Maximum Lightning Damage Resistance %")]
        BaseMaximumLightningDamageResistancePct = 962,
        [Description("Base Maximum Chaos Damage Resistance %")]
        BaseMaximumChaosDamageResistancePct = 963,
        [Description("Additional Maximum All Resistances %")]
        AdditionalMaximumAllResistancesPct = 964,
        [Description("Additional Maximum All Elemental Resistances %")]
        AdditionalMaximumAllElementalResistancesPct = 965,
        [Description("Local Display Socketed Gems Get Concentrated Area Level")]
        LocalDisplaySocketedGemsGetConcentratedAreaLevel = 966,
        [Description("Number Of Additional Traps Allowed")]
        NumberOfAdditionalTrapsAllowed = 967,
        [Description("Number Of Additional Remote Mines Allowed")]
        NumberOfAdditionalRemoteMinesAllowed = 968,
        [Description("Number Of Traps Allowed")]
        NumberOfTrapsAllowed = 969,
        [Description("Number Of Remote Mines Allowed")]
        NumberOfRemoteMinesAllowed = 970,
        [Description("Number Of Additional Totems Allowed")]
        NumberOfAdditionalTotemsAllowed = 971,
        [Description("Number Of Totems Allowed")]
        NumberOfTotemsAllowed = 972,
        [Description("Additional Physical Damage Reduction % When On Low Life")]
        AdditionalPhysicalDamageReductionPctWhenOnLowLife = 973,
        [Description("Endurance Only Conduit")]
        EnduranceOnlyConduit = 974,
        [Description("Frenzy Only Conduit")]
        FrenzyOnlyConduit = 975,
        [Description("Power Only Conduit")]
        PowerOnlyConduit = 976,
        [Description("Ice Spear Second Form Critical Strike Chance +%")]
        IceSpearSecondFormCriticalStrikeChancePosPct = 977,
        [Description("Monster Dropped Item Rarity +% From Player Support")]
        MonsterDroppedItemRarityPosPctFromPlayerSupport = 978,
        [Description("Monster Dropped Item Quantity +% From Player Support")]
        MonsterDroppedItemQuantityPosPctFromPlayerSupport = 979,
        [Description("Monster Ground Ice On Death Base Area Of Effect Radius")]
        MonsterGroundIceOnDeathBaseAreaOfEffectRadius = 980,
        [Description("Monster Ground Ice On Death Duration Ms")]
        MonsterGroundIceOnDeathDurationMs = 981,
        [Description("Monster Ground Tar On Death Base Area Of Effect Radius")]
        MonsterGroundTarOnDeathBaseAreaOfEffectRadius = 982,
        [Description("Monster Ground Tar On Death Duration Ms")]
        MonsterGroundTarOnDeathDurationMs = 983,
        [Description("Monster Ground Tar On Death Monvement Speed Pluspercent")]
        MonsterGroundTarOnDeathMonvementSpeedPluspercent = 984,
        [Description("Blinded")]
        Blinded = 985,
        [Description("Local Chance To Blind On Hit %")]
        LocalChanceToBlindOnHitPct = 986,
        [Description("Main Hand Local Chance To Blind On Hit %")]
        MainHandLocalChanceToBlindOnHitPct = 987,
        [Description("Off Hand Local Chance To Blind On Hit %")]
        OffHandLocalChanceToBlindOnHitPct = 988,
        [Description("Global Chance To Blind On Hit %")]
        GlobalChanceToBlindOnHitPct = 989,
        [Description("Main Hand Chance To Blind On Hit %")]
        MainHandChanceToBlindOnHitPct = 990,
        [Description("Off Hand Chance To Blind On Hit %")]
        OffHandChanceToBlindOnHitPct = 991,
        [Description("Local Display Socketed Gems Get Blind Level")]
        LocalDisplaySocketedGemsGetBlindLevel = 992,
        [Description("Blind Duration +%")]
        BlindDurationPosPct = 993,
        [Description("Cannot Be Knocked Back")]
        CannotBeKnockedBack = 994,
        [Description("Dual Wield Inherent Attack Speed +% Final")]
        DualWieldInherentAttackSpeedPosPctFinal = 995,
        [Description("Map Spawn Two Bosses")]
        MapSpawnTwoBosses = 996,
        [Description("Map Boss Damage +%")]
        MapBossDamagePosPct = 997,
        [Description("Map Boss Attack And Cast Speed +%")]
        MapBossAttackAndCastSpeedPosPct = 998,
        [Description("Map Monsters Additional Fire Resistance")]
        MapMonstersAdditionalFireResistance = 999,
        [Description("Map Monsters Additional Cold Resistance")]
        MapMonstersAdditionalColdResistance = 1000,
        [Description("Map Monsters Additional Lightning Resistance")]
        MapMonstersAdditionalLightningResistance = 1001,
        [Description("Map Monsters Additional Physical Damage Reduction")]
        MapMonstersAdditionalPhysicalDamageReduction = 1002,
        [Description("Map Monsters Cannot Be Stunned")]
        MapMonstersCannotBeStunned = 1003,
        [Description("Map Monsters Life +%")]
        MapMonstersLifePosPct = 1004,
        [Description("Map Monsters Damage +%")]
        MapMonstersDamagePosPct = 1005,
        [Description("Map Monsters Movement Speed +%")]
        MapMonstersMovementSpeedPosPct = 1006,
        [Description("Map Monsters Attack Speed +%")]
        MapMonstersAttackSpeedPosPct = 1007,
        [Description("Map Monsters Cast Speed +%")]
        MapMonstersCastSpeedPosPct = 1008,
        [Description("Map Monsters Reflect % Physical Damage")]
        MapMonstersReflectPctPhysicalDamage = 1009,
        [Description("Map Monsters Reflect % Elemental Damage")]
        MapMonstersReflectPctElementalDamage = 1010,
        [Description("Map Monsters Additional Number Of Projecitles")]
        MapMonstersAdditionalNumberOfProjecitles = 1011,
        [Description("Map Player Has Level X Vulnerability")]
        MapPlayerHasLevelXVulnerability = 1012,
        [Description("Map Player Has Level X Warlords Mark")]
        MapPlayerHasLevelXWarlordsMark = 1013,
        [Description("Map Player Has Level X Enfeeble")]
        MapPlayerHasLevelXEnfeeble = 1014,
        [Description("Map Player Has Level X Elemental Weakness")]
        MapPlayerHasLevelXElementalWeakness = 1015,
        [Description("Map Player Has Level X Temporal Chains")]
        MapPlayerHasLevelXTemporalChains = 1016,
        [Description("Map Player No Regeneration")]
        MapPlayerNoRegeneration = 1017,
        [Description("No Life Regeneration")]
        NoLifeRegeneration = 1018,
        [Description("No Mana Regeneration")]
        NoManaRegeneration = 1019,
        [Description("Map Player Base Chaos Damage Taken Per Minute")]
        MapPlayerBaseChaosDamageTakenPerMinute = 1020,
        [Description("Map Player Has Blood Magic Keystone")]
        MapPlayerHasBloodMagicKeystone = 1021,
        [Description("Map Player Has Elemental Equilibrium Keystone")]
        MapPlayerHasElementalEquilibriumKeystone = 1022,
        [Description("Map Player Has Chaos Inoculation Keystone")]
        MapPlayerHasChaosInoculationKeystone = 1023,
        [Description("Map Additional Player Maximum Resistances %")]
        MapAdditionalPlayerMaximumResistancesPct = 1024,
        [Description("Map Player Status Recovery Speed +%")]
        MapPlayerStatusRecoverySpeedPosPct = 1025,
        [Description("Life Recovery Speed +% Final From Map")]
        LifeRecoverySpeedPosPctFinalFromMap = 1026,
        [Description("Mana Recovery Speed +% Final From Map")]
        ManaRecoverySpeedPosPctFinalFromMap = 1027,
        [Description("Energy Shield Recovery Speed +% Final From Map")]
        EnergyShieldRecoverySpeedPosPctFinalFromMap = 1028,
        [Description("Map Size +%")]
        MapSizePosPct = 1029,
        [Description("Map Is Branchy")]
        MapIsBranchy = 1030,
        [Description("Map Packs Are Totems")]
        MapPacksAreTotems = 1031,
        [Description("Map Packs Are Skeletons")]
        MapPacksAreSkeletons = 1032,
        [Description("Map Packs Are Bandits")]
        MapPacksAreBandits = 1033,
        [Description("Map Packs Are Goatmen")]
        MapPacksAreGoatmen = 1034,
        [Description("Map Packs Are Sea Witches And Spawn")]
        MapPacksAreSeaWitchesAndSpawn = 1035,
        [Description("Map Packs Are Undead And Necromancers")]
        MapPacksAreUndeadAndNecromancers = 1036,
        [Description("Map Packs Fire Projectiles")]
        MapPacksFireProjectiles = 1037,
        [Description("Map Pack Size +%")]
        MapPackSizePosPct = 1038,
        [Description("Map Number Of Magic Packs +%")]
        MapNumberOfMagicPacksPosPct = 1039,
        [Description("Map Number Of Rare Packs +%")]
        MapNumberOfRarePacksPosPct = 1040,
        [Description("Map Base Ground Fire Damage To Deal Per Minute")]
        MapBaseGroundFireDamageToDealPerMinute = 1041,
        [Description("Map Monsters % Physical Damage To Convert To Fire")]
        MapMonstersPctPhysicalDamageToConvertToFire = 1042,
        [Description("Map Monsters % Physical Damage To Convert To Cold")]
        MapMonstersPctPhysicalDamageToConvertToCold = 1043,
        [Description("Map Monsters % Physical Damage To Convert To Lightning")]
        MapMonstersPctPhysicalDamageToConvertToLightning = 1044,
        [Description("Map Monsters % Physical Damage To Convert To Chaos")]
        MapMonstersPctPhysicalDamageToConvertToChaos = 1045,
        [Description("Map Monsters % Physical Damage To Add As Fire")]
        MapMonstersPctPhysicalDamageToAddAsFire = 1046,
        [Description("Map Monsters % Physical Damage To Add As Cold")]
        MapMonstersPctPhysicalDamageToAddAsCold = 1047,
        [Description("Map Monsters % Physical Damage To Add As Lightning")]
        MapMonstersPctPhysicalDamageToAddAsLightning = 1048,
        [Description("Map Monsters % Physical Damage To Add As Chaos")]
        MapMonstersPctPhysicalDamageToAddAsChaos = 1049,
        [Description("Base Additional Physical Damage Reduction %")]
        BaseAdditionalPhysicalDamageReductionPct = 1050,
        [Description("Map Monsters Gain X Frenzy Charges Every 20 Seconds")]
        MapMonstersGainXFrenzyChargesEvery20Seconds = 1051,
        [Description("Map Additional Number Of Packs To Choose")]
        MapAdditionalNumberOfPacksToChoose = 1052,
        [Description("Map Item Drop Quantity +%")]
        MapItemDropQuantityPosPct = 1053,
        [Description("Map Ground Effect Patches Per 100 Tiles")]
        MapGroundEffectPatchesPer100Tiles = 1054,
        [Description("Map Ground Tar Movement Speed +%")]
        MapGroundTarMovementSpeedPosPct = 1055,
        [Description("Map Ground Effect Radius")]
        MapGroundEffectRadius = 1056,
        [Description("Map Ground Ice")]
        MapGroundIce = 1057,
        [Description("Map Chest Item Quantity +%")]
        MapChestItemQuantityPosPct = 1058,
        [Description("Map Chest Item Rarity +%")]
        MapChestItemRarityPosPct = 1059,
        [Description("Display Map No Monsters")]
        DisplayMapNoMonsters = 1060,
        [Description("Necromancer Additional Rarity Levels Can Be Raised")]
        NecromancerAdditionalRarityLevelsCanBeRaised = 1061,
        [Description("Monster Dropped Item Quantity From Numplayers +%")]
        MonsterDroppedItemQuantityFromNumplayersPosPct = 1062,
        [Description("Map Disable Chest Drop Scaling")]
        MapDisableChestDropScaling = 1063,
        [Description("Physical Damage Taken % As Fire")]
        PhysicalDamageTakenPctAsFire = 1064,
        [Description("Physical Damage Taken % As Cold")]
        PhysicalDamageTakenPctAsCold = 1065,
        [Description("Physical Damage Taken % As Lightning")]
        PhysicalDamageTakenPctAsLightning = 1066,
        [Description("Physical Damage Taken % As Chaos")]
        PhysicalDamageTakenPctAsChaos = 1067,
        [Description("Base Energy Shield Regeneration Rate Per Minute")]
        BaseEnergyShieldRegenerationRatePerMinute = 1068,
        [Description("Leech Energy Shield Instead Of Life")]
        LeechEnergyShieldInsteadOfLife = 1069,
        [Description("Energy Shield Regeneration Rate Per Minute")]
        EnergyShieldRegenerationRatePerMinute = 1070,
        [Description("Monster Uses Mass Power Text")]
        MonsterUsesMassPowerText = 1071,
        [Description("Monster Uses Mass Endurance Text")]
        MonsterUsesMassEnduranceText = 1072,
        [Description("Monster Uses Shockwave Text")]
        MonsterUsesShockwaveText = 1073,
        [Description("Unique Facebreaker Unarmed Physical Damage +% Final")]
        UniqueFacebreakerUnarmedPhysicalDamagePosPctFinal = 1074,
        [Description("Local Display Socketed Gems Get Increased Area Level")]
        LocalDisplaySocketedGemsGetIncreasedAreaLevel = 1075,
        [Description("Local Socketed Aura Gem Level +")]
        LocalSocketedAuraGemLevelPos = 1076,
        [Description("Extra Gore")]
        ExtraGore = 1077,
        [Description("Local One Socket Each Colour Only")]
        LocalOneSocketEachColourOnly = 1078,
        [Description("Life Reserved By Stat %")]
        LifeReservedByStatPct = 1079,
        [Description("Block While Dual Wielding Claws %")]
        BlockWhileDualWieldingClawsPct = 1080,
        [Description("Unique Chin Sol Close Range Bow Damage +% Final")]
        UniqueChinSolCloseRangeBowDamagePosPctFinal = 1081,
        [Description("Unique Chin Sol Close Range Knockback")]
        UniqueChinSolCloseRangeKnockback = 1082,
        [Description("Physical Damage Reduction Rating Against Projectiles")]
        PhysicalDamageReductionRatingAgainstProjectiles = 1083,
        [Description("Projectile Block %")]
        ProjectileBlockPct = 1084,
        [Description("Additional Block Chance Against Projectiles %")]
        AdditionalBlockChanceAgainstProjectilesPct = 1085,
        [Description("Physical Damage Reduction Rating +% Against Projectiles")]
        PhysicalDamageReductionRatingPosPctAgainstProjectiles = 1086,
        [Description("Spell Projectile Block %")]
        SpellProjectileBlockPct = 1087,
        [Description("Projectile Attack Block %")]
        ProjectileAttackBlockPct = 1088,
        [Description("Display Estimated Physical Damage Reduciton Against Projectiles %")]
        DisplayEstimatedPhysicalDamageReducitonAgainstProjectilesPct = 1089,
        [Description("Damage Taken Goes To Mana %")]
        DamageTakenGoesToManaPct = 1090,
        [Description("Evasion And Physical Damage Reduction Rating +%")]
        EvasionAndPhysicalDamageReductionRatingPosPct = 1091,
        [Description("Additional Item Drop Slots When Deleted On Death")]
        AdditionalItemDropSlotsWhenDeletedOnDeath = 1092,
        [Description("Mana Degeneration Per Minute")]
        ManaDegenerationPerMinute = 1093,
        [Description("Life Degeneration Per Minute")]
        LifeDegenerationPerMinute = 1094,
        [Description("Ice Shield Moving Mana Degeneration Per Minute")]
        IceShieldMovingManaDegenerationPerMinute = 1095,
        [Description("Unique Quill Rain Weapon Damage +% Final")]
        UniqueQuillRainWeaponDamagePosPctFinal = 1096,
        [Description("Melee Physical Damage Taken % To Deal To Attacker")]
        MeleePhysicalDamageTakenPctToDealToAttacker = 1097,
        [Description("Additional Block %")]
        AdditionalBlockPct = 1098,
        [Description("Frozen Monsters Take Increased Damage")]
        FrozenMonstersTakeIncreasedDamage = 1099,
        [Description("Local Display Socketed Gems Get Blood Magic Level")]
        LocalDisplaySocketedGemsGetBloodMagicLevel = 1100,
        [Description("Local Display Socketed Gems Have Blood Magic")]
        LocalDisplaySocketedGemsHaveBloodMagic = 1101,
        [Description("Monster Base Block %")]
        MonsterBaseBlockPct = 1102,
        [Description("Base Cannot Leech")]
        BaseCannotLeech = 1103,
        [Description("Keystone Vampirism")]
        KeystoneVampirism = 1104,
        [Description("Unique Dewaths Hide Physical Attack Damage Dealt -")]
        UniqueDewathsHidePhysicalAttackDamageDealtNeg = 1105,
        [Description("Local Strength Requirement +%")]
        LocalStrengthRequirementPosPct = 1106,
        [Description("Local Dexterity Requirement +%")]
        LocalDexterityRequirementPosPct = 1107,
        [Description("Local Intelligence Requirement +%")]
        LocalIntelligenceRequirementPosPct = 1108,
        [Description("Local Cannot Be Used With Chaos Innoculation")]
        LocalCannotBeUsedWithChaosInnoculation = 1109,
        [Description("Local Display Socketed Gems Have Mana Reservation +%")]
        LocalDisplaySocketedGemsHaveManaReservationPosPct = 1110,
        [Description("Mace Elemental Damage +%")]
        MaceElementalDamagePosPct = 1111,
        [Description("Active Skill Minion Movement Velocity +% Final")]
        ActiveSkillMinionMovementVelocityPosPctFinal = 1112,
        [Description("Movement Velocity +% Final For Minion")]
        MovementVelocityPosPctFinalForMinion = 1113,
        [Description("Movement Velocity Cap")]
        MovementVelocityCap = 1114,
        [Description("Display Minion Base Maximum Life")]
        DisplayMinionBaseMaximumLife = 1115,
        [Description("Display Minion Maximum Life")]
        DisplayMinionMaximumLife = 1116,
        [Description("Skill Physical Damage % To Convert To Fire")]
        SkillPhysicalDamagePctToConvertToFire = 1117,
        [Description("Skill Physical Damage % To Convert To Cold")]
        SkillPhysicalDamagePctToConvertToCold = 1118,
        [Description("Skill Physical Damage % To Convert To Lightning")]
        SkillPhysicalDamagePctToConvertToLightning = 1119,
        [Description("Skill Physical Damage % To Convert To Chaos")]
        SkillPhysicalDamagePctToConvertToChaos = 1120,
        [Description("Skill Cold Damage % To Convert To Fire")]
        SkillColdDamagePctToConvertToFire = 1121,
        [Description("Physical Damage % To Convert To Fire")]
        PhysicalDamagePctToConvertToFire = 1122,
        [Description("Physical Damage % To Convert To Cold")]
        PhysicalDamagePctToConvertToCold = 1123,
        [Description("Physical Damage % To Convert To Lightning")]
        PhysicalDamagePctToConvertToLightning = 1124,
        [Description("Physical Damage % To Convert To Chaos")]
        PhysicalDamagePctToConvertToChaos = 1125,
        [Description("Cold Damage % To Convert To Fire")]
        ColdDamagePctToConvertToFire = 1126,
        [Description("Main Hand Attack Duration Ms")]
        MainHandAttackDurationMs = 1127,
        [Description("Off Hand Attack Duration Ms")]
        OffHandAttackDurationMs = 1128,
        [Description("Spell Cast Time Ms")]
        SpellCastTimeMs = 1129,
        [Description("Cast Time Overrides Attack Duration")]
        CastTimeOverridesAttackDuration = 1130,
        [Description("Projectiles Fork")]
        ProjectilesFork = 1131,
        [Description("Base Skill Number Of Additional Hits")]
        BaseSkillNumberOfAdditionalHits = 1132,
        [Description("Skill Override Pvp Scaling Time Ms")]
        SkillOverridePvpScalingTimeMs = 1133,
        [Description("Skill Double Hits When Dual Wielding")]
        SkillDoubleHitsWhenDualWielding = 1134,
        [Description("Skill Number Of Additional Hits")]
        SkillNumberOfAdditionalHits = 1135,
        [Description("Trap Override Pvp Scaling Time Ms")]
        TrapOverridePvpScalingTimeMs = 1136,
        [Description("Mine Override Pvp Scaling Time Ms")]
        MineOverridePvpScalingTimeMs = 1137,
        [Description("Override Pvp Scaling Time Ms")]
        OverridePvpScalingTimeMs = 1138,
        [Description("Skill Display Number Of Totems Allowed")]
        SkillDisplayNumberOfTotemsAllowed = 1139,
        [Description("Skill Display Number Of Traps Allowed")]
        SkillDisplayNumberOfTrapsAllowed = 1140,
        [Description("Skill Display Number Of Remote Mines Allowed")]
        SkillDisplayNumberOfRemoteMinesAllowed = 1141,
        [Description("Energy Shield % Gained On Block")]
        EnergyShieldPctGainedOnBlock = 1142,
        [Description("Local Display Socketed Gems Get Added Chaos Damage Level")]
        LocalDisplaySocketedGemsGetAddedChaosDamageLevel = 1143,
        [Description("Projectiles Return")]
        ProjectilesReturn = 1144,
        [Description("Projectile Number To Split")]
        ProjectileNumberToSplit = 1145,
        [Description("Determination Aura Armour +% Final")]
        DeterminationAuraArmourPosPctFinal = 1146,
        [Description("Support Chain Hit Damage +% Final")]
        SupportChainHitDamagePosPctFinal = 1147,
        [Description("Support Split Projectile Damage +% Final")]
        SupportSplitProjectileDamagePosPctFinal = 1148,
        [Description("Support Return Projectile Damage +% Final")]
        SupportReturnProjectileDamagePosPctFinal = 1149,
        [Description("Support Fork Projectile Damage +% Final")]
        SupportForkProjectileDamagePosPctFinal = 1150,
        [Description("Energy Shield % Of Armour Rating Gained On Block")]
        EnergyShieldPctOfArmourRatingGainedOnBlock = 1151,
        [Description("Skeleton Duration +%")]
        SkeletonDurationPosPct = 1152,
        [Description("Local Poison On Hit")]
        LocalPoisonOnHit = 1153,
        [Description("Main Hand Local Poison On Hit")]
        MainHandLocalPoisonOnHit = 1154,
        [Description("Off Hand Local Poison On Hit")]
        OffHandLocalPoisonOnHit = 1155,
        [Description("On Low Mana")]
        OnLowMana = 1156,
        [Description("Spell Damage Taken +% When On Low Mana")]
        SpellDamageTakenPosPctWhenOnLowMana = 1157,
        [Description("Spell Damage Taken +%")]
        SpellDamageTakenPosPct = 1158,
        [Description("Evasion Rating + When On Full Life")]
        EvasionRatingPosWhenOnFullLife = 1159,
        [Description("Aura Effect On Self +%")]
        AuraEffectOnSelfPosPct = 1160,
        [Description("Minions Have Aura Effect +%")]
        MinionsHaveAuraEffectPosPct = 1161,
        [Description("Reflect Curses")]
        ReflectCurses = 1162,
        [Description("Global Critical Strike Chance +% While Holding Staff")]
        GlobalCriticalStrikeChancePosPctWhileHoldingStaff = 1163,
        [Description("Global Critical Strike Multiplier + While Holding Staff")]
        GlobalCriticalStrikeMultiplierPosWhileHoldingStaff = 1164,
        [Description("Secondary Damage Critical Strike Multiplier +")]
        SecondaryDamageCriticalStrikeMultiplierPos = 1165,
        [Description("Old Do Not Use Life Leech From Spell Damage %")]
        OldDoNotUseLifeLeechFromSpellDamagePct = 1166,
        [Description("Old Do Not Use Mana Leech From Spell Damage %")]
        OldDoNotUseManaLeechFromSpellDamagePct = 1167,
        [Description("Punishment Physical Damage % Reflected For Normal Monsters")]
        PunishmentPhysicalDamagePctReflectedForNormalMonsters = 1168,
        [Description("Punishment Physical Damage % Reflected For Magic Monsters")]
        PunishmentPhysicalDamagePctReflectedForMagicMonsters = 1169,
        [Description("Punishment Physical Damage % Reflected For Rare Monsters")]
        PunishmentPhysicalDamagePctReflectedForRareMonsters = 1170,
        [Description("Punishment Physical Damage % Reflected For Unique Monsters")]
        PunishmentPhysicalDamagePctReflectedForUniqueMonsters = 1171,
        [Description("Is Player Minion")]
        IsPlayerMinion = 1172,
        [Description("Local Flask Curse Immunity While Healing")]
        LocalFlaskCurseImmunityWhileHealing = 1173,
        [Description("Attacks Deal No Physical Damage")]
        AttacksDealNoPhysicalDamage = 1174,
        [Description("Whirling Blades Base Ground Fire Damage To Deal Per Minute")]
        WhirlingBladesBaseGroundFireDamageToDealPerMinute = 1175,
        [Description("Monster Casts Ethereal Knives Text")]
        MonsterCastsEtherealKnivesText = 1176,
        [Description("Monster Throws Beartraps Text")]
        MonsterThrowsBeartrapsText = 1177,
        [Description("Monster Casts Lightning Thorns Text")]
        MonsterCastsLightningThornsText = 1178,
        [Description("Monster Throws Fire Bombs Text")]
        MonsterThrowsFireBombsText = 1179,
        [Description("Monster Throws Caustic Bombs Text")]
        MonsterThrowsCausticBombsText = 1180,
        [Description("Monster Casts Freezing Pulse Text")]
        MonsterCastsFreezingPulseText = 1181,
        [Description("Monster Cleaves Text")]
        MonsterCleavesText = 1182,
        [Description("Monster Fires Ice Shot Arrows Text")]
        MonsterFiresIceShotArrowsText = 1183,
        [Description("Monster Casts Conductivity Text")]
        MonsterCastsConductivityText = 1184,
        [Description("Monster Casts Flammability Text")]
        MonsterCastsFlammabilityText = 1185,
        [Description("Monster Casts Augmented Fireballs Text")]
        MonsterCastsAugmentedFireballsText = 1186,
        [Description("Monster Channels Lightning Text")]
        MonsterChannelsLightningText = 1187,
        [Description("Monster Casts Arc Text")]
        MonsterCastsArcText = 1188,
        [Description("Monster Raises Zombies Text")]
        MonsterRaisesZombiesText = 1189,
        [Description("Monster Casts Ice Shield Text")]
        MonsterCastsIceShieldText = 1190,
        [Description("Monster Casts Unholy Fire Text")]
        MonsterCastsUnholyFireText = 1191,
        [Description("Physical Damage Taken +")]
        PhysicalDamageTakenPos = 1192,
        [Description("Fire Damage Taken +")]
        FireDamageTakenPos = 1193,
        [Description("Monster Gain Power Charge On Kin Death")]
        MonsterGainPowerChargeOnKinDeath = 1194,
        [Description("Monster Casts Discharge Text")]
        MonsterCastsDischargeText = 1195,
        [Description("Trap Variation")]
        TrapVariation = 1196,
        [Description("Number Of Water Elementals To Summon")]
        NumberOfWaterElementalsToSummon = 1197,
        [Description("Number Of Water Elementals Allowed")]
        NumberOfWaterElementalsAllowed = 1198,
        [Description("Display Summons Water Elementals Text")]
        DisplaySummonsWaterElementalsText = 1199,
        [Description("Shield Charge Remove Stun And Knockback")]
        ShieldChargeRemoveStunAndKnockback = 1200,
        [Description("Display Monster Uses Double Strike Text")]
        DisplayMonsterUsesDoubleStrikeText = 1201,
        [Description("Bleed On Hit Base Duration")]
        BleedOnHitBaseDuration = 1202,
        [Description("Display Monster Uses Whirling Blades Text")]
        DisplayMonsterUsesWhirlingBladesText = 1203,
        [Description("Cannot Be Stunned")]
        CannotBeStunned = 1204,
        [Description("Cannot Be Stunned When On Low Life")]
        CannotBeStunnedWhenOnLowLife = 1205,
        [Description("Display Monster Casts Lightning Warp Text")]
        DisplayMonsterCastsLightningWarpText = 1206,
        [Description("Display Golden Radiance")]
        DisplayGoldenRadiance = 1207,
        [Description("Display Monster Casts Frostbite Text")]
        DisplayMonsterCastsFrostbiteText = 1208,
        [Description("Cannot Be Converted Or Dominated")]
        CannotBeConvertedOrDominated = 1209,
        [Description("Map Hidden Monster Life +% Times 6 Final")]
        MapHiddenMonsterLifePosPctTimes6Final = 1210,
        [Description("Map Hidden Monster Damage +% Squared Final")]
        MapHiddenMonsterDamagePosPctSquaredFinal = 1211,
        [Description("Regenerate Energy Shield Instead Of Life")]
        RegenerateEnergyShieldInsteadOfLife = 1212,
        [Description("Damage Not From Skill User")]
        DamageNotFromSkillUser = 1213,
        [Description("Deal No Damage Yourself")]
        DealNoDamageYourself = 1214,
        [Description("Deal No Damage")]
        DealNoDamage = 1215,
        [Description("Disable Skill If Melee Attack")]
        DisableSkillIfMeleeAttack = 1216,
        [Description("Display Disable Melee Weapons")]
        DisplayDisableMeleeWeapons = 1217,
        [Description("Chaos Damage Does Not Bypass Energy Shield")]
        ChaosDamageDoesNotBypassEnergyShield = 1218,
        [Description("Cannot Cast Spells")]
        CannotCastSpells = 1219,
        [Description("Piety Transform Debuff Time Ms")]
        PietyTransformDebuffTimeMs = 1220,
        [Description("Cheat Override Blood Effect Level")]
        CheatOverrideBloodEffectLevel = 1221,
        [Description("Map Undead Monsters Get Up After X Seconds")]
        MapUndeadMonstersGetUpAfterXSeconds = 1222,
        [Description("Local Stun Threshold Reduction +%")]
        LocalStunThresholdReductionPosPct = 1223,
        [Description("Main Hand Local Stun Threshold Reduction +%")]
        MainHandLocalStunThresholdReductionPosPct = 1224,
        [Description("Off Hand Local Stun Threshold Reduction +%")]
        OffHandLocalStunThresholdReductionPosPct = 1225,
        [Description("Intermediary Maximum Life Including Chaos Innoculation")]
        IntermediaryMaximumLifeIncludingChaosInnoculation = 1226,
        [Description("Light Radius +%")]
        LightRadiusPosPct = 1227,
        [Description("Active Skill Cast Speed +% Final")]
        ActiveSkillCastSpeedPosPctFinal = 1228,
        [Description("Map Has X Waves Of Monsters")]
        MapHasXWavesOfMonsters = 1229,
        [Description("Map Has X Seconds Between Waves")]
        MapHasXSecondsBetweenWaves = 1230,
        [Description("Map Num Initial Wave Monsters")]
        MapNumInitialWaveMonsters = 1231,
        [Description("Map Wave Monster Increment")]
        MapWaveMonsterIncrement = 1232,
        [Description("Flamethrower Damage +% Per Stage Final")]
        FlamethrowerDamagePosPctPerStageFinal = 1233,
        [Description("Ground Tar On Take Crit Base Area Of Effect Radius")]
        GroundTarOnTakeCritBaseAreaOfEffectRadius = 1234,
        [Description("Ground Tar On Take Crit Duration Ms")]
        GroundTarOnTakeCritDurationMs = 1235,
        [Description("Ground Tar On Take Crit Monvement Speed Pluspercent")]
        GroundTarOnTakeCritMonvementSpeedPluspercent = 1236,
        [Description("Curse On Hit % Enfeeble")]
        CurseOnHitPctEnfeeble = 1237,
        [Description("Totem Art Variation")]
        TotemArtVariation = 1238,
        [Description("Spells Have Culling Strike")]
        SpellsHaveCullingStrike = 1239,
        [Description("Map Monsters Immune To A Random Status Ailment Or Stun")]
        MapMonstersImmuneToARandomStatusAilmentOrStun = 1240,
        [Description("Map Monster Melee Attacks Apply Random Curses")]
        MapMonsterMeleeAttacksApplyRandomCurses = 1241,
        [Description("Map Monsters Reflect Curses")]
        MapMonstersReflectCurses = 1242,
        [Description("Curse On Melee Hit % Random Curse")]
        CurseOnMeleeHitPctRandomCurse = 1243,
        [Description("Main Hand Maximum Attack Distance")]
        MainHandMaximumAttackDistance = 1244,
        [Description("Off Hand Maximum Attack Distance")]
        OffHandMaximumAttackDistance = 1245,
        [Description("Melee Range +")]
        MeleeRangePos = 1246,
        [Description("Cyclone Movement Speed +% Final")]
        CycloneMovementSpeedPosPctFinal = 1247,
        [Description("Local Display Socketed Gems Get Added Fire Damage Level")]
        LocalDisplaySocketedGemsGetAddedFireDamageLevel = 1248,
        [Description("Local Display Socketed Gems Get Cold To Fire Level")]
        LocalDisplaySocketedGemsGetColdToFireLevel = 1249,
        [Description("Local Display Socketed Gems Get Fire Penetration Level")]
        LocalDisplaySocketedGemsGetFirePenetrationLevel = 1250,
        [Description("Evasion Rating +% When On Low Life")]
        EvasionRatingPosPctWhenOnLowLife = 1251,
        [Description("Life Leech Is Instant")]
        LifeLeechIsInstant = 1252,
        [Description("Base Life Leech Is Instant")]
        BaseLifeLeechIsInstant = 1253,
        [Description("Support Multiple Attacks Melee Attack Speed +% Final")]
        SupportMultipleAttacksMeleeAttackSpeedPosPctFinal = 1254,
        [Description("Map Item Drop Rarity +%")]
        MapItemDropRarityPosPct = 1255,
        [Description("Life Gain Per Target")]
        LifeGainPerTarget = 1256,
        [Description("Local Life Leech Is Instant")]
        LocalLifeLeechIsInstant = 1257,
        [Description("Main Hand Local Life Leech Is Instant")]
        MainHandLocalLifeLeechIsInstant = 1258,
        [Description("Off Hand Local Life Leech Is Instant")]
        OffHandLocalLifeLeechIsInstant = 1259,
        [Description("Avoid Ignite % When On Low Life")]
        AvoidIgnitePctWhenOnLowLife = 1260,
        [Description("Fire Damage Resistance % When On Low Life")]
        FireDamageResistancePctWhenOnLowLife = 1261,
        [Description("Local Display Socketed Gems Get Elemental Proliferation Level")]
        LocalDisplaySocketedGemsGetElementalProliferationLevel = 1262,
        [Description("Melee Splash")]
        MeleeSplash = 1263,
        [Description("Support Melee Splash Damage +% Final")]
        SupportMeleeSplashDamagePosPctFinal = 1264,
        [Description("Support Melee Splash Damage +% Final For Splash")]
        SupportMeleeSplashDamagePosPctFinalForSplash = 1265,
        [Description("Add Power Charge On Critical Strike %")]
        AddPowerChargeOnCriticalStrikePct = 1266,
        [Description("Base Melee Attack Repeat Count")]
        BaseMeleeAttackRepeatCount = 1267,
        [Description("Attack Repeat Count")]
        AttackRepeatCount = 1268,
        [Description("Display Map Larger Maze")]
        DisplayMapLargerMaze = 1269,
        [Description("Display Map Restless Dead")]
        DisplayMapRestlessDead = 1270,
        [Description("Display Map Two Bosses")]
        DisplayMapTwoBosses = 1271,
        [Description("Display Map Large Chest")]
        DisplayMapLargeChest = 1272,
        [Description("Local Socketed Movement Gem Level +")]
        LocalSocketedMovementGemLevelPos = 1273,
        [Description("Map Projectile Speed +%")]
        MapProjectileSpeedPosPct = 1274,
        [Description("Map Player Projectile Damage +% Final")]
        MapPlayerProjectileDamagePosPctFinal = 1275,
        [Description("Projectile Damage +% Final From Map")]
        ProjectileDamagePosPctFinalFromMap = 1276,
        [Description("Support Multiple Attack Damage +% Final")]
        SupportMultipleAttackDamagePosPctFinal = 1277,
        [Description("Necromancer Revivable Even If Corpse Unusable")]
        NecromancerRevivableEvenIfCorpseUnusable = 1278,
        [Description("Local Six Linked White Sockets")]
        LocalSixLinkedWhiteSockets = 1279,
        [Description("Area Of Effect +% Per 20 Int")]
        AreaOfEffectPosPctPer20Int = 1280,
        [Description("Attack Speed +% Per 10 Dex")]
        AttackSpeedPosPctPer10Dex = 1281,
        [Description("Physical Weapon Damage +% Per 10 Str")]
        PhysicalWeaponDamagePosPctPer10Str = 1282,
        [Description("Chance To Dodge % Per Frenzy Charge")]
        ChanceToDodgePctPerFrenzyCharge = 1283,
        [Description("Gain Power Charge Per Enemy You Crit")]
        GainPowerChargePerEnemyYouCrit = 1284,
        [Description("Local Unique Tabula Rasa No Requirement Or Energy Shield")]
        LocalUniqueTabulaRasaNoRequirementOrEnergyShield = 1285,
        [Description("Map Wave Magic Increase")]
        MapWaveMagicIncrease = 1286,
        [Description("Local Display Socketed Gems Get Spell Totem Level")]
        LocalDisplaySocketedGemsGetSpellTotemLevel = 1287,
        [Description("Cannot Increase Quantity Of Dropped Items")]
        CannotIncreaseQuantityOfDroppedItems = 1288,
        [Description("Cannot Increase Rarity Of Dropped Items")]
        CannotIncreaseRarityOfDroppedItems = 1289,
        [Description("Killed Monster Dropped Item Rarity +%")]
        KilledMonsterDroppedItemRarityPosPct = 1290,
        [Description("Killed Monster Dropped Item Quantity +%")]
        KilledMonsterDroppedItemQuantityPosPct = 1291,
        [Description("Burning Damage Taken +%")]
        BurningDamageTakenPosPct = 1292,
        [Description("Curse Effect On Self +%")]
        CurseEffectOnSelfPosPct = 1293,
        [Description("Randomly Cursed When Totems Die Curse Level")]
        RandomlyCursedWhenTotemsDieCurseLevel = 1294,
        [Description("Maximum Physical Damage To Return When Hit")]
        MaximumPhysicalDamageToReturnWhenHit = 1295,
        [Description("Maximum Fire Damage To Return When Hit")]
        MaximumFireDamageToReturnWhenHit = 1296,
        [Description("Maximum Cold Damage To Return When Hit")]
        MaximumColdDamageToReturnWhenHit = 1297,
        [Description("Maximum Lightning Damage To Return When Hit")]
        MaximumLightningDamageToReturnWhenHit = 1298,
        [Description("Maximum Chaos Damage To Return When Hit")]
        MaximumChaosDamageToReturnWhenHit = 1299,
        [Description("Minimum Physical Damage To Return When Hit")]
        MinimumPhysicalDamageToReturnWhenHit = 1300,
        [Description("Minimum Fire Damage To Return When Hit")]
        MinimumFireDamageToReturnWhenHit = 1301,
        [Description("Minimum Cold Damage To Return When Hit")]
        MinimumColdDamageToReturnWhenHit = 1302,
        [Description("Minimum Lightning Damage To Return When Hit")]
        MinimumLightningDamageToReturnWhenHit = 1303,
        [Description("Minimum Chaos Damage To Return When Hit")]
        MinimumChaosDamageToReturnWhenHit = 1304,
        [Description("Local Display Socketed Gems Get Increased Duration Level")]
        LocalDisplaySocketedGemsGetIncreasedDurationLevel = 1305,
        [Description("Summon Fire Resistance +")]
        SummonFireResistancePos = 1306,
        [Description("Summon Cold Resistance +")]
        SummonColdResistancePos = 1307,
        [Description("Summon Lightning Resistance +")]
        SummonLightningResistancePos = 1308,
        [Description("Melee Weapon Critical Strike Multiplier +")]
        MeleeWeaponCriticalStrikeMultiplierPos = 1309,
        [Description("Map Monster Skills Chain X Additional Times")]
        MapMonsterSkillsChainXAdditionalTimes = 1310,
        [Description("Local Ring Disable Other Ring")]
        LocalRingDisableOtherRing = 1311,
        [Description("Disable Ring Slot 1")]
        DisableRingSlot1 = 1312,
        [Description("Disable Ring Slot 2")]
        DisableRingSlot2 = 1313,
        [Description("Global Item Attribute Requirements +%")]
        GlobalItemAttributeRequirementsPosPct = 1314,
        [Description("Grant Kill To Target When Exploding Self")]
        GrantKillToTargetWhenExplodingSelf = 1315,
        [Description("Mana Gain Per Target")]
        ManaGainPerTarget = 1316,
        [Description("Animation Effect Variation")]
        AnimationEffectVariation = 1317,
        [Description("Enemy Hits Roll Low Damage")]
        EnemyHitsRollLowDamage = 1318,
        [Description("Minions Take No Actions")]
        MinionsTakeNoActions = 1319,
        [Description("Unique Loris Lantern Golden Light")]
        UniqueLorisLanternGoldenLight = 1320,
        [Description("Chaos Damage Resistance % When On Low Life")]
        ChaosDamageResistancePctWhenOnLowLife = 1321,
        [Description("Gain Power Charge For Each Quarter Life Removed")]
        GainPowerChargeForEachQuarterLifeRemoved = 1322,
        [Description("Enemy Extra Damage Rolls")]
        EnemyExtraDamageRolls = 1323,
        [Description("Enemy Extra Damage Rolls When On Low Life")]
        EnemyExtraDamageRollsWhenOnLowLife = 1324,
        [Description("Map Fixed Seed")]
        MapFixedSeed = 1325,
        [Description("Map Monsters Drop Ground Fire On Death Base Radius")]
        MapMonstersDropGroundFireOnDeathBaseRadius = 1326,
        [Description("Map Monsters Drop Ground Fire On Death Duration Ms")]
        MapMonstersDropGroundFireOnDeathDurationMs = 1327,
        [Description("Map Monsters Drop Ground Fire On Death % Max Damage To Deal Per Minute")]
        MapMonstersDropGroundFireOnDeathPctMaxDamageToDealPerMinute = 1328,
        [Description("Map Monsters Convert All Physical Damage To Fire")]
        MapMonstersConvertAllPhysicalDamageToFire = 1329,
        [Description("Map Players Convert All Physical Damage To Fire")]
        MapPlayersConvertAllPhysicalDamageToFire = 1330,
        [Description("Local Display Socketed Gems Have Chance To Flee %")]
        LocalDisplaySocketedGemsHaveChanceToFleePct = 1331,
        [Description("Map No Refills In Town")]
        MapNoRefillsInTown = 1332,
        [Description("Base Minimum Lightning Damage On Charge Expiry")]
        BaseMinimumLightningDamageOnChargeExpiry = 1333,
        [Description("Base Maximum Lightning Damage On Charge Expiry")]
        BaseMaximumLightningDamageOnChargeExpiry = 1334,
        [Description("Item Drops On Death")]
        ItemDropsOnDeath = 1335,
        [Description("Map Minimap Revealed")]
        MapMinimapRevealed = 1336,
        [Description("Explode On Death % Main Hand Damage To Deal As Fire")]
        ExplodeOnDeathPctMainHandDamageToDealAsFire = 1337,
        [Description("Explode On Death % Main Hand Damage To Deal As Lightning")]
        ExplodeOnDeathPctMainHandDamageToDealAsLightning = 1338,
        [Description("Explode On Death % Main Hand Damage To Deal As Cold")]
        ExplodeOnDeathPctMainHandDamageToDealAsCold = 1339,
        [Description("Explode On Death % Main Hand Damage To Deal As Chaos")]
        ExplodeOnDeathPctMainHandDamageToDealAsChaos = 1340,
        [Description("Never Shock")]
        NeverShock = 1341,
        [Description("Never Freeze")]
        NeverFreeze = 1342,
        [Description("Faster Burn %")]
        FasterBurnPct = 1343,
        [Description("Disable Chest Slot")]
        DisableChestSlot = 1344,
        [Description("Local Display Socketed Gems Get Faster Attacks Level")]
        LocalDisplaySocketedGemsGetFasterAttacksLevel = 1345,
        [Description("Local Display Socketed Gems Get Melee Physical Damage Level")]
        LocalDisplaySocketedGemsGetMeleePhysicalDamageLevel = 1346,
        [Description("Flasks Dispel Burning")]
        FlasksDispelBurning = 1347,
        [Description("Physical Claw Damage +% When On Low Life")]
        PhysicalClawDamagePosPctWhenOnLowLife = 1348,
        [Description("Accuracy Rating +% When On Low Life")]
        AccuracyRatingPosPctWhenOnLowLife = 1349,
        [Description("Cannot Leech")]
        CannotLeech = 1350,
        [Description("Cannot Leech When On Low Life")]
        CannotLeechWhenOnLowLife = 1351,
        [Description("Base Cannot Leech Life")]
        BaseCannotLeechLife = 1352,
        [Description("Base Cannot Leech Mana")]
        BaseCannotLeechMana = 1353,
        [Description("Cannot Leech Life")]
        CannotLeechLife = 1354,
        [Description("Cannot Leech Mana")]
        CannotLeechMana = 1355,
        [Description("Base Energy Shield Gained On Enemy Death")]
        BaseEnergyShieldGainedOnEnemyDeath = 1356,
        [Description("Summon Totem Cast Speed +%")]
        SummonTotemCastSpeedPosPct = 1357,
        [Description("Consecrate On Block % Chance To Create")]
        ConsecrateOnBlockPctChanceToCreate = 1358,
        [Description("Consecrate On Block % Life Regen Per Minute")]
        ConsecrateOnBlockPctLifeRegenPerMinute = 1359,
        [Description("Consecrate On Block Base Radius")]
        ConsecrateOnBlockBaseRadius = 1360,
        [Description("Consecrate On Block Duration Ms")]
        ConsecrateOnBlockDurationMs = 1361,
        [Description("Desecrate On Block % Chance To Create")]
        DesecrateOnBlockPctChanceToCreate = 1362,
        [Description("Desecrate On Block Base Chaos Damage To Deal Per Minute")]
        DesecrateOnBlockBaseChaosDamageToDealPerMinute = 1363,
        [Description("Desecrate On Block Base Radius")]
        DesecrateOnBlockBaseRadius = 1364,
        [Description("Desecrate On Block Duration Ms")]
        DesecrateOnBlockDurationMs = 1365,
        [Description("Base Chaos Damage % Of Maximum Life Taken Per Minute Per Frenzy Charge")]
        BaseChaosDamagePctOfMaximumLifeTakenPerMinutePerFrenzyCharge = 1366,
        [Description("Add Frenzy Charge On Kill % Chance")]
        AddFrenzyChargeOnKillPctChance = 1367,
        [Description("Local Socketed Elemental Gem Level +")]
        LocalSocketedElementalGemLevelPos = 1368,
        [Description("Melee Critical Strike Chance +%")]
        MeleeCriticalStrikeChancePosPct = 1369,
        [Description("Melee Critical Strike Chance +% When On Full Life")]
        MeleeCriticalStrikeChancePosPctWhenOnFullLife = 1370,
        [Description("Cannot Be Killed By Elemental Reflect")]
        CannotBeKilledByElementalReflect = 1371,
        [Description("Local Display Socketed Gems Get Added Lightning Damage Level")]
        LocalDisplaySocketedGemsGetAddedLightningDamageLevel = 1372,
        [Description("Map Is Unidentified")]
        MapIsUnidentified = 1373,
        [Description("Melee Attacks Usable Without Mana Cost")]
        MeleeAttacksUsableWithoutManaCost = 1374,
        [Description("Melee Attack Mana Cost +")]
        MeleeAttackManaCostPos = 1375,
        [Description("Melee Damage +%")]
        MeleeDamagePosPct = 1376,
        [Description("Melee Damage Taken +%")]
        MeleeDamageTakenPosPct = 1377,
        [Description("Map Experience Gain +%")]
        MapExperienceGainPosPct = 1378,
        [Description("Life Gained On Block")]
        LifeGainedOnBlock = 1379,
        [Description("Mana Gained On Block")]
        ManaGainedOnBlock = 1380,
        [Description("Minimum Physical Damage To Return On Block")]
        MinimumPhysicalDamageToReturnOnBlock = 1381,
        [Description("Maximum Physical Damage To Return On Block")]
        MaximumPhysicalDamageToReturnOnBlock = 1382,
        [Description("Footstep Effect Variation")]
        FootstepEffectVariation = 1383,
        [Description("Zombie Maximum Life +")]
        ZombieMaximumLifePos = 1384,
        [Description("Number Of Zombies Allowed +%")]
        NumberOfZombiesAllowedPosPct = 1385,
        [Description("Zombie Chaos Elemental Damage Resistance %")]
        ZombieChaosElementalDamageResistancePct = 1386,
        [Description("Chill And Freeze Duration Based On % Energy Shield")]
        ChillAndFreezeDurationBasedOnPctEnergyShield = 1387,
        [Description("Number Of Equipped Uniques")]
        NumberOfEquippedUniques = 1388,
        [Description("Intelligence +% Per Equipped Unique")]
        IntelligencePosPctPerEquippedUnique = 1389,
        [Description("Ignited Enemies Explode On Kill")]
        IgnitedEnemiesExplodeOnKill = 1390,
        [Description("Additional Scroll Of Wisdom Drop Chance %")]
        AdditionalScrollOfWisdomDropChancePct = 1391,
        [Description("Explode On Kill % Fire Damage To Deal")]
        ExplodeOnKillPctFireDamageToDeal = 1392,
        [Description("Zombie Explode On Kill % Fire Damage To Deal")]
        ZombieExplodeOnKillPctFireDamageToDeal = 1393,
        [Description("Local Unique Flask Item Rarity +% While Healing")]
        LocalUniqueFlaskItemRarityPosPctWhileHealing = 1394,
        [Description("Local Unique Flask Item Quantity +% While Healing")]
        LocalUniqueFlaskItemQuantityPosPctWhileHealing = 1395,
        [Description("Local Unique Flask Light Radius +% While Healing")]
        LocalUniqueFlaskLightRadiusPosPctWhileHealing = 1396,
        [Description("Local Unique Flask Additional Maximum All Elemental Resistances % While Healing")]
        LocalUniqueFlaskAdditionalMaximumAllElementalResistancesPctWhileHealing = 1397,
        [Description("Additional Strength And Intelligence")]
        AdditionalStrengthAndIntelligence = 1398,
        [Description("Additional Strength And Dexterity")]
        AdditionalStrengthAndDexterity = 1399,
        [Description("Additional Dexterity And Intelligence")]
        AdditionalDexterityAndIntelligence = 1400,
        [Description("Curse Effect +%")]
        CurseEffectPosPct = 1401,
        [Description("Nonfunctional Old Stat Map Monster Movement Velocity Cap")]
        NonfunctionalOldStatMapMonsterMovementVelocityCap = 1402,
        [Description("Movement Velocity +% While Cursed")]
        MovementVelocityPosPctWhileCursed = 1403,
        [Description("Map Spawn Exile Per Area %")]
        MapSpawnExilePerAreaPct = 1404,
        [Description("Cyclone Extra Distance")]
        CycloneExtraDistance = 1405,
        [Description("Zombie Boss Extract Life % To Gain")]
        ZombieBossExtractLifePctToGain = 1406,
        [Description("Life Regeneration Rate Per Minute % Per Frenzy Charge")]
        LifeRegenerationRatePerMinutePctPerFrenzyCharge = 1407,
        [Description("Enemy On Low Life Damage Taken +% Per Frenzy Charge")]
        EnemyOnLowLifeDamageTakenPosPctPerFrenzyCharge = 1408,
        [Description("Movement Velocity +% Per Ten Levels")]
        MovementVelocityPosPctPerTenLevels = 1409,
        [Description("Enemy On Low Life Damage Taken +%")]
        EnemyOnLowLifeDamageTakenPosPct = 1410,
        [Description("Add Power Charge On Kill % Chance")]
        AddPowerChargeOnKillPctChance = 1411,
        [Description("Gain Endurance Charge On Power Charge Expiry")]
        GainEnduranceChargeOnPowerChargeExpiry = 1412,
        [Description("Melee Damage +% When On Full Life")]
        MeleeDamagePosPctWhenOnFullLife = 1413,
        [Description("Consecrate On Crit % Chance To Create")]
        ConsecrateOnCritPctChanceToCreate = 1414,
        [Description("Projectile Speed +%")]
        ProjectileSpeedPosPct = 1415,
        [Description("Projectile Speed +% Per Frenzy Charge")]
        ProjectileSpeedPosPctPerFrenzyCharge = 1416,
        [Description("Projectile Damage +% Per Power Charge")]
        ProjectileDamagePosPctPerPowerCharge = 1417,
        [Description("Killed Monster Dropped Item Rarity +% On Crit")]
        KilledMonsterDroppedItemRarityPosPctOnCrit = 1418,
        [Description("Onslaught Buff Duration On Kill Ms")]
        OnslaughtBuffDurationOnKillMs = 1419,
        [Description("Local Right Ring Slot No Mana Regeneration")]
        LocalRightRingSlotNoManaRegeneration = 1420,
        [Description("Local Right Ring Slot Base Energy Shield Regeneration Rate Per Minute %")]
        LocalRightRingSlotBaseEnergyShieldRegenerationRatePerMinutePct = 1421,
        [Description("Local Left Ring Slot Mana Regeneration Rate +%")]
        LocalLeftRingSlotManaRegenerationRatePosPct = 1422,
        [Description("Local Left Ring Slot No Energy Shield Recharge Or Regeneration")]
        LocalLeftRingSlotNoEnergyShieldRechargeOrRegeneration = 1423,
        [Description("No Energy Shield Recharge Or Regeneration")]
        NoEnergyShieldRechargeOrRegeneration = 1424,
        [Description("Base Energy Shield Regeneration Rate Per Minute %")]
        BaseEnergyShieldRegenerationRatePerMinutePct = 1425,
        [Description("Character Sheet Monster Level")]
        CharacterSheetMonsterLevel = 1426,
        [Description("Keystone Acrobatics Energy Shield +% Final")]
        KeystoneAcrobaticsEnergyShieldPosPctFinal = 1427,
        [Description("Keystone Acrobatics Physical Damage Reduction Rating +% Final")]
        KeystoneAcrobaticsPhysicalDamageReductionRatingPosPctFinal = 1428,
        [Description("Life Recovery Per Minute From Leech")]
        LifeRecoveryPerMinuteFromLeech = 1429,
        [Description("Mana Recovery Per Minute From Leech")]
        ManaRecoveryPerMinuteFromLeech = 1430,
        [Description("Energy Shield Recovery Per Minute From Leech")]
        EnergyShieldRecoveryPerMinuteFromLeech = 1431,
        [Description("Life Recovery Per Minute")]
        LifeRecoveryPerMinute = 1432,
        [Description("Mana Recovery Per Minute")]
        ManaRecoveryPerMinute = 1433,
        [Description("Energy Shield Recovery Per Minute")]
        EnergyShieldRecoveryPerMinute = 1434,
        [Description("Extra Critical Rolls")]
        ExtraCriticalRolls = 1435,
        [Description("Combined All Damage +%")]
        CombinedAllDamagePosPct = 1436,
        [Description("Combined All Damage +% Final")]
        CombinedAllDamagePosPctFinal = 1437,
        [Description("Combined Spell All Damage +%")]
        CombinedSpellAllDamagePosPct = 1438,
        [Description("Combined Spell All Damage +% Final")]
        CombinedSpellAllDamagePosPctFinal = 1439,
        [Description("Combined Attack All Damage +%")]
        CombinedAttackAllDamagePosPct = 1440,
        [Description("Combined Attack All Damage +% Final")]
        CombinedAttackAllDamagePosPctFinal = 1441,
        [Description("Combined Main Hand Attack All Damage +%")]
        CombinedMainHandAttackAllDamagePosPct = 1442,
        [Description("Combined Off Hand Attack All Damage +%")]
        CombinedOffHandAttackAllDamagePosPct = 1443,
        [Description("Combined Physical Damage +%")]
        CombinedPhysicalDamagePosPct = 1444,
        [Description("Combined Physical Damage +% Final")]
        CombinedPhysicalDamagePosPctFinal = 1445,
        [Description("Combined Attack Physical Damage +%")]
        CombinedAttackPhysicalDamagePosPct = 1446,
        [Description("Combined Attack Physical Damage +% Final")]
        CombinedAttackPhysicalDamagePosPctFinal = 1447,
        [Description("Combined Main Hand Attack Physical Damage +%")]
        CombinedMainHandAttackPhysicalDamagePosPct = 1448,
        [Description("Combined Off Hand Attack Physical Damage +%")]
        CombinedOffHandAttackPhysicalDamagePosPct = 1449,
        [Description("Combined Main Hand Attack Physical Damage +% Final")]
        CombinedMainHandAttackPhysicalDamagePosPctFinal = 1450,
        [Description("Combined Off Hand Attack Physical Damage +% Final")]
        CombinedOffHandAttackPhysicalDamagePosPctFinal = 1451,
        [Description("Combined Fire Damage +%")]
        CombinedFireDamagePosPct = 1452,
        [Description("Combined Fire Damage +% Final")]
        CombinedFireDamagePosPctFinal = 1453,
        [Description("Combined Cold Damage +%")]
        CombinedColdDamagePosPct = 1454,
        [Description("Combined Cold Damage +% Final")]
        CombinedColdDamagePosPctFinal = 1455,
        [Description("Combined Lightning Damage +%")]
        CombinedLightningDamagePosPct = 1456,
        [Description("Combined Lightning Damage +% Final")]
        CombinedLightningDamagePosPctFinal = 1457,
        [Description("Combined Chaos Damage +%")]
        CombinedChaosDamagePosPct = 1458,
        [Description("Combined Chaos Damage +% Final")]
        CombinedChaosDamagePosPctFinal = 1459,
        [Description("Combined Elemental Damage +%")]
        CombinedElementalDamagePosPct = 1460,
        [Description("Combined Elemental Damage +% Final")]
        CombinedElementalDamagePosPctFinal = 1461,
        [Description("Combined Attack Fire Damage +%")]
        CombinedAttackFireDamagePosPct = 1462,
        [Description("Combined Attack Fire Damage +% Final")]
        CombinedAttackFireDamagePosPctFinal = 1463,
        [Description("Combined Attack Cold Damage +%")]
        CombinedAttackColdDamagePosPct = 1464,
        [Description("Combined Attack Cold Damage +% Final")]
        CombinedAttackColdDamagePosPctFinal = 1465,
        [Description("Combined Spell Fire Damage +%")]
        CombinedSpellFireDamagePosPct = 1466,
        [Description("Combined Spell Fire Damage +% Final")]
        CombinedSpellFireDamagePosPctFinal = 1467,
        [Description("Combined Spell Cold Damage +%")]
        CombinedSpellColdDamagePosPct = 1468,
        [Description("Combined Spell Lightning Damage +%")]
        CombinedSpellLightningDamagePosPct = 1469,
        [Description("Combined Spell Lightning Damage +% Final")]
        CombinedSpellLightningDamagePosPctFinal = 1470,
        [Description("Combined Spell Elemental Damage +%")]
        CombinedSpellElementalDamagePosPct = 1471,
        [Description("Combined Spell Elemental Damage +% Final")]
        CombinedSpellElementalDamagePosPctFinal = 1472,
        [Description("Combined Main Hand Attack Elemental Damage +%")]
        CombinedMainHandAttackElementalDamagePosPct = 1473,
        [Description("Combined Off Hand Attack Elemental Damage +%")]
        CombinedOffHandAttackElementalDamagePosPct = 1474,
        [Description("Combined Main Hand Attack Elemental Damage +% Final")]
        CombinedMainHandAttackElementalDamagePosPctFinal = 1475,
        [Description("Combined Off Hand Attack Elemental Damage +% Final")]
        CombinedOffHandAttackElementalDamagePosPctFinal = 1476,
        [Description("Combined Main Hand Attack Fire Damage +%")]
        CombinedMainHandAttackFireDamagePosPct = 1477,
        [Description("Combined Off Hand Attack Fire Damage +%")]
        CombinedOffHandAttackFireDamagePosPct = 1478,
        [Description("Combined Main Hand Attack Cold Damage +%")]
        CombinedMainHandAttackColdDamagePosPct = 1479,
        [Description("Combined Off Hand Attack Cold Damage +%")]
        CombinedOffHandAttackColdDamagePosPct = 1480,
        [Description("Combined Main Hand Attack Lightning Damage +%")]
        CombinedMainHandAttackLightningDamagePosPct = 1481,
        [Description("Combined Off Hand Attack Lightning Damage +%")]
        CombinedOffHandAttackLightningDamagePosPct = 1482,
        [Description("Combined Main Hand Attack Chaos Damage +%")]
        CombinedMainHandAttackChaosDamagePosPct = 1483,
        [Description("Combined Off Hand Attack Chaos Damage +%")]
        CombinedOffHandAttackChaosDamagePosPct = 1484,
        [Description("Spell Minimum Base Physical Damage")]
        SpellMinimumBasePhysicalDamage = 1485,
        [Description("Spell Maximum Base Physical Damage")]
        SpellMaximumBasePhysicalDamage = 1486,
        [Description("Spell Minimum Base Fire Damage")]
        SpellMinimumBaseFireDamage = 1487,
        [Description("Spell Maximum Base Fire Damage")]
        SpellMaximumBaseFireDamage = 1488,
        [Description("Spell Minimum Base Cold Damage")]
        SpellMinimumBaseColdDamage = 1489,
        [Description("Spell Maximum Base Cold Damage")]
        SpellMaximumBaseColdDamage = 1490,
        [Description("Spell Minimum Base Lightning Damage")]
        SpellMinimumBaseLightningDamage = 1491,
        [Description("Spell Maximum Base Lightning Damage")]
        SpellMaximumBaseLightningDamage = 1492,
        [Description("Spell Minimum Base Chaos Damage")]
        SpellMinimumBaseChaosDamage = 1493,
        [Description("Spell Maximum Base Chaos Damage")]
        SpellMaximumBaseChaosDamage = 1494,
        [Description("Is Projectile")]
        IsProjectile = 1495,
        [Description("Attack Is Melee")]
        AttackIsMelee = 1496,
        [Description("Base Lightning Damage % To Convert To Fire")]
        BaseLightningDamagePctToConvertToFire = 1497,
        [Description("Base Lightning Damage % To Convert To Cold")]
        BaseLightningDamagePctToConvertToCold = 1498,
        [Description("Base Fire Damage % To Convert To Chaos")]
        BaseFireDamagePctToConvertToChaos = 1499,
        [Description("Base Cold Damage % To Convert To Chaos")]
        BaseColdDamagePctToConvertToChaos = 1500,
        [Description("Base Lightning Damage % To Convert To Chaos")]
        BaseLightningDamagePctToConvertToChaos = 1501,
        [Description("Skill Lightning Damage % To Convert To Fire")]
        SkillLightningDamagePctToConvertToFire = 1502,
        [Description("Skill Lightning Damage % To Convert To Cold")]
        SkillLightningDamagePctToConvertToCold = 1503,
        [Description("Skill Fire Damage % To Convert To Chaos")]
        SkillFireDamagePctToConvertToChaos = 1504,
        [Description("Skill Cold Damage % To Convert To Chaos")]
        SkillColdDamagePctToConvertToChaos = 1505,
        [Description("Skill Lightning Damage % To Convert To Chaos")]
        SkillLightningDamagePctToConvertToChaos = 1506,
        [Description("Lightning Damage % To Convert To Fire")]
        LightningDamagePctToConvertToFire = 1507,
        [Description("Lightning Damage % To Convert To Cold")]
        LightningDamagePctToConvertToCold = 1508,
        [Description("Fire Damage % To Convert To Chaos")]
        FireDamagePctToConvertToChaos = 1509,
        [Description("Cold Damage % To Convert To Chaos")]
        ColdDamagePctToConvertToChaos = 1510,
        [Description("Lightning Damage % To Convert To Chaos")]
        LightningDamagePctToConvertToChaos = 1511,
        [Description("Physical Damage % Lost To Conversion")]
        PhysicalDamagePctLostToConversion = 1512,
        [Description("Fire Damage % Lost To Conversion")]
        FireDamagePctLostToConversion = 1513,
        [Description("Cold Damage % Lost To Conversion")]
        ColdDamagePctLostToConversion = 1514,
        [Description("Lightning Damage % Lost To Conversion")]
        LightningDamagePctLostToConversion = 1515,
        [Description("Chaos Damage % Lost To Conversion")]
        ChaosDamagePctLostToConversion = 1516,
        [Description("Fire Damage % To Add As Chaos")]
        FireDamagePctToAddAsChaos = 1517,
        [Description("Cold Damage % To Add As Fire")]
        ColdDamagePctToAddAsFire = 1518,
        [Description("Cold Damage % To Add As Chaos")]
        ColdDamagePctToAddAsChaos = 1519,
        [Description("Lightning Damage % To Add As Fire")]
        LightningDamagePctToAddAsFire = 1520,
        [Description("Lightning Damage % To Add As Cold")]
        LightningDamagePctToAddAsCold = 1521,
        [Description("Lightning Damage % To Add As Chaos")]
        LightningDamagePctToAddAsChaos = 1522,
        [Description("Total Physical Damage % As Fire")]
        TotalPhysicalDamagePctAsFire = 1523,
        [Description("Total Physical Damage % As Cold")]
        TotalPhysicalDamagePctAsCold = 1524,
        [Description("Total Physical Damage % As Lightning")]
        TotalPhysicalDamagePctAsLightning = 1525,
        [Description("Total Physical Damage % As Chaos")]
        TotalPhysicalDamagePctAsChaos = 1526,
        [Description("Total Lightning Damage % As Fire")]
        TotalLightningDamagePctAsFire = 1527,
        [Description("Total Lightning Damage % As Cold")]
        TotalLightningDamagePctAsCold = 1528,
        [Description("Total Lightning Damage % As Chaos")]
        TotalLightningDamagePctAsChaos = 1529,
        [Description("Total Cold Damage % As Fire")]
        TotalColdDamagePctAsFire = 1530,
        [Description("Total Cold Damage % As Chaos")]
        TotalColdDamagePctAsChaos = 1531,
        [Description("Total Fire Damage % As Chaos")]
        TotalFireDamagePctAsChaos = 1532,
        [Description("Secondary Minimum Base Physical Damage")]
        SecondaryMinimumBasePhysicalDamage = 1533,
        [Description("Secondary Maximum Base Physical Damage")]
        SecondaryMaximumBasePhysicalDamage = 1534,
        [Description("Secondary Minimum Base Fire Damage")]
        SecondaryMinimumBaseFireDamage = 1535,
        [Description("Secondary Maximum Base Fire Damage")]
        SecondaryMaximumBaseFireDamage = 1536,
        [Description("Secondary Minimum Base Cold Damage")]
        SecondaryMinimumBaseColdDamage = 1537,
        [Description("Secondary Maximum Base Cold Damage")]
        SecondaryMaximumBaseColdDamage = 1538,
        [Description("Secondary Minimum Base Lightning Damage")]
        SecondaryMinimumBaseLightningDamage = 1539,
        [Description("Secondary Maximum Base Lightning Damage")]
        SecondaryMaximumBaseLightningDamage = 1540,
        [Description("Secondary Minimum Base Chaos Damage")]
        SecondaryMinimumBaseChaosDamage = 1541,
        [Description("Secondary Maximum Base Chaos Damage")]
        SecondaryMaximumBaseChaosDamage = 1542,
        [Description("Spell Total Minimum Base Physical Damage")]
        SpellTotalMinimumBasePhysicalDamage = 1543,
        [Description("Spell Total Maximum Base Physical Damage")]
        SpellTotalMaximumBasePhysicalDamage = 1544,
        [Description("Spell Total Minimum Base Fire Damage")]
        SpellTotalMinimumBaseFireDamage = 1545,
        [Description("Spell Total Maximum Base Fire Damage")]
        SpellTotalMaximumBaseFireDamage = 1546,
        [Description("Spell Total Minimum Base Cold Damage")]
        SpellTotalMinimumBaseColdDamage = 1547,
        [Description("Spell Total Maximum Base Cold Damage")]
        SpellTotalMaximumBaseColdDamage = 1548,
        [Description("Spell Total Minimum Base Lightning Damage")]
        SpellTotalMinimumBaseLightningDamage = 1549,
        [Description("Spell Total Maximum Base Lightning Damage")]
        SpellTotalMaximumBaseLightningDamage = 1550,
        [Description("Spell Total Minimum Base Chaos Damage")]
        SpellTotalMinimumBaseChaosDamage = 1551,
        [Description("Spell Total Maximum Base Chaos Damage")]
        SpellTotalMaximumBaseChaosDamage = 1552,
        [Description("Spell Total Minimum Added Physical Damage")]
        SpellTotalMinimumAddedPhysicalDamage = 1553,
        [Description("Spell Total Maximum Added Physical Damage")]
        SpellTotalMaximumAddedPhysicalDamage = 1554,
        [Description("Spell Total Minimum Added Fire Damage")]
        SpellTotalMinimumAddedFireDamage = 1555,
        [Description("Spell Total Maximum Added Fire Damage")]
        SpellTotalMaximumAddedFireDamage = 1556,
        [Description("Spell Total Minimum Added Cold Damage")]
        SpellTotalMinimumAddedColdDamage = 1557,
        [Description("Spell Total Maximum Added Cold Damage")]
        SpellTotalMaximumAddedColdDamage = 1558,
        [Description("Spell Total Minimum Added Lightning Damage")]
        SpellTotalMinimumAddedLightningDamage = 1559,
        [Description("Spell Total Maximum Added Lightning Damage")]
        SpellTotalMaximumAddedLightningDamage = 1560,
        [Description("Spell Total Minimum Added Chaos Damage")]
        SpellTotalMinimumAddedChaosDamage = 1561,
        [Description("Spell Total Maximum Added Chaos Damage")]
        SpellTotalMaximumAddedChaosDamage = 1562,
        [Description("Main Hand Total Minimum Base Physical Damage")]
        MainHandTotalMinimumBasePhysicalDamage = 1563,
        [Description("Main Hand Total Maximum Base Physical Damage")]
        MainHandTotalMaximumBasePhysicalDamage = 1564,
        [Description("Main Hand Total Minimum Base Fire Damage")]
        MainHandTotalMinimumBaseFireDamage = 1565,
        [Description("Main Hand Total Maximum Base Fire Damage")]
        MainHandTotalMaximumBaseFireDamage = 1566,
        [Description("Main Hand Total Minimum Base Cold Damage")]
        MainHandTotalMinimumBaseColdDamage = 1567,
        [Description("Main Hand Total Maximum Base Cold Damage")]
        MainHandTotalMaximumBaseColdDamage = 1568,
        [Description("Main Hand Total Minimum Base Lightning Damage")]
        MainHandTotalMinimumBaseLightningDamage = 1569,
        [Description("Main Hand Total Maximum Base Lightning Damage")]
        MainHandTotalMaximumBaseLightningDamage = 1570,
        [Description("Main Hand Total Minimum Base Chaos Damage")]
        MainHandTotalMinimumBaseChaosDamage = 1571,
        [Description("Main Hand Total Maximum Base Chaos Damage")]
        MainHandTotalMaximumBaseChaosDamage = 1572,
        [Description("Main Hand Total Minimum Added Physical Damage")]
        MainHandTotalMinimumAddedPhysicalDamage = 1573,
        [Description("Main Hand Total Maximum Added Physical Damage")]
        MainHandTotalMaximumAddedPhysicalDamage = 1574,
        [Description("Main Hand Total Minimum Added Fire Damage")]
        MainHandTotalMinimumAddedFireDamage = 1575,
        [Description("Main Hand Total Maximum Added Fire Damage")]
        MainHandTotalMaximumAddedFireDamage = 1576,
        [Description("Main Hand Total Minimum Added Cold Damage")]
        MainHandTotalMinimumAddedColdDamage = 1577,
        [Description("Main Hand Total Maximum Added Cold Damage")]
        MainHandTotalMaximumAddedColdDamage = 1578,
        [Description("Main Hand Total Minimum Added Lightning Damage")]
        MainHandTotalMinimumAddedLightningDamage = 1579,
        [Description("Main Hand Total Maximum Added Lightning Damage")]
        MainHandTotalMaximumAddedLightningDamage = 1580,
        [Description("Main Hand Total Minimum Added Chaos Damage")]
        MainHandTotalMinimumAddedChaosDamage = 1581,
        [Description("Main Hand Total Maximum Added Chaos Damage")]
        MainHandTotalMaximumAddedChaosDamage = 1582,
        [Description("Off Hand Total Minimum Base Physical Damage")]
        OffHandTotalMinimumBasePhysicalDamage = 1583,
        [Description("Off Hand Total Maximum Base Physical Damage")]
        OffHandTotalMaximumBasePhysicalDamage = 1584,
        [Description("Off Hand Total Minimum Base Fire Damage")]
        OffHandTotalMinimumBaseFireDamage = 1585,
        [Description("Off Hand Total Maximum Base Fire Damage")]
        OffHandTotalMaximumBaseFireDamage = 1586,
        [Description("Off Hand Total Minimum Base Cold Damage")]
        OffHandTotalMinimumBaseColdDamage = 1587,
        [Description("Off Hand Total Maximum Base Cold Damage")]
        OffHandTotalMaximumBaseColdDamage = 1588,
        [Description("Off Hand Total Minimum Base Lightning Damage")]
        OffHandTotalMinimumBaseLightningDamage = 1589,
        [Description("Off Hand Total Maximum Base Lightning Damage")]
        OffHandTotalMaximumBaseLightningDamage = 1590,
        [Description("Off Hand Total Minimum Base Chaos Damage")]
        OffHandTotalMinimumBaseChaosDamage = 1591,
        [Description("Off Hand Total Maximum Base Chaos Damage")]
        OffHandTotalMaximumBaseChaosDamage = 1592,
        [Description("Off Hand Total Minimum Added Physical Damage")]
        OffHandTotalMinimumAddedPhysicalDamage = 1593,
        [Description("Off Hand Total Maximum Added Physical Damage")]
        OffHandTotalMaximumAddedPhysicalDamage = 1594,
        [Description("Off Hand Total Minimum Added Fire Damage")]
        OffHandTotalMinimumAddedFireDamage = 1595,
        [Description("Off Hand Total Maximum Added Fire Damage")]
        OffHandTotalMaximumAddedFireDamage = 1596,
        [Description("Off Hand Total Minimum Added Cold Damage")]
        OffHandTotalMinimumAddedColdDamage = 1597,
        [Description("Off Hand Total Maximum Added Cold Damage")]
        OffHandTotalMaximumAddedColdDamage = 1598,
        [Description("Off Hand Total Minimum Added Lightning Damage")]
        OffHandTotalMinimumAddedLightningDamage = 1599,
        [Description("Off Hand Total Maximum Added Lightning Damage")]
        OffHandTotalMaximumAddedLightningDamage = 1600,
        [Description("Off Hand Total Minimum Added Chaos Damage")]
        OffHandTotalMinimumAddedChaosDamage = 1601,
        [Description("Off Hand Total Maximum Added Chaos Damage")]
        OffHandTotalMaximumAddedChaosDamage = 1602,
        [Description("Spell Minimum Added Physical Damage")]
        SpellMinimumAddedPhysicalDamage = 1603,
        [Description("Spell Maximum Added Physical Damage")]
        SpellMaximumAddedPhysicalDamage = 1604,
        [Description("Spell Minimum Added Fire Damage")]
        SpellMinimumAddedFireDamage = 1605,
        [Description("Spell Maximum Added Fire Damage")]
        SpellMaximumAddedFireDamage = 1606,
        [Description("Spell Minimum Added Cold Damage")]
        SpellMinimumAddedColdDamage = 1607,
        [Description("Spell Maximum Added Cold Damage")]
        SpellMaximumAddedColdDamage = 1608,
        [Description("Spell Minimum Added Lightning Damage")]
        SpellMinimumAddedLightningDamage = 1609,
        [Description("Spell Maximum Added Lightning Damage")]
        SpellMaximumAddedLightningDamage = 1610,
        [Description("Spell Minimum Added Chaos Damage")]
        SpellMinimumAddedChaosDamage = 1611,
        [Description("Spell Maximum Added Chaos Damage")]
        SpellMaximumAddedChaosDamage = 1612,
        [Description("Total Base Life Regeneration Rate Per Minute %")]
        TotalBaseLifeRegenerationRatePerMinutePct = 1613,
        [Description("Total Base Life Regeneration Rate Per Minute")]
        TotalBaseLifeRegenerationRatePerMinute = 1614,
        [Description("Total Base Maximum Energy Shield")]
        TotalBaseMaximumEnergyShield = 1615,
        [Description("Combined Energy Shield +%")]
        CombinedEnergyShieldPosPct = 1616,
        [Description("Combined Energy Shield From Shield +%")]
        CombinedEnergyShieldFromShieldPosPct = 1617,
        [Description("Combined Energy Shield +% Final")]
        CombinedEnergyShieldPosPctFinal = 1618,
        [Description("Total Base Evasion Rating")]
        TotalBaseEvasionRating = 1619,
        [Description("Combined Evasion Rating +%")]
        CombinedEvasionRatingPosPct = 1620,
        [Description("Combined Evasion Rating From Shield +%")]
        CombinedEvasionRatingFromShieldPosPct = 1621,
        [Description("Movement Velocity +1% Per X Evasion Rating")]
        MovementVelocityPos1PctPerXEvasionRating = 1622,
        [Description("Local Display Socketed Gems Have % Chance To Ignite With Fire Damage")]
        LocalDisplaySocketedGemsHavePctChanceToIgniteWithFireDamage = 1623,
        [Description("Cannot Freeze Shock Ignite On Critical")]
        CannotFreezeShockIgniteOnCritical = 1624,
        [Description("No Critical Strike Multiplier")]
        NoCriticalStrikeMultiplier = 1625,
        [Description("Onslaught On Crit Duration Ms")]
        OnslaughtOnCritDurationMs = 1626,
        [Description("Zombie Scale +%")]
        ZombieScalePosPct = 1627,
        [Description("Zombie Physical Damage +%")]
        ZombiePhysicalDamagePosPct = 1628,
        [Description("Faster Burn From Attacks %")]
        FasterBurnFromAttacksPct = 1629,
        [Description("Weapon Elemental Damage +% Per Power Charge")]
        WeaponElementalDamagePosPctPerPowerCharge = 1630,
        [Description("Apply Linked Curses On Hit %")]
        ApplyLinkedCursesOnHitPct = 1631,
        [Description("Cannot Cast Curses")]
        CannotCastCurses = 1632,
        [Description("Spell Damage Modifiers Apply To Attack Damage")]
        SpellDamageModifiersApplyToAttackDamage = 1633,
        [Description("Spell Damage +% From Dexterity")]
        SpellDamagePosPctFromDexterity = 1634,
        [Description("Agile Will")]
        AgileWill = 1635,
        [Description("Old Do Not Use Mana Leech From Physical Damage % Per Power Charge")]
        OldDoNotUseManaLeechFromPhysicalDamagePctPerPowerCharge = 1636,
        [Description("Chaos Damage Can Shock")]
        ChaosDamageCanShock = 1637,
        [Description("Physical Damage Can Chill")]
        PhysicalDamageCanChill = 1638,
        [Description("Killed Monster Dropped Item Quantity +% When Frozen")]
        KilledMonsterDroppedItemQuantityPosPctWhenFrozen = 1639,
        [Description("Killed Monster Dropped Item Rarity +% When Shocked")]
        KilledMonsterDroppedItemRarityPosPctWhenShocked = 1640,
        [Description("Local Flask Removes % Maximum Energy Shield On Use")]
        LocalFlaskRemovesPctMaximumEnergyShieldOnUse = 1641,
        [Description("Local Flask Deals % Maximum Life As Chaos Damage On Use")]
        LocalFlaskDealsPctMaximumLifeAsChaosDamageOnUse = 1642,
        [Description("Local Flask Gain Power Charges On Use")]
        LocalFlaskGainPowerChargesOnUse = 1643,
        [Description("Local Flask Gain Frenzy Charges On Use")]
        LocalFlaskGainFrenzyChargesOnUse = 1644,
        [Description("Local Flask Gain Endurance Charges On Use")]
        LocalFlaskGainEnduranceChargesOnUse = 1645,
        [Description("Deaths Oath Debuff On Kill Duration Ms")]
        DeathsOathDebuffOnKillDurationMs = 1646,
        [Description("Deaths Oath Debuff On Kill Base Chaos Damage To Deal Per Minute")]
        DeathsOathDebuffOnKillBaseChaosDamageToDealPerMinute = 1647,
        [Description("Local Display Aura Base Chaos Damage To Deal Per Minute")]
        LocalDisplayAuraBaseChaosDamageToDealPerMinute = 1648,
        [Description("Blood Footprints From Item")]
        BloodFootprintsFromItem = 1649,
        [Description("Demigod Footprints From Item")]
        DemigodFootprintsFromItem = 1650,
        [Description("Silver Footprints From Item")]
        SilverFootprintsFromItem = 1651,
        [Description("Projectile Homing Type")]
        ProjectileHomingType = 1652,
        [Description("Projectile Homing Range")]
        ProjectileHomingRange = 1653,
        [Description("Map Obas Trial")]
        MapObasTrial = 1654,
        [Description("Display Skill Deals Secondary Damage")]
        DisplaySkillDealsSecondaryDamage = 1655,
        [Description("Secondary Minimum Total Damage")]
        SecondaryMinimumTotalDamage = 1656,
        [Description("Secondary Maximum Total Damage")]
        SecondaryMaximumTotalDamage = 1657,
        [Description("Local Unique Counts As Dual Wielding")]
        LocalUniqueCountsAsDualWielding = 1658,
        [Description("Unique Local Minimum Added Fire Damage When In Main Hand")]
        UniqueLocalMinimumAddedFireDamageWhenInMainHand = 1659,
        [Description("Unique Local Maximum Added Fire Damage When In Main Hand")]
        UniqueLocalMaximumAddedFireDamageWhenInMainHand = 1660,
        [Description("Unique Local Minimum Added Chaos Damage When In Off Hand")]
        UniqueLocalMinimumAddedChaosDamageWhenInOffHand = 1661,
        [Description("Unique Local Maximum Added Chaos Damage When In Off Hand")]
        UniqueLocalMaximumAddedChaosDamageWhenInOffHand = 1662,
        [Description("Unique Local Minimum Added Cold Damage When In Off Hand")]
        UniqueLocalMinimumAddedColdDamageWhenInOffHand = 1663,
        [Description("Unique Local Maximum Added Cold Damage When In Off Hand")]
        UniqueLocalMaximumAddedColdDamageWhenInOffHand = 1664,
        [Description("Map Floor Unlock Time Seconds Unused")]
        MapFloorUnlockTimeSecondsUNUSED = 1665,
        [Description("Map Ignore Rogue Exile Rarity Bias")]
        MapIgnoreRogueExileRarityBias = 1666,
        [Description("Map Override Rogue Exile Min Level")]
        MapOverrideRogueExileMinLevel = 1667,
        [Description("Attack Speed +% Per Frenzy Charge")]
        AttackSpeedPosPctPerFrenzyCharge = 1668,
        [Description("Cast Speed +% Per Frenzy Charge")]
        CastSpeedPosPctPerFrenzyCharge = 1669,
        [Description("Attack And Cast Speed +% Per Frenzy Charge")]
        AttackAndCastSpeedPosPctPerFrenzyCharge = 1670,
        [Description("Converted Original Team")]
        ConvertedOriginalTeam = 1671,
        [Description("Damage +% Vs Enemies On Low Life Per Frenzy Charge")]
        DamagePosPctVsEnemiesOnLowLifePerFrenzyCharge = 1672,
        [Description("Damage +% Per Frenzy Charge")]
        DamagePosPctPerFrenzyCharge = 1673,
        [Description("Damage Removed From Mana Before Life %")]
        DamageRemovedFromManaBeforeLifePct = 1674,
        [Description("Local Display Aura Damage +%")]
        LocalDisplayAuraDamagePosPct = 1675,
        [Description("Attack Ignite Chance %")]
        AttackIgniteChancePct = 1676,
        [Description("Melee Damage +% Vs Frozen Enemies")]
        MeleeDamagePosPctVsFrozenEnemies = 1677,
        [Description("Melee Damage +% Vs Shocked Enemies")]
        MeleeDamagePosPctVsShockedEnemies = 1678,
        [Description("Melee Damage +% Vs Burning Enemies")]
        MeleeDamagePosPctVsBurningEnemies = 1679,
        [Description("Melee Damage Taken % To Deal To Attacker")]
        MeleeDamageTakenPctToDealToAttacker = 1680,
        [Description("Mana Gained When Hit")]
        ManaGainedWhenHit = 1681,
        [Description("Local Display Socketed Gems Get Reduced Mana Cost Level")]
        LocalDisplaySocketedGemsGetReducedManaCostLevel = 1682,
        [Description("Local Display Socketed Gems Get Faster Cast Level")]
        LocalDisplaySocketedGemsGetFasterCastLevel = 1683,
        [Description("Projectile Ignite Chance %")]
        ProjectileIgniteChancePct = 1684,
        [Description("Projectile Freeze Chance %")]
        ProjectileFreezeChancePct = 1685,
        [Description("Projectile Shock Chance %")]
        ProjectileShockChancePct = 1686,
        [Description("Local Off Hand Visual Identity Override Hash")]
        LocalOffHandVisualIdentityOverrideHash = 1687,
        [Description("Elemental Reflect Damage Taken +%")]
        ElementalReflectDamageTakenPosPct = 1688,
        [Description("Physical Reflect Damage Taken +%")]
        PhysicalReflectDamageTakenPosPct = 1689,
        [Description("Local Left Ring Slot Elemental Reflect Damage Taken +%")]
        LocalLeftRingSlotElementalReflectDamageTakenPosPct = 1690,
        [Description("Local Right Ring Slot Physical Reflect Damage Taken +%")]
        LocalRightRingSlotPhysicalReflectDamageTakenPosPct = 1691,
        [Description("Grace Aura Evasion Rating +% Final")]
        GraceAuraEvasionRatingPosPctFinal = 1692,
        [Description("Deal No Attack Damage")]
        DealNoAttackDamage = 1693,
        [Description("Deal No Main Hand Damage")]
        DealNoMainHandDamage = 1694,
        [Description("Deal No Off Hand Damage")]
        DealNoOffHandDamage = 1695,
        [Description("Deal No Spell Damage")]
        DealNoSpellDamage = 1696,
        [Description("Deal No Secondary Damage")]
        DealNoSecondaryDamage = 1697,
        [Description("Deal No Physical Damage")]
        DealNoPhysicalDamage = 1698,
        [Description("Deal No Fire Damage")]
        DealNoFireDamage = 1699,
        [Description("Deal No Cold Damage")]
        DealNoColdDamage = 1700,
        [Description("Deal No Lightning Damage")]
        DealNoLightningDamage = 1701,
        [Description("Deal No Chaos Damage")]
        DealNoChaosDamage = 1702,
        [Description("Deal No Spell Physical Damage")]
        DealNoSpellPhysicalDamage = 1703,
        [Description("Deal No Spell Fire Damage")]
        DealNoSpellFireDamage = 1704,
        [Description("Deal No Spell Cold Damage")]
        DealNoSpellColdDamage = 1705,
        [Description("Deal No Spell Lightning Damage")]
        DealNoSpellLightningDamage = 1706,
        [Description("Deal No Spell Chaos Damage")]
        DealNoSpellChaosDamage = 1707,
        [Description("Deal No Secondary Physical Damage")]
        DealNoSecondaryPhysicalDamage = 1708,
        [Description("Deal No Secondary Fire Damage")]
        DealNoSecondaryFireDamage = 1709,
        [Description("Deal No Secondary Cold Damage")]
        DealNoSecondaryColdDamage = 1710,
        [Description("Deal No Secondary Lightning Damage")]
        DealNoSecondaryLightningDamage = 1711,
        [Description("Deal No Secondary Chaos Damage")]
        DealNoSecondaryChaosDamage = 1712,
        [Description("Deal No Main Hand Physical Damage")]
        DealNoMainHandPhysicalDamage = 1713,
        [Description("Deal No Main Hand Fire Damage")]
        DealNoMainHandFireDamage = 1714,
        [Description("Deal No Main Hand Cold Damage")]
        DealNoMainHandColdDamage = 1715,
        [Description("Deal No Main Hand Lightning Damage")]
        DealNoMainHandLightningDamage = 1716,
        [Description("Deal No Main Hand Chaos Damage")]
        DealNoMainHandChaosDamage = 1717,
        [Description("Deal No Off Hand Physical Damage")]
        DealNoOffHandPhysicalDamage = 1718,
        [Description("Deal No Off Hand Fire Damage")]
        DealNoOffHandFireDamage = 1719,
        [Description("Deal No Off Hand Cold Damage")]
        DealNoOffHandColdDamage = 1720,
        [Description("Deal No Off Hand Lightning Damage")]
        DealNoOffHandLightningDamage = 1721,
        [Description("Deal No Off Hand Chaos Damage")]
        DealNoOffHandChaosDamage = 1722,
        [Description("Base Deal No Main Hand Damage")]
        BaseDealNoMainHandDamage = 1723,
        [Description("Base Deal No Off Hand Damage")]
        BaseDealNoOffHandDamage = 1724,
        [Description("Base Deal No Spell Damage")]
        BaseDealNoSpellDamage = 1725,
        [Description("Base Deal No Secondary Damage")]
        BaseDealNoSecondaryDamage = 1726,
        [Description("Base Deal No Attack Damage")]
        BaseDealNoAttackDamage = 1727,
        [Description("Base Deal No Physical Damage")]
        BaseDealNoPhysicalDamage = 1728,
        [Description("Base Deal No Fire Damage")]
        BaseDealNoFireDamage = 1729,
        [Description("Base Deal No Cold Damage")]
        BaseDealNoColdDamage = 1730,
        [Description("Base Deal No Lightning Damage")]
        BaseDealNoLightningDamage = 1731,
        [Description("Base Deal No Chaos Damage")]
        BaseDealNoChaosDamage = 1732,
        [Description("Local Can Only Deal Damage With This Weapon")]
        LocalCanOnlyDealDamageWithThisWeapon = 1733,
        [Description("Reave Area Of Effect +% Final Per Stage")]
        ReaveAreaOfEffectPosPctFinalPerStage = 1734,
        [Description("Skill Can Add Multiple Charges Per Action")]
        SkillCanAddMultipleChargesPerAction = 1735,
        [Description("Local Charges Used +%")]
        LocalChargesUsedPosPct = 1736,
        [Description("Non Critical Damage Multiplier +%")]
        NonCriticalDamageMultiplierPosPct = 1737,
        [Description("Skill Sound Variation")]
        SkillSoundVariation = 1738,
        [Description("Unique Map Boss Number Of Rare Items To Drop")]
        UniqueMapBossNumberOfRareItemsToDrop = 1739,
        [Description("Unique Map Boss Class Of Rare Items To Drop")]
        UniqueMapBossClassOfRareItemsToDrop = 1740,
        [Description("Base Cold Damage To Deal Per Minute")]
        BaseColdDamageToDealPerMinute = 1741,
        [Description("Number Of Totems Summoned In Formation")]
        NumberOfTotemsSummonedInFormation = 1742,
        [Description("Supported Active Skill Gem Level +")]
        SupportedActiveSkillGemLevelPos = 1743,
        [Description("Shock Art Variation")]
        ShockArtVariation = 1744,
        [Description("Support Multicast Cast Speed +% Final")]
        SupportMulticastCastSpeedPosPctFinal = 1745,
        [Description("Global Attack Speed +% Per Green Socket On Item")]
        GlobalAttackSpeedPosPctPerGreenSocketOnItem = 1746,
        [Description("Global Weapon Physical Damage +% Per Red Socket On Item")]
        GlobalWeaponPhysicalDamagePosPctPerRedSocketOnItem = 1747,
        [Description("Old Do Not Use Global Mana Leech From Physical Attack Damage % Per Blue Socket On Item")]
        OldDoNotUseGlobalManaLeechFromPhysicalAttackDamagePctPerBlueSocketOnItem = 1748,
        [Description("Global Melee Range + Per White Socket On Item")]
        GlobalMeleeRangePosPerWhiteSocketOnItem = 1749,
        [Description("Spell Damage +% Per 5% Block Chance")]
        SpellDamagePosPctPer5PctBlockChance = 1750,
        [Description("Base Life Gained On Spell Hit")]
        BaseLifeGainedOnSpellHit = 1751,
        [Description("Armour % To Leech As Life On Block")]
        ArmourPctToLeechAsLifeOnBlock = 1752,
        [Description("Energy Shield % To Lose On Block")]
        EnergyShieldPctToLoseOnBlock = 1753,
        [Description("Light Radius Scales With Energy Shield")]
        LightRadiusScalesWithEnergyShield = 1754,
        [Description("Fishing Range +%")]
        FishingRangePosPct = 1755,
        [Description("Fishing Line Strength +%")]
        FishingLineStrengthPosPct = 1756,
        [Description("Fish Quantity +%")]
        FishQuantityPosPct = 1757,
        [Description("Fish Rarity +%")]
        FishRarityPosPct = 1758,
        [Description("Fishing Pool Consumption +%")]
        FishingPoolConsumptionPosPct = 1759,
        [Description("Fishing Lure Type")]
        FishingLureType = 1760,
        [Description("Fishing Hook Type")]
        FishingHookType = 1761,
        [Description("Cannot Be Damaged By Things Outside Radius")]
        CannotBeDamagedByThingsOutsideRadius = 1762,
        [Description("Inside Shield")]
        InsideShield = 1763,
        [Description("Flask Effect +%")]
        FlaskEffectPosPct = 1764,
        [Description("Chance To Gain Endurance Charge When Hit %")]
        ChanceToGainEnduranceChargeWhenHitPct = 1765,
        [Description("Lose All Endurance Charges When Reaching Maximum")]
        LoseAllEnduranceChargesWhenReachingMaximum = 1766,
        [Description("Gain Onslaught Ms When Reaching Maximum Endurance Charges")]
        GainOnslaughtMsWhenReachingMaximumEnduranceCharges = 1767,
        [Description("Cannot Gain Endurance Charges While Have Onslaught")]
        CannotGainEnduranceChargesWhileHaveOnslaught = 1768,
        [Description("Has Onslaught")]
        HasOnslaught = 1769,
        [Description("Cannot Gain Endurance Charges")]
        CannotGainEnduranceCharges = 1770,
        [Description("Local Weapon Range +")]
        LocalWeaponRangePos = 1771,
        [Description("Off Hand Weapon Range +")]
        OffHandWeaponRangePos = 1772,
        [Description("Main Hand Weapon Range +")]
        MainHandWeaponRangePos = 1773,
        [Description("Local Has X Sockets")]
        LocalHasXSockets = 1774,
        [Description("Weapon Physical Damage +%")]
        WeaponPhysicalDamagePosPct = 1775,
        [Description("Maximum Critical Strike Chance")]
        MaximumCriticalStrikeChance = 1776,
        [Description("Chilled Monsters Take +% Burning Damage")]
        ChilledMonstersTakePosPctBurningDamage = 1777,
        [Description("Unique Ignite Chance % When In Main Hand")]
        UniqueIgniteChancePctWhenInMainHand = 1778,
        [Description("Unique Chill Duration +% When In Off Hand")]
        UniqueChillDurationPosPctWhenInOffHand = 1779,
        [Description("Curse On Melee Block Level X Punishment")]
        CurseOnMeleeBlockLevelXPunishment = 1780,
        [Description("Curse On Projectile Block Level X Temporal Chains")]
        CurseOnProjectileBlockLevelXTemporalChains = 1781,
        [Description("Curse On Spell Block Level X Elemental Weakness")]
        CurseOnSpellBlockLevelXElementalWeakness = 1782,
        [Description("Local Display Socketed Gems Get Item Quantity +%")]
        LocalDisplaySocketedGemsGetItemQuantityPosPct = 1783,
        [Description("Local Display Socketed Gems Get Iron Will Level")]
        LocalDisplaySocketedGemsGetIronWillLevel = 1784,
        [Description("Gain Onslaught On Stun Duration Ms")]
        GainOnslaughtOnStunDurationMs = 1785,
        [Description("Cast Linked Spells On Attack Hit %")]
        CastLinkedSpellsOnAttackHitPct = 1786,
        [Description("Spectres Have Aura Cast Attack Move Speed +%")]
        SpectresHaveAuraCastAttackMoveSpeedPosPct = 1787,
        [Description("Physical Damage Reduction Rating Per Level")]
        PhysicalDamageReductionRatingPerLevel = 1788,
        [Description("Maximum Life Per 10 Levels")]
        MaximumLifePer10Levels = 1789,
        [Description("Resist All Elements % Per 10 Levels")]
        ResistAllElementsPctPer10Levels = 1790,
        [Description("Chance To Gain Random Curse When Hit % Per 10 Levels")]
        ChanceToGainRandomCurseWhenHitPctPer10Levels = 1791,
        [Description("Chance To Gain Random Curse When Hit %")]
        ChanceToGainRandomCurseWhenHitPct = 1792,
        [Description("Curse On Hit % Flammability")]
        CurseOnHitPctFlammability = 1793,
        [Description("Support Trap Damage +% Final")]
        SupportTrapDamagePosPctFinal = 1794,
        [Description("Number Of Additional Traps To Throw")]
        NumberOfAdditionalTrapsToThrow = 1795,
        [Description("Number Of Traps To Throw")]
        NumberOfTrapsToThrow = 1796,
        [Description("Projectiles Nova")]
        ProjectilesNova = 1797,
        [Description("Support Multithrow Damage +% Final")]
        SupportMultithrowDamagePosPctFinal = 1798,
        [Description("Suppressing Fire Debuff Cast Speed +% Final")]
        SuppressingFireDebuffCastSpeedPosPctFinal = 1799,
        [Description("Suppressing Fire Debuff Non Melee Attack Speed +% Final")]
        SuppressingFireDebuffNonMeleeAttackSpeedPosPctFinal = 1800,
        [Description("Cast On Death %")]
        CastOnDeathPct = 1801,
        [Description("Accuracy Rating +% Per Frenzy Charge")]
        AccuracyRatingPosPctPerFrenzyCharge = 1802,
        [Description("Base Skill Is Trapped")]
        BaseSkillIsTrapped = 1803,
        [Description("Base Skill Is Mined")]
        BaseSkillIsMined = 1804,
        [Description("Base Skill Is Totemified")]
        BaseSkillIsTotemified = 1805,
        [Description("Trap Damage +%")]
        TrapDamagePosPct = 1806,
        [Description("Totem Damage +%")]
        TotemDamagePosPct = 1807,
        [Description("Mine Damage +%")]
        MineDamagePosPct = 1808,
        [Description("Monster Reverse Point Blank Damage -% At Minimum Range")]
        MonsterReversePointBlankDamageNegPctAtMinimumRange = 1809,
        [Description("Frenzy Charge Duration +% Per Frenzy Charge")]
        FrenzyChargeDurationPosPctPerFrenzyCharge = 1810,
        [Description("Virtual Frenzy Charge Duration +%")]
        VirtualFrenzyChargeDurationPosPct = 1811,
        [Description("Attacks Poison While At Max Frenzy Charges")]
        AttacksPoisonWhileAtMaxFrenzyCharges = 1812,
        [Description("Attacks Poison")]
        AttacksPoison = 1813,
        [Description("Gain Endurance Charge On Melee Stun")]
        GainEnduranceChargeOnMeleeStun = 1814,
        [Description("Damage Taken +% Vs Demons")]
        DamageTakenPosPctVsDemons = 1815,
        [Description("Damage +% Vs Demons")]
        DamagePosPctVsDemons = 1816,
        [Description("Local Recharge On Demon Killed")]
        LocalRechargeOnDemonKilled = 1817,
        [Description("Local Unique Flask Damage Taken +% Vs Demons While Healing")]
        LocalUniqueFlaskDamageTakenPosPctVsDemonsWhileHealing = 1818,
        [Description("Local Unique Flask Damage +% Vs Demons While Healing")]
        LocalUniqueFlaskDamagePosPctVsDemonsWhileHealing = 1819,
        [Description("Chance To Apply Suppression On Hit %")]
        ChanceToApplySuppressionOnHitPct = 1820,
        [Description("Is Frozen")]
        IsFrozen = 1821,
        [Description("Is Chilled")]
        IsChilled = 1822,
        [Description("Is Ignited")]
        IsIgnited = 1823,
        [Description("Curses Reflected To Self")]
        CursesReflectedToSelf = 1824,
        [Description("Movement Speed Bonus When Throwing Trap Ms")]
        MovementSpeedBonusWhenThrowingTrapMs = 1825,
        [Description("Local Display Socketed Gems Get Trap Level")]
        LocalDisplaySocketedGemsGetTrapLevel = 1826,
        [Description("Poison On Melee Critical Strike %")]
        PoisonOnMeleeCriticalStrikePct = 1827,
        [Description("Shocks Reflected To Self")]
        ShocksReflectedToSelf = 1828,
        [Description("Damage +% Per Shock")]
        DamagePosPctPerShock = 1829,
        [Description("Movement Velocity +% Per Shock")]
        MovementVelocityPosPctPerShock = 1830,
        [Description("Damage +1% Per X Strength")]
        DamagePos1PctPerXStrength = 1831,
        [Description("Physical Damage Reduction Rating +1% Per X Strength")]
        PhysicalDamageReductionRatingPos1PctPerXStrength = 1832,
        [Description("Damage +1% Per X Strength When In Main Hand")]
        DamagePos1PctPerXStrengthWhenInMainHand = 1833,
        [Description("Physical Damage Reduction Rating +1% Per X Strength When In Off Hand")]
        PhysicalDamageReductionRatingPos1PctPerXStrengthWhenInOffHand = 1834,
        [Description("Local Display Socketed Gems Get Curse Reflection")]
        LocalDisplaySocketedGemsGetCurseReflection = 1835,
        [Description("Freeze Mine Cold Resistance + While Frozen")]
        FreezeMineColdResistancePosWhileFrozen = 1836,
        [Description("Max Corrupted Blood Stacks")]
        MaxCorruptedBloodStacks = 1837,
        [Description("Current Corrupted Blood Stacks")]
        CurrentCorruptedBloodStacks = 1838,
        [Description("Physical Damage Taken Per Minute")]
        PhysicalDamageTakenPerMinute = 1839,
        [Description("Base Physical Damage Taken Per Minute Per Corrupted Blood Stack")]
        BasePhysicalDamageTakenPerMinutePerCorruptedBloodStack = 1840,
        [Description("Firestorm Drop Burning Ground Duration Ms")]
        FirestormDropBurningGroundDurationMs = 1841,
        [Description("Firestorm Base Area Of Effect +%")]
        FirestormBaseAreaOfEffectPosPct = 1842,
        [Description("Mine Duration +%")]
        MineDurationPosPct = 1843,
        [Description("Display Monster Spike Nova On Death Text")]
        DisplayMonsterSpikeNovaOnDeathText = 1844,
        [Description("Display Monster Ice Spear Nova On Death Text")]
        DisplayMonsterIceSpearNovaOnDeathText = 1845,
        [Description("Skill Unusable")]
        SkillUnusable = 1846,
        [Description("Cast Linked Spells On Attack Crit %")]
        CastLinkedSpellsOnAttackCritPct = 1847,
        [Description("Cast Linked Spells On Melee Kill %")]
        CastLinkedSpellsOnMeleeKillPct = 1848,
        [Description("Spell Uncastable If Triggerable")]
        SpellUncastableIfTriggerable = 1849,
        [Description("Mine Detonation Is Instant")]
        MineDetonationIsInstant = 1850,
        [Description("Trap Damage Penetrates % Elemental Resistance")]
        TrapDamagePenetratesPctElementalResistance = 1851,
        [Description("Mine Damage Penetrates % Elemental Resistance")]
        MineDamagePenetratesPctElementalResistance = 1852,
        [Description("Traps Invulnerable For Duration Ms")]
        TrapsInvulnerableForDurationMs = 1853,
        [Description("Mines Invulnerable For Duration Ms")]
        MinesInvulnerableForDurationMs = 1854,
        [Description("Totem Elemental Resistance %")]
        TotemElementalResistancePct = 1855,
        [Description("Totem Additional Physical Damage Reduction %")]
        TotemAdditionalPhysicalDamageReductionPct = 1856,
        [Description("Mine Detonation Radius +%")]
        MineDetonationRadiusPosPct = 1857,
        [Description("Totem Skill Cast Speed +%")]
        TotemSkillCastSpeedPosPct = 1858,
        [Description("Totem Skill Attack Speed +%")]
        TotemSkillAttackSpeedPosPct = 1859,
        [Description("Mine Laying Speed +%")]
        MineLayingSpeedPosPct = 1860,
        [Description("Cyclone Places Ground Ice")]
        CyclonePlacesGroundIce = 1861,
        [Description("Leap Slam Base Ground Fire Damage To Deal Per Minute")]
        LeapSlamBaseGroundFireDamageToDealPerMinute = 1862,
        [Description("Projectiles Return If No Hit Object")]
        ProjectilesReturnIfNoHitObject = 1863,
        [Description("Cast On Stunned %")]
        CastOnStunnedPct = 1864,
        [Description("Cast On Damage Taken %")]
        CastOnDamageTakenPct = 1865,
        [Description("Cast On Damage Taken Threshold")]
        CastOnDamageTakenThreshold = 1866,
        [Description("Deal No Non Fire Damage")]
        DealNoNonFireDamage = 1867,
        [Description("Ice Nova Places Ground Ice")]
        IceNovaPlacesGroundIce = 1868,
        [Description("Shock Nova Places X Ground Lightning Patches")]
        ShockNovaPlacesXGroundLightningPatches = 1869,
        [Description("Ignores Proximity Shield")]
        IgnoresProximityShield = 1870,
        [Description("Emerge Speed +%")]
        EmergeSpeedPosPct = 1871,
        [Description("Animated Armour Replace Off Hand Weapon")]
        AnimatedArmourReplaceOffHandWeapon = 1872,
        [Description("Map No Exiles")]
        MapNoExiles = 1873,
        [Description("Animate Item Maximum Level Requirement")]
        AnimateItemMaximumLevelRequirement = 1874,
        [Description("Phase Through Objects")]
        PhaseThroughObjects = 1875,
        [Description("Delete On Death")]
        DeleteOnDeath = 1876,
        [Description("Corpse Consumption Mana To Gain")]
        CorpseConsumptionManaToGain = 1877,
        [Description("Fixed Projectile Spread")]
        FixedProjectileSpread = 1878,
        [Description("Fire And Cold Damage Resistance %")]
        FireAndColdDamageResistancePct = 1879,
        [Description("Fire And Lightning Damage Resistance %")]
        FireAndLightningDamageResistancePct = 1880,
        [Description("Cold And Lightning Damage Resistance %")]
        ColdAndLightningDamageResistancePct = 1881,
        [Description("Display Monster Mod Nemesis Test")]
        DisplayMonsterModNemesisTest = 1882,
        [Description("Base Damage Not From Skill User")]
        BaseDamageNotFromSkillUser = 1883,
        [Description("Map Rare Monsters Have Nemesis Mod")]
        MapRareMonstersHaveNemesisMod = 1884,
        [Description("Display Monster Has Firestorm Daemon")]
        DisplayMonsterHasFirestormDaemon = 1885,
        [Description("Monster Raises After Death")]
        MonsterRaisesAfterDeath = 1886,
        [Description("Display Monster Is Apparition")]
        DisplayMonsterIsApparition = 1887,
        [Description("Monster Spawns X Monsters On Death")]
        MonsterSpawnsXMonstersOnDeath = 1888,
        [Description("Damage +% While Ignited")]
        DamagePosPctWhileIgnited = 1889,
        [Description("Physical Damage Reduction Rating While Frozen")]
        PhysicalDamageReductionRatingWhileFrozen = 1890,
        [Description("Old Do Not Use Mana Leech % Vs Shocked Enemies")]
        OldDoNotUseManaLeechPctVsShockedEnemies = 1891,
        [Description("Old Do Not Use Life Leech % Vs Frozen Enemies")]
        OldDoNotUseLifeLeechPctVsFrozenEnemies = 1892,
        [Description("Damage +% Vs Rare Monsters")]
        DamagePosPctVsRareMonsters = 1893,
        [Description("Damage +% Vs Enemies Per Freeze Shock Ignite")]
        DamagePosPctVsEnemiesPerFreezeShockIgnite = 1894,
        [Description("Chance To Freeze Shock Ignite %")]
        ChanceToFreezeShockIgnitePct = 1895,
        [Description("Shrine Buff Effect On Self +%")]
        ShrineBuffEffectOnSelfPosPct = 1896,
        [Description("Shrine Effect Duration +%")]
        ShrineEffectDurationPosPct = 1897,
        [Description("Local Unique Flask Cannot Recover Life While Healing")]
        LocalUniqueFlaskCannotRecoverLifeWhileHealing = 1898,
        [Description("Local Unique Flask Recover % Maximum Life When Effect Reaches Duration")]
        LocalUniqueFlaskRecoverPctMaximumLifeWhenEffectReachesDuration = 1899,
        [Description("Local Unique Flask No Mana Cost While Healing")]
        LocalUniqueFlaskNoManaCostWhileHealing = 1900,
        [Description("Shock X Nearby Enemies For 2 S On Killing Shocked Enemy")]
        ShockXNearbyEnemiesFor2SOnKillingShockedEnemy = 1901,
        [Description("Ignite X Nearby Enemies For 4 S On Killing Ignited Enemy")]
        IgniteXNearbyEnemiesFor4SOnKillingIgnitedEnemy = 1902,
        [Description("Chance To Ignite %")]
        ChanceToIgnitePct = 1903,
        [Description("Chance To Shock %")]
        ChanceToShockPct = 1904,
        [Description("Chance To Freeze %")]
        ChanceToFreezePct = 1905,
        [Description("Echoing Shrine Cast Speed +% Final")]
        EchoingShrineCastSpeedPosPctFinal = 1906,
        [Description("Echoing Shrine Attack Speed +% Final")]
        EchoingShrineAttackSpeedPosPctFinal = 1907,
        [Description("Display Monster Has Proximity Shield Daemon")]
        DisplayMonsterHasProximityShieldDaemon = 1908,
        [Description("Display Monster Has Summon Skeletons Daemon")]
        DisplayMonsterHasSummonSkeletonsDaemon = 1909,
        [Description("Display Monster Has Smoke Mine Daemon")]
        DisplayMonsterHasSmokeMineDaemon = 1910,
        [Description("Monster Drop Additional Unique Items")]
        MonsterDropAdditionalUniqueItems = 1911,
        [Description("Base Corrupt Blood When Hit % Average Damage To Deal Per Minute Per Stack")]
        BaseCorruptBloodWhenHitPctAverageDamageToDealPerMinutePerStack = 1912,
        [Description("Cannot Recover Life")]
        CannotRecoverLife = 1913,
        [Description("Recover % Maximum Life When Buff Reaches Duration")]
        RecoverPctMaximumLifeWhenBuffReachesDuration = 1914,
        [Description("No Mana Cost")]
        NoManaCost = 1915,
        [Description("Gain Rare Monster Mods On Kill Ms")]
        GainRareMonsterModsOnKillMs = 1916,
        [Description("Corpse Cannot Be Destroyed")]
        CorpseCannotBeDestroyed = 1917,
        [Description("Cannot Be Dominated")]
        CannotBeDominated = 1918,
        [Description("Lightning Warp Shocked Ground Duration Ms")]
        LightningWarpShockedGroundDurationMs = 1919,
        [Description("Physical Damage % To Add As Random Element")]
        PhysicalDamagePctToAddAsRandomElement = 1920,
        [Description("Always Cause Elemental Status Ailment")]
        AlwaysCauseElementalStatusAilment = 1921,
        [Description("Reflect Projectiles At Owner")]
        ReflectProjectilesAtOwner = 1922,
        [Description("Base Righteous Fire % Of Max Energy Shield To Deal To Nearby Per Minute")]
        BaseRighteousFirePctOfMaxEnergyShieldToDealToNearbyPerMinute = 1923,
        [Description("Base Nonlethal Fire Damage % Of Maximum Energy Shield Taken Per Minute")]
        BaseNonlethalFireDamagePctOfMaximumEnergyShieldTakenPerMinute = 1924,
        [Description("Nemesis Transform On Low Life")]
        NemesisTransformOnLowLife = 1925,
        [Description("Attack And Cast Speed +%")]
        AttackAndCastSpeedPosPct = 1926,
        [Description("Cleave Damage +% Final While Dual Wielding")]
        CleaveDamagePosPctFinalWhileDualWielding = 1927,
        [Description("Monster Level Scale Maximum Mana And Mana Cost +% Final")]
        MonsterLevelScaleMaximumManaAndManaCostPosPctFinal = 1928,
        [Description("Grant Actor Scale +% To Aura Owner On Death")]
        GrantActorScalePosPctToAuraOwnerOnDeath = 1929,
        [Description("Grant Attack Speed +% To Aura Owner On Death")]
        GrantAttackSpeedPosPctToAuraOwnerOnDeath = 1930,
        [Description("Grant Cast Speed +% To Aura Owner On Death")]
        GrantCastSpeedPosPctToAuraOwnerOnDeath = 1931,
        [Description("Grant Damage Reduction % To Aura Owner On Death")]
        GrantDamageReductionPctToAuraOwnerOnDeath = 1932,
        [Description("Random Curse On Hit %")]
        RandomCurseOnHitPct = 1933,
        [Description("Random Curses Include Silence")]
        RandomCursesIncludeSilence = 1934,
        [Description("Is Twinned Unique Boss")]
        IsTwinnedUniqueBoss = 1935,
        [Description("Remove Flask Effects On Hit %")]
        RemoveFlaskEffectsOnHitPct = 1936,
        [Description("Remove Charges On Hit %")]
        RemoveChargesOnHitPct = 1937,
        [Description("Monster Casts Arctic Breath Text")]
        MonsterCastsArcticBreathText = 1938,
        [Description("Cast On Death Damage +% Final While Dead")]
        CastOnDeathDamagePosPctFinalWhileDead = 1939,
        [Description("Cast On Damage Taken Damage +% Final")]
        CastOnDamageTakenDamagePosPctFinal = 1940,
        [Description("Life Gained On Spell Hit")]
        LifeGainedOnSpellHit = 1941,
        [Description("Base Attacks Poison")]
        BaseAttacksPoison = 1942,
        [Description("Active Skill Attack Speed +% Final")]
        ActiveSkillAttackSpeedPosPctFinal = 1943,
        [Description("Infinite Skill Effect Duration")]
        InfiniteSkillEffectDuration = 1944,
        [Description("Physical Damage Reduction Rating +% While Not Ignited Frozen Shocked")]
        PhysicalDamageReductionRatingPosPctWhileNotIgnitedFrozenShocked = 1945,
        [Description("Max Corrupted Blood Rain Stacks")]
        MaxCorruptedBloodRainStacks = 1946,
        [Description("Current Corrupted Blood Rain Stacks")]
        CurrentCorruptedBloodRainStacks = 1947,
        [Description("Base Physical Damage Taken Per Minute Per Corrupted Blood Rain Stack")]
        BasePhysicalDamageTakenPerMinutePerCorruptedBloodRainStack = 1948,
        [Description("Base Damage Removed From Mana Before Life %")]
        BaseDamageRemovedFromManaBeforeLifePct = 1949,
        [Description("Keystone Mana Shield")]
        KeystoneManaShield = 1950,
        [Description("Actor Scale +%")]
        ActorScalePosPct = 1951,
        [Description("Capped Actor Scale +%")]
        CappedActorScalePosPct = 1952,
        [Description("Cannot Stun")]
        CannotStun = 1953,
        [Description("Is Daemon")]
        IsDaemon = 1954,
        [Description("Disable Light")]
        DisableLight = 1955,
        [Description("Base Chance To Dodge %")]
        BaseChanceToDodgePct = 1956,
        [Description("Base Chance To Dodge Spells %")]
        BaseChanceToDodgeSpellsPct = 1957,
        [Description("Map Allow Shrines")]
        MapAllowShrines = 1958,
        [Description("Aura Effect +%")]
        AuraEffectPosPct = 1959,
        [Description("Display Monster Uses Far Shot Text")]
        DisplayMonsterUsesFarShotText = 1960,
        [Description("Monster Additional Rarity Of Dropped Items In Merciless +%")]
        MonsterAdditionalRarityOfDroppedItemsInMercilessPosPct = 1961,
        [Description("Monster Additional Quantity Of Dropped Items In Merciless +%")]
        MonsterAdditionalQuantityOfDroppedItemsInMercilessPosPct = 1962,
        [Description("Mortal Conviction Mana Reservation +% Final")]
        MortalConvictionManaReservationPosPctFinal = 1963,
        [Description("Mana Reservation +%")]
        ManaReservationPosPct = 1964,
        [Description("Additional Player Bonus Maximum Energy Shield +% Final")]
        AdditionalPlayerBonusMaximumEnergyShieldPosPctFinal = 1965,
        [Description("Additional Player Bonus Monster Slain Flask Charges Granted +% Final")]
        AdditionalPlayerBonusMonsterSlainFlaskChargesGrantedPosPctFinal = 1966,
        [Description("Display Monster Uses Suppressing Fire Text")]
        DisplayMonsterUsesSuppressingFireText = 1967,
        [Description("Display Monster Casts Devouring Totem Skill Text")]
        DisplayMonsterCastsDevouringTotemSkillText = 1968,
        [Description("Monster Additional Quantity Of Dropped Items In Cruel +%")]
        MonsterAdditionalQuantityOfDroppedItemsInCruelPosPct = 1969,
        [Description("Monster Additional Rarity Of Dropped Items In Cruel +%")]
        MonsterAdditionalRarityOfDroppedItemsInCruelPosPct = 1970,
        [Description("Supported Active Skill Gem Quality %")]
        SupportedActiveSkillGemQualityPct = 1971,
        [Description("Map Rarity")]
        MapRarity = 1972,
        [Description("Animate Guardian Last Known Life")]
        AnimateGuardianLastKnownLife = 1973,
        [Description("Spell Only Castable On Death")]
        SpellOnlyCastableOnDeath = 1974,
        [Description("Local Support Gem Max Skill Level Requirement To Support")]
        LocalSupportGemMaxSkillLevelRequirementToSupport = 1975,
        [Description("Display Monster Casts Lightning Nova Text")]
        DisplayMonsterCastsLightningNovaText = 1976,
        [Description("Physical Damage To Deal Per Minute")]
        PhysicalDamageToDealPerMinute = 1977,
        [Description("Base Physical Damage To Deal Per Minute")]
        BasePhysicalDamageToDealPerMinute = 1978,
        [Description("Fire Damage To Deal Per Minute")]
        FireDamageToDealPerMinute = 1979,
        [Description("Cold Damage To Deal Per Minute")]
        ColdDamageToDealPerMinute = 1980,
        [Description("Lightning Damage To Deal Per Minute")]
        LightningDamageToDealPerMinute = 1981,
        [Description("Base Lightning Damage To Deal Per Minute")]
        BaseLightningDamageToDealPerMinute = 1982,
        [Description("Chaos Damage To Deal Per Minute")]
        ChaosDamageToDealPerMinute = 1983,
        [Description("Base Chaos Damage To Deal Per Minute")]
        BaseChaosDamageToDealPerMinute = 1984,
        [Description("Base Chaos Damage % Of Maximum Life To Deal Per Minute")]
        BaseChaosDamagePctOfMaximumLifeToDealPerMinute = 1985,
        [Description("Base Chaos Damage Taken Per Minute Per Viper Strike Orb")]
        BaseChaosDamageTakenPerMinutePerViperStrikeOrb = 1986,
        [Description("Combined All Damage Over Time +%")]
        CombinedAllDamageOverTimePosPct = 1987,
        [Description("Combined All Damage Over Time +% Final")]
        CombinedAllDamageOverTimePosPctFinal = 1988,
        [Description("Combined Physical Damage Over Time +%")]
        CombinedPhysicalDamageOverTimePosPct = 1989,
        [Description("Combined Physical Damage Over Time +% Final")]
        CombinedPhysicalDamageOverTimePosPctFinal = 1990,
        [Description("Combined Elemental Damage Over Time +%")]
        CombinedElementalDamageOverTimePosPct = 1991,
        [Description("Combined Elemental Damage Over Time +% Final")]
        CombinedElementalDamageOverTimePosPctFinal = 1992,
        [Description("Combined Fire Damage Over Time +%")]
        CombinedFireDamageOverTimePosPct = 1993,
        [Description("Combined Fire Damage Over Time +% Final")]
        CombinedFireDamageOverTimePosPctFinal = 1994,
        [Description("Combined Cold Damage Over Time +%")]
        CombinedColdDamageOverTimePosPct = 1995,
        [Description("Combined Cold Damage Over Time +% Final")]
        CombinedColdDamageOverTimePosPctFinal = 1996,
        [Description("Combined Lightning Damage Over Time +%")]
        CombinedLightningDamageOverTimePosPct = 1997,
        [Description("Combined Lightning Damage Over Time +% Final")]
        CombinedLightningDamageOverTimePosPctFinal = 1998,
        [Description("Combined Chaos Damage Over Time +%")]
        CombinedChaosDamageOverTimePosPct = 1999,
        [Description("Combined Chaos Damage Over Time +% Final")]
        CombinedChaosDamageOverTimePosPctFinal = 2000,
        [Description("Damage Over Time +%")]
        DamageOverTimePosPct = 2001,
        [Description("Fire Damage Taken Per Minute")]
        FireDamageTakenPerMinute = 2002,
        [Description("Base Fire Damage Taken Per Minute")]
        BaseFireDamageTakenPerMinute = 2003,
        [Description("Cold Damage Taken Per Minute")]
        ColdDamageTakenPerMinute = 2004,
        [Description("Base Cold Damage Taken Per Minute")]
        BaseColdDamageTakenPerMinute = 2005,
        [Description("Lightning Damage Taken Per Minute")]
        LightningDamageTakenPerMinute = 2006,
        [Description("Base Lightning Damage Taken Per Minute")]
        BaseLightningDamageTakenPerMinute = 2007,
        [Description("Deal No Damage Over Time")]
        DealNoDamageOverTime = 2008,
        [Description("Base Deal No Damage Over Time")]
        BaseDealNoDamageOverTime = 2009,
        [Description("Deal No Physical Damage Over Time")]
        DealNoPhysicalDamageOverTime = 2010,
        [Description("Deal No Fire Damage Over Time")]
        DealNoFireDamageOverTime = 2011,
        [Description("Deal No Cold Damage Over Time")]
        DealNoColdDamageOverTime = 2012,
        [Description("Deal No Lightning Damage Over Time")]
        DealNoLightningDamageOverTime = 2013,
        [Description("Deal No Chaos Damage Over Time")]
        DealNoChaosDamageOverTime = 2014,
        [Description("Unique Critical Strike Chance +% Final")]
        UniqueCriticalStrikeChancePosPctFinal = 2015,
        [Description("Map Ground Lightning")]
        MapGroundLightning = 2016,
        [Description("Add Endurance Charge On Kill")]
        AddEnduranceChargeOnKill = 2017,
        [Description("Unique Lose All Endurance Charges When Hit")]
        UniqueLoseAllEnduranceChargesWhenHit = 2018,
        [Description("Unique Gain Onslaught When Hit Duration Ms")]
        UniqueGainOnslaughtWhenHitDurationMs = 2019,
        [Description("Chance To Counter Strike When Hit %")]
        ChanceToCounterStrikeWhenHitPct = 2020,
        [Description("Hundred Times Average Damage Per Hit")]
        HundredTimesAverageDamagePerHit = 2021,
        [Description("Hundred Times Average Damage Per Skill Use")]
        HundredTimesAverageDamagePerSkillUse = 2022,
        [Description("Base Skill Show Average Damage Instead Of Dps")]
        BaseSkillShowAverageDamageInsteadOfDps = 2023,
        [Description("Display Hundred Times Damage Per Skill Use")]
        DisplayHundredTimesDamagePerSkillUse = 2024,
        [Description("Base Monster Will Be Deleted On Death")]
        BaseMonsterWillBeDeletedOnDeath = 2025,
        [Description("Monster Will Be Deleted On Death")]
        MonsterWillBeDeletedOnDeath = 2026,
        [Description("Charged Blast Spell Damage +% Final Per Stack")]
        ChargedBlastSpellDamagePosPctFinalPerStack = 2027,
        [Description("From Code Active Skill Spell Damage +% Final")]
        FromCodeActiveSkillSpellDamagePosPctFinal = 2028,
        [Description("Leech X Life Per Spell Cast")]
        LeechXLifePerSpellCast = 2029,
        [Description("Zero Elemental Resistance")]
        ZeroElementalResistance = 2030,
        [Description("Global Defences +%")]
        GlobalDefencesPosPct = 2031,
        [Description("Minimum Lightning Damage To Return On Block")]
        MinimumLightningDamageToReturnOnBlock = 2032,
        [Description("Maximum Lightning Damage To Return On Block")]
        MaximumLightningDamageToReturnOnBlock = 2033,
        [Description("Leap Slam Spawn X Zombies On Impact")]
        LeapSlamSpawnXZombiesOnImpact = 2034,
        [Description("Culling Strike On Burning Enemies")]
        CullingStrikeOnBurningEnemies = 2035,
        [Description("Gain Frenzy Charge If Attack Ignites")]
        GainFrenzyChargeIfAttackIgnites = 2036,
        [Description("Map Monsters Are Immune To Curses")]
        MapMonstersAreImmuneToCurses = 2037,
        [Description("Map Packs Are Animals")]
        MapPacksAreAnimals = 2038,
        [Description("Map Packs Are Demons")]
        MapPacksAreDemons = 2039,
        [Description("Map Packs Are Humanoids")]
        MapPacksAreHumanoids = 2040,
        [Description("Monster Drop Higher Level Gear")]
        MonsterDropHigherLevelGear = 2041,
        [Description("Regenerate X Life Over 1 Second On Cast")]
        RegenerateXLifeOver1SecondOnCast = 2042,
        [Description("Map Monsters Gain X Power Charges Every 20 Seconds")]
        MapMonstersGainXPowerChargesEvery20Seconds = 2043,
        [Description("Map Monsters Gain X Endurance Charges Every 20 Seconds")]
        MapMonstersGainXEnduranceChargesEvery20Seconds = 2044,
        [Description("Damage +% Per 10 Levels")]
        DamagePosPctPer10Levels = 2045,
        [Description("Monster Caustic Cloud On Death % Max Damage To Deal Per Minute")]
        MonsterCausticCloudOnDeathPctMaxDamageToDealPerMinute = 2046,
        [Description("Monster Caustic Cloud On Death Base Area Of Effect Radius")]
        MonsterCausticCloudOnDeathBaseAreaOfEffectRadius = 2047,
        [Description("Monster Caustic Cloud On Death Duration Ms")]
        MonsterCausticCloudOnDeathDurationMs = 2048,
        [Description("Chaos Damage Taken +")]
        ChaosDamageTakenPos = 2049,
        [Description("Local Socketed Curse Gem Level +")]
        LocalSocketedCurseGemLevelPos = 2050,
        [Description("Base Curse Duration +%")]
        BaseCurseDurationPosPct = 2051,
        [Description("Curse Duration +%")]
        CurseDurationPosPct = 2052,
        [Description("Curse Effect Duration")]
        CurseEffectDuration = 2053,
        [Description("Self Curse Duration +%")]
        SelfCurseDurationPosPct = 2054,
        [Description("Local Display Socketed Gems Get Flee Level")]
        LocalDisplaySocketedGemsGetFleeLevel = 2055,
        [Description("Dexterity +%")]
        DexterityPosPct = 2056,
        [Description("Strength +%")]
        StrengthPosPct = 2057,
        [Description("Intelligence +%")]
        IntelligencePosPct = 2058,
        [Description("Display Map Final Boss Drops Higher Level Gear")]
        DisplayMapFinalBossDropsHigherLevelGear = 2059,
        [Description("Chaos Resistance + While Using Flask")]
        ChaosResistancePosWhileUsingFlask = 2060,
        [Description("Minimum Physical Damage To Reflect To Self On Attack")]
        MinimumPhysicalDamageToReflectToSelfOnAttack = 2061,
        [Description("Maximum Physical Damage To Reflect To Self On Attack")]
        MaximumPhysicalDamageToReflectToSelfOnAttack = 2062,
        [Description("Is Bleeding")]
        IsBleeding = 2063,
        [Description("Damage +% Vs Bleeding Enemies")]
        DamagePosPctVsBleedingEnemies = 2064,
        [Description("Unique Gain Onslaught When Hit Duration Ms Per Endurance Charge")]
        UniqueGainOnslaughtWhenHitDurationMsPerEnduranceCharge = 2065,
        [Description("Unique Gain Endurance Charges Instead Of Frenzy Charges")]
        UniqueGainEnduranceChargesInsteadOfFrenzyCharges = 2066,
        [Description("Unique Gain Endurance Charges Instead Of Power Charges")]
        UniqueGainEnduranceChargesInsteadOfPowerCharges = 2067,
        [Description("Fire Damage Taken +%")]
        FireDamageTakenPosPct = 2068,
        [Description("Crits Have Culling Strike")]
        CritsHaveCullingStrike = 2069,
        [Description("Support Projectile Attack Physical Damage +% Final")]
        SupportProjectileAttackPhysicalDamagePosPctFinal = 2070,
        [Description("Support Projectile Attack Speed +% Final")]
        SupportProjectileAttackSpeedPosPctFinal = 2071,
        [Description("Supported Active Skill Gem Expereince Gained +%")]
        SupportedActiveSkillGemExpereinceGainedPosPct = 2072,
        [Description("Flame Whip Damage +% Final Vs Burning Enemies")]
        FlameWhipDamagePosPctFinalVsBurningEnemies = 2073,
        [Description("Unique Spread Poison To Nearby Enemies On Kill")]
        UniqueSpreadPoisonToNearbyEnemiesOnKill = 2074,
        [Description("Unique Spread Poison To Nearby Allies As Regeneration On Kill")]
        UniqueSpreadPoisonToNearbyAlliesAsRegenerationOnKill = 2075,
        [Description("Uncapped Fire Damage Resistance %")]
        UncappedFireDamageResistancePct = 2076,
        [Description("Uncapped Cold Damage Resistance %")]
        UncappedColdDamageResistancePct = 2077,
        [Description("Uncapped Lightning Damage Resistance %")]
        UncappedLightningDamageResistancePct = 2078,
        [Description("Uncapped Chaos Damage Resistance %")]
        UncappedChaosDamageResistancePct = 2079,
        [Description("Local Ring Duplicate Other Ring")]
        LocalRingDuplicateOtherRing = 2080,
        [Description("Duplicate Ring Slot 1")]
        DuplicateRingSlot1 = 2081,
        [Description("Duplicate Ring Slot 2")]
        DuplicateRingSlot2 = 2082,
        [Description("Unique Fire Damage Shocks")]
        UniqueFireDamageShocks = 2083,
        [Description("Unique Cold Damage Ignites")]
        UniqueColdDamageIgnites = 2084,
        [Description("Unique Lightning Damage Freezes")]
        UniqueLightningDamageFreezes = 2085,
        [Description("Fire Damage Can Shock")]
        FireDamageCanShock = 2086,
        [Description("Cold Damage Can Ignite")]
        ColdDamageCanIgnite = 2087,
        [Description("Lightning Damage Can Freeze")]
        LightningDamageCanFreeze = 2088,
        [Description("Fire Damage Cannot Ignite")]
        FireDamageCannotIgnite = 2089,
        [Description("Cold Damage Cannot Freeze")]
        ColdDamageCannotFreeze = 2090,
        [Description("Lightning Damage Cannot Shock")]
        LightningDamageCannotShock = 2091,
        [Description("Can Catch Exotic Fish")]
        CanCatchExoticFish = 2092,
        [Description("Transfer Curses To X Nearby Enemies On Kill")]
        TransferCursesToXNearbyEnemiesOnKill = 2093,
        [Description("Freeze As Though Dealt Damage +%")]
        FreezeAsThoughDealtDamagePosPct = 2094,
        [Description("Chill Prevention Ms When Chilled")]
        ChillPreventionMsWhenChilled = 2095,
        [Description("Freeze Prevention Ms When Frozen")]
        FreezePreventionMsWhenFrozen = 2096,
        [Description("Ignite Prevention Ms When Ignited")]
        IgnitePreventionMsWhenIgnited = 2097,
        [Description("Shock Prevention Ms When Shocked")]
        ShockPreventionMsWhenShocked = 2098,
        [Description("Grant X Frenzy Charges To Nearby Allies On Death")]
        GrantXFrenzyChargesToNearbyAlliesOnDeath = 2099,
        [Description("Unique Gain Power Charge On Non Crit")]
        UniqueGainPowerChargeOnNonCrit = 2100,
        [Description("Unique Lose All Power Charges On Crit")]
        UniqueLoseAllPowerChargesOnCrit = 2101,
        [Description("Curse Area Of Effect +%")]
        CurseAreaOfEffectPosPct = 2102,
        [Description("Support Spell Totem Cast Speed +% Final")]
        SupportSpellTotemCastSpeedPosPctFinal = 2103,
        [Description("Support Attack Totem Attack Speed +% Final")]
        SupportAttackTotemAttackSpeedPosPctFinal = 2104,
        [Description("Map Non Unique Monsters Spawn X Monsters On Death")]
        MapNonUniqueMonstersSpawnXMonstersOnDeath = 2105,
        [Description("Local Unique Attacks Cast Socketed Lightning Spells %")]
        LocalUniqueAttacksCastSocketedLightningSpellsPct = 2106,
        [Description("Main Hand Local Unique Attacks Cast Socketed Lightning Spells %")]
        MainHandLocalUniqueAttacksCastSocketedLightningSpellsPct = 2107,
        [Description("Off Hand Local Unique Attacks Cast Socketed Lightning Spells %")]
        OffHandLocalUniqueAttacksCastSocketedLightningSpellsPct = 2108,
        [Description("Local Display Aura Curse Effect On Self +%")]
        LocalDisplayAuraCurseEffectOnSelfPosPct = 2109,
        [Description("Flask Minion Heal %")]
        FlaskMinionHealPct = 2110,
        [Description("Minion Block %")]
        MinionBlockPct = 2111,
        [Description("Minion Physical Damage Reduction Rating")]
        MinionPhysicalDamageReductionRating = 2112,
        [Description("Untargetable By Monster Ai")]
        UntargetableByMonsterAi = 2113,
        [Description("Desecrate Number Of Corpses To Create")]
        DesecrateNumberOfCorpsesToCreate = 2114,
        [Description("Local Display Aura Damage +% Allies Only")]
        LocalDisplayAuraDamagePosPctAlliesOnly = 2115,
        [Description("Map Invasion Monster Packs")]
        MapInvasionMonsterPacks = 2116,
        [Description("Base Spell Block %")]
        BaseSpellBlockPct = 2117,
        [Description("Minion Attack Speed +%")]
        MinionAttackSpeedPosPct = 2118,
        [Description("Minion Cast Speed +%")]
        MinionCastSpeedPosPct = 2119,
        [Description("Old Do Not Use Minion Life Leech From Any Damage Permyriad")]
        OldDoNotUseMinionLifeLeechFromAnyDamagePermyriad = 2120,
        [Description("Minion Life Regeneration Rate Per Minute %")]
        MinionLifeRegenerationRatePerMinutePct = 2121,
        [Description("Minion Elemental Resistance %")]
        MinionElementalResistancePct = 2122,
        [Description("Minion Chaos Resistance %")]
        MinionChaosResistancePct = 2123,
        [Description("Skill Show Average Damage Instead Of Dps")]
        SkillShowAverageDamageInsteadOfDps = 2124,
        [Description("Offering Skill Effect Duration Per Corpse")]
        OfferingSkillEffectDurationPerCorpse = 2125,
        [Description("Unholy Might On Kill Duration Ms")]
        UnholyMightOnKillDurationMs = 2126,
        [Description("Minion Unholy Might On Kill Duration Ms")]
        MinionUnholyMightOnKillDurationMs = 2127,
        [Description("Chest Delay Drops Until Daemons Finish")]
        ChestDelayDropsUntilDaemonsFinish = 2128,
        [Description("Base Number Of Raging Spirits Allowed")]
        BaseNumberOfRagingSpiritsAllowed = 2129,
        [Description("Number Of Raging Spirits Allowed")]
        NumberOfRagingSpiritsAllowed = 2130,
        [Description("Chest Play Warning Sound")]
        ChestPlayWarningSound = 2131,
        [Description("Chest Drop Additional Unqiue Items")]
        ChestDropAdditionalUnqiueItems = 2132,
        [Description("Upheaval Number Of Spikes")]
        UpheavalNumberOfSpikes = 2133,
        [Description("Chest Display Summons Skeletons")]
        ChestDisplaySummonsSkeletons = 2134,
        [Description("Chest Display Ice Nova")]
        ChestDisplayIceNova = 2135,
        [Description("Chest Display Freeze")]
        ChestDisplayFreeze = 2136,
        [Description("Cyclone Places Ground Desecration Chaos Damage Per Minute")]
        CyclonePlacesGroundDesecrationChaosDamagePerMinute = 2137,
        [Description("Firestorm Drop Ground Ice Duration Ms")]
        FirestormDropGroundIceDurationMs = 2138,
        [Description("Vaal Burning Arrow Explode On Hit")]
        VaalBurningArrowExplodeOnHit = 2139,
        [Description("Molten Shell Explode Each Hit")]
        MoltenShellExplodeEachHit = 2140,
        [Description("Desecrate Corpse Level")]
        DesecrateCorpseLevel = 2141,
        [Description("Lightning Warp Remove Delay")]
        LightningWarpRemoveDelay = 2142,
        [Description("Immortal Call Prevent All Damage")]
        ImmortalCallPreventAllDamage = 2143,
        [Description("Power Siphon Fire At All Targets")]
        PowerSiphonFireAtAllTargets = 2144,
        [Description("Rain Of Arrows Place Shocking Ground Duration Ms")]
        RainOfArrowsPlaceShockingGroundDurationMs = 2145,
        [Description("Leap Slam Base Caustic Cloud Damage To Deal Per Minute")]
        LeapSlamBaseCausticCloudDamageToDealPerMinute = 2146,
        [Description("Base Number Of Projectiles In Spiral Nova")]
        BaseNumberOfProjectilesInSpiralNova = 2147,
        [Description("Projectile Spiral Nova Time Ms")]
        ProjectileSpiralNovaTimeMs = 2148,
        [Description("Projectile Spiral Nova Angle")]
        ProjectileSpiralNovaAngle = 2149,
        [Description("Kiweth Consume Leech % Max Life")]
        KiwethConsumeLeechPctMaxLife = 2150,
        [Description("Ice Nova Number Of Repeats")]
        IceNovaNumberOfRepeats = 2151,
        [Description("Ice Nova Radius +% Per Repeat")]
        IceNovaRadiusPosPctPerRepeat = 2152,
        [Description("Local Display Socketed Gems Have Iron Will")]
        LocalDisplaySocketedGemsHaveIronWill = 2153,
        [Description("Local Display Socketed Gems Chain X Additional Times")]
        LocalDisplaySocketedGemsChainXAdditionalTimes = 2154,
        [Description("Old Do Not Use Base Life Leech From Physical Damage Permyriad")]
        OldDoNotUseBaseLifeLeechFromPhysicalDamagePermyriad = 2155,
        [Description("Old Do Not Use Base Life Leech From Fire Damage Permyriad")]
        OldDoNotUseBaseLifeLeechFromFireDamagePermyriad = 2156,
        [Description("Old Do Not Use Base Life Leech From Cold Damage Permyriad")]
        OldDoNotUseBaseLifeLeechFromColdDamagePermyriad = 2157,
        [Description("Old Do Not Use Base Life Leech From Lightning Damage Permyriad")]
        OldDoNotUseBaseLifeLeechFromLightningDamagePermyriad = 2158,
        [Description("Base Life Leech From Chaos Damage Permyriad")]
        BaseLifeLeechFromChaosDamagePermyriad = 2159,
        [Description("Base Mana Leech From Physical Damage Permyriad")]
        BaseManaLeechFromPhysicalDamagePermyriad = 2160,
        [Description("Base Mana Leech From Fire Damage Permyriad")]
        BaseManaLeechFromFireDamagePermyriad = 2161,
        [Description("Base Mana Leech From Cold Damage Permyriad")]
        BaseManaLeechFromColdDamagePermyriad = 2162,
        [Description("Old Do Not Use Base Mana Leech From Lightning Damage Permyriad")]
        OldDoNotUseBaseManaLeechFromLightningDamagePermyriad = 2163,
        [Description("Base Mana Leech From Chaos Damage Permyriad")]
        BaseManaLeechFromChaosDamagePermyriad = 2164,
        [Description("Base Leech Is Instant On Critical")]
        BaseLeechIsInstantOnCritical = 2165,
        [Description("Local Socketed Vaal Gem Level +")]
        LocalSocketedVaalGemLevelPos = 2166,
        [Description("Elemental Damage % To Add As Chaos")]
        ElementalDamagePctToAddAsChaos = 2167,
        [Description("Chance To Ignite % While Using Flask")]
        ChanceToIgnitePctWhileUsingFlask = 2168,
        [Description("Chance To Freeze % While Using Flask")]
        ChanceToFreezePctWhileUsingFlask = 2169,
        [Description("Chance To Shock % While Using Flask")]
        ChanceToShockPctWhileUsingFlask = 2170,
        [Description("Stun Threshold Reduction +% While Using Flask")]
        StunThresholdReductionPosPctWhileUsingFlask = 2171,
        [Description("Local Unique Flask Physical Damage % To Add As Chaos While Healing")]
        LocalUniqueFlaskPhysicalDamagePctToAddAsChaosWhileHealing = 2172,
        [Description("Local Unique Flask Elemental Damage % To Add As Chaos While Healing")]
        LocalUniqueFlaskElementalDamagePctToAddAsChaosWhileHealing = 2173,
        [Description("Old Do Not Use Local Unique Flask Life Leech From Chaos Damage Permyriad While Healing")]
        OldDoNotUseLocalUniqueFlaskLifeLeechFromChaosDamagePermyriadWhileHealing = 2174,
        [Description("Local Display Socketed Spells Repeat Count")]
        LocalDisplaySocketedSpellsRepeatCount = 2175,
        [Description("Map Ambush Chests")]
        MapAmbushChests = 2176,
        [Description("Atziri Do Not Gain Skill Charges")]
        AtziriDoNotGainSkillCharges = 2177,
        [Description("Chest Hidden Item Quantity +%")]
        ChestHiddenItemQuantityPosPct = 2178,
        [Description("Chest Hidden Item Rarity +%")]
        ChestHiddenItemRarityPosPct = 2179,
        [Description("Monster Drop Vaal Fragment Chance")]
        MonsterDropVaalFragmentChance = 2180,
        [Description("Summoned Monster Rarity")]
        SummonedMonsterRarity = 2181,
        [Description("Number Of Monsters To Summon")]
        NumberOfMonstersToSummon = 2182,
        [Description("Chest Gems Drop With Experience")]
        ChestGemsDropWithExperience = 2183,
        [Description("Chest Drops Additional Utility Flasks")]
        ChestDropsAdditionalUtilityFlasks = 2184,
        [Description("Chest Items Drop Identified")]
        ChestItemsDropIdentified = 2185,
        [Description("Chest Drop Additional Normal Items Up To")]
        ChestDropAdditionalNormalItemsUpTo = 2186,
        [Description("Chest Drop Additional Magic Items Up To")]
        ChestDropAdditionalMagicItemsUpTo = 2187,
        [Description("Chest Drop Additional Rare Items Up To")]
        ChestDropAdditionalRareItemsUpTo = 2188,
        [Description("Chest Dropped Items Have Quality %")]
        ChestDroppedItemsHaveQualityPct = 2189,
        [Description("Dropped Items Have Additional Sockets")]
        DroppedItemsHaveAdditionalSockets = 2190,
        [Description("Dropped Items Are Fully Linked")]
        DroppedItemsAreFullyLinked = 2191,
        [Description("Chest Dropped Item Level +")]
        ChestDroppedItemLevelPos = 2192,
        [Description("Dropped Items Are Duplicated")]
        DroppedItemsAreDuplicated = 2193,
        [Description("Monster Unlock Chests On Death")]
        MonsterUnlockChestsOnDeath = 2194,
        [Description("Local Display Socketed Gems Mana Cost -%")]
        LocalDisplaySocketedGemsManaCostNegPct = 2195,
        [Description("Chest Spawn Rogue Exiles")]
        ChestSpawnRogueExiles = 2196,
        [Description("Chest Display Revive Nearby Monsters")]
        ChestDisplayReviveNearbyMonsters = 2197,
        [Description("Chest Display Spawns Monsters Continuously")]
        ChestDisplaySpawnsMonstersContinuously = 2198,
        [Description("Chest Display Explodes Corpses")]
        ChestDisplayExplodesCorpses = 2199,
        [Description("Chest Camoflaged")]
        ChestCamoflaged = 2200,
        [Description("Chest Display Cast Random Curse")]
        ChestDisplayCastRandomCurse = 2201,
        [Description("Chest Display Ignite")]
        ChestDisplayIgnite = 2202,
        [Description("Chest Display Fire Storm")]
        ChestDisplayFireStorm = 2203,
        [Description("Chest Display Caustic Clouds")]
        ChestDisplayCausticClouds = 2204,
        [Description("Chest Display Explosion")]
        ChestDisplayExplosion = 2205,
        [Description("Chest Drops Only Hybrid Flasks")]
        ChestDropsOnlyHybridFlasks = 2206,
        [Description("Chest Drops Only Support Gems")]
        ChestDropsOnlySupportGems = 2207,
        [Description("Chest Drops Extra Vaal Gems")]
        ChestDropsExtraVaalGems = 2208,
        [Description("Firestorm Drop Ground Shock Duration Ms")]
        FirestormDropGroundShockDurationMs = 2209,
        [Description("Detonate Dead Chain Explode")]
        DetonateDeadChainExplode = 2210,
        [Description("Corrupted Blood Cleave Stacks To Add")]
        CorruptedBloodCleaveStacksToAdd = 2211,
        [Description("Desecrated Ground Art Variation")]
        DesecratedGroundArtVariation = 2212,
        [Description("Kiweth Projectile Spawn Kiweth")]
        KiwethProjectileSpawnKiweth = 2213,
        [Description("Rain Of Arrows Pin")]
        RainOfArrowsPin = 2214,
        [Description("Onslaught On Vaal Skill Use Duration Ms")]
        OnslaughtOnVaalSkillUseDurationMs = 2215,
        [Description("Cold Snap Ground Ice")]
        ColdSnapGroundIce = 2216,
        [Description("Num Ghost Monkeys To Summon")]
        NumGhostMonkeysToSummon = 2217,
        [Description("Smoke Mine Spawn X Snakes On Teleport")]
        SmokeMineSpawnXSnakesOnTeleport = 2218,
        [Description("Num Sandspitters To Summon")]
        NumSandspittersToSummon = 2219,
        [Description("Vaal Lightning Strike Beam Damage +% Final")]
        VaalLightningStrikeBeamDamagePosPctFinal = 2220,
        [Description("Atziri Lightning Charge Requirement -")]
        AtziriLightningChargeRequirementNeg = 2221,
        [Description("Atziri Fire Charge Requirement -")]
        AtziriFireChargeRequirementNeg = 2222,
        [Description("Atziri Physical Charge Requirement -")]
        AtziriPhysicalChargeRequirementNeg = 2223,
        [Description("Life Leech From Physical Damage Permyriad")]
        LifeLeechFromPhysicalDamagePermyriad = 2224,
        [Description("Life Leech From Fire Damage Permyriad")]
        LifeLeechFromFireDamagePermyriad = 2225,
        [Description("Life Leech From Cold Damage Permyriad")]
        LifeLeechFromColdDamagePermyriad = 2226,
        [Description("Life Leech From Lightning Damage Permyriad")]
        LifeLeechFromLightningDamagePermyriad = 2227,
        [Description("Life Leech From Chaos Damage Permyriad")]
        LifeLeechFromChaosDamagePermyriad = 2228,
        [Description("Mana Leech From Physical Damage Permyriad")]
        ManaLeechFromPhysicalDamagePermyriad = 2229,
        [Description("Mana Leech From Fire Damage Permyriad")]
        ManaLeechFromFireDamagePermyriad = 2230,
        [Description("Mana Leech From Cold Damage Permyriad")]
        ManaLeechFromColdDamagePermyriad = 2231,
        [Description("Mana Leech From Lightning Damage Permyriad")]
        ManaLeechFromLightningDamagePermyriad = 2232,
        [Description("Mana Leech From Chaos Damage Permyriad")]
        ManaLeechFromChaosDamagePermyriad = 2233,
        [Description("Old Do Not Use Base Life Leech From Elemental Damage Permyriad")]
        OldDoNotUseBaseLifeLeechFromElementalDamagePermyriad = 2234,
        [Description("Base Mana Leech From Elemental Damage Permyriad")]
        BaseManaLeechFromElementalDamagePermyriad = 2235,
        [Description("Keystone Vampirism Life Leech Amount +% Final")]
        KeystoneVampirismLifeLeechAmountPosPctFinal = 2236,
        [Description("Attack Minimum Added Physical Damage With Bow")]
        AttackMinimumAddedPhysicalDamageWithBow = 2237,
        [Description("Attack Maximum Added Physical Damage With Bow")]
        AttackMaximumAddedPhysicalDamageWithBow = 2238,
        [Description("Attack Minimum Added Fire Damage With Bow")]
        AttackMinimumAddedFireDamageWithBow = 2239,
        [Description("Attack Maximum Added Fire Damage With Bow")]
        AttackMaximumAddedFireDamageWithBow = 2240,
        [Description("Number Of Packs To Summon")]
        NumberOfPacksToSummon = 2241,
        [Description("Summon Monster Radius")]
        SummonMonsterRadius = 2242,
        [Description("Resist Life Leech %")]
        ResistLifeLeechPct = 2243,
        [Description("Resist Mana Leech %")]
        ResistManaLeechPct = 2244,
        [Description("Life Leech Amount +%")]
        LifeLeechAmountPosPct = 2245,
        [Description("Level 11 Or Lower Life +% Final")]
        Level11OrLowerLifePosPctFinal = 2246,
        [Description("Local Socketed Support Gem Level +")]
        LocalSocketedSupportGemLevelPos = 2247,
        [Description("Level 33 Or Lower Life +% Final")]
        Level33OrLowerLifePosPctFinal = 2248,
        [Description("Level 33 Or Lower Damage +% Final")]
        Level33OrLowerDamagePosPctFinal = 2249,
        [Description("Display Monster Casts Vaal Detonate Dead Text")]
        DisplayMonsterCastsVaalDetonateDeadText = 2250,
        [Description("Minions Have Chest Summon Indicator")]
        MinionsHaveChestSummonIndicator = 2251,
        [Description("Curse On Hit Level Temporal Chains")]
        CurseOnHitLevelTemporalChains = 2252,
        [Description("Curse On Hit Level Vulnerability")]
        CurseOnHitLevelVulnerability = 2253,
        [Description("Curse On Hit Level Elemental Weakness")]
        CurseOnHitLevelElementalWeakness = 2254,
        [Description("Local Display Socketed Gems Get Melee Splash Level")]
        LocalDisplaySocketedGemsGetMeleeSplashLevel = 2255,
        [Description("Local Display Socketed Gems Get Cast On Crit Level")]
        LocalDisplaySocketedGemsGetCastOnCritLevel = 2256,
        [Description("Local Display Socketed Gems Get Cast When Stunned Level")]
        LocalDisplaySocketedGemsGetCastWhenStunnedLevel = 2257,
        [Description("Is Double")]
        IsDouble = 2258,
        [Description("Can Catch Corrupted Fish")]
        CanCatchCorruptedFish = 2259,
        [Description("Disable Animated Armour")]
        DisableAnimatedArmour = 2260,
        [Description("Number Of Archer Skeletons To Summon")]
        NumberOfArcherSkeletonsToSummon = 2261,
        [Description("Number Of Mage Skeletons To Summon")]
        NumberOfMageSkeletonsToSummon = 2262,
        [Description("Number Of Leader Skeletons To Summon")]
        NumberOfLeaderSkeletonsToSummon = 2263,
        [Description("Map Spawn Extra Exiles")]
        MapSpawnExtraExiles = 2264,
        [Description("Map Disable New Instance Management")]
        MapDisableNewInstanceManagement = 2265,
        [Description("Local Display Socketed Gems Get Mana Multplier %")]
        LocalDisplaySocketedGemsGetManaMultplierPct = 2266,
        [Description("Local Display Socketed Gems Get Stun Level")]
        LocalDisplaySocketedGemsGetStunLevel = 2267,
        [Description("Local Display Socketed Gems Get Additional Accuracy Level")]
        LocalDisplaySocketedGemsGetAdditionalAccuracyLevel = 2268,
        [Description("Local Display Socketed Gems Get Multistrike Level")]
        LocalDisplaySocketedGemsGetMultistrikeLevel = 2269,
        [Description("Local Display Socketed Gems Get Faster Projectiles Level")]
        LocalDisplaySocketedGemsGetFasterProjectilesLevel = 2270,
        [Description("Local Display Socketed Gems Get Life Leech Level")]
        LocalDisplaySocketedGemsGetLifeLeechLevel = 2271,
        [Description("Local Display Socketed Gems Get Increased Critical Damage Level")]
        LocalDisplaySocketedGemsGetIncreasedCriticalDamageLevel = 2272,
        [Description("Local Display Socketed Gems Get Fork Level")]
        LocalDisplaySocketedGemsGetForkLevel = 2273,
        [Description("Local Display Socketed Gems Get Weapon Elemental Damage Level")]
        LocalDisplaySocketedGemsGetWeaponElementalDamageLevel = 2274,
        [Description("Local Display Grants Skill Purity Of Fire Level")]
        LocalDisplayGrantsSkillPurityOfFireLevel = 2275,
        [Description("Local Display Grants Skill Purity Of Cold Level")]
        LocalDisplayGrantsSkillPurityOfColdLevel = 2276,
        [Description("Local Display Grants Skill Purity Of Lightning Level")]
        LocalDisplayGrantsSkillPurityOfLightningLevel = 2277,
        [Description("Local Display Grants Skill Flammability Level")]
        LocalDisplayGrantsSkillFlammabilityLevel = 2278,
        [Description("Local Display Grants Skill Conductivity Level")]
        LocalDisplayGrantsSkillConductivityLevel = 2279,
        [Description("Local Display Grants Skill Frostbite Level")]
        LocalDisplayGrantsSkillFrostbiteLevel = 2280,
        [Description("Local Display Grants Skill Temporal Chains Level")]
        LocalDisplayGrantsSkillTemporalChainsLevel = 2281,
        [Description("Local Display Grants Skill Haste Level")]
        LocalDisplayGrantsSkillHasteLevel = 2282,
        [Description("Local Display Grants Skill Clarity Level")]
        LocalDisplayGrantsSkillClarityLevel = 2283,
        [Description("Local Display Grants Skill Vitality Level")]
        LocalDisplayGrantsSkillVitalityLevel = 2284,
        [Description("Local Display Grants Skill Purity Level")]
        LocalDisplayGrantsSkillPurityLevel = 2285,
        [Description("Local Display Grants Skill Critical Weakness Level")]
        LocalDisplayGrantsSkillCriticalWeaknessLevel = 2286,
        [Description("Local Display Grants Skill Wrath Level")]
        LocalDisplayGrantsSkillWrathLevel = 2287,
        [Description("Local Display Grants Skill Hatred Level")]
        LocalDisplayGrantsSkillHatredLevel = 2288,
        [Description("Local Display Grants Skill Anger Level")]
        LocalDisplayGrantsSkillAngerLevel = 2289,
        [Description("Local Display Grants Skill Determination Level")]
        LocalDisplayGrantsSkillDeterminationLevel = 2290,
        [Description("Local Display Grants Skill Grace Level")]
        LocalDisplayGrantsSkillGraceLevel = 2291,
        [Description("Local Display Grants Skill Discipline Level")]
        LocalDisplayGrantsSkillDisciplineLevel = 2292,
        [Description("Local Display Grants Skill Projectile Weakness Level")]
        LocalDisplayGrantsSkillProjectileWeaknessLevel = 2293,
        [Description("Local Display Grants Skill Elemental Weakness Level")]
        LocalDisplayGrantsSkillElementalWeaknessLevel = 2294,
        [Description("Local Display Grants Skill Vulnerability Level")]
        LocalDisplayGrantsSkillVulnerabilityLevel = 2295,
        [Description("Cold Damage Cannot Chill")]
        ColdDamageCannotChill = 2296,
        [Description("Elemental Damage Taken % As Chaos")]
        ElementalDamageTakenPctAsChaos = 2297,
        [Description("Fire Damage Taken % As Chaos")]
        FireDamageTakenPctAsChaos = 2298,
        [Description("Cold Damage Taken % As Chaos")]
        ColdDamageTakenPctAsChaos = 2299,
        [Description("Lightning Damage Taken % As Chaos")]
        LightningDamageTakenPctAsChaos = 2300,
        [Description("Global Reduce Enemy Block %")]
        GlobalReduceEnemyBlockPct = 2301,
        [Description("Base Spell Repeat Count")]
        BaseSpellRepeatCount = 2302,
        [Description("Spell Repeat Count")]
        SpellRepeatCount = 2303,
        [Description("Pvp Damage +% Final Scale")]
        PvpDamagePosPctFinalScale = 2304,
        [Description("Physical Damage Taken + Vs Beasts")]
        PhysicalDamageTakenPosVsBeasts = 2305,
        [Description("Local Strength Requirement +")]
        LocalStrengthRequirementPos = 2306,
        [Description("Local Dexterity Requirement +")]
        LocalDexterityRequirementPos = 2307,
        [Description("Local Intelligence Requirement +")]
        LocalIntelligenceRequirementPos = 2308,
        [Description("Display Monster Vaal Storm Call")]
        DisplayMonsterVaalStormCall = 2309,
        [Description("Reave Rotation On Repeat")]
        ReaveRotationOnRepeat = 2310,
        [Description("Reave Additional Max Stacks")]
        ReaveAdditionalMaxStacks = 2311,
        [Description("Reave Additional Starting Stacks")]
        ReaveAdditionalStartingStacks = 2312,
        [Description("Bleed On Melee Crit Chance %")]
        BleedOnMeleeCritChancePct = 2313,
        [Description("Bleed On Melee Crit Chance Duration Ms")]
        BleedOnMeleeCritChanceDurationMs = 2314,
        [Description("Energy Shield Recharge Not Delayed By Damage")]
        EnergyShieldRechargeNotDelayedByDamage = 2315,
        [Description("Maximum Dodge Chance %")]
        MaximumDodgeChancePct = 2316,
        [Description("Maximum Spell Dodge Chance %")]
        MaximumSpellDodgeChancePct = 2317,
        [Description("Weapon Physical Damage % To Add As Random Element")]
        WeaponPhysicalDamagePctToAddAsRandomElement = 2318,
        [Description("Throw Traps In Circle Radius")]
        ThrowTrapsInCircleRadius = 2319,
        [Description("Damage Taken +%")]
        DamageTakenPosPct = 2320,
        [Description("Damage Taken +% Per Frenzy Charge")]
        DamageTakenPosPctPerFrenzyCharge = 2321,
        [Description("Lightning Damage +% Per Frenzy Charge")]
        LightningDamagePosPctPerFrenzyCharge = 2322,
        [Description("Life Gained On Enemy Death")]
        LifeGainedOnEnemyDeath = 2323,
        [Description("Life Gained On Enemy Death Per Frenzy Charge")]
        LifeGainedOnEnemyDeathPerFrenzyCharge = 2324,
        [Description("Vaal Sweep Additional Base Radius For Push")]
        VaalSweepAdditionalBaseRadiusForPush = 2325,
        [Description("Main Hand Weapon Elemental Damage +%")]
        MainHandWeaponElementalDamagePosPct = 2326,
        [Description("Off Hand Weapon Elemental Damage +%")]
        OffHandWeaponElementalDamagePosPct = 2327,
        [Description("Local Attacks With This Weapon Elemental Damage +%")]
        LocalAttacksWithThisWeaponElementalDamagePosPct = 2328,
        [Description("Monster Casts Glacial Cascade Text")]
        MonsterCastsGlacialCascadeText = 2329,
        [Description("Dual Wield Inherent Physical Attack Damage +% Final")]
        DualWieldInherentPhysicalAttackDamagePosPctFinal = 2330,
        [Description("Damage Cannot Be Reflected")]
        DamageCannotBeReflected = 2331,
        [Description("Map Base Ground Desecration Damage To Deal Per Minute")]
        MapBaseGroundDesecrationDamageToDealPerMinute = 2332,
        [Description("Global Poison On Hit")]
        GlobalPoisonOnHit = 2333,
        [Description("Map Monsters Poison On Hit")]
        MapMonstersPoisonOnHit = 2334,
        [Description("Play Jack The Axe Sounds")]
        PlayJackTheAxeSounds = 2335,
        [Description("Sound On Kill Wolf Call")]
        SoundOnKillWolfCall = 2336,
        [Description("Oba Decapitated")]
        ObaDecapitated = 2337,
        [Description("Chest Number Of Additional Kaom Uniques To Drop")]
        ChestNumberOfAdditionalKaomUniquesToDrop = 2338,
        [Description("Chest Drop Additional Number Of Uniques Of Drop Pool Types")]
        ChestDropAdditionalNumberOfUniquesOfDropPoolTypes = 2339,
        [Description("Chest Display Kaom Totems")]
        ChestDisplayKaomTotems = 2340,
        [Description("Map Mission Id")]
        MapMissionId = 2341,
        [Description("Chest No Regular Drops")]
        ChestNoRegularDrops = 2342,
        [Description("Map Side Area Chance +%")]
        MapSideAreaChancePosPct = 2343,
        [Description("Chest Drop Additional Unique Maps")]
        ChestDropAdditionalUniqueMaps = 2344,
        [Description("Map Display Garena Drop Buff")]
        MapDisplayGarenaDropBuff = 2345,
        [Description("Keystone Unwavering Stance")]
        KeystoneUnwaveringStance = 2346,
        [Description("Cannot Evade")]
        CannotEvade = 2347,
        [Description("Never Ignite")]
        NeverIgnite = 2348,
        [Description("Global Chance To Knockback %")]
        GlobalChanceToKnockbackPct = 2349,
        [Description("Local Unique Flask Instantly Recovers % Maximum Life")]
        LocalUniqueFlaskInstantlyRecoversPctMaximumLife = 2350,
        [Description("Local Unique Flask Chaos Damage % Of Maximum Life To Deal Per Minute While Healing")]
        LocalUniqueFlaskChaosDamagePctOfMaximumLifeToDealPerMinuteWhileHealing = 2351,
        [Description("Unique Add Power Charge On Melee Knockback %")]
        UniqueAddPowerChargeOnMeleeKnockbackPct = 2352,
        [Description("Display Map Boss Gives Experience +%")]
        DisplayMapBossGivesExperiencePosPct = 2353,
        [Description("Gain Power Charge When Throwing Trap %")]
        GainPowerChargeWhenThrowingTrapPct = 2354,
        [Description("Local Display Grants Skill Bear Trap Level")]
        LocalDisplayGrantsSkillBearTrapLevel = 2355,
        [Description("Critical Strike Chance +% Per 8 Strength")]
        CriticalStrikeChancePosPctPer8Strength = 2356,
        [Description("Skill Is Trapped")]
        SkillIsTrapped = 2357,
        [Description("Skill Is Mined")]
        SkillIsMined = 2358,
        [Description("Skill Is Totemified")]
        SkillIsTotemified = 2359,
        [Description("Current Rampage Stacks")]
        CurrentRampageStacks = 2360,
        [Description("Max Rampage Stacks")]
        MaxRampageStacks = 2361,
        [Description("Damage +% Per 10 Rampage Stacks")]
        DamagePosPctPer10RampageStacks = 2362,
        [Description("Movement Velocity +% Per 10 Rampage Stacks")]
        MovementVelocityPosPctPer10RampageStacks = 2363,
        [Description("Map Players Gain Rampage Stacks")]
        MapPlayersGainRampageStacks = 2364,
        [Description("Map Disable Missions")]
        MapDisableMissions = 2365,
        [Description("Map Spawn Map Portal")]
        MapSpawnMapPortal = 2366,
        [Description("Local Unique Flask Block % While Healing")]
        LocalUniqueFlaskBlockPctWhileHealing = 2367,
        [Description("Local Unique Flask Spell Block % While Healing")]
        LocalUniqueFlaskSpellBlockPctWhileHealing = 2368,
        [Description("Map Beyond Rules")]
        MapBeyondRules = 2369,
        [Description("Map Extra Ruleset")]
        MapExtraRuleset = 2370,
        [Description("Map Mission Variation")]
        MapMissionVariation = 2371,
        [Description("Ground Spikes Physical Damage To Deal Per Minute")]
        GroundSpikesPhysicalDamageToDealPerMinute = 2372,
        [Description("Ground Spikes Moving Physical Damage To Deal Per Minute")]
        GroundSpikesMovingPhysicalDamageToDealPerMinute = 2373,
        [Description("Attack Speed +% While Ignited")]
        AttackSpeedPosPctWhileIgnited = 2374,
        [Description("Cast Speed +% While Ignited")]
        CastSpeedPosPctWhileIgnited = 2375,
        [Description("Chance To Ignite % While Ignited")]
        ChanceToIgnitePctWhileIgnited = 2376,
        [Description("Fire Nova Damage +% Per Repeat Final")]
        FireNovaDamagePosPctPerRepeatFinal = 2377,
        [Description("Lightning Trap Projectiles Leave Shocking Ground")]
        LightningTrapProjectilesLeaveShockingGround = 2378,
        [Description("Main Hand Weapon Physical Damage +% Per 250 Evasion")]
        MainHandWeaponPhysicalDamagePosPctPer250Evasion = 2379,
        [Description("Off Hand Weapon Physical Damage +% Per 250 Evasion")]
        OffHandWeaponPhysicalDamagePosPctPer250Evasion = 2380,
        [Description("Local Attacks With This Weapon Physical Damage +% Per 250 Evasion")]
        LocalAttacksWithThisWeaponPhysicalDamagePosPctPer250Evasion = 2381,
        [Description("Map Cagan Has Hidden Mods")]
        MapCaganHasHiddenMods = 2382,
        [Description("Cyclone Places Ground Tar Movement Speed +%")]
        CyclonePlacesGroundTarMovementSpeedPosPct = 2383,
        [Description("Wand Damage +%")]
        WandDamagePosPct = 2384,
        [Description("Cast Speed While Dual Wielding +%")]
        CastSpeedWhileDualWieldingPosPct = 2385,
        [Description("Shield Spell Block %")]
        ShieldSpellBlockPct = 2386,
        [Description("Local Display Socketed Gems Get Echo Level")]
        LocalDisplaySocketedGemsGetEchoLevel = 2387,
        [Description("Support Echo Damage +% Final")]
        SupportEchoDamagePosPctFinal = 2388,
        [Description("Global Bleed On Hit")]
        GlobalBleedOnHit = 2389,
        [Description("Local Bleed On Hit")]
        LocalBleedOnHit = 2390,
        [Description("Main Hand Bleed On Hit")]
        MainHandBleedOnHit = 2391,
        [Description("Off Hand Bleed On Hit")]
        OffHandBleedOnHit = 2392,
        [Description("Damage +% Vs Ignited Enemies")]
        DamagePosPctVsIgnitedEnemies = 2393,
        [Description("Recover % Maximum Life On Rampage Threshold")]
        RecoverPctMaximumLifeOnRampageThreshold = 2394,
        [Description("Dispel Status Ailments On Rampage Threshold")]
        DispelStatusAilmentsOnRampageThreshold = 2395,
        [Description("Gain Physical Damage Immunity On Rampage Threshold Ms")]
        GainPhysicalDamageImmunityOnRampageThresholdMs = 2396,
        [Description("Gain X Vaal Souls On Rampage Threshold")]
        GainXVaalSoulsOnRampageThreshold = 2397,
        [Description("Physical Damage +% Vs Poisoned Enemies")]
        PhysicalDamagePosPctVsPoisonedEnemies = 2398,
        [Description("Block Causes Monster Flee %")]
        BlockCausesMonsterFleePct = 2399,
        [Description("Life Regeneration Rate Per Minute Per Level")]
        LifeRegenerationRatePerMinutePerLevel = 2400,
        [Description("Critical Strike Chance +% Per Level")]
        CriticalStrikeChancePosPctPerLevel = 2401,
        [Description("Attack Damage +% Per Level")]
        AttackDamagePosPctPerLevel = 2402,
        [Description("Spell Damage +% Per Level")]
        SpellDamagePosPctPerLevel = 2403,
        [Description("Recharge Flasks On Crit")]
        RechargeFlasksOnCrit = 2404,
        [Description("Bleeding Monsters Movement Velocity +%")]
        BleedingMonstersMovementVelocityPosPct = 2405,
        [Description("Old Do Not Use Life Leech Permyriad On Crit")]
        OldDoNotUseLifeLeechPermyriadOnCrit = 2406,
        [Description("Ground Smoke On Rampage Threshold Ms")]
        GroundSmokeOnRampageThresholdMs = 2407,
        [Description("Phasing On Rampage Threshold Ms")]
        PhasingOnRampageThresholdMs = 2408,
        [Description("On Full Energy Shield")]
        OnFullEnergyShield = 2409,
        [Description("Movement Velocity +% On Full Energy Shield")]
        MovementVelocityPosPctOnFullEnergyShield = 2410,
        [Description("Sword Critical Strike Chance +%")]
        SwordCriticalStrikeChancePosPct = 2411,
        [Description("Attack Damage +% Per 450 Evasion")]
        AttackDamagePosPctPer450Evasion = 2412,
        [Description("Old Do Not Use Mana Leech From Physical Damage With Claw %")]
        OldDoNotUseManaLeechFromPhysicalDamageWithClawPct = 2413,
        [Description("Main Hand Steal Power Frenzy Endurance Charges On Hit %")]
        MainHandStealPowerFrenzyEnduranceChargesOnHitPct = 2414,
        [Description("Off Hand Steal Power Frenzy Endurance Charges On Hit %")]
        OffHandStealPowerFrenzyEnduranceChargesOnHitPct = 2415,
        [Description("Claw Steal Power Frenzy Endurance Charges On Hit %")]
        ClawStealPowerFrenzyEnduranceChargesOnHitPct = 2416,
        [Description("Player Gain Rampage Stacks")]
        PlayerGainRampageStacks = 2417,
        [Description("Regenerate % Armour As Life Over 1 Second On Block")]
        RegeneratePctArmourAsLifeOver1SecondOnBlock = 2418,
        [Description("Monster Cast Spell % On Attack Hit")]
        MonsterCastSpellPctOnAttackHit = 2419,
        [Description("Unique Chaos Damage To Reflect To Self On Attack % Chance")]
        UniqueChaosDamageToReflectToSelfOnAttackPctChance = 2420,
        [Description("Unique Minimum Chaos Damage To Reflect To Self On Attack")]
        UniqueMinimumChaosDamageToReflectToSelfOnAttack = 2421,
        [Description("Unique Maximum Chaos Damage To Reflect To Self On Attack")]
        UniqueMaximumChaosDamageToReflectToSelfOnAttack = 2422,
        [Description("Map Monsters Curse Effect +%")]
        MapMonstersCurseEffectPosPct = 2423,
        [Description("Map Mission Variation2")]
        MapMissionVariation2 = 2424,
        [Description("Map Player Has Random Level X Curse Every 10 Seconds")]
        MapPlayerHasRandomLevelXCurseEvery10Seconds = 2425,
        [Description("Display Map Inhabited By Wild Beasts")]
        DisplayMapInhabitedByWildBeasts = 2426,
        [Description("Monster No Drops")]
        MonsterNoDrops = 2427,
        [Description("Map Monster No Drops")]
        MapMonsterNoDrops = 2428,
        [Description("Life Regeneration Rate +%")]
        LifeRegenerationRatePosPct = 2429,
        [Description("Cannot Be Blinded")]
        CannotBeBlinded = 2430,
        [Description("Local Socketed Skill Gem Level +")]
        LocalSocketedSkillGemLevelPos = 2431,
        [Description("Gain Unholy Might On Rampage Threshold Ms")]
        GainUnholyMightOnRampageThresholdMs = 2432,
        [Description("Elemental Damage +% Per Level")]
        ElementalDamagePosPctPerLevel = 2433,
        [Description("Chaos Damage +% Per Level")]
        ChaosDamagePosPctPerLevel = 2434,
        [Description("Life Gained On Enemy Death Per Level")]
        LifeGainedOnEnemyDeathPerLevel = 2435,
        [Description("Mana Gained On Enemy Death")]
        ManaGainedOnEnemyDeath = 2436,
        [Description("Energy Shield Gained On Enemy Death")]
        EnergyShieldGainedOnEnemyDeath = 2437,
        [Description("Mana Gained On Enemy Death Per Level")]
        ManaGainedOnEnemyDeathPerLevel = 2438,
        [Description("Energy Shield Gained On Enemy Death Per Level")]
        EnergyShieldGainedOnEnemyDeathPerLevel = 2439,
        [Description("Aura Cannot Affect Self")]
        AuraCannotAffectSelf = 2440,
        [Description("Map Scion Mission Monster Pack")]
        MapScionMissionMonsterPack = 2441,
        [Description("Mace Critical Strike Chance +%")]
        MaceCriticalStrikeChancePosPct = 2442,
        [Description("Staff Critical Strike Chance +%")]
        StaffCriticalStrikeChancePosPct = 2443,
        [Description("Wand Critical Strike Chance +%")]
        WandCriticalStrikeChancePosPct = 2444,
        [Description("Wand Critical Strike Multiplier +")]
        WandCriticalStrikeMultiplierPos = 2445,
        [Description("Bow Stun Threshold Reduction +%")]
        BowStunThresholdReductionPosPct = 2446,
        [Description("Number Of Animated Bows To Summon")]
        NumberOfAnimatedBowsToSummon = 2447,
        [Description("Number Of Animated Daggers To Summon")]
        NumberOfAnimatedDaggersToSummon = 2448,
        [Description("Number Of Animated Two Handed Swords To Summon")]
        NumberOfAnimatedTwoHandedSwordsToSummon = 2449,
        [Description("Firestorm Avoid Unwalkable Terrain")]
        FirestormAvoidUnwalkableTerrain = 2450,
        [Description("Ground Effect Ring Type")]
        GroundEffectRingType = 2451,
        [Description("Local Display Socketed Gems Have Elemental Equilibrium")]
        LocalDisplaySocketedGemsHaveElementalEquilibrium = 2452,
        [Description("Unique Fire Damage Resistance % When Red Gem Socketed")]
        UniqueFireDamageResistancePctWhenRedGemSocketed = 2453,
        [Description("Unique Cold Damage Resistance % When Green Gem Socketed")]
        UniqueColdDamageResistancePctWhenGreenGemSocketed = 2454,
        [Description("Unique Lightning Damage Resistance % When Blue Gem Socketed")]
        UniqueLightningDamageResistancePctWhenBlueGemSocketed = 2455,
        [Description("Skill Mana Cost +")]
        SkillManaCostPos = 2456,
        [Description("Map Aoe Daemons Per 100 Tiles")]
        MapAoeDaemonsPer100Tiles = 2457,
        [Description("Map Aoe Daemons Variation")]
        MapAoeDaemonsVariation = 2458,
        [Description("Monster No Beyond Portal")]
        MonsterNoBeyondPortal = 2459,
        [Description("Local Socketed Support Gem Quality +")]
        LocalSocketedSupportGemQualityPos = 2460,
        [Description("Map Packs Are Str Mission Totems")]
        MapPacksAreStrMissionTotems = 2461,
        [Description("Chance To Grant Frenzy Charge On Death %")]
        ChanceToGrantFrenzyChargeOnDeathPct = 2462,
        [Description("Life Granted When Hit By Attacks")]
        LifeGrantedWhenHitByAttacks = 2463,
        [Description("Mana Granted When Hit By Attacks")]
        ManaGrantedWhenHitByAttacks = 2464,
        [Description("Life Granted When Killed")]
        LifeGrantedWhenKilled = 2465,
        [Description("Mana Granted When Killed")]
        ManaGrantedWhenKilled = 2466,
        [Description("Evasion Rating +% Final From Poachers Mark")]
        EvasionRatingPosPctFinalFromPoachersMark = 2467,
        [Description("Monster Interactible Corpse")]
        MonsterInteractibleCorpse = 2468,
        [Description("Revive All With Onslaught Make Minions")]
        ReviveAllWithOnslaughtMakeMinions = 2469,
        [Description("Revive All With Onslaught Make Unusable")]
        ReviveAllWithOnslaughtMakeUnusable = 2470,
        [Description("Additive Spell Damage Modifiers Apply To Attack Damage")]
        AdditiveSpellDamageModifiersApplyToAttackDamage = 2471,
        [Description("Monster Show Mission Minimap Icon")]
        MonsterShowMissionMinimapIcon = 2472,
        [Description("Monster Potential Mission Target")]
        MonsterPotentialMissionTarget = 2473,
        [Description("Is Trap Object")]
        IsTrapObject = 2474,
        [Description("Attack Projectiles Return")]
        AttackProjectilesReturn = 2475,
        [Description("Attack Projectiles Return If No Hit Object")]
        AttackProjectilesReturnIfNoHitObject = 2476,
        [Description("Minion Damage +% Per 10 Rampage Stacks")]
        MinionDamagePosPctPer10RampageStacks = 2477,
        [Description("Minion Movement Velocity +% Per 10 Rampage Stacks")]
        MinionMovementVelocityPosPctPer10RampageStacks = 2478,
        [Description("Virtual Minion Damage +%")]
        VirtualMinionDamagePosPct = 2479,
        [Description("Player Dex Mission Enable Pointer")]
        PlayerDexMissionEnablePointer = 2480,
        [Description("Map Hidden Monster Life +% Final")]
        MapHiddenMonsterLifePosPctFinal = 2481,
        [Description("Map Hidden Monster Damage +% Final")]
        MapHiddenMonsterDamagePosPctFinal = 2482,
        [Description("Projectiles Not Offset")]
        ProjectilesNotOffset = 2483,
        [Description("Herald Of Ash Fire Damage +%")]
        HeraldOfAshFireDamagePosPct = 2484,
        [Description("Map Num Extra Invasion Bosses")]
        MapNumExtraInvasionBosses = 2485,
        [Description("Map Num Extra Strongboxes")]
        MapNumExtraStrongboxes = 2486,
        [Description("Map Num Extra Shrines")]
        MapNumExtraShrines = 2487,
        [Description("Map All Monster Packs Rare And Allow Magic")]
        MapAllMonsterPacksRareAndAllowMagic = 2488,
        [Description("Duelist Master Is Dummy Variation")]
        DuelistMasterIsDummyVariation = 2489,
        [Description("Soul Eater Ignore Non Experience Monsters")]
        SoulEaterIgnoreNonExperienceMonsters = 2490,
        [Description("Summoned Monsters Are Minions")]
        SummonedMonstersAreMinions = 2491,
        [Description("Summoned Monsters No Drops Or Experience")]
        SummonedMonstersNoDropsOrExperience = 2492,
        [Description("Monster Do Not Fracture")]
        MonsterDoNotFracture = 2493,
        [Description("Item Generation Cannot Change Prefixes")]
        ItemGenerationCannotChangePrefixes = 2494,
        [Description("Item Generation Cannot Change Suffixes")]
        ItemGenerationCannotChangeSuffixes = 2495,
        [Description("Item Generation Cannot Roll Caster Affixes")]
        ItemGenerationCannotRollCasterAffixes = 2496,
        [Description("Item Generation Cannot Roll Attack Affixes")]
        ItemGenerationCannotRollAttackAffixes = 2497,
        [Description("Item Generation Can Have Multiple Crafted Mods")]
        ItemGenerationCanHaveMultipleCraftedMods = 2498,
        [Description("Map Set League Category")]
        MapSetLeagueCategory = 2499,
        [Description("Local Level Requirement +")]
        LocalLevelRequirementPos = 2500,
        [Description("Projectile Spiral Nova Starting Angle Offset")]
        ProjectileSpiralNovaStartingAngleOffset = 2501,
        [Description("Projectile Spiral Nova Both Directions")]
        ProjectileSpiralNovaBothDirections = 2502,
        [Description("Triggered Spell Spell Damage +%")]
        TriggeredSpellSpellDamagePosPct = 2503,
        [Description("Damage +% Vs Blinded Enemies")]
        DamagePosPctVsBlindedEnemies = 2504,
        [Description("Ground Smoke When Hit %")]
        GroundSmokeWhenHitPct = 2505,
        [Description("Number Of Beacons")]
        NumberOfBeacons = 2506,
        [Description("Is Dead")]
        IsDead = 2507,
        [Description("Area Of Effect +% While Dead")]
        AreaOfEffectPosPctWhileDead = 2508,
        [Description("Beacon Placement Radius")]
        BeaconPlacementRadius = 2509,
        [Description("Map Area Portal Variation")]
        MapAreaPortalVariation = 2510,
        [Description("Skill Is Triggered")]
        SkillIsTriggered = 2511,
        [Description("Skill Is Curse")]
        SkillIsCurse = 2512,
        [Description("Skill Triggerable Spell")]
        SkillTriggerableSpell = 2513,
        [Description("Unique Mjolner Lightning Spells Triggered")]
        UniqueMjolnerLightningSpellsTriggered = 2514,
        [Description("Skill Number Of Triggers")]
        SkillNumberOfTriggers = 2515,
        [Description("Curse On Block Level X Vulnerability")]
        CurseOnBlockLevelXVulnerability = 2516,
        [Description("Monster Enrages On Low Life Text")]
        MonsterEnragesOnLowLifeText = 2517,
        [Description("Drop Bear Fall On Target")]
        DropBearFallOnTarget = 2518,
        [Description("Map Magic Pack Mod Rules")]
        MapMagicPackModRules = 2519,
        [Description("Display Map Has Oxygen")]
        DisplayMapHasOxygen = 2520,
        [Description("Bloodlines Beacon On Death Variation")]
        BloodlinesBeaconOnDeathVariation = 2521,
        [Description("Actor Scale +% Granted To Pack Members On Death")]
        ActorScalePosPctGrantedToPackMembersOnDeath = 2522,
        [Description("Maximum Life +% Granted To Pack Members On Death")]
        MaximumLifePosPctGrantedToPackMembersOnDeath = 2523,
        [Description("Monster Dodge Direction")]
        MonsterDodgeDirection = 2524,
        [Description("Herald Of Ice Cold Damage +%")]
        HeraldOfIceColdDamagePosPct = 2525,
        [Description("Herald Of Thunder Lightning Damage +%")]
        HeraldOfThunderLightningDamagePosPct = 2526,
        [Description("Number Of Taniwha Tails Allowed")]
        NumberOfTaniwhaTailsAllowed = 2527,
        [Description("Minion Dies When Parent Dies")]
        MinionDiesWhenParentDies = 2528,
        [Description("Unique Nearby Allies Recover Permyriad Max Life On Death")]
        UniqueNearbyAlliesRecoverPermyriadMaxLifeOnDeath = 2529,
        [Description("Suppress Mod Stat Display")]
        SuppressModStatDisplay = 2530,
        [Description("Base Steal Power Frenzy Endurance Charges On Hit %")]
        BaseStealPowerFrenzyEnduranceChargesOnHitPct = 2531,
        [Description("Cannot Die And Damage +% Near Pack Corpse")]
        CannotDieAndDamagePosPctNearPackCorpse = 2532,
        [Description("Projectile Spread Radius")]
        ProjectileSpreadRadius = 2533,
        [Description("Local Item Drops On Death If Equipped By Animate Armour")]
        LocalItemDropsOnDeathIfEquippedByAnimateArmour = 2534,
        [Description("Physical Attack Damage +%")]
        PhysicalAttackDamagePosPct = 2535,
        [Description("Melee Physical Damage +% While Holding Shield")]
        MeleePhysicalDamagePosPctWhileHoldingShield = 2536,
        [Description("Local Display Socketed Gems Get Cast On Death Level")]
        LocalDisplaySocketedGemsGetCastOnDeathLevel = 2537,
        [Description("Cluster Burst Spawn Amount")]
        ClusterBurstSpawnAmount = 2538,
        [Description("Bloodline Daemon Update Count On Death")]
        BloodlineDaemonUpdateCountOnDeath = 2539,
        [Description("Bloodline Daemon Pack Death Count")]
        BloodlineDaemonPackDeathCount = 2540,
        [Description("Bloodline Summon Blood Monster On Pack Death")]
        BloodlineSummonBloodMonsterOnPackDeath = 2541,
        [Description("Damage Taken +% Per Bloodline Damage Charge")]
        DamageTakenPosPctPerBloodlineDamageCharge = 2542,
        [Description("Attack Speed +% Per Bloodline Speed Charge")]
        AttackSpeedPosPctPerBloodlineSpeedCharge = 2543,
        [Description("Cast Speed +% Per Bloodline Speed Charge")]
        CastSpeedPosPctPerBloodlineSpeedCharge = 2544,
        [Description("Current Bloodline Damage Charges")]
        CurrentBloodlineDamageCharges = 2545,
        [Description("Current Bloodline Speed Charges")]
        CurrentBloodlineSpeedCharges = 2546,
        [Description("Maximum Bloodline Damage Charges")]
        MaximumBloodlineDamageCharges = 2547,
        [Description("Maximum Bloodline Speed Charges")]
        MaximumBloodlineSpeedCharges = 2548,
        [Description("Apply X Random Curses On Hit")]
        ApplyXRandomCursesOnHit = 2549,
        [Description("Total Projectile Spread Angle Override")]
        TotalProjectileSpreadAngleOverride = 2550,
        [Description("Map Beyond Chance %")]
        MapBeyondChancePct = 2551,
        [Description("Map Boss Vaal Item Drop %")]
        MapBossVaalItemDropPct = 2552,
        [Description("Map Is Corrupted")]
        MapIsCorrupted = 2553,
        [Description("Map No Strongboxes")]
        MapNoStrongboxes = 2554,
        [Description("Keystone Acrobatics Block Chance +% Final")]
        KeystoneAcrobaticsBlockChancePosPctFinal = 2555,
        [Description("Corpse Consumption Affects Pack")]
        CorpseConsumptionAffectsPack = 2556,
        [Description("Damage +% Per Bloodline Damage Charge")]
        DamagePosPctPerBloodlineDamageCharge = 2557,
        [Description("Movement Speed +% Per Bloodline Speed Charge")]
        MovementSpeedPosPctPerBloodlineSpeedCharge = 2558,
        [Description("Active Skill Area Damage +% Final")]
        ActiveSkillAreaDamagePosPctFinal = 2559,
        [Description("Monster Share Charges With Pack")]
        MonsterShareChargesWithPack = 2560,
        [Description("Melee Counterattack Trigger On Block %")]
        MeleeCounterattackTriggerOnBlockPct = 2561,
        [Description("Bloodline Firestorm Scales With Pack Death")]
        BloodlineFirestormScalesWithPackDeath = 2562,
        [Description("Base Fire Damage % Of Maximum Life Plus Maximum Es Taken Per Minute")]
        BaseFireDamagePctOfMaximumLifePlusMaximumESTakenPerMinute = 2563,
        [Description("Is Totem Object")]
        IsTotemObject = 2564,
        [Description("Uses No Mana")]
        UsesNoMana = 2565,
        [Description("Monster Spawn Bloodlines Ghost Totem On Death")]
        MonsterSpawnBloodlinesGhostTotemOnDeath = 2566,
        [Description("Skill Triggerable Attack")]
        SkillTriggerableAttack = 2567,
        [Description("Attack Unusable If Triggerable")]
        AttackUnusableIfTriggerable = 2568,
        [Description("Clone Hidden Duration")]
        CloneHiddenDuration = 2569,
        [Description("Never Take Critical Strike")]
        NeverTakeCriticalStrike = 2570,
        [Description("Tormented Necromancer Spawn Monster On Death Variation")]
        TormentedNecromancerSpawnMonsterOnDeathVariation = 2571,
        [Description("Tormented Mutilator Spawn Monster On Death Variation")]
        TormentedMutilatorSpawnMonsterOnDeathVariation = 2572,
        [Description("Spawn Monster On Death Variation")]
        SpawnMonsterOnDeathVariation = 2573,
        [Description("Map Spawn Tormented Spirits")]
        MapSpawnTormentedSpirits = 2574,
        [Description("Damage +% Vs Frozen Shocked Ignited Enemies")]
        DamagePosPctVsFrozenShockedIgnitedEnemies = 2575,
        [Description("Bloodlines Animate Guardian On Death")]
        BloodlinesAnimateGuardianOnDeath = 2576,
        [Description("Melee Counterattack Trigger On Hit %")]
        MeleeCounterattackTriggerOnHitPct = 2577,
        [Description("Reduce Enemy Dodge %")]
        ReduceEnemyDodgePct = 2578,
        [Description("Shield Counterattack Aoe Range")]
        ShieldCounterattackAoeRange = 2579,
        [Description("Bloodlines Monster Unholy Might Duration Ms")]
        BloodlinesMonsterUnholyMightDurationMs = 2580,
        [Description("Bloodlines Monster Unholy Might Damage Taken +%")]
        BloodlinesMonsterUnholyMightDamageTakenPosPct = 2581,
        [Description("Bloodlines Phylacteral Link Is Vulnerable")]
        BloodlinesPhylacteralLinkIsVulnerable = 2582,
        [Description("Bloodlines Full Guardian Size +% On Death")]
        BloodlinesFullGuardianSizePosPctOnDeath = 2583,
        [Description("Bloodlines Guardian Damage +% On Death")]
        BloodlinesGuardianDamagePosPctOnDeath = 2584,
        [Description("Bloodlines Guardian Attack Speed +% On Death")]
        BloodlinesGuardianAttackSpeedPosPctOnDeath = 2585,
        [Description("Bloodlines Guardian Movement Speed +% On Death")]
        BloodlinesGuardianMovementSpeedPosPctOnDeath = 2586,
        [Description("Bloodlines Force Drop Of Pack Item Type Rarity")]
        BloodlinesForceDropOfPackItemTypeRarity = 2587,
        [Description("Merveil Number Of Geysers")]
        MerveilNumberOfGeysers = 2588,
        [Description("Weapon Elemental Damage +% While Using Flask")]
        WeaponElementalDamagePosPctWhileUsingFlask = 2589,
        [Description("Attack Speed +% While Holding Shield")]
        AttackSpeedPosPctWhileHoldingShield = 2590,
        [Description("Create Trap At Target Location")]
        CreateTrapAtTargetLocation = 2591,
        [Description("Avoid Knockback %")]
        AvoidKnockbackPct = 2592,
        [Description("Bloodlines Corrupted Blood % Average Damage To Deal Per Minute Per Stack For 20 Pack Members")]
        BloodlinesCorruptedBloodPctAverageDamageToDealPerMinutePerStackFor20PackMembers = 2593,
        [Description("Cant Touch This")]
        CantTouchThis = 2594,
        [Description("Cant Possess This")]
        CantPossessThis = 2595,
        [Description("Base Physical Damage % Of Maximum Life Taken Per Minute")]
        BasePhysicalDamagePctOfMaximumLifeTakenPerMinute = 2596,
        [Description("Static Strike Explosion Damage +% Final")]
        StaticStrikeExplosionDamagePosPctFinal = 2597,
        [Description("Disable Highlight")]
        DisableHighlight = 2598,
        [Description("Removes % Mana On Hit")]
        RemovesPctManaOnHit = 2599,
        [Description("Curse When Hit % Silence")]
        CurseWhenHitPctSilence = 2600,
        [Description("Life Gain On Ignited Enemy Hit")]
        LifeGainOnIgnitedEnemyHit = 2601,
        [Description("Minimum Added Physical Damage Vs Frozen Enemies")]
        MinimumAddedPhysicalDamageVsFrozenEnemies = 2602,
        [Description("Maximum Added Physical Damage Vs Frozen Enemies")]
        MaximumAddedPhysicalDamageVsFrozenEnemies = 2603,
        [Description("Damage Vs Shocked Enemies +%")]
        DamageVsShockedEnemiesPosPct = 2604,
        [Description("Old Do Not Use Life Leech Permyriad Vs Shocked Enemies")]
        OldDoNotUseLifeLeechPermyriadVsShockedEnemies = 2605,
        [Description("Physical Damage As Fire Damage Vs Ignited Enemies %")]
        PhysicalDamageAsFireDamageVsIgnitedEnemiesPct = 2606,
        [Description("Local Display Socketed Melee Gems Have Area Radius +%")]
        LocalDisplaySocketedMeleeGemsHaveAreaRadiusPosPct = 2607,
        [Description("Local Display Socketed Red Gems Have % Of Physical Damage To Add As Fire")]
        LocalDisplaySocketedRedGemsHavePctOfPhysicalDamageToAddAsFire = 2608,
        [Description("Curse Effect +% Vs Players")]
        CurseEffectPosPctVsPlayers = 2609,
        [Description("Monster Drop Additional Currency Items")]
        MonsterDropAdditionalCurrencyItems = 2610,
        [Description("Monster Drop Additional Wisdom Scrolls")]
        MonsterDropAdditionalWisdomScrolls = 2611,
        [Description("Monster Drop Additional Portal Scrolls")]
        MonsterDropAdditionalPortalScrolls = 2612,
        [Description("Monster Drop Additional Rings Amulets")]
        MonsterDropAdditionalRingsAmulets = 2613,
        [Description("Item Generation Local Maximum Mod Required Level Override")]
        ItemGenerationLocalMaximumModRequiredLevelOverride = 2614,
        [Description("Block Chance +%")]
        BlockChancePosPct = 2615,
        [Description("Local Unique Flask Physical Damage Taken % As Cold While Healing")]
        LocalUniqueFlaskPhysicalDamageTakenPctAsColdWhileHealing = 2616,
        [Description("Local Unique Flask Physical Damage % To Add As Cold While Healing")]
        LocalUniqueFlaskPhysicalDamagePctToAddAsColdWhileHealing = 2617,
        [Description("Local Unique Flask Avoid Chill % While Healing")]
        LocalUniqueFlaskAvoidChillPctWhileHealing = 2618,
        [Description("Local Unique Flask Avoid Freeze % While Healing")]
        LocalUniqueFlaskAvoidFreezePctWhileHealing = 2619,
        [Description("Monster Drop Additional Map Items")]
        MonsterDropAdditionalMapItems = 2620,
        [Description("Lightning Warp Move Speed Override")]
        LightningWarpMoveSpeedOverride = 2621,
        [Description("Fire Damage Taken % Causes Additional Physical Damage")]
        FireDamageTakenPctCausesAdditionalPhysicalDamage = 2622,
        [Description("Chill Effectiveness On Self +%")]
        ChillEffectivenessOnSelfPosPct = 2623,
        [Description("Temporal Chains Effeciveness +%")]
        TemporalChainsEffecivenessPosPct = 2624,
        [Description("Gain Flask Charge When Crit %")]
        GainFlaskChargeWhenCritPct = 2625,
        [Description("Gain Flask Charge When Crit Amount")]
        GainFlaskChargeWhenCritAmount = 2626,
        [Description("Self Physical Damage On Skill Use % Mana Cost")]
        SelfPhysicalDamageOnSkillUsePctManaCost = 2627,
        [Description("Torment Embezzler Debuff On Hit Recovery Speed +%")]
        TormentEmbezzlerDebuffOnHitRecoverySpeedPosPct = 2628,
        [Description("Monster No Drops When Not Deleted On Death")]
        MonsterNoDropsWhenNotDeletedOnDeath = 2629,
        [Description("Leech Amount +% Final On Crit")]
        LeechAmountPosPctFinalOnCrit = 2630,
        [Description("Unqiue Atzitis Acuity Instant Leech 60% Effectiveness On Crit")]
        UnqiueAtzitisAcuityInstantLeech60PctEffectivenessOnCrit = 2631,
        [Description("Leech Is Instant On Critical")]
        LeechIsInstantOnCritical = 2632,
        [Description("Bleed On Melee Attack Chance %")]
        BleedOnMeleeAttackChancePct = 2633,
        [Description("Physical Damage Over Time +%")]
        PhysicalDamageOverTimePosPct = 2634,
        [Description("Elemental Equilibrium Effect +%")]
        ElementalEquilibriumEffectPosPct = 2635,
        [Description("Local Display Socketed Gems Have Elemental Equilibrium Effect Pluspercent")]
        LocalDisplaySocketedGemsHaveElementalEquilibriumEffectPluspercent = 2636,
        [Description("Attack Damage +%")]
        AttackDamagePosPct = 2637,
        [Description("Attack Damage Vs Bleeding Enemies +%")]
        AttackDamageVsBleedingEnemiesPosPct = 2638,
        [Description("Chance To Gain Endurance Charge On Crit %")]
        ChanceToGainEnduranceChargeOnCritPct = 2639,
        [Description("Chance To Gain Power Charge When Block %")]
        ChanceToGainPowerChargeWhenBlockPct = 2640,
        [Description("Stuns Have Culling Strike")]
        StunsHaveCullingStrike = 2641,
        [Description("Chance To Gain Onslaught On Kill %")]
        ChanceToGainOnslaughtOnKillPct = 2642,
        [Description("Onslaught Time Granted On Kill Ms")]
        OnslaughtTimeGrantedOnKillMs = 2643,
        [Description("Base Main Hand Damage +%")]
        BaseMainHandDamagePosPct = 2644,
        [Description("Base Off Hand Attack Speed +%")]
        BaseOffHandAttackSpeedPosPct = 2645,
        [Description("Damage Vs Enemies On Low Life +%")]
        DamageVsEnemiesOnLowLifePosPct = 2646,
        [Description("Drop Additional Rare Items")]
        DropAdditionalRareItems = 2647,
        [Description("Monster Drop Additional Vaal Items")]
        MonsterDropAdditionalVaalItems = 2648,
        [Description("Bloodlines Shrouded")]
        BloodlinesShrouded = 2649,
        [Description("Monster Pretend To Be Player Level")]
        MonsterPretendToBePlayerLevel = 2650,
        [Description("Monster Display Es When Life Full")]
        MonsterDisplayESWhenLifeFull = 2651,
        [Description("Minimum Added Fire Damage Vs Ignited Enemies")]
        MinimumAddedFireDamageVsIgnitedEnemies = 2652,
        [Description("Maximum Added Fire Damage Vs Ignited Enemies")]
        MaximumAddedFireDamageVsIgnitedEnemies = 2653,
        [Description("Monster Is Possessed")]
        MonsterIsPossessed = 2654,
        [Description("Monster Has Second Form")]
        MonsterHasSecondForm = 2655,
        [Description("Map Crash Instance Debug")]
        MapCrashInstanceDebug = 2656,
        [Description("Map Pause Instance Debug")]
        MapPauseInstanceDebug = 2657,
        [Description("Chance To Gain Endurance Charge On Melee Crit %")]
        ChanceToGainEnduranceChargeOnMeleeCritPct = 2658,
        [Description("Physical Damage Per Endurance Charge +%")]
        PhysicalDamagePerEnduranceChargePosPct = 2659,
        [Description("Penetrate Elemental Resistance Per Frenzy Charge %")]
        PenetrateElementalResistancePerFrenzyChargePct = 2660,
        [Description("Damage Vs Enemies On Full Life Per Power Charge +%")]
        DamageVsEnemiesOnFullLifePerPowerChargePosPct = 2661,
        [Description("Damage Vs Enemies On Low Life Per Power Charge +%")]
        DamageVsEnemiesOnLowLifePerPowerChargePosPct = 2662,
        [Description("Monster Dodge Distance")]
        MonsterDodgeDistance = 2663,
        [Description("Cast Socketed Minion Skills On Bow Kill %")]
        CastSocketedMinionSkillsOnBowKillPct = 2664,
        [Description("Minion Damage +% Per 10 Dex")]
        MinionDamagePosPctPer10Dex = 2665,
        [Description("Unique Bow Minion Spells Triggered")]
        UniqueBowMinionSpellsTriggered = 2666,
        [Description("Local Flask Ignite Immunity While Healing")]
        LocalFlaskIgniteImmunityWhileHealing = 2667,
        [Description("Local Flask Chill And Freeze Immunity While Healing")]
        LocalFlaskChillAndFreezeImmunityWhileHealing = 2668,
        [Description("Local Flask Shock Immunity While Healing")]
        LocalFlaskShockImmunityWhileHealing = 2669,
        [Description("Local Flask Bleeding Immunity While Healing")]
        LocalFlaskBleedingImmunityWhileHealing = 2670,
        [Description("Immune To Bleeding")]
        ImmuneToBleeding = 2671,
        [Description("Local Display Socketed Gems Have Number Of Additional Projectiles")]
        LocalDisplaySocketedGemsHaveNumberOfAdditionalProjectiles = 2672,
        [Description("Local Display Socketed Gems Projectiles Nova")]
        LocalDisplaySocketedGemsProjectilesNova = 2673,
        [Description("Local Display Socketed Gems Skill Effect Duration +%")]
        LocalDisplaySocketedGemsSkillEffectDurationPosPct = 2674,
        [Description("Life Regen Per Minute Per Endurance Charge")]
        LifeRegenPerMinutePerEnduranceCharge = 2675,
        [Description("Vaal Souls Gained Per Minute")]
        VaalSoulsGainedPerMinute = 2676,
        [Description("Attack Damage That Stuns Also Chills")]
        AttackDamageThatStunsAlsoChills = 2677,
        [Description("Cannot Knockback")]
        CannotKnockback = 2678,
        [Description("Cleave Disable Predictive Damage")]
        CleaveDisablePredictiveDamage = 2679,
        [Description("Display Map Contains Grandmasters")]
        DisplayMapContainsGrandmasters = 2680,
        [Description("Gain X Life When Endurance Charge Expires Or Consumed")]
        GainXLifeWhenEnduranceChargeExpiresOrConsumed = 2681,
        [Description("Virtual Maximum Endurance Charges")]
        VirtualMaximumEnduranceCharges = 2682,
        [Description("Virtual Maximum Frenzy Charges")]
        VirtualMaximumFrenzyCharges = 2683,
        [Description("Virtual Maximum Power Charges")]
        VirtualMaximumPowerCharges = 2684,
        [Description("No Maximum Power Charges")]
        NoMaximumPowerCharges = 2685,
        [Description("Damage Vs Cursed Enemies Per Enemy Curse +%")]
        DamageVsCursedEnemiesPerEnemyCursePosPct = 2686,
        [Description("Virtual Ignite Duration +%")]
        VirtualIgniteDurationPosPct = 2687,
        [Description("Virtual Shock Duration +%")]
        VirtualShockDurationPosPct = 2688,
        [Description("Virtual Freeze Duration +%")]
        VirtualFreezeDurationPosPct = 2689,
        [Description("Virtual Chill Duration +%")]
        VirtualChillDurationPosPct = 2690,
        [Description("Base Elemental Status Ailment Duration +%")]
        BaseElementalStatusAilmentDurationPosPct = 2691,
        [Description("Local Display Socketed Gems Supported By X Knockback Level")]
        LocalDisplaySocketedGemsSupportedByXKnockbackLevel = 2692,
        [Description("Enemy Knockback Direction Is Reversed")]
        EnemyKnockbackDirectionIsReversed = 2693,
        [Description("Map Zana Subarea Mission")]
        MapZanaSubareaMission = 2694,
        [Description("Map Zana Subarea Extra Req")]
        MapZanaSubareaExtraReq = 2695,
        [Description("Immune To Ally Buff Auras")]
        ImmuneToAllyBuffAuras = 2696,
        [Description("Buff Auras Dont Affect Allies")]
        BuffAurasDontAffectAllies = 2697,
        [Description("Hits Can Only Kill Frozen Enemies")]
        HitsCanOnlyKillFrozenEnemies = 2698,
        [Description("Spectral Throw Deceleration Override")]
        SpectralThrowDecelerationOverride = 2699,
        [Description("Maximum Life Taken As Physical Damage On Minion Death %")]
        MaximumLifeTakenAsPhysicalDamageOnMinionDeathPct = 2700,
        [Description("Maximum Es Taken As Physical Damage On Minion Death %")]
        MaximumEsTakenAsPhysicalDamageOnMinionDeathPct = 2701,
        [Description("Minion Skill Area Of Effect +%")]
        MinionSkillAreaOfEffectPosPct = 2702,
        [Description("Energy Shield Regeneration % Per Minute While Shocked")]
        EnergyShieldRegenerationPctPerMinuteWhileShocked = 2703,
        [Description("Chest Drops Extra Vaal Fragments")]
        ChestDropsExtraVaalFragments = 2704,
        [Description("Chest Drops Extra Rare Items Of Same Base Type")]
        ChestDropsExtraRareItemsOfSameBaseType = 2705,
        [Description("Ignite Art Variation")]
        IgniteArtVariation = 2706,
        [Description("Curse Apply As Aura")]
        CurseApplyAsAura = 2707,
        [Description("Combined Pvp Damage +% Final")]
        CombinedPvpDamagePosPctFinal = 2708,
        [Description("Support Cast On Death Pvp Damage +% Final")]
        SupportCastOnDeathPvpDamagePosPctFinal = 2709,
        [Description("Support Cast On Damage Taken Pvp Damage +% Final")]
        SupportCastOnDamageTakenPvpDamagePosPctFinal = 2710,
        [Description("Support Cast When Stunned Pvp Damage +% Final")]
        SupportCastWhenStunnedPvpDamagePosPctFinal = 2711,
        [Description("Support Cast On Crit Pvp Damage +% Final")]
        SupportCastOnCritPvpDamagePosPctFinal = 2712,
        [Description("Support Bloodlust Melee Physical Damage +% Final Vs Bleeding Enemies")]
        SupportBloodlustMeleePhysicalDamagePosPctFinalVsBleedingEnemies = 2713,
        [Description("Support Bloodlust Melee Physical Damage +% Final")]
        SupportBloodlustMeleePhysicalDamagePosPctFinal = 2714,
        [Description("Cannot Be Damaged By Nonplayer Damage")]
        CannotBeDamagedByNonplayerDamage = 2715,
        [Description("Cannot Cause Bleeding")]
        CannotCauseBleeding = 2716,
        [Description("Inspiring Cry Damage +% Per One Hundred Nearby Enemies")]
        InspiringCryDamagePosPctPerOneHundredNearbyEnemies = 2717,
        [Description("Charge Duration +%")]
        ChargeDurationPosPct = 2718,
        [Description("Virtual Power Charge Duration +%")]
        VirtualPowerChargeDurationPosPct = 2719,
        [Description("Virtual Endurance Charge Duration +%")]
        VirtualEnduranceChargeDurationPosPct = 2720,
        [Description("Daresso Attack Combo Physical Damage % To Add As Cold")]
        DaressoAttackComboPhysicalDamagePctToAddAsCold = 2721,
        [Description("Old Do Not Use Life Leech From Attack Damage Permyriad Vs Chilled Enemies")]
        OldDoNotUseLifeLeechFromAttackDamagePermyriadVsChilledEnemies = 2722,
        [Description("Base Life Leech From Attack Damage Permyriad")]
        BaseLifeLeechFromAttackDamagePermyriad = 2723,
        [Description("Base Mana Leech From Attack Damage Permyriad")]
        BaseManaLeechFromAttackDamagePermyriad = 2724,
        [Description("Test Stat Check Code")]
        TestStatCheckCode = 2725,
        [Description("Monster Penalty Against Minions Damage +% Final")]
        MonsterPenaltyAgainstMinionsDamagePosPctFinal = 2726,
        [Description("Monster Penalty Against Minions Damage +% Final Vs Player Minions")]
        MonsterPenaltyAgainstMinionsDamagePosPctFinalVsPlayerMinions = 2727,
        [Description("Physical Damage Taken On Minion Death")]
        PhysicalDamageTakenOnMinionDeath = 2728,
        [Description("Abyssal Cry Movement Velocity +% Per One Hundred Nearby Enemies")]
        AbyssalCryMovementVelocityPosPctPerOneHundredNearbyEnemies = 2729,
        [Description("Onslaught Buff Duration On Culling Strike Ms")]
        OnslaughtBuffDurationOnCullingStrikeMs = 2730,
        [Description("Base Avoid Chill % While Have Onslaught")]
        BaseAvoidChillPctWhileHaveOnslaught = 2731,
        [Description("Base Avoid Freeze % While Have Onslaught")]
        BaseAvoidFreezePctWhileHaveOnslaught = 2732,
        [Description("Base Avoid Shock % While Have Onslaught")]
        BaseAvoidShockPctWhileHaveOnslaught = 2733,
        [Description("Base Avoid Ignite % While Have Onslaught")]
        BaseAvoidIgnitePctWhileHaveOnslaught = 2734,
        [Description("Avoid Chill % While Have Onslaught")]
        AvoidChillPctWhileHaveOnslaught = 2735,
        [Description("Avoid Freeze % While Have Onslaught")]
        AvoidFreezePctWhileHaveOnslaught = 2736,
        [Description("Avoid Shock % While Have Onslaught")]
        AvoidShockPctWhileHaveOnslaught = 2737,
        [Description("Avoid Ignite % While Have Onslaught")]
        AvoidIgnitePctWhileHaveOnslaught = 2738,
        [Description("Attack Minimum Added Lightning Damage While Unarmed")]
        AttackMinimumAddedLightningDamageWhileUnarmed = 2739,
        [Description("Attack Maximum Added Lightning Damage While Unarmed")]
        AttackMaximumAddedLightningDamageWhileUnarmed = 2740,
        [Description("Spell Minimum Added Lightning Damage While Unarmed")]
        SpellMinimumAddedLightningDamageWhileUnarmed = 2741,
        [Description("Spell Maximum Added Lightning Damage While Unarmed")]
        SpellMaximumAddedLightningDamageWhileUnarmed = 2742,
        [Description("Gain X Energy Shield On Killing Shocked Enemy")]
        GainXEnergyShieldOnKillingShockedEnemy = 2743,
        [Description("Support Concentrated Effect Skill Area Of Effect +% Final")]
        SupportConcentratedEffectSkillAreaOfEffectPosPctFinal = 2744,
        [Description("Elemental Damage +% Per Frenzy Charge")]
        ElementalDamagePosPctPerFrenzyCharge = 2745,
        [Description("Chaos Damage Poisons")]
        ChaosDamagePoisons = 2746,
        [Description("Mine Extra Uses")]
        MineExtraUses = 2747,
        [Description("From Code Active Skill Damage +% Final")]
        FromCodeActiveSkillDamagePosPctFinal = 2748,
        [Description("Newshocknova First Ring Damage +% Final")]
        NewshocknovaFirstRingDamagePosPctFinal = 2749,
        [Description("Ice Crash Second Hit Damage +% Final")]
        IceCrashSecondHitDamagePosPctFinal = 2750,
        [Description("Killed Monster Dropped Item Rarity +% When Frozen")]
        KilledMonsterDroppedItemRarityPosPctWhenFrozen = 2751,
        [Description("Local Six Linked Sockets")]
        LocalSixLinkedSockets = 2752,
        [Description("Local Display Socketed Gems Get Generosity Level")]
        LocalDisplaySocketedGemsGetGenerosityLevel = 2753,
        [Description("Local Display Socketed Gems Get Remote Mine Level")]
        LocalDisplaySocketedGemsGetRemoteMineLevel = 2754,
        [Description("Local Display Aura Life Regeneration Rate Per Minute %")]
        LocalDisplayAuraLifeRegenerationRatePerMinutePct = 2755,
        [Description("Local Display Aura Mana Regeneration Rate +%")]
        LocalDisplayAuraManaRegenerationRatePosPct = 2756,
        [Description("Unique Insanity Do Weird Things")]
        UniqueInsanityDoWeirdThings = 2757,
        [Description("Base Elemental Damage Heals")]
        BaseElementalDamageHeals = 2758,
        [Description("Base Fire Damage Heals")]
        BaseFireDamageHeals = 2759,
        [Description("Base Cold Damage Heals")]
        BaseColdDamageHeals = 2760,
        [Description("Base Lightning Damage Heals")]
        BaseLightningDamageHeals = 2761,
        [Description("Fire Damage Heals")]
        FireDamageHeals = 2762,
        [Description("Cold Damage Heals")]
        ColdDamageHeals = 2763,
        [Description("Lightning Damage Heals")]
        LightningDamageHeals = 2764,
        [Description("Chance To Gain Power Charge On Melee Stun %")]
        ChanceToGainPowerChargeOnMeleeStunPct = 2765,
        [Description("Gain Unholy Might For 2 Seconds On Melee Crit")]
        GainUnholyMightFor2SecondsOnMeleeCrit = 2766,
        [Description("Unique Mine Damage +% Final")]
        UniqueMineDamagePosPctFinal = 2767,
        [Description("Abyssal Cry % Max Life As Chaos On Death")]
        AbyssalCryPctMaxLifeAsChaosOnDeath = 2768,
        [Description("Ignites Reflected To Self")]
        IgnitesReflectedToSelf = 2769,
        [Description("Avoid Freeze Chill Ignite % While Have Onslaught")]
        AvoidFreezeChillIgnitePctWhileHaveOnslaught = 2770,
        [Description("Sword Physical Damage % To Add As Fire")]
        SwordPhysicalDamagePctToAddAsFire = 2771,
        [Description("Gain Onslaught When Ignited Ms")]
        GainOnslaughtWhenIgnitedMs = 2772,
        [Description("Blind Nearby Enemies When Ignited %")]
        BlindNearbyEnemiesWhenIgnitedPct = 2773,
        [Description("Map Has Weather")]
        MapHasWeather = 2774,
        [Description("Malachai Elemental Cone Spell Minimum Damage")]
        MalachaiElementalConeSpellMinimumDamage = 2775,
        [Description("Malachai Elemental Cone Spell Maximum Damage")]
        MalachaiElementalConeSpellMaximumDamage = 2776,
        [Description("Local Display Socketed Gems Supported By Pierce Level")]
        LocalDisplaySocketedGemsSupportedByPierceLevel = 2777,
        [Description("Map Non Unique Equipment Drops As Sell Price")]
        MapNonUniqueEquipmentDropsAsSellPrice = 2778,
        [Description("Local Flask Use Causes Monster Flee Chance %")]
        LocalFlaskUseCausesMonsterFleeChancePct = 2779,
        [Description("Local Unique Lions Roar Melee Physical Damage +% Final During Flask Effect")]
        LocalUniqueLionsRoarMeleePhysicalDamagePosPctFinalDuringFlaskEffect = 2780,
        [Description("Unique Lions Roar Melee Physical Damage +% Final")]
        UniqueLionsRoarMeleePhysicalDamagePosPctFinal = 2781,
        [Description("Local Flask Adds Knockback During Flask Effect")]
        LocalFlaskAddsKnockbackDuringFlaskEffect = 2782,
        [Description("Map Items Drop Corrupted")]
        MapItemsDropCorrupted = 2783,
        [Description("Chest Number Of Additional Spider Uniques To Drop")]
        ChestNumberOfAdditionalSpiderUniquesToDrop = 2784,
        [Description("Virtual Mana Gain Per Target")]
        VirtualManaGainPerTarget = 2785,
        [Description("Life And Mana Gain Per Hit")]
        LifeAndManaGainPerHit = 2786,
        [Description("Life And Mana Leech From Physical Damage Permyriad")]
        LifeAndManaLeechFromPhysicalDamagePermyriad = 2787,
        [Description("Cannot Inflict Status Ailments")]
        CannotInflictStatusAilments = 2788,
        [Description("Map Weapons Drop Animated")]
        MapWeaponsDropAnimated = 2789,
        [Description("Attacks Bleed On Stun")]
        AttacksBleedOnStun = 2790,
        [Description("Chance To Fortify On Melee Hit +%")]
        ChanceToFortifyOnMeleeHitPosPct = 2791,
        [Description("Taunt Target Id")]
        TauntTargetId = 2792,
        [Description("Spell Minimum Base Cold Damage + Per 10 Intelligence")]
        SpellMinimumBaseColdDamagePosPer10Intelligence = 2793,
        [Description("Spell Maximum Base Cold Damage + Per 10 Intelligence")]
        SpellMaximumBaseColdDamagePosPer10Intelligence = 2794,
        [Description("Skill Effect Duration +% Per 10 Strength")]
        SkillEffectDurationPosPctPer10Strength = 2795,
        [Description("Virtual Skill Effect Duration +%")]
        VirtualSkillEffectDurationPosPct = 2796,
        [Description("Skill Is Fire Skill")]
        SkillIsFireSkill = 2797,
        [Description("Skill Is Cold Skill")]
        SkillIsColdSkill = 2798,
        [Description("Skill Is Lightning Skill")]
        SkillIsLightningSkill = 2799,
        [Description("Ground Slam Cone Angle Override")]
        GroundSlamConeAngleOverride = 2800,
        [Description("Virtual Minion Movement Velocity +%")]
        VirtualMinionMovementVelocityPosPct = 2801,
        [Description("Map Disable Torment Spirits")]
        MapDisableTormentSpirits = 2802,
        [Description("Map Spawn Extra Torment Spirits")]
        MapSpawnExtraTormentSpirits = 2803,
        [Description("Use Goddess Player Audio")]
        UseGoddessPlayerAudio = 2804,
        [Description("Local Display Grants Skill Gluttony Of Elements Level")]
        LocalDisplayGrantsSkillGluttonyOfElementsLevel = 2805,
        [Description("Local Display Socketed Gems Get Pierce Level")]
        LocalDisplaySocketedGemsGetPierceLevel = 2806,
        [Description("Damage With Fire Skills +%")]
        DamageWithFireSkillsPosPct = 2807,
        [Description("Damage With Cold Skills +%")]
        DamageWithColdSkillsPosPct = 2808,
        [Description("Damage With Lightning Skills +%")]
        DamageWithLightningSkillsPosPct = 2809,
        [Description("Cast Speed For Fire Skills +%")]
        CastSpeedForFireSkillsPosPct = 2810,
        [Description("Cast Speed For Cold Skills +%")]
        CastSpeedForColdSkillsPosPct = 2811,
        [Description("Cast Speed For Lightning Skills +%")]
        CastSpeedForLightningSkillsPosPct = 2812,
        [Description("Movement Velocity +% While Phasing")]
        MovementVelocityPosPctWhilePhasing = 2813,
        [Description("Phase On Vaal Skill Use Duration Ms")]
        PhaseOnVaalSkillUseDurationMs = 2814,
        [Description("Monster Inherent Damage Taken +% Final")]
        MonsterInherentDamageTakenPosPctFinal = 2815,
        [Description("Taunt Duration +%")]
        TauntDurationPosPct = 2816,
        [Description("Cyclone Ice Path Radius")]
        CycloneIcePathRadius = 2817,
        [Description("Unarmed Melee Physical Damage +%")]
        UnarmedMeleePhysicalDamagePosPct = 2818,
        [Description("Unarmed Melee Attack Speed +%")]
        UnarmedMeleeAttackSpeedPosPct = 2819,
        [Description("Cast Speed +% While Holding Shield")]
        CastSpeedPosPctWhileHoldingShield = 2820,
        [Description("Cast Speed +% While Holding Staff")]
        CastSpeedPosPctWhileHoldingStaff = 2821,
        [Description("Virtual Energy Shield Gain Per Target")]
        VirtualEnergyShieldGainPerTarget = 2822,
        [Description("Energy Shield Gain Per Target")]
        EnergyShieldGainPerTarget = 2823,
        [Description("Axe Critical Strike Chance +%")]
        AxeCriticalStrikeChancePosPct = 2824,
        [Description("Claw Critical Strike Multiplier +")]
        ClawCriticalStrikeMultiplierPos = 2825,
        [Description("Staff Critical Strike Multiplier +")]
        StaffCriticalStrikeMultiplierPos = 2826,
        [Description("Local Jewel Effect Base Radius")]
        LocalJewelEffectBaseRadius = 2827,
        [Description("Local Jewel Nearby Passives Str To Dex")]
        LocalJewelNearbyPassivesStrToDex = 2828,
        [Description("Local Jewel Nearby Passives Dex To Str")]
        LocalJewelNearbyPassivesDexToStr = 2829,
        [Description("Local Jewel Nearby Passives Str To Int")]
        LocalJewelNearbyPassivesStrToInt = 2830,
        [Description("Local Jewel Nearby Passives Int To Str")]
        LocalJewelNearbyPassivesIntToStr = 2831,
        [Description("Local Jewel Nearby Passives Dex To Int")]
        LocalJewelNearbyPassivesDexToInt = 2832,
        [Description("Local Jewel Nearby Passives Int To Dex")]
        LocalJewelNearbyPassivesIntToDex = 2833,
        [Description("Critical Strike Chance While Wielding Shield +%")]
        CriticalStrikeChanceWhileWieldingShieldPosPct = 2834,
        [Description("Trap Critical Strike Chance +%")]
        TrapCriticalStrikeChancePosPct = 2835,
        [Description("Mine Critical Strike Chance +%")]
        MineCriticalStrikeChancePosPct = 2836,
        [Description("Projectiles Can Shotgun")]
        ProjectilesCanShotgun = 2837,
        [Description("Life Recovery Rate +%")]
        LifeRecoveryRatePosPct = 2838,
        [Description("Mana Recovery Rate +%")]
        ManaRecoveryRatePosPct = 2839,
        [Description("Energy Shield Recovery Rate +%")]
        EnergyShieldRecoveryRatePosPct = 2840,
        [Description("Spell Chance To Shock Frozen Enemies %")]
        SpellChanceToShockFrozenEnemiesPct = 2841,
        [Description("Cannot Be Taunted")]
        CannotBeTaunted = 2842,
        [Description("Cannot Be Taunted When Taunted Ms")]
        CannotBeTauntedWhenTauntedMs = 2843,
        [Description("Attacks Do Not Cost Mana")]
        AttacksDoNotCostMana = 2844,
        [Description("Cannot Leech Or Regenerate Mana")]
        CannotLeechOrRegenerateMana = 2845,
        [Description("Virtual Global Cannot Crit")]
        VirtualGlobalCannotCrit = 2846,
        [Description("Virtual Global Attacks Always Hit")]
        VirtualGlobalAttacksAlwaysHit = 2847,
        [Description("Resolute Technique")]
        ResoluteTechnique = 2848,
        [Description("Local Life And Mana Leech From Physical Damage Permyriad")]
        LocalLifeAndManaLeechFromPhysicalDamagePermyriad = 2849,
        [Description("Main Hand Local Life And Mana Leech From Physical Damage Permyriad")]
        MainHandLocalLifeAndManaLeechFromPhysicalDamagePermyriad = 2850,
        [Description("Off Hand Local Life And Mana Leech From Physical Damage Permyriad")]
        OffHandLocalLifeAndManaLeechFromPhysicalDamagePermyriad = 2851,
        [Description("Local Flask Use Causes Area Knockback")]
        LocalFlaskUseCausesAreaKnockback = 2852,
        [Description("Skill Is Chaos Skill")]
        SkillIsChaosSkill = 2853,
        [Description("Critical Strike Multiplier Is 100")]
        CriticalStrikeMultiplierIs100 = 2854,
        [Description("Can Inflict Multiple Ignites")]
        CanInflictMultipleIgnites = 2855,
        [Description("Ignite Duration -%")]
        IgniteDurationNegPct = 2856,
        [Description("Passive Can Be Allocated Without Connection")]
        PassiveCanBeAllocatedWithoutConnection = 2857,
        [Description("Local Unique Jewel Nearby Disconnected Passives Can Be Allocated")]
        LocalUniqueJewelNearbyDisconnectedPassivesCanBeAllocated = 2858,
        [Description("Local Chance To Bleed On Hit %")]
        LocalChanceToBleedOnHitPct = 2859,
        [Description("Main Hand Local Chance To Bleed On Hit %")]
        MainHandLocalChanceToBleedOnHitPct = 2860,
        [Description("Off Hand Local Chance To Bleed On Hit %")]
        OffHandLocalChanceToBleedOnHitPct = 2861,
        [Description("Skill Total Pvp Damage +% Final")]
        SkillTotalPvpDamagePosPctFinal = 2862,
        [Description("Fire Critical Strike Chance +%")]
        FireCriticalStrikeChancePosPct = 2863,
        [Description("Lightning Critical Strike Chance +%")]
        LightningCriticalStrikeChancePosPct = 2864,
        [Description("Cold Critical Strike Chance +%")]
        ColdCriticalStrikeChancePosPct = 2865,
        [Description("Elemental Critical Strike Chance +%")]
        ElementalCriticalStrikeChancePosPct = 2866,
        [Description("Chaos Critical Strike Chance +%")]
        ChaosCriticalStrikeChancePosPct = 2867,
        [Description("Pvp Shield Damage +% Final")]
        PvpShieldDamagePosPctFinal = 2868,
        [Description("Skill Area Of Effect When Unarmed +%")]
        SkillAreaOfEffectWhenUnarmedPosPct = 2869,
        [Description("Gain X Random Rare Monster Mods On Kill")]
        GainXRandomRareMonsterModsOnKill = 2870,
        [Description("Chance To Gain Power Charge On Stun %")]
        ChanceToGainPowerChargeOnStunPct = 2871,
        [Description("Gain Unholy Might For 2 Seconds On Crit")]
        GainUnholyMightFor2SecondsOnCrit = 2872,
        [Description("Monster Life +% Final From Rarity")]
        MonsterLifePosPctFinalFromRarity = 2873,
        [Description("Monster Life +% Final From Map")]
        MonsterLifePosPctFinalFromMap = 2874,
        [Description("Melee Critical Strike Multiplier + While Wielding Shield")]
        MeleeCriticalStrikeMultiplierPosWhileWieldingShield = 2875,
        [Description("Trap Critical Strike Multiplier +")]
        TrapCriticalStrikeMultiplierPos = 2876,
        [Description("Mine Critical Strike Multiplier +")]
        MineCriticalStrikeMultiplierPos = 2877,
        [Description("Fire Critical Strike Multiplier +")]
        FireCriticalStrikeMultiplierPos = 2878,
        [Description("Lightning Critical Strike Multiplier +")]
        LightningCriticalStrikeMultiplierPos = 2879,
        [Description("Cold Critical Strike Multiplier +")]
        ColdCriticalStrikeMultiplierPos = 2880,
        [Description("Elemental Critical Strike Multiplier +")]
        ElementalCriticalStrikeMultiplierPos = 2881,
        [Description("Chaos Critical Strike Multiplier +")]
        ChaosCriticalStrikeMultiplierPos = 2882,
        [Description("Cast Speed For Chaos Skills +%")]
        CastSpeedForChaosSkillsPosPct = 2883,
        [Description("Spell Block While Dual Wielding %")]
        SpellBlockWhileDualWieldingPct = 2884,
        [Description("Spell Block With Staff %")]
        SpellBlockWithStaffPct = 2885,
        [Description("Recover % Maximum Life When Corpse Destroyed Or Consumed")]
        RecoverPctMaximumLifeWhenCorpseDestroyedOrConsumed = 2886,
        [Description("Local Unique Jewel Totem Life +x% Per 10 Str In Radius")]
        LocalUniqueJewelTotemLifePosXPctPer10StrInRadius = 2887,
        [Description("Minion Chance To Dodge %")]
        MinionChanceToDodgePct = 2888,
        [Description("Local Unique Jewel With 4 Notables Gain X Random Rare Monster Mods On Kill")]
        LocalUniqueJewelWith4NotablesGainXRandomRareMonsterModsOnKill = 2889,
        [Description("Minimum Added Fire Damage Per Active Buff")]
        MinimumAddedFireDamagePerActiveBuff = 2890,
        [Description("Maximum Added Fire Damage Per Active Buff")]
        MaximumAddedFireDamagePerActiveBuff = 2891,
        [Description("Recover % Of Maximum Life On Block")]
        RecoverPctOfMaximumLifeOnBlock = 2892,
        [Description("Minion Recover % Of Maximum Life On Block")]
        MinionRecoverPctOfMaximumLifeOnBlock = 2893,
        [Description("Totems Cannot Be Stunned")]
        TotemsCannotBeStunned = 2894,
        [Description("Is Leeching")]
        IsLeeching = 2895,
        [Description("Damage +% While Leeching")]
        DamagePosPctWhileLeeching = 2896,
        [Description("Is Life Leeching")]
        IsLifeLeeching = 2897,
        [Description("Is Mana Leeching")]
        IsManaLeeching = 2898,
        [Description("Is Es Leeching")]
        IsEsLeeching = 2899,
        [Description("Movement Velocity +% While Ignited")]
        MovementVelocityPosPctWhileIgnited = 2900,
        [Description("Bow Damage +%")]
        BowDamagePosPct = 2901,
        [Description("Display Bow Range +")]
        DisplayBowRangePos = 2902,
        [Description("Bleed On Bow Attack Chance %")]
        BleedOnBowAttackChancePct = 2903,
        [Description("Bow Physical Damage +% While Holding Shield")]
        BowPhysicalDamagePosPctWhileHoldingShield = 2904,
        [Description("Bow Steal Power Frenzy Endurance Charges On Hit %")]
        BowStealPowerFrenzyEnduranceChargesOnHitPct = 2905,
        [Description("Life Leech From Physical Damage With Bow Permyriad")]
        LifeLeechFromPhysicalDamageWithBowPermyriad = 2906,
        [Description("Mana Leech From Physical Damage With Bow Permyriad")]
        ManaLeechFromPhysicalDamageWithBowPermyriad = 2907,
        [Description("Poison On Critical Strike With Bow")]
        PoisonOnCriticalStrikeWithBow = 2908,
        [Description("Bow Elemental Damage +%")]
        BowElementalDamagePosPct = 2909,
        [Description("With Bow Additional Block %")]
        WithBowAdditionalBlockPct = 2910,
        [Description("Bow Enemy Block -%")]
        BowEnemyBlockNegPct = 2911,
        [Description("Local Unique Jewel Melee Applies To Bow")]
        LocalUniqueJewelMeleeAppliesToBow = 2912,
        [Description("Local Unique Jewel Chaos Damage +% Per 10 Int In Radius")]
        LocalUniqueJewelChaosDamagePosPctPer10IntInRadius = 2913,
        [Description("Local Unique Jewel Passives In Radius Applied To Minions Instead")]
        LocalUniqueJewelPassivesInRadiusAppliedToMinionsInstead = 2914,
        [Description("Life Gained On Hit Per Enemy Status Ailment")]
        LifeGainedOnHitPerEnemyStatusAilment = 2915,
        [Description("Life Gained On Spell Hit Per Enemy Status Ailment")]
        LifeGainedOnSpellHitPerEnemyStatusAilment = 2916,
        [Description("Life Regeneration Rate +% While Es Full")]
        LifeRegenerationRatePosPctWhileEsFull = 2917,
        [Description("Local Unique Jewel With X Int In Radius +1 Curse")]
        LocalUniqueJewelWithXIntInRadiusPos1Curse = 2918,
        [Description("Melee Range + While Unarmed")]
        MeleeRangePosWhileUnarmed = 2919,
        [Description("Damage +% Per Equipped Magic Item")]
        DamagePosPctPerEquippedMagicItem = 2920,
        [Description("Number Of Equipped Magic Items")]
        NumberOfEquippedMagicItems = 2921,
        [Description("Base Number Of Golems Allowed")]
        BaseNumberOfGolemsAllowed = 2922,
        [Description("Number Of Golems Allowed")]
        NumberOfGolemsAllowed = 2923,
        [Description("Fire Golem Grants Damage +%")]
        FireGolemGrantsDamagePosPct = 2924,
        [Description("Ice Golem Grants Critical Strike Chance +%")]
        IceGolemGrantsCriticalStrikeChancePosPct = 2925,
        [Description("Ice Golem Grants Accuracy +%")]
        IceGolemGrantsAccuracyPosPct = 2926,
        [Description("Chaos Golem Grants Additional Physical Damage Reduction %")]
        ChaosGolemGrantsAdditionalPhysicalDamageReductionPct = 2927,
        [Description("Spell Damage +% While Es Full")]
        SpellDamagePosPctWhileEsFull = 2928,
        [Description("Virtual Number Of Additional Projectiles")]
        VirtualNumberOfAdditionalProjectiles = 2929,
        [Description("Totem Number Of Additional Projectiles")]
        TotemNumberOfAdditionalProjectiles = 2930,
        [Description("Chance To Dodge Spells % While Es Full")]
        ChanceToDodgeSpellsPctWhileEsFull = 2931,
        [Description("Chance To Gain Unholy Might On Melee Kill %")]
        ChanceToGainUnholyMightOnMeleeKillPct = 2932,
        [Description("Spell Damage +% While No Mana Reserved")]
        SpellDamagePosPctWhileNoManaReserved = 2933,
        [Description("Mana Reserved")]
        ManaReserved = 2934,
        [Description("Spell Damage +% While Not Low Mana")]
        SpellDamagePosPctWhileNotLowMana = 2935,
        [Description("Mana Cost +% While Not Low Mana")]
        ManaCostPosPctWhileNotLowMana = 2936,
        [Description("Local Display Grants Skill Icestorm Level")]
        LocalDisplayGrantsSkillIcestormLevel = 2937,
        [Description("Spell Damage +% Per 10 Int")]
        SpellDamagePosPctPer10Int = 2938,
        [Description("Virtual Firestorm Drop Chilled Ground Duration Ms")]
        VirtualFirestormDropChilledGroundDurationMs = 2939,
        [Description("Virtual Firestorm Drop Shocked Ground Duration Ms")]
        VirtualFirestormDropShockedGroundDurationMs = 2940,
        [Description("Virtual Firestorm Drop Burning Ground Duration Ms")]
        VirtualFirestormDropBurningGroundDurationMs = 2941,
        [Description("Number Of Assigned Keystones")]
        NumberOfAssignedKeystones = 2942,
        [Description("All Attributes +% Per Assigned Keystone")]
        AllAttributesPosPctPerAssignedKeystone = 2943,
        [Description("Number Of Additional Clones")]
        NumberOfAdditionalClones = 2944,
        [Description("Damage Taken +% From Hits")]
        DamageTakenPosPctFromHits = 2945,
        [Description("Chance To Gain Frenzy Charge On Killing Frozen Enemy %")]
        ChanceToGainFrenzyChargeOnKillingFrozenEnemyPct = 2946,
        [Description("Damage +% Vs Frozen Enemies")]
        DamagePosPctVsFrozenEnemies = 2947,
        [Description("Support Hypothermia Damage +% Vs Chilled Enemies Final")]
        SupportHypothermiaDamagePosPctVsChilledEnemiesFinal = 2948,
        [Description("Additional Chance To Freeze Chilled Enemies %")]
        AdditionalChanceToFreezeChilledEnemiesPct = 2949,
        [Description("Onslaught Time Granted On Killing Shocked Enemy Ms")]
        OnslaughtTimeGrantedOnKillingShockedEnemyMs = 2950,
        [Description("Support Hypothermia Damage +% Final")]
        SupportHypothermiaDamagePosPctFinal = 2951,
        [Description("Object Inherent Attack Skills Damage +% Final Per Frenzy Charge")]
        ObjectInherentAttackSkillsDamagePosPctFinalPerFrenzyCharge = 2952,
        [Description("Skill Effect Duration Per 100 Int")]
        SkillEffectDurationPer100Int = 2953,
        [Description("Local Unique Jewel Intelligence Per Unallocated Node In Radius")]
        LocalUniqueJewelIntelligencePerUnallocatedNodeInRadius = 2954,
        [Description("Local Unique Jewel With 70 Dex Physical Damage To Add As Chaos %")]
        LocalUniqueJewelWith70DexPhysicalDamageToAddAsChaosPct = 2955,
        [Description("Local Unique Jewel With 70 Str Life Recovery Speed +%")]
        LocalUniqueJewelWith70StrLifeRecoverySpeedPosPct = 2956,
        [Description("Cannot Be Cursed With Silence")]
        CannotBeCursedWithSilence = 2957,
        [Description("Number Of Equipped Corrupted Items")]
        NumberOfEquippedCorruptedItems = 2958,
        [Description("Vaal Skill Damage +%")]
        VaalSkillDamagePosPct = 2959,
        [Description("Skill Is Vaal Skill")]
        SkillIsVaalSkill = 2960,
        [Description("Damage +% While Dead")]
        DamagePosPctWhileDead = 2961,
        [Description("Chaos Damage +% Per Equipped Corrupted Item")]
        ChaosDamagePosPctPerEquippedCorruptedItem = 2962,
        [Description("Life Leech Speed +% Per Equipped Corrupted Item")]
        LifeLeechSpeedPosPctPerEquippedCorruptedItem = 2963,
        [Description("Virtual Life Leech Speed +%")]
        VirtualLifeLeechSpeedPosPct = 2964,
        [Description("Mana Leech Speed +% Per Equipped Corrupted Item")]
        ManaLeechSpeedPosPctPerEquippedCorruptedItem = 2965,
        [Description("Virtual Mana Leech Speed +%")]
        VirtualManaLeechSpeedPosPct = 2966,
        [Description("Skill Is Attack")]
        SkillIsAttack = 2967,
        [Description("Hundred Times Non Spell Casts Per Second")]
        HundredTimesNonSpellCastsPerSecond = 2968,
        [Description("Sound On Rare Kill Ice Whisper")]
        SoundOnRareKillIceWhisper = 2969,
        [Description("Chance To Gain Vaal Soul On Kill %")]
        ChanceToGainVaalSoulOnKillPct = 2970,
        [Description("Piety Fire Form Hits Cause Stacking Damage Taken")]
        PietyFireFormHitsCauseStackingDamageTaken = 2971,
        [Description("Vaal Skill Effect Duration +%")]
        VaalSkillEffectDurationPosPct = 2972,
        [Description("Energy Shield Protects Mana")]
        EnergyShieldProtectsMana = 2973,
        [Description("Spend Energy Shield For Costs Before Mana")]
        SpendEnergyShieldForCostsBeforeMana = 2974,
        [Description("Vaal Skill Critical Strike Chance +%")]
        VaalSkillCriticalStrikeChancePosPct = 2975,
        [Description("Local Unique Item Limit")]
        LocalUniqueItemLimit = 2976,
        [Description("Vaal Skill Critical Strike Multiplier +")]
        VaalSkillCriticalStrikeMultiplierPos = 2977,
        [Description("Local Display Aura Allies Have Culling Strike")]
        LocalDisplayAuraAlliesHaveCullingStrike = 2978,
        [Description("Local Display Aura Allies Have Increased Item Rarity +%")]
        LocalDisplayAuraAlliesHaveIncreasedItemRarityPosPct = 2979,
        [Description("Chance To Gain Vaal Soul On Enemy Shatter %")]
        ChanceToGainVaalSoulOnEnemyShatterPct = 2980,
        [Description("Mana Cost +% On Totemified Aura Skills")]
        ManaCostPosPctOnTotemifiedAuraSkills = 2981,
        [Description("Skill Is Aura Skill")]
        SkillIsAuraSkill = 2982,
        [Description("Corrupted Gem Experience Gain +%")]
        CorruptedGemExperienceGainPosPct = 2983,
        [Description("Active Skill Attack Damage Final Permyriad")]
        ActiveSkillAttackDamageFinalPermyriad = 2984,
        [Description("Fortify Duration +%")]
        FortifyDurationPosPct = 2985,
        [Description("Support Slower Projectiles Damage +% Final")]
        SupportSlowerProjectilesDamagePosPctFinal = 2986,
        [Description("Chance To Evade Melee Attacks +%")]
        ChanceToEvadeMeleeAttacksPosPct = 2987,
        [Description("Support Elemental Proliferation Damage +% Final")]
        SupportElementalProliferationDamagePosPctFinal = 2988,
        [Description("Flicker Strike More Attack Speed +% Final")]
        FlickerStrikeMoreAttackSpeedPosPctFinal = 2989,
        [Description("Support Minion Damage +% Final")]
        SupportMinionDamagePosPctFinal = 2990,
        [Description("Damage +% Final From Support Minion Damage")]
        DamagePosPctFinalFromSupportMinionDamage = 2991,
        [Description("Life Leech Uses Chaos Damage When X Corrupted Items Equipped")]
        LifeLeechUsesChaosDamageWhenXCorruptedItemsEquipped = 2992,
        [Description("Half Physical Bypasses Es Half Chaos Damages Es When X Corrupted Items Equipped")]
        HalfPhysicalBypassesEsHalfChaosDamagesEsWhenXCorruptedItemsEquipped = 2993,
        [Description("Chaos Damage Damages Energy Shield %")]
        ChaosDamageDamagesEnergyShieldPct = 2994,
        [Description("Physical Damage Bypass Energy Shield %")]
        PhysicalDamageBypassEnergyShieldPct = 2995,
        [Description("Gain Soul Eater With Equipped Corrupted Items On Vaal Skill Use Ms")]
        GainSoulEaterWithEquippedCorruptedItemsOnVaalSkillUseMs = 2996,
        [Description("Base Spell Lightning Damage +%")]
        BaseSpellLightningDamagePosPct = 2997,
        [Description("Wrath Aura Spell Lightning Damage +% Final")]
        WrathAuraSpellLightningDamagePosPctFinal = 2998,
        [Description("Support Slower Projectiles Projectile Speed +% Final")]
        SupportSlowerProjectilesProjectileSpeedPosPctFinal = 2999,
        [Description("Support Reduced Duration Skill Effect Duration +% Final")]
        SupportReducedDurationSkillEffectDurationPosPctFinal = 3000,
        [Description("Maximum Mana % Gained On Kill")]
        MaximumManaPctGainedOnKill = 3001,
        [Description("Maximum Life % Lost On Kill")]
        MaximumLifePctLostOnKill = 3002,
        [Description("Maximum Energy Shield % Lost On Kill")]
        MaximumEnergyShieldPctLostOnKill = 3003,
        [Description("Passive Applies To Minions")]
        PassiveAppliesToMinions = 3004,
        [Description("Chance To Curse Self With Punishment On Kill %")]
        ChanceToCurseSelfWithPunishmentOnKillPct = 3005,
        [Description("Damage Taken +% While Es Full")]
        DamageTakenPosPctWhileEsFull = 3006,
        [Description("Base Deal No Damage")]
        BaseDealNoDamage = 3007,
        [Description("Voll Slam Damage +% Final At Centre")]
        VollSlamDamagePosPctFinalAtCentre = 3008,
        [Description("Local Unique Jewel Evasion Rating +% Per X Dex In Radius")]
        LocalUniqueJewelEvasionRatingPosPctPerXDexInRadius = 3009,
        [Description("Local Unique Jewel Claw Physical Damage +% Per X Dex In Radius")]
        LocalUniqueJewelClawPhysicalDamagePosPctPerXDexInRadius = 3010,
        [Description("Local Unique Jewel Damage Increases Applies To Fire Damage")]
        LocalUniqueJewelDamageIncreasesAppliesToFireDamage = 3011,
        [Description("Fire Sword Damage +%")]
        FireSwordDamagePosPct = 3012,
        [Description("Fire Wand Damage +%")]
        FireWandDamagePosPct = 3013,
        [Description("Two Handed Melee Fire Damage +%")]
        TwoHandedMeleeFireDamagePosPct = 3014,
        [Description("Spell Fire Damage +%")]
        SpellFireDamagePosPct = 3015,
        [Description("Melee Fire Damage +% While Holding Shield")]
        MeleeFireDamagePosPctWhileHoldingShield = 3016,
        [Description("Fire Staff Damage +%")]
        FireStaffDamagePosPct = 3017,
        [Description("Fire Mace Damage +%")]
        FireMaceDamagePosPct = 3018,
        [Description("Fire Damage While Dual Wielding +%")]
        FireDamageWhileDualWieldingPosPct = 3019,
        [Description("Fire Dagger Damage +%")]
        FireDaggerDamagePosPct = 3020,
        [Description("Fire Claw Damage +%")]
        FireClawDamagePosPct = 3021,
        [Description("Fire Bow Damage +%")]
        FireBowDamagePosPct = 3022,
        [Description("Fire Axe Damage +%")]
        FireAxeDamagePosPct = 3023,
        [Description("Fire Attack Damage +%")]
        FireAttackDamagePosPct = 3024,
        [Description("One Handed Melee Fire Damage +%")]
        OneHandedMeleeFireDamagePosPct = 3025,
        [Description("Melee Fire Damage +%")]
        MeleeFireDamagePosPct = 3026,
        [Description("Fire Damage Over Time +%")]
        FireDamageOverTimePosPct = 3027,
        [Description("Local Unique Jewel Physical Damage Increases Applies To Cold Damage")]
        LocalUniqueJewelPhysicalDamageIncreasesAppliesToColdDamage = 3028,
        [Description("Cold Sword Damage +%")]
        ColdSwordDamagePosPct = 3029,
        [Description("Cold Wand Damage +%")]
        ColdWandDamagePosPct = 3030,
        [Description("Two Handed Melee Cold Damage +%")]
        TwoHandedMeleeColdDamagePosPct = 3031,
        [Description("Spell Cold Damage +%")]
        SpellColdDamagePosPct = 3032,
        [Description("Melee Cold Damage +% While Holding Shield")]
        MeleeColdDamagePosPctWhileHoldingShield = 3033,
        [Description("Cold Staff Damage +%")]
        ColdStaffDamagePosPct = 3034,
        [Description("Cold Mace Damage +%")]
        ColdMaceDamagePosPct = 3035,
        [Description("Cold Damage While Dual Wielding +%")]
        ColdDamageWhileDualWieldingPosPct = 3036,
        [Description("Cold Dagger Damage +%")]
        ColdDaggerDamagePosPct = 3037,
        [Description("Cold Claw Damage +%")]
        ColdClawDamagePosPct = 3038,
        [Description("Cold Bow Damage +%")]
        ColdBowDamagePosPct = 3039,
        [Description("Cold Axe Damage +%")]
        ColdAxeDamagePosPct = 3040,
        [Description("Cold Attack Damage +%")]
        ColdAttackDamagePosPct = 3041,
        [Description("One Handed Melee Cold Damage +%")]
        OneHandedMeleeColdDamagePosPct = 3042,
        [Description("Melee Cold Damage +%")]
        MeleeColdDamagePosPct = 3043,
        [Description("Cold Damage Over Time +%")]
        ColdDamageOverTimePosPct = 3044,
        [Description("Additional Staff Block %")]
        AdditionalStaffBlockPct = 3045,
        [Description("Local Unique Jewel Cold Damage Increases Applies To Physical Damage")]
        LocalUniqueJewelColdDamageIncreasesAppliesToPhysicalDamage = 3046,
        [Description("Local Unique Jewel One Additional Maximum Lightning Damage Per X Dex")]
        LocalUniqueJewelOneAdditionalMaximumLightningDamagePerXDex = 3047,
        [Description("Local Unique Jewel Additional Life Per X Int In Radius")]
        LocalUniqueJewelAdditionalLifePerXIntInRadius = 3048,
        [Description("Local Unique Jewel Chaos Damage +% Per X Int In Radius")]
        LocalUniqueJewelChaosDamagePosPctPerXIntInRadius = 3049,
        [Description("Local Unique Jewel Chill Freeze Duration -% Per X Dex In Radius")]
        LocalUniqueJewelChillFreezeDurationNegPctPerXDexInRadius = 3050,
        [Description("Local Unique Jewel Dex And Int Apply To Str Melee Damage Bonus In Radius")]
        LocalUniqueJewelDexAndIntApplyToStrMeleeDamageBonusInRadius = 3051,
        [Description("Melee Damage Bonus Attributes From Jewels")]
        MeleeDamageBonusAttributesFromJewels = 3052,
        [Description("Kaom Number Of Spawners Triggered")]
        KaomNumberOfSpawnersTriggered = 3053,
        [Description("Melee Damage Vs Bleeding Enemies +%")]
        MeleeDamageVsBleedingEnemiesPosPct = 3054,
        [Description("Number Of Active Buffs")]
        NumberOfActiveBuffs = 3055,
        [Description("Fire Mortar Second Hit Damage +% Final")]
        FireMortarSecondHitDamagePosPctFinal = 3056,
        [Description("Support Trap And Mine Damage +% Final")]
        SupportTrapAndMineDamagePosPctFinal = 3057,
        [Description("Active Skill Minion Added Damage +% Final")]
        ActiveSkillMinionAddedDamagePosPctFinal = 3058,
        [Description("Minion Added Damage +% Final From Skill")]
        MinionAddedDamagePosPctFinalFromSkill = 3059,
        [Description("Newpunishment Melee Physical Damage +% Final")]
        NewpunishmentMeleePhysicalDamagePosPctFinal = 3060,
        [Description("Physical Damage +% While Life Leeching")]
        PhysicalDamagePosPctWhileLifeLeeching = 3061,
        [Description("Spell Staff Damage +%")]
        SpellStaffDamagePosPct = 3062,
        [Description("Spell Damage +% While Holding Shield")]
        SpellDamagePosPctWhileHoldingShield = 3063,
        [Description("Spell Damage +% While Dual Wielding")]
        SpellDamagePosPctWhileDualWielding = 3064,
        [Description("Cyclone Places Ground Fire Damage Per Minute")]
        CyclonePlacesGroundFireDamagePerMinute = 3065,
        [Description("Newpunishment Melee Damage +% Final")]
        NewpunishmentMeleeDamagePosPctFinal = 3066,
        [Description("Newpunishment Attack Speed +%")]
        NewpunishmentAttackSpeedPosPct = 3067,
        [Description("Base Strength And Dexterity")]
        BaseStrengthAndDexterity = 3068,
        [Description("Base Strength And Intelligence")]
        BaseStrengthAndIntelligence = 3069,
        [Description("Base Dexterity And Intelligence")]
        BaseDexterityAndIntelligence = 3070,
        [Description("Base Physical Damage % Of Maximum Life To Deal Per Minute")]
        BasePhysicalDamagePctOfMaximumLifeToDealPerMinute = 3071,
        [Description("Has Fortify")]
        HasFortify = 3072,
        [Description("Physical Damage Reduction Rating +% While Fortify Is Active")]
        PhysicalDamageReductionRatingPosPctWhileFortifyIsActive = 3073,
        [Description("Evasion Rating +% While Onslaught Is Active")]
        EvasionRatingPosPctWhileOnslaughtIsActive = 3074,
        [Description("Fortify Effect +%")]
        FortifyEffectPosPct = 3075,
        [Description("Melee Physical Damage +% While Fortify Is Active")]
        MeleePhysicalDamagePosPctWhileFortifyIsActive = 3076,
        [Description("Local Unique Jewel Unarmed Damage +% Per X Dex In Radius")]
        LocalUniqueJewelUnarmedDamagePosPctPerXDexInRadius = 3077,
        [Description("Increased Critical Strike Chance Buff For X Milliseconds On Placing A Totem")]
        IncreasedCriticalStrikeChanceBuffForXMillisecondsOnPlacingATotem = 3078,
        [Description("% Chance To Gain Power Charge On Trap Triggered By An Enemy")]
        PctChanceToGainPowerChargeOnTrapTriggeredByAnEnemy = 3079,
        [Description("% Chance To Gain Power Charge On Mine Detonated Targeting An Enemy")]
        PctChanceToGainPowerChargeOnMineDetonatedTargetingAnEnemy = 3080,
        [Description("Totem Critical Strike Chance +%")]
        TotemCriticalStrikeChancePosPct = 3081,
        [Description("Totem Critical Strike Multiplier +")]
        TotemCriticalStrikeMultiplierPos = 3082,
        [Description("Damage +% Per Active Curse On Self")]
        DamagePosPctPerActiveCurseOnSelf = 3083,
        [Description("Map Force Topology")]
        MapForceTopology = 3084,
        [Description("Maximum Life Leech Rate % Per Minute")]
        MaximumLifeLeechRatePctPerMinute = 3085,
        [Description("Maximum Mana Leech Rate % Per Minute")]
        MaximumManaLeechRatePctPerMinute = 3086,
        [Description("Chill Enemy When Hit Duration Ms")]
        ChillEnemyWhenHitDurationMs = 3087,
        [Description("Ice Crash Third Hit Damage +% Final")]
        IceCrashThirdHitDamagePosPctFinal = 3088,
        [Description("Newpunishment Applied Buff Duration Ms")]
        NewpunishmentAppliedBuffDurationMs = 3089,
        [Description("Recover X Life On Block")]
        RecoverXLifeOnBlock = 3090,
        [Description("Minion Recover X Life On Block")]
        MinionRecoverXLifeOnBlock = 3091,
        [Description("Base Physical Damage % Of Maximum Energy Shield To Deal Per Minute")]
        BasePhysicalDamagePctOfMaximumEnergyShieldToDealPerMinute = 3092,
        [Description("Base Physical Damage % Of Maximum Energy Shield Taken Per Minute")]
        BasePhysicalDamagePctOfMaximumEnergyShieldTakenPerMinute = 3093,
        [Description("Minimum Added Fire Attack Damage Per Active Buff")]
        MinimumAddedFireAttackDamagePerActiveBuff = 3094,
        [Description("Maximum Added Fire Attack Damage Per Active Buff")]
        MaximumAddedFireAttackDamagePerActiveBuff = 3095,
        [Description("Minimum Added Fire Spell Damage Per Active Buff")]
        MinimumAddedFireSpellDamagePerActiveBuff = 3096,
        [Description("Maximum Added Fire Spell Damage Per Active Buff")]
        MaximumAddedFireSpellDamagePerActiveBuff = 3097,
        [Description("Revenant Revive Explode Damage %")]
        RevenantReviveExplodeDamagePct = 3098,
        [Description("New Arctic Armour Physical Damage Taken When Hit +% Final")]
        NewArcticArmourPhysicalDamageTakenWhenHitPosPctFinal = 3099,
        [Description("New Arctic Armour Fire Damage Taken When Hit +% Final")]
        NewArcticArmourFireDamageTakenWhenHitPosPctFinal = 3100,
        [Description("Firestorm Use Server Effects")]
        FirestormUseServerEffects = 3101,
        [Description("Monster No Map Drops")]
        MonsterNoMapDrops = 3102,
        [Description("Local Life Gain Per Target")]
        LocalLifeGainPerTarget = 3103,
        [Description("Base Main Hand Local Life Gain Per Target")]
        BaseMainHandLocalLifeGainPerTarget = 3104,
        [Description("Base Off Hand Local Life Gain Per Target")]
        BaseOffHandLocalLifeGainPerTarget = 3105,
        [Description("Local Mana Gain Per Target")]
        LocalManaGainPerTarget = 3106,
        [Description("Base Main Hand Local Mana Gain Per Target")]
        BaseMainHandLocalManaGainPerTarget = 3107,
        [Description("Base Off Hand Local Mana Gain Per Target")]
        BaseOffHandLocalManaGainPerTarget = 3108,
        [Description("Local Unique Chaos Damage Does Not Bypass Energy Shield During Flask Effect")]
        LocalUniqueChaosDamageDoesNotBypassEnergyShieldDuringFlaskEffect = 3109,
        [Description("Local Unique Remove Life And Regen Es From Removed Life")]
        LocalUniqueRemoveLifeAndRegenEsFromRemovedLife = 3110,
        [Description("Local Unique Regen Es From Removed Life Duration Ms")]
        LocalUniqueRegenEsFromRemovedLifeDurationMs = 3111,
        [Description("Elemental Strike Physical Damage % To Convert")]
        ElementalStrikePhysicalDamagePctToConvert = 3112,
        [Description("Main Hand Local Life Gain Per Target")]
        MainHandLocalLifeGainPerTarget = 3113,
        [Description("Off Hand Local Life Gain Per Target")]
        OffHandLocalLifeGainPerTarget = 3114,
        [Description("Local Life And Mana Gain Per Target")]
        LocalLifeAndManaGainPerTarget = 3115,
        [Description("Base Main Hand Local Life And Mana Gain Per Target")]
        BaseMainHandLocalLifeAndManaGainPerTarget = 3116,
        [Description("Base Off Hand Local Life And Mana Gain Per Target")]
        BaseOffHandLocalLifeAndManaGainPerTarget = 3117,
        [Description("Main Hand Local Mana Gain Per Target")]
        MainHandLocalManaGainPerTarget = 3118,
        [Description("Off Hand Local Mana Gain Per Target")]
        OffHandLocalManaGainPerTarget = 3119,
        [Description("Local Life Leech From Physical Damage Permyriad")]
        LocalLifeLeechFromPhysicalDamagePermyriad = 3120,
        [Description("Main Hand Local Life Leech From Physical Damage Permyriad")]
        MainHandLocalLifeLeechFromPhysicalDamagePermyriad = 3121,
        [Description("Off Hand Local Life Leech From Physical Damage Permyriad")]
        OffHandLocalLifeLeechFromPhysicalDamagePermyriad = 3122,
        [Description("Local Mana Leech From Physical Damage Permyriad")]
        LocalManaLeechFromPhysicalDamagePermyriad = 3123,
        [Description("Main Hand Local Mana Leech From Physical Damage Permyriad")]
        MainHandLocalManaLeechFromPhysicalDamagePermyriad = 3124,
        [Description("Off Hand Local Mana Leech From Physical Damage Permyriad")]
        OffHandLocalManaLeechFromPhysicalDamagePermyriad = 3125,
        [Description("Life Leech From Physical Attack Damage Permyriad")]
        LifeLeechFromPhysicalAttackDamagePermyriad = 3126,
        [Description("Mana Leech From Physical Attack Damage Permyriad")]
        ManaLeechFromPhysicalAttackDamagePermyriad = 3127,
        [Description("Local Flask Life Leech Permyriad While Healing")]
        LocalFlaskLifeLeechPermyriadWhileHealing = 3128,
        [Description("Local Flask Mana Leech Permyriad While Healing")]
        LocalFlaskManaLeechPermyriadWhileHealing = 3129,
        [Description("Base Life Leech From Spell Damage Permyriad")]
        BaseLifeLeechFromSpellDamagePermyriad = 3130,
        [Description("Base Mana Leech From Spell Damage Permyriad")]
        BaseManaLeechFromSpellDamagePermyriad = 3131,
        [Description("Life Leech From Spell Damage Permyriad")]
        LifeLeechFromSpellDamagePermyriad = 3132,
        [Description("Mana Leech From Spell Damage Permyriad")]
        ManaLeechFromSpellDamagePermyriad = 3133,
        [Description("Mana Leech From Physical Damage Permyriad Per Power Charge")]
        ManaLeechFromPhysicalDamagePermyriadPerPowerCharge = 3134,
        [Description("Global Mana Leech From Physical Attack Damage Permyriad Per Blue Socket On Item")]
        GlobalManaLeechFromPhysicalAttackDamagePermyriadPerBlueSocketOnItem = 3135,
        [Description("Base Mana Leech Permyriad Vs Shocked Enemies")]
        BaseManaLeechPermyriadVsShockedEnemies = 3136,
        [Description("Base Life Leech Permyriad Vs Frozen Enemies")]
        BaseLifeLeechPermyriadVsFrozenEnemies = 3137,
        [Description("Mana Leech Permyriad Vs Shocked Enemies")]
        ManaLeechPermyriadVsShockedEnemies = 3138,
        [Description("Life Leech Permyriad Vs Frozen Enemies")]
        LifeLeechPermyriadVsFrozenEnemies = 3139,
        [Description("Base Life Leech From Physical Damage Permyriad")]
        BaseLifeLeechFromPhysicalDamagePermyriad = 3140,
        [Description("Base Life Leech From Fire Damage Permyriad")]
        BaseLifeLeechFromFireDamagePermyriad = 3141,
        [Description("Base Life Leech From Cold Damage Permyriad")]
        BaseLifeLeechFromColdDamagePermyriad = 3142,
        [Description("Base Life Leech From Lightning Damage Permyriad")]
        BaseLifeLeechFromLightningDamagePermyriad = 3143,
        [Description("Base Mana Leech From Lightning Damage Permyriad")]
        BaseManaLeechFromLightningDamagePermyriad = 3144,
        [Description("Local Unique Flask Life Leech From Chaos Damage Permyriad While Healing")]
        LocalUniqueFlaskLifeLeechFromChaosDamagePermyriadWhileHealing = 3145,
        [Description("Base Life Leech From Elemental Damage Permyriad")]
        BaseLifeLeechFromElementalDamagePermyriad = 3146,
        [Description("Life Leech Permyriad On Crit")]
        LifeLeechPermyriadOnCrit = 3147,
        [Description("Base Life Leech Permyriad Vs Shocked Enemies")]
        BaseLifeLeechPermyriadVsShockedEnemies = 3148,
        [Description("Life Leech Permyriad Vs Shocked Enemies")]
        LifeLeechPermyriadVsShockedEnemies = 3149,
        [Description("Base Life Leech From Attack Damage Permyriad Vs Chilled Enemies")]
        BaseLifeLeechFromAttackDamagePermyriadVsChilledEnemies = 3150,
        [Description("Life Leech From Physical Damage With Claw Permyriad")]
        LifeLeechFromPhysicalDamageWithClawPermyriad = 3151,
        [Description("Minion Life Leech From Any Damage Permyriad")]
        MinionLifeLeechFromAnyDamagePermyriad = 3152,
        [Description("Mana Leech From Physical Damage With Claw Permyriad")]
        ManaLeechFromPhysicalDamageWithClawPermyriad = 3153,
        [Description("Life Leech From Attack Damage Permyriad Vs Chilled Enemies")]
        LifeLeechFromAttackDamagePermyriadVsChilledEnemies = 3154,
        [Description("Map Summon Exploding Buff Storms")]
        MapSummonExplodingBuffStorms = 3155,
        [Description("Map Items Have Random Quality")]
        MapItemsHaveRandomQuality = 3156,
        [Description("Map Summon Runic Circles")]
        MapSummonRunicCircles = 3157,
        [Description("Map Spawn Warbands")]
        MapSpawnWarbands = 3158,
        [Description("Chance To Gain Endurance Charge On Bow Crit %")]
        ChanceToGainEnduranceChargeOnBowCritPct = 3159,
        [Description("Global Critical Strike Chance +% While Holding Bow")]
        GlobalCriticalStrikeChancePosPctWhileHoldingBow = 3160,
        [Description("Global Critical Strike Multiplier + While Holding Bow")]
        GlobalCriticalStrikeMultiplierPosWhileHoldingBow = 3161,
        [Description("Map Spawn Extra Warbands")]
        MapSpawnExtraWarbands = 3162,
        [Description("Soul Is Consumed On Death")]
        SoulIsConsumedOnDeath = 3163,
        [Description("Some Passives Apply To Minions")]
        SomePassivesApplyToMinions = 3164,
        [Description("Damage +% With Movement Skills")]
        DamagePosPctWithMovementSkills = 3165,
        [Description("Attack Speed +% With Movement Skills")]
        AttackSpeedPosPctWithMovementSkills = 3166,
        [Description("Life Gained On Killing Ignited Enemies")]
        LifeGainedOnKillingIgnitedEnemies = 3167,
        [Description("Damage Taken +% From Skeletons")]
        DamageTakenPosPctFromSkeletons = 3168,
        [Description("Damage Taken +% From Ghosts")]
        DamageTakenPosPctFromGhosts = 3169,
        [Description("Skill Is Movement Skill")]
        SkillIsMovementSkill = 3170,
        [Description("Cannot Be Shocked While Frozen")]
        CannotBeShockedWhileFrozen = 3171,
        [Description("Local Display Grants Skill Lightning Warp Level")]
        LocalDisplayGrantsSkillLightningWarpLevel = 3172,
        [Description("Life Leech From Attack Damage Permyriad Vs Bleeding Enemies")]
        LifeLeechFromAttackDamagePermyriadVsBleedingEnemies = 3173,
        [Description("Number Of Additional Curses Allowed On Self")]
        NumberOfAdditionalCursesAllowedOnSelf = 3174,
        [Description("Map Spawn Warband Fire")]
        MapSpawnWarbandFire = 3175,
        [Description("Map Spawn Warband Cold")]
        MapSpawnWarbandCold = 3176,
        [Description("Map Spawn Warband Thunder")]
        MapSpawnWarbandThunder = 3177,
        [Description("Map Spawn Warband Chaos")]
        MapSpawnWarbandChaos = 3178,
        [Description("Map Max Warband Rank")]
        MapMaxWarbandRank = 3179,
        [Description("Monster Report Warband Destroyed On Death")]
        MonsterReportWarbandDestroyedOnDeath = 3180,
        [Description("Trap Throw Arm Time Override")]
        TrapThrowArmTimeOverride = 3181,
        [Description("Item Rarity +% While Using Flask")]
        ItemRarityPosPctWhileUsingFlask = 3182,
        [Description("Dropped Items Are Corrupted")]
        DroppedItemsAreCorrupted = 3183,
        [Description("Monster Dropped Non Unique Equipment Drops As Sell Price")]
        MonsterDroppedNonUniqueEquipmentDropsAsSellPrice = 3184,
        [Description("Monster Dropped Items Have Random Quality")]
        MonsterDroppedItemsHaveRandomQuality = 3185,
        [Description("Player Found Items Are Corrupted")]
        PlayerFoundItemsAreCorrupted = 3186,
        [Description("Player Non Unique Equipment Found As Sell Price")]
        PlayerNonUniqueEquipmentFoundAsSellPrice = 3187,
        [Description("Player Found Items Have Random Quality")]
        PlayerFoundItemsHaveRandomQuality = 3188,
        [Description("Map Storm Delay +%")]
        MapStormDelayPosPct = 3189,
        [Description("Map Storm Duration +%")]
        MapStormDurationPosPct = 3190,
        [Description("Map Storm Area Of Effect +%")]
        MapStormAreaOfEffectPosPct = 3191,
        [Description("Map Storm Buff Duration +%")]
        MapStormBuffDurationPosPct = 3192,
        [Description("Map Storm Buff Duration +% On Low Life Target")]
        MapStormBuffDurationPosPctOnLowLifeTarget = 3193,
        [Description("Map Tempest Random Monster Drops Unique")]
        MapTempestRandomMonsterDropsUnique = 3194,
        [Description("Map Tempest Random Monster Drops Map")]
        MapTempestRandomMonsterDropsMap = 3195,
        [Description("Map Tempest Fish School Size +%")]
        MapTempestFishSchoolSizePosPct = 3196,
        [Description("Monster Stormcall Individually Trigger")]
        MonsterStormcallIndividuallyTrigger = 3197,
        [Description("Map Tempest Random Monster Drops Vaal Fragment")]
        MapTempestRandomMonsterDropsVaalFragment = 3198,
        [Description("Map Bosses Have Phylacteral Link")]
        MapBossesHavePhylacteralLink = 3199,
        [Description("Monster Can Have Bloodline")]
        MonsterCanHaveBloodline = 3200,
        [Description("Local Socketed Warcry Gem Level +")]
        LocalSocketedWarcryGemLevelPos = 3201,
        [Description("Mana Gained On Hitting Taunted Enemy")]
        ManaGainedOnHittingTauntedEnemy = 3202,
        [Description("Life Gained On Taunting Enemy")]
        LifeGainedOnTauntingEnemy = 3203,
        [Description("Onslaught Buff Duration On Killing Taunted Enemy Ms")]
        OnslaughtBuffDurationOnKillingTauntedEnemyMs = 3204,
        [Description("Local Socketed Golem Gem Level +")]
        LocalSocketedGolemGemLevelPos = 3205,
        [Description("Local Display Socketed Gems Supported By X Increased Minion Life Level")]
        LocalDisplaySocketedGemsSupportedByXIncreasedMinionLifeLevel = 3206,
        [Description("Local Display Socketed Gems Supported By X Lesser Multiple Projectiles Level")]
        LocalDisplaySocketedGemsSupportedByXLesserMultipleProjectilesLevel = 3207,
        [Description("Local Display Socketed Gems Supported By X Increased Minion Damage Level")]
        LocalDisplaySocketedGemsSupportedByXIncreasedMinionDamageLevel = 3208,
        [Description("Local Display Socketed Gems Supported By X Increased Critical Damage Level")]
        LocalDisplaySocketedGemsSupportedByXIncreasedCriticalDamageLevel = 3209,
        [Description("Number Of Power Charges To Gain")]
        NumberOfPowerChargesToGain = 3210,
        [Description("Number Of Frenzy Charges To Gain")]
        NumberOfFrenzyChargesToGain = 3211,
        [Description("Number Of Endurance Charges To Gain")]
        NumberOfEnduranceChargesToGain = 3212,
        [Description("Animate Weapon Duration +%")]
        AnimateWeaponDurationPosPct = 3213,
        [Description("Totem Skill Area Of Effect +%")]
        TotemSkillAreaOfEffectPosPct = 3214,
        [Description("Life Leech From Skills Used By Totems Permyriad")]
        LifeLeechFromSkillsUsedByTotemsPermyriad = 3215,
        [Description("Damage Reflected To Enemies % Gained As Life")]
        DamageReflectedToEnemiesPctGainedAsLife = 3216,
        [Description("Animate Weapon Number Of Additional Copies")]
        AnimateWeaponNumberOfAdditionalCopies = 3217,
        [Description("Cannot Drop Below % Life")]
        CannotDropBelowPctLife = 3218,
        [Description("Local Display Socketed Gems Supported By X Increased Minion Speed Level")]
        LocalDisplaySocketedGemsSupportedByXIncreasedMinionSpeedLevel = 3219,
        [Description("Attack Is Not Melee Override")]
        AttackIsNotMeleeOverride = 3220,
        [Description("Map Storm Delay +% Final")]
        MapStormDelayPosPctFinal = 3221,
        [Description("Map Storm Duration +% Final")]
        MapStormDurationPosPctFinal = 3222,
        [Description("Map Always Has Weather")]
        MapAlwaysHasWeather = 3223,
        [Description("Melee Weapon Range +")]
        MeleeWeaponRangePos = 3224,
        [Description("Damage +% Vs Players")]
        DamagePosPctVsPlayers = 3225,
        [Description("Immune Vaal Lighting Warp")]
        ImmuneVaalLightingWarp = 3226,
        [Description("Base Secondary Skill Effect Duration")]
        BaseSecondarySkillEffectDuration = 3227,
        [Description("Secondary Skill Effect Duration")]
        SecondarySkillEffectDuration = 3228,
        [Description("Enemy Aggro Radius +%")]
        EnemyAggroRadiusPosPct = 3229,
        [Description("Skill Effect Duration +% Per Frenzy Charge")]
        SkillEffectDurationPosPctPerFrenzyCharge = 3230,
        [Description("Chilled Ground Effect On Self +%")]
        ChilledGroundEffectOnSelfPosPct = 3231,
        [Description("Burning Ground Effect On Self +%")]
        BurningGroundEffectOnSelfPosPct = 3232,
        [Description("Shocked Ground Effect On Self +%")]
        ShockedGroundEffectOnSelfPosPct = 3233,
        [Description("Desecrated Ground Effect On Self +%")]
        DesecratedGroundEffectOnSelfPosPct = 3234,
        [Description("Spell And Attack Minimum Added Lightning Damage")]
        SpellAndAttackMinimumAddedLightningDamage = 3235,
        [Description("Spell And Attack Maximum Added Lightning Damage")]
        SpellAndAttackMaximumAddedLightningDamage = 3236,
        [Description("Shocked Ground When Hit %")]
        ShockedGroundWhenHitPct = 3237,
        [Description("Map Tempest Base Ground Fire Damage To Deal Per Minute")]
        MapTempestBaseGroundFireDamageToDealPerMinute = 3238,
        [Description("Map Tempest Base Ground Desecration Damage To Deal Per Minute")]
        MapTempestBaseGroundDesecrationDamageToDealPerMinute = 3239,
        [Description("Map Tempest Ground Ice")]
        MapTempestGroundIce = 3240,
        [Description("Map Tempest Ground Tar Movement Speed +%")]
        MapTempestGroundTarMovementSpeedPosPct = 3241,
        [Description("Map Tempest Ground Lightning")]
        MapTempestGroundLightning = 3242,
        [Description("Map Tempest Ground Effect Patches Per 100 Tiles")]
        MapTempestGroundEffectPatchesPer100Tiles = 3243,
        [Description("Map Tempest Ground Effect Radius")]
        MapTempestGroundEffectRadius = 3244,
        [Description("Projectile Minimum Range")]
        ProjectileMinimumRange = 3245,
        [Description("Projectile Speed Variation +%")]
        ProjectileSpeedVariationPosPct = 3246,
        [Description("Secondary Buff Effect Duration")]
        SecondaryBuffEffectDuration = 3247,
        [Description("Level 1 To 40 Life +% Final")]
        Level1To40LifePosPctFinal = 3248,
        [Description("Level 41 To 57 Life +% Final")]
        Level41To57LifePosPctFinal = 3249,
        [Description("Level 58 To 70 Life +% Final")]
        Level58To70LifePosPctFinal = 3250,
        [Description("Local Unique Jewel Energy Shield Increases Applies To Armour Doubled")]
        LocalUniqueJewelEnergyShieldIncreasesAppliesToArmourDoubled = 3251,
        [Description("Local Unique Jewel Life Increases Applies To Energy Shield")]
        LocalUniqueJewelLifeIncreasesAppliesToEnergyShield = 3252,
        [Description("Local Unique Jewel Life Increases Applies To Mana Doubled")]
        LocalUniqueJewelLifeIncreasesAppliesToManaDoubled = 3253,
        [Description("Cyclone First Hit Damage +% Final")]
        CycloneFirstHitDamagePosPctFinal = 3254,
        [Description("Cannot Use Warcries")]
        CannotUseWarcries = 3255,
        [Description("Map Debug Disable Nonboss Monsters")]
        MapDebugDisableNonbossMonsters = 3256,
        [Description("Totem Mana +%")]
        TotemManaPosPct = 3257,
        [Description("Totem Energy Shield +%")]
        TotemEnergyShieldPosPct = 3258,
        [Description("Minion Maximum Mana +%")]
        MinionMaximumManaPosPct = 3259,
        [Description("Minion Maximum Energy Shield +%")]
        MinionMaximumEnergyShieldPosPct = 3260,
        [Description("Base Maximum Life Per Red Socket On Item")]
        BaseMaximumLifePerRedSocketOnItem = 3261,
        [Description("Base Maximum Energy Shield Per Blue Socket On Item")]
        BaseMaximumEnergyShieldPerBlueSocketOnItem = 3262,
        [Description("Base Maximum Mana Per Green Socket On Item")]
        BaseMaximumManaPerGreenSocketOnItem = 3263,
        [Description("Currently Has No Energy Shield")]
        CurrentlyHasNoEnergyShield = 3264,
        [Description("Damage +% When Currently Has No Energy Shield")]
        DamagePosPctWhenCurrentlyHasNoEnergyShield = 3265,
        [Description("Chance To Gain Unholy Might On Block %")]
        ChanceToGainUnholyMightOnBlockPct = 3266,
        [Description("Damage +% When On Burning Ground")]
        DamagePosPctWhenOnBurningGround = 3267,
        [Description("Life Regeneration Rate Per Minute % When On Chilled Ground")]
        LifeRegenerationRatePerMinutePctWhenOnChilledGround = 3268,
        [Description("Movement Velocity +% When On Shocked Ground")]
        MovementVelocityPosPctWhenOnShockedGround = 3269,
        [Description("Is On Ground Fire Burn")]
        IsOnGroundFireBurn = 3270,
        [Description("Is On Ground Ice Chill")]
        IsOnGroundIceChill = 3271,
        [Description("Is On Ground Lightning Shock")]
        IsOnGroundLightningShock = 3272,
        [Description("Damage Taken Goes To Mana % Per Power Charge")]
        DamageTakenGoesToManaPctPerPowerCharge = 3273,
        [Description("Power Charge Art Variation")]
        PowerChargeArtVariation = 3274,
        [Description("Map Tempest Display Prefix")]
        MapTempestDisplayPrefix = 3275,
        [Description("Map Tempest Display Suffix")]
        MapTempestDisplaySuffix = 3276,
        [Description("Temporal Chains Action Speed +% Final")]
        TemporalChainsActionSpeedPosPctFinal = 3277,
        [Description("Virtual Action Speed +%")]
        VirtualActionSpeedPosPct = 3278,
        [Description("Light Radius +% While Phased")]
        LightRadiusPosPctWhilePhased = 3279,
        [Description("Map Monsters Area Of Effect +%")]
        MapMonstersAreaOfEffectPosPct = 3280,
        [Description("Map Monsters Avoid Freeze And Chill %")]
        MapMonstersAvoidFreezeAndChillPct = 3281,
        [Description("Map Monsters Avoid Ignite %")]
        MapMonstersAvoidIgnitePct = 3282,
        [Description("Map Monsters Avoid Shock %")]
        MapMonstersAvoidShockPct = 3283,
        [Description("Map Monsters Avoid Elemental Ailments %")]
        MapMonstersAvoidElementalAilmentsPct = 3284,
        [Description("Map Monsters Critical Strike Chance +%")]
        MapMonstersCriticalStrikeChancePosPct = 3285,
        [Description("Map Monsters Critical Strike Multiplier +")]
        MapMonstersCriticalStrikeMultiplierPos = 3286,
        [Description("Map Monsters Life Leech Resistance %")]
        MapMonstersLifeLeechResistancePct = 3287,
        [Description("Map Monsters Mana Leech Resistance %")]
        MapMonstersManaLeechResistancePct = 3288,
        [Description("Map Boss Maximum Life +%")]
        MapBossMaximumLifePosPct = 3289,
        [Description("Map Boss Area Of Effect +%")]
        MapBossAreaOfEffectPosPct = 3290,
        [Description("Map Hidden Experience Gain +%")]
        MapHiddenExperienceGainPosPct = 3291,
        [Description("Map Hidden Rare Monsters Have Nemesis Mod")]
        MapHiddenRareMonstersHaveNemesisMod = 3292,
        [Description("Map Hidden Spawn Extra Exiles")]
        MapHiddenSpawnExtraExiles = 3293,
        [Description("Map Hidden Spawn Extra Torment Spirits")]
        MapHiddenSpawnExtraTormentSpirits = 3294,
        [Description("Map Hidden Magic Pack Mod Rules")]
        MapHiddenMagicPackModRules = 3295,
        [Description("Map Hidden Monsters Additional Fire Resistance")]
        MapHiddenMonstersAdditionalFireResistance = 3296,
        [Description("Map Hidden Monsters Additional Cold Resistance")]
        MapHiddenMonstersAdditionalColdResistance = 3297,
        [Description("Map Hidden Monsters Additional Lightning Resistance")]
        MapHiddenMonstersAdditionalLightningResistance = 3298,
        [Description("Map Hidden Monsters Poison On Hit")]
        MapHiddenMonstersPoisonOnHit = 3299,
        [Description("Map Hidden Monsters % Physical Damage To Add As Fire")]
        MapHiddenMonstersPctPhysicalDamageToAddAsFire = 3300,
        [Description("Map Hidden Monsters % Physical Damage To Add As Cold")]
        MapHiddenMonstersPctPhysicalDamageToAddAsCold = 3301,
        [Description("Map Hidden Monsters % Physical Damage To Add As Lightning")]
        MapHiddenMonstersPctPhysicalDamageToAddAsLightning = 3302,
        [Description("Map Hidden Monsters % Physical Damage To Add As Chaos")]
        MapHiddenMonstersPctPhysicalDamageToAddAsChaos = 3303,
        [Description("Map Hidden Packs Are Totems")]
        MapHiddenPacksAreTotems = 3304,
        [Description("Skill Effect Duration Per 100 Int +%")]
        SkillEffectDurationPer100IntPosPct = 3305,
        [Description("Map Equipment Drops Identified")]
        MapEquipmentDropsIdentified = 3306,
        [Description("Player Found Equipment Drops Identified")]
        PlayerFoundEquipmentDropsIdentified = 3307,
        [Description("Monster Equipment Drops Identified")]
        MonsterEquipmentDropsIdentified = 3308,
        [Description("Flask Charges Gained +% During Flask Effect")]
        FlaskChargesGainedPosPctDuringFlaskEffect = 3309,
        [Description("Mana Regeneration Rate +% During Flask Effect")]
        ManaRegenerationRatePosPctDuringFlaskEffect = 3310,
        [Description("Movement Speed +% During Flask Effect")]
        MovementSpeedPosPctDuringFlaskEffect = 3311,
        [Description("Map Player Has Level X Punishment")]
        MapPlayerHasLevelXPunishment = 3312,
        [Description("Item Found Quantity +% Per White Socket On Item")]
        ItemFoundQuantityPosPctPerWhiteSocketOnItem = 3313,
        [Description("Monster Number Of Additional Players")]
        MonsterNumberOfAdditionalPlayers = 3314,
        [Description("Local Unique Jewel Physical Attack Damage +1% Per X Strength In Radius")]
        LocalUniqueJewelPhysicalAttackDamagePos1PctPerXStrengthInRadius = 3315,
        [Description("Local Unique Jewel Fortify Duration +1% Per X Int In Radius")]
        LocalUniqueJewelFortifyDurationPos1PctPerXIntInRadius = 3316,
        [Description("Local Unique Jewel Fire Damage +1% Per X Int In Radius")]
        LocalUniqueJewelFireDamagePos1PctPerXIntInRadius = 3317,
        [Description("Local Unique Jewel Cold Damage +1% Per X Int In Radius")]
        LocalUniqueJewelColdDamagePos1PctPerXIntInRadius = 3318,
        [Description("Local Unique Jewel Physical Damage +1% Per Int In Radius")]
        LocalUniqueJewelPhysicalDamagePos1PctPerIntInRadius = 3319,
        [Description("Local Unique Jewel Physical Attack Damage +1% Per X Dex In Radius")]
        LocalUniqueJewelPhysicalAttackDamagePos1PctPerXDexInRadius = 3320,
        [Description("Local Unique Jewel Projectile Damage +1% Per X Dex In Radius")]
        LocalUniqueJewelProjectileDamagePos1PctPerXDexInRadius = 3321,
        [Description("Local Unique Jewel Fireball Explosion Radius 20% Less At Close Range 50% More At Long Range With X Int In Radius")]
        LocalUniqueJewelFireballExplosionRadius20PctLessAtCloseRange50PctMoreAtLongRangeWithXIntInRadius = 3322,
        [Description("Local Unique Jewel Glacial Cascade Additional Sequence With X Int In Radius")]
        LocalUniqueJewelGlacialCascadeAdditionalSequenceWithXIntInRadius = 3323,
        [Description("Local Unique Jewel Animate Weapon Animates Bows And Wands With X Dex In Radius")]
        LocalUniqueJewelAnimateWeaponAnimatesBowsAndWandsWithXDexInRadius = 3324,
        [Description("Local Unique Jewel Split Arrow Fires Additional Arrow With X Dex In Radius")]
        LocalUniqueJewelSplitArrowFiresAdditionalArrowWithXDexInRadius = 3325,
        [Description("Vigilant Strike Applies To Nearby Allies For X Seconds")]
        VigilantStrikeAppliesToNearbyAlliesForXSeconds = 3326,
        [Description("Split Arrow Number Of Additional Arrows")]
        SplitArrowNumberOfAdditionalArrows = 3327,
        [Description("Animate Weapon Can Animate Bows")]
        AnimateWeaponCanAnimateBows = 3328,
        [Description("Animate Weapon Can Animate Wands")]
        AnimateWeaponCanAnimateWands = 3329,
        [Description("Fireball Explosion Radius 20% Less At Close Range 50% More At Long Range")]
        FireballExplosionRadius20PctLessAtCloseRange50PctMoreAtLongRange = 3330,
        [Description("Total Physical Damage Taken Per Minute")]
        TotalPhysicalDamageTakenPerMinute = 3331,
        [Description("Total Fire Damage Taken Per Minute")]
        TotalFireDamageTakenPerMinute = 3332,
        [Description("Total Cold Damage Taken Per Minute")]
        TotalColdDamageTakenPerMinute = 3333,
        [Description("Total Lightning Damage Taken Per Minute")]
        TotalLightningDamageTakenPerMinute = 3334,
        [Description("Total Chaos Damage Taken Per Minute")]
        TotalChaosDamageTakenPerMinute = 3335,
        [Description("Total Nonlethal Fire Damage Taken Per Minute")]
        TotalNonlethalFireDamageTakenPerMinute = 3336,
        [Description("Total Damage Taken Per Minute To Energy Shield")]
        TotalDamageTakenPerMinuteToEnergyShield = 3337,
        [Description("Total Damage Taken Per Minute To Life")]
        TotalDamageTakenPerMinuteToLife = 3338,
        [Description("Total Nonlethal Damage Taken Per Minute To Energy Shield")]
        TotalNonlethalDamageTakenPerMinuteToEnergyShield = 3339,
        [Description("Total Nonlethal Damage Taken Per Minute To Life")]
        TotalNonlethalDamageTakenPerMinuteToLife = 3340,
        [Description("Total Healing From Damage Taken Per Minute")]
        TotalHealingFromDamageTakenPerMinute = 3341,
        [Description("Chance To Gain Unholy Might On Kill For 3 Seconds %")]
        ChanceToGainUnholyMightOnKillFor3SecondsPct = 3342,
        [Description("Chance To Grant Nearby Enemies Onslaught On Kill %")]
        ChanceToGrantNearbyEnemiesOnslaughtOnKillPct = 3343,
        [Description("Chance To Grant Nearby Enemies Unholy Might On Kill %")]
        ChanceToGrantNearbyEnemiesUnholyMightOnKillPct = 3344,
        [Description("Recover % Maximum Life On Kill")]
        RecoverPctMaximumLifeOnKill = 3345,
        [Description("Chance To Cast On Kill % Target Self")]
        ChanceToCastOnKillPctTargetSelf = 3346,
        [Description("Socketed Trap Skills Create Smoke Cloud")]
        SocketedTrapSkillsCreateSmokeCloud = 3347,
        [Description("Fire Damage +% To Blinded Enemies")]
        FireDamagePosPctToBlindedEnemies = 3348,
        [Description("Spell Damage Taken +% From Blinded Enemies")]
        SpellDamageTakenPosPctFromBlindedEnemies = 3349,
        [Description("Curse Enemies With Level X Assassins Mark When Curse Cast")]
        CurseEnemiesWithLevelXAssassinsMarkWhenCurseCast = 3350,
        [Description("Disable Weapons")]
        DisableWeapons = 3351,
        [Description("Shock Dispelled On Full Energy Shield")]
        ShockDispelledOnFullEnergyShield = 3352,
        [Description("Local Display Nearby Enemies Take X Lightning Damage Per Minute")]
        LocalDisplayNearbyEnemiesTakeXLightningDamagePerMinute = 3353,
        [Description("Item Destroyed On Death")]
        ItemDestroyedOnDeath = 3354,
        [Description("Summoned Monsters Set Parent")]
        SummonedMonstersSetParent = 3355,
        [Description("Maximum Number Of Spinning Blades")]
        MaximumNumberOfSpinningBlades = 3356,
        [Description("Ball Lightning Damage +%")]
        BallLightningDamagePosPct = 3357,
        [Description("Cast When Critically Hit %")]
        CastWhenCriticallyHitPct = 3358,
        [Description("Attack Trigger On Hit %")]
        AttackTriggerOnHitPct = 3359,
        [Description("Cast On Hit %")]
        CastOnHitPct = 3360,
        [Description("Map Spawn Talismans")]
        MapSpawnTalismans = 3361,
        [Description("Map Spawn Extra Talismans")]
        MapSpawnExtraTalismans = 3362,
        [Description("Map Hidden Num Extra Invasion Bosses")]
        MapHiddenNumExtraInvasionBosses = 3363,
        [Description("Monster No Talismans")]
        MonsterNoTalismans = 3364,
        [Description("Enchantment Boots Life And Mana Regen Per Minute % For 4 Seconds When Hit")]
        EnchantmentBootsLifeAndManaRegenPerMinutePctFor4SecondsWhenHit = 3365,
        [Description("Fire Damage Taken % As Lightning")]
        FireDamageTakenPctAsLightning = 3366,
        [Description("Fire Damage Taken % As Cold")]
        FireDamageTakenPctAsCold = 3367,
        [Description("Lightning Damage Taken % As Cold")]
        LightningDamageTakenPctAsCold = 3368,
        [Description("Lightning Damage Taken % As Fire")]
        LightningDamageTakenPctAsFire = 3369,
        [Description("Cold Damage Taken % As Lightning")]
        ColdDamageTakenPctAsLightning = 3370,
        [Description("Cold Damage Taken % As Fire")]
        ColdDamageTakenPctAsFire = 3371,
        [Description("All Attributes +%")]
        AllAttributesPosPct = 3372,
        [Description("Base Cooldown Speed +%")]
        BaseCooldownSpeedPosPct = 3373,
        [Description("Virtual Cooldown Speed +%")]
        VirtualCooldownSpeedPosPct = 3374,
        [Description("Base Righteous Lightning % Of Max Mana To Deal To Nearby Per Minute")]
        BaseRighteousLightningPctOfMaxManaToDealToNearbyPerMinute = 3375,
        [Description("Righteous Lightning Critical Strike Chance +%")]
        RighteousLightningCriticalStrikeChancePosPct = 3376,
        [Description("Mana Degeneration Per Minute %")]
        ManaDegenerationPerMinutePct = 3377,
        [Description("Active Skill Index")]
        ActiveSkillIndex = 3378,
        [Description("Stun Threshold Based On % Mana Instead Of Life")]
        StunThresholdBasedOnPctManaInsteadOfLife = 3379,
        [Description("Local Flask Gain X Seconds Of Onslaught Per Frenzy Charge")]
        LocalFlaskGainXSecondsOfOnslaughtPerFrenzyCharge = 3380,
        [Description("Life Leech Applies To Enemies %")]
        LifeLeechAppliesToEnemiesPct = 3381,
        [Description("Enchantment Boots Minimum Added Fire Damage On Kill 4s")]
        EnchantmentBootsMinimumAddedFireDamageOnKill4s = 3382,
        [Description("Enchantment Boots Maximum Added Fire Damage On Kill 4s")]
        EnchantmentBootsMaximumAddedFireDamageOnKill4s = 3383,
        [Description("Enchantment Boots Movement Speed +% When Not Hit For 4 Seconds")]
        EnchantmentBootsMovementSpeedPosPctWhenNotHitFor4Seconds = 3384,
        [Description("Enchantment Boots Dodge Chance When Critically Hit %")]
        EnchantmentBootsDodgeChanceWhenCriticallyHitPct = 3385,
        [Description("Enchantment Boots Status Ailment Chance +% When Havent Crit For 4 Seconds")]
        EnchantmentBootsStatusAilmentChancePosPctWhenHaventCritFor4Seconds = 3386,
        [Description("Base Chance To Stun %")]
        BaseChanceToStunPct = 3387,
        [Description("Display Cast Word Of Flames On Kill %")]
        DisplayCastWordOfFlamesOnKillPct = 3388,
        [Description("Display Cast Word Of Blades On Kill %")]
        DisplayCastWordOfBladesOnKillPct = 3389,
        [Description("Display Cast Word Of Reflection On Kill %")]
        DisplayCastWordOfReflectionOnKillPct = 3390,
        [Description("Display Cast Word Of Force On Hit %")]
        DisplayCastWordOfForceOnHitPct = 3391,
        [Description("Display Cast Word Of Light When Hit %")]
        DisplayCastWordOfLightWhenHitPct = 3392,
        [Description("Display Cast Word Of Thunder On Hit %")]
        DisplayCastWordOfThunderOnHitPct = 3393,
        [Description("Display Cast Word Of The Grave On Kill %")]
        DisplayCastWordOfTheGraveOnKillPct = 3394,
        [Description("Display Cast Word Of War On Kill %")]
        DisplayCastWordOfWarOnKillPct = 3395,
        [Description("Map Spawn Stone Circles")]
        MapSpawnStoneCircles = 3396,
        [Description("Map Force Stone Circle")]
        MapForceStoneCircle = 3397,
        [Description("Base Poison Damage +%")]
        BasePoisonDamagePosPct = 3398,
        [Description("Base Poison Duration +%")]
        BasePoisonDurationPosPct = 3399,
        [Description("Poison Duration +%")]
        PoisonDurationPosPct = 3400,
        [Description("Poison Skill Effect Duration")]
        PoisonSkillEffectDuration = 3401,
        [Description("Base Chance To Poison On Hit %")]
        BaseChanceToPoisonOnHitPct = 3402,
        [Description("Quake Slam Fully Charged Explosion Damage +% Final")]
        QuakeSlamFullyChargedExplosionDamagePosPctFinal = 3403,
        [Description("Local Unique Jewel Glacial Hammer Item Rarity On Shattering Enemy +% With 50 Strength In Radius")]
        LocalUniqueJewelGlacialHammerItemRarityOnShatteringEnemyPosPctWith50StrengthInRadius = 3404,
        [Description("Local Unique Jewel Spectral Throw Damage For Each Enemy Hit With Spectral Weapon +% With 50 Dexterity In Radius")]
        LocalUniqueJewelSpectralThrowDamageForEachEnemyHitWithSpectralWeaponPosPctWith50DexterityInRadius = 3405,
        [Description("Local Unique Jewel Double Strike Chance To Trigger On Kill Effects An Additional Time % With 50 Dexterity In Radius")]
        LocalUniqueJewelDoubleStrikeChanceToTriggerOnKillEffectsAnAdditionalTimePctWith50DexterityInRadius = 3406,
        [Description("Local Unique Jewel Viper Strike Attack Damage Per Poison On Enemy +% With 50 Dexterity In Radius")]
        LocalUniqueJewelViperStrikeAttackDamagePerPoisonOnEnemyPosPctWith50DexterityInRadius = 3407,
        [Description("Local Unique Jewel Heavy Strike Chance To Deal Double Damage % With 50 Strength In Radius")]
        LocalUniqueJewelHeavyStrikeChanceToDealDoubleDamagePctWith50StrengthInRadius = 3408,
        [Description("Enchantment Boots Mana Costs When Hit +%")]
        EnchantmentBootsManaCostsWhenHitPosPct = 3409,
        [Description("Enchantment Boots Stun Avoid % On Kill")]
        EnchantmentBootsStunAvoidPctOnKill = 3410,
        [Description("Enchantment Boots Spell Dodge When Hit By Spells %")]
        EnchantmentBootsSpellDodgeWhenHitBySpellsPct = 3411,
        [Description("Enchantment Boots Attack And Cast Speed +% For 4 Seconds On Kill")]
        EnchantmentBootsAttackAndCastSpeedPosPctFor4SecondsOnKill = 3412,
        [Description("Enchantment Boots Added Cold Damage When Hit Minimum")]
        EnchantmentBootsAddedColdDamageWhenHitMinimum = 3413,
        [Description("Enchantment Boots Added Cold Damage When Hit Maximum")]
        EnchantmentBootsAddedColdDamageWhenHitMaximum = 3414,
        [Description("Enchantment Boots Minimum Added Lightning Damage When You Havent Killed For 4 Seconds")]
        EnchantmentBootsMinimumAddedLightningDamageWhenYouHaventKilledFor4Seconds = 3415,
        [Description("Enchantment Boots Maximum Added Lightning Damage When You Havent Killed For 4 Seconds")]
        EnchantmentBootsMaximumAddedLightningDamageWhenYouHaventKilledFor4Seconds = 3416,
        [Description("Enchantment Boots Life And Mana Leech On Kill Permyriad")]
        EnchantmentBootsLifeAndManaLeechOnKillPermyriad = 3417,
        [Description("Enchantment Critical Strike Chance +% If You Havent Crit For 4 Seconds")]
        EnchantmentCriticalStrikeChancePosPctIfYouHaventCritFor4Seconds = 3418,
        [Description("No Extra Bleed Damage While Moving")]
        NoExtraBleedDamageWhileMoving = 3419,
        [Description("Action Speed Cannot Be Reduced Below Base")]
        ActionSpeedCannotBeReducedBelowBase = 3420,
        [Description("Movement Speed Cannot Be Reduced Below Base")]
        MovementSpeedCannotBeReducedBelowBase = 3421,
        [Description("Damage +% While Fortified")]
        DamagePosPctWhileFortified = 3422,
        [Description("Life Regeneration Per Minute % While Fortified")]
        LifeRegenerationPerMinutePctWhileFortified = 3423,
        [Description("Damage +% Per Endurance Charge")]
        DamagePosPctPerEnduranceCharge = 3424,
        [Description("Warcry Duration +%")]
        WarcryDurationPosPct = 3425,
        [Description("Restore Life And Mana On Warcry %")]
        RestoreLifeAndManaOnWarcryPct = 3426,
        [Description("Attack Speed +% When Hit")]
        AttackSpeedPosPctWhenHit = 3427,
        [Description("Movement Velocity While Not Hit +%")]
        MovementVelocityWhileNotHitPosPct = 3428,
        [Description("Is Warcry")]
        IsWarcry = 3429,
        [Description("Map Player Corrupt Blood When Hit % Average Damage To Deal Per Minute Per Stack")]
        MapPlayerCorruptBloodWhenHitPctAverageDamageToDealPerMinutePerStack = 3430,
        [Description("Damage +% When Not On Low Life")]
        DamagePosPctWhenNotOnLowLife = 3431,
        [Description("Gain Life And Mana Leech On Kill Permyriad")]
        GainLifeAndManaLeechOnKillPermyriad = 3432,
        [Description("Number Of Active Minions")]
        NumberOfActiveMinions = 3433,
        [Description("Number Of Active Totems")]
        NumberOfActiveTotems = 3434,
        [Description("Damage +% While Totem Active")]
        DamagePosPctWhileTotemActive = 3435,
        [Description("Physical Damage % Added As Fire Damage On Kill")]
        PhysicalDamagePctAddedAsFireDamageOnKill = 3436,
        [Description("Totems Gain % Of Players Armour")]
        TotemsGainPctOfPlayersArmour = 3437,
        [Description("Attack And Cast Speed +% On Placing Totem")]
        AttackAndCastSpeedPosPctOnPlacingTotem = 3438,
        [Description("Damage +% To Rare And Unique Enemies")]
        DamagePosPctToRareAndUniqueEnemies = 3439,
        [Description("Life Leech On Overkill Damage %")]
        LifeLeechOnOverkillDamagePct = 3440,
        [Description("Attack Speed +% While Leeching")]
        AttackSpeedPosPctWhileLeeching = 3441,
        [Description("Life Leech Does Not Stop At Full Life")]
        LifeLeechDoesNotStopAtFullLife = 3442,
        [Description("Cannot Be Stunned While Leeching")]
        CannotBeStunnedWhileLeeching = 3443,
        [Description("Attacks Use Life In Place Of Mana")]
        AttacksUseLifeInPlaceOfMana = 3444,
        [Description("Chance To Taunt On Hit %")]
        ChanceToTauntOnHitPct = 3445,
        [Description("Bleeding Enemies Explode For % Life As Physical Damage")]
        BleedingEnemiesExplodeForPctLifeAsPhysicalDamage = 3446,
        [Description("Attack And Cast Speed When Hit +%")]
        AttackAndCastSpeedWhenHitPosPct = 3447,
        [Description("Physical Damage On Block +%")]
        PhysicalDamageOnBlockPosPct = 3448,
        [Description("Block Chance On Damage Taken %")]
        BlockChanceOnDamageTakenPct = 3449,
        [Description("Damage While No Damage Taken +%")]
        DamageWhileNoDamageTakenPosPct = 3450,
        [Description("Recover % Life On Gained Fortify")]
        RecoverPctLifeOnGainedFortify = 3451,
        [Description("Recover % Life On Lost Fortify")]
        RecoverPctLifeOnLostFortify = 3452,
        [Description("Attack Speed While Fortified +%")]
        AttackSpeedWhileFortifiedPosPct = 3453,
        [Description("Taunted Enemies Damage Taken +%")]
        TauntedEnemiesDamageTakenPosPct = 3454,
        [Description("Taunted Enemies Chance To Be Stunned +%")]
        TauntedEnemiesChanceToBeStunnedPosPct = 3455,
        [Description("Armour And Evasion On Low Life +%")]
        ArmourAndEvasionOnLowLifePosPct = 3456,
        [Description("Is Taunted")]
        IsTaunted = 3457,
        [Description("Summoned Monsters Set Monster Mortar Parent")]
        SummonedMonstersSetMonsterMortarParent = 3458,
        [Description("Storm Cloud Charged Damage +% Final")]
        StormCloudChargedDamagePosPctFinal = 3459,
        [Description("Chaos Damage Taken +%")]
        ChaosDamageTakenPosPct = 3460,
        [Description("Number Of Melee Skeletons To Summon As Mage Skeletons")]
        NumberOfMeleeSkeletonsToSummonAsMageSkeletons = 3461,
        [Description("Local Unique Jewel With 50 Int In Radius Summon X Melee Skeletons As Mage Skeletons")]
        LocalUniqueJewelWith50IntInRadiusSummonXMeleeSkeletonsAsMageSkeletons = 3462,
        [Description("Local Display Socketed Trap Skills Create Smoke Cloud")]
        LocalDisplaySocketedTrapSkillsCreateSmokeCloud = 3463,
        [Description("Glacial Hammer Item Rarity On Shattering Enemy +%")]
        GlacialHammerItemRarityOnShatteringEnemyPosPct = 3464,
        [Description("Spectral Throw Damage For Each Enemy Hit With Spectral Weapon +%")]
        SpectralThrowDamageForEachEnemyHitWithSpectralWeaponPosPct = 3465,
        [Description("Double Strike Chance To Trigger On Kill Effects An Additional Time %")]
        DoubleStrikeChanceToTriggerOnKillEffectsAnAdditionalTimePct = 3466,
        [Description("Viper Strike Attack Damage Per Poison On Enemy +%")]
        ViperStrikeAttackDamagePerPoisonOnEnemyPosPct = 3467,
        [Description("Heavy Strike Chance To Deal Double Damage %")]
        HeavyStrikeChanceToDealDoubleDamagePct = 3468,
        [Description("Local Unique Jewel Vigilant Strike Fortifies Nearby Allies For X Seconds With 50 Str In Radius")]
        LocalUniqueJewelVigilantStrikeFortifiesNearbyAlliesForXSecondsWith50StrInRadius = 3469,
        [Description("Local Unique Jewel Fireball Radius Up To +% At Longer Ranges With 50 Int In Radius")]
        LocalUniqueJewelFireballRadiusUpToPosPctAtLongerRangesWith50IntInRadius = 3470,
        [Description("Fireball Radius Up To +% At Longer Ranges")]
        FireballRadiusUpToPosPctAtLongerRanges = 3471,
        [Description("Local Unique Jewel Animate Weapon Can Animate Up To X Additional Ranged Weapons With 50 Dex In Radius")]
        LocalUniqueJewelAnimateWeaponCanAnimateUpToXAdditionalRangedWeaponsWith50DexInRadius = 3472,
        [Description("Animate Weapon Can Animate Up To X Additional Ranged Weapons")]
        AnimateWeaponCanAnimateUpToXAdditionalRangedWeapons = 3473,
        [Description("Local Unique Jewel Ground Slam Angle +% With 50 Str In Radius")]
        LocalUniqueJewelGroundSlamAnglePosPctWith50StrInRadius = 3474,
        [Description("Ground Slam Angle +%")]
        GroundSlamAnglePosPct = 3475,
        [Description("Local Unique Jewel Cold Snap Gain Power Charge On Kill % With 50 Int In Radius")]
        LocalUniqueJewelColdSnapGainPowerChargeOnKillPctWith50IntInRadius = 3476,
        [Description("Cold Snap Gain Power Charge On Kill %")]
        ColdSnapGainPowerChargeOnKillPct = 3477,
        [Description("Local Unique Jewel Rallying Cry Damage Taken Goes To Mana % With 50 Int In Radius")]
        LocalUniqueJewelRallyingCryDamageTakenGoesToManaPctWith50IntInRadius = 3478,
        [Description("Rallying Cry Damage Taken Goes To Mana %")]
        RallyingCryDamageTakenGoesToManaPct = 3479,
        [Description("Local Unique Jewel Barrage Final Volley Fires X Additional Projectiles Simultaneously With 50 Dex In Radius")]
        LocalUniqueJewelBarrageFinalVolleyFiresXAdditionalProjectilesSimultaneouslyWith50DexInRadius = 3480,
        [Description("Barrage Final Volley Fires X Additional Projectiles Simultaneously")]
        BarrageFinalVolleyFiresXAdditionalProjectilesSimultaneously = 3481,
        [Description("Never Block")]
        NeverBlock = 3482,
        [Description("Mana Cost -% Per Endurance Charge")]
        ManaCostNegPctPerEnduranceCharge = 3483,
        [Description("Gain Rampage While At Maximum Endurance Charges")]
        GainRampageWhileAtMaximumEnduranceCharges = 3484,
        [Description("Lose Endurance Charges On Rampage End")]
        LoseEnduranceChargesOnRampageEnd = 3485,
        [Description("Physical Attack Damage +% While Holding A Shield")]
        PhysicalAttackDamagePosPctWhileHoldingAShield = 3486,
        [Description("Cold Attack Damage +% While Holding A Shield")]
        ColdAttackDamagePosPctWhileHoldingAShield = 3487,
        [Description("Fire Attack Damage +% While Holding A Shield")]
        FireAttackDamagePosPctWhileHoldingAShield = 3488,
        [Description("Base Number Of Ranged Animated Weapons Allowed")]
        BaseNumberOfRangedAnimatedWeaponsAllowed = 3489,
        [Description("Virtual Number Of Ranged Animated Weapons Allowed")]
        VirtualNumberOfRangedAnimatedWeaponsAllowed = 3490,
        [Description("Virtual Player Gain Rampage Stacks")]
        VirtualPlayerGainRampageStacks = 3491,
        [Description("Minion Does Not Equip Quiver")]
        MinionDoesNotEquipQuiver = 3492,
        [Description("Number Of Grasping Ornaments")]
        NumberOfGraspingOrnaments = 3493,
        [Description("Grasping Ornament Placement Radius")]
        GraspingOrnamentPlacementRadius = 3494,
        [Description("Local No Block Chance")]
        LocalNoBlockChance = 3495,
        [Description("Support Controlled Destruction Spell Damage +% Final")]
        SupportControlledDestructionSpellDamagePosPctFinal = 3496,
        [Description("Support Void Manipulation Chaos Damage +% Final")]
        SupportVoidManipulationChaosDamagePosPctFinal = 3497,
        [Description("Support Rapid Decay Damage Over Time +% Final")]
        SupportRapidDecayDamageOverTimePosPctFinal = 3498,
        [Description("Cast On Any Damage Taken %")]
        CastOnAnyDamageTakenPct = 3499,
        [Description("Stun Threshold +%")]
        StunThresholdPosPct = 3500,
        [Description("Number Of Active Spectres")]
        NumberOfActiveSpectres = 3501,
        [Description("Number Of Active Skeletons")]
        NumberOfActiveSkeletons = 3502,
        [Description("Number Of Active Raging Spirits")]
        NumberOfActiveRagingSpirits = 3503,
        [Description("Number Of Active Zombies")]
        NumberOfActiveZombies = 3504,
        [Description("Minion Attack And Cast Speed +% Per Active Skeleton")]
        MinionAttackAndCastSpeedPosPctPerActiveSkeleton = 3505,
        [Description("Minion Duration +% Per Active Zombie")]
        MinionDurationPosPctPerActiveZombie = 3506,
        [Description("Minion Damage +% Per Active Spectre")]
        MinionDamagePosPctPerActiveSpectre = 3507,
        [Description("Minion Life Regeneration Per Minute Per Active Raging Spirit")]
        MinionLifeRegenerationPerMinutePerActiveRagingSpirit = 3508,
        [Description("Virtual Skill Effect Duration Pluspercent Final")]
        VirtualSkillEffectDurationPluspercentFinal = 3509,
        [Description("Virtual Additional Skill Effect Duration")]
        VirtualAdditionalSkillEffectDuration = 3510,
        [Description("Offering Of Judgement Counter")]
        OfferingOfJudgementCounter = 3511,
        [Description("Gain Her Blessing For 3 Seconds On Ignite %")]
        GainHerBlessingFor3SecondsOnIgnitePct = 3512,
        [Description("Blind Nearby Enemies When Gaining Her Blessing %")]
        BlindNearbyEnemiesWhenGainingHerBlessingPct = 3513,
        [Description("Have Her Blessing")]
        HaveHerBlessing = 3514,
        [Description("Avoid Freeze Chill Ignite % With Her Blessing")]
        AvoidFreezeChillIgnitePctWithHerBlessing = 3515,
        [Description("Attack And Movement Speed +% With Her Blessing")]
        AttackAndMovementSpeedPosPctWithHerBlessing = 3516,
        [Description("Warcry Speed +%")]
        WarcrySpeedPosPct = 3517,
        [Description("Gain Power Charge On Non Critical Strike %")]
        GainPowerChargeOnNonCriticalStrikePct = 3518,
        [Description("Critical Strike Multiplier + Per Power Charge")]
        CriticalStrikeMultiplierPosPerPowerCharge = 3519,
        [Description("Apply Poison On Hit Vs Bleeding Enemies %")]
        ApplyPoisonOnHitVsBleedingEnemiesPct = 3520,
        [Description("Avoid Blind %")]
        AvoidBlindPct = 3521,
        [Description("Damage Taken +% From Blinded Enemies")]
        DamageTakenPosPctFromBlindedEnemies = 3522,
        [Description("Attack Damage +% Per Frenzy Charge")]
        AttackDamagePosPctPerFrenzyCharge = 3523,
        [Description("Attack Damage +% While Onslaught Active")]
        AttackDamagePosPctWhileOnslaughtActive = 3524,
        [Description("Onslaught Effect +%")]
        OnslaughtEffectPosPct = 3525,
        [Description("Critical Strike Multiplier + Vs Bleeding Enemies")]
        CriticalStrikeMultiplierPosVsBleedingEnemies = 3526,
        [Description("Critical Strike Chance +% Vs Poisoned Enemies")]
        CriticalStrikeChancePosPctVsPoisonedEnemies = 3527,
        [Description("Elemental Damage Taken +%")]
        ElementalDamageTakenPosPct = 3528,
        [Description("Damage Taken From Traps And Mines +%")]
        DamageTakenFromTrapsAndMinesPosPct = 3529,
        [Description("Maim On Hit % Vs Poisoned Enemies")]
        MaimOnHitPctVsPoisonedEnemies = 3530,
        [Description("Raider Passive Evade Melee Attacks While Onslaughted +% Final")]
        RaiderPassiveEvadeMeleeAttacksWhileOnslaughtedPosPctFinal = 3531,
        [Description("Raider Passive Evade Projectile Attacks While Onslaughted +% Final")]
        RaiderPassiveEvadeProjectileAttacksWhileOnslaughtedPosPctFinal = 3532,
        [Description("Dispel Status Ailments On Flask Use")]
        DispelStatusAilmentsOnFlaskUse = 3533,
        [Description("Avoid Status Ailments % During Flask Effect")]
        AvoidStatusAilmentsPctDuringFlaskEffect = 3534,
        [Description("Attack Speed +% During Flask Effect")]
        AttackSpeedPosPctDuringFlaskEffect = 3535,
        [Description("Poison On Hit During Flask Effect %")]
        PoisonOnHitDuringFlaskEffectPct = 3536,
        [Description("Cyclone Places Ground Lightning")]
        CyclonePlacesGroundLightning = 3537,
        [Description("Cyclone Lightning Path Radius")]
        CycloneLightningPathRadius = 3538,
        [Description("Local Unique Flask Shock Nearby Enemies During Flask Effect")]
        LocalUniqueFlaskShockNearbyEnemiesDuringFlaskEffect = 3539,
        [Description("Local Unique Flask Shocked During Flask Effect")]
        LocalUniqueFlaskShockedDuringFlaskEffect = 3540,
        [Description("Local Unique Flask Leech Lightning Damage % As Life During Flask Effect")]
        LocalUniqueFlaskLeechLightningDamagePctAsLifeDuringFlaskEffect = 3541,
        [Description("Local Unique Flask Leech Lightning Damage % As Mana During Flask Effect")]
        LocalUniqueFlaskLeechLightningDamagePctAsManaDuringFlaskEffect = 3542,
        [Description("Local Unique Flask Leech Is Instant During Flask Effect")]
        LocalUniqueFlaskLeechIsInstantDuringFlaskEffect = 3543,
        [Description("Local Unique Flask Minimum Added Lightning Damage To Attacks During Flask Effect")]
        LocalUniqueFlaskMinimumAddedLightningDamageToAttacksDuringFlaskEffect = 3544,
        [Description("Local Unique Flask Maximum Added Lightning Damage To Attacks During Flask Effect")]
        LocalUniqueFlaskMaximumAddedLightningDamageToAttacksDuringFlaskEffect = 3545,
        [Description("Local Unique Flask Minimum Added Lightning Damage To Spells During Flask Effect")]
        LocalUniqueFlaskMinimumAddedLightningDamageToSpellsDuringFlaskEffect = 3546,
        [Description("Local Unique Flask Maximum Added Lightning Damage To Spells During Flask Effect")]
        LocalUniqueFlaskMaximumAddedLightningDamageToSpellsDuringFlaskEffect = 3547,
        [Description("Local Unique Flask Physical Damage % Converted To Lightning During Flask Effect")]
        LocalUniqueFlaskPhysicalDamagePctConvertedToLightningDuringFlaskEffect = 3548,
        [Description("Local Unique Flask Lightning Resistance Penetration % During Flask Effect")]
        LocalUniqueFlaskLightningResistancePenetrationPctDuringFlaskEffect = 3549,
        [Description("Leech Is Instant")]
        LeechIsInstant = 3550,
        [Description("Mana Leech Is Instant")]
        ManaLeechIsInstant = 3551,
        [Description("Projectiles Drop Ground Fire")]
        ProjectilesDropGroundFire = 3552,
        [Description("Projectiles Drop Ground Lightning")]
        ProjectilesDropGroundLightning = 3553,
        [Description("Projectiles Drop Ground Ice")]
        ProjectilesDropGroundIce = 3554,
        [Description("Projectiles Drop Ground Effects On Client")]
        ProjectilesDropGroundEffectsOnClient = 3555,
        [Description("Base Projectile Ground Effect Duration")]
        BaseProjectileGroundEffectDuration = 3556,
        [Description("Base Projectile Skill Dot Ground Fire Area Damage Per Minute")]
        BaseProjectileSkillDotGroundFireAreaDamagePerMinute = 3557,
        [Description("Projectile Ground Effect Duration")]
        ProjectileGroundEffectDuration = 3558,
        [Description("Projectile Skill Dot Ground Fire Area Damage Per Minute")]
        ProjectileSkillDotGroundFireAreaDamagePerMinute = 3559,
        [Description("Chaos Damage Can Chill")]
        ChaosDamageCanChill = 3560,
        [Description("Explode On Kill % Chaos Damage To Deal")]
        ExplodeOnKillPctChaosDamageToDeal = 3561,
        [Description("Enchantment Boots Damage Penetrates Elemental Resistance % While You Havent Killed For 4 Seconds")]
        EnchantmentBootsDamagePenetratesElementalResistancePctWhileYouHaventKilledFor4Seconds = 3562,
        [Description("Enchantment Boots Physical Damage % Added As Elements In Spells That Hit You In Past 4 Seconds")]
        EnchantmentBootsPhysicalDamagePctAddedAsElementsInSpellsThatHitYouInPast4Seconds = 3563,
        [Description("Enchantment Boots Minimum Added Chaos Damage For 4 Seconds When Crit 4s")]
        EnchantmentBootsMinimumAddedChaosDamageFor4SecondsWhenCrit4s = 3564,
        [Description("Enchantment Boots Maximum Added Chaos Damage For 4 Seconds When Crit 4s")]
        EnchantmentBootsMaximumAddedChaosDamageFor4SecondsWhenCrit4s = 3565,
        [Description("Life Leech Permyriad From Elemental Damage Against Enemies With Elemental Status Ailments")]
        LifeLeechPermyriadFromElementalDamageAgainstEnemiesWithElementalStatusAilments = 3566,
        [Description("Movement Speed +% While Not Affected By Status Ailments")]
        MovementSpeedPosPctWhileNotAffectedByStatusAilments = 3567,
        [Description("Stacking Spell Damage +% When You Or Your Totems Kill An Enemy For 2 Seconds")]
        StackingSpellDamagePosPctWhenYouOrYourTotemsKillAnEnemyFor2Seconds = 3568,
        [Description("Give Parent Stacking Spell Damage +% For 2 Seconds On Kill")]
        GiveParentStackingSpellDamagePosPctFor2SecondsOnKill = 3569,
        [Description("Totems Explode For % Of Max Life As Fire Damage On Low Life")]
        TotemsExplodeForPctOfMaxLifeAsFireDamageOnLowLife = 3570,
        [Description("Chance To Avoid Stun % Aura While Wielding A Staff")]
        ChanceToAvoidStunPctAuraWhileWieldingAStaff = 3571,
        [Description("Map Monsters Have Onslaught")]
        MapMonstersHaveOnslaught = 3572,
        [Description("Monster Is Invasion Boss")]
        MonsterIsInvasionBoss = 3573,
        [Description("Virtual Minion Attack Speed +%")]
        VirtualMinionAttackSpeedPosPct = 3574,
        [Description("Virtual Minion Cast Speed +%")]
        VirtualMinionCastSpeedPosPct = 3575,
        [Description("Virtual Minion Life Regeneration Per Minute")]
        VirtualMinionLifeRegenerationPerMinute = 3576,
        [Description("Dropbear Desecration Area Of Effect +%")]
        DropbearDesecrationAreaOfEffectPosPct = 3577,
        [Description("Physical Damage To Return To Melee Attacker")]
        PhysicalDamageToReturnToMeleeAttacker = 3578,
        [Description("Cold Damage To Return To Melee Attacker")]
        ColdDamageToReturnToMeleeAttacker = 3579,
        [Description("Fire Damage To Return To Melee Attacker")]
        FireDamageToReturnToMeleeAttacker = 3580,
        [Description("Lightning Damage To Return To Melee Attacker")]
        LightningDamageToReturnToMeleeAttacker = 3581,
        [Description("Chaos Damage To Return To Melee Attacker")]
        ChaosDamageToReturnToMeleeAttacker = 3582,
        [Description("Physical Damage To Return When Hit")]
        PhysicalDamageToReturnWhenHit = 3583,
        [Description("Cold Damage To Return When Hit")]
        ColdDamageToReturnWhenHit = 3584,
        [Description("Fire Damage To Return When Hit")]
        FireDamageToReturnWhenHit = 3585,
        [Description("Lightning Damage To Return When Hit")]
        LightningDamageToReturnWhenHit = 3586,
        [Description("Chaos Damage To Return When Hit")]
        ChaosDamageToReturnWhenHit = 3587,
        [Description("Trap Idle Duration")]
        TrapIdleDuration = 3588,
        [Description("Trap Retracts")]
        TrapRetracts = 3589,
        [Description("Physical Damage Taken +% While Frozen")]
        PhysicalDamageTakenPosPctWhileFrozen = 3590,
        [Description("Damage +% For 4 Seconds On Crit")]
        DamagePosPctFor4SecondsOnCrit = 3591,
        [Description("Damage And Minion Damage +% For 4 Seconds On Consume Corpse")]
        DamageAndMinionDamagePosPctFor4SecondsOnConsumeCorpse = 3592,
        [Description("Enemies Damage Taken +% While Cursed")]
        EnemiesDamageTakenPosPctWhileCursed = 3593,
        [Description("Spectre Damage +%")]
        SpectreDamagePosPct = 3594,
        [Description("Critical Strike Chance +% For 4 Seconds On Kill")]
        CriticalStrikeChancePosPctFor4SecondsOnKill = 3595,
        [Description("Ignite Effect +%")]
        IgniteEffectPosPct = 3596,
        [Description("Chill Effect +%")]
        ChillEffectPosPct = 3597,
        [Description("Shock Effect +%")]
        ShockEffectPosPct = 3598,
        [Description("Frozen Effect +%")]
        FrozenEffectPosPct = 3599,
        [Description("Critical Strikes Ignore Elemental Resistances")]
        CriticalStrikesIgnoreElementalResistances = 3600,
        [Description("Physical Damage Reduction And Minion Physical Damage Reduction % Per Raised Zombie")]
        PhysicalDamageReductionAndMinionPhysicalDamageReductionPctPerRaisedZombie = 3601,
        [Description("Damage Taken +% From Bleeding Enemies")]
        DamageTakenPosPctFromBleedingEnemies = 3602,
        [Description("Maim Bleeding Enemies On Hit %")]
        MaimBleedingEnemiesOnHitPct = 3603,
        [Description("One Handed Attack Speed +%")]
        OneHandedAttackSpeedPosPct = 3604,
        [Description("Movement Speed +% For 4 Seconds On Block")]
        MovementSpeedPosPctFor4SecondsOnBlock = 3605,
        [Description("Movement Speed +% While Fortified")]
        MovementSpeedPosPctWhileFortified = 3606,
        [Description("Elemental Damage Taken +% At Maximum Endurance Charges")]
        ElementalDamageTakenPosPctAtMaximumEnduranceCharges = 3607,
        [Description("Status Ailments Removed At Low Life")]
        StatusAilmentsRemovedAtLowLife = 3608,
        [Description("Gain Frenzy Charge On Main Hand Kill %")]
        GainFrenzyChargeOnMainHandKillPct = 3609,
        [Description("Gain Endurance Charge On Main Hand Kill %")]
        GainEnduranceChargeOnMainHandKillPct = 3610,
        [Description("Damage Taken +% For 4 Seconds On Kill")]
        DamageTakenPosPctFor4SecondsOnKill = 3611,
        [Description("Avoid Stun % For 4 Seconds On Kill")]
        AvoidStunPctFor4SecondsOnKill = 3612,
        [Description("Damage Taken +% For 4 Seconds On Killing Taunted Enemy")]
        DamageTakenPosPctFor4SecondsOnKillingTauntedEnemy = 3613,
        [Description("Warcry Cooldown Speed +%")]
        WarcryCooldownSpeedPosPct = 3614,
        [Description("Always Stun Enemies That Are On Full Life")]
        AlwaysStunEnemiesThatAreOnFullLife = 3615,
        [Description("Stun Duration +% Vs Enemies That Are On Full Life")]
        StunDurationPosPctVsEnemiesThatAreOnFullLife = 3616,
        [Description("Stun Duration +% Vs Enemies That Are On Low Life")]
        StunDurationPosPctVsEnemiesThatAreOnLowLife = 3617,
        [Description("Damage +% With One Handed Weapons")]
        DamagePosPctWithOneHandedWeapons = 3618,
        [Description("Damage +% With Two Handed Weapons")]
        DamagePosPctWithTwoHandedWeapons = 3619,
        [Description("Damage Reduction Rating From Body Armour Doubled")]
        DamageReductionRatingFromBodyArmourDoubled = 3620,
        [Description("Damage Reduction Rating % With Active Totem")]
        DamageReductionRatingPctWithActiveTotem = 3621,
        [Description("Virtual Physical Damage Taken +%")]
        VirtualPhysicalDamageTakenPosPct = 3622,
        [Description("Virtual Elemental Damage Taken +%")]
        VirtualElementalDamageTakenPosPct = 3623,
        [Description("Is Burning")]
        IsBurning = 3624,
        [Description("Ignite Effect On Self +%")]
        IgniteEffectOnSelfPosPct = 3625,
        [Description("Shocked Effect On Self +%")]
        ShockedEffectOnSelfPosPct = 3626,
        [Description("Ancestor Totem Parent Activiation Range")]
        AncestorTotemParentActiviationRange = 3627,
        [Description("Support Clustertrap Damage +% Final")]
        SupportClustertrapDamagePosPctFinal = 3628,
        [Description("Local Display Cast Level X Manifest Rageblade")]
        LocalDisplayCastLevelXManifestRageblade = 3629,
        [Description("Local Display Manifest Rageblade Disables Weapons")]
        LocalDisplayManifestRagebladeDisablesWeapons = 3630,
        [Description("Local Display Manifest Rageblade Destroy On End Rampage")]
        LocalDisplayManifestRagebladeDestroyOnEndRampage = 3631,
        [Description("Minions Grant Onslaught")]
        MinionsGrantOnslaught = 3632,
        [Description("Ground Fire Art Variation")]
        GroundFireArtVariation = 3633,
        [Description("Frost Blades Damage +%")]
        FrostBladesDamagePosPct = 3634,
        [Description("Frost Blades Projectile Speed +%")]
        FrostBladesProjectileSpeedPosPct = 3635,
        [Description("Frost Blades Number Of Additional Projectiles In Chain")]
        FrostBladesNumberOfAdditionalProjectilesInChain = 3636,
        [Description("Summoned Raging Spirit Duration +%")]
        SummonedRagingSpiritDurationPosPct = 3637,
        [Description("Summoned Raging Spirit Chance To Spawn Additional Minion %")]
        SummonedRagingSpiritChanceToSpawnAdditionalMinionPct = 3638,
        [Description("Discharge Damage +%")]
        DischargeDamagePosPct = 3639,
        [Description("Discharge Radius +%")]
        DischargeRadiusPosPct = 3640,
        [Description("Discharge Chance Not To Consume Charges %")]
        DischargeChanceNotToConsumeChargesPct = 3641,
        [Description("Anger Mana Reservation +%")]
        AngerManaReservationPosPct = 3642,
        [Description("Anger Aura Effect +%")]
        AngerAuraEffectPosPct = 3643,
        [Description("Lightning Trap Damage +%")]
        LightningTrapDamagePosPct = 3644,
        [Description("Lightning Trap Number Of Additional Projectiles")]
        LightningTrapNumberOfAdditionalProjectiles = 3645,
        [Description("Lightning Trap Cooldown Speed +%")]
        LightningTrapCooldownSpeedPosPct = 3646,
        [Description("Virtual Number Of Additional Projectiles In Chain")]
        VirtualNumberOfAdditionalProjectilesInChain = 3647,
        [Description("Ambush Passive Critical Strike Chance Vs Enemies On Full Life +% Final")]
        AmbushPassiveCriticalStrikeChanceVsEnemiesOnFullLifePosPctFinal = 3648,
        [Description("Critical Strike Multiplier Vs Enemies On Full Life +")]
        CriticalStrikeMultiplierVsEnemiesOnFullLifePos = 3649,
        [Description("Assassinate Passive Critical Strike Chance Vs Enemies On Low Life +% Final")]
        AssassinatePassiveCriticalStrikeChanceVsEnemiesOnLowLifePosPctFinal = 3650,
        [Description("Ambush Passive Critical Strike Chance +% Final")]
        AmbushPassiveCriticalStrikeChancePosPctFinal = 3651,
        [Description("Assassinate Passive Critical Strike Chance +% Final")]
        AssassinatePassiveCriticalStrikeChancePosPctFinal = 3652,
        [Description("Immune To Lava Damage")]
        ImmuneToLavaDamage = 3653,
        [Description("Number Of Additional Storm Clouds Allowed")]
        NumberOfAdditionalStormCloudsAllowed = 3654,
        [Description("Local Flask Consumes X Frenzy Charges On Use")]
        LocalFlaskConsumesXFrenzyChargesOnUse = 3655,
        [Description("Local Flask Consumes X Endurance Charges On Use")]
        LocalFlaskConsumesXEnduranceChargesOnUse = 3656,
        [Description("Local Flask Consumes X Power Charges On Use")]
        LocalFlaskConsumesXPowerChargesOnUse = 3657,
        [Description("Map Shrines Are Darkshrines")]
        MapShrinesAreDarkshrines = 3658,
        [Description("Physical Damage +% While Frozen")]
        PhysicalDamagePosPctWhileFrozen = 3659,
        [Description("Local Recharge On Crit %")]
        LocalRechargeOnCritPct = 3660,
        [Description("Mana And Es Regeneration Per Minute % When You Freeze Shock Or Ignite An Enemy")]
        ManaAndEsRegenerationPerMinutePctWhenYouFreezeShockOrIgniteAnEnemy = 3661,
        [Description("Damage Taken +% To An Element For 4 Seconds When Hit By Damage From An Element")]
        DamageTakenPosPctToAnElementFor4SecondsWhenHitByDamageFromAnElement = 3662,
        [Description("Cold Damage Taken +%")]
        ColdDamageTakenPosPct = 3663,
        [Description("Lightning Damage Taken +%")]
        LightningDamageTakenPosPct = 3664,
        [Description("Burning Arrow Spread Burning Ground When Igniting Enemy On Hit %")]
        BurningArrowSpreadBurningGroundWhenIgnitingEnemyOnHitPct = 3665,
        [Description("Burning Arrow Spread Tar Ground When Not Igniting Enemy On Hit %")]
        BurningArrowSpreadTarGroundWhenNotIgnitingEnemyOnHitPct = 3666,
        [Description("Local Unique Jewel Burning Arrow Spread Burning Ground When Igniting Enemy On Hit % With 50 Dexterity In Radius")]
        LocalUniqueJewelBurningArrowSpreadBurningGroundWhenIgnitingEnemyOnHitPctWith50DexterityInRadius = 3667,
        [Description("Local Unique Jewel Burning Arrow Spread Tar Ground When Not Igniting Enemy On Hit % With 50 Dexterity In Radius")]
        LocalUniqueJewelBurningArrowSpreadTarGroundWhenNotIgnitingEnemyOnHitPctWith50DexterityInRadius = 3668,
        [Description("Bleed On Hit With Attacks %")]
        BleedOnHitWithAttacksPct = 3669,
        [Description("Gain Flask Chance On Crit %")]
        GainFlaskChanceOnCritPct = 3670,
        [Description("Player Far Shot")]
        PlayerFarShot = 3671,
        [Description("Fire Elemental Meteor Landing Range")]
        FireElementalMeteorLandingRange = 3672,
        [Description("Virtual Aura Effect Pluspercent")]
        VirtualAuraEffectPluspercent = 3673,
        [Description("Cannot Be Poisoned")]
        CannotBePoisoned = 3674,
        [Description("Avoid Fire Damage %")]
        AvoidFireDamagePct = 3675,
        [Description("Avoid Cold Damage %")]
        AvoidColdDamagePct = 3676,
        [Description("Avoid Lightning Damage %")]
        AvoidLightningDamagePct = 3677,
        [Description("Avoid Chaos Damage %")]
        AvoidChaosDamagePct = 3678,
        [Description("Avoid Physical Damage %")]
        AvoidPhysicalDamagePct = 3679,
        [Description("Remove Bleed On Flask Use")]
        RemoveBleedOnFlaskUse = 3680,
        [Description("Slayer Ascendancy Melee Splash Damage +% Final")]
        SlayerAscendancyMeleeSplashDamagePosPctFinal = 3681,
        [Description("Slayer Ascendancy Melee Splash Damage +% Final For Splash")]
        SlayerAscendancyMeleeSplashDamagePosPctFinalForSplash = 3682,
        [Description("Guardian Reserved Mana % Given To You And Nearby Allies As Base Maximum Energy Shield")]
        GuardianReservedManaPctGivenToYouAndNearbyAlliesAsBaseMaximumEnergyShield = 3683,
        [Description("Virtual Base Maximum Energy Shield To Grant To You And Nearby Allies")]
        VirtualBaseMaximumEnergyShieldToGrantToYouAndNearbyAllies = 3684,
        [Description("Virtual Armour To Grant To You And Nearby Allies")]
        VirtualArmourToGrantToYouAndNearbyAllies = 3685,
        [Description("Number Of Additional Siege Ballistae Per 200 Dexterity")]
        NumberOfAdditionalSiegeBallistaePer200Dexterity = 3686,
        [Description("Attack Minimum Added Physical Damage Per 25 Dexterity")]
        AttackMinimumAddedPhysicalDamagePer25Dexterity = 3687,
        [Description("Attack Maximum Added Physical Damage Per 25 Dexterity")]
        AttackMaximumAddedPhysicalDamagePer25Dexterity = 3688,
        [Description("Local Display Nearby Enemies Are Blinded")]
        LocalDisplayNearbyEnemiesAreBlinded = 3689,
        [Description("Local Display Nearby Enemies Movement Speed +%")]
        LocalDisplayNearbyEnemiesMovementSpeedPosPct = 3690,
        [Description("Local Display Socketed Gems Supported By X Hypothermia")]
        LocalDisplaySocketedGemsSupportedByXHypothermia = 3691,
        [Description("Local Display Socketed Gems Supported By X Ice Bite")]
        LocalDisplaySocketedGemsSupportedByXIceBite = 3692,
        [Description("Local Display Socketed Gems Supported By X Cold Penetration")]
        LocalDisplaySocketedGemsSupportedByXColdPenetration = 3693,
        [Description("Local Display Socketed Gems Supported By X Mana Leech")]
        LocalDisplaySocketedGemsSupportedByXManaLeech = 3694,
        [Description("Local Display Socketed Gems Supported By X Added Cold Damage")]
        LocalDisplaySocketedGemsSupportedByXAddedColdDamage = 3695,
        [Description("Local Display Socketed Gems Supported By X Reduced Mana Cost")]
        LocalDisplaySocketedGemsSupportedByXReducedManaCost = 3696,
        [Description("Projectile Nova Extend Projectiles Forward By X Units")]
        ProjectileNovaExtendProjectilesForwardByXUnits = 3697,
        [Description("Storm Cloud Destroy When Caster Dies")]
        StormCloudDestroyWhenCasterDies = 3698,
        [Description("Chance To Gain Onslaught On Kill For 4 Seconds %")]
        ChanceToGainOnslaughtOnKillFor4SecondsPct = 3699,
        [Description("Chance To Cast On Rampage Tier %")]
        ChanceToCastOnRampageTierPct = 3700,
        [Description("Local Display Minions Grant Onslaught")]
        LocalDisplayMinionsGrantOnslaught = 3701,
        [Description("% Of Life And Energy Shield To Deal As Damage")]
        PctOfLifeAndEnergyShieldToDealAsDamage = 3702,
        [Description("Critical Strike Chance +% Vs Blinded Enemies")]
        CriticalStrikeChancePosPctVsBlindedEnemies = 3703,
        [Description("Is In Singularity")]
        IsInSingularity = 3704,
        [Description("Chilled Ground On Freeze % Chance For 3 Seconds")]
        ChilledGroundOnFreezePctChanceFor3Seconds = 3705,
        [Description("Consecrate Ground On Kill % For 3 Seconds")]
        ConsecrateGroundOnKillPctFor3Seconds = 3706,
        [Description("In Symbol")]
        InSymbol = 3707,
        [Description("Damage Taken +% From Enemies In Symbols")]
        DamageTakenPosPctFromEnemiesInSymbols = 3708,
        [Description("Local Display Socketed Aura Gems Reserve No Mana")]
        LocalDisplaySocketedAuraGemsReserveNoMana = 3709,
        [Description("No Mana Reserved")]
        NoManaReserved = 3710,
        [Description("Piercing Attacks Cause Bleeding")]
        PiercingAttacksCauseBleeding = 3711,
        [Description("Spell Damage Modifiers Apply To Skill Dot")]
        SpellDamageModifiersApplyToSkillDot = 3712,
        [Description("Shadow Blades Projectile Spread")]
        ShadowBladesProjectileSpread = 3713,
        [Description("Map Disable Bloodlines")]
        MapDisableBloodlines = 3714,
        [Description("Map Disable Nemesis")]
        MapDisableNemesis = 3715,
        [Description("Is Poisoned")]
        IsPoisoned = 3716,
        [Description("Is Vinktar Lightning Bond Source")]
        IsVinktarLightningBondSource = 3717,
        [Description("Is Vinktar Lightning Bond Target")]
        IsVinktarLightningBondTarget = 3718,
        [Description("Energy Shield Recharges On Block %")]
        EnergyShieldRechargesOnBlockPct = 3719,
        [Description("Dropped Weapons Have 20 Quality")]
        DroppedWeaponsHave20Quality = 3720,
        [Description("Drop Additional 20 Quality Gems")]
        DropAdditional20QualityGems = 3721,
        [Description("Killed Rare Monsters Drop Additional Unique Items")]
        KilledRareMonstersDropAdditionalUniqueItems = 3722,
        [Description("Poison Duration Is Skill Duration")]
        PoisonDurationIsSkillDuration = 3723,
        [Description("Map Players Gain Rare Monster Mods On Kill Ms")]
        MapPlayersGainRareMonsterModsOnKillMs = 3724,
        [Description("Soul Eater On Rare Kill Ms")]
        SoulEaterOnRareKillMs = 3725,
        [Description("Map Players Gain Soul Eater On Rare Kill Ms")]
        MapPlayersGainSoulEaterOnRareKillMs = 3726,
        [Description("Gain Soul Eater During Flask Effect")]
        GainSoulEaterDuringFlaskEffect = 3727,
        [Description("Lose Soul Eater Souls On Flask Use")]
        LoseSoulEaterSoulsOnFlaskUse = 3728,
        [Description("Totemified Skills Taunt On Hit %")]
        TotemifiedSkillsTauntOnHitPct = 3729,
        [Description("Virtual Chance To Taunt On Hit %")]
        VirtualChanceToTauntOnHitPct = 3730,
        [Description("Offerings Also Buff You")]
        OfferingsAlsoBuffYou = 3731,
        [Description("Caustic Cloud On Death Maximum Life Per Minute To Deal As Chaos Damage %")]
        CausticCloudOnDeathMaximumLifePerMinuteToDealAsChaosDamagePct = 3732,
        [Description("Minion Caustic Cloud On Death Maximum Life Per Minute To Deal As Chaos Damage %")]
        MinionCausticCloudOnDeathMaximumLifePerMinuteToDealAsChaosDamagePct = 3733,
        [Description("Storm Cloud Charge Count")]
        StormCloudChargeCount = 3734,
        [Description("Monster Is Duplicated")]
        MonsterIsDuplicated = 3735,
        [Description("Gain Life Leech From Any Damage Permyriad As Life For 4 Seconds If Taken Savage Hit")]
        GainLifeLeechFromAnyDamagePermyriadAsLifeFor4SecondsIfTakenSavageHit = 3736,
        [Description("Gain Damage +% For 4 Seconds If Taken Savage Hit")]
        GainDamagePosPctFor4SecondsIfTakenSavageHit = 3737,
        [Description("Gain Attack Speed +% For 4 Seconds If Taken Savage Hit")]
        GainAttackSpeedPosPctFor4SecondsIfTakenSavageHit = 3738,
        [Description("Damage +% Vs Burning Enemies")]
        DamagePosPctVsBurningEnemies = 3739,
        [Description("Endurance Charge On Off Hand Kill %")]
        EnduranceChargeOnOffHandKillPct = 3740,
        [Description("Aura Melee Physical Damage +% Per 10 Strength")]
        AuraMeleePhysicalDamagePosPctPer10Strength = 3741,
        [Description("Attack On Death %")]
        AttackOnDeathPct = 3742,
        [Description("Siphon Life Leech From Damage Permyriad")]
        SiphonLifeLeechFromDamagePermyriad = 3743,
        [Description("Total Base Maximum Mana")]
        TotalBaseMaximumMana = 3744,
        [Description("Combined Mana +%")]
        CombinedManaPosPct = 3745,
        [Description("Combined Mana +% Final")]
        CombinedManaPosPctFinal = 3746,
        [Description("You And Your Totems Gain An Endurance Charge On Burning Enemy Kill %")]
        YouAndYourTotemsGainAnEnduranceChargeOnBurningEnemyKillPct = 3747,
        [Description("Minions Grant Owner And Owners Totems Gains Endurance Charge On Burning Enemy Kill %")]
        MinionsGrantOwnerAndOwnersTotemsGainsEnduranceChargeOnBurningEnemyKillPct = 3748,
        [Description("Grant Owner And Owners Totems An Endurance Charge On Burning Enemy Kill %")]
        GrantOwnerAndOwnersTotemsAnEnduranceChargeOnBurningEnemyKillPct = 3749,
        [Description("Auras Grant Additional Physical Damage Reduction % To You And Your Allies")]
        AurasGrantAdditionalPhysicalDamageReductionPctToYouAndYourAllies = 3750,
        [Description("Auras Grant Damage +% To You And Your Allies")]
        AurasGrantDamagePosPctToYouAndYourAllies = 3751,
        [Description("Auras Grant Attack And Cast Speed +% To You And Your Allies")]
        AurasGrantAttackAndCastSpeedPosPctToYouAndYourAllies = 3752,
        [Description("Placing Traps Cooldown Recovery +%")]
        PlacingTrapsCooldownRecoveryPosPct = 3753,
        [Description("Damage +% Vs Enemies Affected By Status Ailments")]
        DamagePosPctVsEnemiesAffectedByStatusAilments = 3754,
        [Description("Warcries Are Instant")]
        WarcriesAreInstant = 3755,
        [Description("Aura Grant Shield Defences To Nearby Allies")]
        AuraGrantShieldDefencesToNearbyAllies = 3756,
        [Description("Minion Additional Physical Damage Reduction %")]
        MinionAdditionalPhysicalDamageReductionPct = 3757,
        [Description("Phasing For 4 Seconds On Kill %")]
        PhasingFor4SecondsOnKillPct = 3758,
        [Description("Skill Area Of Effect +% Per Active Mine")]
        SkillAreaOfEffectPosPctPerActiveMine = 3759,
        [Description("Damage +% Per Active Trap")]
        DamagePosPctPerActiveTrap = 3760,
        [Description("Immune To Status Ailments While Phased")]
        ImmuneToStatusAilmentsWhilePhased = 3761,
        [Description("Chance To Dodge Spells % While Phased")]
        ChanceToDodgeSpellsPctWhilePhased = 3762,
        [Description("Additional Critical Strike Chance Per Power Charge Permyriad")]
        AdditionalCriticalStrikeChancePerPowerChargePermyriad = 3763,
        [Description("Movement Skills Cost No Mana")]
        MovementSkillsCostNoMana = 3764,
        [Description("Attack And Cast Speed +% For 4 Seconds On Movement Skill Use")]
        AttackAndCastSpeedPosPctFor4SecondsOnMovementSkillUse = 3765,
        [Description("Recover 10% Of Maximum Mana On Skill Use %")]
        Recover10PctOfMaximumManaOnSkillUsePct = 3766,
        [Description("Mine Laying Speed +% For 4 Seconds On Detonation")]
        MineLayingSpeedPosPctFor4SecondsOnDetonation = 3767,
        [Description("Damage +% For 4 Seconds On Detonation")]
        DamagePosPctFor4SecondsOnDetonation = 3768,
        [Description("Flask Charges Recovered Per 3 Seconds")]
        FlaskChargesRecoveredPer3Seconds = 3769,
        [Description("Trap Skill Area Of Effect +%")]
        TrapSkillAreaOfEffectPosPct = 3770,
        [Description("Number Of Active Mines")]
        NumberOfActiveMines = 3771,
        [Description("Number Of Active Traps")]
        NumberOfActiveTraps = 3772,
        [Description("Is Spike Trap")]
        IsSpikeTrap = 3773,
        [Description("Is Arrow Trap")]
        IsArrowTrap = 3774,
        [Description("Damage Taken +% From Spike Traps Final")]
        DamageTakenPosPctFromSpikeTrapsFinal = 3775,
        [Description("Damage Taken +% From Arrow Traps Final")]
        DamageTakenPosPctFromArrowTrapsFinal = 3776,
        [Description("Minion Damage Taken +% From Spike Traps Final")]
        MinionDamageTakenPosPctFromSpikeTrapsFinal = 3777,
        [Description("Minion Damage Taken +% From Arrow Traps Final")]
        MinionDamageTakenPosPctFromArrowTrapsFinal = 3778,
        [Description("Labyrinth Trap Degen Effect On Self +%")]
        LabyrinthTrapDegenEffectOnSelfPosPct = 3779,
        [Description("Minions Have Labyrinth Trap Degen Effect +%")]
        MinionsHaveLabyrinthTrapDegenEffectPosPct = 3780,
        [Description("Immune To Labyrinth Degen Effect")]
        ImmuneToLabyrinthDegenEffect = 3781,
        [Description("Minions Are Immune To Labyrinth Degen Effect")]
        MinionsAreImmuneToLabyrinthDegenEffect = 3782,
        [Description("Nearby Traps Within X Units Also Trigger On Triggering Trap")]
        NearbyTrapsWithinXUnitsAlsoTriggerOnTriggeringTrap = 3783,
        [Description("Number Of Additional Mines To Place")]
        NumberOfAdditionalMinesToPlace = 3784,
        [Description("Chance To Place An Additional Mine %")]
        ChanceToPlaceAnAdditionalMinePct = 3785,
        [Description("Immune To Shunt Geal")]
        ImmuneToShuntGeal = 3786,
        [Description("Chance For Elemental Damage To Be Added As Additional Chaos Damage %")]
        ChanceForElementalDamageToBeAddedAsAdditionalChaosDamagePct = 3787,
        [Description("Critical Strike Chance +% Vs Enemies Without Elemental Status Ailments")]
        CriticalStrikeChancePosPctVsEnemiesWithoutElementalStatusAilments = 3788,
        [Description("Spell Damage +% For 4 Seconds On Cast")]
        SpellDamagePosPctFor4SecondsOnCast = 3789,
        [Description("Attack Damage +% For 4 Seconds On Cast")]
        AttackDamagePosPctFor4SecondsOnCast = 3790,
        [Description("Attack Speed +% For 4 Seconds On Attack")]
        AttackSpeedPosPctFor4SecondsOnAttack = 3791,
        [Description("Cast Speed +% For 4 Seconds On Attack")]
        CastSpeedPosPctFor4SecondsOnAttack = 3792,
        [Description("Attack And Cast Speed +% For 4 Seconds On Begin Es Recharge")]
        AttackAndCastSpeedPosPctFor4SecondsOnBeginEsRecharge = 3793,
        [Description("Display Attack With Commandment Of Force On Hit %")]
        DisplayAttackWithCommandmentOfForceOnHitPct = 3794,
        [Description("Display Attack With Commandment Of Fury On Hit %")]
        DisplayAttackWithCommandmentOfFuryOnHitPct = 3795,
        [Description("Display Attack With Commandment Of Light When Critically Hit %")]
        DisplayAttackWithCommandmentOfLightWhenCriticallyHitPct = 3796,
        [Description("Display Attack With Commandment Of Spite When Hit %")]
        DisplayAttackWithCommandmentOfSpiteWhenHitPct = 3797,
        [Description("Display Attack With Decree Of Force On Hit %")]
        DisplayAttackWithDecreeOfForceOnHitPct = 3798,
        [Description("Display Attack With Decree Of Fury On Hit %")]
        DisplayAttackWithDecreeOfFuryOnHitPct = 3799,
        [Description("Display Attack With Decree Of Light When Critically Hit %")]
        DisplayAttackWithDecreeOfLightWhenCriticallyHitPct = 3800,
        [Description("Display Attack With Decree Of Spite When Hit %")]
        DisplayAttackWithDecreeOfSpiteWhenHitPct = 3801,
        [Description("Display Attack With Edict Of Force On Hit %")]
        DisplayAttackWithEdictOfForceOnHitPct = 3802,
        [Description("Display Attack With Edict Of Fury On Hit %")]
        DisplayAttackWithEdictOfFuryOnHitPct = 3803,
        [Description("Display Attack With Edict Of Ire When Hit %")]
        DisplayAttackWithEdictOfIreWhenHitPct = 3804,
        [Description("Display Attack With Edict Of Light When Critically Hit %")]
        DisplayAttackWithEdictOfLightWhenCriticallyHitPct = 3805,
        [Description("Display Attack With Edict Of Spite When Hit %")]
        DisplayAttackWithEdictOfSpiteWhenHitPct = 3806,
        [Description("Display Attack With Word Of Force On Hit %")]
        DisplayAttackWithWordOfForceOnHitPct = 3807,
        [Description("Display Attack With Word Of Fury On Hit %")]
        DisplayAttackWithWordOfFuryOnHitPct = 3808,
        [Description("Display Attack With Word Of Light When Critically Hit %")]
        DisplayAttackWithWordOfLightWhenCriticallyHitPct = 3809,
        [Description("Display Attack With Word Of Ire When Hit %")]
        DisplayAttackWithWordOfIreWhenHitPct = 3810,
        [Description("Display Attack With Word Of Spite When Hit %")]
        DisplayAttackWithWordOfSpiteWhenHitPct = 3811,
        [Description("Display Cast Commandment Of Blades On Hit % ")]
        DisplayCastCommandmentOfBladesOnHitPct = 3812,
        [Description("Display Cast Commandment Of Inferno On Kill %")]
        DisplayCastCommandmentOfInfernoOnKillPct = 3813,
        [Description("Display Cast Commandment Of Reflection When Hit %")]
        DisplayCastCommandmentOfReflectionWhenHitPct = 3814,
        [Description("Display Cast Commandment Of Tempest On Hit %")]
        DisplayCastCommandmentOfTempestOnHitPct = 3815,
        [Description("Display Cast Commandment Of The Grave On Kill %")]
        DisplayCastCommandmentOfTheGraveOnKillPct = 3816,
        [Description("Display Cast Commandment Of War On Kill %")]
        DisplayCastCommandmentOfWarOnKillPct = 3817,
        [Description("Display Cast Commandment Of Winter When Hit %")]
        DisplayCastCommandmentOfWinterWhenHitPct = 3818,
        [Description("Display Cast Decree Of Blades On Hit %  ")]
        DisplayCastDecreeOfBladesOnHitPct = 3819,
        [Description("Display Cast Decree Of Inferno On Kill %")]
        DisplayCastDecreeOfInfernoOnKillPct = 3820,
        [Description("Display Cast Decree Of Reflection When Hit %")]
        DisplayCastDecreeOfReflectionWhenHitPct = 3821,
        [Description("Display Cast Decree Of Tempest On Hit %")]
        DisplayCastDecreeOfTempestOnHitPct = 3822,
        [Description("Display Cast Decree Of The Grave On Kill %")]
        DisplayCastDecreeOfTheGraveOnKillPct = 3823,
        [Description("Display Cast Decree Of War On Kill %")]
        DisplayCastDecreeOfWarOnKillPct = 3824,
        [Description("Display Cast Decree Of Winter When Hit %")]
        DisplayCastDecreeOfWinterWhenHitPct = 3825,
        [Description("Display Cast Edict Of Blades On Hit % ")]
        DisplayCastEdictOfBladesOnHitPct = 3826,
        [Description("Display Cast Edict Of Inferno On Kill %")]
        DisplayCastEdictOfInfernoOnKillPct = 3827,
        [Description("Display Cast Edict Of Reflection When Hit %")]
        DisplayCastEdictOfReflectionWhenHitPct = 3828,
        [Description("Display Cast Edict Of Tempest On Hit %")]
        DisplayCastEdictOfTempestOnHitPct = 3829,
        [Description("Display Cast Edict Of The Grave On Kill %")]
        DisplayCastEdictOfTheGraveOnKillPct = 3830,
        [Description("Display Cast Edict Of War On Kill %")]
        DisplayCastEdictOfWarOnKillPct = 3831,
        [Description("Display Cast Edict Of Winter When Hit %")]
        DisplayCastEdictOfWinterWhenHitPct = 3832,
        [Description("Display Cast Word Of Blades On Hit %")]
        DisplayCastWordOfBladesOnHitPct = 3833,
        [Description("Display Cast Word Of Inferno On Kill %")]
        DisplayCastWordOfInfernoOnKillPct = 3834,
        [Description("Display Cast Word Of Reflection When Hit %")]
        DisplayCastWordOfReflectionWhenHitPct = 3835,
        [Description("Display Cast Word Of Tempest On Hit %")]
        DisplayCastWordOfTempestOnHitPct = 3836,
        [Description("Display Cast Word Of Winter When Hit %")]
        DisplayCastWordOfWinterWhenHitPct = 3837,
        [Description("Life Es And Mana Recovery +% For 4 Seconds On Killing Enemies Affected By Your Degen")]
        LifeEsAndManaRecoveryPosPctFor4SecondsOnKillingEnemiesAffectedByYourDegen = 3838,
        [Description("Trickster Passive Chance To Evade Attacks While Not On Full Energy Shield +% Final")]
        TricksterPassiveChanceToEvadeAttacksWhileNotOnFullEnergyShieldPosPctFinal = 3839,
        [Description("Display Cast Word Of Flames On Hit %")]
        DisplayCastWordOfFlamesOnHitPct = 3840,
        [Description("Display Cast Edict Of Flames On Hit %")]
        DisplayCastEdictOfFlamesOnHitPct = 3841,
        [Description("Display Cast Decree Of Flames On Hit %")]
        DisplayCastDecreeOfFlamesOnHitPct = 3842,
        [Description("Display Cast Commandment Of Flames On Hit %")]
        DisplayCastCommandmentOfFlamesOnHitPct = 3843,
        [Description("Display Cast Word Of Frost On Kill %")]
        DisplayCastWordOfFrostOnKillPct = 3844,
        [Description("Display Cast Edict Of Frost On Kill %")]
        DisplayCastEdictOfFrostOnKillPct = 3845,
        [Description("Display Cast Decree Of Frost On Kill %")]
        DisplayCastDecreeOfFrostOnKillPct = 3846,
        [Description("Display Cast Commandment Of Frost On Kill %")]
        DisplayCastCommandmentOfFrostOnKillPct = 3847,
        [Description("Display Cast Word Of Thunder On Kill %")]
        DisplayCastWordOfThunderOnKillPct = 3848,
        [Description("Display Cast Edict Of Thunder On Kill %")]
        DisplayCastEdictOfThunderOnKillPct = 3849,
        [Description("Display Cast Decree Of Thunder On Kill %")]
        DisplayCastDecreeOfThunderOnKillPct = 3850,
        [Description("Display Cast Commandment Of Thunder On Kill %")]
        DisplayCastCommandmentOfThunderOnKillPct = 3851,
        [Description("Display Cast Fire Burst On Kill")]
        DisplayCastFireBurstOnKill = 3852,
        [Description("Local Stat Monsters Pick Up Item")]
        LocalStatMonstersPickUpItem = 3853,
        [Description("Stone Golem Grants Base Life Regeneration Rate Per Minute")]
        StoneGolemGrantsBaseLifeRegenerationRatePerMinute = 3854,
        [Description("Bladefall Damage Per Stage +% Final")]
        BladefallDamagePerStagePosPctFinal = 3855,
        [Description("Global Maim On Hit")]
        GlobalMaimOnHit = 3856,
        [Description("Consecrate Ground For 3 Seconds When Hit %")]
        ConsecrateGroundFor3SecondsWhenHitPct = 3857,
        [Description("Damage +% On Consecrated Ground")]
        DamagePosPctOnConsecratedGround = 3858,
        [Description("Mana Cost +% On Consecrated Ground")]
        ManaCostPosPctOnConsecratedGround = 3859,
        [Description("Avoid Ailments % On Consecrated Ground")]
        AvoidAilmentsPctOnConsecratedGround = 3860,
        [Description("On Consecrated Ground")]
        OnConsecratedGround = 3861,
        [Description("Inquisitor Aura Elemental Damage +% Final")]
        InquisitorAuraElementalDamagePosPctFinal = 3862,
        [Description("Critical Strike Multiplier + Vs Enemies Affected By Elemental Status Ailment")]
        CriticalStrikeMultiplierPosVsEnemiesAffectedByElementalStatusAilment = 3863,
        [Description("Non Critical Strikes Penetrate Elemental Resistances %")]
        NonCriticalStrikesPenetrateElementalResistancesPct = 3864,
        [Description("Virtual Penetrate Elemental Resistances %")]
        VirtualPenetrateElementalResistancesPct = 3865,
        [Description("Base Penetrate Elemental Resistances %")]
        BasePenetrateElementalResistancesPct = 3866,
        [Description("Virtual Minion Additional Physical Damage Reduction Percent")]
        VirtualMinionAdditionalPhysicalDamageReductionPercent = 3867,
        [Description("Chance To Poison On Hit With Attacks %")]
        ChanceToPoisonOnHitWithAttacksPct = 3868,
        [Description("Chance To Double Stun Duration %")]
        ChanceToDoubleStunDurationPct = 3869,
        [Description("Is Guillotine Trap")]
        IsGuillotineTrap = 3870,
        [Description("Damage Taken +% From Guillotine Traps Final")]
        DamageTakenPosPctFromGuillotineTrapsFinal = 3871,
        [Description("Minion Damage Taken +% From Guillotine Traps Final")]
        MinionDamageTakenPosPctFromGuillotineTrapsFinal = 3872,
        [Description("Labyrinth Arrow Movement Speed +% Final")]
        LabyrinthArrowMovementSpeedPosPctFinal = 3873,
        [Description("Map Disable Portal Use")]
        MapDisablePortalUse = 3874,
        [Description("Jorrhasts Blacksteel Animate Weapon Duration +% Final")]
        JorrhastsBlacksteelAnimateWeaponDurationPosPctFinal = 3875,
        [Description("Shockwave Slam Explosion Damage +% Final")]
        ShockwaveSlamExplosionDamagePosPctFinal = 3876,
        [Description("Display Monster Casts Wither")]
        DisplayMonsterCastsWither = 3877,
        [Description("Display Monster Causes Ground Desecration")]
        DisplayMonsterCausesGroundDesecration = 3878,
        [Description("Spread Tar Ground When Not Igniting Enemy On Hit %")]
        SpreadTarGroundWhenNotIgnitingEnemyOnHitPct = 3879,
        [Description("Spread Burning Ground When Igniting Enemy On Hit %")]
        SpreadBurningGroundWhenIgnitingEnemyOnHitPct = 3880,
        [Description("Non Curse Aura Effect +%")]
        NonCurseAuraEffectPosPct = 3881,
        [Description("Max Talisman Degen Stacks")]
        MaxTalismanDegenStacks = 3882,
        [Description("Current Talisman Degen Stacks")]
        CurrentTalismanDegenStacks = 3883,
        [Description("Base Physical Damage Taken Per Minute Per Talisman Degen Stack")]
        BasePhysicalDamageTakenPerMinutePerTalismanDegenStack = 3884,
        [Description("Melee Splash Area Of Effect +% Final")]
        MeleeSplashAreaOfEffectPosPctFinal = 3885,
        [Description("Unarmed Damage +% Vs Bleeding Enemies")]
        UnarmedDamagePosPctVsBleedingEnemies = 3886,
        [Description("Life Gained On Bleeding Enemy Hit")]
        LifeGainedOnBleedingEnemyHit = 3887,
        [Description("Base Critical Strike Chance While Unarmed %")]
        BaseCriticalStrikeChanceWhileUnarmedPct = 3888,
        [Description("Modifiers To Claw Damage Also Affect Unarmed Damage")]
        ModifiersToClawDamageAlsoAffectUnarmedDamage = 3889,
        [Description("Damage +% While Unarmed")]
        DamagePosPctWhileUnarmed = 3890,
        [Description("Bloodworm On Damage Taken %")]
        BloodwormOnDamageTakenPct = 3891,
        [Description("Map Sidearea Level Override")]
        MapSideareaLevelOverride = 3892,
        [Description("Map Boss Talisman Tier")]
        MapBossTalismanTier = 3893,
        [Description("Map Boss Talisman Rarity")]
        MapBossTalismanRarity = 3894,
        [Description("Local Display Illusory Warp Level")]
        LocalDisplayIllusoryWarpLevel = 3895,
        [Description("Fortify Effect On Self +%")]
        FortifyEffectOnSelfPosPct = 3896,
        [Description("Local Implicit Stat Magnitude +%")]
        LocalImplicitStatMagnitudePosPct = 3897,
        [Description("Using Flask")]
        UsingFlask = 3898,
        [Description("Chance To Poison On Hit %")]
        ChanceToPoisonOnHitPct = 3899,
        [Description("Flask Charges Gained +%")]
        FlaskChargesGainedPosPct = 3900,
        [Description("Soul Eater From Stat")]
        SoulEaterFromStat = 3901,
        [Description("Gain Power Charge On Kill With Hit %")]
        GainPowerChargeOnKillWithHitPct = 3902,
        [Description("Killed Monster Dropped Item Rarity +% When Shattered")]
        KilledMonsterDroppedItemRarityPosPctWhenShattered = 3903,
        [Description("Energy Shield Delay During Flask Effect -%")]
        EnergyShieldDelayDuringFlaskEffectNegPct = 3904,
        [Description("Virtual Energy Shield Delay -%")]
        VirtualEnergyShieldDelayNegPct = 3905,
        [Description("Energy Shield Recharge Rate During Flask Effect +%")]
        EnergyShieldRechargeRateDuringFlaskEffectPosPct = 3906,
        [Description("Virtual Energy Shield Recharge Rate +%")]
        VirtualEnergyShieldRechargeRatePosPct = 3907,
        [Description("Base Cold Damage % Of Maximum Life Plus Maximum Es Taken Per Minute")]
        BaseColdDamagePctOfMaximumLifePlusMaximumESTakenPerMinute = 3908,
        [Description("Base Lightning Damage % Of Maximum Life Plus Maximum Es Taken Per Minute")]
        BaseLightningDamagePctOfMaximumLifePlusMaximumESTakenPerMinute = 3909,
        [Description("Modifiers To Claw Attack Speed Also Affect Unarmed Attack Speed")]
        ModifiersToClawAttackSpeedAlsoAffectUnarmedAttackSpeed = 3910,
        [Description("Modifiers To Claw Critical Strike Chance Also Affect Unarmed Critical Strike Chance")]
        ModifiersToClawCriticalStrikeChanceAlsoAffectUnarmedCriticalStrikeChance = 3911,
        [Description("Main Hand Chance To Poison On Critical Strike %")]
        MainHandChanceToPoisonOnCriticalStrikePct = 3912,
        [Description("Off Hand Chance To Poison On Critical Strike %")]
        OffHandChanceToPoisonOnCriticalStrikePct = 3913,
        [Description("Chance To Poison On Critical Strike With Dagger %")]
        ChanceToPoisonOnCriticalStrikeWithDaggerPct = 3914,
        [Description("Minion Duration")]
        MinionDuration = 3915,
        [Description("Number Of Wolves Allowed")]
        NumberOfWolvesAllowed = 3916,
        [Description("Whirling Leap Bloodworms To Spawn")]
        WhirlingLeapBloodwormsToSpawn = 3917,
        [Description("Map Display Unique Boss Drops X Maps")]
        MapDisplayUniqueBossDropsXMaps = 3918,
        [Description("Endurance Charge On Kill %")]
        EnduranceChargeOnKillPct = 3919,
        [Description("Fishing Bite Sensitivity +%")]
        FishingBiteSensitivityPosPct = 3920,
        [Description("Local Display Summon Wolf On Kill %")]
        LocalDisplaySummonWolfOnKillPct = 3921,
        [Description("Corrupted Blood On Hit % Average Damage To Deal Per Minute Per Stack")]
        CorruptedBloodOnHitPctAverageDamageToDealPerMinutePerStack = 3922,
        [Description("Maim On Hit % With At Least 3 Stacks Of Corrupted Blood")]
        MaimOnHitPctWithAtLeast3StacksOfCorruptedBlood = 3923,
        [Description("Monster Can Spawn With Talisman")]
        MonsterCanSpawnWithTalisman = 3924,
        [Description("Monster Explodes On Death Text")]
        MonsterExplodesOnDeathText = 3925,
        [Description("Number Of Active Wolves")]
        NumberOfActiveWolves = 3926,
        [Description("Active Skill Area Of Effect +% Final")]
        ActiveSkillAreaOfEffectPosPctFinal = 3927,
        [Description("Cold Damage +% Per 1% Block Chance")]
        ColdDamagePosPctPer1PctBlockChance = 3928,
        [Description("Maximum Mana +% Per 2% Spell Block Chance")]
        MaximumManaPosPctPer2PctSpellBlockChance = 3929,
        [Description("Physical Damage Reduction Rating +% While Chilled Or Frozen")]
        PhysicalDamageReductionRatingPosPctWhileChilledOrFrozen = 3930,
        [Description("Support Reduced Duration Damage +% Final")]
        SupportReducedDurationDamagePosPctFinal = 3931,
        [Description("Map Players Action Speed +% While Chilled")]
        MapPlayersActionSpeedPosPctWhileChilled = 3932,
        [Description("Action Speed +% While Chilled")]
        ActionSpeedPosPctWhileChilled = 3933,
        [Description("Extra Gore Chance Override %")]
        ExtraGoreChanceOverridePct = 3934,
        [Description("Siphon Base Chaos Damage To Deal Per Minute")]
        SiphonBaseChaosDamageToDealPerMinute = 3935,
        [Description("Blade Vortex Buff Range")]
        BladeVortexBuffRange = 3936,
        [Description("Spell And Attack Minimum Added Cold Damage")]
        SpellAndAttackMinimumAddedColdDamage = 3937,
        [Description("Spell And Attack Maximum Added Cold Damage")]
        SpellAndAttackMaximumAddedColdDamage = 3938,
        [Description("Reduce Enemy Cold Resistance With Weapons %")]
        ReduceEnemyColdResistanceWithWeaponsPct = 3939,
        [Description("Reduce Enemy Fire Resistance With Weapons %")]
        ReduceEnemyFireResistanceWithWeaponsPct = 3940,
        [Description("Reduce Enemy Lightning Resistance With Weapons %")]
        ReduceEnemyLightningResistanceWithWeaponsPct = 3941,
        [Description("Reduce Enemy Chaos Resistance With Weapons %")]
        ReduceEnemyChaosResistanceWithWeaponsPct = 3942,
        [Description("Support Minefield Mine Damage +% Final")]
        SupportMinefieldMineDamagePosPctFinal = 3943,
        [Description("Modifiers To Map Item Drop Quantity Also Apply To Map Item Drop Rarity")]
        ModifiersToMapItemDropQuantityAlsoApplyToMapItemDropRarity = 3944,
        [Description("Map Monster Drop Higher Level Gear")]
        MapMonsterDropHigherLevelGear = 3945,
        [Description("Support Gem Elemental Damage +% Final")]
        SupportGemElementalDamagePosPctFinal = 3946,
        [Description("Keystone Elemental Overload Damage +% Final")]
        KeystoneElementalOverloadDamagePosPctFinal = 3947,
        [Description("Keystone Elemental Overload")]
        KeystoneElementalOverload = 3948,
        [Description("Local Smoke Ground On Flask Use Radius")]
        LocalSmokeGroundOnFlaskUseRadius = 3949,
        [Description("Local Consecrate Ground On Flask Use Radius")]
        LocalConsecrateGroundOnFlaskUseRadius = 3950,
        [Description("Gain Onslaught During Flask Effect")]
        GainOnslaughtDuringFlaskEffect = 3951,
        [Description("Cast Linked Curses On Curse")]
        CastLinkedCursesOnCurse = 3952,
        [Description("Reduce Enemy Elemental Resistance With Weapons %")]
        ReduceEnemyElementalResistanceWithWeaponsPct = 3953,
        [Description("% Chance To Gain Frenzy Charge On Trap Triggered By An Enemy")]
        PctChanceToGainFrenzyChargeOnTrapTriggeredByAnEnemy = 3954,
        [Description("% Chance To Gain Endurance Charge On Trap Triggered By An Enemy")]
        PctChanceToGainEnduranceChargeOnTrapTriggeredByAnEnemy = 3955,
        [Description("Local Number Of Bloodworms To Spawn On Flask Use")]
        LocalNumberOfBloodwormsToSpawnOnFlaskUse = 3956,
        [Description("Add Power Charge On Hit %")]
        AddPowerChargeOnHitPct = 3957,
        [Description("Lose All Power Charges On Reaching Maximum Power Charges")]
        LoseAllPowerChargesOnReachingMaximumPowerCharges = 3958,
        [Description("Shocked For 4 Seconds On Reaching Maximum Power Charges")]
        ShockedFor4SecondsOnReachingMaximumPowerCharges = 3959,
        [Description("Local Display Molten Burst On Melee Hit %")]
        LocalDisplayMoltenBurstOnMeleeHitPct = 3960,
        [Description("Max Frost Nova Stacks")]
        MaxFrostNovaStacks = 3961,
        [Description("Current Frost Nova Stacks")]
        CurrentFrostNovaStacks = 3962,
        [Description("Reverse Projectile Spread")]
        ReverseProjectileSpread = 3963,
        [Description("Base Cold Damage +% Per Frost Nova Stack")]
        BaseColdDamagePosPctPerFrostNovaStack = 3964,
        [Description("Frost Nova Cold Damage +% Per Frost Nova Stack")]
        FrostNovaColdDamagePosPctPerFrostNovaStack = 3965,
        [Description("Is Petrified")]
        IsPetrified = 3966,
        [Description("Cast On Melee Hit %")]
        CastOnMeleeHitPct = 3967,
        [Description("Izaro Curse On Hit Level Temporal Chains")]
        IzaroCurseOnHitLevelTemporalChains = 3968,
        [Description("Izaro Curse On Hit Level Elemental Weakness")]
        IzaroCurseOnHitLevelElementalWeakness = 3969,
        [Description("Izaro Curse On Hit Level Vulnerability")]
        IzaroCurseOnHitLevelVulnerability = 3970,
        [Description("Labyrinth Trinket Instantly Kill Next Pylon")]
        LabyrinthTrinketInstantlyKillNextPylon = 3971,
        [Description("Labyrinth Trinket Instantly Kill Next Lieutenant")]
        LabyrinthTrinketInstantlyKillNextLieutenant = 3972,
        [Description("Labyrinth Trinket Instantly Kill Next Elemental")]
        LabyrinthTrinketInstantlyKillNextElemental = 3973,
        [Description("Labyrinth Trinket Instantly Kill Next Gargoyle")]
        LabyrinthTrinketInstantlyKillNextGargoyle = 3974,
        [Description("Labyrinth Trinket Permanently Disable Next Statue")]
        LabyrinthTrinketPermanentlyDisableNextStatue = 3975,
        [Description("Labyrinth Trinket Permanently Disable Next Symbol")]
        LabyrinthTrinketPermanentlyDisableNextSymbol = 3976,
        [Description("Labyrinth Trinket Reactivate Next Charge Disruptor After 5 Seconds")]
        LabyrinthTrinketReactivateNextChargeDisruptorAfter5Seconds = 3977,
        [Description("Add Endurance Charge On Gain Power Charge %")]
        AddEnduranceChargeOnGainPowerChargePct = 3978,
        [Description("Stacking Damage +% On Kill For 4 Seconds")]
        StackingDamagePosPctOnKillFor4Seconds = 3979,
        [Description("Grant Owner Stacking Damage +% On Kill For 4 Seconds")]
        GrantOwnerStackingDamagePosPctOnKillFor4Seconds = 3980,
        [Description("Attack And Cast Speed +% While Totem Active")]
        AttackAndCastSpeedPosPctWhileTotemActive = 3981,
        [Description("Number Of Additional Totems Allowed On Kill For 8 Seconds")]
        NumberOfAdditionalTotemsAllowedOnKillFor8Seconds = 3982,
        [Description("Owner Number Of Additional Totems Allowed On Kill For 8 Seconds")]
        OwnerNumberOfAdditionalTotemsAllowedOnKillFor8Seconds = 3983,
        [Description("Map Monsters Base Self Critical Strike Multiplier -%")]
        MapMonstersBaseSelfCriticalStrikeMultiplierNegPct = 3984,
        [Description("Local Flask Is Petrified")]
        LocalFlaskIsPetrified = 3985,
        [Description("Hierophant Helmet Supported By Elemental Penetration")]
        HierophantHelmetSupportedByElementalPenetration = 3986,
        [Description("Hierophant Gloves Supported By Increased Area Of Effect")]
        HierophantGlovesSupportedByIncreasedAreaOfEffect = 3987,
        [Description("Hierophant Boots Supported By Life Leech")]
        HierophantBootsSupportedByLifeLeech = 3988,
        [Description("Power Frenzy Or Endurance Charge On Kill %")]
        PowerFrenzyOrEnduranceChargeOnKillPct = 3989,
        [Description("Local Flask Effect +%")]
        LocalFlaskEffectPosPct = 3990,
        [Description("Local Flask Poison Immunity During Flask Effect")]
        LocalFlaskPoisonImmunityDuringFlaskEffect = 3991,
        [Description("Immune To Poison")]
        ImmuneToPoison = 3992,
        [Description("Local Flask Additional Physical Damage Reduction %")]
        LocalFlaskAdditionalPhysicalDamageReductionPct = 3993,
        [Description("Unique Spread Poison To Nearby Allies As 200 Life Regeneration Per Second On Kill")]
        UniqueSpreadPoisonToNearbyAlliesAs200LifeRegenerationPerSecondOnKill = 3994,
        [Description("Support Pierce Projectile Damage +% Final")]
        SupportPierceProjectileDamagePosPctFinal = 3995,
        [Description("Elementalist Damage With An Element +% For 4 Seconds After Being Hit By An Element")]
        ElementalistDamageWithAnElementPosPctFor4SecondsAfterBeingHitByAnElement = 3996,
        [Description("Elementalist Elemental Damage +% For 4 Seconds Every 10 Seconds")]
        ElementalistElementalDamagePosPctFor4SecondsEvery10Seconds = 3997,
        [Description("Elementalist Cold Penetration % For 4 Seconds On Using Fire Skill")]
        ElementalistColdPenetrationPctFor4SecondsOnUsingFireSkill = 3998,
        [Description("Elementalist Lightning Penetration % For 4 Seconds On Using Cold Skill")]
        ElementalistLightningPenetrationPctFor4SecondsOnUsingColdSkill = 3999,
        [Description("Elementalist Fire Penetration % For 4 Seconds On Using Lightning Skill")]
        ElementalistFirePenetrationPctFor4SecondsOnUsingLightningSkill = 4000,
        [Description("Elementalist Summon Elemental Golem On Killing Enemy With Element %")]
        ElementalistSummonElementalGolemOnKillingEnemyWithElementPct = 4001,
        [Description("Elementalist All Damage Causes Chill Shock And Ignite For 4 Seconds On Kill %")]
        ElementalistAllDamageCausesChillShockAndIgniteFor4SecondsOnKillPct = 4002,
        [Description("Elementalist Elemental Status Effect Aura Radius")]
        ElementalistElementalStatusEffectAuraRadius = 4003,
        [Description("Elementalist Elemental Damage Rotation")]
        ElementalistElementalDamageRotation = 4004,
        [Description("Virtual Elemental Status Effect Aura Radius")]
        VirtualElementalStatusEffectAuraRadius = 4005,
        [Description("All Damage Can Chill Ignite Shock")]
        AllDamageCanChillIgniteShock = 4006,
        [Description("Is Blighted")]
        IsBlighted = 4007,
        [Description("Virtual Life Leech Permyriad On Crit")]
        VirtualLifeLeechPermyriadOnCrit = 4008,
        [Description("Occultist Gain % Of Non Chaos Damage As Chaos Damage Per Curse On Target On Kill For 4 Seconds")]
        OccultistGainPctOfNonChaosDamageAsChaosDamagePerCurseOnTargetOnKillFor4Seconds = 4009,
        [Description("Occultist Energy Shield Always Recovers For 4 Seconds After Starting Recovery")]
        OccultistEnergyShieldAlwaysRecoversFor4SecondsAfterStartingRecovery = 4010,
        [Description("Occultist Stun Threshold Is Based On Energy Shield Instead Of Life")]
        OccultistStunThresholdIsBasedOnEnergyShieldInsteadOfLife = 4011,
        [Description("Is Counterattack")]
        IsCounterattack = 4012,
        [Description("Knockback On Counterattack %")]
        KnockbackOnCounterattackPct = 4013,
        [Description("Local Flask Chilled Ground On Flask Use Radius")]
        LocalFlaskChilledGroundOnFlaskUseRadius = 4014,
        [Description("Local Flask Duration +%")]
        LocalFlaskDurationPosPct = 4015,
        [Description("Max Charged Attack Stacks")]
        MaxChargedAttackStacks = 4016,
        [Description("Current Charged Attack Stacks")]
        CurrentChargedAttackStacks = 4017,
        [Description("Local Display Socketed Curse Gems Supported By Level X Blasphemy")]
        LocalDisplaySocketedCurseGemsSupportedByLevelXBlasphemy = 4018,
        [Description("Chill On You Proliferates To Nearby Enemies Within X Radius")]
        ChillOnYouProliferatesToNearbyEnemiesWithinXRadius = 4019,
        [Description("Freeze On You Proliferates To Nearby Enemies Within X Radius")]
        FreezeOnYouProliferatesToNearbyEnemiesWithinXRadius = 4020,
        [Description("Animate Weapon Damage +%")]
        AnimateWeaponDamagePosPct = 4021,
        [Description("Burning Arrow Damage +%")]
        BurningArrowDamagePosPct = 4022,
        [Description("Cleave Damage +%")]
        CleaveDamagePosPct = 4023,
        [Description("Double Strike Damage +%")]
        DoubleStrikeDamagePosPct = 4024,
        [Description("Dual Strike Damage +%")]
        DualStrikeDamagePosPct = 4025,
        [Description("Fire Trap Damage +%")]
        FireTrapDamagePosPct = 4026,
        [Description("Fireball Damage +%")]
        FireballDamagePosPct = 4027,
        [Description("Freezing Pulse Damage +%")]
        FreezingPulseDamagePosPct = 4028,
        [Description("Glacial Hammer Damage +%")]
        GlacialHammerDamagePosPct = 4029,
        [Description("Ground Slam Damage +%")]
        GroundSlamDamagePosPct = 4030,
        [Description("Heavy Strike Damage +%")]
        HeavyStrikeDamagePosPct = 4031,
        [Description("Infernal Blow Damage +%")]
        InfernalBlowDamagePosPct = 4032,
        [Description("Lightning Strike Damage +%")]
        LightningStrikeDamagePosPct = 4033,
        [Description("Lightning Tendrils Damage +%")]
        LightningTendrilsDamagePosPct = 4034,
        [Description("Magma Orb Damage +%")]
        MagmaOrbDamagePosPct = 4035,
        [Description("Molten Strike Damage +%")]
        MoltenStrikeDamagePosPct = 4036,
        [Description("Zombie Damage +%")]
        ZombieDamagePosPct = 4037,
        [Description("Reave Damage +%")]
        ReaveDamagePosPct = 4038,
        [Description("Spark Damage +%")]
        SparkDamagePosPct = 4039,
        [Description("Spectral Throw Damage +%")]
        SpectralThrowDamagePosPct = 4040,
        [Description("Split Arrow Damage +%")]
        SplitArrowDamagePosPct = 4041,
        [Description("Ethereal Knives Damage +%")]
        EtherealKnivesDamagePosPct = 4042,
        [Description("Ice Shot Damage +%")]
        IceShotDamagePosPct = 4043,
        [Description("Rain Of Arrows Damage +%")]
        RainOfArrowsDamagePosPct = 4044,
        [Description("Raging Spirit Damage +%")]
        RagingSpiritDamagePosPct = 4045,
        [Description("Viper Strike Damage +%")]
        ViperStrikeDamagePosPct = 4046,
        [Description("Flicker Strike Damage +%")]
        FlickerStrikeDamagePosPct = 4047,
        [Description("Leap Slam Damage +%")]
        LeapSlamDamagePosPct = 4048,
        [Description("Lightning Arrow Damage +%")]
        LightningArrowDamagePosPct = 4049,
        [Description("Lightning Warp Damage +%")]
        LightningWarpDamagePosPct = 4050,
        [Description("Puncture Damage +%")]
        PunctureDamagePosPct = 4051,
        [Description("Shield Charge Damage +%")]
        ShieldChargeDamagePosPct = 4052,
        [Description("Skeletons Damage +%")]
        SkeletonsDamagePosPct = 4053,
        [Description("Arc Damage +%")]
        ArcDamagePosPct = 4054,
        [Description("Barrage Damage +%")]
        BarrageDamagePosPct = 4055,
        [Description("Fire Nova Mine Damage +%")]
        FireNovaMineDamagePosPct = 4056,
        [Description("Fire Storm Damage +%")]
        FireStormDamagePosPct = 4057,
        [Description("Flame Surge Damage +%")]
        FlameSurgeDamagePosPct = 4058,
        [Description("Ice Nova Damage +%")]
        IceNovaDamagePosPct = 4059,
        [Description("Ice Spear Damage +%")]
        IceSpearDamagePosPct = 4060,
        [Description("Incinerate Damage +%")]
        IncinerateDamagePosPct = 4061,
        [Description("Power Siphon Damage +%")]
        PowerSiphonDamagePosPct = 4062,
        [Description("Searing Bond Damage +%")]
        SearingBondDamagePosPct = 4063,
        [Description("Static Strike Damage +%")]
        StaticStrikeDamagePosPct = 4064,
        [Description("Storm Call Damage +%")]
        StormCallDamagePosPct = 4065,
        [Description("Sweep Damage +%")]
        SweepDamagePosPct = 4066,
        [Description("Frenzy Damage +%")]
        FrenzyDamagePosPct = 4067,
        [Description("Righteous Fire Damage +%")]
        RighteousFireDamagePosPct = 4068,
        [Description("Elemental Hit Damage +%")]
        ElementalHitDamagePosPct = 4069,
        [Description("Cyclone Damage +%")]
        CycloneDamagePosPct = 4070,
        [Description("Tornado Shot Damage +%")]
        TornadoShotDamagePosPct = 4071,
        [Description("Arctic Breath Damage +%")]
        ArcticBreathDamagePosPct = 4072,
        [Description("Explosive Arrow Damage +%")]
        ExplosiveArrowDamagePosPct = 4073,
        [Description("Flameblast Damage +%")]
        FlameblastDamagePosPct = 4074,
        [Description("Glacial Cascade Damage +%")]
        GlacialCascadeDamagePosPct = 4075,
        [Description("Ice Crash Damage +%")]
        IceCrashDamagePosPct = 4076,
        [Description("Kinetic Blast Damage +%")]
        KineticBlastDamagePosPct = 4077,
        [Description("Shock Nova Damage +%")]
        ShockNovaDamagePosPct = 4078,
        [Description("Shockwave Totem Damage +%")]
        ShockwaveTotemDamagePosPct = 4079,
        [Description("Wild Strike Damage +%")]
        WildStrikeDamagePosPct = 4080,
        [Description("Detonate Dead Damage +%")]
        DetonateDeadDamagePosPct = 4081,
        [Description("Caustic Arrow Damage +%")]
        CausticArrowDamagePosPct = 4082,
        [Description("Chaos Golem Damage +%")]
        ChaosGolemDamagePosPct = 4083,
        [Description("Flame Golem Damage +%")]
        FlameGolemDamagePosPct = 4084,
        [Description("Ice Golem Damage +%")]
        IceGolemDamagePosPct = 4085,
        [Description("Cold Snap Damage +%")]
        ColdSnapDamagePosPct = 4086,
        [Description("Flame Totem Damage +%")]
        FlameTotemDamagePosPct = 4087,
        [Description("Animate Guardian Damage +%")]
        AnimateGuardianDamagePosPct = 4088,
        [Description("Bear Trap Damage +%")]
        BearTrapDamagePosPct = 4089,
        [Description("Frost Wall Damage +%")]
        FrostWallDamagePosPct = 4090,
        [Description("Molten Shell Damage +%")]
        MoltenShellDamagePosPct = 4091,
        [Description("Reckoning Damage +%")]
        ReckoningDamagePosPct = 4092,
        [Description("Vigilant Strike Damage +%")]
        VigilantStrikeDamagePosPct = 4093,
        [Description("Whirling Blades Damage +%")]
        WhirlingBladesDamagePosPct = 4094,
        [Description("Flame Dash Damage +%")]
        FlameDashDamagePosPct = 4095,
        [Description("Freeze Mine Damage +%")]
        FreezeMineDamagePosPct = 4096,
        [Description("Herald Of Ash Damage +%")]
        HeraldOfAshDamagePosPct = 4097,
        [Description("Herald Of Ice Damage +%")]
        HeraldOfIceDamagePosPct = 4098,
        [Description("Herald Of Thunder Damage +%")]
        HeraldOfThunderDamagePosPct = 4099,
        [Description("Tempest Shield Damage +%")]
        TempestShieldDamagePosPct = 4100,
        [Description("Desecrate Damage +%")]
        DesecrateDamagePosPct = 4101,
        [Description("Blink Arrow And Blink Arrow Clone Damage +%")]
        BlinkArrowAndBlinkArrowCloneDamagePosPct = 4102,
        [Description("Mirror Arrow And Mirror Arrow Clone Damage +%")]
        MirrorArrowAndMirrorArrowCloneDamagePosPct = 4103,
        [Description("Riposte Damage +%")]
        RiposteDamagePosPct = 4104,
        [Description("Vengeance Damage +%")]
        VengeanceDamagePosPct = 4105,
        [Description("Converted Enemies Damage +%")]
        ConvertedEnemiesDamagePosPct = 4106,
        [Description("Abyssal Cry Damage +%")]
        AbyssalCryDamagePosPct = 4107,
        [Description("Shrapnel Shot Damage +%")]
        ShrapnelShotDamagePosPct = 4108,
        [Description("Blast Rain Damage +%")]
        BlastRainDamagePosPct = 4109,
        [Description("Essence Drain Damage +%")]
        EssenceDrainDamagePosPct = 4110,
        [Description("Contagion Damage +%")]
        ContagionDamagePosPct = 4111,
        [Description("Blade Vortex Damage +%")]
        BladeVortexDamagePosPct = 4112,
        [Description("Bladefall Damage +%")]
        BladefallDamagePosPct = 4113,
        [Description("Ice Trap Damage +%")]
        IceTrapDamagePosPct = 4114,
        [Description("Earthquake Damage +%")]
        EarthquakeDamagePosPct = 4115,
        [Description("Stone Golem Damage +%")]
        StoneGolemDamagePosPct = 4116,
        [Description("Frost Bomb Damage +%")]
        FrostBombDamagePosPct = 4117,
        [Description("Orb Of Storms Damage +%")]
        OrbOfStormsDamagePosPct = 4118,
        [Description("Siege Ballista Damage +%")]
        SiegeBallistaDamagePosPct = 4119,
        [Description("Blight Damage +%")]
        BlightDamagePosPct = 4120,
        [Description("Shockwave Slam Damage +%")]
        ShockwaveSlamDamagePosPct = 4121,
        [Description("Fire Beam Damage +%")]
        FireBeamDamagePosPct = 4122,
        [Description("Life Regeneration Per Minute % While Frozen")]
        LifeRegenerationPerMinutePctWhileFrozen = 4123,
        [Description("Occultist Stacking Energy Shield Regeneration Rate Per Minute % On Kill For 4 Seconds")]
        OccultistStackingEnergyShieldRegenerationRatePerMinutePctOnKillFor4Seconds = 4124,
        [Description("Occultist Immune To Stun While Has Energy Shield")]
        OccultistImmuneToStunWhileHasEnergyShield = 4125,
        [Description("Totem Damage +% Final Per Active Totem")]
        TotemDamagePosPctFinalPerActiveTotem = 4126,
        [Description("Totem Damage +% Final")]
        TotemDamagePosPctFinal = 4127,
        [Description("Cannot Be Affected By Flasks")]
        CannotBeAffectedByFlasks = 4128,
        [Description("Flasks Apply To Your Zombies And Spectres")]
        FlasksApplyToYourZombiesAndSpectres = 4129,
        [Description("Modifiers To Minion Damage Also Affect You")]
        ModifiersToMinionDamageAlsoAffectYou = 4130,
        [Description("Modifiers To Minion Attack Speed Also Affect You")]
        ModifiersToMinionAttackSpeedAlsoAffectYou = 4131,
        [Description("Modifiers To Minion Cast Speed Also Affect You")]
        ModifiersToMinionCastSpeedAlsoAffectYou = 4132,
        [Description("Modifiers To Minion Life Regeneration Also Affect You")]
        ModifiersToMinionLifeRegenerationAlsoAffectYou = 4133,
        [Description("Modifiers To Minion Movement Speed Also Affect You")]
        ModifiersToMinionMovementSpeedAlsoAffectYou = 4134,
        [Description("Modifiers To Minion Resistances Also Affect You")]
        ModifiersToMinionResistancesAlsoAffectYou = 4135,
        [Description("Cast On Gain Skill")]
        CastOnGainSkill = 4136,
        [Description("Base Lightning Damage Taken Per Second")]
        BaseLightningDamageTakenPerSecond = 4137,
        [Description("Current Izaro Charges")]
        CurrentIzaroCharges = 4138,
        [Description("Attack Speed +% Per Izaro Charge")]
        AttackSpeedPosPctPerIzaroCharge = 4139,
        [Description("Cast Speed +% Per Izaro Charge")]
        CastSpeedPosPctPerIzaroCharge = 4140,
        [Description("Damage +% Per Izaro Charge Final")]
        DamagePosPctPerIzaroChargeFinal = 4141,
        [Description("Physical Damage Reduction % Per Izaro Charge")]
        PhysicalDamageReductionPctPerIzaroCharge = 4142,
        [Description("Resist All Elements % Per Izaro Charge")]
        ResistAllElementsPctPerIzaroCharge = 4143,
        [Description("Critical Strike Chance +% Per Izaro Charge")]
        CriticalStrikeChancePosPctPerIzaroCharge = 4144,
        [Description("Shield Charge Scaling Stun Threshold Reduction +% At Maximum Range")]
        ShieldChargeScalingStunThresholdReductionPosPctAtMaximumRange = 4145,
        [Description("Map Spawn Perandus Chests")]
        MapSpawnPerandusChests = 4146,
        [Description("Set User Life To 1 On Skill Use")]
        SetUserLifeTo1OnSkillUse = 4147,
        [Description("Grant Izaro Buff On Skill Use")]
        GrantIzaroBuffOnSkillUse = 4148,
        [Description("Local Double Damage To Chilled Enemies")]
        LocalDoubleDamageToChilledEnemies = 4149,
        [Description("Main Hand Double Damage To Chilled Enemies")]
        MainHandDoubleDamageToChilledEnemies = 4150,
        [Description("Off Hand Double Damage To Chilled Enemies")]
        OffHandDoubleDamageToChilledEnemies = 4151,
        [Description("Global Number Of Times Damage Is Doubled")]
        GlobalNumberOfTimesDamageIsDoubled = 4152,
        [Description("Main Hand Number Of Times Damage Is Doubled")]
        MainHandNumberOfTimesDamageIsDoubled = 4153,
        [Description("Off Hand Number Of Times Damage Is Doubled")]
        OffHandNumberOfTimesDamageIsDoubled = 4154,
        [Description("Base Main Hand Number Of Times Damage Is Doubled")]
        BaseMainHandNumberOfTimesDamageIsDoubled = 4155,
        [Description("Base Off Hand Number Of Times Damage Is Doubled")]
        BaseOffHandNumberOfTimesDamageIsDoubled = 4156,
        [Description("Local Elemental Penetration %")]
        LocalElementalPenetrationPct = 4157,
        [Description("Main Hand Elemental Penetration %")]
        MainHandElementalPenetrationPct = 4158,
        [Description("Off Hand Elemental Penetration %")]
        OffHandElementalPenetrationPct = 4159,
        [Description("Damage While No Frenzy Charges +%")]
        DamageWhileNoFrenzyChargesPosPct = 4160,
        [Description("Local Flask Ghost Reaver")]
        LocalFlaskGhostReaver = 4161,
        [Description("Local Flask Zealots Oath")]
        LocalFlaskZealotsOath = 4162,
        [Description("Critical Strike Chance Against Enemies On Full Life +%")]
        CriticalStrikeChanceAgainstEnemiesOnFullLifePosPct = 4163,
        [Description("Spirit Offering Life % Added As Base Maximum Energy Shield Per Corpse Consumed")]
        SpiritOfferingLifePctAddedAsBaseMaximumEnergyShieldPerCorpseConsumed = 4164,
        [Description("Minions Deal % Of Physical Damage As Additional Chaos Damage")]
        MinionsDealPctOfPhysicalDamageAsAdditionalChaosDamage = 4165,
        [Description("Attack Critical Strike Damage Life Leech Permyriad")]
        AttackCriticalStrikeDamageLifeLeechPermyriad = 4166,
        [Description("Minion Attack Minimum Added Physical Damage")]
        MinionAttackMinimumAddedPhysicalDamage = 4167,
        [Description("Minion Attack Maximum Added Physical Damage")]
        MinionAttackMaximumAddedPhysicalDamage = 4168,
        [Description("Attack Physical Damage % To Add As Lightning")]
        AttackPhysicalDamagePctToAddAsLightning = 4169,
        [Description("Attack Physical Damage % To Add As Fire")]
        AttackPhysicalDamagePctToAddAsFire = 4170,
        [Description("Maximum Energy Shield + Per 5 Strength")]
        MaximumEnergyShieldPosPer5Strength = 4171,
        [Description("Attack Always Crit")]
        AttackAlwaysCrit = 4172,
        [Description("Totem Aura Enemy Damage +% Final")]
        TotemAuraEnemyDamagePosPctFinal = 4173,
        [Description("Totem Aura Enemy Fire And Physical Damage Taken +%")]
        TotemAuraEnemyFireAndPhysicalDamageTakenPosPct = 4174,
        [Description("Local Varunastra Weapon Counts As All 1h Melee Weapon Types")]
        LocalVarunastraWeaponCountsAsAll1hMeleeWeaponTypes = 4175,
        [Description("Main Hand Varunastra Weapon Counts As All 1h Melee Weapon Types")]
        MainHandVarunastraWeaponCountsAsAll1hMeleeWeaponTypes = 4176,
        [Description("Off Hand Varunastra Weapon Counts As All 1h Melee Weapon Types")]
        OffHandVarunastraWeaponCountsAsAll1hMeleeWeaponTypes = 4177,
        [Description("Guardian Warcry Grant Attack Cast And Movement Speed To You And Nearby Allies +%")]
        GuardianWarcryGrantAttackCastAndMovementSpeedToYouAndNearbyAlliesPosPct = 4178,
        [Description("Guardian Auras Grant Life Regeneration Per Minute %")]
        GuardianAurasGrantLifeRegenerationPerMinutePct = 4179,
        [Description("Guardian Nearby Enemies Cannot Gain Charges")]
        GuardianNearbyEnemiesCannotGainCharges = 4180,
        [Description("Guardian Reserved Life Granted To You And Allies As Armour %")]
        GuardianReservedLifeGrantedToYouAndAlliesAsArmourPct = 4181,
        [Description("Guardian Remove Curses And Status Ailments Every 10 Seconds")]
        GuardianRemoveCursesAndStatusAilmentsEvery10Seconds = 4182,
        [Description("Guardian Gain Life Regeneration Per Minute % For 1 Second Every 10 Seconds")]
        GuardianGainLifeRegenerationPerMinutePctFor1SecondEvery10Seconds = 4183,
        [Description("Life Reserved")]
        LifeReserved = 4184,
        [Description("Cannot Gain Charges")]
        CannotGainCharges = 4185,
        [Description("Max Izaro Charges")]
        MaxIzaroCharges = 4186,
        [Description("Local Display Socketed Gems Supported By Level X Fortify")]
        LocalDisplaySocketedGemsSupportedByLevelXFortify = 4187,
        [Description("Base Fire Immunity")]
        BaseFireImmunity = 4188,
        [Description("Totem Fire Immunity")]
        TotemFireImmunity = 4189,
        [Description("Base % Maximum Life Inflicted As Aoe Fire Damage When Hit")]
        BasePctMaximumLifeInflictedAsAoeFireDamageWhenHit = 4190,
        [Description("Totem % Maximum Life Inflicted As Aoe Fire Damage When Hit")]
        TotemPctMaximumLifeInflictedAsAoeFireDamageWhenHit = 4191,
        [Description("Active Skill Attack Speed +% Final Per Frenzy Charge")]
        ActiveSkillAttackSpeedPosPctFinalPerFrenzyCharge = 4192,
        [Description("Trap Damage Buildup Damage +% Final")]
        TrapDamageBuildupDamagePosPctFinal = 4193,
        [Description("Trap Damage Buildup Damage +% Final When First Set")]
        TrapDamageBuildupDamagePosPctFinalWhenFirstSet = 4194,
        [Description("Trap Damage Buildup Damage +% Final After 4 Seconds")]
        TrapDamageBuildupDamagePosPctFinalAfter4Seconds = 4195,
        [Description("Local Display Grants Level X Summon Stone Golem")]
        LocalDisplayGrantsLevelXSummonStoneGolem = 4196,
        [Description("Global Total Minimum Added Physical Damage")]
        GlobalTotalMinimumAddedPhysicalDamage = 4197,
        [Description("Global Total Maximum Added Physical Damage")]
        GlobalTotalMaximumAddedPhysicalDamage = 4198,
        [Description("Local Flask Immune To Damage")]
        LocalFlaskImmuneToDamage = 4199,
        [Description("Local Weapon Always Crit")]
        LocalWeaponAlwaysCrit = 4200,
        [Description("Main Hand Weapon Always Crit")]
        MainHandWeaponAlwaysCrit = 4201,
        [Description("Off Hand Weapon Always Crit")]
        OffHandWeaponAlwaysCrit = 4202,
        [Description("Trap And Mine Minimum Added Physical Damage")]
        TrapAndMineMinimumAddedPhysicalDamage = 4203,
        [Description("Trap And Mine Maximum Added Physical Damage")]
        TrapAndMineMaximumAddedPhysicalDamage = 4204,
        [Description("Trap % Chance To Trigger Twice")]
        TrapPctChanceToTriggerTwice = 4205,
        [Description("Trap Has Triggered")]
        TrapHasTriggered = 4206,
        [Description("Physical Damage Over Time Per 10 Dexterity +%")]
        PhysicalDamageOverTimePer10DexterityPosPct = 4207,
        [Description("Bleed Duration Per 12 Intelligence +%")]
        BleedDurationPer12IntelligencePosPct = 4208,
        [Description("% Chance To Cause Bleeding Enemies To Flee On Hit")]
        PctChanceToCauseBleedingEnemiesToFleeOnHit = 4209,
        [Description("Labyrinth Trinket Permanently Disable Statue Healing")]
        LabyrinthTrinketPermanentlyDisableStatueHealing = 4210,
        [Description("Labyrinth Trinket Instantly Kill Next Pedestal")]
        LabyrinthTrinketInstantlyKillNextPedestal = 4211,
        [Description("Labyrinth Trinket Instantly Kill Next Portal")]
        LabyrinthTrinketInstantlyKillNextPortal = 4212,
        [Description("Number Of Perandus Coin Stacks To Drop")]
        NumberOfPerandusCoinStacksToDrop = 4213,
        [Description("Melee Ancestor Totem Grant Owner Attack Speed +% Final")]
        MeleeAncestorTotemGrantOwnerAttackSpeedPosPctFinal = 4214,
        [Description("Gain Cannot Be Stunned Aura For 4 Seconds On Block Radius")]
        GainCannotBeStunnedAuraFor4SecondsOnBlockRadius = 4215,
        [Description("Cleave Radius +%")]
        CleaveRadiusPosPct = 4216,
        [Description("Ground Slam Radius +%")]
        GroundSlamRadiusPosPct = 4217,
        [Description("Infernal Blow Radius +%")]
        InfernalBlowRadiusPosPct = 4218,
        [Description("Lightning Tendrils Radius +%")]
        LightningTendrilsRadiusPosPct = 4219,
        [Description("Magma Orb Radius +%")]
        MagmaOrbRadiusPosPct = 4220,
        [Description("Reave Radius +%")]
        ReaveRadiusPosPct = 4221,
        [Description("Molten Strike Radius +%")]
        MoltenStrikeRadiusPosPct = 4222,
        [Description("Ice Shot Radius +%")]
        IceShotRadiusPosPct = 4223,
        [Description("Rain Of Arrows Radius +%")]
        RainOfArrowsRadiusPosPct = 4224,
        [Description("Leap Slam Radius +%")]
        LeapSlamRadiusPosPct = 4225,
        [Description("Lightning Arrow Radius +%")]
        LightningArrowRadiusPosPct = 4226,
        [Description("Ice Nova Radius +%")]
        IceNovaRadiusPosPct = 4227,
        [Description("Static Strike Radius +%")]
        StaticStrikeRadiusPosPct = 4228,
        [Description("Storm Call Radius +%")]
        StormCallRadiusPosPct = 4229,
        [Description("Sweep Radius +%")]
        SweepRadiusPosPct = 4230,
        [Description("Righteous Fire Radius +%")]
        RighteousFireRadiusPosPct = 4231,
        [Description("Arctic Breath Radius +%")]
        ArcticBreathRadiusPosPct = 4232,
        [Description("Ball Lightning Radius +%")]
        BallLightningRadiusPosPct = 4233,
        [Description("Explosive Arrow Radius +%")]
        ExplosiveArrowRadiusPosPct = 4234,
        [Description("Flameblast Radius +%")]
        FlameblastRadiusPosPct = 4235,
        [Description("Glacial Cascade Radius +%")]
        GlacialCascadeRadiusPosPct = 4236,
        [Description("Wild Strike Radius +%")]
        WildStrikeRadiusPosPct = 4237,
        [Description("Detonate Dead Radius +%")]
        DetonateDeadRadiusPosPct = 4238,
        [Description("Ice Crash Radius +%")]
        IceCrashRadiusPosPct = 4239,
        [Description("Kinetic Blast Radius +%")]
        KineticBlastRadiusPosPct = 4240,
        [Description("Caustic Arrow Radius +%")]
        CausticArrowRadiusPosPct = 4241,
        [Description("Cold Snap Radius +%")]
        ColdSnapRadiusPosPct = 4242,
        [Description("Decoy Totem Radius +%")]
        DecoyTotemRadiusPosPct = 4243,
        [Description("Shock Nova Radius +%")]
        ShockNovaRadiusPosPct = 4244,
        [Description("Shockwave Totem Radius +%")]
        ShockwaveTotemRadiusPosPct = 4245,
        [Description("Cleave Attack Speed +%")]
        CleaveAttackSpeedPosPct = 4246,
        [Description("Double Strike Attack Speed +%")]
        DoubleStrikeAttackSpeedPosPct = 4247,
        [Description("Dual Strike Attack Speed +%")]
        DualStrikeAttackSpeedPosPct = 4248,
        [Description("Heavy Strike Attack Speed +%")]
        HeavyStrikeAttackSpeedPosPct = 4249,
        [Description("Zombie Attack Speed +%")]
        ZombieAttackSpeedPosPct = 4250,
        [Description("Rain Of Arrows Attack Speed +%")]
        RainOfArrowsAttackSpeedPosPct = 4251,
        [Description("Leap Slam Attack Speed +%")]
        LeapSlamAttackSpeedPosPct = 4252,
        [Description("Shield Charge Attack Speed +%")]
        ShieldChargeAttackSpeedPosPct = 4253,
        [Description("Barrage Attack Speed +%")]
        BarrageAttackSpeedPosPct = 4254,
        [Description("Elemental Hit Attack Speed +%")]
        ElementalHitAttackSpeedPosPct = 4255,
        [Description("Cyclone Attack Speed +%")]
        CycloneAttackSpeedPosPct = 4256,
        [Description("Power Siphon Attack Speed +%")]
        PowerSiphonAttackSpeedPosPct = 4257,
        [Description("Spectre Attack And Cast Speed +%")]
        SpectreAttackAndCastSpeedPosPct = 4258,
        [Description("Freezing Pulse Cast Speed +%")]
        FreezingPulseCastSpeedPosPct = 4259,
        [Description("Fireball Cast Speed +%")]
        FireballCastSpeedPosPct = 4260,
        [Description("Fire Nova Mine Cast Speed +%")]
        FireNovaMineCastSpeedPosPct = 4261,
        [Description("Lightning Warp Cast Speed +%")]
        LightningWarpCastSpeedPosPct = 4262,
        [Description("Fire Trap Cooldown Speed +%")]
        FireTrapCooldownSpeedPosPct = 4263,
        [Description("Flicker Strike Cooldown Speed +%")]
        FlickerStrikeCooldownSpeedPosPct = 4264,
        [Description("Cold Snap Cooldown Speed +%")]
        ColdSnapCooldownSpeedPosPct = 4265,
        [Description("Ball Lightning Projectile Speed +%")]
        BallLightningProjectileSpeedPosPct = 4266,
        [Description("Freezing Pulse Projectile Speed +%")]
        FreezingPulseProjectileSpeedPosPct = 4267,
        [Description("Spark Projectile Speed +%")]
        SparkProjectileSpeedPosPct = 4268,
        [Description("Spectral Throw Projectile Speed +%")]
        SpectralThrowProjectileSpeedPosPct = 4269,
        [Description("Ethereal Knives Projectile Speed +%")]
        EtherealKnivesProjectileSpeedPosPct = 4270,
        [Description("Flame Totem Projectile Speed +%")]
        FlameTotemProjectileSpeedPosPct = 4271,
        [Description("Incinerate Projectile Speed +%")]
        IncinerateProjectileSpeedPosPct = 4272,
        [Description("Dominating Blow Duration +%")]
        DominatingBlowDurationPosPct = 4273,
        [Description("Puncture Duration +%")]
        PunctureDurationPosPct = 4274,
        [Description("Viper Strike Poison Duration +%")]
        ViperStrikePoisonDurationPosPct = 4275,
        [Description("Firestorm Duration +%")]
        FirestormDurationPosPct = 4276,
        [Description("Static Strike Duration +%")]
        StaticStrikeDurationPosPct = 4277,
        [Description("Storm Call Duration +%")]
        StormCallDurationPosPct = 4278,
        [Description("Arctic Breath Duration +%")]
        ArcticBreathDurationPosPct = 4279,
        [Description("Lightning Warp Duration +%")]
        LightningWarpDurationPosPct = 4280,
        [Description("Ice Shot Duration +%")]
        IceShotDurationPosPct = 4281,
        [Description("Caustic Arrow Duration +%")]
        CausticArrowDurationPosPct = 4282,
        [Description("Double Strike Critical Strike Chance +%")]
        DoubleStrikeCriticalStrikeChancePosPct = 4283,
        [Description("Dual Strike Critical Strike Chance +%")]
        DualStrikeCriticalStrikeChancePosPct = 4284,
        [Description("Split Arrow Critical Strike Chance +%")]
        SplitArrowCriticalStrikeChancePosPct = 4285,
        [Description("Viper Strike Critical Strike Chance +%")]
        ViperStrikeCriticalStrikeChancePosPct = 4286,
        [Description("Flameblast Critical Strike Chance +%")]
        FlameblastCriticalStrikeChancePosPct = 4287,
        [Description("Flame Surge Critical Strike Chance +%")]
        FlameSurgeCriticalStrikeChancePosPct = 4288,
        [Description("Tornado Shot Critical Strike Chance +%")]
        TornadoShotCriticalStrikeChancePosPct = 4289,
        [Description("Lightning Strike Num Of Additional Projectiles")]
        LightningStrikeNumOfAdditionalProjectiles = 4290,
        [Description("Molten Strike Num Of Additional Projectiles")]
        MoltenStrikeNumOfAdditionalProjectiles = 4291,
        [Description("Spark Num Of Additional Projectiles")]
        SparkNumOfAdditionalProjectiles = 4292,
        [Description("Split Arrow Num Of Additional Projectiles")]
        SplitArrowNumOfAdditionalProjectiles = 4293,
        [Description("Barrage Num Of Additional Projectiles")]
        BarrageNumOfAdditionalProjectiles = 4294,
        [Description("Tornado Shot Num Of Secondary Projectiles")]
        TornadoShotNumOfSecondaryProjectiles = 4295,
        [Description("Magma Orb Num Of Additional Projectiles In Chain")]
        MagmaOrbNumOfAdditionalProjectilesInChain = 4296,
        [Description("Arc Num Of Additional Projectiles In Chain")]
        ArcNumOfAdditionalProjectilesInChain = 4297,
        [Description("Flame Totem Num Of Additional Projectiles")]
        FlameTotemNumOfAdditionalProjectiles = 4298,
        [Description("Burning Arrow Ignite Chance %")]
        BurningArrowIgniteChancePct = 4299,
        [Description("Burning Arrow Physical Damage % To Add As Fire Damage")]
        BurningArrowPhysicalDamagePctToAddAsFireDamage = 4300,
        [Description("Infernal Blow Physical Damage % To Add As Fire Damage")]
        InfernalBlowPhysicalDamagePctToAddAsFireDamage = 4301,
        [Description("Fire Trap Burning Damage +%")]
        FireTrapBurningDamagePosPct = 4302,
        [Description("Fireball Ignite Chance %")]
        FireballIgniteChancePct = 4303,
        [Description("Glacial Hammer Freeze Chance %")]
        GlacialHammerFreezeChancePct = 4304,
        [Description("Ice Nova Freeze Chance %")]
        IceNovaFreezeChancePct = 4305,
        [Description("Reave Attack Speed Per Reave Stack +%")]
        ReaveAttackSpeedPerReaveStackPosPct = 4306,
        [Description("Spectral Throw Projectile Deceleration +%")]
        SpectralThrowProjectileDecelerationPosPct = 4307,
        [Description("Flicker Strike Damage +% Per Frenzy Charge")]
        FlickerStrikeDamagePosPctPerFrenzyCharge = 4308,
        [Description("Puncture Maim On Hit % Chance")]
        PunctureMaimOnHitPctChance = 4309,
        [Description("Arc Shock Chance %")]
        ArcShockChancePct = 4310,
        [Description("Fire Nova Mine Num Of Additional Repeats")]
        FireNovaMineNumOfAdditionalRepeats = 4311,
        [Description("Firestorm Explosion Area Of Effect +%")]
        FirestormExplosionAreaOfEffectPosPct = 4312,
        [Description("Flame Surge Damage +% Vs Burning Enemies")]
        FlameSurgeDamagePosPctVsBurningEnemies = 4313,
        [Description("Ice Spear % Chance To Gain Power Charge On Critical Strike")]
        IceSpearPctChanceToGainPowerChargeOnCriticalStrike = 4314,
        [Description("Power Siphon % Chance To Gain Power Charge On Kill")]
        PowerSiphonPctChanceToGainPowerChargeOnKill = 4315,
        [Description("Searing Bond Totem Placement Speed +%")]
        SearingBondTotemPlacementSpeedPosPct = 4316,
        [Description("Sweep Knockback Chance %")]
        SweepKnockbackChancePct = 4317,
        [Description("Frenzy Damage +% Per Frenzy Charge")]
        FrenzyDamagePosPctPerFrenzyCharge = 4318,
        [Description("Frenzy % Chance To Gain Additional Frenzy Charge")]
        FrenzyPctChanceToGainAdditionalFrenzyCharge = 4319,
        [Description("Elemental Hit Chance To Freeze Shock Ignite %")]
        ElementalHitChanceToFreezeShockIgnitePct = 4320,
        [Description("Glacial Cascade Physical Damage % To Convert To Cold")]
        GlacialCascadePhysicalDamagePctToConvertToCold = 4321,
        [Description("Glacial Hammer Physical Damage % To Add As Cold Damage")]
        GlacialHammerPhysicalDamagePctToAddAsColdDamage = 4322,
        [Description("Ice Crash Physical Damage % To Add As Cold Damage")]
        IceCrashPhysicalDamagePctToAddAsColdDamage = 4323,
        [Description("Spectre Elemental Resistances %")]
        SpectreElementalResistancesPct = 4324,
        [Description("Zombie Elemental Resistances %")]
        ZombieElementalResistancesPct = 4325,
        [Description("Flame Golem Elemental Resistances %")]
        FlameGolemElementalResistancesPct = 4326,
        [Description("Chaos Golem Elemental Resistances %")]
        ChaosGolemElementalResistancesPct = 4327,
        [Description("Ice Golem Elemental Resistances %")]
        IceGolemElementalResistancesPct = 4328,
        [Description("Shock Nova Ring Damage +%")]
        ShockNovaRingDamagePosPct = 4329,
        [Description("Detonate Dead % Chance To Detonate Additional Corpse")]
        DetonateDeadPctChanceToDetonateAdditionalCorpse = 4330,
        [Description("Animate Weapon Chance To Create Additional Copy %")]
        AnimateWeaponChanceToCreateAdditionalCopyPct = 4331,
        [Description("Decoy Totem Life +%")]
        DecoyTotemLifePosPct = 4332,
        [Description("Devouring Totem Leech Per Second +%")]
        DevouringTotemLeechPerSecondPosPct = 4333,
        [Description("Rejuvenation Totem % Life Regeneration Added As Mana Regeneration")]
        RejuvenationTotemPctLifeRegenerationAddedAsManaRegeneration = 4334,
        [Description("Rejuvenation Totem Aura Effect +%")]
        RejuvenationTotemAuraEffectPosPct = 4335,
        [Description("Summon Skeletons Num Additional Warrior Skeletons")]
        SummonSkeletonsNumAdditionalWarriorSkeletons = 4336,
        [Description("Wild Strike Num Of Additional Projectiles In Chain")]
        WildStrikeNumOfAdditionalProjectilesInChain = 4337,
        [Description("Shockwave Totem Cast Speed +%")]
        ShockwaveTotemCastSpeedPosPct = 4338,
        [Description("Devouring Totem % Chance To Consume Additional Corpse")]
        DevouringTotemPctChanceToConsumeAdditionalCorpse = 4339,
        [Description("Incinerate Damage +% Per Stage")]
        IncinerateDamagePosPctPerStage = 4340,
        [Description("Siege Ballista Totem Placement Speed +%")]
        SiegeBallistaTotemPlacementSpeedPosPct = 4341,
        [Description("Virtual Curse Effect +%")]
        VirtualCurseEffectPosPct = 4342,
        [Description("Poachers Mark Curse Effect +%")]
        PoachersMarkCurseEffectPosPct = 4343,
        [Description("Projectile Weakness Curse Effect +%")]
        ProjectileWeaknessCurseEffectPosPct = 4344,
        [Description("Temporal Chains Curse Effect +%")]
        TemporalChainsCurseEffectPosPct = 4345,
        [Description("Assassins Mark Curse Effect +%")]
        AssassinsMarkCurseEffectPosPct = 4346,
        [Description("Conductivity Curse Effect +%")]
        ConductivityCurseEffectPosPct = 4347,
        [Description("Elemental Weakness Curse Effect +%")]
        ElementalWeaknessCurseEffectPosPct = 4348,
        [Description("Enfeeble Curse Effect +%")]
        EnfeebleCurseEffectPosPct = 4349,
        [Description("Flammability Curse Effect +%")]
        FlammabilityCurseEffectPosPct = 4350,
        [Description("Frostbite Curse Effect +%")]
        FrostbiteCurseEffectPosPct = 4351,
        [Description("Punishment Curse Effect +%")]
        PunishmentCurseEffectPosPct = 4352,
        [Description("Vulnerability Curse Effect +%")]
        VulnerabilityCurseEffectPosPct = 4353,
        [Description("Warlords Mark Curse Effect +%")]
        WarlordsMarkCurseEffectPosPct = 4354,
        [Description("Lightning Golem Grants Attack And Cast Speed +%")]
        LightningGolemGrantsAttackAndCastSpeedPosPct = 4355,
        [Description("Lightning Golem Grants Added Lightning Damage")]
        LightningGolemGrantsAddedLightningDamage = 4356,
        [Description("Arctic Armour Mana Reservation +%")]
        ArcticArmourManaReservationPosPct = 4357,
        [Description("Herald Of Ash Mana Reservation +%")]
        HeraldOfAshManaReservationPosPct = 4358,
        [Description("Herald Of Ice Mana Reservation +%")]
        HeraldOfIceManaReservationPosPct = 4359,
        [Description("Herald Of Thunder Mana Reservation +%")]
        HeraldOfThunderManaReservationPosPct = 4360,
        [Description("Clarity Mana Reservation +%")]
        ClarityManaReservationPosPct = 4361,
        [Description("Hatred Mana Reservation +%")]
        HatredManaReservationPosPct = 4362,
        [Description("Purity Of Ice Mana Reservation +%")]
        PurityOfIceManaReservationPosPct = 4363,
        [Description("Determination Mana Reservation +%")]
        DeterminationManaReservationPosPct = 4364,
        [Description("Discipline Mana Reservation +%")]
        DisciplineManaReservationPosPct = 4365,
        [Description("Purity Of Elements Mana Reservation +%")]
        PurityOfElementsManaReservationPosPct = 4366,
        [Description("Purity Of Fire Mana Reservation +%")]
        PurityOfFireManaReservationPosPct = 4367,
        [Description("Purity Of Lightning Mana Reservation +%")]
        PurityOfLightningManaReservationPosPct = 4368,
        [Description("Vitality Mana Reservation +%")]
        VitalityManaReservationPosPct = 4369,
        [Description("Wrath Mana Reservation +%")]
        WrathManaReservationPosPct = 4370,
        [Description("Grace Mana Reservation +%")]
        GraceManaReservationPosPct = 4371,
        [Description("Haste Mana Reservation +%")]
        HasteManaReservationPosPct = 4372,
        [Description("Immortal Call Duration +%")]
        ImmortalCallDurationPosPct = 4373,
        [Description("Bone Offering Duration +%")]
        BoneOfferingDurationPosPct = 4374,
        [Description("Flesh Offering Duration +%")]
        FleshOfferingDurationPosPct = 4375,
        [Description("Smoke Mine Duration +%")]
        SmokeMineDurationPosPct = 4376,
        [Description("Frost Wall Duration +%")]
        FrostWallDurationPosPct = 4377,
        [Description("Vigilant Strike Fortify Duration +%")]
        VigilantStrikeFortifyDurationPosPct = 4378,
        [Description("Poachers Mark Duration +%")]
        PoachersMarkDurationPosPct = 4379,
        [Description("Projectile Weakness Duration +%")]
        ProjectileWeaknessDurationPosPct = 4380,
        [Description("Temporal Chains Duration +%")]
        TemporalChainsDurationPosPct = 4381,
        [Description("Warlords Mark Duration +%")]
        WarlordsMarkDurationPosPct = 4382,
        [Description("Vulnerability Duration +%")]
        VulnerabilityDurationPosPct = 4383,
        [Description("Punishment Duration +%")]
        PunishmentDurationPosPct = 4384,
        [Description("Frostbite Duration +%")]
        FrostbiteDurationPosPct = 4385,
        [Description("Flammability Duration +%")]
        FlammabilityDurationPosPct = 4386,
        [Description("Enfeeble Duration +%")]
        EnfeebleDurationPosPct = 4387,
        [Description("Elemental Weakness Duration +%")]
        ElementalWeaknessDurationPosPct = 4388,
        [Description("Conductivity Duration +%")]
        ConductivityDurationPosPct = 4389,
        [Description("Assassins Mark Duration +%")]
        AssassinsMarkDurationPosPct = 4390,
        [Description("Rallying Cry Duration +%")]
        RallyingCryDurationPosPct = 4391,
        [Description("Abyssal Cry Duration +%")]
        AbyssalCryDurationPosPct = 4392,
        [Description("Contagion Duration +%")]
        ContagionDurationPosPct = 4393,
        [Description("Siphon Duration +%")]
        SiphonDurationPosPct = 4394,
        [Description("Wither Duration +%")]
        WitherDurationPosPct = 4395,
        [Description("Blade Vortex Duration +%")]
        BladeVortexDurationPosPct = 4396,
        [Description("Earthquake Duration +%")]
        EarthquakeDurationPosPct = 4397,
        [Description("Blight Duration +%")]
        BlightDurationPosPct = 4398,
        [Description("Blight Secondary Skill Effect Duration +%")]
        BlightSecondarySkillEffectDurationPosPct = 4399,
        [Description("Convocation Cooldown Speed +%")]
        ConvocationCooldownSpeedPosPct = 4400,
        [Description("Bear Trap Cooldown Speed +%")]
        BearTrapCooldownSpeedPosPct = 4401,
        [Description("Frost Wall Cooldown Speed +%")]
        FrostWallCooldownSpeedPosPct = 4402,
        [Description("Reckoning Cooldown Speed +%")]
        ReckoningCooldownSpeedPosPct = 4403,
        [Description("Flame Dash Cooldown Speed +%")]
        FlameDashCooldownSpeedPosPct = 4404,
        [Description("Desecrate Cooldown Speed +%")]
        DesecrateCooldownSpeedPosPct = 4405,
        [Description("Blink Arrow Cooldown Speed +%")]
        BlinkArrowCooldownSpeedPosPct = 4406,
        [Description("Mirror Arrow Cooldown Speed +%")]
        MirrorArrowCooldownSpeedPosPct = 4407,
        [Description("Riposte Cooldown Speed +%")]
        RiposteCooldownSpeedPosPct = 4408,
        [Description("Vengeance Cooldown Speed +%")]
        VengeanceCooldownSpeedPosPct = 4409,
        [Description("Enduring Cry Cooldown Speed +%")]
        EnduringCryCooldownSpeedPosPct = 4410,
        [Description("Frost Bomb Cooldown Speed +%")]
        FrostBombCooldownSpeedPosPct = 4411,
        [Description("Conversion Trap Cooldown Speed +%")]
        ConversionTrapCooldownSpeedPosPct = 4412,
        [Description("Ice Trap Cooldown Speed +%")]
        IceTrapCooldownSpeedPosPct = 4413,
        [Description("Siege Ballista Attack Speed +%")]
        SiegeBallistaAttackSpeedPosPct = 4414,
        [Description("Shockwave Slam Attack Speed +%")]
        ShockwaveSlamAttackSpeedPosPct = 4415,
        [Description("Mirror Arrow And Mirror Arrow Clone Attack Speed +%")]
        MirrorArrowAndMirrorArrowCloneAttackSpeedPosPct = 4416,
        [Description("Freeze Mine Radius +%")]
        FreezeMineRadiusPosPct = 4417,
        [Description("Shrapnel Shot Radius +%")]
        ShrapnelShotRadiusPosPct = 4418,
        [Description("Blast Rain Radius +%")]
        BlastRainRadiusPosPct = 4419,
        [Description("Contagion Radius +%")]
        ContagionRadiusPosPct = 4420,
        [Description("Wither Radius +%")]
        WitherRadiusPosPct = 4421,
        [Description("Blade Vortex Radius +%")]
        BladeVortexRadiusPosPct = 4422,
        [Description("Bladefall Radius +%")]
        BladefallRadiusPosPct = 4423,
        [Description("Ice Trap Radius +%")]
        IceTrapRadiusPosPct = 4424,
        [Description("Earthquake Radius +%")]
        EarthquakeRadiusPosPct = 4425,
        [Description("Frost Bomb Radius +%")]
        FrostBombRadiusPosPct = 4426,
        [Description("Storm Cloud Radius +%")]
        StormCloudRadiusPosPct = 4427,
        [Description("Blight Radius +%")]
        BlightRadiusPosPct = 4428,
        [Description("Shockwave Slam Radius +%")]
        ShockwaveSlamRadiusPosPct = 4429,
        [Description("Display Attack With Decree Of Ire When Hit %")]
        DisplayAttackWithDecreeOfIreWhenHitPct = 4430,
        [Description("Display Attack With Commandment Of Ire When Hit %")]
        DisplayAttackWithCommandmentOfIreWhenHitPct = 4431,
        [Description("Blink Arrow And Blink Arrow Clone Attack Speed +%")]
        BlinkArrowAndBlinkArrowCloneAttackSpeedPosPct = 4432,
        [Description("Whirling Blades Attack Speed +%")]
        WhirlingBladesAttackSpeedPosPct = 4433,
        [Description("Arctic Armour Buff Effect +%")]
        ArcticArmourBuffEffectPosPct = 4434,
        [Description("Immortal Call % Chance To Not Consume Endurance Charges")]
        ImmortalCallPctChanceToNotConsumeEnduranceCharges = 4435,
        [Description("Phase Run % Chance To Not Consume Frenzy Charges")]
        PhaseRunPctChanceToNotConsumeFrenzyCharges = 4436,
        [Description("Animate Guardian Elemental Resistances %")]
        AnimateGuardianElementalResistancesPct = 4437,
        [Description("Shrapnel Shot Physical Damage % To Add As Lightning Damage")]
        ShrapnelShotPhysicalDamagePctToAddAsLightningDamage = 4438,
        [Description("Bladefall Critical Strike Chance +%")]
        BladefallCriticalStrikeChancePosPct = 4439,
        [Description("Storm Cloud Critical Strike Chance +%")]
        StormCloudCriticalStrikeChancePosPct = 4440,
        [Description("Tempest Shield Num Of Additional Projectiles In Chain")]
        TempestShieldNumOfAdditionalProjectilesInChain = 4441,
        [Description("Map Labyrinth Secret1 Override")]
        MapLabyrinthSecret1Override = 4442,
        [Description("Map Labyrinth Secret2 Override")]
        MapLabyrinthSecret2Override = 4443,
        [Description("Melee Ancestor Totem Granted Attack Speed +% Final")]
        MeleeAncestorTotemGrantedAttackSpeedPosPctFinal = 4444,
        [Description("Cannot Be Stunned While At Max Endurance Charges")]
        CannotBeStunnedWhileAtMaxEnduranceCharges = 4445,
        [Description("Life Regenerate Rate Per Second % While Totem Active")]
        LifeRegenerateRatePerSecondPctWhileTotemActive = 4446,
        [Description("Gain Attack And Cast Speed +% For 4 Seconds If Taken Savage Hit")]
        GainAttackAndCastSpeedPosPctFor4SecondsIfTakenSavageHit = 4447,
        [Description("Berserker Damage +% Final")]
        BerserkerDamagePosPctFinal = 4448,
        [Description("Elemental Damage Taken +% While On Consecrated Ground")]
        ElementalDamageTakenPosPctWhileOnConsecratedGround = 4449,
        [Description("Critical Strike Chance +% Vs Enemies With Elemental Status Ailments")]
        CriticalStrikeChancePosPctVsEnemiesWithElementalStatusAilments = 4450,
        [Description("Scion Helmet Skill Maximum Totems +")]
        ScionHelmetSkillMaximumTotemsPos = 4451,
        [Description("% Chance To Gain Power Charge On Placing A Totem")]
        PctChanceToGainPowerChargeOnPlacingATotem = 4452,
        [Description("Attack And Cast Speed +% For You And Allies Affected By Your Auras")]
        AttackAndCastSpeedPosPctForYouAndAlliesAffectedByYourAuras = 4453,
        [Description("Gain Elemental Conflux For X Ms When You Kill A Rare Or Unique Enemy")]
        GainElementalConfluxForXMsWhenYouKillARareOrUniqueEnemy = 4454,
        [Description("Enemies Chaos Resistance % While Cursed")]
        EnemiesChaosResistancePctWhileCursed = 4455,
        [Description("Damage +% For 4 Seconds When You Kill A Cursed Enemy")]
        DamagePosPctFor4SecondsWhenYouKillACursedEnemy = 4456,
        [Description("Physical Damage Reduction And Minion Physical Damage Reduction %")]
        PhysicalDamageReductionAndMinionPhysicalDamageReductionPct = 4457,
        [Description("Offering Spells Effect +%")]
        OfferingSpellsEffectPosPct = 4458,
        [Description("Damage +% For You And Allies Affected By Your Auras")]
        DamagePosPctForYouAndAlliesAffectedByYourAuras = 4459,
        [Description("You And Minion Attack And Cast Speed +% For 4 Seconds When Corpse Destroyed")]
        YouAndMinionAttackAndCastSpeedPosPctFor4SecondsWhenCorpseDestroyed = 4460,
        [Description("% Chance To Gain Power Charge On Hit Against Enemies On Full Life")]
        PctChanceToGainPowerChargeOnHitAgainstEnemiesOnFullLife = 4461,
        [Description("Cause Maim On Critical Strike Attack")]
        CauseMaimOnCriticalStrikeAttack = 4462,
        [Description("% Chance To Create Smoke Cloud On Mine Or Trap Creation")]
        PctChanceToCreateSmokeCloudOnMineOrTrapCreation = 4463,
        [Description("Damage +% For Each Trap And Mine Active")]
        DamagePosPctForEachTrapAndMineActive = 4464,
        [Description("Evasion Rating While Es Full +% Final")]
        EvasionRatingWhileEsFullPosPctFinal = 4465,
        [Description("Damage +% While Es Not Full")]
        DamagePosPctWhileEsNotFull = 4466,
        [Description("Mana Regeneration +% For 4 Seconds On Movement Skill Use")]
        ManaRegenerationPosPctFor4SecondsOnMovementSkillUse = 4467,
        [Description("Gain Onslaught While Frenzy Charges Full")]
        GainOnslaughtWhileFrenzyChargesFull = 4468,
        [Description("Projectile Damage +% Max As Distance Travelled Increases")]
        ProjectileDamagePosPctMaxAsDistanceTravelledIncreases = 4469,
        [Description("Damage +% During Flask Effect")]
        DamagePosPctDuringFlaskEffect = 4470,
        [Description("Avoid Freeze Shock Ignite Bleed % During Flask Effect")]
        AvoidFreezeShockIgniteBleedPctDuringFlaskEffect = 4471,
        [Description("Elemental Damage Taken +% During Flask Effect")]
        ElementalDamageTakenPosPctDuringFlaskEffect = 4472,
        [Description("Damage +% For 4 Seconds When You Kill A Bleeding Enemy")]
        DamagePosPctFor4SecondsWhenYouKillABleedingEnemy = 4473,
        [Description("Damage +% To You And Nearby Allies While You Have Fortify")]
        DamagePosPctToYouAndNearbyAlliesWhileYouHaveFortify = 4474,
        [Description("Damage Taken +% From Taunted Enemies")]
        DamageTakenPosPctFromTauntedEnemies = 4475,
        [Description("Attack And Cast Speed +% While Leeching")]
        AttackAndCastSpeedPosPctWhileLeeching = 4476,
        [Description("Base Avoid Bleed %")]
        BaseAvoidBleedPct = 4477,
        [Description("Avoid Bleed %")]
        AvoidBleedPct = 4478,
        [Description("Virtual Phase Through Objects")]
        VirtualPhaseThroughObjects = 4479,
        [Description("Virtual Has Onslaught")]
        VirtualHasOnslaught = 4480,
        [Description("Shield Charge Damage Per Target Hit +%")]
        ShieldChargeDamagePerTargetHitPosPct = 4481,
        [Description("Number Of Mines To Place")]
        NumberOfMinesToPlace = 4482,
        [Description("Local Flask Life Gain On Skill Use % Mana Cost")]
        LocalFlaskLifeGainOnSkillUsePctManaCost = 4483,
        [Description("Life Gain On Skill Use Percent Mana Cost")]
        LifeGainOnSkillUsePercentManaCost = 4484,
        [Description("Traps And Mines % Chance To Poison")]
        TrapsAndMinesPctChanceToPoison = 4485,
        [Description("Damage +% Of Each Type That You Have An Active Golem Of")]
        DamagePosPctOfEachTypeThatYouHaveAnActiveGolemOf = 4486,
        [Description("Elemental Golem Immunity To Elemental Damage")]
        ElementalGolemImmunityToElementalDamage = 4487,
        [Description("Elemental Golem Granted Buff Effect +%")]
        ElementalGolemGrantedBuffEffectPosPct = 4488,
        [Description("Current Number Of Fire Golems")]
        CurrentNumberOfFireGolems = 4489,
        [Description("Current Number Of Ice Golems")]
        CurrentNumberOfIceGolems = 4490,
        [Description("Current Number Of Lightning Golems")]
        CurrentNumberOfLightningGolems = 4491,
        [Description("Current Number Of Stone Golems")]
        CurrentNumberOfStoneGolems = 4492,
        [Description("Current Number Of Chaos Golems")]
        CurrentNumberOfChaosGolems = 4493,
        [Description("Base Cold Immunity")]
        BaseColdImmunity = 4494,
        [Description("Base Lightning Immunity")]
        BaseLightningImmunity = 4495,
        [Description("Gain Elemental Penetration For 4 Seconds On Mine Detonation")]
        GainElementalPenetrationFor4SecondsOnMineDetonation = 4496,
        [Description("Display Can Take Character Start Point")]
        DisplayCanTakeCharacterStartPoint = 4497,
        [Description("Fire Damage Immunity")]
        FireDamageImmunity = 4498,
        [Description("Cold Damage Immunity")]
        ColdDamageImmunity = 4499,
        [Description("Lightning Damage Immunity")]
        LightningDamageImmunity = 4500,
        [Description("Chaos Damage Immunity")]
        ChaosDamageImmunity = 4501,
        [Description("Elemental Damage Immunity")]
        ElementalDamageImmunity = 4502,
        [Description("Global Total Minimum Added Lightning Damage")]
        GlobalTotalMinimumAddedLightningDamage = 4503,
        [Description("Global Total Maximum Added Lightning Damage")]
        GlobalTotalMaximumAddedLightningDamage = 4504,
        [Description("Have Killed Recently")]
        HaveKilledRecently = 4505,
        [Description("Track Have Killed Recently")]
        TrackHaveKilledRecently = 4506,
        [Description("Number Of Times Have Been Hit Recently")]
        NumberOfTimesHaveBeenHitRecently = 4507,
        [Description("Track Have Been Hit Recently")]
        TrackHaveBeenHitRecently = 4508,
        [Description("Have Crit Recently")]
        HaveCritRecently = 4509,
        [Description("Track Have Crit Recently")]
        TrackHaveCritRecently = 4510,
        [Description("Base Body Armour Physical Damage Reduction Rating")]
        BaseBodyArmourPhysicalDamageReductionRating = 4511,
        [Description("Chance To Grant Power Charge To Nearby Allies On Kill %")]
        ChanceToGrantPowerChargeToNearbyAlliesOnKillPct = 4512,
        [Description("Chance To Grant Frenzy Charge To Nearby Allies On Hit %")]
        ChanceToGrantFrenzyChargeToNearbyAlliesOnHitPct = 4513,
        [Description("Blood Rage Grants Additional Attack Speed +%")]
        BloodRageGrantsAdditionalAttackSpeedPosPct = 4514,
        [Description("Blood Rage Grants Additional % Chance To Gain Frenzy On Kill")]
        BloodRageGrantsAdditionalPctChanceToGainFrenzyOnKill = 4515,
        [Description("Play Tempestuous Steel Sounds")]
        PlayTempestuousSteelSounds = 4516,
        [Description("From Totem Aura Damage +% Final")]
        FromTotemAuraDamagePosPctFinal = 4517,
        [Description("Explode Enemies For 25% Life As Chaos On Kill Chance %")]
        ExplodeEnemiesFor25PctLifeAsChaosOnKillChancePct = 4518,
        [Description("Explode Cursed Enemies For 25% Life As Chaos On Kill Chance %")]
        ExplodeCursedEnemiesFor25PctLifeAsChaosOnKillChancePct = 4519,
        [Description("Base Minion Duration +%")]
        BaseMinionDurationPosPct = 4520,
        [Description("Skill Specific Minion Duration +% Final")]
        SkillSpecificMinionDurationPosPctFinal = 4521,
        [Description("Base Chaos Golem Granted Buff Effect +%")]
        BaseChaosGolemGrantedBuffEffectPosPct = 4522,
        [Description("Base Stone Golem Granted Buff Effect +%")]
        BaseStoneGolemGrantedBuffEffectPosPct = 4523,
        [Description("Base Fire Golem Granted Buff Effect +%")]
        BaseFireGolemGrantedBuffEffectPosPct = 4524,
        [Description("Base Ice Golem Granted Buff Effect +%")]
        BaseIceGolemGrantedBuffEffectPosPct = 4525,
        [Description("Base Lightning Golem Granted Buff Effect +%")]
        BaseLightningGolemGrantedBuffEffectPosPct = 4526,
        [Description("Stone Golem Elemental Resistances %")]
        StoneGolemElementalResistancesPct = 4527,
        [Description("Dominating Blow Minion Damage +%")]
        DominatingBlowMinionDamagePosPct = 4528,
        [Description("Dominating Blow Skill Attack Damage +%")]
        DominatingBlowSkillAttackDamagePosPct = 4529,
        [Description("Lightning Golem Elemental Resistances %")]
        LightningGolemElementalResistancesPct = 4530,
        [Description("Lightning Golem Damage +%")]
        LightningGolemDamagePosPct = 4531,
        [Description("Is Hindered")]
        IsHindered = 4532,
        [Description("Damage +% Vs Hindered Enemies")]
        DamagePosPctVsHinderedEnemies = 4533,
        [Description("Blast Rain Number Of Blasts")]
        BlastRainNumberOfBlasts = 4534,
        [Description("Local Display Socketed Curse Gems Have Mana Reservation +%")]
        LocalDisplaySocketedCurseGemsHaveManaReservationPosPct = 4535,
        [Description("Bone Offering Block Chance +%")]
        BoneOfferingBlockChancePosPct = 4536,
        [Description("Map Number Of Explicit Mods")]
        MapNumberOfExplicitMods = 4537,
        [Description("Curse Orb Additional Height")]
        CurseOrbAdditionalHeight = 4538,
        [Description("Curse Orb Additional Radius")]
        CurseOrbAdditionalRadius = 4539,
        [Description("Phase Run Skill Effect Duration +%")]
        PhaseRunSkillEffectDurationPosPct = 4540,
        [Description("Lightning Tendrils Critical Strike Chance +%")]
        LightningTendrilsCriticalStrikeChancePosPct = 4541,
        [Description("Searing Totem Elemental Resistance +%")]
        SearingTotemElementalResistancePosPct = 4542,
        [Description("Flesh Offering Attack Speed +%")]
        FleshOfferingAttackSpeedPosPct = 4543,
        [Description("Smoke Mine Base Movement Velocity +%")]
        SmokeMineBaseMovementVelocityPosPct = 4544,
        [Description("Convocation Buff Effect +%")]
        ConvocationBuffEffectPosPct = 4545,
        [Description("Molten Shell Buff Effect +%")]
        MoltenShellBuffEffectPosPct = 4546,
        [Description("Enduring Cry Buff Effect +%")]
        EnduringCryBuffEffectPosPct = 4547,
        [Description("Righteous Fire Spell Damage +%")]
        RighteousFireSpellDamagePosPct = 4548,
        [Description("Rallying Cry Buff Effect +%")]
        RallyingCryBuffEffectPosPct = 4549,
        [Description("Attack Trigger When Critically Hit %")]
        AttackTriggerWhenCriticallyHitPct = 4550,
        [Description("Cast When Hit %")]
        CastWhenHitPct = 4551,
        [Description("Attack Trigger When Hit %")]
        AttackTriggerWhenHitPct = 4552,
        [Description("Attack Trigger On Kill %")]
        AttackTriggerOnKillPct = 4553,
        [Description("Decrement Parent Counter On Death")]
        DecrementParentCounterOnDeath = 4554,
        [Description("Minions Explode On Death For % Max Life At End Of Duration")]
        MinionsExplodeOnDeathForPctMaxLifeAtEndOfDuration = 4555,
        [Description("Explode On Death For % Max Life At End Of Duration")]
        ExplodeOnDeathForPctMaxLifeAtEndOfDuration = 4556,
        [Description("Melee Ancestor Totem Damage +%")]
        MeleeAncestorTotemDamagePosPct = 4557,
        [Description("Melee Ancestor Totem Placement Speed +%")]
        MeleeAncestorTotemPlacementSpeedPosPct = 4558,
        [Description("Melee Ancestor Totem Elemental Resistance %")]
        MeleeAncestorTotemElementalResistancePct = 4559,
        [Description("Blast Rain % Chance For Additional Blast")]
        BlastRainPctChanceForAdditionalBlast = 4560,
        [Description("Perandus Chest Revive Targeted Monster")]
        PerandusChestReviveTargetedMonster = 4561,
        [Description("Current Difficulty")]
        CurrentDifficulty = 4562,
        [Description("Base Fire Damage % Of Maximum Life Plus Maximum Es Taken Per Minute In Cruel")]
        BaseFireDamagePctOfMaximumLifePlusMaximumESTakenPerMinuteInCruel = 4563,
        [Description("Base Fire Damage % Of Maximum Life Plus Maximum Es Taken Per Minute In Merciless")]
        BaseFireDamagePctOfMaximumLifePlusMaximumESTakenPerMinuteInMerciless = 4564,
        [Description("Kinetic Blast % Chance For Additional Blast")]
        KineticBlastPctChanceForAdditionalBlast = 4565,
        [Description("Share Charges With Party Members In Aura")]
        ShareChargesWithPartyMembersInAura = 4566,
        [Description("Guardian Nearby Allies Share Charges")]
        GuardianNearbyAlliesShareCharges = 4567,
        [Description("Bleed Duration +%")]
        BleedDurationPosPct = 4568,
        [Description("Summoned Monsters Are Parented To My Parent")]
        SummonedMonstersAreParentedToMyParent = 4569,
        [Description("Monster Grants No Experience After X Revives")]
        MonsterGrantsNoExperienceAfterXRevives = 4570,
        [Description("Consecrate Ground On Shatter % Chance For 3 Seconds")]
        ConsecrateGroundOnShatterPctChanceFor3Seconds = 4571,
        [Description("Summoned Monsters Decrement Parent Counter")]
        SummonedMonstersDecrementParentCounter = 4572,
        [Description("Skill Buff Effect +%")]
        SkillBuffEffectPosPct = 4573,
        [Description("Glows In Area With Unique Fish")]
        GlowsInAreaWithUniqueFish = 4574,
        [Description("Local Display Summon Raging Spirit On Kill %")]
        LocalDisplaySummonRagingSpiritOnKillPct = 4575,
        [Description("Attacks Num Of Additional Chains")]
        AttacksNumOfAdditionalChains = 4576,
        [Description("Monster Do Not Give Soul To Soul Eater")]
        MonsterDoNotGiveSoulToSoulEater = 4577,
        [Description("Monster Grants No Flask Charges")]
        MonsterGrantsNoFlaskCharges = 4578,
        [Description("Used Teleports")]
        UsedTeleports = 4579,
        [Description("Explosive Arrow Attack Speed +%")]
        ExplosiveArrowAttackSpeedPosPct = 4580,
        [Description("Slam Ancestor Totem Grant Owner Melee Damage +% Final")]
        SlamAncestorTotemGrantOwnerMeleeDamagePosPctFinal = 4581,
        [Description("Slash Ancestor Totem Grant Owner Physical Damage Added As Fire +%")]
        SlashAncestorTotemGrantOwnerPhysicalDamageAddedAsFirePosPct = 4582,
        [Description("Slam Ancestor Totem Granted Melee Damage +% Final")]
        SlamAncestorTotemGrantedMeleeDamagePosPctFinal = 4583,
        [Description("Perandus Chest Spawned Bosses")]
        PerandusChestSpawnedBosses = 4584,
        [Description("Lightning Damage +% Per 10 Intelligence")]
        LightningDamagePosPctPer10Intelligence = 4585,
        [Description("Shield Charge Range +%")]
        ShieldChargeRangePosPct = 4586,
        [Description("Local Maim On Hit")]
        LocalMaimOnHit = 4587,
        [Description("Main Hand Maim On Hit")]
        MainHandMaimOnHit = 4588,
        [Description("Off Hand Maim On Hit")]
        OffHandMaimOnHit = 4589,
        [Description("Warcries Cost No Mana")]
        WarcriesCostNoMana = 4590,
        [Description("Is On Ground Maelstrom")]
        IsOnGroundMaelstrom = 4591,
        [Description("Gain A Power Charge When You Or Your Totems Kill % Chance")]
        GainAPowerChargeWhenYouOrYourTotemsKillPctChance = 4592,
        [Description("Give Parent Power Charge On Kill % Chance")]
        GiveParentPowerChargeOnKillPctChance = 4593,
        [Description("Buff Visuals Show While Hidden Override")]
        BuffVisualsShowWhileHiddenOverride = 4594,
        [Description("Always Pierce")]
        AlwaysPierce = 4595,
        [Description("Always Crit Shocked Enemies")]
        AlwaysCritShockedEnemies = 4596,
        [Description("Cannot Crit Non Shocked Enemies")]
        CannotCritNonShockedEnemies = 4597,
        [Description("Map Prophecy")]
        MapProphecy = 4598,
        [Description("Frost Bolt Damage +%")]
        FrostBoltDamagePosPct = 4599,
        [Description("Frost Bolt Nova Damage +%")]
        FrostBoltNovaDamagePosPct = 4600,
        [Description("Double Slash Damage +%")]
        DoubleSlashDamagePosPct = 4601,
        [Description("Charged Attack Damage +%")]
        ChargedAttackDamagePosPct = 4602,
        [Description("Slam Ancestor Totem Damage +%")]
        SlamAncestorTotemDamagePosPct = 4603,
        [Description("Slash Ancestor Totem Damage +%")]
        SlashAncestorTotemDamagePosPct = 4604,
        [Description("Slash Ancestor Totem Radius +%")]
        SlashAncestorTotemRadiusPosPct = 4605,
        [Description("Slam Ancestor Totem Radius +%")]
        SlamAncestorTotemRadiusPosPct = 4606,
        [Description("Frost Bolt Nova Radius +%")]
        FrostBoltNovaRadiusPosPct = 4607,
        [Description("Double Slash Critical Strike Chance +%")]
        DoubleSlashCriticalStrikeChancePosPct = 4608,
        [Description("Charged Attack Radius +%")]
        ChargedAttackRadiusPosPct = 4609,
        [Description("Double Slash Radius +%")]
        DoubleSlashRadiusPosPct = 4610,
        [Description("Charged Attack Damage Per Stack +% Final")]
        ChargedAttackDamagePerStackPosPctFinal = 4611,
        [Description("% Of Life And Energy Shield To Take As Damage On Using A Movement Skill")]
        PctOfLifeAndEnergyShieldToTakeAsDamageOnUsingAMovementSkill = 4612,
        [Description("Remove % Of Targets Current Flask Charges On Hit")]
        RemovePctOfTargetsCurrentFlaskChargesOnHit = 4613,
        [Description("Virtual Reduce Enemy Cold Resistance With Weapons %")]
        VirtualReduceEnemyColdResistanceWithWeaponsPct = 4614,
        [Description("Virtual Reduce Enemy Fire Resistance With Weapons %")]
        VirtualReduceEnemyFireResistanceWithWeaponsPct = 4615,
        [Description("Virtual Reduce Enemy Lightning Resistance With Weapons %")]
        VirtualReduceEnemyLightningResistanceWithWeaponsPct = 4616,
        [Description("Minions % Chance To Blind On Hit")]
        MinionsPctChanceToBlindOnHit = 4617,
        [Description("Minions Cannot Be Blinded")]
        MinionsCannotBeBlinded = 4618,
        [Description("Display Socketed Minion Gems Supported By Level X Life Leech")]
        DisplaySocketedMinionGemsSupportedByLevelXLifeLeech = 4619,
        [Description("Magic Items Drop Identified")]
        MagicItemsDropIdentified = 4620,
        [Description("Number Of Stackable Unique Jewels")]
        NumberOfStackableUniqueJewels = 4621,
        [Description("X Mana Per Stackable Unique Jewel")]
        XManaPerStackableUniqueJewel = 4622,
        [Description("X Armour Per Stackable Unique Jewel")]
        XArmourPerStackableUniqueJewel = 4623,
        [Description("Elemental Damage +% Per Stackable Unique Jewel")]
        ElementalDamagePosPctPerStackableUniqueJewel = 4624,
        [Description("Base Fire Damage % Of Maximum Life Plus Maximum Es Taken Per Minute In Normal")]
        BaseFireDamagePctOfMaximumLifePlusMaximumESTakenPerMinuteInNormal = 4625,
        [Description("Projectile Uses Contact Position")]
        ProjectileUsesContactPosition = 4626,
        [Description("Skeletal Chains Aoe % Health Dealt As Chaos Damage")]
        SkeletalChainsAoePctHealthDealtAsChaosDamage = 4627,
        [Description("Virtual Number Of Inca Minions Allowed")]
        VirtualNumberOfIncaMinionsAllowed = 4628,
        [Description("Virtual Number Of Insects Allowed")]
        VirtualNumberOfInsectsAllowed = 4629,
        [Description("Virtual Number Of Taniwha Tails Allowed")]
        VirtualNumberOfTaniwhaTailsAllowed = 4630,
        [Description("Virtual Number Of Wolves Allowed")]
        VirtualNumberOfWolvesAllowed = 4631,
        [Description("You Cannot Have Non Golem Minions")]
        YouCannotHaveNonGolemMinions = 4632,
        [Description("Lightning Damage % Taken From Mana Before Life")]
        LightningDamagePctTakenFromManaBeforeLife = 4633,
        [Description("Recover % Maximum Mana When Enemy Shocked")]
        RecoverPctMaximumManaWhenEnemyShocked = 4634,
        [Description("Ground Caustic Art Variation")]
        GroundCausticArtVariation = 4635,
        [Description("Global Life Leech From Physical Attack Damage Per Red Socket On Item Permyriad")]
        GlobalLifeLeechFromPhysicalAttackDamagePerRedSocketOnItemPermyriad = 4636,
        [Description("Spell Dodge Chance +% If You Have Taken Attack Damage Recently")]
        SpellDodgeChancePosPctIfYouHaveTakenAttackDamageRecently = 4637,
        [Description("Dodge Chance +% If You Have Taken Spell Damage Recently")]
        DodgeChancePosPctIfYouHaveTakenSpellDamageRecently = 4638,
        [Description("Quantity Of Items Dropped By Maimed Enemies +%")]
        QuantityOfItemsDroppedByMaimedEnemiesPosPct = 4639,
        [Description("Rarity Of Items Dropped By Maimed Enemies +%")]
        RarityOfItemsDroppedByMaimedEnemiesPosPct = 4640,
        [Description("Damage Taken +% If You Have Taken A Savage Hit Recently")]
        DamageTakenPosPctIfYouHaveTakenASavageHitRecently = 4641,
        [Description("Is Maimed")]
        IsMaimed = 4642,
        [Description("Track Have Been Savage Hit Recently")]
        TrackHaveBeenSavageHitRecently = 4643,
        [Description("Have Been Savage Hit Recently")]
        HaveBeenSavageHitRecently = 4644,
        [Description("Track Have Taken Attack Damage Recently")]
        TrackHaveTakenAttackDamageRecently = 4645,
        [Description("Have Taken Attack Damage Recently")]
        HaveTakenAttackDamageRecently = 4646,
        [Description("Track Have Taken Spell Damage Recently")]
        TrackHaveTakenSpellDamageRecently = 4647,
        [Description("Have Taken Spell Damage Recently")]
        HaveTakenSpellDamageRecently = 4648,
        [Description("Stun Duration On Self +%")]
        StunDurationOnSelfPosPct = 4649,
        [Description("Melee Damage +% Per Endurance Charge")]
        MeleeDamagePosPctPerEnduranceCharge = 4650,
        [Description("Totems Resist All Elements +% Per Active Totem")]
        TotemsResistAllElementsPosPctPerActiveTotem = 4651,
        [Description("Summon Your Maximum Number Of Totems In Formation")]
        SummonYourMaximumNumberOfTotemsInFormation = 4652,
        [Description("Gain Life Regeneration % Per Second For 1 Second If Taken Savage Hit")]
        GainLifeRegenerationPctPerSecondFor1SecondIfTakenSavageHit = 4653,
        [Description("Maximum Life % To Add As Maximum Energy Shield")]
        MaximumLifePctToAddAsMaximumEnergyShield = 4654,
        [Description("Total Base Maximum Life")]
        TotalBaseMaximumLife = 4655,
        [Description("Combined Life +%")]
        CombinedLifePosPct = 4656,
        [Description("Combined Life +% Final")]
        CombinedLifePosPctFinal = 4657,
        [Description("Cannot Be Shocked While At Maximum Endurance Charges")]
        CannotBeShockedWhileAtMaximumEnduranceCharges = 4658,
        [Description("Movement Speed +% If Used A Warcry Recently")]
        MovementSpeedPosPctIfUsedAWarcryRecently = 4659,
        [Description("Mana Leech From Attack Damage Permyriad Vs Poisoned Enemies")]
        ManaLeechFromAttackDamagePermyriadVsPoisonedEnemies = 4660,
        [Description("Have Used A Warcry Recently")]
        HaveUsedAWarcryRecently = 4661,
        [Description("Track Have Used A Warcry Recently")]
        TrackHaveUsedAWarcryRecently = 4662,
        [Description("Totems Spells Cast Speed +% Per Active Totem")]
        TotemsSpellsCastSpeedPosPctPerActiveTotem = 4663,
        [Description("Movement Skills Mana Cost +%")]
        MovementSkillsManaCostPosPct = 4664,
        [Description("Global Critical Strike Mulitplier + Per Green Socket On Item")]
        GlobalCriticalStrikeMulitplierPosPerGreenSocketOnItem = 4665,
        [Description("Additional Block Chance % When In Off Hand")]
        AdditionalBlockChancePctWhenInOffHand = 4666,
        [Description("Critical Strike Chance +% When In Main Hand")]
        CriticalStrikeChancePosPctWhenInMainHand = 4667,
        [Description("Spirit Offering Duration +%")]
        SpiritOfferingDurationPosPct = 4668,
        [Description("Spirit Offering Physical Damage % To Add As Chaos")]
        SpiritOfferingPhysicalDamagePctToAddAsChaos = 4669,
        [Description("Base Fire Damage % Of Maximum Life Taken Per Minute In Normal")]
        BaseFireDamagePctOfMaximumLifeTakenPerMinuteInNormal = 4670,
        [Description("Base Fire Damage % Of Maximum Es Taken Per Minute In Normal")]
        BaseFireDamagePctOfMaximumEsTakenPerMinuteInNormal = 4671,
        [Description("Base Fire Damage % Of Maximum Life Taken Per Minute In Cruel")]
        BaseFireDamagePctOfMaximumLifeTakenPerMinuteInCruel = 4672,
        [Description("Base Fire Damage % Of Maximum Es Taken Per Minute In Cruel")]
        BaseFireDamagePctOfMaximumEsTakenPerMinuteInCruel = 4673,
        [Description("Base Fire Damage % Of Maximum Life Taken Per Minute In Merciless")]
        BaseFireDamagePctOfMaximumLifeTakenPerMinuteInMerciless = 4674,
        [Description("Base Fire Damage % Of Maximum Es Taken Per Minute In Merciless")]
        BaseFireDamagePctOfMaximumEsTakenPerMinuteInMerciless = 4675,
        [Description("% Of Life To Deal As Damage")]
        PctOfLifeToDealAsDamage = 4676,
        [Description("% Of Es To Deal As Damage")]
        PctOfEsToDealAsDamage = 4677,
        [Description("% Of Life To Take As Damage On Using A Movement Skill")]
        PctOfLifeToTakeAsDamageOnUsingAMovementSkill = 4678,
        [Description("% Of Energy Shield To Take As Damage On Using A Movement Skill")]
        PctOfEnergyShieldToTakeAsDamageOnUsingAMovementSkill = 4679,
        [Description("% Of Life To Deal As Damage On Using A Movement Skill")]
        PctOfLifeToDealAsDamageOnUsingAMovementSkill = 4680,
        [Description("% Of Energy Shield To Deal As Damage On Using A Movement Skill")]
        PctOfEnergyShieldToDealAsDamageOnUsingAMovementSkill = 4681,
        [Description("Local Unique Overflowing Chalice Flask Cannot Gain Flask Charges During Flask Effect")]
        LocalUniqueOverflowingChaliceFlaskCannotGainFlaskChargesDuringFlaskEffect = 4682,
        [Description("Using Flask Overflowing Chalice")]
        UsingFlaskOverflowingChalice = 4683,
        [Description("Cannot Be Chained From")]
        CannotBeChainedFrom = 4684,
        [Description("Damage Taken +% If Not Hit Recently Final")]
        DamageTakenPosPctIfNotHitRecentlyFinal = 4685,
        [Description("Evasion +% If Hit Recently")]
        EvasionPosPctIfHitRecently = 4686,
        [Description("Cast Socketed Spells On X Mana Spent")]
        CastSocketedSpellsOnXManaSpent = 4687,
        [Description("Cast Socketed Spells On Mana Spent % Chance")]
        CastSocketedSpellsOnManaSpentPctChance = 4688,
        [Description("Block Chance % Vs Taunted Enemies")]
        BlockChancePctVsTauntedEnemies = 4689,
        [Description("Minion Cold Damage Resistance %")]
        MinionColdDamageResistancePct = 4690,
        [Description("Minion Physical Damage % To Add As Cold")]
        MinionPhysicalDamagePctToAddAsCold = 4691,
        [Description("Armour And Evasion Rating +% If Killed A Taunted Enemy Recently")]
        ArmourAndEvasionRatingPosPctIfKilledATauntedEnemyRecently = 4692,
        [Description("Have Killed A Taunted Enemy Recently")]
        HaveKilledATauntedEnemyRecently = 4693,
        [Description("Map Owner Master Exp Favour +%")]
        MapOwnerMasterExpFavourPosPct = 4694,
        [Description("Support Cast On Mana Spent")]
        SupportCastOnManaSpent = 4695,
        [Description("Num Of Additional Chains At Max Frenzy Charges")]
        NumOfAdditionalChainsAtMaxFrenzyCharges = 4696,
        [Description("Critical Strikes Do Not Always Freeze")]
        CriticalStrikesDoNotAlwaysFreeze = 4697,
        [Description("Damage +% For Each Level The Enemy Is Higher Than You")]
        DamagePosPctForEachLevelTheEnemyIsHigherThanYou = 4698,
        [Description("Local Unique Flask Charges Gained +% During Flask Effect")]
        LocalUniqueFlaskChargesGainedPosPctDuringFlaskEffect = 4699,
        [Description("Gain Phasing For 4 Seconds On Begin Es Recharge")]
        GainPhasingFor4SecondsOnBeginEsRecharge = 4700,
        [Description("Chance To Dodge Attacks % While Phasing")]
        ChanceToDodgeAttacksPctWhilePhasing = 4701,
        [Description("Item Found Rarity +% While Phasing")]
        ItemFoundRarityPosPctWhilePhasing = 4702,
        [Description("Hexproof")]
        Hexproof = 4703,
        [Description("Map Monsters Are Hexproof")]
        MapMonstersAreHexproof = 4704,
        [Description("Ignore Hexproof")]
        IgnoreHexproof = 4705,
        [Description("Totems Attack Speed +% Per Active Totem")]
        TotemsAttackSpeedPosPctPerActiveTotem = 4706,
        [Description("Attacks Num Of Additional Chains When In Main Hand")]
        AttacksNumOfAdditionalChainsWhenInMainHand = 4707,
        [Description("Attacks Number Of Additional Projectiles")]
        AttacksNumberOfAdditionalProjectiles = 4708,
        [Description("Attacks Number Of Additional Projectiles When In Off Hand")]
        AttacksNumberOfAdditionalProjectilesWhenInOffHand = 4709,
        [Description("Counter Attacks Minimum Added Physical Damage")]
        CounterAttacksMinimumAddedPhysicalDamage = 4710,
        [Description("Counter Attacks Maximum Added Physical Damage")]
        CounterAttacksMaximumAddedPhysicalDamage = 4711,
        [Description("Golem Damage +% Per Active Golem Type")]
        GolemDamagePosPctPerActiveGolemType = 4712,
        [Description("Life +% With No Corrupted Equipped Items")]
        LifePosPctWithNoCorruptedEquippedItems = 4713,
        [Description("Life Regeneration Per Minute With No Corrupted Equipped Items")]
        LifeRegenerationPerMinuteWithNoCorruptedEquippedItems = 4714,
        [Description("Energy Shield Recharge Rate Per Minute With All Corrupted Equipped Items")]
        EnergyShieldRechargeRatePerMinuteWithAllCorruptedEquippedItems = 4715,
        [Description("Local Display Nearby Enemies Take X Chaos Damage Per Minute")]
        LocalDisplayNearbyEnemiesTakeXChaosDamagePerMinute = 4716,
        [Description("Number Of Equipped Items")]
        NumberOfEquippedItems = 4717,
        [Description("Virtual Mana Leech From Any Damage Permyriad")]
        VirtualManaLeechFromAnyDamagePermyriad = 4718,
        [Description("Virtual Current Number Of Golem Types")]
        VirtualCurrentNumberOfGolemTypes = 4719,
        [Description("Local Display Socketed Skills Summon Your Maximum Number Of Totems In Formation")]
        LocalDisplaySocketedSkillsSummonYourMaximumNumberOfTotemsInFormation = 4720,
        [Description("Energy Shield Regeneration Rate Per Minute % While On Low Life")]
        EnergyShieldRegenerationRatePerMinutePctWhileOnLowLife = 4721,
        [Description("Counter Attacks Minimum Added Cold Damage")]
        CounterAttacksMinimumAddedColdDamage = 4722,
        [Description("Counter Attacks Maximum Added Cold Damage")]
        CounterAttacksMaximumAddedColdDamage = 4723,
        [Description("Movement Speed +% If Pierced Recently")]
        MovementSpeedPosPctIfPiercedRecently = 4724,
        [Description("Have Pierced Recently")]
        HavePiercedRecently = 4725,
        [Description("Track Have Pierced Recently")]
        TrackHavePiercedRecently = 4726,
        [Description("Item Found Quantity +% If Wearing A Magic Item")]
        ItemFoundQuantityPosPctIfWearingAMagicItem = 4727,
        [Description("Item Found Rarity +% If Wearing A Normal Item")]
        ItemFoundRarityPosPctIfWearingANormalItem = 4728,
        [Description("Number Of Equipped Normal Items")]
        NumberOfEquippedNormalItems = 4729,
        [Description("Poison Cursed Enemies On Hit")]
        PoisonCursedEnemiesOnHit = 4730,
        [Description("Base Fire Damage % To Convert To Chaos 60% Value")]
        BaseFireDamagePctToConvertToChaos60PctValue = 4731,
        [Description("Base Lightning Damage % To Convert To Chaos 60% Value")]
        BaseLightningDamagePctToConvertToChaos60PctValue = 4732,
        [Description("Gain Onslaught For X Ms On Killing Rare Or Unique Monster")]
        GainOnslaughtForXMsOnKillingRareOrUniqueMonster = 4733,
        [Description("Kill Enemy On Hit If Under 20% Life")]
        KillEnemyOnHitIfUnder20PctLife = 4734,
        [Description("Immune To Bleeding While Leeching")]
        ImmuneToBleedingWhileLeeching = 4735,
        [Description("Damage +% If Enemy Killed Recently Final")]
        DamagePosPctIfEnemyKilledRecentlyFinal = 4736,
        [Description("Skill Area Of Effect +% If Enemy Killed Recently")]
        SkillAreaOfEffectPosPctIfEnemyKilledRecently = 4737,
        [Description("Virtual Immune To Bleeding")]
        VirtualImmuneToBleeding = 4738,
        [Description("Have Killed A Maimed Enemy Recently")]
        HaveKilledAMaimedEnemyRecently = 4739,
        [Description("Track Have Killed A Maimed Enemy Recently")]
        TrackHaveKilledAMaimedEnemyRecently = 4740,
        [Description("Skill Effect Duration +% If Killed Maimed Enemy Recently")]
        SkillEffectDurationPosPctIfKilledMaimedEnemyRecently = 4741,
        [Description("Have Taunted An Enemy Recently")]
        HaveTauntedAnEnemyRecently = 4742,
        [Description("Track Have Taunted An Enemy Recently")]
        TrackHaveTauntedAnEnemyRecently = 4743,
        [Description("Damage Taken +% If Taunted An Enemy Recently")]
        DamageTakenPosPctIfTauntedAnEnemyRecently = 4744,
        [Description("Life Regeneration Rate Per Minute % If Taunted An Enemy Recently")]
        LifeRegenerationRatePerMinutePctIfTauntedAnEnemyRecently = 4745,
        [Description("Immune To Elemental Status Ailments During Flask Effect")]
        ImmuneToElementalStatusAilmentsDuringFlaskEffect = 4746,
        [Description("Elemental Damage +% During Flask Effect")]
        ElementalDamagePosPctDuringFlaskEffect = 4747,
        [Description("Chance To Freeze Shock Ignite % During Flask Effect")]
        ChanceToFreezeShockIgnitePctDuringFlaskEffect = 4748,
        [Description("Summoned Monster Types Arent Duplicated")]
        SummonedMonsterTypesArentDuplicated = 4749,
        [Description("Slash Ancestor Totem Elemental Resistance %")]
        SlashAncestorTotemElementalResistancePct = 4750,
        [Description("Melee Ancestor Totem Grant Owner Attack Speed +%")]
        MeleeAncestorTotemGrantOwnerAttackSpeedPosPct = 4751,
        [Description("Slam Ancestor Totem Grant Owner Melee Damage +%")]
        SlamAncestorTotemGrantOwnerMeleeDamagePosPct = 4752,
        [Description("Frost Bolt Cast Speed +%")]
        FrostBoltCastSpeedPosPct = 4753,
        [Description("Frost Bolt Freeze Chance %")]
        FrostBoltFreezeChancePct = 4754,
        [Description("Frost Bolt Nova Duration +%")]
        FrostBoltNovaDurationPosPct = 4755,
        [Description("Chest Drop Additional Fire Warband Uniques")]
        ChestDropAdditionalFireWarbandUniques = 4756,
        [Description("Chest Drop Additional Cold Warband Uniques")]
        ChestDropAdditionalColdWarbandUniques = 4757,
        [Description("Chest Drop Additional Lightning Warband Uniques")]
        ChestDropAdditionalLightningWarbandUniques = 4758,
        [Description("Chest Drop Additional Chaos Warband Uniques")]
        ChestDropAdditionalChaosWarbandUniques = 4759,
        [Description("Weapons Drop Animated")]
        WeaponsDropAnimated = 4760,
        [Description("Es And Mana Regeneration Rate Per Minute % While On Consecrated Ground")]
        EsAndManaRegenerationRatePerMinutePctWhileOnConsecratedGround = 4761,
        [Description("Attack And Cast Speed +% While On Consecrated Ground")]
        AttackAndCastSpeedPosPctWhileOnConsecratedGround = 4762,
        [Description("Chest Display Summons Fire Warband")]
        ChestDisplaySummonsFireWarband = 4763,
        [Description("Chest Display Summons Cold Warband")]
        ChestDisplaySummonsColdWarband = 4764,
        [Description("Chest Display Summons Lightning Warband")]
        ChestDisplaySummonsLightningWarband = 4765,
        [Description("Chest Display Summons Chaos Warband")]
        ChestDisplaySummonsChaosWarband = 4766,
        [Description("Is Dominated")]
        IsDominated = 4767,
        [Description("Blast Rain Arrow Delay Ms")]
        BlastRainArrowDelayMs = 4768,
        [Description("Additional Block Chance % For 1 Second Every 5 Seconds")]
        AdditionalBlockChancePctFor1SecondEvery5Seconds = 4769,
        [Description("Mine Arming Speed +%")]
        MineArmingSpeedPosPct = 4770,
        [Description("Flasks % Chance To Not Consume Charges")]
        FlasksPctChanceToNotConsumeCharges = 4771,
        [Description("Critical Strike Chance +% Vs Bleeding Enemies")]
        CriticalStrikeChancePosPctVsBleedingEnemies = 4772,
        [Description("Physical Damage +% For 4 Seconds When You Block A Unique Enemy Hit")]
        PhysicalDamagePosPctFor4SecondsWhenYouBlockAUniqueEnemyHit = 4773,
        [Description("Your Consecrated Ground Grants Damage +%")]
        YourConsecratedGroundGrantsDamagePosPct = 4774,
        [Description("Attack Speed +% If Enemy Not Killed Recently")]
        AttackSpeedPosPctIfEnemyNotKilledRecently = 4775,
        [Description("Physical Damage +% While At Maximum Frenzy Charges Final")]
        PhysicalDamagePosPctWhileAtMaximumFrenzyChargesFinal = 4776,
        [Description("Physical Damage Taken +% While At Maximum Endurance Charges")]
        PhysicalDamageTakenPosPctWhileAtMaximumEnduranceCharges = 4777,
        [Description("Totem Damage Leeched As Life To You Permyriad")]
        TotemDamageLeechedAsLifeToYouPermyriad = 4778,
        [Description("Damage Leeched As Life To Parent Permyriad")]
        DamageLeechedAsLifeToParentPermyriad = 4779,
        [Description("Attack Speed +% Per 200 Accuracy Rating")]
        AttackSpeedPosPctPer200AccuracyRating = 4780,
        [Description("Gain Phasing While At Maximum Frenzy Charges")]
        GainPhasingWhileAtMaximumFrenzyCharges = 4781,
        [Description("Gain Phasing While You Have Onslaught")]
        GainPhasingWhileYouHaveOnslaught = 4782,
        [Description("Gain Maximum Endurance Charges On Endurance Charge Gained % Chance")]
        GainMaximumEnduranceChargesOnEnduranceChargeGainedPctChance = 4783,
        [Description("Elementalist Skill Area Of Effect +% For 4 Seconds Every 10 Seconds")]
        ElementalistSkillAreaOfEffectPosPctFor4SecondsEvery10Seconds = 4784,
        [Description("Physical Damage % To Add As Chaos Vs Bleeding Enemies")]
        PhysicalDamagePctToAddAsChaosVsBleedingEnemies = 4785,
        [Description("Elemental Resistances +% For You And Allies Affected By Your Auras")]
        ElementalResistancesPosPctForYouAndAlliesAffectedByYourAuras = 4786,
        [Description("Gain X Life On Trap Triggered By An Enemy")]
        GainXLifeOnTrapTriggeredByAnEnemy = 4787,
        [Description("Gain X Es On Trap Triggered By An Enemy")]
        GainXEsOnTrapTriggeredByAnEnemy = 4788,
        [Description("Phasing % For 3 Seconds On Trap Triggered By An Enemy")]
        PhasingPctFor3SecondsOnTrapTriggeredByAnEnemy = 4789,
        [Description("Visual Always Use Smallest Blood Effect")]
        VisualAlwaysUseSmallestBloodEffect = 4790,
        [Description("Attack Skills Additional Totems Allowed")]
        AttackSkillsAdditionalTotemsAllowed = 4791,
        [Description("Global Defences +% Per White Socket On Item")]
        GlobalDefencesPosPctPerWhiteSocketOnItem = 4792,
        [Description("Global Total Minimum Added Cold Damage")]
        GlobalTotalMinimumAddedColdDamage = 4793,
        [Description("Global Total Maximum Added Cold Damage")]
        GlobalTotalMaximumAddedColdDamage = 4794,
        [Description("Poison From Critical Strikes Damage +% Final")]
        PoisonFromCriticalStrikesDamagePosPctFinal = 4795,
        [Description("Bleed Damage +% Vs Maimed Enemies Final")]
        BleedDamagePosPctVsMaimedEnemiesFinal = 4796,
        [Description("Flask Charges +% From Enemies With Status Ailments")]
        FlaskChargesPosPctFromEnemiesWithStatusAilments = 4797,
        [Description("Mana Cost +% While On Full Energy Shield")]
        ManaCostPosPctWhileOnFullEnergyShield = 4798,
        [Description("Permanently Intimidate Enemies You Hit On Full Life")]
        PermanentlyIntimidateEnemiesYouHitOnFullLife = 4799,
        [Description("Number Of Corpses Consumed Recently")]
        NumberOfCorpsesConsumedRecently = 4800,
        [Description("Track Number Of Corpses Consumed Recently")]
        TrackNumberOfCorpsesConsumedRecently = 4801,
        [Description("Damage +% If You Have Consumed A Corpse Recently")]
        DamagePosPctIfYouHaveConsumedACorpseRecently = 4802,
        [Description("Attack And Cast Speed +% Per Corpse Consumed Recently")]
        AttackAndCastSpeedPosPctPerCorpseConsumedRecently = 4803,
        [Description("Armour And Evasion +% While Fortified")]
        ArmourAndEvasionPosPctWhileFortified = 4804,
        [Description("Melee Damage +% While Fortified")]
        MeleeDamagePosPctWhileFortified = 4805,
        [Description("Desecrate Creates X Additional Corpses")]
        DesecrateCreatesXAdditionalCorpses = 4806,
        [Description("Mana Regeneration Rate +% While Phasing")]
        ManaRegenerationRatePosPctWhilePhasing = 4807,
        [Description("Chaos Skill Effect Duration +%")]
        ChaosSkillEffectDurationPosPct = 4808,
        [Description("Damage +% Final Vs Non Taunt Target From Ot")]
        DamagePosPctFinalVsNonTauntTargetFromOt = 4809,
        [Description("Damage +% Final Vs Non Taunt Target From Passive")]
        DamagePosPctFinalVsNonTauntTargetFromPassive = 4810,
        [Description("Damage +% Final From Damaging Non Taunt Target")]
        DamagePosPctFinalFromDamagingNonTauntTarget = 4811,
        [Description("Taunted Enemies Damage +% Final Vs Non Taunt Target")]
        TauntedEnemiesDamagePosPctFinalVsNonTauntTarget = 4812,
        [Description("Chest Drop Additional Deshret Uniques")]
        ChestDropAdditionalDeshretUniques = 4813,
        [Description("Chest Drop Additional Rare Maraketh Weapons")]
        ChestDropAdditionalRareMarakethWeapons = 4814,
        [Description("Chest Display Spawns Torment Spirits Continuously")]
        ChestDisplaySpawnsTormentSpiritsContinuously = 4815,
        [Description("Chance To Cast On Owned Kill %")]
        ChanceToCastOnOwnedKillPct = 4816,
        [Description("Local Flask Cannot Be Stunned During Flask Effect")]
        LocalFlaskCannotBeStunnedDuringFlaskEffect = 4817,
        [Description("Local Flask Lose All Charges On Entering New Area")]
        LocalFlaskLoseAllChargesOnEnteringNewArea = 4818,
        [Description("Summon Specific Monsters Radius +%")]
        SummonSpecificMonstersRadiusPosPct = 4819,
        [Description("Monster Drop Additional Currency Items With Quality")]
        MonsterDropAdditionalCurrencyItemsWithQuality = 4820,
        [Description("Prophecy Spawned Monster Magic Minimum Rarity")]
        ProphecySpawnedMonsterMagicMinimumRarity = 4821,
        [Description("Gain Life Leech On Kill Permyriad")]
        GainLifeLeechOnKillPermyriad = 4822,
        [Description("Immune To Shock")]
        ImmuneToShock = 4823,
        [Description("Poison On Melee Hit")]
        PoisonOnMeleeHit = 4824,
        [Description("Life Leech Permyriad Vs Cursed Enemies")]
        LifeLeechPermyriadVsCursedEnemies = 4825,
        [Description("Movement Speed +% If Enemy Killed Recently")]
        MovementSpeedPosPctIfEnemyKilledRecently = 4826,
        [Description("Local Display Socketed Gems Supported By X Controlled Destruction")]
        LocalDisplaySocketedGemsSupportedByXControlledDestruction = 4827,
        [Description("Local Unique Flask Kiaras Determination")]
        LocalUniqueFlaskKiarasDetermination = 4828,
        [Description("Map Items Dropped Are Mirrored")]
        MapItemsDroppedAreMirrored = 4829,
        [Description("Monster Is Corrupted Display")]
        MonsterIsCorruptedDisplay = 4830,
        [Description("Monster Casts Fire Nova Text")]
        MonsterCastsFireNovaText = 4831,
        [Description("Monster Casts Flask Charge Nova Text")]
        MonsterCastsFlaskChargeNovaText = 4832,
        [Description("Monster Has Damage Taken Aura Text")]
        MonsterHasDamageTakenAuraText = 4833,
        [Description("Monster Has Temporal Chains Aura Text")]
        MonsterHasTemporalChainsAuraText = 4834,
        [Description("Monster Has Movement Skill Damage Aura Text")]
        MonsterHasMovementSkillDamageAuraText = 4835,
        [Description("Monster Casts Bleed Nova Text")]
        MonsterCastsBleedNovaText = 4836,
        [Description("Weapon Physical Damage % To Add As Each Element")]
        WeaponPhysicalDamagePctToAddAsEachElement = 4837,
        [Description("Map Force Labyrinth Trial")]
        MapForceLabyrinthTrial = 4838,
        [Description("Unique Cold Damage Can Also Ignite")]
        UniqueColdDamageCanAlsoIgnite = 4839,
        [Description("Monster Throws Chaos Bombs Text")]
        MonsterThrowsChaosBombsText = 4840,
        [Description("Attack Trigger On Melee Hit %")]
        AttackTriggerOnMeleeHitPct = 4841,
        [Description("Physical Damage % Added As Fire Damage If Enemy Killed Recently By You Or Your Totems")]
        PhysicalDamagePctAddedAsFireDamageIfEnemyKilledRecentlyByYouOrYourTotems = 4842,
        [Description("Give Parent Physical Damage % Added As Fire Damage If Enemy Killed Recently")]
        GiveParentPhysicalDamagePctAddedAsFireDamageIfEnemyKilledRecently = 4843,
        [Description("Unique Boss Curse Effect On Self +% Final")]
        UniqueBossCurseEffectOnSelfPosPctFinal = 4844,
        [Description("Chest Drop Additional Unique Item Divination Cards")]
        ChestDropAdditionalUniqueItemDivinationCards = 4845,
        [Description("Chest Drop Additional Corrupted Item Divination Cards")]
        ChestDropAdditionalCorruptedItemDivinationCards = 4846,
        [Description("Chest Drop Additional Currency Item Divination Cards")]
        ChestDropAdditionalCurrencyItemDivinationCards = 4847,
        [Description("Chest Drop Additional Divination Cards From Current World Area")]
        ChestDropAdditionalDivinationCardsFromCurrentWorldArea = 4848,
        [Description("Chest Drop Additional Divination Cards From Same Set")]
        ChestDropAdditionalDivinationCardsFromSameSet = 4849,
        [Description("Global Critical Strike Chance While Dual Wielding +%")]
        GlobalCriticalStrikeChanceWhileDualWieldingPosPct = 4850,
        [Description("Global Critical Strike Multiplier While Dual Wielding +")]
        GlobalCriticalStrikeMultiplierWhileDualWieldingPos = 4851,
        [Description("Doom Arrow Number Of Arrows")]
        DoomArrowNumberOfArrows = 4852,
        [Description("Stance Movement Speed +% Final")]
        StanceMovementSpeedPosPctFinal = 4853,
        [Description("Base Physical Damage Reduction And Evasion Rating")]
        BasePhysicalDamageReductionAndEvasionRating = 4854,
        [Description("First Blood Extra Gore")]
        FirstBloodExtraGore = 4855,
        [Description("Cast When Triggered By Other Skill %")]
        CastWhenTriggeredByOtherSkillPct = 4856,
        [Description("Local Display Socketed Gems Minimum Added Fire Damage")]
        LocalDisplaySocketedGemsMinimumAddedFireDamage = 4857,
        [Description("Local Display Socketed Gems Maximum Added Fire Damage")]
        LocalDisplaySocketedGemsMaximumAddedFireDamage = 4858,
        [Description("Local Display Socketed Gems Attack And Cast Speed +% Final")]
        LocalDisplaySocketedGemsAttackAndCastSpeedPosPctFinal = 4859,
        [Description("Local Display Socketed Gems Physical Damage % To Add As Lightning")]
        LocalDisplaySocketedGemsPhysicalDamagePctToAddAsLightning = 4860,
        [Description("Local Display Socketed Gems Elemental Damage +% Final")]
        LocalDisplaySocketedGemsElementalDamagePosPctFinal = 4861,
        [Description("Curse Nova Damage +% Final Per Curse Removed")]
        CurseNovaDamagePosPctFinalPerCurseRemoved = 4862,
        [Description("Elemental Penetration % During Flask Effect")]
        ElementalPenetrationPctDuringFlaskEffect = 4863,
        [Description("Additional Physical Damage Reduction % During Flask Effect")]
        AdditionalPhysicalDamageReductionPctDuringFlaskEffect = 4864,
        [Description("Reflect Damage Taken +%")]
        ReflectDamageTakenPosPct = 4865,
        [Description("Power Charge On Block % Chance")]
        PowerChargeOnBlockPctChance = 4866,
        [Description("Nearby Enemies Chilled On Block")]
        NearbyEnemiesChilledOnBlock = 4867,
        [Description("Arrow Projectile Variation")]
        ArrowProjectileVariation = 4868,
        [Description("Essence Buff Elemental Damage Taken +%")]
        EssenceBuffElementalDamageTakenPosPct = 4869,
        [Description("Essence Buff Ground Fire Damage To Deal Per Second")]
        EssenceBuffGroundFireDamageToDealPerSecond = 4870,
        [Description("Essence Buff Ground Fire Duration Ms")]
        EssenceBuffGroundFireDurationMs = 4871,
        [Description("Trigger Spawners Override Row")]
        TriggerSpawnersOverrideRow = 4872,
        [Description("Trigger Spawners Max Count")]
        TriggerSpawnersMaxCount = 4873,
        [Description("Map Race Data")]
        MapRaceData = 4874,
        [Description("Map Packs Have Pop Up Traps")]
        MapPacksHavePopUpTraps = 4875,
        [Description("Permanent Damage Taken +% On Minion Death")]
        PermanentDamageTakenPosPctOnMinionDeath = 4876,
        [Description("Permanent Actor Scale +% On Minion Death")]
        PermanentActorScalePosPctOnMinionDeath = 4877,
        [Description("Permanent Item Quantity +% On Minion Death")]
        PermanentItemQuantityPosPctOnMinionDeath = 4878,
        [Description("Permanent Item Rarity +% On Minion Death")]
        PermanentItemRarityPosPctOnMinionDeath = 4879,
        [Description("Ground Maelstrom Art Variation")]
        GroundMaelstromArtVariation = 4880,
        [Description("Do Not Revive After Time")]
        DoNotReviveAfterTime = 4881,
        [Description("Chaos Damage Taken Over Time +%")]
        ChaosDamageTakenOverTimePosPct = 4882,
        [Description("Local Display Socketed Gems Additional Critical Strike Chance %")]
        LocalDisplaySocketedGemsAdditionalCriticalStrikeChancePct = 4883,
        [Description("Attack And Cast Speed +% During Flask Effect")]
        AttackAndCastSpeedPosPctDuringFlaskEffect = 4884,
        [Description("Minimum Added Cold Damage Per Frenzy Charge")]
        MinimumAddedColdDamagePerFrenzyCharge = 4885,
        [Description("Maximum Added Cold Damage Per Frenzy Charge")]
        MaximumAddedColdDamagePerFrenzyCharge = 4886,
        [Description("Minimum Added Fire Damage If Blocked Recently")]
        MinimumAddedFireDamageIfBlockedRecently = 4887,
        [Description("Maximum Added Fire Damage If Blocked Recently")]
        MaximumAddedFireDamageIfBlockedRecently = 4888,
        [Description("Track Have Blocked Attack Recently")]
        TrackHaveBlockedAttackRecently = 4889,
        [Description("Have Blocked Attack Recently")]
        HaveBlockedAttackRecently = 4890,
        [Description("Global Total Minimum Added Fire Damage")]
        GlobalTotalMinimumAddedFireDamage = 4891,
        [Description("Global Total Maximum Added Fire Damage")]
        GlobalTotalMaximumAddedFireDamage = 4892,
        [Description("Stun Threshold Based On Energy Shield Instead Of Life")]
        StunThresholdBasedOnEnergyShieldInsteadOfLife = 4893,
        [Description("Cannot Leech Life From Critical Strikes")]
        CannotLeechLifeFromCriticalStrikes = 4894,
        [Description("% Chance To Blind On Critical Strike")]
        PctChanceToBlindOnCriticalStrike = 4895,
        [Description("Bleed On Melee Critical Strike")]
        BleedOnMeleeCriticalStrike = 4896,
        [Description("Map Has Monoliths")]
        MapHasMonoliths = 4897,
        [Description("In Lava")]
        InLava = 4898,
        [Description("Base Life Regeneration Per Minute % While In Lava")]
        BaseLifeRegenerationPerMinutePctWhileInLava = 4899,
        [Description("Lava Buff Effect On Self +%")]
        LavaBuffEffectOnSelfPosPct = 4900,
        [Description("Current Fire Beam Stacks")]
        CurrentFireBeamStacks = 4901,
        [Description("Max Fire Beam Stacks")]
        MaxFireBeamStacks = 4902,
        [Description("Marker Warp Marker Variation")]
        MarkerWarpMarkerVariation = 4903,
        [Description("Self Take No Extra Damage From Critical Strikes")]
        SelfTakeNoExtraDamageFromCriticalStrikes = 4904,
        [Description("Enemies You Shock Cast Speed +%")]
        EnemiesYouShockCastSpeedPosPct = 4905,
        [Description("Enemies You Shock Movement Speed +%")]
        EnemiesYouShockMovementSpeedPosPct = 4906,
        [Description("Burning Damage +% If Ignited An Enemy Recently")]
        BurningDamagePosPctIfIgnitedAnEnemyRecently = 4907,
        [Description("Recover % Maximum Life On Enemy Ignited")]
        RecoverPctMaximumLifeOnEnemyIgnited = 4908,
        [Description("Melee Physical Damage +% Vs Ignited Enemies")]
        MeleePhysicalDamagePosPctVsIgnitedEnemies = 4909,
        [Description("Critical Strike Chance +% For Forking Arrows")]
        CriticalStrikeChancePosPctForForkingArrows = 4910,
        [Description("Arrows Always Pierce After Chaining")]
        ArrowsAlwaysPierceAfterChaining = 4911,
        [Description("Arrows That Pierce Cause Bleeding")]
        ArrowsThatPierceCauseBleeding = 4912,
        [Description("Spells Number Of Additional Projectiles")]
        SpellsNumberOfAdditionalProjectiles = 4913,
        [Description("Minion Damage +% If Enemy Hit Recently")]
        MinionDamagePosPctIfEnemyHitRecently = 4914,
        [Description("Have Hit An Enemy Recently")]
        HaveHitAnEnemyRecently = 4915,
        [Description("Track Have Hit An Enemy Recently")]
        TrackHaveHitAnEnemyRecently = 4916,
        [Description("Minion Damage Increases And Reductions Also Affects You")]
        MinionDamageIncreasesAndReductionsAlsoAffectsYou = 4917,
        [Description("Projectile Attack Damage +% Per 200 Accuracy")]
        ProjectileAttackDamagePosPctPer200Accuracy = 4918,
        [Description("Map Bosses Have Union Of Souls")]
        MapBossesHaveUnionOfSouls = 4919,
        [Description("Map Extra Monoliths")]
        MapExtraMonoliths = 4920,
        [Description("Minion Dies When Parent Deleted")]
        MinionDiesWhenParentDeleted = 4921,
        [Description("Spectral Throw Projectile Scale +%")]
        SpectralThrowProjectileScalePosPct = 4922,
        [Description("Gain Onslaught For 3 Seconds % Chance When Hit")]
        GainOnslaughtFor3SecondsPctChanceWhenHit = 4923,
        [Description("Local Display Socketed Gems Damage Over Time +% Final")]
        LocalDisplaySocketedGemsDamageOverTimePosPctFinal = 4924,
        [Description("Deal Chaos Damage Per Second For 10 Seconds On Hit")]
        DealChaosDamagePerSecondFor10SecondsOnHit = 4925,
        [Description("Movement Speed +% While On Burning Chilled Shocked Ground")]
        MovementSpeedPosPctWhileOnBurningChilledShockedGround = 4926,
        [Description("Mana % Gained On Block")]
        ManaPctGainedOnBlock = 4927,
        [Description("Projectiles Drop Caustic Cloud")]
        ProjectilesDropCausticCloud = 4928,
        [Description("Base Projectile Ground Caustic Cloud Damage Per Minute")]
        BaseProjectileGroundCausticCloudDamagePerMinute = 4929,
        [Description("Local Display Socketed Non Curse Aura Gems Effect +%")]
        LocalDisplaySocketedNonCurseAuraGemsEffectPosPct = 4930,
        [Description("Local Display Fire Burst On Hit %")]
        LocalDisplayFireBurstOnHitPct = 4931,
        [Description("Essence Support Attack And Cast Speed +% Final")]
        EssenceSupportAttackAndCastSpeedPosPctFinal = 4932,
        [Description("Essence Support Elemental Damage +% Final")]
        EssenceSupportElementalDamagePosPctFinal = 4933,
        [Description("Base Number Of Essence Spirits Allowed")]
        BaseNumberOfEssenceSpiritsAllowed = 4934,
        [Description("Number Of Essence Spirits Allowed")]
        NumberOfEssenceSpiritsAllowed = 4935,
        [Description("Number Of Active Essence Spirits")]
        NumberOfActiveEssenceSpirits = 4936,
        [Description("Chest Drop Additional Prophecy Coins")]
        ChestDropAdditionalProphecyCoins = 4937,
        [Description("Ground Effect Variation")]
        GroundEffectVariation = 4938,
        [Description("Essence Support Damage Over Time +% Final")]
        EssenceSupportDamageOverTimePosPctFinal = 4939,
        [Description("Local Unique Jewel Spectres Gain Soul Eater On Kill % Chance With 50 Int In Radius")]
        LocalUniqueJewelSpectresGainSoulEaterOnKillPctChanceWith50IntInRadius = 4940,
        [Description("Spectres Gain Soul Eater For 30 Seconds On Kill % Chance")]
        SpectresGainSoulEaterFor30SecondsOnKillPctChance = 4941,
        [Description("Gain Soul Eater For 30 Seconds On Kill % Chance")]
        GainSoulEaterFor30SecondsOnKillPctChance = 4942,
        [Description("Local Unique Cast Socketed Cold Skills On Melee Critical Strike")]
        LocalUniqueCastSocketedColdSkillsOnMeleeCriticalStrike = 4943,
        [Description("Main Hand Local Unique Cast Socketed Cold Skills On Melee Critical Strike")]
        MainHandLocalUniqueCastSocketedColdSkillsOnMeleeCriticalStrike = 4944,
        [Description("Off Hand Local Unique Cast Socketed Cold Skills On Melee Critical Strike")]
        OffHandLocalUniqueCastSocketedColdSkillsOnMeleeCriticalStrike = 4945,
        [Description("Global Critical Strike Chance +% Vs Chilled Enemies")]
        GlobalCriticalStrikeChancePosPctVsChilledEnemies = 4946,
        [Description("Unique Cospris Malice Cold Spells Triggered")]
        UniqueCosprisMaliceColdSpellsTriggered = 4947,
        [Description("Projectile Ground Caustic Cloud Radius")]
        ProjectileGroundCausticCloudRadius = 4948,
        [Description("Gain Phasing If Enemy Killed Recently")]
        GainPhasingIfEnemyKilledRecently = 4949,
        [Description("Movement Skills Deal No Physical Damage")]
        MovementSkillsDealNoPhysicalDamage = 4950,
        [Description("X Mana Per 4 Strength")]
        XManaPer4Strength = 4951,
        [Description("Energy Shield +% Per 10 Strength")]
        EnergyShieldPosPctPer10Strength = 4952,
        [Description("X Life Per 4 Dexterity")]
        XLifePer4Dexterity = 4953,
        [Description("Melee Physical Damage +% Per 10 Dexterity")]
        MeleePhysicalDamagePosPctPer10Dexterity = 4954,
        [Description("X Accuracy Per 2 Intelligence")]
        XAccuracyPer2Intelligence = 4955,
        [Description("Evasion +% Per 10 Intelligence")]
        EvasionPosPctPer10Intelligence = 4956,
        [Description("Maximum Life % To Add As Maximum Armour")]
        MaximumLifePctToAddAsMaximumArmour = 4957,
        [Description("Monster No Drops If Death Timer Expired")]
        MonsterNoDropsIfDeathTimerExpired = 4958,
        [Description("Attack Area Of Effect +%")]
        AttackAreaOfEffectPosPct = 4959,
        [Description("Physical Damage Can Shock")]
        PhysicalDamageCanShock = 4960,
        [Description("Deal No Elemental Damage")]
        DealNoElementalDamage = 4961,
        [Description("Immune To Freeze")]
        ImmuneToFreeze = 4962,
        [Description("Immune To Ignite")]
        ImmuneToIgnite = 4963,
        [Description("Immune To Chill")]
        ImmuneToChill = 4964,
        [Description("Monster Drop No Essences")]
        MonsterDropNoEssences = 4965,
        [Description("Base Immune To Freeze")]
        BaseImmuneToFreeze = 4966,
        [Description("Base Immune To Chill")]
        BaseImmuneToChill = 4967,
        [Description("Base Immune To Ignite")]
        BaseImmuneToIgnite = 4968,
        [Description("Base Immune To Shock")]
        BaseImmuneToShock = 4969,
        [Description("Base Cannot Gain Bleeding")]
        BaseCannotGainBleeding = 4970,
        [Description("Map Boss Dropped Unique Items +")]
        MapBossDroppedUniqueItemsPos = 4971,
        [Description("Map Boss Drops Corrupted Items")]
        MapBossDropsCorruptedItems = 4972,
        [Description("Map Players And Monsters Damage +% Per Curse")]
        MapPlayersAndMonstersDamagePosPctPerCurse = 4973,
        [Description("Map Players And Monsters Critical Strike Chance +%")]
        MapPlayersAndMonstersCriticalStrikeChancePosPct = 4974,
        [Description("Map Monsters Steal Charges")]
        MapMonstersStealCharges = 4975,
        [Description("Map Unidentified Maps Item Quantity +%")]
        MapUnidentifiedMapsItemQuantityPosPct = 4976,
        [Description("Map Boss Dropped Item Quantity +%")]
        MapBossDroppedItemQuantityPosPct = 4977,
        [Description("Map Number Of Additional Mods")]
        MapNumberOfAdditionalMods = 4978,
        [Description("Map Nemesis Dropped Items +")]
        MapNemesisDroppedItemsPos = 4979,
        [Description("Map Contains Master")]
        MapContainsMaster = 4980,
        [Description("Buff Impl Stat")]
        BuffImplStat = 4981,
        [Description("Cannot Be Shocked")]
        CannotBeShocked = 4982,
        [Description("Restore Skill Life %")]
        RestoreSkillLifePct = 4983,
        [Description("Restore Skill Mana %")]
        RestoreSkillManaPct = 4984,
        [Description("Restore Skill Es %")]
        RestoreSkillEsPct = 4985,
        [Description("Ground Tar Art Variation")]
        GroundTarArtVariation = 4986,
        [Description("Fire Damage Taken When Enemy Ignited")]
        FireDamageTakenWhenEnemyIgnited = 4987,
        [Description("Life Leech From Fire Damage While Ignited Permyriad")]
        LifeLeechFromFireDamageWhileIgnitedPermyriad = 4988,
        [Description("Action Ignores Crit Tracking")]
        ActionIgnoresCritTracking = 4989,
        [Description("Movement Velocity While Spider +%")]
        MovementVelocityWhileSpiderPosPct = 4990,
        [Description("Is Spider")]
        IsSpider = 4991,
        [Description("Projectile Attack Damage +%")]
        ProjectileAttackDamagePosPct = 4992,
        [Description("Covered In Spiders Damage +% Final")]
        CoveredInSpidersDamagePosPctFinal = 4993,
        [Description("Covered In Spiders Attack And Cast Speed +% Final")]
        CoveredInSpidersAttackAndCastSpeedPosPctFinal = 4994,
        [Description("Map Create Instance Terrain Plugin")]
        MapCreateInstanceTerrainPlugin = 4995,
        [Description("Monster Map Boss Take Critical Strike Chance +% Final")]
        MonsterMapBossTakeCriticalStrikeChancePosPctFinal = 4996,
        [Description("Monster Map Boss Extra Damage Taken From Crit +% Final")]
        MonsterMapBossExtraDamageTakenFromCritPosPctFinal = 4997,
        [Description("Extra Damage Taken From Crit +%")]
        ExtraDamageTakenFromCritPosPct = 4998,
        [Description("Chance To Gain Frenzy Charge On Stun %")]
        ChanceToGainFrenzyChargeOnStunPct = 4999,
        [Description("Local Unique Flask Damage Over Time +% During Flask Effect")]
        LocalUniqueFlaskDamageOverTimePosPctDuringFlaskEffect = 5000,
        [Description("Local Unique Flask Nearby Enemies Cursed With Level X Despair During Flask Effect")]
        LocalUniqueFlaskNearbyEnemiesCursedWithLevelXDespairDuringFlaskEffect = 5001,
        [Description("Restore Skill Life Regeneration Rate Per Minute %")]
        RestoreSkillLifeRegenerationRatePerMinutePct = 5002,
        [Description("Restore Skill Mana Regeneration Rate Per Minute %")]
        RestoreSkillManaRegenerationRatePerMinutePct = 5003,
        [Description("Restore Skill Es Regeneration Rate Per Minute %")]
        RestoreSkillEsRegenerationRatePerMinutePct = 5004,
        [Description("Projectiles Pierce While Phasing")]
        ProjectilesPierceWhilePhasing = 5005,
        [Description("Avoid Projectiles While Phasing % Chance")]
        AvoidProjectilesWhilePhasingPctChance = 5006,
        [Description("Essence Display Drop Burning Ground While Moving Fire Damage Per Second")]
        EssenceDisplayDropBurningGroundWhileMovingFireDamagePerSecond = 5007,
        [Description("Essence Display Elemental Damage Taken While Not Moving +%")]
        EssenceDisplayElementalDamageTakenWhileNotMovingPosPct = 5008,
        [Description("Local Flask Area Of Effect +% During Flask Effect")]
        LocalFlaskAreaOfEffectPosPctDuringFlaskEffect = 5009,
        [Description("Local Flask Number Of Additional Projectiles During Flask Effect")]
        LocalFlaskNumberOfAdditionalProjectilesDuringFlaskEffect = 5010,
        [Description("Corrupted Blood On Hit Duration")]
        CorruptedBloodOnHitDuration = 5011,
        [Description("Take No Actions While Parent Dead")]
        TakeNoActionsWhileParentDead = 5012,
        [Description("Cast On Hide %")]
        CastOnHidePct = 5013,
        [Description("Map Item Level Override")]
        MapItemLevelOverride = 5014,
        [Description("Hallowed Ground Boss Use Clone Attack")]
        HallowedGroundBossUseCloneAttack = 5015,
        [Description("Hallowed Ground Boss Drop Tar On Ground Slam")]
        HallowedGroundBossDropTarOnGroundSlam = 5016,
        [Description("Drop Ground Tar On Hit %")]
        DropGroundTarOnHitPct = 5017,
        [Description("Map Drop Stacked Deck On Death Permyriad")]
        MapDropStackedDeckOnDeathPermyriad = 5018,
        [Description("Magic Monster Dropped Item Rarity +%")]
        MagicMonsterDroppedItemRarityPosPct = 5019,
        [Description("Normal Monster Dropped Item Quantity +%")]
        NormalMonsterDroppedItemQuantityPosPct = 5020,
        [Description("Map Player Has Level X Projectile Weakness")]
        MapPlayerHasLevelXProjectileWeakness = 5021,
        [Description("Map Player Has Level X Conductivity")]
        MapPlayerHasLevelXConductivity = 5022,
        [Description("Map Player Has Level X Flammability")]
        MapPlayerHasLevelXFlammability = 5023,
        [Description("Map Player Has Level X Frostbite")]
        MapPlayerHasLevelXFrostbite = 5024,
        [Description("Support Cast On Crit Spell Damage +% Final")]
        SupportCastOnCritSpellDamagePosPctFinal = 5025,
        [Description("Support Cast On Melee Kill Spell Damage +% Final")]
        SupportCastOnMeleeKillSpellDamagePosPctFinal = 5026,
        [Description("Avoid Projectiles % Chance")]
        AvoidProjectilesPctChance = 5027,
        [Description("Monster Inside Monolith")]
        MonsterInsideMonolith = 5028,
        [Description("Map Spawn Extra Perandus Chests")]
        MapSpawnExtraPerandusChests = 5029,
        [Description("Map Spawn Cadiro % Chance")]
        MapSpawnCadiroPctChance = 5030,
        [Description("Cast On Unhide %")]
        CastOnUnhidePct = 5031,
        [Description("Map Players And Monsters Have Resolute Technique")]
        MapPlayersAndMonstersHaveResoluteTechnique = 5032,
        [Description("Map Resolute Technique")]
        MapResoluteTechnique = 5033,
        [Description("Map Unique Boss Drops Divination Cards")]
        MapUniqueBossDropsDivinationCards = 5034,
        [Description("All Damage Can Chill")]
        AllDamageCanChill = 5035,
        [Description("All Damage Can Shock")]
        AllDamageCanShock = 5036,
        [Description("All Damage Can Ignite")]
        AllDamageCanIgnite = 5037,
        [Description("Elementalist Gain Shaper Of Desolation Every 10 Seconds")]
        ElementalistGainShaperOfDesolationEvery10Seconds = 5038,
        [Description("Monster Delay Item Drops Millis")]
        MonsterDelayItemDropsMillis = 5039,
        [Description("Map Area Contains Grandmaster Ally")]
        MapAreaContainsGrandmasterAlly = 5040,
        [Description("Map Contains Creeping Agony")]
        MapContainsCreepingAgony = 5041,
        [Description("Map Portals Do Not Expire")]
        MapPortalsDoNotExpire = 5042,
        [Description("Map Monsters Are Converted On Kill")]
        MapMonstersAreConvertedOnKill = 5043,
        [Description("Map Contains X Fewer Portals")]
        MapContainsXFewerPortals = 5044,
        [Description("Monsters Are Converted On Kill")]
        MonstersAreConvertedOnKill = 5045,
        [Description("Map No Uniques Drop Randomly")]
        MapNoUniquesDropRandomly = 5046,
        [Description("Map Players Additional Number Of Projectiles")]
        MapPlayersAdditionalNumberOfProjectiles = 5047,
        [Description("Map Damage +% Of Type Inflicted By Current Ground Effect You Are On")]
        MapDamagePosPctOfTypeInflictedByCurrentGroundEffectYouAreOn = 5048,
        [Description("On Desecrated Ground")]
        OnDesecratedGround = 5049,
        [Description("Map Players And Monsters Curses Are Reflected")]
        MapPlayersAndMonstersCursesAreReflected = 5050,
        [Description("Map Player Has Level X Silence")]
        MapPlayerHasLevelXSilence = 5051,
        [Description("Map Strongbox Items Dropped Are Mirrored")]
        MapStrongboxItemsDroppedAreMirrored = 5052,
        [Description("Map Players Are Poisoned While Moving Chaos Damage Per Second")]
        MapPlayersArePoisonedWhileMovingChaosDamagePerSecond = 5053,
        [Description("Discharge Triggered Damage +% Final")]
        DischargeTriggeredDamagePosPctFinal = 5054,
        [Description("Map Normal Items Drop As Magic")]
        MapNormalItemsDropAsMagic = 5055,
        [Description("Monster No Additional Player Scaling")]
        MonsterNoAdditionalPlayerScaling = 5056,
        [Description("Phase Through Objects While Spider")]
        PhaseThroughObjectsWhileSpider = 5057,
        [Description("Map Flask Charges Recovered Per 3 Seconds %")]
        MapFlaskChargesRecoveredPer3SecondsPct = 5058,
        [Description("Virtual Flask Charges Recovered Per 3 Seconds %")]
        VirtualFlaskChargesRecoveredPer3SecondsPct = 5059,
        [Description("Combined Hit All Damage +% Final")]
        CombinedHitAllDamagePosPctFinal = 5060,
        [Description("Support Remote Mine Hit Damage +% Final")]
        SupportRemoteMineHitDamagePosPctFinal = 5061,
        [Description("Map Magic Items Drop As Normal")]
        MapMagicItemsDropAsNormal = 5062,
        [Description("Flask Charges Recovered Per 3 Seconds %")]
        FlaskChargesRecoveredPer3SecondsPct = 5063,
        [Description("Support Trap Hit Damage +% Final")]
        SupportTrapHitDamagePosPctFinal = 5064,
        [Description("Damage Vs Tiki Totems +%")]
        DamageVsTikiTotemsPosPct = 5065,
        [Description("Is Tiki Totem")]
        IsTikiTotem = 5066,
        [Description("Self Ignite Duration +% Final")]
        SelfIgniteDurationPosPctFinal = 5067,
        [Description("Self Bleed Duration +% Final")]
        SelfBleedDurationPosPctFinal = 5068,
        [Description("Self Poison Duration +% Final")]
        SelfPoisonDurationPosPctFinal = 5069,
        [Description("Treasure Pile Damage +% Final")]
        TreasurePileDamagePosPctFinal = 5070,
        [Description("Map Contains Additional Packs Of Fire Monsters")]
        MapContainsAdditionalPacksOfFireMonsters = 5071,
        [Description("Map Contains Additional Packs Of Chaos Monsters")]
        MapContainsAdditionalPacksOfChaosMonsters = 5072,
        [Description("Map Contains Additional Packs Of Physical Monsters")]
        MapContainsAdditionalPacksOfPhysicalMonsters = 5073,
        [Description("Map Contains Additional Packs Of Lightning Monsters")]
        MapContainsAdditionalPacksOfLightningMonsters = 5074,
        [Description("Map Contains Additional Packs Of Cold Monsters")]
        MapContainsAdditionalPacksOfColdMonsters = 5075,
        [Description("Map Players And Monsters Fire Damage Taken +%")]
        MapPlayersAndMonstersFireDamageTakenPosPct = 5076,
        [Description("Map Players And Monsters Chaos Damage Taken +%")]
        MapPlayersAndMonstersChaosDamageTakenPosPct = 5077,
        [Description("Map Players And Monsters Physical Damage Taken +%")]
        MapPlayersAndMonstersPhysicalDamageTakenPosPct = 5078,
        [Description("Map Players And Monsters Lightning Damage Taken +%")]
        MapPlayersAndMonstersLightningDamageTakenPosPct = 5079,
        [Description("Map Players And Monsters Cold Damage Taken +%")]
        MapPlayersAndMonstersColdDamageTakenPosPct = 5080,
        [Description("Map Players And Monsters Have Onslaught If Hit Recently")]
        MapPlayersAndMonstersHaveOnslaughtIfHitRecently = 5081,
        [Description("Map Players And Monsters Damage Taken +% While Stationary")]
        MapPlayersAndMonstersDamageTakenPosPctWhileStationary = 5082,
        [Description("Chance To Poison On Melee Hit %")]
        ChanceToPoisonOnMeleeHitPct = 5083,
        [Description("Chilled Ground Effect +%")]
        ChilledGroundEffectPosPct = 5084,
        [Description("Damage Vs Spiders While Spider +%")]
        DamageVsSpidersWhileSpiderPosPct = 5085,
        [Description("Damage Taken From Spiders While Spider +%")]
        DamageTakenFromSpidersWhileSpiderPosPct = 5086,
        [Description("Map Players And Monsters Movement Speed +%")]
        MapPlayersAndMonstersMovementSpeedPosPct = 5087,
        [Description("Damage Taken +% For 4 Seconds After Spending 200 Mana")]
        DamageTakenPosPctFor4SecondsAfterSpending200Mana = 5088,
        [Description("Life Regeneration Per Minute Per Active Buff")]
        LifeRegenerationPerMinutePerActiveBuff = 5089,
        [Description("Buff Effect +% On Low Energy Shield")]
        BuffEffectPosPctOnLowEnergyShield = 5090,
        [Description("On Low Energy Shield")]
        OnLowEnergyShield = 5091,
        [Description("Map Ground Haste Action Speed +%")]
        MapGroundHasteActionSpeedPosPct = 5092,
        [Description("Map Drops All Maps")]
        MapDropsAllMaps = 5093,
        [Description("Essence Delirium Spawn Monster On Death Variation")]
        EssenceDeliriumSpawnMonsterOnDeathVariation = 5094,
        [Description("Essence Anguish Spawn Monster On Death Variation")]
        EssenceAnguishSpawnMonsterOnDeathVariation = 5095,
        [Description("Essence Suffering Spawn Monster On Death Variation")]
        EssenceSufferingSpawnMonsterOnDeathVariation = 5096,
        [Description("Essence Corrupt Spawn Monster On Death Variation")]
        EssenceCorruptSpawnMonsterOnDeathVariation = 5097,
        [Description("Map Ground Haste Effect Patches Per 100 Tiles")]
        MapGroundHasteEffectPatchesPer100Tiles = 5098,
        [Description("Map Ground Haste Effect Radius")]
        MapGroundHasteEffectRadius = 5099,
        [Description("Map Breach Rules")]
        MapBreachRules = 5100,
        [Description("Cannot Regenerate Energy Shield")]
        CannotRegenerateEnergyShield = 5101,
        [Description("Cannot Recharge Energy Shield")]
        CannotRechargeEnergyShield = 5102,
        [Description("Energy Shield Lost Per Minute %")]
        EnergyShieldLostPerMinutePct = 5103,
        [Description("Life Leech Applies To Energy Shield On Full Life")]
        LifeLeechAppliesToEnergyShieldOnFullLife = 5104,
        [Description("Virtual Leech Energy Shield Instead Of Life")]
        VirtualLeechEnergyShieldInsteadOfLife = 5105,
        [Description("Current Number Of Spinning Blades")]
        CurrentNumberOfSpinningBlades = 5106,
        [Description("Fire Beam Additional Stack Damage +% Final")]
        FireBeamAdditionalStackDamagePosPctFinal = 5107,
        [Description("Number Of Blood Ravens To Summon")]
        NumberOfBloodRavensToSummon = 5108,
        [Description("Map Fishy Effect 0")]
        MapFishyEffect0 = 5109,
        [Description("Map Hidden Players Have Insanity")]
        MapHiddenPlayersHaveInsanity = 5110,
        [Description("Map Monster And Player Onslaught Effect +%")]
        MapMonsterAndPlayerOnslaughtEffectPosPct = 5111,
        [Description("Map Damage While Stationary +%")]
        MapDamageWhileStationaryPosPct = 5112,
        [Description("Map Damage Taken While Stationary +%")]
        MapDamageTakenWhileStationaryPosPct = 5113,
        [Description("Map Item Drop Quality Also Applies To Map Item Drop Rarity")]
        MapItemDropQualityAlsoAppliesToMapItemDropRarity = 5114,
        [Description("Map Has X% Quality")]
        MapHasXPctQuality = 5115,
        [Description("Map Unique Monsters Drop Corrupted Items")]
        MapUniqueMonstersDropCorruptedItems = 5116,
        [Description("Fire Beam Degen Spread To Enemies In Radius On Kill")]
        FireBeamDegenSpreadToEnemiesInRadiusOnKill = 5117,
        [Description("Fire Beam Enemy Fire Resistance % Per Stack")]
        FireBeamEnemyFireResistancePctPerStack = 5118,
        [Description("Fire Beam Cast Speed +%")]
        FireBeamCastSpeedPosPct = 5119,
        [Description("Map Corrupted Bosses Drop X Additional Vaal Items")]
        MapCorruptedBossesDropXAdditionalVaalItems = 5120,
        [Description("Map Strongboxes Are Corrupted")]
        MapStrongboxesAreCorrupted = 5121,
        [Description("Map Players Cannot Take Reflected Damage")]
        MapPlayersCannotTakeReflectedDamage = 5122,
        [Description("Map Player Flask Recovery Is Instant")]
        MapPlayerFlaskRecoveryIsInstant = 5123,
        [Description("Map Contains X Additional Packs With Mirrored Rare Monsters")]
        MapContainsXAdditionalPacksWithMirroredRareMonsters = 5124,
        [Description("Map Contains X Additional Healing Packs")]
        MapContainsXAdditionalHealingPacks = 5125,
        [Description("Map Contains X Additional Normal Packs")]
        MapContainsXAdditionalNormalPacks = 5126,
        [Description("Map Contains X Additional Magic Packs")]
        MapContainsXAdditionalMagicPacks = 5127,
        [Description("Map Contains X Additional Rare Packs")]
        MapContainsXAdditionalRarePacks = 5128,
        [Description("Map Contains X Additional Packs That Convert On Death")]
        MapContainsXAdditionalPacksThatConvertOnDeath = 5129,
        [Description("Map Contains X Additional Packs On Their Own Team")]
        MapContainsXAdditionalPacksOnTheirOwnTeam = 5130,
        [Description("Map On Complete Drop X Additional Maps")]
        MapOnCompleteDropXAdditionalMaps = 5131,
        [Description("Monster Converts On Death")]
        MonsterConvertsOnDeath = 5132,
        [Description("Flask Recovery Is Instant")]
        FlaskRecoveryIsInstant = 5133,
        [Description("Map Fishy Effect 1")]
        MapFishyEffect1 = 5134,
        [Description("Map Fishy Effect 2")]
        MapFishyEffect2 = 5135,
        [Description("Map Fishy Effect 3")]
        MapFishyEffect3 = 5136,
        [Description("Map Magic Pack Size +%")]
        MapMagicPackSizePosPct = 5137,
        [Description("Map Rogue Exiles Damage +%")]
        MapRogueExilesDamagePosPct = 5138,
        [Description("Map Rogue Exiles Maximum Life +%")]
        MapRogueExilesMaximumLifePosPct = 5139,
        [Description("Map Rogue Exiles Drop X Additional Jewels")]
        MapRogueExilesDropXAdditionalJewels = 5140,
        [Description("Monster Drop Additional Jewels")]
        MonsterDropAdditionalJewels = 5141,
        [Description("Map Strongbox Monsters Item Quantity +%")]
        MapStrongboxMonstersItemQuantityPosPct = 5142,
        [Description("Map Strongbox Monsters Actor Scale +%")]
        MapStrongboxMonstersActorScalePosPct = 5143,
        [Description("Map Strongbox Monsters Attack Speed +%")]
        MapStrongboxMonstersAttackSpeedPosPct = 5144,
        [Description("Map Strongbox Monsters Movement Velocity +%")]
        MapStrongboxMonstersMovementVelocityPosPct = 5145,
        [Description("Strongbox Monsters Item Quantity +%")]
        StrongboxMonstersItemQuantityPosPct = 5146,
        [Description("Strongbox Monsters Actor Scale +%")]
        StrongboxMonstersActorScalePosPct = 5147,
        [Description("Strongbox Monsters Attack Speed +%")]
        StrongboxMonstersAttackSpeedPosPct = 5148,
        [Description("Strongbox Monsters Movement Velocity +%")]
        StrongboxMonstersMovementVelocityPosPct = 5149,
        [Description("Damage +% Per Poison Stack")]
        DamagePosPctPerPoisonStack = 5150,
        [Description("Movement Velocity +% Per Poison Stack")]
        MovementVelocityPosPctPerPoisonStack = 5151,
        [Description("Map Damage +% Per Poison Stack")]
        MapDamagePosPctPerPoisonStack = 5152,
        [Description("Map Movement Velocity +% Per Poison Stack")]
        MapMovementVelocityPosPctPerPoisonStack = 5153,
        [Description("Map Contains X Additional Poison Packs")]
        MapContainsXAdditionalPoisonPacks = 5154,
        [Description("Inspiring Cry Enemy Count Override")]
        InspiringCryEnemyCountOverride = 5155,
        [Description("Map Area Contains X Additional Clusters Of Explosive Barrels")]
        MapAreaContainsXAdditionalClustersOfExplosiveBarrels = 5156,
        [Description("Map Bonus Barrel %")]
        MapBonusBarrelPct = 5157,
        [Description("Empowering Cry Physical Damage Added As Fire Damage %")]
        EmpoweringCryPhysicalDamageAddedAsFireDamagePct = 5158,
        [Description("Map Boss Accompanied By Bodyguards")]
        MapBossAccompaniedByBodyguards = 5159,
        [Description("Blade Vortex Hit Rate +% Per Blade")]
        BladeVortexHitRatePosPctPerBlade = 5160,
        [Description("Blade Vortex Damage +% Per Blade Final")]
        BladeVortexDamagePosPctPerBladeFinal = 5161,
        [Description("Golem Maximum Life +%")]
        GolemMaximumLifePosPct = 5162,
        [Description("Golem Life Regeneration Per Minute %")]
        GolemLifeRegenerationPerMinutePct = 5163,
        [Description("Have Summoned A Golem In Past 8 Seconds")]
        HaveSummonedAGolemInPast8Seconds = 5164,
        [Description("Damage +% If Golem Summoned In Past 8 Seconds")]
        DamagePosPctIfGolemSummonedInPast8Seconds = 5165,
        [Description("Golem Damage +% If Summoned In Past 8 Seconds")]
        GolemDamagePosPctIfSummonedInPast8Seconds = 5166,
        [Description("Golem Skill Cooldown Recovery +%")]
        GolemSkillCooldownRecoveryPosPct = 5167,
        [Description("Golem Cooldown Recovery +%")]
        GolemCooldownRecoveryPosPct = 5168,
        [Description("Golem Buff Effect +%")]
        GolemBuffEffectPosPct = 5169,
        [Description("Golem Attack And Cast Speed +%")]
        GolemAttackAndCastSpeedPosPct = 5170,
        [Description("Golem Physical Damage Reduction Rating")]
        GolemPhysicalDamageReductionRating = 5171,
        [Description("Primordial Jewel Count")]
        PrimordialJewelCount = 5172,
        [Description("Number Of Golems Allowed With 3 Primordial Jewels")]
        NumberOfGolemsAllowedWith3PrimordialJewels = 5173,
        [Description("Map Monster Curse Effect On Self +%")]
        MapMonsterCurseEffectOnSelfPosPct = 5174,
        [Description("Map Player Curse Effect On Self +%")]
        MapPlayerCurseEffectOnSelfPosPct = 5175,
        [Description("Thrown Shield Num Additional Projectiles")]
        ThrownShieldNumAdditionalProjectiles = 5176,
        [Description("Buff Damage While Stationery +%")]
        BuffDamageWhileStationeryPosPct = 5177,
        [Description("Buff Damage Taken While Stationery +%")]
        BuffDamageTakenWhileStationeryPosPct = 5178,
        [Description("Map Display Strongbox Monsters Are Enraged")]
        MapDisplayStrongboxMonstersAreEnraged = 5179,
        [Description("Celestial Footprints From Item")]
        CelestialFootprintsFromItem = 5180,
        [Description("Deal 1000 Chaos Damage Per Second For 10 Seconds On Hit")]
        Deal1000ChaosDamagePerSecondFor10SecondsOnHit = 5181,
        [Description("Map Strongboxes Minimum Rarity")]
        MapStrongboxesMinimumRarity = 5182,
        [Description("Map Area Contains X Additional Clusters Of Wealthy Barrels")]
        MapAreaContainsXAdditionalClustersOfWealthyBarrels = 5183,
        [Description("Map Area Contains X Additional Clusters Of Volatile Barrels")]
        MapAreaContainsXAdditionalClustersOfVolatileBarrels = 5184,
        [Description("Map Area Contains X Additional Clusters Of Bloodworm Barrels")]
        MapAreaContainsXAdditionalClustersOfBloodwormBarrels = 5185,
        [Description("Map Area Contains X Additional Clusters Of Parasite Barrels")]
        MapAreaContainsXAdditionalClustersOfParasiteBarrels = 5186,
        [Description("Map Area Contains X Additional Clusters Of Beacon Barrels")]
        MapAreaContainsXAdditionalClustersOfBeaconBarrels = 5187,
        [Description("Map Contains X Additional Rare Packs If Rare")]
        MapContainsXAdditionalRarePacksIfRare = 5188,
        [Description("Map Contains X Additional Magic Packs If Magic")]
        MapContainsXAdditionalMagicPacksIfMagic = 5189,
        [Description("Map Contains X Additional Normal Packs If Normal")]
        MapContainsXAdditionalNormalPacksIfNormal = 5190,
        [Description("Map Boss Drops X Additional Vaal Items")]
        MapBossDropsXAdditionalVaalItems = 5191,
        [Description("Fire Beam Length +%")]
        FireBeamLengthPosPct = 5192,
        [Description("Is Breach Monster")]
        IsBreachMonster = 5193,
        [Description("Cast Linked Spells On Shocked Enemy Kill %")]
        CastLinkedSpellsOnShockedEnemyKillPct = 5194,
        [Description("Map Equipment Drops Identified In Identified Areas")]
        MapEquipmentDropsIdentifiedInIdentifiedAreas = 5195,
        [Description("Map Items Drop Corrupted %")]
        MapItemsDropCorruptedPct = 5196,
        [Description("Doom Arrow Area Of Effect +% Final Per Frenzy Charge")]
        DoomArrowAreaOfEffectPosPctFinalPerFrenzyCharge = 5197,
        [Description("Bonespire Number Of Bone Piles To Spawn")]
        BonespireNumberOfBonePilesToSpawn = 5198,
        [Description("Mortar Cone Angle")]
        MortarConeAngle = 5199,
        [Description("Current Consume Charges")]
        CurrentConsumeCharges = 5200,
        [Description("Maximum Consume Charges")]
        MaximumConsumeCharges = 5201,
        [Description("Expend Consume Charges On Skill Use")]
        ExpendConsumeChargesOnSkillUse = 5202,
        [Description("Gain Consume Charges On Skill Use")]
        GainConsumeChargesOnSkillUse = 5203,
        [Description("Secondary Skill Effect Duration +%")]
        SecondarySkillEffectDurationPosPct = 5204,
        [Description("X Armour Per Active Totem")]
        XArmourPerActiveTotem = 5205,
        [Description("Map Pack Size +% In Unidentified Areas")]
        MapPackSizePosPctInUnidentifiedAreas = 5206,
        [Description("Chance To Dodge % At Max Charged Attack Stacks")]
        ChanceToDodgePctAtMaxChargedAttackStacks = 5207,
        [Description("Critical Strikes Deal No Damage")]
        CriticalStrikesDealNoDamage = 5208,
        [Description("Spell Damage +% If Have Crit Recently")]
        SpellDamagePosPctIfHaveCritRecently = 5209,
        [Description("Critical Strike Multiplier + If Have Dealt Non Crit Recently")]
        CriticalStrikeMultiplierPosIfHaveDealtNonCritRecently = 5210,
        [Description("Track Have Dealt Non Crit Recently")]
        TrackHaveDealtNonCritRecently = 5211,
        [Description("Have Dealt Non Crit Recently")]
        HaveDealtNonCritRecently = 5212,
        [Description("Total Base Armour Rating")]
        TotalBaseArmourRating = 5213,
        [Description("Combined Only Armour +%")]
        CombinedOnlyArmourPosPct = 5214,
        [Description("Combined Armour +%")]
        CombinedArmourPosPct = 5215,
        [Description("Combined Only Armour +% Final")]
        CombinedOnlyArmourPosPctFinal = 5216,
        [Description("Combined Evasion Rating +% Final")]
        CombinedEvasionRatingPosPctFinal = 5217,
        [Description("Combined Only Armour From Shield +%")]
        CombinedOnlyArmourFromShieldPosPct = 5218,
        [Description("Combined Armour From Shield +%")]
        CombinedArmourFromShieldPosPct = 5219,
        [Description("Armour Differs Against Projectiles")]
        ArmourDiffersAgainstProjectiles = 5220,
        [Description("Armour While Stationary")]
        ArmourWhileStationary = 5221,
        [Description("Mana Regeneration Rate +% While Stationary")]
        ManaRegenerationRatePosPctWhileStationary = 5222,
        [Description("Non Critical Strikes Deal No Damage")]
        NonCriticalStrikesDealNoDamage = 5223,
        [Description("Chilled Ground When Hit With Attack %")]
        ChilledGroundWhenHitWithAttackPct = 5224,
        [Description("Critical Strike Multiplier + Per 1% Block Chance")]
        CriticalStrikeMultiplierPosPer1PctBlockChance = 5225,
        [Description("Local Flask Unholy Might During Flask Effect")]
        LocalFlaskUnholyMightDuringFlaskEffect = 5226,
        [Description("Spell Minimum Added Cold Damage Per Power Charge")]
        SpellMinimumAddedColdDamagePerPowerCharge = 5227,
        [Description("Spell Maximum Added Cold Damage Per Power Charge")]
        SpellMaximumAddedColdDamagePerPowerCharge = 5228,
        [Description("Recover X Mana On Killing Frozen Enemy")]
        RecoverXManaOnKillingFrozenEnemy = 5229,
        [Description("Chance To Gain Power Charge On Killing Frozen Enemy %")]
        ChanceToGainPowerChargeOnKillingFrozenEnemyPct = 5230,
        [Description("Damage +% If You Have Frozen Enemy Recently")]
        DamagePosPctIfYouHaveFrozenEnemyRecently = 5231,
        [Description("Track Have Frozen Enemy Recently")]
        TrackHaveFrozenEnemyRecently = 5232,
        [Description("Have Frozen Enemy Recently")]
        HaveFrozenEnemyRecently = 5233,
        [Description("Maximum Added Lightning Damage Per 10 Int")]
        MaximumAddedLightningDamagePer10Int = 5234,
        [Description("Attack Speed +% Per 25 Dex")]
        AttackSpeedPosPctPer25Dex = 5235,
        [Description("Number Of Shocked Enemies Killed Recently")]
        NumberOfShockedEnemiesKilledRecently = 5236,
        [Description("Minimum Added Lightning Damage Per Shocked Enemy Killed Recently")]
        MinimumAddedLightningDamagePerShockedEnemyKilledRecently = 5237,
        [Description("Maximum Added Lightning Damage Per Shocked Enemy Killed Recently")]
        MaximumAddedLightningDamagePerShockedEnemyKilledRecently = 5238,
        [Description("Reflect Shocks")]
        ReflectShocks = 5239,
        [Description("Movement Speed +% While Bleeding")]
        MovementSpeedPosPctWhileBleeding = 5240,
        [Description("Physical Damage Taken +% While Moving")]
        PhysicalDamageTakenPosPctWhileMoving = 5241,
        [Description("Physical Damage Reduction Rating % While Not Moving")]
        PhysicalDamageReductionRatingPctWhileNotMoving = 5242,
        [Description("Display Max Fire Beam Stacks")]
        DisplayMaxFireBeamStacks = 5243,
        [Description("Display Max Blight Stacks")]
        DisplayMaxBlightStacks = 5244,
        [Description("Virtual Track Movement")]
        VirtualTrackMovement = 5245,
        [Description("Is Moving")]
        IsMoving = 5246,
        [Description("Mass Flicker Strike Number Of Teleports")]
        MassFlickerStrikeNumberOfTeleports = 5247,
        [Description("Blind Chilled Enemies On Hit %")]
        BlindChilledEnemiesOnHitPct = 5248,
        [Description("Cold Damage +% Per Frenzy Charge")]
        ColdDamagePosPctPerFrenzyCharge = 5249,
        [Description("Gain Frenzy Charge On Reaching Maximum Power Charges")]
        GainFrenzyChargeOnReachingMaximumPowerCharges = 5250,
        [Description("Gain Frenzy Charge On Hit While Bleeding")]
        GainFrenzyChargeOnHitWhileBleeding = 5251,
        [Description("Virtual Chaos Damage Does Not Bypass Energy Shield")]
        VirtualChaosDamageDoesNotBypassEnergyShield = 5252,
        [Description("Chaos Damage Does Not Bypass Energy Shield While Not Low Life Or Mana")]
        ChaosDamageDoesNotBypassEnergyShieldWhileNotLowLifeOrMana = 5253,
        [Description("Local Display Grants Level X Reckoning")]
        LocalDisplayGrantsLevelXReckoning = 5254,
        [Description("Reflect Shocks To Enemies In Radius")]
        ReflectShocksToEnemiesInRadius = 5255,
        [Description("Recover % Maximum Life On Killing Poisoned Enemy")]
        RecoverPctMaximumLifeOnKillingPoisonedEnemy = 5256,
        [Description("Minions Recover % Maximum Life On Killing Poisoned Enemy")]
        MinionsRecoverPctMaximumLifeOnKillingPoisonedEnemy = 5257,
        [Description("Recover X Life On Enemy Ignited")]
        RecoverXLifeOnEnemyIgnited = 5258,
        [Description("Cold Penetration % Vs Chilled Enemies")]
        ColdPenetrationPctVsChilledEnemies = 5259,
        [Description("Local Display Grants Level X Envy")]
        LocalDisplayGrantsLevelXEnvy = 5260,
        [Description("Cast On Cyclone Contact %")]
        CastOnCycloneContactPct = 5261,
        [Description("Cyclone Has Triggered Skill")]
        CycloneHasTriggeredSkill = 5262,
        [Description("Minions Chance To Poison On Hit %")]
        MinionsChanceToPoisonOnHitPct = 5263,
        [Description("X Armour If You Have Blocked Recently")]
        XArmourIfYouHaveBlockedRecently = 5264,
        [Description("Enemies Explode On Kill")]
        EnemiesExplodeOnKill = 5265,
        [Description("Local Display Attack With Level X Bone Nova On Bleeding Enemy Kill")]
        LocalDisplayAttackWithLevelXBoneNovaOnBleedingEnemyKill = 5266,
        [Description("Attack Trigger On Killing Bleeding Enemy %")]
        AttackTriggerOnKillingBleedingEnemyPct = 5267,
        [Description("Permanently Intimidate Enemy On Block")]
        PermanentlyIntimidateEnemyOnBlock = 5268,
        [Description("Receive Bleeding Chance % When Hit By Attack")]
        ReceiveBleedingChancePctWhenHitByAttack = 5269,
        [Description("Attacks Cause Bleeding Vs Cursed Enemies")]
        AttacksCauseBleedingVsCursedEnemies = 5270,
        [Description("Armour Increased By Uncapped Fire Resistance")]
        ArmourIncreasedByUncappedFireResistance = 5271,
        [Description("Evasion Rating Increased By Uncapped Cold Resistance")]
        EvasionRatingIncreasedByUncappedColdResistance = 5272,
        [Description("Critical Strike Chance Increased By Uncapped Lightning Resistance")]
        CriticalStrikeChanceIncreasedByUncappedLightningResistance = 5273,
        [Description("Combined Critical Strike Chance +%")]
        CombinedCriticalStrikeChancePosPct = 5274,
        [Description("Combined Critical Strike Chance +% Final")]
        CombinedCriticalStrikeChancePosPctFinal = 5275,
        [Description("Totems Cannot Evade")]
        TotemsCannotEvade = 5276,
        [Description("Disable Seek Seal Prophecies")]
        DisableSeekSealProphecies = 5277,
        [Description("Mortar Distance In Front Of Target")]
        MortarDistanceInFrontOfTarget = 5278,
        [Description("Apply Covered In Ash To Attacker When Hit %")]
        ApplyCoveredInAshToAttackerWhenHitPct = 5279,
        [Description("Covered In Ash Movement Speed +% Final")]
        CoveredInAshMovementSpeedPosPctFinal = 5280,
        [Description("Secondary Total Minimum Base Physical Damage")]
        SecondaryTotalMinimumBasePhysicalDamage = 5281,
        [Description("Secondary Total Maximum Base Physical Damage")]
        SecondaryTotalMaximumBasePhysicalDamage = 5282,
        [Description("Minimum Secondary Physical Damage Per 15 Strength")]
        MinimumSecondaryPhysicalDamagePer15Strength = 5283,
        [Description("Maximum Secondary Physical Damage Per 15 Strength")]
        MaximumSecondaryPhysicalDamagePer15Strength = 5284,
        [Description("Flame Geyser Number Of Splits")]
        FlameGeyserNumberOfSplits = 5285,
        [Description("Keystone Avatar Of Fire")]
        KeystoneAvatarOfFire = 5286,
        [Description("Keystone Eldritch Battery")]
        KeystoneEldritchBattery = 5287,
        [Description("Keystone Ancestral Bond")]
        KeystoneAncestralBond = 5288,
        [Description("Skeletal Chains No Minions Damage +% Final")]
        SkeletalChainsNoMinionsDamagePosPctFinal = 5289,
        [Description("Virtual Energy Shield Protects Mana")]
        VirtualEnergyShieldProtectsMana = 5290,
        [Description("Virtual Spend Energy Shield For Costs Before Mana")]
        VirtualSpendEnergyShieldForCostsBeforeMana = 5291,
        [Description("Shock Nova Skill Area Of Effect +% Per Contact Point")]
        ShockNovaSkillAreaOfEffectPosPctPerContactPoint = 5292,
        [Description("Spell Skills Deal No Damage")]
        SpellSkillsDealNoDamage = 5293,
        [Description("Ignite Proliferation Radius")]
        IgniteProliferationRadius = 5294,
        [Description("Base Ignite Proliferation Radius")]
        BaseIgniteProliferationRadius = 5295,
        [Description("Transition Objects At State")]
        TransitionObjectsAtState = 5296,
        [Description("Fire Beam Enemy Fire Resistance % At Max Stacks")]
        FireBeamEnemyFireResistancePctAtMaxStacks = 5297,
        [Description("Attack Damage +1% Per 300 Of Min Of Armour Or Evasion")]
        AttackDamagePos1PctPer300OfMinOfArmourOrEvasion = 5298,
        [Description("Chance To Fortify On Melee Stun %")]
        ChanceToFortifyOnMeleeStunPct = 5299,
        [Description("Gain Onslaught While You Have Fortify")]
        GainOnslaughtWhileYouHaveFortify = 5300,
        [Description("Local Six Linked Random Sockets")]
        LocalSixLinkedRandomSockets = 5301,
        [Description("Local Can Only Socket Corrupted Gems")]
        LocalCanOnlySocketCorruptedGems = 5302,
        [Description("Fire Beam Enemy Fire Resistance % Maximum")]
        FireBeamEnemyFireResistancePctMaximum = 5303,
        [Description("Proximity Shield Ground Lightning Duration Ms")]
        ProximityShieldGroundLightningDurationMs = 5304,
        [Description("Map Player Charges Gained +%")]
        MapPlayerChargesGainedPosPct = 5305,
        [Description("Curse Effect On Self +% Final")]
        CurseEffectOnSelfPosPctFinal = 5306,
        [Description("Map Monsters Curse Effect On Self +% Final")]
        MapMonstersCurseEffectOnSelfPosPctFinal = 5307,
        [Description("Map Monsters % Chance To Inflict Status Ailments")]
        MapMonstersPctChanceToInflictStatusAilments = 5308,
        [Description("Map Monsters Movement Speed Cannot Be Reduced Below Base")]
        MapMonstersMovementSpeedCannotBeReducedBelowBase = 5309,
        [Description("Map Monsters Cannot Be Taunted")]
        MapMonstersCannotBeTaunted = 5310,
        [Description("Map Monsters Always Ignite")]
        MapMonstersAlwaysIgnite = 5311,
        [Description("Map Monsters Additional Chaos Resistance")]
        MapMonstersAdditionalChaosResistance = 5312,
        [Description("Map Monsters Avoid Poison Blind Bleed %")]
        MapMonstersAvoidPoisonBlindBleedPct = 5313,
        [Description("Base Avoid Poison %")]
        BaseAvoidPoisonPct = 5314,
        [Description("Map Players Have Point Blank")]
        MapPlayersHavePointBlank = 5315,
        [Description("Map Players Block Chance +%")]
        MapPlayersBlockChancePosPct = 5316,
        [Description("Map Players Armour +% Final")]
        MapPlayersArmourPosPctFinal = 5317,
        [Description("Map Monsters Accuracy Rating +%")]
        MapMonstersAccuracyRatingPosPct = 5318,
        [Description("Map Players Extra Dodge Rolls")]
        MapPlayersExtraDodgeRolls = 5319,
        [Description("Extra Dodge Rolls")]
        ExtraDodgeRolls = 5320,
        [Description("Map Players Skill Area Of Effect +% Final")]
        MapPlayersSkillAreaOfEffectPosPctFinal = 5321,
        [Description("Cannot Gain Frenzy Charges")]
        CannotGainFrenzyCharges = 5322,
        [Description("Cannot Gain Power Charges")]
        CannotGainPowerCharges = 5323,
        [Description("Map Players Cannot Gain Power Charges")]
        MapPlayersCannotGainPowerCharges = 5324,
        [Description("Map Players Cannot Gain Frenzy Charges")]
        MapPlayersCannotGainFrenzyCharges = 5325,
        [Description("Map Players Cannot Gain Endurance Charges")]
        MapPlayersCannotGainEnduranceCharges = 5326,
        [Description("Map Players No Regeneration Including Es")]
        MapPlayersNoRegenerationIncludingEs = 5327,
        [Description("Map Player Life And Es Recovery Speed +% Final")]
        MapPlayerLifeAndEsRecoverySpeedPosPctFinal = 5328,
        [Description("Armour +% Final")]
        ArmourPosPctFinal = 5329,
        [Description("Map Packs Are Abomination Monsters")]
        MapPacksAreAbominationMonsters = 5330,
        [Description("Gain Frenzy Charge On Hitting Rare Or Unique Enemy %")]
        GainFrenzyChargeOnHittingRareOrUniqueEnemyPct = 5331,
        [Description("Onslaught Duration +%")]
        OnslaughtDurationPosPct = 5332,
        [Description("Curse On Hit Level 10 Vulnerability %")]
        CurseOnHitLevel10VulnerabilityPct = 5333,
        [Description("Local Item Stats Are Doubled In Breach")]
        LocalItemStatsAreDoubledInBreach = 5334,
        [Description("Cast On Crit %")]
        CastOnCritPct = 5335,
        [Description("Local Unique Jewel Cold And Lightning Resistance To Melee Damage")]
        LocalUniqueJewelColdAndLightningResistanceToMeleeDamage = 5336,
        [Description("Local Unique Jewel Fire And Lightning Resistance To Projectile Attack Damage")]
        LocalUniqueJewelFireAndLightningResistanceToProjectileAttackDamage = 5337,
        [Description("Local Unique Jewel Fire And Cold Resistance To Spell Damage")]
        LocalUniqueJewelFireAndColdResistanceToSpellDamage = 5338,
        [Description("Local Unique Jewel Fire Resistance Also Grants Block Chance Scaled %")]
        LocalUniqueJewelFireResistanceAlsoGrantsBlockChanceScaledPct = 5339,
        [Description("Local Unique Jewel Cold Resistance Also Grants Dodge Chance Scaled %")]
        LocalUniqueJewelColdResistanceAlsoGrantsDodgeChanceScaledPct = 5340,
        [Description("Local Unique Jewel Lightning Resistance Also Grants Block Spells Chance Scaled %")]
        LocalUniqueJewelLightningResistanceAlsoGrantsBlockSpellsChanceScaledPct = 5341,
        [Description("Local Unique Jewel Fire Resistance Also Grants Endurance Charge On Kill Chance")]
        LocalUniqueJewelFireResistanceAlsoGrantsEnduranceChargeOnKillChance = 5342,
        [Description("Local Unique Jewel Cold Resistance Also Grants Frenzy Charge On Kill Chance")]
        LocalUniqueJewelColdResistanceAlsoGrantsFrenzyChargeOnKillChance = 5343,
        [Description("Local Unique Jewel Lightning Resistance Also Grants Power Charge On Kill Chance")]
        LocalUniqueJewelLightningResistanceAlsoGrantsPowerChargeOnKillChance = 5344,
        [Description("Cast While Channelling Time Ms")]
        CastWhileChannellingTimeMs = 5345,
        [Description("Support Cast While Channelling Triggered Skill Damage +% Final")]
        SupportCastWhileChannellingTriggeredSkillDamagePosPctFinal = 5346,
        [Description("Number Of Spider Minions Allowed")]
        NumberOfSpiderMinionsAllowed = 5347,
        [Description("Number Of Active Spider Minions")]
        NumberOfActiveSpiderMinions = 5348,
        [Description("Local Display Raise Spider On Kill % Chance")]
        LocalDisplayRaiseSpiderOnKillPctChance = 5349,
        [Description("Local Display Cast Lightning On Critical Strike")]
        LocalDisplayCastLightningOnCriticalStrike = 5350,
        [Description("Your Spells Are Disabled")]
        YourSpellsAreDisabled = 5351,
        [Description("Monster Ruleset Id")]
        MonsterRulesetId = 5352,
        [Description("Map Monsters Additional Elemental Resistance")]
        MapMonstersAdditionalElementalResistance = 5353,
        [Description("Support Minion Totem Resistance Elemental Damage +% Final")]
        SupportMinionTotemResistanceElementalDamagePosPctFinal = 5354,
        [Description("Elemental Damage +% Final On Minion From Resistance Support")]
        ElementalDamagePosPctFinalOnMinionFromResistanceSupport = 5355,
        [Description("Goat Footprints From Item")]
        GoatFootprintsFromItem = 5356,
        [Description("Totem Ignores Cooldown")]
        TotemIgnoresCooldown = 5357,
        [Description("Attack Minimum Added Lightning Damage Per 10 Int")]
        AttackMinimumAddedLightningDamagePer10Int = 5358,
        [Description("Attack Maximum Added Lightning Damage Per 10 Int")]
        AttackMaximumAddedLightningDamagePer10Int = 5359,
        [Description("Fire Damage +% Per 20 Strength")]
        FireDamagePosPctPer20Strength = 5360,
        [Description("Mana Recharge Rate Per Minute With All Corrupted Equipped Items")]
        ManaRechargeRatePerMinuteWithAllCorruptedEquippedItems = 5361,
        [Description("Life Leech Permyriad Vs Poisoned Enemies")]
        LifeLeechPermyriadVsPoisonedEnemies = 5362,
        [Description("Minion Life Leech Permyriad Vs Poisoned Enemies")]
        MinionLifeLeechPermyriadVsPoisonedEnemies = 5363,
        [Description("Display Vaal Breach No Drops Xp")]
        DisplayVaalBreachNoDropsXp = 5364,
        [Description("Golems Larger Aggro Radius")]
        GolemsLargerAggroRadius = 5365,
        [Description("Maximum Life % To Convert To Maximum Energy Shield")]
        MaximumLifePctToConvertToMaximumEnergyShield = 5366,
        [Description("Display Abberaths Hooves Skill Level")]
        DisplayAbberathsHoovesSkillLevel = 5367,
        [Description("Cannot Be Used As Minion")]
        CannotBeUsedAsMinion = 5368,
        [Description("Breach Map Time To Portal Ms")]
        BreachMapTimeToPortalMs = 5369,
        [Description("Breach Map Initial Time Ms")]
        BreachMapInitialTimeMs = 5370,
        [Description("Breach Team Warp Buff Damage Taken +%")]
        BreachTeamWarpBuffDamageTakenPosPct = 5371,
        [Description("Local Poison On Hit %")]
        LocalPoisonOnHitPct = 5372,
        [Description("Main Hand Local Poison On Hit %")]
        MainHandLocalPoisonOnHitPct = 5373,
        [Description("Off Hand Local Poison On Hit %")]
        OffHandLocalPoisonOnHitPct = 5374,
        [Description("Breach Team Warp Buff Movement Velocity +%")]
        BreachTeamWarpBuffMovementVelocityPosPct = 5375,
        [Description("Breach Team Warp Buff Lightning Damage +%")]
        BreachTeamWarpBuffLightningDamagePosPct = 5376,
        [Description("Base Blade Vortex Hit Rate Ms")]
        BaseBladeVortexHitRateMs = 5377,
        [Description("Blade Vortex Hit Rate Ms")]
        BladeVortexHitRateMs = 5378,
        [Description("Additional Maximum All Resistances % With No Endurance Charges")]
        AdditionalMaximumAllResistancesPctWithNoEnduranceCharges = 5379,
        [Description("Spell Damage +% While Shocked")]
        SpellDamagePosPctWhileShocked = 5380,
        [Description("Display Skill Minions Level Is Corpse Level")]
        DisplaySkillMinionsLevelIsCorpseLevel = 5381,
        [Description("Monster Beyond Portal Chance +%")]
        MonsterBeyondPortalChancePosPct = 5382,
        [Description("Life Leech Uses Chaos Damage")]
        LifeLeechUsesChaosDamage = 5383,
        [Description("Base Cannot Gain Endurance Charges")]
        BaseCannotGainEnduranceCharges = 5384,
        [Description("Gain Onslaught While At Maximum Endurance Charges")]
        GainOnslaughtWhileAtMaximumEnduranceCharges = 5385,
        [Description("Number Of Zombies Allowed +1 Per X Strength")]
        NumberOfZombiesAllowedPos1PerXStrength = 5386,
        [Description("Minions Gain Your Strength")]
        MinionsGainYourStrength = 5387,
        [Description("Avarius Cast On Charge Contact")]
        AvariusCastOnChargeContact = 5388,
        [Description("Zombie Damage Leeched As Life To You Permyriad If Over 1000 Strength")]
        ZombieDamageLeechedAsLifeToYouPermyriadIfOver1000Strength = 5389,
        [Description("Virtual Minion Additional Strength")]
        VirtualMinionAdditionalStrength = 5390,
        [Description("Virtual Zombie Damage Leeched As Life To You Permyriad")]
        VirtualZombieDamageLeechedAsLifeToYouPermyriad = 5391,
        [Description("Base Bleed Duration +%")]
        BaseBleedDurationPosPct = 5392,
        [Description("Item Found Rarity +1% Per X Rampage Stacks")]
        ItemFoundRarityPos1PctPerXRampageStacks = 5393,
        [Description("Is Channelling")]
        IsChannelling = 5394,
        [Description("Warcries Knock Back Enemies")]
        WarcriesKnockBackEnemies = 5395,
        [Description("Map Monsters No Drops Or Experience")]
        MapMonstersNoDropsOrExperience = 5396,
        [Description("Off Hand Minimum Added Physical Damage Per 15 Shield Armour And Evasion Rating")]
        OffHandMinimumAddedPhysicalDamagePer15ShieldArmourAndEvasionRating = 5397,
        [Description("Off Hand Maximum Added Physical Damage Per 15 Shield Armour And Evasion Rating")]
        OffHandMaximumAddedPhysicalDamagePer15ShieldArmourAndEvasionRating = 5398,
        [Description("Off Hand Minimum Added Physical Damage Per 5 Shield Armour")]
        OffHandMinimumAddedPhysicalDamagePer5ShieldArmour = 5399,
        [Description("Off Hand Maximum Added Physical Damage Per 5 Shield Armour")]
        OffHandMaximumAddedPhysicalDamagePer5ShieldArmour = 5400,
        [Description("Off Hand Minimum Added Physical Damage Per 5 Shield Evasion Rating")]
        OffHandMinimumAddedPhysicalDamagePer5ShieldEvasionRating = 5401,
        [Description("Off Hand Maximum Added Physical Damage Per 5 Shield Evasion Rating")]
        OffHandMaximumAddedPhysicalDamagePer5ShieldEvasionRating = 5402,
        [Description("Gain Vaal Soul On Hit Cooldown Ms")]
        GainVaalSoulOnHitCooldownMs = 5403,
        [Description("Unique Spells Triggered On Shocked Kill")]
        UniqueSpellsTriggeredOnShockedKill = 5404,
        [Description("Maximum Life Per 2% Increased Item Found Rarity")]
        MaximumLifePer2PctIncreasedItemFoundRarity = 5405,
        [Description("Damage +% Per 1% Increased Item Found Quantity")]
        DamagePosPctPer1PctIncreasedItemFoundQuantity = 5406,
        [Description("Item Found Quantity +% Per Chest Opened Recently")]
        ItemFoundQuantityPosPctPerChestOpenedRecently = 5407,
        [Description("Number Of Chests Opened Recently")]
        NumberOfChestsOpenedRecently = 5408,
        [Description("Track Number Of Chests Opened Recently")]
        TrackNumberOfChestsOpenedRecently = 5409,
        [Description("Movement Speed +% Per Chest Opened Recently")]
        MovementSpeedPosPctPerChestOpenedRecently = 5410,
        [Description("Immune To Burning Shocks And Chilled Ground")]
        ImmuneToBurningShocksAndChilledGround = 5411,
        [Description("Maximum Life Per 10 Dexterity")]
        MaximumLifePer10Dexterity = 5412,
        [Description("Life Regeneration Per Minute While Moving")]
        LifeRegenerationPerMinuteWhileMoving = 5413,
        [Description("Chest Number Of Additional Pirate Uniques To Drop")]
        ChestNumberOfAdditionalPirateUniquesToDrop = 5414,
        [Description("Shrapnel Shot Number Of Additional Cones")]
        ShrapnelShotNumberOfAdditionalCones = 5415,
        [Description("Local Unique Jewel Shrapnel Shot Number Of Additional Cones With 50 Dex In Radius")]
        LocalUniqueJewelShrapnelShotNumberOfAdditionalConesWith50DexInRadius = 5416,
        [Description("Burning Arrow Additional Ignite Stacks")]
        BurningArrowAdditionalIgniteStacks = 5417,
        [Description("Local Unique Jewel Burning Arrow Additional Ignite Stacks With 50 Dex In Radius")]
        LocalUniqueJewelBurningArrowAdditionalIgniteStacksWith50DexInRadius = 5418,
        [Description("Cleave Fortify On Hit")]
        CleaveFortifyOnHit = 5419,
        [Description("Local Unique Jewel Cleave Fortify On Hit With 50 Str In Radius")]
        LocalUniqueJewelCleaveFortifyOnHitWith50StrInRadius = 5420,
        [Description("Cleave Skill Area Of Effect +% Per Nearby Enemy")]
        CleaveSkillAreaOfEffectPosPctPerNearbyEnemy = 5421,
        [Description("Local Unique Jewel Cleave Skill Area Of Effect +% Per Nearby Enemy With 50 Str In Radius")]
        LocalUniqueJewelCleaveSkillAreaOfEffectPosPctPerNearbyEnemyWith50StrInRadius = 5422,
        [Description("Freezing Pulse Number Of Additional Projectiles")]
        FreezingPulseNumberOfAdditionalProjectiles = 5423,
        [Description("Local Unique Jewel Freezing Pulse Number Of Additional Projectiles With 50 Int In Radius")]
        LocalUniqueJewelFreezingPulseNumberOfAdditionalProjectilesWith50IntInRadius = 5424,
        [Description("Freezing Pulse Damage +% If Enemy Shattered Recently")]
        FreezingPulseDamagePosPctIfEnemyShatteredRecently = 5425,
        [Description("Local Unique Jewel Freezing Pulse Damage +% If Enemy Shattered Recently With 50 Int In Radius")]
        LocalUniqueJewelFreezingPulseDamagePosPctIfEnemyShatteredRecentlyWith50IntInRadius = 5426,
        [Description("Local Unique Jewel Ice Shot Explosion Skill Area Of Effect +% With 50 Dex In Radius")]
        LocalUniqueJewelIceShotExplosionSkillAreaOfEffectPosPctWith50DexInRadius = 5427,
        [Description("Ice Shot Damage +% To Chilled Enemies")]
        IceShotDamagePosPctToChilledEnemies = 5428,
        [Description("Local Unique Jewel Ice Shot Damage +% To Chilled Enemies With 50 Dex In Radius")]
        LocalUniqueJewelIceShotDamagePosPctToChilledEnemiesWith50DexInRadius = 5429,
        [Description("Local Unique Jewel Molten Strike Number Of Additional Projectiles With 50 Str In Radius")]
        LocalUniqueJewelMoltenStrikeNumberOfAdditionalProjectilesWith50StrInRadius = 5430,
        [Description("Local Unique Jewel Molten Strike Skill Area Of Effect +% With 50 Str In Radius")]
        LocalUniqueJewelMoltenStrikeSkillAreaOfEffectPosPctWith50StrInRadius = 5431,
        [Description("Frost Blades Melee Cold Damage +% Per Frenzy Charge")]
        FrostBladesMeleeColdDamagePosPctPerFrenzyCharge = 5432,
        [Description("Local Unique Jewel Frost Blades Melee Cold Damage +% Per Frenzy Charge With 50 Dex In Radius")]
        LocalUniqueJewelFrostBladesMeleeColdDamagePosPctPerFrenzyChargeWith50DexInRadius = 5433,
        [Description("Dual Strike Melee Splash With Off Hand Weapon")]
        DualStrikeMeleeSplashWithOffHandWeapon = 5434,
        [Description("Local Unique Jewel Dual Strike Melee Splash With Off Hand Weapon With 50 Dex In Radius")]
        LocalUniqueJewelDualStrikeMeleeSplashWithOffHandWeaponWith50DexInRadius = 5435,
        [Description("Frostbolt Projectile Acceleration")]
        FrostboltProjectileAcceleration = 5436,
        [Description("Local Unique Jewel Frostbolt Projectile Acceleration With 50 Int In Radius")]
        LocalUniqueJewelFrostboltProjectileAccelerationWith50IntInRadius = 5437,
        [Description("Ethereal Knives Projectiles Nova")]
        EtherealKnivesProjectilesNova = 5438,
        [Description("Local Unique Jewel Ethereal Knives Projectiles Nova With 50 Dex In Radius")]
        LocalUniqueJewelEtherealKnivesProjectilesNovaWith50DexInRadius = 5439,
        [Description("Ethereal Knives Number Of Additional Projectiles")]
        EtherealKnivesNumberOfAdditionalProjectiles = 5440,
        [Description("Local Unique Jewel Ethereal Knives Number Of Additional Projectiles With 50 Dex In Radius")]
        LocalUniqueJewelEtherealKnivesNumberOfAdditionalProjectilesWith50DexInRadius = 5441,
        [Description("Ethereal Knives Projectile Speed +% Per Frenzy Charge")]
        EtherealKnivesProjectileSpeedPosPctPerFrenzyCharge = 5442,
        [Description("Local Unique Jewel Ethereal Knives Projectile Speed +% Per Frenzy Charge With 50 Dex In Radius")]
        LocalUniqueJewelEtherealKnivesProjectileSpeedPosPctPerFrenzyChargeWith50DexInRadius = 5443,
        [Description("Ethereal Knives Grant Frenzy Charge On Kill")]
        EtherealKnivesGrantFrenzyChargeOnKill = 5444,
        [Description("Local Unique Jewel Ethereal Knives Grant Frenzy Charge On Kill With 50 Dex In Radius")]
        LocalUniqueJewelEtherealKnivesGrantFrenzyChargeOnKillWith50DexInRadius = 5445,
        [Description("Lightning Tendrils Skill Area Of Effect +% Per Enemy Hit")]
        LightningTendrilsSkillAreaOfEffectPosPctPerEnemyHit = 5446,
        [Description("Local Unique Jewel Lightning Tendrils Skill Area Of Effect +% Per Enemy Hit With 50 Int In Radius")]
        LocalUniqueJewelLightningTendrilsSkillAreaOfEffectPosPctPerEnemyHitWith50IntInRadius = 5447,
        [Description("Magma Orb Skill Area Of Effect +% Per Bounce")]
        MagmaOrbSkillAreaOfEffectPosPctPerBounce = 5448,
        [Description("Local Unique Jewel Magma Orb Skill Area Of Effect +% Per Bounce With 50 Int In Radius")]
        LocalUniqueJewelMagmaOrbSkillAreaOfEffectPosPctPerBounceWith50IntInRadius = 5449,
        [Description("Glacial Hammer Melee Splash With Cold Damage")]
        GlacialHammerMeleeSplashWithColdDamage = 5450,
        [Description("Local Unique Jewel Glacial Hammer Melee Splash With Cold Damage With 50 Str In Radius")]
        LocalUniqueJewelGlacialHammerMeleeSplashWithColdDamageWith50StrInRadius = 5451,
        [Description("Glacial Hammer Physical Damage % To Convert To Cold")]
        GlacialHammerPhysicalDamagePctToConvertToCold = 5452,
        [Description("Local Unique Jewel Glacial Hammer Physical Damage % To Convert To Cold With 50 Str In Radius")]
        LocalUniqueJewelGlacialHammerPhysicalDamagePctToConvertToColdWith50StrInRadius = 5453,
        [Description("Blight Skill Area Of Effect +% After 1 Second Channelling")]
        BlightSkillAreaOfEffectPosPctAfter1SecondChannelling = 5454,
        [Description("Local Unique Jewel Blight Skill Area Of Effect +% After 1 Second Channelling With 50 Int In Radius")]
        LocalUniqueJewelBlightSkillAreaOfEffectPosPctAfter1SecondChannellingWith50IntInRadius = 5455,
        [Description("Fortify On Hit")]
        FortifyOnHit = 5456,
        [Description("Melee Splash Cold Damage Only")]
        MeleeSplashColdDamageOnly = 5457,
        [Description("Track Have Shattered Recently")]
        TrackHaveShatteredRecently = 5458,
        [Description("Have Shattered Recently")]
        HaveShatteredRecently = 5459,
        [Description("Can Gain Vaal Souls From No Experience Monsters")]
        CanGainVaalSoulsFromNoExperienceMonsters = 5460,
        [Description("Maim On Hit %")]
        MaimOnHitPct = 5461,
        [Description("Total Skill Area Of Effect Radius +% Including Final")]
        TotalSkillAreaOfEffectRadiusPosPctIncludingFinal = 5462,
        [Description("Melee Splash Off Hand Only")]
        MeleeSplashOffHandOnly = 5463,
        [Description("Classic Remaining Areas To Apply Leaguestone")]
        ClassicRemainingAreasToApplyLeaguestone = 5464,
        [Description("Map Spawn Leaguestones")]
        MapSpawnLeaguestones = 5465,
        [Description("Monster Can Spawn With Leaguestone")]
        MonsterCanSpawnWithLeaguestone = 5466,
        [Description("Monster No Leaguestone")]
        MonsterNoLeaguestone = 5467,
        [Description("Local Unique Jewel Shrapnel Shot Cone % Chance To Deal Double Damage With 50 Dex In Radius")]
        LocalUniqueJewelShrapnelShotConePctChanceToDealDoubleDamageWith50DexInRadius = 5468,
        [Description("Shrapnel Shot Cone % Chance To Deal Double Damage")]
        ShrapnelShotConePctChanceToDealDoubleDamage = 5469,
        [Description("Local Unique Jewel Shrapnel Shot Radius +% With 50 Dex In Radius")]
        LocalUniqueJewelShrapnelShotRadiusPosPctWith50DexInRadius = 5470,
        [Description("Endurance Charge On Kill Percent Chance While Holding Shield")]
        EnduranceChargeOnKillPercentChanceWhileHoldingShield = 5471,
        [Description("Frenzy Charge On Kill Percent Chance While Holding Shield")]
        FrenzyChargeOnKillPercentChanceWhileHoldingShield = 5472,
        [Description("Power Charge On Kill Percent Chance While Holding Shield")]
        PowerChargeOnKillPercentChanceWhileHoldingShield = 5473,
        [Description("Block Chance % While Holding Shield")]
        BlockChancePctWhileHoldingShield = 5474,
        [Description("Dodge Chance % While Holding Shield")]
        DodgeChancePctWhileHoldingShield = 5475,
        [Description("Block Spells Chance % While Holding Shield")]
        BlockSpellsChancePctWhileHoldingShield = 5476,
        [Description("Local Unique Flask Elemental Damage Taken +% Of Lowest Uncapped Resistance Type")]
        LocalUniqueFlaskElementalDamageTakenPosPctOfLowestUncappedResistanceType = 5477,
        [Description("Local Unique Flask Elemental Penetration % Of Highest Uncapped Resistance Type")]
        LocalUniqueFlaskElementalPenetrationPctOfHighestUncappedResistanceType = 5478,
        [Description("Elemental Damage Taken +% Of Lowest Uncapped Resistance Type")]
        ElementalDamageTakenPosPctOfLowestUncappedResistanceType = 5479,
        [Description("Elemental Penetration % Of Highest Uncapped Resistance Type")]
        ElementalPenetrationPctOfHighestUncappedResistanceType = 5480,
        [Description("Virtual Fire Damage Taken +% From Lowest Uncapped Resistance Type")]
        VirtualFireDamageTakenPosPctFromLowestUncappedResistanceType = 5481,
        [Description("Virtual Cold Damage Taken +% From Lowest Uncapped Resistance Type")]
        VirtualColdDamageTakenPosPctFromLowestUncappedResistanceType = 5482,
        [Description("Virtual Lightning Damage Taken +% From Lowest Uncapped Resistance Type")]
        VirtualLightningDamageTakenPosPctFromLowestUncappedResistanceType = 5483,
        [Description("Virtual Fire Penetration % From Highest Uncapped Resistance Type")]
        VirtualFirePenetrationPctFromHighestUncappedResistanceType = 5484,
        [Description("Virtual Cold Penetration % From Highest Uncapped Resistance Type")]
        VirtualColdPenetrationPctFromHighestUncappedResistanceType = 5485,
        [Description("Virtual Lightning Penetration % From Highest Uncapped Resistance Type")]
        VirtualLightningPenetrationPctFromHighestUncappedResistanceType = 5486,
        [Description("Start At Zero Energy Shield")]
        StartAtZeroEnergyShield = 5487,
        [Description("Map Number Of Additional Silver Coin Drops")]
        MapNumberOfAdditionalSilverCoinDrops = 5488,
        [Description("Map Monsters That Drop Silver Coin Drop X Additional Silver Coins")]
        MapMonstersThatDropSilverCoinDropXAdditionalSilverCoins = 5489,
        [Description("Map Item Quantity From Monsters That Drop Silver Coin +%")]
        MapItemQuantityFromMonstersThatDropSilverCoinPosPct = 5490,
        [Description("Local Unique Jewel Spark Number Of Additional Projectiles With 50 Int In Radius")]
        LocalUniqueJewelSparkNumberOfAdditionalProjectilesWith50IntInRadius = 5491,
        [Description("Spark Num Of Additional Projectiles In Chain")]
        SparkNumOfAdditionalProjectilesInChain = 5492,
        [Description("Local Unique Jewel Spark Number Of Additional Chains With 50 Int In Radius")]
        LocalUniqueJewelSparkNumberOfAdditionalChainsWith50IntInRadius = 5493,
        [Description("Monster Slam Cooldown Speed +%")]
        MonsterSlamCooldownSpeedPosPct = 5494,
        [Description("Zombie Slam Cooldown Speed +%")]
        ZombieSlamCooldownSpeedPosPct = 5495,
        [Description("Local Unique Jewel Zombie Slam Cooldown Speed +% With 50 Int In Radius")]
        LocalUniqueJewelZombieSlamCooldownSpeedPosPctWith50IntInRadius = 5496,
        [Description("Monster Slam Damage +%")]
        MonsterSlamDamagePosPct = 5497,
        [Description("Zombie Slam Damage +%")]
        ZombieSlamDamagePosPct = 5498,
        [Description("Local Unique Jewel Zombie Slam Damage +% With 50 Int In Radius")]
        LocalUniqueJewelZombieSlamDamagePosPctWith50IntInRadius = 5499,
        [Description("Map Leaguestone Override Base Num Rogue Exiles")]
        MapLeaguestoneOverrideBaseNumRogueExiles = 5500,
        [Description("Map Rogue Exiles Are Doubled")]
        MapRogueExilesAreDoubled = 5501,
        [Description("Map Rogue Exile Drop Skill Gem With Quality")]
        MapRogueExileDropSkillGemWithQuality = 5502,
        [Description("Map Rogue Exile Attack Cast And Movement Speed +%")]
        MapRogueExileAttackCastAndMovementSpeedPosPct = 5503,
        [Description("Map Leaguestone Rogue Exiles Dropped Item Rarity +% Final")]
        MapLeaguestoneRogueExilesDroppedItemRarityPosPctFinal = 5504,
        [Description("Monster Drop Skill Gem With Quality")]
        MonsterDropSkillGemWithQuality = 5505,
        [Description("Map Leaguestone Override Base Num Breaches")]
        MapLeaguestoneOverrideBaseNumBreaches = 5506,
        [Description("Map Contains Additional Breaches")]
        MapContainsAdditionalBreaches = 5507,
        [Description("Map Rare Breach Monsters Drop Additional Shards")]
        MapRareBreachMonstersDropAdditionalShards = 5508,
        [Description("Map Breach Has Boss")]
        MapBreachHasBoss = 5509,
        [Description("Map Breach Has Large Chest")]
        MapBreachHasLargeChest = 5510,
        [Description("Map Breach Monster Quantity +%")]
        MapBreachMonsterQuantityPosPct = 5511,
        [Description("Map Leaguestone Override Base Num Monoliths")]
        MapLeaguestoneOverrideBaseNumMonoliths = 5512,
        [Description("Map Essence Monsters Have Additional Essences")]
        MapEssenceMonstersHaveAdditionalEssences = 5513,
        [Description("Map Essence Monsters Are Corrupted")]
        MapEssenceMonstersAreCorrupted = 5514,
        [Description("Map Essence Monsters Higher Tier")]
        MapEssenceMonstersHigherTier = 5515,
        [Description("Fire Beam Rotation Speed +%")]
        FireBeamRotationSpeedPosPct = 5516,
        [Description("Fire Beam Charge Up Time Ms")]
        FireBeamChargeUpTimeMs = 5517,
        [Description("Map Leaguestone Override Base Num Talismans")]
        MapLeaguestoneOverrideBaseNumTalismans = 5518,
        [Description("Map Talismans Higher Tier")]
        MapTalismansHigherTier = 5519,
        [Description("Map Talismans Dropped As Rare")]
        MapTalismansDroppedAsRare = 5520,
        [Description("Map Contains Talisman Boss With Higher Tier")]
        MapContainsTalismanBossWithHigherTier = 5521,
        [Description("Virtual Fire Damage Taken +%")]
        VirtualFireDamageTakenPosPct = 5522,
        [Description("Virtual Chaos Damage Taken +%")]
        VirtualChaosDamageTakenPosPct = 5523,
        [Description("Virtual Lightning Damage Taken +%")]
        VirtualLightningDamageTakenPosPct = 5524,
        [Description("Virtual Cold Damage Taken +%")]
        VirtualColdDamageTakenPosPct = 5525,
        [Description("Local Display Socketed Gems Supported By Level X Endurance Charge On Stun")]
        LocalDisplaySocketedGemsSupportedByLevelXEnduranceChargeOnStun = 5526,
        [Description("Number Of Generic Limited Minions Allowed")]
        NumberOfGenericLimitedMinionsAllowed = 5527,
        [Description("Number Of Active Generic Limited Minions")]
        NumberOfActiveGenericLimitedMinions = 5528,
        [Description("Local Unique Jewel Viper Strike Chance To Gain Unholy Might % On Hit Per Poison Stack On Enemy With 50 Dex In Radius")]
        LocalUniqueJewelViperStrikeChanceToGainUnholyMightPctOnHitPerPoisonStackOnEnemyWith50DexInRadius = 5529,
        [Description("Local Unique Jewel Ground Slam Chance To Gain Endurance Charge % On Stun With 50 Str In Radius")]
        LocalUniqueJewelGroundSlamChanceToGainEnduranceChargePctOnStunWith50StrInRadius = 5530,
        [Description("Viper Strike Chance To Gain Unholy Might % On Hit Per Poison Stack On Enemy")]
        ViperStrikeChanceToGainUnholyMightPctOnHitPerPoisonStackOnEnemy = 5531,
        [Description("Ground Slam Chance To Gain Endurance Charge % On Stun")]
        GroundSlamChanceToGainEnduranceChargePctOnStun = 5532,
        [Description("Classic Next Area Contains Talisman")]
        ClassicNextAreaContainsTalisman = 5533,
        [Description("Classic Next Area Contains Anarchy")]
        ClassicNextAreaContainsAnarchy = 5534,
        [Description("Map Area Contains Avatar Of Prophecy")]
        MapAreaContainsAvatarOfProphecy = 5535,
        [Description("Map Area Contains Avatar Of Breach")]
        MapAreaContainsAvatarOfBreach = 5536,
        [Description("Map Area Contains Avatar Of Essence")]
        MapAreaContainsAvatarOfEssence = 5537,
        [Description("Map Area Contains Avatar Of Perandus")]
        MapAreaContainsAvatarOfPerandus = 5538,
        [Description("Map Area Contains Avatar Of Anarchy")]
        MapAreaContainsAvatarOfAnarchy = 5539,
        [Description("Map Area Contains Avatar Of Talisman")]
        MapAreaContainsAvatarOfTalisman = 5540,
        [Description("Map Area Contains Avatar Of Tempest")]
        MapAreaContainsAvatarOfTempest = 5541,
        [Description("Map Random Area Prophecy")]
        MapRandomAreaProphecy = 5542,
        [Description("Map Contains Nevalis Monkey")]
        MapContainsNevalisMonkey = 5543,
        [Description("Armour +% While No Energy Shield")]
        ArmourPosPctWhileNoEnergyShield = 5544,
        [Description("Life Leech From Attack Damage Permyriad Vs Taunted Enemies")]
        LifeLeechFromAttackDamagePermyriadVsTauntedEnemies = 5545,
        [Description("Random Curse On Hit % Against Uncursed Enemies")]
        RandomCurseOnHitPctAgainstUncursedEnemies = 5546,
        [Description("Mana Leech From Attack Damage Permyriad Per Power Charge")]
        ManaLeechFromAttackDamagePermyriadPerPowerCharge = 5547,
        [Description("Virtual Life Leech From Attack Damage Permyriad")]
        VirtualLifeLeechFromAttackDamagePermyriad = 5548,
        [Description("Virtual Mana Leech From Attack Damage Permyriad")]
        VirtualManaLeechFromAttackDamagePermyriad = 5549,
        [Description("Gain X Life On Stun")]
        GainXLifeOnStun = 5550,
        [Description("Blood Offering % Of Life To Lose")]
        BloodOfferingPctOfLifeToLose = 5551,
        [Description("Blood Offering % Of Lost Life To Regenerate As Life Per Second")]
        BloodOfferingPctOfLostLifeToRegenerateAsLifePerSecond = 5552,
        [Description("Blood Offering Life Regenerated +% Final Per Corpse")]
        BloodOfferingLifeRegeneratedPosPctFinalPerCorpse = 5553,
        [Description("Damage +% Vs Chilled Enemies")]
        DamagePosPctVsChilledEnemies = 5554,
        [Description("Additional Block % While On Consecrated Ground")]
        AdditionalBlockPctWhileOnConsecratedGround = 5555,
        [Description("Warcry Buff Effect +%")]
        WarcryBuffEffectPosPct = 5556,
        [Description("Spell And Attack Minimum Added Fire Damage")]
        SpellAndAttackMinimumAddedFireDamage = 5557,
        [Description("Spell And Attack Maximum Added Fire Damage")]
        SpellAndAttackMaximumAddedFireDamage = 5558,
        [Description("Resist All Elements % With 200 Or More Strength")]
        ResistAllElementsPctWith200OrMoreStrength = 5559,
        [Description("Spell Block % If Blocked An Attack Recently")]
        SpellBlockPctIfBlockedAnAttackRecently = 5560,
        [Description("Track Have Blocked Spell Recently")]
        TrackHaveBlockedSpellRecently = 5561,
        [Description("Have Blocked Spell Recently")]
        HaveBlockedSpellRecently = 5562,
        [Description("Attack Block % If Blocked A Spell Recently")]
        AttackBlockPctIfBlockedASpellRecently = 5563,
        [Description("Life Regeneration Rate Per Minute % If Have Been Hit Recently")]
        LifeRegenerationRatePerMinutePctIfHaveBeenHitRecently = 5564,
        [Description("Life Regeneration Rate Per Minute % With 400 Or More Strength")]
        LifeRegenerationRatePerMinutePctWith400OrMoreStrength = 5565,
        [Description("Ground Tar When Hit % Chance")]
        GroundTarWhenHitPctChance = 5566,
        [Description("Spell And Attack Minimum Added Chaos Damage During Flask Effect")]
        SpellAndAttackMinimumAddedChaosDamageDuringFlaskEffect = 5567,
        [Description("Spell And Attack Maximum Added Chaos Damage During Flask Effect")]
        SpellAndAttackMaximumAddedChaosDamageDuringFlaskEffect = 5568,
        [Description("Fire Damage +% If You Have Been Hit Recently")]
        FireDamagePosPctIfYouHaveBeenHitRecently = 5569,
        [Description("Immune To Freeze And Chill While Ignited")]
        ImmuneToFreezeAndChillWhileIgnited = 5570,
        [Description("Fire Penetration % If You Have Blocked Recently")]
        FirePenetrationPctIfYouHaveBlockedRecently = 5571,
        [Description("Local Display Grants Level X Vengeance")]
        LocalDisplayGrantsLevelXVengeance = 5572,
        [Description("Gain X Power Charges On Using A Warcry")]
        GainXPowerChargesOnUsingAWarcry = 5573,
        [Description("Gain Onslaught Ms On Using A Warcry")]
        GainOnslaughtMsOnUsingAWarcry = 5574,
        [Description("Local Display Socketed Golem Buff Effect +%")]
        LocalDisplaySocketedGolemBuffEffectPosPct = 5575,
        [Description("Local Display Socketed Golem Chance To Taunt %")]
        LocalDisplaySocketedGolemChanceToTauntPct = 5576,
        [Description("Local Display Socketed Golem Life Regeneration Rate Per Minute %")]
        LocalDisplaySocketedGolemLifeRegenerationRatePerMinutePct = 5577,
        [Description("Minimum Added Cold Damage Vs Chilled Enemies")]
        MinimumAddedColdDamageVsChilledEnemies = 5578,
        [Description("Maximum Added Cold Damage Vs Chilled Enemies")]
        MaximumAddedColdDamageVsChilledEnemies = 5579,
        [Description("Map Area Contains Avatar Of Rampage")]
        MapAreaContainsAvatarOfRampage = 5580,
        [Description("Map Area Contains Avatar Of Beyond")]
        MapAreaContainsAvatarOfBeyond = 5581,
        [Description("Map Area Contains Avatar Of Onslaught")]
        MapAreaContainsAvatarOfOnslaught = 5582,
        [Description("Map Area Contains Avatar Of Ambush")]
        MapAreaContainsAvatarOfAmbush = 5583,
        [Description("Map Area Contains Avatar Of Bloodlines")]
        MapAreaContainsAvatarOfBloodlines = 5584,
        [Description("Map Area Contains Avatar Of Nemesis")]
        MapAreaContainsAvatarOfNemesis = 5585,
        [Description("Map Area Contains Avatar Of Torment")]
        MapAreaContainsAvatarOfTorment = 5586,
        [Description("Map Area Contains Avatar Of Domination")]
        MapAreaContainsAvatarOfDomination = 5587,
        [Description("Map Area Contains Avatar Of Invasion")]
        MapAreaContainsAvatarOfInvasion = 5588,
        [Description("Map Area Contains Avatar Of Warbands")]
        MapAreaContainsAvatarOfWarbands = 5589,
        [Description("Avoid Freeze And Chill % If You Have Used A Fire Skill Recently")]
        AvoidFreezeAndChillPctIfYouHaveUsedAFireSkillRecently = 5590,
        [Description("Track Have Used A Fire Skill Recently")]
        TrackHaveUsedAFireSkillRecently = 5591,
        [Description("Have Used A Fire Skill Recently")]
        HaveUsedAFireSkillRecently = 5592,
        [Description("Avoid Shock % While Chilled")]
        AvoidShockPctWhileChilled = 5593,
        [Description("Local Display Nearby Enemies Are Intimidated")]
        LocalDisplayNearbyEnemiesAreIntimidated = 5594,
        [Description("Chance To Shock Chilled Enemies %")]
        ChanceToShockChilledEnemiesPct = 5595,
        [Description("Map Area Contains Map Chest")]
        MapAreaContainsMapChest = 5596,
        [Description("Map Area Contains Unique Item Chest")]
        MapAreaContainsUniqueItemChest = 5597,
        [Description("Map Area Contains Currency Chest")]
        MapAreaContainsCurrencyChest = 5598,
        [Description("Map Area Contains Perandus Coin Chest")]
        MapAreaContainsPerandusCoinChest = 5599,
        [Description("Map Area Contains Jewellery Chest")]
        MapAreaContainsJewelleryChest = 5600,
        [Description("Perandus Double Number Of Coins Found")]
        PerandusDoubleNumberOfCoinsFound = 5601,
        [Description("Local Chill On Hit Ms If In Off Hand")]
        LocalChillOnHitMsIfInOffHand = 5602,
        [Description("Off Hand Local Chill On Hit Ms")]
        OffHandLocalChillOnHitMs = 5603,
        [Description("Movement Speed +% On Throwing Trap")]
        MovementSpeedPosPctOnThrowingTrap = 5604,
        [Description("Herald Of Thunder Buff Effect +%")]
        HeraldOfThunderBuffEffectPosPct = 5605,
        [Description("Local Display Movement Speed +% For You And Nearby Allies")]
        LocalDisplayMovementSpeedPosPctForYouAndNearbyAllies = 5606,
        [Description("Curse On Hit Level Flammability")]
        CurseOnHitLevelFlammability = 5607,
        [Description("Phasing On Trap Triggered By An Enemy Ms")]
        PhasingOnTrapTriggeredByAnEnemyMs = 5608,
        [Description("Global Attack Speed +% Per Level")]
        GlobalAttackSpeedPosPctPerLevel = 5609,
        [Description("Physical Damage +% Final For Minion")]
        PhysicalDamagePosPctFinalForMinion = 5610,
        [Description("Zombie Physical Damage +% Final")]
        ZombiePhysicalDamagePosPctFinal = 5611,
        [Description("Ground Tar When Hit Base Area Of Effect Radius")]
        GroundTarWhenHitBaseAreaOfEffectRadius = 5612,
        [Description("Ground Tar When Hit Duration Ms")]
        GroundTarWhenHitDurationMs = 5613,
        [Description("Ground Tar When Hit Movement Speed +%")]
        GroundTarWhenHitMovementSpeedPosPct = 5614,
        [Description("Chance To Gain Unholy Might On Block Ms")]
        ChanceToGainUnholyMightOnBlockMs = 5615,
        [Description("Old Dagger Implicit Critical Strike Chance +30%")]
        OldDaggerImplicitCriticalStrikeChancePos30Pct = 5616,
        [Description("Old Dagger Implicit Critical Strike Chance +40%")]
        OldDaggerImplicitCriticalStrikeChancePos40Pct = 5617,
        [Description("Old Dagger Implicit Critical Strike Chance +50%")]
        OldDaggerImplicitCriticalStrikeChancePos50Pct = 5618,
        [Description("Old Dagger Implicit Critical Strike Chance +30% From Main Hand")]
        OldDaggerImplicitCriticalStrikeChancePos30PctFromMainHand = 5619,
        [Description("Old Dagger Implicit Critical Strike Chance +40% From Main Hand")]
        OldDaggerImplicitCriticalStrikeChancePos40PctFromMainHand = 5620,
        [Description("Old Dagger Implicit Critical Strike Chance +50% From Main Hand")]
        OldDaggerImplicitCriticalStrikeChancePos50PctFromMainHand = 5621,
        [Description("Old Dagger Implicit Critical Strike Chance +30% From Off Hand")]
        OldDaggerImplicitCriticalStrikeChancePos30PctFromOffHand = 5622,
        [Description("Old Dagger Implicit Critical Strike Chance +40% From Off Hand")]
        OldDaggerImplicitCriticalStrikeChancePos40PctFromOffHand = 5623,
        [Description("Old Dagger Implicit Critical Strike Chance +50% From Off Hand")]
        OldDaggerImplicitCriticalStrikeChancePos50PctFromOffHand = 5624,
        [Description("Has Defender Conditional Damage Stats")]
        HasDefenderConditionalDamageStats = 5625,
        [Description("Area Transition Animation Index")]
        AreaTransitionAnimationIndex = 5626,
        [Description("Map Leaguestone Override Base Num Tormented Spirits")]
        MapLeaguestoneOverrideBaseNumTormentedSpirits = 5627,
        [Description("Map Leaguestone Additional Tormented Spirits")]
        MapLeaguestoneAdditionalTormentedSpirits = 5628,
        [Description("Map Random Unique Monster Is Possessed")]
        MapRandomUniqueMonsterIsPossessed = 5629,
        [Description("Map Tormented Spirits Drop X Additional Rare Items")]
        MapTormentedSpiritsDropXAdditionalRareItems = 5630,
        [Description("Map Area Contains Tormented Vaal Cultist")]
        MapAreaContainsTormentedVaalCultist = 5631,
        [Description("Map Area Contains Tormented Seditionist")]
        MapAreaContainsTormentedSeditionist = 5632,
        [Description("Map Area Contains Tormented Embezzler")]
        MapAreaContainsTormentedEmbezzler = 5633,
        [Description("Map Leaguestone Override Base Num Perandus Chests")]
        MapLeaguestoneOverrideBaseNumPerandusChests = 5634,
        [Description("Display Monster Uses Vaal Burning Arrow")]
        DisplayMonsterUsesVaalBurningArrow = 5635,
        [Description("Remove Parent Life On Death Permyriad")]
        RemoveParentLifeOnDeathPermyriad = 5636,
        [Description("Curse On Hit Level Projectile Weakness")]
        CurseOnHitLevelProjectileWeakness = 5637,
        [Description("Local Left Ring Slot Maximum Mana")]
        LocalLeftRingSlotMaximumMana = 5638,
        [Description("Local Right Ring Slot Energy Shield")]
        LocalRightRingSlotEnergyShield = 5639,
        [Description("Map Leaguestone Additional Breaches")]
        MapLeaguestoneAdditionalBreaches = 5640,
        [Description("Map Leaguestone Additional Monoliths")]
        MapLeaguestoneAdditionalMonoliths = 5641,
        [Description("Map Leaguestone Additional Talismans")]
        MapLeaguestoneAdditionalTalismans = 5642,
        [Description("Map Leaguestone Additional Rogue Exiles")]
        MapLeaguestoneAdditionalRogueExiles = 5643,
        [Description("Map Leaguestone Additional Perandus Chests")]
        MapLeaguestoneAdditionalPerandusChests = 5644,
        [Description("Local Left Ring Slot Mana Regeneration Rate Per Minute")]
        LocalLeftRingSlotManaRegenerationRatePerMinute = 5645,
        [Description("Local Right Ring Slot Maximum Mana")]
        LocalRightRingSlotMaximumMana = 5646,
        [Description("Local Left Ring Slot Energy Shield")]
        LocalLeftRingSlotEnergyShield = 5647,
        [Description("Local Display Cast Level X Consecrate On Crit")]
        LocalDisplayCastLevelXConsecrateOnCrit = 5648,
        [Description("Is Tormented Spirit")]
        IsTormentedSpirit = 5649,
        [Description("Shavronne Teleport Number Of Markers")]
        ShavronneTeleportNumberOfMarkers = 5650,
        [Description("Map Packs Are Spiders")]
        MapPacksAreSpiders = 5651,
        [Description("Map Packs Are Blackguards")]
        MapPacksAreBlackguards = 5652,
        [Description("Local Display Cast Level 1 Summon Lesser Shrine On Kill %")]
        LocalDisplayCastLevel1SummonLesserShrineOnKillPct = 5653,
        [Description("Shavronne Teleport No Teleport")]
        ShavronneTeleportNoTeleport = 5654,
        [Description("Debug Projectile Index Override")]
        DebugProjectileIndexOverride = 5655,
        [Description("Ground Slam Retarget After Contact Point")]
        GroundSlamRetargetAfterContactPoint = 5656,
        [Description("Map Leaguestone Override Base Num Warband Packs")]
        MapLeaguestoneOverrideBaseNumWarbandPacks = 5657,
        [Description("Map Leaguestone Additional Warband Packs")]
        MapLeaguestoneAdditionalWarbandPacks = 5658,
        [Description("Map Leaguestone Explicit Warband Type Override")]
        MapLeaguestoneExplicitWarbandTypeOverride = 5659,
        [Description("Map Leaguestone Contains Warband Leader")]
        MapLeaguestoneContainsWarbandLeader = 5660,
        [Description("Map Leaguestone Override Base Num Shrines")]
        MapLeaguestoneOverrideBaseNumShrines = 5661,
        [Description("Map Leaguestone Shrine Monster Rarity Override")]
        MapLeaguestoneShrineMonsterRarityOverride = 5662,
        [Description("Map Leaguestone Shrine Override Type")]
        MapLeaguestoneShrineOverrideType = 5663,
        [Description("Map Rampage Time +%")]
        MapRampageTimePosPct = 5664,
        [Description("Map Contains X Additional Animated Weapon Packs")]
        MapContainsXAdditionalAnimatedWeaponPacks = 5665,
        [Description("Map Leaguestones Currency Items Drop When First Reaching X Rampage Stacks")]
        MapLeaguestonesCurrencyItemsDropWhenFirstReachingXRampageStacks = 5666,
        [Description("Map Leaguestones Spawn Powerful Monster When Reaching X Rampage Stacks")]
        MapLeaguestonesSpawnPowerfulMonsterWhenReachingXRampageStacks = 5667,
        [Description("Map Contains Keepers Of The Trove Bloodline Pack")]
        MapContainsKeepersOfTheTroveBloodlinePack = 5668,
        [Description("Map Contains Wealthy Pack")]
        MapContainsWealthyPack = 5669,
        [Description("Map Leaguestone Implicit Tempest Random")]
        MapLeaguestoneImplicitTempestRandom = 5670,
        [Description("Map Leaguestone Explicit Tempest Type Override")]
        MapLeaguestoneExplicitTempestTypeOverride = 5671,
        [Description("Local Unique Jewel Frostbolt Additional Projectiles With 40 Int In Radius")]
        LocalUniqueJewelFrostboltAdditionalProjectilesWith40IntInRadius = 5672,
        [Description("Frostbolt Number Of Additional Projectiles")]
        FrostboltNumberOfAdditionalProjectiles = 5673,
        [Description("Skill Area Of Effect +% Final")]
        SkillAreaOfEffectPosPctFinal = 5674,
        [Description("Total Skill Area Of Effect +% Including Final")]
        TotalSkillAreaOfEffectPosPctIncludingFinal = 5675,
        [Description("Local Unique Jewel Magma Orb Additional Projectiles With 40 Int In Radius")]
        LocalUniqueJewelMagmaOrbAdditionalProjectilesWith40IntInRadius = 5676,
        [Description("Magma Orb Number Of Additional Projectiles")]
        MagmaOrbNumberOfAdditionalProjectiles = 5677,
        [Description("Curse On Hit Level Cold Weakness")]
        CurseOnHitLevelColdWeakness = 5678,
        [Description("Elemental Damage +% If Used A Warcry Recently")]
        ElementalDamagePosPctIfUsedAWarcryRecently = 5679,
        [Description("Local Display Socketed Golem Attack And Cast Speed +%")]
        LocalDisplaySocketedGolemAttackAndCastSpeedPosPct = 5680,
        [Description("Local Display Cast Animate Weapon On Kill % Chance")]
        LocalDisplayCastAnimateWeaponOnKillPctChance = 5681,
        [Description("Gain Onslaught Ms On Skill Use")]
        GainOnslaughtMsOnSkillUse = 5682,
        [Description("Local Display Socketed Golem Skill Grants Onslaught When Summoned")]
        LocalDisplaySocketedGolemSkillGrantsOnslaughtWhenSummoned = 5683,
        [Description("Has Unholy Might")]
        HasUnholyMight = 5684,
        [Description("Chest Drop Reliquary Items")]
        ChestDropReliquaryItems = 5685,
        [Description("Deal No Skill Dot Damage Over Time")]
        DealNoSkillDotDamageOverTime = 5686,
        [Description("Combined All Projectile Damage +%")]
        CombinedAllProjectileDamagePosPct = 5687,
        [Description("Combined All Projectile Damage +% Final")]
        CombinedAllProjectileDamagePosPctFinal = 5688,
        [Description("Combined All Area Damage +%")]
        CombinedAllAreaDamagePosPct = 5689,
        [Description("Combined All Area Damage +% Final")]
        CombinedAllAreaDamagePosPctFinal = 5690,
        [Description("Combined All Added Damage +% Final")]
        CombinedAllAddedDamagePosPctFinal = 5691,
        [Description("Combined Hit All Damage +%")]
        CombinedHitAllDamagePosPct = 5692,
        [Description("Combined Skill Dot All Damage Over Time +%")]
        CombinedSkillDotAllDamageOverTimePosPct = 5693,
        [Description("Combined Skill Dot All Damage Over Time +% Final")]
        CombinedSkillDotAllDamageOverTimePosPctFinal = 5694,
        [Description("Projectile Damage Modifiers Apply To Skill Dot")]
        ProjectileDamageModifiersApplyToSkillDot = 5695,
        [Description("Fire Beam Max Rotation Speed +%")]
        FireBeamMaxRotationSpeedPosPct = 5696,
        [Description("Map Player Onslaught On Kill %")]
        MapPlayerOnslaughtOnKillPct = 5697,
        [Description("Map Monster Attack Cast And Movement Speed +%")]
        MapMonsterAttackCastAndMovementSpeedPosPct = 5698,
        [Description("Map Rare Monsters Drop X Additional Rare Items")]
        MapRareMonstersDropXAdditionalRareItems = 5699,
        [Description("Map Area Contains X Rare Monsters With Inner Treasure")]
        MapAreaContainsXRareMonstersWithInnerTreasure = 5700,
        [Description("Map Leaguestone Invasion Boss Item Quantity And Rarity +% Final")]
        MapLeaguestoneInvasionBossItemQuantityAndRarityPosPctFinal = 5701,
        [Description("Map First Invasion Boss Killed Drops X Additional Currency")]
        MapFirstInvasionBossKilledDropsXAdditionalCurrency = 5702,
        [Description("Map Invasion Monsters Guarded By X Magic Packs")]
        MapInvasionMonstersGuardedByXMagicPacks = 5703,
        [Description("Map Leaguestone Override Base Num Strongboxes")]
        MapLeaguestoneOverrideBaseNumStrongboxes = 5704,
        [Description("Map Leaguestone Additional Strongboxes")]
        MapLeaguestoneAdditionalStrongboxes = 5705,
        [Description("Map First Strongbox Contains X Additional Rare Monsters")]
        MapFirstStrongboxContainsXAdditionalRareMonsters = 5706,
        [Description("Map Area Contains Gemcutters Strongbox")]
        MapAreaContainsGemcuttersStrongbox = 5707,
        [Description("Map Area Contains Cartographers Strongbox")]
        MapAreaContainsCartographersStrongbox = 5708,
        [Description("Map Area Contains Unique Strongbox")]
        MapAreaContainsUniqueStrongbox = 5709,
        [Description("Map Area Contains Arcanists Strongbox")]
        MapAreaContainsArcanistsStrongbox = 5710,
        [Description("Map Strongboxes Drop X Additional Rare Items")]
        MapStrongboxesDropXAdditionalRareItems = 5711,
        [Description("Map Leaguestone Beyond Monster Item Quantity And Rarity +% Final")]
        MapLeaguestoneBeyondMonsterItemQuantityAndRarityPosPctFinal = 5712,
        [Description("Map First Unique Beyond Boss Slain Drops X Beyond Uniques")]
        MapFirstUniqueBeyondBossSlainDropsXBeyondUniques = 5713,
        [Description("Map Leaguestone X Monsters Spawn Random Beyond Boss")]
        MapLeaguestoneXMonstersSpawnRandomBeyondBoss = 5714,
        [Description("Map Leaguestone X Monsters Spawn Abaxoth")]
        MapLeaguestoneXMonstersSpawnAbaxoth = 5715,
        [Description("Map Item Found Rarity +% Per 15 Rampage Stacks")]
        MapItemFoundRarityPosPctPer15RampageStacks = 5716,
        [Description("Item Found Rarity +% Per 15 Rampage Stacks")]
        ItemFoundRarityPosPctPer15RampageStacks = 5717,
        [Description("Leaguestone Spawn Beyond Monster On Death Index")]
        LeaguestoneSpawnBeyondMonsterOnDeathIndex = 5718,
        [Description("Map Contains Three Magic Packs With Attack Cast And Movement Speed +%")]
        MapContainsThreeMagicPacksWithAttackCastAndMovementSpeedPosPct = 5719,
        [Description("Map Contains Three Magic Packs With Item Quantity Of Dropped Items +% Final")]
        MapContainsThreeMagicPacksWithItemQuantityOfDroppedItemsPosPctFinal = 5720,
        [Description("Leaguestone Maximum Area Level")]
        LeaguestoneMaximumAreaLevel = 5721,
        [Description("Attack Minimum Added Physical Damage Per Level")]
        AttackMinimumAddedPhysicalDamagePerLevel = 5722,
        [Description("Attack Maximum Added Physical Damage Per Level")]
        AttackMaximumAddedPhysicalDamagePerLevel = 5723,
        [Description("Attack Minimum Added Fire Damage Per 10 Strength")]
        AttackMinimumAddedFireDamagePer10Strength = 5724,
        [Description("Attack Maximum Added Fire Damage Per 10 Strength")]
        AttackMaximumAddedFireDamagePer10Strength = 5725,
        [Description("Unique Ryuslathas Clutches Minimum Physical Attack Damage +% Final")]
        UniqueRyuslathasClutchesMinimumPhysicalAttackDamagePosPctFinal = 5726,
        [Description("Unique Ryuslathas Clutches Maximum Physical Attack Damage +% Final")]
        UniqueRyuslathasClutchesMaximumPhysicalAttackDamagePosPctFinal = 5727,
        [Description("Is Intimidated")]
        IsIntimidated = 5728,
        [Description("Local Unique Jewel Frost Blades Melee Damage Penetrates % Cold Resistance With 40 Dex In Radius")]
        LocalUniqueJewelFrostBladesMeleeDamagePenetratesPctColdResistanceWith40DexInRadius = 5729,
        [Description("Frost Blades Melee Damage Penetrates % Cold Resistance")]
        FrostBladesMeleeDamagePenetratesPctColdResistance = 5730,
        [Description("Melee Damage Penetrates % Cold Resistance")]
        MeleeDamagePenetratesPctColdResistance = 5731,
        [Description("Local Display Socketed Golem Skills Minions Life % To Add As Energy Shield")]
        LocalDisplaySocketedGolemSkillsMinionsLifePctToAddAsEnergyShield = 5732,
        [Description("Mana Leech Permyriad Vs Frozen Enemies")]
        ManaLeechPermyriadVsFrozenEnemies = 5733,
        [Description("Map Mini Monolith Monsters Are Magic")]
        MapMiniMonolithMonstersAreMagic = 5734,
        [Description("Map Shrines Grant A Random Additional Effect")]
        MapShrinesGrantARandomAdditionalEffect = 5735,
        [Description("Map Shrines Drop X Currency Items On Activation")]
        MapShrinesDropXCurrencyItemsOnActivation = 5736,
        [Description("Map Monsters Spawned With Talisman Drop Additional Rare Items")]
        MapMonstersSpawnedWithTalismanDropAdditionalRareItems = 5737,
        [Description("Chance To Cast On Kill %")]
        ChanceToCastOnKillPct = 5738,
        [Description("Map Warbands Packs Have Additional Grunts")]
        MapWarbandsPacksHaveAdditionalGrunts = 5739,
        [Description("Map Warbands Packs Have Additional Supports")]
        MapWarbandsPacksHaveAdditionalSupports = 5740,
        [Description("Map Warbands Packs Have Additional Elites")]
        MapWarbandsPacksHaveAdditionalElites = 5741,
        [Description("Map Leaguestone Warbands Packs Have Item Rarity +% Final")]
        MapLeaguestoneWarbandsPacksHaveItemRarityPosPctFinal = 5742,
        [Description("Map Leaguestone Warbands Packs Have Item Quantity +% Final")]
        MapLeaguestoneWarbandsPacksHaveItemQuantityPosPctFinal = 5743,
        [Description("Map Monsters Near Shrines Are Chilled")]
        MapMonstersNearShrinesAreChilled = 5744,
        [Description("Map Imprisoned Monsters Damage Taken +%")]
        MapImprisonedMonstersDamageTakenPosPct = 5745,
        [Description("Map Imprisoned Monsters Damage +%")]
        MapImprisonedMonstersDamagePosPct = 5746,
        [Description("Map Leaguestone Imprisoned Monsters Item Rarity +% Final")]
        MapLeaguestoneImprisonedMonstersItemRarityPosPctFinal = 5747,
        [Description("Map Leaguestone Imprisoned Monsters Item Quantity +% Final")]
        MapLeaguestoneImprisonedMonstersItemQuantityPosPctFinal = 5748,
        [Description("Map Leaguestone Strongboxes Rarity Override")]
        MapLeaguestoneStrongboxesRarityOverride = 5749,
        [Description("Has Shrine Effect")]
        HasShrineEffect = 5750,
        [Description("Map Player Dodge Chance % During Shrine Effect")]
        MapPlayerDodgeChancePctDuringShrineEffect = 5751,
        [Description("Dodge Chance % During Shrine Effect")]
        DodgeChancePctDuringShrineEffect = 5752,
        [Description("Map Player Damage +% Vs Breach Monsters")]
        MapPlayerDamagePosPctVsBreachMonsters = 5753,
        [Description("Map Player Damage Taken +% Vs Breach Monsters")]
        MapPlayerDamageTakenPosPctVsBreachMonsters = 5754,
        [Description("Damage +% Vs Breach Monsters")]
        DamagePosPctVsBreachMonsters = 5755,
        [Description("Damage Taken +% Vs Breach Monsters")]
        DamageTakenPosPctVsBreachMonsters = 5756,
        [Description("Map Rare Breach Monster Additional Breach Ring Drop Chance %")]
        MapRareBreachMonsterAdditionalBreachRingDropChancePct = 5757,
        [Description("Map Strongboxes Vaal Orb Drop Chance %")]
        MapStrongboxesVaalOrbDropChancePct = 5758,
        [Description("Map Player Shrine Effect Duration +%")]
        MapPlayerShrineEffectDurationPosPct = 5759,
        [Description("Monster Is Beyond Boss")]
        MonsterIsBeyondBoss = 5760,
        [Description("Active Skill Base Radius +")]
        ActiveSkillBaseRadiusPos = 5761,
        [Description("Map Leaguestone Area Contains X Additional Leaguestones")]
        MapLeaguestoneAreaContainsXAdditionalLeaguestones = 5762,
        [Description("Map Leaguestone Monolith Contains Essence Type")]
        MapLeaguestoneMonolithContainsEssenceType = 5763,
        [Description("Map Contains Uul Netol Breach")]
        MapContainsUulNetolBreach = 5764,
        [Description("Map Contains Chayula Breach")]
        MapContainsChayulaBreach = 5765,
        [Description("Number Of Animated Weapons Allowed")]
        NumberOfAnimatedWeaponsAllowed = 5766,
        [Description("Number Of Active Animated Weapons")]
        NumberOfActiveAnimatedWeapons = 5767,
        [Description("Map Leaguestone Perandus Chests Have Item Rarity +% Final")]
        MapLeaguestonePerandusChestsHaveItemRarityPosPctFinal = 5768,
        [Description("Map Leaguestone Perandus Chests Have Item Quantity +% Final")]
        MapLeaguestonePerandusChestsHaveItemQuantityPosPctFinal = 5769,
        [Description("Map Perandus Monsters Drop Perandus Coin Stack %")]
        MapPerandusMonstersDropPerandusCoinStackPct = 5770,
        [Description("Map Perandus Guards Are Rare")]
        MapPerandusGuardsAreRare = 5771,
        [Description("Map Contains Perandus Boss")]
        MapContainsPerandusBoss = 5772,
        [Description("Drop Perandus Coin Stack %")]
        DropPerandusCoinStackPct = 5773,
        [Description("Kills Count Twice For Rampage %")]
        KillsCountTwiceForRampagePct = 5774,
        [Description("Map Next Area Contains X Additional Voidspawn Of Abaxoth Packs")]
        MapNextAreaContainsXAdditionalVoidspawnOfAbaxothPacks = 5775,
        [Description("Map Next Area Contains X Additional Bearers Of The Guardian Packs")]
        MapNextAreaContainsXAdditionalBearersOfTheGuardianPacks = 5776,
        [Description("Map Gain Onslaught For X Ms On Killing Rare Monster")]
        MapGainOnslaughtForXMsOnKillingRareMonster = 5777,
        [Description("Gain Onslaught For X Ms On Killing Rare Monster")]
        GainOnslaughtForXMsOnKillingRareMonster = 5778,
        [Description("Monster Held Item Force No Drop Penalty")]
        MonsterHeldItemForceNoDropPenalty = 5779,
        [Description("Leaguestone Prefix Minimum Area Level")]
        LeaguestonePrefixMinimumAreaLevel = 5780,
        [Description("Leaguestone Suffix Minimum Area Level")]
        LeaguestoneSuffixMinimumAreaLevel = 5781,
        [Description("Map Rare Monsters Drop Rare Prismatic Ring On Death %")]
        MapRareMonstersDropRarePrismaticRingOnDeathPct = 5782,
        [Description("Drop Rare Prismatic Ring On Death %")]
        DropRarePrismaticRingOnDeathPct = 5783,
        [Description("Map Players Gain 1 Rare Monster Mods On Kill For 20 Seconds %")]
        MapPlayersGain1RareMonsterModsOnKillFor20SecondsPct = 5784,
        [Description("Gain 1 Rare Monster Mods On Kill For 20 Seconds %")]
        Gain1RareMonsterModsOnKillFor20SecondsPct = 5785,
        [Description("Monster Is Beyond Monster")]
        MonsterIsBeyondMonster = 5786,
        [Description("Map Spawn Beyond Boss When Beyond Boss Slain %")]
        MapSpawnBeyondBossWhenBeyondBossSlainPct = 5787,
        [Description("Map Damage Taken +% From Beyond Monsters")]
        MapDamageTakenPosPctFromBeyondMonsters = 5788,
        [Description("Damage Taken +% From Beyond Monsters")]
        DamageTakenPosPctFromBeyondMonsters = 5789,
        [Description("Map Monster Damage Taken +% While Possessed")]
        MapMonsterDamageTakenPosPctWhilePossessed = 5790,
        [Description("Monster Damage Taken +% While Possessed")]
        MonsterDamageTakenPosPctWhilePossessed = 5791,
        [Description("Map Invasion Bosses Drop X Additional Vaal Orbs")]
        MapInvasionBossesDropXAdditionalVaalOrbs = 5792,
        [Description("Map Invasion Bosses Dropped Items Are Fully Linked")]
        MapInvasionBossesDroppedItemsAreFullyLinked = 5793,
        [Description("Map Invasion Bosses Dropped Items Have X Additional Sockets")]
        MapInvasionBossesDroppedItemsHaveXAdditionalSockets = 5794,
        [Description("Is Holding Silver Coin")]
        IsHoldingSilverCoin = 5795,
        [Description("Map Monsters With Silver Coins Drop X Additional Rare Items")]
        MapMonstersWithSilverCoinsDropXAdditionalRareItems = 5796,
        [Description("Map Monsters With Silver Coins Drop X Additional Currency Items")]
        MapMonstersWithSilverCoinsDropXAdditionalCurrencyItems = 5797,
        [Description("Map Bloodline Packs Drop X Additional Rare Items")]
        MapBloodlinePacksDropXAdditionalRareItems = 5798,
        [Description("Map Bloodline Packs Drop X Additional Currency Items")]
        MapBloodlinePacksDropXAdditionalCurrencyItems = 5799,
        [Description("Map Player Attack Cast And Movement Speed +% During Onslaught")]
        MapPlayerAttackCastAndMovementSpeedPosPctDuringOnslaught = 5800,
        [Description("Attack Cast And Movement Speed +% During Onslaught")]
        AttackCastAndMovementSpeedPosPctDuringOnslaught = 5801,
        [Description("Map Leaguestone Additional Shrines")]
        MapLeaguestoneAdditionalShrines = 5802,
        [Description("Active Skill Area Of Effect Radius +% Final")]
        ActiveSkillAreaOfEffectRadiusPosPctFinal = 5803,
        [Description("Map Rare Monsters Are Hindered")]
        MapRareMonstersAreHindered = 5804,
        [Description("Map Players Movement Speed +%")]
        MapPlayersMovementSpeedPosPct = 5805,
        [Description("Map Magic Monsters Damage Taken +%")]
        MapMagicMonstersDamageTakenPosPct = 5806,
        [Description("Map Magic Monsters Are Maimed")]
        MapMagicMonstersAreMaimed = 5807,
        [Description("Map Players Gain Onslaught During Flask Effect")]
        MapPlayersGainOnslaughtDuringFlaskEffect = 5808,
        [Description("Map Players Gain Rare Monster Mods On Kill % Chance")]
        MapPlayersGainRareMonsterModsOnKillPctChance = 5809,
        [Description("Gain Rare Monster Mods On Kill % Chance")]
        GainRareMonsterModsOnKillPctChance = 5810,
        [Description("Map Invasion Bosses Are Twinned")]
        MapInvasionBossesAreTwinned = 5811,
        [Description("Map Tormented Spirits Movement Speed +%")]
        MapTormentedSpiritsMovementSpeedPosPct = 5812,
        [Description("Map Tormented Spirits Duration +%")]
        MapTormentedSpiritsDurationPosPct = 5813,
        [Description("Map Players Gain Onslaught After Opening A Strongbox Ms")]
        MapPlayersGainOnslaughtAfterOpeningAStrongboxMs = 5814,
        [Description("Gain Onslaught After Opening A Strongbox Ms")]
        GainOnslaughtAfterOpeningAStrongboxMs = 5815,
        [Description("Map Players Additional Spell Dodge %")]
        MapPlayersAdditionalSpellDodgePct = 5816,
        [Description("Map Rare Monsters Have Inner Treasure")]
        MapRareMonstersHaveInnerTreasure = 5817,
        [Description("Map Leaguestone Override Base Num Prophecy Coins")]
        MapLeaguestoneOverrideBaseNumProphecyCoins = 5818,
        [Description("Map Leaguestone Additional Prophecy Coins")]
        MapLeaguestoneAdditionalProphecyCoins = 5819,
        [Description("Map Leaguestone Override Base Num Invasion Bosses")]
        MapLeaguestoneOverrideBaseNumInvasionBosses = 5820,
        [Description("Map Leaguestone Additional Invasion Bosses")]
        MapLeaguestoneAdditionalInvasionBosses = 5821,
        [Description("Map Monster Beyond Portal Chance +%")]
        MapMonsterBeyondPortalChancePosPct = 5822,
        [Description("Local Unique Jewel Fireball Base Radius Up To + At Longer Ranges With 40 Int In Radius")]
        LocalUniqueJewelFireballBaseRadiusUpToPosAtLongerRangesWith40IntInRadius = 5823,
        [Description("Fireball Base Radius Up To + At Longer Ranges")]
        FireballBaseRadiusUpToPosAtLongerRanges = 5824,
        [Description("Local Display Cast Level X Shock Ground When Hit")]
        LocalDisplayCastLevelXShockGroundWhenHit = 5825,
        [Description("Curse With Enfeeble On Hit % Against Uncursed Enemies")]
        CurseWithEnfeebleOnHitPctAgainstUncursedEnemies = 5826,
        [Description("Map Rogue Exiles Drop Additional Currency Items With Quality")]
        MapRogueExilesDropAdditionalCurrencyItemsWithQuality = 5827,
        [Description("Map Rogue Exiles Dropped Items Are Duplicated")]
        MapRogueExilesDroppedItemsAreDuplicated = 5828,
        [Description("Map Rogue Exiles Dropped Items Are Corrupted")]
        MapRogueExilesDroppedItemsAreCorrupted = 5829,
        [Description("Map Rogue Exiles Dropped Items Are Fully Linked")]
        MapRogueExilesDroppedItemsAreFullyLinked = 5830,
        [Description("Drop Additional Vaal Orbs")]
        DropAdditionalVaalOrbs = 5831,
        [Description("Map Contains Additional Mandible Talisman")]
        MapContainsAdditionalMandibleTalisman = 5832,
        [Description("Map Contains Additional Chrysalis Talisman")]
        MapContainsAdditionalChrysalisTalisman = 5833,
        [Description("Map Contains Additional Writhing Talisman")]
        MapContainsAdditionalWrithingTalisman = 5834,
        [Description("Map Contains Additional Fangjaw Talisman")]
        MapContainsAdditionalFangjawTalisman = 5835,
        [Description("Map Contains Additional Clutching Talisman")]
        MapContainsAdditionalClutchingTalisman = 5836,
        [Description("Map Contains Additional Three Rat Talisman")]
        MapContainsAdditionalThreeRatTalisman = 5837,
        [Description("Map Contains Additional Unique Talisman")]
        MapContainsAdditionalUniqueTalisman = 5838,
        [Description("Map Tempest Frequency +%")]
        MapTempestFrequencyPosPct = 5839,
        [Description("Map Player Life Regeneration Rate Per Minute % Per 25 Rampage Stacks")]
        MapPlayerLifeRegenerationRatePerMinutePctPer25RampageStacks = 5840,
        [Description("Life Regeneration Rate Per Minute % Per 25 Rampage Stacks")]
        LifeRegenerationRatePerMinutePctPer25RampageStacks = 5841,
        [Description("Map Player Damage Taken +% While Rampaging")]
        MapPlayerDamageTakenPosPctWhileRampaging = 5842,
        [Description("Damage Taken +% While Rampaging")]
        DamageTakenPosPctWhileRampaging = 5843,
        [Description("Map Contains Corrupted Strongbox")]
        MapContainsCorruptedStrongbox = 5844,
        [Description("Number Of Monsters To Summon Override")]
        NumberOfMonstersToSummonOverride = 5845,
        [Description("Monster Beyond Portal Chance +% Final")]
        MonsterBeyondPortalChancePosPctFinal = 5846,
        [Description("Map Num Leaguestones Active")]
        MapNumLeaguestonesActive = 5847,
        [Description("Virtual Monster Dropped Item Rarity +%")]
        VirtualMonsterDroppedItemRarityPosPct = 5848,
        [Description("Virtual Monster Dropped Item Quantity +%")]
        VirtualMonsterDroppedItemQuantityPosPct = 5849,
        [Description("Virtual Chest Item Quantity +%")]
        VirtualChestItemQuantityPosPct = 5850,
        [Description("Virtual Chest Item Rarity +%")]
        VirtualChestItemRarityPosPct = 5851,
        [Description("Leaguestone Monster Dropped Item Rarity +% Final")]
        LeaguestoneMonsterDroppedItemRarityPosPctFinal = 5852,
        [Description("Leaguestone Monster Dropped Item Quantity +% Final")]
        LeaguestoneMonsterDroppedItemQuantityPosPctFinal = 5853,
        [Description("Leaguestone Chest Item Quantity +% Final")]
        LeaguestoneChestItemQuantityPosPctFinal = 5854,
        [Description("Leaguestone Chest Item Rarity +% Final")]
        LeaguestoneChestItemRarityPosPctFinal = 5855,
        [Description("Map Leaguestone Stone Circle % Chance")]
        MapLeaguestoneStoneCirclePctChance = 5856,
        [Description("Local Unique Jewel Frost Blades Projectile Speed +% With 40 Dex In Radius")]
        LocalUniqueJewelFrostBladesProjectileSpeedPosPctWith40DexInRadius = 5857,
        [Description("Local Unique Jewel Dual Strike Main Hand Deals Double Damage % With 40 Dex In Radius")]
        LocalUniqueJewelDualStrikeMainHandDealsDoubleDamagePctWith40DexInRadius = 5858,
        [Description("Dual Strike Main Hand Deals Double Damage %")]
        DualStrikeMainHandDealsDoubleDamagePct = 5859,
        [Description("Chance To Deal Double Damage %")]
        ChanceToDealDoubleDamagePct = 5860,
        [Description("Always Ignite While Burning")]
        AlwaysIgniteWhileBurning = 5861,
        [Description("Full Life Threshold")]
        FullLifeThreshold = 5862,
        [Description("Unique Rat Cage Chance To Squeak When Hit By Fire Damage")]
        UniqueRatCageChanceToSqueakWhenHitByFireDamage = 5863,
        [Description("Map Monster Slain Experience +%")]
        MapMonsterSlainExperiencePosPct = 5864,
        [Description("Map Imprisoned Monsters Action Speed +%")]
        MapImprisonedMonstersActionSpeedPosPct = 5865,
        [Description("Is Beyond Monster Daemon")]
        IsBeyondMonsterDaemon = 5866,
        [Description("Map Tempest Area Of Effect +% Visible")]
        MapTempestAreaOfEffectPosPctVisible = 5867,
        [Description("Fortify Applies To Nearby Allies For X Seconds")]
        FortifyAppliesToNearbyAlliesForXSeconds = 5868,
        [Description("Suppress Phasing Visual")]
        SuppressPhasingVisual = 5869,
        [Description("Show Phasing Visual")]
        ShowPhasingVisual = 5870,
        [Description("Energy Shield Has Started Recharging Recently")]
        EnergyShieldHasStartedRechargingRecently = 5871,
        [Description("Track Energy Shield Has Started Recharging Recently")]
        TrackEnergyShieldHasStartedRechargingRecently = 5872,
        [Description("Not Affected By Action Speed Modifiers")]
        NotAffectedByActionSpeedModifiers = 5873,
        [Description("Map Player Movement Velocity +%")]
        MapPlayerMovementVelocityPosPct = 5874,
        [Description("Lunaris Glaive Angle")]
        LunarisGlaiveAngle = 5875,
        [Description("Lunaris Glaive Acceleration X")]
        LunarisGlaiveAccelerationX = 5876,
        [Description("Lunaris Glaive Acceleration Y")]
        LunarisGlaiveAccelerationY = 5877,
        [Description("Maintain Projectile Direction When Using Contact Position")]
        MaintainProjectileDirectionWhenUsingContactPosition = 5878,
        [Description("Map Force Side Area")]
        MapForceSideArea = 5879,
        [Description("Map Num Sextant Mods")]
        MapNumSextantMods = 5880,
        [Description("Cannot Be Stunned If You Have Been Stunned Recently")]
        CannotBeStunnedIfYouHaveBeenStunnedRecently = 5881,
        [Description("Track Have Been Stunned Recently")]
        TrackHaveBeenStunnedRecently = 5882,
        [Description("Have Been Stunned Recently")]
        HaveBeenStunnedRecently = 5883,
        [Description("Cannot Be Frozen If You Have Been Frozen Recently")]
        CannotBeFrozenIfYouHaveBeenFrozenRecently = 5884,
        [Description("Track Have Been Frozen Recently")]
        TrackHaveBeenFrozenRecently = 5885,
        [Description("Have Been Frozen Recently")]
        HaveBeenFrozenRecently = 5886,
        [Description("Life And Energy Shield Recovery Rate +% If Stopped Taking Damage Over Time Recently")]
        LifeAndEnergyShieldRecoveryRatePosPctIfStoppedTakingDamageOverTimeRecently = 5887,
        [Description("Movement Speed +% While On Burning Ground")]
        MovementSpeedPosPctWhileOnBurningGround = 5888,
        [Description("Chaos Damage Over Time Resistance %")]
        ChaosDamageOverTimeResistancePct = 5889,
        [Description("While Stationary Gain Additional Physical Damage Reduction %")]
        WhileStationaryGainAdditionalPhysicalDamageReductionPct = 5890,
        [Description("While Stationary Gain Life Regeneration Rate Per Minute %")]
        WhileStationaryGainLifeRegenerationRatePerMinutePct = 5891,
        [Description("Fire Damage Taken +% While Moving")]
        FireDamageTakenPosPctWhileMoving = 5892,
        [Description("Cold And Lightning Damage Taken As Fire Damage When Hit % Chance")]
        ColdAndLightningDamageTakenAsFireDamageWhenHitPctChance = 5893,
        [Description("Life Flasks Gain X Charges Every 3 Seconds If You Have Not Used A Life Flask Recently")]
        LifeFlasksGainXChargesEvery3SecondsIfYouHaveNotUsedALifeFlaskRecently = 5894,
        [Description("Life Recovery +% From Flasks While On Low Life")]
        LifeRecoveryPosPctFromFlasksWhileOnLowLife = 5895,
        [Description("Virtual Flask Life To Recover +%")]
        VirtualFlaskLifeToRecoverPosPct = 5896,
        [Description("Additional % Chance To Evade Attacks If You Have Taken A Savage Hit Recently")]
        AdditionalPctChanceToEvadeAttacksIfYouHaveTakenASavageHitRecently = 5897,
        [Description("Physical Damage Reduction % Per Hit You Have Taken Recently")]
        PhysicalDamageReductionPctPerHitYouHaveTakenRecently = 5898,
        [Description("Curses Have No Effect On You For 4 Seconds Every 10 Seconds")]
        CursesHaveNoEffectOnYouFor4SecondsEvery10Seconds = 5899,
        [Description("Hinder Effect On Self +%")]
        HinderEffectOnSelfPosPct = 5900,
        [Description("Avoid Corrupted Blood % Chance")]
        AvoidCorruptedBloodPctChance = 5901,
        [Description("Avoid Maim % Chance")]
        AvoidMaimPctChance = 5902,
        [Description("Monster Ground Fire On Death Variation")]
        MonsterGroundFireOnDeathVariation = 5903,
        [Description("Traps Explode On Timeout")]
        TrapsExplodeOnTimeout = 5904,
        [Description("Physical Skill Dot Damage To Deal Per Minute")]
        PhysicalSkillDotDamageToDealPerMinute = 5905,
        [Description("Fire Skill Dot Damage To Deal Per Minute")]
        FireSkillDotDamageToDealPerMinute = 5906,
        [Description("Cold Skill Dot Damage To Deal Per Minute")]
        ColdSkillDotDamageToDealPerMinute = 5907,
        [Description("Lightning Skill Dot Damage To Deal Per Minute")]
        LightningSkillDotDamageToDealPerMinute = 5908,
        [Description("Chaos Skill Dot Damage To Deal Per Minute")]
        ChaosSkillDotDamageToDealPerMinute = 5909,
        [Description("Physical Area Damage To Deal Per Minute")]
        PhysicalAreaDamageToDealPerMinute = 5910,
        [Description("Fire Area Damage To Deal Per Minute")]
        FireAreaDamageToDealPerMinute = 5911,
        [Description("Cold Area Damage To Deal Per Minute")]
        ColdAreaDamageToDealPerMinute = 5912,
        [Description("Lightning Area Damage To Deal Per Minute")]
        LightningAreaDamageToDealPerMinute = 5913,
        [Description("Chaos Area Damage To Deal Per Minute")]
        ChaosAreaDamageToDealPerMinute = 5914,
        [Description("Physical Skill Dot Area Damage To Deal Per Minute")]
        PhysicalSkillDotAreaDamageToDealPerMinute = 5915,
        [Description("Fire Skill Dot Area Damage To Deal Per Minute")]
        FireSkillDotAreaDamageToDealPerMinute = 5916,
        [Description("Cold Skill Dot Area Damage To Deal Per Minute")]
        ColdSkillDotAreaDamageToDealPerMinute = 5917,
        [Description("Lightning Skill Dot Area Damage To Deal Per Minute")]
        LightningSkillDotAreaDamageToDealPerMinute = 5918,
        [Description("Chaos Skill Dot Area Damage To Deal Per Minute")]
        ChaosSkillDotAreaDamageToDealPerMinute = 5919,
        [Description("Combined Attack Elemental Damage Pluspercent")]
        CombinedAttackElementalDamagePluspercent = 5920,
        [Description("Combined Attack Lightning Damage Pluspercent")]
        CombinedAttackLightningDamagePluspercent = 5921,
        [Description("Combined Attack Lightning Damage Pluspercent Final")]
        CombinedAttackLightningDamagePluspercentFinal = 5922,
        [Description("Combined Skill Dot Elemental Damage Over Time +%")]
        CombinedSkillDotElementalDamageOverTimePosPct = 5923,
        [Description("Combined Skill Dot Fire Damage Over Time +%")]
        CombinedSkillDotFireDamageOverTimePosPct = 5924,
        [Description("Combined Skill Dot Cold Damage Over Time +%")]
        CombinedSkillDotColdDamageOverTimePosPct = 5925,
        [Description("Combined Skill Dot Lightning Damage Over Time +%")]
        CombinedSkillDotLightningDamageOverTimePosPct = 5926,
        [Description("Combined Skill Dot Lightning Damage Over Time +% Final")]
        CombinedSkillDotLightningDamageOverTimePosPctFinal = 5927,
        [Description("Ignite Damage +%")]
        IgniteDamagePosPct = 5928,
        [Description("Combined Ignite Damage Over Time +%")]
        CombinedIgniteDamageOverTimePosPct = 5929,
        [Description("Bleed Is Skill Dot")]
        BleedIsSkillDot = 5930,
        [Description("Ignite Is Skill Dot")]
        IgniteIsSkillDot = 5931,
        [Description("Poison Is Skill Dot")]
        PoisonIsSkillDot = 5932,
        [Description("Deal No Bleed Damage Over Time")]
        DealNoBleedDamageOverTime = 5933,
        [Description("Deal No Ignite Damage Over Time")]
        DealNoIgniteDamageOverTime = 5934,
        [Description("Deal No Poison Damage Over Time")]
        DealNoPoisonDamageOverTime = 5935,
        [Description("Minimum Bleed Damage To Deal Per Minute From Main Hand Physical Damage")]
        MinimumBleedDamageToDealPerMinuteFromMainHandPhysicalDamage = 5936,
        [Description("Maximum Bleed Damage To Deal Per Minute From Main Hand Physical Damage")]
        MaximumBleedDamageToDealPerMinuteFromMainHandPhysicalDamage = 5937,
        [Description("Keystone Ghost Reaver")]
        KeystoneGhostReaver = 5938,
        [Description("Infest On Hit Chance %")]
        InfestOnHitChancePct = 5939,
        [Description("Infest On Hit Duration Ms")]
        InfestOnHitDurationMs = 5940,
        [Description("Energy Shield Per Level")]
        EnergyShieldPerLevel = 5941,
        [Description("Minimum Bleed Damage To Deal Per Minute From Off Hand Physical Damage")]
        MinimumBleedDamageToDealPerMinuteFromOffHandPhysicalDamage = 5942,
        [Description("Maximum Bleed Damage To Deal Per Minute From Off Hand Physical Damage")]
        MaximumBleedDamageToDealPerMinuteFromOffHandPhysicalDamage = 5943,
        [Description("Virtual Physical Damage Can Ignite")]
        VirtualPhysicalDamageCanIgnite = 5944,
        [Description("Virtual Fire Damage Cannot Ignite")]
        VirtualFireDamageCannotIgnite = 5945,
        [Description("Virtual Cold Damage Can Ignite")]
        VirtualColdDamageCanIgnite = 5946,
        [Description("Virtual Lightning Damage Can Ignite")]
        VirtualLightningDamageCanIgnite = 5947,
        [Description("Virtual Chaos Damage Can Ignite")]
        VirtualChaosDamageCanIgnite = 5948,
        [Description("Minimum Ignite Damage To Deal Per Minute From Main Hand Physical Damage")]
        MinimumIgniteDamageToDealPerMinuteFromMainHandPhysicalDamage = 5949,
        [Description("Maximum Ignite Damage To Deal Per Minute From Main Hand Physical Damage")]
        MaximumIgniteDamageToDealPerMinuteFromMainHandPhysicalDamage = 5950,
        [Description("Minimum Ignite Damage To Deal Per Minute From Main Hand Fire Damage")]
        MinimumIgniteDamageToDealPerMinuteFromMainHandFireDamage = 5951,
        [Description("Maximum Ignite Damage To Deal Per Minute From Main Hand Fire Damage")]
        MaximumIgniteDamageToDealPerMinuteFromMainHandFireDamage = 5952,
        [Description("Minimum Ignite Damage To Deal Per Minute From Main Hand Cold Damage")]
        MinimumIgniteDamageToDealPerMinuteFromMainHandColdDamage = 5953,
        [Description("Maximum Ignite Damage To Deal Per Minute From Main Hand Cold Damage")]
        MaximumIgniteDamageToDealPerMinuteFromMainHandColdDamage = 5954,
        [Description("Minimum Ignite Damage To Deal Per Minute From Main Hand Lightning Damage")]
        MinimumIgniteDamageToDealPerMinuteFromMainHandLightningDamage = 5955,
        [Description("Maximum Ignite Damage To Deal Per Minute From Main Hand Lightning Damage")]
        MaximumIgniteDamageToDealPerMinuteFromMainHandLightningDamage = 5956,
        [Description("Minimum Ignite Damage To Deal Per Minute From Main Hand Chaos Damage")]
        MinimumIgniteDamageToDealPerMinuteFromMainHandChaosDamage = 5957,
        [Description("Maximum Ignite Damage To Deal Per Minute From Main Hand Chaos Damage")]
        MaximumIgniteDamageToDealPerMinuteFromMainHandChaosDamage = 5958,
        [Description("Minimum Ignite Damage To Deal Per Minute From Off Hand Physical Damage")]
        MinimumIgniteDamageToDealPerMinuteFromOffHandPhysicalDamage = 5959,
        [Description("Maximum Ignite Damage To Deal Per Minute From Off Hand Physical Damage")]
        MaximumIgniteDamageToDealPerMinuteFromOffHandPhysicalDamage = 5960,
        [Description("Minimum Ignite Damage To Deal Per Minute From Off Hand Fire Damage")]
        MinimumIgniteDamageToDealPerMinuteFromOffHandFireDamage = 5961,
        [Description("Maximum Ignite Damage To Deal Per Minute From Off Hand Fire Damage")]
        MaximumIgniteDamageToDealPerMinuteFromOffHandFireDamage = 5962,
        [Description("Minimum Ignite Damage To Deal Per Minute From Off Hand Cold Damage")]
        MinimumIgniteDamageToDealPerMinuteFromOffHandColdDamage = 5963,
        [Description("Maximum Ignite Damage To Deal Per Minute From Off Hand Cold Damage")]
        MaximumIgniteDamageToDealPerMinuteFromOffHandColdDamage = 5964,
        [Description("Minimum Ignite Damage To Deal Per Minute From Off Hand Lightning Damage")]
        MinimumIgniteDamageToDealPerMinuteFromOffHandLightningDamage = 5965,
        [Description("Maximum Ignite Damage To Deal Per Minute From Off Hand Lightning Damage")]
        MaximumIgniteDamageToDealPerMinuteFromOffHandLightningDamage = 5966,
        [Description("Minimum Ignite Damage To Deal Per Minute From Off Hand Chaos Damage")]
        MinimumIgniteDamageToDealPerMinuteFromOffHandChaosDamage = 5967,
        [Description("Maximum Ignite Damage To Deal Per Minute From Off Hand Chaos Damage")]
        MaximumIgniteDamageToDealPerMinuteFromOffHandChaosDamage = 5968,
        [Description("Minimum Ignite Damage To Deal Per Minute From Spell Physical Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSpellPhysicalDamage = 5969,
        [Description("Maximum Ignite Damage To Deal Per Minute From Spell Physical Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSpellPhysicalDamage = 5970,
        [Description("Minimum Ignite Damage To Deal Per Minute From Spell Fire Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSpellFireDamage = 5971,
        [Description("Maximum Ignite Damage To Deal Per Minute From Spell Fire Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSpellFireDamage = 5972,
        [Description("Minimum Ignite Damage To Deal Per Minute From Spell Cold Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSpellColdDamage = 5973,
        [Description("Maximum Ignite Damage To Deal Per Minute From Spell Cold Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSpellColdDamage = 5974,
        [Description("Minimum Ignite Damage To Deal Per Minute From Spell Lightning Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSpellLightningDamage = 5975,
        [Description("Maximum Ignite Damage To Deal Per Minute From Spell Lightning Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSpellLightningDamage = 5976,
        [Description("Minimum Ignite Damage To Deal Per Minute From Spell Chaos Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSpellChaosDamage = 5977,
        [Description("Maximum Ignite Damage To Deal Per Minute From Spell Chaos Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSpellChaosDamage = 5978,
        [Description("Minimum Ignite Damage To Deal Per Minute From Secondary Physical Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSecondaryPhysicalDamage = 5979,
        [Description("Maximum Ignite Damage To Deal Per Minute From Secondary Physical Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSecondaryPhysicalDamage = 5980,
        [Description("Minimum Ignite Damage To Deal Per Minute From Secondary Fire Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSecondaryFireDamage = 5981,
        [Description("Maximum Ignite Damage To Deal Per Minute From Secondary Fire Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSecondaryFireDamage = 5982,
        [Description("Minimum Ignite Damage To Deal Per Minute From Secondary Cold Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSecondaryColdDamage = 5983,
        [Description("Maximum Ignite Damage To Deal Per Minute From Secondary Cold Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSecondaryColdDamage = 5984,
        [Description("Minimum Ignite Damage To Deal Per Minute From Secondary Lightning Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSecondaryLightningDamage = 5985,
        [Description("Maximum Ignite Damage To Deal Per Minute From Secondary Lightning Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSecondaryLightningDamage = 5986,
        [Description("Minimum Ignite Damage To Deal Per Minute From Secondary Chaos Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSecondaryChaosDamage = 5987,
        [Description("Maximum Ignite Damage To Deal Per Minute From Secondary Chaos Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSecondaryChaosDamage = 5988,
        [Description("Global Total Minimum Added Chaos Damage")]
        GlobalTotalMinimumAddedChaosDamage = 5989,
        [Description("Global Total Maximum Added Chaos Damage")]
        GlobalTotalMaximumAddedChaosDamage = 5990,
        [Description("Minimum Ignite Damage To Deal Per Minute From Main Hand Damage")]
        MinimumIgniteDamageToDealPerMinuteFromMainHandDamage = 5991,
        [Description("Maximum Ignite Damage To Deal Per Minute From Main Hand Damage")]
        MaximumIgniteDamageToDealPerMinuteFromMainHandDamage = 5992,
        [Description("Minimum Ignite Damage To Deal Per Minute From Off Hand Damage")]
        MinimumIgniteDamageToDealPerMinuteFromOffHandDamage = 5993,
        [Description("Maximum Ignite Damage To Deal Per Minute From Off Hand Damage")]
        MaximumIgniteDamageToDealPerMinuteFromOffHandDamage = 5994,
        [Description("Minimum Ignite Damage To Deal Per Minute From Spell Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSpellDamage = 5995,
        [Description("Maximum Ignite Damage To Deal Per Minute From Spell Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSpellDamage = 5996,
        [Description("Minimum Ignite Damage To Deal Per Minute From Secondary Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSecondaryDamage = 5997,
        [Description("Maximum Ignite Damage To Deal Per Minute From Secondary Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSecondaryDamage = 5998,
        [Description("Virtual Always Ignite")]
        VirtualAlwaysIgnite = 5999,
        [Description("Trap Additional Random Duration Ms")]
        TrapAdditionalRandomDurationMs = 6000,
        [Description("Minions Hits Can Only Kill Ignited Enemies")]
        MinionsHitsCanOnlyKillIgnitedEnemies = 6001,
        [Description("Hits Can Only Kill Ignited Enemies")]
        HitsCanOnlyKillIgnitedEnemies = 6002,
        [Description("Additional Spell Block % While Cursed")]
        AdditionalSpellBlockPctWhileCursed = 6003,
        [Description("Additional Block % While Not Cursed")]
        AdditionalBlockPctWhileNotCursed = 6004,
        [Description("Ignite Damage From Attack Skills +%")]
        IgniteDamageFromAttackSkillsPosPct = 6005,
        [Description("Minimum Poison Damage To Deal Per Minute From Main Hand Physical Damage")]
        MinimumPoisonDamageToDealPerMinuteFromMainHandPhysicalDamage = 6006,
        [Description("Maximum Poison Damage To Deal Per Minute From Main Hand Physical Damage")]
        MaximumPoisonDamageToDealPerMinuteFromMainHandPhysicalDamage = 6007,
        [Description("Minimum Poison Damage To Deal Per Minute From Main Hand Fire Damage")]
        MinimumPoisonDamageToDealPerMinuteFromMainHandFireDamage = 6008,
        [Description("Maximum Poison Damage To Deal Per Minute From Main Hand Fire Damage")]
        MaximumPoisonDamageToDealPerMinuteFromMainHandFireDamage = 6009,
        [Description("Minimum Poison Damage To Deal Per Minute From Main Hand Cold Damage")]
        MinimumPoisonDamageToDealPerMinuteFromMainHandColdDamage = 6010,
        [Description("Maximum Poison Damage To Deal Per Minute From Main Hand Cold Damage")]
        MaximumPoisonDamageToDealPerMinuteFromMainHandColdDamage = 6011,
        [Description("Minimum Poison Damage To Deal Per Minute From Main Hand Lightning Damage")]
        MinimumPoisonDamageToDealPerMinuteFromMainHandLightningDamage = 6012,
        [Description("Maximum Poison Damage To Deal Per Minute From Main Hand Lightning Damage")]
        MaximumPoisonDamageToDealPerMinuteFromMainHandLightningDamage = 6013,
        [Description("Minimum Poison Damage To Deal Per Minute From Main Hand Chaos Damage")]
        MinimumPoisonDamageToDealPerMinuteFromMainHandChaosDamage = 6014,
        [Description("Maximum Poison Damage To Deal Per Minute From Main Hand Chaos Damage")]
        MaximumPoisonDamageToDealPerMinuteFromMainHandChaosDamage = 6015,
        [Description("Minimum Poison Damage To Deal Per Minute From Off Hand Physical Damage")]
        MinimumPoisonDamageToDealPerMinuteFromOffHandPhysicalDamage = 6016,
        [Description("Maximum Poison Damage To Deal Per Minute From Off Hand Physical Damage")]
        MaximumPoisonDamageToDealPerMinuteFromOffHandPhysicalDamage = 6017,
        [Description("Minimum Poison Damage To Deal Per Minute From Off Hand Fire Damage")]
        MinimumPoisonDamageToDealPerMinuteFromOffHandFireDamage = 6018,
        [Description("Maximum Poison Damage To Deal Per Minute From Off Hand Fire Damage")]
        MaximumPoisonDamageToDealPerMinuteFromOffHandFireDamage = 6019,
        [Description("Minimum Poison Damage To Deal Per Minute From Off Hand Cold Damage")]
        MinimumPoisonDamageToDealPerMinuteFromOffHandColdDamage = 6020,
        [Description("Maximum Poison Damage To Deal Per Minute From Off Hand Cold Damage")]
        MaximumPoisonDamageToDealPerMinuteFromOffHandColdDamage = 6021,
        [Description("Minimum Poison Damage To Deal Per Minute From Off Hand Lightning Damage")]
        MinimumPoisonDamageToDealPerMinuteFromOffHandLightningDamage = 6022,
        [Description("Maximum Poison Damage To Deal Per Minute From Off Hand Lightning Damage")]
        MaximumPoisonDamageToDealPerMinuteFromOffHandLightningDamage = 6023,
        [Description("Minimum Poison Damage To Deal Per Minute From Off Hand Chaos Damage")]
        MinimumPoisonDamageToDealPerMinuteFromOffHandChaosDamage = 6024,
        [Description("Maximum Poison Damage To Deal Per Minute From Off Hand Chaos Damage")]
        MaximumPoisonDamageToDealPerMinuteFromOffHandChaosDamage = 6025,
        [Description("Minimum Poison Damage To Deal Per Minute From Spell Physical Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSpellPhysicalDamage = 6026,
        [Description("Maximum Poison Damage To Deal Per Minute From Spell Physical Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSpellPhysicalDamage = 6027,
        [Description("Minimum Poison Damage To Deal Per Minute From Spell Fire Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSpellFireDamage = 6028,
        [Description("Maximum Poison Damage To Deal Per Minute From Spell Fire Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSpellFireDamage = 6029,
        [Description("Minimum Poison Damage To Deal Per Minute From Spell Cold Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSpellColdDamage = 6030,
        [Description("Maximum Poison Damage To Deal Per Minute From Spell Cold Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSpellColdDamage = 6031,
        [Description("Minimum Poison Damage To Deal Per Minute From Spell Lightning Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSpellLightningDamage = 6032,
        [Description("Maximum Poison Damage To Deal Per Minute From Spell Lightning Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSpellLightningDamage = 6033,
        [Description("Minimum Poison Damage To Deal Per Minute From Spell Chaos Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSpellChaosDamage = 6034,
        [Description("Maximum Poison Damage To Deal Per Minute From Spell Chaos Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSpellChaosDamage = 6035,
        [Description("Minimum Poison Damage To Deal Per Minute From Secondary Physical Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSecondaryPhysicalDamage = 6036,
        [Description("Maximum Poison Damage To Deal Per Minute From Secondary Physical Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSecondaryPhysicalDamage = 6037,
        [Description("Minimum Poison Damage To Deal Per Minute From Secondary Fire Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSecondaryFireDamage = 6038,
        [Description("Maximum Poison Damage To Deal Per Minute From Secondary Fire Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSecondaryFireDamage = 6039,
        [Description("Minimum Poison Damage To Deal Per Minute From Secondary Cold Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSecondaryColdDamage = 6040,
        [Description("Maximum Poison Damage To Deal Per Minute From Secondary Cold Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSecondaryColdDamage = 6041,
        [Description("Minimum Poison Damage To Deal Per Minute From Secondary Lightning Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSecondaryLightningDamage = 6042,
        [Description("Maximum Poison Damage To Deal Per Minute From Secondary Lightning Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSecondaryLightningDamage = 6043,
        [Description("Minimum Poison Damage To Deal Per Minute From Secondary Chaos Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSecondaryChaosDamage = 6044,
        [Description("Maximum Poison Damage To Deal Per Minute From Secondary Chaos Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSecondaryChaosDamage = 6045,
        [Description("Combined Poison Damage Over Time +%")]
        CombinedPoisonDamageOverTimePosPct = 6046,
        [Description("Poison Damage From Attack Skills +%")]
        PoisonDamageFromAttackSkillsPosPct = 6047,
        [Description("Virtual Physical Damage Cannot Poison")]
        VirtualPhysicalDamageCannotPoison = 6048,
        [Description("Virtual Fire Damage Can Poison")]
        VirtualFireDamageCanPoison = 6049,
        [Description("Virtual Cold Damage Can Poison")]
        VirtualColdDamageCanPoison = 6050,
        [Description("Virtual Lightning Damage Can Poison")]
        VirtualLightningDamageCanPoison = 6051,
        [Description("Virtual Chaos Damage Cannot Poison")]
        VirtualChaosDamageCannotPoison = 6052,
        [Description("Non Chaos Damage Cannot Poison")]
        NonChaosDamageCannotPoison = 6053,
        [Description("All Damage Can Poison")]
        AllDamageCanPoison = 6054,
        [Description("Minimum Poison Damage To Deal Per Minute From Main Hand Damage")]
        MinimumPoisonDamageToDealPerMinuteFromMainHandDamage = 6055,
        [Description("Maximum Poison Damage To Deal Per Minute From Main Hand Damage")]
        MaximumPoisonDamageToDealPerMinuteFromMainHandDamage = 6056,
        [Description("Minimum Poison Damage To Deal Per Minute From Off Hand Damage")]
        MinimumPoisonDamageToDealPerMinuteFromOffHandDamage = 6057,
        [Description("Maximum Poison Damage To Deal Per Minute From Off Hand Damage")]
        MaximumPoisonDamageToDealPerMinuteFromOffHandDamage = 6058,
        [Description("Minimum Poison Damage To Deal Per Minute From Spell Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSpellDamage = 6059,
        [Description("Maximum Poison Damage To Deal Per Minute From Spell Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSpellDamage = 6060,
        [Description("Minimum Poison Damage To Deal Per Minute From Secondary Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSecondaryDamage = 6061,
        [Description("Maximum Poison Damage To Deal Per Minute From Secondary Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSecondaryDamage = 6062,
        [Description("Minimum Poison Damage To Always Deal Per Minute From Main Hand Damage")]
        MinimumPoisonDamageToAlwaysDealPerMinuteFromMainHandDamage = 6063,
        [Description("Maximum Poison Damage To Always Deal Per Minute From Main Hand Damage")]
        MaximumPoisonDamageToAlwaysDealPerMinuteFromMainHandDamage = 6064,
        [Description("Minimum Poison Damage To Always Deal Per Minute From Off Hand Damage")]
        MinimumPoisonDamageToAlwaysDealPerMinuteFromOffHandDamage = 6065,
        [Description("Maximum Poison Damage To Always Deal Per Minute From Off Hand Damage")]
        MaximumPoisonDamageToAlwaysDealPerMinuteFromOffHandDamage = 6066,
        [Description("Minimum Poison Damage To Always Deal Per Minute From Spell Damage")]
        MinimumPoisonDamageToAlwaysDealPerMinuteFromSpellDamage = 6067,
        [Description("Maximum Poison Damage To Always Deal Per Minute From Spell Damage")]
        MaximumPoisonDamageToAlwaysDealPerMinuteFromSpellDamage = 6068,
        [Description("Minimum Poison Damage To Always Deal Per Minute From Secondary Damage")]
        MinimumPoisonDamageToAlwaysDealPerMinuteFromSecondaryDamage = 6069,
        [Description("Maximum Poison Damage To Always Deal Per Minute From Secondary Damage")]
        MaximumPoisonDamageToAlwaysDealPerMinuteFromSecondaryDamage = 6070,
        [Description("Ice Spear Second Form Damage +%")]
        IceSpearSecondFormDamagePosPct = 6071,
        [Description("Extra Damage Taken From Crit While No Power Charges +%")]
        ExtraDamageTakenFromCritWhileNoPowerChargesPosPct = 6072,
        [Description("Chest Display Weylams War")]
        ChestDisplayWeylamsWar = 6073,
        [Description("Minion Movement Speed +% Per 50 Dex")]
        MinionMovementSpeedPosPctPer50Dex = 6074,
        [Description("Minion Attack Speed +% Per 50 Dex")]
        MinionAttackSpeedPosPctPer50Dex = 6075,
        [Description("Main Hand Attack Minimum Added Lightning Damage Per 10 Int")]
        MainHandAttackMinimumAddedLightningDamagePer10Int = 6076,
        [Description("Main Hand Attack Maximum Added Lightning Damage Per 10 Int")]
        MainHandAttackMaximumAddedLightningDamagePer10Int = 6077,
        [Description("Off Hand Attack Minimum Added Lightning Damage Per 10 Int")]
        OffHandAttackMinimumAddedLightningDamagePer10Int = 6078,
        [Description("Off Hand Attack Maximum Added Lightning Damage Per 10 Int")]
        OffHandAttackMaximumAddedLightningDamagePer10Int = 6079,
        [Description("Main Hand Attack Minimum Added Fire Damage Per 10 Strength")]
        MainHandAttackMinimumAddedFireDamagePer10Strength = 6080,
        [Description("Main Hand Attack Maximum Added Fire Damage Per 10 Strength")]
        MainHandAttackMaximumAddedFireDamagePer10Strength = 6081,
        [Description("Off Hand Attack Minimum Added Fire Damage Per 10 Strength")]
        OffHandAttackMinimumAddedFireDamagePer10Strength = 6082,
        [Description("Off Hand Attack Maximum Added Fire Damage Per 10 Strength")]
        OffHandAttackMaximumAddedFireDamagePer10Strength = 6083,
        [Description("Fire Beam Start Angle Offset Variance")]
        FireBeamStartAngleOffsetVariance = 6084,
        [Description("Display Monster May Inflict Bleeding")]
        DisplayMonsterMayInflictBleeding = 6085,
        [Description("Combined Bleeding Damage Over Time +%")]
        CombinedBleedingDamageOverTimePosPct = 6086,
        [Description("Combined Bleeding Damage Over Time +% Final")]
        CombinedBleedingDamageOverTimePosPctFinal = 6087,
        [Description("Bleeding Damage +%")]
        BleedingDamagePosPct = 6088,
        [Description("Active Skill Bleeding Damage +% Final")]
        ActiveSkillBleedingDamagePosPctFinal = 6089,
        [Description("Frog God Number Of Orbs To Summon")]
        FrogGodNumberOfOrbsToSummon = 6090,
        [Description("Combined Ignite Damage Over Time +% Final")]
        CombinedIgniteDamageOverTimePosPctFinal = 6091,
        [Description("Physical Damage With Attack Skills +%")]
        PhysicalDamageWithAttackSkillsPosPct = 6092,
        [Description("Elemental Damage With Attack Skills +%")]
        ElementalDamageWithAttackSkillsPosPct = 6093,
        [Description("Fire Damage With Attack Skills +%")]
        FireDamageWithAttackSkillsPosPct = 6094,
        [Description("Cold Damage With Attack Skills +%")]
        ColdDamageWithAttackSkillsPosPct = 6095,
        [Description("Lightning Damage With Attack Skills +%")]
        LightningDamageWithAttackSkillsPosPct = 6096,
        [Description("Chaos Damage With Attack Skills +%")]
        ChaosDamageWithAttackSkillsPosPct = 6097,
        [Description("Doedre Aura Damage +% Final")]
        DoedreAuraDamagePosPctFinal = 6098,
        [Description("Base Fire Damage % Of Maximum Life Plus Maximum Es To Deal Per Minute")]
        BaseFireDamagePctOfMaximumLifePlusMaximumESToDealPerMinute = 6099,
        [Description("Cast At Teleport Start %")]
        CastAtTeleportStartPct = 6100,
        [Description("Cast At Teleport End %")]
        CastAtTeleportEndPct = 6101,
        [Description("Summoned Monsters Are Parented To My Target")]
        SummonedMonstersAreParentedToMyTarget = 6102,
        [Description("Cast At Mortar Impact %")]
        CastAtMortarImpactPct = 6103,
        [Description("Mortar Has Triggered Skills")]
        MortarHasTriggeredSkills = 6104,
        [Description("Active Skill Base Attack Damage Final Permyriad")]
        ActiveSkillBaseAttackDamageFinalPermyriad = 6105,
        [Description("Map Bosses Have Summon Zombie Giant")]
        MapBossesHaveSummonZombieGiant = 6106,
        [Description("Monster Spawn Bloodlines Zombie Giant")]
        MonsterSpawnBloodlinesZombieGiant = 6107,
        [Description("Base Critical Degen Multiplier")]
        BaseCriticalDegenMultiplier = 6108,
        [Description("Critical Degen Multiplier From Main Hand")]
        CriticalDegenMultiplierFromMainHand = 6109,
        [Description("Critical Degen Multiplier From Off Hand")]
        CriticalDegenMultiplierFromOffHand = 6110,
        [Description("Critical Degen Multiplier From Spell")]
        CriticalDegenMultiplierFromSpell = 6111,
        [Description("Critical Degen Multiplier From Secondary")]
        CriticalDegenMultiplierFromSecondary = 6112,
        [Description("Monster Ignite Damage +% Final")]
        MonsterIgniteDamagePosPctFinal = 6113,
        [Description("Monster Bleeding Damage +% Final")]
        MonsterBleedingDamagePosPctFinal = 6114,
        [Description("Monster Poison Damage +% Final")]
        MonsterPoisonDamagePosPctFinal = 6115,
        [Description("Combined Poison Damage Over Time +% Final")]
        CombinedPoisonDamageOverTimePosPctFinal = 6116,
        [Description("Bleeding Moving Damage % Of Base Override")]
        BleedingMovingDamagePctOfBaseOverride = 6117,
        [Description("Active Skill If Used Through Frostbolt Damage +% Final")]
        ActiveSkillIfUsedThroughFrostboltDamagePosPctFinal = 6118,
        [Description("Used Through Frostbolt")]
        UsedThroughFrostbolt = 6119,
        [Description("Display Monster May Inflict Maim")]
        DisplayMonsterMayInflictMaim = 6120,
        [Description("Support Attack Skills Elemental Damage +% Final")]
        SupportAttackSkillsElementalDamagePosPctFinal = 6121,
        [Description("Elemental Damage With Attack Skills +% While Using Flask")]
        ElementalDamageWithAttackSkillsPosPctWhileUsingFlask = 6122,
        [Description("Support Burning Damage +% Final")]
        SupportBurningDamagePosPctFinal = 6123,
        [Description("Bleeding Skill Effect Duration")]
        BleedingSkillEffectDuration = 6124,
        [Description("Bleed Duration Is Skill Duration")]
        BleedDurationIsSkillDuration = 6125,
        [Description("Base All Ailment Duration +%")]
        BaseAllAilmentDurationPosPct = 6126,
        [Description("Shocked Enemies Explode For % Life As Lightning Damage")]
        ShockedEnemiesExplodeForPctLifeAsLightningDamage = 6127,
        [Description("Track Number Of Enemies Shocked Recently")]
        TrackNumberOfEnemiesShockedRecently = 6128,
        [Description("Number Of Enemies Shocked Recently")]
        NumberOfEnemiesShockedRecently = 6129,
        [Description("Damage +% If You Have Shocked Recently")]
        DamagePosPctIfYouHaveShockedRecently = 6130,
        [Description("Herald Mana Reservation Override 45%")]
        HeraldManaReservationOverride45Pct = 6131,
        [Description("Avoid Stun 35% Per Active Herald")]
        AvoidStun35PctPerActiveHerald = 6132,
        [Description("Number Of Active Heralds")]
        NumberOfActiveHeralds = 6133,
        [Description("Base Avoid Stun %")]
        BaseAvoidStunPct = 6134,
        [Description("Herald Of Ash Burning Damage +% Final")]
        HeraldOfAshBurningDamagePosPctFinal = 6135,
        [Description("Depair Bear Upheaval Movement Speed +%")]
        DepairBearUpheavalMovementSpeedPosPct = 6136,
        [Description("Virtual Ignite Faster Burn %")]
        VirtualIgniteFasterBurnPct = 6137,
        [Description("Kill Traps Mines And Totems On Death")]
        KillTrapsMinesAndTotemsOnDeath = 6138,
        [Description("Chest Drop X Divination Cards")]
        ChestDropXDivinationCards = 6139,
        [Description("Chest Drop Divination Cards With Full Stack Number X")]
        ChestDropDivinationCardsWithFullStackNumberX = 6140,
        [Description("Keystone Ailment Crit")]
        KeystoneAilmentCrit = 6141,
        [Description("Fire Beam Prioritise Players For Targeting")]
        FireBeamPrioritisePlayersForTargeting = 6142,
        [Description("Support Ignite Proliferation Radius")]
        SupportIgniteProliferationRadius = 6143,
        [Description("Support Maimed Enemies Physical Damage Taken +%")]
        SupportMaimedEnemiesPhysicalDamageTakenPosPct = 6144,
        [Description("Support Chance To Ignite Fire Damage +% Final")]
        SupportChanceToIgniteFireDamagePosPctFinal = 6145,
        [Description("Support Better Ailments Ailment Damage +% Final")]
        SupportBetterAilmentsAilmentDamagePosPctFinal = 6146,
        [Description("Support Better Ailments Hit Damage +% Final")]
        SupportBetterAilmentsHitDamagePosPctFinal = 6147,
        [Description("Additional Chaos Resistance Against Damage Over Time %")]
        AdditionalChaosResistanceAgainstDamageOverTimePct = 6148,
        [Description("From Code Active Skill Hit Damage +% Final")]
        FromCodeActiveSkillHitDamagePosPctFinal = 6149,
        [Description("Hit Damage +%")]
        HitDamagePosPct = 6150,
        [Description("Uncapped Chaos Damage Over Time Resistance %")]
        UncappedChaosDamageOverTimeResistancePct = 6151,
        [Description("Attack Cast Movement Speed +% If Taken A Savage Hit Recently")]
        AttackCastMovementSpeedPosPctIfTakenASavageHitRecently = 6152,
        [Description("Chaos Resistance % For You And Allies Affected By Your Auras")]
        ChaosResistancePctForYouAndAlliesAffectedByYourAuras = 6153,
        [Description("Additional Block Chance % For You And Allies Affected By Your Auras")]
        AdditionalBlockChancePctForYouAndAlliesAffectedByYourAuras = 6154,
        [Description("Attack Cast Movement Speed +% For You And Allies Affected By Your Auras")]
        AttackCastMovementSpeedPosPctForYouAndAlliesAffectedByYourAuras = 6155,
        [Description("Mana Regeneration Rate Per Minute If Used Movement Skill Recently")]
        ManaRegenerationRatePerMinuteIfUsedMovementSkillRecently = 6156,
        [Description("Movement Speed +% If Placed Trap Or Mine Recently")]
        MovementSpeedPosPctIfPlacedTrapOrMineRecently = 6157,
        [Description("Trap And Mine Damage +% If Armed For 4 Seconds")]
        TrapAndMineDamagePosPctIfArmedFor4Seconds = 6158,
        [Description("Skill Effect And Damaging Ailment Duration +%")]
        SkillEffectAndDamagingAilmentDurationPosPct = 6159,
        [Description("Active Skill Damage Over Time From Projectile Hits +% Final")]
        ActiveSkillDamageOverTimeFromProjectileHitsPosPctFinal = 6160,
        [Description("Trigger Spawners Time Between Min Ms")]
        TriggerSpawnersTimeBetweenMinMs = 6161,
        [Description("Trigger Spawners Time Between Max Ms")]
        TriggerSpawnersTimeBetweenMaxMs = 6162,
        [Description("Cast On Delayed Skill Trigger %")]
        CastOnDelayedSkillTriggerPct = 6163,
        [Description("Track Have Used Movement Skill Recently")]
        TrackHaveUsedMovementSkillRecently = 6164,
        [Description("Have Used Movement Skill Recently")]
        HaveUsedMovementSkillRecently = 6165,
        [Description("Track Have Placed Trap Or Mine Recently")]
        TrackHavePlacedTrapOrMineRecently = 6166,
        [Description("Have Placed Trap Or Mine Recently")]
        HavePlacedTrapOrMineRecently = 6167,
        [Description("Blast Rain No Los Required")]
        BlastRainNoLosRequired = 6168,
        [Description("Despair Bear Upheaval Physical Damage To Deal Per Minute")]
        DespairBearUpheavalPhysicalDamageToDealPerMinute = 6169,
        [Description("Number Of Additional Ignites Allowed")]
        NumberOfAdditionalIgnitesAllowed = 6170,
        [Description("Cast On Trigger Charge Event %")]
        CastOnTriggerChargeEventPct = 6171,
        [Description("Monster Can Drop Hinekoras Sight")]
        MonsterCanDropHinekorasSight = 6172,
        [Description("Support Efficacy Spell Damage +% Final")]
        SupportEfficacySpellDamagePosPctFinal = 6173,
        [Description("Support Efficacy Damage Over Time +% Final")]
        SupportEfficacyDamageOverTimePosPctFinal = 6174,
        [Description("Support Debilitate Poison Damage +% Final")]
        SupportDebilitatePoisonDamagePosPctFinal = 6175,
        [Description("Support Debilitate Hit Damage +% Final")]
        SupportDebilitateHitDamagePosPctFinal = 6176,
        [Description("Support Debilitate Hit Damage +% Final Per Poison Stack")]
        SupportDebilitateHitDamagePosPctFinalPerPoisonStack = 6177,
        [Description("Support Debilitate Hit Damage Max Poison Stacks")]
        SupportDebilitateHitDamageMaxPoisonStacks = 6178,
        [Description("Support Minimum Added Fire Damage Vs Burning Enemies")]
        SupportMinimumAddedFireDamageVsBurningEnemies = 6179,
        [Description("Support Maximum Added Fire Damage Vs Burning Enemies")]
        SupportMaximumAddedFireDamageVsBurningEnemies = 6180,
        [Description("Support Unbound Ailments Ailment Damage +% Final")]
        SupportUnboundAilmentsAilmentDamagePosPctFinal = 6181,
        [Description("Trigger Charge Additional Block Chance Against Projectiles %")]
        TriggerChargeAdditionalBlockChanceAgainstProjectilesPct = 6182,
        [Description("Chaos Damage Resistance Is Doubled")]
        ChaosDamageResistanceIsDoubled = 6183,
        [Description("Skill Area Of Effect +% While No Frenzy Charges")]
        SkillAreaOfEffectPosPctWhileNoFrenzyCharges = 6184,
        [Description("Global Critical Strike Multiplier + While You Have No Frenzy Charges")]
        GlobalCriticalStrikeMultiplierPosWhileYouHaveNoFrenzyCharges = 6185,
        [Description("Gain Maximum Power Charges On Power Charge Gained % Chance")]
        GainMaximumPowerChargesOnPowerChargeGainedPctChance = 6186,
        [Description("Damage +% Per Power Charge")]
        DamagePosPctPerPowerCharge = 6187,
        [Description("Base Fire Damage Can Poison")]
        BaseFireDamageCanPoison = 6188,
        [Description("Base Cold Damage Can Poison")]
        BaseColdDamageCanPoison = 6189,
        [Description("Base Lightning Damage Can Poison")]
        BaseLightningDamageCanPoison = 6190,
        [Description("Fire Skills Chance To Poison On Hit %")]
        FireSkillsChanceToPoisonOnHitPct = 6191,
        [Description("Cold Skills Chance To Poison On Hit %")]
        ColdSkillsChanceToPoisonOnHitPct = 6192,
        [Description("Lightning Skills Chance To Poison On Hit %")]
        LightningSkillsChanceToPoisonOnHitPct = 6193,
        [Description("Movement Attack Skills Attack Speed +%")]
        MovementAttackSkillsAttackSpeedPosPct = 6194,
        [Description("Local Socketed Herald Gem Level +")]
        LocalSocketedHeraldGemLevelPos = 6195,
        [Description("Cold Damage +% If You Have Used A Fire Skill Recently")]
        ColdDamagePosPctIfYouHaveUsedAFireSkillRecently = 6196,
        [Description("Fire Damage +% If You Have Used A Cold Skill Recently")]
        FireDamagePosPctIfYouHaveUsedAColdSkillRecently = 6197,
        [Description("Track Have Used A Cold Skill Recently")]
        TrackHaveUsedAColdSkillRecently = 6198,
        [Description("Have Used A Cold Skill Recently")]
        HaveUsedAColdSkillRecently = 6199,
        [Description("Support Maim Chance Physical Damage +% Final")]
        SupportMaimChancePhysicalDamagePosPctFinal = 6200,
        [Description("Support Brutality Physical Damage +% Final")]
        SupportBrutalityPhysicalDamagePosPctFinal = 6201,
        [Description("Summon Specific Monsters In Front Offset")]
        SummonSpecificMonstersInFrontOffset = 6202,
        [Description("Trap And Mine Damage Penetrates % Elemental Resistance")]
        TrapAndMineDamagePenetratesPctElementalResistance = 6203,
        [Description("Cooldown Speed +% Per Additional Player")]
        CooldownSpeedPosPctPerAdditionalPlayer = 6204,
        [Description("Total Damage Taken Per Minute To Mana")]
        TotalDamageTakenPerMinuteToMana = 6205,
        [Description("Total Damage Taken Per Minute That Bypasses Es")]
        TotalDamageTakenPerMinuteThatBypassesEs = 6206,
        [Description("Total Damage Taken Per Minute That Damages Es")]
        TotalDamageTakenPerMinuteThatDamagesEs = 6207,
        [Description("Total Nonlethal Damage Taken Per Minute That Damages Es")]
        TotalNonlethalDamageTakenPerMinuteThatDamagesEs = 6208,
        [Description("Enemies That Hit You With Attack Recently Attack Speed +%")]
        EnemiesThatHitYouWithAttackRecentlyAttackSpeedPosPct = 6209,
        [Description("Vaal Skill Soul Cost +%")]
        VaalSkillSoulCostPosPct = 6210,
        [Description("Has Attacker Projectile Attack Conditional Damage Stats")]
        HasAttackerProjectileAttackConditionalDamageStats = 6211,
        [Description("Has Attacker Conditional Damage Stats")]
        HasAttackerConditionalDamageStats = 6212,
        [Description("Has Attacker Projectile Spell Conditional Damage Stats")]
        HasAttackerProjectileSpellConditionalDamageStats = 6213,
        [Description("Number Of Projectiles Override")]
        NumberOfProjectilesOverride = 6214,
        [Description("Map Pantheon Flask Capture Boss Soul")]
        MapPantheonFlaskCaptureBossSoul = 6215,
        [Description("Physical Damage Over Time Taken +% While Moving")]
        PhysicalDamageOverTimeTakenPosPctWhileMoving = 6216,
        [Description("Physical Damage Reduction % If Only One Enemy Nearby")]
        PhysicalDamageReductionPctIfOnlyOneEnemyNearby = 6217,
        [Description("Take Half Area Damage From Hit % Chance")]
        TakeHalfAreaDamageFromHitPctChance = 6218,
        [Description("Elemental Damage Taken +% If Not Hit Recently")]
        ElementalDamageTakenPosPctIfNotHitRecently = 6219,
        [Description("Self Take No Extra Damage From Critical Strikes If Have Been Crit Recently")]
        SelfTakeNoExtraDamageFromCriticalStrikesIfHaveBeenCritRecently = 6220,
        [Description("Have Been Crit Recently")]
        HaveBeenCritRecently = 6221,
        [Description("Track Have Been Crit Recently")]
        TrackHaveBeenCritRecently = 6222,
        [Description("Avoid Ailments % From Crit")]
        AvoidAilmentsPctFromCrit = 6223,
        [Description("Physical Damage Reduction % Per Nearby Enemy")]
        PhysicalDamageReductionPctPerNearbyEnemy = 6224,
        [Description("Movement Speed +% Per Nearby Enemy")]
        MovementSpeedPosPctPerNearbyEnemy = 6225,
        [Description("Base Avoid Projectiles % Chance")]
        BaseAvoidProjectilesPctChance = 6226,
        [Description("Dodge Attacks And Spells % Chance If Have Been Hit Recently")]
        DodgeAttacksAndSpellsPctChanceIfHaveBeenHitRecently = 6227,
        [Description("Prevent Projectile Chaining % Chance")]
        PreventProjectileChainingPctChance = 6228,
        [Description("Avoid Chained Projectile % Chance")]
        AvoidChainedProjectilePctChance = 6229,
        [Description("Cold Damage Taken +% If Have Been Hit Recently")]
        ColdDamageTakenPosPctIfHaveBeenHitRecently = 6230,
        [Description("Reflect Chill And Freeze % Chance")]
        ReflectChillAndFreezePctChance = 6231,
        [Description("Virtual Self Take No Extra Damage From Critical Strikes")]
        VirtualSelfTakeNoExtraDamageFromCriticalStrikes = 6232,
        [Description("Projectile Spread Radius Per Additional Projectile")]
        ProjectileSpreadRadiusPerAdditionalProjectile = 6233,
        [Description("Trigger Cascade Number Of Spikes")]
        TriggerCascadeNumberOfSpikes = 6234,
        [Description("Trigger Cascade Ms Between Spikes")]
        TriggerCascadeMsBetweenSpikes = 6235,
        [Description("Cast On Trigger Cascade Event %")]
        CastOnTriggerCascadeEventPct = 6236,
        [Description("Trigger Cascade Behaviour Variation")]
        TriggerCascadeBehaviourVariation = 6237,
        [Description("Garukhan Number Of Tornadoes")]
        GarukhanNumberOfTornadoes = 6238,
        [Description("Map Pack Subindex Override")]
        MapPackSubindexOverride = 6239,
        [Description("Map Boss Override")]
        MapBossOverride = 6240,
        [Description("Map Daily Mission Master Level")]
        MapDailyMissionMasterLevel = 6241,
        [Description("Number Of Nearby Enemies")]
        NumberOfNearbyEnemies = 6242,
        [Description("Track Number Of Nearby Enemies")]
        TrackNumberOfNearbyEnemies = 6243,
        [Description("Volatile Flameblood Spawn Monster On Death Variation")]
        VolatileFlamebloodSpawnMonsterOnDeathVariation = 6244,
        [Description("Hit And Poison Damage +%")]
        HitAndPoisonDamagePosPct = 6245,
        [Description("Hit And Poison Damage +% Per Poison On Enemy")]
        HitAndPoisonDamagePosPctPerPoisonOnEnemy = 6246,
        [Description("Attack Minimum Added Physical Damage With Weapons")]
        AttackMinimumAddedPhysicalDamageWithWeapons = 6247,
        [Description("Attack Maximum Added Physical Damage With Weapons")]
        AttackMaximumAddedPhysicalDamageWithWeapons = 6248,
        [Description("Trigger On Projectile Loop Count")]
        TriggerOnProjectileLoopCount = 6249,
        [Description("Trigger On Projectile Death")]
        TriggerOnProjectileDeath = 6250,
        [Description("Base Number Of Beast Minions Allowed")]
        BaseNumberOfBeastMinionsAllowed = 6251,
        [Description("Number Of Beast Minions Allowed")]
        NumberOfBeastMinionsAllowed = 6252,
        [Description("Local Display Grants Summon Beast Companion")]
        LocalDisplayGrantsSummonBeastCompanion = 6253,
        [Description("Molten Shell Explosion Cooldown Ms")]
        MoltenShellExplosionCooldownMs = 6254,
        [Description("From Code Active Skill Hit And Ailment Damage +% Final")]
        FromCodeActiveSkillHitAndAilmentDamagePosPctFinal = 6255,
        [Description("Tornado Movement Velocity +%")]
        TornadoMovementVelocityPosPct = 6256,
        [Description("Monster Aggro Radius +%")]
        MonsterAggroRadiusPosPct = 6257,
        [Description("Ground Ice Art Variation")]
        GroundIceArtVariation = 6258,
        [Description("Additional Projectiles Fire Parallel X Dist")]
        AdditionalProjectilesFireParallelXDist = 6259,
        [Description("Additional Projectiles Fire Parallel Y Dist")]
        AdditionalProjectilesFireParallelYDist = 6260,
        [Description("From Code Active Skill Ailment Damage +% Final")]
        FromCodeActiveSkillAilmentDamagePosPctFinal = 6261,
        [Description("Flameblast Ailment Damage +% Final Per Stack")]
        FlameblastAilmentDamagePosPctFinalPerStack = 6262,
        [Description("Trigger Cascade A")]
        TriggerCascadeA = 6263,
        [Description("Trigger Cascade B")]
        TriggerCascadeB = 6264,
        [Description("Trigger Cascade C")]
        TriggerCascadeC = 6265,
        [Description("Trigger Cascade D")]
        TriggerCascadeD = 6266,
        [Description("Trigger Cascade Angle")]
        TriggerCascadeAngle = 6267,
        [Description("Local Use Skill On Hit %")]
        LocalUseSkillOnHitPct = 6268,
        [Description("Main Hand Use Skill On Hit %")]
        MainHandUseSkillOnHitPct = 6269,
        [Description("Off Hand Use Skill On Hit %")]
        OffHandUseSkillOnHitPct = 6270,
        [Description("Skill Has Trigger From Unique Item")]
        SkillHasTriggerFromUniqueItem = 6271,
        [Description("Local Display Use Level X Abyssal Cry On Hit")]
        LocalDisplayUseLevelXAbyssalCryOnHit = 6272,
        [Description("Accelerate Min")]
        AccelerateMin = 6273,
        [Description("Accelerate Max")]
        AccelerateMax = 6274,
        [Description("Accelerate Time")]
        AccelerateTime = 6275,
        [Description("Skill Is Minion Skill")]
        SkillIsMinionSkill = 6276,
        [Description("Minion Skill Mana Cost +%")]
        MinionSkillManaCostPosPct = 6277,
        [Description("Local Display Grants Skill Doryanis Touch Level")]
        LocalDisplayGrantsSkillDoryanisTouchLevel = 6278,
        [Description("Trigger Cascade Target Variation")]
        TriggerCascadeTargetVariation = 6279,
        [Description("Trigger Cascade Number Of Arms")]
        TriggerCascadeNumberOfArms = 6280,
        [Description("Trigger Cascade Angle Between Arms")]
        TriggerCascadeAngleBetweenArms = 6281,
        [Description("Support Ruthless Big Hit Max Count")]
        SupportRuthlessBigHitMaxCount = 6282,
        [Description("Melee Damage +% Final From Ruthless Blow")]
        MeleeDamagePosPctFinalFromRuthlessBlow = 6283,
        [Description("Stun Base Duration Override Ms")]
        StunBaseDurationOverrideMs = 6284,
        [Description("Support Ruthless Big Hit Stun Base Duration Override Ms")]
        SupportRuthlessBigHitStunBaseDurationOverrideMs = 6285,
        [Description("Support Ruthless Big Hit Damage +% Final")]
        SupportRuthlessBigHitDamagePosPctFinal = 6286,
        [Description("Support Scion Onslaught On Killing Blow % Chance")]
        SupportScionOnslaughtOnKillingBlowPctChance = 6287,
        [Description("Support Scion Onslaught On Killing Blow Duration Ms")]
        SupportScionOnslaughtOnKillingBlowDurationMs = 6288,
        [Description("Support Arcane Surge Gain Buff On Mana Use Threshold")]
        SupportArcaneSurgeGainBuffOnManaUseThreshold = 6289,
        [Description("Support Arcane Surge Spell Damage +% Final")]
        SupportArcaneSurgeSpellDamagePosPctFinal = 6290,
        [Description("Spell Damage +% Final From Arcane Surge")]
        SpellDamagePosPctFinalFromArcaneSurge = 6291,
        [Description("Support Arcane Surge Duration Ms")]
        SupportArcaneSurgeDurationMs = 6292,
        [Description("Support Arcane Surge Base Duration Ms")]
        SupportArcaneSurgeBaseDurationMs = 6293,
        [Description("Support Arcane Surge Cast Speed +%")]
        SupportArcaneSurgeCastSpeedPosPct = 6294,
        [Description("Support Arcane Surge Mana Regeneration Rate Per Minute %")]
        SupportArcaneSurgeManaRegenerationRatePerMinutePct = 6295,
        [Description("Hidden Monster Can Have Auras")]
        HiddenMonsterCanHaveAuras = 6296,
        [Description("Projectile Number Of Targets To Pierce")]
        ProjectileNumberOfTargetsToPierce = 6297,
        [Description("Arrow Number Of Targets To Pierce")]
        ArrowNumberOfTargetsToPierce = 6298,
        [Description("Projectile Base Number Of Targets To Pierce")]
        ProjectileBaseNumberOfTargetsToPierce = 6299,
        [Description("Arrow Base Number Of Targets To Pierce")]
        ArrowBaseNumberOfTargetsToPierce = 6300,
        [Description("Arrows Always Pierce")]
        ArrowsAlwaysPierce = 6301,
        [Description("Base Arrows Always Pierce")]
        BaseArrowsAlwaysPierce = 6302,
        [Description("Virtual Always Pierce")]
        VirtualAlwaysPierce = 6303,
        [Description("Support Ignite Prolif Ignite Damage +% Final")]
        SupportIgniteProlifIgniteDamagePosPctFinal = 6304,
        [Description("Combined Ailment All Damage Over Time +% Final")]
        CombinedAilmentAllDamageOverTimePosPctFinal = 6305,
        [Description("Projectiles Always Pierce You")]
        ProjectilesAlwaysPierceYou = 6306,
        [Description("Arrow Damage +% Vs Pierced Targets")]
        ArrowDamagePosPctVsPiercedTargets = 6307,
        [Description("Projectiles Pierce X Additional Targets While You Have Phasing")]
        ProjectilesPierceXAdditionalTargetsWhileYouHavePhasing = 6308,
        [Description("Quiver Projectiles Pierce 1 Additional Target")]
        QuiverProjectilesPierce1AdditionalTarget = 6309,
        [Description("Quiver Projectiles Pierce 2 Additional Targets")]
        QuiverProjectilesPierce2AdditionalTargets = 6310,
        [Description("Quiver Projectiles Pierce 3 Additional Targets")]
        QuiverProjectilesPierce3AdditionalTargets = 6311,
        [Description("Projectiles Pierce All Nearby Targets")]
        ProjectilesPierceAllNearbyTargets = 6312,
        [Description("Projectiles Pierce 1 Additional Target Per 10 Stat Value")]
        ProjectilesPierce1AdditionalTargetPer10StatValue = 6313,
        [Description("Projectiles Pierce 1 Additional Target Per 15 Stat Value")]
        ProjectilesPierce1AdditionalTargetPer15StatValue = 6314,
        [Description("Talisman Implicit Projectiles Pierce 1 Additional Target Per 10")]
        TalismanImplicitProjectilesPierce1AdditionalTargetPer10 = 6315,
        [Description("Blade Vortex Ailment Damage +% Per Blade Final")]
        BladeVortexAilmentDamagePosPctPerBladeFinal = 6316,
        [Description("Bladefall Width +%")]
        BladefallWidthPosPct = 6317,
        [Description("Lightning Strike Additional Pierce Per 10 Old")]
        LightningStrikeAdditionalPiercePer10Old = 6318,
        [Description("Lightning Strike Additional Pierce")]
        LightningStrikeAdditionalPierce = 6319,
        [Description("Lightning Trap Additional Pierce Per 10 Old")]
        LightningTrapAdditionalPiercePer10Old = 6320,
        [Description("Lightning Trap Additional Pierce")]
        LightningTrapAdditionalPierce = 6321,
        [Description("Support Poison Poison Damage +% Final")]
        SupportPoisonPoisonDamagePosPctFinal = 6322,
        [Description("Attacks Chance To Poison % On Max Frenzy Charges")]
        AttacksChanceToPoisonPctOnMaxFrenzyCharges = 6323,
        [Description("Chance To Poison % Vs Cursed Enemies")]
        ChanceToPoisonPctVsCursedEnemies = 6324,
        [Description("Chaos Damage Chance To Poison %")]
        ChaosDamageChanceToPoisonPct = 6325,
        [Description("Virtual Chance To Poison On Hit With Attacks %")]
        VirtualChanceToPoisonOnHitWithAttacksPct = 6326,
        [Description("Support Innervate Minimum Added Lightning Damage")]
        SupportInnervateMinimumAddedLightningDamage = 6327,
        [Description("Support Innervate Maximum Added Lightning Damage")]
        SupportInnervateMaximumAddedLightningDamage = 6328,
        [Description("Support Innervate Buff Duration Ms")]
        SupportInnervateBuffDurationMs = 6329,
        [Description("Support Innervate Buff Base Duration Ms")]
        SupportInnervateBuffBaseDurationMs = 6330,
        [Description("Local Unique Jewel Spark Projectiles Nova With 40 Int In Radius")]
        LocalUniqueJewelSparkProjectilesNovaWith40IntInRadius = 6331,
        [Description("Spark Projectiles Nova")]
        SparkProjectilesNova = 6332,
        [Description("Local Unique Jewel Spark Number Of Additional Projectiles With 40 Int In Radius")]
        LocalUniqueJewelSparkNumberOfAdditionalProjectilesWith40IntInRadius = 6333,
        [Description("Spark Number Of Additional Projectiles")]
        SparkNumberOfAdditionalProjectiles = 6334,
        [Description("Local Unique Jewel Blight Hinder Enemy Chaos Damage Taken +% With 40 Int In Radius")]
        LocalUniqueJewelBlightHinderEnemyChaosDamageTakenPosPctWith40IntInRadius = 6335,
        [Description("Blight Hinder Enemy Chaos Damage Taken +%")]
        BlightHinderEnemyChaosDamageTakenPosPct = 6336,
        [Description("Local Unique Jewel Blight Hinder Duration +% With 40 Int In Radius")]
        LocalUniqueJewelBlightHinderDurationPosPctWith40IntInRadius = 6337,
        [Description("Local Unique Jewel Split Arrow Projectiles Fire In Parallel X Dist With 40 Dex In Radius")]
        LocalUniqueJewelSplitArrowProjectilesFireInParallelXDistWith40DexInRadius = 6338,
        [Description("Split Arrow Projectiles Fire In Parallel X Dist")]
        SplitArrowProjectilesFireInParallelXDist = 6339,
        [Description("Local Unique Jewel Split Arrow Projectiles Fire In Parallel Y Dist With 40 Dex In Radius")]
        LocalUniqueJewelSplitArrowProjectilesFireInParallelYDistWith40DexInRadius = 6340,
        [Description("Split Arrow Projectiles Fire In Parallel Y Dist")]
        SplitArrowProjectilesFireInParallelYDist = 6341,
        [Description("Local Unique Jewel Fire Trap Number Of Additional Traps To Throw With 40 Dex In Radius")]
        LocalUniqueJewelFireTrapNumberOfAdditionalTrapsToThrowWith40DexInRadius = 6342,
        [Description("Fire Trap Number Of Additional Traps To Throw")]
        FireTrapNumberOfAdditionalTrapsToThrow = 6343,
        [Description("Piercing Projectiles Critical Strike Chance +%")]
        PiercingProjectilesCriticalStrikeChancePosPct = 6344,
        [Description("Arrow Damage +50% Vs Pierced Targets")]
        ArrowDamagePos50PctVsPiercedTargets = 6345,
        [Description("Arrows Pierce Additional Target")]
        ArrowsPierceAdditionalTarget = 6346,
        [Description("Ice Shot Additional Pierce Per 10 Old")]
        IceShotAdditionalPiercePer10Old = 6347,
        [Description("Local Unique Jewel Ice Shot Additional Pierce Per 10 Old With 40 Dex In Radius")]
        LocalUniqueJewelIceShotAdditionalPiercePer10OldWith40DexInRadius = 6348,
        [Description("Virtual Cooldown Modifier Ms")]
        VirtualCooldownModifierMs = 6349,
        [Description("Base Cooldown Modifier Ms")]
        BaseCooldownModifierMs = 6350,
        [Description("Summon Skeletons Cooldown Modifier Ms")]
        SummonSkeletonsCooldownModifierMs = 6351,
        [Description("Trigger Cascade Use Contact Points")]
        TriggerCascadeUseContactPoints = 6352,
        [Description("Arrows Pierce 1 Additional Target Per 10 Stat Value")]
        ArrowsPierce1AdditionalTargetPer10StatValue = 6353,
        [Description("Summon Skeletons Additional Warrior Skeleton % Chance")]
        SummonSkeletonsAdditionalWarriorSkeletonPctChance = 6354,
        [Description("Map Spawn Harbingers")]
        MapSpawnHarbingers = 6355,
        [Description("Map Num Extra Harbingers")]
        MapNumExtraHarbingers = 6356,
        [Description("Map Packs Are Lunaris")]
        MapPacksAreLunaris = 6357,
        [Description("Map Packs Are Solaris")]
        MapPacksAreSolaris = 6358,
        [Description("Map Packs Are Ghosts")]
        MapPacksAreGhosts = 6359,
        [Description("Skeletal Chains No Minions Radius +")]
        SkeletalChainsNoMinionsRadiusPos = 6360,
        [Description("Skeletal Chains No Minions Targets Self")]
        SkeletalChainsNoMinionsTargetsSelf = 6361,
        [Description("Ice Shot Pierce +")]
        IceShotPiercePos = 6362,
        [Description("Local Unique Jewel Ice Shot Pierce + With 40 Dex In Radius")]
        LocalUniqueJewelIceShotPiercePosWith40DexInRadius = 6363,
        [Description("Non Damaging Ailment Effect +%")]
        NonDamagingAilmentEffectPosPct = 6364,
        [Description("Bleeding Stacks Up To X Times")]
        BleedingStacksUpToXTimes = 6365,
        [Description("Energy Shield Recharge Start When Stunned")]
        EnergyShieldRechargeStartWhenStunned = 6366,
        [Description("No Extra Bleed Damage While Target Is Moving")]
        NoExtraBleedDamageWhileTargetIsMoving = 6367,
        [Description("Track Which Enemies Hit")]
        TrackWhichEnemiesHit = 6368,
        [Description("Skill Behaviour Variation")]
        SkillBehaviourVariation = 6369,
        [Description("Trigger Skill Restriction")]
        TriggerSkillRestriction = 6370,
        [Description("Prophecy Monster Spawn Level")]
        ProphecyMonsterSpawnLevel = 6371,
        [Description("Number Of Skeletons Allowed Per 2 Old")]
        NumberOfSkeletonsAllowedPer2Old = 6372,
        [Description("Cast On Trigger Cascade Event")]
        CastOnTriggerCascadeEvent = 6373,
        [Description("Spark Skill Effect Duration +%")]
        SparkSkillEffectDurationPosPct = 6374,
        [Description("Support Innervate Gain Buff On Killing Shocked Enemy")]
        SupportInnervateGainBuffOnKillingShockedEnemy = 6375,
        [Description("Additional Critical Strike Chance Permyriad While At Maximum Power Charges")]
        AdditionalCriticalStrikeChancePermyriadWhileAtMaximumPowerCharges = 6376,
        [Description("Object Inherent Spell Damage +% Final Per Power Charge")]
        ObjectInherentSpellDamagePosPctFinalPerPowerCharge = 6377,
        [Description("Damage Over Time +% Per Frenzy Charge")]
        DamageOverTimePosPctPerFrenzyCharge = 6378,
        [Description("Damage Over Time +% Per Power Charge")]
        DamageOverTimePosPctPerPowerCharge = 6379,
        [Description("Gain Frenzy And Power Charge On Kill %")]
        GainFrenzyAndPowerChargeOnKillPct = 6380,
        [Description("Maximum Power And Frenzy Charges +")]
        MaximumPowerAndFrenzyChargesPos = 6381,
        [Description("Labyrinth Darkshrine Players Damage Taken From Labyrinth Traps +%")]
        LabyrinthDarkshrinePlayersDamageTakenFromLabyrinthTrapsPosPct = 6382,
        [Description("Labyrinth Darkshrine Boss Room Traps Are Disabled")]
        LabyrinthDarkshrineBossRoomTrapsAreDisabled = 6383,
        [Description("Labyrinth Darkshrine Players Have Shrine Row X Effect For This Labyrinth")]
        LabyrinthDarkshrinePlayersHaveShrineRowXEffectForThisLabyrinth = 6384,
        [Description("Labyrinth Darkshrine Divine Font Grants One Additional Enchantment Use To Player X")]
        LabyrinthDarkshrineDivineFontGrantsOneAdditionalEnchantmentUseToPlayerX = 6385,
        [Description("Labyrinth Darkshrine Izaro Drops X Additional Treasure Keys")]
        LabyrinthDarkshrineIzaroDropsXAdditionalTreasureKeys = 6386,
        [Description("Damage Taken From Labyrinth Traps +%")]
        DamageTakenFromLabyrinthTrapsPosPct = 6387,
        [Description("Labyrinth Darkshrine Izaro Dropped Unique Items +")]
        LabyrinthDarkshrineIzaroDroppedUniqueItemsPos = 6388,
        [Description("Convocation Max Number Of Minions To Teleport")]
        ConvocationMaxNumberOfMinionsToTeleport = 6389,
        [Description("Local Chance To Bleed On Hit 25%")]
        LocalChanceToBleedOnHit25Pct = 6390,
        [Description("Main Hand Local Chance To Bleed On Hit 25%")]
        MainHandLocalChanceToBleedOnHit25Pct = 6391,
        [Description("Off Hand Local Chance To Bleed On Hit 25%")]
        OffHandLocalChanceToBleedOnHit25Pct = 6392,
        [Description("Recover % Maximum Mana On Kill")]
        RecoverPctMaximumManaOnKill = 6393,
        [Description("Arctic Armour Chill When Hit Duration")]
        ArcticArmourChillWhenHitDuration = 6394,
        [Description("Debuff Time Passed +%")]
        DebuffTimePassedPosPct = 6395,
        [Description("Skill Is Channelled")]
        SkillIsChannelled = 6396,
        [Description("Channelled Skill Damage +%")]
        ChannelledSkillDamagePosPct = 6397,
        [Description("Local Display Socketed Gems Supported By X Innervate Level")]
        LocalDisplaySocketedGemsSupportedByXInnervateLevel = 6398,
        [Description("Local Display Summon Harbinger X On Equip")]
        LocalDisplaySummonHarbingerXOnEquip = 6399,
        [Description("Skeleton Movement Speed +%")]
        SkeletonMovementSpeedPosPct = 6400,
        [Description("Skeleton Attack Speed +%")]
        SkeletonAttackSpeedPosPct = 6401,
        [Description("Skeleton Cast Speed +%")]
        SkeletonCastSpeedPosPct = 6402,
        [Description("Physical Damage Over Time Taken +%")]
        PhysicalDamageOverTimeTakenPosPct = 6403,
        [Description("Summon Skeletons Additional Warrior Skeleton One Twentieth Chance")]
        SummonSkeletonsAdditionalWarriorSkeletonOneTwentiethChance = 6404,
        [Description("Leapslam Overshoot Distance")]
        LeapslamOvershootDistance = 6405,
        [Description("Skill Is Projectile Skill")]
        SkillIsProjectileSkill = 6406,
        [Description("Projectile Attack Skill Critical Strike Chance +%")]
        ProjectileAttackSkillCriticalStrikeChancePosPct = 6407,
        [Description("Storm Burst Avoid Interruption While Casting %")]
        StormBurstAvoidInterruptionWhileCastingPct = 6408,
        [Description("Storm Burst Area Of Effect +%")]
        StormBurstAreaOfEffectPosPct = 6409,
        [Description("Skeletal Chains Cast Speed +%")]
        SkeletalChainsCastSpeedPosPct = 6410,
        [Description("Skeletal Chains Area Of Effect +%")]
        SkeletalChainsAreaOfEffectPosPct = 6411,
        [Description("Unique Volkuurs Clutch Poison Duration +% Final")]
        UniqueVolkuursClutchPoisonDurationPosPctFinal = 6412,
        [Description("Combined Poison Duration +% Final")]
        CombinedPoisonDurationPosPctFinal = 6413,
        [Description("Local Display Trigger Level X Darktongue Kiss On Curse")]
        LocalDisplayTriggerLevelXDarktongueKissOnCurse = 6414,
        [Description("Cast When Cast Curse %")]
        CastWhenCastCursePct = 6415,
        [Description("Move Daemon Number Of Daemons To Spawn")]
        MoveDaemonNumberOfDaemonsToSpawn = 6416,
        [Description("Move Daemon Movement Speed")]
        MoveDaemonMovementSpeed = 6417,
        [Description("Move Daemon Distance To Travel")]
        MoveDaemonDistanceToTravel = 6418,
        [Description("Move Daemon Delay Between Daemons Ms")]
        MoveDaemonDelayBetweenDaemonsMs = 6419,
        [Description("Move Daemon Rotation")]
        MoveDaemonRotation = 6420,
        [Description("Move Daemon Rotation Per Daemon")]
        MoveDaemonRotationPerDaemon = 6421,
        [Description("Move Daemon End Rotation")]
        MoveDaemonEndRotation = 6422,
        [Description("Move Daemon End Rotation Per Daemon")]
        MoveDaemonEndRotationPerDaemon = 6423,
        [Description("Move Daemon X Offset")]
        MoveDaemonXOffset = 6424,
        [Description("Move Daemon Y Offset")]
        MoveDaemonYOffset = 6425,
        [Description("Move Daemon X Offset Per Daemon")]
        MoveDaemonXOffsetPerDaemon = 6426,
        [Description("Move Daemon Y Offset Per Daemon")]
        MoveDaemonYOffsetPerDaemon = 6427,
        [Description("Move Daemon Pivot Variation")]
        MoveDaemonPivotVariation = 6428,
        [Description("Harbinger Minion Damage Taken +% Final Min")]
        HarbingerMinionDamageTakenPosPctFinalMin = 6429,
        [Description("Harbinger Minion Damage Taken +% Final Max")]
        HarbingerMinionDamageTakenPosPctFinalMax = 6430,
        [Description("Harbinger Minion Damage Taken +% Final Time")]
        HarbingerMinionDamageTakenPosPctFinalTime = 6431,
        [Description("Harbinger Minion Rare Chance %")]
        HarbingerMinionRareChancePct = 6432,
        [Description("Harbinger Minion Magic Chance %")]
        HarbingerMinionMagicChancePct = 6433,
        [Description("Harbinger Minion Remove Parent Life On Death Permyriad")]
        HarbingerMinionRemoveParentLifeOnDeathPermyriad = 6434,
        [Description("Critical Strike Chance Increased By Lightning Resistance")]
        CriticalStrikeChanceIncreasedByLightningResistance = 6435,
        [Description("Piercing Projectiles Critical Strike Chance +100%")]
        PiercingProjectilesCriticalStrikeChancePos100Pct = 6436,
        [Description("Cast On Skill Use %")]
        CastOnSkillUsePct = 6437,
        [Description("Local Display Trigger Level X Void Gaze On Skill Use")]
        LocalDisplayTriggerLevelXVoidGazeOnSkillUse = 6438,
        [Description("Cannot Be Stunned If You Have Blocked A Stun Recently")]
        CannotBeStunnedIfYouHaveBlockedAStunRecently = 6439,
        [Description("Track Have Blocked A Stun Recently")]
        TrackHaveBlockedAStunRecently = 6440,
        [Description("Have Blocked A Stun Recently")]
        HaveBlockedAStunRecently = 6441,
        [Description("Charged Dash Damage +% Maximum")]
        ChargedDashDamagePosPctMaximum = 6442,
        [Description("Local Display Trigger Level X Storm Cascade On Attack")]
        LocalDisplayTriggerLevelXStormCascadeOnAttack = 6443,
        [Description("Empty Action State Value")]
        EmptyActionStateValue = 6444,
        [Description("Minimum Added Chaos Damage Vs Enemies With 5+ Poisons")]
        MinimumAddedChaosDamageVsEnemiesWith5PosPoisons = 6445,
        [Description("Maximum Added Chaos Damage Vs Enemies With 5+ Poisons")]
        MaximumAddedChaosDamageVsEnemiesWith5PosPoisons = 6446,
        [Description("Main Hand Minimum Added Chaos Damage Vs Enemies With 5+ Poisons")]
        MainHandMinimumAddedChaosDamageVsEnemiesWith5PosPoisons = 6447,
        [Description("Main Hand Maximum Added Chaos Damage Vs Enemies With 5+ Poisons")]
        MainHandMaximumAddedChaosDamageVsEnemiesWith5PosPoisons = 6448,
        [Description("Off Hand Minimum Added Chaos Damage Vs Enemies With 5+ Poisons")]
        OffHandMinimumAddedChaosDamageVsEnemiesWith5PosPoisons = 6449,
        [Description("Off Hand Maximum Added Chaos Damage Vs Enemies With 5+ Poisons")]
        OffHandMaximumAddedChaosDamageVsEnemiesWith5PosPoisons = 6450,
        [Description("Life Leech From Attack Damage Permyriad Vs Poisoned Enemies")]
        LifeLeechFromAttackDamagePermyriadVsPoisonedEnemies = 6451,
        [Description("Poison Duration +% Per Power Charge")]
        PoisonDurationPosPctPerPowerCharge = 6452,
        [Description("Poison Damage +% Per Frenzy Charge")]
        PoisonDamagePosPctPerFrenzyCharge = 6453,
        [Description("Gain Frenzy Charge On Kill Vs Enemies With 5+ Poisons %")]
        GainFrenzyChargeOnKillVsEnemiesWith5PosPoisonsPct = 6454,
        [Description("Gain Power Charge On Kill Vs Enemies With Less Than 5 Poisons %")]
        GainPowerChargeOnKillVsEnemiesWithLessThan5PoisonsPct = 6455,
        [Description("Local Display Socketed Gems Supported By X Lesser Poison")]
        LocalDisplaySocketedGemsSupportedByXLesserPoison = 6456,
        [Description("Poison Duration +% With Over 150 Intelligence")]
        PoisonDurationPosPctWithOver150Intelligence = 6457,
        [Description("Poison Damage +% With Over 300 Dexterity")]
        PoisonDamagePosPctWithOver300Dexterity = 6458,
        [Description("Local Display Socketed Gems Supported By X Vile Toxins")]
        LocalDisplaySocketedGemsSupportedByXVileToxins = 6459,
        [Description("Local Display Grants Skill Blight Level")]
        LocalDisplayGrantsSkillBlightLevel = 6460,
        [Description("You Cannot Be Hindered")]
        YouCannotBeHindered = 6461,
        [Description("Support Melee Physical Damage Poison And Bleeding Damage +% Final From Melee Hits")]
        SupportMeleePhysicalDamagePoisonAndBleedingDamagePosPctFinalFromMeleeHits = 6462,
        [Description("Support Phys Proj Attack Damage Bleeing And Poison Damage +% Final From Projectile Hits")]
        SupportPhysProjAttackDamageBleeingAndPoisonDamagePosPctFinalFromProjectileHits = 6463,
        [Description("Support Ruthless Blow Bleeding Damage From Melee Hits +% Final")]
        SupportRuthlessBlowBleedingDamageFromMeleeHitsPosPctFinal = 6464,
        [Description("Melee Hit Bleeding Damage +% Final From Ruthless Blow")]
        MeleeHitBleedingDamagePosPctFinalFromRuthlessBlow = 6465,
        [Description("Support Chance To Bleed Bleeding Damage +% Final")]
        SupportChanceToBleedBleedingDamagePosPctFinal = 6466,
        [Description("Charged Dash Chance To Dodge % If Finished Channelling Recently")]
        ChargedDashChanceToDodgePctIfFinishedChannellingRecently = 6467,
        [Description("Charged Dash Area Of Effect Radius + Of Final Explosion")]
        ChargedDashAreaOfEffectRadiusPosOfFinalExplosion = 6468,
        [Description("Additional Physical Damage Reduction % If Not Player")]
        AdditionalPhysicalDamageReductionPctIfNotPlayer = 6469,
        [Description("Resist All Elements % If Not Player")]
        ResistAllElementsPctIfNotPlayer = 6470,
        [Description("Physical Damage % To Gain As Chaos While At Maximum Power Charges")]
        PhysicalDamagePctToGainAsChaosWhileAtMaximumPowerCharges = 6471,
        [Description("Attack Ailment Damage +% While Wielding Dagger")]
        AttackAilmentDamagePosPctWhileWieldingDagger = 6472,
        [Description("Attack Ailment Damage +% While Wielding Claw")]
        AttackAilmentDamagePosPctWhileWieldingClaw = 6473,
        [Description("Attack Ailment Damage +% While Wielding Sword")]
        AttackAilmentDamagePosPctWhileWieldingSword = 6474,
        [Description("Attack Ailment Damage +% While Wielding Bow")]
        AttackAilmentDamagePosPctWhileWieldingBow = 6475,
        [Description("Attack Ailment Damage +% While Wielding Axe")]
        AttackAilmentDamagePosPctWhileWieldingAxe = 6476,
        [Description("Attack Ailment Damage +% While Wielding Mace")]
        AttackAilmentDamagePosPctWhileWieldingMace = 6477,
        [Description("Attack Ailment Damage +% While Wielding One Handed Weapon")]
        AttackAilmentDamagePosPctWhileWieldingOneHandedWeapon = 6478,
        [Description("Attack Ailment Damage +% While Wielding Two Handed Weapon")]
        AttackAilmentDamagePosPctWhileWieldingTwoHandedWeapon = 6479,
        [Description("Attack Ailment Damage +% While Dual Wielding")]
        AttackAilmentDamagePosPctWhileDualWielding = 6480,
        [Description("Attack Ailment Damage +% While Holding Shield")]
        AttackAilmentDamagePosPctWhileHoldingShield = 6481,
        [Description("Attack Ailment Damage +% While Wielding Melee Weapon")]
        AttackAilmentDamagePosPctWhileWieldingMeleeWeapon = 6482,
        [Description("Combined Ailment Damage +% From Weapon Types")]
        CombinedAilmentDamagePosPctFromWeaponTypes = 6483,
        [Description("Immune To Status Ailments")]
        ImmuneToStatusAilments = 6484,
        [Description("Chance To Hit While Blinded +% Final")]
        ChanceToHitWhileBlindedPosPctFinal = 6485,
        [Description("Chance To Hit +% Final")]
        ChanceToHitPosPctFinal = 6486,
        [Description("Is Summoned Harbinger Monster")]
        IsSummonedHarbingerMonster = 6487,
        [Description("Ignored By Enemy Target Selection")]
        IgnoredByEnemyTargetSelection = 6488,
        [Description("Base Ignored By Enemy Target Selection")]
        BaseIgnoredByEnemyTargetSelection = 6489,
        [Description("Map Packs Have Belly Totems")]
        MapPacksHaveBellyTotems = 6490,
        [Description("Harbinger Minion Max Magic Count")]
        HarbingerMinionMaxMagicCount = 6491,
        [Description("Harbinger Minion Max Rare Count")]
        HarbingerMinionMaxRareCount = 6492,
        [Description("Cannot Be Stunned If Have Been Stunned Or Blocked Stunning Hit In Past 2 Seconds")]
        CannotBeStunnedIfHaveBeenStunnedOrBlockedStunningHitInPast2Seconds = 6493,
        [Description("Glacial Cascade Number Of Additional Bursts")]
        GlacialCascadeNumberOfAdditionalBursts = 6494,
        [Description("Local Unique Jewel Glacial Cascade Number Of Additional Bursts With 40 Int In Radius")]
        LocalUniqueJewelGlacialCascadeNumberOfAdditionalBurstsWith40IntInRadius = 6495,
        [Description("Number Of Active Beast Minions")]
        NumberOfActiveBeastMinions = 6496,
        [Description("Projectile Attacks Chance To Bleed On Hit % If You Have Beast Minion")]
        ProjectileAttacksChanceToBleedOnHitPctIfYouHaveBeastMinion = 6497,
        [Description("Attack Minimum Added Physical Damage If You Have Beast Minion")]
        AttackMinimumAddedPhysicalDamageIfYouHaveBeastMinion = 6498,
        [Description("Attack Maximum Added Physical Damage If You Have Beast Minion")]
        AttackMaximumAddedPhysicalDamageIfYouHaveBeastMinion = 6499,
        [Description("Projectile Attacks Chance To Maim On Hit % If You Have Beast Minion")]
        ProjectileAttacksChanceToMaimOnHitPctIfYouHaveBeastMinion = 6500,
        [Description("Attack And Movement Speed +% If You Have Beast Minion")]
        AttackAndMovementSpeedPosPctIfYouHaveBeastMinion = 6501,
        [Description("Projectile Attacks Chance To Poison On Hit % If You Have Beast Minion")]
        ProjectileAttacksChanceToPoisonOnHitPctIfYouHaveBeastMinion = 6502,
        [Description("Attack Minimum Added Chaos Damage If You Have Beast Minion")]
        AttackMinimumAddedChaosDamageIfYouHaveBeastMinion = 6503,
        [Description("Attack Maximum Added Chaos Damage If You Have Beast Minion")]
        AttackMaximumAddedChaosDamageIfYouHaveBeastMinion = 6504,
        [Description("Local Bleed On Critical Strike Chance %")]
        LocalBleedOnCriticalStrikeChancePct = 6505,
        [Description("Main Hand Local Bleed On Critical Strike Chance %")]
        MainHandLocalBleedOnCriticalStrikeChancePct = 6506,
        [Description("Off Hand Local Bleed On Critical Strike Chance %")]
        OffHandLocalBleedOnCriticalStrikeChancePct = 6507,
        [Description("Local Poison On Critical Strike Chance %")]
        LocalPoisonOnCriticalStrikeChancePct = 6508,
        [Description("Main Hand Local Poison On Critical Strike Chance %")]
        MainHandLocalPoisonOnCriticalStrikeChancePct = 6509,
        [Description("Off Hand Local Poison On Critical Strike Chance %")]
        OffHandLocalPoisonOnCriticalStrikeChancePct = 6510,
        [Description("Virtual Main Hand Chance To Bleed On Critical Strike %")]
        VirtualMainHandChanceToBleedOnCriticalStrikePct = 6511,
        [Description("Virtual Off Hand Chance To Bleed On Critical Strike %")]
        VirtualOffHandChanceToBleedOnCriticalStrikePct = 6512,
        [Description("Local Chance To Bleed On Crit 50%")]
        LocalChanceToBleedOnCrit50Pct = 6513,
        [Description("Main Hand Local Chance To Bleed On Crit 50%")]
        MainHandLocalChanceToBleedOnCrit50Pct = 6514,
        [Description("Off Hand Local Chance To Bleed On Crit 50%")]
        OffHandLocalChanceToBleedOnCrit50Pct = 6515,
        [Description("Cast On Attack Use %")]
        CastOnAttackUsePct = 6516,
        [Description("Ignite Slower Burn %")]
        IgniteSlowerBurnPct = 6517,
        [Description("Virtual Ignite Duration +% Final")]
        VirtualIgniteDurationPosPctFinal = 6518,
        [Description("Object Inherent Damage +% Final Per Frenzy Charge")]
        ObjectInherentDamagePosPctFinalPerFrenzyCharge = 6519,
        [Description("Local Maim On Hit %")]
        LocalMaimOnHitPct = 6520,
        [Description("Main Hand Local Maim On Hit %")]
        MainHandLocalMaimOnHitPct = 6521,
        [Description("Off Hand Local Maim On Hit %")]
        OffHandLocalMaimOnHitPct = 6522,
        [Description("Life Leech From Attack Damage Permyriad Vs Maimed Enemies")]
        LifeLeechFromAttackDamagePermyriadVsMaimedEnemies = 6523,
        [Description("Local Display Grants Skill Death Aura Level")]
        LocalDisplayGrantsSkillDeathAuraLevel = 6524,
        [Description("Chilled Ground Base Magnitude Override")]
        ChilledGroundBaseMagnitudeOverride = 6525,
        [Description("Shocked Ground Base Magnitude Override")]
        ShockedGroundBaseMagnitudeOverride = 6526,
        [Description("Harbinger Base Currency Shard Stack Tenths To Drop")]
        HarbingerBaseCurrencyShardStackTenthsToDrop = 6527,
        [Description("Charged Dash Damage +%")]
        ChargedDashDamagePosPct = 6528,
        [Description("Storm Burst Damage +%")]
        StormBurstDamagePosPct = 6529,
        [Description("Skeletal Chains Damage +%")]
        SkeletalChainsDamagePosPct = 6530,
        [Description("Whirling Blades Base Ground Chaos Damage To Deal Per Minute")]
        WhirlingBladesBaseGroundChaosDamageToDealPerMinute = 6531,
        [Description("Chill And Freeze Duration +%")]
        ChillAndFreezeDurationPosPct = 6532,
        [Description("Local Chance To Bleed On Hit 50%")]
        LocalChanceToBleedOnHit50Pct = 6533,
        [Description("Main Hand Local Chance To Bleed On Hit 50%")]
        MainHandLocalChanceToBleedOnHit50Pct = 6534,
        [Description("Off Hand Local Chance To Bleed On Hit 50%")]
        OffHandLocalChanceToBleedOnHit50Pct = 6535,
        [Description("Arrows That Pierce Chance To Bleed 25%")]
        ArrowsThatPierceChanceToBleed25Pct = 6536,
        [Description("Attacks Chance To Bleed 25% Vs Cursed Enemies")]
        AttacksChanceToBleed25PctVsCursedEnemies = 6537,
        [Description("Damage Taken +% Final")]
        DamageTakenPosPctFinal = 6538,
        [Description("Display One Harbinger Allowed")]
        DisplayOneHarbingerAllowed = 6539,
        [Description("Action Speed +% Minimum Value")]
        ActionSpeedPosPctMinimumValue = 6540,
        [Description("Shavronne Ball Lightning Held Projectile Damage +% Final")]
        ShavronneBallLightningHeldProjectileDamagePosPctFinal = 6541,
        [Description("Grant Rampage Kill To Parent On Hitting Unique Enemy %")]
        GrantRampageKillToParentOnHittingUniqueEnemyPct = 6542,
        [Description("Minion Grants Rampage Kill To Parent On Hitting Unique Enemy %")]
        MinionGrantsRampageKillToParentOnHittingUniqueEnemyPct = 6543,
        [Description("Monster Inherent Experience Granted +% Final Because Deleted On Death")]
        MonsterInherentExperienceGrantedPosPctFinalBecauseDeletedOnDeath = 6544,
        [Description("Monster Inherent Experience Granted +% Final If Deleted On Death")]
        MonsterInherentExperienceGrantedPosPctFinalIfDeletedOnDeath = 6545,
        [Description("Harbinger Minion Extra Monster Chance %")]
        HarbingerMinionExtraMonsterChancePct = 6546,
        [Description("Harbinger Minion Max Extra Monsters Count")]
        HarbingerMinionMaxExtraMonstersCount = 6547,
        [Description("Harbinger Minion Damage Taken +% Final")]
        HarbingerMinionDamageTakenPosPctFinal = 6548,
        [Description("Skill Global Actor Definition Index Override")]
        SkillGlobalActorDefinitionIndexOverride = 6549,
        [Description("Virtual Total Main Hand Chance To Bleed On Hit %")]
        VirtualTotalMainHandChanceToBleedOnHitPct = 6550,
        [Description("Virtual Total Off Hand Chance To Bleed On Hit %")]
        VirtualTotalOffHandChanceToBleedOnHitPct = 6551,
        [Description("Virtual Total Main Hand Chance To Ignite On Hit %")]
        VirtualTotalMainHandChanceToIgniteOnHitPct = 6552,
        [Description("Virtual Total Off Hand Chance To Ignite On Hit %")]
        VirtualTotalOffHandChanceToIgniteOnHitPct = 6553,
        [Description("Virtual Total Spell Chance To Ignite On Hit %")]
        VirtualTotalSpellChanceToIgniteOnHitPct = 6554,
        [Description("Virtual Total Secondary Chance To Ignite On Hit %")]
        VirtualTotalSecondaryChanceToIgniteOnHitPct = 6555,
        [Description("Virtual Total Main Hand Chance To Poison On Hit %")]
        VirtualTotalMainHandChanceToPoisonOnHitPct = 6556,
        [Description("Virtual Total Off Hand Chance To Poison On Hit %")]
        VirtualTotalOffHandChanceToPoisonOnHitPct = 6557,
        [Description("Virtual Total Spell Chance To Poison On Hit %")]
        VirtualTotalSpellChanceToPoisonOnHitPct = 6558,
        [Description("Virtual Total Secondary Chance To Poison On Hit %")]
        VirtualTotalSecondaryChanceToPoisonOnHitPct = 6559,
        [Description("Total Number Of Map Mods")]
        TotalNumberOfMapMods = 6560,
        [Description("Harbinger Currency Shard Stack Size +%")]
        HarbingerCurrencyShardStackSizePosPct = 6561,
        [Description("Map Force Monster Pack Index")]
        MapForceMonsterPackIndex = 6562,
        [Description("Volatile Dead Base Number Of Corpses To Consume")]
        VolatileDeadBaseNumberOfCorpsesToConsume = 6563,
        [Description("Chance To Cast When Your Trap Is Triggered %")]
        ChanceToCastWhenYourTrapIsTriggeredPct = 6564,
        [Description("Local Display Gain Power Charge On Spending Mana")]
        LocalDisplayGainPowerChargeOnSpendingMana = 6565,
        [Description("Is Untethered Pet")]
        IsUntetheredPet = 6566,
        [Description("Walk Emerge Distance")]
        WalkEmergeDistance = 6567,
        [Description("Walk Emerge Extra Distance")]
        WalkEmergeExtraDistance = 6568,
        [Description("Walk Emerge Height Offset")]
        WalkEmergeHeightOffset = 6569,
        [Description("Walk Emerge Tilt")]
        WalkEmergeTilt = 6570,
        [Description("Combined Armour And Evasion Rating +%")]
        CombinedArmourAndEvasionRatingPosPct = 6571,
        [Description("Herald Of Ash Burning % Overkill Damage Per Minute")]
        HeraldOfAshBurningPctOverkillDamagePerMinute = 6572,
        [Description("Local Display Grants Skill Scorching Ray Level")]
        LocalDisplayGrantsSkillScorchingRayLevel = 6573,
        [Description("Support Minion Maximum Life +% Final")]
        SupportMinionMaximumLifePosPctFinal = 6574,
        [Description("Max Life +% Final For Minion From Support")]
        MaxLifePosPctFinalForMinionFromSupport = 6575,
        [Description("Lightning Tendrils Channelled Larger Pulse Radius +")]
        LightningTendrilsChannelledLargerPulseRadiusPos = 6576,
        [Description("Lightning Tendrils Channelled Larger Pulse Damage +% Final")]
        LightningTendrilsChannelledLargerPulseDamagePosPctFinal = 6577,
        [Description("Discorectangle Slam Damage With Endurance Charge +% Final")]
        DiscorectangleSlamDamageWithEnduranceChargePosPctFinal = 6578,
        [Description("Discorectangle Slam Radius With Endurance Charge +")]
        DiscorectangleSlamRadiusWithEnduranceChargePos = 6579,
        [Description("Unearth Base Corpse Level")]
        UnearthBaseCorpseLevel = 6580,
        [Description("Map Tencent Event Shards Drop Rate")]
        MapTencentEventShardsDropRate = 6581,
        [Description("Is In Caustic Cloud")]
        IsInCausticCloud = 6582,
        [Description("Chaos Damage Taken Over Time +% While In Caustic Cloud")]
        ChaosDamageTakenOverTimePosPctWhileInCausticCloud = 6583,
        [Description("Local Can Socket Gems Ignoring Colour")]
        LocalCanSocketGemsIgnoringColour = 6584,
        [Description("Local No Attribute Requirements")]
        LocalNoAttributeRequirements = 6585,
        [Description("Local Socketed Gems In Red Sockets Get Level +")]
        LocalSocketedGemsInRedSocketsGetLevelPos = 6586,
        [Description("Local Socketed Gems In Green Sockets Get Quality %")]
        LocalSocketedGemsInGreenSocketsGetQualityPct = 6587,
        [Description("Local Socketed Gems In Blue Sockets Experience Gained +%")]
        LocalSocketedGemsInBlueSocketsExperienceGainedPosPct = 6588,
        [Description("Local Socketed Gems In White Sockets Get Nothing")]
        LocalSocketedGemsInWhiteSocketsGetNothing = 6589,
        [Description("Corpse Erruption Base Maximum Number Of Geyers")]
        CorpseErruptionBaseMaximumNumberOfGeyers = 6590,
        [Description("Thaumaturgy Rotation Active")]
        ThaumaturgyRotationActive = 6591,
        [Description("Thaumaturgy Rotation Buff Exists")]
        ThaumaturgyRotationBuffExists = 6592,
        [Description("Trigger On Delayed Blast")]
        TriggerOnDelayedBlast = 6593,
        [Description("Trigger On Delayed Blast %")]
        TriggerOnDelayedBlastPct = 6594,
        [Description("Delayed Blast Has Trigger")]
        DelayedBlastHasTrigger = 6595,
        [Description("Spirit Charge Tier")]
        SpiritChargeTier = 6596,
        [Description("Current Spirit Charges")]
        CurrentSpiritCharges = 6597,
        [Description("Maximum Spirit Charges")]
        MaximumSpiritCharges = 6598,
        [Description("Recover % Of Maximum Life On Gaining A Spirit Charge")]
        RecoverPctOfMaximumLifeOnGainingASpiritCharge = 6599,
        [Description("Corpse Skill Has Triggers")]
        CorpseSkillHasTriggers = 6600,
        [Description("Cast On Corpse Consume")]
        CastOnCorpseConsume = 6601,
        [Description("Cast On Corpse Consume %")]
        CastOnCorpseConsumePct = 6602,
        [Description("Cast On Damage Taken Also Tracks Dot")]
        CastOnDamageTakenAlsoTracksDot = 6603,
        [Description("Thrown Shield Projectile Max Distance")]
        ThrownShieldProjectileMaxDistance = 6604,
        [Description("Thrown Shield Projectile Fire Random Directions")]
        ThrownShieldProjectileFireRandomDirections = 6605,
        [Description("Thrown Shield Secondary Projectile Damage +% Final")]
        ThrownShieldSecondaryProjectileDamagePosPctFinal = 6606,
        [Description("Cast On Corpse Consume Id")]
        CastOnCorpseConsumeId = 6607,
        [Description("Gain Random Charge Per Second While Stationary")]
        GainRandomChargePerSecondWhileStationary = 6608,
        [Description("Lose All Charges On Starting Movement")]
        LoseAllChargesOnStartingMovement = 6609,
        [Description("Mana Regeneration Rate Per Minute Per Power Charge")]
        ManaRegenerationRatePerMinutePerPowerCharge = 6610,
        [Description("Spectre Maximum Life +")]
        SpectreMaximumLifePos = 6611,
        [Description("Accuracy Rating While At Maximum Frenzy Charges")]
        AccuracyRatingWhileAtMaximumFrenzyCharges = 6612,
        [Description("Display Map Inhabited By Solaris Fanatics")]
        DisplayMapInhabitedBySolarisFanatics = 6613,
        [Description("Display Map Inhabited By Lunaris Fanatics")]
        DisplayMapInhabitedByLunarisFanatics = 6614,
        [Description("Map Elder Boss Variation")]
        MapElderBossVariation = 6615,
        [Description("Ignite Triggered Ground Fire Base Damage Per Minute")]
        IgniteTriggeredGroundFireBaseDamagePerMinute = 6616,
        [Description("Virtual Shock Effect +%")]
        VirtualShockEffectPosPct = 6617,
        [Description("Virtual Chill Effect +%")]
        VirtualChillEffectPosPct = 6618,
        [Description("Local Unique Jewel Non Keystone Passive In Radius Effect +%")]
        LocalUniqueJewelNonKeystonePassiveInRadiusEffectPosPct = 6619,
        [Description("Local Unique Jewel Notable Passive In Radius Does Nothing")]
        LocalUniqueJewelNotablePassiveInRadiusDoesNothing = 6620,
        [Description("Passive Skill Does Nothing")]
        PassiveSkillDoesNothing = 6621,
        [Description("Local Unique Hungry Loop Number Of Gems To Consume")]
        LocalUniqueHungryLoopNumberOfGemsToConsume = 6622,
        [Description("Local Unique Hungry Loop Has Consumed Gem")]
        LocalUniqueHungryLoopHasConsumedGem = 6623,
        [Description("Local Display Socketed Gems Supported By Level X Greater Multiple Projectiles")]
        LocalDisplaySocketedGemsSupportedByLevelXGreaterMultipleProjectiles = 6624,
        [Description("Local Display Socketed Gems Supported By Level X Increased Critical Strikes")]
        LocalDisplaySocketedGemsSupportedByLevelXIncreasedCriticalStrikes = 6625,
        [Description("Local Display Socketed Gems Supported By Level X Item Quantity")]
        LocalDisplaySocketedGemsSupportedByLevelXItemQuantity = 6626,
        [Description("Local Display Socketed Gems Supported By Level X Item Rarity")]
        LocalDisplaySocketedGemsSupportedByLevelXItemRarity = 6627,
        [Description("Local Display Socketed Gems Supported By Level X Increased Duration")]
        LocalDisplaySocketedGemsSupportedByLevelXIncreasedDuration = 6628,
        [Description("Local Display Socketed Gems Supported By Level X Chance To Ignite")]
        LocalDisplaySocketedGemsSupportedByLevelXChanceToIgnite = 6629,
        [Description("Local Display Socketed Gems Supported By Level X Bloodlust")]
        LocalDisplaySocketedGemsSupportedByLevelXBloodlust = 6630,
        [Description("Local Display Socketed Gems Supported By Level X Life Gain On Hit")]
        LocalDisplaySocketedGemsSupportedByLevelXLifeGainOnHit = 6631,
        [Description("Local Display Socketed Gems Supported By Level X Culling Strike")]
        LocalDisplaySocketedGemsSupportedByLevelXCullingStrike = 6632,
        [Description("Local Display Socketed Gems Supported By Level X Point Blank")]
        LocalDisplaySocketedGemsSupportedByLevelXPointBlank = 6633,
        [Description("Local Display Socketed Gems Supported By Level X Iron Grip")]
        LocalDisplaySocketedGemsSupportedByLevelXIronGrip = 6634,
        [Description("Local Display Socketed Gems Supported By Level X Melee Damage On Full Life")]
        LocalDisplaySocketedGemsSupportedByLevelXMeleeDamageOnFullLife = 6635,
        [Description("Local Display Socketed Gems Supported By Level X Ranged Attack Totem")]
        LocalDisplaySocketedGemsSupportedByLevelXRangedAttackTotem = 6636,
        [Description("Local Display Socketed Gems Supported By Level X Fire Penetration")]
        LocalDisplaySocketedGemsSupportedByLevelXFirePenetration = 6637,
        [Description("Local Display Socketed Gems Supported By Level X Lightning Penetration")]
        LocalDisplaySocketedGemsSupportedByLevelXLightningPenetration = 6638,
        [Description("Local Display Socketed Gems Supported By Level X Chain")]
        LocalDisplaySocketedGemsSupportedByLevelXChain = 6639,
        [Description("Local Display Socketed Gems Supported By Level X Multicast")]
        LocalDisplaySocketedGemsSupportedByLevelXMulticast = 6640,
        [Description("Local Display Socketed Gems Supported By Level X Power Charge On Crit")]
        LocalDisplaySocketedGemsSupportedByLevelXPowerChargeOnCrit = 6641,
        [Description("Local Display Socketed Gems Supported By Level X Increased Burning Damage")]
        LocalDisplaySocketedGemsSupportedByLevelXIncreasedBurningDamage = 6642,
        [Description("Local Display Socketed Gems Supported By Level X Summon Elemental Resistance")]
        LocalDisplaySocketedGemsSupportedByLevelXSummonElementalResistance = 6643,
        [Description("Local Display Socketed Gems Supported By Level X Curse On Hit")]
        LocalDisplaySocketedGemsSupportedByLevelXCurseOnHit = 6644,
        [Description("Local Display Socketed Gems Supported By Level X Cast On Kill")]
        LocalDisplaySocketedGemsSupportedByLevelXCastOnKill = 6645,
        [Description("Local Display Socketed Gems Supported By Level X Multi Trap")]
        LocalDisplaySocketedGemsSupportedByLevelXMultiTrap = 6646,
        [Description("Local Display Socketed Gems Supported By Level X Empower")]
        LocalDisplaySocketedGemsSupportedByLevelXEmpower = 6647,
        [Description("Local Display Socketed Gems Supported By Level X Slower Projectiles")]
        LocalDisplaySocketedGemsSupportedByLevelXSlowerProjectiles = 6648,
        [Description("Local Display Socketed Gems Supported By Level X Reduced Duration")]
        LocalDisplaySocketedGemsSupportedByLevelXReducedDuration = 6649,
        [Description("Local Display Socketed Gems Supported By Level X Cast On Damage Taken")]
        LocalDisplaySocketedGemsSupportedByLevelXCastOnDamageTaken = 6650,
        [Description("Local Display Socketed Gems Supported By Level X Enhance")]
        LocalDisplaySocketedGemsSupportedByLevelXEnhance = 6651,
        [Description("Local Display Socketed Gems Supported By Level X Physical Projectile Attack Damage")]
        LocalDisplaySocketedGemsSupportedByLevelXPhysicalProjectileAttackDamage = 6652,
        [Description("Local Display Socketed Gems Supported By Level X Enlighten")]
        LocalDisplaySocketedGemsSupportedByLevelXEnlighten = 6653,
        [Description("Local Display Socketed Gems Supported By Level X Physical To Lightning")]
        LocalDisplaySocketedGemsSupportedByLevelXPhysicalToLightning = 6654,
        [Description("Local Display Socketed Gems Supported By Level X Trap And Mine Damage")]
        LocalDisplaySocketedGemsSupportedByLevelXTrapAndMineDamage = 6655,
        [Description("Local Display Socketed Gems Supported By Level X Poison")]
        LocalDisplaySocketedGemsSupportedByLevelXPoison = 6656,
        [Description("Local Display Socketed Gems Supported By Level X Void Manipulation")]
        LocalDisplaySocketedGemsSupportedByLevelXVoidManipulation = 6657,
        [Description("Local Display Socketed Gems Supported By Level X Rapid Decay")]
        LocalDisplaySocketedGemsSupportedByLevelXRapidDecay = 6658,
        [Description("Local Display Socketed Gems Supported By Level X Cluster Trap")]
        LocalDisplaySocketedGemsSupportedByLevelXClusterTrap = 6659,
        [Description("Local Display Socketed Gems Supported By Level X Elemental Focus")]
        LocalDisplaySocketedGemsSupportedByLevelXElementalFocus = 6660,
        [Description("Local Display Socketed Gems Supported By Level X Minefield")]
        LocalDisplaySocketedGemsSupportedByLevelXMinefield = 6661,
        [Description("Local Display Socketed Gems Supported By Level X Trap Cooldown")]
        LocalDisplaySocketedGemsSupportedByLevelXTrapCooldown = 6662,
        [Description("Local Display Socketed Gems Supported By Level X Cast While Channelling")]
        LocalDisplaySocketedGemsSupportedByLevelXCastWhileChannelling = 6663,
        [Description("Local Display Socketed Gems Supported By Level X Ignite Proliferation")]
        LocalDisplaySocketedGemsSupportedByLevelXIgniteProliferation = 6664,
        [Description("Local Display Socketed Gems Supported By Level X Chance To Bleed")]
        LocalDisplaySocketedGemsSupportedByLevelXChanceToBleed = 6665,
        [Description("Local Display Socketed Gems Supported By Level X Deadly Ailments")]
        LocalDisplaySocketedGemsSupportedByLevelXDeadlyAilments = 6666,
        [Description("Local Display Socketed Gems Supported By Level X Decay")]
        LocalDisplaySocketedGemsSupportedByLevelXDecay = 6667,
        [Description("Local Display Socketed Gems Supported By Level X Efficacy")]
        LocalDisplaySocketedGemsSupportedByLevelXEfficacy = 6668,
        [Description("Local Display Socketed Gems Supported By Level X Maim")]
        LocalDisplaySocketedGemsSupportedByLevelXMaim = 6669,
        [Description("Local Display Socketed Gems Supported By Level X Immolate")]
        LocalDisplaySocketedGemsSupportedByLevelXImmolate = 6670,
        [Description("Local Display Socketed Gems Supported By Level X Unbound Ailments")]
        LocalDisplaySocketedGemsSupportedByLevelXUnboundAilments = 6671,
        [Description("Local Display Socketed Gems Supported By Level X Brutality")]
        LocalDisplaySocketedGemsSupportedByLevelXBrutality = 6672,
        [Description("Local Display Socketed Gems Supported By Level X Ruthless")]
        LocalDisplaySocketedGemsSupportedByLevelXRuthless = 6673,
        [Description("Local Display Socketed Gems Supported By Level X Onslaught")]
        LocalDisplaySocketedGemsSupportedByLevelXOnslaught = 6674,
        [Description("Local Display Socketed Gems Supported By Level X Arcane Surge")]
        LocalDisplaySocketedGemsSupportedByLevelXArcaneSurge = 6675,
        [Description("Local Display Socketed Gems Supported By Level X Reduced Block Chance")]
        LocalDisplaySocketedGemsSupportedByLevelXReducedBlockChance = 6676,
        [Description("Spectral Throw Gain Vaal Soul For Vaal Spectral Throw On Hit %")]
        SpectralThrowGainVaalSoulForVaalSpectralThrowOnHitPct = 6677,
        [Description("Local Unique Jewel Spectral Throw Gain Vaal Soul For Vaal St On Hit % With 40 Dex In Radius")]
        LocalUniqueJewelSpectralThrowGainVaalSoulForVaalStOnHitPctWith40DexInRadius = 6678,
        [Description("Trigger Socketed Spell On Attack %")]
        TriggerSocketedSpellOnAttackPct = 6679,
        [Description("Main Hand Trigger Socketed Spell On Attack %")]
        MainHandTriggerSocketedSpellOnAttackPct = 6680,
        [Description("Off Hand Trigger Socketed Spell On Attack %")]
        OffHandTriggerSocketedSpellOnAttackPct = 6681,
        [Description("Local Attack Minimum Added Physical Damage Per 3 Levels")]
        LocalAttackMinimumAddedPhysicalDamagePer3Levels = 6682,
        [Description("Local Attack Maximum Added Physical Damage Per 3 Levels")]
        LocalAttackMaximumAddedPhysicalDamagePer3Levels = 6683,
        [Description("Main Hand Attack Minimum Added Physical Damage Per 3 Levels")]
        MainHandAttackMinimumAddedPhysicalDamagePer3Levels = 6684,
        [Description("Main Hand Attack Maximum Added Physical Damage Per 3 Levels")]
        MainHandAttackMaximumAddedPhysicalDamagePer3Levels = 6685,
        [Description("Off Hand Attack Minimum Added Physical Damage Per 3 Levels")]
        OffHandAttackMinimumAddedPhysicalDamagePer3Levels = 6686,
        [Description("Off Hand Attack Maximum Added Physical Damage Per 3 Levels")]
        OffHandAttackMaximumAddedPhysicalDamagePer3Levels = 6687,
        [Description("Local Poison Duration +% During Flask Effect")]
        LocalPoisonDurationPosPctDuringFlaskEffect = 6688,
        [Description("Local Grant Perfect Agony During Flask Effect")]
        LocalGrantPerfectAgonyDuringFlaskEffect = 6689,
        [Description("Local Chance To Poison On Hit % During Flask Effect")]
        LocalChanceToPoisonOnHitPctDuringFlaskEffect = 6690,
        [Description("Local No Critical Strike Multiplier During Flask Effect")]
        LocalNoCriticalStrikeMultiplierDuringFlaskEffect = 6691,
        [Description("Local Socketed Skill Gem Level +1 Per X Player Levels")]
        LocalSocketedSkillGemLevelPos1PerXPlayerLevels = 6692,
        [Description("Map Spawn Abysses")]
        MapSpawnAbysses = 6693,
        [Description("Map Num Extra Abysses")]
        MapNumExtraAbysses = 6694,
        [Description("Lightning Tendrils Channelled Larger Pulse Interval")]
        LightningTendrilsChannelledLargerPulseInterval = 6695,
        [Description("Local Has X Abyss Sockets")]
        LocalHasXAbyssSockets = 6696,
        [Description("Melee Skills Area Of Effect +%")]
        MeleeSkillsAreaOfEffectPosPct = 6697,
        [Description("Skill Is Melee Skill")]
        SkillIsMeleeSkill = 6698,
        [Description("Local Unique Jewel Melee Skills Area Of Effect +% With Passive Tree Connected To Marauder Start")]
        LocalUniqueJewelMeleeSkillsAreaOfEffectPosPctWithPassiveTreeConnectedToMarauderStart = 6699,
        [Description("Local Unique Jewel Life Leech From Attack Damage Permyriad With Passive Tree Connected To Duelist Start")]
        LocalUniqueJewelLifeLeechFromAttackDamagePermyriadWithPassiveTreeConnectedToDuelistStart = 6700,
        [Description("Local Unique Jewel Movement Speed +% With Passive Tree Connected To Ranger Start")]
        LocalUniqueJewelMovementSpeedPosPctWithPassiveTreeConnectedToRangerStart = 6701,
        [Description("Local Unique Jewel Additional Critical Strike Chance Permyriad With Passive Tree Connected To Shadow Start")]
        LocalUniqueJewelAdditionalCriticalStrikeChancePermyriadWithPassiveTreeConnectedToShadowStart = 6702,
        [Description("Local Unique Jewel Mana Regeneration Rate Per Minute % With Passive Tree Connected To Witch Start")]
        LocalUniqueJewelManaRegenerationRatePerMinutePctWithPassiveTreeConnectedToWitchStart = 6703,
        [Description("Local Unique Jewel Elemental Penetration % With Passive Tree Connected To Templar Start")]
        LocalUniqueJewelElementalPenetrationPctWithPassiveTreeConnectedToTemplarStart = 6704,
        [Description("Local Unique Jewel Additional All Attributes With Passive Tree Connected To Scion Start")]
        LocalUniqueJewelAdditionalAllAttributesWithPassiveTreeConnectedToScionStart = 6705,
        [Description("Local Unique Jewel Glacial Cascade Physical Damage % To Convert To Cold With 40 Int In Radius")]
        LocalUniqueJewelGlacialCascadePhysicalDamagePctToConvertToColdWith40IntInRadius = 6706,
        [Description("Attack Critical Strike Chance +% Per 200 Accuracy Rating")]
        AttackCriticalStrikeChancePosPctPer200AccuracyRating = 6707,
        [Description("Attack Minimum Added Physical Damage With Wands")]
        AttackMinimumAddedPhysicalDamageWithWands = 6708,
        [Description("Attack Maximum Added Physical Damage With Wands")]
        AttackMaximumAddedPhysicalDamageWithWands = 6709,
        [Description("Attack Minimum Added Physical Damage With Daggers")]
        AttackMinimumAddedPhysicalDamageWithDaggers = 6710,
        [Description("Attack Maximum Added Physical Damage With Daggers")]
        AttackMaximumAddedPhysicalDamageWithDaggers = 6711,
        [Description("Attack Minimum Added Physical Damage With Claws")]
        AttackMinimumAddedPhysicalDamageWithClaws = 6712,
        [Description("Attack Maximum Added Physical Damage With Claws")]
        AttackMaximumAddedPhysicalDamageWithClaws = 6713,
        [Description("Attack Minimum Added Physical Damage With Swords")]
        AttackMinimumAddedPhysicalDamageWithSwords = 6714,
        [Description("Attack Maximum Added Physical Damage With Swords")]
        AttackMaximumAddedPhysicalDamageWithSwords = 6715,
        [Description("Attack Minimum Added Physical Damage With Axes")]
        AttackMinimumAddedPhysicalDamageWithAxes = 6716,
        [Description("Attack Maximum Added Physical Damage With Axes")]
        AttackMaximumAddedPhysicalDamageWithAxes = 6717,
        [Description("Attack Minimum Added Physical Damage With Maces")]
        AttackMinimumAddedPhysicalDamageWithMaces = 6718,
        [Description("Attack Maximum Added Physical Damage With Maces")]
        AttackMaximumAddedPhysicalDamageWithMaces = 6719,
        [Description("Attack Minimum Added Physical Damage With Staves")]
        AttackMinimumAddedPhysicalDamageWithStaves = 6720,
        [Description("Attack Maximum Added Physical Damage With Staves")]
        AttackMaximumAddedPhysicalDamageWithStaves = 6721,
        [Description("Attack Minimum Added Lightning Damage With Daggers")]
        AttackMinimumAddedLightningDamageWithDaggers = 6722,
        [Description("Attack Maximum Added Lightning Damage With Daggers")]
        AttackMaximumAddedLightningDamageWithDaggers = 6723,
        [Description("Attack Minimum Added Lightning Damage With Claws")]
        AttackMinimumAddedLightningDamageWithClaws = 6724,
        [Description("Attack Maximum Added Lightning Damage With Claws")]
        AttackMaximumAddedLightningDamageWithClaws = 6725,
        [Description("Attack Minimum Added Lightning Damage With Bows")]
        AttackMinimumAddedLightningDamageWithBows = 6726,
        [Description("Attack Maximum Added Lightning Damage With Bows")]
        AttackMaximumAddedLightningDamageWithBows = 6727,
        [Description("Attack Minimum Added Lightning Damage With Swords")]
        AttackMinimumAddedLightningDamageWithSwords = 6728,
        [Description("Attack Maximum Added Lightning Damage With Swords")]
        AttackMaximumAddedLightningDamageWithSwords = 6729,
        [Description("Attack Minimum Added Lightning Damage With Axes")]
        AttackMinimumAddedLightningDamageWithAxes = 6730,
        [Description("Attack Maximum Added Lightning Damage With Axes")]
        AttackMaximumAddedLightningDamageWithAxes = 6731,
        [Description("Attack Minimum Added Lightning Damage With Maces")]
        AttackMinimumAddedLightningDamageWithMaces = 6732,
        [Description("Attack Maximum Added Lightning Damage With Maces")]
        AttackMaximumAddedLightningDamageWithMaces = 6733,
        [Description("Attack Minimum Added Lightning Damage With Staves")]
        AttackMinimumAddedLightningDamageWithStaves = 6734,
        [Description("Attack Maximum Added Lightning Damage With Staves")]
        AttackMaximumAddedLightningDamageWithStaves = 6735,
        [Description("Attack Minimum Added Fire Damage With Daggers")]
        AttackMinimumAddedFireDamageWithDaggers = 6736,
        [Description("Attack Maximum Added Fire Damage With Daggers")]
        AttackMaximumAddedFireDamageWithDaggers = 6737,
        [Description("Attack Minimum Added Fire Damage With Claws")]
        AttackMinimumAddedFireDamageWithClaws = 6738,
        [Description("Attack Maximum Added Fire Damage With Claws")]
        AttackMaximumAddedFireDamageWithClaws = 6739,
        [Description("Attack Minimum Added Fire Damage With Swords")]
        AttackMinimumAddedFireDamageWithSwords = 6740,
        [Description("Attack Maximum Added Fire Damage With Swords")]
        AttackMaximumAddedFireDamageWithSwords = 6741,
        [Description("Attack Minimum Added Fire Damage With Axes")]
        AttackMinimumAddedFireDamageWithAxes = 6742,
        [Description("Attack Maximum Added Fire Damage With Axes")]
        AttackMaximumAddedFireDamageWithAxes = 6743,
        [Description("Attack Minimum Added Fire Damage With Maces")]
        AttackMinimumAddedFireDamageWithMaces = 6744,
        [Description("Attack Maximum Added Fire Damage With Maces")]
        AttackMaximumAddedFireDamageWithMaces = 6745,
        [Description("Attack Minimum Added Fire Damage With Staves")]
        AttackMinimumAddedFireDamageWithStaves = 6746,
        [Description("Attack Maximum Added Fire Damage With Staves")]
        AttackMaximumAddedFireDamageWithStaves = 6747,
        [Description("Attack Minimum Added Cold Damage With Daggers")]
        AttackMinimumAddedColdDamageWithDaggers = 6748,
        [Description("Attack Maximum Added Cold Damage With Daggers")]
        AttackMaximumAddedColdDamageWithDaggers = 6749,
        [Description("Attack Minimum Added Cold Damage With Claws")]
        AttackMinimumAddedColdDamageWithClaws = 6750,
        [Description("Attack Maximum Added Cold Damage With Claws")]
        AttackMaximumAddedColdDamageWithClaws = 6751,
        [Description("Attack Minimum Added Cold Damage With Bows")]
        AttackMinimumAddedColdDamageWithBows = 6752,
        [Description("Attack Maximum Added Cold Damage With Bows")]
        AttackMaximumAddedColdDamageWithBows = 6753,
        [Description("Attack Minimum Added Cold Damage With Swords")]
        AttackMinimumAddedColdDamageWithSwords = 6754,
        [Description("Attack Maximum Added Cold Damage With Swords")]
        AttackMaximumAddedColdDamageWithSwords = 6755,
        [Description("Attack Minimum Added Cold Damage With Axes")]
        AttackMinimumAddedColdDamageWithAxes = 6756,
        [Description("Attack Maximum Added Cold Damage With Axes")]
        AttackMaximumAddedColdDamageWithAxes = 6757,
        [Description("Attack Minimum Added Cold Damage With Maces")]
        AttackMinimumAddedColdDamageWithMaces = 6758,
        [Description("Attack Maximum Added Cold Damage With Maces")]
        AttackMaximumAddedColdDamageWithMaces = 6759,
        [Description("Attack Minimum Added Cold Damage With Staves")]
        AttackMinimumAddedColdDamageWithStaves = 6760,
        [Description("Attack Maximum Added Cold Damage With Staves")]
        AttackMaximumAddedColdDamageWithStaves = 6761,
        [Description("Attack Minimum Added Physical Damage While Unarmed")]
        AttackMinimumAddedPhysicalDamageWhileUnarmed = 6762,
        [Description("Attack Maximum Added Physical Damage While Unarmed")]
        AttackMaximumAddedPhysicalDamageWhileUnarmed = 6763,
        [Description("Attack Minimum Added Physical Damage While Holding A Shield")]
        AttackMinimumAddedPhysicalDamageWhileHoldingAShield = 6764,
        [Description("Attack Maximum Added Physical Damage While Holding A Shield")]
        AttackMaximumAddedPhysicalDamageWhileHoldingAShield = 6765,
        [Description("Spell Minimum Added Fire Damage While Dual Wielding")]
        SpellMinimumAddedFireDamageWhileDualWielding = 6766,
        [Description("Spell Maximum Added Fire Damage While Dual Wielding")]
        SpellMaximumAddedFireDamageWhileDualWielding = 6767,
        [Description("Spell Minimum Added Cold Damage While Dual Wielding")]
        SpellMinimumAddedColdDamageWhileDualWielding = 6768,
        [Description("Spell Maximum Added Cold Damage While Dual Wielding")]
        SpellMaximumAddedColdDamageWhileDualWielding = 6769,
        [Description("Spell Minimum Added Lightning Damage While Dual Wielding")]
        SpellMinimumAddedLightningDamageWhileDualWielding = 6770,
        [Description("Spell Maximum Added Lightning Damage While Dual Wielding")]
        SpellMaximumAddedLightningDamageWhileDualWielding = 6771,
        [Description("Spell Minimum Added Physical Damage While Dual Wielding")]
        SpellMinimumAddedPhysicalDamageWhileDualWielding = 6772,
        [Description("Spell Maximum Added Physical Damage While Dual Wielding")]
        SpellMaximumAddedPhysicalDamageWhileDualWielding = 6773,
        [Description("Spell Minimum Added Chaos Damage While Dual Wielding")]
        SpellMinimumAddedChaosDamageWhileDualWielding = 6774,
        [Description("Spell Maximum Added Chaos Damage While Dual Wielding")]
        SpellMaximumAddedChaosDamageWhileDualWielding = 6775,
        [Description("Spell Minimum Added Fire Damage While Wielding Two Handed Weapon")]
        SpellMinimumAddedFireDamageWhileWieldingTwoHandedWeapon = 6776,
        [Description("Spell Maximum Added Fire Damage While Wielding Two Handed Weapon")]
        SpellMaximumAddedFireDamageWhileWieldingTwoHandedWeapon = 6777,
        [Description("Spell Minimum Added Cold Damage While Wielding Two Handed Weapon")]
        SpellMinimumAddedColdDamageWhileWieldingTwoHandedWeapon = 6778,
        [Description("Spell Maximum Added Cold Damage While Wielding Two Handed Weapon")]
        SpellMaximumAddedColdDamageWhileWieldingTwoHandedWeapon = 6779,
        [Description("Spell Minimum Added Lightning Damage While Wielding Two Handed Weapon")]
        SpellMinimumAddedLightningDamageWhileWieldingTwoHandedWeapon = 6780,
        [Description("Spell Maximum Added Lightning Damage While Wielding Two Handed Weapon")]
        SpellMaximumAddedLightningDamageWhileWieldingTwoHandedWeapon = 6781,
        [Description("Spell Minimum Added Physical Damage While Wielding Two Handed Weapon")]
        SpellMinimumAddedPhysicalDamageWhileWieldingTwoHandedWeapon = 6782,
        [Description("Spell Maximum Added Physical Damage While Wielding Two Handed Weapon")]
        SpellMaximumAddedPhysicalDamageWhileWieldingTwoHandedWeapon = 6783,
        [Description("Spell Minimum Added Chaos Damage While Wielding Two Handed Weapon")]
        SpellMinimumAddedChaosDamageWhileWieldingTwoHandedWeapon = 6784,
        [Description("Spell Maximum Added Chaos Damage While Wielding Two Handed Weapon")]
        SpellMaximumAddedChaosDamageWhileWieldingTwoHandedWeapon = 6785,
        [Description("Spell Minimum Added Fire Damage While Holding A Shield")]
        SpellMinimumAddedFireDamageWhileHoldingAShield = 6786,
        [Description("Spell Maximum Added Fire Damage While Holding A Shield")]
        SpellMaximumAddedFireDamageWhileHoldingAShield = 6787,
        [Description("Spell Minimum Added Cold Damage While Holding A Shield")]
        SpellMinimumAddedColdDamageWhileHoldingAShield = 6788,
        [Description("Spell Maximum Added Cold Damage While Holding A Shield")]
        SpellMaximumAddedColdDamageWhileHoldingAShield = 6789,
        [Description("Spell Minimum Added Lightning Damage While Holding A Shield")]
        SpellMinimumAddedLightningDamageWhileHoldingAShield = 6790,
        [Description("Spell Maximum Added Lightning Damage While Holding A Shield")]
        SpellMaximumAddedLightningDamageWhileHoldingAShield = 6791,
        [Description("Spell Minimum Added Physical Damage While Holding A Shield")]
        SpellMinimumAddedPhysicalDamageWhileHoldingAShield = 6792,
        [Description("Spell Maximum Added Physical Damage While Holding A Shield")]
        SpellMaximumAddedPhysicalDamageWhileHoldingAShield = 6793,
        [Description("Spell Minimum Added Chaos Damage While Holding A Shield")]
        SpellMinimumAddedChaosDamageWhileHoldingAShield = 6794,
        [Description("Spell Maximum Added Chaos Damage While Holding A Shield")]
        SpellMaximumAddedChaosDamageWhileHoldingAShield = 6795,
        [Description("Damage Over Time +% While Dual Wielding")]
        DamageOverTimePosPctWhileDualWielding = 6796,
        [Description("Damage Over Time +% While Wielding Two Handed Weapon")]
        DamageOverTimePosPctWhileWieldingTwoHandedWeapon = 6797,
        [Description("Damage Over Time +% While Holding A Shield")]
        DamageOverTimePosPctWhileHoldingAShield = 6798,
        [Description("Minion Global Minimum Added Fire Damage")]
        MinionGlobalMinimumAddedFireDamage = 6799,
        [Description("Minion Global Maximum Added Fire Damage")]
        MinionGlobalMaximumAddedFireDamage = 6800,
        [Description("Minion Global Minimum Added Cold Damage")]
        MinionGlobalMinimumAddedColdDamage = 6801,
        [Description("Minion Global Maximum Added Cold Damage")]
        MinionGlobalMaximumAddedColdDamage = 6802,
        [Description("Minion Global Minimum Added Lightning Damage")]
        MinionGlobalMinimumAddedLightningDamage = 6803,
        [Description("Minion Global Maximum Added Lightning Damage")]
        MinionGlobalMaximumAddedLightningDamage = 6804,
        [Description("Minion Global Minimum Added Physical Damage")]
        MinionGlobalMinimumAddedPhysicalDamage = 6805,
        [Description("Minion Global Maximum Added Physical Damage")]
        MinionGlobalMaximumAddedPhysicalDamage = 6806,
        [Description("Minion Global Minimum Added Chaos Damage")]
        MinionGlobalMinimumAddedChaosDamage = 6807,
        [Description("Minion Global Maximum Added Chaos Damage")]
        MinionGlobalMaximumAddedChaosDamage = 6808,
        [Description("Minion Life Regeneration Rate Per Second")]
        MinionLifeRegenerationRatePerSecond = 6809,
        [Description("Energy Shield Regeneration Rate Per Second")]
        EnergyShieldRegenerationRatePerSecond = 6810,
        [Description("Local Attack Cast Movement Speed +% During Flask Effect")]
        LocalAttackCastMovementSpeedPosPctDuringFlaskEffect = 6811,
        [Description("Local Attack Cast Movement Speed +% Per Second During Flask Effect")]
        LocalAttackCastMovementSpeedPosPctPerSecondDuringFlaskEffect = 6812,
        [Description("Damage +% Vs Abyssal Monsters")]
        DamagePosPctVsAbyssalMonsters = 6813,
        [Description("Minion Damage +% Vs Abyssal Monsters")]
        MinionDamagePosPctVsAbyssalMonsters = 6814,
        [Description("Additional Physical Damage Reduction % Vs Abyssal Monsters")]
        AdditionalPhysicalDamageReductionPctVsAbyssalMonsters = 6815,
        [Description("Attacker Conditional Damage Stats Requires Tags")]
        AttackerConditionalDamageStatsRequiresTags = 6816,
        [Description("Defender Conditional Damage Stats Requires Tags")]
        DefenderConditionalDamageStatsRequiresTags = 6817,
        [Description("Chance To Block Spells % If Damaged By A Hit Recently")]
        ChanceToBlockSpellsPctIfDamagedByAHitRecently = 6818,
        [Description("Track Have Been Damaged By A Hit Recently")]
        TrackHaveBeenDamagedByAHitRecently = 6819,
        [Description("Have Been Damaged By A Hit Recently")]
        HaveBeenDamagedByAHitRecently = 6820,
        [Description("Movement Speed +% If Have Not Taken Damage Recently")]
        MovementSpeedPosPctIfHaveNotTakenDamageRecently = 6821,
        [Description("Track Have Stopped Taking Damage Over Time Recently")]
        TrackHaveStoppedTakingDamageOverTimeRecently = 6822,
        [Description("Have Stopped Taking Damage Over Time Recently")]
        HaveStoppedTakingDamageOverTimeRecently = 6823,
        [Description("Is Currently Taking Damage Over Time")]
        IsCurrentlyTakingDamageOverTime = 6824,
        [Description("Damage +% If Enemy Killed Recently")]
        DamagePosPctIfEnemyKilledRecently = 6825,
        [Description("Critical Strike Multiplier + If Enemy Killed Recently")]
        CriticalStrikeMultiplierPosIfEnemyKilledRecently = 6826,
        [Description("Armour +% If Enemy Not Killed Recently")]
        ArmourPosPctIfEnemyNotKilledRecently = 6827,
        [Description("Accuracy Rating +% If Enemy Not Killed Recently")]
        AccuracyRatingPosPctIfEnemyNotKilledRecently = 6828,
        [Description("Damage Penetrates % Elemental Resistance If Enemy Not Killed Recently")]
        DamagePenetratesPctElementalResistanceIfEnemyNotKilledRecently = 6829,
        [Description("Cast Speed +% If Player Minion Has Been Killed Recently")]
        CastSpeedPosPctIfPlayerMinionHasBeenKilledRecently = 6830,
        [Description("Track Has Player Minion Been Killed Recently")]
        TrackHasPlayerMinionBeenKilledRecently = 6831,
        [Description("Has Player Minion Been Killed Recently")]
        HasPlayerMinionBeenKilledRecently = 6832,
        [Description("Minion Damage +% If Have Used A Minion Skill Recently")]
        MinionDamagePosPctIfHaveUsedAMinionSkillRecently = 6833,
        [Description("Track Have Used A Minion Skill Recently")]
        TrackHaveUsedAMinionSkillRecently = 6834,
        [Description("Have Used A Minion Skill Recently")]
        HaveUsedAMinionSkillRecently = 6835,
        [Description("Evasion Rating +% While Moving")]
        EvasionRatingPosPctWhileMoving = 6836,
        [Description("Mana Regeneration Rate +% While Moving")]
        ManaRegenerationRatePosPctWhileMoving = 6837,
        [Description("Life Regeneration Rate Per Minute % While Moving")]
        LifeRegenerationRatePerMinutePctWhileMoving = 6838,
        [Description("Physical Damage % To Add As Fire If Have Crit Recently")]
        PhysicalDamagePctToAddAsFireIfHaveCritRecently = 6839,
        [Description("Attack Speed +% If Have Crit Recently")]
        AttackSpeedPosPctIfHaveCritRecently = 6840,
        [Description("Cast Speed +% If Have Crit Recently")]
        CastSpeedPosPctIfHaveCritRecently = 6841,
        [Description("Critical Strike Chance +% If Have Not Crit Recently")]
        CriticalStrikeChancePosPctIfHaveNotCritRecently = 6842,
        [Description("Minion Attack And Cast Speed +% If You Or Minions Have Killed Enemy Recently")]
        MinionAttackAndCastSpeedPosPctIfYouOrMinionsHaveKilledEnemyRecently = 6843,
        [Description("Notify Parent Have Killed Enemy Recently")]
        NotifyParentHaveKilledEnemyRecently = 6844,
        [Description("Minion Has Killed Enemy Recently")]
        MinionHasKilledEnemyRecently = 6845,
        [Description("Attacks Chance To Blind On Hit %")]
        AttacksChanceToBlindOnHitPct = 6846,
        [Description("Attacks Chance To Taunt On Hit %")]
        AttacksChanceToTauntOnHitPct = 6847,
        [Description("Spells Chance To Hinder On Hit %")]
        SpellsChanceToHinderOnHitPct = 6848,
        [Description("Minion Attacks Chance To Blind On Hit %")]
        MinionAttacksChanceToBlindOnHitPct = 6849,
        [Description("Minion Attacks Chance To Taunt On Hit %")]
        MinionAttacksChanceToTauntOnHitPct = 6850,
        [Description("Minion Spells Chance To Hinder On Hit %")]
        MinionSpellsChanceToHinderOnHitPct = 6851,
        [Description("Desecrate Maximum Number Of Corpses")]
        DesecrateMaximumNumberOfCorpses = 6852,
        [Description("Additional Physical Damage Reduction % If Not Damaged By A Hit Recently")]
        AdditionalPhysicalDamageReductionPctIfNotDamagedByAHitRecently = 6853,
        [Description("Has Aegis Shield Type")]
        HasAegisShieldType = 6854,
        [Description("Local Display Cast Fire Aegis On Gain Skill")]
        LocalDisplayCastFireAegisOnGainSkill = 6855,
        [Description("Local Display Cast Cold Aegis On Gain Skill")]
        LocalDisplayCastColdAegisOnGainSkill = 6856,
        [Description("Local Display Cast Elemental Aegis On Gain Skill")]
        LocalDisplayCastElementalAegisOnGainSkill = 6857,
        [Description("Poison Reflected To Self")]
        PoisonReflectedToSelf = 6858,
        [Description("Bleeding Reflected To Self")]
        BleedingReflectedToSelf = 6859,
        [Description("Chaos Damage Resistance % Per Poison Stack")]
        ChaosDamageResistancePctPerPoisonStack = 6860,
        [Description("Armour +% While Bleeding")]
        ArmourPosPctWhileBleeding = 6861,
        [Description("Avoid Poison %")]
        AvoidPoisonPct = 6862,
        [Description("Cannot Be Frozen")]
        CannotBeFrozen = 6863,
        [Description("Local Display Grants Level X Curse Pillar Skill")]
        LocalDisplayGrantsLevelXCursePillarSkill = 6864,
        [Description("Local Socketed Active Skill Gem Level +")]
        LocalSocketedActiveSkillGemLevelPos = 6865,
        [Description("Local Socketed Active Skill Gem Quality +")]
        LocalSocketedActiveSkillGemQualityPos = 6866,
        [Description("Aegis Unique Shield Max Value")]
        AegisUniqueShieldMaxValue = 6867,
        [Description("Move Daemon Rotation Per Repeat")]
        MoveDaemonRotationPerRepeat = 6868,
        [Description("Move Daemon End Rotation Per Repeat")]
        MoveDaemonEndRotationPerRepeat = 6869,
        [Description("Move Daemon X Offset Per Repeat")]
        MoveDaemonXOffsetPerRepeat = 6870,
        [Description("Move Daemon Y Offset Per Repeat")]
        MoveDaemonYOffsetPerRepeat = 6871,
        [Description("Map Tier +5")]
        MapTierPos5 = 6872,
        [Description("Map Tier 16")]
        MapTier16 = 6873,
        [Description("Raised Spectre Max Level")]
        RaisedSpectreMaxLevel = 6874,
        [Description("Summon Specific Monsters In Front Angle Offset")]
        SummonSpecificMonstersInFrontAngleOffset = 6875,
        [Description("Move Daemon Random Xy Offset")]
        MoveDaemonRandomXyOffset = 6876,
        [Description("Move Daemon Random X Offset")]
        MoveDaemonRandomXOffset = 6877,
        [Description("Move Daemon Random Y Offset")]
        MoveDaemonRandomYOffset = 6878,
        [Description("Endurance Charge Slam Damage +% Final With Endurance Charge")]
        EnduranceChargeSlamDamagePosPctFinalWithEnduranceCharge = 6879,
        [Description("Generic Skill Trigger Skills With Id")]
        GenericSkillTriggerSkillsWithId = 6880,
        [Description("Generic Skill Trigger Id")]
        GenericSkillTriggerId = 6881,
        [Description("Generic Skill Trigger %")]
        GenericSkillTriggerPct = 6882,
        [Description("Projectile Swap From To Locations")]
        ProjectileSwapFromToLocations = 6883,
        [Description("Projectile Angle Variance")]
        ProjectileAngleVariance = 6884,
        [Description("Maligaro Combo Attack Third Hit Damage +% Final")]
        MaligaroComboAttackThirdHitDamagePosPctFinal = 6885,
        [Description("Minions Cannot Be Damaged")]
        MinionsCannotBeDamaged = 6886,
        [Description("Minions Deal No Damage")]
        MinionsDealNoDamage = 6887,
        [Description("Curse On Hit Level Assassins Mark")]
        CurseOnHitLevelAssassinsMark = 6888,
        [Description("Projectile Distance Override")]
        ProjectileDistanceOverride = 6889,
        [Description("Triggered Skill Use Animation Event")]
        TriggeredSkillUseAnimationEvent = 6890,
        [Description("Map Atlas Influence Type")]
        MapAtlasInfluenceType = 6891,
        [Description("Combo Attack First Hit Damage +% Final")]
        ComboAttackFirstHitDamagePosPctFinal = 6892,
        [Description("Support Storm Barrier Physical Damage Taken When Hit +% Final")]
        SupportStormBarrierPhysicalDamageTakenWhenHitPosPctFinal = 6893,
        [Description("Support Storm Barrier Lightning Damage Taken When Hit +% Final")]
        SupportStormBarrierLightningDamageTakenWhenHitPosPctFinal = 6894,
        [Description("Support Storm Barrier Gain Power Charge When Hit %")]
        SupportStormBarrierGainPowerChargeWhenHitPct = 6895,
        [Description("Gain Power Charge When Hit %")]
        GainPowerChargeWhenHitPct = 6896,
        [Description("Local Display Socketed Gems Supported By Level X Storm Barrier")]
        LocalDisplaySocketedGemsSupportedByLevelXStormBarrier = 6897,
        [Description("Gain Critical Strike Chance % For 2 Seconds When You Spend 800 Mana")]
        GainCriticalStrikeChancePctFor2SecondsWhenYouSpend800Mana = 6898,
        [Description("Virtual Maximum Life Leech Rate % Per Minute")]
        VirtualMaximumLifeLeechRatePctPerMinute = 6899,
        [Description("Keystone Vaal Pact")]
        KeystoneVaalPact = 6900,
        [Description("Life Leech Speed Is Doubled")]
        LifeLeechSpeedIsDoubled = 6901,
        [Description("Maximum Life Leech Rate % Per Minute Is Doubled")]
        MaximumLifeLeechRatePctPerMinuteIsDoubled = 6902,
        [Description("Spectres Have Base Duration Ms")]
        SpectresHaveBaseDurationMs = 6903,
        [Description("Spectres Critical Strike Chance +%")]
        SpectresCriticalStrikeChancePosPct = 6904,
        [Description("Gain Her Embrace For X Ms On Enemy Ignited")]
        GainHerEmbraceForXMsOnEnemyIgnited = 6905,
        [Description("Has Her Embrace")]
        HasHerEmbrace = 6906,
        [Description("% Maximum Es And Life Taken As Fire Damage Per Minute Per Level While In Her Embrace")]
        PctMaximumEsAndLifeTakenAsFireDamagePerMinutePerLevelWhileInHerEmbrace = 6907,
        [Description("Projectile Uses Contact Direction")]
        ProjectileUsesContactDirection = 6908,
        [Description("Spell Base Fire Damage % Maximum Life")]
        SpellBaseFireDamagePctMaximumLife = 6909,
        [Description("Additional Critical Strike Chance Per 10 Shield Maximum Energy Shield Permyriad")]
        AdditionalCriticalStrikeChancePer10ShieldMaximumEnergyShieldPermyriad = 6910,
        [Description("Bone Lance Skill Behaviour Variation")]
        BoneLanceSkillBehaviourVariation = 6911,
        [Description("Gain Armour Equal To Mana Reserved")]
        GainArmourEqualToManaReserved = 6912,
        [Description("Gain Vaal Pact If You Have Crit Recently")]
        GainVaalPactIfYouHaveCritRecently = 6913,
        [Description("Virtual Keystone Vaal Pact")]
        VirtualKeystoneVaalPact = 6914,
        [Description("Support Parallel Projectile Number Of Points Per Side")]
        SupportParallelProjectileNumberOfPointsPerSide = 6915,
        [Description("Support Spell Cascade Number Of Cascades Per Side")]
        SupportSpellCascadeNumberOfCascadesPerSide = 6916,
        [Description("Support Spell Cascade Area Of Effect +% Per Cascade")]
        SupportSpellCascadeAreaOfEffectPosPctPerCascade = 6917,
        [Description("Support Spell Cascade Area Of Effect +% Final")]
        SupportSpellCascadeAreaOfEffectPosPctFinal = 6918,
        [Description("Local Display Socketed Gems Supported By Level X Parallel Projectiles")]
        LocalDisplaySocketedGemsSupportedByLevelXParallelProjectiles = 6919,
        [Description("Local Display Socketed Gems Supported By Level X Spell Cascade")]
        LocalDisplaySocketedGemsSupportedByLevelXSpellCascade = 6920,
        [Description("Map Display Area Contains Unbridged Gaps To Cross")]
        MapDisplayAreaContainsUnbridgedGapsToCross = 6921,
        [Description("Map Players Movement Skills Cooldown Speed +%")]
        MapPlayersMovementSkillsCooldownSpeedPosPct = 6922,
        [Description("Movement Skills Cooldown Speed +%")]
        MovementSkillsCooldownSpeedPosPct = 6923,
        [Description("Map Packs Are Kitava")]
        MapPacksAreKitava = 6924,
        [Description("Map Packs Have Anomalies")]
        MapPacksHaveAnomalies = 6925,
        [Description("Map Shaper Influence Spawn Shaper Clone")]
        MapShaperInfluenceSpawnShaperClone = 6926,
        [Description("Map Shaper Influence Additional Packs Of Space Monsters")]
        MapShaperInfluenceAdditionalPacksOfSpaceMonsters = 6927,
        [Description("Map Shaper Influence Spawn Boss Pack")]
        MapShaperInfluenceSpawnBossPack = 6928,
        [Description("Map Shaper Influence Spawn Maelstrom Cell")]
        MapShaperInfluenceSpawnMaelstromCell = 6929,
        [Description("Grasping Vines Movement Speed +% Final")]
        GraspingVinesMovementSpeedPosPctFinal = 6930,
        [Description("Support Parallel Projectiles Damage +% Final")]
        SupportParallelProjectilesDamagePosPctFinal = 6931,
        [Description("Is Trigger Daemon When Hit Triggered Skill")]
        IsTriggerDaemonWhenHitTriggeredSkill = 6932,
        [Description("Trigger Daemon When Hit Triggered Skill Chance %")]
        TriggerDaemonWhenHitTriggeredSkillChancePct = 6933,
        [Description("Cannot Be Ignited With Strength Higher Than Dex")]
        CannotBeIgnitedWithStrengthHigherThanDex = 6934,
        [Description("Cannot Be Frozen With Dex Higher Than Int")]
        CannotBeFrozenWithDexHigherThanInt = 6935,
        [Description("Cannot Be Shocked With Int Higher Than Strength")]
        CannotBeShockedWithIntHigherThanStrength = 6936,
        [Description("Damage +% Per 5 Of Your Lowest Attribute")]
        DamagePosPctPer5OfYourLowestAttribute = 6937,
        [Description("Cannot Be Ignited")]
        CannotBeIgnited = 6938,
        [Description("Attacks With This Weapon Minimum Added Cold Damage Per 10 Dexterity")]
        AttacksWithThisWeaponMinimumAddedColdDamagePer10Dexterity = 6939,
        [Description("Attacks With This Weapon Maximum Added Cold Damage Per 10 Dexterity")]
        AttacksWithThisWeaponMaximumAddedColdDamagePer10Dexterity = 6940,
        [Description("Main Hand Attacks With This Weapon Minimum Added Cold Damage Per 10 Dexterity")]
        MainHandAttacksWithThisWeaponMinimumAddedColdDamagePer10Dexterity = 6941,
        [Description("Main Hand Attacks With This Weapon Maximum Added Cold Damage Per 10 Dexterity")]
        MainHandAttacksWithThisWeaponMaximumAddedColdDamagePer10Dexterity = 6942,
        [Description("Off Hand Attacks With This Weapon Minimum Added Cold Damage Per 10 Dexterity")]
        OffHandAttacksWithThisWeaponMinimumAddedColdDamagePer10Dexterity = 6943,
        [Description("Off Hand Attacks With This Weapon Maximum Added Cold Damage Per 10 Dexterity")]
        OffHandAttacksWithThisWeaponMaximumAddedColdDamagePer10Dexterity = 6944,
        [Description("Local Chaos Damage Taken Per Minute During Flask Effect")]
        LocalChaosDamageTakenPerMinuteDuringFlaskEffect = 6945,
        [Description("Melee Attack Number Of Spirit Strikes")]
        MeleeAttackNumberOfSpiritStrikes = 6946,
        [Description("Cannot Taunt Enemies")]
        CannotTauntEnemies = 6947,
        [Description("Minions Cannot Taunt Enemies")]
        MinionsCannotTauntEnemies = 6948,
        [Description("Base Number Of Support Ghosts Allowed")]
        BaseNumberOfSupportGhostsAllowed = 6949,
        [Description("Chance To Summon Support Ghost On Killing Blow %")]
        ChanceToSummonSupportGhostOnKillingBlowPct = 6950,
        [Description("Support Ghost Base Duration")]
        SupportGhostBaseDuration = 6951,
        [Description("Support Ghost Duration")]
        SupportGhostDuration = 6952,
        [Description("Skill Can Own Support Ghosts")]
        SkillCanOwnSupportGhosts = 6953,
        [Description("Local Display Socketed Gems Supported By Level X Spirit Strike")]
        LocalDisplaySocketedGemsSupportedByLevelXSpiritStrike = 6954,
        [Description("Local Display Socketed Gems Supported By Level X Summon Ghost On Kill")]
        LocalDisplaySocketedGemsSupportedByLevelXSummonGhostOnKill = 6955,
        [Description("Support Spirit Strike Damage +% Final")]
        SupportSpiritStrikeDamagePosPctFinal = 6956,
        [Description("Local Display Socketed Attacks Additional Critical Strike Chance")]
        LocalDisplaySocketedAttacksAdditionalCriticalStrikeChance = 6957,
        [Description("Local Display Socketed Attacks Critical Strike Multiplier +")]
        LocalDisplaySocketedAttacksCriticalStrikeMultiplierPos = 6958,
        [Description("Local Display Socketed Spells Additional Critical Strike Chance")]
        LocalDisplaySocketedSpellsAdditionalCriticalStrikeChance = 6959,
        [Description("Local Display Socketed Spells Critical Strike Multiplier +")]
        LocalDisplaySocketedSpellsCriticalStrikeMultiplierPos = 6960,
        [Description("Keystone Shared Suffering")]
        KeystoneSharedSuffering = 6961,
        [Description("All Damage Can Cause Elemental Ailments You Are Suffering From")]
        AllDamageCanCauseElementalAilmentsYouAreSufferingFrom = 6962,
        [Description("Base All Damage Can Cause Elemental Ailments You Are Suffering From")]
        BaseAllDamageCanCauseElementalAilmentsYouAreSufferingFrom = 6963,
        [Description("Always Inflict Elemental Ailments You Are Suffering From")]
        AlwaysInflictElementalAilmentsYouAreSufferingFrom = 6964,
        [Description("Base Always Inflict Elemental Ailments You Are Suffering From")]
        BaseAlwaysInflictElementalAilmentsYouAreSufferingFrom = 6965,
        [Description("Remove Elemental Ailments From You When You Inflict Them")]
        RemoveElementalAilmentsFromYouWhenYouInflictThem = 6966,
        [Description("Base Remove Elemental Ailments From You When You Inflict Them")]
        BaseRemoveElementalAilmentsFromYouWhenYouInflictThem = 6967,
        [Description("Geometry Attack Shape")]
        GeometryAttackShape = 6968,
        [Description("Geometry Attack Length")]
        GeometryAttackLength = 6969,
        [Description("Geometry Attack Width")]
        GeometryAttackWidth = 6970,
        [Description("Geometry Attack Arc Angle")]
        GeometryAttackArcAngle = 6971,
        [Description("Map Packs Have Tentacle Fiends")]
        MapPacksHaveTentacleFiends = 6972,
        [Description("No Movement Speed")]
        NoMovementSpeed = 6973,
        [Description("Unaffected By Shock")]
        UnaffectedByShock = 6974,
        [Description("Unaffected By Shocked Ground")]
        UnaffectedByShockedGround = 6975,
        [Description("Unaffected By Burning Ground")]
        UnaffectedByBurningGround = 6976,
        [Description("Unaffected By Chilled Ground")]
        UnaffectedByChilledGround = 6977,
        [Description("Unaffected By Desecrated Ground")]
        UnaffectedByDesecratedGround = 6978,
        [Description("Flammability Mana Reservation +%")]
        FlammabilityManaReservationPosPct = 6979,
        [Description("Frostbite Mana Reservation +%")]
        FrostbiteManaReservationPosPct = 6980,
        [Description("Conductivity Mana Reservation +%")]
        ConductivityManaReservationPosPct = 6981,
        [Description("Vulnerability Mana Reservation +%")]
        VulnerabilityManaReservationPosPct = 6982,
        [Description("Chaos Weakness Mana Reservation +%")]
        ChaosWeaknessManaReservationPosPct = 6983,
        [Description("Local Display Grants Skill Decoy Totem Level")]
        LocalDisplayGrantsSkillDecoyTotemLevel = 6984,
        [Description("Local Display Grants Skill Enduring Cry Level")]
        LocalDisplayGrantsSkillEnduringCryLevel = 6985,
        [Description("Local Display Grants Skill Rallying Cry Level")]
        LocalDisplayGrantsSkillRallyingCryLevel = 6986,
        [Description("Local Display Grants Skill Abyssal Cry Level")]
        LocalDisplayGrantsSkillAbyssalCryLevel = 6987,
        [Description("Local Display Grants Skill Herald Of Ash Level")]
        LocalDisplayGrantsSkillHeraldOfAshLevel = 6988,
        [Description("Local Display Grants Skill Herald Of Ice Level")]
        LocalDisplayGrantsSkillHeraldOfIceLevel = 6989,
        [Description("Local Display Grants Skill Herald Of Thunder Level")]
        LocalDisplayGrantsSkillHeraldOfThunderLevel = 6990,
        [Description("Curse On Hit Level Poachers Mark")]
        CurseOnHitLevelPoachersMark = 6991,
        [Description("Curse On Hit Level Warlords Mark")]
        CurseOnHitLevelWarlordsMark = 6992,
        [Description("Elemental Damage Can Shock")]
        ElementalDamageCanShock = 6993,
        [Description("Ailment Types Apply Damage Taken +%")]
        AilmentTypesApplyDamageTakenPosPct = 6994,
        [Description("Evasion Rating +% While Leeching")]
        EvasionRatingPosPctWhileLeeching = 6995,
        [Description("Blind Enemies When Hit % Chance")]
        BlindEnemiesWhenHitPctChance = 6996,
        [Description("Evasion Rating +% If You Have Hit An Enemy Recently")]
        EvasionRatingPosPctIfYouHaveHitAnEnemyRecently = 6997,
        [Description("Gain 1 Rare Monster Mod On Kill For 10 Seconds % Chance")]
        Gain1RareMonsterModOnKillFor10SecondsPctChance = 6998,
        [Description("Enemy Evasion +% If You Have Hit Them Recently")]
        EnemyEvasionPosPctIfYouHaveHitThemRecently = 6999,
        [Description("Critical Strike Multiplier + If Have Not Dealt Critical Strike Recently")]
        CriticalStrikeMultiplierPosIfHaveNotDealtCriticalStrikeRecently = 7000,
        [Description("Number Of Additional Arrows While Main Hand Accuracy Is 3000 Or More")]
        NumberOfAdditionalArrowsWhileMainHandAccuracyIs3000OrMore = 7001,
        [Description("Accuracy Rating Is Doubled")]
        AccuracyRatingIsDoubled = 7002,
        [Description("Melee Physical Damage +% Per 10 Strength While Fortified")]
        MeleePhysicalDamagePosPctPer10StrengthWhileFortified = 7003,
        [Description("Chance To Dodge Attacks % While Off Hand Is Empty")]
        ChanceToDodgeAttacksPctWhileOffHandIsEmpty = 7004,
        [Description("Cold Damage +% While Off Hand Is Empty")]
        ColdDamagePosPctWhileOffHandIsEmpty = 7005,
        [Description("Iron Reflexes Rotation Active")]
        IronReflexesRotationActive = 7006,
        [Description("Unique Bow Arborix Close Range Bow Damage +% Final While Have Iron Reflexes")]
        UniqueBowArborixCloseRangeBowDamagePosPctFinalWhileHaveIronReflexes = 7007,
        [Description("Unique Bow Arborix Close Range Bow Damage +% Final")]
        UniqueBowArborixCloseRangeBowDamagePosPctFinal = 7008,
        [Description("Virtual Player Far Shot")]
        VirtualPlayerFarShot = 7009,
        [Description("Gain Player Far Shot While Do Not Have Iron Reflexes")]
        GainPlayerFarShotWhileDoNotHaveIronReflexes = 7010,
        [Description("Attack Cast And Movement Speed +% While Do Not Have Iron Reflexes")]
        AttackCastAndMovementSpeedPosPctWhileDoNotHaveIronReflexes = 7011,
        [Description("Local Display Trigger Death Walk On Equip Level")]
        LocalDisplayTriggerDeathWalkOnEquipLevel = 7012,
        [Description("Number Of Melee Abyss Jewels")]
        NumberOfMeleeAbyssJewels = 7013,
        [Description("Number Of Ranged Abyss Jewels")]
        NumberOfRangedAbyssJewels = 7014,
        [Description("Number Of Caster Abyss Jewels")]
        NumberOfCasterAbyssJewels = 7015,
        [Description("Number Of Minion Abyss Jewels")]
        NumberOfMinionAbyssJewels = 7016,
        [Description("Number Of Abyss Jewels")]
        NumberOfAbyssJewels = 7017,
        [Description("Number Of Abyss Jewel Types")]
        NumberOfAbyssJewelTypes = 7018,
        [Description("Damage +% Per Abyss Jewel Type")]
        DamagePosPctPerAbyssJewelType = 7019,
        [Description("Support Spell Cascade Damage +% Final")]
        SupportSpellCascadeDamagePosPctFinal = 7020,
        [Description("Virtual Physical Damage Can Chill")]
        VirtualPhysicalDamageCanChill = 7021,
        [Description("Virtual Fire Damage Can Chill")]
        VirtualFireDamageCanChill = 7022,
        [Description("Virtual Cold Damage Cannot Chill")]
        VirtualColdDamageCannotChill = 7023,
        [Description("Virtual Lightning Damage Can Chill")]
        VirtualLightningDamageCanChill = 7024,
        [Description("Virtual Chaos Damage Can Chill")]
        VirtualChaosDamageCanChill = 7025,
        [Description("Fire Damage Can Chill")]
        FireDamageCanChill = 7026,
        [Description("Lightning Damage Can Chill")]
        LightningDamageCanChill = 7027,
        [Description("Virtual Physical Damage Can Freeze")]
        VirtualPhysicalDamageCanFreeze = 7028,
        [Description("Virtual Fire Damage Can Freeze")]
        VirtualFireDamageCanFreeze = 7029,
        [Description("Virtual Cold Damage Cannot Freeze")]
        VirtualColdDamageCannotFreeze = 7030,
        [Description("Virtual Lightning Damage Can Freeze")]
        VirtualLightningDamageCanFreeze = 7031,
        [Description("Virtual Chaos Damage Can Freeze")]
        VirtualChaosDamageCanFreeze = 7032,
        [Description("Physical Damage Can Freeze")]
        PhysicalDamageCanFreeze = 7033,
        [Description("Fire Damage Can Freeze")]
        FireDamageCanFreeze = 7034,
        [Description("Chaos Damage Can Freeze")]
        ChaosDamageCanFreeze = 7035,
        [Description("All Damage Can Freeze")]
        AllDamageCanFreeze = 7036,
        [Description("Virtual Physical Damage Can Shock")]
        VirtualPhysicalDamageCanShock = 7037,
        [Description("Virtual Fire Damage Can Shock")]
        VirtualFireDamageCanShock = 7038,
        [Description("Virtual Cold Damage Can Shock")]
        VirtualColdDamageCanShock = 7039,
        [Description("Virtual Lightning Damage Cannot Shock")]
        VirtualLightningDamageCannotShock = 7040,
        [Description("Virtual Chaos Damage Can Shock")]
        VirtualChaosDamageCanShock = 7041,
        [Description("Cold Damage Can Shock")]
        ColdDamageCanShock = 7042,
        [Description("Chaos Damage Cannot Poison")]
        ChaosDamageCannotPoison = 7043,
        [Description("Physical Damage Cannot Poison")]
        PhysicalDamageCannotPoison = 7044,
        [Description("Area Of Effect +% With 500 Or More Strength")]
        AreaOfEffectPosPctWith500OrMoreStrength = 7045,
        [Description("Area Of Effect +% If Have Stunned An Enemy Recently")]
        AreaOfEffectPosPctIfHaveStunnedAnEnemyRecently = 7046,
        [Description("Track Have Stunned An Enemy Recently")]
        TrackHaveStunnedAnEnemyRecently = 7047,
        [Description("Have Stunned An Enemy Recently")]
        HaveStunnedAnEnemyRecently = 7048,
        [Description("Chance To Gain Endurance Charge On Hit % Vs Bleeding Enemy")]
        ChanceToGainEnduranceChargeOnHitPctVsBleedingEnemy = 7049,
        [Description("Local Display Socketed Movement Skills Have No Mana Cost")]
        LocalDisplaySocketedMovementSkillsHaveNoManaCost = 7050,
        [Description("Local Hits With This Weapon Always Hit If Have Blocked Recently")]
        LocalHitsWithThisWeaponAlwaysHitIfHaveBlockedRecently = 7051,
        [Description("Main Hand Hits With This Weapon Always Hit If Have Blocked Recently")]
        MainHandHitsWithThisWeaponAlwaysHitIfHaveBlockedRecently = 7052,
        [Description("Off Hand Hits With This Weapon Always Hit If Have Blocked Recently")]
        OffHandHitsWithThisWeaponAlwaysHitIfHaveBlockedRecently = 7053,
        [Description("Additional Block % Per Endurance Charge")]
        AdditionalBlockPctPerEnduranceCharge = 7054,
        [Description("Attack Speed +% If Have Blocked Recently")]
        AttackSpeedPosPctIfHaveBlockedRecently = 7055,
        [Description("Local Display Trigger Level X Smoke Cloud On Trap Triggered")]
        LocalDisplayTriggerLevelXSmokeCloudOnTrapTriggered = 7056,
        [Description("Area Of Effect +% While Fortified")]
        AreaOfEffectPosPctWhileFortified = 7057,
        [Description("Melee Weapon Range + If You Have Killed Recently")]
        MeleeWeaponRangePosIfYouHaveKilledRecently = 7058,
        [Description("Melee Weapon Range + While Fortified")]
        MeleeWeaponRangePosWhileFortified = 7059,
        [Description("Stun Duration +% Per 15 Strength")]
        StunDurationPosPctPer15Strength = 7060,
        [Description("Stun Threshold Reduction +% With 500 Or More Strength")]
        StunThresholdReductionPosPctWith500OrMoreStrength = 7061,
        [Description("Area Of Effect +% Per Endurance Charge")]
        AreaOfEffectPosPctPerEnduranceCharge = 7062,
        [Description("Area Damage +% Per 12 Strength")]
        AreaDamagePosPctPer12Strength = 7063,
        [Description("Damage +% Vs Taunted Enemies")]
        DamagePosPctVsTauntedEnemies = 7064,
        [Description("Chance To Gain Endurance Charge When You Taunt Enemy %")]
        ChanceToGainEnduranceChargeWhenYouTauntEnemyPct = 7065,
        [Description("Attacks Chance To Bleed On Hit % Vs Taunted Enemies")]
        AttacksChanceToBleedOnHitPctVsTauntedEnemies = 7066,
        [Description("Bleed Damage +% Per Endurance Charge")]
        BleedDamagePosPctPerEnduranceCharge = 7067,
        [Description("Melee Movement Skill Chance To Fortify On Hit %")]
        MeleeMovementSkillChanceToFortifyOnHitPct = 7068,
        [Description("Melee Weapon Range + While At Maximum Frenzy Charges")]
        MeleeWeaponRangePosWhileAtMaximumFrenzyCharges = 7069,
        [Description("Poison Damage +% Vs Bleeding Enemies")]
        PoisonDamagePosPctVsBleedingEnemies = 7070,
        [Description("Additional Physical Damage Reduction % While Moving")]
        AdditionalPhysicalDamageReductionPctWhileMoving = 7071,
        [Description("Elemental Damage Taken +% While Stationary")]
        ElementalDamageTakenPosPctWhileStationary = 7072,
        [Description("Map Monsters Avoid Ailments %")]
        MapMonstersAvoidAilmentsPct = 7073,
        [Description("Number Of Endurance Charges To Gain Every 4 Seconds While Stationary")]
        NumberOfEnduranceChargesToGainEvery4SecondsWhileStationary = 7074,
        [Description("Maximum Life +% Per Abyssal Jewel Affecting You")]
        MaximumLifePosPctPerAbyssalJewelAffectingYou = 7075,
        [Description("Maximum Mana +% Per Abyssal Jewel Affecting You")]
        MaximumManaPosPctPerAbyssalJewelAffectingYou = 7076,
        [Description("Cast Speed +% During Flask Effect")]
        CastSpeedPosPctDuringFlaskEffect = 7077,
        [Description("Melee Damage +% During Flask Effect")]
        MeleeDamagePosPctDuringFlaskEffect = 7078,
        [Description("Projectile Attack Damage +% During Flask Effect")]
        ProjectileAttackDamagePosPctDuringFlaskEffect = 7079,
        [Description("Spell Damage +% During Flask Effect")]
        SpellDamagePosPctDuringFlaskEffect = 7080,
        [Description("Local Crits Have Culling Strike")]
        LocalCritsHaveCullingStrike = 7081,
        [Description("Main Hand Local Crits Have Culling Strike")]
        MainHandLocalCritsHaveCullingStrike = 7082,
        [Description("Off Hand Local Crits Have Culling Strike")]
        OffHandLocalCritsHaveCullingStrike = 7083,
        [Description("Global Minimum Added Fire Damage Vs Ignited Enemies")]
        GlobalMinimumAddedFireDamageVsIgnitedEnemies = 7084,
        [Description("Global Maximum Added Fire Damage Vs Ignited Enemies")]
        GlobalMaximumAddedFireDamageVsIgnitedEnemies = 7085,
        [Description("Global Minimum Added Cold Damage Vs Chilled Or Frozen Enemies")]
        GlobalMinimumAddedColdDamageVsChilledOrFrozenEnemies = 7086,
        [Description("Global Maximum Added Cold Damage Vs Chilled Or Frozen Enemies")]
        GlobalMaximumAddedColdDamageVsChilledOrFrozenEnemies = 7087,
        [Description("Global Minimum Added Lightning Damage Vs Shocked Enemies")]
        GlobalMinimumAddedLightningDamageVsShockedEnemies = 7088,
        [Description("Global Maximum Added Lightning Damage Vs Shocked Enemies")]
        GlobalMaximumAddedLightningDamageVsShockedEnemies = 7089,
        [Description("Chill Attackers For 4 Seconds On Block % Chance")]
        ChillAttackersFor4SecondsOnBlockPctChance = 7090,
        [Description("Shock Attackers For 4 Seconds On Block % Chance")]
        ShockAttackersFor4SecondsOnBlockPctChance = 7091,
        [Description("Damage +% Per 1% Block Chance")]
        DamagePosPctPer1PctBlockChance = 7092,
        [Description("Dodge Attacks Chance % If You Have Blocked Recently")]
        DodgeAttacksChancePctIfYouHaveBlockedRecently = 7093,
        [Description("Damage +% Per 15 Strength")]
        DamagePosPctPer15Strength = 7094,
        [Description("Damage +% Per 15 Dex")]
        DamagePosPctPer15Dex = 7095,
        [Description("Damage +% Per 15 Int")]
        DamagePosPctPer15Int = 7096,
        [Description("Additional Block % With 5 Or More Nearby Enemies")]
        AdditionalBlockPctWith5OrMoreNearbyEnemies = 7097,
        [Description("Gain Random Charge On Block")]
        GainRandomChargeOnBlock = 7098,
        [Description("Chance To Evade Attacks %")]
        ChanceToEvadeAttacksPct = 7099,
        [Description("Mana Gained On Spell Hit")]
        ManaGainedOnSpellHit = 7100,
        [Description("Remove Ignite And Burning On Flask Use")]
        RemoveIgniteAndBurningOnFlaskUse = 7101,
        [Description("Remove Chill And Freeze On Flask Use")]
        RemoveChillAndFreezeOnFlaskUse = 7102,
        [Description("Remove Shock On Flask Use")]
        RemoveShockOnFlaskUse = 7103,
        [Description("Number Of Equipped Elder Items")]
        NumberOfEquippedElderItems = 7104,
        [Description("Maximum Life Per Equipped Elder Item")]
        MaximumLifePerEquippedElderItem = 7105,
        [Description("Non Damaging Ailment Effect +% Per Equipped Elder Item")]
        NonDamagingAilmentEffectPosPctPerEquippedElderItem = 7106,
        [Description("Ailment Damage +% Per Equipped Elder Item")]
        AilmentDamagePosPctPerEquippedElderItem = 7107,
        [Description("Remove Random Ailment On Flask Use If All Equipped Items Are Elder")]
        RemoveRandomAilmentOnFlaskUseIfAllEquippedItemsAreElder = 7108,
        [Description("Virtual Freeze Effect +%")]
        VirtualFreezeEffectPosPct = 7109,
        [Description("Virtual Ignite Effect +%")]
        VirtualIgniteEffectPosPct = 7110,
        [Description("Virtual Poison Effect +%")]
        VirtualPoisonEffectPosPct = 7111,
        [Description("Virtual Bleed Effect +%")]
        VirtualBleedEffectPosPct = 7112,
        [Description("Virtual Minion Elemental Resistance %")]
        VirtualMinionElementalResistancePct = 7113,
        [Description("Minion Elemental Resistance 30%")]
        MinionElementalResistance30Pct = 7114,
        [Description("Strength Damage Bonus Grants Melee Physical Damage +3% Per 10 Strength Instead")]
        StrengthDamageBonusGrantsMeleePhysicalDamagePos3PctPer10StrengthInstead = 7115,
        [Description("Fortify Duration +% Per 10 Strength")]
        FortifyDurationPosPctPer10Strength = 7116,
        [Description("Attack Additional Critical Strike Chance Permyriad")]
        AttackAdditionalCriticalStrikeChancePermyriad = 7117,
        [Description("Spell Additional Critical Strike Chance Permyriad")]
        SpellAdditionalCriticalStrikeChancePermyriad = 7118,
        [Description("Virtual Fortify Duration +%")]
        VirtualFortifyDurationPosPct = 7119,
        [Description("Virtual Fortify Effect On Self +%")]
        VirtualFortifyEffectOnSelfPosPct = 7120,
        [Description("Fortify Effect On Self +% While Stationary")]
        FortifyEffectOnSelfPosPctWhileStationary = 7121,
        [Description("Remove Bleeding On Warcry")]
        RemoveBleedingOnWarcry = 7122,
        [Description("Chance To Gain Endurance Charge When You Stun Enemy %")]
        ChanceToGainEnduranceChargeWhenYouStunEnemyPct = 7123,
        [Description("Critical Strike Multiplier + If You Have Blocked Recently")]
        CriticalStrikeMultiplierPosIfYouHaveBlockedRecently = 7124,
        [Description("Bleeding Damage +% Vs Poisoned Enemies")]
        BleedingDamagePosPctVsPoisonedEnemies = 7125,
        [Description("Area Of Effect +% If You Have Blocked Recently")]
        AreaOfEffectPosPctIfYouHaveBlockedRecently = 7126,
        [Description("Elemental Damage +% Per Power Charge")]
        ElementalDamagePosPctPerPowerCharge = 7127,
        [Description("Elemental Damage +% Per 12 Int")]
        ElementalDamagePosPctPer12Int = 7128,
        [Description("Elemental Damage +% Per 12 Strength")]
        ElementalDamagePosPctPer12Strength = 7129,
        [Description("Elemental Damage Taken +% Per Endurance Charge")]
        ElementalDamageTakenPosPctPerEnduranceCharge = 7130,
        [Description("Additional Block % If You Have Crit Recently")]
        AdditionalBlockPctIfYouHaveCritRecently = 7131,
        [Description("Area Of Effect +% Per 50 Strength")]
        AreaOfEffectPosPctPer50Strength = 7132,
        [Description("Local Life Gain Per Target Vs Blinded Enemies")]
        LocalLifeGainPerTargetVsBlindedEnemies = 7133,
        [Description("Main Hand Local Life Gain Per Target Vs Blinded Enemies")]
        MainHandLocalLifeGainPerTargetVsBlindedEnemies = 7134,
        [Description("Off Hand Local Life Gain Per Target Vs Blinded Enemies")]
        OffHandLocalLifeGainPerTargetVsBlindedEnemies = 7135,
        [Description("Local Culling Strike If Crit Recently")]
        LocalCullingStrikeIfCritRecently = 7136,
        [Description("Main Hand Culling Strike If Crit Recently")]
        MainHandCullingStrikeIfCritRecently = 7137,
        [Description("Off Hand Culling Strike If Crit Recently")]
        OffHandCullingStrikeIfCritRecently = 7138,
        [Description("Support Mirage Archer Base Duration")]
        SupportMirageArcherBaseDuration = 7139,
        [Description("Support Mirage Archer Duration")]
        SupportMirageArcherDuration = 7140,
        [Description("Summon Mirage Archer On Hit")]
        SummonMirageArcherOnHit = 7141,
        [Description("Skill Can Own Mirage Archers")]
        SkillCanOwnMirageArchers = 7142,
        [Description("Number Of Mirage Archers Allowed")]
        NumberOfMirageArchersAllowed = 7143,
        [Description("Support Mirage Archer Damage +% Final")]
        SupportMirageArcherDamagePosPctFinal = 7144,
        [Description("Use Scaled Contact Offset")]
        UseScaledContactOffset = 7145,
        [Description("Local Culling Strike Vs Bleeding Enemies")]
        LocalCullingStrikeVsBleedingEnemies = 7146,
        [Description("Main Hand Culling Strike Vs Bleeding Enemies")]
        MainHandCullingStrikeVsBleedingEnemies = 7147,
        [Description("Off Hand Culling Strike Vs Bleeding Enemies")]
        OffHandCullingStrikeVsBleedingEnemies = 7148,
        [Description("Local Display Grants Level X Blood Offering Skill")]
        LocalDisplayGrantsLevelXBloodOfferingSkill = 7149,
        [Description("Active Skill Projectile Speed +% Variation Final")]
        ActiveSkillProjectileSpeedPosPctVariationFinal = 7150,
        [Description("Local Socketed Abyss Jewel Effect +%")]
        LocalSocketedAbyssJewelEffectPosPct = 7151,
        [Description("Non Piercing Projectiles Critical Strike Chance +%")]
        NonPiercingProjectilesCriticalStrikeChancePosPct = 7152,
        [Description("Local Evasion Rating And Energy Shield")]
        LocalEvasionRatingAndEnergyShield = 7153,
        [Description("Number Of Additional Projectiles If You Have Been Hit Recently")]
        NumberOfAdditionalProjectilesIfYouHaveBeenHitRecently = 7154,
        [Description("Gain Iron Reflexes While Stationary")]
        GainIronReflexesWhileStationary = 7155,
        [Description("Armour +% While Stationary")]
        ArmourPosPctWhileStationary = 7156,
        [Description("Number Of Additional Projectiles If You Have Used Movement Skill Recently")]
        NumberOfAdditionalProjectilesIfYouHaveUsedMovementSkillRecently = 7157,
        [Description("Virtual Keystone Iron Reflexes")]
        VirtualKeystoneIronReflexes = 7158,
        [Description("Attacks Intimidate On Hit %")]
        AttacksIntimidateOnHitPct = 7159,
        [Description("Local Attacks Intimidate On Hit For 4 Seconds With Melee Abyss Jewel Socketed")]
        LocalAttacksIntimidateOnHitFor4SecondsWithMeleeAbyssJewelSocketed = 7160,
        [Description("Local Attacks Maim On Hit For 4 Seconds With Ranged Abyss Jewel Socketed")]
        LocalAttacksMaimOnHitFor4SecondsWithRangedAbyssJewelSocketed = 7161,
        [Description("Elemental Overload Rotation Active")]
        ElementalOverloadRotationActive = 7162,
        [Description("Gain Resolute Technique While Do Not Have Elemental Overload")]
        GainResoluteTechniqueWhileDoNotHaveElementalOverload = 7163,
        [Description("Virtual Keystone Resolute Technique")]
        VirtualKeystoneResoluteTechnique = 7164,
        [Description("Local Minimum Added Physical Damage Vs Ignited Enemies")]
        LocalMinimumAddedPhysicalDamageVsIgnitedEnemies = 7165,
        [Description("Local Maximum Added Physical Damage Vs Ignited Enemies")]
        LocalMaximumAddedPhysicalDamageVsIgnitedEnemies = 7166,
        [Description("Local Minimum Added Fire Damage Vs Bleeding Enemies")]
        LocalMinimumAddedFireDamageVsBleedingEnemies = 7167,
        [Description("Local Maximum Added Fire Damage Vs Bleeding Enemies")]
        LocalMaximumAddedFireDamageVsBleedingEnemies = 7168,
        [Description("Main Hand Minimum Added Physical Damage Vs Ignited Enemies")]
        MainHandMinimumAddedPhysicalDamageVsIgnitedEnemies = 7169,
        [Description("Main Hand Maximum Added Physical Damage Vs Ignited Enemies")]
        MainHandMaximumAddedPhysicalDamageVsIgnitedEnemies = 7170,
        [Description("Main Hand Minimum Added Fire Damage Vs Bleeding Enemies")]
        MainHandMinimumAddedFireDamageVsBleedingEnemies = 7171,
        [Description("Main Hand Maximum Added Fire Damage Vs Bleeding Enemies")]
        MainHandMaximumAddedFireDamageVsBleedingEnemies = 7172,
        [Description("Off Hand Minimum Added Physical Damage Vs Ignited Enemies")]
        OffHandMinimumAddedPhysicalDamageVsIgnitedEnemies = 7173,
        [Description("Off Hand Maximum Added Physical Damage Vs Ignited Enemies")]
        OffHandMaximumAddedPhysicalDamageVsIgnitedEnemies = 7174,
        [Description("Off Hand Minimum Added Fire Damage Vs Bleeding Enemies")]
        OffHandMinimumAddedFireDamageVsBleedingEnemies = 7175,
        [Description("Off Hand Maximum Added Fire Damage Vs Bleeding Enemies")]
        OffHandMaximumAddedFireDamageVsBleedingEnemies = 7176,
        [Description("Local Chance Bleed On Hit % Vs Ignited Enemies")]
        LocalChanceBleedOnHitPctVsIgnitedEnemies = 7177,
        [Description("Main Hand Chance Bleed On Hit % Vs Ignited Enemies")]
        MainHandChanceBleedOnHitPctVsIgnitedEnemies = 7178,
        [Description("Off Hand Chance Bleed On Hit % Vs Ignited Enemies")]
        OffHandChanceBleedOnHitPctVsIgnitedEnemies = 7179,
        [Description("Avatar Of Fire Rotation Active")]
        AvatarOfFireRotationActive = 7180,
        [Description("Critical Strike Chance +% While You Have Avatar Of Fire")]
        CriticalStrikeChancePosPctWhileYouHaveAvatarOfFire = 7181,
        [Description("Physical Damage % To Convert To Fire While You Have Avatar Of Fire")]
        PhysicalDamagePctToConvertToFireWhileYouHaveAvatarOfFire = 7182,
        [Description("Armour While You Do Not Have Avatar Of Fire")]
        ArmourWhileYouDoNotHaveAvatarOfFire = 7183,
        [Description("Non Chaos Damage To Add As Chaos Damage %")]
        NonChaosDamageToAddAsChaosDamagePct = 7184,
        [Description("Projectile Non Chaos Damage To Add As Chaos Damage % Per Chain")]
        ProjectileNonChaosDamageToAddAsChaosDamagePctPerChain = 7185,
        [Description("Attack Speed +% If Enemy Killed Recently")]
        AttackSpeedPosPctIfEnemyKilledRecently = 7186,
        [Description("Critical Strike Chance +% If Enemy Killed Recently")]
        CriticalStrikeChancePosPctIfEnemyKilledRecently = 7187,
        [Description("Projectile Damage +% Per Pierced Enemy")]
        ProjectileDamagePosPctPerPiercedEnemy = 7188,
        [Description("Recover Energy Shield % On Kill")]
        RecoverEnergyShieldPctOnKill = 7189,
        [Description("Map Monsters Add Power Charge On Hit %")]
        MapMonstersAddPowerChargeOnHitPct = 7190,
        [Description("Map Monsters Add Frenzy Charge On Hit %")]
        MapMonstersAddFrenzyChargeOnHitPct = 7191,
        [Description("Map Monsters Add Endurance Charge On Hit %")]
        MapMonstersAddEnduranceChargeOnHitPct = 7192,
        [Description("Local Life Gain Per Target While Leeching")]
        LocalLifeGainPerTargetWhileLeeching = 7193,
        [Description("Main Hand Life Gain Per Target While Leeching")]
        MainHandLifeGainPerTargetWhileLeeching = 7194,
        [Description("Off Hand Life Gain Per Target While Leeching")]
        OffHandLifeGainPerTargetWhileLeeching = 7195,
        [Description("Local Display Socketed Gems Supported By Level X Mirage Archer")]
        LocalDisplaySocketedGemsSupportedByLevelXMirageArcher = 7196,
        [Description("Spectre Duration")]
        SpectreDuration = 7197,
        [Description("Arrows That Pierce Also Return")]
        ArrowsThatPierceAlsoReturn = 7198,
        [Description("Predict Totem Maximum Life")]
        PredictTotemMaximumLife = 7199,
        [Description("Unique Monster Dropped Item Rarity +%")]
        UniqueMonsterDroppedItemRarityPosPct = 7200,
        [Description("Cannot Block Spells")]
        CannotBlockSpells = 7201,
        [Description("Gain Endurance Charge % Chance When You Lose Fortify")]
        GainEnduranceChargePctChanceWhenYouLoseFortify = 7202,
        [Description("Affected By Determination")]
        AffectedByDetermination = 7203,
        [Description("Affected By Grace")]
        AffectedByGrace = 7204,
        [Description("Affected By Discipline")]
        AffectedByDiscipline = 7205,
        [Description("Affected By Wrath")]
        AffectedByWrath = 7206,
        [Description("Affected By Anger")]
        AffectedByAnger = 7207,
        [Description("Affected By Hatred")]
        AffectedByHatred = 7208,
        [Description("Affected By Vitality")]
        AffectedByVitality = 7209,
        [Description("Affected By Clarity")]
        AffectedByClarity = 7210,
        [Description("Affected By Haste")]
        AffectedByHaste = 7211,
        [Description("Affected By Purity Of Fire")]
        AffectedByPurityOfFire = 7212,
        [Description("Affected By Purity Of Ice")]
        AffectedByPurityOfIce = 7213,
        [Description("Affected By Purity Of Lightning")]
        AffectedByPurityOfLightning = 7214,
        [Description("Affected By Purity Of Elements")]
        AffectedByPurityOfElements = 7215,
        [Description("Additional Physical Damage Reduction % While Affected By Determination")]
        AdditionalPhysicalDamageReductionPctWhileAffectedByDetermination = 7216,
        [Description("Block % While Affected By Determination")]
        BlockPctWhileAffectedByDetermination = 7217,
        [Description("Extra Damage Taken From Crit +% While Affected By Determination")]
        ExtraDamageTakenFromCritPosPctWhileAffectedByDetermination = 7218,
        [Description("Chance To Evade Attacks % While Affected By Grace")]
        ChanceToEvadeAttacksPctWhileAffectedByGrace = 7219,
        [Description("Chance To Dodge Attacks % While Affected By Grace")]
        ChanceToDodgeAttacksPctWhileAffectedByGrace = 7220,
        [Description("Movement Speed +% While Affected By Grace")]
        MovementSpeedPosPctWhileAffectedByGrace = 7221,
        [Description("Unaffected By Vulnerability While Affected By Determination")]
        UnaffectedByVulnerabilityWhileAffectedByDetermination = 7222,
        [Description("Unaffected By Enfeeble While Affected By Grace")]
        UnaffectedByEnfeebleWhileAffectedByGrace = 7223,
        [Description("Unaffected By Temporal Chains While Affected By Haste")]
        UnaffectedByTemporalChainsWhileAffectedByHaste = 7224,
        [Description("Unaffected By Burning Ground While Affected By Purity Of Fire")]
        UnaffectedByBurningGroundWhileAffectedByPurityOfFire = 7225,
        [Description("Unaffected By Flammability While Affected By Purity Of Fire")]
        UnaffectedByFlammabilityWhileAffectedByPurityOfFire = 7226,
        [Description("Unaffected By Chilled Ground While Affected By Purity Of Ice")]
        UnaffectedByChilledGroundWhileAffectedByPurityOfIce = 7227,
        [Description("Unaffected By Frostbite While Affected By Purity Of Ice")]
        UnaffectedByFrostbiteWhileAffectedByPurityOfIce = 7228,
        [Description("Unaffected By Shocked Ground While Affected By Purity Of Lightning")]
        UnaffectedByShockedGroundWhileAffectedByPurityOfLightning = 7229,
        [Description("Unaffected By Conductivity While Affected By Purity Of Lightning")]
        UnaffectedByConductivityWhileAffectedByPurityOfLightning = 7230,
        [Description("Unaffected By Elemental Weakness While Affected By Purity Of Elements")]
        UnaffectedByElementalWeaknessWhileAffectedByPurityOfElements = 7231,
        [Description("Reduce Enemy Cold Resistance % While Affected By Hatred")]
        ReduceEnemyColdResistancePctWhileAffectedByHatred = 7232,
        [Description("Reduce Enemy Fire Resistance % While Affected By Anger")]
        ReduceEnemyFireResistancePctWhileAffectedByAnger = 7233,
        [Description("Reduce Enemy Lightning Resistance % While Affected By Wrath")]
        ReduceEnemyLightningResistancePctWhileAffectedByWrath = 7234,
        [Description("Energy Shield Regeneration Rate Per Minute % While Affected By Discipline")]
        EnergyShieldRegenerationRatePerMinutePctWhileAffectedByDiscipline = 7235,
        [Description("Chance To Block Spells % While Affected By Discipline")]
        ChanceToBlockSpellsPctWhileAffectedByDiscipline = 7236,
        [Description("Energy Shield Delay -% While Affected By Discipline")]
        EnergyShieldDelayNegPctWhileAffectedByDiscipline = 7237,
        [Description("Energy Shield Gain Per Target Hit While Affected By Discipline")]
        EnergyShieldGainPerTargetHitWhileAffectedByDiscipline = 7238,
        [Description("Mana Leech From Lightning Damage Permyriad While Affected By Wrath")]
        ManaLeechFromLightningDamagePermyriadWhileAffectedByWrath = 7239,
        [Description("Physical Damage % To Add As Lightning Damage While Affected By Wrath")]
        PhysicalDamagePctToAddAsLightningDamageWhileAffectedByWrath = 7240,
        [Description("Base Physical Damage % To Convert To Lightning While Affected By Wrath")]
        BasePhysicalDamagePctToConvertToLightningWhileAffectedByWrath = 7241,
        [Description("Virtual Non Skill Physical Damage % To Convert To Fire")]
        VirtualNonSkillPhysicalDamagePctToConvertToFire = 7242,
        [Description("Virtual Non Skill Physical Damage % To Convert To Cold")]
        VirtualNonSkillPhysicalDamagePctToConvertToCold = 7243,
        [Description("Virtual Non Skill Physical Damage % To Convert To Lightning")]
        VirtualNonSkillPhysicalDamagePctToConvertToLightning = 7244,
        [Description("Virtual Non Skill Physical Damage % To Convert To Chaos")]
        VirtualNonSkillPhysicalDamagePctToConvertToChaos = 7245,
        [Description("Virtual Non Skill Lightning Damage % To Convert To Fire")]
        VirtualNonSkillLightningDamagePctToConvertToFire = 7246,
        [Description("Virtual Non Skill Lightning Damage % To Convert To Cold")]
        VirtualNonSkillLightningDamagePctToConvertToCold = 7247,
        [Description("Virtual Non Skill Lightning Damage % To Convert To Chaos")]
        VirtualNonSkillLightningDamagePctToConvertToChaos = 7248,
        [Description("Virtual Non Skill Cold Damage % To Convert To Fire")]
        VirtualNonSkillColdDamagePctToConvertToFire = 7249,
        [Description("Virtual Non Skill Cold Damage % To Convert To Chaos")]
        VirtualNonSkillColdDamagePctToConvertToChaos = 7250,
        [Description("Virtual Non Skill Fire Damage % To Convert To Chaos")]
        VirtualNonSkillFireDamagePctToConvertToChaos = 7251,
        [Description("Base Physical Damage % To Convert To Fire While Affected By Anger")]
        BasePhysicalDamagePctToConvertToFireWhileAffectedByAnger = 7252,
        [Description("Physical Damage % To Add As Fire Damage While Affected By Anger")]
        PhysicalDamagePctToAddAsFireDamageWhileAffectedByAnger = 7253,
        [Description("Life Leech From Fire Damage Permyriad While Affected By Anger")]
        LifeLeechFromFireDamagePermyriadWhileAffectedByAnger = 7254,
        [Description("Minimum Added Cold Damage While Affected By Hatred")]
        MinimumAddedColdDamageWhileAffectedByHatred = 7255,
        [Description("Maximum Added Cold Damage While Affected By Hatred")]
        MaximumAddedColdDamageWhileAffectedByHatred = 7256,
        [Description("Base Physical Damage % To Convert To Cold While Affected By Hatred")]
        BasePhysicalDamagePctToConvertToColdWhileAffectedByHatred = 7257,
        [Description("Additional Critical Strike Chance Permyriad While Affected By Hatred")]
        AdditionalCriticalStrikeChancePermyriadWhileAffectedByHatred = 7258,
        [Description("Life Leech From Any Damage Permyriad While Affected By Vitality")]
        LifeLeechFromAnyDamagePermyriadWhileAffectedByVitality = 7259,
        [Description("Life Regeneration Per Minute While Affected By Vitality")]
        LifeRegenerationPerMinuteWhileAffectedByVitality = 7260,
        [Description("Life Recovery Rate +% While Affected By Vitality")]
        LifeRecoveryRatePosPctWhileAffectedByVitality = 7261,
        [Description("Life Gain Per Target Hit While Affected By Vitality")]
        LifeGainPerTargetHitWhileAffectedByVitality = 7262,
        [Description("Virtual Skill Mana Cost +")]
        VirtualSkillManaCostPos = 7263,
        [Description("Skill Mana Cost + While Affected By Clarity")]
        SkillManaCostPosWhileAffectedByClarity = 7264,
        [Description("Damage Removed From Mana Before Life % While Affected By Clarity")]
        DamageRemovedFromManaBeforeLifePctWhileAffectedByClarity = 7265,
        [Description("Recover 10% Mana On Skill Use % Chance While Affected By Clarity")]
        Recover10PctManaOnSkillUsePctChanceWhileAffectedByClarity = 7266,
        [Description("Maximum Mana % To Add To Energy Shield While Affected By Clarity")]
        MaximumManaPctToAddToEnergyShieldWhileAffectedByClarity = 7267,
        [Description("Chance To Dodge Spells % While Affected By Haste")]
        ChanceToDodgeSpellsPctWhileAffectedByHaste = 7268,
        [Description("Gain Onslaught On Kill Ms While Affected By Haste")]
        GainOnslaughtOnKillMsWhileAffectedByHaste = 7269,
        [Description("Gain Phasing While Affected By Haste")]
        GainPhasingWhileAffectedByHaste = 7270,
        [Description("Physical Damage Taken % As Fire While Affected By Purity Of Fire")]
        PhysicalDamageTakenPctAsFireWhileAffectedByPurityOfFire = 7271,
        [Description("Physical Damage Taken % As Cold While Affected By Purity Of Ice")]
        PhysicalDamageTakenPctAsColdWhileAffectedByPurityOfIce = 7272,
        [Description("Physical Damage Taken % As Lightning While Affected By Purity Of Lightning")]
        PhysicalDamageTakenPctAsLightningWhileAffectedByPurityOfLightning = 7273,
        [Description("Physical Damage Taken % As Fire While Affected By Purity Of Elements")]
        PhysicalDamageTakenPctAsFireWhileAffectedByPurityOfElements = 7274,
        [Description("Physical Damage Taken % As Cold While Affected By Purity Of Elements")]
        PhysicalDamageTakenPctAsColdWhileAffectedByPurityOfElements = 7275,
        [Description("Physical Damage Taken % As Lightning While Affected By Purity Of Elements")]
        PhysicalDamageTakenPctAsLightningWhileAffectedByPurityOfElements = 7276,
        [Description("Immune To Ignite While Affected By Purity Of Fire")]
        ImmuneToIgniteWhileAffectedByPurityOfFire = 7277,
        [Description("Immune To Freeze While Affected By Purity Of Ice")]
        ImmuneToFreezeWhileAffectedByPurityOfIce = 7278,
        [Description("Immune To Shock While Affected By Purity Of Lightning")]
        ImmuneToShockWhileAffectedByPurityOfLightning = 7279,
        [Description("Virtual Physical Damage Taken % As Fire")]
        VirtualPhysicalDamageTakenPctAsFire = 7280,
        [Description("Virtual Physical Damage Taken % As Cold")]
        VirtualPhysicalDamageTakenPctAsCold = 7281,
        [Description("Virtual Physical Damage Taken % As Lightning")]
        VirtualPhysicalDamageTakenPctAsLightning = 7282,
        [Description("Disable Rarity Epk")]
        DisableRarityEpk = 7283,
        [Description("Cannot Spawn Support Ghosts")]
        CannotSpawnSupportGhosts = 7284,
        [Description("Chance To Gain Frenzy Charge On Block %")]
        ChanceToGainFrenzyChargeOnBlockPct = 7285,
        [Description("Spell Damage +% Per 10 Strength")]
        SpellDamagePosPctPer10Strength = 7286,
        [Description("Spell Damage +% Per 16 Dex")]
        SpellDamagePosPctPer16Dex = 7287,
        [Description("Spell Damage +% Per 16 Strength")]
        SpellDamagePosPctPer16Strength = 7288,
        [Description("Spell Damage +% Per 16 Int")]
        SpellDamagePosPctPer16Int = 7289,
        [Description("Deal No Non Elemental Damage")]
        DealNoNonElementalDamage = 7290,
        [Description("Cast Speed +% If Enemy Killed Recently")]
        CastSpeedPosPctIfEnemyKilledRecently = 7291,
        [Description("Trigger On Skill Use % If You Have A Spirit Charge")]
        TriggerOnSkillUsePctIfYouHaveASpiritCharge = 7292,
        [Description("Map Force Private Seed Debug")]
        MapForcePrivateSeedDebug = 7293,
        [Description("Active Skill Display Aegis Variation")]
        ActiveSkillDisplayAegisVariation = 7294,
        [Description("Volatile Dead Number Of Corpses To Consume")]
        VolatileDeadNumberOfCorpsesToConsume = 7295,
        [Description("Unearth Additional Corpse Level")]
        UnearthAdditionalCorpseLevel = 7296,
        [Description("Unearth Corpse Level")]
        UnearthCorpseLevel = 7297,
        [Description("Corpse Erruption Maximum Number Of Geyers")]
        CorpseErruptionMaximumNumberOfGeyers = 7298,
        [Description("Base Number Of Effigies Allowed")]
        BaseNumberOfEffigiesAllowed = 7299,
        [Description("Visual Attached Elder Tentacles")]
        VisualAttachedElderTentacles = 7300,
        [Description("Map Elder Influence Additional Packs Of Elder Monsters")]
        MapElderInfluenceAdditionalPacksOfElderMonsters = 7301,
        [Description("Bone Lance Damage +%")]
        BoneLanceDamagePosPct = 7302,
        [Description("Corpse Eruption Damage +%")]
        CorpseEruptionDamagePosPct = 7303,
        [Description("Volatile Dead Damage +%")]
        VolatileDeadDamagePosPct = 7304,
        [Description("Corpse Warp Damage +%")]
        CorpseWarpDamagePosPct = 7305,
        [Description("Bone Lance Cast Speed +%")]
        BoneLanceCastSpeedPosPct = 7306,
        [Description("Corpse Eruption Cast Speed +%")]
        CorpseEruptionCastSpeedPosPct = 7307,
        [Description("Volatile Dead Cast Speed +%")]
        VolatileDeadCastSpeedPosPct = 7308,
        [Description("Corpse Warp Cast Speed +%")]
        CorpseWarpCastSpeedPosPct = 7309,
        [Description("Display Attack Block Chance")]
        DisplayAttackBlockChance = 7310,
        [Description("Display Spell Block Chance")]
        DisplaySpellBlockChance = 7311,
        [Description("Minimum Added Chaos Damage Taken")]
        MinimumAddedChaosDamageTaken = 7312,
        [Description("Maximum Added Chaos Damage Taken")]
        MaximumAddedChaosDamageTaken = 7313,
        [Description("Chance To Be Maimed When Hit %")]
        ChanceToBeMaimedWhenHitPct = 7314,
        [Description("Energy Shield Gained On Spell Hit")]
        EnergyShieldGainedOnSpellHit = 7315,
        [Description("Monster Spirit Charges Are Infinite")]
        MonsterSpiritChargesAreInfinite = 7316,
        [Description("Gain Spirit Charge On Kill % Chance")]
        GainSpiritChargeOnKillPctChance = 7317,
        [Description("Gain % Life When Spirit Charge Expires Or Consumed")]
        GainPctLifeWhenSpiritChargeExpiresOrConsumed = 7318,
        [Description("Local Display Trigger Level X Spirit Burst On Skill Use If Have Spirit Charge")]
        LocalDisplayTriggerLevelXSpiritBurstOnSkillUseIfHaveSpiritCharge = 7319,
        [Description("Maximum Spirit Charges Per Abyss Jewel Equipped")]
        MaximumSpiritChargesPerAbyssJewelEquipped = 7320,
        [Description("Local Display Socketed Gems Supported By Level X Elemental Penetration")]
        LocalDisplaySocketedGemsSupportedByLevelXElementalPenetration = 7321,
        [Description("Skill Used By Mirage Archer")]
        SkillUsedByMirageArcher = 7322,
        [Description("Support Mirage Archer Attack Speed +% Final")]
        SupportMirageArcherAttackSpeedPosPctFinal = 7323,
        [Description("Virtual Maximum Spirit Charges")]
        VirtualMaximumSpiritCharges = 7324,
        [Description("Gain Debilitating Presence Ms On Kill Vs Rare Or Unique Enemy")]
        GainDebilitatingPresenceMsOnKillVsRareOrUniqueEnemy = 7325,
        [Description("Cast Speed +% From Grasping Tentacles")]
        CastSpeedPosPctFromGraspingTentacles = 7326,
        [Description("Charge Elder Art Variation")]
        ChargeElderArtVariation = 7327,
        [Description("Virtual Projectile Additional Height Offset")]
        VirtualProjectileAdditionalHeightOffset = 7328,
        [Description("Local Display Trigger Level 20 Shade Form On Skill Use %")]
        LocalDisplayTriggerLevel20ShadeFormOnSkillUsePct = 7329,
        [Description("Mirage Archer Projectile Additional Height Offset")]
        MirageArcherProjectileAdditionalHeightOffset = 7330,
        [Description("Minimum Added Physical Damage Per Endurance Charge")]
        MinimumAddedPhysicalDamagePerEnduranceCharge = 7331,
        [Description("Maximum Added Physical Damage Per Endurance Charge")]
        MaximumAddedPhysicalDamagePerEnduranceCharge = 7332,
        [Description("Chaos Damage Resistance % Per Endurance Charge")]
        ChaosDamageResistancePctPerEnduranceCharge = 7333,
        [Description("Elemental Damage Taken From Hits +% Per Endurance Charge")]
        ElementalDamageTakenFromHitsPosPctPerEnduranceCharge = 7334,
        [Description("Physical Damage Reduction Rating Per Endurance Charge")]
        PhysicalDamageReductionRatingPerEnduranceCharge = 7335,
        [Description("Fire Damage Taken Per Minute Per Endurance Charge If You Have Been Hit Recently")]
        FireDamageTakenPerMinutePerEnduranceChargeIfYouHaveBeenHitRecently = 7336,
        [Description("Minimum Added Lightning Damage To Spells Per Power Charge")]
        MinimumAddedLightningDamageToSpellsPerPowerCharge = 7337,
        [Description("Maximum Added Lightning Damage To Spells Per Power Charge")]
        MaximumAddedLightningDamageToSpellsPerPowerCharge = 7338,
        [Description("Additional Spell Block % Per Power Charge")]
        AdditionalSpellBlockPctPerPowerCharge = 7339,
        [Description("Lightning Damage Taken Per Minute Per Power Charge If Have Crit Recently")]
        LightningDamageTakenPerMinutePerPowerChargeIfHaveCritRecently = 7340,
        [Description("Avoid Elemental Damage % Per Frenzy Charge")]
        AvoidElementalDamagePctPerFrenzyCharge = 7341,
        [Description("Life Leech From Attack Damage Permyriad Per Frenzy Charge")]
        LifeLeechFromAttackDamagePermyriadPerFrenzyCharge = 7342,
        [Description("Cold Damage Taken Per Minute Per Frenzy Charge While Moving")]
        ColdDamageTakenPerMinutePerFrenzyChargeWhileMoving = 7343,
        [Description("Raise Spectre Mana Cost +%")]
        RaiseSpectreManaCostPosPct = 7344,
        [Description("Map Packs Have Tentacle Minions")]
        MapPacksHaveTentacleMinions = 7345,
        [Description("Map Elder Influence Spawn Daemon")]
        MapElderInfluenceSpawnDaemon = 7346,
        [Description("Monster Has Oni Goroshi")]
        MonsterHasOniGoroshi = 7347,
        [Description("Skill User Maximum Life")]
        SkillUserMaximumLife = 7348,
        [Description("Local Display Grant Level X Petrification Statue")]
        LocalDisplayGrantLevelXPetrificationStatue = 7349,
        [Description("Petrification Statue Gaze Action Speed -% Per Stack")]
        PetrificationStatueGazeActionSpeedNegPctPerStack = 7350,
        [Description("Chest Display Guarded By Dario")]
        ChestDisplayGuardedByDario = 7351,
        [Description("Base Physical Damage Over Time Taken +%")]
        BasePhysicalDamageOverTimeTakenPosPct = 7352,
        [Description("Ground Spores Art Variation")]
        GroundSporesArtVariation = 7353,
        [Description("Move Daemon Use Random Direction")]
        MoveDaemonUseRandomDirection = 7354,
        [Description("Disable Skill If Weapon Not Bow")]
        DisableSkillIfWeaponNotBow = 7355,
        [Description("Trigger On Skill Use From Chest %")]
        TriggerOnSkillUseFromChestPct = 7356,
        [Description("Thrown Weapon On Return Trigger Skills With Id")]
        ThrownWeaponOnReturnTriggerSkillsWithId = 7357,
        [Description("Thrown Weapon On Return Trigger Id")]
        ThrownWeaponOnReturnTriggerId = 7358,
        [Description("Thrown Weapon On Return Trigger %")]
        ThrownWeaponOnReturnTriggerPct = 7359,
        [Description("Skill Cannot Be Interrupted")]
        SkillCannotBeInterrupted = 7360,
        [Description("Skill Cannot Be Stunned")]
        SkillCannotBeStunned = 7361,
        [Description("Skill Cannot Be Knocked Back")]
        SkillCannotBeKnockedBack = 7362,
        [Description("Is Immobilised By Elder")]
        IsImmobilisedByElder = 7363,
        [Description("Recover % Maximum Life On Mana Flask Use")]
        RecoverPctMaximumLifeOnManaFlaskUse = 7364,
        [Description("Non Instant Mana Recovery From Flasks Also Recovers Life")]
        NonInstantManaRecoveryFromFlasksAlsoRecoversLife = 7365,
        [Description("Spell Damage +% Per 200 Mana Spent Recently")]
        SpellDamagePosPctPer200ManaSpentRecently = 7366,
        [Description("Mana Cost +% Per 200 Mana Spent Recently")]
        ManaCostPosPctPer200ManaSpentRecently = 7367,
        [Description("Virtual Track Mana Spent Recently")]
        VirtualTrackManaSpentRecently = 7368,
        [Description("Total Mana Spent Recently")]
        TotalManaSpentRecently = 7369,
        [Description("Left Ring Is Shaper Item")]
        LeftRingIsShaperItem = 7370,
        [Description("Left Ring Is Elder Item")]
        LeftRingIsElderItem = 7371,
        [Description("Right Ring Is Shaper Item")]
        RightRingIsShaperItem = 7372,
        [Description("Right Ring Is Elder Item")]
        RightRingIsElderItem = 7373,
        [Description("Cannot Be Stunned By Attacks If Other Ring Is Elder Item")]
        CannotBeStunnedByAttacksIfOtherRingIsElderItem = 7374,
        [Description("Cannot Be Stunned By Attacks If Left Ring Is Elder Item")]
        CannotBeStunnedByAttacksIfLeftRingIsElderItem = 7375,
        [Description("Cannot Be Stunned By Attacks If Right Ring Is Elder Item")]
        CannotBeStunnedByAttacksIfRightRingIsElderItem = 7376,
        [Description("Attack Damage +% If Other Ring Is Shaper Item")]
        AttackDamagePosPctIfOtherRingIsShaperItem = 7377,
        [Description("Attack Damage +% If Left Ring Is Shaper Item")]
        AttackDamagePosPctIfLeftRingIsShaperItem = 7378,
        [Description("Attack Damage +% If Right Ring Is Shaper Item")]
        AttackDamagePosPctIfRightRingIsShaperItem = 7379,
        [Description("Spell Damage +% If Other Ring Is Elder Item")]
        SpellDamagePosPctIfOtherRingIsElderItem = 7380,
        [Description("Spell Damage +% If Left Ring Is Elder Item")]
        SpellDamagePosPctIfLeftRingIsElderItem = 7381,
        [Description("Spell Damage +% If Right Ring Is Elder Item")]
        SpellDamagePosPctIfRightRingIsElderItem = 7382,
        [Description("Cannot Be Stunned By Spells If Other Ring Is Shaper Item")]
        CannotBeStunnedBySpellsIfOtherRingIsShaperItem = 7383,
        [Description("Cannot Be Stunned By Spells If Left Ring Is Shaper Item")]
        CannotBeStunnedBySpellsIfLeftRingIsShaperItem = 7384,
        [Description("Cannot Be Stunned By Spells If Right Ring Is Shaper Item")]
        CannotBeStunnedBySpellsIfRightRingIsShaperItem = 7385,
        [Description("Current Siphoning Charges")]
        CurrentSiphoningCharges = 7386,
        [Description("Virtual Maximum Siphoning Charges")]
        VirtualMaximumSiphoningCharges = 7387,
        [Description("Gain Siphoning Charge On Skill Use % Chance")]
        GainSiphoningChargeOnSkillUsePctChance = 7388,
        [Description("Maximum Siphoning Charges Per Elder Or Shaper Item Equipped")]
        MaximumSiphoningChargesPerElderOrShaperItemEquipped = 7389,
        [Description("Attack And Spell Minimum Added Physical Damage Per Siphoning Charge")]
        AttackAndSpellMinimumAddedPhysicalDamagePerSiphoningCharge = 7390,
        [Description("Attack And Spell Maximum Added Physical Damage Per Siphoning Charge")]
        AttackAndSpellMaximumAddedPhysicalDamagePerSiphoningCharge = 7391,
        [Description("Life Leech From Any Damage Permyriad Per Siphoning Charge")]
        LifeLeechFromAnyDamagePermyriadPerSiphoningCharge = 7392,
        [Description("Non Chaos Damage % To Add As Chaos Damage Per Siphoning Charge")]
        NonChaosDamagePctToAddAsChaosDamagePerSiphoningCharge = 7393,
        [Description("Additional Physical Damage Reduction Against Hits % Per Siphoning Charge")]
        AdditionalPhysicalDamageReductionAgainstHitsPctPerSiphoningCharge = 7394,
        [Description("Additional Physical Damage Reduction % Against Hits")]
        AdditionalPhysicalDamageReductionPctAgainstHits = 7395,
        [Description("Armour Differs Against Hits")]
        ArmourDiffersAgainstHits = 7396,
        [Description("Display Estimated Physical Damage Reduction Against Hits %")]
        DisplayEstimatedPhysicalDamageReductionAgainstHitsPct = 7397,
        [Description("Physical Damage Taken Per Minute Per Siphoning Charge If Have Used A Skill Recently")]
        PhysicalDamageTakenPerMinutePerSiphoningChargeIfHaveUsedASkillRecently = 7398,
        [Description("Track Have Used A Skill Recently")]
        TrackHaveUsedASkillRecently = 7399,
        [Description("Have Used A Skill Recently")]
        HaveUsedASkillRecently = 7400,
        [Description("Number Of Equipped Shaper Items")]
        NumberOfEquippedShaperItems = 7401,
        [Description("Virtual Physical Damage Taken Per Minute Per Siphoning Charge")]
        VirtualPhysicalDamageTakenPerMinutePerSiphoningCharge = 7402,
        [Description("Map Force Terrain Feature")]
        MapForceTerrainFeature = 7403,
        [Description("Local Display Trigger Level X Void Shot On Arrow Fire While You Have Void Arrow")]
        LocalDisplayTriggerLevelXVoidShotOnArrowFireWhileYouHaveVoidArrow = 7404,
        [Description("Trigger On Skill Use % If You Have A Void Arrow")]
        TriggerOnSkillUsePctIfYouHaveAVoidArrow = 7405,
        [Description("Current Void Arrows")]
        CurrentVoidArrows = 7406,
        [Description("Maximum Void Arrows")]
        MaximumVoidArrows = 7407,
        [Description("Local Display Grant Void Arrow Every X Ms")]
        LocalDisplayGrantVoidArrowEveryXMs = 7408,
        [Description("Local Display Trigger Tentacle Smash On Kill % Chance")]
        LocalDisplayTriggerTentacleSmashOnKillPctChance = 7409,
        [Description("Local Display Trigger Temporal Anomaly When Hit % Chance")]
        LocalDisplayTriggerTemporalAnomalyWhenHitPctChance = 7410,
        [Description("Local Display Trigger Void Sphere On Kill % Chance")]
        LocalDisplayTriggerVoidSphereOnKillPctChance = 7411,
        [Description("Despair Duration +%")]
        DespairDurationPosPct = 7412,
        [Description("Despair Curse Effect +%")]
        DespairCurseEffectPosPct = 7413,
        [Description("Cast When Hit % Target Self")]
        CastWhenHitPctTargetSelf = 7414,
        [Description("Inca Rock Spawn Chance %")]
        IncaRockSpawnChancePct = 7415,
        [Description("Inca Rock Spawn Limit")]
        IncaRockSpawnLimit = 7416,
        [Description("Volatile Dead Consume Additional Corpse")]
        VolatileDeadConsumeAdditionalCorpse = 7417,
        [Description("Virtual Chance To Evade Attacks %")]
        VirtualChanceToEvadeAttacksPct = 7418,
        [Description("Projectile Skill Dot Ground Caustic Area Damage Per Minute")]
        ProjectileSkillDotGroundCausticAreaDamagePerMinute = 7419,
        [Description("Cannot Be Stunned By Spells")]
        CannotBeStunnedBySpells = 7420,
        [Description("Cannot Be Stunned By Attacks")]
        CannotBeStunnedByAttacks = 7421,
        [Description("Reflected Physical Damage Taken +% While Affected By Determination")]
        ReflectedPhysicalDamageTakenPosPctWhileAffectedByDetermination = 7422,
        [Description("Virtual Physical Reflect Damage Taken +%")]
        VirtualPhysicalReflectDamageTakenPosPct = 7423,
        [Description("Armour + While Affected By Determination")]
        ArmourPosWhileAffectedByDetermination = 7424,
        [Description("Virtual Blind Enemies When Hit % Chance")]
        VirtualBlindEnemiesWhenHitPctChance = 7425,
        [Description("Blind Enemies When Hit While Affected By Grace % Chance")]
        BlindEnemiesWhenHitWhileAffectedByGracePctChance = 7426,
        [Description("Energy Shield Recovery Rate While Affected By Discipline +%")]
        EnergyShieldRecoveryRateWhileAffectedByDisciplinePosPct = 7427,
        [Description("Fire Damage +% While Affected By Anger")]
        FireDamagePosPctWhileAffectedByAnger = 7428,
        [Description("Critical Strike Multiplier + While Affected By Anger")]
        CriticalStrikeMultiplierPosWhileAffectedByAnger = 7429,
        [Description("Lightning Damage +% While Affected By Wrath")]
        LightningDamagePosPctWhileAffectedByWrath = 7430,
        [Description("Critical Strike Chance +% While Affected By Wrath")]
        CriticalStrikeChancePosPctWhileAffectedByWrath = 7431,
        [Description("Cold Damage +% While Affected By Hatred")]
        ColdDamagePosPctWhileAffectedByHatred = 7432,
        [Description("Flask Life Recovery +% While Affected By Vitality")]
        FlaskLifeRecoveryPosPctWhileAffectedByVitality = 7433,
        [Description("Mana Recovery Rate +% While Affected By Clarity")]
        ManaRecoveryRatePosPctWhileAffectedByClarity = 7434,
        [Description("Virtual Damage Taken Goes To Mana Over 4 Seconds %")]
        VirtualDamageTakenGoesToManaOver4SecondsPct = 7435,
        [Description("Damage Taken Goes To Mana Over 4 Seconds % While Affected By Clarity")]
        DamageTakenGoesToManaOver4SecondsPctWhileAffectedByClarity = 7436,
        [Description("Virtual Debuff Time Passed +%")]
        VirtualDebuffTimePassedPosPct = 7437,
        [Description("Debuff Time Passed +% While Affected By Haste")]
        DebuffTimePassedPosPctWhileAffectedByHaste = 7438,
        [Description("Movement Skills Cooldown Speed +% While Affected By Haste")]
        MovementSkillsCooldownSpeedPosPctWhileAffectedByHaste = 7439,
        [Description("Fire Reflect Damage Taken +%")]
        FireReflectDamageTakenPosPct = 7440,
        [Description("Lightning Reflect Damage Taken +%")]
        LightningReflectDamageTakenPosPct = 7441,
        [Description("Cold Reflect Damage Taken +%")]
        ColdReflectDamageTakenPosPct = 7442,
        [Description("Fire Reflect Damage Taken +% While Affected By Purity Of Fire")]
        FireReflectDamageTakenPosPctWhileAffectedByPurityOfFire = 7443,
        [Description("Lightning Reflect Damage Taken +% While Affected By Purity Of Lightning")]
        LightningReflectDamageTakenPosPctWhileAffectedByPurityOfLightning = 7444,
        [Description("Cold Reflect Damage Taken +% While Affected By Purity Of Ice")]
        ColdReflectDamageTakenPosPctWhileAffectedByPurityOfIce = 7445,
        [Description("Elemental Reflect Damage Taken +% While Affected By Purity Of Elements")]
        ElementalReflectDamageTakenPosPctWhileAffectedByPurityOfElements = 7446,
        [Description("Chaos Damage Resistance % While Affected By Purity Of Elements")]
        ChaosDamageResistancePctWhileAffectedByPurityOfElements = 7447,
        [Description("Intimidating Cry Attack Speed +% Per 100 Enemies")]
        IntimidatingCryAttackSpeedPosPctPer100Enemies = 7448,
        [Description("Local Display Grants Skill Intimidating Cry Level")]
        LocalDisplayGrantsSkillIntimidatingCryLevel = 7449,
        [Description("Map Spawn Bestiary Encounters")]
        MapSpawnBestiaryEncounters = 7450,
        [Description("Map Force Bestiary Encounter")]
        MapForceBestiaryEncounter = 7451,
        [Description("Local Display Grants Skill Cat Aspect Level")]
        LocalDisplayGrantsSkillCatAspectLevel = 7452,
        [Description("Local Display Grants Skill Bird Aspect Level")]
        LocalDisplayGrantsSkillBirdAspectLevel = 7453,
        [Description("Avoid Damage %")]
        AvoidDamagePct = 7454,
        [Description("Minion Chance To Deal Double Damage %")]
        MinionChanceToDealDoubleDamagePct = 7455,
        [Description("Local Display Grants Skill Spider Aspect Level")]
        LocalDisplayGrantsSkillSpiderAspectLevel = 7456,
        [Description("Damage +% Per 10 Dex")]
        DamagePosPctPer10Dex = 7457,
        [Description("Life Regeneration Per Minute While Ignited")]
        LifeRegenerationPerMinuteWhileIgnited = 7458,
        [Description("Chance To Deal Double Damage % Per 500 Strength")]
        ChanceToDealDoubleDamagePctPer500Strength = 7459,
        [Description("Virtual Chance To Deal Double Damage %")]
        VirtualChanceToDealDoubleDamagePct = 7460,
        [Description("Track Have Killed Cursed Enemy Recently")]
        TrackHaveKilledCursedEnemyRecently = 7461,
        [Description("Have Killed Cursed Enemy Recently")]
        HaveKilledCursedEnemyRecently = 7462,
        [Description("Elemental Damage +% If Cursed Enemy Killed Recently")]
        ElementalDamagePosPctIfCursedEnemyKilledRecently = 7463,
        [Description("Local Display Grants Skill Crab Aspect Level")]
        LocalDisplayGrantsSkillCrabAspectLevel = 7464,
        [Description("Current Crab Aspect Stacks")]
        CurrentCrabAspectStacks = 7465,
        [Description("Max Crab Aspect Stacks")]
        MaxCrabAspectStacks = 7466,
        [Description("Physical Damage Reduction % Per Crab Aspect Stack")]
        PhysicalDamageReductionPctPerCrabAspectStack = 7467,
        [Description("Raging Spirits Refresh Duration When They Kill Ignited Enemy")]
        RagingSpiritsRefreshDurationWhenTheyKillIgnitedEnemy = 7468,
        [Description("Add Frenzy Charge Every 50 Rampage Stacks")]
        AddFrenzyChargeEvery50RampageStacks = 7469,
        [Description("Area Of Effect +% Per 25 Rampage Stacks")]
        AreaOfEffectPosPctPer25RampageStacks = 7470,
        [Description("Traps Do Not Explode On Timeout")]
        TrapsDoNotExplodeOnTimeout = 7471,
        [Description("Cannot Be Ignited While Flame Golem Summoned")]
        CannotBeIgnitedWhileFlameGolemSummoned = 7472,
        [Description("Cannot Be Shocked While Lightning Golem Summoned")]
        CannotBeShockedWhileLightningGolemSummoned = 7473,
        [Description("Cannot Be Chilled Or Frozen While Ice Golem Summoned")]
        CannotBeChilledOrFrozenWhileIceGolemSummoned = 7474,
        [Description("Cannot Be Chilled")]
        CannotBeChilled = 7475,
        [Description("Attach Vines To Defender On Hit % Chance")]
        AttachVinesToDefenderOnHitPctChance = 7476,
        [Description("Unaffected By Curses")]
        UnaffectedByCurses = 7477,
        [Description("Chill Minimum Slow %")]
        ChillMinimumSlowPct = 7478,
        [Description("Shock Minimum Damage Taken Increase %")]
        ShockMinimumDamageTakenIncreasePct = 7479,
        [Description("Has Avians Flight")]
        HasAviansFlight = 7480,
        [Description("Has Avians Might")]
        HasAviansMight = 7481,
        [Description("Life Regeneration Per Minute While You Have Avians Flight")]
        LifeRegenerationPerMinuteWhileYouHaveAviansFlight = 7482,
        [Description("Mana Regeneration Rate Per Minute While You Have Avians Flight")]
        ManaRegenerationRatePerMinuteWhileYouHaveAviansFlight = 7483,
        [Description("Avians Flight Duration Ms +")]
        AviansFlightDurationMsPos = 7484,
        [Description("Avians Might Duration Ms +")]
        AviansMightDurationMsPos = 7485,
        [Description("Minimum Added Cold Damage While You Have Avians Might")]
        MinimumAddedColdDamageWhileYouHaveAviansMight = 7486,
        [Description("Maximum Added Cold Damage While You Have Avians Might")]
        MaximumAddedColdDamageWhileYouHaveAviansMight = 7487,
        [Description("Minimum Added Lightning Damage While You Have Avians Might")]
        MinimumAddedLightningDamageWhileYouHaveAviansMight = 7488,
        [Description("Maximum Added Lightning Damage While You Have Avians Might")]
        MaximumAddedLightningDamageWhileYouHaveAviansMight = 7489,
        [Description("Aspect Of The Avian Grants Avians Might And Avians Flight To Nearby Allies")]
        AspectOfTheAvianGrantsAviansMightAndAviansFlightToNearbyAllies = 7490,
        [Description("Aspect Of The Avian Buff Effect +%")]
        AspectOfTheAvianBuffEffectPosPct = 7491,
        [Description("Retaliation Godmode Ghost Duration Ms")]
        RetaliationGodmodeGhostDurationMs = 7492,
        [Description("Has Cats Stealth")]
        HasCatsStealth = 7493,
        [Description("Local Display Trigger Level 20 Tornado When You Gain Avians Flight Or Avians Might %")]
        LocalDisplayTriggerLevel20TornadoWhenYouGainAviansFlightOrAviansMightPct = 7494,
        [Description("Cast On Gain Avians Flight Or Avians Might %")]
        CastOnGainAviansFlightOrAviansMightPct = 7495,
        [Description("Gain Phasing While You Have Cats Stealth")]
        GainPhasingWhileYouHaveCatsStealth = 7496,
        [Description("Cats Stealth Duration Ms +")]
        CatsStealthDurationMsPos = 7497,
        [Description("Cat Aspect Reserves No Mana")]
        CatAspectReservesNoMana = 7498,
        [Description("Gain Maximum Frenzy And Power Charges When You Gain Cats Stealth")]
        GainMaximumFrenzyAndPowerChargesWhenYouGainCatsStealth = 7499,
        [Description("Override Off Hand Base Critical Strike Chance To 5%")]
        OverrideOffHandBaseCriticalStrikeChanceTo5Pct = 7500,
        [Description("Cannot Be Stunned If You Have 10 Or More Crab Charges")]
        CannotBeStunnedIfYouHave10OrMoreCrabCharges = 7501,
        [Description("Number Of Crab Charges Lost Recently")]
        NumberOfCrabChargesLostRecently = 7502,
        [Description("Cannot Lose Crab Charges If You Have Lost Crab Charges Recently")]
        CannotLoseCrabChargesIfYouHaveLostCrabChargesRecently = 7503,
        [Description("Do Not Lose Crab Charges When Hit")]
        DoNotLoseCrabChargesWhenHit = 7504,
        [Description("Damage +% Per Crab Charge")]
        DamagePosPctPerCrabCharge = 7505,
        [Description("Chance To Gain Max Crab Stacks When You Would Gain A Crab Stack %")]
        ChanceToGainMaxCrabStacksWhenYouWouldGainACrabStackPct = 7506,
        [Description("Additional Block % While You Have At Least 5 Crab Charges")]
        AdditionalBlockPctWhileYouHaveAtLeast5CrabCharges = 7507,
        [Description("Additional Block % While You Have At Least 10 Crab Charges")]
        AdditionalBlockPctWhileYouHaveAtLeast10CrabCharges = 7508,
        [Description("Number Of Crab Charges Lost When Hit")]
        NumberOfCrabChargesLostWhenHit = 7509,
        [Description("Life And Mana Leech From Attack Damage Permyriad If Killed Recently")]
        LifeAndManaLeechFromAttackDamagePermyriadIfKilledRecently = 7510,
        [Description("Monster Mortar Number Of Forks")]
        MonsterMortarNumberOfForks = 7511,
        [Description("Local Display Trigger Level X Intimidating Cry When You Lose Cats Stealth")]
        LocalDisplayTriggerLevelXIntimidatingCryWhenYouLoseCatsStealth = 7512,
        [Description("Cast On Lose Cats Stealth")]
        CastOnLoseCatsStealth = 7513,
        [Description("Movement Speed +% While You Have Cats Stealth")]
        MovementSpeedPosPctWhileYouHaveCatsStealth = 7514,
        [Description("Minimum Added Fire Damage To Attacks Per 10 Strength")]
        MinimumAddedFireDamageToAttacksPer10Strength = 7515,
        [Description("Maximum Added Fire Damage To Attacks Per 10 Strength")]
        MaximumAddedFireDamageToAttacksPer10Strength = 7516,
        [Description("Minimum Added Cold Damage To Attacks Per 10 Dexterity")]
        MinimumAddedColdDamageToAttacksPer10Dexterity = 7517,
        [Description("Maximum Added Cold Damage To Attacks Per 10 Dexterity")]
        MaximumAddedColdDamageToAttacksPer10Dexterity = 7518,
        [Description("Minimum Added Lightning Damage To Attacks Per 10 Intelligence")]
        MinimumAddedLightningDamageToAttacksPer10Intelligence = 7519,
        [Description("Maximum Added Lightning Damage To Attacks Per 10 Intelligence")]
        MaximumAddedLightningDamageToAttacksPer10Intelligence = 7520,
        [Description("Gain Rage On Kill")]
        GainRageOnKill = 7521,
        [Description("Maximum Rage")]
        MaximumRage = 7522,
        [Description("Current Rage")]
        CurrentRage = 7523,
        [Description("Attack Damage +% From Rage")]
        AttackDamagePosPctFromRage = 7524,
        [Description("Attack Speed +% From Rage")]
        AttackSpeedPosPctFromRage = 7525,
        [Description("Movement Speed +% From Rage")]
        MovementSpeedPosPctFromRage = 7526,
        [Description("Life Loss % Per Minute From Rage")]
        LifeLossPctPerMinuteFromRage = 7527,
        [Description("Gain Rage When You Use A Warcry")]
        GainRageWhenYouUseAWarcry = 7528,
        [Description("Rage Effects Doubled")]
        RageEffectsDoubled = 7529,
        [Description("Virtual Life Degeneration Per Minute")]
        VirtualLifeDegenerationPerMinute = 7530,
        [Description("Gain Rage On Hitting Rare Unique Enemy %")]
        GainRageOnHittingRareUniqueEnemyPct = 7531,
        [Description("Spectral Shield Throw Secondary Projectiles Pierce")]
        SpectralShieldThrowSecondaryProjectilesPierce = 7532,
        [Description("Herald Skills Mana Reservation +%")]
        HeraldSkillsManaReservationPosPct = 7533,
        [Description("Herald Effect On Self +%")]
        HeraldEffectOnSelfPosPct = 7534,
        [Description("Affected By Herald Of Ash")]
        AffectedByHeraldOfAsh = 7535,
        [Description("Affected By Herald Of Ice")]
        AffectedByHeraldOfIce = 7536,
        [Description("Affected By Herald Of Thunder")]
        AffectedByHeraldOfThunder = 7537,
        [Description("Damage Penetrates % Fire Resistance While Affected By Herald Of Ash")]
        DamagePenetratesPctFireResistanceWhileAffectedByHeraldOfAsh = 7538,
        [Description("Damage Penetrates % Cold Resistance While Affected By Herald Of Ice")]
        DamagePenetratesPctColdResistanceWhileAffectedByHeraldOfIce = 7539,
        [Description("Damage Penetrates % Lightning Resistance While Affected By Herald Of Thunder")]
        DamagePenetratesPctLightningResistanceWhileAffectedByHeraldOfThunder = 7540,
        [Description("Cannot Be Stunned With 25 Rage")]
        CannotBeStunnedWith25Rage = 7541,
        [Description("Monster Rarity Damage +% Final")]
        MonsterRarityDamagePosPctFinal = 7542,
        [Description("Counterattacks Deal Double Damage")]
        CounterattacksDealDoubleDamage = 7543,
        [Description("Owner Stacking Energy Shield Regeneration Rate Per Minute % On Kill For 4 Seconds")]
        OwnerStackingEnergyShieldRegenerationRatePerMinutePctOnKillFor4Seconds = 7544,
        [Description("Chance To Gain Random Standard Charge On Hit %")]
        ChanceToGainRandomStandardChargeOnHitPct = 7545,
        [Description("Blink And Mirror Arrow Cooldown Speed +%")]
        BlinkAndMirrorArrowCooldownSpeedPosPct = 7546,
        [Description("Elementalist Elemental Damage +% For 5 Seconds")]
        ElementalistElementalDamagePosPctFor5Seconds = 7547,
        [Description("Elementalist Area Of Effect +% For 5 Seconds")]
        ElementalistAreaOfEffectPosPctFor5Seconds = 7548,
        [Description("Immune To Elemental Ailments While On Consecrated Ground")]
        ImmuneToElementalAilmentsWhileOnConsecratedGround = 7549,
        [Description("Create Consecrated Ground On Hit % Vs Rare Or Unique Enemy")]
        CreateConsecratedGroundOnHitPctVsRareOrUniqueEnemy = 7550,
        [Description("Cannot Be Stunned While Fortified")]
        CannotBeStunnedWhileFortified = 7551,
        [Description("Armour And Evasion Rating + While Fortified")]
        ArmourAndEvasionRatingPosWhileFortified = 7552,
        [Description("Global Chance To Blind On Hit % Vs Bleeding Enemies")]
        GlobalChanceToBlindOnHitPctVsBleedingEnemies = 7553,
        [Description("Cannot Be Stunned By Blocked Hits")]
        CannotBeStunnedByBlockedHits = 7554,
        [Description("Gratuitous Violence Bleeding Damage +% Final")]
        GratuitousViolenceBleedingDamagePosPctFinal = 7555,
        [Description("Chance To Gain Onslaught On Hit % Vs Rare Or Unique Enemy")]
        ChanceToGainOnslaughtOnHitPctVsRareOrUniqueEnemy = 7556,
        [Description("Unaffected By Temporal Chains")]
        UnaffectedByTemporalChains = 7557,
        [Description("Apply Covered In Ash To Attacker On Hit % Vs Rare Or Unique Enemy")]
        ApplyCoveredInAshToAttackerOnHitPctVsRareOrUniqueEnemy = 7558,
        [Description("Gain Endurance Charge Per Second If Have Been Hit Recently")]
        GainEnduranceChargePerSecondIfHaveBeenHitRecently = 7559,
        [Description("Stun Duration +% Per Endurance Charge")]
        StunDurationPosPctPerEnduranceCharge = 7560,
        [Description("Chance To Gain Endurance Charge On Stun %")]
        ChanceToGainEnduranceChargeOnStunPct = 7561,
        [Description("Totem Maximum Energy Shield")]
        TotemMaximumEnergyShield = 7562,
        [Description("You And Totem Life Regeneration Rate Per Minute % Per Active Totem")]
        YouAndTotemLifeRegenerationRatePerMinutePctPerActiveTotem = 7563,
        [Description("Mana Regeneration Rate Per Minute % Per Active Totem")]
        ManaRegenerationRatePerMinutePctPerActiveTotem = 7564,
        [Description("Fire Damage +% Per Endurance Charge")]
        FireDamagePosPctPerEnduranceCharge = 7565,
        [Description("Track Have Taken Fire Damage From A Hit Recently")]
        TrackHaveTakenFireDamageFromAHitRecently = 7566,
        [Description("Have Taken Fire Damage From A Hit Recently")]
        HaveTakenFireDamageFromAHitRecently = 7567,
        [Description("Life Regeneration Rate Per Minute % If Have Taken Fire Damage From A Hit Recently")]
        LifeRegenerationRatePerMinutePctIfHaveTakenFireDamageFromAHitRecently = 7568,
        [Description("Local Display Every 10 Seconds Physical Damage % To Add As Fire For 3 Seconds")]
        LocalDisplayEvery10SecondsPhysicalDamagePctToAddAsFireFor3Seconds = 7569,
        [Description("Critical Strike Damage Cannot Be Reflected")]
        CriticalStrikeDamageCannotBeReflected = 7570,
        [Description("Damage +% If Only One Enemy Nearby")]
        DamagePosPctIfOnlyOneEnemyNearby = 7571,
        [Description("Self Take No Extra Damage From Critical Strikes If Only One Nearby Enemy")]
        SelfTakeNoExtraDamageFromCriticalStrikesIfOnlyOneNearbyEnemy = 7572,
        [Description("Poison Duration +% Per Poison Applied Recently")]
        PoisonDurationPosPctPerPoisonAppliedRecently = 7573,
        [Description("Additional Critical Strike Chance Permyriad Per Poison On Enemy Up To 2%")]
        AdditionalCriticalStrikeChancePermyriadPerPoisonOnEnemyUpTo2Pct = 7574,
        [Description("Physical Damage % To Add As Chaos Vs Poisoned Enemies")]
        PhysicalDamagePctToAddAsChaosVsPoisonedEnemies = 7575,
        [Description("Recover Permyriad Maximum Life Per Poison On Enemy On Kill")]
        RecoverPermyriadMaximumLifePerPoisonOnEnemyOnKill = 7576,
        [Description("Zombie Caustic Cloud On Death Maximum Life Per Minute To Deal As Chaos Damage %")]
        ZombieCausticCloudOnDeathMaximumLifePerMinuteToDealAsChaosDamagePct = 7577,
        [Description("Self Offering Effect +%")]
        SelfOfferingEffectPosPct = 7578,
        [Description("% Chance To Gain 25% Non Chaos Damage To Add As Chaos Damage")]
        PctChanceToGain25PctNonChaosDamageToAddAsChaosDamage = 7579,
        [Description("% Chance To Gain 50% Non Chaos Damage To Add As Chaos Damage")]
        PctChanceToGain50PctNonChaosDamageToAddAsChaosDamage = 7580,
        [Description("% Chance To Gain 100% Non Chaos Damage To Add As Chaos Damage")]
        PctChanceToGain100PctNonChaosDamageToAddAsChaosDamage = 7581,
        [Description("Damage +% Per Active Golem")]
        DamagePosPctPerActiveGolem = 7582,
        [Description("Virtual Total Number Of Active Golems")]
        VirtualTotalNumberOfActiveGolems = 7583,
        [Description("Unaffected By Ignite")]
        UnaffectedByIgnite = 7584,
        [Description("Gain Accuracy Rating Equal To Strength")]
        GainAccuracyRatingEqualToStrength = 7585,
        [Description("Accuracy Rating +% If Have Crit In Past 8 Seconds")]
        AccuracyRatingPosPctIfHaveCritInPast8Seconds = 7586,
        [Description("Damage +% If Have Crit In Past 8 Seconds")]
        DamagePosPctIfHaveCritInPast8Seconds = 7587,
        [Description("Track Have Crit In Past 8 Seconds")]
        TrackHaveCritInPast8Seconds = 7588,
        [Description("Have Crit In Past 8 Seconds")]
        HaveCritInPast8Seconds = 7589,
        [Description("Virtual Accuracy Rating +%")]
        VirtualAccuracyRatingPosPct = 7590,
        [Description("Hierophant Mana Reservation +% Final")]
        HierophantManaReservationPosPctFinal = 7591,
        [Description("Elemental Penetration % If You Have A Power Charge")]
        ElementalPenetrationPctIfYouHaveAPowerCharge = 7592,
        [Description("Elemental Damage Taken +% If You Have An Endurance Charge")]
        ElementalDamageTakenPosPctIfYouHaveAnEnduranceCharge = 7593,
        [Description("Track Number Of Traps Triggered Recently")]
        TrackNumberOfTrapsTriggeredRecently = 7594,
        [Description("Number Of Traps Triggered Recently")]
        NumberOfTrapsTriggeredRecently = 7595,
        [Description("Track Number Of Mines Detonated Recently")]
        TrackNumberOfMinesDetonatedRecently = 7596,
        [Description("Number Of Mines Detonated Recently")]
        NumberOfMinesDetonatedRecently = 7597,
        [Description("Life Regeneration Rate Per Minute % Per Trap Triggered Recently Up To 20%")]
        LifeRegenerationRatePerMinutePctPerTrapTriggeredRecentlyUpTo20Pct = 7598,
        [Description("Life Regeneration Rate Per Minute % Per Mine Detonated Recently Up To 20%")]
        LifeRegenerationRatePerMinutePctPerMineDetonatedRecentlyUpTo20Pct = 7599,
        [Description("You And Allies Additional Block % If Have Attacked Recently")]
        YouAndAlliesAdditionalBlockPctIfHaveAttackedRecently = 7600,
        [Description("You And Allies Additional Spell Block % If Cast Spell Recently")]
        YouAndAlliesAdditionalSpellBlockPctIfCastSpellRecently = 7601,
        [Description("Movement Speed +% While You Have Energy Shield")]
        MovementSpeedPosPctWhileYouHaveEnergyShield = 7602,
        [Description("Chance To Dodge Attacks And Spells % While You Have Energy Shield")]
        ChanceToDodgeAttacksAndSpellsPctWhileYouHaveEnergyShield = 7603,
        [Description("Trickster Damage Over Time +% Final")]
        TricksterDamageOverTimePosPctFinal = 7604,
        [Description("Object Cannot Taunt Enemies")]
        ObjectCannotTauntEnemies = 7605,
        [Description("Cold Beam Retaliation Chilled Ground In Beam Duration Ms")]
        ColdBeamRetaliationChilledGroundInBeamDurationMs = 7606,
        [Description("Cold Beam Retaliation Chilled Ground In Area Duration Ms")]
        ColdBeamRetaliationChilledGroundInAreaDurationMs = 7607,
        [Description("Enemy Extra Damage Rolls When On Full Life")]
        EnemyExtraDamageRollsWhenOnFullLife = 7608,
        [Description("Burning Damage +% Per Enemy Shocked Recently")]
        BurningDamagePosPctPerEnemyShockedRecently = 7609,
        [Description("Global Minimum Added Lightning Damage Vs Ignited Enemies")]
        GlobalMinimumAddedLightningDamageVsIgnitedEnemies = 7610,
        [Description("Global Maximum Added Lightning Damage Vs Ignited Enemies")]
        GlobalMaximumAddedLightningDamageVsIgnitedEnemies = 7611,
        [Description("Lightning Damage Can Ignite")]
        LightningDamageCanIgnite = 7612,
        [Description("Minimum Added Spell Fire Damage While No Life Is Reserved")]
        MinimumAddedSpellFireDamageWhileNoLifeIsReserved = 7613,
        [Description("Maximum Added Spell Fire Damage While No Life Is Reserved")]
        MaximumAddedSpellFireDamageWhileNoLifeIsReserved = 7614,
        [Description("Minimum Added Spell Cold Damage While No Life Is Reserved")]
        MinimumAddedSpellColdDamageWhileNoLifeIsReserved = 7615,
        [Description("Maximum Added Spell Cold Damage While No Life Is Reserved")]
        MaximumAddedSpellColdDamageWhileNoLifeIsReserved = 7616,
        [Description("Minimum Added Spell Lightning Damage While No Life Is Reserved")]
        MinimumAddedSpellLightningDamageWhileNoLifeIsReserved = 7617,
        [Description("Maximum Added Spell Lightning Damage While No Life Is Reserved")]
        MaximumAddedSpellLightningDamageWhileNoLifeIsReserved = 7618,
        [Description("Projectile Attack Damage +% With At Least 200 Dex")]
        ProjectileAttackDamagePosPctWithAtLeast200Dex = 7619,
        [Description("Critical Strike Chance +% With At Least 200 Int")]
        CriticalStrikeChancePosPctWithAtLeast200Int = 7620,
        [Description("Virtual Keystone Crimson Dance")]
        VirtualKeystoneCrimsonDance = 7621,
        [Description("Keystone Crimson Dance")]
        KeystoneCrimsonDance = 7622,
        [Description("Gain Crimson Dance If Have Dealt Critical Strike Recently")]
        GainCrimsonDanceIfHaveDealtCriticalStrikeRecently = 7623,
        [Description("Gain Crimson Dance While You Have Cat Stealth")]
        GainCrimsonDanceWhileYouHaveCatStealth = 7624,
        [Description("Virtual Bleeding Stacks Up To X Times")]
        VirtualBleedingStacksUpToXTimes = 7625,
        [Description("Gain Onslaught While On Low Life")]
        GainOnslaughtWhileOnLowLife = 7626,
        [Description("Hits Ignore Enemy Fire Resistance While You Are Ignited")]
        HitsIgnoreEnemyFireResistanceWhileYouAreIgnited = 7627,
        [Description("Virtual Hits Ignore Enemy Fire Resistance")]
        VirtualHitsIgnoreEnemyFireResistance = 7628,
        [Description("Override Maximum Damage Resistance %")]
        OverrideMaximumDamageResistancePct = 7629,
        [Description("Local Display Trigger Commandment Of Inferno On Crit %")]
        LocalDisplayTriggerCommandmentOfInfernoOnCritPct = 7630,
        [Description("Local Display Trigger Level X Icicle Nova On Kill Vs Frozen Enemy")]
        LocalDisplayTriggerLevelXIcicleNovaOnKillVsFrozenEnemy = 7631,
        [Description("Trigger On Kill Vs Frozen Enemy %")]
        TriggerOnKillVsFrozenEnemyPct = 7632,
        [Description("Attacks Bleed On Hit While You Have Cat Stealth")]
        AttacksBleedOnHitWhileYouHaveCatStealth = 7633,
        [Description("Hit And Ailment Damage +% Vs Bleeding Enemies")]
        HitAndAilmentDamagePosPctVsBleedingEnemies = 7634,
        [Description("Base Ailment Damage +%")]
        BaseAilmentDamagePosPct = 7635,
        [Description("Accuracy Rating Vs Bleeding Enemies")]
        AccuracyRatingVsBleedingEnemies = 7636,
        [Description("Gain % Total Phys Damage Prevented In The Past 10 Sec As Life Regen Per Sec")]
        GainPctTotalPhysDamagePreventedInThePast10SecAsLifeRegenPerSec = 7637,
        [Description("Total Armour Of Animated Guardians Items")]
        TotalArmourOfAnimatedGuardiansItems = 7638,
        [Description("Total Evasion Rating Of Animated Guardians Items")]
        TotalEvasionRatingOfAnimatedGuardiansItems = 7639,
        [Description("Total Maximum Energy Shield Of Animated Guardians Items")]
        TotalMaximumEnergyShieldOfAnimatedGuardiansItems = 7640,
        [Description("Animated Weapon Armour")]
        AnimatedWeaponArmour = 7641,
        [Description("Animated Weapon Evasion Rating")]
        AnimatedWeaponEvasionRating = 7642,
        [Description("Aniamted Weapon Maximum Energy Shield")]
        AniamtedWeaponMaximumEnergyShield = 7643,
        [Description("Defences From Animated Guardians Items Apply To Animated Weapon")]
        DefencesFromAnimatedGuardiansItemsApplyToAnimatedWeapon = 7644,
        [Description("Fire Projectile Retaliation Skill Visual Scale +% When Hit While Charging")]
        FireProjectileRetaliationSkillVisualScalePosPctWhenHitWhileCharging = 7645,
        [Description("Fire Projectile Retaliation Area Of Effect +% When Hit While Charging")]
        FireProjectileRetaliationAreaOfEffectPosPctWhenHitWhileCharging = 7646,
        [Description("Fire Projectile Retaliation Projectile Speed And Damage +% When Hit While Charging")]
        FireProjectileRetaliationProjectileSpeedAndDamagePosPctWhenHitWhileCharging = 7647,
        [Description("Gained Rage Recently")]
        GainedRageRecently = 7648,
        [Description("Local Display Trigger Level 20 Animate Guardian Weapon On Guardian Kill % Chance")]
        LocalDisplayTriggerLevel20AnimateGuardianWeaponOnGuardianKillPctChance = 7649,
        [Description("Chance To Trigger On Animate Guardian Kill %")]
        ChanceToTriggerOnAnimateGuardianKillPct = 7650,
        [Description("Animate Guardian And Weapon Track On Kill")]
        AnimateGuardianAndWeaponTrackOnKill = 7651,
        [Description("Local Display Trigger Level 20 Animate Guardian Weapon On Weapon Kill % Chance")]
        LocalDisplayTriggerLevel20AnimateGuardianWeaponOnWeaponKillPctChance = 7652,
        [Description("Chance To Trigger On Animate Weapon Kill %")]
        ChanceToTriggerOnAnimateWeaponKillPct = 7653,
        [Description("You Cannot Have Non Animated Minions")]
        YouCannotHaveNonAnimatedMinions = 7654,
        [Description("Animate Guardian Damage +% Per Animated Weapon")]
        AnimateGuardianDamagePosPctPerAnimatedWeapon = 7655,
        [Description("Animated Minions Melee Splash")]
        AnimatedMinionsMeleeSplash = 7656,
        [Description("Grant Animated Minion Melee Splash Damage +% Final For Splash")]
        GrantAnimatedMinionMeleeSplashDamagePosPctFinalForSplash = 7657,
        [Description("Animated Minion Melee Splash Damage +% Final For Splash")]
        AnimatedMinionMeleeSplashDamagePosPctFinalForSplash = 7658,
        [Description("Animated Minion Melee Splash Damage +% Final")]
        AnimatedMinionMeleeSplashDamagePosPctFinal = 7659,
        [Description("Number Of Active Animated Armour")]
        NumberOfActiveAnimatedArmour = 7660,
        [Description("Geometry Attack Use Orientation Direction")]
        GeometryAttackUseOrientationDirection = 7661,
        [Description("Virtual Elemental Reflect Damage Taken +%")]
        VirtualElementalReflectDamageTakenPosPct = 7662,
        [Description("Additional Critical Strike Chance Permyriad While Affected By Cat Aspect")]
        AdditionalCriticalStrikeChancePermyriadWhileAffectedByCatAspect = 7663,
        [Description("Virtual % Chance To Blind On Critical Strike")]
        VirtualPctChanceToBlindOnCriticalStrike = 7664,
        [Description("% Chance To Blind On Critical Strike While You Have Cats Stealth")]
        PctChanceToBlindOnCriticalStrikeWhileYouHaveCatsStealth = 7665,
        [Description("Has Cat Aspect")]
        HasCatAspect = 7666,
        [Description("Hit And Ailment Damage +% Vs Blinded Enemies")]
        HitAndAilmentDamagePosPctVsBlindedEnemies = 7667,
        [Description("Has Adrenaline")]
        HasAdrenaline = 7668,
        [Description("Gain Adrenaline For X Seconds On Low Life Unless You Have Adrenaline")]
        GainAdrenalineForXSecondsOnLowLifeUnlessYouHaveAdrenaline = 7669,
        [Description("Remove Ailments And Burning On Gaining Adrenaline")]
        RemoveAilmentsAndBurningOnGainingAdrenaline = 7670,
        [Description("Attack Ailment Damage +% While Wielding Staff")]
        AttackAilmentDamagePosPctWhileWieldingStaff = 7671,
        [Description("Attack Ailment Damage +% While Wielding Wand")]
        AttackAilmentDamagePosPctWhileWieldingWand = 7672,
        [Description("Enemies Taunted By You Cannot Evade Attacks")]
        EnemiesTauntedByYouCannotEvadeAttacks = 7673,
        [Description("Spider Aspect Web Interval Ms")]
        SpiderAspectWebIntervalMs = 7674,
        [Description("Spider Aspect Max Web Count")]
        SpiderAspectMaxWebCount = 7675,
        [Description("Spider Aspect Debuff Duration +%")]
        SpiderAspectDebuffDurationPosPct = 7676,
        [Description("Energy Shield Gain When You Hit Enemy Affected By Spiders Web")]
        EnergyShieldGainWhenYouHitEnemyAffectedBySpidersWeb = 7677,
        [Description("Chill Effect Is Reversed")]
        ChillEffectIsReversed = 7678,
        [Description("Virtual On Low Life")]
        VirtualOnLowLife = 7679,
        [Description("You Count As Low Life While Not On Full Life")]
        YouCountAsLowLifeWhileNotOnFullLife = 7680,
        [Description("Mana Cost +% For Trap And Mine Skills")]
        ManaCostPosPctForTrapAndMineSkills = 7681,
        [Description("Gain Arcane Surge On Spell Hit By You Or Your Totems")]
        GainArcaneSurgeOnSpellHitByYouOrYourTotems = 7682,
        [Description("Spell Damage +% While You Have Arcane Surge")]
        SpellDamagePosPctWhileYouHaveArcaneSurge = 7683,
        [Description("Area Of Effect +% While You Have Arcane Surge")]
        AreaOfEffectPosPctWhileYouHaveArcaneSurge = 7684,
        [Description("Immune To Elemental Ailments While You Have Arcane Surge")]
        ImmuneToElementalAilmentsWhileYouHaveArcaneSurge = 7685,
        [Description("Chance To Gain Onslaught On Kill For 10 Seconds %")]
        ChanceToGainOnslaughtOnKillFor10SecondsPct = 7686,
        [Description("Curse On Hit Level Poachers Mark Bypass Hexproof")]
        CurseOnHitLevelPoachersMarkBypassHexproof = 7687,
        [Description("You Have No Armour Or Energy Shield")]
        YouHaveNoArmourOrEnergyShield = 7688,
        [Description("Chance To Trigger Socketed Spell On Bow Attack %")]
        ChanceToTriggerSocketedSpellOnBowAttackPct = 7689,
        [Description("Culling Strike On Enemies Affected By Poachers Mark")]
        CullingStrikeOnEnemiesAffectedByPoachersMark = 7690,
        [Description("Self Physical Damage On Movement Skill Use")]
        SelfPhysicalDamageOnMovementSkillUse = 7691,
        [Description("Grant Tailwind To Nearby Allies If Used Skill Recently")]
        GrantTailwindToNearbyAlliesIfUsedSkillRecently = 7692,
        [Description("Evasion Rating + While You Have Tailwind")]
        EvasionRatingPosWhileYouHaveTailwind = 7693,
        [Description("Tailwind Effect On Self +%")]
        TailwindEffectOnSelfPosPct = 7694,
        [Description("Enemies You Curse Have Malediction")]
        EnemiesYouCurseHaveMalediction = 7695,
        [Description("Has Arcane Surge")]
        HasArcaneSurge = 7696,
        [Description("Virtual Light Radius +%")]
        VirtualLightRadiusPosPct = 7697,
        [Description("Light Radius Increases Apply To Area Of Effect")]
        LightRadiusIncreasesApplyToAreaOfEffect = 7698,
        [Description("Local Display Trigger Level X Blinding Aura Skill On Equip")]
        LocalDisplayTriggerLevelXBlindingAuraSkillOnEquip = 7699,
        [Description("Minimum Added Chaos Damage Per Spiders Web On Enemy")]
        MinimumAddedChaosDamagePerSpidersWebOnEnemy = 7700,
        [Description("Maximum Added Chaos Damage Per Spiders Web On Enemy")]
        MaximumAddedChaosDamagePerSpidersWebOnEnemy = 7701,
        [Description("Hit And Ailment Damage +% Vs Enemies Affected By At Least 3 Spiders Webs")]
        HitAndAilmentDamagePosPctVsEnemiesAffectedByAtLeast3SpidersWebs = 7702,
        [Description("Damage +% For Enemies You Inflict Spiders Web Upon")]
        DamagePosPctForEnemiesYouInflictSpidersWebUpon = 7703,
        [Description("Spider Aspect Skill Area Of Effect +%")]
        SpiderAspectSkillAreaOfEffectPosPct = 7704,
        [Description("Resist All % For Enemies You Inflict Spiders Web Upon")]
        ResistAllPctForEnemiesYouInflictSpidersWebUpon = 7705,
        [Description("Resist All %")]
        ResistAllPct = 7706,
        [Description("Chance To Gain Power Charge On Hitting Enemy Affected By Spiders Web %")]
        ChanceToGainPowerChargeOnHittingEnemyAffectedBySpidersWebPct = 7707,
        [Description("Chance To Poison On Hit % Per Power Charge")]
        ChanceToPoisonOnHitPctPerPowerCharge = 7708,
        [Description("Poison Damage +% Per Power Charge")]
        PoisonDamagePosPctPerPowerCharge = 7709,
        [Description("Spider Aspect Web Interval Ms Override")]
        SpiderAspectWebIntervalMsOverride = 7710,
        [Description("Bestiary Net Variation")]
        BestiaryNetVariation = 7711,
        [Description("Virtual Golem Buff Effect +%")]
        VirtualGolemBuffEffectPosPct = 7712,
        [Description("Golem Buff Effect +% Per Summoned Golem")]
        GolemBuffEffectPosPctPerSummonedGolem = 7713,
        [Description("Has Tailwind")]
        HasTailwind = 7714,
        [Description("Summoned Skeletons Hits Cant Be Evaded")]
        SummonedSkeletonsHitsCantBeEvaded = 7715,
        [Description("Zombie Slam Area Of Effect +%")]
        ZombieSlamAreaOfEffectPosPct = 7716,
        [Description("Monster Slam Area Of Effect +%")]
        MonsterSlamAreaOfEffectPosPct = 7717,
        [Description("Additional Block % Per Hit You Have Blocked In Past 10 Seconds")]
        AdditionalBlockPctPerHitYouHaveBlockedInPast10Seconds = 7718,
        [Description("Herald Of Ash Spell Fire Damage +% Final")]
        HeraldOfAshSpellFireDamagePosPctFinal = 7719,
        [Description("Skill Uses Main Hand")]
        SkillUsesMainHand = 7720,
        [Description("Skill Uses Off Hand")]
        SkillUsesOffHand = 7721,
        [Description("Hundred Times Average Damage Per Spell Hit")]
        HundredTimesAverageDamagePerSpellHit = 7722,
        [Description("Hundred Times Average Damage Per Secondary Hit")]
        HundredTimesAverageDamagePerSecondaryHit = 7723,
        [Description("Hundred Times Average Damage Per Main Hand Hit")]
        HundredTimesAverageDamagePerMainHandHit = 7724,
        [Description("Hundred Times Average Damage Per Off Hand Hit")]
        HundredTimesAverageDamagePerOffHandHit = 7725,
        [Description("Life Leech From Spell Damage Permyriad While You Have Arcane Surge")]
        LifeLeechFromSpellDamagePermyriadWhileYouHaveArcaneSurge = 7726,
        [Description("Additional Spell Block %")]
        AdditionalSpellBlockPct = 7727,
        [Description("Cannot Pierce")]
        CannotPierce = 7728,
        [Description("Projectile Damage % For Each Remaining Chain")]
        ProjectileDamagePctForEachRemainingChain = 7729,
        [Description("Raging Spirits Always Ignite")]
        RagingSpiritsAlwaysIgnite = 7730,
        [Description("Reduce Enemy Fire Resistance % Vs Blinded Enemies")]
        ReduceEnemyFireResistancePctVsBlindedEnemies = 7731,
        [Description("Hits Cannot Be Evaded Vs Blinded Enemies")]
        HitsCannotBeEvadedVsBlindedEnemies = 7732,
        [Description("Base Body Armour Evasion Rating")]
        BaseBodyArmourEvasionRating = 7733,
        [Description("Base Helmet Maximum Energy Shield")]
        BaseHelmetMaximumEnergyShield = 7734,
        [Description("Evasion Rating + Per 1 Helmet Energy Shield")]
        EvasionRatingPosPer1HelmetEnergyShield = 7735,
        [Description("Maximum Energy Shield + Per 6 Body Armour Evasion Rating")]
        MaximumEnergyShieldPosPer6BodyArmourEvasionRating = 7736,
        [Description("Damage Taken +% If Have Not Been Hit Recently")]
        DamageTakenPosPctIfHaveNotBeenHitRecently = 7737,
        [Description("Cannot Be Stunned If Have Not Been Hit Recently")]
        CannotBeStunnedIfHaveNotBeenHitRecently = 7738,
        [Description("Map Num Grandmasters")]
        MapNumGrandmasters = 7739,
        [Description("Map Grandmaster Seed")]
        MapGrandmasterSeed = 7740,
        [Description("Minimum Fire Damage To Hits Against Blinded Enemies")]
        MinimumFireDamageToHitsAgainstBlindedEnemies = 7741,
        [Description("Maximum Fire Damage To Hits Against Blinded Enemies")]
        MaximumFireDamageToHitsAgainstBlindedEnemies = 7742,
        [Description("Light Radius Increases Apply To Accuracy")]
        LightRadiusIncreasesApplyToAccuracy = 7743,
        [Description("Endurance Charge On Melee Stun Damage +% Final Per Endurance Charge")]
        EnduranceChargeOnMeleeStunDamagePosPctFinalPerEnduranceCharge = 7744,
        [Description("Tectonic Slam Chance To Not Consume Endurance Charge %")]
        TectonicSlamChanceToNotConsumeEnduranceChargePct = 7745,
        [Description("% Number Of Raging Spirits Allowed")]
        PctNumberOfRagingSpiritsAllowed = 7746,
        [Description("Manifest Dancing Dervish Number Of Additional Copies")]
        ManifestDancingDervishNumberOfAdditionalCopies = 7747,
        [Description("Map Is Zana Map")]
        MapIsZanaMap = 7748,
        [Description("Map Num Zana Mods")]
        MapNumZanaMods = 7749,
        [Description("Local Display Trigger Level X Curse Nova On Hit While Cursed")]
        LocalDisplayTriggerLevelXCurseNovaOnHitWhileCursed = 7750,
        [Description("Cast On Hit If Cursed %")]
        CastOnHitIfCursedPct = 7751,
        [Description("Base Life Recovery Per Minute From Flask")]
        BaseLifeRecoveryPerMinuteFromFlask = 7752,
        [Description("Base Mana Recovery Per Minute From Flask")]
        BaseManaRecoveryPerMinuteFromFlask = 7753,
        [Description("Tectonic Slam Damage +%")]
        TectonicSlamDamagePosPct = 7754,
        [Description("Tectonic Slam Area Of Effect +%")]
        TectonicSlamAreaOfEffectPosPct = 7755,
        [Description("Spectral Shield Throw Damage +%")]
        SpectralShieldThrowDamagePosPct = 7756,
        [Description("Spectral Shield Throw Projectile Speed +%")]
        SpectralShieldThrowProjectileSpeedPosPct = 7757,
        [Description("Spectral Shield Throw Num Of Additional Projectiles")]
        SpectralShieldThrowNumOfAdditionalProjectiles = 7758,
        [Description("Cannot Take Reflected Elemental Damage")]
        CannotTakeReflectedElementalDamage = 7759,
        [Description("Cannot Take Reflected Physical Damage")]
        CannotTakeReflectedPhysicalDamage = 7760,
        [Description("Golem Damage +% Per Active Golem")]
        GolemDamagePosPctPerActiveGolem = 7761,
        [Description("Tailwind Effect On Self +% For Each Skill Used Recently")]
        TailwindEffectOnSelfPosPctForEachSkillUsedRecently = 7762,
        [Description("Virtual Spider Aspect Web Interval Ms")]
        VirtualSpiderAspectWebIntervalMs = 7763,
        [Description("Aspect Of The Spider Web Count +")]
        AspectOfTheSpiderWebCountPos = 7764,
        [Description("Crab Aspect Crab Barrier Max +")]
        CrabAspectCrabBarrierMaxPos = 7765,
        [Description("Combined Skill Dot Fire Damage Over Time +% Final")]
        CombinedSkillDotFireDamageOverTimePosPctFinal = 7766,
        [Description("Virtual No Mana Cost")]
        VirtualNoManaCost = 7767,
    }
}
