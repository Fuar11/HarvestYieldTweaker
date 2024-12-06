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

            static int defaultValue = 0;

            public static void Postfix(Panel_BreakDown __instance, ref bool enable)
            {

                if (!enable) return;

                int value = 0;
                defaultValue = defaultValue == 0 ? __instance.m_BreakDown.m_YieldObjectUnits[0] : defaultValue;

                if (__instance.m_BreakDownNameLabel.mText.Equals("Cedar Limb"))
                {
                    Main.Logger.Log("Cedar found", ComplexLogger.FlaggedLoggingLevel.Debug);
                    value = defaultValue >= 5 ? CustomSettings.settings.largeCedar : CustomSettings.settings.smallCedar;
                }
                else if(__instance.m_BreakDownNameLabel.mText.Equals("Fir Limb"))
                {
                    Main.Logger.Log("Fir found", ComplexLogger.FlaggedLoggingLevel.Debug);
                    value = defaultValue >= 5 ? CustomSettings.settings.largeFir : CustomSettings.settings.smallFir;
                }

                Main.Logger.Log($"Yield is {value}", ComplexLogger.FlaggedLoggingLevel.Debug);
                __instance.m_BreakDown.m_YieldObjectUnits[0] = value;
                __instance.RefreshYield();
            }

        }

    }
}
