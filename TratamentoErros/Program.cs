string entrada = string.Empty;
Console.WriteLine("-------------------");
Console.WriteLine("Tratamento de Erros");
Console.WriteLine("-------------------");

do{
    Console.WriteLine("");
    Console.WriteLine("Selecione uma das opções abaixo:");
    Console.WriteLine("1 - Tratamento de Erros");
    Console.WriteLine("2 - Try {} Catch {}");
    Console.WriteLine("3 - Catch com Filtros");
    Console.WriteLine("4 - ");
    Console.WriteLine("5 - ");
    Console.WriteLine("0 - SAIR");

    entrada = Console.ReadLine();

    switch(entrada)
    {
        case "1":
            //int count = int.Parse("abc");
            bool aux = true;
            while(aux)
            {

                Console.WriteLine("Quantos ovos na cesta?");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int count))
                {
                    Console.WriteLine($"Existem {count} ovos no cesto.");
                    aux = false;
                }
                else
                {
                    Console.WriteLine("Não é um numero válido.");
                    aux = true;
                }
            }
        break;

        case "2":
            
            Console.WriteLine("Antes da Validação.");
            Console.WriteLine("Informe a sua idade:");
            string input2 = Console.ReadLine();
            try
            {
                int age = int.Parse(input2);
                //forçando um erro de indice fora dos limites do vetor
                int [] vetInteiros = {0,1,2,3};
                Console.WriteLine(vetInteiros[vetInteiros.Length -1]);
            }
            catch(IndexOutOfRangeException ixorgex)
            {
                Console.WriteLine("Queridão, posição inexistente no vetor.");
            }
            catch(FormatException fex)
            {
                Console.WriteLine("Erro de formato inválido de dados.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ocorreu um erro. Dados Inválidos.");
                Console.WriteLine($"{ex.GetType()}: {ex.Message}");
            }
            Console.WriteLine("Depois da validação.");
        break;

        case "3":

            Console.WriteLine("Informe um valor:");
            string quantia = Console.ReadLine();
            if(string.IsNullOrEmpty(quantia))
                Console.WriteLine("Quantia inválida.");
            else
            {
                try
                {
                    decimal amountValue = decimal.Parse(quantia);
                    Console.WriteLine($"Valor formatado: {amountValue:C}");
                }
                catch(FormatException) when (quantia.Contains("$"))
                {
                    Console.WriteLine("O valor deve ser informado sem $");
                }
                catch(FormatException fex)
                {
                    Console.WriteLine("Informe apenas os digitos.");
                }
            }

        break;

        case "4":
        break;

        case "5":
        break;

        case "0":
        break;

        default: 
            Console.WriteLine("ATENÇÃO: Opção inválida!");
        break;

    }

}while( !entrada.Equals("0") && string.IsNullOrWhiteSpace(entrada));