using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    public class OleInPlaceFrame:IOleInPlaceFrame, IUnknown
    {
        public IntPtr QueryInterface(ref Guid riid)
        {
            throw new NotImplementedException();
        }

        public uint AddRef()
        {
            return 1;
        }

        public uint Release()
        {
            return 1;
        }

        public void GetWindow(out IntPtr phwnd)
        {
            phwnd = ((_OleInPlaceFrameEx) this).Window;
        }

        public void ContextSensitiveHelp([In] int fEnterMode)
        {
            throw new NotImplementedException();
        }

        public void GetBorder([MarshalAs(UnmanagedType.LPArray), Out] RECT[] lprectBorder)
        {
            throw new NotImplementedException();
        }

        public void RequestBorderSpace([In, MarshalAs(UnmanagedType.LPArray)] RECT[] pborderwidths)
        {
            throw new NotImplementedException();
        }

        public void SetBorderSpace([In, MarshalAs(UnmanagedType.LPArray)] RECT[] pborderwidths)
        {
            throw new NotImplementedException();
        }

        public void SetActiveObject([In, MarshalAs(UnmanagedType.Interface)] IOleInPlaceActiveObject pActiveObject, [In, MarshalAs(UnmanagedType.LPWStr)] string pszObjName)
        {
            throw new NotImplementedException();
        }

        public void InsertMenus([In] IntPtr hmenuShared, [In, MarshalAs(UnmanagedType.LPArray), Out] OLEMENUGROUPWIDTHS[] lpMenuWidths)
        {
            throw new NotImplementedException();
        }

        public void SetMenu([In] IntPtr hmenuShared, [In] IntPtr HOLEMENU, [In] IntPtr hwndActiveObject)
        {
            throw new NotImplementedException();
        }

        public void RemoveMenus([In] IntPtr hmenuShared)
        {
            throw new NotImplementedException();
        }

        public void SetStatusText([In, MarshalAs(UnmanagedType.LPWStr)] string pszStatusText)
        {
            throw new NotImplementedException();
        }

        public void EnableModeless([In] int fEnable)
        {
            throw new NotImplementedException();
        }

        public int TranslateAccelerator([In, MarshalAs(UnmanagedType.LPArray)] MSG[] lpmsg, [In] ushort wID)
        {
            throw new NotImplementedException();
        }
    }

   

}
