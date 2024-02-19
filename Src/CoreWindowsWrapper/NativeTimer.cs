using System;
using Diga.Core.Api.Win32;
using Diga.Core.Api.Win32.GDI;
namespace CoreWindowsWrapper
{
    public class NativeImageList : NativeNoCreateControlBase
    {
        public new IntPtr Handle { get; private set; }
        public override bool Create(IntPtr parentHandle)
        {
            return base.Create(parentHandle);

        }
        protected override void Initialize()
        {
            base.Initialize();
            this.ControlType = Win32ApiForm.ControlType.ImageList;
            this.Handle = ComCtl32.ImageList_Create(16, 16, ImageListConst.ILC_MASK, 1, 0);
        }
        public int ImageCount
        {
            get
            {
                return ComCtl32.ImageList_GetImageCount(this.Handle);
            }
            set
            {
                ComCtl32.ImageList_SetImageCount(this.Handle, (uint)value);
            }
        }
        public int AddIcon(IntPtr hIcon)
        {
            return ComCtl32.ImageList_AddIcon(this.Handle, hIcon);
        }
        public int AddIconRes(int resId)
        {
            IntPtr ico = ResourceLoader.Loader.LoadIcon(resId);
            return ComCtl32.ImageList_AddIcon(this.Handle, ico);
        }
        public IntPtr GetIcon(int id, uint flag = ImageListConst.ILD_NORMAL)
        {
            return ComCtl32.ImageList_GetIcon(this.Handle, id, flag);
        }

        public new int BackColor
        {
            get
            {
                return (int)ComCtl32.ImageList_GetBkColor(this.Handle) ;
            }
            set
            {
                

                ComCtl32.ImageList_SetBkColor(this.Handle,(uint)(IntPtr)value);
            }
        }
        
        public int Replace(int index, IntPtr newIcon)
        {
            return ComCtl32.ImageList_ReplaceIcon(this.Handle, index, newIcon);
            
        }

        public Size IconSize
        {
            get
            {
                ComCtl32.ImageList_GetIconSize(this.Handle , out int x , out int y);
                return new Size(x , y);
            }
            set
            {
                ComCtl32.ImageList_SetIconSize(this.Handle, value.cx , value.cy);
            }
        }
        public Size GetIconSize(int index)
        {
            ComCtl32.ImageList_GetIconSize(this.Handle, out int x , out int y);
            return new Size(x, y);
        }

        public bool Remove(int index)
        {
            return ComCtl32.ImageList_Remove(this.Handle, index);
        }

        public override void Destroy()
        {
            base.Destroy();
            if (this.Handle != IntPtr.Zero)
            {
                ComCtl32.ImageList_Destroy(this.Handle);
            }

        }

    }
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
            TimerProc proc = OnTimerProc;
            UIntPtr id = (UIntPtr)this.ControlId;
            uint intVal = System.Convert.ToUInt32(this.Interval);
            if (this.Interval > 0)
                User32.SetTimer(this.ParentHandle, id, intVal, proc);
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