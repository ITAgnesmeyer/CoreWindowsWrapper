using System;
using System.Diagnostics;
using CoreWindowsWrapper;
using Diga.Core.Api.Win32;

namespace ConsoleCaller
{
    public class ControlTest: NativeWindow 
    {
        private NativeTextBox _TextBox;
        private NativeButton _Button;

        protected override void OnBeforeCreate(BeforeWindowCreateEventArgs e)
        {
            e.Styles.Style = WindowStylesConst.WS_VISIBLE | WindowStylesConst.WS_CHILD | WindowStylesConst.WS_TABSTOP; 
            e.Styles.StyleEx =0;
        }
        protected override void InitControls()
        {
            //base.InitControls();
            Debug.Print(this.Width.ToString());

            this._TextBox = new NativeTextBox();
            this._Button = new NativeButton();
            this._TextBox.Width = 100;
            this._TextBox.Height = 30;
            this._TextBox.Left = 0;
            this._TextBox.Top = 0;
            this._TextBox.Name = "CONTROL_TEST_TXT";
            this._Button.Width = 20;
            this._Button.Height = 30;
            this._Button.Left = this._TextBox.Width;
            this._Button.Top = 0;
            this._Button.Name = "CONTROL_TEST_BT";
            this._Button.Text = "...";
            
            this._Button.Clicked += Button_Clicked;
            this.Controls.Add(this._TextBox);
            this.Controls.Add(this._Button);
        }
        //protected override void Initialize()
        //{
        //    base.Initialize();
        //    Debug.Print(this.Width.ToString());

        //    this._TextBox = new NativeTextBox();
        //    this._Button = new NativeButton();
        //    this._TextBox.Width = 100;
        //    this._TextBox.Height = 100;
        //    this._TextBox.Left = 0;
        //    this._TextBox.Top = 0;
        //    this._TextBox.Name = "CONTROL_TEST_TXT";
        //    this._Button.Width = 20;
        //    this._Button.Height =100;
        //    this._Button.Left = this._TextBox.Width;
        //    this._Button.Top = 0;
        //    this._Button.Name = "CONTROL_TEST_BT";
        //    this._Button.Text = "...";

        //    this._Button.Clicked += Button_Clicked;
        //    this.Controls.Add(this._TextBox);
        //    this.Controls.Add(this._Button);

        //}
        protected override void OnCreate(CreateEventArgs e)
        {
            base.OnCreate(e);
            Rect rect = this.GetClientRect();
            this._Button.Left = rect.Width - this._Button.Width;
            this._TextBox.Width = rect.Width - this._Button.Width;

        }
        protected override void OnSize(SizeEventArgs e)
        {
            base.OnSize(e);
            this._Button.Left = this.Width - this._Button.Width;
            this._TextBox.Width = this.Width - this._Button.Width;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            this._TextBox.Text = "hallo";
        }
    }
}