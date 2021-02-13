using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilgiyarismasi
{
    class Program
    {
       
        static void MyMethod(string isim)
        {
            Console.WriteLine("Yarışmamıza hoşgeldiniz" +" " + isim);
        }
        static string Job()
        {
            string iş = Console.ReadLine();
            return iş;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("İsminiz nedir efendim ?");
            MyMethod(Console.ReadLine());

            Console.WriteLine("Hangi meslek dalında çalışmaktasınız ?");
            string getjob= Job();
            Console.WriteLine("Mesleğiniz"+" "+getjob+" "+"demek.İşinizde kolaylık diliyorum size.Sizi tanıdığımıza göre yarışmamıza geri dönelim.");

            int dogrucevapsayisi = 0;
            const double Pi = 3.14;

            Console.WriteLine("Bu arada doğru cevapladığınız soru başına 5000 Lira ödülümüz var.O yüzden mümkün olduğunca soruları doğru cevaplayın.");    
            Console.WriteLine("İlk sorumuz geliyor hazır mısınız ?");

            
           string cevap = Console.ReadLine();

                if ((((((cevap == "evet") || (cevap == "Evet")) || (cevap == "EVET")) || (cevap == "Hazırım")) || (cevap == "hazırım")) || (cevap == "HAZIRIM"))
                {
                    Console.WriteLine("O zaman sorumuz gelsin.");
                }
                else
                {
                    Console.WriteLine("Merak etmeyin,heyecanınız ilerledikçe geçer.");
                    Console.WriteLine("O zaman sorumuz gelsin.");
                }

                /* İlk soru burada başlıyor */
                Console.WriteLine("Pi sayısının ilk 3 basamağı kaçtır? Ondalık sayı gösterimi için virgül kullanınız.");
                decimal cevap1 = Convert.ToDecimal(Console.ReadLine());
                if (cevap1 == 3.14m)
                {
                dogrucevapsayisi = dogrucevapsayisi + 1;
                Console.WriteLine("Tebrikler.Soruya doğru cevap verdiniz.Şimdi sıradaki soruya geçiyoruz.");
                }
                else
                {
                Console.WriteLine("Yanlış Cevap Verdiniz.Fakat üzülmeyin çünkü yine de diğer soruya geçiyoruz.");
            }

                /* İkinci soru burada başlıyor.*/

                Console.WriteLine("Alfabemizin baştan onuncu harfi kaçtır ?");

                char cevap2 = Convert.ToChar(Console.ReadLine());
                switch (cevap2)
                {
                    case 'h':
                        Console.WriteLine("Tebrikler.Soruya doğru cevap verdiniz.Şimdi sıradaki soruya geçiyoruz.");
                    dogrucevapsayisi = dogrucevapsayisi + 1;
                    break;

                    case 'H':
                        Console.WriteLine("Tebrikler.Soruya doğru cevap verdiniz.Şimdi sıradaki soruya geçiyoruz.");
                    dogrucevapsayisi = dogrucevapsayisi + 1;
                    break;

                    default:
                        Console.WriteLine("Yanlış Cevap Verdiniz.Fakat üzülmeyin çünkü yine de diğer soruya geçiyoruz.");
                    break;
                }

                /* Üçüncü soru burada başlıyor. */

                Console.WriteLine("Türkiye'nin pasif durumda İkinci Dünya Savaşı'na katılma tarihi yıl olarak kaçtır ? ");

                int cevap3 = Convert.ToInt32(Console.ReadLine());


            if (cevap3 == 1945) 
            
                for (int sayac1 = 1; sayac1 < 2; sayac1 = sayac1 + 1)
                {
                    dogrucevapsayisi = dogrucevapsayisi + 1;
                    Console.WriteLine("Tebrikler.Soruya doğru cevap verdiniz.Şimdi sıradaki soruya geçiyoruz.");
                }

            else
            {
                Console.WriteLine("Yanlış Cevap Verdiniz.Fakat üzülmeyin çünkü yine de diğer soruya geçiyoruz.");
            }
                              
                /* Dördüncü soru burada başlıyor. */

                Console.WriteLine("Şu anki gözlemler ve teorilere göre evrenimizin yaşının yuvarlanmış hali kaçtır ?");
                long cevap4 = Convert.ToInt64(Console.ReadLine());
                int sayac2;
                sayac2 = 1;
                 
                if (cevap4 == 14000000000L)
            
                while (sayac2 < 2)
                {
                    dogrucevapsayisi = dogrucevapsayisi + 1;
                Console.WriteLine("Tebrikler.Soruya doğru cevap verdiniz.Şimdi sıradaki soruya geçiyoruz.");
                    sayac2 = sayac2 + 1;
                    }

                else
                {
                    Console.WriteLine("Yanlış Cevap Verdiniz.Fakat üzülmeyin çünkü yine de diğer soruya geçiyoruz.");
            }

            /* Beşinci soru burada başlıyor. */

            Console.WriteLine("Yüzüklerin Efendisi serisinde Yüzük Kardeşliği'nin oluşturulduğu,elf kontrolünde olan yerin ismi nedir ?");
                string cevap5 = Console.ReadLine();
                int sayac3;
                sayac3 = 1;

                if (cevap5 == "Ayrıkvadi")

                    do
                    {
                    dogrucevapsayisi = dogrucevapsayisi + 1;
                    Console.WriteLine("Tebrikler.Soruya doğru cevap verdiniz.Şimdi sıradaki soruya geçiyoruz.");
                    sayac3 = sayac3 + 1;
                    }
                    while (sayac3 < 2);

                else
                {
                    Console.WriteLine("Yanlış Cevap Verdiniz.Fakat üzülmeyin çünkü yine de diğer soruya geçiyoruz.");
            }

            /* Altıncı soru burada başlıyor. */
            
            Console.WriteLine("Yüzüklerin Efendisi'nde yüzük taşıyıcısı ve onun arkadaşının isimleri nelerdir ?");
            string cevap6 = Console.ReadLine();
            if (((cevap6 == "Frodo") && (cevap6 == "Samwise")) || (cevap6 == "Frodo ve Samwise"))
            {
                dogrucevapsayisi = dogrucevapsayisi + 1;
                Console.WriteLine("Tebrikler.Soruya doğru cevap verdiniz.Sorularımız bu kadardı yarıştığınız için teşekkür ederiz.");
                Console.WriteLine("Doğru cevap sayınız:" + " " + dogrucevapsayisi);
                Console.WriteLine("Kazandığınız ödül:" + " " + dogrucevapsayisi * 5000 + "Türk Lirası");
            }
            else
            {
                Console.WriteLine("Yanlış Cevap Verdiniz.Sorularımız bu kadardı yarıştığınız için teşekkür ederiz.");
                Console.WriteLine("Doğru cevap sayınız:" + " " + dogrucevapsayisi);
                Console.WriteLine("Kazandığınız ödül:" + " " +dogrucevapsayisi*5000+" "+"Türk Lirası");
            }
            Console.ReadKey();
        }
    }
}
