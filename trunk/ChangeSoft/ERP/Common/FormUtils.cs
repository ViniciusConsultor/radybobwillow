using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Com.GainWinSoft.Common
{
    public class FormUtils
    {
        /// <summary>
        /// 在Tablelayoutpanel里循环清空必须输入小星星starlbl控件
        /// 必须输入提示label必须命名前缀starlbl
        /// </summary>
        /// <param name="container"></param>
        public static void ClearStarControl(Control container)
        {

            foreach (Control c in container.Controls)
            {

                if (c.GetType() == typeof(TableLayoutPanel))
                {
                    ClearStarControl(c);
                }
                else
                {
                    if (c.GetType() == typeof(Label))
                    {
                        if (c.Name.StartsWith("starlbl"))
                        {
                            c.Text = "";
                        }
                        
                    }
                }
            }
        }
    }
}
