// ReSharper disable InconsistentNaming

namespace Diga.Core.Api.Win32
{
    public static class ProgressBarMessages
    {
        public const uint PBM_SETRANGE = (0x0400 + 1);
        public const uint PBM_SETPOS = (0x0400 + 2);
        public const uint PBM_DELTAPOS = (0x0400 + 3);
        public const uint PBM_SETSTEP = (0x0400 + 4);
        public const uint PBM_STEPIT = (0x0400 + 5);
        public const uint PBM_SETRANGE32 = 1030;
        public const uint PBM_GETRANGE = 1031;
        public const uint PBM_GETPOS = 1032;
        public const uint PBM_SETBARCOLOR = 1033;
        public const uint PBM_SETBKCOLOR = 8193;
    }
}