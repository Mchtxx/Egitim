

using System;
 
namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Person("Mücahit","Daldal","20"));
            
        }
 
        void SayHello()
        {
            Console.WriteLine("Merhaba Dünya");
        }

        int YasHesapla(int Number1,int number2)
        {

            return Number1+number2;

        }

        string Person(string Name,string Surname,string age)
        {
           

            return Name + Surname + age;


        
        }
    }
}
 
