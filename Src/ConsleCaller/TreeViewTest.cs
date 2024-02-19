using System;
using CoreWindowsWrapper;
using CoreWindowsWrapper.Tools;

namespace ConsoleCaller
{
    class TreeViewTest :NativeWindow
    {
        private NativeImageList _ImageList;
        private NativeButton _Button;
        private NativeTreeView _TreeView;
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
                Left = 0,
                Top = 40,
                Width = 400,
                Height = 400

            };
            
            this.Controls.Add(this._Button);
            this.Controls.Add(this._ImageList);
            this.Controls.Add(this._TreeView);

        }

        protected override void OnCreate(CreateEventArgs e)
        {
            base.OnCreate(e);
            NativeApp.DoEvents();
            
            this._TreeView.SetImageList(this._ImageList);

            var rect = this.GetClientRect();
            this._TreeView.Width = rect.Width;

        }
        
        protected override void OnSize(SizeEventArgs e)
        {
            this._TreeView.Width = e.Width/2;
            this._TreeView.Height = e.Height - this._TreeView.Top -10;
        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            IntPtr root = this._TreeView.AddItemToRoot("RootItem",0, -1, -1);
            IntPtr firstChild = this._TreeView.AddItem(root, "FirstChild",1);
            IntPtr secondChild = this._TreeView.AddItemAfter(root, firstChild, "SecondChild",2,-1,-1);
            IntPtr thirdChild = this._TreeView.AddItemAfter(root, firstChild, "ThirdChild", 3,-1,-1);
            this._TreeView.Expand(root);
        }

        
    }
}
