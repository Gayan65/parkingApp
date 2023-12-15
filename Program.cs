using ParkingApp;
using System.Text.RegularExpressions;

bool anyMore;
TimeOnly startTime, endTime;
//const string format = @".....";
Regex newFormate = new Regex(@".....");



do
{
    Console.WriteLine("********************************************");
    Console.WriteLine("         WELCOME TO THE PARKING CAL    ");
    Console.WriteLine("   Time in HH.MM (24 hours) format please   ");
    Console.WriteLine("********************************************");

    // Display and Handling of user inputs
    Console.Write(" Enter the Start time               : ");
    string userTime = Console.ReadLine();
    while (!TimeOnly.TryParse(userTime, out startTime) || (startTime.Hour < 7) || (startTime.Hour > 22) || (startTime.Hour >= 22 && startTime.Minute > 00) || !newFormate.IsMatch(userTime))
    {
        Console.Write(" Invalid!, Enter the Start time     : ");
        userTime = Console.ReadLine();
    }

    Console.Write(" Enter the End time                 : ");
    userTime = Console.ReadLine();
    while (!TimeOnly.TryParse(userTime, out endTime) || (endTime.Hour < 7) || (endTime.Hour > 22) || (endTime.Hour >= 22 && endTime.Minute > 00) || startTime > endTime || !newFormate.IsMatch(userTime))
    {
        Console.Write(" Invalid!, Enter the End time       : ");
        userTime = Console.ReadLine();
    }

 


    // Class Access
    Parking obj = new Parking(startTime, endTime);
    Console.WriteLine(" Your fee is EURs {0:F2}", obj.FeeCal());
    Console.WriteLine("***************** THE END ******************");
    Console.WriteLine();


    Console.Write("You wish to contune (Y/N) : ");
    string choice = Console.ReadLine().ToUpper();
    if(choice.StartsWith("Y"))
        anyMore = true;
    else
        anyMore = false;
} while (anyMore);