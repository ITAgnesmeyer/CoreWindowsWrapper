using System;
using Diga.Core.Api.Win32;
using Diga.Core.Api.Win32.GDI;
namespace CoreWindowsWrapper
{
    public class NativeTimer : NativeNoCreateControlBase
    {
        public int Interval { get; set; }
        public event EventHandler<EventArgs> Tick;
        protected override void Initialize()
        {
            base.Initialize();
            this.ControlType = Win32ApiForm.ControlType.Timer;

        }

        public void StartTimer()
        {
            //First check if there is a parent Window
            if (this.ParentHandle == IntPtr.Zero)
                throw new InvalidOperationException("You cannot start Timer before main Window created!");
            //timer Proc is  disabled 
            //Uses Windows Message insted!
            //TimerProc proc = OnTimerProc;
            UIntPtr id = (UIntPtr)this.ControlId;
            uint intVal = System.Convert.ToUInt32(this.Interval);
            if (this.Interval > 0)
            {
                User32.SetTimer(this.ParentHandle, id, intVal, null);
            }
                
        }

        private void OnTimerProc(IntPtr param0, uint param1, IntPtr param2, uint param3)
        {
            OnTick();
        }

        protected virtual void OnTick()
        {
            //this.Tick?.Invoke(this,new EventArgs());
            SafeInvoke(this.Tick, EventArgs.Empty);
        }
        protected override bool ControlProc(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam, IntPtr lParam)
        {
            switch(command)
            {
                case WindowsMessages.WM_TIMER:
                    OnTick();
                    return true;
            }
            return base.ControlProc(hWndParent, hWndControl, controlId, command, wParam, lParam);
        }
        public void StopTimer()
        {

            UIntPtr id = (UIntPtr)this.ControlId;
            User32.KillTimer(this.ParentHandle, id);
        }

        public override void Destroy()
        {
            base.Destroy();
            StopTimer();
        }
    }
}