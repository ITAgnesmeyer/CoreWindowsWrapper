﻿using System;
using System.Diagnostics;
using CoreWindowsWrapper;
using CoreWindowsWrapper.Tools;


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
        private NativeBitmap _Bitmap;
        private NativeTimer _Timer;
        private NativeCheckBox _CheckBox;
        private NativeListBox _ListBox;
        protected override  void InitControls()
        {
           
            
            this.Text = "Dies ist meine Anwnedung";
            this.Name = "Window1";
           // this.Left = 100;
           //this.Top = 100;
            this.Width = 600;
            this.Height = 400;
            //this.BackColor = ColorTool.LightGray;
            this.StartUpPosition = WindowsStartupPosition.CenterScreen;
            this.BackColor = ColorTool.White;
            this._Timer = new NativeTimer();
            this._Timer.Interval = 100;
            //this._Timer.ControlId = 700;
            this._Timer.Tick += Timer_OnTick;
            this._Button = new NativeButton
            {
                Left = 10,
                Top = 10,
                Width = 100,
                Height = 30,
                Text = "Test",
                Name = "bnTest",
                BackColor=ColorTool.Blue,
                ForeColor = ColorTool.Green
               
            };

            this._Button1 = new NativeButton
            {
                Left = 150,
                Top = 10,
                Width = 100,
                Height = 30,
                Text = "Test",
                Name = "bnTest"//,
                //ControlId = 505
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
                Font = new Font(){Name="Arial",Size=14},
                ForeColor = ColorTool.Read
                //ControlId = 502
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
                //ControlId = 503,
                BackColor = ColorTool.Black,
                ForeColor= ColorTool.White
                
            };

            this._Label1 = new NativeLabel
            {
                Left = 10,
                Top = 200,
                Width = 100,
                Height = 30,
                Text = "Dies ist ein Label"//,
                //BackColor=ColorTool.Read,
                //ForeColor = ColorTool.Green,
                //ControlId = 504
                
            };
            this._Label1.Clicked += Label1_Click; 
            this._Label1.DblClicked += Label1_DblClick;

            this._Bitmap = new NativeBitmap();
            this._Bitmap.BitMap = "Skype.bmp";
            this._Bitmap.Left = 150;
            this._Bitmap.Top = 50;
            this._Bitmap.Width = 100;
            this._Bitmap.Height = 100;

            this._CheckBox = new NativeCheckBox();
            this._CheckBox.Left = 300;
            this._CheckBox.Top = 50;
            this._CheckBox.Width = 200;
            this._CheckBox.Height = 30;
            this._CheckBox.Text = "TEST CHECKBOX";
            this._CheckBox.BackColor = ColorTool.White;
            this._CheckBox.Checked = true;

            this._ListBox = new NativeListBox();
            this._ListBox.Left = 300;
            this._ListBox.Top = 90;
            this._ListBox.Width = 400;
            this._ListBox.Height = 400;
            this._ListBox.BackColor = ColorTool.Yellow;


            this._ProgressBar = new NativeProgress
            {
                Left = 10,
                Top = 250,
                Width = 150,
                Height = 30//,
                //ControlId = 507
            };



            this._TextBox.Clicked += TextBox_Click;
            
            this.Controls.Add(this._Button);
            this.Controls.Add(this._Button1);
            this.Controls.Add(this._TextBox);
            this.Controls.Add(this._TextBox2);
            this.Controls.Add(this._Label1);
            this.Controls.Add(this._Bitmap);
            this.Controls.Add(this._CheckBox);
            this.Controls.Add(this._ListBox);
            this.Controls.Add(this._ProgressBar);
            this.Controls.Add(this._Timer);
            Click += Window1_Click;
            DoubleClick += Window1_DblClick;
            Create += Window1_Create;
        }

        private void Timer_OnTick(object sender, EventArgs e)
        {
            this._Label1.Text = DateTime.Now.ToString();
            int value = this._ProgressBar.Value;
            value += 1;
            if(value > 100)
                value = 1;
            this._ProgressBar.Value = value;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Debug.Print("Label1_Clicked");
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TextBox_Clicked");
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
            MessageBox.Show("label DblClicked!");
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
            this._ListBox.Clear();
        }

        private void Window1_Create(object sender, CreateEventArgs e)
        {
            this._Button.Text = "halllo";
            this._Bitmap.Refresh();
            //MessageBox.Show("OnCreate");
           //this._Timer.ParentHandle = this.Handle;
            this._Timer.StartTimer();
            this._ListBox.AddText("hallo");
            this._ListBox.AddText("wert");
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
