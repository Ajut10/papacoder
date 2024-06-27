using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Console.WriteLine("Helo jata tetai");
            //Console.Write("Anywhere");
            //Console.WriteLine("Everywhere");
            // Console.ReadLine();

            //types of dataTypes

            /*1)predifined data type
             * Int -->4bytes
             * float-->4bytes
             * double-->8 bytes
             * char-->2
             * decimal-->
             * boolean-->1 bytes
             * string-->2 bytes per charecter
             * 
        
             
            int a = 6;
            float flow = 5.56f;
            double b = 5.67;
            string nop = "hrl";
            char ch = 'a';
            bool istrue=true;
            decimal num = 444.453m;

            Console.WriteLine(a);
            Console.WriteLine(flow);
            Console.WriteLine(b);
            Console.WriteLine(nop);
            Console.WriteLine(ch);
            Console.WriteLine(istrue);
            Console.WriteLine(num);
            Console.ReadLine();
            */

            /*2) user defined
             * 
             */

            //type casting
            /*1) implicit
             * char to int to long to float to double
             */


            //int x = 3;
            //double y = x;
            //int z = 'x';
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //2) explicit
            //int a = (int)3.4;
            //Console.WriteLine(a);

            //type casting using methods
            //float byr = Convert.ToInt32(3.44);
            //Console.WriteLine(byr);

            string a=  Console.ReadLine();
            //Console.Write( a);
            Console.WriteLine(3+Convert.ToInt32(a));
            Console.ReadKey();

        }
    }
}
