// See https://aka.ms/new-console-template for more information
using Crm.Entities;
using Crm.Services;
using Crm.methods;
 ClientService clientService = new();
 CreateClient();
 
void CreateClient()
{
    string firstName = Console.ReadLine();
    string lastName = Console.ReadLine();
    string middleName = Console.ReadLine();
    string ageInputStr = Console.ReadLine();
    string passportNumber = Console.ReadLine();
    string[] array = new string[3];
   string genderInputStr = Console.ReadLine();

    if(!errorCode.ValidateClient(
        firstName,
        lastName,
        middleName,
        ageInputStr,
        passportNumber,
        genderInputStr
    )) return;

    Gender gender = (Gender)int.Parse(genderInputStr);
    short age = short.Parse(ageInputStr);

    Client newClient = clientService.CreateClient(
        firstName,
        lastName,
        middleName,
        age,
        passportNumber,
        gender
    );
    newClient.Array = ClientService.MakeOrder(firstName);
}