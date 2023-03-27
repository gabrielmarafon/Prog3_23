var myFloat = 10f;
float meuFloat = 11;

// Conversão de tipo numerico

int myInterger = 100;
meuFloat = (float)myInterger;

decimal myDecimal = Convert.ToDecimal(myInterger);

var myDouble = 10d;
myDecimal = 10m;

string meuNumeroTexto = Convert.ToString(myInterger);
int qtdChars = meuNumeroTexto.Length;
for (int i = 0; i < qtdChars; i++)
{
    Console.WriteLine( meuNumeroTexto[i] );
}
