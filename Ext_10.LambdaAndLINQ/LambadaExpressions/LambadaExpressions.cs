namespace LambadaExpressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LambadaExpressions
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, string>> expressions = 
                new Dictionary<string, Dictionary<string, string>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "lambada")
            {
                var inputData = inputLine.Split(new[] {' ', '=', '>', '.'}, StringSplitOptions.RemoveEmptyEntries);

                if (inputData[0] != "dance")
                {
                    var selector = inputData[0];
                    var selectorObject = inputData[1];
                    var property = inputData[2];
                        
                    if (! expressions.ContainsKey(selector))
                    {
                        expressions.Add(selector, new Dictionary<string, string>());
                    }

                    expressions[selector][selectorObject] = property;
                }
                else
                {
                    expressions = expressions
                        .ToDictionary(selector => selector.Key, 
                        selector => selector.Value.ToDictionary(selectorObject => 
                        selectorObject.Key, selectorObject => selectorObject.Key + "." + selectorObject.Value));
                }

                inputLine = Console.ReadLine();
            }

            foreach (var expression in expressions)
            {
                foreach (var selectorObject in expression.Value)
                {
                    Console.WriteLine($"{expression.Key} => {selectorObject.Key}.{selectorObject.Value}");
                }
            }
            // *** The same action and same result, but with LINQ only:
            //expressions
            //    .ToList()
            //    .ForEach(selector => selector.Value
            //    .ToList()
            //    .ForEach(selectorObject => 
            //    Console.WriteLine($"{selector.Key} => {selectorObject.Key}.{selectorObject.Value}")));
        }
    }
}
