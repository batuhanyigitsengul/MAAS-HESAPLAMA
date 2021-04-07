using System;

namespace ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel calisan = new Personel();

            Console.WriteLine("Adınızı giriniz:");
            calisan.isim = (Console.ReadLine());
            Console.WriteLine("Soyadınızı giriniz:");
            calisan.soyad = (Console.ReadLine());
            Console.WriteLine("Başlama Yılınızı Giriniz:");
            calisan.baslamayili = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hesaplanmış maaşınız:{calisan.Maas}");

        }
    }

    class Personel
    {
        public string isim;
        public string soyad;
        public double baslamayili = 2015;
        private double maas = 1000 * 0.8 * (2021 - baslamayili);

        public double Maas { get => maas; set => maas = value; }
    }

}
