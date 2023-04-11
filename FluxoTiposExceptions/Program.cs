//Operadores Unários
using FluxoTiposExceptions.Classes;

int x = 5;
int incrementoPosfixado = x++; //6
incrementoPosfixado++; //x++; x = x + 1
int incrementoPrefixado = ++x; //atribuição
Console.WriteLine($"Posfixado: {incrementoPosfixado}");
Console.WriteLine($"Prefixado: {incrementoPrefixado}");

//Como obter o tipo de uma variável
Type tipoDeInteiro = typeof(int);
Type tipoDeX = x.GetType();

//Como obter o nome de uma variável
string nomeDaVariavel = nameof(x);
int quantosBytes = sizeof(int);

Console.WriteLine( "Nome da var: " + nomeDaVariavel);

//Operadores de Atribuição
int p = 6;
p += 3; //equivalente a p = p + 3;
Console.WriteLine ($"+={p}");
p -= 3; //equivalente a p = p - 3:
Console.WriteLine ($"-={p}");
p *= 3; //equivalente a p = p * 3:
Console.WriteLine ($"*={p}");
p /= 3; //equivalente a p = p / 3:
Console.WriteLine ($"/={p}");

//operadores lógicos

bool a = true;
bool b = false;
WriteLine($" AND | a   | b  ");
WriteLine($"a    |{a & a, -5} | {a & b, -5}");

static bool FacaAlgo()
{
    WriteLine("fazendo alguma coisa");
    return true;
}
WriteLine();
WriteLine($"a & facaAlgo() = {a & FacaAlgo()}");
WriteLine($"b & facaAlgo() = {b & FacaAlgo()}");

//-------------------------------------------------

Animal[] animals = new Animal[]
{
    new Cat{
        Name = "Craudio"
        , Born = new(year: 2022, month: 8, day: 23)
        , Legs = 4
        , IsDomestic = true
    },
    new Animal{
        Name = "Eu mesmo"
        ,Born = new(year: 1984, month:7, day:5)
        ,Legs = 2
    },

    new Cat{
        Name = "Darci"
        , Born = new(year: 1994, month: 6, day: 12)
        , Legs = 3
        , IsDomestic = true
    },

    new Spider{
        Name = "Pernuda"
        , Born = DateTime.Today
        , IsPoisonous = true
        , Legs = 8
    },

    new Cat{
        Name = "Champola"
        , Born = DateTime.Today
        , Legs = 3
        , IsDomestic = false
    },
};

// Laços de Repetição
// 3 tipos de variáveis para controle de repetição
//1 flag - Bandeirinha, booleano que indica se para ou se continua
//2 counter - Contador, conta quantas vezes a repetição ocorreu 
//3 acumulador - Permite acumular valores a cada interação

//laço for 
for (int i = 0; i < animals.Length; i++)
{
    string message; 
    message = $"Nome: {animals[i].Name} ";
    message += $"Data Nasc: {animals[i].Born.ToShortDateString()}";
    Console.WriteLine(message);
}

//laço de repetição para cada, dispensa contador e acumulador
Console.WriteLine("\n---FOREACH---\n");
foreach( Animal animal in animals )
{
    string message = string.Empty;
    if(animal != null)
    {
        message += $"Nome: {animal.Name}";
    }
    Console.WriteLine(message);
}
