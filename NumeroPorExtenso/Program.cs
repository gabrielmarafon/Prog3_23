using NumeroPorExtenso;

static string ConverterNumbero(string numero)
{
    int nro;
    try
    {
        nro = Convert.ToInt32(numero);
    }
    catch
    {
        return "O número não é válido.";
    }
    string retorno = "";
    switch (numero.Length)
    {
        case 1:
            Unidade unidade = new Unidade();
            retorno = unidade.UnidadePorExtenso(nro);
            break;

        case 2:
            Dezena dezena = new Dezena();
            retorno = dezena.DezenaPorExtenso(nro);
            break;

        case 3:
            Centena centena = new Centena();
            retorno = centena.CentenaPorExtenso(nro);
            break;
    }
    return retorno;
}
static string ConverterNumeroDecimal(string numero)
{
    string numeroInteiro = Convert.ToString(Math.Truncate(double.Parse(numero)));
    string numeroDecimal = Convert.ToString(Math.Truncate((double.Parse(numero) - Math.Truncate(double.Parse(numero)))*100));
    string textoNumeroInteiro = ConverterNumbero(numeroInteiro);
    string textoNumeroDecimal = int.Parse(numeroDecimal)>0 ? ConverterNumbero(numeroDecimal): "";
    string conector = int.Parse(numeroDecimal)>0 ? " vírgula ": "";

    return textoNumeroInteiro + conector + textoNumeroDecimal;
}


Console.WriteLine("***********************");
Console.WriteLine("Escrever número por extenso");
Console.WriteLine("***********************");

Console.WriteLine("Informe um número inteiro:");
string numero = Console.ReadLine();
Console.WriteLine(ConverterNumeroDecimal(numero));

