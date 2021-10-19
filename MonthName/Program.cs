using System;

namespace MonthName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user!\nPlease enter any year number followed by month number" +
                " to see how many days are there:\nGOOD LUCK!");
            string result = Console.ReadLine();
            string result2 = Console.ReadLine();
            int resultnumber = Convert.ToInt32(result);
            int resultnumber2 = Convert.ToInt32(result2);
            int daysInMonth = System.DateTime.DaysInMonth(resultnumber, resultnumber2);
            string fullNameOfTheMonth = result2;
            Console.WriteLine($"There are {daysInMonth} days!\nThank you for using this app!");
            Console.ReadLine();
        }


    }
}
