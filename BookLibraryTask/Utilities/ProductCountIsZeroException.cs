﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities
{
    public class ProductCountIsZeroException:Exception
    {
        public ProductCountIsZeroException(string message) : base(message)
        {

        }
    }
}
