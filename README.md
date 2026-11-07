# Akıllı Lojistik Sistemi

Yazılım tasarım desenlerini bir arada kullanmak için yaptığım ders projesi. Basit bir sipariş ve kargo sistemi: ürün seçip sipariş veriliyor, ödeme yöntemi ve kargo firması seçiliyor, sipariş aşama aşama ilerletiliyor ve yapılan her işlem ekrandaki log listesine düşüyor. C# ve Windows Forms ile yazıldı.

## Neler yapılabiliyor

Ekranda bir rol seçiliyor (yönetici, depo personeli ya da müşteri) ve her rol farklı işlemleri yapabiliyor. Müşteri sipariş verip iptal ya da iade isteyebiliyor, depo personeli siparişin durumunu ilerletip stok ekleyebiliyor, yönetici ikisini de yapabiliyor.

Sipariş verirken ürün, ödeme yöntemi ve kargo firması seçiliyor. Kargoya sigorta ve "kırılacak eşya" seçenekleri eklenebiliyor, ikisi de kargo ücretini artırıyor. Stok belli bir seviyenin altına düşünce depo sorumlusuna ve yöneticiye bildirim gidiyor.

## Kullandığım desenler

- **Singleton:** `Log_Servisi` tüm programda tek bir log servisi olarak kullanılıyor.
- **Composite:** Ürünler tek parça (`BasitUrun`) ya da parçalardan oluşan (`KarmasikUrun`) olabiliyor. Bilgisayar kasasının fiyatı parçalarının toplamından hesaplanıyor.
- **State:** Sipariş Beklemede → Onaylandı → Hazırlanıyor → Kargoda → Teslim Edildi aşamalarından geçiyor. İptal ve iade isteği her aşamada farklı davranıyor.
- **Strategy:** Kredi kartı, havale ve kripto ödeme yöntemleri.
- **Factory:** `KargoFabrikasi` seçilen firmaya göre kargo nesnesini oluşturuyor.
- **Decorator:** Sigorta ve kırılacak eşya seçenekleri kargo ücretinin üstüne ekleniyor.
- **Adapter:** PTT'nin farklı yapıdaki API'si diğer kargo firmalarıyla aynı arayüzden kullanılıyor.
- **Proxy:** `YetkiKontrolProxy` stok güncellemeden önce kullanıcının rolünü kontrol ediyor.
- **Observer:** Stok azalınca `StokTakipServisi` kayıtlı gözlemcilere haber veriyor.

## Çalıştırmak için

Visual Studio 2022'de `AkilliLojistikSistemi.sln` dosyasını açıp çalıştırmak yeterli. Proje .NET 8 kullanıyor.

`AkilliLojistikSistemi.Tests` projesinde kargo ücreti hesaplaması için MSTest ile yazılmış testler var. Visual Studio'da Test Explorer'dan ya da komut satırında `dotnet test` ile çalıştırılabilir.
