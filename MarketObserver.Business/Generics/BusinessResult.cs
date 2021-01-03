using System;
using System.Collections.Generic;
using System.Text;

namespace MarketObserver.Business.Generics
{
    public class BusinessResult<TResult>
    {
        public bool Success { get; private set; }
        public TResult Result { get; private set; }
        public string NonSuccessMessage { get; private set; }
        public Exception Exception { get; private set; }

        public static BusinessResult<TResult> CreateSuccessResult(TResult result)
        {
            return new BusinessResult<TResult> { Success = true, Result = result };
        }

        public static BusinessResult<TResult> CreateFailure(string nonSuccessMessage)
        {
            return new BusinessResult<TResult> { Success = false, NonSuccessMessage = nonSuccessMessage };
        }

        public static BusinessResult<TResult> CreateFailure(Exception ex)
        {
            return new BusinessResult<TResult>
            {
                Success = false,
                NonSuccessMessage = String.Format("{0}{1}{1}{2}", ex.Message, Environment.NewLine, ex.StackTrace),
                Exception = ex
            };
        }
    }
}
