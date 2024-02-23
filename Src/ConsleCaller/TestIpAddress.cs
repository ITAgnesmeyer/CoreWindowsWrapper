using System;
using System.Diagnostics;
using CoreWindowsWrapper;

namespace ConsoleCaller
{
    class TestIpAddress : NativeWindow
    {
        private NativeIpAddressEdit _IpEdit;
        private NativeButton _TestButton;
        private NativeLabel _Label;

        protected override void InitControls()
        {
            //this.Width = 400;
            //this.Height = 400;
            this.Text = "Test TExt";
            this.KeyDown += FormKeyDown;


            this.BackColor = CoreWindowsWrapper.Tools.ColorTool.Rgb(255, 255, 255);
            this._IpEdit = new NativeIpAddressEdit()
            {
                Top = 10,
                Left = 10,
                Width = 120,
                Height = 25
            };

            this._TestButton = new NativeButton()
            {
                Top = 40,
                Left = 10,
                Width = 100,
                Height = 25,
                Text = "TEST"
            };
            this._Label = new NativeLabel()
            {
                BackColor = CoreWindowsWrapper.Tools.ColorTool.ControlBackground,
                Top = 80,
                Left = 10,
                Width = 150,
                Height = 25,
                Font = new Font() { Name = "Arial", Size = 15 }
            };

            this._TestButton.Clicked += OnTestButtonClick;
            this.Controls.Add(this._IpEdit);
            this.Controls.Add(this._TestButton);
            this.Controls.Add(this._Label);


        }


        private void FormKeyDown(object sender, NativeKeyEventArgs e)
        {
            if (e.VirtalKey == Diga.Core.Api.Win32.VirtualKeys.VK_F11)
            {
                this.SetWindowState(WindowState.Maximized);
                NativeApp.DoEvents();
            }
        }

        private void OnTestButtonClick(object sender, EventArgs e)
        {
            this._IpEdit.GetAddress(out byte b1, out byte b2, out byte b3, out byte b4);
            Debug.Print($"{b1}.{b2}.{b3}.{b4}");
            this._Label.Text = $"{b1}.{b2}.{b3}.{b4}";

        }
    }
}