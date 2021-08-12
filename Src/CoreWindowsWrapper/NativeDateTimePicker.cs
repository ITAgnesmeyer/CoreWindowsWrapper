namespace CoreWindowsWrapper
{
    public class NativeDateTimePicker : NativeControlBase
    {
        protected override void Initialize()
        {
            base.Initialize();
            this.TypeIdentifier = "SysDateTimePick32";
        }
    }
}