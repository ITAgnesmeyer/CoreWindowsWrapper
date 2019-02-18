using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeMultiLineTextBox : NativeTextBox
    {
        protected override void Initialize()
        {
            base.Initialize();
            this.Style = this.Style | EditBoxStyles.ES_MULTILINE | WindowStylesConst.WS_HSCROLL | WindowStylesConst.WS_VSCROLL;
            this.BackColor = Tools.ColorTool.Rgb(199, 199, 199);
            this.Font = new Font() {Name = "Arial", Size = 10};
        }
    }
}