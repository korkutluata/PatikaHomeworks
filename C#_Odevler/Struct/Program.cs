using System;

namespace Struct
{
    /*
Class lar referans tipli özellikler gösterir, Yapılar ise değer tipli özellikler gösterirler. En temel fark budur.
Diğer struct yada sınıflardan kalıtım almazlar.
Interface'lerden kalıtım alabilirler.
new anahtar sözcüğü ile nesneleri yaratılabilir.
Sınıflar gibi metot, property ve field'lardan oluşurlar.
Sınıf içerisinde struct, struct içerisinde de sınıf oluşturulabilir.
Static üye barındırabilirler.
parametresiz constructor olusturulamiyor, class'larda farkli overload'lar olabiliyordu
kucuk veriler ile calisilacaksa (16 byte??? altinda) performans hizi icin struct, daha buyukler icin class diyorlarmissss
class'lardan farkli olarak struct'lar deger tipindedir, referans tip degildir.
new'lemeden de instance alinabilir struct'ta
*/
     class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.kisaKenar = 3;
            dikdortgen.uzunKenar = 4;
            Console.WriteLine("Class Dikdörtgen Alanı {0}",dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct();
            dikdortgen_Struct.kisaKenar = 3;
            dikdortgen_Struct.uzunKenar = 4;
            Console.WriteLine("Struct Dikdörtgen Alanı {0}",dikdortgen_Struct.AlanHesapla());
        }
    }

    class Dikdortgen
    {
        public int kisaKenar;
        public int uzunKenar;

        public Dikdortgen()
        {
            kisaKenar = 3;
            uzunKenar = 4;
        }
        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int kisaKenar;
        public int uzunKenar;

        public Dikdortgen_Struct(int KisaKenar , int UzunKenar)
        {
            uzunKenar = UzunKenar;
            kisaKenar = KisaKenar;
        }
        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }
}
