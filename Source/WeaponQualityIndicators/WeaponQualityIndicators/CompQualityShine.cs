using RimWorld;
using UnityEngine;
using Verse;
using System.Globalization;

namespace WeaponQualityIndicators
{
    public class CompQualityShine : ThingComp
    {
        public CompProperties_QualityShine Props
        {
            get
            {
                return (CompProperties_QualityShine)props;
            }
        }

        public override string TransformLabel(string label)
        {
            if (!ModSettingGetter.changeLabelColor) return label;
            if (parent.TryGetQuality(out QualityCategory cat))
            {
                switch (cat)
                {
                    case QualityCategory.Awful:
                        return label.Replace(string.Format("({0})", "QualityCategory_Awful".Translate()), string.Format("({0}{1}</color>)", ModSettingGetter.stringAwful, "QualityCategory_Awful".Translate()));
                    case QualityCategory.Poor:
                        return label.Replace(string.Format("({0})", "QualityCategory_Poor".Translate()), string.Format("({0}{1}</color>)", ModSettingGetter.stringPoor, "QualityCategory_Poor".Translate()));
                    case QualityCategory.Normal:
                        return label.Replace(string.Format("({0})", "QualityCategory_Normal".Translate()), string.Format("({0}{1}</color>)", ModSettingGetter.stringNormal, "QualityCategory_Normal".Translate()));
                    case QualityCategory.Good:
                        return label.Replace(string.Format("({0})", "QualityCategory_Good".Translate()), string.Format("({0}{1}</color>)", ModSettingGetter.stringGood, "QualityCategory_Good".Translate()));
                    case QualityCategory.Excellent:
                        return label.Replace(string.Format("({0})", "QualityCategory_Excellent".Translate()), string.Format("({0}{1}</color>)", ModSettingGetter.stringExcellent, "QualityCategory_Excellent".Translate()));
                    case QualityCategory.Masterwork:
                        return label.Replace(string.Format("({0})", "QualityCategory_Masterwork".Translate()), string.Format("({0}{1}</color>)", ModSettingGetter.stringMasterwork, "QualityCategory_Masterwork".Translate()));
                    case QualityCategory.Legendary:
                        return label.Replace(string.Format("({0})", "QualityCategory_Legendary".Translate()), string.Format("({0}{1}</color>)", ModSettingGetter.stringLegendary, "QualityCategory_Legendary".Translate()));
                }
            }
            return label;
        }

        public override void PostPrintOnto(SectionLayer layer)
        {
            base.PostPrintOnto(layer);
            if (!ModSettingGetter.renderGraphicIndicator) return;
            Vector3 center = parent.TrueCenter() + new Vector3(0, 1, 0.5f * ModSettingGetter.yDrawSize);
            Vector2 size = new Vector2(ModSettingGetter.xDrawSize, ModSettingGetter.yDrawSize);
            Material mat = MaterialPool.MatFrom(new MaterialRequest(ContentFinder<Texture2D>.Get(Props.graphicData.texPath, true)));
            Color32 color = new Color32(1, 1, 1, 1);
            if (parent is ThingWithComps thingWithComps && thingWithComps.TryGetComp<CompQuality>() is CompQuality compQuality)
            {
                switch (compQuality.Quality)
                {
                    case QualityCategory.Awful:
                        color = new Color(int.Parse(ModSettingGetter.stringAwful.Substring(8, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringAwful.Substring(10, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringAwful.Substring(12, 2), NumberStyles.HexNumber) / 255f, 1f);
                        break;
                    case QualityCategory.Poor:
                        color = new Color(int.Parse(ModSettingGetter.stringPoor.Substring(8, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringPoor.Substring(10, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringPoor.Substring(12, 2), NumberStyles.HexNumber) / 255f, 1f);
                        break;
                    case QualityCategory.Normal:
                        color = new Color(int.Parse(ModSettingGetter.stringNormal.Substring(8, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringNormal.Substring(10, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringNormal.Substring(12, 2), NumberStyles.HexNumber) / 255f, 1f);
                        break;
                    case QualityCategory.Good:
                        color = new Color(int.Parse(ModSettingGetter.stringGood.Substring(8, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringGood.Substring(10, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringGood.Substring(12, 2), NumberStyles.HexNumber) / 255f, 1f);
                        break;
                    case QualityCategory.Excellent:
                        color = new Color(int.Parse(ModSettingGetter.stringExcellent.Substring(8, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringExcellent.Substring(10, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringExcellent.Substring(12, 2), NumberStyles.HexNumber) / 255f, 1f);
                        break;
                    case QualityCategory.Masterwork:
                        color = new Color(int.Parse(ModSettingGetter.stringMasterwork.Substring(8, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringMasterwork.Substring(10, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringMasterwork.Substring(12, 2), NumberStyles.HexNumber) / 255f, 1f);
                        break;
                    case QualityCategory.Legendary:
                        color = new Color(int.Parse(ModSettingGetter.stringLegendary.Substring(8, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringLegendary.Substring(10, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringLegendary.Substring(12, 2), NumberStyles.HexNumber) / 255f, 1f);
                        break;
                }
            }
            Printer_Plane.PrintPlane(layer, center, size, mat, 0, false, null, new Color32[] { color, color, color, color });
        }
    }
}
