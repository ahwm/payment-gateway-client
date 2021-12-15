using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway
{
    static class Log
    {
        internal readonly static string[] NoInclude = { "ccnumber", "ccexp", "cvv", "checkaba", "checkaccount", "checkname", "account_holder_type", "account_type" };
    }
}
