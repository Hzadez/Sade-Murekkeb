using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % n == 0)
                {
                    Console.WriteLine($"Daxil olan {n} ededi sade ededdir");
                    count++;
                }
                else if ((i % n == 0) && (i % n == 1) && (count > 2))
                {
                    Console.WriteLine($"{n} ededi murekkeb ededdir");
                    
                }
            }


        }
    }
}
