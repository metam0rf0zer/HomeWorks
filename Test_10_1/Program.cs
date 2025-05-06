using System;

// Базовый класс Building
public class Building
{
    protected string _address;
    protected double _area;
    protected int _yearBuilt;

    public Building(string address, double area, int yearBuilt)
    {
        _address = address;
        _area = area;
        _yearBuilt = yearBuilt;
    }

    // Свойство только для чтения - возраст здания
    public int BuildingAge => DateTime.Now.Year - _yearBuilt;

    // Виртуальный метод для расчета налога
    public virtual double CalculateTax()
    {
        return _area * 1000;
    }

    // Виртуальный метод для вывода информации
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Адрес: {_address}");
        Console.WriteLine($"Площадь: {_area} кв.м");
        Console.WriteLine($"Год постройки: {_yearBuilt}");
        Console.WriteLine($"Возраст здания: {BuildingAge} лет");
        Console.WriteLine($"Налог: {CalculateTax():C}");
    }
}

// Производный класс MultiBuilding (запечатанный - запрещено наследование)
public sealed class MultiBuilding : Building
{
    private int _floors;
    private bool _hasElevator;

    public MultiBuilding(string address, double area, int yearBuilt, int floors, bool hasElevator)
        : base(address, area, yearBuilt)
    {
        _floors = floors;
        _hasElevator = hasElevator;
    }

    // Свойство только для чтения - средняя площадь на этаж
    public double AreaPerFloor => _area / _floors;

    // Переопределенный метод расчета налога
    public override double CalculateTax()
    {
        double baseTax = base.CalculateTax();
        double floorsCoefficient = 1 + (_floors - 1) * 0.05;
        double elevatorFee = _hasElevator ? 5000 : 0;

        return baseTax * floorsCoefficient + elevatorFee;
    }

    // Переопределенный метод вывода информации
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Количество этажей: {_floors}");
        Console.WriteLine($"Наличие лифта: {(_hasElevator ? "Да" : "Нет")}");
        Console.WriteLine($"Средняя площадь на этаж: {AreaPerFloor:F2} кв.м");
        Console.WriteLine($"Налог с учетом коэффициентов: {CalculateTax():C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Демонстрация работы классов Building и MultiBuilding ===");

        // Создание объектов
        Building house = new Building("ул. Ленина, 10", 120.5, 1990);
        MultiBuilding skyscraper = new MultiBuilding("ул. Гагарина, 42", 5000, 2010, 25, true);

        Console.WriteLine("\n1. Информация о здании (базовый класс):");
        house.DisplayInfo();

        Console.WriteLine("\n2. Информация о многоэтажном здании:");
        skyscraper.DisplayInfo();

        // Upcasting - приведение производного класса к базовому
        Console.WriteLine("\n3. Upcasting (приведение MultiBuilding к Building):");
        Building building = skyscraper;
        building.DisplayInfo(); // Вызовется переопределенный метод

        // Downcasting - обратное приведение с проверкой типа
        Console.WriteLine("\n4. Downcasting с проверкой типа:");
        if (building is MultiBuilding)
        {
            MultiBuilding multiBuilding = (MultiBuilding)building;
            Console.WriteLine($"Проверка downcasting: AreaPerFloor = {multiBuilding.AreaPerFloor:F2}");

            // Вызов уникального метода производного класса
            Console.WriteLine("\n5. Использование уникального свойства производного класса:");
            Console.WriteLine($"Средняя площадь на этаж: {multiBuilding.AreaPerFloor:F2} кв.м");
        }

        Console.WriteLine("\n6. Сравнение налогов:");
        Console.WriteLine($"Налог для обычного здания: {house.CalculateTax():C}");
        Console.WriteLine($"Налог для многоэтажки: {skyscraper.CalculateTax():C}");
    }
}