using CoreWindowsWrapper;
using Diga.Core.Api.Win32;
using System;

namespace ConsoleCaller
{
    class TabStopTest :NativeWindow
    {
        private NativeTextBox txtText1;
        private NativeTextBox txtText2;
        private NativeTextBox txtText3;
        private NativeTextBox txtText4;
        private NativeTextBox txtText5;
        private NativeButton btnTest;
        protected override void InitControls()
        {
            txtText1 = new NativeTextBox()
            {
                Left = 0,
                Top = 0,
                Width = 100,
                Height = 25,
            };
            txtText1.Style |= WindowStylesConst.WS_BORDER;
            txtText2 = new NativeTextBox()
            {
                Left = 0,
                Top = 30,
                Width = 100,
                Height = 25,

            };
            txtText2.Style |= WindowStylesConst.WS_BORDER;
            txtText3 = new NativeTextBox()
            {
                Left = 0,
                Top = 60,
                Width = 100,
                Height = 25,

            };
            txtText3.Style |= WindowStylesConst.WS_BORDER;
            txtText4 = new NativeTextBox()
            {
                Left = 0,
                Top = 90,
                Width = 100,
                Height = 25,

            };
            txtText4.Style |= WindowStylesConst.WS_BORDER;
            txtText5 = new NativeTextBox()
            {
                Left = 0,
                Top = 120,
                Width = 100,
                Height = 25,

            };
            txtText5.Style |= WindowStylesConst.WS_BORDER;
            this.btnTest = new NativeButton()
            {
                Left = 0,
                Top = 150,
                Width = 100,
                Height = 25,
                Text = "Test"
            };
            this.btnTest.Clicked += btnTest_Click;
            this.Controls.Add(txtText1);
            this.Controls.Add(txtText2);
            this.Controls.Add(txtText3);
            this.Controls.Add(txtText4);
            this.Controls.Add(txtText5);
            this.Controls.Add(btnTest);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if ((this.txtText1.IsReadOnly))
            {
                this.txtText1.ReadOnly = false;
            }
            else 
            {
                this.txtText1.ReadOnly = true;
            }
            this.txtText5.Focus();
        }
    }
}
