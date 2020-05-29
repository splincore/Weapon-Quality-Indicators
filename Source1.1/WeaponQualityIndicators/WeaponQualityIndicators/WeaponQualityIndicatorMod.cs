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
            listingStandard.Label("Indicator width");
            Rect rect1 = listingStandard.GetRect(22f);
            weaponQualityIndicatorModSettings.xDrawSize = Widgets.HorizontalSlider(rect1, weaponQualityIndicatorModSettings.xDrawSize, 0f, 5f, false, (weaponQualityIndicatorModSettings.xDrawSize).ToString("") + "", "0", "5", 0.1f);

            listingStandard.Gap(listingStandard.verticalSpacing);
            listingStandard.Label("Indicator length");
            Rect rect2 = listingStandard.GetRect(22f);
            weaponQualityIndicatorModSettings.yDrawSize = Widgets.HorizontalSlider(rect2, weaponQualityIndicatorModSettings.yDrawSize, 0f, 5f, false, (weaponQualityIndicatorModSettings.yDrawSize).ToString("") + "", "0", "5", 0.1f);

            listingStandard.Gap(listingStandard.verticalSpacing);
            listingStandard.CheckboxLabeled("Show graphic indicator", ref weaponQualityIndicatorModSettings.renderGraphicIndicator);

            listingStandard.Gap(listingStandard.verticalSpacing);
            listingStandard.CheckboxLabeled("Change quality color in description card", ref weaponQualityIndicatorModSettings.changeInspectorCardColor);

            listingStandard.Gap(listingStandard.verticalSpacing);
            listingStandard.CheckboxLabeled("Change label color on ground", ref weaponQualityIndicatorModSettings.changeShortLabelColor);

            listingStandard.End();

            ModSettingGetter.GetSettings();
        }

        public override string SettingsCategory()
        {
            return "Weapon and Apparel Quality Indicators";
        }
    }
}
