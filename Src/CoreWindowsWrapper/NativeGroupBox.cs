using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeGroupBox : NativeControlBase
    {
        protected override void Initialize()
        {
            base.Initialize();
            this.TypeIdentifier = "button";
            this.Style = this.Style | ButtonStyles.BS_GROUPBOX;
        }
    }
}