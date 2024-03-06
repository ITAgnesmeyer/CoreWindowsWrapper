using System;
using CoreWindowsWrapper;
using CoreWindowsWrapper.Tools;
using Diga.Core.Api.Win32;

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
        private NativeTextBox _topTextBox;
        private NativeTextBox _bottomTextBox;
        private NativeTextBox _leftTextBox;
        private NativeTextBox _rightTextBox;
        private NativeTextBox _centerTextBox;
        private NativeTextBox _cneterTextBox1;
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
            this._topTextBox = new NativeTextBox
            {
                Left = 0,
                Top = 0,
                Height = 30,
                Width = 100,
                Text = "TOP"
            };
            this._PanelTop.Controls.Add(this._topTextBox);
            this._leftTextBox = new NativeTextBox
            {
                Left = 0,
                Top = 0,
                Height = 30,
                Width = 100,
                Text = "LEFT"
            };
            this._PanelLeft.Controls.Add(this._leftTextBox);

            this._bottomTextBox = new NativeTextBox
            {
                Left = 0,
                Top = 0,
                Height = 30,
                Width = 100,
                Text = "BOTTOM"
            };
            this._PanelBottom.Controls.Add( this._bottomTextBox);
            this._rightTextBox = new NativeTextBox
            {
                Left = 0,
                Top = 0,
                Height = 30,
                Width = 100,
                Text = "RIGHT"
            };
            this._panelRight.Controls.Add(this._rightTextBox);
            this._centerTextBox = new NativeTextBox
            {
                Left = 0,
                Top = 0,
                Height = 30,
                Width = 100,
                Text = "CENTER"
            };
            this._cneterTextBox1 = new NativeTextBox
            {
                Left = 0,
                Top = 40,
                Height = 30,
                Width = 100,
                Text = "CENTER1"
            };
            this._PanelCenter.Controls.Add(this._centerTextBox);
            this._PanelCenter.Controls.Add(this._cneterTextBox1);
            this._PanelCenter.Controls.Add(this._panelRight);
            this._MainPanel.Controls.Add(this._PanelLeft);
            this._MainPanel.Controls.Add(this._PanelTop);
            this._MainPanel.Controls.Add(this._PanelBottom);
            this._MainPanel.Controls.Add(this._PanelCenter);
            this.Controls.Add(this._MainPanel);

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
