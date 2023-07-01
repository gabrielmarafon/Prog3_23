using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Models;
using Arquivos.Data;
using AtividadeFinal_Arquivos.Controllers;
using Arquivos.Controllers;
using AtividadeFinal_Arquivos.Models;

namespace Arquivos.Views
{
    public class DoctorView
    {
        private DoctorController doctorController;

        public DoctorView()
        {
            doctorController = new DoctorController();
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("VOCÊ ESTÁ EM DOUTORES");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Doutor");
            Console.WriteLine("2 - Listar Doutores");
            Console.WriteLine("3 - Exportar Doutores");
            Console.WriteLine("4 - Importar Doutores");
            Console.WriteLine("5 - Pesquisar Doutores");
            Console.WriteLine("");
            int option = 0;
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Insert();
                    break;
                default:
                    break;

                case 2:
                    List();
                    break;

                case 3:
                    Export();
                    break;

                case 4:
                    Import();
                    break;

                case 5:
                    SearchByName();
                    break;
            }
        }

        private void List()
        {
            List<Doctor> listagem = doctorController.List();

            for (int i = 0; i < listagem.Count; i++)
            {
                Console.WriteLine(Print(listagem[i]));
            }
        }

        private string Print(Doctor doctor)
        {
            string retorno = "";
            retorno += $"Id: {doctor.Id} \n";
            retorno += $"Nome: {doctor.FirstName} {doctor.LastName}\n";
            retorno += "-------------------------------------------\n";

            return retorno;
        }

        private void Insert()
        {
            Doctor doctor = new Doctor();
            doctor.Id = doctorController.GetNextId();

            Console.WriteLine("Informe o primeiro nome: ");
            doctor.FirstName = Console.ReadLine();

            Console.WriteLine("Informe o segundo nome: ");
            doctor.LastName = Console.ReadLine();

            Console.WriteLine("Informe a especialidade: ");
            doctor.Specialty = Console.ReadLine();

            Console.WriteLine("Informe o telefone: ");
            doctor.PhoneNumber = Console.ReadLine();

        }
        private void Export()
        {
            if (doctorController.ExportToTextFile())
                Console.WriteLine("Arquivo gerado com sucesso!");
            else
                Console.WriteLine("Ooooops.");
        }
        private void Import()
        {
            if (doctorController.ImportFromTxtFile())
                Console.WriteLine("Arquivo gerado com sucesso!");
            else
                Console.WriteLine("Ooooops.");
        }
        private void SearchByName()
        {
            Console.WriteLine("Pesquisar doutor pelo nome.");
            Console.WriteLine("Digite o nome.");
            string? name = Console.ReadLine();

            foreach (Doctor d in doctorController.SearchByName(name))
            {
                Console.WriteLine(d.ToString());
            }
        }
    }
}