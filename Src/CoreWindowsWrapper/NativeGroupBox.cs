using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeGroupBox : NativeControlBase
    {
        protected override void Initialize()
        {
            base.Initialize();
            this.ControlType = Win32ApiForm.ControlType.GroupBox;
            this.TypeIdentifier = "button";
            this.Style = this.Style | ButtonStyles.BS_GROUPBOX;
        }
    }
}