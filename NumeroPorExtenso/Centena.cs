using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumeroPorExtenso
{
    public class Centena
    {
        public string CentenaPorExtenso(int numero)
        {
            string retorno = "";
            Dezena dezena = new Dezena();

            if (numero >= 100 && numero <= 199)
            {
                if (numero == 100)
                    retorno = "Cem";

                else
                {
                    string und = numero.ToString().Substring(1, 2);
                    retorno = "Cento e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }
            return retorno;

        }


    }
}