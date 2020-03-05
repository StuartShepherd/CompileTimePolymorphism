using System;

namespace CompileTimePolymorphism
{
    public class Calculate
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("a + b = {0}", a + b);
        }

        public void AddNumbers(int a, int b, int c)
        {
            Console.WriteLine("a + b + c = {0}", a + b + c);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compile Time Polymorphism");
            Console.WriteLine("Polymorphism provides an ability for the classes to implement different methods that are called through the same name and it also provides an ability to invoke the methods of a derived class through base class reference during runtime based on our requirements.");
            Console.WriteLine("Compile Time Polymorphism means defining multiple methods with the same name but with different parameters. By using compile-time polymorphism, we can perform different tasks with the same method name by passing different parameters.");
            Console.WriteLine("");

            Calculate c = new Calculate();
            c.AddNumbers(1, 2);
            c.AddNumbers(1, 2, 3);
            Console.ReadLine();
        }
    }
}