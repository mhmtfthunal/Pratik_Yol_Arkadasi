# Pratik_Yol_Arkadasi

Bu C# konsol uygulaması, kullanıcıların Bodrum, Marmaris veya Çeşme lokasyonlarından birini seçerek 3 günlük bir tatil planlamalarına yardımcı olur.  
Ulaşım tercihi ve kişi sayısına göre toplam tatil maliyetini hesaplar.

---

## 🎯 Uygulamanın Amacı

Kullanıcının aşağıdaki bilgilere göre tatil planlamasını sağlamak:

- Gitmek istediği lokasyon
- Kaç kişiyle seyahat edeceği
- Ulaşım tercihi (kara yolu veya hava yolu)
- Toplam maliyet hesabı
- Tatil onayı ve yeni plan döngüsü

---

## 🌍 Lokasyonlar

| Lokasyon  | Paket Başlangıç Fiyatı |
|-----------|------------------------|
| Bodrum    | 4000 TL                |
| Marmaris  | 3000 TL                |
| Çeşme     | 5000 TL                |

---

## 🚗 Ulaşım Seçenekleri

| Ulaşım Türü | Kişi Başı Gidiş-Dönüş Ücreti |
|-------------|------------------------------|
| Kara Yolu   | 1500 TL                      |
| Hava Yolu   | 4000 TL                      |

---

## 🔁 Uygulama Akışı

1. Kullanıcı lokasyonu seçer (**büyük-küçük harf duyarsız**).
2. Kişi sayısı girilir.
3. Ulaşım türü seçilir.
4. Toplam fiyat hesaplanır:
5. Kullanıcı tatili **onaylar** veya **iptal eder**.
6. Tatil iptal edilse bile kullanıcıya **yeni bir tatil planı yapmak isteyip istemediği** sorulur.
7. "Hayır" cevabında uygulama kapanır, "Evet" cevabında baştan başlar.

---

## 🛠 Kullanılan Teknolojiler

- C# (.NET Console App)
- Visual Studio
- Temel programlama yapıları: `while`, `if/else`, `string`, `int`, `Console.ReadLine()`

---

## 🚀 Nasıl Çalıştırılır?

1. Visual Studio yeni bir **Console App** projesi oluştur.
2. `Program.cs` dosyasına bu örnekleri yapıştır.
3. `Ctrl + F5` veya `Run` tuşu ile programı çalıştır.

---
