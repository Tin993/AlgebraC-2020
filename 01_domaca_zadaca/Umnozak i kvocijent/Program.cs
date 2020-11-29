using System;

namespace Umnozak_i_kvocijent
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unos brojeva
            int a;
            Console.WriteLine("Upišite prvi cijeli broj");
            a = int.Parse(Console.ReadLine());

            int b;
            Console.WriteLine("Upišite drugi cijeli broj");
            b = int.Parse(Console.ReadLine());

            //Kvocijent i umonzak
            double Kvocijent;
            Kvocijent = (double)a / (double)b;
            Console.WriteLine("Kvocijent je {0}", Kvocijent);

            int Umnozak;
            Umnozak = a * b;
            Console.WriteLine("Umnozak je {0}", Umnozak);

        }
    }
}
