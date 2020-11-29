using System;

namespace Zbroj_i_razlika
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

            //Zbroj i razlika
            int Zbroj;
            Zbroj = a + b;
            Console.WriteLine("Zbroj je {0}", Zbroj);

            int Razlika;
            Razlika = a - b;
            Console.WriteLine("Razlika je {0}", Razlika);
        }
    }
}
