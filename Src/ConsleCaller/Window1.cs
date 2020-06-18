using System;
using System.Diagnostics;
using System.Globalization;
using CoreWindowsWrapper;
using CoreWindowsWrapper.Tools;
using Diga.Core.Api.Win32;

namespace ConsoleCaller
{
    class Window1 : NativeWindow
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
        private NativeComboBox _ComboBox;
        private ControlTest _ControlTest;
        protected override void OnBeforeCreate(BeforeCreateEventArgs e)
        {
            //e.Styles.Style = WindowStylesConst.WS_VISIBLE|WindowStylesConst.WS_CAPTION | WindowStylesConst.WS_SYSMENU | WindowStylesConst.WS_SIZEBOX;
            //e.Styles.StyleEx = WindowStylesConst.WS_EX_APPWINDOW;
        }
        protected override void InitControls()
        {


            this.Text = "Dies ist meine Anwnedung";
            this.Name = "Window1";
            //this.StatusBar = false;
            // this.Left = 100;
            //this.Top = 100;
            this.Width = 600;
            this.Height = 400;
            
            this._ControlTest = new ControlTest();
            this._ControlTest.Width = 200;
            this._ControlTest.Height = 30;
            this._ControlTest.Left = 500;
            this._ControlTest.Top = 200;
            
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
                BackColor = ColorTool.Blue,
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


            this._ComboBox = new NativeComboBox();
            this._ComboBox.Location = new Point(300, 10);
            
            this._ComboBox.Height = 30;
            this._ComboBox.Width = 200;
            this._ComboBox.Name = "cbbTest";
            this._ComboBox.ForeColor = ColorTool.Blue;
            this._ComboBox.BackColor = ColorTool.Green;
            this._ComboBox.Font = new Font() { Name = "Arial", Size = 10 };
            this._ComboBox.SelChange += ComboBox_SelChange;


            this._TextBox = new NativeTextBox
            {
                Left = 10,
                Top = 50,
                Width = 100,
                Height = 30,
                Text = "ATEST",
                Name = "txtTest",
                Font = new Font() { Name = "Arial", Size = 14 },
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
                ForeColor = ColorTool.White

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
            this._ListBox.Top = 200;
            this._ListBox.Width = 400;
            this._ListBox.Height = 400;
            this._ListBox.BackColor = ColorTool.Yellow;
            this._ListBox.ForeColor = ColorTool.Read;
            this._ListBox.Font = new Font() { Name = "Arial", Size = 16 };
            this._ListBox.MultiSelect = true;
            this._ListBox.DblClicked+=ListBox_DblClicked;
            
            this._ListBox.SelChange+=ListBox_SelChange;

            this._ProgressBar = new NativeProgress
            {
                Left = 10,
                Top = 250,
                Width = 150,
                Height = 30//,
                //ControlId = 507
            };



            this._TextBox.Clicked += TextBox_Click;
            //this.Controls.Add(this._ControlTest);
            this.Controls.Add(this._Button);
            this.Controls.Add(this._Button1);
            this.Controls.Add(this._ComboBox);
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

        private void ListBox_SelChange(object sender, EventArgs e)
        {
            int selCount = this._ListBox.GetSelCount();
            this._TextBox2.Text = selCount.ToString();
            int currSel = this._ListBox.CurrentSelected();
            string text = this._ListBox.GetItemText(currSel);
            this._TextBox2.Text = this._TextBox2.Text + ";" + text;
        }

        private void ListBox_DblClicked(object sender, EventArgs e)
        {
            int value = this._ListBox.CurrentSelected();
      
            bool isSelected = this._ListBox.IsItemSelected(value);

            MessageBox.Show("Listbox selected=>" + isSelected);

            value += 1;
            try
            {
                this._ListBox.SetSelectionRange(value - 2,value);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error=>" + exception.Message);
            }
        }

        private void ComboBox_SelChange(object sender, NativeComboBoxSelChangeEventArgs e)
        {
            string text = this._ComboBox.ItemText(e.Index);
            MessageBox.Show("Text => " + text);
        }

        private void Timer_OnTick(object sender, EventArgs e)
        {
            try
            {
                this._Label1.Text = DateTime.Now.ToString(CultureInfo.InvariantCulture);
                int value = this._ProgressBar.Value;
                value += 1;
                if (value > 100)
                    value = 1;
                this._ProgressBar.Value = value;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Timer Proc Error=>" + exception.Message);
            }

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
        
           
            this._Button.Enabled = true;

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
            int items = this._ComboBox.ItemsCount();
            for (int i = 0; i < items; i++)
            {
                this._ListBox.AddText(this._ComboBox.ItemText(i));
            }

            MessageBox.Show($"Combobox has {items} Items!");
            this._Bitmap.Width = this._Bitmap.Width - 10;
            this._Bitmap.Refresh();
            this._Button.Enabled = false;
            this.Width = 200;
        }

        private void Window1_Create(object sender, CreateEventArgs e)
        {
            this._Button.Text = "hallo";
            this._Bitmap.Refresh();
            //MessageBox.Show("OnCreate");
            //this._Timer.ParentHandle = this.Handle;
            this._Timer.StartTimer();
            this._ListBox.AddText("hallo");
            this._ListBox.AddText("welt");
            for (int i = 1; i < 100; i++)
            {
                this._ListBox.AddText("welt" + i);
            }

            this._ComboBox.Add("hallo");
            this._ComboBox.Add("world");
            this._ComboBox.Add("home");
            this._ComboBox.SelectedIndex = 2;

        }

        private void Window1_DblClick(object sender, MouseClickEventArgs e)
        {
            Window2 win2 = new Window2(this);
            //this.Controls.Add(win2);
            win2.Show();
            MessageBox.Show("Nach Show");
        }

        private void Window1_Click(object sender, MouseClickEventArgs e)
        {

        }
    }
}
