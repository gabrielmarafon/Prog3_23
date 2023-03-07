Console.WriteLine("Olá, seja bem vindo");
Console.WriteLine("Qual é o seu nome?");
string name = Console.ReadLine();
Console.WriteLine($"Olá {name} prazer conhecê-lo");
Console.WriteLine("Qual a sigla do seu estado?");
string estado = Console.ReadLine();
Console.WriteLine($"Olá DJ {name} {estado}");

// declarar sem inicializar / primitivo
string message1;
//declarar inicializando / abstrato
String message2 = "Seu nome completo";
//Declarar string vazia 
string message3 = String.Empty;
string message4 = "";

//Declaração com tipo implícito
var message5 = "Mensagem aleatória";

message1 = "Rogério Ceni;Pelé;The Rock;Roberto Carlos";
var palavras = message1.Split(';');
foreach(var word in palavras)
{
    // Variável de escopo local 
    // laço de repetição foreach    
    Console.WriteLine(word);
}
