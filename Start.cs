using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace telefonRehberi
{

    internal class Start
    {

        public void start()
        {
            Rehber rehber = new Rehber();


            while (true)
            {

                Console.WriteLine("  Lütfen Yapmak İstediğiniz İşlemi Seçiniz :)  ");
                Console.WriteLine();
                Console.WriteLine(" 1. Telefon Numarası Kaydet ");
                Console.WriteLine(" 2. Telefon Numarasını Sil ");
                Console.WriteLine(" 3. Telefon Numarası Güncelle ");
                Console.WriteLine(" 4. Rehber Listeleme (A-Z, Z-A seçimli) ");
                Console.WriteLine(" 5. Rehberde Arama ");
                Console.WriteLine(" 6. Çıkış Yap ");
                Console.WriteLine();
                Console.Write(" Seçiminiz: ");

                int secim = int.Parse(Console.ReadLine());



                switch (secim)
                {
                    case 1:
                        Console.Write(" Lütfen isim giriniz           : ");
                        string ad = Console.ReadLine();
                        Console.Write(" Lütfen soyisim giriniz        : ");
                        string soyad = Console.ReadLine();
                        Console.Write("Lütfen telefon numarası giriniz: ");
                        string no = Console.ReadLine();

                        rehber.KişiEkle(new Kisi { Ad= ad, Soyad= soyad, TelefonNumarasi=no});

                        break;

                    case 2:
                        Console.Write("Lütfen silmek istediğiniz kişinin adını giriniz : ");
                        string silad = Console.ReadLine();
                        Console.Write("Lütfen silmek istediğiniz kişinin soyadını giriniz : ");
                        string silSoyad = Console.ReadLine();
                        rehber.KişiSil(silad,silSoyad);

                        break;

                    case 3:
                        Console.Write("Lütfen güncellemek istediğiniz kişinin adını giriniz: ");
                        string guncelad = Console.ReadLine();
                        Console.Write("Lütfen güncellemek istediğiniz kişinin soyadını giriniz: ");
                        string guncelsoyad = Console.ReadLine();
                        Console.Write("Lütfen güncellemek istediğiniz kişinin yeni telefon numarasını giriniz: ");
                        string guncelno = Console.ReadLine();
                        rehber.KişiGüncelle(guncelad, guncelsoyad, guncelno);
                        break;

                    case 4:
                        rehber.RehberListele();
                        
                        break;

                    case 5:
                        Console.Write("Arama yapmak istediğiniz terimi girin: ");
                        string aramaTerimi = Console.ReadLine();
                        rehber.KisiAra(aramaTerimi);
                        break;
                    case 6:
                        Console.WriteLine("Çıkış Yapılıyor...");
                        return;

                    default:
                        Console.WriteLine("Yanlış Seçim Yaptınız!");
                        break;
                }

            }

        }



    }

}





    

