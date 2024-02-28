//Valyuta konvertri

/*
Bir valyutadagi summani sumga aylantiruvchi dastur tuzing. Summa va valyuta kursini e’lon qiling va konvertatsiya qilingan summani hisoblang. Natijani ekranga chiqaring.
Input: qiymat=2, kurs=12400 so’m
Output: 24800 so’m
----------------
Input: qiymat=7.6, kurs=12400 so’m
Output: 94240 so’m
*/

namespace Task
{
    public class SecondTask
    {
        public static void Task()
        {
            Console.Write("Enter the amount of currency: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the price of currency: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            decimal total = amount * price;

            Console.WriteLine($"The total value of the currency: {total}");
        }
    }
}
