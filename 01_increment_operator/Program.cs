using System;

namespace _01_increment_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Increment i decrement");
            double x = 1.5, y;  // deklaracija
            int z;
            y = 0;              // definicija
            Console.WriteLine("y="+y);
            //y = x++; // x=x+1 
            y = ++x; // x=x+1
            Console.WriteLine("y="+y);

            Console.WriteLine("explicitna konverzija");

            z = (int)x; // cast operator , cjelobrojni broj int z
            Console.WriteLine("z=" + z);

            // String s1 = (String)x;
            String s1 = Convert.ToString(x);
            Console.WriteLine("Ovo je konvertirani broj x"+s1);

            
            double zz = x + Convert.ToDouble(s1);
            Console.WriteLine("zz=" + zz);
            Console.ForegroundColor = ConsoleColor.Red;

                
            


        }
    }
}
