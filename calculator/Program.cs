using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, ans = 0;
            string oper;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            oper = Console.ReadLine();
            switch(oper){
                case "+":
                    ans = a + b;
                    break;
                case "-":
                    ans = a - b;
                    break;
                case "*":
                    ans = a * b;
                    break;
                case "/":
                    if(b == 0) {
                        Console.WriteLine("sb");
                        ans = 666;
                    }
                    else ans = a / b;
                    break;
                
                    
            }
            Console.WriteLine(ans);
        }
    }
}
