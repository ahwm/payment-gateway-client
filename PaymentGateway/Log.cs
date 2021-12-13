using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway
{
    static class Log
    {
        internal readonly static string[] NoInclude = { "ccnumber", "ccexp", "cvv", "checkaba", "checkaccount", "xDUKPT", "xRouting", "xAccount", "xMICR" };
    }
}
