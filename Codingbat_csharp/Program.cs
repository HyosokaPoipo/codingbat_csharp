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


        public static int array11(int[] nums, int index)
        { 
            //Kondisi stop
            if (nums.Length == 0) return 0;
            if (nums.Length == 1)
            {
                if (nums[0] == 11) return 1;
                else return 0;
            }

            //Proses rekursif
            int[] temp = new int[nums.Length - index - 1];
            System.Array.Copy(nums, index+1, temp, 0, temp.Length);
            if (nums[index] == 11) return 1 + array11(temp, index);
            else return array11(temp, index);
        }












        public static int contoh()
        {
            return 3;
        }

 }

    
}
