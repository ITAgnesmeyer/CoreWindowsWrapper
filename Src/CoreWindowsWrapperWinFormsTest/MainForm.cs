using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreWindowsWrapper;
namespace CoreWindowsWrapperWinFormsTest
{
    public partial class MainForm : Form
    {
        private Window1 win;
        private CoreWindowsWrapper.NativeWindow nativeWindow;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            nativeWindow = new CoreWindowsWrapper.NativeWindow(this.Handle);
            nativeWindow.Size += OnSize;
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
            nativeWindow.Menu = menuFile;
            nativeWindow.BackColor = CoreWindowsWrapper.Tools.ColorTool.White;
            nativeWindow.PostCreateControls();

        }

        private void OnSize(object sender, SizeEventArgs e)
        {
            this.Refresh();
        }

        private void MenuInfo_Click(object sender, MouseClickEventArgs e)
        {
            CoreWindowsWrapper.MessageBox.Show(nativeWindow.Handle,"MenuInfo!","API");
        }

        private void Menu_Exit(object sender, MouseClickEventArgs e)
        {
            CoreWindowsWrapper.MessageBox.Show(nativeWindow.Handle,"MenuInfo!","API");
        }

        private void FileOpen_Click(object sender, MouseClickEventArgs e)
        {
            CoreWindowsWrapper.MessageBox.Show(nativeWindow.Handle,"MenuInfo!","API");
        }

        private void FileSave_Click(object sender, MouseClickEventArgs e)
        {
            CoreWindowsWrapper.MessageBox.Show(nativeWindow.Handle,"MenuInfo!","API");
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x004E)
                Debug.Print("Destroy");
            base.WndProc(ref m);

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
