// See https://aka.ms/new-console-template for more information

using inclass;
using System;
#region inclass 
//Dog dog = new Dog() { weight = 10, name = "buddy" };
//Cat cat = new Cat() { weight = 5, name = "miki" };
//Bear bear = new Bear() { name = "bobo", weight = 260 };
//Donkey donkey = new Donkey { name = "momo", weight = 120 };
//Dog dog2 = new Dog();
//Console.WriteLine(Dog.counter);
//Console.WriteLine(Dog.DoSomething());
//Animal[] animals = new Animal[] { dog, cat, bear, donkey };

//foreach (Animal animal in animals)
//{
//    Console.WriteLine(animal.sayhello());
//}
#endregion inclass 

Console.WriteLine("hello to github");

while (true)
{
    try
    { 
        Console.Write("Enter the number please: ");
        int num = int.Parse(Console.ReadLine());
        num = num + 3;
     //   num = num / 0;
        Test();

            Console.WriteLine("Result is:" + num);

    }
    catch (FormatException ex)
    {
        Console.WriteLine("Format Exception" + ex.Message);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("DivideByZeroException" + ex.Message);
    }
    catch (Exception ex) 
    {
        Console.WriteLine("General Exception" + ex.Message);
    }
    finally
    {
        Console.WriteLine("Finally code");

    }
}



static void Test()
{
    Console.WriteLine("Enter your name pls:");
    string? name= Console.ReadLine();
    if(name == "Ella")
    {
        Console.WriteLine("Hello " + name); 
    }
    else
    {
        throw new Exception("Name is not Ella");
    }

}