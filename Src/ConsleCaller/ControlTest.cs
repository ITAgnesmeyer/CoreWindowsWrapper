using CoreWindowsWrapper;
namespace ConsleCaller
{
    public class ControlTest: NativeContainerControl 
    {
        private NativeTextBox _TextBox;
        private NativeButton _Button;

      
        protected override void Initialize()
        {
            base.Initialize();

            this._TextBox = new NativeTextBox();
            this._Button = new NativeButton();
            this._TextBox.Width = this.Width - 20;
            this._TextBox.Height = this.Height;
            this._TextBox.Left = 0;
            this._TextBox.Top = 0;
            this._Button.Width = 20;
            this._Button.Height = this.Height;
            this._Button.Left = this._TextBox.Width;
            this._Button.Top = 0;
            this._Button.Text = "...";
            
            this.Controls.Add(this._TextBox);
            this.Controls.Add(this._Button);

        }

        
    }
}