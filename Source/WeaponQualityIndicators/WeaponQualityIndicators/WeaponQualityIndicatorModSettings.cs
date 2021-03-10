using Verse;

namespace WeaponQualityIndicators
{
    public class WeaponQualityIndicatorModSettings : ModSettings
    {
        public float xDrawSize = 1f;
        public float yDrawSize = 1f;
        public bool renderGraphicIndicator = true;
        public bool changeInspectorCardColor = true;
        public bool changeShortLabelColor = true;
        public bool changeLabelColor = true;

        public string colorAwful = "<color=#ffffff>";
        public string colorPoor = "<color=#66ff33>";
        public string colorNormal = "<color=#0000ff>";
        public string colorGood = "<color=#990099>";
        public string colorExcellent = "<color=#ff9900>";
        public string colorMasterwork = "<color=#ff66cc>";
        public string colorLegendary = "<color=#00ffff>";

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look<float>(ref xDrawSize, "xDrawSize", 1f, false);
            Scribe_Values.Look<float>(ref yDrawSize, "yDrawSize", 1f, false);
            Scribe_Values.Look<bool>(ref renderGraphicIndicator, "renderGraphicIndicator", true, false);
            Scribe_Values.Look<bool>(ref changeInspectorCardColor, "changeInspectorCardColor", true, false);
            Scribe_Values.Look<bool>(ref changeShortLabelColor, "changeShortLabelColor", true, false);
            Scribe_Values.Look<bool>(ref changeLabelColor, "changeLabelColor", true, false);
            Scribe_Values.Look<string>(ref colorAwful, "colorAwful", "<color=#ffffff>", false);
            Scribe_Values.Look<string>(ref colorPoor, "colorPoor", "<color=#66ff33>", false);
            Scribe_Values.Look<string>(ref colorNormal, "colorNormal", "<color=#0000ff>", false);
            Scribe_Values.Look<string>(ref colorGood, "colorGood", "<color=#990099>", false);
            Scribe_Values.Look<string>(ref colorExcellent, "colorExcellent", "<color=#ff9900>", false);
            Scribe_Values.Look<string>(ref colorMasterwork, "colorMasterwork", "<color=#ff66cc>", false);
            Scribe_Values.Look<string>(ref colorLegendary, "colorLegendary", "<color=#00ffff>", false);
        }
    }
}
