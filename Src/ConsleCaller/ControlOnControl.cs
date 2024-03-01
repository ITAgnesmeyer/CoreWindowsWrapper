using System;
using System.Runtime.CompilerServices;
using CoreWindowsWrapper;
using CoreWindowsWrapper.Tools;
using Diga.Core.Api.Win32;

namespace ConsoleCaller
{
    public enum DockType
    {
        None,
        Top,
        Bottom,
        Left,
        Right,
        Fill
    }
    public class NativePanel : NativeWindow
    {
        public DockType DockType { get; set; } = DockType.None;
        protected override void OnBeforeCreate(BeforeWindowCreateEventArgs e)
        {
            e.Styles.Style = WindowStylesConst.WS_VISIBLE | WindowStylesConst.WS_CHILD | WindowStylesConst.WS_TABSTOP;
            e.Styles.StyleEx = 0;
        }
        public void DoDock()
        {
            if (InDock) return;
            if (this.ParentHandle == IntPtr.Zero)
                return;
            if (this.DockType == DockType.None)
                return;
            InDock = true;
            User32.GetClientRect(this.ParentHandle, out Rect rect);
            switch (this.DockType)
            {
                case DockType.Top:
                    this.Top = 0;
                    this.Left = 0;
                    this.Width = rect.Width;
                    break;
                case DockType.Bottom:
                    this.Left = 0;
                    this.Width = rect.Width;
                    this.Top = rect.Height - this.Height;
                    break;
                case DockType.Left:
                    this.Left = 0;
                    this.Height = rect.Height;
                    break;
                case DockType.Right:
                    this.Left = rect.Width - this.Width;
                    this.Top = 0;
                    this.Height = rect.Height;
                    break;
                case DockType.Fill:
                    {
                        int left = 0;
                        int top = 0;
                        int height = rect.Height;
                        int width = rect.Width;
                        //foreach (var item in this.Controls)
                        //{
                        //    if(item.Value is NativePanel)
                        //    {
                        //        NativePanel np = item.Value as NativePanel;
                        //        if(np.DockType == DockType.Left)
                        //        {

                        //        }
                        //    }
                        //}
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

        protected override void OnParentResize()
        {
            DoDock();
        }
    }
    class ControlOnControl : NativeWindow
    {
        private NativePanel _MainPanel;
        private NativePanel _PanelTop;
        private NativePanel _PanelBottom;
        protected override void InitControls()
        {
            this.Text = "Control on Control";
            this.Name = "MainWindow";
            this.Width = 600;
            this.Height = 400;
            this.StartUpPosition = WindowsStartupPosition.CenterScreen;
            this._MainPanel = new NativePanel
            {
                Name = "main_Panel",
                DockType = DockType.Fill,
                BackColor = ColorTool.Black
            };
            this._PanelTop = new NativePanel
            {
                DockType = DockType.Top,
                Height = 100,
                Name = "top_Panel",
                BackColor = ColorTool.Green
               
            };
            this._PanelBottom = new NativePanel
            {
                DockType = DockType.Bottom,
                Height = 100,
                Name = "bottom_Panel",
                BackColor = ColorTool.Blue

            };

                
            this.Controls.Add(this._MainPanel);
            this._MainPanel.Controls.Add(this._PanelTop);
            this._MainPanel.Controls.Add(this._PanelBottom);
           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            MessageBox.Show(this.Handle, "Test", "TEST");
        }
        protected override void OnSize(SizeEventArgs e)
        {
            
            base.OnSize(e);
        }
    }
}
