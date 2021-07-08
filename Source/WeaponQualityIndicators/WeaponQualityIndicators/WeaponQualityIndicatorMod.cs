using UnityEngine;
using Verse;

namespace WeaponQualityIndicators
{
    public class WeaponQualityIndicatorMod : Mod
    {
        WeaponQualityIndicatorModSettings weaponQualityIndicatorModSettings;

        public WeaponQualityIndicatorMod(ModContentPack content) : base(content)
        {
            this.weaponQualityIndicatorModSettings = GetSettings<WeaponQualityIndicatorModSettings>();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);

            listingStandard.Gap(listingStandard.verticalSpacing);
            listingStandard.Label("WeaponQualityIndicatorWidth".Translate());
            Rect rect1 = listingStandard.GetRect(22f);
            weaponQualityIndicatorModSettings.xDrawSize = Widgets.HorizontalSlider(rect1, weaponQualityIndicatorModSettings.xDrawSize, 0f, 5f, false, (weaponQualityIndicatorModSettings.xDrawSize).ToString("") + "", "0", "5", 0.1f);

            listingStandard.Gap(listingStandard.verticalSpacing);
            listingStandard.Label("WeaponQualityIndicatorLenght".Translate());
            Rect rect2 = listingStandard.GetRect(22f);
            weaponQualityIndicatorModSettings.yDrawSize = Widgets.HorizontalSlider(rect2, weaponQualityIndicatorModSettings.yDrawSize, 0f, 5f, false, (weaponQualityIndicatorModSettings.yDrawSize).ToString("") + "", "0", "5", 0.1f);

            listingStandard.Gap(listingStandard.verticalSpacing);
            listingStandard.CheckboxLabeled("WeaponQualityIndicatorShow".Translate(), ref weaponQualityIndicatorModSettings.renderGraphicIndicator);

            listingStandard.Gap(listingStandard.verticalSpacing);
            listingStandard.CheckboxLabeled("WeaponQualityIndicatorDescriptionCard".Translate(), ref weaponQualityIndicatorModSettings.changeInspectorCardColor);

            listingStandard.Gap(listingStandard.verticalSpacing);
            listingStandard.CheckboxLabeled("WeaponQualityIndicatorGroundLabel".Translate(), ref weaponQualityIndicatorModSettings.changeShortLabelColor);

            listingStandard.Gap(listingStandard.verticalSpacing);
            listingStandard.CheckboxLabeled("WeaponQualityIndicatorItemName".Translate(), ref weaponQualityIndicatorModSettings.changeLabelColor);

            listingStandard.Gap(listingStandard.verticalSpacing);
            if (listingStandard.ButtonText(string.Format("{0} {1}{2}</color> {3}", "WeaponQualityIndicatorChange".Translate(), ModSettingGetter.stringAwful, "QualityCategory_Awful".Translate(), "WeaponQualityIndicatorColor".Translate())))
            {
                Find.WindowStack.Add(new ColorChangeWindow("awful", ModSettingGetter.stringAwful, "<color=#ffffff>"));
            }

            listingStandard.Gap(listingStandard.verticalSpacing);
            if (listingStandard.ButtonText(string.Format("{0} {1}{2}</color> {3}", "WeaponQualityIndicatorChange".Translate(), ModSettingGetter.stringPoor, "QualityCategory_Poor".Translate(), "WeaponQualityIndicatorColor".Translate())))
            {
                Find.WindowStack.Add(new ColorChangeWindow("poor", ModSettingGetter.stringPoor, "<color=#66ff33>"));
            }

            listingStandard.Gap(listingStandard.verticalSpacing);
            if (listingStandard.ButtonText(string.Format("{0} {1}{2}</color> {3}", "WeaponQualityIndicatorChange".Translate(), ModSettingGetter.stringNormal, "QualityCategory_Normal".Translate(), "WeaponQualityIndicatorColor".Translate())))
            {
                Find.WindowStack.Add(new ColorChangeWindow("normal", ModSettingGetter.stringNormal, "<color=#0000ff>"));
            }

            listingStandard.Gap(listingStandard.verticalSpacing);
            if (listingStandard.ButtonText(string.Format("{0} {1}{2}</color> {3}", "WeaponQualityIndicatorChange".Translate(), ModSettingGetter.stringGood, "QualityCategory_Good".Translate(), "WeaponQualityIndicatorColor".Translate())))
            {
                Find.WindowStack.Add(new ColorChangeWindow("good", ModSettingGetter.stringGood, "<color=#990099>"));
            }

            listingStandard.Gap(listingStandard.verticalSpacing);
            if (listingStandard.ButtonText(string.Format("{0} {1}{2}</color> {3}", "WeaponQualityIndicatorChange".Translate(), ModSettingGetter.stringExcellent, "QualityCategory_Excellent".Translate(), "WeaponQualityIndicatorColor".Translate())))
            {
                Find.WindowStack.Add(new ColorChangeWindow("excellent", ModSettingGetter.stringExcellent, "<color=#ff9900>"));
            }

            listingStandard.Gap(listingStandard.verticalSpacing);
            if (listingStandard.ButtonText(string.Format("{0} {1}{2}</color> {3}", "WeaponQualityIndicatorChange".Translate(), ModSettingGetter.stringMasterwork, "QualityCategory_Masterwork".Translate(), "WeaponQualityIndicatorColor".Translate())))
            {
                Find.WindowStack.Add(new ColorChangeWindow("masterwork", ModSettingGetter.stringMasterwork, "<color=#ff66cc>"));
            }

            listingStandard.Gap(listingStandard.verticalSpacing);
            if (listingStandard.ButtonText(string.Format("{0} {1}{2}</color> {3}", "WeaponQualityIndicatorChange".Translate(), ModSettingGetter.stringLegendary, "QualityCategory_Legendary".Translate(), "WeaponQualityIndicatorColor".Translate())))
            {
                Find.WindowStack.Add(new ColorChangeWindow("legendary", ModSettingGetter.stringLegendary, "<color=#00ffff>"));
            }

            listingStandard.End();

            ModSettingGetter.GetSettings();
        }

        public override string SettingsCategory()
        {
            return "Weapon and Apparel Quality Indicators";
        }
    }
}
