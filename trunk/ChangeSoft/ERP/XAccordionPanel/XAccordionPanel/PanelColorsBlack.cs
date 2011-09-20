using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Com.GainWinSoft.Common.Control.XAccordionPanel
{
    /// <summary>
    /// Provide black theme colors for a Panel or XAccordionPanelPanel display element.
    /// </summary>
    /// <copyright>Copyright ?2006-2008 Uwe Eichkorn
    /// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
    /// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
    /// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
    /// PURPOSE. IT CAN BE DISTRIBUTED FREE OF CHARGE AS LONG AS THIS HEADER 
    /// REMAINS UNCHANGED.
    /// </copyright>
    public class PanelColorsBlack : PanelColorsBse
    {
		#region FieldsPrivate
		#endregion

		#region Properties
        #endregion

        #region MethodsPublic
        /// <summary>
        /// Initialize a new instance of the PanelColorsBlack class.
        /// </summary>
        public PanelColorsBlack()
			: base()
		{
		}
        /// <summary>
        /// Initialize a new instance of the PanelColorsBlack class.
        /// </summary>
        /// <param name="basePanel">Base class for the panel or xpanderpanel control.</param>
        public PanelColorsBlack(BasePanel basePanel)
            : base(basePanel)
        {
        }

        #endregion

        #region MethodsProtected
        /// <summary>
        /// Initialize a color Dictionary with defined colors
        /// </summary>
        /// <param name="rgbTable">Dictionary with defined colors</param>
        protected override void InitColors(Dictionary<PanelColors.KnownColors, Color> rgbTable)
        {
            base.InitColors(rgbTable);
            rgbTable[KnownColors.BorderColor] = Color.FromArgb(0, 0, 0);
            rgbTable[KnownColors.PanelCaptionCloseIcon] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColors.PanelCaptionExpandIcon] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColors.PanelCaptionGradientBegin] = Color.FromArgb(122, 122, 122);
            rgbTable[KnownColors.PanelCaptionGradientEnd] = Color.FromArgb(0, 0, 0);
            rgbTable[KnownColors.PanelCaptionGradientMiddle] = Color.FromArgb(80, 80, 80);
            rgbTable[KnownColors.PanelContentGradientBegin] = Color.FromArgb(240, 241, 242);
            rgbTable[KnownColors.PanelContentGradientEnd] = Color.FromArgb(240, 241, 242);
            rgbTable[KnownColors.PanelCaptionText] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColors.PanelCollapsedCaptionText] = Color.FromArgb(0, 0, 0);
            rgbTable[KnownColors.InnerBorderColor] = Color.FromArgb(185, 185, 185);
            rgbTable[KnownColors.XAccordionPanelPanelBackColor] = Color.FromArgb(240, 241, 242);
            rgbTable[KnownColors.XAccordionPanelPanelCaptionCloseIcon] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColors.XAccordionPanelPanelCaptionExpandIcon] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColors.XAccordionPanelPanelCaptionText] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColors.XAccordionPanelPanelCaptionGradientBegin] = Color.FromArgb(155, 155, 155);
            rgbTable[KnownColors.XAccordionPanelPanelCaptionGradientEnd] = Color.FromArgb(47, 47, 47);
            rgbTable[KnownColors.XAccordionPanelPanelCaptionGradientMiddle] = Color.FromArgb(0, 0, 0);
            rgbTable[KnownColors.XAccordionPanelPanelFlatCaptionGradientBegin] = Color.FromArgb(90, 90, 90);
            rgbTable[KnownColors.XAccordionPanelPanelFlatCaptionGradientEnd] = Color.FromArgb(155, 155, 155);
        }

        #endregion

        #region MethodsPrivate
        #endregion
    }
}
