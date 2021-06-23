using System;

namespace LearnDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World
            HelloWorld.PrintHelloWorld();
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
            Console.Write("I like it.");

        }
        public static void HelloMyFriend()
        {
            Console.WriteLine("Hi, I'm Twikura, Can you tell me your name?");
           
        }
    }
}
