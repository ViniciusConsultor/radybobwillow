using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Com.GainWinSoft.Common.Control.XAccordionPanel
{
	/// <summary>
	/// Baseclass for a office2007 styled colortable.
	/// </summary>
	/// <copyright>Copyright © 2008 Uwe Eichkorn
    /// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
    /// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
    /// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
    /// PURPOSE. IT CAN BE DISTRIBUTED FREE OF CHARGE AS LONG AS THIS HEADER 
    /// REMAINS UNCHANGED.
    /// </copyright>
	public class PanelColorsOffice : PanelColors
    {
        #region Properties
        /// <summary>
        /// Gets the associated PanelStyle for the XAccordionPanelControls
        /// </summary>
        public override PanelStyle PanelStyle
        {
            get { return PanelStyle.Office2007; }
        }
        #endregion

        #region MethodsPublic
        /// <summary>
		/// Initialize a new instance of the PanelColorsOffice class.
        /// </summary>
        public PanelColorsOffice()
			: base()
		{
		}
        /// <summary>
		/// Initialize a new instance of the PanelColorsOffice class.
        /// </summary>
        /// <param name="basePanel">Base class for the panel or xpanderpanel control.</param>
		public PanelColorsOffice(BasePanel basePanel)
            : base(basePanel)
        {
        }
        #endregion
		
		#region MethodsProtected
		/// <summary>
		/// Initialize a color Dictionary with defined Office2007 colors
		/// </summary>
		/// <param name="rgbTable">Dictionary with defined colors</param>
		protected override void InitColors(Dictionary<KnownColors, System.Drawing.Color> rgbTable)
		{
			base.InitColors(rgbTable);
            rgbTable[KnownColors.PanelCaptionSelectedGradientBegin] = Color.FromArgb(255, 255, 220);
            rgbTable[KnownColors.PanelCaptionSelectedGradientEnd] = Color.FromArgb(247, 193, 94);
            rgbTable[KnownColors.XAccordionPanelPanelCheckedCaptionBegin] = Color.FromArgb(255, 217, 170);
            rgbTable[KnownColors.XAccordionPanelPanelCheckedCaptionEnd] = Color.FromArgb(254, 225, 122);
            rgbTable[KnownColors.XAccordionPanelPanelCheckedCaptionMiddle] = Color.FromArgb(255, 171, 63);
            rgbTable[KnownColors.XAccordionPanelPanelPressedCaptionBegin] = Color.FromArgb(255, 189, 105);
            rgbTable[KnownColors.XAccordionPanelPanelPressedCaptionEnd] = Color.FromArgb(254, 211, 100);
            rgbTable[KnownColors.XAccordionPanelPanelPressedCaptionMiddle] = Color.FromArgb(251, 140, 60);
            rgbTable[KnownColors.XAccordionPanelPanelSelectedCaptionBegin] = Color.FromArgb(255, 252, 222);
			rgbTable[KnownColors.XAccordionPanelPanelSelectedCaptionEnd] = Color.FromArgb(255, 230, 158);
			rgbTable[KnownColors.XAccordionPanelPanelSelectedCaptionMiddle] = Color.FromArgb(255, 215, 103);
			rgbTable[KnownColors.XAccordionPanelPanelSelectedCaptionText] = Color.Black;
		}
		#endregion
	}
}
