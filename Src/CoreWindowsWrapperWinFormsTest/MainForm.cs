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
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.win= new Window1();
            win.Show();

            


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
