using System;
using System.Collections.Generic;

namespace CoreWindowsWrapper
{

    public class MenuItemCollection : Dictionary<int, IMenuItem>, IDisposable
    {
        public void Add(IMenuItem menuItem)
        {
            if (menuItem.Id <= 0)
            {
                Win32ApiForm.Win32Control.LastControlId+=1;
                menuItem.Id = Win32ApiForm.Win32Control.LastControlId;
            }
            base.Add(menuItem.Id, menuItem);
        }

        
        #region IDisposable Support
        private bool disposedValue = false; // Dient zur Erkennung redundanter Aufrufe.

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: verwalteten Zustand (verwaltete Objekte) entsorgen.
                    
                }

       
                disposedValue = true;
            }
        }

       
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion

    }

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
                if (this._ParentWindow.Handle != IntPtr.Zero)
                {
                    ctrl.Create(this._ParentWindow.Handle);
                }
            }

            if (this._ParentControl != null)
            {
                if (this._ParentControl.Handle != IntPtr.Zero)
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