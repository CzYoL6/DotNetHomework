using System;

namespace b1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            n = m = Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i * i <= n; i++){
                if(m % i == 0)Console.WriteLine(i);
                while(m % i == 0) {
                    
                    m /= i;
                }
            }
            if(m != 1) Console.WriteLine(m);
        }
    }
}
