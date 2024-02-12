
#region '1.Soru'
  

//    //cevap= dizi içerisindeki değerlerin toplamını almak için foreach kullandım.
//    // çünkü dizi içerindeki değer kadar içeride döngü yapması gerekiyordu.

//     int[] numbers = { 5, -3, 8, -2, 4 };
//         int total=0;

//         foreach(int number in numbers)
//         {
//             total=total+number;
//         }
//         Console.WriteLine("Toplam Değer : "+total);
  
#endregion

#region '2.Soru'

// //yazmış oluğum kod klavyeden girilen 2 sayıyı tam sayı olarak bölmekte , yorum satırı olarak kapattığım bir kod daha bu bu kod ile işlem yapıldğında  sonuç ondalıklı bir şekilde çıkmakta.
// //try-catch bloğu ile de oluşan hatayı ekrana yazdırıyorum 

// try
// {
//     Console.WriteLine("Number 1 :");
//     int Number1 = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Number 2 :");
//     int Number2 = Convert.ToInt32(Console.ReadLine());
//     int Sonuc = Number1 / Number2;

//     //küsüratlı sonuç elde etmek için ;
//     //double Sonuc = (double)Number1 / Number2;
//     Console.WriteLine("Sonuç : " + Sonuc);

// }
// catch (Exception e)
// {
//     Console.WriteLine(e.Message);
// }

// finally
//   {
//     Console.WriteLine("İşlem Tamamlandı.");
// }
  
#endregion

#region '3.Soru'

//     //soruyu diploma puanına göre kurguladım.
//     //soruda istememiştin ama komut bloğunun sağlığı için try-catch komutunuda kullanmak istedim.
// try
// {
//      Console.Write("Diploma Notu :");
//     int point= Convert.ToInt32(Console.ReadLine());

//     //&&(ve), &&(veya)
//   if (point>=90 &&point<=100)
//   {
//     Console.WriteLine("Notunuz AA, Tebrikler!");
//   }

//   else if(point>=80 && point<=89)
//   {
//     Console.WriteLine("Notunuz BA, İyi iş çıkardınız.");
//   }
  
//   else if(point>=70 && point<=79)
//   {
//     Console.WriteLine("Notunuz BB, Başarılı.");
//   }
  
//   else if(point>=60 && point<=69)
//   {
//     Console.WriteLine("Notunuz CB, Biraz daha çaba göstermelisiniz.");
//   }
  
//   else if(point>=50 && point<=59)
//   {
//     Console.WriteLine("Notunuz CC, Geçer not, ancak gelişim göstermeniz önemli.");

//   }
//   else if(point>=0 && point<=49)
//   {
//     Console.WriteLine("Notunuz FF, Kaldınız. Daha fazla çalışmalısınız.");
    
//   }

//   else
//   Console.WriteLine("Yanlış Diploma Puanı Girdiniz.");
// }
// catch (Exception x)
// {
    
//     Console.WriteLine(x.Message);
// }
// finally
// {
//     Console.WriteLine("Hesaplama İşlemi Tamamlandı.");
// }
   
#endregion


