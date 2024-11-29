using System;

namespace while3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            var result = N;
            double count = 0;

            while (result>= K)
            {
                result -= K;
                count++;
                
            }
            Console.WriteLine(result);
            Console.WriteLine(count);
        }
    }
}