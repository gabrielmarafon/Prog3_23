using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Models;
using AtividadeFinal_Arquivos.Models;

namespace Arquivos.Data
{
    public static class DataSet
    {
        public static List<Client> Clients
            = new List<Client>();
        public static List<Animal> Animals
            = new List<Animal>();

        public static List<Clinic> Clinics
            = new List<Clinic>();

        public static List<Doctor> Doctors
            = new List<Doctor>();
    }
}