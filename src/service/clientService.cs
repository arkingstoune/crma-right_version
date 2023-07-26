using Crm.Entities;

namespace Crm.Services;

public  class ClientService
{
    int specifynumber = 32434;
    public Client CreateClient(
        string firstName,
        string lastName,
        string middleName,
        short age,
        string passportNumber,
        Gender gender
    )
    {
        // TODO: Validate input parameters.
        return new()
        {
            FirstName = firstName,
            LastName = lastName,
            MiddleName = middleName,
            Age = age,
            // ditailOfOrders = DitailOfOrders,
            PassportNumber = passportNumber,
            Gender = gender
        };
    }
     public string[] MakeOrder(string s)
     {
        
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
            }
            else Console.WriteLine("sorry the system is broke");
            return Array;
  }
}
   