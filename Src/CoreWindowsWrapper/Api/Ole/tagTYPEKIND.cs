﻿namespace CoreWindowsWrapper.Api.Ole
{
    public enum tagTYPEKIND
    {
        /// TKIND_ENUM -> 0
        TKIND_ENUM = 0,

        /// TKIND_RECORD -> TKIND_ENUM+1
        TKIND_RECORD = (TKIND_ENUM + 1),

        /// TKIND_MODULE -> TKIND_RECORD+1
        TKIND_MODULE = (TKIND_RECORD + 1),

        /// TKIND_INTERFACE -> TKIND_MODULE+1
        TKIND_INTERFACE = (TKIND_MODULE + 1),

        /// TKIND_DISPATCH -> TKIND_INTERFACE+1
        TKIND_DISPATCH = (TKIND_INTERFACE + 1),

        /// TKIND_COCLASS -> TKIND_DISPATCH+1
        TKIND_COCLASS = (TKIND_DISPATCH + 1),

        /// TKIND_ALIAS -> TKIND_COCLASS+1
        TKIND_ALIAS = (TKIND_COCLASS + 1),

        /// TKIND_UNION -> TKIND_ALIAS+1
        TKIND_UNION = (TKIND_ALIAS + 1),

        /// TKIND_MAX -> TKIND_UNION+1
        TKIND_MAX = (TKIND_UNION + 1),
    }
}