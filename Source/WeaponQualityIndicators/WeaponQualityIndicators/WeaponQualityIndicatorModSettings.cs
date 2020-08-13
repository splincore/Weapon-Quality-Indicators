using Verse;

namespace WeaponQualityIndicators
{
    public class WeaponQualityIndicatorModSettings : ModSettings
    {
        public float xDrawSize = 1f;
        public float yDrawSize = 1f;
        public bool renderGraphicIndicator = true;
        public bool changeInspectorCardColor = false;
        public bool changeShortLabelColor = false;

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look<float>(ref xDrawSize, "xDrawSize", 1f, false);
            Scribe_Values.Look<float>(ref yDrawSize, "yDrawSize", 1f, false);
            Scribe_Values.Look<bool>(ref renderGraphicIndicator, "renderGraphicIndicator", true, false);
            Scribe_Values.Look<bool>(ref changeInspectorCardColor, "changeInspectorCardColor", false, false);
            Scribe_Values.Look<bool>(ref changeShortLabelColor, "changeShortLabelColor", false, false);
        }
    }
}
