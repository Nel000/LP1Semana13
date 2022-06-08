using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            double min, max;

            SuperList sl = new SuperList() { 125, 12 };
            
            min = sl.GetMinMax1(out max);

            Console.WriteLine($"{min}, {max}");
        }
    }
}
