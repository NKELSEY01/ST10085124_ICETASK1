using System;

namespace icetask1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var TotalPrice = 0.0;
                //object[] obj = new object[size]
                try
                {
                    item_c1[] items = new item_c1[5];
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("Please enter the name of the item: ");
                        string NameOfItem = Console.ReadLine();

                        Console.Write("Please enter the price of each item: ");
                        double PriceOfItem = Convert.ToDouble(Console.ReadLine());

                        TotalPrice += PriceOfItem;//All 5 prices added together

                        items[i] = new item_c1(NameOfItem, PriceOfItem);
                    }

                    Cart cart = new(TotalPrice);

                    cart.count();
                    string output = "";
                    for (int i = 0; i < 5; i++)
                    {
                        output += items[i].NameOfItems
                                  + " "
                                  + items[i].PriceOfItems.ToString("C")
                                  + "\n";
                    }
                    cart.DisplayOutput(output);

                    Console.WriteLine("Please enter 0 to exit the program");
                    var exit = Convert.ToInt32(Console.ReadLine());
                    if (exit
                        == 0) ;
                    {
                        Environment.Exit(0);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You have eneterd an invalid format");
                }
            }
        }
    }
}
