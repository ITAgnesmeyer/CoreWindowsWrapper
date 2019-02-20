using System;
using System.Collections.Generic;
using System.Text;
using CoreWindowsWrapper;

namespace ConsleCaller
{
    class Windows3 : NativeWindow
    {
        private NativeTextBox _TextBox;

        protected override void InitControls()
        {
            this.Text = "Little Editor";
            this._TextBox = new NativeMultiLineTextBox();
            this._TextBox.Left = 0;
            this._TextBox.Top = 0;
            this._TextBox.Width = 480;
            this._TextBox.Height = 380;
            this.Width = 500;
            this.Height = 400;
            this.StartUpPosition = WindowsStartupPosition.CenterScreen;

            //Creating the File Menu
            NativeMenu menuFile = new NativeMenu("mnuFile", "&File");
            
            //Create Sub-Items for File-Menu
            NativeMenuItem menuFileOpen = new NativeMenuItem("mnuOpen", "&Open");
            NativeMenuItem menuFileClose = new NativeMenuItem("mnuClose", "&Close Document");
            NativeMenuItem menuFileSep = new NativeMenuItem("mnuFileSep") {IsSeparator = true};
            NativeMenuItem menFileExit = new NativeMenuItem("mnuExit", "E&xit");

            //Add Menu Event Handlers
            menuFileClose.Click += FileClose_Click;
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
            menuHelp.Items.Add(menuInfo);
            menuFile.Items.Add(menuHelp);

            //Add the first Element of the Menu to the Form
            this.Menu = menuFile;

            this.Controls.Add(this._TextBox);
        }

        private void FileClose_Click(object sender, MouseClickEventArgs e)
        {
            MessageBox.Show(this.Handle, "FileClose_Click", "Info",
                MessageBoxOptions.IconInformation | MessageBoxOptions.OkOnly);
        }

        private void FileOpen_Click(object sender, MouseClickEventArgs e)
        {
            MessageBox.Show(this.Handle, "FileOpen_Click", "Info",
                MessageBoxOptions.IconInformation | MessageBoxOptions.OkOnly);
        }

        private void Menu_Exit(object sender, MouseClickEventArgs e)
        {
            this.Close();
        }

        private void MenuInfo_Click(object sender, MouseClickEventArgs e)
        {
            MessageBox.Show(this.Handle, "MenuInfo Clicked", "Info",
                MessageBoxOptions.IconInformation | MessageBoxOptions.OkOnly);
        }

        protected override void OnCreate(CreateEventArgs e)
        {
            base.OnCreate(e);
            CoreWindowsWrapper.Api.Win32.Rect rect = this.GetClientRect();
            this._TextBox.Left = rect.Left;
            this._TextBox.Top = rect.Top;
            this._TextBox.Width = rect.Width;
            this._TextBox.Height = rect.Height;
        }

        protected override void OnSize(SizeEventArgs e)
        {
            if (e.Width == 0) return;
            base.OnSize(e);
            this._TextBox.Left = e.X;
            this._TextBox.Top = e.Y;

            this._TextBox.Width = e.Width;
            this._TextBox.Height = e.Height;
        }
    }
}
