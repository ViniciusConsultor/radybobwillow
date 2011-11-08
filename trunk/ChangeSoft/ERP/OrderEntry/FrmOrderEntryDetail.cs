using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Com.GainWinSoft.Common;
using WeifenLuo.WinFormsUI.Docking;

namespace Com.GainWinSoft.ERP.OrderEntry
{
    public partial class FrmOrderEntryDetail : BaseContent
    {
        public FrmOrderEntryDetail(DockPanel _parentdockpanel)
            : base(_parentdockpanel)
        {
            InitializeComponent();
        }

        /// <summary>
        /// 画面加载初期化处理
        /// </summary>
        private void FrmFactory_Load(object sender, System.EventArgs e)
        {
            this.Check_Init();
            this.Initialize();
        }

        /// <summary>
        /// 初期化处理
        /// </summary>
        private void Initialize()
        {
            
            this.button1.Image = (Image)Com.GainWinSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");
            this.button2.Image = (Image)Com.GainWinSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");
            this.button3.Image = (Image)Com.GainWinSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");
            this.button4.Image = (Image)Com.GainWinSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");
            this.button5.Image = (Image)Com.GainWinSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");
            this.button6.Image = (Image)Com.GainWinSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");
            
        }

        /// <summary>
        /// 各种Check用Validation初期化
        /// </summary>
        private void Check_Init()
        {

        }



    }
}
