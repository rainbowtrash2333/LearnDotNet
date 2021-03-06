# 数据类型

## 值类型（Valve types)

| 类型    | 描述                                 | 范围                                                    | 默认值 |
| :------ | :----------------------------------- | :------------------------------------------------------ | :----- |
| bool    | 布尔值                               | True 或 False                                           | False  |
| byte    | 8 位无符号整数                       | 0 到 255                                                | 0      |
| char    | 16 位 Unicode 字符                   | U +0000 到 U +ffff                                      | '\0'   |
| decimal | 128 位精确的十进制值，28-29 有效位数 | (-7.9 x 1028 到 7.9 x 1028) / 100 到 28                 | 0.0M   |
| double  | 64 位双精度浮点型                    | (+/-)5.0 x 10-324 到 (+/-)1.7 x 10308                   | 0.0D   |
| float   | 32 位单精度浮点型                    | -3.4 x 1038 到 + 3.4 x 1038                             | 0.0F   |
| int     | 32 位有符号整数类型                  | -2,147,483,648 到 2,147,483,647                         | 0      |
| long    | 64 位有符号整数类型                  | -9,223,372,036,854,775,808 到 9,223,372,036,854,775,807 | 0L     |
| sbyte   | 8 位有符号整数类型                   | -128 到 127                                             | 0      |
| short   | 16 位有符号整数类型                  | -32,768 到 32,767                                       | 0      |
| uint    | 32 位无符号整数类型                  | 0 到 4,294,967,295                                      | 0      |
| ulong   | 64 位无符号整数类型                  | 0 到 18,446,744,073,709,551,615                         | 0      |
| ushort  | 16 位无符号整数类型                  | 0 到 65,535                                             | 0      |

## 引用类型（Reference types）

对象（Object）类型跟Java一样，动态（Dynamic）类型类似python等动态语言的变量，使用dynamic修饰，例如`dynamic d = 20;`。字符串（String）类型更Java一样，不过多了个”逐字字符串“，使用@修饰，将转义字符（\）当作普通字符对待，如`string str = @"C:\Windows";`等价与`string str = "C:\\Windows";`。同时可以在字符串中换行，类似python的三引号字符串（’‘’）

## 指针类型（Pointer types）

与C语言一样，例如`char* cptr`

## 变量交换

与Java一样，直接交换值类型的变量是没用的，如下面的代码：

```C#
 public static void swap(int a, int b)
 {
     int temp = a;
     a = b;
     b = temp;
 }
```

直接调用`swap()`是不会交换的，使用`ref`修饰变量，类似于C的`&`，如下：

```C#
 public static void swap(ref int a, ref int b)
 {
     int temp = a;
     a = b;
     b = temp;
 }
```

# 标准输入、输出

## 输入

在C#中，`Console.WorterLine()`为输出一行，输出的字符串后自动带“\n"换行，`Console.Write()`则为仅输出字符串，不会换行。同时可以使用“{<munber>}”作为占位符，构造字符串。同时也可以使用“+”链接字符串，同Java。

```C#
Console.WriteLine("Hello the World!");
Console.Write("Hello My Firends,");
//等效为Console.WriteLine(" do you like My little Pony?");
Console.Write(" do you like My little Pony?\n");
//如下构造字符串
 Console.WriteLine("I like it.I like {0} and {1} very much.","Twilight Sparkle", "Rainbow Dash");
String pony_fs = "Flattershy";
Console.WriteLine("My Favorite pony is" + pony_fs + "!");
```

输出为

```
Hello the World!
Hello My Firends, do you like My little Pony?
I like it.I like Twilight Sparkle and Rainbow Dash very much.
My  pony isFlattershy!
```

## 输出

使用` Console.WriteLine();`来读取用户输入的内容，代码如下：

```C#
public static void HelloMyFriend()
{
    Console.WriteLine("Hi, I'm Twikura, Can you tell me your name?");
    String name = Console.ReadLine();
    Console.WriteLine("Hi,{0},nice to see you.", name);
}
```

# 常量、枚举、结构体

这三个和C语言非常像，常量使用`const`修饰。枚举使用`enum`，结构体使用`struct`。

```C#
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
```

输出如下

```
name:           Li Hua
age:            18
gender:         男
name            id
TwilightSparkle         0
RanbowDash              1
Flattershy              2
```

# 可空类型（Nullable）

无法直接赋值为 null 的数据类型进行 null 的赋值

```c#
int? i = 3;
//等同于：
Nullable<int> i = new Nullable<int>(3);

int? ii;//默认值null

double? num1 = null;
double num3;
num3 = num1 ?? 5.34;      // num1 如果为空值则返回 5.34
```

