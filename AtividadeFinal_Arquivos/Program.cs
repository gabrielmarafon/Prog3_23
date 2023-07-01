using Arquivos.Views;
using Arquivos.Utils;

/*
    programa para leitura e exportação em arquivos .txt
*/

Bootstrapper.BootstrapperChangeDoctors();
Bootstrapper.BootstrapperChargeClinic();
Bootstrapper.BootstrapperChargeAnimal();
Bootstrapper.BootstrapperChargeClient();

int option = 0;

do 
{
    Console.WriteLine("********************");
    Console.WriteLine("Programa para leitura e exportação de dados");
    Console.WriteLine("********************");
    Console.WriteLine("");
    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Clinica");
    Console.WriteLine("3 - Doutor");
    Console.WriteLine("4 - Animal");

    option = Convert.ToInt32(Console.ReadLine());

    switch(option)
    {
        case 1:
            Console.WriteLine("OPÇÃO CLIENTES");
            ClientView clientView = new ClientView();
        break;

        case 2:
            Console.WriteLine("OPÇÃO CLINICA");
            ClinicView clinicView = new ClinicView();
        break;

        case 3:
            Console.WriteLine("OPÇÃO DOUTOR");
            DoctorView doctorView = new DoctorView();
        break;

        case 4:
            Console.WriteLine("OPÇÃO ANIMAL");
            AnimalView animalView = new AnimalView();
        break;
    }
}
while(option > 0 );