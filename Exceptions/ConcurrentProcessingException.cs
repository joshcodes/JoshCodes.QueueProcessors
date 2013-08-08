using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshCodes.QueueProcessors
{
    public class ConcurrentProcessingException : Exception
    {
        public ConcurrentProcessingException(string movingToState, string expectedState, string foundState, string message = null)
        {
        }
    }
}
