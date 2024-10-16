namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            int n = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                if (i % n == 0)
                {
                    Console.WriteLine($"{n} ededi sade ededdir");

                }   
            }
            for (int i = 1; i <= n; i++)
            {
                if ((i % n == 0) && (i % n == 1))
                {
                   Console.WriteLine($"{n} ededi murekkeb ededdir");

                }
            }
        }
    }
}
