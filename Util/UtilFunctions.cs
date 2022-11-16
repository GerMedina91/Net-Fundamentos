using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platzi_Escuela.Util
{
    public class UtilFunctions
    {
        public static decimal GenerarNota(Random random)
        {
            int entero = random.Next(0, 5);

            int dec = 0;
            if (entero != 5)
                dec = random.Next(0, 9);

            return Decimal.Parse($"{entero},{dec}");
        }
    }
}
