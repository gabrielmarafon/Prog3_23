using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
    public class Clinic
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? PhoneNumber { get; set; }

        public Clinic()
        {

        }

        public Clinic(int id, string? name, string? address, string? phonenumber)
        {
            Id = id;
            Name = name;
            Address = address;
            PhoneNumber = phonenumber;
        }
    }
}