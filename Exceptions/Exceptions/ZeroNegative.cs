using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class ZeroNegative : Exception
    {
        public ZeroNegative()
            : base() {}
        public ZeroNegative(string message)
            : base(message) { }

    }
}
