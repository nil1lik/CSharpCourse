using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Nil";

            var result = sentence.Length; //Lenght uzunluğu hesaplar.
            var result2 = sentence.Clone(); //Klonlama amacı ile kullanılır. Her ne kadar resul2'de clone yapsak da sentence'ı değiştirsek de clone yapıldığı için result2 değişmez.
            sentence = "My name is Asel";

            bool result3 = sentence.EndsWith("ğ"); //Bu cümle "ğ" ile bitiyor mu?
            bool result4 = sentence.StartsWith("My Name"); //Bu cümle "My Name" ile başlıyor mu?

            var result5 = sentence.IndexOf("name"); //Belli bir karakteri aramak için kullanılır. Konsola "3" yazar çünkü name'in başlangıcı 3. indextedir. Bulamazsa -1 döndürür.
            var result6 = sentence.IndexOf(" "); //Boşluğu arar. Bulduğu ilk boşluğu sayar sonra devam etmez.
            var result7 = sentence.LastIndexOf(" "); //Aramaya sondan başlar.
            var result8 = sentence.Insert(0, "Hello, "); //Bir string ifadeye başka bir metni yerleştirmek için kullanılır. Cümlenin sıfırıncı karakterinden itibaren "Hello, " diye bir ifade ekler.
            var result9 = sentence.Substring(3, 4); //Metni parçaladığı yerden alır. Yani 3. indexten itibaren 4 karakter al.
            var result10 = sentence.ToLower(); //Bütün karakterleri küçük harfe çevirir.
            var result11 = sentence.ToUpper(); //Bütün karakterleri büyük harfe çevirir.
            var result12 = sentence.Replace(" ", "-"); //Belirli karakterleri değiştirmek için kullanılır. Burada boşluk yerine çizgi ekler.
            var result13 = sentence.Remove(2, 4); //Bir metinden belli bir indexten sonrasını atmak için kullanılır. Burada 2. indexten itibaren 4 karakteri siler.


            Console.WriteLine(result13);
            Console.ReadLine();


        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            //Stringler aslında birer char arraydir. Aslında arkada 5 elemanlı bir dizi oluşturur. city[0] Bu şekilde 'A' harfini ekrana yazdırır.

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "İstanbul";
            //string result = city + city2; //İki stringi yanyana getirir. Ankaraİstanbul yazar.
            Console.WriteLine(String.Format("{0} {1}", city, city2)); //Stringi bir değişkene atarken String.Format kullanabiliriz.
        }
    }
}
