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
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    // TODO: verwalteten Zustand (verwaltete Objekte) entsorgen.
                    
                }

       
                this.disposedValue = true;
            }
        }

       
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion

    }
}