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

        public class GetMinMax2
        {
            public double MinValue { get; }
            public double MaxValue { get; }

            public GetMinMax2(List<double> list)
            {
                MinValue = list[0];

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] > MaxValue)
                        MaxValue = list[i];

                    if (list[i] < MinValue)
                        MinValue = list[i];
                }
            }
        }

        public Tuple<double, double> GetMinMax3()
        {
            double minValue = this[0], maxValue = 0;

            for (int i = 0; i < this.Count; i++)
            {
                if (this[i] > maxValue)
                    maxValue = this[i];

                if (this[i] < minValue)
                    minValue = this[i];
            }

            return Tuple.Create(minValue, maxValue);
        }

        public (double MinValue, double MaxValue) GetMinMax4()
        {
            double minValue = this[0], maxValue = 0;

            for (int i = 0; i < this.Count; i++)
            {
                if (this[i] > maxValue)
                    maxValue = this[i];

                if (this[i] < minValue)
                    minValue = this[i];
            }

            return (minValue, maxValue);
        }
    }
}