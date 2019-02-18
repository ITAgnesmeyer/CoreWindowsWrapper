using System;
using System.Collections.Generic;

namespace CoreWindowsWrapper
{


    public class ControlCollection : Dictionary<int, IControl>,IDisposable
    {
        private Win32ApiForm.Win32Window _ParentWindow;

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
                if (this._ParentWindow.Handle != IntPtr.Zero)
                {
                    ctrl.Create(this._ParentWindow.Handle);
                }
            }
        }

        public void Dispose()
        {
            this._ParentWindow = null;

        }
    }
}