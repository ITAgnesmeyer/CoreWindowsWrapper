using System;

namespace CoreWindowsWrapper.Api.Ole
{
    public class tagCONNECTDATA
	  {
		public IUnknown pUnk {get; set;}
		public uint dwCookie {get; set;}
	  }
 
    	public class _IOleInPlaceFrameEx
	{
		public IOleInPlaceFrame frame {get; set;} = new IOleInPlaceFrame(); // The IOleInPlaceFrame must be first!

		///////////////////////////////////////////////////
		// Here you add any variables that you need
		// to access in your IOleInPlaceFrame functions.
		// You don't want those functions to access global
		// variables, because then you couldn't use more
		// than one browser object. (ie, You couldn't have
		// multiple windows, each with its own embedded
		// browser object to display a different web page).
		//
		// So here is where I added my extra HWND that my
		// IOleInPlaceFrame function Frame_GetWindow() needs
		// to access.
		///////////////////////////////////////////////////
		public HWND__ window {get; set;}
	}

    public class __IOleInPlaceSiteEx
	{
		public IOleInPlaceSite inplace {get; set;} = new IOleInPlaceSite(); // My IOleInPlaceSite object. Must be first.

		///////////////////////////////////////////////////
		// Here you add any variables that you need
		// to access in your IOleInPlaceSite functions.
		// You don't want those functions to access global
		// variables, because then you couldn't use more
		// than one browser object. (ie, You couldn't have
		// multiple windows, each with its own embedded
		// browser object to display a different web page.
		//
		// So here is where I added my extra pointer to my
		// IOleInPlaceFrame struct.
		///////////////////////////////////////////////////
		public _IOleInPlaceFrameEx frame {get; set;}
	}


    public class __IOleClientSiteEx
	{
		public IOleClientSite client {get; set;} = new IOleClientSite(); // My IOleClientSite object. Must be first.
		public __IOleInPlaceSiteEx inplace {get; set;} = new __IOleInPlaceSiteEx(); // My IOleInPlaceSite object.

		///////////////////////////////////////////////////
		// Here you add any variables that you need
		// to access in your IOleClientSite functions.
		///////////////////////////////////////////////////

	}



    internal class Implentations
    {
        
        private const int S_OK=0;
        private const int S_FALSE=1;
        private const long E_NOTIMPLEMENTED=0x80004001L;
        private const long E_NOINTERFACE=0x80004002L;
    /// Return Type: int
    ///_Buf1: void*
    ///_Buf2: void*
    ///_Size: size_t->unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("ntdll.dll", EntryPoint="memcmp", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
public static extern  int memcmp([System.Runtime.InteropServices.InAttribute()] System.IntPtr _Buf1, [System.Runtime.InteropServices.InAttribute()] System.IntPtr _Buf2, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysUInt)] uint _Size) ;


        public static IOleInPlaceSiteVtbl MyIOleInPlaceSiteTable = new IOleInPlaceSiteVtbl() {QueryInterface = Site_QueryInterface, AddRef = Site_AddRef, Release = Site_Release, GetWindow = Site_GetWindow, ContextSensitiveHelp = Site_ContextSensitiveHelp, CanInPlaceActivate = Site_CanInPlaceActivate, OnInPlaceActivate = Site_OnInPlaceActivate, OnUIActivate = Site_OnUIActivate, GetWindowContext = Site_GetWindowContext, Scroll = Site_Scroll, OnUIDeactivate = Site_OnUIDeactivate, OnInPlaceDeactivate = Site_OnInPlaceDeactivate, DiscardUndoState = Site_DiscardUndoState, DeactivateAndUndo = Site_DeactivateAndUndo, OnPosRectChange = Site_OnPosRectChange};

        private static int Site_OnPosRectChange(ref IOleInPlaceSite This, ref tagRECT lprcPosRect)
        {
            throw new NotImplementedException();
        }

        private static int Site_DeactivateAndUndo(ref IOleInPlaceSite This)
        {
            throw new NotImplementedException();
        }

        private static int Site_DiscardUndoState(ref IOleInPlaceSite This)
        {
            throw new NotImplementedException();
        }

        private static int Site_OnInPlaceDeactivate(ref IOleInPlaceSite This)
        {
            throw new NotImplementedException();
        }

        private static int Site_OnUIDeactivate(ref IOleInPlaceSite This, bool fUndoable)
        {
            throw new NotImplementedException();
        }

        private static int Site_Scroll(ref IOleInPlaceSite This, tagSIZE scrollExtant)
        {
            throw new NotImplementedException();
        }

        private static int Site_GetWindowContext(ref IOleInPlaceSite This, ref IntPtr ppFrame, ref IntPtr ppDoc, ref tagRECT lprcPosRect, ref tagRECT lprcClipRect, ref tagOIFI lpFrameInfo)
        {
            throw new NotImplementedException();
        }

        private static int Site_OnUIActivate(ref IOleInPlaceSite This)
        {
            throw new NotImplementedException();
        }

        private static int Site_OnInPlaceActivate(ref IOleInPlaceSite This)
        {
            throw new NotImplementedException();
        }

        private static int Site_CanInPlaceActivate(ref IOleInPlaceSite This)
        {
            throw new NotImplementedException();
        }

        private static int Site_ContextSensitiveHelp(ref IOleInPlaceSite This, bool fEnterMode)
        {
            throw new NotImplementedException();
        }

        private static int Site_GetWindow(ref IOleInPlaceSite This, ref IntPtr phwnd)
        {
            throw new NotImplementedException();
        }

        private static uint Site_Release(ref IOleInPlaceSite This)
        {
            throw new NotImplementedException();
        }

        private static uint Site_AddRef(ref IOleInPlaceSite This)
        {
            throw new NotImplementedException();
        }

        private static int Site_QueryInterface(ref IOleInPlaceSite This, ref GUID riid, ref IntPtr ppvObject)
        {
 //           		// It just so happens that the first arg passed to us is our _IOleClientSiteEx struct we allocated
	//		// and passed to DoVerb() and OleCreate(). Nevermind that 'This' is declared is an IOleClientSite *.
	//		// Remember that in EmbedBrowserObject(), we allocated our own _IOleClientSiteEx struct, and lied
	//		// to OleCreate() and DoVerb() -- passing our _IOleClientSiteEx struct and saying it was an
	//		// IOleClientSite struct. It's ok. An _IOleClientSiteEx starts with an embedded IOleClientSite, so
	//		// the browser didn't mind. So that's what the browser object is passing us now. The browser doesn't
	//		// know that it's really an _IOleClientSiteEx struct. But we do. So we can recast it and use it as
	//		// so here.

	//		// If the browser is asking us to match IID_IOleClientSite, then it wants us to return a pointer to
	//		// our IOleClientSite struct. Then the browser will use the VTable in that struct to call our
	//		// IOleClientSite functions. It will also pass this same pointer to all of our IOleClientSite
	//		// functions.
	//		//
	//		// Actually, we're going to lie to the browser again. We're going to return our own _IOleClientSiteEx
	//		// struct, and tell the browser that it's a IOleClientSite struct. It's ok. The first thing in our
	//		// _IOleClientSiteEx is an embedded IOleClientSite, so the browser doesn't mind. We want the browser
	//		// to continue passing our _IOleClientSiteEx pointer wherever it would normally pass a IOleClientSite
	//		// pointer.
	//		//
	//		// The IUnknown interface uses the same VTable as the first object in our _IOleClientSiteEx
	//		// struct (which happens to be an IOleClientSite). So if the browser is asking us to match
	//		// IID_IUnknown, then we'll also return a pointer to our _IOleClientSiteEx.

	////C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
		
            
	//			ppvObject[0] = ((__IOleClientSiteEx)This).client;
			

	//		// If the browser is asking us to match IID_IOleInPlaceSite, then it wants us to return a pointer to
	//		// our IOleInPlaceSite struct. Then the browser will use the VTable in that struct to call our
	//		// IOleInPlaceSite functions.  It will also pass this same pointer to all of our IOleInPlaceSite
	//		// functions (except for Site_QueryInterface, Site_AddRef, and Site_Release. Those will always get
	//		// the pointer to our _IOleClientSiteEx.
	//		//
	//		// Actually, we're going to lie to the browser. We're going to return our own IOleInPlaceSiteEx
	//		// struct, and tell the browser that it's a IOleInPlaceSite struct. It's ok. The first thing in
	//		// our IOleInPlaceSiteEx is an embedded IOleInPlaceSite, so the browser doesn't mind. We want the
	//		// browser to continue passing our IOleInPlaceSiteEx pointer wherever it would normally pass a
	//		// IOleInPlaceSite pointer. My, we're really playing dirty tricks on the browser here. heheh.
	////C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
	//		else if (!memcmp(new REFIID(riid), IID_IOleInPlaceSite, sizeof(EXTERN_C)))
	//		{
	//			ppvObject[0] = ((__IOleClientSiteEx)This).inplace;
	//		}

	//		// For other types of objects the browser wants, just report that we don't have any such objects.
	//		// NOTE: If you want to add additional functionality to your browser hosting, you may need to
	//		// provide some more objects here. You'll have to investigate what the browser is asking for
	//		// (ie, what REFIID it is passing).
	//		else
	//		{
	//			ppvObject[0] = 0;
	//			return (_HRESULT_TYPEDEF_(0x80004002));
	//		}

			return (((int)0x00000000));

        }
    }
      
}
