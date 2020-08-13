using HarmonyLib;
using RimWorld;
using Verse;

namespace WeaponQualityIndicators
{
    [StaticConstructorOnStartup]
    static class HarmonyPatch
    {
        static HarmonyPatch()
        {
            var harmony = new Harmony("rimworld.carnysenpai.weaponqualityindicators");
            harmony.Patch(AccessTools.Method(typeof(CompQuality), "CompInspectStringExtra"), null, new HarmonyMethod(typeof(HarmonyPatch).GetMethod("CompInspectStringExtra_PostFix")), null);
            harmony.Patch(AccessTools.Method(typeof(QualityUtility), "GetLabelShort"), null, new HarmonyMethod(typeof(HarmonyPatch).GetMethod("GetLabelShort_PostFix")), null);
        }

        [HarmonyPostfix]
        public static void CompInspectStringExtra_PostFix(CompQuality __instance, ref string __result)
        {
            if (!ModSettingGetter.changeInspectorCardColor) return;
            switch(__instance.Quality)
            {
                case QualityCategory.Awful:
                    __result = "<color=#ffffff>" + __result + "</color>"; // white
                    break;
                case QualityCategory.Poor:
                    __result = "<color=#66ff33>" + __result + "</color>"; // green
                    break;
                case QualityCategory.Normal:
                    __result = "<color=#0000ff>" + __result + "</color>"; // blue
                    break;
                case QualityCategory.Good:
                    __result = "<color=#990099>" + __result + "</color>"; // purple
                    break;
                case QualityCategory.Excellent:
                    __result = "<color=#ff9900>" + __result + "</color>"; // orange
                    break;
                case QualityCategory.Masterwork:
                    __result = "<color=#ff66cc>" + __result + "</color>"; // pink
                    break;
                case QualityCategory.Legendary:
                    __result = "<color=#00ffff>" + __result + "</color>"; // cyan
                    break;
            }
        }

        [HarmonyPostfix]
        public static void GetLabelShort_PostFix(QualityCategory cat, ref string __result)
        {
            if (!ModSettingGetter.changeShortLabelColor) return;
            switch (cat)
            {
                case QualityCategory.Awful:
                    __result = "<color=#ffffff>" + __result + "</color>"; // white
                    break;
                case QualityCategory.Poor:
                    __result = "<color=#66ff33>" + __result + "</color>"; // green
                    break;
                case QualityCategory.Normal:
                    __result = "<color=#0000ff>" + __result + "</color>"; // blue
                    break;
                case QualityCategory.Good:
                    __result = "<color=#990099>" + __result + "</color>"; // purple
                    break;
                case QualityCategory.Excellent:
                    __result = "<color=#ff9900>" + __result + "</color>"; // orange
                    break;
                case QualityCategory.Masterwork:
                    __result = "<color=#ff66cc>" + __result + "</color>"; // pink
                    break;
                case QualityCategory.Legendary:
                    __result = "<color=#00ffff>" + __result + "</color>"; // cyan
                    break;
            }
        }
    }
}
