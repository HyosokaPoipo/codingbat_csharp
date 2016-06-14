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
            String test = "xxxhixxx";
            int index = test.IndexOf("hi");
            Console.WriteLine(" Index : "+ index);
            Console.WriteLine(" SubString : " + test.Substring(index+1,test.Length-(1+index)));

            String test2 = "xxxxxxxx";
            index = test2.IndexOf("hi");
            Console.WriteLine(" Index : " + index);
            Console.WriteLine(" SubString : " + test2.Substring(index + 1, test2.Length - (1 + index)));

            String test3 = "xxhixxxxaahixxxaahinnn";
            index = test3.IndexOf("hi");
            Console.WriteLine(" Index : " + index);
            Console.WriteLine(" SubString : " + test3.Substring(index + 1, test3.Length - (1 + index)));


            Console.ReadLine();
        }

        /*
         * 
            Given a string, compute recursively (no loops) the number of times lowercase "hi"
         *  appears in the string.

            countHi("xxhixx") → 1
            countHi("xhixhix") → 2
            countHi("hi") → 1
         * 
         * */

        public static int countHi(String str)
        { 
            //stop condition
            if (str.Length < 2) return 0;

            //Process
            int index = str.IndexOf("hi");
            if (index < 0) return 0;
            return 1 + countHi(str.Substring(index + 1, str.Length - (1 + index)));
           
        }
    }

    
}
