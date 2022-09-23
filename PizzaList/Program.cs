using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> toppings = new List<string> { "Pepperoni","Margherita","Hawaiian"};

            List<string> selections = ChooseFrom(toppings);
            Console.WriteLine(selections);
            Console.ReadLine();
        }

        private static List<string> ChooseFrom(List<string> toppings)
        {
            string selection = "";
            List<string> selections = new List<string> { };
            while (selection != "q")

            {
                int i = 1;
                foreach (string topping in toppings)
                {
                    Console.WriteLine(i + ". " + topping);
                    i++;
                }
                Console.WriteLine("Enter the corresponding value, q to quit");

                selection = Console.ReadLine();
                if (selection != "q")
                {
                    selections.Add(toppings[(int.Parse(selection) - 1)]);
                }
            }
            return selections;
        }
    }
}
