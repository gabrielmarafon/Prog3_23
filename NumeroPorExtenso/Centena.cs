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

            if (numero >= 200 && numero <= 299)
            {
                if (numero == 200)
                    retorno = "Duzentos";

                else
                {
                    string und = numero.ToString().Substring(1, 2);
                    retorno = "Duzentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if (numero >= 300 && numero <= 399)
            {
                if (numero == 300)
                    retorno = "Trezentos";

                else
                {
                    string und = numero.ToString().Substring(1, 2);
                    retorno = "Trezentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if (numero >= 400 && numero <= 499)
            {
                if (numero == 400)
                    retorno = "Quatrocentos";

                else
                {
                    string und = numero.ToString().Substring(1, 2);
                    retorno = "Quatrocentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if (numero >= 500 && numero <= 599)
            {
                if (numero == 500)
                    retorno = "Quinhentos";

                else
                {
                    string und = numero.ToString().Substring(1, 2);
                    retorno = "Quinhentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if (numero >= 600 && numero <= 699)
            {
                if (numero == 600)
                    retorno = "Seiscentos";

                else
                {
                    string und = numero.ToString().Substring(1, 2);
                    retorno = "Seiscentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if (numero >= 700 && numero <= 799)
            {
                if (numero == 700)
                    retorno = "Setecentos";

                else
                {
                    string und = numero.ToString().Substring(1, 2);
                    retorno = "Setecentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if (numero >= 800 && numero <= 899)
            {
                if (numero == 800)
                    retorno = "Oitocentos";

                else
                {
                    string und = numero.ToString().Substring(1, 2);
                    retorno = "Oitocentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if (numero >= 900 && numero <= 999)
            {
                if (numero == 900)
                    retorno = "Novecentos";

                else
                {
                    string und = numero.ToString().Substring(1, 2);
                    retorno = "Novecentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }

            return retorno;

        }


    }
}