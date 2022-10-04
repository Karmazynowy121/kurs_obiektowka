using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsTutorial.MyExceptions
{
    public class MyOwnException : Exception, IMyExceptions
    {
        public int ErrorCode { get; }
        private readonly Logger _logger = new Logger();

        public MyOwnException(int errorCode)
        {
            ErrorCode = errorCode;
            _logger.SaveExceptionToLog(this);
        }

        public MyOwnException(int errorCode, string? message)
            : base(message)
        {
            ErrorCode = errorCode;
            _logger.SaveExceptionToLog(this);
        }
    }
}
