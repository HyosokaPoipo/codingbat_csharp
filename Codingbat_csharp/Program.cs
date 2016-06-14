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

        /*
         * Given a string, compute recursively (no loops) the number of lowercase 'x' chars in the string.

            countX("xxhixx") → 4
            countX("xhixhix") → 3
            countX("hi") → 0
         * 
         * 
         * */
        public static int countX(String str)
        {
            //stop condition
            if (str.Length == 0) return 0;
            if (str[(str.Length - 1)] == 'x') return 1 + countX(str.Substring(0, str.Length - 1));
            return countX(str.Substring(0, str.Length - 1));
        }
        
        
 }

    
}
