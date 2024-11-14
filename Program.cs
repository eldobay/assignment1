using System.Runtime.InteropServices;

namespace assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallCarpet = 25 ;
            int largeCarpet = 35 ;
            double tax = .06 ;
            Console.WriteLine("number of small carpet : ");
            int numberofsmallcarpet = int.Parse(Console.ReadLine());
            Console.WriteLine($"number of small carpet : {numberofsmallcarpet} ");
            int costofsmallcarpet = smallCarpet * numberofsmallcarpet;
             Console.WriteLine(costofsmallcarpet);


            Console.WriteLine("number of large carpet :  ");
            int numberoflargecarpet = int.Parse(Console.ReadLine());
            Console.WriteLine($"number of large carpet : {numberoflargecarpet} ");
            int costoflargecarpet = largeCarpet * numberoflargecarpet;
            Console.WriteLine(costoflargecarpet);

            double thetotalprice = costofsmallcarpet + costoflargecarpet + tax ;
            Console.WriteLine($"the total price is  : {thetotalprice}");



        }
    }
}
