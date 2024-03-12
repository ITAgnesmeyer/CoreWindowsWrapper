using System;
using System.Diagnostics;
using CoreWindowsWrapper;
using CoreWindowsWrapper.Tools;
using Diga.Core.Api.Win32;

namespace ConsoleCaller
{
    class TreeViewTest : NativeWindow
    {
        private NativeImageList _ImageList;
        private NativeButton _Button;
        private NativeTreeView _TreeView;
        private NativeTextBox txtOldValue;
        private NativeTextBox txtNewValue;
        protected override void InitControls()
        {
            this.Text = "TreeView Test";
            this.BackColor = ColorTool.White;
            this._Button = new NativeButton
            {
                Left = 0,
                Top = 0,
                Height = 30,
                Width = 255,
                Text = "Fill"
            };

            this._Button.Clicked += OnButtonClicked;
            this._ImageList = new NativeImageList();
            this._ImageList.AddIconRes(102);
            this._ImageList.AddIconRes(103);
            this._ImageList.AddIconRes(104);
            this._ImageList.AddIconRes(105);
            int count = this._ImageList.ImageCount;
            this._TreeView = new NativeTreeView
            {

                Anchor = AnchorType.Left | AnchorType.Right | AnchorType.Top | AnchorType.Bottom,
                Left = 0,
                Top = 40,
                Width = 400,
                Height = 400

            };
            this._TreeView.Changed += TreeView_Changed;

            this.txtOldValue = new NativeTextBox
            {
                
                Anchor = AnchorType.Top | AnchorType.Right,
                Location = new Point(410, 40),
                Size = new Size(150, 30)
            };
            this.txtOldValue.Style |= WindowStylesConst.WS_BORDER;
            this.txtNewValue = new NativeTextBox
            {
                Anchor = AnchorType.Top | AnchorType.Right,
                Location = new Point(410, 75),
                Size = new Size(150, 30)
            };
            this.txtNewValue.Style |= WindowStylesConst.WS_BORDER;
            this.Controls.Add(this._Button);
            this.Controls.Add(this._ImageList);
            this.Controls.Add(this._TreeView);
            this.Controls.Add(this.txtOldValue);
            this.Controls.Add(this.txtNewValue);

        }

        private void TreeView_Changed(object sender, TreeViewChagneEventArgs e)
        {

            this.txtOldValue.Text = $"old key({e.OldKey}):{e.OldItem.pszText}";
            this.txtNewValue.Text = $"new key({e.NewKey}):{e.NewItem.pszText}";

        }

        protected override void OnCreate(CreateEventArgs e)
        {
            base.OnCreate(e);
            NativeApp.DoEvents();

            this._TreeView.SetImageList(this._ImageList);

            //var rect = this.GetClientRect();
            //this._TreeView.Width = rect.Width;

        }

        protected override void OnSize(SizeEventArgs e)
        {
            //this._TreeView.Width = e.Width / 2;
            //this._TreeView.Height = e.Height - this._TreeView.Top - 10;
        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            this._TreeView.Clear();
            IntPtr root = this._TreeView.AddItemToRoot("RootItem", 0, -1, -1);
            IntPtr firstChild = this._TreeView.AddItem(root, "FirstChild", 1);
            IntPtr secondChild = this._TreeView.AddItemAfter(root, firstChild, "SecondChild", 2, -1, -1);
            IntPtr thirdChild = this._TreeView.AddItemAfter(root, firstChild, "ThirdChild", 3, -1, -1);
            IntPtr forthChild = this._TreeView.AddItemToRoot("ForthChild", 1);
            IntPtr fifthChild = this._TreeView.AddItem(forthChild, "FifthChild", 2);
            this._TreeView.Expand(root);
        }


    }
}
