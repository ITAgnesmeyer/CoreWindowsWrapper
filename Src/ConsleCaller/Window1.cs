using System;
using System.Diagnostics;
using System.Drawing;
using CoreWindowsWrapper;
using CoreWindowsWrapper.Tools;
using CoreWindowsWrapper.Win32ApiForm;


namespace ConsleCaller
{
    class Window1:NativeWindow
    {



        private NativeButton _Button;
        private NativeButton _Button1;
        private NativeTextBox _TextBox;
        private NativeTextBox _TextBox2;
        private NativeLabel _Label1;
        private NativeProgress _ProgressBar;

        protected override  void InitControls()
        {
            ColorConverter c = new ColorConverter();
            
            this.Text = "Dies ist meine Anwnedung";
            this.Name = "Window1";
            this.Left = 100;
            this.Top = 100;
            this.Width = 600;
            this.Height = 400;
            //this.BackColor = ColorTool.LightGray;
            this._Button = new NativeButton
            {
                Left = 10,
                Top = 10,
                Width = 100,
                Height = 30,
                Text = "Test",
                Name = "bnTest",
                ControlId = 501
            };

            this._Button1 = new NativeButton
            {
                Left = 150,
                Top = 10,
                Width = 100,
                Height = 30,
                Text = "Test",
                Name = "bnTest",
                ControlId = 505
            };
            this._Button.Clicked += button_OnClicked;
            this._Button.DblClicked += button_OnDblClicked;
            this._Button1.Clicked += button1_OnClicked;
            this._Button1.DblClicked += button1_OnDblClicked;

            this._TextBox = new NativeTextBox
            {
                Left = 10,
                Top = 50,
                Width = 100,
                Height = 30,
                Text = "ATEST",
                Name = "txtTest",
                ControlId = 502
            };
            this._TextBox.Change += TextBox_Change;

            this._TextBox2 = new NativeTextBox
            {
                Left = 10,
                Top = 150,
                Width = 100,
                Height = 30,
                Text = "",
                Name = "txt2Test",
                ControlId = 503,
                BackColor = ColorTool.Yellow
                
            };

            this._Label1 = new NativeLabel
            {
                Left = 10,
                Top = 200,
                Width = 100,
                Height = 30,
                Text = "Dies ist ein Label",
                ControlId = 504
                
            };

            this._ProgressBar = new NativeProgress
            {
                Left = 10,
                Top = 250,
                Width = 150,
                Height = 30,
                ControlId = 507
            };

            this._TextBox.Clicked += Label1_DblClick;
            
            this.Controls.Add(this._Button);
            this.Controls.Add(this._Button1);
            this.Controls.Add(this._TextBox);
            this.Controls.Add(this._TextBox2);
            this.Controls.Add(this._Label1);
            this.Controls.Add(this._ProgressBar);
            Click += Window1_Click;
            DoubleClick += Window1_DblClick;
            Create += Window1_Create;
        }

        private void button1_OnDblClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Button1_DblClicked");
        }

        private void button1_OnClicked(object sender, EventArgs e)
        {
            int value = this._ProgressBar.Value;
            value += 1;
            int maxVal = this._ProgressBar.MaxValue;
            MessageBox.Show("maximum:" + maxVal.ToString());
            this._ProgressBar.Value = value;
        }

        private void Label1_DblClick(object sender, EventArgs eventArgs)
        {
            Debug.Print("label DblClicked!");
        }

        private void TextBox_Change(object sender, EventArgs e)
        {
            string text = this._TextBox.Text;
            this._TextBox2.Text = text;
        }

        private void button_OnDblClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Button DblClicked");
        }

        private void button_OnClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked!");
        }

        private void Window1_Create(object sender, CreateEventArgs e)
        {
            this._Button.Text = "halllo";
            MessageBox.Show("OnCreate");
        }

        private void Window1_DblClick(object sender, MouseClickEventArgs e)
        {
            Window2 win = new Window2();
            win.Show();

        }

        private void Window1_Click(object sender, MouseClickEventArgs e)
        {
            
        }
    }
}
