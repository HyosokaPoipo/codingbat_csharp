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

            Console.Out.WriteLine(endX("xxre"));
            Console.Out.WriteLine(endX("xxhixx"));
            Console.Out.WriteLine(endX("xhixhix"));
            Console.Out.WriteLine(endX("hellow"));
            Console.Out.WriteLine(endX(""));
            Console.Out.WriteLine(endX("x"));
            Console.Out.WriteLine(endX("e"));
            Console.ReadLine();
        }


        public static String endX(String str)
        {
            //Kondisi setop
            if (str.Length < 2) return str;


            if (str[0] == 'x') return endX(str.Substring(1)) + str[0];
            return str[0] + endX(str.Substring(1));
        }












        public static int contoh()
        {
            return 3;
        }

 }

    
}
