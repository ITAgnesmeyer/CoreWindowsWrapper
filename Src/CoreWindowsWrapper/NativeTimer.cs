using System;

namespace CoreWindowsWrapper
{
    public class NativeTimer:NativeNoCreateControlBase
    {
        public int Interval{get;set;}
        public event EventHandler<EventArgs> Tick;
        protected override void Initialize()
        {
            base.Initialize();
            this.ControlType = Win32ApiForm.ControlType.Timer;

        }

        public void StartTimer()
        {
            Api.Win32.TimerProc proc = OnTimerProc;
            UIntPtr id = (UIntPtr)this.ControlId;
            uint intVal = System.Convert.ToUInt32(this.Interval);
            if(this.Interval > 0)
                Api.Win32.User32.SetTimer(this.ParentHandle, id,intVal,proc);
        }

        private void OnTimerProc(IntPtr param0, uint param1, IntPtr param2, uint param3)
        {
            OnTick();
        }

        protected virtual void OnTick()
        {
            //this.Tick?.Invoke(this,new EventArgs());
            SafeInvokeAsync(this.Tick, EventArgs.Empty);
        }

        public void StopTimer()
        {
           
            UIntPtr id = (UIntPtr)this.ControlId;
            Api.Win32.User32.KillTimer(this.ParentHandle, id);
        }

        public override void Destroy()
        {
            base.Destroy();
            StopTimer();
        }
    }
}