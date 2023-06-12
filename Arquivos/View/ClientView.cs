using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Models;
using Arquivos.Data;
using Arquivos.Controllers;

namespace Arquivos.Views
{
    public class ClientView
    {
        private ClientController clientController;
        
        public ClientView()
        {
            clientController = new ClientController();
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("VOCÊ ESTÁ EM CLIENTES");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Cliente");
            Console.WriteLine("2 - Listar Clientes");
            Console.WriteLine("3 - Exprtar Clientes");
            Console.WriteLine("4 - Importar Clientes");
            Console.WriteLine("");
            int option = 0;
            switch(option)
            {
                case 1 :
                    Insert();
                break;
                default:
                break;
            }
        }

        private void Insert()
        {
            Client client = new Client();
            client.Id = clientController.GetNextId();

            Console.WriteLine("Informe o primeiro nome: ");
            client.FirstName = Console.ReadLine();

            Console.WriteLine("Informe o segundo nome: ");
            client.LastName = Console.ReadLine();

            Console.WriteLine("Informe o CPF: ");
            client.CPF = Console.ReadLine();

            Console.WriteLine("Informe o email: ");
            client.Email = Console.ReadLine();
        }
    }
}
