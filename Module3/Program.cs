using System;
using System.Xml.Linq;

class MainClass
{

    //enum DaysOfWeek : byte
    //{
    //    Monday = 1,
    //    Tuesday,
    //    Wednesday,
    //    Thursday, 
    //    Friday, 
    //    Saturday, 
    //    Sunday 
    //}

    //enum Semaphore : short
    //{
    //    Red = 100,
    //    Yellow = 200,
    //    Green = 300
    //}

    public static void Main(string[] args)
    {
        //const string myName = "Никита";
        //string MyName1 = "Никита";
        //string MyName = "Никита";
        //string name = "Никита";
        //byte MyAge = 27;
        //bool HaveIApet = true;
        //double MyShoeSize = 37.5;
        //byte age = 28;
        //string favcolor = "black";
        //double result = 10 % 3;
        //DaysOfWeek MyFavoriteDay;
        //int olddata = 6;

        //MyFavoriteDay = DaysOfWeek.Sunday;



        //Console.WriteLine("\t Привет, мир");
        //Console.WriteLine("\t Мне 28 лет");
        //Console.WriteLine("\t My name is \n Никита");
        //Console.WriteLine("\u0040");
        //Console.WriteLine("\x23");


        //Console.WriteLine(myName);
        //Console.WriteLine("My name is " + MyName1);
        //Console.WriteLine("MyAge " + MyAge);
        //Console.WriteLine("Do I have a pet? " + HaveIApet);
        //Console.WriteLine("My shoe size is " + MyShoeSize);


        //Console.WriteLine("IntMin {0} ", int.MinValue);
        //Console.WriteLine("IntMax {0} ", int.MaxValue);

        //Console.WriteLine(MyFavoriteDay);

        //Console.WriteLine("\t Привет, \n мир!");

        //Console.WriteLine("Привет, Мир");
        //Console.WriteLine();
        //Console.WriteLine($"Меня зовут {MyName}");
        //Console.WriteLine($"Мой возраст {age}");
        //Console.WriteLine("{0} \n  {1} \n {2}", name, age, favcolor);


        //Console.WriteLine("Привет, человек");
        //Console.WriteLine("Меня зовут {0}", MyName);
        //Console.Write("А как тебя зовут? ");
        ////string YourName = Console.ReadLine();
        ////Console.Write("Рад встрече, {0} ", YourName);


        //Console.WriteLine(result);


        Console.Write("Введите имя: ");
        var Name = Console.ReadLine();
        Console.Write("Введите возраст: ");
        var Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите дату рождения: ");
        var birthdate = Console.ReadLine();
        Console.WriteLine(" Тебя зовут {0} \n Тебе {1} лет \n Дата рождения: {2}", Name, Age, birthdate);


        Console.ReadKey();



    }
}