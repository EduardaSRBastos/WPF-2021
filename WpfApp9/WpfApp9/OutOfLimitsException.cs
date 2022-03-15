using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9
{
    public class OutOfLimitsException : System.ApplicationException
    {
        public OutOfLimitsException(string msg) : base(msg)
        {
        }
    }
}
