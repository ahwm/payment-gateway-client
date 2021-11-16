using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway
{
    static class Log
    {
        internal readonly static string[] NoInclude = { "xCardNum", "xMagStripe", "xExp", "xCVV", "xToken", "xDUKPT", "xRouting", "xAccount", "xMICR" };
    }
}
