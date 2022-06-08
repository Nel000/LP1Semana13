using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        public double GetMinMax1(out double max)
        {
            double minValue = this[0], maxValue = 0;

            for (int i = 0; i < this.Count; i++)
            {
                if (this[i] > maxValue)
                    maxValue = this[i];

                if (this[i] < minValue)
                    minValue = this[i];
            }

            max = maxValue;
            return minValue;
        }
    }
}