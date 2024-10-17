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
                if (n % i == 0)
                {
                  count++;
                }

            }
                if (count > 2)
                {
                    Console.WriteLine($"Daxil olan {n} ededi murekkeb ededdir");
                }
                else if (n == 0 || n == 1)
                {
                    Console.WriteLine($"{n} ededi 0 ve 1 olmaz");
                }
                else
                {
                    Console.WriteLine($"{n} ededi sade ededdir");
                }        

            
        }
    }
}
