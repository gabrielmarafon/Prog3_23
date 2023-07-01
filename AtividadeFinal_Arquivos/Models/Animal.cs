using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{   
    public class Animal
    {
        public int Id { get; set; }
        public string? Pawns { get; set; }

        public string? Species { get; set; }

        public string? Sex { get; set; }

        public string? Color { get; set; }

        public Animal()
        {

        }

        public Animal(int id, string? pawns, string? species, string? sex, string? color)
        {
            Id = id;
            Pawns = pawns;
            Species = species;
            Sex = sex;
            Color = color;
        }
    }
}