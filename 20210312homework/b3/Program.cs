using System;

namespace b3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] isPrime = new bool[105];
            for(int i = 1; i <= 100; i++) isPrime[i] = true;
            for(int i = 2; i * i <= 100; i++){
                if(isPrime[i]){
                    for(int j = i * i; j <= 100; j += i)
                        isPrime[j] = false;
                }
            }
            for(int i = 2; i <= 100; i++)
                if(isPrime[i]) Console.Write("{0} ", i);
        }
    }
}
