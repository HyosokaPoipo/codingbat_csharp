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

            Console.WriteLine(pairStar("hellow"));
            Console.WriteLine(pairStar("xxyy"));
            Console.WriteLine(pairStar("aaaa"));
            Console.WriteLine(pairStar(""));
            Console.WriteLine(pairStar("noadjacent"));
            Console.WriteLine(pairStar("abba"));
            Console.WriteLine(pairStar("abbba"));
            Console.WriteLine(pairStar("112233"));
            Console.ReadLine();
        }


        public static String pairStar(String str)
        { 
            //Kondisi setop
            if (str.Length < 2) return str;


            //Main rekursif
            if (str[0] == str[1]) return str[0] + "*" + pairStar(str.Substring(1));
            else return str[0] + pairStar(str.Substring(1));
        }












        public static int contoh()
        {
            return 3;
        }

 }

    
}
