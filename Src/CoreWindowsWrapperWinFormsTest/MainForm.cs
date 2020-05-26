using System;
using System.Diagnostics;
using System.Windows.Forms;
using CoreWindowsWrapper;
using CoreWindowsWrapper.Tools;

namespace CoreWindowsWrapperWinFormsTest
{
    public partial class MainForm : Form
    {
        //private Window1 win;
        private CoreWindowsWrapper.NativeWindow _NativeWindow;
        private CoreWindowsWrapper.NativeWindow _Panel2Window;
        private CoreWindowsWrapper.NativeWindow _Panel1Window;
        private NativeButton _Button;
        private NativeButton _Button1;
        private NativeWebBrowser _WebBrowser;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

           

        }

        private void OnSize(object sender, SizeEventArgs e)
        {
            if (e.Width == 0) return;
            
            this._WebBrowser.Left = e.X;
            this._WebBrowser.Top = e.Y;
            this._WebBrowser.Width = e.Width;
            this._WebBrowser.Height = e.Height;
            this._WebBrowser.DoDock();
            this.Refresh();
        }

        private void MenuInfo_Click(object sender, MouseClickEventArgs e)
        {
            CoreWindowsWrapper.MessageBox.Show(this._NativeWindow.Handle,"MenuInfo!","API");
        }

        private void Menu_Exit(object sender, MouseClickEventArgs e)
        {
            CoreWindowsWrapper.MessageBox.Show(this._NativeWindow.Handle,"Close Application!","API");
            this.Close();
        }

        private void FileOpen_Click(object sender, MouseClickEventArgs e)
        {
            CoreWindowsWrapper.MessageBox.Show(this._NativeWindow.Handle,"MenuInfo!","API");
        }

        private void FileSave_Click(object sender, MouseClickEventArgs e)
        {
            CoreWindowsWrapper.MessageBox.Show(this._NativeWindow.Handle,"MenuInfo!","API");
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x004E)
                Debug.Print("Destroy");
            base.WndProc(ref m);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this._Panel1Window = new CoreWindowsWrapper.NativeWindow(this.panel1.Handle);
            this._Panel2Window = new CoreWindowsWrapper.NativeWindow(this.panel2.Handle);
            this._NativeWindow = new CoreWindowsWrapper.NativeWindow(this.Handle);
            this._Panel2Window.Size += OnSize;
            NativeMenu menuFile = new NativeMenu("mnuFile", "&File");
            
            //Create Sub-Items for File-Menu
            NativeMenuItem menuFileOpen = new NativeMenuItem("mnuOpen", "&Open");
            NativeMenuItem menuFileClose = new NativeMenuItem("mnuSave", "&Save");
            NativeMenuItem menuFileSep = new NativeMenuItem("mnuFileSep") {IsSeparator = true};
            NativeMenuItem menFileExit = new NativeMenuItem("mnuExit", "E&xit");

            //Add Menu Event Handlers
            menuFileClose.Click += FileSave_Click;
            menuFileOpen.Click += FileOpen_Click;
            menFileExit.Click += Menu_Exit;

            //Add The Sub-Items to File-Menu
            menuFile.Items.Add(menuFileOpen);
            menuFile.Items.Add(menuFileClose);
            menuFile.Items.Add(menuFileSep);
            menuFile.Items.Add(menFileExit);

            //Create Help-Menu
            NativeMenu menuHelp = new NativeMenu("&Help");
            //Add Sub-Item to Help-Menu
            NativeMenuItem menuInfo = new NativeMenuItem("&Info");
            //Add Event-Handler
            menuInfo.Click += MenuInfo_Click;
            //Add the Sub-Item to the Help-Menu
            menuHelp.Items.Add(menuInfo);
            //Add the Help-Menu to the File-Menu
            menuFile.Items.Add(menuHelp);
            this._NativeWindow.Menu = menuFile;
            this._NativeWindow.BackColor = CoreWindowsWrapper.Tools.ColorTool.White;


            this._Button = new NativeButton
            {
                Left = 10,
                Top = 0,
                Width = 100,
                Height = 30,
                Text = "<",
                Font = new Font(){Name="Segoe UI Symbol", Size= 15},
                Name = "bnTestA",
                BackColor = ColorTool.Blue,
                ForeColor = ColorTool.Green


            };

            this._Button.Font.Name = "Segoe UI ";

            this._Button1 = new NativeButton
            {
                Left = 150,
                Top = 0,
                Width = 100,
                Height = 30,
                Text = ">",
                Name = "bnTestB"//,
                //ControlId = 505
            };
            this._Button.Clicked += button_OnClicked;
            
            this._Button1.Clicked += button1_OnClicked;
         
            
            this._WebBrowser = new NativeWebBrowser()
            {
                Width = this._NativeWindow.Width,
                Height = this._NativeWindow.Height,
                Url = "http://www.itagnesmeyer.de",
                IsStatusBarEnabled = true,
                DefaultContextMenusEnabled = false,
                DevToolsEnabled = false
                
            };
           
            this._Panel2Window.Controls.Add(this._WebBrowser);
            this._Panel1Window.Controls.Add(this._Button);
            this._Panel1Window.Controls.Add(this._Button1);
            this._NativeWindow.PostCreateControls();
        }

      
        private void button1_OnClicked(object sender, EventArgs e)
        {
            CoreWindowsWrapper.MessageBox.Show(this._NativeWindow.Handle,"button1_OnClicked!","API");
        }

       

        private void button_OnClicked(object sender, EventArgs e)
        {
            CoreWindowsWrapper.MessageBox.Show(this._NativeWindow.Handle,"button_OnClicked!","API");
        }
    }



    public class Window1 : CoreWindowsWrapper.NativeChildWindow
    {
        private NativeButton ButtonOne;
        protected override void InitControls()
        {
            
            this.ButtonOne = new NativeButton();
            this.ButtonOne.Left = 10;
            this.ButtonOne.Top = 10;
            this.ButtonOne.Width = 99;
            this.ButtonOne.Height = 33;
            this.ButtonOne.Text = "ClickMe";
            this.ButtonOne.Clicked += OnButtonOne_Click;
            this.Controls.Add(this.ButtonOne);
        }

        private void OnButtonOne_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            
            System.Windows.Forms.NativeWindow nw =  System.Windows.Forms.NativeWindow.FromHandle(this.Handle);
            form.Show(nw);
            
            
           
        }
        
    }
}
