using System;
using System.Diagnostics;
using CoreWindowsWrapper;

namespace ConsoleCaller
{
    class TestIpAddress : NativeWindow
    {
        private NativeIpAddressEdit _IpEdit;
        private NativeButton _TestButton;
        protected override void InitControls()
        {
            this.Width = 400;
            this.Height = 400;
            this.Text = "Test TExt";
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
            this._TestButton.Clicked += OnTestButtonClick;
            this.Controls.Add(this._IpEdit);
            this.Controls.Add(this._TestButton);

            
        }

        private void OnTestButtonClick(object sender, EventArgs e)
        {
            this._IpEdit.GetAddress(out byte b1, out byte b2 , out byte b3 , out byte b4);
            Debug.Print($"{b1}.{b2}.{b3}.{b4}");

        }
    }
}