using System;
using Diga.Core.Api.Win32;
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
}