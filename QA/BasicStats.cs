using System;
using System.Collections.Generic;
using System.Linq;


namespace QA
{
    class BasicStats
    {
        public static int GetLowest(List<int> RandomNumbers)
        {
            int LowestNumber = RandomNumbers.First();
            foreach( int Number in RandomNumbers)
            {
                if(Number < LowestNumber)
                {
                    LowestNumber = Number;
                }
            }
            return LowestNumber;
        }


        public static int GetHighest(List<int> RandomNumbers)
        {
            int HighestNumber = RandomNumbers.First();
            foreach(int Number in RandomNumbers)
            {
                if(Number > HighestNumber)
                {
                    HighestNumber = Number;
                }
            }
            return HighestNumber;
        }

        public static int GetSum(List<int> RandomNumbers)
        {
            int sum = 0;
            foreach(int Number in RandomNumbers)
            {
                sum += Number;
            }
            return sum;

        }
        public static double GetAverage(List<int> RandomNumbers)
        {
            return GetSum(RandomNumbers) / RandomNumbers.Count();
        }
    }
}
