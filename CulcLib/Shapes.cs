using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulcLib
{ 
    public abstract class Figure
    {
        public abstract double CalcSquare();
    }

    public class Circle : Figure
    {
        public double Radius { get; private set; }

        public Circle(double Radius)
        {
            if (Radius < 0) throw new ArgumentException($"Ошибка: радиус не может быть меньше 0\nПроверьте введённый значения");
            this.Radius = Radius;
        }

        public override double CalcSquare()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }

    public class Triangle : Figure
    {
        public double ab { get; private set; }
        public double bc { get; private set; }
        public double ac { get; private set; }

        public Triangle(double ab, double bc, double ac)
        {
            if (ab < 0 || bc < 0 || ac < 0) throw new ArgumentException(
                $"Ошибка: стороны не могут быть меньше 0\nПроверьте введённый значения");
            else if (ab > (bc + ac) || bc > (ab + ac) || ac > (ab + bc)) throw new ArgumentException(
                $"Ошибка: не соблюдено соотногение сторон\nПроверьте введённый значения");
            else
            {
                this.ab = ab;
                this.bc = bc;
                this.ac = ac;
            }
        }

        public override double CalcSquare()
        {
            double p = (ab + bc + ac) / 2;
            double result = Math.Round(Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac)), 1);
            return result;
        }

        public bool IsRectangular()
        {
            bool check = (ab == Math.Sqrt(Math.Pow(bc, 2) + Math.Pow(ac, 2))
                         || bc == Math.Sqrt(Math.Pow(ab, 2) + Math.Pow(ac, 2))
                         || ac == Math.Sqrt(Math.Pow(ab, 2) + Math.Pow(bc, 2)));
            return check;
        }
    }
}
