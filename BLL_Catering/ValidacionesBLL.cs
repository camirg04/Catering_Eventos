using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Catering
{
    internal class ValidacionesBLL
    {
        public bool esDecimal(string numero)
        {
            int puntos = 0;
            bool numDecimal = true;

            foreach (char letra in numero)
            {
                if (!(Char.IsNumber(letra)) && letra != ',')
                    numDecimal = false;
                else if (letra == ',')
                {
                    puntos++;
                    if (puntos > 1)
                        numDecimal = false;
                }
            }

            return numDecimal;
        }
    }
}
