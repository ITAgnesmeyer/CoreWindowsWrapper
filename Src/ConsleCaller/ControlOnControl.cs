using System;
using CoreWindowsWrapper;
using CoreWindowsWrapper.Tools;

namespace ConsoleCaller
{


    class ControlOnControl : NativeWindow
    {
        private NativePanel _MainPanel;
        private NativePanel _PanelTop;
        private NativePanel _PanelBottom;
        private NativePanel _PanelCenter;
        private NativePanel _PanelLeft;
        private NativePanel _panelRight;
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
            this._PanelLeft = new NativePanel 
            { 
                DockType = DockType.Left,
                Width = 100,
                Height = 100,
                BackColor = ColorTool.Read,
                Name = "left_Panel"
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
            
            this._PanelCenter = new NativePanel
            {
                DockType = DockType.Fill,
                Width = 100,
                Name = "center_Panel",
                BackColor = ColorTool.White
            };

            this._panelRight = new NativePanel
            {
                DockType = DockType.Right,
                Width = 100,
                Name = "right_Panel",
                BackColor = ColorTool.Yellow

            };
            this.Controls.Add(this._MainPanel);
            this._PanelCenter.Controls.Add(this._panelRight);
            this._MainPanel.Controls.Add(this._PanelLeft);
            this._MainPanel.Controls.Add(this._PanelTop);
            this._MainPanel.Controls.Add(this._PanelBottom);
            this._MainPanel.Controls.Add(this._PanelCenter);

           
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
