//Yoshni hisoblash

/*
Foydalanuvchining tug’ilgan yilini (int x) consoledan oling. Uning yoshini kunlarda ifodalang. Kabisa yilini hisobga olmang
Input: x=2004
Output: 6935
-----------------
Input: x= 1996
Output: 9855
*/

namespace Task
{
    public class ThirdTask
    {
        public static void Task()
        {
            Console.Write("Enter your birth year: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            int currentYear = 2024;

            int dayOfLive = (currentYear - birthYear) * 365;

            Console.WriteLine($"Number of days the user has lived: {dayOfLive}");
        }
    }
}
