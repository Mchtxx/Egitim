using System;
 
namespace LearningCSharp
{
    class Program
   
    {
        //Overwritting = parent classın metodunun üzerine yazma

        class Canli
        {
            public void Eat(){
                Console.WriteLine("Et Ürünü");
            }
        }

        class Insan:Canli
        {
            public void Eat(){
                Console.WriteLine("Sebze Ürünü");
            }
        }

     
        static void Main(string[] args)
        {
            Insan Enes=new Insan();
            Enes.Eat();
         

        }
    }
}