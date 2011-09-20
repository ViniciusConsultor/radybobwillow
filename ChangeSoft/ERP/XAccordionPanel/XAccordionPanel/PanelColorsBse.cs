using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Com.GainWinSoft.Common.Control.XAccordionPanel
{
	/// <summary>
	/// Baseclass for a bse styled colortable.
	/// </summary>
	/// <copyright>Copyright © 2008 Uwe Eichkorn
    /// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
    /// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
    /// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
    /// PURPOSE. IT CAN BE DISTRIBUTED FREE OF CHARGE AS LONG AS THIS HEADER 
    /// REMAINS UNCHANGED.
    /// </copyright>
	public class PanelColorsBse : PanelColors
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
		/// Initialize a new instance of the PanelColorsBse class.
        /// </summary>
        public PanelColorsBse()
			: base()
		{
		}
        /// <summary>
		/// Initialize a new instance of the PanelColorsBse class.
        /// </summary>
        /// <param name="basePanel">Base class for the panel or xpanderpanel control.</param>
        public PanelColorsBse(BasePanel basePanel)
            : base(basePanel)
        {
        }
        #endregion
		
		#region MethodsProtected
		/// <summary>
		/// Initialize a color Dictionary with defined Bse colors
		/// </summary>
		/// <param name="rgbTable">Dictionary with defined colors</param>
		protected override void InitColors(Dictionary<KnownColors, System.Drawing.Color> rgbTable)
		{
			base.InitColors(rgbTable);
            rgbTable[KnownColors.PanelCaptionSelectedGradientBegin] = Color.FromArgb(156, 163, 254);
            rgbTable[KnownColors.PanelCaptionSelectedGradientEnd] = Color.FromArgb(90, 98, 254);
            rgbTable[KnownColors.XAccordionPanelPanelCheckedCaptionBegin] = Color.FromArgb(136, 144, 254);
            rgbTable[KnownColors.XAccordionPanelPanelCheckedCaptionEnd] = Color.FromArgb(111, 145, 255);
            rgbTable[KnownColors.XAccordionPanelPanelCheckedCaptionMiddle] = Color.FromArgb(42, 52, 254);
            rgbTable[KnownColors.XAccordionPanelPanelPressedCaptionBegin] = Color.FromArgb(106, 109, 228);
            rgbTable[KnownColors.XAccordionPanelPanelPressedCaptionEnd] = Color.FromArgb(88, 111, 226);
            rgbTable[KnownColors.XAccordionPanelPanelPressedCaptionMiddle] = Color.FromArgb(39, 39, 217);
            rgbTable[KnownColors.XAccordionPanelPanelSelectedCaptionBegin] = Color.FromArgb(156, 163, 254);
            rgbTable[KnownColors.XAccordionPanelPanelSelectedCaptionEnd] = Color.FromArgb(139, 164, 255);
            rgbTable[KnownColors.XAccordionPanelPanelSelectedCaptionMiddle] = Color.FromArgb(90, 98, 254);
            rgbTable[KnownColors.XAccordionPanelPanelSelectedCaptionText] = Color.White;
		}
		#endregion
	}
}
