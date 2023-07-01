using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;
using AtividadeFinal_Arquivos.Models;

namespace Arquivos.Utils
{
    public static class Bootstrapper
    {
        public static void BootstrapperChangeDoctors()
        {
            var d1 = new Doctor
            {
                Id = 1,
                FirstName = "Gabriel",
                LastName = "Marafon",
                Specialty = "Ortopedia",
                PhoneNumber = "49 95555-5555"
            };
            DataSet.Doctors.Add(d1);

            DataSet.Doctors.Add(
                new Doctor
                {
                    Id = 2,
                    FirstName = "Jefer",
                    LastName = "Sound",
                    Specialty = "Homeopatia",
                    PhoneNumber = "49 92424-1111"
                }
            );

            DataSet.Doctors.Add(
                new Doctor
                {
                    Id = 3,
                    FirstName = "Vitão",
                    LastName = "Soligo",
                    Specialty = "Oncologia",
                    PhoneNumber = "49 91111-2424"
                });
        }

        public static void BootstrapperChargeClinic()
        {
            var c1 = new Clinic
            {
                Id = 1,
                Name = "Ducão",
                Address = "Avenida Brasil, 55, Centro",
                PhoneNumber = "49 91234-5678"
            };
            DataSet.Clinics.Add(c1);

            DataSet.Clinics.Add(
                new Clinic
                {
                    Id = 2,
                    Name = "Ducat",
                    Address = "Avenida Amazonas, 99, Matriz",
                    PhoneNumber = "49 99876-5432"
                });

            DataSet.Clinics.Add(
                new Clinic
                {
                    Id = 3,
                    Name = "Amor de Pet",
                    Address = "Rua dos Carecas, 178, Centro",
                    PhoneNumber = "49 97648-9132"
                });
        }

        public static void BootstrapperChargeClient()
        {
            var cliente1 = new Client
            {
                Id = 1,
                CPF = "123.456.678-10",
                FirstName = "Chuck",
                LastName = "Noris",
                Email = "fodastico@gmail.com"
            };
            DataSet.Clients.Add(cliente1);

            DataSet.Clients.Add(
                new Client
                {
                    Id = 2,
                    CPF = "987.654.321-10",
                    FirstName = "Tim",
                    LastName = "Maia",
                    Email = "canalesonorizasom@gmail.com"
                });

            DataSet.Clients.Add(
                new Client
                {
                    Id = 3,
                    CPF = "198.273.555-55",
                    FirstName = "Coronel",
                    LastName = "Veigh",
                    Email = "vidachique@gmail.com"
                });
        }
        public static void BootstrapperChargeAnimal()
        {
            var a1 = new Animal
            {
                Id = 1,
                Pawns = "Quatro",
                Species = "Cachorro",
                Sex = "Macho",
                Color = "Preto"
            };
            DataSet.Animals.Add(a1);

            DataSet.Animals.Add(
                new Animal
                {
                    Id = 2,
                    Pawns = "2",
                    Species = "Pato",
                    Sex = "Macho",
                    Color = "Branco"
                });

            DataSet.Animals.Add(
                new Animal
                {
                    Id = 3,
                    Pawns = "Quatro",
                    Species = "Gato",
                    Sex = "Femea",
                    Color = "Azul"
                });
        }
    }
}