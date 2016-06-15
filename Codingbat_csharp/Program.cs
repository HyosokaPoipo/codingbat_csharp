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
            Console.WriteLine(stringClean("yyzzza"));
            Console.WriteLine(stringClean("abbbcdd"));
            Console.WriteLine(stringClean("Hellow"));
            Console.WriteLine(stringClean("XXabcYY"));
            Console.WriteLine(stringClean("112ab445"));
            Console.WriteLine(stringClean("Hellow Bookkeeper"));
            Console.ReadLine();
        }

        public static string stringClean(string str)
        { 
            //kondisi setop
            if (str.Length < 2) return str;

            //main rekursif
            int index = 0;
            for (index=0; index+1 < str.Length; index++)
            {
                if (str[index] != str[index + 1]) break;
            }

            return str[index] + stringClean(str.Substring(index+1));

        }













        public static int contoh()
        {
            return 3;
        }

 }

    
}
