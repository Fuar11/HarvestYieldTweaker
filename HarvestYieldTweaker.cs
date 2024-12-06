using ComplexLogger;
using Il2Cpp;

namespace HarvestYieldTweaker
{

    public class Main : MelonMod
    {
        internal static ComplexLogger<Main> Logger = new();

        public override void OnInitializeMelon()
        {
            Logger.Log("Harvest Yield Tweaker is online.", FlaggedLoggingLevel.Always);
            CustomSettings.OnLoad();
        }
    }
}
