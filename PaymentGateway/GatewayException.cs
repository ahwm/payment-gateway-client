using System;
using System.Runtime.Serialization;

namespace PaymentGateway
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class GatewayException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public GatewayException() : base()
        { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public GatewayException(string msg) : base(msg)
        { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="innerException"></param>
        public GatewayException(string msg, Exception innerException) : base(msg, innerException)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected GatewayException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public virtual new void GetObjectData(SerializationInfo info, StreamingContext context) => base.GetObjectData(info, context);
    }
}
