// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;


double cursqr = 0;
double sqr = 0;
bool flag = true;
int num = 0;
for (int i = 1; i < 3; i++)
{
    Console.WriteLine("Введите длину стороны А треугольника номер {0}", i);
    double sideA = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите длину стороны B треугольника номер {0}", i);
    double sideB = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите длину стороны C треугольника номер {0}", i);
    double sideC = Convert.ToDouble(Console.ReadLine());

    // Проверка на возможность существования треугольника
    if (sideA <= 0 || sideB <= 0 || sideC <= 0)
    {
        Console.WriteLine("Длины сторон должны быть положительными");
        flag = false;
        break;
    }

    if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
    {
        Console.WriteLine("Треугольник с такими сторонами не существует");
        flag = false;
        break;

    }
    sqr = CalcSquare(sideA, sideB, sideC);
    Console.WriteLine("Площадь треугольника номер {0} = {1}", i, sqr);
    if (sqr > cursqr)
    {
        cursqr = sqr;
        num = i;
    }

    
}



if (flag==true)
{
    Console.WriteLine("Площадь {0} треугольника больше",num);
}


static double CalcSquare(double sideA, double sideB, double sideC)
{

    double p = (sideA + sideB + sideC) / 2;


    double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
    return area;

}

