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
                    __result = ModSettingGetter.stringAwful + __result + "</color>";
                    break;
                case QualityCategory.Poor:
                    __result = ModSettingGetter.stringPoor + __result + "</color>";
                    break;
                case QualityCategory.Normal:
                    __result = ModSettingGetter.stringNormal + __result + "</color>";
                    break;
                case QualityCategory.Good:
                    __result = ModSettingGetter.stringGood + __result + "</color>";
                    break;
                case QualityCategory.Excellent:
                    __result = ModSettingGetter.stringExcellent + __result + "</color>";
                    break;
                case QualityCategory.Masterwork:
                    __result = ModSettingGetter.stringMasterwork + __result + "</color>";
                    break;
                case QualityCategory.Legendary:
                    __result = ModSettingGetter.stringLegendary + __result + "</color>";
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
                    __result = ModSettingGetter.stringAwful + __result + "</color>";
                    break;
                case QualityCategory.Poor:
                    __result = ModSettingGetter.stringPoor + __result + "</color>";
                    break;
                case QualityCategory.Normal:
                    __result = ModSettingGetter.stringNormal + __result + "</color>";
                    break;
                case QualityCategory.Good:
                    __result = ModSettingGetter.stringGood + __result + "</color>";
                    break;
                case QualityCategory.Excellent:
                    __result = ModSettingGetter.stringExcellent + __result + "</color>";
                    break;
                case QualityCategory.Masterwork:
                    __result = ModSettingGetter.stringMasterwork + __result + "</color>";
                    break;
                case QualityCategory.Legendary:
                    __result = ModSettingGetter.stringLegendary + __result + "</color>";
                    break;
            }
        }
    }
}
