using System;


namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
        
            SuperList numbers = new SuperList(new double[] { 1.5, 20.3, 
            14.7, 0.8, 4.2 });

            numbers.GetMinMax1(out double min1, out double max1);
            Console.WriteLine($"GetMinMax1 Min:{min1} and Max: {max1}");

            var resultado2 = numbers.GetMinMax2();
            Console.WriteLine($"GetMinMax2 Min:{resultado2.MinS} and Max:" +
            $" {resultado2.MaxS}");

            var result3 = numbers.GetMinMax3();
            Console.WriteLine($"GetMinMax3 Min: {result3.min} and Max: {result3.max}");

            var (min4, max4) = numbers.GetMinMax4();
            Console.WriteLine($"GetMinMax4 Min: {min4} and Max: {max4}");
        }
    }
}
