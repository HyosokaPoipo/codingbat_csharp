using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingbat_csharp
{
    public class Program
    {
        public Program()
        { 
        
        }
        static void Main(string[] args)
        {
            int[] A = {5,5,5};
            Console.WriteLine(splitOdd10(A));

            int[] A1 = { 5, 5, 6 };
            Console.WriteLine(splitOdd10(A1));

            int[] A2 = { 5, 5, 6, 1 };
            Console.WriteLine(splitOdd10(A2));

            int[] A3 = { 1 };
            Console.WriteLine(splitOdd10(A3));

            int[] A4 = {  };
            Console.WriteLine(splitOdd10(A4));

            Console.ReadLine();
        }


        public static Boolean splitOdd10(int[] nums)
        {
            return helper(0, nums, 0);
        }

        public static Boolean helper(int index, int[] nums, int result)
        { 
            if(index >= nums.Length)
            {
                if ((result % 10) % 2 == 1) return true;
                else return false;
            }

            return helper(index + 1, nums, result + nums[index]);
        }












        public static int contoh()
        {
            return 3;
        }

 }

    
}
