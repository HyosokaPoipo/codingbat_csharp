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

        /*Given base and n that are both 1 or more, compute recursively (no loops) the value of base to the n power, 
         * so powerN(3, 2) is 9 (3 squared).

            powerN(3, 1) → 3
            powerN(3, 2) → 9
            powerN(3, 3) → 27
        */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseNum"></param>
        /// <param name="n"></param>
        /// <returns></returns>
    public static int powerN(int baseNum, int n)
    {
      if(n == 0 ) return 1;
      if (n == 1) return baseNum;
      return baseNum * powerN(baseNum, n - 1);
    }


 }

    
}
