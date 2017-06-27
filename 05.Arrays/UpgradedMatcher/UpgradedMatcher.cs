namespace UpgradedMatcher
{
    using System;
    using System.Linq;

    public class UpgradedMatcher
    {
        public static void Main()
        {
            var goods = Console.ReadLine().Split().ToArray();
            var quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            var product = Console.ReadLine().Split().ToArray();

            while (product[0] != "done")
            {
                for (int i = 0; i < goods.Length; i++)
                {
                    if (goods[i] == product[0])
                    {
                        var orderQuantity = long.Parse(product[1]);
                        
                        if (i < quantities.Length && quantities[i] >= orderQuantity)
                        {
                            Console.WriteLine($"{goods[i]} x {product[1]} costs {prices[i] * orderQuantity:f2}");
                            quantities[i] -= orderQuantity;
                        }
                        else
                        {
                            Console.WriteLine($"We do not have enough {goods[i]}");
                        }
                    }
                }
               
                product = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
