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

        [Name("Mini Crate")]
        [Description("The amount of reclaimed wood you get from chopping mini crates.")]
        [Slider(2, 3)]
        public int crateMini = 2;

        [Name("Small Crate")]
        [Description("The amount of reclaimed wood you get from chopping small crates.")]
        [Slider(2, 6)]
        public int crateSmall = 2;

        [Name("Medium Crate")]
        [Description("The amount of reclaimed wood you get from chopping medium crates.")]
        [Slider(4, 10)]
        public int crateMedium = 4;

        [Name("Large Crate")]
        [Description("The amount of reclaimed wood you get from chopping large crates.")]
        [Slider(6, 12)]
        public int crateLarge = 6;
    
        [Name("Stacked Pallets")]
        [Description("The amount of reclaimed wood you get from chopping stacked pallets.")]
        [Slider(16, 32)]
        public int stackedPallets = 16;

        [Name("Piled Pallets")]
        [Description("The amount of reclaimed wood you get from chopping pilled pallets.")]
        [Slider(12, 32)]
        public int piledPallets = 12;

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
