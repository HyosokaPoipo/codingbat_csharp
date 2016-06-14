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
            String test = "pipi";
            
            int index = test.IndexOf("pi");
            Console.WriteLine("index "+index);
            Console.WriteLine("Hasil substring "+test.Substring(index+2,test.Length-index-2));

            Console.WriteLine(changePi("pipi"));
            Console.WriteLine(changePi("xxpixxpixx"));
            Console.WriteLine(changePi("xpix"));
            Console.ReadLine();
        }



        public static String changePi(String str)
        {
            if (str.Length < 1) return "";
            int index = str.IndexOf("pi");
            if (index < 0 ) return str;
            String temp0 = str.Substring(0, index);
            String temp = str.Substring(index+2, str.Length-(2+index));
            return temp0+"3.14" + changePi(temp);
        }











        public static int contoh()
        {
            return 3;
        }

 }

    
}
