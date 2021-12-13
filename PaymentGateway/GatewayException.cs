﻿using System;
namespace PaymentGateway
{
    /// <summary>
    /// 
    /// </summary>
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
        /// <inheritdoc>
        public GatewayException(string msg, Exception innerException) : base(msg, innerException)
        { }
    }
}
