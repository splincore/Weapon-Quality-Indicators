using System;
using UnityEngine;
using Verse;
using System.Globalization;

namespace WeaponQualityIndicators
{
    public class ColorChangeWindow : Window
    {
        public override Vector2 InitialSize
        {
            get
            {
                return this.WindowSize;
            }
        }
        protected Vector2 WindowSize = new Vector2(600f, 500f); // Border Size is 18

        private string quality = "";
        private string qualityColor = "";
        private string defaultQualityColor = "";
        private float colorR;
        private float colorG;
        private float colorB;

        public ColorChangeWindow(string tmpQuality, string tmpQualityColor, string tmpDefaultQualityColor)
        {
            quality = tmpQuality;
            qualityColor = tmpQualityColor;
            defaultQualityColor = tmpDefaultQualityColor;
            SetRGBColors();
        }

        public override void DoWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);
            listingStandard.Label(string.Format("{0} {1}{2}</color>", "WeaponQualityIndicatorChangeColor".Translate(), qualityColor, ("QualityCategory_" + quality.CapitalizeFirst()).Translate()));

            listingStandard.Gap(10f);
            listingStandard.Label(string.Format("<color=#FF0000>{0}</color>", "WeaponQualityIndicatorRed".Translate()));
            Rect rectR = listingStandard.GetRect(22f);
            colorR = Widgets.HorizontalSlider(rectR, colorR, 0f, 255f, false, colorR.ToString(), "0", "255", 1f);

            listingStandard.Gap(10f);
            listingStandard.Label(string.Format("<color=#00FF00>{0}</color>", "WeaponQualityIndicatorGreen".Translate()));
            Rect rectG = listingStandard.GetRect(22f);
            colorG = Widgets.HorizontalSlider(rectG, colorG, 0f, 255f, false, colorG.ToString(), "0", "255", 1f);

            listingStandard.Gap(10f);
            listingStandard.Label(string.Format("<color=#0000FF>{0}</color>", "WeaponQualityIndicatorBlue".Translate()));
            Rect rectB = listingStandard.GetRect(22f);
            colorB = Widgets.HorizontalSlider(rectB, colorB, 0f, 255f, false, colorB.ToString(), "0", "255", 1f);

            listingStandard.Gap(10f);
            if (listingStandard.ButtonText("WeaponQualityIndicatorResetDefault".Translate()))
            {
                qualityColor = defaultQualityColor;
                SetRGBColors();
            }
            listingStandard.End();

            qualityColor = "<color=#" + String.Format("{0:X2}{1:X2}{2:X2}", (int)colorR, (int)colorG, (int)colorB) + ">";

            Vector2 buttonSize = new Vector2(120f, 40f);
            float positionButtonY = InitialSize.y - buttonSize.y - 36f;
            float positionOk = InitialSize.x / 2 - buttonSize.x - 5f - 18f;
            float positionCancel = positionOk + buttonSize.x + 10f;
            Rect rectOk = new Rect(positionOk, positionButtonY, buttonSize.x, buttonSize.y);
            Rect rectCancel = new Rect(positionCancel, positionButtonY, buttonSize.x, buttonSize.y);

            if (Widgets.ButtonText(rectOk, "OK".Translate()))
            {
                switch (quality)
                {
                    case "awful":
                        LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().colorAwful = qualityColor;
                        break;
                    case "poor":
                        LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().colorPoor = qualityColor;
                        break;
                    case "normal":
                        LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().colorNormal = qualityColor;
                        break;
                    case "good":
                        LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().colorGood = qualityColor;
                        break;
                    case "excellent":
                        LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().colorExcellent = qualityColor;
                        break;
                    case "masterwork":
                        LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().colorMasterwork = qualityColor;
                        break;
                    case "legendary":
                        LoadedModManager.GetMod<WeaponQualityIndicatorMod>().GetSettings<WeaponQualityIndicatorModSettings>().colorLegendary = qualityColor;
                        break;
                    default:
                        break;
                }

                this.Close(true);
                Event.current.Use();
            }
            if (Widgets.ButtonText(rectCancel, "CancelButton".Translate()))
            {
                this.Close(true);
                Event.current.Use();
            }
        }

        public void SetRGBColors()
        {
            string hexColor = qualityColor.Replace("<color=#", "").Replace(">", "");
            colorR = int.Parse(hexColor.Substring(0, 2), NumberStyles.AllowHexSpecifier);
            colorG = int.Parse(hexColor.Substring(2, 2), NumberStyles.AllowHexSpecifier);
            colorB = int.Parse(hexColor.Substring(4, 2), NumberStyles.AllowHexSpecifier);
        }

    }
}