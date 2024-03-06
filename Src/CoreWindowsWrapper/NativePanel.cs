using System;
using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativePanel : NativeWindow
    {
        public new DockType DockType 
        { 
            get 
            {
                return base.DockType;
            }
            set
            {
                base.DockType = value;
            }
        } 
        protected override void OnBeforeCreate(BeforeWindowCreateEventArgs e)
        {
            this.IsPanel = true;       
            e.Styles.Style = WindowStylesConst.WS_VISIBLE | WindowStylesConst.WS_CHILD | WindowStylesConst.WS_TABSTOP;
            e.Styles.StyleEx = WindowStylesConst.WS_EX_CONTROLPARENT;
        }
       
        public void DoDock()
        {
            if (InDock) return;
            if (this.ParentHandle == IntPtr.Zero)
                return;
            if (this.DockType == DockType.None)
                return;
            InDock = true;
            int restTop = 0;
            int restBottom = 0;
            int restLeft = 0;
            int restRight = 0;
            if (NativeWindow.TryGetWindow(this.ParentHandle, out NativeWindow nw))
            {
                if (nw.IsPanel)
                {


                    foreach (var item in nw.Controls)
                    {
                        if(item.Value is NativePanel panel)
                        {
                            if (panel.Handle == this.Handle)
                            {
                                break;
                            }

                            if (panel.DockType != DockType.None)
                            {
                                switch (panel.DockType)
                                {
                                    case DockType.Top:
                                        restTop += panel.Height;
                                        break;
                                    case DockType.Left:
                                        restLeft += panel.Width;
                                        break;
                                    case DockType.Right:
                                        restRight += panel.Width;
                                        break;
                                    case DockType.Bottom:
                                        restBottom += panel.Height;
                                        break;

                                }
                            }
                        }

                    }
                }
            }
            //foreach (var item in this.Controls)
            //{
            //    if (item.Value is NativePanel panel)
            //    {
            //        if (panel.Height == 0 || panel.Width == 0)
            //        {
            //            break;
            //        }

            //        if (panel.DockType != DockType.None)
            //        {
            //            switch (panel.DockType)
            //            {
            //                case DockType.Top:
            //                    restTop += panel.Height;
            //                    break;
            //                case DockType.Left:
            //                    restLeft += panel.Width;
            //                    break;
            //                case DockType.Right:
            //                    restRight += panel.Width;
            //                    break;
            //                case DockType.Bottom:
            //                    restBottom += panel.Height;
            //                    break;
            //            }
            //        }


            //    }
            //}
            User32.GetClientRect(this.ParentHandle, out Rect rect);
            switch (this.DockType)
            {
                case DockType.Top:
                    this.Top = restTop;
                    this.Left = restLeft;
                    this.Width = rect.Width - restLeft - restRight;
                    break;
                case DockType.Bottom:
                    this.Left = restLeft;
                    this.Width = rect.Width - restLeft - restRight;
                    this.Top = rect.Height - this.Height - restBottom;
                    break;
                case DockType.Left:
                    this.Top = restTop;
                    this.Left = restLeft;
                    this.Height = rect.Height - restTop - restBottom;
                    break;
                case DockType.Right:
                    this.Left = rect.Width - this.Width - restLeft - restRight;
                    this.Top = restTop;
                    this.Height = rect.Height;
                    break;
                case DockType.Fill:
                    {
                        int left = restLeft;
                        int top = restTop;
                        int height = rect.Height -restTop - restBottom;
                        int width = rect.Width -restLeft - restRight;
                       
                        this.Left = left;
                        this.Top = top;
                        this.Height = height;
                        this.Width = width;

                    }
                    break;
            }
            InDock = false;
        }
        private bool InDock = false;
        protected override void OnCreate(CreateEventArgs e)
        {

            base.OnCreate(e);
            DoDock();

        }

        public override void OnParentResize()
        {
            DoDock();
        }
    }
}