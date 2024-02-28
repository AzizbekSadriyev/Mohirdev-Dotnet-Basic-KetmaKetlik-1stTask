// Doira yuzi va aylana uzunligini hisoblash

/*
Console dan raduisni qiymatini oling va erkanga doiraning yuzi (S=pi*radius^2) va aylana uzunligini (L=2*pi*radius) erkanga chiqaring.
Input: radius=3
Output: S=28.2743338823081, L=18.8495559215388
--------------
Input: radius=4.23
Output: S=56.2122031914168, L=26.5778738493697
*/

namespace Task
{
    public class FirstTask
    {
        public static void Task()
        {
            Console.Write("Enter the radius of the circle:   ");

            decimal radius = Convert.ToDecimal(Console.ReadLine());
            const decimal PI = (decimal)Math.PI;
            decimal length = 2 * PI * radius;
            decimal surface = PI * radius * radius;

            Console.WriteLine($"The surface of the circle: {surface}");
            Console.WriteLine($"The radius of the circle: {length}");
        }
    }
}
