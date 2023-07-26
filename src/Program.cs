// See https://aka.ms/new-console-template for more information
using Crm.Entities;
using Crm.Services;
using Crm.methods;
using System;
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
    newClient.Array = MakeOrder();
    string[] MakeOrder()
     {
            Random  rnd = new Random();
            int specifynumber = rnd.Next();
            string[] Array = new string[3];
           Console.WriteLine("Hi dear Client you will make some order :)");
           Console.WriteLine("first of all please specify the name of the thing you want to by there are the list of things:");
           List<string> listOFStuff = new List<string> { "coke 1$", "new friend 10$", "iphone bu really not 200$", "chips 2&", "laptop 400$", "???? 300 buks", "icecream for free!!!!!" };
           foreach (string s in listOFStuff) Console.WriteLine(s);
           string nameOfOrder = Console.ReadLine();
           bool b = listOFStuff.IndexOf(nameOfOrder) >= 0;
           if (b){ 
               Array[0] = specifynumber.ToString();
               specifynumber++;
               Array[1] = nameOfOrder;
               Console.WriteLine("your operation ends successfully");
            }
            else  Console.WriteLine("sorry the system is broke");
            return Array;
  }
}