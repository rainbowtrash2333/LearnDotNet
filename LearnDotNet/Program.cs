using System;

namespace LearnDotNet
{
    #region ENUM STRUCT
    public enum Gender
    {
        男,
        女,
    }
    public struct Person
    {
        public String _name;
        public int _age;
        public Gender _gender;
    }
    public enum Pony
    {
        // 可以设定enum的int值，不能说与C差不多，只能说是一模一样
        // TwilightSparkle=1,
        TwilightSparkle,
        RanbowDash,
        Flattershy,
        AppleJack,
        // AppleJeck=6,
        Rarity,
        PinkiePie
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World
            //HelloWorld.PrintHelloWorld();
            //HelloWorld.Swap();
            //HelloWorld.HelloMyFriend();
            HelloWorld.PersionSystem();
            HelloWorld.PonyValley();
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
        // enum、struct练习
        public static void PersionSystem()
        {
            Person Li;
            Li._name = "Li Hua";
            Li._age = 18;
            Li._gender = Gender.男;
            Console.WriteLine("name:\t\t{0}\r\nage:\t\t{1}\r\ngender:\t\t{2}", Li._name, Li._age, Li._gender);
        }
        public static void PonyValley()
        {
            Pony TS = Pony.TwilightSparkle;
            int TS_id = (int)TS;
            int RD_id = 1;
            Pony RD = (Pony)RD_id;
            String FS_id_str = "2";
            try
            {
                int FS_id = Convert.ToInt32(FS_id_str);
                // String 转换为enum
                Pony FS = (Pony)Enum.Parse(typeof(Pony), FS_id_str);
                Console.WriteLine("name\t\tid\r\n{0}\t\t{1}\r\n{2}\t\t{3}\r\n{4}\t\t{5}\r\n", TS, TS_id, RD, RD_id, FS, FS_id);

            }
            catch
            {
                Console.WriteLine("error");
            }
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
