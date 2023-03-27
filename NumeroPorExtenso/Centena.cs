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
        Unidade unidade = new Unidade();

         if ( numero >= 100 && numero <=199 )
        {
            if (numero == 100)
            retorno = "Cem";

            else 
            {
                string und = numero.ToString().Substring(2,1);
                retorno = "Cento e ";
                retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
            }
        }
        return retorno;

        }


    }
}