using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetherRealms
{
    public class NetherRealms
    {
        public static void Main()
        {
            string[] demonsNames = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            
            SortedDictionary<string, double[]> demonsData = new SortedDictionary<string, double[]>();

            foreach (var demon in demonsNames)
            {
                double health = GetDemonsHealth(demon);
                double damage = GetDemonsDamage(demon);
                
                if (!demonsData.ContainsKey(demon))
                {
                    demonsData[demon] = new double[2];
                }

                demonsData[demon][0] = health;
                demonsData[demon][1] = damage;
            }
            
            foreach (var demon in demonsData)
            {
                var name = demon.Key;
                var health = demon.Value[0];
                var damage = demon.Value[1];
                Console.WriteLine($"{name} - {health:f0} health, {damage:f2} damage");
            }
        }

        public static double GetDemonsHealth(string demonsName)
        {
            double health = 0;

            foreach (var symbol in demonsName)
            {
                if (symbol != '+' && symbol != '-' && symbol != '*' && symbol != '/' && symbol != '.' && !char.IsDigit(symbol))
                {
                    health += symbol;
                }
            }
            //'+', '-', '*', '/') and delimiter dot ('.'))
            return health;
        }

        public static double GetDemonsDamage(string demon)
        {
            Regex regex = new Regex(@"([+-]?[0-9]+\.[0-9]+)|([+-]?[0-9]+)");

            var damage = regex.Matches(demon)
                .Cast<Match>()
                .Select(x => x.Value)
                .Select(double.Parse)
                .Sum();

            foreach (var symbol in demon)
            {
                if (symbol == '*')
                {
                    damage *= 2;
                }
                else if (symbol == '/')
                {
                    damage /= 2;
                }
            }

            return damage;
        }
    }
}
