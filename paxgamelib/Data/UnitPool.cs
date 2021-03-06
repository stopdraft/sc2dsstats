﻿using paxgamelib.Models;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.Json;

namespace paxgamelib.Data
{
    public static class UnitPool
    {
        public static List<Unit> Units { get; set; } = new List<Unit>();
        public static List<IUnit> IUnits { get; set; } = new List<IUnit>();

        public static void Init()
        {
            //Units = JsonSerializer.Deserialize<List<Unit>>(File.ReadAllText("/data/units.json"));
            Build();

        }

        public static void Build()
        {
            Unit na = new Unit();
            na.Name = "NA";
            na.ID = 0;
            na.Attributes = new List<UnitAttributes>() { UnitAttributes.Biological, UnitAttributes.Light };
            na.AttacType = UnitUpgrades.GroundAttac;
            na.ArmorType = UnitUpgrades.GroundArmor;
            na.Race = UnitRace.Terran;
            na.Tier = 1;
            na.Healthpoints = 10;
            na.Healthbar = na.Healthpoints;
            na.Attacrange = 5;
            na.Attacdamage = 6;
            na.Attacspeed = 0.61f;
            na.AttacUpgradeModifier = 1;
            na.ArmorUpgradeModifier = 1;
            na.Armor = 0;
            na.Image = "images/pax_na_tiny.png";
            na.Speed = 3.15f;
            na.Visionrange = 9;
            na.Cost = 0;
            na.Size = 0.5f;



            Unit p1 = new Unit();
            p1.Name = "Zealot";
            p1.ID = 40;
            p1.Attributes = new List<UnitAttributes>() { UnitAttributes.Biological, UnitAttributes.Light };
            p1.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.ShieldRegeneration).FirstOrDefault().DeepCopy());
            p1.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.Charge).FirstOrDefault().DeepCopy());
            p1.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.ChargeBase).FirstOrDefault().DeepCopy());
            p1.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.SunderingImpact).FirstOrDefault().DeepCopy());
            p1.AttacType = UnitUpgrades.GroundAttac;
            p1.ArmorType = UnitUpgrades.GroundArmor;
            p1.Race = UnitRace.Protoss;
            p1.Tier = 1;
            p1.Healthpoints = 100;
            p1.Healthbar = p1.Healthpoints;
            p1.Shieldpoints = 50;
            p1.Shieldbar = p1.Shieldpoints;
            p1.Attacrange = 0.1f;
            p1.Attacdamage = 8;
            p1.Attacspeed = 0.86f;
            p1.Attacs = 2;
            p1.AttacUpgradeModifier = 1;
            p1.ArmorUpgradeModifier = 1;
            p1.ShieldArmorUpgradeModifier = 1;
            p1.Armor = 1;
            p1.ShieldArmor = 0;
            p1.Image = "images/pax_zealot_tiny.png";
            p1.Speed = 3.15f;
            p1.Visionrange = 9;
            p1.Cost = 85;
            p1.Size = 0.5f;

            Unit p2 = new Unit();
            p2.Name = "Adept";
            p2.ID = 41;
            p2.Attributes = new List<UnitAttributes>() { UnitAttributes.Biological, UnitAttributes.Light };
            p2.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.ShieldRegeneration).FirstOrDefault().DeepCopy());
            p2.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.PsionicTransfer).FirstOrDefault().DeepCopy());
            p2.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.ResonatingGlaives).FirstOrDefault().DeepCopy());
            p2.AttacType = UnitUpgrades.GroundAttac;
            p2.ArmorType = UnitUpgrades.GroundArmor;
            p2.Race = UnitRace.Protoss;
            p2.Tier = 1;
            p2.Healthpoints = 70;
            p2.Healthbar = p2.Healthpoints;
            p2.Shieldpoints = 70;
            p2.Shieldbar = p2.Shieldpoints;
            p2.Attacrange = 4;
            p2.Attacdamage = 10;
            p2.Attacspeed = 1.61f;
            p2.AttacUpgradeModifier = 1;
            p2.ArmorUpgradeModifier = 1;
            p2.ShieldArmorUpgradeModifier = 1;
            p2.Armor = 1;
            p2.ShieldArmor = 0;
            p2.Image = "images/pax_adept_tiny.png";
            p2.Speed = 3.5f;
            p2.Visionrange = 9;
            p2.Cost = 95;
            p2.Size = 0.5f;
            p2.Bonusdamage = new BonusDamage();
            p2.Bonusdamage.Attribute = UnitAttributes.Light;
            p2.Bonusdamage.Type = p2.AttacType;
            p2.Bonusdamage.Damage = 12;
            p2.Bonusdamage.Modifier = 1;

            Unit p3 = new Unit();
            p3.Name = "Stalker";
            p3.ID = 42;
            p3.Attributes = new List<UnitAttributes>() { UnitAttributes.Mechanical, UnitAttributes.Armored };
            p3.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.ShieldRegeneration).FirstOrDefault().DeepCopy());
            p3.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.Blink).FirstOrDefault().DeepCopy());
            p3.AttacType = UnitUpgrades.GroundAttac;
            p3.ArmorType = UnitUpgrades.GroundArmor;
            p3.Race = UnitRace.Protoss;
            p3.Tier = 1;
            p3.Healthpoints = 80;
            p3.Healthbar = p3.Healthpoints;
            p3.Shieldpoints = 80;
            p3.Shieldbar = p3.Shieldpoints;
            p3.Attacrange = 6;
            p3.Attacdamage = 13;
            p3.Attacspeed = 1.34f;
            p3.AttacUpgradeModifier = 1;
            p3.ArmorUpgradeModifier = 1;
            p3.ShieldArmorUpgradeModifier = 1;
            p3.Armor = 1;
            p3.ShieldArmor = 0;
            p3.Image = "images/pax_stalker_tiny.png";
            p3.Speed = 4.13f;
            p3.Visionrange = 10;
            p3.Cost = 100;
            p3.Size = 1;
            p3.BuildSize = 2;
            p3.Bonusdamage = new BonusDamage();
            p3.Bonusdamage.Attribute = UnitAttributes.Armored;
            p3.Bonusdamage.Type = p2.AttacType;
            p3.Bonusdamage.Damage = 5;
            p3.Bonusdamage.Modifier = 1;

            Unit p4 = new Unit();
            p4.Name = "Sentry";
            p4.ID = 43;
            p4.Attributes = new List<UnitAttributes>() { UnitAttributes.Mechanical, UnitAttributes.Light, UnitAttributes.Psionic };
            p4.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.ShieldRegeneration).FirstOrDefault().DeepCopy());
            p4.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.EnergyRegeneration).FirstOrDefault().DeepCopy());
            p4.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.Haluzination).FirstOrDefault().DeepCopy());
            p4.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.GuardianShield).FirstOrDefault().DeepCopy());
            p4.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.GuardianShieldMitigation).FirstOrDefault().DeepCopy());
            p4.AttacType = UnitUpgrades.GroundAttac;
            p4.ArmorType = UnitUpgrades.GroundArmor;
            p4.Race = UnitRace.Protoss;
            p4.Tier = 1;
            p4.Healthpoints = 40;
            p4.Healthbar = p1.Healthpoints;
            p4.Shieldpoints = 40;
            p4.Shieldbar = p1.Shieldpoints;
            p4.Attacrange = 5;
            p4.Attacdamage = 6;
            p4.Attacspeed = 0.71f;
            p4.Attacs = 1;
            p4.AttacUpgradeModifier = 1;
            p4.ArmorUpgradeModifier = 1;
            p4.ShieldArmorUpgradeModifier = 1;
            p4.Armor = 1;
            p4.ShieldArmor = 0;
            p4.Image = "images/pax_sentry_tiny.png";
            p4.ImagesAlt = new List<string>() { "images/pax_sentry_alt1.png" };
            p4.Speed = 3.15f;
            p4.Visionrange = 10;
            p4.Energypoints = 200;
            p4.Energybar = 120;
            p4.Cost = 115;
            p4.Size = 0.5f;

            Unit GuardienShield = new Unit();
            GuardienShield.Name = "GuardianShield";
            GuardienShield.ID = 101;
            GuardienShield.Attributes = new List<UnitAttributes>() { UnitAttributes.Neutral };
            GuardienShield.Abilities.Add(AbilityPool.Abilities.SingleOrDefault(x => x.Ability == UnitAbilities.LifeTime).DeepCopy());
            GuardienShield.Abilities.First().Duration = new System.TimeSpan(0, 0, 0, 15, 0);
            GuardienShield.Race = UnitRace.Neutral;
            GuardienShield.Healthpoints = 10000;
            GuardienShield.Healthbar = 10000;
            GuardienShield.Attacdamage = 0;
            GuardienShield.Speed = 0;
            GuardienShield.Image = "images/pax_guardianshield.png";
            GuardienShield.Visionrange = 0;
            GuardienShield.Cost = 0;
            GuardienShield.Size = 0;

            Unit ArchonHalu = new Unit();
            ArchonHalu.Name = "ArchonHaluzination";
            ArchonHalu.ID = 102;
            ArchonHalu.Attributes = new List<UnitAttributes>() { UnitAttributes.Decoy };
            ArchonHalu.Race = UnitRace.Decoy;
            ArchonHalu.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.LifeTime).FirstOrDefault().DeepCopy());
            ArchonHalu.Healthpoints = 360 / 2;
            ArchonHalu.Healthbar = ArchonHalu.Healthpoints;
            ArchonHalu.Image = "images/pax_archon_tiny.png";
            ArchonHalu.Attacdamage = 0;
            ArchonHalu.Cost = 0;
            ArchonHalu.Speed = 3.94f;
            ArchonHalu.Attacrange = 3;
            ArchonHalu.Visionrange = 9;

            Unit AbilityVisualization = new Unit();
            AbilityVisualization.Name = "AbilityVisualization";
            AbilityVisualization.ID = 103;
            AbilityVisualization.Attributes = new List<UnitAttributes>() { UnitAttributes.Neutral };
            AbilityVisualization.Race = UnitRace.Neutral;
            AbilityVisualization.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.LifeTime).FirstOrDefault().DeepCopy());
            AbilityVisualization.Abilities.First().Duration = new System.TimeSpan(0, 0, 0, 0, 501);
            AbilityVisualization.Healthpoints = 10000;
            AbilityVisualization.Healthbar = AbilityVisualization.Healthpoints;
            AbilityVisualization.Image = "images/pax_ability_stimpack.png";
            AbilityVisualization.Attacdamage = 0;
            AbilityVisualization.Cost = 0;
            AbilityVisualization.Speed = 0;
            AbilityVisualization.Attacrange = 0;
            AbilityVisualization.Visionrange = 0;

            Unit Queen = new Unit();
            Queen.Name = "Queen";
            Queen.ID = 23;
            Queen.Attributes = new List<UnitAttributes>() { UnitAttributes.Biological, UnitAttributes.Psionic};
            Queen.Race = UnitRace.Zerg;
            Queen.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.Regeneration).FirstOrDefault().DeepCopy());
            Queen.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.EnergyRegeneration).FirstOrDefault().DeepCopy());
            Queen.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.Transfusion).FirstOrDefault().DeepCopy());
            Queen.Abilities.Add(AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.LifeTime).FirstOrDefault().DeepCopy());
            Queen.Tier = 1;
            Queen.AttacType = UnitUpgrades.GroundAttac;
            Queen.ArmorType = UnitUpgrades.GroundArmor;
            Queen.Healthpoints = 175;
            Queen.Healthbar = Queen.Healthpoints;
            Queen.Image = "images/pax_queen_tiny.png";
            Queen.Attacdamage = 4;
            Queen.Attacs = 2;
            Queen.AttacUpgradeModifier = 1;
            Queen.Attacspeed = 0.71f;
            Queen.Attacrange = 5;
            Queen.Visionrange = 9;
            Queen.Size = 1;
            Queen.BuildSize = 2;
            Queen.Cost = 175;
            Queen.Armor = 1;
            //Queen.Armor = 100;
            Queen.ArmorUpgradeModifier = 1;
            Queen.Speed = 1.31f;
            Queen.Energypoints = 200;
            Queen.Energybar = 80;


            Unit Marine = new Unit();
            Marine.Name = "Marine";
            Marine.ID = 1;
            Marine.Attributes = new List<UnitAttributes>() { UnitAttributes.Biological, UnitAttributes.Light };
            Marine.AttacType = UnitUpgrades.GroundAttac;
            Marine.ArmorType = UnitUpgrades.GroundArmor;
            Marine.Race = UnitRace.Terran;
            Marine.Tier = 1;
            Marine.Abilities.Add((UnitAbility)AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.Stimpack).FirstOrDefault().DeepCopy());
            Marine.Abilities.Add((UnitAbility)AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.CombatShield).FirstOrDefault().DeepCopy());
            Marine.Healthpoints = 45;
            Marine.Healthbar = Marine.Healthpoints;
            Marine.Attacrange = 5;
            Marine.Attacdamage = 6;
            Marine.Attacspeed = 0.61f;
            Marine.AttacUpgradeModifier = 1;
            Marine.ArmorUpgradeModifier = 1;
            Marine.Armor = 0;
            Marine.Image = "images/pax_marine_tiny.png";
            Marine.Speed = 3.15f;
            Marine.Visionrange = 9;
            Marine.Cost = 50;
            Marine.Size = 0.5f;

            Unit Marauder = new Unit();
            Marauder.Name = "Marauder";
            Marauder.ID = 2;
            Marauder.Attributes = new List<UnitAttributes>() { UnitAttributes.Biological, UnitAttributes.Armored };
            Marauder.AttacType = UnitUpgrades.GroundAttac;
            Marauder.ArmorType = UnitUpgrades.GroundArmor;
            Marauder.Race = UnitRace.Terran;
            Marauder.Tier = 1;
            Marauder.Abilities.Add((UnitAbility)AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.Stimpack).FirstOrDefault().DeepCopy());
            Marauder.Abilities.Add((UnitAbility)AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.ConcussiveShells).FirstOrDefault().DeepCopy());
            Marauder.Healthpoints = 125;
            Marauder.Healthbar = Marauder.Healthpoints;
            Marauder.Attacrange = 6;
            Marauder.Attacdamage = 10;
            Marauder.Attacspeed = 1.07f;
            Marauder.AttacUpgradeModifier = 1;
            Marauder.ArmorUpgradeModifier = 1;
            Marauder.Armor = 1;
            Marauder.Image = "images/pax_marauder_tiny.png";
            Marauder.Speed = 3.15f;
            Marauder.Visionrange = 10;
            Marauder.Cost = 95;
            Marauder.Bonusdamage = new BonusDamage();
            Marauder.Bonusdamage.Attribute = UnitAttributes.Armored;
            Marauder.Bonusdamage.Type = Marauder.AttacType;
            Marauder.Bonusdamage.Damage = 10;
            Marauder.Bonusdamage.Modifier = 1;
            Marauder.Size = 0.5f;

            Unit Reaper = new Unit();
            Reaper.Name = "Reaper";
            Reaper.ID = 3;
            Reaper.Attributes = new List<UnitAttributes>() { UnitAttributes.Biological, UnitAttributes.Light };
            Reaper.AttacType = UnitUpgrades.GroundAttac;
            Reaper.ArmorType = UnitUpgrades.GroundArmor;
            Reaper.Race = UnitRace.Terran;
            Reaper.Tier = 1;
            Reaper.Abilities.Add((UnitAbility)AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.KD8Charge).FirstOrDefault().DeepCopy());
            Reaper.Healthpoints = 60;
            Reaper.Healthbar = Reaper.Healthpoints;
            Reaper.Attacrange = 5;
            Reaper.Attacdamage = 4;
            Reaper.Attacspeed = 0.79f;
            Reaper.Attacs = 2;
            Reaper.AttacUpgradeModifier = 1;
            Reaper.ArmorUpgradeModifier = 1;
            Reaper.Armor = 0;
            Reaper.Image = "images/pax_reaper_tiny.png";
            Reaper.Speed = 5.25f;
            Reaper.Visionrange = 9;
            Reaper.Cost = 65;
            Reaper.Size = 0.5f;

            Unit Zergling = new Unit();
            Zergling.Name = "Zergling";
            Zergling.ID = 20;
            Zergling.Attributes = new List<UnitAttributes>() { UnitAttributes.Biological, UnitAttributes.Light };
            Zergling.AttacType = UnitUpgrades.GroundMeleeAttac;
            Zergling.ArmorType = UnitUpgrades.GroundArmor;
            Zergling.Race = UnitRace.Zerg;
            Zergling.Tier = 1;
            Zergling.Abilities.Add((UnitAbility)AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.Regeneration).FirstOrDefault().DeepCopy());
            Zergling.Abilities.Add((UnitAbility)AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.MetabolicBoost).FirstOrDefault().DeepCopy());
            Zergling.Abilities.Add((UnitAbility)AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.AdrenalGlands).FirstOrDefault().DeepCopy());
            Zergling.Healthpoints = 35;
            Zergling.Healthbar = Zergling.Healthpoints;
            Zergling.Attacrange = 0.1f;
            Zergling.Attacdamage = 5;
            //Zergling.Attacdamage = 0;
            Zergling.Attacspeed = 0.696f;
            Zergling.AttacUpgradeModifier = 1;
            Zergling.ArmorUpgradeModifier = 1;
            Zergling.Armor = 0;
            Zergling.Image = "images/pax_zergling_tiny.png";
            Zergling.Speed = 2.9531f;
            Zergling.Visionrange = 8;
            Zergling.Cost = 20;
            Zergling.Size = 0.25f;

            Unit Baneling = new Unit();
            Baneling.Name = "Baneling";
            Baneling.ID = 21;
            Baneling.Attributes = new List<UnitAttributes>() { UnitAttributes.Biological, UnitAttributes.Suicide };
            Baneling.AttacType = UnitUpgrades.GroundMeleeAttac;
            Baneling.ArmorType = UnitUpgrades.GroundArmor;
            Baneling.Race = UnitRace.Zerg;
            Baneling.Tier = 1;
            Baneling.Abilities.Add((UnitAbility)AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.Regeneration).FirstOrDefault().DeepCopy());
            Baneling.Abilities.Add((UnitAbility)AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.Suicide).FirstOrDefault().DeepCopy());
            Baneling.Abilities.Add((UnitAbility)AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.SuicideOnDeath).FirstOrDefault().DeepCopy());
            Baneling.Abilities.Add((UnitAbility)AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.CentrifugalHooks).FirstOrDefault().DeepCopy());
            Baneling.Healthpoints = 30;
            Baneling.Healthbar = Baneling.Healthpoints;
            Baneling.Attacrange = 0.1f;
            Baneling.Attacdamage = 20;
            Baneling.Attacspeed = 0;
            Baneling.AttacUpgradeModifier = 2;
            Baneling.ArmorUpgradeModifier = 1;
            Baneling.Armor = 0;
            Baneling.Image = "images/pax_baneling_tiny.png";
            Baneling.Speed = 3.5f;
            Baneling.Visionrange = 8;
            Baneling.Cost = 40;
            Baneling.Size = 0.5f;
            Baneling.Areadamage = new AreaDamage();
            Baneling.Areadamage.Distance3 = 0;
            Baneling.Areadamage.Distance2 = 0;
            Baneling.Areadamage.Distance1 = (2.2f / paxgame.Battlefieldmodifier) + Baneling.Size;
            Baneling.Areadamage.FriendlyFire = false;
            Baneling.Bonusdamage = new BonusDamage();
            Baneling.Bonusdamage.Attribute = UnitAttributes.Light;
            Baneling.Bonusdamage.Type = Baneling.AttacType;
            Baneling.Bonusdamage.Damage = 15;
            Baneling.Bonusdamage.Modifier = 2;

            Unit Roach = new Unit();
            Roach.Name = "Roach";
            Roach.ID = 22;
            Roach.Attributes = new List<UnitAttributes>() { UnitAttributes.Biological, UnitAttributes.Armored };
            Roach.AttacType = UnitUpgrades.GroundAttac;
            Roach.ArmorType = UnitUpgrades.GroundArmor;
            Roach.Race = UnitRace.Zerg;
            Roach.Tier = 1;
            Roach.Abilities.Add((UnitAbility)AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.Regeneration).FirstOrDefault().DeepCopy());
            Roach.Healthpoints = 145;
            Roach.Healthbar = Roach.Healthpoints;
            Roach.Attacrange = 4;
            Roach.Attacdamage = 16;
            Roach.Attacspeed = 1.43f;
            Roach.AttacUpgradeModifier = 2;
            Roach.ArmorUpgradeModifier = 1;
            Roach.Armor = 1;
            Roach.Image = "images/pax_roach_tiny.png";
            Roach.Speed = 3.15f;
            Roach.Visionrange = 9;
            Roach.Cost = 80;
            Roach.Size = 0.5f;

            Unit KD8 = new Unit();
            KD8.Name = "KD8";
            KD8.ID = 100;
            KD8.Attributes = new List<UnitAttributes>() { UnitAttributes.Neutral };
            KD8.AttacType = UnitUpgrades.GroundAttac;
            KD8.ArmorType = UnitUpgrades.GroundArmor;
            KD8.Race = UnitRace.Neutral;
            KD8.Tier = 1;
            KD8.Abilities.Add((UnitAbility)AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.Suicide).FirstOrDefault().DeepCopy());
            KD8.Abilities.Add((UnitAbility)AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.KnockBack).FirstOrDefault().DeepCopy());
            KD8.Abilities.Add((UnitAbility)AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.Explode).FirstOrDefault().DeepCopy());
            KD8.Healthpoints = 10000;
            KD8.Healthbar = KD8.Healthpoints;
            KD8.Attacrange = 1;
            KD8.Attacdamage = 5;
            KD8.Attacspeed = 0;
            KD8.AttacUpgradeModifier = 0;
            KD8.ArmorUpgradeModifier = 0;
            KD8.Armor = 100;
            KD8.Image = "images/pax_kd8.png";
            KD8.Speed = 0;
            KD8.Visionrange = 0;
            KD8.Cost = 0;
            KD8.Size = 0;
            KD8.Areadamage = new AreaDamage();
            KD8.Areadamage.Distance3 = 0;
            KD8.Areadamage.Distance2 = 0;
            KD8.Areadamage.Distance1 = 2.0f / 4;
            KD8.Areadamage.FriendlyFire = false;

            Unit cc1 = new Unit();
            cc1.Name = "CommandCenter1";
            cc1.ID = 10000;
            cc1.Owner = 1;
            cc1.Attributes = new List<UnitAttributes>() { UnitAttributes.Defence, UnitAttributes.Massive };
            cc1.Race = UnitRace.Defence;
            cc1.Tier = 1;
            cc1.Abilities.Add((UnitAbility)AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.ShieldRegeneration).FirstOrDefault().DeepCopy());
            cc1.Healthpoints = 750;
            cc1.Shieldpoints = 250;
            cc1.Healthbar = cc1.Healthpoints;
            cc1.Shieldbar = cc1.Shieldpoints;
            cc1.Attacrange = 8;
            cc1.Attacdamage = 50;
            cc1.Attacspeed = 0.25f;
            cc1.Armor = 1;
            cc1.ShieldArmor = 1;
            cc1.Image = "images/pax_cc.png";
            cc1.Speed = 0;
            cc1.Visionrange = 9;
            cc1.Cost = 0;
            cc1.Pos = new Vector2(2, Battlefield.Ymax / 2);
            cc1.RealPos = cc1.Pos;
            cc1.BuildPos = cc1.Pos;
            cc1.Status = UnitStatuses.Placed;
            cc1.Areadamage = new AreaDamage();
            cc1.Size = 4;

            Unit cc2 = new Unit();
            cc2.Name = "CommandCenter2";
            cc2.ID = 10001;
            cc2.Owner = 4;
            cc2.Attributes = new List<UnitAttributes>() { UnitAttributes.Defence, UnitAttributes.Massive };
            cc2.Race = UnitRace.Defence;
            cc2.Tier = 1;
            cc2.Abilities.Add((UnitAbility)AbilityPool.Abilities.Where(x => x.Ability == UnitAbilities.ShieldRegeneration).FirstOrDefault().DeepCopy());
            cc2.Healthpoints = 750;
            cc2.Shieldpoints = 250;
            cc2.Healthbar = cc2.Healthpoints;
            cc2.Shieldbar = cc2.Shieldpoints;
            cc2.Attacrange = 8;
            cc2.Attacdamage = 50;
            cc2.Attacspeed = 0.25f;
            cc2.Armor = 1;
            cc2.ShieldArmor = 1;
            cc2.Image = "images/pax_cc.png";
            cc2.Speed = 0;
            cc2.Visionrange = 9;
            cc2.Cost = 0;
            cc2.Pos = new Vector2(Battlefield.Xmax - 3, Battlefield.Ymax / 2);
            cc2.RealPos = cc2.Pos;
            cc2.BuildPos = cc2.Pos;
            cc2.Size = 4;
            cc2.Status = UnitStatuses.Placed;
            cc2.Areadamage = new AreaDamage();

            Unit sc1 = new Unit();
            sc1.Name = "SuicideCounter1";
            sc1.ID = 10002;
            sc1.Owner = 1;
            sc1.Attributes = new List<UnitAttributes>() { UnitAttributes.Neutral };
            sc1.Race = UnitRace.Neutral;
            sc1.Pos = new Vector2(2, Battlefield.Ymax / 2);
            sc1.RealPos = cc1.Pos;
            sc1.BuildPos = cc1.Pos;
            sc1.Status = UnitStatuses.Placed;

            Unit sc2 = new Unit();
            sc2.Name = "SuicideCounter2";
            sc2.ID = 10003;
            sc2.Owner = 1;
            sc2.Attributes = new List<UnitAttributes>() { UnitAttributes.Neutral };
            sc2.Race = UnitRace.Neutral;
            sc2.Pos = new Vector2(Battlefield.Xmax - 3, Battlefield.Ymax / 2);
            sc2.RealPos = cc1.Pos;
            sc2.BuildPos = cc1.Pos;
            sc2.Status = UnitStatuses.Placed;

            Units.Add(na);
            Units.Add(p1);
            Units.Add(p2);
            Units.Add(p3);
            Units.Add(p4);
            Units.Add(GuardienShield);
            Units.Add(ArchonHalu);
            Units.Add(AbilityVisualization);
            Units.Add(Queen);

            Units.Add(Marine);
            Units.Add(Zergling);
            Units.Add(Marauder);
            Units.Add(Baneling);
            Units.Add(Reaper);
            Units.Add(Roach);
            Units.Add(KD8);
            Units.Add(cc1);
            Units.Add(cc2);

            IUnits.AddRange(Units);

            JsonSerializerOptions opt = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            //var json = JsonSerializer.Serialize(Units, opt);
            //File.WriteAllText("/data/units.json", json);
        }

        public static Unit GetCopy(string name)
        {
            return Units.SingleOrDefault(x => x.Name == name).DeepCopy();
        }

        public static Unit GetUnit(string name)
        {
            Unit u = new Unit();
            u.Name = name;
            return u;
        }

    }
}
