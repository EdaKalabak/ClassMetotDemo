using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name = "Hatice";
            musteri1.SurName = "Kalabak";
            musteri1.BirthDate = "04.10.1971";
            musteri1.Id = "123654789";
            musteri1.Bakiye = 24000;

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Cenk";
            musteri2.SurName = "Kalabak";
            musteri2.BirthDate = "19.03.1967";
            musteri2.Id = "654123987";
            musteri2.Bakiye = 9886;

            Musteri musteri3 = new Musteri();
            musteri3.Name = "Özen";
            musteri3.SurName = "Yılmaz";
            musteri3.BirthDate = "31.12.1946";
            musteri3.Id = "753951852";
            musteri3.Bakiye = 321456;

            Musteri musteri4 = new Musteri();
            musteri4.Name = "Turan";
            musteri4.SurName = "Yılmaz";
            musteri4.BirthDate = "19.03.1936";
            musteri4.Id = "4595125825";
            musteri4.Bakiye = 999999;

            Musteri musteri5= new Musteri();
            musteri5.Name = "Suat";
            musteri5.SurName = "Kılıçbeyli";
            musteri5.BirthDate = "01.04.1996";
            musteri5.Id = "4595125825";
            musteri5.Bakiye = 855552555;



            Musteri[] musteri = new Musteri[] { musteri2, musteri4, musteri5 };

            foreach (var musterii in musteri)
            {
                Console.WriteLine("Sisteme Hoşgeldiniz :" + musterii.Name + "   " + musterii.SurName);
                Console.WriteLine("Kişisel bilgilerinizi kimseyle paylaşmayınız..");
                Console.WriteLine("Doğum tarihi :" + musterii.BirthDate);
                Console.WriteLine("Id :" + musterii.Id);
                Console.WriteLine("Bakiyeniz :" + musterii.Bakiye);

                Console.WriteLine("---------------------------------------------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            
            Console.WriteLine("------------------------------------------------------------");

            musteriManager.Silme(musteri3);

           
            

            




        }
    }
}
