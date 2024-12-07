using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2Cpp;
using HarmonyLib;
using Unity.VisualScripting;

namespace HarvestYieldTweaker.Patches
{
    internal class HarvestPatches
    {

        [HarmonyPatch(typeof(Panel_BreakDown), nameof(Panel_BreakDown.Enable), new Type[] { typeof(bool) })]

        public class ChangeYield
        {

            public static void Postfix(Panel_BreakDown __instance, ref bool enable)
            {

                if (!enable) return;

                int value = 1;

                if (__instance.m_BreakDownNameLabel.mText.Equals("Cedar Limb")) value = __instance.m_BreakDown.name.Contains("LimbA_Big") ? CustomSettings.settings.largeCedar : CustomSettings.settings.smallCedar;
                else if (__instance.m_BreakDownNameLabel.mText.Equals("Fir Limb")) value = __instance.m_BreakDown.name.Contains("LimbB_Big") ? CustomSettings.settings.largeFir : CustomSettings.settings.smallFir;
                else if (__instance.m_BreakDownNameLabel.mText.Equals("Branch")) value = CustomSettings.settings.branchYield;
                else if (__instance.m_BreakDownNameLabel.mText.Equals("Scrub Brush")) value = CustomSettings.settings.brushYield;
                else if (__instance.m_BreakDownNameLabel.mText.Equals("Crate"))
                {
                    if (__instance.m_BreakDown.name.Contains("CratesB")) value = CustomSettings.settings.crateMini;
                    else if (__instance.m_BreakDown.name.Contains("BoxCrateC")) value = CustomSettings.settings.crateSmall;
                    else if (__instance.m_BreakDown.name.Contains("BoxCrateB")) value = CustomSettings.settings.crateMedium;
                    else if (__instance.m_BreakDown.name.Contains("BoxCrateA")) value = CustomSettings.settings.crateLarge;
                    else value = __instance.m_BreakDown.m_YieldObjectUnits[0];
                }
                else if (__instance.m_BreakDownNameLabel.mText.Equals("Pallets")) value = __instance.m_BreakDown.name.Contains("PalletPileB") ? CustomSettings.settings.stackedPallets : CustomSettings.settings.piledPallets;
                else value = __instance.m_BreakDown.m_YieldObjectUnits[0];

                    Main.Logger.Log($"Yield is {value}", ComplexLogger.FlaggedLoggingLevel.Debug);
                __instance.m_BreakDown.m_YieldObjectUnits[0] = value;
                __instance.RefreshYield();
            }

        }

    }
}
