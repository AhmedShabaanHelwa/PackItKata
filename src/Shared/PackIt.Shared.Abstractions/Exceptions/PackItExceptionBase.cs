using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Shared.Abstractions.Exceptions
{
    /// <summary>
    /// PackIt exception base class
    /// </summary>
    public abstract class PackItExceptionBase : Exception
    {
        protected PackItExceptionBase(string message) : base (message)
        { 
        }
    }
}
