using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass
{
    public abstract class Animal
    {
        public double weight { get; set; }

        public string? name { get; set; }
        protected string? Description;

        public abstract string sayhello();
    }

    public class Dog : Animal
    {
        public static int counter = 0;
        public Dog()
        {
            counter++;
        }
        public static string DoSomething()
        {
            return "static method ready!";
        }
        public override string sayhello()
        {
            return $"woof! i am a dog named{name}. Description; {this.Description}";
        }
    }
    public class Cat : Animal
    {
        public override string sayhello()
        {
            return $"myau! i am a cat named{name}.";
        }
    }
    public class Bear : Animal
    {
        public override string sayhello()
        {
            return $"ahhhh! i am a bear named{name}.";
        }
    }
    public class Donkey : Animal
    {
        public override string sayhello()
        {
            return $"e aaa! i am a donkey named{name}.";
        }
    }
    public class Horse : Animal
    {
        public void Jump()
        {
            Console.WriteLine($"{name} : Jump");
        }
        public override string sayhello()
        {
            return $"{name} : Igo-go!";
        }
    }
}
