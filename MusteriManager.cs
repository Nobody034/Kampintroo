using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public static List<Musteri> musteriler = new List<Musteri>();

        public void MusteriEkle(Musteri musteri)
        {
            Console.Write("Adınızı giriniz --> ");
            musteri.Ad = Console.ReadLine();

            Console.Write("Soyadını giriniz --> ");
            musteri.Soyad = Console.ReadLine();

            Console.Write("Id numaranızı giriniz --> ");
            musteri.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Telefonunuzu giriniz --> ");
            musteri.Telefon = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adresinizi giriniz --> ");
            musteri.Adress = Console.ReadLine();

            musteriler.Add(musteri);
        }

        public void MusteriSil()
        {
            int idNumara = 0;
            int musteriSayisi = musteriler.Count;


            Console.Write("Silmek istediğiniz müşterinin ıd numarasını giriniz --> ");
            idNumara = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < musteriSayisi; i++)
            {
                if (idNumara == musteriler[i].Id)
                {
                    Console.WriteLine(musteriler[i].Id + " numaralı müşteri başarıyla silindi");
                    musteriler.RemoveAt(i);
                    break;
                }
                else
                {
                    Console.WriteLine("Bu numaraya ait müşteri yok!!!");
                }
            }

            //foreach (Musteri musteri in musteriler)
            //{
            //    if (idNumara == musteri.Id)
            //    {
            //        musteriler.RemoveAt(i);
            //        Console.WriteLine(musteri.Id + " numaralı müşteri başarıyla silindi");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bu numaraya ait müşteri yok!!!");
            //    }
            //}
        }

        public void MusteriListele()
        {
            int i = 0;
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müsteri[{0}]", i++);
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Müsteri Adı: " + musteri.Ad);
                Console.WriteLine("Müsteri Soyadı: " + musteri.Soyad);
                Console.WriteLine("Müsteri Id Numarası: " + musteri.Id);
                Console.WriteLine("Müsteri Telefonu: " + musteri.Telefon);
                Console.WriteLine("Müsteri Adresi: " + musteri.Adress);
                Console.WriteLine();
            }
        }
    }
}
