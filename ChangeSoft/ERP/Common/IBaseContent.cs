using System;
namespace Com.GainWinSoft.Common
{
    public interface IBaseContent
    {
        void CloseContent();
        string DockTitle { get; set; }
        void Language_Change();
        WeifenLuo.WinFormsUI.Docking.DockPanel Parentdockpanel { get; set; }
        void ShowContent(bool closeowner);
        void ShowContentAtFirst(bool closeowner);
    }
}
