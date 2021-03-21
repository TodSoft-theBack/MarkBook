using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ControllerExceptions
{
    public class IncorectCredentialsException : Exception
    {
        public IncorectCredentialsException(string message) : base(message) { }
    }
}
