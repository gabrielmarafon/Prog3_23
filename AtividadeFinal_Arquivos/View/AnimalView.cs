using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Models;
using Arquivos.Data;
using Arquivos.Views;
using AtividadeFinal_Arquivos.Controllers;

namespace Arquivos.Views
{
    public class AnimalView
    {
        private AnimalController animalController;

        public AnimalView()
        {
            animalController = new AnimalController();
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("VOCÊ ESTÁ EM ANIMAIS");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Animal");
            Console.WriteLine("2 - Listar Animais");
            Console.WriteLine("3 - Exportar Animais");
            Console.WriteLine("4 - Importar Animais");
            Console.WriteLine("5 - Pesquisar Animais");
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
                    SearchByColor();
                    break;
            }
        }

        private void List()
        {
            List<Animal> listagem = animalController.List();

            for (int i = 0; i < listagem.Count; i++)
            {
                Console.WriteLine(Print(listagem[i]));
            }
        }

        private string Print(Animal animal)
        {
            string retorno = "";
            retorno += $"Id: {animal.Id} \n";
            retorno += $"Especie: {animal.Species}\n";
            retorno += "-------------------------------------------\n";

            return retorno;
        }

        private void Insert()
        {
            Animal animal = new Animal();
            animal.Id = animalController.GetNextId();

            Console.WriteLine("Informe a quantidade de patas: ");
            animal.Pawns = Console.ReadLine();

            Console.WriteLine("Informe a Especie: ");
            animal.Species = Console.ReadLine();

            Console.WriteLine("Informe o sexo: ");
            animal.Sex = Console.ReadLine();

            Console.WriteLine("Informe a cor: ");
            animal.Color = Console.ReadLine();

            bool retorno = animalController.Insert(animal);

            if (retorno)
                Console.WriteLine("Animal Inserido com sucesso!");

            else Console.WriteLine("Falha ao inserir, verifique os dados");
        }
        private void Export()
        {
            if (animalController.ExportToTextFile())
                Console.WriteLine("Arquivo gerado com sucesso!");
            else
                Console.WriteLine("Ooooops.");
        }
        private void Import()
        {
            if (animalController.ImportFromTxtFile())
                Console.WriteLine("Arquivo gerado com sucesso!");
            else
                Console.WriteLine("Ooooops.");
        }
        private void SearchByColor()
        {
            Console.WriteLine("Pesquisar animal pela Cor.");
            Console.WriteLine("Digite a cor.");
            string? name = Console.ReadLine();

            foreach (Animal a in animalController.SearchByColor())
            {
                Console.WriteLine(a.ToString());
            }
        }
    }
}