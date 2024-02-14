using System;
 
namespace LearningCSharp
{
    class Program
   
    {
        // overloading =Aşırı Yükleme 
        //aynı isimde farklı parametrelerel aynı işi yapmak 

      static  int add(int x,int y)
      {
        return x+y;
      }

      static int add(int x,int y,int z)
      {
        return x+y+z;
      }
        static void Main(string[] args)
        {
            Console.WriteLine(add(5,9,6));
            Console.WriteLine(add(5,4));

        }
    }
}