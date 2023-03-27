//função estática: não muda o compartamento no decorer do código
//dentro do parenteses 1º tipo 2º nome da variavel
static void FormatString(string stringToFormat)
//chaves definem o scopo de algo que fica dentro
{
    //replace é uma função nativa do tipo string 
    stringToFormat.Replace("Mundo", "Marte");
}

static string FormatReturningString(string stringToFormat)
{
    return stringToFormat.Replace("Mundo", "Marte");
}

var mensagem = "Olá Mundo!";
//invocando o método sem retorno
FormatString(mensagem);
Console.WriteLine(mensagem);

var outraMensagem = "Bom dia Mundo!";
Console.WriteLine( FormatReturningString(outraMensagem) );