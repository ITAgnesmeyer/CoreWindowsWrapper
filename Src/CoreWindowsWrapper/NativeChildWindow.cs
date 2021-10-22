namespace CoreWindowsWrapper
{
    public class NativeChildWindow : NativeWindow
    {
        public NativeChildWindow() : base()
        {
            this.IsMainWindow = false;
        }
        public NativeChildWindow(NativeWindow parent) : base(parent)
        {
            this.IsMainWindow = false;
        }
    }
}