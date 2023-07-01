using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeFinal_Arquivos.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Specialty { get; set; }

        public string? PhoneNumber { get; set; }

        public Doctor()
        {

        }

        public Doctor(int id, string? firstName, string? lastName, string? specialty, string? phonenumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Specialty = specialty;
            PhoneNumber = phonenumber;
        }

        public string FullName => $"{this.FirstName} {this.LastName}";

        public override string ToString()
        {
            return $"Id: {this.Id}; Name: {this.FullName}";
        }

    }
}