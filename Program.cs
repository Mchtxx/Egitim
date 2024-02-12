using System;
 
namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Sum(1, 2, 3));
            Console.WriteLine(Sum("Hello", " ", "World"));
            Console.WriteLine(Person("Mücahit","Daldal","20"));
        
        }
 

        static string Person(string Name,string Surname , string age)
        {

            return Name + " " +Surname + " " + age ;

        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
 
        static string Sum(string a, string b, string c)
        {
            return a + b + c;
        }
    }
}