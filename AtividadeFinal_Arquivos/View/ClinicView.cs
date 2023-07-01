using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Models;
using Arquivos.Data;
using AtividadeFinal_Arquivos.Controllers;

namespace Arquivos.Views
{
    public class ClinicView
    {
        private ClinicController clinicController;
        
        public ClinicView()
        {
            clinicController = new ClinicController();
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("VOCÊ ESTÁ EM CLINICA");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Clinica");
            Console.WriteLine("2 - Listar Clinicas");
            Console.WriteLine("3 - Exportar Clinicas");
            Console.WriteLine("4 - Importar Clinicas");
            Console.WriteLine("5 - Pesquisar Clinicas");
            Console.WriteLine("");
            int option = 0;
            option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1 :
                    Insert();
                break;
                default:
                break;

                case 2 :
                    List();
                break;

                case 3 :
                    Export();
                break;

                case 4 :
                    Import();
                break;

                case 5 :
                    SearchByName();
                break;
            }
        }

        private void List()
        {
            List<Clinic> listagem = clinicController.List();
        }
        

        private void Insert()
        {
            Clinic clinic = new Clinic();
            clinic.Id = clinicController.GetNextId();

            Console.WriteLine("Informe o nome: ");
            clinic.Name = Console.ReadLine();

            Console.WriteLine("Informe o endereço: ");
            clinic.Address = Console.ReadLine();

            Console.WriteLine("Informe o telefone: ");
            clinic.PhoneNumber = Console.ReadLine();

            bool retorno = clinicController.Insert(clinic);

            if(retorno)
                Console.WriteLine("Clinica Inserida com sucesso!");

            else Console.WriteLine("Falha ao inserir, verifique os dados");
        }
        private void Export()
        {
            if(clinicController.ExportToTextFile())
                Console.WriteLine("Arquivo gerado com sucesso!");          
            else
                Console.WriteLine("Ooooops.");
        }
        private void Import()
        {
            if(clinicController.ImportFromTxtFile())
                Console.WriteLine("Arquivo gerado com sucesso!");          
            else
                Console.WriteLine("Ooooops.");
        }
        private void SearchByName()
        {
            Console.WriteLine("Pesquisar cliente pelo nome.");
            Console.WriteLine("Digite o nome.");
            string? name = Console.ReadLine();

            foreach(Client c in clinicController.SearchByName(name))
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}
