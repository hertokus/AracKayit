# Arac Kayit

# 🚗 AracKayit - Araç Kayıt ve Yönetim Sistemi  

Bu proje, **ASP.NET Core MVC** kullanılarak geliştirilmiş bir **Araç Kayıt ve Yönetim Sistemi**dir. **Gülsan Holding Şirketi** için özel olarak hazırlanmış olup, şirketin araçlarını dijital ortamda kaydetmesini, yönetmesini ve takip etmesini sağlar.  

## 🎯 Proje Amacı  
Bu sistem, şirket araçlarının kayıt sürecini kolaylaştırmayı, bilgilerin güvenli ve erişilebilir bir şekilde saklanmasını sağlamayı amaçlamaktadır. Kullanıcılar, araç bilgilerini sisteme ekleyebilir, düzenleyebilir, silebilir ve detaylarını görüntüleyebilir. Ayrıca, belirli araçların kayıt sürecinin tamamlanması için bir **onay mekanizması** bulunmaktadır.  

## 🚀 Özellikler  
### 📌 Temel İşlevler  
- **Araç Kaydı:** Yeni araç bilgileri sisteme eklenebilir.  
- **Araç Listeleme:** Kayıtlı araçlar görüntülenebilir ve detaylarına erişilebilir.  
- **Arama ve Filtreleme:** Araçlar belirli kriterlere göre filtrelenebilir ve aranabilir.  
- **Güncelleme ve Silme:** Araç bilgileri düzenlenebilir veya sistemden kaldırılabilir.  

### 📌 Onay Süreci  
- **Onay Formu:** Araç kayıtlarının belirli kriterlere göre onaylanmasını sağlayan bir form mekanizması bulunmaktadır.  
- **Dinamik Soru Setleri:** Onay süreci için gerekli olan sorular **veritabanından** dinamik olarak çekilmektedir.  
- **Yetkilendirme:** Kullanıcı rollerine bağlı olarak onay işlemleri gerçekleştirilebilir.  

## 🛠 Kullanılan Teknolojiler  
Bu proje, **modern ve ölçeklenebilir bir mimari** ile geliştirilmiş olup, aşağıdaki teknolojileri içermektedir:  
- **ASP.NET Core MVC** – Web uygulaması geliştirme  
- **Entity Framework Core** – Veri tabanı yönetimi ve sorgulama  
- **SQL Server** – Verilerin saklanması ve yönetilmesi  
- **Bootstrap** – Duyarlı ve modern kullanıcı arayüzü tasarımı  
- **HTML, CSS, JavaScript** – UI/UX geliştirme için kullanılan temel teknolojiler  

## 🏗 Mimari ve Yapı  
Bu proje, **MVC (Model-View-Controller)** mimarisine uygun olarak geliştirilmiştir. **Entity Framework Core** kullanılarak **Code-First** yaklaşımı benimsenmiştir. Bu sayede veri tabanı şeması, kod üzerinden yönetilebilmekte ve **migration** işlemleri ile kolayca güncellenebilmektedir.  

📌 **Veri Tabanı:**  
Sistem, **AracKayit** tablosunu kullanarak araç bilgilerini saklamaktadır. Ek olarak, **onay süreci** için gerekli olan dinamik soru setleri ve kayıt verileri ayrı tablolar halinde tutulmaktadır.  

📌 **Kullanıcı Arayüzü:**  
Projenin kullanıcı deneyimi **Bootstrap** ve **modern web teknolojileri** kullanılarak geliştirilmiştir. Sayfalar, **responsive (mobil uyumlu)** olacak şekilde tasarlanmıştır.  



## 🏁 Sonuç  
Bu proje, **kurumsal bir araç kayıt ve yönetim sistemi** olarak geliştirilmiştir. Şirket araçlarının takibini kolaylaştırarak **dijital ve verimli bir çözüm** sunmaktadır. Kullanıcı dostu arayüzü ve güçlü veri tabanı altyapısı sayesinde **hızlı, güvenilir ve ölçeklenebilir** bir sistem oluşturulmuştur. 🚗✅  





