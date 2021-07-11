using System;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// customexception class
    /// </summary>
    class CabInvoiceException: Exception 
    {
        /// <summary>
        /// Enumfor exception type
        /// </summary>
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE,
            INVALID_DISTANCE,
            INVALID_TIME,
            NULL_RIDES,
            INVALID_USER_ID
        }
        public ExceptionType Type;
        /// <summary>
        /// parameter constructor for exception type and throws exception
        /// base is used to intialize the new instance of system.exception for specified error
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exceptionType"></param>
        public CabInvoiceException(ExceptionType exceptionType,string message):base(message)
        {
            this.Type = exceptionType;
        }

    }
}
