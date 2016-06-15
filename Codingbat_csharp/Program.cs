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


        public static string allStar(String str)
        { 
            //Kondisi stop
            if (str.Length < 1) return "";
            if (str.Length == 1) return str;


            //Proses rekursif
            return str[0] + "*" + allStar(str.Substring(1));
        }












        public static int contoh()
        {
            return 3;
        }

 }

    
}
