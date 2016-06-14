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
         * Given a string, compute recursively (no loops) a new string where all 
         * the lowercase 'x' chars have been changed to 'y' chars.

            changeXY("codex") → "codey"
            changeXY("xxhixx") → "yyhiyy"
            changeXY("xhixhix") → "yhiyhiy"
         * */

        public static String changeXY(String str)
        {
            if (str.Length < 1) return "";
            Char temp = str[str.Length - 1];
            if (temp == 'x') temp = 'y';
            return changeXY(str.Substring(0, str.Length - 1)) + temp;
        }










        public static int contoh()
        {
            return 3;
        }

 }

    
}
