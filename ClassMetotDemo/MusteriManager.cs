using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Yeni müşterimiz : " + musteri.Name + "   "  + musteri.SurName);
            Console.WriteLine("Id :" + musteri.Id);
            Console.WriteLine("Doğum Tarihi :" + musteri.BirthDate);
        }


        public void Listele(Musteri musteri)
        {

            Console.WriteLine("Müşterilerimiz :" + musteri.Name);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Silinecek Müşteri :" + musteri.Name + "    " + musteri.SurName);
        }

    }
}
