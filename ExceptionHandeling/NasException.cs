using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandeling
{
    class NasException:Exception
    {
        public NasException(string poruka)
            :base(poruka)
        {

        }
    }
}
