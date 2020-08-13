using RimWorld;
using UnityEngine;
using Verse;

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
                            graphicData.color = new Color(1f, 1f, 1f); // white
                            break;
                        case QualityCategory.Poor:
                            graphicData.color = new Color(0.4f, 1f, 0.2f); // green
                            break;
                        case QualityCategory.Normal:
                            graphicData.color = new Color(0f, 0f, 1f); // blue
                            break;
                        case QualityCategory.Good:
                            graphicData.color = new Color(0.6f, 0f, 0.6f); // purple
                            break;
                        case QualityCategory.Excellent:
                            graphicData.color = new Color(1f, 0.6f, 0f); // orange
                            break;
                        case QualityCategory.Masterwork:
                            graphicData.color = new Color(1f, 0.2f, 0.8f); // pink
                            break;
                        case QualityCategory.Legendary:
                            graphicData.color = new Color(0f, 1f, 1f); // cyan
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
