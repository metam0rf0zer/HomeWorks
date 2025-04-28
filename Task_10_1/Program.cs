using System.Net;

namespace Task_10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //одноэтажное здание
            Building building = new Building("г. Москва, ул. Ленина дом№ 8", 1500, 1989);
            building.DisplayInfo();

            //многоэтажное здание
            MultiBuilding mbuilding = new MultiBuilding("г. Москва, ул. Маркса дом№ 3", 1500, 1979, 24, true);
            mbuilding.DisplayInfo();

            //UPCASTING
            Console.WriteLine("UPCASTING");
            Building upcastbuilding = mbuilding;
            upcastbuilding.DisplayInfo();

            //DOWNCASTING 

            Console.WriteLine("DOWNCASTING");
            if (upcastbuilding is MultiBuilding)
            {
                MultiBuilding multiBuilding = (MultiBuilding)upcastbuilding;
                Console.WriteLine($"Проверка downcasting: AreaPerFloor = {multiBuilding.AreaPerFloor:F2}");

                // Вызов уникального метода производного класса
                Console.WriteLine("\n5. Использование уникального свойства производного класса:");
                Console.WriteLine($"Средняя площадь на этаж: {multiBuilding.AreaPerFloor:F2} кв.м");
            }       

            Console.WriteLine("\n=== Уникальные методы MultiBuilding ===");
            Console.WriteLine($"Налог с учетом этажей: {mbuilding.CalculateTax():C2}");
            Console.WriteLine($"Средняя площадь этажа: {mbuilding.AreaPerFloor:F2} кв.м");
        }
    }
    public class Building
    {
        // Поля
        protected string _address;
        protected double _area;
        protected int _yearBuilt;


        public int BuildingAge
        {
            get { return DateTime.Now.Year - _yearBuilt; }
        }
        // Конструктор
        public Building(string address, double area, int yearBuilt)
        {
            _address = address;
            _area = area;
            _yearBuilt = yearBuilt;
        }
        // Виртуальный метод расчета налога
        public virtual double CalculateTax()
        {
            return _area * 1000;
        }

        // Виртуальный метод вывода информации
        public virtual void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine("======Одноэтажное здание=======");
            Console.WriteLine($"Адрес: {_address}");
            Console.WriteLine($"Площадь: {_area} кв.м");
            Console.WriteLine($"Год постройки: {_yearBuilt}");
            Console.WriteLine($"Возраст здания: {BuildingAge} лет");
            Console.WriteLine($"Налог: {CalculateTax():C2}");
            Console.WriteLine();
        }
    }
    public sealed class MultiBuilding : Building
    {
        int _floors;
        bool _hasElevator;

        public MultiBuilding(string address, double area, int yearBuilt, int floors, bool hasElevator)
            : base(address, area, yearBuilt)
        {
            _floors = floors;
            _hasElevator = hasElevator;
        }
        public double AreaPerFloor
        {
            get
            {
                return _area / _floors;
            }
        }
        public override double CalculateTax()
        {
            if (_hasElevator)
            {
                return _area * 1000 * (1 + (_floors - 1) * 0.05);
            }
            else
            {
                return _area * 1000 * (1 + (_floors - 1) * 0.05) + 5000;
            }
        }
        public override void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine("======Многоэтажное здание=======");
            Console.WriteLine($"Адрес: {_address}");
            Console.WriteLine($"Площадь: {_area} кв.м");
            Console.WriteLine($"Год постройки: {_yearBuilt}");
            Console.WriteLine($"Возраст здания: {BuildingAge} лет");
            Console.WriteLine($"Налог: {CalculateTax():C2}");
            string elevator = _hasElevator ? "Есть" : "Отсутствует";
            Console.WriteLine($"Наличие лифта: {elevator}");
            Console.WriteLine($"Количество этажей: {_floors}");
            Console.WriteLine($"Площадь на этаж: {AreaPerFloor}");
            Console.WriteLine();
        }

    }
}
