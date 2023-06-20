using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtivAnimais.Models
{
    public class Animal
    {
        public Animal()
        {
        }

        public Animal(int id, string? name, string? species, string? breed, string? owner)
        {
            Id = id;
            Name = name;
            Species = species;
            Breed = breed;
            Owner = owner;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Species { get; set; }
        public string? Breed { get; set; }
        public string? Owner { get; set; }
    }
}