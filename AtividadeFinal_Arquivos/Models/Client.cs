using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{//incicio do escopo do namespace
    public class Client
    { //inicio do escopo da classe
        public int Id {get; set;}
        public string? FirstName {get; set;}

        public string? LastName {get; set;}

        public string? CPF {get; set;}

        public string? Email {get; set;}

        //os métodos construtores são responsáveis por instanciar uma variável do tipo especificado pela classe.
        // a regra é de que o construtor tenha o mesmo nome da classe.
        public Client()
        {

        }

        //método SEMPRE utiliza parenteses
        public Client(int id, string? firstName, string? lastName, string? cPF, string? email)
        {
            //inicia o escopo deste método
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CPF = cPF;
            Email = email;
        }//fim do escopo deste método

        public string FullName => $"{this.FirstName} {this.LastName}";

        public override string ToString()
        {
            return $"Id: {this.Id}; Name: {this.FullName}";
        }

    }//fim do escopo da classe
}// fim do escopo do namespace