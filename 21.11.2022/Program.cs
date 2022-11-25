using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _21._11._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            ////kullanıcıdan bir rakam girişi isteyiniz. rakam girmeyince ve girilen ifade rakam değil sayı ise tekrar tekrar giriş isteyiniz. giriş başarılı ise tebrikler başarılı giriş yaptınız. mesajı veriniz.

            //            ////Console.WriteLine("LÜTFEN BİR RAKAM GİRİNİZ.");
            //            ////string KullancidanAlinan = Console.ReadLine();
            //            ////int sayidonen;
            //            ////bool sayiMi = false;


            //            ////do
            //            ////{
            //            ////    Console.WriteLine("bir sayı giriniz.");
            //            ////    string KullanicidanAlinan = Console.ReadLine();
            //            ////    sayiMi  = int.TryParse(KullancidanAlinan, out sayidonen);
            //            ////    Console.WriteLine("BAŞARILI GİRİŞ YAPTINIZ.");
            //            ////    if (sayidonen>10 || sayidonen<10)
            //            ////    {
            //            ////        sayiMi = false;
            //            ////    }

            //            ////} while (sayiMi==false|| sayidonen>10 || sayidonen<10);
            //            ////Console.WriteLine("BAŞARILI GİRİŞ YAPTINIZ.");


            //            ////Console.ReadKey();

            //            ///// yukarıdaki örneği while döngüsü ile yapınız.
            //            ///// 

            //            ////bool sayiMi = false;
            //            ////int sayiDonen = 1;
            //            ////while (sayiMi==false || sayiDonen<0 || sayiDonen>10)
            //            ////{
            //            ////    Console.WriteLine("LÜTFEN BİR RAKAM GİRİNİZ.");
            //            ////    string KullanicidanAlinan = Console.ReadLine();
            //            ////    sayiMi = int.TryParse(KullanicidanAlinan, out sayiDonen);
            //            ////}

            //            ////Console.WriteLine("BAŞARILI GİRİŞ YAPTINIZ.");
            //            ////Console.ReadKey();

            //            //// value types(stack)** mülakatlarda çıkar.
            //            ////referance types**
            //            ////byte, sbyte, short, integer, long, ulong, double, float,decimal en büyük ve en küçük değerlerini ekrana yazdır.
            //            ////#region Value Types
            //            ////Console.WriteLine("byte için minimum değer" + byte.MinValue);
            //            ////Console.WriteLine("byte için maksimum değer" + byte.MaxValue);

            //            ////Console.WriteLine("sbyte için minimum değer" + sbyte.MinValue);
            //            ////Console.WriteLine("sbyte için maksimum değer" + sbyte.MaxValue);

            //            ////Console.WriteLine("integer için minimum değer" + int.MinValue);
            //            ////Console.WriteLine("integer için maksimum değer" + int.MaxValue);

            //            ////Console.WriteLine("long için minimum değer" + long.MinValue);
            //            ////Console.WriteLine("long için maksimum değer" + long.MaxValue);

            //            ////Console.WriteLine("long için minimum değer" + double.MinValue);
            //            ////Console.WriteLine("long için maksimum değer" + double.MaxValue);

            //            ////Console.ReadKey();
            //            ////#endregion  /kısayolu ctrl+a+f

            //            ////KULLANICIDAN 2 SAYI İSTEYİN BUNLARIN SAYI OLDUĞUNU KONTROL EDİNİZ. toplam diye bir region oluşturup içine atınız.

            //            ////#region Toplam
            //            ////Console.WriteLine("BİRİNCİ SAYI GİRİNİZ");
            //            ////string sayi1= Console.ReadLine();
            //            ////int number1;
            //            ////bool __IsSuccess1 = int.TryParse(sayi1, out number1);
            //            ////Console.WriteLine("İKİNCİ SAYI GİRİNİZ");
            //            ////string sayi2 = Console.ReadLine();
            //            ////int number2;
            //            ////bool __IsSuccess2 = int.TryParse(sayi2, out number2);
            //            ////if (__IsSuccess1 && __IsSuccess2)
            //            ////{
            //            ////    Console.WriteLine("BAŞARILI GİRİŞ YAPTINIZ.");
            //            ////    Console.WriteLine("SAYILARIN TOPLAMI: " + (number1+number2));
            //            ////}

            //            ////else
            //            ////{
            //            ////    Console.WriteLine("HATALI GİRİŞ YAPTINIZ.");
            //            ////}

            //            ////Console.ReadKey();
            //            ////#endregion


            //            ////bool sayiMi1, sayiMi2;
            //            ////decimal sayidonen1, sayidonen2;
            //            ////do
            //            ////{
            //            ////    Console.WriteLine("1. sayıyı giriniz.");
            //            ////    string kullanicidanalinan1 = Console.ReadLine();
            //            ////    sayiMi1 = decimal.TryParse(kullanicidanalinan1, out sayidonen1);

            //            ////} while (sayiMi1 == false);
            //            ////do
            //            ////{
            //            ////    Console.WriteLine("2. sayıyı giriniz.");
            //            ////    string kullanicidanalinan2 = Console.ReadLine();
            //            ////    sayiMi1 = decimal.TryParse(kullanicidanalinan2, out sayidonen2);
            //            ////} while (sayiMi1 == false || sayidonen2 == 0);
            //            ////#region Dört İşlem
            //            ////Console.WriteLine("SAYILARIN TOPLAMI: " + (sayidonen1 + sayidonen2));
            //            ////Console.WriteLine("SAYILARIN ÇIKARMA: " + (sayidonen1 - sayidonen2));
            //            ////Console.WriteLine("SAYILARIN ÇARPIMI: " + (sayidonen1 * sayidonen2));
            //            ////Console.WriteLine("SAYILARIN BÖLÜMÜ: " + (sayidonen1 / sayidonen2));
            //            ////#endregion

            //            //////MOD ALMA ALMA İŞLEMİ EKLEYİNİZ.
            //            //////SAYİ DONEN İ 1 ARTTIRIP EKRANA YAZDIRINIZ.
            //            //////SAYI DÖNEN 2 Yİ 1 ARTTIRIP EKRANA YAZDIRINIZ.
            //            ////#region Mod alma işlemi
            //            ////Console.WriteLine("1. sayının 2. sayıya bölümünden kalan :" + (sayidonen1%sayidonen2));
            //            ////Console.WriteLine("2. sayının 1. sayıya bölümünden kalan :" + (sayidonen2%sayidonen1));
            //            ////#endregion

            //            ////#region sayıları 1 arttırma ve 1 azaltma
            //            ////sayidonen1 = sayidonen1 + 1;
            //            ////Console.WriteLine(sayidonen1);
            //            ////sayidonen1++;
            //            ////Console.WriteLine(sayidonen1);

            //            ////sayidonen2 = sayidonen2 - 1;
            //            ////Console.WriteLine(sayidonen2);
            //            ////sayidonen2--;
            //            ////Console.WriteLine(sayidonen2);

            //            ////dışsarıdan alınan iki sayının toplamı ile farkının birbirine bölümünden kalanı ekrana yazdırın.


            //            //bool sayiMi1, sayiMi2;
            //            //decimal sayidonen1, sayidonen2;
            //            //do
            //            //{
            //            //    Console.WriteLine("1. sayıyı giriniz.");
            //            //    string kullanicidanalinan1 = Console.ReadLine();
            //            //    sayiMi1 = decimal.TryParse(kullanicidanalinan1, out sayidonen1);

            //            //} while (sayiMi1 == false);
            //            //do
            //            //{
            //            //    Console.WriteLine("2. sayıyı giriniz.");
            //            //    string kullanicidanalinan2 = Console.ReadLine();
            //            //    sayiMi1 = decimal.TryParse(kullanicidanalinan2, out sayidonen2);

            //            //} while (sayiMi1 == false || sayidonen2 == 0);
            //            //Console.WriteLine("SAYILARIN TOPLAMI: " + (sayidonen1 + sayidonen2));
            //            //Console.WriteLine("SAYILARIN FARKI: " + (sayidonen1 - sayidonen2));
            //            //Console.WriteLine("TOPLAMIN VE FARKIN BİRBİRİNE BÖLÜMÜNDEN KALAN: " + ((sayidonen1 + sayidonen2) % (sayidonen1 - sayidonen2)));
            //            //Console.ReadKey();
            //            //decimal toplam = sayidonen1 + sayidonen2;
            //            //decimal fark = sayidonen1 - sayidonen2;
            //            //if (fark==0)
            //            //{
            //            //    Console.WriteLine("BU BÖLME İŞLEMİ YAPILAMAZ, BÖLME İŞLEMİ YAPILAMAZ. ");
            //            //}
            //            //else
            //            //{
            //            //    decimal kalan = toplam % fark;
            //            //    Console.WriteLine("TOPLAMIN VE FARKIN BİRBİRİNE BÖLÜMÜNDEN KALAN: " + ((sayidonen1 + sayidonen2) % (sayidonen1 - sayidonen2)));
            //            //}

            //            //Console.ReadKey();

            //            // KULANICIDAN ALINAN 1 SAYININ 10 EKSİĞİNİN 20 FAZLASININ 2 YE BÖLÜMÜNDEN KALANIN KARESİ KAÇTIR?

            //            //Console.WriteLine("BİR SAYI GİRİNİZ");
            //            //string sayi1 = Console.ReadLine();
            //            //double Sayi;
            //            //bool __IsSuccess = double.TryParse(sayi1, out Sayi);
            //            //if (__IsSuccess)
            //            //{
            //            //    Console.WriteLine("Sonuç:" + (((Sayi-10)+20)%2) * (((Sayi - 10) + 20) % 2));
            //            //    Console.ReadKey();
            //            //}
            //            //else
            //            //{
            //            //    Console.WriteLine("SAYISAL DEĞER GİRMEDİĞİNİZDEN İŞLEM YAPILAMADI. ");
            //            //}

            //            //Console.ReadKey();

            //            // kullanıcıdan alınan 2 sayının karelerinin toplamı ile karelerinin farkının toplamını veren programı yazınız.


            //            //Console.WriteLine("BİR SAYI GİRİNİZ");
            //            //string kullanıcidanalinan = Console.ReadLine();
            //            //double Sayi1;
            //            //bool __IsSuccess1 = double.TryParse(kullanıcidanalinan, out Sayi1);
            //            //Console.WriteLine("BİR SAYI GİRİNİZ");
            //            //string kullanıcidanalinan1 = Console.ReadLine();
            //            //double Sayi2;
            //            //bool __IsSuccess2 = double.TryParse(kullanıcidanalinan1, out Sayi2);

            //            //if (__IsSuccess1 && __IsSuccess2)
            //            //{
            //            //    Console.WriteLine("Sonuç:" + (((Sayi1*Sayi1)+(Sayi2*Sayi2))+((Sayi1*Sayi1)- (Sayi2 * Sayi2))));
            //            //    Console.ReadKey();
            //            //}
            //            //else
            //            //{
            //            //    Console.WriteLine("SAYISAL DEĞER GİRMEDİĞİNİZDEN İŞLEM YAPILAMADI. ");
            //            //}

            //            //Console.ReadKey();

            //            // SINAV NOT UYGULAMASI:
            //            // 1. GÖREV ÖĞRENCİYE VİZE VE FİNAL NOUNU SORUNUZ
            //            //2. GÖREV VİZE NOTUNUN % 40 INI FİNAL NOTUNUN %60 INI ALARAK DÖNEM SONU NOTUNU HESAPLAYINIZ.
            //            //3. GÖREV ÖĞRENCİNİN NOTU 50 Yİ GEÇERSE GEÇTİ, 50 ni altında kalırsa BAŞARAMADIN., BİLGİSNİ VERİNİZ.


            //            //Console.WriteLine("VİZE NOTUNUZU GİRİNİZ");
            //            //string kullanıcidanalinan = Console.ReadLine();
            //            //double __Vize;
            //            //bool __IsSuccess1 = double.TryParse(kullanıcidanalinan, out __Vize);
            //            //Console.WriteLine("FİNAL NOTUNUZU GİRİNİZ.");
            //            //string kullanıcidanalinan1 = Console.ReadLine();
            //            //double __Final;
            //            //bool __IsSuccess2 = double.TryParse(kullanıcidanalinan1, out __Final);

            //            //if (__IsSuccess1 && __IsSuccess2)
            //            //{
            //            //    __Vize = (__Vize * 40)/100;
            //            //    __Final = (__Final * 60) / 100;
            //            //    double sonuc = __Vize + __Final;

            //            //    if (__Vize + __Final >= 50 )
            //            //    {
            //            //        Console.WriteLine("GEÇTİNİZ " + sonuc);
            //            //    }


            //            //    else
            //            //    {
            //            //        Console.WriteLine("BAŞARAMADIN "+ sonuc);
            //            //    }
            //            //}
            //            //else
            //            //{
            //            //    Console.WriteLine("SAYISAL DEĞER GİRMEDİĞİNİZDEN İŞLEM YAPILAMADI. ");
            //            //}

            //            //Console.ReadKey();

            //            /*KULLANICININ AD E SOYAD BİLGİLERİNİ ALINIZ. AD.SOYAD@BİLGEADAM.COM ŞEKLİNDE BİR MAİL ADRESİ OLUŞTURUP, EKRANA AD.SOYAD@BİLGEADAM.COM MAİLİNİZ AKTİF HALE GETİRİLMİŞTİR YAZDIRINIZ.          
            //             */
            //            //#region bilgeadam
            //            //Console.WriteLine("BİR İSİM GİRİNİZ.");
            //            //string __Name= Console.ReadLine();
            //            //Console.WriteLine("BİR SOYİSİM GİRİNİZ.");
            //            //string __Surname = Console.ReadLine();
            //            //string __Mail= __Name + "." +__Surname +"@BİLGEADAM.COM";
            //            //Console.WriteLine("MAİLİNİZ AKTİF HALE GETİRİLMİŞTİR." + __Mail);
            //            //#endregion
            //            //Console.ReadKey();

            //            /*
            //             * kullanıcıdan iki sayı alınız dört işlem yaptırınız. (kullanıcıdan işlem istenecek)
            //             */

            //            //bool sayiMi1, sayiMi2;
            //            //decimal sayidonen1, sayidonen2;
            //            //do
            //            //{
            //            //    Console.WriteLine("1. sayıyı giriniz.");
            //            //    string kullanicidanalinan1 = Console.ReadLine();
            //            //    sayiMi1 = decimal.TryParse(kullanicidanalinan1, out sayidonen1);

            //            //} while (sayiMi1 == false);
            //            //do
            //            //{
            //            //    Console.WriteLine("2. sayıyı giriniz.");
            //            //    string kullanicidanalinan2 = Console.ReadLine();
            //            //    sayiMi1 = decimal.TryParse(kullanicidanalinan2, out sayidonen2);
            //            //} while (sayiMi1 == false || sayidonen2 == 0);
            //            //Console.WriteLine("bir işlem değeri giriniz");
            //            //int __islem = int.Parse.Console.ReadLine();


            //            //if (__islem == 1) 
            //            //{
            //            //    Console.WriteLine("SAYILARIN TOPLAMI: " + (sayidonen1 + sayidonen2));
            //            //}
            //            //if (__islem == 2)
            //            //{
            //            //    Console.WriteLine("SAYILARIN ÇIKARMA: " + (sayidonen1 - sayidonen2));
            //            //}
            //            //if (__islem ==3)
            //            //{
            //            //    Console.WriteLine("SAYILARIN ÇARPIMI: " + (sayidonen1 * sayidonen2));
            //            //}
            //            //if (__islem ==4)
            //            //{
            //            //    Console.WriteLine("SAYILARIN BÖLÜMÜ: " + (sayidonen1 / sayidonen2));
            //            //}



            //            //    Console.WriteLine("lütfen 1. sayıyı giriniz.");
            //            //    float sayi1 = Convert.ToSingle(Console.ReadLine());
            //            //ikincisayi: Console.WriteLine("lütfen 2. sayıyı giriniz.");
            //            //    float sayi2 = Convert.ToSingle(Console.ReadLine());
            //            //islemsec: Console.WriteLine("lütfen işlem tipini giriniz. t,c,x,b,u");
            //            //    char islemtipi = Convert.ToChar(Console.ReadLine());

            //            //    if (islemtipi == 't')
            //            //    {

            //            //        Console.WriteLine("toplam: " + (sayi1 + sayi2));
            //            //    }
            //            //    else if (islemtipi == 'c')
            //            //    {
            //            //        Console.WriteLine("çıkarma: " + (sayi1 - sayi2));
            //            //    }
            //            //    else if (islemtipi == 'x')
            //            //    {
            //            //        Console.WriteLine("çarpma: " + (sayi1 * sayi2));
            //            //    }
            //            //    else if (islemtipi == 'b')
            //            //    {
            //            //        if (sayi2 == 0)
            //            //        {
            //            //            Console.WriteLine("bölen 0 olamaz.");
            //            //            goto ikincisayi;
            //            //        }

            //            //        Console.WriteLine("bölme: " + (sayi1 / sayi2));

            //            //    }
            //            //    else if (islemtipi == 'u')
            //            //    {
            //            //        Console.WriteLine("kuvveti: " + Math.Pow(sayi1, sayi2));
            //            //    }
            //            //    else
            //            //    {
            //            //        Console.WriteLine("yanlış giriş yaptınız tekrar denemek ister misiniz. tekrar denemek isterseniz e yi tuşlayınız");
            //            //        char cevap = Convert.ToChar(Console.ReadLine());
            //            //        if (cevap == 'e')
            //            //        {
            //            //            Console.Clear();
            //            //            goto islemsec;
            //            //        }
            //            //        else
            //            //        {
            //            //            Environment.Exit(0);
            //            //        }
            //            //    }

            //            /*ternary if
            //            //int sayi1 = 100;
            //            //int sayi2 = 10;
            //            //string sonuc = sayi1 > sayi2 ? "1. sayı, ikinci sayıdan büyüktür." : "2. sayı, 1. sayıdan büyüktür.";
            //            Console.WriteLine(sonuc); */


            //            //kullanıcıdan iki sayı isteyin, hangi sayı büyükse ekrana yazdırın.

            //            //Console.WriteLine("lütfen 1. sayıyı giriniz.");
            //            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //            //Console.WriteLine("lütfen 2. sayıyı giriniz.");
            //            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //            //string sonuc = sayi1 > sayi2 ? "1. sayı, 2. sayıdan büyüktür." : sayi1 == sayi2 ? "sayılar eşittir. " : "2. sayı, 1. sayıdan büyüktür.";
            //            //Console.WriteLine(sonuc);
            //            //Console.ReadLine();


            //            /*KULLANICIDAN YAŞINI İSTEYİNİZ. SAYISAL MI DEĞİL Mİ DİYE KONROL EDİN.
            //             * YAŞ KONTROL(YAS>17) İSE ÇIKTISI EHLİYET ALABİLİR BUNU DA TERNARY İS İLE YAP
            //             */

            //            //Console.WriteLine("YAŞINIZI GİRİNİZ.");
            //            //string __temp = Console.ReadLine();
            //            //double Sayi;
            //            //bool __IsSuccess = double.TryParse(__temp, out Sayi);
            //            //int sayi2 = 17;
            //            //string sonuc;
            //            //if (__IsSuccess)
            //            //{
            //            //   sonuc = Sayi > sayi2 ? "EHLİYET ALABİLİR" :  "EHLİYET ALAMAZ " ;
            //            //    Console.WriteLine(sonuc);
            //            //}
            //            //Console.ReadLine();

            //            ///*celcius, kelvin, fahrenait, reneur
            //            // * 1 adet c cinsinden sıcaklık bilgisi alıp diğer sıcaklık bilgilerine dönüştürüp ekrana yazdırınız.*/
            //            //double celcius, kelvin, fahrenait, reneur;
            //            //Console.WriteLine("sıcaklığı giriniz.");
            //            //double __sicaklik = double.Parse(Console.ReadLine());
            //            //fahrenait = (__sicaklik) * 180 / 100 + 32;
            //            //kelvin = (__sicaklik) + 273.5;
            //            //reneur = (__sicaklik) * 8 / 10;
            //            //Console.WriteLine($"FAHRENAİT: {fahrenait} KELVİN:{kelvin} RENOUR:{reneur}");


            //            Console.WriteLine("BİR SAYI GİRİNİZ");
            //            string __Sayistr = Console.ReadLine();
            //            int __Sayi;
            //            bool __IsSuccess = int.TryParse(__Sayistr, out __Sayi);

            //            Console.WriteLine("BİR SAYI GİRİNİZ");
            //            string __Sayistr1 = Console.ReadLine();
            //            int __Sayi1;
            //            bool __IsSuccess1 = int.TryParse(__Sayistr1, out __Sayi1);
            //            if (__IsSuccess && __IsSuccess1)
            //            {



            //                Console.WriteLine("SONUÇ:" + (__Sayi1+__Sayi));

            //            }
            //            else
            //            {
            //                Console.WriteLine("sayısal değer girmediniz.");
            //            }

            //            Console.ReadKey();

            /*1. görev: kullanıcıya araç tipini sorunuz.(Binek, binek,Ticari,ticari)
             * binek için => 100 tl mtv başlangıç ücreti, ticari Mtv>= 150 mtv başlangıç ücreti
             *2. görev: kullanıcıya aracın yaşını sorunuz.
             *araç yaşı 0-3 MTV*2, 3-7 arası mtv*1.75; 7+mtv*1.5
             * 3. görev: kullanıcıya motor hacmini sorunuz.
             * 0-1300 (1300 dahil)  mtv*2, 1300-1600 (1600 dahil), mtv*3, 1600-2000 mtv*4, 2000+ mtv*5
//             * 4. görev: yukarıdaki koşullara ve kullanıcıdan alınan bilgilere göre ödemeniz gereken mtv>0 x tl dir. bilgisi veriniz.
//             */
            //            double mtvIlk = 0;
            //            int __aracyasi = int.MinValue; //bu sayıyı girmeyecek 
            //            int hacim = 0;

            //baslagic:   Console.Clear();
            //            Console.WriteLine("araç tipiniz nedir");
            //            string __Aractipi = Console.ReadLine();
            //            if (__Aractipi== "Binek" || __Aractipi== "binek")
            //            {
            //                mtvIlk = 100;
            //            }
            //            else if (__Aractipi == "Ticari" || __Aractipi == "ticari")
            //            {
            //                mtvIlk = 150;
            //            }
            //            Console.WriteLine("yanlış giriş yaptınız.");
            //            goto baslangic;
            //yaş:        Console.WriteLine("araç yaşınızı giriniz.");
            //            __aracyasi = int.Parse(Console.ReadLine());
            //            if (__aracyasi>=0 && __aracyasi < 4)
            //            {
            //                mtvIlk = mtvIlk * 2;
            //            }
            //            else if (__aracyasi >= 4 && __aracyasi < 8)
            //            {
            //                mtvIlk = mtvIlk * 1.75;
            //            }
            //            else if (__aracyasi >= 8 )
            //            {
            //                mtvIlk = mtvIlk * 8;
            //            }
            //            else
            //            {
            //                Console.WriteLine("yanlış giriş yaptınız.");
            //            }

            //motor   : Console.WriteLine("motor hacminizi giriniz.");
            //            int motorhacmi = int.Parse(Console.ReadLine());
            //            if (motorhacmi<=1300)
            //            {
            //                mtvIlk = mtvIlk * 2;
            //            }
            //            else if (motorhacmi >= 1300 || motorhacmi <= 1600)
            //            {
            //                mtvIlk = mtvIlk * 3;
            //            }
            //            else if (motorhacmi >= 1600 || motorhacmi <= 2000)
            //            {
            //                mtvIlk = mtvIlk * 4;
            //            }
            //            else
            //            {
            //                mtvIlk = mtvIlk * 4;

            //            }
            // try catch
            //double mtvIlk = 100;
            //int __aracyasi = int.MinValue; //bu sayıyı girmeyecek 
            //int hacim = 0;
            //try
            //{
            //    Console.WriteLine("motor hacminizi giriniz.");
            //    int motorhacmi = int.Parse(Console.ReadLine());
            //    if (motorhacmi <= 1300)                {
            //        mtvIlk = mtvIlk * 2;
            //        Console.WriteLine(mtvIlk);
            //    }
            //    else if (motorhacmi >= 1300 || motorhacmi <= 1600)
            //    {
            //        mtvIlk = mtvIlk * 3;
            //    }
            //    else if (motorhacmi >= 1600 || motorhacmi <= 2000)
            //    {
            //        mtvIlk = mtvIlk * 4;
            //    }
            //    else
            //    {
            //        mtvIlk = mtvIlk * 5;

            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("hatalı giriş yaptınız.");
            //}
            //Console.ReadLine();

            ////swictch case
            //switch (motorhacmi)
            //{
            //    case motorhacmi 0 > && 1301<

            //    default:
            //        break;
            //}















            //try
            //{
            //    Console.WriteLine("araç tipiniz nedir");
            //    string __Tip= Console.ReadLine();

            //    __Tip == "Binek" || __Tip == "binek" ? 100 : __Tip == "Ticari" || __Tip == "ticari" ? 150 ;
            //    Console.WriteLine("aracınızın yaşı nedir?");
            //    int __Yas = Convert.ToInt32(Console.ReadLine());

            //    0 <= __Yas <= 3 ? Console.WriteLine(__Mtv * 2) : 3 <= __Yas <= 7 ? Console.WriteLine(__Mtv * 1, 75) :  <= __Yas <= 10 Console.WriteLine(__Mtv * 1, 75);
            //    Console.WriteLine("motor hacminiz nedir");
            //    int __Hacim = int.Parse.Console.ReadLine();
            //    0 <= __Hacim <= 1300 ? Console.WriteLine(__Mtv * 2) : 1300 <= __Hacim <= 1600 ? Console.WriteLine(__Mtv * 3, 75) : 1600 <= __Hacim <= 2000 ? Console.WriteLine(__Mtv * 4) : 1600 <= __Hacim <= 2000 ? Console.WriteLine(__Mtv * 5);
            //    Console.WriteLine("ödemeniz gereken mtv: "  );
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("hatalı giriş");

            //}


            /* kullanıcıdan  kullanıcı adı ve şifresini isteyiniz
             * kullanıcı adı admin ise ve şifresi 1234 ise giriş başarılı mesajı veriniz.
             * ADMIN AdMİN gibi bütün kombinasyonları kabul etmek istiyorum.
             */
            //Console.WriteLine("adınızı giriniz.");
            //string __name= Console.ReadLine();
            //string __nameupper = __name.ToUpper();

            //Console.WriteLine("şifrenizi giriniz");
            // string __sıfre = (Console.ReadLine());
            //if (__nameupper == "ADMİN" && __sıfre == "1234")
            //{
            //    Console.WriteLine("BAŞARILI GİRİŞ YAPTINIZ.");
            //}
            //else
            //{
            //    Console.WriteLine("şifrenizi yanlış girdiniz.");
            //}

            //Console.ReadKey();

            // bir üniversite öğrencilerininkilo ort., cinsiyetlerine göre bulunduran program.

            //1. görev kullanıcıya cinsiyetni sorun 
            //2. görev kilosu sorulacak
            //3. görev toplam erkek sayısını bulunuz
            //4. görev toplam kadın sayısını bulunuz
            //5. erkek kilo ortalmasını bulunuz.
            //6. görev kadın kilo ortalamasını bulunuz.
            //7. görev yeni bir kayıt - yeni bir giriş yapmak istiyor musunuz diye sorunuz.
            //8. görev başka bir giriş yapma istemiyorsa ekrana kadın, erkek sayısı,toplam kayıt sayısı,kadın erkke kilo ortalamalarını yazdırınız.




            //           double _ErkekSayisi = 0;
            //           double _KadinSayisi = 0;
            //           double _erkekkilo;
            //           double _kadınkilo; ;
            //           double toplamerkekkilo = 0;
            //           double toplamkadınkilo = 0;
            //           double erkekort = 0;
            //           double kadınort = 0;

            //yeniden:   Console.WriteLine("cinsiyetinizi yazınız");
            //           string _Cinsiyet = Console.ReadLine();
            //           string __Cinsiyet = _Cinsiyet.ToUpper();


            //           if (_Cinsiyet == "ERKEK")
            //           {

            //               _ErkekSayisi++;
            //               Console.WriteLine("kilonuzu giriniz.");
            //               _erkekkilo = Convert.ToDouble(Console.ReadLine());                             

            //               toplamerkekkilo = toplamerkekkilo + _erkekkilo;

            //               erkekort = toplamerkekkilo / _ErkekSayisi;

            //           }
            //           if (_Cinsiyet == "KADIN")
            //           {

            //               _KadinSayisi++;
            //               Console.WriteLine("kilonuzu giriniz.");
            //               _kadınkilo = double.Parse(Console.ReadLine());                          

            //                toplamkadınkilo = toplamkadınkilo + _kadınkilo;
            //                kadınort = toplamkadınkilo / _KadinSayisi;                           

            //           }

            //           Console.WriteLine("yeni bir giriş yapmak istiyor musunuz?");
            //           string __cevap = Console.ReadLine();
            //           __cevap = __cevap.ToUpper();

            //           if (__cevap == "EVET")
            //           {
            //               goto yeniden;
            //           }

            //           if (__cevap == "HAYIR")
            //           {
            //               Console.WriteLine("erkek sayısı: "+_ErkekSayisi);
            //               Console.WriteLine("kadın sayısı: "+_KadinSayisi);
            //               Console.WriteLine("kadın kilo: "+toplamkadınkilo);
            //               Console.WriteLine("erkek kilo: "+toplamerkekkilo);
            //               Console.WriteLine("kadın kilo ort: "+ kadınort);
            //               Console.WriteLine("erkek kilo ort: "+erkekort);
            //           }


            //           Console.ReadLine();

            //KULLANICIDAN BİR SAYI GİRİŞİ İSTEYİNİZ.
            //GİRİLEN SAYIYI VE SAYININ POZİTİF NEGATİF BİLGİSİNİ EKRANA YAZDIRINIZ.
            //Console.WriteLine("bir sayı giriniz.");
            //string __Numberstr = Console.ReadLine();
            //int __Number;
            //bool __IsSuccess = int.TryParse(__Numberstr, out __Number);

            //if (__IsSuccess)
            //{
            //    if (__Number < 0)
            //    {
            //        Console.WriteLine("sayı negatiftir.");
            //    }
            //    else if (__Number > 0)
            //    {
            //        Console.WriteLine("sayı pozitiftir.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("sayı değeri girmediniz.");
            //}
            //Console.ReadLine();



            //METOT İLE YAPINIZ.



            //cDeger __Deger = new cDeger();
            //__Deger.DegeriKontrolEt();
            //Console.ReadLine();


            //kullanıcıdan yazı alınıp ekrana yazdırılacak
            //Console.WriteLine("bir isim yazınız");
            //string __Name = Console.ReadLine();
            //c_Yazı __Deger = new c_Yazı();
            //__Deger.EkranaYazdir(__Name);
            //Console.ReadLine();


            /*1. kullanıcıdan yaş bilgisi alınız
             * 2. yaş ve 20-65 arasındaysa riskli gruptasınız mesajı veiniz.
             * 3. yaş 0-20 ve 65-100 arasındaysa riskli gruptasınız mesajı verniz 
             * hatalı girişler için hatalı giriş yazın.  
             */

            //baslangıc:  Console.WriteLine("bir sayı giriniz.");
            //            string __Yastr = Console.ReadLine();
            //            int __Yas;
            //            bool __IsSuccess = int.TryParse(__Yastr, out __Yas);

            //            if (__IsSuccess)
            //            {
            //                if (__Yas > 20 && __Yas < 65)
            //                {
            //                    Console.WriteLine("riskli grupta değilsiniz");
            //                }
            //                else if (__Yas > 65 && __Yas < 100)
            //                {
            //                    Console.WriteLine("riskli gruptasınız");
            //                }

            //                else
            //                {
            //                    Console.WriteLine("aralıkta bir değer girmediniz.");
            //                    goto baslangıc;
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("sayı değeri girmediniz.");
            //                goto baslangıc;
            //            }
            //            Console.ReadLine();


            // switch case

            //kullanıcıya içecek tercihini sorunuz, tercihe göre ekrana (çay/kahve/su) oldu yazınız.

            // Console.WriteLine("içecek tercihinizi giriniz /n (çay: Ç/ç, Kahve:K/k, Su:S,s,)");
            //Console.ReadLine();
            // char tercih = Convert.ToChar(Console.ReadLine());
            // switch (tercih)
            // {
            //     case 'C':
            //     case 'c':
            //         Console.WriteLine("tercihiniz çay oldu");
            //         break;
            //     case 'K':
            //     case 'k':
            //         Console.WriteLine("tercihiniz kahve oldu");
            //         break;

            //     case 'S':
            //     case 's':
            //         Console.WriteLine("tercihiniz su oldu");
            //         break;

            //     default:
            //         Console.WriteLine("hatalı giriş");
            //         break;
            // }

            //satış yapılan bir ürünümüz var. kullanıcıya ürünü beğenip beğenmediğini ya da kararsız olma durumunu sorunuz
            //ankete devam etmek istiyor musunuz diye sorunuz
            //beğenme beğenmemem kararsız sayısını anket sonunda yazdırınız.
            //            int begenensayisi = 0;
            //            int begenmeyensayisi = 0;
            //            int kararsızsayisi = 0;
            //        baslangic:  Console.WriteLine("ürün hakkında ne düşünüyorsunuz? /n (beğenme: E/e, beğenmeme:H/h, Kararsız:K,k, ye basınız)");
            //            string tercih=Console.ReadLine();

            //            switch (tercih.ToLower())
            //            {
            //                case "e":              

            //                    begenensayisi++;

            //                    break;
            //                case "h":

            //                    begenmeyensayisi++;
            //                    break;

            //                case "k":

            //                    kararsızsayisi++;
            //                    break;


            //                    Console.WriteLine(begenensayisi);
            //                    Console.WriteLine(begenmeyensayisi);
            //                    Console.WriteLine(kararsızsayisi);

            //                default:
            //                    Console.WriteLine("hatalı giriş");
            //                    goto baslangic;
            //                    break;
            //anketsorgu:
            //                    Console.WriteLine("ankete devam etmek istiyor musunuz?");
            //                    string _cevap = Console.ReadLine();
            //                    switch (_cevap.ToLower())
            //                    {

            //                        case "e":
            //                            goto baslangic;
            //                        case "h":

            //                            Console.WriteLine(begenensayisi+ begenmeyensayisi+ kararsızsayisi);
            //                        default:

            //                            Console.WriteLine("yanlış giriş yaptınız");
            //                            goto anketsorgu;
            //                            break;
            //                    }
            //            }


            //taş kağıt makas oyunu
            //kullanıcı vs bilg
            //el bittiği zmana 

 baslangic: Console.WriteLine("taş kağıt veya makas seçiniz");
            string kullanıcısecimi = Console.ReadLine();
            int bilgisayarskor = 0;
            int oyuncuskor = 0;

            Random r = new Random();
            int bilgisayarsecimi = r.Next(4);

            if (bilgisayarsecimi == 1)
            {
                if (kullanıcısecimi == "taş")
                {
                    Console.WriteLine("bilgisayar taş seçti");
                    Console.WriteLine("eşitlik ");
                    bilgisayarskor++;
                    oyuncuskor++;
                    Console.WriteLine(oyuncuskor + bilgisayarskor);
                }
                else if (kullanıcısecimi == "kağıt")
                {
                    Console.WriteLine("bilgisayar kağıt seçti");
                    Console.WriteLine("eşitlik");
                    bilgisayarskor++;
                    oyuncuskor++;
                    Console.WriteLine(oyuncuskor + bilgisayarskor);
                }
                else if (kullanıcısecimi == "makas")
                {
                    Console.WriteLine("bilgisayar makas seçti");
                    Console.WriteLine("eşitlik ");
                    bilgisayarskor++;
                    oyuncuskor++;
                    Console.WriteLine(oyuncuskor + bilgisayarskor);
                }
                else
                {
                    goto baslangic;
                    Console.WriteLine(oyuncuskor + bilgisayarskor);
                    Console.WriteLine(oyuncuskor + bilgisayarskor);

                }

            }

            else if (bilgisayarsecimi == 2)
            {
                if (kullanıcısecimi == "taş")
                {
                    Console.WriteLine("bilgisayar kağıt seçti");
                    Console.WriteLine("kaybettiniz, kağut taşı sardı.");
                    bilgisayarskor++;
                    Console.WriteLine("oyuncu:"+oyuncuskor + "bilgisayar:"+bilgisayarskor);

                }
                else if (kullanıcısecimi == "kağıt")
                {
                    Console.WriteLine("bilgisayar makası seçti");
                    Console.WriteLine("kaybettiniz makas kağıdı kesti ");
                    bilgisayarskor++;
                    Console.WriteLine("oyuncu:" + oyuncuskor + "bilgisayar:" + bilgisayarskor);
                }
                else if (kullanıcısecimi == "makas")
                {
                    Console.WriteLine("bilgisayar kayayı seçti");
                    Console.WriteLine("kaybettiniz kaya makası kırar");
                    bilgisayarskor++;
                    Console.WriteLine("oyuncu:" + oyuncuskor + "bilgisayar:" + bilgisayarskor);
                }
                else
                {
                    goto baslangic;

                    Console.WriteLine("oyuncu:" + oyuncuskor + "bilgisayar:" + bilgisayarskor);
                }
            }
            else if (bilgisayarsecimi == 3)
            {
                if (kullanıcısecimi == "taş")
                {
                    Console.WriteLine("bilgisayar makas seçti.");
                    Console.WriteLine("kazandnız");
                    oyuncuskor++;
                    Console.WriteLine("oyuncu:" + oyuncuskor + "bilgisayar:" + bilgisayarskor);
                }
                else if (kullanıcısecimi == "kağıt")
                {
                    Console.WriteLine("bilgisayar taş seçti");
                    Console.WriteLine("kazandnız");
                    oyuncuskor++;
                    Console.WriteLine("oyuncu:" + oyuncuskor + "bilgisayar:" + bilgisayarskor);

                }
                else if (kullanıcısecimi == "makas")
                {
                    Console.WriteLine("bilgisayar kağıt seçti");
                    Console.WriteLine("kazandnız");
                    oyuncuskor++;
                    Console.WriteLine("oyuncu:" + oyuncuskor + "bilgisayar:" + bilgisayarskor);

                }
                else
                {
                    goto baslangic;
                    Console.WriteLine("oyuncu:" + oyuncuskor + "bilgisayar:" + bilgisayarskor);
                }



                string devam= Console.ReadLine();
                if (devam == "e")
                {
                    goto baslangic;

                }
                else if (devam == "h")
                {
                    Console.WriteLine("çıkış yaptınız");
                    Console.WriteLine("oyuncu:" + oyuncuskor + "bilgisayar:" + bilgisayarskor);
                }
              
            }

            Console.ReadLine();






        }
    }
}




