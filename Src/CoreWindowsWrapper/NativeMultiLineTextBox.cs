using System;
using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeMultiLineTextBox : NativeTextBox
    {
        protected override void Initialize()
        {
            base.Initialize();
            this.ControlType = Win32ApiForm.ControlType.Edit;
            this.Style = this.Style | EditBoxStyles.ES_MULTILINE | WindowStylesConst.WS_HSCROLL | WindowStylesConst.WS_VSCROLL | WindowStylesConst.WS_VISIBLE;
            this.BackColor = Tools.ColorTool.White;
            this.ForeColor = Tools.ColorTool.Black;
            this.Font = new Font() { Name = "Arial", Size = 10 };
        }

        public override bool Create(IntPtr parentId)
        {
            bool retVal= base.Create(parentId);
            User32.SendMessage(this.Handle, EditBoxMessages.EM_SETLIMITTEXT, 0, int.MaxValue);
            return retVal;

        }
    }
}