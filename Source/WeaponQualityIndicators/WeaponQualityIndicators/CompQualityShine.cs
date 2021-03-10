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

        public override void PostDraw()
        {
            base.PostDraw();
            if (!ModSettingGetter.renderGraphicIndicator) return;
            if (!isInitialized)
            {
                graphicData = new GraphicData();
                graphicData.texPath = Props.graphicData.texPath;
                graphicData.graphicClass = Props.graphicData.graphicClass;
                graphicData.drawSize = new Vector2() { x = ModSettingGetter.xDrawSize, y = ModSettingGetter.yDrawSize };
                if (parent is ThingWithComps thingWithComps && thingWithComps.TryGetComp<CompQuality>() is CompQuality compQuality)
                {
                    switch (compQuality.Quality)
                    {
                        case QualityCategory.Awful:
                            graphicData.color = new Color(int.Parse(ModSettingGetter.stringAwful.Substring(8, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringAwful.Substring(10, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringAwful.Substring(12, 2), NumberStyles.HexNumber) / 255f);
                            break;
                        case QualityCategory.Poor:
                            graphicData.color = new Color(int.Parse(ModSettingGetter.stringPoor.Substring(8, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringPoor.Substring(10, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringPoor.Substring(12, 2), NumberStyles.HexNumber) / 255f);
                            break;
                        case QualityCategory.Normal:
                            graphicData.color = new Color(int.Parse(ModSettingGetter.stringNormal.Substring(8, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringNormal.Substring(10, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringNormal.Substring(12, 2), NumberStyles.HexNumber) / 255f);
                            break;
                        case QualityCategory.Good:
                            graphicData.color = new Color(int.Parse(ModSettingGetter.stringGood.Substring(8, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringGood.Substring(10, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringGood.Substring(12, 2), NumberStyles.HexNumber) / 255f);
                            break;
                        case QualityCategory.Excellent:
                            graphicData.color = new Color(int.Parse(ModSettingGetter.stringExcellent.Substring(8, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringExcellent.Substring(10, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringExcellent.Substring(12, 2), NumberStyles.HexNumber) / 255f);
                            break;
                        case QualityCategory.Masterwork:
                            graphicData.color = new Color(int.Parse(ModSettingGetter.stringMasterwork.Substring(8, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringMasterwork.Substring(10, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringMasterwork.Substring(12, 2), NumberStyles.HexNumber) / 255f);
                            break;
                        case QualityCategory.Legendary:
                            graphicData.color = new Color(int.Parse(ModSettingGetter.stringLegendary.Substring(8, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringLegendary.Substring(10, 2), NumberStyles.HexNumber) / 255f, int.Parse(ModSettingGetter.stringLegendary.Substring(12, 2), NumberStyles.HexNumber) / 255f);
                            break;
                    }
                }
                isInitialized = true;
            }
            graphicData.Graphic.Draw(parent.DrawPos + new Vector3(0f, 2f, 0.5f * graphicData.Graphic.drawSize.y), Rot4.North, parent);
        }

        private GraphicData graphicData = null;
        private bool isInitialized = false;
    }
}
