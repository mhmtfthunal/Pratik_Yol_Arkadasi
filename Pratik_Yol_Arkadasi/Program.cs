while (true)
{
    Console.WriteLine("Bodrum (Paket başlangıç fiyatı 4000 TL)");
    Console.WriteLine("Marmaris (Paket başlangıç fiyatı 3000 TL)");
    Console.WriteLine("Çeşme (Paket başlangıç fiyatı 5000 TL)");

    string secilenLokasyon = "";

    while (true)
    {
        Console.WriteLine("Lütfen gidilecek yeri seçiniz (BODRUM / MARMARİS / ÇEŞME): ");
        string gidilecekYer = Console.ReadLine().ToUpper();

        if (gidilecekYer == "BODRUM" || gidilecekYer == "MARMARİS" || gidilecekYer == "ÇEŞME")
        {
            secilenLokasyon = gidilecekYer;
            Console.WriteLine($"Tatil için çok iyi bir seçim yaptınız. {gidilecekYer} seçtiniz.");

            break;
        }
        else
        {
            Console.WriteLine("Hatalı giriş yaptınız. Lütfen tekrar deneyin.");
        }
    }
    Console.WriteLine($"Seçilen lokasyon işlem için kaydedildi: {secilenLokasyon}");

    Console.WriteLine("------------------");

    Console.WriteLine("Kaç kişilik tatil planlaması yapıyorsunuz?");

    int kisiSayisi = Convert.ToInt32(Console.ReadLine());

    if (secilenLokasyon == "BODRUM")
    {
        Console.WriteLine($"Tercih ettiğiniz {secilenLokasyon}'da {kisiSayisi} kişi ile lokasyonunda bodrumu gezeceksiniz.  ");

    }
    else if (secilenLokasyon == "MARMARİS")
    {
        Console.WriteLine($"Tercih ettiğiniz {secilenLokasyon}'de {kisiSayisi} kişi ile lokasyonunda marmasiz gezeceksiniz. ");


    }
    else if (secilenLokasyon == "ÇEŞME")
    {
        Console.WriteLine($"Tercih ettiğiniz {secilenLokasyon}'de {kisiSayisi} kişi ile lokasyonunda çeşme gezeceksiniz. ");
    }

    int yolSec = 0;

    while (true)
    {
        Console.WriteLine("Tatile ne şekilde gitmek istersiniz?");

        Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)");
        Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");

        Console.WriteLine("Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz.");

        int yolSecimi = Convert.ToInt32(Console.ReadLine());

        if (yolSecimi == 1)
        {
            Console.WriteLine($"Kara yolu seçtiniz");
            yolSec = yolSecimi;
            break;
        }
        else if (yolSecimi == 2)
        {
            Console.WriteLine($"Hava yolunu seçtiniz");
            yolSec = yolSecimi;
            break;
        }
        else
        {
            Console.WriteLine("Yanlış seçim yaptınız. Lütfen tekrar seçim yapınız.");
        }
    }

    int bodrumFiyat = 4000;
    int marmarisFiyat = 3000;
    int cesmeFiyat = 5000;
    int lokasyonFiyat = 0;
    int karayoluFiyat = 1500 * kisiSayisi;
    int havayoluFiyat = 4000 * kisiSayisi;
    int toplamFiyat = 0;

    if (secilenLokasyon == "BODRUM")
    {
        Console.WriteLine($"Tercih ettiğiniz lokasyonunun paket ücreti {bodrumFiyat} TL");
        lokasyonFiyat = bodrumFiyat;
    }
    else if (secilenLokasyon == "MARMARİS")
    {
        Console.WriteLine($"Tercih ettiğiniz lokasyonunun paket ücreti {marmarisFiyat} TL ");
        lokasyonFiyat = marmarisFiyat;
    }
    else if (secilenLokasyon == "ÇEŞME")
    {
        Console.WriteLine($"Tercih ettiğiniz lokasyonunun paket ücreti {cesmeFiyat} TL");
        lokasyonFiyat = cesmeFiyat;
    }


    if (yolSec == 1)
    {
        Console.WriteLine($"Seçilen ulaşım aracının ücreti: {karayoluFiyat}  TL");
        toplamFiyat = lokasyonFiyat + karayoluFiyat;

    }
    else if (yolSec == 2)
    {
        Console.WriteLine($"Seçilen ulaşım aracının ücreti: {havayoluFiyat}  TL");
        toplamFiyat = lokasyonFiyat + havayoluFiyat;
    }

    Console.WriteLine($"Tatilinizin toplam ücreti: {toplamFiyat} TL");

    while (true)
    {
        Console.WriteLine("Bu tatili yapmak ister misiniz?");
        Console.WriteLine("Evet - Hayır");
        string secim = Console.ReadLine().ToUpper();

        if (secim == "EVET")
        {
            Console.WriteLine("Tatil planınız başarıyla oluşturuldu! İyi yolculuklar.");
            break;
        }
        else if (secim == "HAYIR")
        {
            Console.WriteLine("Tatil planı iptal edildi.");
            break;
        }
        else
        {
            Console.WriteLine("Geçersiz seçim yaptınız. Lütfen sadece 'Evet' veya 'Hayır' yazın.");
        }
    }

    Console.WriteLine("Yeni bir tatil planlamak ister misiniz? (Evet / Hayır)");
    string tekrar = Console.ReadLine().ToUpper();
    if (tekrar == "HAYIR")
    {
        Console.WriteLine("İyi günler dileriz!");
        break;
    }
    Console.Clear();
}
