namespace telefonRehberi
{
  
        public class Kisi
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string TelefonNumarasi { get; set; }
        }
    public class Rehber
    {

        private List<Kisi> kisiler;

        public Rehber()
        {
            kisiler = new List<Kisi>
        {
            new Kisi { Ad = "Nergis", Soyad = "Yılmaz", TelefonNumarasi = "5225522522" },
            new Kisi { Ad = "Sümbül", Soyad = "Kaya", TelefonNumarasi = "5488866844" },
            new Kisi { Ad = "Kardelen", Soyad = "Demir", TelefonNumarasi = "5484152125" },
            new Kisi { Ad = "Frezya", Soyad = "Çicek", TelefonNumarasi = "5514222557" },
            new Kisi { Ad = "Yasemin", Soyad = "Şahin", TelefonNumarasi = "5241224255" }
        };
        }


        public void KişiEkle(Kisi kisi)
        {

            kisiler.Add(kisi);
        }
      
        
        public void KişiSil(string ad, string soyad)
        {
            {
                Kisi silinecekKisi = kisiler.FirstOrDefault(k => k.Ad == ad && k.Soyad == soyad);
                if (silinecekKisi != null)
                {
                    kisiler.Remove(silinecekKisi);
                    Console.WriteLine("Kişi başarıyla silindi.");
                }
                else
                {
                    Console.WriteLine("Kişi bulunamadı.");
                }
                                  
                                  
            }
        }


        public void KişiGüncelle(string ad, string soyad, string yeniTelefonNumarasi)
        {
            Kisi guncellenecekKisi = kisiler.FirstOrDefault(k => k.Ad == ad && k.Soyad == soyad);
            if (guncellenecekKisi != null)
            {
                guncellenecekKisi.TelefonNumarasi = yeniTelefonNumarasi;
                Console.WriteLine("Kişi başarıyla güncellendi.");
            }
            else
            {
                Console.WriteLine("Kişi bulunamadı.");
            }
        }

        public void RehberListele(bool siralama = true)
        {
            var siraliKisiler = siralama ? kisiler.OrderBy(k => k.Ad) : kisiler.OrderByDescending(k => k.Ad);
            Console.WriteLine("Telefon Rehberi:");
            foreach (var kisi in siraliKisiler)
            {
                Console.WriteLine($"Ad: {kisi.Ad} Soyad: {kisi.Soyad}, Telefon Numarası: {kisi.TelefonNumarasi}");
            }
        }

        public void KisiAra(string aramaKelimesi)
        {
            var aramaSonuclari = kisiler.Where(k => k.Ad.Contains(aramaKelimesi) || k.Soyad.Contains(aramaKelimesi) || k.TelefonNumarasi.Contains(aramaKelimesi));
            if (aramaSonuclari.Any())
            {
                Console.WriteLine("Arama Sonuçları:");
                foreach (var kisi in aramaSonuclari)
                {
                    Console.WriteLine($"Ad: {kisi.Ad} Soyad: {kisi.Soyad}, Telefon Numarası: {kisi.TelefonNumarasi}");
                }
            }
            else
            {
                Console.WriteLine("Eşleşen kişi bulunamadı.");
            }
        }

    }
}
