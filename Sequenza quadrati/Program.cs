using System;

namespace Sequenza_quadrati
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2;
            double pow;
            bool try_pap = true;
            do
            {
                Console.WriteLine("Inserire il numero ");
            } while (try_pap = !int.TryParse(Console.ReadLine(), out n1));
            try_pap = true;
            do
            {
                Console.WriteLine("Inserire il numero di numeri quadrati ");
            } while (try_pap = !int.TryParse(Console.ReadLine(), out n2));
            for (int i = 1; i < n2; i++)
            {
                pow = Math.Pow(n1 , i);
                Console.WriteLine($"{i} radice di {n1} = {pow}");
            }
        }
    }
}
