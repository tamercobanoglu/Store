
*****************************************************

     Personel ID                  Password

         1                           1
         2                           2
         3                           3
         4                           4

*****************************************************

Müşteri Kullanıcı Adı             Password

         5                           5
         6                           6
         7                           7
         8                           8

*****************************************************

/*Personel (satıcı)*/

-Programdan eklenemez. Databaseden eklenebilir.
-Tüm ürün ve müşteri listesini görebilir.
-Sadece kendi sattığı ürünleri sorgulayabilir.
-Bir ürünün fiyat ve stok bilgilerini güncelleyebilir.
-Satılmamış bir ürünü silebilir.


/*Müşteri*/

-Kayıt olma yoluyla kendini ekleyebilir.
-Açık siparişini ve tamamlanmış siparişlerini ayrı ayrı içerikleriyle birlikte
-görüntüleyebilir.
-Ödeme ekranında istediği sipariş için istediği miktarda ödeme yapabilir.


-Personel ve müşteri, kendi bilgilerini güncelleyebilir.
-Aynı kullanıcı adı seçilemez.


/*PROGRAM PRENSİPLERİ*/

-4 ana kategorinin 4'er alt kategorisine ait çeşitli toplam 100 ürün; stok ve 
 fiyat bilgileri ile databasede kayıtlıdır.

-Bir müşteri teker teker ürün ekleyerek sepet oluşturur.

-Bir sepette birden fazla ürün olabilir.

-Müşteri "Siparişi Tamamla" butonuna bastığında veya arayüzü kapattığında
 sepeti onaylanarak tamamlanmış bir sipariş haline gelir.

-Bir müşterinin birden çok tamamlanmış siparişi olabilir.

-Bir sepet onaylanıp "tamamlanmış sipariş" sıfatını almadan; yeni sepet oluşturulamaz.

-Alınan ürünün stoktan eksilmesi ve ürün tükendiğinde veya fazla sipariş verildiğinde
 gösterilen uyarılar ve çeşitli validasyonlar programda mevcuttur.

-Yukardaki madde, müşterinin bakiyesi için de benzer ölçüde geçerli olup müşteri bu
 bağlamda alışveriş yapabilmektedir.

