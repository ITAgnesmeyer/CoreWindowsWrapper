using System;
using System.Diagnostics;
using CoreWindowsWrapper;
using CoreWindowsWrapper.Tools;
using Diga.Core.Api.Win32;

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
            this._TreeView.Changed += TreeView_Changed;
            this.Controls.Add(this._Button);
            this.Controls.Add(this._ImageList);
            this.Controls.Add(this._TreeView);

        }

        private void TreeView_Changed(object sender, TreeViewChagneEventArgs e)
        {
            
           
            var nItem = new TVITEMEXW();
            nItem.mask = TreeViewConst.TVIF_TEXT | TreeViewConst.TVIF_IMAGE | TreeViewConst.TVIF_EXPANDEDIMAGE | TreeViewConst.TVIF_SELECTEDIMAGE | TreeViewConst.TVIF_CHILDREN | TreeViewConst.TVIF_PARAM;
            nItem.pszText = new string('\0', 1000);
            nItem.hItem = e.NewItem.hItem;
            nItem.cchTextMax = 1000;
            nItem.hwnd = this._TreeView.Handle;
            

            if (TreeViewMacros.TreeView_GetItem(this._TreeView.Handle, ref nItem))
            {
                Debug.Print(nItem.pszText);
            }

            
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
            IntPtr forthChild = this._TreeView.AddItemToRoot("ForthChild", 1);
            IntPtr fifthChild = this._TreeView.AddItem(forthChild, "FifthChild", 2);
            this._TreeView.Expand(root);
        }

        
    }
}
