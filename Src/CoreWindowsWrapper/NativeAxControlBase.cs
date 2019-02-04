using CoreWindowsWrapper.Win32ApiForm;

namespace CoreWindowsWrapper
{
    public class NativeAxControlBase: NativeControlBase
    {
       

        //public NativeAxControlBase()
        //{
        //    this.Initialize();
        //}
        protected override void Initialize()
        {

            this.Control = new Win32AxControl();

            
        }
    }
}