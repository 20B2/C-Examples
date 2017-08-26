using System;

namespace Test
{
    public delegate int dSum(int x, int y);
    class Program
    {
        public static int Sum (int a, int b)
        {
            return a+b;
        }
        
        static void Main(string[] args)
        {
            int a = 30, b = 20;

            dSum nAdd = Sum;
            Console.WriteLine("Using Delegate instance");
            Console.WriteLine($"Sum of {a} and {b} is {nAdd(a,b)}");
            Console.WriteLine();

            dSum dlAdd = (x,y) => x+y;
            Console.WriteLine("Using Delegate instance and Lambda");
            Console.WriteLine($"Sum of {a} and {b} is {dlAdd(a,b)}");
            Console.WriteLine();

            dSum daAdd = delegate(int x, int y){ return x+y; };
            Console.WriteLine("Using Delegate instance and Anonymous Method");
            Console.WriteLine($"Sum of {a} and {b} is {daAdd(a,b)}");
            Console.WriteLine();

            
            
            Func<int, int, int> fadd = Sum;
            int result = fadd(a,b);
            Console.WriteLine("Using Func<> Function");
            Console.WriteLine($"Sum of {a} and {b} is {result}");
            Console.WriteLine();

            Func<int, int, int> lfadd = (x,y)=>x+y;
            Console.WriteLine("Using Func<> and Lambda Function");
            Console.WriteLine($"Sum of {a} and {b} is {lfadd(a,b)}");
            Console.WriteLine();

            Func<int> getRandomNumber = delegate(){
                return new Random().Next(1,100);
            };
            Console.WriteLine($"Random Number using Anonymous method {getRandomNumber()}");
            Console.WriteLine();

            Func<int, int, int> getSum = delegate(int x,int y){
                return x+y;
            };
            Console.WriteLine("Using Func<> and Anonymous Method");
            Console.WriteLine($"Sum or {a} and {b} is { getSum(a,b)}");

            Console.ReadLine();
        }
    }
}
