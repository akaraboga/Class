using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOrnek
{
    internal class Person //Person adında sınıf oluşturarak kişileri public propertyler ile alacağız.
    {   
        //Propertylerimizi almak istediğimiz değişken tipinde ekliyoruz.
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public int Dtarih { get; set; }
    }
}
