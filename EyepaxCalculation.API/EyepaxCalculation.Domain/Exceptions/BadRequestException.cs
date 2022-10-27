using System;

namespace EyepaxCalculation.Domain
{
    public abstract class BadRequestException : Exception
    {
        protected BadRequestException(string message)
           : base(message)
        {
        }
    }
}
