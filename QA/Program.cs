using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> RandomNumbers = new List<int>();
            string UserInput;

            do
            {
                Console.WriteLine("Unesite broj (ostavite prazan unos za kraj rada) >");
                UserInput = Console.ReadLine();
                if(UserInput != "")
                {
                    RandomNumbers.Add(Convert.ToInt32(UserInput));
                }
            } while (UserInput != "");
            
            Console.WriteLine("GetLowest = {0}", BasicStats.GetLowest(RandomNumbers));
            Console.WriteLine("GetHighest = {0}", BasicStats.GetHighest(RandomNumbers));
            Console.WriteLine("GetAverage = {0}", BasicStats.GetAverage(RandomNumbers));
            Console.WriteLine("GetSum = {0}", BasicStats.GetSum(RandomNumbers));
            
            Console.ReadKey();
        }
    }
}
