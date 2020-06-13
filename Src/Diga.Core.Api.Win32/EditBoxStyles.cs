// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local

namespace Diga.Core.Api.Win32
{
    public static class EditBoxStyles
    {
        /// ES_AUTOVSCROLL -> 0x0040L
        public const int ES_AUTOVSCROLL = 64;

        /// ES_AUTOHSCROLL -> 0x0080L
        public const int ES_AUTOHSCROLL = 128;

        /// ES_WANTRETURN -> 0x1000L
        public const int ES_WANTRETURN = 4096;

        /// ES_OEMCONVERT -> 0x0400L
        public const int ES_OEMCONVERT = 1024;

        /// ES_UPPERCASE -> 0x0008L
        public const int ES_UPPERCASE = 8;

        /// ES_NOHIDESEL -> 0x0100L
        public const int ES_NOHIDESEL = 256;

        /// ES_MULTILINE -> 0x0004L
        public const int ES_MULTILINE = 4;

        /// ES_LOWERCASE -> 0x0010L
        public const int ES_LOWERCASE = 16;

        /// ES_READONLY -> 0x0800L
        public const int ES_READONLY = 2048;

        /// ES_PASSWORD -> 0x0020L
        public const int ES_PASSWORD = 32;

        /// ES_NUMBER -> 0x2000L
        public const int ES_NUMBER = 8192;

        /// ES_CENTER -> 0x0001L
        public const int ES_CENTER = 1;

        /// ES_RIGHT -> 0x0002L
        public const int ES_RIGHT = 2;

        /// ES_LEFT -> 0x0000L
        public const int ES_LEFT = 0;
    }
}