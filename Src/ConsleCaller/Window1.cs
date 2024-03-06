using System;
using System.Diagnostics;
using System.Globalization;
using CoreWindowsWrapper;
using CoreWindowsWrapper.Tools;
using CoreWindowsWrapper.Win32ApiForm;
using Diga.Core.Api.Win32;

namespace ConsoleCaller
{
    class Window1 : NativeWindow
    {



        private NativeButton _Button;
        private NativeButton _Button1;
        private NativeButton _Button3;
        private NativeTextBox _TextBox;
        private NativeTextBox _TextBox2;
        private NativeLabel _Label1;
        private NativeProgress _ProgressBar;
        private NativeBitmap _Bitmap;
        private NativeTimer _Timer;
        private NativeCheckBox _CheckBox;
        private NativeListBox _ListBox;
        private NativeComboBox _ComboBox;
        private NativeDateTimePicker _DateTimePicker;
        private ControlTest _ControlTest;
        private static string CAPTION = "Dies ist meine Anwnedung";
        protected override void OnBeforeCreate(BeforeWindowCreateEventArgs e)
        {
            //e.Styles.Style = WindowStylesConst.WS_VISIBLE | WindowStylesConst.WS_CAPTION | WindowStylesConst.WS_SYSMENU | WindowStylesConst.WS_SIZEBOX;
            //e.Styles.StyleEx = WindowStylesConst.WS_EX_DLGMODALFRAME;
        }
        protected override void InitControls()
        {


            this.Text = CAPTION;
            this.Name = "Window1";
            //this.StatusBar = false;
            // this.Left = 100;
            //this.Top = 100;
            this.Width = 600;
            this.Height = 400;
            
            this._ControlTest = new ControlTest
            {
                Location = new Point(300,80),
                Width = 200,
                Height = 100,
                Name = "TEST_CONTAINER"
            };

            //this.BackColor = ColorTool.LightGray;
            this.StartUpPosition = WindowsStartupPosition.CenterScreen;
            this.BackColor = ColorTool.White;
            this._Timer = new NativeTimer
            {
                Interval = 100
            };
            //this._Timer.ControlId = 700;
            this._Timer.Tick += Timer_OnTick;
            this._Button = new NativeButton
            {
                Location = new Point(10, 10),
                Size = new Size(100, 30),
                Text = "Test",
                Name = "bnTest",
                BackColor = ColorTool.Blue,
                ForeColor = ColorTool.Green

            };
            this._Button.Clicked += button_OnClicked;
            this._Button.DblClicked += button_OnDblClicked;

            this._Button1 = new NativeButton
            {
                Location = new Point(150, 10),
                Size = new Size(100, 30),
                Text = "Test",
                Name = "bnTest"//,
                //ControlId = 505
            };

            this._Button1.Clicked += button1_OnClicked;
            this._Button1.DblClicked += button1_OnDblClicked;

            this._Button3 = new NativeButton
            {
                Location = new Point(300, 10),
                Size = new Size(20, 30),
                Name = "SelectFolder",
                Text = "…"
            };

            this._Button3.Clicked += Button3_Click;
            this._ComboBox = new NativeComboBox
            {
                Location = new Point(350, 10),
                Size = new Size(200, 30),
                Name = "cbbTest",
                ForeColor = ColorTool.Blue,
                BackColor = ColorTool.Green,
                Font = new Font() { Name = "Arial", Size = 10 }
            };

            this._ComboBox.SelChange += ComboBox_SelChange;


            this._TextBox = new NativeTextBox
            {
                Location = new Point(10,50),
                Size = new Size(300,30),
                Text = "ATEST",
                Name = "txtTest",
                Font = new Font() { Name = "Arial", Size = 14 },
                ForeColor = ColorTool.Read
                //ControlId = 502
            };
            
            this._TextBox.Change += TextBox_Change;
            this._TextBox.Clicked += TextBox_Click;
            this._TextBox.KeyPress += TextBox_KeyPress;
            
            this._TextBox2 = new NativeTextBox
            {
                Location = new Point(10,150),
                Size = new Size(100,30),
                Text = "",
                Name = "txt2Test",
                //ControlId = 503,
                BackColor = ColorTool.Black,
                ForeColor = ColorTool.White

            };

            this._Label1 = new NativeLabel
            {
                Location = new Point(10, 200),
                Size = new Size(100, 30),
                Text = "Dies ist ein Label"//,
                                           //BackColor=ColorTool.Read,
                                           //ForeColor = ColorTool.Green,
                                           //ControlId = 504

            };
            this._Label1.Clicked += Label1_Click;
            this._Label1.DblClicked += Label1_DblClick;

            this._Bitmap = new NativeBitmap
            {
                BitMap = "Skype.bmp",
                Left = 150,
                Top = 50,
                Width = 100,
                Height = 100
            };

            this._CheckBox = new NativeCheckBox
            {
                Left = 300,
                Top = 50,
                Width = 200,
                Height = 30,
                Text = "TEST CHECKBOX",
                BackColor = ColorTool.White,
                Checked = true
            };

            this._ListBox = new NativeListBox
            {
                Left = 300,
                Top = 200,
                Width = 400,
                Height = 400,
                BackColor = ColorTool.Yellow,
                ForeColor = ColorTool.Read,
                Font = new Font() { Name = "Arial", Size = 16 },
                MultiSelect = true
            };
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

            this._DateTimePicker = new NativeDateTimePicker
            {
                Left = 10,
                Top = 300,
                Width = 150,
                Height = 30

            };


            
            
            this.Controls.Add(this._Button);
            this.Controls.Add(this._Button1);
            this.Controls.Add(this._Button3);
            this.Controls.Add(this._ComboBox);
            this.Controls.Add(this._TextBox);
            this.Controls.Add(this._TextBox2);
            this.Controls.Add(this._Label1);
            this.Controls.Add(this._Bitmap);
            this.Controls.Add(this._CheckBox);
            this.Controls.Add(this._ListBox);
            this.Controls.Add(this._ProgressBar);
            this.Controls.Add(this._DateTimePicker);
            this.Controls.Add(this._Timer);
            this.Controls.Add(this._ControlTest);
            Click += Window1_Click;
            DoubleClick += Window1_DblClick;
            Create += Window1_Create;
            SysKeyDown += Window1_SysKeyDown;
            KeyDown += Window1_KeyDown;
            this.MouseMove += Window1_MoseMove;
        }

        private void TextBox_KeyPress(object sender, NativeKeyEventArgs e)
        {
           if(e.Key == (uint)VirtualKeys.VK_RETURN )
            {
                MessageBox.Show(this.Handle, "Return Pressed", "Return");
                e.Handled = true;
            }
        }

        private void Window1_KeyDown(object sender, NativeKeyEventArgs e)
        {
            if (e.Key == (int)KeyCode.KeyA)
            {
                MessageBox.Show(this.Handle, "A pressed", "F4");
            }
        }

        private unsafe uint GetVal(int index)
        {
            int* p = &index;
            uint* pp = (uint*)p;
            return *pp;
        }
        private void Window1_SysKeyDown(object sender, NativeKeyEventArgs e)
        {
            if (e.IsAlt && e.VirtalKey == VirtualKeys.VK_F5)
            {
                int i = (0 - 740);
                Debug.Print("DTN_FIRST=>0x" + i.ToString("x4"));
                i = (0 - 745);
                Debug.Print("DTN_LAST=>0x" + i.ToString("x4"));
                i = (0 - 753);
                Debug.Print("DTN_FIRST2=>0x" + i.ToString("x4"));
                i = (0 - 799);
                Debug.Print("DTN_LAST2=>0x" + i.ToString("x4"));

                MessageBox.Show(this.Handle, "F4 pressed", "F4");
                e.Handled = true;
            }
        }

        private void Window1_MoseMove(object sender, MouseMoveEventArgs e)
        {
            this.Text = CAPTION + ":" + e.Point.X + "," + e.Point.Y;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            OpenFolderDialog ofd = new OpenFolderDialog();
            ofd.Caption = "Select your Folder";
            ofd.InitialPath = "C:\\tmp";
            bool retVal = ofd.Show(this);
            if(retVal)
            {
                this._TextBox.Text = ofd.SelectedPath;
            }
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
        
            this._Button3.Visible = !this._Button3.Visible;
           
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
            win2.StartUpPosition = WindowsStartupPosition.CenterScreen;
            win2.ShowModal(this);
            MessageBox.Show("Nach Show");
        }

        private void Window1_Click(object sender, MouseClickEventArgs e)
        {

        }
    }
}
