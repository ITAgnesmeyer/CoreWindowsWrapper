using System;
using CoreWindowsWrapper;
using Diga.NativeControls.WebBrowser;

namespace ConsoleCaller
{
    public class Window2 : NativeWindow
    {
        private NativeWebBrowser _WebBrowser;
        private NativeButton _Button;
        private NativeLink _Link;
        private NativeGroupBox _GroupBox;
        private  int lastLeft = 1;
        private  int LastTop = 1;

        public Window2(NativeWindow parent):base(parent)
        {
            
        }
        //public Window2(NativeWindow parent) : base(parent)
        //{

        //}
        protected override void InitControls()
        {
            this.Text = "Dies ist ein 2. Fenster";
            this.Name = "Window2";
            this.Left = 100;
            this.Top = 100;
            this.Width = 600;
            this.Height = 400;
           
            this.Click += Window2_Click;
            this.DoubleClick += Window2_DblClick;
            this.Create += Window2_Create;
            this._WebBrowser = new NativeWebBrowser();
            this._WebBrowser.Location = new Diga.Core.Api.Win32.Point(100,100);
            this._WebBrowser.Width = 200;
            this._WebBrowser.Height = 200;
            this._WebBrowser.Url = "https://www.google.de";

            this._Button = new NativeButton();
            this._Button.Left = 100;
            this._Button.Top =100;
            this._Button.Width = 100;
            this._Button.Height = 30;
            this._Button.Text = "Add a Button";
            this._Button.Name = "nativeButton";
            this._Button.Clicked += Button_AddButton;

            this._Link = new NativeLink();
            this._Link.Left = 200;
            this._Link.Top = 100;
            this._Link.Width = 300;
            this._Link.Height = 25;
            this._Link.Text = "For more information, <A ID=\"TEST\" HREF=\"https://www.microsoft.com\">click here</A> or <A ID=\"idInfo\">here</A>.";
            this._Link.LinkClicked += Link_Clicked;
            this._Link.Font = new Font() {Name = "Arial", Size = 12};

            this._GroupBox = new NativeGroupBox();
            this._GroupBox.Left = 100;
            this._GroupBox.Top = 250;
            this._GroupBox.Width = 300;
            this._GroupBox.Height = 100;
            this._GroupBox.Text = "TEST";
            

            this.Controls.Add(this._WebBrowser);
            this.Controls.Add(this._Button);
            this.Controls.Add(this._Link);
            this.Controls.Add(this._GroupBox);

        }

        private void Link_Clicked(object sender, NativeLinkClickEventArgs e)
        {
            MessageBox.Show("ID: " + e.Id +  "\nUlr: " + e.Url);
        }

        private void Button_AddButton(object sender, EventArgs e)
        {
            NativeButton bn = new NativeButton();
            bn.Left = this.lastLeft;
            bn.Top = this.LastTop;
            bn.Height = 30;
            bn.Width = 100;
            this.lastLeft += bn.Width + 5;
            this.LastTop += bn.Height + 5;
            bn.Text = "Button" + this.lastLeft;
            bn.ForeColor = CoreWindowsWrapper.Tools.ColorTool.Blue;
            bn.BackColor = CoreWindowsWrapper.Tools.ColorTool.White;
            bn.Name = bn.Text;
            bn.Clicked += CreatedButton_Clicked;
            this.Controls.Add(bn);
        }

        private void CreatedButton_Clicked(object sender, EventArgs e)
        {
            NativeButton bn = sender as NativeButton;
            if (bn != null)
            {
                MessageBox.Show("Button Click=>" + bn.Name);
            }
            
        }

        private void Window2_Create(object sender, CreateEventArgs e)
        {
            
        }

        private void Window2_DblClick(object sender, MouseClickEventArgs e)
        {
            MessageBox.Show("BrowserID:" + this._WebBrowser.Handle.ToInt32());
            this.Close();
        }

        private void Window2_Click(object sender, MouseClickEventArgs e)
        {
            
        }
    }
}