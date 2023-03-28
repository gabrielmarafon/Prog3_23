//Operadores Unários
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
WriteLine($"a    |{a & a, -5} | {a & b, -5}")
