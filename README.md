Admin Paneli :
Kullanıcı Adı: admin
Şifresi: admin

					ÖZBEK FURNİTURE PROJECT		
Projenin yapım aşamaları;
•	OzFurniture adında ASP.NET Web Application oluşturuldu. BLL ,DAL, ENTITIES Class Libraryleri oluşturuldu.
•	ENTITIES klasörünün altına Concrete adında klasör oluşturup içerisine SQL de oluşturulacak tablolarımızın classları ve içerikleri oluşturuldu. İlişkileri belirlendi.
•	DAL klasörüne Concrete klasörü açıldı., içerisine Context Classı eklendi ve db tablolarının isimleri property olarak eklendi.
•	Migration klasörü eklendi içerisine Package Manager Console üzerinden enable-migration komutu kullanılarak migration eklendi ve update-database ile MSSQL e veritabanı oluşturulması sağlandı.
•	DAL klasörü içerisine Abstract klasörü açılarak İnterface eklendi içerisinde temel CRUD işlemlerinin gerçekleşeceği Irepository interface’ini tanımladık. Abstract klasörünü db deki tablolarımızın adında IBlogDal v.b. Interface leri ekledik.
•	DAL klasörü içerisine Concrete klasörü açılarak Generic repository class ı oluşturuldu. İçerisine CRUD işlemleri kodları yazıldı. 
•	BLL klasörü içerisine Concrete,Abstract,Validation klasörü açıldı ve iş katmanı dosyaları eklendi. 
•	Admin template index’i _AdminLayout oluşturularak içerisine kopyalandı ve düzenlendi.
•	AdminKategoriController eklendi ve sayfası düzenlendi.
•	MVCUI bölümünde gerekli Controller ve View sayfaları eklenerek içleri düzenlenerek kodlandı.
•	Anasayfa bölümünde more-master teması kullanıldı ve Home Controller üzerinden HomePage View oluşturularak düzenlendi.
•	Admin paneli için Login Controller ve View i düzenlendi. AdminKategori ve Blog sayfalarına yetki verildi.
•	Hata Controller oluşturularak adres satırında yanlış karakterler girilmesi engellendi ve 404 sayfasına Web Config’te bulunan Connection String bağlantısı kullanıldı.
•	Anasayfa düzenlemeleri yapıldı.
•	Admin paneli tasarımları yapıldı, diğer yönetici ve personel panelleri ise geliştirilecektir. 



Okuduğunuz için Teşekkürler.
