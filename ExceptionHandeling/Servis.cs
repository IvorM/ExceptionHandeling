using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandeling
{
    class Servis
    {
        public Servis()
        {

        }

        public int Radi(int ulazniParametar)
        {
            if (ulazniParametar>1)
            {
                return 1;
            }
            else
            {
                throw new NasException("Ulazni parametar je manji od 1");
            }
        }
    }
}
