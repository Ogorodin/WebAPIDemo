using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class UserServiceException : Exception
    {

        public UserServiceException()
        {

        }

        public UserServiceException(string message) : base(message)
        {

        }

        public UserServiceException(string message, Exception innerEx) : base(message, innerEx)
        {

        }
    }
}
