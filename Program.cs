using System;
 
namespace LearningCSharp
{
    class Program
   
    {
        // method to add two numbers

       static int Topla(int Number1,int Number2)
       {
        return Number1+Number2;
       }

     static void Toplama(int x,int y)
     {
        Console.WriteLine((double)(x+y)/2);
     }
      static void Namewrite(string Name)
     {
        Console.WriteLine("Merhaba Ben "+Name);
     }
 
       
        static void Main(string[] args)
        {
           // int Toplam=Topla(10,5);
            //Console.WriteLine(Toplam); 
            //Toplama(5,6);
            Namewrite("Enes");
        }
    }
}