using Crm.Entities;
namespace Crm.methods;
public class errorCode
{
        public static bool ValidateClient(
        string firstName,
        string lastName,
        string middleName,
        string ageStr,
        string passportNumber,
        string genderStr)
    {
        List<string> errors = new();

        if (firstName is { Length: 0 })
            errors.Add("First Name field is required!");

        if (lastName is { Length: 0 })
            errors.Add("Last Name field is required!");

        if (middleName is { Length: 0 })
            errors.Add("Middle Name field is required!");

        bool isAgeCorrect = short.TryParse(ageStr, out short age);
        if (!isAgeCorrect)
            errors.Add("Please input correct value for age field!");

        if (passportNumber is { Length: 0 })
            errors.Add("Passport Number field is required!");

        bool isGenderCorrect = int.TryParse(genderStr, out int genderIndex);
        if (!isGenderCorrect)
            errors.Add("Please input correct value for gender field!");

         bool isEnumGenderCorrect = genderIndex.TryParse(out Entities.Gender gender);
         if (!isEnumGenderCorrect)
             errors.Add("Please input correct value for gender field (0 - Male, 1 - Female)!");

        if (errors is { Count: > 0 })
        {
            foreach(string errorMessage in errors)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errorMessage);
            }

            Console.ForegroundColor = ConsoleColor.White;
            return false;
        }

        return true;
    }
}