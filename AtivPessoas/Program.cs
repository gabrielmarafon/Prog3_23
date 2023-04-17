using AtivPessoas.Classes;

Person[] people = new Person[]
{
    new Manager{
        Name = "Glauber Rodrigues"
        , Gender = "Masculino"
        , DateBorn = new(year: 1976, month: 3, day: 22)
        , SubordinateSectors = 4
        , Wage = 8750
    },
    new Supervisor{
        Name = "Larissa dos Santos"
        , Gender = "Feminino"
        , DateBorn = new(year: 1996, month: 9, day: 17)
        , SubordinateEmployees = 25
        , Wage = 5000
    },
    new Worker{
        Name = "Thiago da Silvassauro"
        , Gender = "Masculino"
        , DateBorn = new(year: 1980, month: 7, day: 30)
        , IdentificationNumber = 25
        , Function = "Auxiliar de Produção"
        , Wage = 2500
    },
    new Worker{
        Name = "Carolina Fernandes"
        , Gender = "Feminino"
        , DateBorn = new(year: 1999, month: 11, day: 14)
        , IdentificationNumber = 95
        , Function = "Auxiliar Administrativo"
        , Wage = 2000
    }
};
for (int i = 0; i < people.Length; i++)
{
    string message; 
    message = $"Nome: {people[i].Name} ";
    message += $"Gênero: {people[i].Gender} ";
    message += $"Data Nasc: {people[i].DateBorn.ToShortDateString()} ";
    message += $"Setores Subordinados: {people[i].SubordinateSectores}"
    Console.WriteLine(message);
}
