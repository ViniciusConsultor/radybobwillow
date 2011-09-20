using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Com.GainWinSoft.Common.Control.XAccordionPanel
{
    /// <summary>
    /// Provides <see cref="Color"/> structures that are colors of a Panel or XAccordionPanelPanel display element.
    /// </summary>
    /// <copyright>Copyright ?2006-2008 Uwe Eichkorn
    /// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
    /// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
    /// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
    /// PURPOSE. IT CAN BE DISTRIBUTED FREE OF CHARGE AS LONG AS THIS HEADER 
    /// REMAINS UNCHANGED.
    /// </copyright>
    public class PanelColors
    {
		#region Enums
		/// <summary>
		/// Gets or sets the KnownColors appearance of the ProfessionalColorTable.
		/// </summary>
		public enum KnownColors
		{
			/// <summary>
			/// The border color of the panel.
			/// </summary>
			BorderColor,
			/// <summary>
			/// The forecolor of a close icon in a Panel.
			/// </summary>
            PanelCaptionCloseIcon,
            /// <summary>
			/// The forecolor of a expand icon in a Panel.
            /// </summary>
			PanelCaptionExpandIcon,
			/// <summary>
			/// The starting color of the gradient of the Panel.
			/// </summary>
            PanelCaptionGradientBegin,
			/// <summary>
			/// The end color of the gradient of the Panel.
			/// </summary>
			PanelCaptionGradientEnd,
			/// <summary>
			/// The middle color of the gradient of the Panel.
			/// </summary>
			PanelCaptionGradientMiddle,
            /// <summary>
            /// The starting color of the gradient used when the hover icon in the captionbar on the Panel is selected.
            /// </summary>
            PanelCaptionSelectedGradientBegin,
            /// <summary>
            /// The end color of the gradient used when the hover icon in the captionbar on the Panel is selected.
            /// </summary>
            PanelCaptionSelectedGradientEnd,
			/// <summary>
			/// The starting color of the gradient used in the Panel.
			/// </summary>
			PanelContentGradientBegin,
			/// <summary>
			/// The end color of the gradient used in the Panel.
			/// </summary>
			PanelContentGradientEnd,
			/// <summary>
			/// The text color of a Panel.
			/// </summary>
			PanelCaptionText,
			/// <summary>
			/// The text color of a Panel when it's collapsed.
			/// </summary>
            PanelCollapsedCaptionText,
			/// <summary>
			/// The inner border color of a Panel.
			/// </summary>
			InnerBorderColor,
			/// <summary>
			/// The backcolor of a XAccordionPanelPanel.
			/// </summary>
            XAccordionPanelPanelBackColor,
			/// <summary>
			/// The forecolor of a close icon in a XAccordionPanelPanel.
			/// </summary>
			XAccordionPanelPanelCaptionCloseIcon,
			/// <summary>
			/// The forecolor of a expand icon in a XAccordionPanelPanel.
			/// </summary>
			XAccordionPanelPanelCaptionExpandIcon,
			/// <summary>
			/// The text color of a XAccordionPanelPanel.
			/// </summary>
			XAccordionPanelPanelCaptionText,
			/// <summary>
			/// The starting color of the gradient of the XAccordionPanelPanel.
			/// </summary>
			XAccordionPanelPanelCaptionGradientBegin,
			/// <summary>
			/// The end color of the gradient of the XAccordionPanelPanel.
			/// </summary>
			XAccordionPanelPanelCaptionGradientEnd,
			/// <summary>
			/// The middle color of the gradient of the XAccordionPanelPanel.
			/// </summary>
			XAccordionPanelPanelCaptionGradientMiddle,
            /// <summary>
            /// The starting color of the gradient of a flat XAccordionPanelPanel.
            /// </summary>
            XAccordionPanelPanelFlatCaptionGradientBegin,
            /// <summary>
            /// The end color of the gradient of a flat XAccordionPanelPanel.
            /// </summary>
            XAccordionPanelPanelFlatCaptionGradientEnd,
            /// <summary>
            /// The starting color of the gradient used when the XAccordionPanelPanel is pressed down.
            /// </summary>
            XAccordionPanelPanelPressedCaptionBegin,
            /// <summary>
            /// The end color of the gradient used when the XAccordionPanelPanel is pressed down.
            /// </summary>
            XAccordionPanelPanelPressedCaptionEnd,
            /// <summary>
            /// The middle color of the gradient used when the XAccordionPanelPanel is pressed down.
            /// </summary>
            XAccordionPanelPanelPressedCaptionMiddle,
            /// <summary>
            /// The starting color of the gradient used when the XAccordionPanelPanel is checked.
            /// </summary>
            XAccordionPanelPanelCheckedCaptionBegin,
            /// <summary>
            /// The end color of the gradient used when the XAccordionPanelPanel is checked.
            /// </summary>
            XAccordionPanelPanelCheckedCaptionEnd,
            /// <summary>
            /// The middle color of the gradient used when the XAccordionPanelPanel is checked.
            /// </summary>
            XAccordionPanelPanelCheckedCaptionMiddle,
            /// <summary>
			/// The starting color of the gradient used when the XAccordionPanelPanel is selected.
			/// </summary>
			XAccordionPanelPanelSelectedCaptionBegin,
			/// <summary>
			/// The end color of the gradient used when the XAccordionPanelPanel is selected.
			/// </summary>
			XAccordionPanelPanelSelectedCaptionEnd,
			/// <summary>
			/// The middle color of the gradient used when the XAccordionPanelPanel is selected.
			/// </summary>
			XAccordionPanelPanelSelectedCaptionMiddle,
			/// <summary>
			/// The text color used when the XAccordionPanelPanel is selected.
			/// </summary>
			XAccordionPanelPanelSelectedCaptionText
		}
		#endregion

        #region FieldsPrivate

        private BasePanel m_basePanel;
		private System.Windows.Forms.ProfessionalColorTable m_professionalColorTable;
		private Dictionary<KnownColors, Color> m_dictionaryRGBTable;
		private bool m_bUseSystemColors;

        #endregion

        #region Properties
        /// <summary>
        /// Gets the border color of a Panel or XAccordionPanelPanel.
        /// </summary>
        public virtual Color BorderColor
        {
			get { return this.FromKnownColor(KnownColors.BorderColor); }
        }
        /// <summary>
        /// Gets the forecolor of a close icon in a Panel.
        /// </summary>
        public virtual Color PanelCaptionCloseIcon
        {
            get { return this.FromKnownColor(KnownColors.PanelCaptionCloseIcon); }
        }
        /// <summary>
        /// Gets the forecolor of an expand icon in a Panel.
        /// </summary>
        public virtual Color PanelCaptionExpandIcon
        {
            get { return this.FromKnownColor(KnownColors.PanelCaptionExpandIcon); }
        }
        /// <summary>
        /// Gets the starting color of the gradient of the Panel.
        /// </summary>
        public virtual Color PanelCaptionGradientBegin
        {
			get { return this.FromKnownColor(KnownColors.PanelCaptionGradientBegin); }
        }
		/// <summary>
        /// Gets the end color of the gradient of the Panel.
        /// </summary>
        public virtual Color PanelCaptionGradientEnd
        {
            get { return this.FromKnownColor(KnownColors.PanelCaptionGradientEnd); }
        }
		/// <summary>
        /// Gets the middle color of the gradient of the Panel.
        /// </summary>
        public virtual Color PanelCaptionGradientMiddle
        {
			get { return this.FromKnownColor(KnownColors.PanelCaptionGradientMiddle); }
        }
        /// <summary>
        /// Gets the starting color of the gradient used when the hover icon in the captionbar on the Panel is selected.
        /// </summary>
        public virtual Color PanelCaptionSelectedGradientBegin
        {
            get { return this.FromKnownColor(KnownColors.PanelCaptionSelectedGradientBegin); }
        }
        /// <summary>
        /// Gets the end color of the gradient used when the hover icon in the captionbar on the Panel is selected.
        /// </summary>
        public virtual Color PanelCaptionSelectedGradientEnd
        {
            get { return this.FromKnownColor(KnownColors.PanelCaptionSelectedGradientEnd); }
        }
        /// <summary>
        /// Gets the text color of a Panel.
        /// </summary>
        public virtual Color PanelCaptionText
		{
			get { return this.FromKnownColor(KnownColors.PanelCaptionText); }
		}
        /// <summary>
        /// Gets the text color of a Panel when it's collapsed.
        /// </summary>
        public virtual Color PanelCollapsedCaptionText
        {
            get { return this.FromKnownColor(KnownColors.PanelCollapsedCaptionText); }
        }
        /// <summary>
        /// Gets the starting color of the gradient used in the Panel.
        /// </summary>
        public virtual Color PanelContentGradientBegin
        {
			get { return this.FromKnownColor(KnownColors.PanelContentGradientBegin); }
        }
		/// <summary>
        /// Gets the end color of the gradient used in the Panel.
        /// </summary>
        public virtual Color PanelContentGradientEnd
        {
			get { return this.FromKnownColor(KnownColors.PanelContentGradientEnd); }
        }
        /// <summary>
        /// Gets the inner border color of a Panel.
        /// </summary>
        public virtual Color InnerBorderColor
        {
            get { return this.FromKnownColor(KnownColors.InnerBorderColor); }
        }
		/// <summary>
		/// Gets the backcolor of a XAccordionPanelPanel.
		/// </summary>
        public virtual Color XAccordionPanelPanelBackColor
		{
			get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelBackColor); }
		}
        /// <summary>
		/// Gets the forecolor of a close icon in a XAccordionPanelPanel.
		/// </summary>
        public virtual Color XAccordionPanelPanelCaptionCloseIcon
		{
			get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelCaptionCloseIcon); }
		}
        /// <summary>
		/// Gets the forecolor of an expand icon in a XAccordionPanelPanel.
		/// </summary>
        public virtual Color XAccordionPanelPanelCaptionExpandIcon
		{
			get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelCaptionExpandIcon); }
		}
        /// <summary>
        /// Gets the starting color of the gradient of the XAccordionPanelPanel.
        /// </summary>
        public virtual Color XAccordionPanelPanelCaptionGradientBegin
        {
            get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelCaptionGradientBegin); }
        }
        /// <summary>
        /// Gets the end color of the gradient of the XAccordionPanelPanel.
        /// </summary>
        public virtual Color XAccordionPanelPanelCaptionGradientEnd
        {
            get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelCaptionGradientEnd); }
        }
        /// <summary>
        /// Gets the middle color of the gradient on the XAccordionPanelPanel captionbar.
        /// </summary>
        public virtual Color XAccordionPanelPanelCaptionGradientMiddle
        {
            get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelCaptionGradientMiddle); }
        }
        /// <summary>
        /// Gets the text color of a XAccordionPanelPanel.
        /// </summary>
        public virtual Color XAccordionPanelPanelCaptionText
        {
			get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelCaptionText); }
        }
        /// <summary>
        /// Gets the starting color of the gradient on a flat XAccordionPanelPanel captionbar.
        /// </summary>
        public virtual Color XAccordionPanelPanelFlatCaptionGradientBegin
        {
            get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelFlatCaptionGradientBegin); }
        }
        /// <summary>
        /// Gets the end color of the gradient on a flat XAccordionPanelPanel captionbar.
        /// </summary>
        public virtual Color XAccordionPanelPanelFlatCaptionGradientEnd
        {
            get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelFlatCaptionGradientEnd); }
        }
        /// <summary>
        /// Gets the starting color of the gradient used when the XAccordionPanelPanel is pressed down.
        /// </summary>
        public virtual Color XAccordionPanelPanelPressedCaptionBegin
        {
            get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelPressedCaptionBegin); }
        }
        /// <summary>
        /// Gets the end color of the gradient used when the XAccordionPanelPanel is pressed down.
        /// </summary>
        public virtual Color XAccordionPanelPanelPressedCaptionEnd
        {
            get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelPressedCaptionEnd); }
        }
        /// <summary>
        /// Gets the middle color of the gradient used when the XAccordionPanelPanel is pressed down.
        /// </summary>
        public virtual Color XAccordionPanelPanelPressedCaptionMiddle
        {
            get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelPressedCaptionMiddle); }
        }
        /// <summary>
        /// Gets the starting color of the gradient used when the XAccordionPanelPanel is checked.
        /// </summary>
        public virtual Color XAccordionPanelPanelCheckedCaptionBegin
        {
            get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelCheckedCaptionBegin); }
        }
        /// <summary>
        /// Gets the end color of the gradient used when the XAccordionPanelPanel is checked.
        /// </summary>
        public virtual Color XAccordionPanelPanelCheckedCaptionEnd
        {
            get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelCheckedCaptionEnd); }
        }
        /// <summary>
        /// Gets the middle color of the gradient used when the XAccordionPanelPanel is checked.
        /// </summary>
        public virtual Color XAccordionPanelPanelCheckedCaptionMiddle
        {
            get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelCheckedCaptionMiddle); }
        }
        /// <summary>
        /// Gets the starting color of the gradient used when the XAccordionPanelPanel is selected.
        /// </summary>
        public virtual Color XAccordionPanelPanelSelectedCaptionBegin
        {
			get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelSelectedCaptionBegin); }
        }
        /// <summary>
        /// Gets the end color of the gradient used when the XAccordionPanelPanel is selected.
        /// </summary>
        public virtual Color XAccordionPanelPanelSelectedCaptionEnd
        {
			get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelSelectedCaptionEnd); }
        }
        /// <summary>
        /// Gets the middle color of the gradient used when the XAccordionPanelPanel is selected.
        /// </summary>
        public virtual Color XAccordionPanelPanelSelectedCaptionMiddle
        {
			get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelSelectedCaptionMiddle); }
        }
        /// <summary>
        /// Gets the text color used when the XAccordionPanelPanel is selected.
        /// </summary>
        public virtual Color XAccordionPanelPanelSelectedCaptionText
        {
			get { return this.FromKnownColor(KnownColors.XAccordionPanelPanelSelectedCaptionText); }
        }
        /// <summary>
        /// Gets the associated PanelStyle for the XAccordionPanelControls
        /// </summary>
        public virtual PanelStyle PanelStyle
        {
            get { return PanelStyle.Default; }
        }
		/// <summary>
		/// Gets or sets a value indicating whether to use System.Drawing.SystemColors rather than colors that match the current visual style.
		/// </summary>
        public bool UseSystemColors
		{
			get { return this.m_bUseSystemColors; }
			set
			{
				if (value.Equals(this.m_bUseSystemColors) == false)
				{
					this.m_bUseSystemColors = value;
					this.m_professionalColorTable.UseSystemColors = this.m_bUseSystemColors;
                    Clear();
				}
			}
		}
        /// <summary>
        /// Gets or sets the panel or xpanderpanel
        /// </summary>
        public BasePanel Panel
		{
			get { return this.m_basePanel; }
			set { this.m_basePanel = value; }
		}
		internal Color FromKnownColor(KnownColors color)
		{
			return (Color)this.ColorTable[color];
		}
        private Dictionary<KnownColors, Color> ColorTable
        {
            get
            {
                if (this.m_dictionaryRGBTable == null)
                {
                    this.m_dictionaryRGBTable = new Dictionary<KnownColors, Color>(0xd4);
                    if ((this.m_basePanel != null) && (this.m_basePanel.ColorScheme == ColorScheme.Professional))
                    {
                        if ((this.m_bUseSystemColors == true) || (ToolStripManager.VisualStylesEnabled == false))
                        {
                            InitBaseColors(this.m_dictionaryRGBTable);
                        }
                        else
                        {
                            InitColors(this.m_dictionaryRGBTable);
                        }
                    }
                    else
                    {
                        InitCustomColors(this.m_dictionaryRGBTable);
                    }
                }
                return this.m_dictionaryRGBTable;
            }
        }

        #endregion

        #region MethodsPublic
		/// <summary>
		/// Initializes a new instance of the PanelColors class.
		/// </summary>
		public PanelColors()
		{
			this.m_professionalColorTable = new System.Windows.Forms.ProfessionalColorTable();
		}
		/// <summary>
        /// Initialize a new instance of the PanelColors class.
        /// </summary>
        /// <param name="basePanel">Base class for the panel or xpanderpanel control.</param>
        public PanelColors(BasePanel basePanel) : this()
        {
            this.m_basePanel = basePanel;
        }
        /// <summary>
        /// Clears the current color table
        /// </summary>
		public void Clear()
        {
            ResetRGBTable();
        }
        #endregion

		#region MethodsProtected
		/// <summary>
		/// Initialize a color Dictionary with defined colors
		/// </summary>
		/// <param name="rgbTable">Dictionary with defined colors</param>
		protected virtual void InitColors(Dictionary<KnownColors, Color> rgbTable)
		{
			InitBaseColors(rgbTable);
		}
		#endregion

        #region MethodsPrivate

		private void InitBaseColors(Dictionary<KnownColors, Color> rgbTable)
		{
            rgbTable[KnownColors.BorderColor] = this.m_professionalColorTable.GripDark;
            rgbTable[KnownColors.InnerBorderColor] = this.m_professionalColorTable.GripLight;
            rgbTable[KnownColors.PanelCaptionCloseIcon] = SystemColors.ControlText;
            rgbTable[KnownColors.PanelCaptionExpandIcon] = SystemColors.ControlText;
            rgbTable[KnownColors.PanelCaptionGradientBegin] = this.m_professionalColorTable.ToolStripGradientBegin;
            rgbTable[KnownColors.PanelCaptionGradientEnd] = this.m_professionalColorTable.ToolStripGradientEnd;
            rgbTable[KnownColors.PanelCaptionGradientMiddle] = this.m_professionalColorTable.ToolStripGradientMiddle;
            rgbTable[KnownColors.PanelCaptionSelectedGradientBegin] = this.m_professionalColorTable.ButtonSelectedGradientBegin;
            rgbTable[KnownColors.PanelCaptionSelectedGradientEnd] = this.m_professionalColorTable.ButtonSelectedGradientEnd;
            rgbTable[KnownColors.PanelContentGradientBegin] = this.m_professionalColorTable.ToolStripContentPanelGradientBegin;
			rgbTable[KnownColors.PanelContentGradientEnd] = this.m_professionalColorTable.ToolStripContentPanelGradientEnd;
			rgbTable[KnownColors.PanelCaptionText] = SystemColors.ControlText;
            rgbTable[KnownColors.PanelCollapsedCaptionText] = SystemColors.ControlText;
			rgbTable[KnownColors.XAccordionPanelPanelBackColor] = this.m_professionalColorTable.ToolStripContentPanelGradientBegin;
			rgbTable[KnownColors.XAccordionPanelPanelCaptionCloseIcon] = SystemColors.ControlText;
			rgbTable[KnownColors.XAccordionPanelPanelCaptionExpandIcon] = SystemColors.ControlText;
			rgbTable[KnownColors.XAccordionPanelPanelCaptionText] = SystemColors.ControlText;
			rgbTable[KnownColors.XAccordionPanelPanelCaptionGradientBegin] = this.m_professionalColorTable.ToolStripGradientBegin;
			rgbTable[KnownColors.XAccordionPanelPanelCaptionGradientEnd] = this.m_professionalColorTable.ToolStripGradientEnd;
			rgbTable[KnownColors.XAccordionPanelPanelCaptionGradientMiddle] = this.m_professionalColorTable.ToolStripGradientMiddle;
            rgbTable[KnownColors.XAccordionPanelPanelFlatCaptionGradientBegin] = this.m_professionalColorTable.ToolStripGradientMiddle;
            rgbTable[KnownColors.XAccordionPanelPanelFlatCaptionGradientEnd] = this.m_professionalColorTable.ToolStripGradientBegin;
            rgbTable[KnownColors.XAccordionPanelPanelPressedCaptionBegin] = this.m_professionalColorTable.ButtonPressedGradientBegin;
            rgbTable[KnownColors.XAccordionPanelPanelPressedCaptionEnd] = this.m_professionalColorTable.ButtonPressedGradientEnd;
            rgbTable[KnownColors.XAccordionPanelPanelPressedCaptionMiddle] = this.m_professionalColorTable.ButtonPressedGradientMiddle;
            rgbTable[KnownColors.XAccordionPanelPanelCheckedCaptionBegin] = this.m_professionalColorTable.ButtonCheckedGradientBegin;
            rgbTable[KnownColors.XAccordionPanelPanelCheckedCaptionEnd] = this.m_professionalColorTable.ButtonCheckedGradientEnd;
            rgbTable[KnownColors.XAccordionPanelPanelCheckedCaptionMiddle] = this.m_professionalColorTable.ButtonCheckedGradientMiddle;
            rgbTable[KnownColors.XAccordionPanelPanelSelectedCaptionBegin] = this.m_professionalColorTable.ButtonSelectedGradientBegin;
            rgbTable[KnownColors.XAccordionPanelPanelSelectedCaptionEnd] = this.m_professionalColorTable.ButtonSelectedGradientEnd;
            rgbTable[KnownColors.XAccordionPanelPanelSelectedCaptionMiddle] = this.m_professionalColorTable.ButtonSelectedGradientMiddle;
			rgbTable[KnownColors.XAccordionPanelPanelSelectedCaptionText] = SystemColors.ControlText;
		}

		private void InitCustomColors(Dictionary<KnownColors, Color> rgbTable)
		{
            Panel panel = this.m_basePanel as Panel;
            if (panel != null)
            {
                rgbTable[KnownColors.BorderColor] = panel.CustomColors.BorderColor;
                rgbTable[KnownColors.InnerBorderColor] = panel.CustomColors.InnerBorderColor;
                rgbTable[KnownColors.PanelCaptionCloseIcon] = panel.CustomColors.CaptionCloseIcon;
                rgbTable[KnownColors.PanelCaptionExpandIcon] = panel.CustomColors.CaptionExpandIcon;
                rgbTable[KnownColors.PanelCaptionGradientBegin] = panel.CustomColors.CaptionGradientBegin;
                rgbTable[KnownColors.PanelCaptionGradientEnd] = panel.CustomColors.CaptionGradientEnd;
                rgbTable[KnownColors.PanelCaptionGradientMiddle] = panel.CustomColors.CaptionGradientMiddle;
                rgbTable[KnownColors.PanelCaptionSelectedGradientBegin] = panel.CustomColors.CaptionSelectedGradientBegin;
                rgbTable[KnownColors.PanelCaptionSelectedGradientEnd] = panel.CustomColors.CaptionSelectedGradientEnd;
                rgbTable[KnownColors.PanelContentGradientBegin] = panel.CustomColors.ContentGradientBegin;
                rgbTable[KnownColors.PanelContentGradientEnd] = panel.CustomColors.ContentGradientEnd;
                rgbTable[KnownColors.PanelCaptionText] = panel.CustomColors.CaptionText;
                rgbTable[KnownColors.PanelCollapsedCaptionText] = panel.CustomColors.CollapsedCaptionText;
            }

			XAccordionPanelPanel xpanderPanel = this.m_basePanel as XAccordionPanelPanel;
			if (xpanderPanel != null)
			{
                rgbTable[KnownColors.BorderColor] = xpanderPanel.CustomColors.BorderColor;
                rgbTable[KnownColors.InnerBorderColor] = xpanderPanel.CustomColors.InnerBorderColor;
                rgbTable[KnownColors.XAccordionPanelPanelBackColor] = xpanderPanel.CustomColors.BackColor;
                rgbTable[KnownColors.XAccordionPanelPanelCaptionCloseIcon] = xpanderPanel.CustomColors.CaptionCloseIcon;
                rgbTable[KnownColors.XAccordionPanelPanelCaptionExpandIcon] = xpanderPanel.CustomColors.CaptionExpandIcon;
				rgbTable[KnownColors.XAccordionPanelPanelCaptionText] = xpanderPanel.CustomColors.CaptionText;
				rgbTable[KnownColors.XAccordionPanelPanelCaptionGradientBegin] = xpanderPanel.CustomColors.CaptionGradientBegin;
				rgbTable[KnownColors.XAccordionPanelPanelCaptionGradientEnd] = xpanderPanel.CustomColors.CaptionGradientEnd;
				rgbTable[KnownColors.XAccordionPanelPanelCaptionGradientMiddle] = xpanderPanel.CustomColors.CaptionGradientMiddle;
                rgbTable[KnownColors.XAccordionPanelPanelFlatCaptionGradientBegin] = xpanderPanel.CustomColors.FlatCaptionGradientBegin;
                rgbTable[KnownColors.XAccordionPanelPanelFlatCaptionGradientEnd] = xpanderPanel.CustomColors.FlatCaptionGradientEnd;
                rgbTable[KnownColors.XAccordionPanelPanelPressedCaptionBegin] = xpanderPanel.CustomColors.CaptionPressedGradientBegin;
                rgbTable[KnownColors.XAccordionPanelPanelPressedCaptionEnd] = xpanderPanel.CustomColors.CaptionPressedGradientEnd;
                rgbTable[KnownColors.XAccordionPanelPanelPressedCaptionMiddle] = xpanderPanel.CustomColors.CaptionPressedGradientMiddle;
                rgbTable[KnownColors.XAccordionPanelPanelCheckedCaptionBegin] = xpanderPanel.CustomColors.CaptionCheckedGradientBegin;
                rgbTable[KnownColors.XAccordionPanelPanelCheckedCaptionEnd] = xpanderPanel.CustomColors.CaptionCheckedGradientEnd;
                rgbTable[KnownColors.XAccordionPanelPanelCheckedCaptionMiddle] = xpanderPanel.CustomColors.CaptionCheckedGradientMiddle;
                rgbTable[KnownColors.XAccordionPanelPanelSelectedCaptionBegin] = xpanderPanel.CustomColors.CaptionSelectedGradientBegin;
				rgbTable[KnownColors.XAccordionPanelPanelSelectedCaptionEnd] = xpanderPanel.CustomColors.CaptionSelectedGradientEnd;
				rgbTable[KnownColors.XAccordionPanelPanelSelectedCaptionMiddle] = xpanderPanel.CustomColors.CaptionSelectedGradientMiddle;
				rgbTable[KnownColors.XAccordionPanelPanelSelectedCaptionText] = xpanderPanel.CustomColors.CaptionSelectedText;
			}
		}

        private void ResetRGBTable()
        {
            if (this.m_dictionaryRGBTable != null)
            {
                this.m_dictionaryRGBTable.Clear();
            }
            this.m_dictionaryRGBTable = null;
        }

        #endregion
    }
}
