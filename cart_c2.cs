using System;

namespace icetask1
{
    class Cart
    {
        private const string V = "===========================================================\n";
        private double G_Total, rateVAT;
        readonly double VATamount = 1.14;

        public Cart(double TotalPrice) => Total_Price = TotalPrice;

        public double Total_Price { get; set; }

        public void count()
        {
            this.rateVAT = Total_Price * 0.14;
            G_Total = this.Total_Price * this.VATamount;
        }

        public void DisplayOutput(String output)
        {

            Console.WriteLine(V +
                "-----------------------------------------------------------");

            Console.WriteLine(value: output);
            Console.WriteLine("-------------------");

            Console.WriteLine(value: "Total R"
                                     + this.Total_Price
                                     + "\n"
                                     + "+VAT "
                                     + this.rateVAT.ToString("C"));

            Console.WriteLine("------------------------------");

            Console.WriteLine(value: "Grand Total: " + this.G_Total.ToString("C")); //0.00 R0.00

            Console.WriteLine("------------------------------");

            Console.WriteLine(V);

        }
    }

}
