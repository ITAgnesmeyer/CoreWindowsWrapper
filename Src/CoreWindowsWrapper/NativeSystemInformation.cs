using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{
    public static class NativeSystemInformation
    {
        public static Size PrimaryMonitorSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXSCREEN), User32.GetSystemMetrics(SystemMetric.SM_CYSCREEN));
            }
        }

        public static int VerticalScrollBarWidth
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_CXVSCROLL);
            }
        }

        public static int HorizontalScrollBarHeight
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_CYHSCROLL);
            }
        }

        public static int CaptionHeight
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_CYCAPTION);
            }
        }

        public static Size BorderSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXBORDER), User32.GetSystemMetrics(SystemMetric.SM_CYBORDER));
            }
        }

        public static Size FixedFrameBorderSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXFIXEDFRAME), User32.GetSystemMetrics(SystemMetric.SM_CYFIXEDFRAME));
            }
        }

        public static int VerticalScrollBarThumbHeight
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_CYVTHUMB);
            }
        }

        public static int HorizontalScrollBarThumbWidth
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_CXHTHUMB);
            }
        }

        public static Size IconSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXICON), User32.GetSystemMetrics(SystemMetric.SM_CYICON));
            }
        }
        public static Size CursorSize
        {
            get
            { 
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXCURSOR), User32.GetSystemMetrics(SystemMetric.SM_CYCURSOR));
            }
        }

        public static int MenuHeight
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_CYMENU);
            }
        }

        public static int KanjiWindowHeight 
        { 
            get 
            {
                return User32.GetSystemMetrics(SystemMetric.SM_CYKANJIWINDOW);
            } 
        }
        
        public static bool MousePresent
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_MOUSEPRESENT) != 0;
            }
        }

        public static int VerticalScrollBarArrowHeight
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_CYVSCROLL);
            }
        }

        public static int HorizontalScrollBarArrowWidth
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_CXHSCROLL);
            }
        }

        public static bool MouseButtonsSwapped
        {
            get
            {
                return (User32.GetSystemMetrics(SystemMetric.SM_SWAPBUTTON) != 0);
            }
        }

        public static Size MinimumWindowSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXMIN), User32.GetSystemMetrics(SystemMetric.SM_CYMIN));
            }
        }

        public static Size CaptionButtonSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXSIZE), User32.GetSystemMetrics(SystemMetric.SM_CYSIZE));
            }
        }

        public static Size FrameBorderSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXFRAME), User32.GetSystemMetrics(SystemMetric.SM_CYFRAME));
            }
        }

        public static Size MinWindowTrackSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXMINTRACK), User32.GetSystemMetrics(SystemMetric.SM_CYMINTRACK));
            }
        }

        public static Size DoubleClickSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXDOUBLECLK), User32.GetSystemMetrics(SystemMetric.SM_CYDOUBLECLK));
            }
        }

        public static Size IconSpacingSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXICONSPACING), User32.GetSystemMetrics(SystemMetric.SM_CYICONSPACING));
            }
        }

        public static bool RightAlignedMenus
        {
            get
            {
                return (User32.GetSystemMetrics(SystemMetric.SM_MENUDROPALIGNMENT) != 0);
            }
        }

        public static bool PenWindows
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_PENWINDOWS) != 0;
            }
        }

        public static bool DbcsEnabled
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_DBCSENABLED) != 0;
            }
        }

        public static int MouseButtons
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_CMOUSEBUTTONS);
            }
        }

        public static Size Border3DSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXEDGE), User32.GetSystemMetrics(SystemMetric.SM_CYEDGE));
            }
        }

        public static Size MinimizedWindowSpacingSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXMINSPACING), User32.GetSystemMetrics(SystemMetric.SM_CYMINSPACING));
            }
        }

        public static Size SmallIconSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXSMICON), User32.GetSystemMetrics(SystemMetric.SM_CYSMICON));
            }
        }

        public static int ToolWindowCaptionHeight
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_CYSMCAPTION);
            }
        }

        public static Size ToolWindowCaptionButtonSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXSMSIZE), User32.GetSystemMetrics(SystemMetric.SM_CYSMSIZE));
            }
        }

        public static Size MenuButtonSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXMENUSIZE), User32.GetSystemMetrics(SystemMetric.SM_CYMENUSIZE));
            }
        }

        public static Size MinimizedWindowSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXMINIMIZED), User32.GetSystemMetrics(SystemMetric.SM_CYMINIMIZED));
            }
        }

        public static Size MaxWindowTrackSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXMAXTRACK), User32.GetSystemMetrics(SystemMetric.SM_CYMAXTRACK));
            }
        }

        public static Size PrimaryMonitorMaximizedWindowSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXMAXIMIZED), User32.GetSystemMetrics(SystemMetric.SM_CYMAXIMIZED));
            }
        }

        public static bool Network
        {
            get
            {
                return (User32.GetSystemMetrics(SystemMetric.SM_NETWORK) & 0x00000001) != 0;
            }
        }

        public static bool TerminalServerSession
        {
            get
            {
                return (User32.GetSystemMetrics(SystemMetric.SM_REMOTESESSION) & 0x00000001) != 0;
            }
        }

        public static Size DragSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXDRAG), User32.GetSystemMetrics(SystemMetric.SM_CYDRAG));
            }
        }

        public static bool ShowSounds
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_SHOWSOUNDS) != 0;
            }
        }

        public static Size MenuCheckSize
        {
            get
            {
                return new Size(User32.GetSystemMetrics(SystemMetric.SM_CXMENUCHECK), User32.GetSystemMetrics(SystemMetric.SM_CYMENUCHECK));
            }
        }

        public static bool MultiMonitorSupport
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_CMONITORS) != 0;
            }
        }

        public static bool MouseWheelSupport
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_MOUSEWHEELPRESENT) != 0;
            }
        }

        public static Rect VirtualScreen
        {
            get
            {
                if(MultiMonitorSupport)
                {
                    return new Rect(User32.GetSystemMetrics(SystemMetric.SM_XVIRTUALSCREEN),
                        User32.GetSystemMetrics(SystemMetric.SM_YVIRTUALSCREEN), 
                        User32.GetSystemMetrics(SystemMetric.SM_CXVIRTUALSCREEN),
                        User32.GetSystemMetrics(SystemMetric.SM_CYVIRTUALSCREEN));
                }
                else
                {
                    Size size = PrimaryMonitorSize;
                    return new Rect(0,0, size.cx, size.cy);
                }
            }
        }

        public static int MointroCount
        {
            get
            {
                if(MultiMonitorSupport)
                {
                    return User32.GetSystemMetrics(SystemMetric.SM_CMONITORS);
                }
                return 1;
            }
        }

        public static bool MonitorsSameDisplayFormat
        {
            get
            {
                if(MultiMonitorSupport)
                {
                    return User32.GetSystemMetrics(SystemMetric.SM_SAMEDISPLAYFORMAT) != 0;
                }
                return true;
            }
        }

        public static int VerticalFocusThickness
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_CYFOCUSBORDER);
            }
        }

        public static int HorizontalFocusThickness
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_CXFOCUSBORDER);
            }
        }

        public static int VerticalResizeBorderThickness
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_CYSIZEFRAME);
            }
        }

        public static int HorizontalResizeBorderThickness
        {
            get
            {
                return User32.GetSystemMetrics(SystemMetric.SM_CXSIZEFRAME);
            }
        }



    }
}