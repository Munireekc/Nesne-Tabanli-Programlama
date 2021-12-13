using System;

namespace MyApplication
{
    interface AdSoyad
    {
        void AdSoyad();


        class İsim : AdSoyad
        {
            public void AdSoyad()
            {
                string isim;
                Console.WriteLine("Adını Gir:");
                isim = Console.ReadLine();
                Console.WriteLine("Merhaba " + " " + isim);
                Console.WriteLine("Devam Etmek İçin 'Enter' tuşuna basınız");
                Console.ReadKey();
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                string malzeme;
                string yemekAdi;

                İsim Ad = new İsim();
                Ad.AdSoyad();

                
                Console.WriteLine("Yemeğin Adını Giriniz :");
                yemekAdi = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("lütfen malzemeleri yazarken araya virgül koyunuz");
                Console.WriteLine();

                Console.WriteLine("Malzemeleri Giriniz :");
                malzeme = Console.ReadLine();


                Console.WriteLine("Yapılacak Yemeğin Adı: " + yemekAdi);
                Console.WriteLine("Yemek İçin Gerekli malzemeler: " + malzeme);
                Console.ReadLine();
                Console.ReadKey();

            }
        }
    }
}