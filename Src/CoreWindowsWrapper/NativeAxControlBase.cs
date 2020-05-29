using System;
using CoreWindowsWrapper.Win32ApiForm;

namespace CoreWindowsWrapper
{

    public class NativeAxControlBase: NativeControlBase
    {


        //public IUnknown Unknown { get; private set; }
        //public NativeAxControlBase()
        //{
        //    this.Initialize();
        //}
        protected override void Initialize()
        {

            this.Control = new Win32AxControl();

            
        }

        public override bool Create(IntPtr parentId)
        {
            bool retVal = base.Create(parentId);
            //IWebBrowser2 webBroswer;
            //GUID CLSID_WebBrowser = new GUID();
            //IntPtr strPtr =  Marshal.StringToHGlobalUni("{8856F961-340A-11D0-A96B-00C04FD705A2}");
            //NativeMethods.IIDFromString(strPtr,ref CLSID_WebBrowser);
            //Marshal.FreeHGlobal(strPtr);
            //GUID IID_IUnknown = new GUID();
            //strPtr =  Marshal.StringToHGlobalUni("{00000000-0000-0000-C000-000000000046}");
            //IntPtr initVal = new IntPtr(0);
            //NativeMethods.IIDFromString(strPtr,ref IID_IUnknown);
            //Marshal.FreeHGlobal(strPtr);

            //NativeMethods.CoInitialize(initVal);
            //Guid cGuid = new Guid("{8856F961-340A-11D0-A96B-00C04FD705A2}");
            //Type test = Type.GetTypeFromCLSID(cGuid);
            //object testObj = Activator.CreateInstance(test);

            //IWebBrowser2 wb = (IWebBrowser2) testObj;
            //webBroswer = wb;
            ////object obj = NativeMethods.CoCreateInstance(ref CLSID_WebBrowser, null, 1 , ref IID_IWebBrowser2);
            //IUnknownVtbl vtbl = new IUnknownVtbl();

            //StrktIUnknown unk = new StrktIUnknown();

            //IntPtr vtIntPtr =  Marshal.AllocHGlobal(Marshal.SizeOf(vtbl));
            //unk.lpVtbl = vtIntPtr;

            //IntPtr pnt = Marshal.AllocHGlobal(Marshal.SizeOf(unk));

            //IntPtr outer = IntPtr.Zero;
            //int val = NativeMethods.CoCreateInstance(ref CLSID_WebBrowser,ref outer, (uint)(1 | 2 | 4 | 16), ref IID_IUnknown,
            //    ref pnt);

            //webBroswer = Marshal.PtrToStructure<IWebBrowser2>(pnt);
            //IntPtr nPtr = new IntPtr(0);
            //int ret = NativeMethods.CoInitialize(0);

            //NativeMethods.AtlAxAttachControl(webBroswer, this.Handle, IntPtr.Zero);
            //IntPtr hDll = NativeMethods.LoadLibrary("atl.dll");
            //NativeMethods.PAttachControl func = NativeMethods.GetProcAddress(hDll, "AtlAxAttachControl");
            //object obj = webBroswer;
            //func.Invoke(obj, this.Handle, IntPtr.Zero);
            //webBroswer.GoHome();
            //object nullObj = null;
            //webBroswer.Navigate("www.google.de",ref nullObj,ref nullObj,ref nullObj,ref nullObj);


            //Marshal.FreeHGlobal(pnt);
            //Marshal.FreeHGlobal(vtIntPtr);
            return retVal;

        }
    }
}