using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sum = Add(6, 2);
            Console.WriteLine(sum);

            var doubleSum = Add(6.2, 2.6);
            Console.WriteLine(doubleSum);

            var decimalSum = Add(2.66m, 6.22m);
            Console.WriteLine(decimalSum);



            var dollarBill5 = Add(3, 2, true);
            Console.WriteLine(dollarBill5);

            var dollarBill1 = Add(0, 1, true);
            Console.WriteLine(dollarBill1);

            var dollarBill16 = Add(8, 8, true);
            Console.WriteLine(dollarBill16);

            var dollarBillFalse = Add(4, 4, false);
            Console.WriteLine(dollarBillFalse);


        }

        public static int Add(int a, int b)
        {
            return (a + b);
        }
        public static double Add(double a, double b)
        {
            return (a + b);
        }
        public static decimal Add(decimal a, decimal b)
        {
            return (a + b);
        }

        public static string Add(int a, int b, bool withDollars)
        {
            if (withDollars && (a + b != 1))
            {
                return ($"{a + b} dollars");
            }
            else if (withDollars && (a + b) == 1)
            {
                return ($"{a + b} dollar");
            }
            else
            {
                return ("Get out of here with your counterfeit bills");
            }
        }
    }
}
