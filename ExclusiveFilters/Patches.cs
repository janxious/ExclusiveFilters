using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using BattleTech;
using BattleTech.UI;
using Harmony;
using JetBrains.Annotations;

namespace ExclusiveFilters
{
    [UsedImplicitly]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [HarmonyPatch(typeof(MechLabInventoryWidget), "FilterWeaponBallistic")]
    public static class MechLabInventoryWidget_FilterWeaponBallistic_Patch
    {
        public static void Prefix(MechLabInventoryWidget __instance)
        {
            var willBeFilteringBallistic = !Traverse.Create(__instance).Field("filterEnabledWeaponBallistic").GetValue<bool>();

            if (willBeFilteringBallistic)
            {
                Traverse.Create(__instance).Field("filterEnabledWeaponEnergy").SetValue(false);
                Traverse.Create(__instance).Field("WeaponEnergyToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);
                
                Traverse.Create(__instance).Field("filterEnabledWeaponMissile").SetValue(false);
                Traverse.Create(__instance).Field("WeaponMissileToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);

                Traverse.Create(__instance).Field("filterEnabledWeaponSmall").SetValue(false);
                Traverse.Create(__instance).Field("WeaponSmallToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);
            }
        }
    }

    [UsedImplicitly]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [HarmonyPatch(typeof(MechLabInventoryWidget), "FilterWeaponEnergy")]
    public static class MechLabInventoryWidget_FilterWeaponEnergy_Patch
    {
        public static void Prefix(MechLabInventoryWidget __instance)
        {
            var willBeFilteringEnergy = !Traverse.Create(__instance).Field("filterEnabledWeaponEnergy").GetValue<bool>();

            if (willBeFilteringEnergy)
            {
                Traverse.Create(__instance).Field("filterEnabledWeaponBallistic").SetValue(false);
                Traverse.Create(__instance).Field("WeaponBallisticToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);

                Traverse.Create(__instance).Field("filterEnabledWeaponMissile").SetValue(false);
                Traverse.Create(__instance).Field("WeaponMissileToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);

                Traverse.Create(__instance).Field("filterEnabledWeaponSmall").SetValue(false);
                Traverse.Create(__instance).Field("WeaponSmallToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);
            }
        }
    }

    [UsedImplicitly]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [HarmonyPatch(typeof(MechLabInventoryWidget), "FilterEquipmentHeatsink")]
    public static class MechLabInventoryWidget_FilterEquipmentHeatsink_Patch
    {
        public static void Prefix(MechLabInventoryWidget __instance)
        {
            var willBeFilteringHeatsink = !Traverse.Create(__instance).Field("filterEnabledHeatsink").GetValue<bool>();

            if (willBeFilteringHeatsink)
            {
                Traverse.Create(__instance).Field("filterEnabledJumpjet").SetValue(false);
                Traverse.Create(__instance).Field("EquipmentJumpjetToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);

                Traverse.Create(__instance).Field("filterEnabledUpgrade").SetValue(false);
                Traverse.Create(__instance).Field("EquipmentUpgradeToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);
            }
        }
    }

    [UsedImplicitly]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [HarmonyPatch(typeof(MechLabInventoryWidget), "FilterEquipmentJumpjet")]
    public static class MechLabInventoryWidget_FilterEquipmentJumpjet_Patch
    {
        public static void Prefix(MechLabInventoryWidget __instance)
        {
            var willBeFilteringJumpJet = !Traverse.Create(__instance).Field("filterEnabledJumpjet").GetValue<bool>();

            if (willBeFilteringJumpJet)
            {
                Traverse.Create(__instance).Field("filterEnabledHeatsink").SetValue(false);
                Traverse.Create(__instance).Field("EquipmentHeatsinkToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);

                Traverse.Create(__instance).Field("filterEnabledUpgrade").SetValue(false);
                Traverse.Create(__instance).Field("EquipmentUpgradeToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);
            }
        }
    }

    [UsedImplicitly]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [HarmonyPatch(typeof(MechLabInventoryWidget), "FilterEquipmentUpgrade")]
    public static class MechLabInventoryWidget_FilterEquipmentUpgrade_Patch
    {
        public static void Prefix(MechLabInventoryWidget __instance)
        {
            var willBeFilteringUpgrade = !Traverse.Create(__instance).Field("filterEnabledUpgrade").GetValue<bool>();

            if (willBeFilteringUpgrade)
            {
                Traverse.Create(__instance).Field("filterEnabledHeatsink").SetValue(false);
                Traverse.Create(__instance).Field("EquipmentHeatsinkToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);

                Traverse.Create(__instance).Field("filterEnabledJumpjet").SetValue(false);
                Traverse.Create(__instance).Field("EquipmentJumpjetToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);
            }
        }
    }


    [UsedImplicitly]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [HarmonyPatch(typeof(MechLabInventoryWidget), "FilterWeaponMissile")]
    public static class MechLabInventoryWidget_FilterWeaponMissile_Patch
    {
        public static void Prefix(MechLabInventoryWidget __instance)
        {
            var willBeFilteringMissle = !Traverse.Create(__instance).Field("filterEnabledWeaponMissile").GetValue<bool>();

            if (willBeFilteringMissle)
            {
                Traverse.Create(__instance).Field("filterEnabledWeaponBallistic").SetValue(false);
                Traverse.Create(__instance).Field("WeaponBallisticToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);

                Traverse.Create(__instance).Field("filterEnabledWeaponEnergy").SetValue(false);
                Traverse.Create(__instance).Field("WeaponEnergyToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);
                
                Traverse.Create(__instance).Field("filterEnabledWeaponSmall").SetValue(false);
                Traverse.Create(__instance).Field("WeaponSmallToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);
            }
        }
    }

    [UsedImplicitly]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [HarmonyPatch(typeof(MechLabInventoryWidget), "FilterWeaponSmall")]
    public static class MechLabInventoryWidget_FilterWeaponSmall_Patch
    {
        public static void Prefix(MechLabInventoryWidget __instance)
        {
            var willBeFilteringSmall = !Traverse.Create(__instance).Field("filterEnabledWeaponSmall").GetValue<bool>();

            if (willBeFilteringSmall)
            {
                Traverse.Create(__instance).Field("filterEnabledWeaponBallistic").SetValue(false);
                Traverse.Create(__instance).Field("WeaponBallisticToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);

                Traverse.Create(__instance).Field("filterEnabledWeaponEnergy").SetValue(false);
                Traverse.Create(__instance).Field("WeaponEnergyToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);

                Traverse.Create(__instance).Field("filterEnabledWeaponMissile").SetValue(false);
                Traverse.Create(__instance).Field("WeaponMissileToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);
            }
        }
    }

    [UsedImplicitly]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [HarmonyPatch(typeof(MechLabInventoryWidget), "ResetFilters")]
    public static class MechLabInventoryWidget_ResetFilters_Patch
    {
        public static void Postfix(MechLabInventoryWidget __instance)
        {
            // start with ballistic selected
            Traverse.Create(__instance).Field("filterEnabledWeaponEnergy").SetValue(false);
            Traverse.Create(__instance).Field("WeaponEnergyToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);

            Traverse.Create(__instance).Field("filterEnabledWeaponMissile").SetValue(false);
            Traverse.Create(__instance).Field("WeaponMissileToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);

            Traverse.Create(__instance).Field("filterEnabledWeaponSmall").SetValue(false);
            Traverse.Create(__instance).Field("WeaponSmallToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);

            // start with upgrade selected
            Traverse.Create(__instance).Field("filterEnabledHeatsink").SetValue(false);
            Traverse.Create(__instance).Field("EquipmentHeatsinkToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);

            Traverse.Create(__instance).Field("filterEnabledJumpjet").SetValue(false);
            Traverse.Create(__instance).Field("EquipmentJumpjetToggleObj").GetValue<HBSDOTweenToggle>().SetState(ButtonState.Enabled);
        }
    }

    [UsedImplicitly]
    public static class Patches
    {
        public static void Init(string modFolder, string modSettings)
        {
            var harmony = HarmonyInstance.Create("io.github.mpstark.ExclusiveFilter");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
