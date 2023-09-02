# Creational Design Patterns
## Singleton Design Pattern
### Özellikler
* Singleton, uygulama başlatıldığında bir sınıfın sadece bir nesnesinin oluşturulmasını garanti eder.
* Çoğu zaman kritik ve önemli bir pattern olarak görülür.
* Günlük yaşamdan bir örnek; her açıktığınızda yemek yapmak yerine bir kez yemek yapıp onu yersiniz.
* Bazen belirli verilerin sistemin içerisinde tek bir instance'da saklanması gerekmektedir. Bu verilerin saklandığı modellerin Singleton Deseni ile tasarlanması daha uygundur.
* Örneğin, veritabanı işlemleri, konfigürasyon değerleri veya matematiksel işlemler gibi fonksiyonel sınıflar için idealdir.
* Matematiksel işlemlerde, 3+3 işlemi herhangi bir nesne için aynıdır ve bu nedenle bu işlemi gerçekleştirmek için sadece bir nesneye ihtiyaç duyulur.
* Personel işlemlerini düşünün; personel adları, maaş bordroları gibi bilgileri sorgularken bu bilgiler tek bir nesne üzerinden sorgulanabilir. Bu nedenle her sorgulama için yeni bir nesne oluşturmanıza gerek yoktur.
* Windows kullanıcıları geri dönüşüm kutusunu aynı anda yalnızca bir kez açabilirler çünkü Microsoft mühendisleri onu Singleton yapmışlardır. Benzer şekilde, Asp.NET Core'da appsettings.json dosyası da bir örnektir.
* Singleton bir sınıfın sadece bir nesnesinin üretilmesi anlamına gelir.
* Bu durum, ilgili sınıftan new operatörü ile sınırsız nesne üretiminin engellenmesini gerektirir.
### Dezavantajları
* Singleton, tek sorumluluk ilkesini ihlal edebilir çünkü aynı anda birden fazla sorunu çözmeye çalışır.
* Asenkron süreçlerde, bu desen birden fazla instance oluşturma riski taşır, bu nedenle ek koruma gereklidir.
* Constructor'un erişilemez olması nedeniyle unit testlerde sorun yaşanabilir.
* Singleton sınıfı, kalıtım işlemlerinde genellikle kullanılamaz.


## Factory Method Design Pattern

Factory Method Design Pattern, nesne oluşturma süreçlerinde kullanılan bir tasarım kalıbıdır.

### Özellikler

* Operasyon süreçlerinde üretilecek nesnelerin türü/sınıfı/referansı yerine sadece kendilerine odaklanıp işlemlerimizi devam ettirmek istediğimiz durumlarda kullanılır.
* Örnek: Starbucks’da kahvenin türüyle ilgilenmezsin, sadece ne istediğini söylersin.
* Kod sürecinde ihtiyaç olan nesnelerin türüne/sınıfına/referansına odaklanmaksızın bu nesnelerin üretilmesi önerilir.
* Kod sürecinde ihtiyaç olan nesnelerin türüne/sınıfına/referansına odaklanmaksızın bu nesnelerin üretilmesi önerilir.Factory Method Design Pattern, nesne oluşturma sorumluluğunu yardımcı bir sınıfa devreder.
* Kod sürecinde ihtiyaç olan nesnelerin türüne/sınıfına/referansına odaklanmaksızın bu nesnelerin üretilmesi önerilir.Nesne oluşturma kodunu, nesneyi gerçekten kullanacağımız koddan ayırmaktadır.
* Kod sürecinde ihtiyaç olan nesnelerin türüne/sınıfına/referansına odaklanmaksızın bu nesnelerin üretilmesi önerilir.Eğer ihtiyaç duyduğunuz nesnelerin sınıf isimlerini ve bağımlılıklarını tam olarak tahmin edemiyorsanız ya da nesne üretim sürecindeki maliyetleri tekrar tekrar yaşamak istemiyorsanız, Factory Method Pattern'i tercih edebilirsiniz.

### Dezavantajları

* Kod sürecinde ihtiyaç olan nesnelerin türüne/sınıfına/referansına odaklanmaksızın bu nesnelerin üretilmesi önerilir.Factory sınıfının üretiminden sorumlu olduğu sınıflar üzerinde yapılacak fiziksel düzenlemeler veya değişiklikler kodun bozulmasına yol açabilir.
* Kod sürecinde ihtiyaç olan nesnelerin türüne/sınıfına/referansına odaklanmaksızın bu nesnelerin üretilmesi önerilir.Basit Factory tasarımında, nesne grubuna yeni bir sınıf eklenirse Factory sınıfının operasyonu değiştirilmelidir. Bu durum, Open/Closed prensibine aykırıdır.
* Kod sürecinde ihtiyaç olan nesnelerin türüne/sınıfına/referansına odaklanmaksızın bu nesnelerin üretilmesi önerilir.Not: Factory Method Pattern ile Basit Factory (Simple Factory) karıştırılmamalıdır. İki tasarım kalıbı benzer özelliklere sahip olsa da farklıdır.

## Abstract Factory Design Pattern

Abstract Factory Design Pattern, nesne oluşturma süreçlerinde kullanılan bir tasarım kalıbıdır.

### Özellikler

* Abstract Factory, birden fazla ürün ailesi ile çalışırken, istemciyi bu yapıların somut gerçekleştirimlerinden soyutlamak için kullanılır.
* Örnek: Bir bilgisayarı kendiniz toplayabilirsiniz ya da hazır da alabilirsiniz. Kendi topladığınızda her bir parçayla ilgilenmeniz gerekirken, hazır alınan bilgisayarda tüm parçalar bir arada sunulur.
* Birbirleriyle ilgili veya bağımlı olan bir dizi nesnenin oluşturulması gerektiğinde kullanılır.
* Bu nesneler, yapısal olarak aynı nitelikte bir ürün ailesinin üyesiyse, Abstract Factory Pattern'ı kullanabilirsiniz.
* İlişkisel olan birden fazla nesnenin instance'ını tek tek üretmek yerine, bütünsel bir yaklaşımla bu nesneleri tek seferde üretmek için Abstract Factory kullanılır.
* Somut nesnelere olan bağımlılığı, arayüz tabanlı çalışmayla soyutlar.
* Daha fazla ürün ya da alt sınıf eklemek istendiğinde tasarım kolayca genişletilebilir.
* Factory Method’a göre koşullu davranışlardan daha az etkilendiği için daha sağlam bir yapıya sahiptir.
* Somut sınıfların izolasyonunu sağlar; üretim maliyeti ve sorumluluğu Factory sınıflarına yüklenir.
* Ürün ailelerini kolayca değiştirmeyi sağlar ve ürünlerin tutarlı olmasını garantiler.
* Single Responsibility Principle ve Open Closed Principle'leri destekler.
* "Fabrikaların fabrikası" (factory of factories) ifadesi, Abstract Factory'i tanımlar.

### Dezavantajları

* Birden fazla yeni arayüz ve sınıf tanımlaması gerektiğinden dolayı karmaşıklık söz konusu olabilir.

## Prototype Design Pattern

Prototype Design Pattern, nesne klonlama temeline dayanan bir tasarım kalıbıdır.

### Özellikler

* Üretimi zaman ve kaynak yoğun olan nesneler için, bu nesneyi baştan üretmek yerine önceden üretilmiş bir prototipi klonlayarak kullanmayı teşvik eder.
* Örnek: Bir kitaptaki hatayı düzeltmek için tüm kitabı baştan yazmazsınız; mevcut bir kopyayı alıp üzerinde değişiklik yaparsınız.
* Çok fazla parametreli constructor'a sahip nesnelerin üretimi genellikle maliyetlidir. Bu nesnelerin üretimi için new operatörünü sürekli kullanmak bu maliyeti tekrar tekrar ödemek anlamına gelir.
* Klonlama yöntemi, özellikle karmaşık nesnelerin üretiminde rahatlıkla kullanılabilir.
* Prototype Pattern'ın anlaşılması ve uygulaması nispeten kolaydır.
* Diğer Creational Pattern'larla karşılaştırıldığında, Prototype direkt olarak sonuç odaklı hareket eder.
* Bir nesnenin prototipini almak, aslında onu derin bir şekilde kopyalamak anlamına gelir (deep copy).
* Özellikle büyük ve maliyetli nesneler için, Prototype Pattern'ı kullanmak bu nesneleri doğrudan oluşturmaktan daha verimlidir.
### Dezavantajları

* Dairesel referanslara sahip karmaşık nesnelerin klonlanması maliyetli ve zor olabilir.

## Object Pool Design Pattern

Object Pool Design Pattern, maliyetli nesne oluşturma ve imha süreçlerini optimize etmek için nesneleri havuzda saklayarak yeniden kullanmayı teşvik eden bir tasarım kalıbıdır.

### Özellikler

* Maliyetli nesnelerin üretim ve imha süreçlerinin maliyetini azaltmak amacıyla, kullanılan nesnelerin bir havuzda saklanması prensibine dayanır.
* Örnek: Bowling oynarken, salondan bir ayakkabı alır ve oyun bittiğinde ayakkabıyı geri koyarsınız.
* Oluşturulan nesne, kullanıldıktan sonra havuzda saklanır, böylece ilerleyen zamanda tekrar kullanılabilir.
* Eğer havuzda gerekli nesne mevcutsa, bu nesne havuzdan alınır ve kullanılır. Bu, nesne oluşturma sürecinin maliyetini azaltır.
* Object Pooling, nesne oluşturma süresini minimize ederek yazılım performansını artırır.
* Özellikle maliyetli nesne oluşturma süreçlerinde, nesnelerin yeniden kullanılabilirliği maliyeti azaltır.
* Sistem kaynaklarını daha verimli kullanmaya yardımcı olur ve uygulama performansını artırır.
* Havuzda saklanabilecek maksimum nesne sayısını belirlememize olanak tanır.
### Dezavantajları

* Nesnelerin yönetim yükü artar.
* Asenkron operasyonlarda birden fazla thread'in havuzdaki nesneleri alması durumunda, ekstra kontroller ve senkronizasyon gerekebilir.

## Builder Design Pattern

Builder Design Pattern, karmaşık nesneleri adım adım oluşturmak için kullanılan bir tasarım kalıbıdır.

### Özellikler

* Nesnelerin ayrıntılarda farklılık gösterecek şekilde çeşitli temsillerini oluşturmak amacıyla kullanılır.
* Örnek: Hem Mercedes hem de Porsche birer arabadır, ancak ayrıntılarına göre farklılıklar gösterirler.
* Birden fazla adımı olan karmaşık nesnelerin oluşturulmasını sağlar. Bu tür nesneler, üretimi maliyetli olabilir.
* Builder Pattern ile nesne oluşturma sürecini adım adım yapılandırabilir ve gerektiğinde farklı yapılandırma adımlarını takip edebilirsiniz.
* Üretimi maliyetli olan nesnelerin oluşturulmasını, sadece bu oluşturma sürecinden sorumlu sınıfların üstlenmesiyle daha yönetilebilir kılar.
* Birden fazla varyasyonu veya temsili olan karmaşık nesneleri oluşturmak için Builder Pattern idealdir.
* Tek Sorumluluk Prensibine (Single Responsibility Principle) uyumludur.
### Dezavantajları

* Desenin karmaşıklığa yol açabileceği durumlar olabilir, çünkü birden fazla sınıf ve yapı oluşturma gereksinimi doğar.
