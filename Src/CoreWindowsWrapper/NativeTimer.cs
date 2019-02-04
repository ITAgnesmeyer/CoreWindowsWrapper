﻿using System;

namespace CoreWindowsWrapper
{
    public class NativeTimer:NativeNoCreateControlBase
    {
        public int Interval{get;set;}
        public event EventHandler Tick;
        protected override void Initialize()
        {
            base.Initialize();

        }

        public void StartTimer()
        {
            Api.Win32.Win32Api.TIMERPROC proc = OnTimerProc;
            UIntPtr id = (UIntPtr)this.ControlId;
            uint intVal = System.Convert.ToUInt32(this.Interval);
            if(this.Interval > 0)
                Api.Win32.Win32Api.SetTimer(this.ParentHandle, id,intVal,proc);
        }

        private void OnTimerProc(IntPtr param0, uint param1, IntPtr param2, uint param3)
        {
            OnTick();
        }

        protected virtual void OnTick()
        {
            this.Tick?.Invoke(this,new EventArgs());
        }

        public void StopTimer()
        {
           
            UIntPtr id = (UIntPtr)this.ControlId;
            Api.Win32.Win32Api.KillTimer(this.ParentHandle, id);
        }

        public override void Destroy()
        {
            base.Destroy();
            StopTimer();
        }
    }
}