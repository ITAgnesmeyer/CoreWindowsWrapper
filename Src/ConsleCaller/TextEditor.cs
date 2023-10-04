using System.IO;
using System.Text;
using CoreWindowsWrapper;

namespace ConsoleCaller
{
    class TextEditor : NativeWindow
    {
        private NativeRichTextBox _TextBox;
        private string _CurrentFileName;


        protected override void InitControls()
        {
            this.Text = "Little Editor";
            this.Name = "MainWindow";
            this.StatusBar = true;
            this._TextBox = new NativeRichTextBox {Left = 0, Top = 0, Width = 480, Height = 380};
            this.Width = 500;
            this.Height = 400;
            this.StartUpPosition = WindowsStartupPosition.CenterScreen;
            
            //Creating the File Menu
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
            //Add the first Element of the Menu to the Form
            this.Menu = menuFile;

            this.Controls.Add(this._TextBox);
        }

        public override void OnKeyDown(NativeKeyEventArgs e)
        {
            if (e.VirtalKey == Diga.Core.Api.Win32.VirtualKeys.VK_F11)
            {
                this.SetWindowState(WindowState.Maximized);

            }
            base.OnKeyDown(e);

        }

        private async void FileSave_Click(object sender, MouseClickEventArgs e)
        {
            if (string.IsNullOrEmpty(this._CurrentFileName))
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Title = "Save file as...",
                    Filter = "All Files(*.*)\0*.*\0Text(*.txt)\0*.txt\0",
                    DefaultFilterIndex = 2
                };
                if (sfd.Show(this))
                {
                    this._CurrentFileName = sfd.File;
                    string text = this._TextBox.Text;
                   
                    await File.WriteAllTextAsync(this._CurrentFileName, text);
                    this.Text = "Little Edit:" + this._CurrentFileName;
                }
            }
            else
            {
                string text = this._TextBox.Text;
                File.WriteAllText(this._CurrentFileName, text);
                this.Text = "Little Edit:" + this._CurrentFileName;
            }
        }



        private async void FileOpen_Click(object sender, MouseClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Open a Text File...",
                Filter = "All File(*.*)\0*.*\0Text(*.txt)\0*.txt\0",
                DefaultFilterIndex = 2
            };

            //Title of the Dialog

            //All Values have to be separated with \0 

            //Shows Text(*.txt) as default

            //Show the Dialog modal to the current Form.
            if (ofd.Show(this))
            {
                this._TextBox.Enabled = false;
                //Read the selected Path
                string fileName = ofd.File;
                //File Actions.
                byte[] b = await File.ReadAllBytesAsync(fileName);

                string text = Encoding.ASCII.GetString(b);  //await File.ReadAllTextAsync(fileName);
                this._CurrentFileName = fileName;
                this._TextBox.Text = text;
                //this._TextBox.Load(fileName);
                this._TextBox.Enabled = true;
                this.Text = "Little Edit:" + fileName;
            }
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
            Diga.Core.Api.Win32.Rect rect = this.GetClientRect();
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
