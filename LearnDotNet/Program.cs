using System;

namespace LearnDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World
            //HelloWorld.PrintHelloWorld();
            //HelloWorld.Swap();
            HelloWorld.HelloMyFriend();
           
        }
    }
    // 学习C#的输入、输出
    class HelloWorld
    {
        public static void PrintHelloWorld()
        {
            Console.WriteLine("Hello the World!");
            //Console.ReadKey();
            Console.Write("Hello My Firends,");
            //等效为Console.WriteLine(" do you like My little Pony?");
            Console.Write(" do you like My little Pony?\n");
            Console.WriteLine("I like it.I like {0} and {1} very much.", "Twilight Sparkle", "Rainbow Dash");
            String pony_fs = "Flattershy";
            Console.WriteLine("My Favorite pony is" + pony_fs + "!");
        }
        // 用户输入
        public static void HelloMyFriend()
        {
            Console.WriteLine("Hi, I'm Twikura, Can you tell me your name?");
            String name = Console.ReadLine();
            Console.WriteLine("Hi,{0},nice to see you.", name);
        }
        public static void Swap()
        {
            int a = 10;
            int b = 20;
            Swap_values.swap(a, b);
            Console.WriteLine("a={0},b={1}，the values do not swap.", a, b);
            Swap_values.swap(ref a, ref b);
            Console.WriteLine("a={0},b={1},Swaped.", a, b);
        }
    }
    // 变量交换
    class Swap_values
    {
        public static void swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}
