# Class
# Bir okul yönetim sistemi yazdırıyoruz.

 Öğrencilerin ve öğretmenlerin bilgilerini yönetmek için Person adında genel bir sınıf oluşturmanız isteniyor. Bu sınıfın özellikleri şunlar olmalı: Ad, Soyad, Doğum Tarihi.

Person adında bir sınıf oluşturun ve bu özellikleri içeren public property'ler (get/set) tanımlayın.

Main metodu içinde, bu sınıftan birkaç öğrenci ve öğretmen nesnesi oluşturun ve bilgilerini konsola yazdırın.

Yukardaki işlemleri ilk olarak  Person adında bir sınıf oluşturarak içine propertyler yazıyoruz.

  public string Ad { get; set; }
        public string Soyad { get; set; }

        public int Dtarih { get; set; }
        
Daha sonra bu propertylere main  metodunda Person sınıfının nesnesini alıp değerlerini atıyoruz ve ekrana bastırıyoruz.
  Person Ogrenci2 = new Person();
  Ogrenci2.Ad = "Mehmet";
  Ogrenci2.Soyad = "Akif";
  Ogrenci2.Dtarih = 2000;

   Console.WriteLine("2.ogrenci :{0} {1} doğum tarihi {2}",Ogrenci2.Ad,Ogrenci2.Soyad,Ogrenci2.Dtarih);
