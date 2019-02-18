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
           
            this._TextBox = new NativeMultiLineTextBox();
            this._TextBox.Left = 0;
            this._TextBox.Top = 0;
            this.Width = 500;
            this.Height = 400;
            this.StartUpPosition = WindowsStartupPosition.CenterScreen;
           
            
            this.Controls.Add(this._TextBox);

        }

       
        protected override void OnSize(SizeEventArgs e)
        {
            base.OnSize(e);
            this._TextBox.Left = e.X;
            this._TextBox.Top = e.Y;
            this._TextBox.Width = e.Width;
            this._TextBox.Height = e.Height;
        }
  }
}
