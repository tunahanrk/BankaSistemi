using System;
using System.Collections.Generic;

namespace BankaSistemi
{
    class Kullanici
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string HesapNumarasi { get; set; }
    }

    class Program
    {
        static string HesapNumarasiOlustur()
        {
            Random random = new Random();
            string hesapNumarasi = "";
            for (int i = 0; i < 10; i++)
            {
                hesapNumarasi += random.Next(0, 10);
            }
            return hesapNumarasi;
        }

        static void Main(string[] args)
        {
            List<Kullanici> kullanicilar = new List<Kullanici>();

            do
            {
                Kullanici kullanici = new Kullanici();

                Console.Write("İsim: ");
                kullanici.Isim = Console.ReadLine();

                Console.Write("Soyisim: ");
                kullanici.Soyisim = Console.ReadLine();

                kullanici.HesapNumarasi = HesapNumarasiOlustur();

                kullanicilar.Add(kullanici);

                Console.Write("Başka kullanıcı eklemek istiyor musunuz? (E/H): ");
            } while (Console.ReadLine().ToLower() == "e");

            Console.WriteLine("\nKullanıcılar ve Hesap Numaraları:");
            foreach (var kullanici in kullanicilar)
            {
                Console.WriteLine("İsim: " + kullanici.Isim);
                Console.WriteLine("Soyisim: " + kullanici.Soyisim);
                Console.WriteLine("Hesap Numarası: " + kullanici.HesapNumarasi);
                Console.WriteLine("--------------------");
            }

            Console.Write("Programı kapatmak için herhangi bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
