using System;
using System.Collections.Generic;

namespace CoreWindowsWrapper
{
    public class ControlCollection : Dictionary<int, IControl>,IDisposable
    {
        private Win32ApiForm.Win32Window _ParentWindow;
        private Win32ApiForm.Win32Control _ParentControl;

        internal ControlCollection(Win32ApiForm.Win32Control parent)
        {
            this._ParentControl = parent;
        }
        internal ControlCollection(Win32ApiForm.Win32Window parent)
        {
            this._ParentWindow = parent;
        }
        public void Add(IControl contorl)
        {
            IControl ctrl = contorl;
            if(ctrl.ControlId <= 0)
            {
                Win32ApiForm.Win32Control.LastControlId+=1;
                ctrl.ControlId = Win32ApiForm.Win32Control.LastControlId;
            }
            
            base.Add(ctrl.ControlId , contorl);

            if (this._ParentWindow != null)
            {
                if (this._ParentWindow.Handle.IsValid)
                {
                    ctrl.Create(this._ParentWindow.Handle);
                }
            }

            if (this._ParentControl != null)
            {
                if (this._ParentControl.Handle.IsValid)
                {
                    ctrl.Create(this._ParentControl.Handle);
                }
            }
        }

        public void Dispose()
        {
            this._ParentWindow = null;
            this._ParentControl = null;

        }
    }
}