using System;
using System.Runtime.InteropServices;
using System.Security;
// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming

namespace CoreWindowsWrapper.Api.Ole
{
    internal enum WebBrowserReadyState
    {
        Uninitialized,
        Loading,
        Loaded,
        Interactive,
        Complete
    }

    internal enum OLECMDF
    {
        OLECMDF_SUPPORTED = 1,
        OLECMDF_ENABLED = 2,
        OLECMDF_LATCHED = 4,
        OLECMDF_NINCHED = 8,
        OLECMDF_INVISIBLE = 16,
        OLECMDF_DEFHIDEONCTXTMENU = 32
    }

    internal enum OLECMDID
    {
        OLECMDID_SAVEAS = 4,
        OLECMDID_PRINT = 6,
        OLECMDID_PRINTPREVIEW = 7,
        OLECMDID_PAGESETUP = 8,
        OLECMDID_PROPERTIES = 10
    }

    internal enum OLECMDEXECOPT
    {
        OLECMDEXECOPT_DODEFAULT,
        OLECMDEXECOPT_PROMPTUSER,
        OLECMDEXECOPT_DONTPROMPTUSER,
        OLECMDEXECOPT_SHOWHELP
    }

   [Guid("D30C1661-CDAF-11d0-8A3E-00C04FC9E26E")]
        [SuppressUnmanagedCodeSecurity]
        [TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDual | TypeLibTypeFlags.FOleAutomation)]
        internal interface IWebBrowser2
        {
            [DispId(555)]
            bool AddressBar
            {
                get;
                set;
            }

            [DispId(200)]
            object Application
            {
                get;
            }

            [DispId(212)]
            bool Busy
            {
                get;
            }

            [DispId(202)]
            object Container
            {
                get;
            }

            [DispId(203)]
            object Document
            {
                get;
            }

            [DispId(400)]
            string FullName
            {
                get;
            }

            [DispId(407)]
            bool FullScreen
            {
                get;
                set;
            }

            [DispId(209)]
            int Height
            {
                get;
                set;
            }

            [DispId(-515)]
            int HWND
            {
                get;
            }

            [DispId(206)]
            int Left
            {
                get;
                set;
            }

            [DispId(210)]
            string LocationName
            {
                get;
            }

            [DispId(211)]
            string LocationURL
            {
                get;
            }

            [DispId(406)]
            bool MenuBar
            {
                get;
                set;
            }

            [DispId(0)]
            string Name
            {
                get;
            }

            [DispId(550)]
            bool Offline
            {
                get;
                set;
            }

            [DispId(201)]
            object Parent
            {
                get;
            }

            [DispId(401)]
            string Path
            {
                get;
            }

            [DispId(-525)]
            WebBrowserReadyState ReadyState
            {
                get;
            }

            [DispId(552)]
            bool RegisterAsBrowser
            {
                get;
                set;
            }

            [DispId(553)]
            bool RegisterAsDropTarget
            {
                get;
                set;
            }

            [DispId(556)]
            bool Resizable
            {
                get;
                set;
            }

            [DispId(551)]
            bool Silent
            {
                get;
                set;
            }

            [DispId(403)]
            bool StatusBar
            {
                get;
                set;
            }

            [DispId(404)]
            string StatusText
            {
                get;
                set;
            }

            [DispId(554)]
            bool TheaterMode
            {
                get;
                set;
            }

            [DispId(405)]
            int ToolBar
            {
                get;
                set;
            }

            [DispId(207)]
            int Top
            {
                get;
                set;
            }

            [DispId(204)]
            bool TopLevelContainer
            {
                get;
            }

            [DispId(205)]
            string Type
            {
                get;
            }

            [DispId(402)]
            bool Visible
            {
                get;
                set;
            }

            [DispId(208)]
            int Width
            {
                get;
                set;
            }

            [DispId(301)]
            void ClientToWindow(out int pcx, out int pcy);

            [DispId(502)]
            void ExecWB([In] OLECMDID cmdID, [In] OLECMDEXECOPT cmdexecopt, ref object pvaIn, IntPtr pvaOut);

            [DispId(303)]
            object GetProperty([In] string property);

            [DispId(100)]
            void GoBack();

            [DispId(101)]
            void GoForward();

            [DispId(102)]
            void GoHome();

            [DispId(103)]
            void GoSearch();

            [DispId(104)]
            void Navigate([In] string Url, [In] ref object flags, [In] ref object targetFrameName, [In] ref object postData, [In] ref object headers);

            [DispId(500)]
            void Navigate2([In] ref object URL, [In] ref object flags, [In] ref object targetFrameName, [In] ref object postData, [In] ref object headers);

            [DispId(302)]
            void PutProperty([In] string property, [In] object vtValue);

            [DispId(501)]
            OLECMDF QueryStatusWB([In] OLECMDID cmdID);

            [DispId(300)]
            void Quit();

            [DispId(-550)]
            void Refresh();

            [DispId(105)]
            void Refresh2([In] ref object level);

            [DispId(503)]
            void ShowBrowserBar([In] ref object pvaClsid, [In] ref object pvarShow, [In] ref object pvarSize);

            [DispId(106)]
            void Stop();
        }
}
