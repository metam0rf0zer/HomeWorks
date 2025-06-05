namespace Доп_задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Character
    {
        public Character(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public bool IsAlive => Health > 0;

        virtual public void Attack(Character target)
        {
            if (!this.IsAlive) return;

            target.Health -= Damage;
            Console.WriteLine($"{Name} наносит {Damage} урона {target.Name}!");


        }
        
    }
}
