using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    internal class InvalidAgeException : ApplicationException
    {
        public InvalidAgeException():base("Invalid age") { }
        public InvalidAgeException(string? message) : base(message) { }
    }
}
