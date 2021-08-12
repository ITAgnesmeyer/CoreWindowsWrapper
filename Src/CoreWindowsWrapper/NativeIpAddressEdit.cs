using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.Core.Api.Win32;
using Diga.Core.Api.Win32.Tools;

namespace CoreWindowsWrapper
{
    public class NativeIpAddressEdit : NativeControlBase
    {
        private const uint IPM_CLEARADDRESS = (WindowsMessages.WM_USER + 100);
        private const uint IPM_SETADDRESS = (WindowsMessages.WM_USER + 101);
        private const uint IPM_GETADDRESS = (WindowsMessages.WM_USER + 102);
        private const uint IPM_SETRANGE = (WindowsMessages.WM_USER + 103);
        private const uint IPM_SETFOCUS = (WindowsMessages.WM_USER + 104);
        private const uint IPM_ISBLANK = (WindowsMessages.WM_USER + 105);
        protected override void Initialize()
        {
            base.Initialize();
            this.TypeIdentifier = "SysIPAddress32";
            ((IControl) this).ClientEdge = true;
        }

        private IntPtr MakeIpAddress(byte b1, byte b2, byte b3, byte b4)
        {
            uint a = (uint) b1 << 24;
            uint b = (uint) b2 << 16;
            uint c = (uint) b3 << 8;
            uint d = b4;
            uint e = a + b + c + d;
            return (IntPtr) e;

        }

        private IntPtr MakeRange(byte low, byte high)
        {
            uint a =(uint) high << 8 ;
            uint b = low;
            uint c = a + b;
            return (IntPtr) c;
        }

        private byte GetIp1(uint input)
        {
            uint a = input >> 24& 0xff;
            return (byte)a;
        }

        private byte GetIp2(uint input)
        {
            uint b = input >> 16& 0xff;
            return (byte)b;
        }

        private byte GetIp3(uint input)
        {
            uint c = input >> 8& 0xff;
            return (byte)c;
        }

        private byte GetIp4(uint input)
        {
            uint d = input & 0xff;
            return (byte) d;
        }

        public void GetAddress(out byte b1, out byte b2, out byte b3, out byte b4)
        {
            b1 = 0;
            b2 = 0;
            b3 = 0;
            b4 = 0;
            IntPtr ptr = Marshal.AllocHGlobal(sizeof(uint));
            var r = User32.SendMessage(this.Handle, IPM_GETADDRESS, IntPtr.Zero, ptr);
            ByteReader br = new ByteReader(ptr);
            uint val = br.GetNextDWordAsUint();
            Marshal.FreeHGlobal(ptr);

            b1 = GetIp1(val);
            b2 = GetIp2(val);
            b3 = GetIp3(val);
            b4 = GetIp4(val);

        }
        public void SetAddress(byte b1, byte b2, byte b3, byte b4)
        {
            IntPtr lParam = MakeIpAddress(b1, b2, b3, b4);
            User32.SendMessage(this.Handle, IPM_SETADDRESS, IntPtr.Zero, lParam);

        }

        public void SetFocus()
        {

        }
        public bool SetRange(int fieldIndex, byte low, byte high)
        {
            IntPtr lParam = MakeRange(low, high);
            var retVal = User32.SendMessage(this.Handle, (int) IPM_SETRANGE, fieldIndex, lParam);
            if (retVal.ToInt32() == 0)
            {
                Win32Exception ex = new Win32Exception(Marshal.GetLastWin32Error());
                Debug.Print((ex.Message));
                return false;
            }

            return true;
        }
    }
}