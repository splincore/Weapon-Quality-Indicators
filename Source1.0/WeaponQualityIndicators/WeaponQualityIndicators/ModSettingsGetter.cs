using Verse;

namespace WeaponQualityIndicators
{
    [StaticConstructorOnStartup]
    public static class ModSettingGetter
    {
        static ModSettingGetter()
        {
            xDrawSize = LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().xDrawSize;
            yDrawSize = LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().yDrawSize;
            renderGraphicIndicator = LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().renderGraphicIndicator;
            changeInspectorCardColor = LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().changeInspectorCardColor;
            changeShortLabelColor = LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().changeShortLabelColor;
        }

        public static float xDrawSize = 1f;
        public static float yDrawSize = 1f;
        public static bool renderGraphicIndicator = true;
        public static bool changeInspectorCardColor = false;
        public static bool changeShortLabelColor = false;
    }
}
