
namespace CharacterStats
{
    using System;

    public class CharacterStats
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            var frontPartHealth = new string('|', currentHealth);
            var backPartHealth = new string('.', maxHealth - currentHealth);

            var frontPartEnergy = new string('|', currentEnergy);
            var backPartEnergy = new string('.', maxEnergy - currentEnergy);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{frontPartHealth}{backPartHealth}|");
            Console.WriteLine($"Energy: |{frontPartEnergy}{backPartEnergy}|");
        }
    }
}
