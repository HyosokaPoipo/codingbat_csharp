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



            Console.ReadLine();
        }


        public static Boolean array6(int[] nums, int index)
        { 
            //stop condition
            if (nums.Length == 0) return false;
            if (nums.Length == 1)
            {
                if (nums[0] == 6) return true;
                else return false;
            }
            if(nums[index] == 6) return true;

            //Main recursive process
            int[] temp = new int[nums.Length-index-1];
            System.Array.Copy(nums,index+1,temp,0,temp.Length);
            return array6(temp, index);
        }












        public static int contoh()
        {
            return 3;
        }

 }

    
}
