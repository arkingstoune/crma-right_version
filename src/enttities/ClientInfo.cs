using System;
namespace Crm.Entities;
public struct ClientInfo
{
    public ClientInfo(Client user)
    {
        string[] temproraryaArray = new string[6];
        temproraryaArray[0] = user.FirstName;
        temproraryaArray[1] = user.LastName;
        temproraryaArray[2] = user.MiddleName;
        temproraryaArray[3] = user.Age.ToString();
        temproraryaArray[4] = user.PassportNumber;
        temproraryaArray[5] = user.Gender.ToString();
        ArrayOFUsers = temproraryaArray;
    }
    public string[] ArrayOFUsers{ get; }
}