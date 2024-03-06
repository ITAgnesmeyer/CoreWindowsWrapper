using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeUserControl : NativeWindow
    {
        protected override void OnBeforeCreate(BeforeWindowCreateEventArgs e)
        {

            e.Styles.Style = WindowStylesConst.WS_VISIBLE | WindowStylesConst.WS_CHILD | WindowStylesConst.WS_TABSTOP;
            e.Styles.StyleEx = WindowStylesConst.WS_EX_CONTROL­PARENT;
        }
    }
}