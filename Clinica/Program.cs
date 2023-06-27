Dictionary<string, string> opcoesClinica = new Dictionary<string, string>()
{
  { "1", "Cadastros" },
  { "2", "Relatórios" },
  { "0", "Sair do sistema" },
};

Dictionary<string, string> opcoesCadastros = new Dictionary<string, string>()
{
  { "1", "Médicos" },
  { "2", "Animais" },
  { "3", "Atendimentos" },
  { "0", "Voltar para o início" },
}; ;

Dictionary<string, string> opcoesRelatorios = new Dictionary<string, string>()
{
  { "1", "Animais" },
  { "2", "Atendimentos" },
  { "0", "Voltar para o início" },
};

void printMenu(string title, Dictionary<string, string> opcoes)
{
  Console.WriteLine(string.Concat(Enumerable.Repeat("-", title.Length)));
  Console.WriteLine(title);
  Console.WriteLine(string.Concat(Enumerable.Repeat("-", title.Length)));
  Console.WriteLine();

  foreach (var opcao in opcoes)
  {
    Console.WriteLine($"{opcao.Key} - {opcao.Value}");
  }
}

string? opcaoClinica, opcaoCadastro, opcaoRelatorio;

do
{
  printMenu("Controle clínica veterinária - Início", opcoesClinica);
  opcaoClinica = Console.ReadLine() ?? "";
  Console.Clear();

  switch (opcaoClinica)
  {
    case "1":
      do
      {
        printMenu("Controle clínica veterinária - Cadastros", opcoesCadastros);
        opcaoCadastro = Console.ReadLine() ?? "";
        Console.Clear();

        switch (opcaoCadastro)
        {
          case "1":
            Console.WriteLine("Cadastro de médicos");
            break;
          case "2":
            Console.WriteLine("Cadastro de animais");
            break;
          case "3":
            Console.WriteLine("Cadastro de atendimentos");
            break;
          default:
            break;
        }
      } while (opcaoCadastro != "0" && !string.IsNullOrEmpty(opcaoCadastro));
      break;
    case "2":
      do
      {
        printMenu("Controle clínica veterinária - Relatórios", opcoesRelatorios);
        opcaoRelatorio = Console.ReadLine() ?? "";
        Console.Clear();

        switch (opcaoRelatorio)
        {
          case "1":
            Console.WriteLine("Listagem de animais");
            break;
          case "2":
            Console.WriteLine("Histórico de atendimentos");
            break;
          default:
            break;
        }
      } while (opcaoRelatorio != "0" && !string.IsNullOrEmpty(opcaoRelatorio));
      break;
    default:
      break;
  }
} while (opcaoClinica != "0" && !string.IsNullOrEmpty(opcaoClinica));
