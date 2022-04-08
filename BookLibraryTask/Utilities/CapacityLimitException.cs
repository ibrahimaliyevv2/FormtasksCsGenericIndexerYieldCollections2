using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities
{
    public class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message):base(message)
        {
            
        }
    }
}
