namespace DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DragonArmy
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, double[]>> dragons = new Dictionary<string, Dictionary<string, double[]>>();

            for (int i = 0; i < n; i++)
            {
                var currentDragon = Console.ReadLine().Split().ToArray();

                var type = currentDragon[0];
                var name = currentDragon[1];
                double damage = 0;
                double health = 0;
                double armor = 0;

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new Dictionary<string, double[]>();
                }

                if (!dragons[type].ContainsKey(name))
                {
                    dragons[type][name] = new double[3];
                }

                if (currentDragon[2] == "null")
                {
                    damage = 45.0;
                }
                else
                {
                    damage = double.Parse(currentDragon[2]);
                }

                if (currentDragon[3] == "null")
                {
                    health = 250.0;
                }
                else
                {
                    health = double.Parse(currentDragon[3]);
                }

                if (currentDragon[4] == "null")
                {
                    armor = 10.0;
                }
                else
                {
                    armor = double.Parse(currentDragon[4]);
                }

                dragons[type][name][0] = damage;
                dragons[type][name][1] = health;
                dragons[type][name][2] = armor;
            }

            foreach (var dragon in dragons)
            {
                double totalDamage = 0;
                double totalHealth = 0;
                double totalArmor = 0;
                int count = 0;

                foreach (var item in dragon.Value)
                {
                    count++;
                    totalDamage += item.Value[0];
                    totalHealth += item.Value[1];
                    totalArmor += item.Value[2];
                }

                Console.Write("{0}::", dragon.Key);
                Console.WriteLine("({0:f2}/{1:f2}/{2:f2})", totalDamage / count, totalHealth / count, totalArmor / count);

                foreach (var state in dragon.Value.OrderBy(k => k.Key))
                {
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", state.Key, state.Value[0], state.Value[1], state.Value[2]);
                }
            }
        }
    }
}
