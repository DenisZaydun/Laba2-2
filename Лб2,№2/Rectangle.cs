using System;

namespace Лб2__2
{
    class Rectangle
    {
        private double _side1, _side2;

        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        private double AreaCalculator()
        {
            double area = _side1 * _side2;
            return area;
        }


        private double PerimeterCalculator()
        {
            double perimeter = (_side1 * 2) + (_side2 * 2);
            return perimeter;
        }

        public double Area  //Создать два свойства double Area и double Perimeter с одним методом доступа get.
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Периметр прямокутника: {Perimeter}");
            Console.WriteLine($"Площа прямокутника: {Area}");
        }
    }
}
