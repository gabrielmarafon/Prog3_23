using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Utils
{
    public static class Bootstrapper
    {
        public static void ChangeClients()
        {
            var c1 = new Client
            {
                Id = 1,
                FirstName = "Gabriel",
                LastName = "Marafon",
                CPF = "000.000.000-00",
                Email = "gabrielmarafon5@gmail.com"
            };
            DataSet.Clients.Add(c1);

            DataSet.Clients.Add(
                new Client
                {
                    Id = 2,
                    FirstName = "Jefer",
                    LastName = "Sound",
                    CPF = "000.000.000-01",
                    Email = "zjeferbroxasound@gmail.com"
                }
            );

            DataSet.Clients.Add(
                new Client
                {
                    Id = 3,
                    FirstName = "Vitãa",
                    LastName = "Soligo",
                    CPF = "000.000.000-02",
                    Email = "vitaogemefino@gmail.com"
                });
        }
    }
}