using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Data;
using System.Windows.Forms;

using Com.GainWinSoft.Common.Control.XAccordionPanel.Properties;

namespace Com.GainWinSoft.Common.Control.XAccordionPanel
{
    #region Class XAccordionPanelPanelList
	/// <summary>
	/// Manages a related set of xpanderpanels.
	/// </summary>
    /// <remarks>
    /// The XAccordionPanelPanelList contains XAccordionPanelPanels, which are represented by XAccordionPanelPanel
    /// objects that you can add through the XAccordionPanelPanels property.
    /// The order of XAccordionPanelPanel objects reflects the order the xpanderpanels appear
    /// in the XAccordionPanelPanelList control.
    /// </remarks>
	/// <copyright>Copyright ?2006-2008 Uwe Eichkorn
    /// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
    /// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
    /// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
    /// PURPOSE. IT CAN BE DISTRIBUTED FREE OF CHARGE AS LONG AS THIS HEADER 
    /// REMAINS UNCHANGED.
    /// </copyright>
    [Designer(typeof(XAccordionPanelPanelListDesigner)),
	DesignTimeVisibleAttribute(true)]
	[ToolboxBitmap(typeof(System.Windows.Forms.Panel))]
	public partial class XAccordionPanelPanelList : ScrollableControl
    {
        #region Events
        /// <summary>
        /// The PanelStyleChanged event occurs when PanelStyle flags have been changed.
        /// </summary>
        [Description("The PanelStyleChanged event occurs when PanelStyle flags have been changed.")]
        public event EventHandler<PanelStyleChangeEventArgs> PanelStyleChanged;
        /// <summary>
        /// The CaptionStyleChanged event occurs when CaptionStyle flags have been changed.
        /// </summary>
        [Description("The CaptionStyleChanged event occurs when CaptionStyle flags have been changed.")]
        public event EventHandler<EventArgs> CaptionStyleChanged;
        /// <summary>
        /// The ColorSchemeChanged event occurs when ColorScheme flags have been changed.
        /// </summary>
        [Description("The ColorSchemeChanged event occurs when ColorScheme flags have been changed.")]
        public event EventHandler<ColorSchemeChangeEventArgs> ColorSchemeChanged;
        /// <summary>
        /// Occurs when the value of the CaptionHeight property changes.
        /// </summary>
        [Description("Occurs when the value of the CaptionHeight property changes.")]
        public event EventHandler<EventArgs> CaptionHeightChanged;
        #endregion

        #region FieldsPrivate

        private bool m_bShowBorder;
        private bool m_bShowGradientBackground;
        private bool m_bShowExpandIcon;
        private bool m_bShowCloseIcon;
        private int m_iCaptionHeight;
        private LinearGradientMode m_linearGradientMode;
        private System.Drawing.Color m_colorGradientBackground;
        private CaptionStyle m_captionStyle;
		private Com.GainWinSoft.Common.Control.XAccordionPanel.PanelStyle m_ePanelStyle;
		private Com.GainWinSoft.Common.Control.XAccordionPanel.ColorScheme m_eColorScheme;
		private XAccordionPanelPanelCollection m_xpanderPanels;
        private PanelColors m_panelColors;

		#endregion

		#region Properties
		/// <summary>
		/// Gets the collection of xpanderpanels in this xpanderpanellist.
		/// </summary>
        /// <example>The following code example creates a XAccordionPanelPanel and adds it to the XAccordionPanelPanels collection,
        /// <code>
        /// private void btnAddXAccordionPanelPanel_Click(object sender, EventArgs e)
        /// {
        ///     if (xPanderPanelList3 != null)
        ///     {
        ///         // Create and initialize a XAccordionPanelPanel.
        ///         Com.GainWinSoft.Common.Control.XAccordionPanel.XAccordionPanelPanel xpanderPanel = new Com.GainWinSoft.Common.Control.XAccordionPanel.XAccordionPanelPanel();
        ///         xpanderPanel.Text = "new XAccordionPanelPanel";
        ///         // and add it to the XAccordionPanelPanels collection
        ///         xPanderPanelList3.XAccordionPanelPanels.Add(xpanderPanel);
        ///     }
        /// }
        /// </code>
        /// </example>
		[RefreshProperties(RefreshProperties.Repaint),
		Category("Collections"),
		Browsable(true),
		Description("Collection containing all the XAccordionPanelPanels for the xpanderpanellist.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Editor(typeof(XAccordionPanelPanelCollectionEditor), typeof(UITypeEditor))]
		public XAccordionPanelPanelCollection XAccordionPanelPanels
		{
			get { return this.m_xpanderPanels; }
		}
		/// <summary>
		/// Specifies the style of the panels in this xpanderpanellist.
		/// </summary>
		[Description("Specifies the style of the xpanderpanels in this xpanderpanellist."),
		DefaultValue(Com.GainWinSoft.Common.Control.XAccordionPanel.PanelStyle.Default),
		Category("Appearance")]
		public Com.GainWinSoft.Common.Control.XAccordionPanel.PanelStyle PanelStyle
		{
			get { return this.m_ePanelStyle; }
			set
			{
                if (value != this.m_ePanelStyle)
                {
                    this.m_ePanelStyle = value;
                    OnPanelStyleChanged(this, new PanelStyleChangeEventArgs(this.m_ePanelStyle));
                }
			}
		}
        /// <summary>
        /// Gets or sets the Panelcolors table.
        /// </summary>
        public PanelColors PanelColors
        {
            get { return this.m_panelColors; }
            set { this.m_panelColors = value; }
        }
		/// <summary>
		/// Specifies the colorscheme of the xpanderpanels in the xpanderpanellist
		/// </summary>
		[Description("The colorscheme of the xpanderpanels in the xpanderpanellist")]
        [DefaultValue(Com.GainWinSoft.Common.Control.XAccordionPanel.ColorScheme.Professional)]
        [Category("Appearance")]
		public ColorScheme ColorScheme
        {
            get { return this.m_eColorScheme; }
            set
            {
                if (value != this.m_eColorScheme)
                {
                    this.m_eColorScheme = value;
                    OnColorSchemeChanged(this, new ColorSchemeChangeEventArgs(this.m_eColorScheme));
                }
            }
        }
        /// <summary>
        /// Gets or sets the style of the captionbar.
        /// </summary>
        [Description("The style of the captionbar.")]
        [Category("Appearance")]
        public CaptionStyle CaptionStyle
        {
            get { return this.m_captionStyle; }
            set
            {
                this.m_captionStyle = value;
                OnCaptionStyleChanged(this, EventArgs.Empty);
            }
        }
		/// <summary>
		/// LinearGradientMode of the background in the xpanderpanellist 
		/// </summary>
		[Description("LinearGradientMode of the background in the xpanderpanellist"),
        DefaultValue(LinearGradientMode.Vertical),
        Category("Appearance")]
        public LinearGradientMode LinearGradientMode
        {
            get { return this.m_linearGradientMode; }
            set
            {
                if (value != this.m_linearGradientMode)
                {
                    this.m_linearGradientMode = value;
                    this.Invalidate(false);
                }
            }
        }
		/// <summary>
		/// Gets or sets a value indicating whether a xpanderpanellist's gradient background is shown. 
		/// </summary>
		[Description("Gets or sets a value indicating whether a xpanderpanellist's gradient background is shown."),
        DefaultValue(false),
        Category("Appearance")]
        public bool ShowGradientBackground
        {
            get { return this.m_bShowGradientBackground; }
            set
            {
                if (value != this.m_bShowGradientBackground)
                {
                    this.m_bShowGradientBackground = value;
                    this.Invalidate(false);
                }
            }
        }
		/// <summary>
		/// Gets or sets a value indicating whether a xpanderpanellist's border is shown
		/// </summary>
		[Description("Gets or sets a value indicating whether a xpanderpanellist's border is shown"),
        DefaultValue(true),
        Category("Appearance")]
        public bool ShowBorder
        {
            get { return this.m_bShowBorder; }
            set
            {
                if (value != this.m_bShowBorder)
                {
                    this.m_bShowBorder = value;
                    foreach (XAccordionPanelPanel xpanderPanel in this.XAccordionPanelPanels)
                    {
                        xpanderPanel.ShowBorder = this.m_bShowBorder;
                    }
                    this.Invalidate(false);
                }
            }
        }
        /// <summary>
        /// Gets or sets a value indicating whether the expand icon of the xpanderpanels in this xpanderpanellist are visible.
        /// </summary>
        [Description("Gets or sets a value indicating whether the expand icon of the xpanderpanels in this xpanderpanellist are visible."),
        DefaultValue(false),
        Category("Appearance")]
        public bool ShowExpandIcon
        {
            get { return this.m_bShowExpandIcon; }
            set
            {
                if (value != this.m_bShowExpandIcon)
                {
                    this.m_bShowExpandIcon = value;
                    foreach (XAccordionPanelPanel xpanderPanel in this.XAccordionPanelPanels)
                    {
                        xpanderPanel.ShowExpandIcon = this.m_bShowExpandIcon;
                    }
                }
            }
        }
        /// <summary>
        /// Gets or sets a value indicating whether the close icon of the xpanderpanels in this xpanderpanellist are visible.
        /// </summary>
        [Description("Gets or sets a value indicating whether the close icon of the xpanderpanels in this xpanderpanellist are visible."),
        DefaultValue(false),
        Category("Appearance")]
        public bool ShowCloseIcon
        {
            get { return this.m_bShowCloseIcon ; }
            set
            {
                if (value != this.m_bShowCloseIcon)
                {
                    this.m_bShowCloseIcon = value;
                    foreach (XAccordionPanelPanel xpanderPanel in this.XAccordionPanelPanels)
                    {
                        xpanderPanel.ShowCloseIcon = this.m_bShowCloseIcon;
                    }
                }
            }
        }
		/// <summary>
		/// Gradientcolor background in this xpanderpanellist
		/// </summary>
		[Description("Gradientcolor background in this xpanderpanellist"),
        DefaultValue(false),
        Category("Appearance")]
        public System.Drawing.Color GradientBackground
        {
            get { return this.m_colorGradientBackground; }
            set
            {
                if (value != this.m_colorGradientBackground)
                {
                    this.m_colorGradientBackground = value;
                    this.Invalidate(false);
                }
            }
        }
        /// <summary>
        /// Gets or sets the height of the XpanderPanels in this XAccordionPanelPanelList. 
        /// </summary>
        [Description("Gets or sets the height of the XpanderPanels in this XAccordionPanelPanelList. "),
        DefaultValue(25),
        Category("Appearance")]
        public int CaptionHeight
        {
            get { return m_iCaptionHeight; }
            set
            {
                if (value < Constants.CaptionMinHeight)
                {
                    throw new InvalidOperationException(
                        string.Format(
                        System.Globalization.CultureInfo.CurrentUICulture,
                        Resources.IDS_InvalidOperationExceptionInteger, value, "CaptionHeight", Constants.CaptionMinHeight));
                }
                this.m_iCaptionHeight = value;
                OnCaptionHeightChanged(this, EventArgs.Empty);
            }
        }
		#endregion

		#region MethodsPublic
		/// <summary>
		/// Initializes a new instance of the XAccordionPanelPanelList class.
		/// </summary>
		public XAccordionPanelPanelList()
		{
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			SetStyle(ControlStyles.DoubleBuffer, true);
			SetStyle(ControlStyles.ResizeRedraw, false);
			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			
			InitializeComponent();

            this.m_xpanderPanels = new XAccordionPanelPanelCollection(this);
            
            this.ShowBorder = true;
            this.PanelStyle = PanelStyle.Default;
            this.LinearGradientMode = LinearGradientMode.Vertical;
            this.CaptionHeight = 25;
		}
		/// <summary>
        /// Expands the specified XAccordionPanelPanel
		/// </summary>
		/// <param name="panel">The XAccordionPanelPanel to expand</param>
        /// <example>
        /// <code>
        /// private void btnExpandXAccordionPanel_Click(object sender, EventArgs e)
        /// {
        ///    // xPanderPanel10 is not null
        ///    if (xPanderPanel10 != null)
        ///    {
        ///        Com.GainWinSoft.Common.Control.XAccordionPanel.XAccordionPanelPanelList panelList = xPanderPanel10.Parent as Com.GainWinSoft.Common.Control.XAccordionPanel.XAccordionPanelPanelList;
        ///        // and it's parent panelList is not null
        ///        if (panelList != null)
        ///        {
        ///            // expands xPanderPanel10 in it's panelList.
        ///            panelList.Expand(xPanderPanel10);
        ///        }
        ///    }
        /// }
        /// </code>
        /// </example>
		public void Expand(BasePanel panel)
		{
			if (panel == null)
			{
				throw new ArgumentNullException("panel",
					string.Format(System.Globalization.CultureInfo.InvariantCulture,
					Com.GainWinSoft.Common.Control.XAccordionPanel.Properties.Resources.IDS_ArgumentException,
					"panel"));
			}

			XAccordionPanelPanel xpanderPanel = panel as XAccordionPanelPanel;
			if (xpanderPanel != null)
			{
				foreach (XAccordionPanelPanel tmpXAccordionPanelPanel in this.m_xpanderPanels)
				{
					if (tmpXAccordionPanelPanel.Equals(xpanderPanel) == false)
					{
						tmpXAccordionPanelPanel.Expand = false;
					}
				}
                PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(xpanderPanel)["Expand"];
                if (propertyDescriptor != null)
                {
                    propertyDescriptor.SetValue(xpanderPanel, true);
                }
			}
		}
		#endregion

		#region MethodsProtected
		/// <summary>
		/// Paints the background of the xpanderpanellist.
		/// </summary>
		/// <param name="pevent">A PaintEventArgs that contains information about the control to paint.</param>
		protected override void OnPaintBackground(PaintEventArgs pevent)
        {
			base.OnPaintBackground(pevent);
            if (this.m_bShowGradientBackground == true)
            {
                Rectangle rectangle = new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height);
                using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
                    rectangle,
                    this.BackColor,
                    this.GradientBackground,
                    this.LinearGradientMode))
                {
					pevent.Graphics.FillRectangle(linearGradientBrush, rectangle);
                }
            }
        }
		/// <summary>
		/// Raises the ControlAdded event.
		/// </summary>
		/// <param name="e">A ControlEventArgs that contains the event data.</param>
		protected override void OnControlAdded(System.Windows.Forms.ControlEventArgs e)
		{
			base.OnControlAdded(e);
			Com.GainWinSoft.Common.Control.XAccordionPanel.XAccordionPanelPanel xpanderPanel = e.Control as Com.GainWinSoft.Common.Control.XAccordionPanel.XAccordionPanelPanel;
			if (xpanderPanel != null)
			{
				if (xpanderPanel.Expand == true)
				{
					foreach (XAccordionPanelPanel tmpXAccordionPanelPanel in this.XAccordionPanelPanels)
					{
						if (tmpXAccordionPanelPanel != xpanderPanel)
						{
							tmpXAccordionPanelPanel.Expand = false;
							tmpXAccordionPanelPanel.Height = xpanderPanel.CaptionHeight;
						}
					}
				}
                xpanderPanel.Parent = this;
				xpanderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
				xpanderPanel.Left = this.Padding.Left;
				xpanderPanel.Width = this.ClientRectangle.Width
					- this.Padding.Left
					- this.Padding.Right;
                xpanderPanel.PanelStyle = this.PanelStyle;
                xpanderPanel.ColorScheme = this.ColorScheme;
                if (this.PanelColors != null)
                {
                    xpanderPanel.SetPanelProperties(this.PanelColors);
                }
                xpanderPanel.ShowBorder = this.ShowBorder;
                xpanderPanel.ShowCloseIcon = this.m_bShowCloseIcon;
                xpanderPanel.ShowExpandIcon = this.m_bShowExpandIcon;
                xpanderPanel.CaptionStyle = this.m_captionStyle;
                xpanderPanel.Top = this.GetTopPosition();
                xpanderPanel.PanelStyleChanged += new EventHandler<PanelStyleChangeEventArgs>(XpanderPanelPanelStyleChanged);
				xpanderPanel.ExpandClick += new EventHandler<EventArgs>(this.XAccordionPanelPanelExpandClick);
				xpanderPanel.CloseClick += new EventHandler<EventArgs>(this.XAccordionPanelPanelCloseClick);
			}
			else
			{
				throw new InvalidOperationException("Can only add Com.GainWinSoft.Common.Control.XAccordionPanel.XAccordionPanelPanel");
			}
		}
		/// <summary>
		/// Raises the ControlRemoved event.
		/// </summary>
		/// <param name="e">A ControlEventArgs that contains the event data.</param>
		protected override void OnControlRemoved(System.Windows.Forms.ControlEventArgs e)
		{
			base.OnControlRemoved(e);

			Com.GainWinSoft.Common.Control.XAccordionPanel.XAccordionPanelPanel xpanderPanel =
				e.Control as Com.GainWinSoft.Common.Control.XAccordionPanel.XAccordionPanelPanel;

			if (xpanderPanel != null)
			{
                xpanderPanel.PanelStyleChanged -= new EventHandler<PanelStyleChangeEventArgs>(XpanderPanelPanelStyleChanged);
				xpanderPanel.ExpandClick -= new EventHandler<EventArgs>(this.XAccordionPanelPanelExpandClick);
				xpanderPanel.CloseClick -= new EventHandler<EventArgs>(this.XAccordionPanelPanelCloseClick);
			}
		}
		/// <summary>
		/// Raises the Resize event.
		/// </summary>
		/// <param name="e">An EventArgs that contains the event data.</param>
		protected override void OnResize(System.EventArgs e)
		{
			base.OnResize(e);
			int iXAccordionPanelPanelCaptionHeight = 0;
			
			if (this.m_xpanderPanels != null)
			{
				foreach (XAccordionPanelPanel xpanderPanel in this.m_xpanderPanels)
				{
					xpanderPanel.Width = this.ClientRectangle.Width
						- this.Padding.Left
						- this.Padding.Right;
					if (xpanderPanel.Visible == false)
					{
						iXAccordionPanelPanelCaptionHeight -= xpanderPanel.CaptionHeight;
					}
					iXAccordionPanelPanelCaptionHeight += xpanderPanel.CaptionHeight;
				}

				foreach (XAccordionPanelPanel xpanderPanel in this.m_xpanderPanels)
				{
					if (xpanderPanel.Expand == true)
					{
						xpanderPanel.Height =
							this.Height
							- iXAccordionPanelPanelCaptionHeight
							- this.Padding.Top
							- this.Padding.Bottom
							+ xpanderPanel.CaptionHeight;
						return;
					}
				}
			}
		}
        /// <summary>
        /// Raises the PanelStyle changed event
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A PanelStyleChangeEventArgs that contains the event data.</param>
        protected virtual void OnPanelStyleChanged(object sender, PanelStyleChangeEventArgs e)
        {
            PanelStyle panelStyle = e.PanelStyle;
            this.Padding = new System.Windows.Forms.Padding(0);

            foreach (XAccordionPanelPanel xpanderPanel in this.XAccordionPanelPanels)
            {
                PropertyDescriptorCollection propertyDescriptorCollection = TypeDescriptor.GetProperties(xpanderPanel);
                if (propertyDescriptorCollection.Count > 0)
                {
                    PropertyDescriptor propertyDescriptorPanelStyle = propertyDescriptorCollection["PanelStyle"];
                    if (propertyDescriptorPanelStyle != null)
                    {
                        propertyDescriptorPanelStyle.SetValue(xpanderPanel, panelStyle);
                    }
                    PropertyDescriptor propertyDescriptorLeft = propertyDescriptorCollection["Left"];
                    if (propertyDescriptorLeft != null)
                    {
                        propertyDescriptorLeft.SetValue(xpanderPanel, this.Padding.Left);
                    }
                    PropertyDescriptor propertyDescriptorWidth = propertyDescriptorCollection["Width"];
                    if (propertyDescriptorWidth != null)
                    {
                        propertyDescriptorWidth.SetValue(
                            xpanderPanel,
                            this.ClientRectangle.Width
                            - this.Padding.Left
                            - this.Padding.Right);
                    }

                }
            }
            if (this.PanelStyleChanged != null)
            {
                this.PanelStyleChanged(sender, e);
            }
        }
        /// <summary>
        /// Raises the ColorScheme changed event
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A EventArgs that contains the event data.</param>
        protected virtual void OnColorSchemeChanged(object sender, ColorSchemeChangeEventArgs e)
        {
            ColorScheme eColorScheme = e.ColorSchema;
            foreach (XAccordionPanelPanel xpanderPanel in this.XAccordionPanelPanels)
            {
                PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(xpanderPanel)["ColorScheme"];
                if (propertyDescriptor != null)
                {
                    propertyDescriptor.SetValue(xpanderPanel, eColorScheme);
                }
            }
            if (this.ColorSchemeChanged != null)
            {
                this.ColorSchemeChanged(sender, e);
            }
        }
        /// <summary>
        /// Raises the CaptionHeight changed event
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A EventArgs that contains the event data.</param>
        protected virtual void OnCaptionHeightChanged(object sender, EventArgs e)
        {
            foreach (XAccordionPanelPanel xpanderPanel in this.XAccordionPanelPanels)
            {
                PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(xpanderPanel)["CaptionHeight"];
                if (propertyDescriptor != null)
                {
                    propertyDescriptor.SetValue(xpanderPanel, this.m_iCaptionHeight);
                }
            }
            if (this.CaptionHeightChanged != null)
            {
                this.CaptionHeightChanged(sender, e);
            }
        }
        /// <summary>
        /// Raises the CaptionStyleChanged changed event
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A EventArgs that contains the event data.</param>
        protected virtual void OnCaptionStyleChanged(object sender, EventArgs e)
        {
            foreach (XAccordionPanelPanel xpanderPanel in this.XAccordionPanelPanels)
            {
                PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(xpanderPanel)["CaptionStyle"];
                if (propertyDescriptor != null)
                {
                    propertyDescriptor.SetValue(xpanderPanel, this.m_captionStyle);
                }
            }
            if (this.CaptionStyleChanged != null)
            {
                this.CaptionStyleChanged(sender, e);
            }
        }
		#endregion

		#region MethodsPrivate

        private void XAccordionPanelPanelExpandClick(object sender, EventArgs e)
		{
			Com.GainWinSoft.Common.Control.XAccordionPanel.XAccordionPanelPanel xpanderPanel = sender as Com.GainWinSoft.Common.Control.XAccordionPanel.XAccordionPanelPanel;
            if (xpanderPanel != null)
			{
                this.Expand(xpanderPanel);
			}
		}

        private void XAccordionPanelPanelCloseClick(object sender, EventArgs e)
        {
            Com.GainWinSoft.Common.Control.XAccordionPanel.XAccordionPanelPanel xpanderPanel = sender as Com.GainWinSoft.Common.Control.XAccordionPanel.XAccordionPanelPanel;
            if (xpanderPanel != null)
            {
                this.Controls.Remove(xpanderPanel);
            }
        }

        private void XpanderPanelPanelStyleChanged(object sender, PanelStyleChangeEventArgs e)
        {
            PanelStyle panelStyle = e.PanelStyle;
            if (panelStyle != this.m_ePanelStyle)
            {
                this.PanelStyle = panelStyle;
            }
        }

        private int GetTopPosition()
        {
			int iTopPosition = this.Padding.Top;
			int iNextTopPosition = 0;

            //The next top position is the highest top value + that controls height, with a
            //little vertical spacing thrown in for good measure
            IEnumerator enumerator = this.XAccordionPanelPanels.GetEnumerator();
            while (enumerator.MoveNext())
            {
				XAccordionPanelPanel xpanderPanel = (XAccordionPanelPanel)enumerator.Current;

				if (xpanderPanel.Visible == true)
				{
					if (iNextTopPosition == this.Padding.Top)
					{
						iTopPosition = this.Padding.Top;
					}
					else
					{
						iTopPosition = iNextTopPosition;
					}
					iNextTopPosition = iTopPosition + xpanderPanel.Height;
				}
            }
			return iTopPosition;
        }
        #endregion
    }

    #endregion

    #region Class XAccordionPanelPanelListDesigner

    /// <summary>
    /// Extends the design mode behavior of a XAccordionPanelPanelList control that supports nested controls.
    /// </summary>
    internal class XAccordionPanelPanelListDesigner : System.Windows.Forms.Design.ParentControlDesigner
    {
        #region FieldsPrivate

        private Pen m_borderPen = new Pen(Color.FromKnownColor(KnownColor.ControlDarkDark));
        private XAccordionPanelPanelList m_xpanderPanelList;

        #endregion

        #region MethodsPublic
        /// <summary>
        /// nitializes a new instance of the XAccordionPanelPanelListDesigner class.
        /// </summary>
        public XAccordionPanelPanelListDesigner()
        {
            this.m_borderPen.DashStyle = DashStyle.Dash;
        }
		/// <summary>
		/// Initializes the designer with the specified component.
		/// </summary>
		/// <param name="component">The IComponent to associate with the designer.</param>
        public override void Initialize(System.ComponentModel.IComponent component)
        {
            base.Initialize(component);
            this.m_xpanderPanelList = (XAccordionPanelPanelList)this.Control;
            //Disable the autoscroll feature for the control during design time.  The control
            //itself sets this property to true when it initializes at run time.  Trying to position
            //controls in this control with the autoscroll property set to True is problematic.
            this.m_xpanderPanelList.AutoScroll = false;
        }
		/// <summary>
		/// This member overrides ParentControlDesigner.ActionLists
		/// </summary>
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                // Create action list collection
                DesignerActionListCollection actionLists = new DesignerActionListCollection();

                // Add custom action list
                actionLists.Add(new XAccordionPanelPanelListDesignerActionList(this.Component));

                // Return to the designer action service
                return actionLists;
            }
        }

        #endregion

        #region MethodsProtected
        /// <summary>
        /// Releases the unmanaged resources used by the XAccordionPanelPanelDesigner,
        /// and optionally releases the managed resources. 
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources;
        /// false to release only unmanaged resources.</param>
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					if (this.m_borderPen != null)
					{
						this.m_borderPen.Dispose();
					}
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
        /// <summary>
        /// Receives a call when the control that the designer is managing has painted its surface so the designer can
        /// paint any additional adornments on top of the xpanderpanel.
        /// </summary>
        /// <param name="e">A PaintEventArgs the designer can use to draw on the xpanderpanel.</param>
        protected override void OnPaintAdornments(PaintEventArgs e)
        {
            base.OnPaintAdornments(e);
            e.Graphics.DrawRectangle(this.m_borderPen, 0, 0, this.m_xpanderPanelList.Width - 2, this.m_xpanderPanelList.Height - 2);
        }

        #endregion
    }

    #endregion

    #region Class XAccordionPanelPanelListDesignerActionList

    /// <summary>
    /// Provides the class for types that define a list of items used to create a smart tag panel for the XAccordionPanelPanelList.
    /// </summary>
    public class XAccordionPanelPanelListDesignerActionList : DesignerActionList
	{
		#region Properties
		
		/// <summary>
		/// Gets a collecion of XAccordionPanelPanel objects
		/// </summary>
        [Editor(typeof(XAccordionPanelPanelCollectionEditor), typeof(UITypeEditor))]
		public XAccordionPanelPanelCollection XAccordionPanelPanels
		{
			get { return this.XAccordionPanelPanelList.XAccordionPanelPanels; }
		}
		/// <summary>
        /// Gets or sets the style of the panel.
		/// </summary>
        public PanelStyle PanelStyle
		{
			get { return this.XAccordionPanelPanelList.PanelStyle; }
			set { SetProperty("PanelStyle", value); }
		}
		/// <summary>
        /// Gets or sets the color schema which is used for the panel.
		/// </summary>
        public ColorScheme ColorScheme
        {
            get { return this.XAccordionPanelPanelList.ColorScheme; }
            set { SetProperty("ColorScheme", value); }
        }
        /// <summary>
        /// Gets or sets the style of the caption (not for PanelStyle.Aqua).
        /// </summary>
        public CaptionStyle CaptionStyle
        {
            get { return this.XAccordionPanelPanelList.CaptionStyle; }
            set { SetProperty("CaptionStyle", value); }
        }
        /// <summary>
        /// Gets or sets a value indicating whether the control shows a border.
        /// </summary>
        public bool ShowBorder
        {
            get { return this.XAccordionPanelPanelList.ShowBorder; }
            set { SetProperty("ShowBorder", value); }
        }
        /// <summary>
        /// Gets or sets a value indicating whether the expand icon is visible
        /// </summary>
        public bool ShowExpandIcon
        {
            get { return this.XAccordionPanelPanelList.ShowExpandIcon; }
            set { SetProperty("ShowExpandIcon", value); }
        }
        /// <summary>
        /// Gets or sets a value indicating whether the close icon is visible
        /// </summary>
        public bool ShowCloseIcon
        {
            get { return this.XAccordionPanelPanelList.ShowCloseIcon; }
            set { SetProperty("ShowCloseIcon", value); }
        }
		#endregion

		#region MethodsPublic
        /// <summary>
        /// Initializes a new instance of the XAccordionPanelPanelListDesignerActionList class.
        /// </summary>
        /// <param name="component">A component related to the DesignerActionList.</param>
		public XAccordionPanelPanelListDesignerActionList(System.ComponentModel.IComponent component)
            : base(component)
        {
            // Automatically display smart tag panel when
            // design-time component is dropped onto the
            // Windows Forms Designer
			base.AutoShow = true;
        }
        /// <summary>
        /// Returns the collection of DesignerActionItem objects contained in the list.
        /// </summary>
        /// <returns> A DesignerActionItem array that contains the items in this list.</returns>
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            // Create list to store designer action items
            DesignerActionItemCollection actionItems = new DesignerActionItemCollection();

            actionItems.Add(
              new DesignerActionMethodItem(
                this,
                "ToggleDockStyle",
                GetDockStyleText(),
                "Design",
                "Dock or undock this control in it's parent container.",
                true));
            
            actionItems.Add(
                new DesignerActionPropertyItem(
                "ShowBorder",
                "Show Border",
                GetCategory(this.XAccordionPanelPanelList, "ShowBorder")));

            actionItems.Add(
                new DesignerActionPropertyItem(
                "ShowExpandIcon",
                "Show ExpandIcon",
                GetCategory(this.XAccordionPanelPanelList, "ShowExpandIcon")));

            actionItems.Add(
                new DesignerActionPropertyItem(
                "ShowCloseIcon",
                "Show CloseIcon",
                GetCategory(this.XAccordionPanelPanelList, "ShowCloseIcon")));
			
            actionItems.Add(
				new DesignerActionPropertyItem(
				"PanelStyle",
				"Select PanelStyle",
				GetCategory(this.XAccordionPanelPanelList, "PanelStyle")));

            actionItems.Add(
                new DesignerActionPropertyItem(
                "ColorScheme",
                "Select ColorScheme",
                GetCategory(this.XAccordionPanelPanelList, "ColorScheme")));

            actionItems.Add(
                new DesignerActionPropertyItem(
                "CaptionStyle",
                "Select CaptionStyle",
                GetCategory(this.XAccordionPanelPanelList, "CaptionStyle")));

            actionItems.Add(
			  new DesignerActionPropertyItem(
				"XAccordionPanelPanels",
				"Edit XAccordionPanelPanels",
				GetCategory(this.XAccordionPanelPanelList, "XAccordionPanelPanels")));
		
            return actionItems;
        }
        /// <summary>
        /// Dock/Undock designer action method implementation
        /// </summary>
        public void ToggleDockStyle()
        {
            // Toggle ClockControl's Dock property
            if (this.XAccordionPanelPanelList.Dock != DockStyle.Fill)
            {
                SetProperty("Dock", DockStyle.Fill);
            }
            else
            {
                SetProperty("Dock", DockStyle.None);
            }
        }

		#endregion

		#region MethodsPrivate
        /// <summary>
        /// Helper method that returns an appropriate display name for the Dock/Undock property,
		/// based on the ClockControl's current Dock property value
        /// </summary>
        /// <returns>the string to display</returns>
		private string GetDockStyleText()
        {
            if (this.XAccordionPanelPanelList.Dock == DockStyle.Fill)
            {
                return "Undock in parent container";
            }
            else
            {
                return "Dock in parent container";
            }
        }

        private XAccordionPanelPanelList XAccordionPanelPanelList
        {
            get { return (XAccordionPanelPanelList)this.Component; }
        }
		
        // Helper method to safely set a component’s property
        private void SetProperty(string propertyName, object value)
        {
            // Get property
            System.ComponentModel.PropertyDescriptor property
                = System.ComponentModel.TypeDescriptor.GetProperties(this.XAccordionPanelPanelList)[propertyName];
            // Set property value
            property.SetValue(this.XAccordionPanelPanelList, value);
        }
		// Helper method to return the Category string from a
		// CategoryAttribute assigned to a property exposed by 
		//the specified object
		private static string GetCategory(object source, string propertyName)
		{
			System.Reflection.PropertyInfo property = source.GetType().GetProperty(propertyName);
			CategoryAttribute attribute = (CategoryAttribute)property.GetCustomAttributes(typeof(CategoryAttribute), false)[0];
			if (attribute == null)
			{
				return null;
			}
			else
			{
				return attribute.Category;
			}
		}

		#endregion
	}

    #endregion

	#region Class XAccordionPanelPanelCollection

	/// <summary>
    /// Contains a collection of XAccordionPanelPanel objects.
	/// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1010:CollectionsShouldImplementGenericInterface")]
	public sealed class XAccordionPanelPanelCollection : IList,ICollection,IEnumerable
    {

        #region FieldsPrivate

        private XAccordionPanelPanelList m_xpanderPanelList;
        private System.Windows.Forms.Control.ControlCollection m_controlCollection;

        #endregion

        #region Constructor

		internal XAccordionPanelPanelCollection(XAccordionPanelPanelList xpanderPanelList)
        {
            this.m_xpanderPanelList = xpanderPanelList;
			this.m_controlCollection = this.m_xpanderPanelList.Controls;
        }

        #endregion

        #region Properties
		/// <summary>
		/// Gets or sets a XAccordionPanelPanel in the collection. 
		/// </summary>
        /// <param name="index">The zero-based index of the XAccordionPanelPanel to get or set.</param>
		/// <returns>The xPanderPanel at the specified index.</returns>
        public XAccordionPanelPanel this[int index]
        {
            get { return (XAccordionPanelPanel)this.m_controlCollection[index] as XAccordionPanelPanel; }
        }

        #endregion

        #region MethodsPublic
        /// <summary>
        /// Determines whether the XAccordionPanelPanelCollection contains a specific XAccordionPanelPanel
        /// </summary>
        /// <param name="xpanderPanel">The XAccordionPanelPanel to locate in the XAccordionPanelPanelCollection</param>
        /// <returns>true if the XAccordionPanelPanelCollection contains the specified value; otherwise, false.</returns>
        public bool Contains(XAccordionPanelPanel xpanderPanel)
        {
			return this.m_controlCollection.Contains(xpanderPanel);
        }
		/// <summary>
		/// Adds a XAccordionPanelPanel to the collection.  
		/// </summary>
		/// <param name="xpanderPanel">The XAccordionPanelPanel to add.</param>
        public void Add(XAccordionPanelPanel xpanderPanel)
        {
			this.m_controlCollection.Add(xpanderPanel);
			this.m_xpanderPanelList.Invalidate();

        }
        /// <summary>
        /// Removes the first occurrence of a specific XAccordionPanelPanel from the XAccordionPanelPanelCollection
        /// </summary>
        /// <param name="xpanderPanel">The XAccordionPanelPanel to remove from the XAccordionPanelPanelCollection</param>
        public void Remove(XAccordionPanelPanel xpanderPanel)
        {
			this.m_controlCollection.Remove(xpanderPanel);
        }
		/// <summary>
		/// Removes all the XAccordionPanelPanels from the collection. 
		/// </summary>
		public void Clear()
		{
			this.m_controlCollection.Clear();
		}
		/// <summary>
		/// Gets the number of XAccordionPanelPanels in the collection. 
		/// </summary>
		public int Count
		{
			get { return this.m_controlCollection.Count; }
		}
		/// <summary>
		/// Gets a value indicating whether the collection is read-only. 
		/// </summary>
		public bool IsReadOnly
		{
			get { return this.m_controlCollection.IsReadOnly; }
		}
		/// <summary>
		/// Returns an enumeration of all the XAccordionPanelPanels in the collection.  
		/// </summary>
		/// <returns></returns>
		public IEnumerator GetEnumerator()
		{
			return this.m_controlCollection.GetEnumerator();
		}
		/// <summary>
		/// Returns the index of the specified XAccordionPanelPanel in the collection. 
		/// </summary>
		/// <param name="xpanderPanel">The xpanderPanel to find the index of.</param>
		/// <returns>The index of the xpanderPanel, or -1 if the xpanderPanel is not in the <see ref="ControlCollection">ControlCollection</see> instance.</returns>
		public int IndexOf(XAccordionPanelPanel xpanderPanel)
		{
			return this.m_controlCollection.IndexOf(xpanderPanel);
		}
		/// <summary>
		/// Removes the XAccordionPanelPanel at the specified index from the collection. 
		/// </summary>
        /// <param name="index">The zero-based index of the xpanderPanel to remove from the ControlCollection instance.</param>
		public void RemoveAt(int index)
		{
			this.m_controlCollection.RemoveAt(index);
		}
		/// <summary>
		/// Inserts an XAccordionPanelPanel to the collection at the specified index. 
		/// </summary>
		/// <param name="index">The zero-based index at which value should be inserted. </param>
		/// <param name="xpanderPanel">The XAccordionPanelPanel to insert into the Collection.</param>
		public void Insert(int index, XAccordionPanelPanel xpanderPanel)
		{
			((IList)this).Insert(index, (object)xpanderPanel);
		}
		/// <summary>
		/// Copies the elements of the collection to an Array, starting at a particular Array index.
		/// </summary>
        /// <param name="xpanderPanels">The one-dimensional Array that is the destination of the elements copied from ICollection.
		/// The Array must have zero-based indexing.
		///</param>
		/// <param name="index">The zero-based index in array at which copying begins.</param>
		public void CopyTo(XAccordionPanelPanel[] xpanderPanels, int index)
		{
			this.m_controlCollection.CopyTo(xpanderPanels, index);
		}
        
		#endregion

		#region Interface ICollection
        /// <summary>
        /// Gets the number of elements contained in the ICollection.
        /// </summary>
		int ICollection.Count
		{
			get { return this.Count; }
		}
        /// <summary>
        /// Gets a value indicating whether access to the ICollection is synchronized
        /// </summary>
		bool ICollection.IsSynchronized
		{
			get { return ((ICollection)this.m_controlCollection).IsSynchronized; }
		}
        /// <summary>
        /// Gets an object that can be used to synchronize access to the ICollection.
        /// </summary>
		object ICollection.SyncRoot
		{
			get { return ((ICollection)this.m_controlCollection).SyncRoot; }
		}
        /// <summary>
        /// Copies the elements of the ICollection to an Array, starting at a particular Array index.
        /// </summary>
        /// <param name="array">The one-dimensional Array that is the destination of the elements copied from ICollection. The Array must have zero-based indexing.</param>
        /// <param name="index">The zero-based index in array at which copying begins.</param>
		void ICollection.CopyTo(Array array, int index)
		{
			((ICollection)this.m_controlCollection).CopyTo(array, index);
		}

		#endregion

		#region Interface IList
        /// <summary>
        /// Gets or sets the element at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the element to get or set.</param>
        /// <returns> The element at the specified index.</returns>
		object IList.this[int index]
		{
			get { return this.m_controlCollection[index]; }
            set {}
		}
        /// <summary>
        /// Adds an item to the IList.
        /// </summary>
        /// <param name="value">The Object to add to the IList.</param>
        /// <returns>The position into which the new element was inserted.</returns>
		int IList.Add(object value)
		{
			XAccordionPanelPanel xpanderPanel = value as XAccordionPanelPanel;
			if (xpanderPanel == null)
			{
				throw new ArgumentException(string.Format(System.Globalization.CultureInfo.CurrentUICulture,
					Resources.IDS_ArgumentException,
					typeof(XAccordionPanelPanel).Name));
			}
			this.Add(xpanderPanel);
			return this.IndexOf(xpanderPanel);
		}
        /// <summary>
        /// Determines whether the IList contains a specific value.
        /// </summary>
        /// <param name="value">The Object to locate in the IList.</param>
        /// <returns>true if the Object is found in the IList; otherwise, false.</returns>
		bool IList.Contains(object value)
		{
			return this.Contains(value as XAccordionPanelPanel);
		}
        /// <summary>
        /// Determines the index of a specific item in the IList.
        /// </summary>
        /// <param name="value">The Object to locate in the IList.</param>
        /// <returns>The index of value if found in the list; otherwise, -1.</returns>
		int IList.IndexOf(object value)
		{
			return this.IndexOf(value as XAccordionPanelPanel);
		}
        /// <summary>
        /// Inserts an item to the IList at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the item to insert.</param>
        /// <param name="value">The Object to insert into the IList.</param>
		void IList.Insert(int index, object value)
		{
			if ((value is XAccordionPanelPanel) == false)
			{
				throw new ArgumentException(
					string.Format(System.Globalization.CultureInfo.CurrentUICulture,
					Resources.IDS_ArgumentException,
					typeof(XAccordionPanelPanel).Name));
			}
		}
        /// <summary>
        /// Removes the first occurrence of a specific object from the IList.
        /// </summary>
        /// <param name="value">The Object to remove from the IList.</param>
		void IList.Remove(object value)
		{
			this.Remove(value as XAccordionPanelPanel);
		}
        /// <summary>
        /// Removes the IList item at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the item to remove.</param>
		void IList.RemoveAt(int index)
		{
			this.RemoveAt(index);
		}
        /// <summary>
        /// Gets a value indicating whether the IList is read-only.
        /// </summary>
		bool IList.IsReadOnly
		{
			get { return this.IsReadOnly; }
		}
        /// <summary>
        /// Gets a value indicating whether the IList has a fixed size.
        /// </summary>
		bool IList.IsFixedSize
		{
			get { return ((IList)this.m_controlCollection).IsFixedSize; }
		}

		#endregion
	}

	#endregion

	#region Class XAccordionPanelPanelCollectionEditor
    /// <summary>
    /// Provides a user interface that can edit most types of collections at design time.
    /// </summary>
	internal class XAccordionPanelPanelCollectionEditor : CollectionEditor
	{
		#region FieldsPrivate

		private CollectionForm m_collectionForm;

		#endregion

		#region MethodsPublic
        /// <summary>
        /// Initializes a new instance of the XAccordionPanelPanelCollectionEditor class
        /// using the specified collection type.
        /// </summary>
        /// <param name="type">The type of the collection for this editor to edit.</param>
        public XAccordionPanelPanelCollectionEditor(Type type)
            : base(type)
        {
        }

		#endregion

		#region MethodsProtected
        /// <summary>
        /// Creates a new form to display and edit the current collection.
        /// </summary>
        /// <returns> A CollectionEditor.CollectionForm to provide as the user interface for editing the collection.</returns>
		protected override CollectionForm CreateCollectionForm()
		{
			this.m_collectionForm = base.CreateCollectionForm();
			return this.m_collectionForm;
		}
        /// <summary>
        /// Creates a new instance of the specified collection item type.
        /// </summary>
        /// <param name="ItemType">The type of item to create.</param>
        /// <returns> A new instance of the specified object.</returns>
        protected override Object CreateInstance(Type ItemType)
        {
            /* you can create the new instance yourself 
                 * ComplexItem ci=new ComplexItem(2,"ComplexItem",null);
                 * we know for sure that the itemType it will always be ComplexItem
                 *but this time let it to do the job... 
                 */

            Com.GainWinSoft.Common.Control.XAccordionPanel.XAccordionPanelPanel xpanderPanel =
                (Com.GainWinSoft.Common.Control.XAccordionPanel.XAccordionPanelPanel)base.CreateInstance(ItemType);

            if (this.Context.Instance != null)
            {
                xpanderPanel.Expand = true;
            }
            return xpanderPanel;
        }

		#endregion
	}

	#endregion

}
