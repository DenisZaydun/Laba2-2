using System;

namespace Лб2__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.Write("Введіть першу сторону прямокутника: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Введіть другу сторону прямокутника: ");
            double side2 = double.Parse(Console.ReadLine());

            Rectangle firstRectangle = new Rectangle(side1, side2);

            firstRectangle.GetInfo();

            Console.ReadKey();
        }
    }
}