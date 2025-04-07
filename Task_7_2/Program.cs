// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите длину ребра куба");
double edge = Convert.ToDouble(Console.ReadLine());
double volume;
double area;

CalcCube(edge,out volume,out area);


Console.WriteLine($"Объем куба: {volume}"); 

Console.WriteLine($"Площадь поверхности куба: {area}"); 
static void CalcCube(double edge, out double volume, out double area)
{

    volume = Math.Pow(edge, 3);
    area=Math.Pow(edge, 2)*6;

}

