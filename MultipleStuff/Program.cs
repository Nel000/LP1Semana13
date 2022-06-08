using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            double min, max;

            SuperList sl = new SuperList() { 125.6, 12.1, 175.4, 11.2, 41.7 };
            
            min = sl.GetMinMax1(out max);
            Console.WriteLine("Values with out parameter:");
            Console.WriteLine($"-Min: {min} -Max: {max}");

            Console.WriteLine();

            SuperList.GetMinMax2 minMax2 = new SuperList.GetMinMax2(sl);
            Console.WriteLine("Values with specific class:");
            Console.WriteLine(
                $"-Min: {minMax2.MinValue} -Max: {minMax2.MaxValue}");

            Console.WriteLine();

            Tuple<double, double> minMax3 = sl.GetMinMax3();
            Console.WriteLine("Values with reference tuple:");
            Console.WriteLine($"-Min: {minMax3.Item1} -Max: {minMax3.Item2}");

            Console.WriteLine();

            (double MinValue, double MaxValue) minMax4 = sl.GetMinMax4();
            Console.WriteLine("Values with value tuple and self-defined names:");
            Console.WriteLine(
                $"-Min: {minMax4.MinValue} -Max: {minMax4.MaxValue}");
        }
    }
}
