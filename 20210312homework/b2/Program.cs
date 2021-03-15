using System;

namespace b2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10005];
            int minVal, maxVal;
            long sum = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++) a[i] = Convert.ToInt32(Console.ReadLine());
            if(n != 0){
                minVal = maxVal = a[1];
                sum = (long)a[1];
                for(int i = 2; i <= n; i++){
                    minVal = Math.Min(minVal, a[i]);
                    maxVal = Math.Max(maxVal, a[i]);
                    sum += a[i];
                }
                Console.Write("{0} {1} {2}", maxVal, minVal, sum * 1.0 / n);
            }
        }
    }
}
