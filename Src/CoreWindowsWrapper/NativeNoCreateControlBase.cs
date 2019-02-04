using CoreWindowsWrapper.Win32ApiForm;

namespace CoreWindowsWrapper
{
    public class NativeNoCreateControlBase:NativeControlBase
    {
        protected override void Initialize()
        {
            this.Control = new Win32NoCreateControl();
        }
    }
}