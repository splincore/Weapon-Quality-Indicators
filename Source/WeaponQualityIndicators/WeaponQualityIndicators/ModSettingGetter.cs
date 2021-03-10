using UnityEngine;
using Verse;

namespace WeaponQualityIndicators
{
    [StaticConstructorOnStartup]
    public static class ModSettingGetter
    {
        static ModSettingGetter()
        {
            GetSettings();
        }

        public static void GetSettings()
        {
            xDrawSize = LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().xDrawSize;
            yDrawSize = LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().yDrawSize;
            renderGraphicIndicator = LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().renderGraphicIndicator;
            changeInspectorCardColor = LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().changeInspectorCardColor;
            changeShortLabelColor = LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().changeShortLabelColor;
            changeLabelColor = LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().changeLabelColor;
            stringAwful = LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().colorAwful;
            stringPoor = LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().colorPoor;
            stringNormal = LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().colorNormal;
            stringGood = LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().colorGood;
            stringExcellent = LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().colorExcellent;
            stringMasterwork = LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().colorMasterwork;
            stringLegendary = LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().colorLegendary;
        }

        public static float xDrawSize = 1f;
        public static float yDrawSize = 1f;
        public static bool renderGraphicIndicator = true;
        public static bool changeInspectorCardColor = false;
        public static bool changeShortLabelColor = false;
        public static bool changeLabelColor = false;
        public static string stringAwful = "<color=#ffffff>";
        public static string stringPoor = "<color=#66ff33>";
        public static string stringNormal = "<color=#0000ff>";
        public static string stringGood = "<color=#990099>";
        public static string stringExcellent = "<color=#ff9900>";
        public static string stringMasterwork = "<color=#ff66cc>";
        public static string stringLegendary = "<color=#00ffff>";
    }
}
