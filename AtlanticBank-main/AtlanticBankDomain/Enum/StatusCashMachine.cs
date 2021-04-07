using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AtlanticBankDomain.Enum
{
    public enum StatusCashMachine
    {
        NullValue = -1,
        [Description("BLOCKED")]
        BLOCKED = 0,
        [Description("ACTIVE")]
        ACTIVE = 1
    }
}
