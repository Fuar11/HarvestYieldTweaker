using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvestYieldTweaker
{
    internal class Settings : JsonModSettings
    {

        [Section("Limbs & Branches")]

        [Name("Large Cedar Limb")]
        [Description("The amount of firewood you get from chopping large cedar limbs.")]
        [Slider(5, 20)]
        public int largeCedar = 5;

        [Name("Small Cedar Limb")]
        [Description("The amount of firewood you get from chopping small cedar limbs.")]
        [Slider(3, 20)]
        public int smallCedar = 3;

        [Name("Large Fir Limb")]
        [Description("The amount of firewood you get from chopping large fir limbs.")]
        [Slider(5, 20)]
        public int largeFir = 5;

        [Name("Small Fir Limb")]
        [Description("The amount of firewood you get from chopping small fir limbs.")]
        [Slider(3, 20)]
        public int smallFir = 3;

        [Name("Branch")]
        [Description("The amount of sticks you get from chopping branches.")]
        [Slider(3, 10)]
        public int branchYield = 3;

        [Name("Scrub Brush")]
        [Description("The amount of sticks you get from chopping brushes.")]
        [Slider(15, 25)]
        public int brushYield = 15;

        [Section("Other")]

        [Name("Crate")]
        [Description("The amount of reclaimed wood you get from chopping crates.")]
        [Slider(5, 15)]
        public int crate = 5;

        [Name("Planks")]
        [Description("The amount of reclaimed wood you get from chopping planks.")]
        [Slider(3, 15)]
        public int planks = 3;
        
        [Name("Pallets")]
        [Description("The amount of reclaimed wood you get from chopping pallets.")]
        [Slider(12, 32)]
        public int pallets = 12;

    }

    static class CustomSettings
    {

        internal static Settings settings;

        internal static void OnLoad()
        {
            settings = new Settings();
            settings.AddToModSettings("Harvest Yield Tweaker", MenuType.Both);
        }
    }

    

}
