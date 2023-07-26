using Crm.Entities;
using System;
namespace Crm.Services;

public  class ClientService
{
    
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
     
}
   