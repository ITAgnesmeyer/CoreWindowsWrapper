using System;
using CoreWindowsWrapper;

namespace DIGAAppSetup
{
    internal partial class MainForm : NativeWindow
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFrom_Create(object sender, CreateEventArgs e)
        {
            this._MainProgress.Value = 50;
        }

        private void OkButton_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Clicked(object sender, EventArgs e)
        {
            MessageBox.Show("CancelButton_Clicked");
        }
    }


    internal partial class MainForm
    {
        private NativeButton _OkButton;
        private NativeButton _CancelButton;
        private NativeLabel _LabelCaption;
        private NativeLabel _LabelDescription;
        private NativeProgress _MainProgress;
        private NativeProgress _SecondProgress;

        protected void InitializeComponent()
        {
            this._OkButton = new NativeButton();
            this._CancelButton = new NativeButton();
            this._LabelCaption = new NativeLabel();
            this._LabelDescription = new NativeLabel();
            this._MainProgress = new NativeProgress();
            this._SecondProgress = new NativeProgress();
            //this.Left = 100;
            //this.Top = 100;

            this.Width = 542;
            this.Height = 300;
            this.BackColor = CoreWindowsWrapper.Tools.ColorTool.White;
            this.Name = "MainForm";
            this.Text = "Welcome to the Setup";
            //this.IconFile = "app.ico";
            this.StartUpPosition = WindowsStartupPosition.CenterScreen;
            this.Create += MainFrom_Create;
            //_LabelCaption
            this._LabelCaption.Left = 12;
            this._LabelCaption.Top = 9;
            this._LabelCaption.Width = 498;
            this._LabelCaption.Height = 49;
            this._LabelCaption.Text = "Welcome to the Setup &s";
            this._LabelCaption.Name = "LabelCaption";
            this._LabelCaption.ForeColor = CoreWindowsWrapper.Tools.ColorTool.Blue;
            this._LabelCaption.Font = new Font(){Name = "Arial",Size=15,Bold = true};

            this._LabelDescription.Left = 12;
            this._LabelDescription.Top = 58;
            this._LabelDescription.Width = 498;
            this._LabelDescription.Height = 78;
            this._LabelDescription.Text = "Do you want to start the Installation?";
            this._LabelDescription.Name = "LabelDescription";
            this._LabelDescription.Font = new Font(){Name = "Arial", Size=12, Italic= true};
            

            this._MainProgress.Left = 12;
            this._MainProgress.Top = 161;
            this._MainProgress.Width = 498;
            this._MainProgress.Height = 14;
            
            this._MainProgress.Name = "MainProgress";

            this._SecondProgress.Left = 12;
            this._SecondProgress.Top = 191;
            this._SecondProgress.Width = 498;
            this._SecondProgress.Height = 14;
            this._SecondProgress.Name = "SecondProgress";

            this._CancelButton.Left = 320;
            this._CancelButton.Top = 220;
            this._CancelButton.Width = 92;
            this._CancelButton.Height = 29;
            this._CancelButton.Text = "Cancel";
            this._CancelButton.Name = "CancelButton";
            this._CancelButton.ForeColor = CoreWindowsWrapper.Tools.ColorTool.Yellow;
            this._CancelButton.Font = new Font(){Size=11,Bold=true};

            this._CancelButton.Clicked += CancelButton_Clicked;
            this._OkButton.Left = 418;
            this._OkButton.Top = 220;
            this._OkButton.Width = 92;
            this._OkButton.Height = 29;
            this._OkButton.Text = "OK";
            this._OkButton.Name = "OkButton";
            this._OkButton.Clicked += OkButton_Clicked;

            this.Controls.Add(this._LabelCaption);
            this.Controls.Add(this._LabelDescription);
            this.Controls.Add(this._MainProgress);
            this.Controls.Add(this._SecondProgress);
            this.Controls.Add(this._CancelButton);

            this.Controls.Add(this._OkButton);
        }
    }
}
