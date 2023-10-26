using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;

namespace LINQandCollectionsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };
            Console.WriteLine("Numbers in the Array: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();

            IEnumerable<int> numberList = nums;

            // loops over each elements and get the highest VALUE
            int highestNumber = numberList.Max();

            // loops over each elements and gets the LOWEST VALUE
            int lowestNumber = numberList.Min();

            // loops over each elements and gets the LOWEST VALUE
            int countNumbers = numberList.Count();

            Console.WriteLine($"HighestNumber: {highestNumber} LowestNumber: {lowestNumber} NumberCount: {countNumbers}");
            Console.WriteLine();

            IEnumerable<int> numsQuery1 =
                from numsForQuery1 in nums
                where numsForQuery1 < 10000
                select numsForQuery1;

            Console.WriteLine("Numbers less than 10000: ");
            foreach (int i in numsQuery1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            IEnumerable<int> numsQuery2 =
                from numsForQuery2 in nums
                where numsForQuery2 > 10 && numsForQuery2 < 100
                select numsForQuery2;
            Console.WriteLine("Numbers between 10 and 100 (exclusive): ");
            foreach (int i in numsQuery2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            IEnumerable<int> numsQuery3 =
                from numsForQuery3 in nums
                where numsForQuery3 >= 100000 && numsForQuery3 <= 999999
                select numsForQuery3;
            Console.WriteLine("Numbers between 100000 and 999999 (inclusive): ");
            foreach (int i in numsQuery3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}