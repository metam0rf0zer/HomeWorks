namespace Task_11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flys = new IFlyable[]
            {
                new Plane(12000,150),
                new Bird(1000),
            };


            foreach (IFlyable flyable in flys)
            {
                Console.WriteLine(flyable.Fly());
            }
        }
    }
    interface IFlyable
    {
        int MaxAltitude { get; }
        string Fly();
    }

    class Bird : IFlyable
    {
        public Bird(int maxAltitude)
        {
            MaxAltitude = maxAltitude;
        }

        public int MaxAltitude { get; set; }

        public string Fly() => $"лечу на высоте {MaxAltitude} метров";
    }

    class Plane : IFlyable
    {
        int CountPassangers { get; set; }
        public Plane(int maxAltitude, int countPassangers)
        {
            MaxAltitude = maxAltitude;
            CountPassangers = countPassangers;
        }

        public int MaxAltitude { get; set; }

        public string Fly() => $"лечу на высоте {MaxAltitude} метров. Везу {CountPassangers} пассажиров";
    }

}
