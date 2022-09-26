using System;

namespace YapayZeka
{



    class Program //sınıf
    {

        //git hub yüklemesi yapıldı

        static string specialWord = "arkadaşım"; //tüm Program için geçerli değişken...



        static void Main(string[] args) //program bu metod ile başlayacak
        {
            
            Console.WriteLine("first word : help"); // içeriği ekrana yazar ve bir satır aşağı iner
            Komut(); // Komut isimli method çağırılıyor
            Console.ReadKey(); // kullanıcıdan herhangi bir tuşa basması bekleniyor

        }



        static void Komut() // komut methodu 
        {
            Console.Write("\nKomut: ");
            string komut = Console.ReadLine(); // kullanıcıdan veri girişi isteniyor ve komut isimli değişkene aktarılıyor

            switch (komut)
            {
                case "selam":
                    Selam();
                    Komut();
                    break;
                case "renk":
                    RenkDegis();
                    Komut();
                    break;
                case "title":
                    TitleDegis();
                    Komut();
                    break;
                case "exit":
                    Exit();
                    break;
                case "help":
                    Help();
                    Komut();
                    break;
                case "clear":
                    Clear();
                    Komut();
                    break;
                default:
                    Console.WriteLine("Geçerli komut gir");
                    Komut();
                    break;
            }
        }



        static void Selam()
        {
            Console.Write("isminiz: "); // içeriği ekrana yazar, satır atlamaz!
            string name = Console.ReadLine(); // kullanıcıdan veri girişi isteniyor, name değişkenine aktarılıyor
            Console.Write("selam {0} {1}, nasılsın?: ", name, specialWord);
            string cevap = Console.ReadLine(); // kullanıcıdan veri girişi isteniyor, cevap değişkenine aktarılıyor
            Console.WriteLine("{0} {2}, demek {1} gibi hissediyorsun...Tamam öyleyse, sana iyi eğlenceler {2} :)", name, cevap, specialWord);
        }
        static void Exit()
        {
            Console.WriteLine("Çıkmak istediğine emin misin? (y/n)?");

            string cevap = Console.ReadLine(); // kullanıcıdan veri girişi isteniyor, cevap değişkenine aktarılıyor

            if (cevap.Equals("y")) // cevap değişkeni verisi "y" ile karşılaştırılıyor
            {
                Console.WriteLine("Gerçekten çıkmak istediğine emin misin? (y/n)?");

                string cevap2 = Console.ReadLine(); // kullanıcıdan veri girişi isteniyor, cevap2 değişkenine aktarılıyor

                if (cevap2.Equals("y")) // cevap2 değişkeni verisi "y" ile karşılaştırılıyor
                {
                    Console.WriteLine("Tamam, arayı fazla açma {0} :)", specialWord);
                }
                else if (cevap2.Equals("n")) // cevap değişkeni verisi "n" ile karşılaştırılıyor
                {
                    Console.WriteLine("Doğru yolu bulduğuna sevindim {0}:)", specialWord);
                    Komut();
                }
                else
                {
                    Console.WriteLine("Geçerli komut gir");
                    Exit();
                }
            }
            else if (cevap.Equals("n"))
            {
                Console.WriteLine("Doğru yolu bulduğuna sevindim {0}:)", specialWord);
                Komut();
            }
            else
            {
                Console.WriteLine("Geçerli komut gir");
                Exit();
            }

        }
        static void TitleDegis()
        {
            Console.Write("Başlık ne olsun? :");
            string baslik = Console.ReadLine();
            Console.Title = baslik;
        }
        static void Help() // method tanımı
        {
            Console.Write("selam | renk | title | clear | help | exit");
        }
        static void RenkHelp() // method tanımı
        {
            Console.Write("green | red | yellow | cyan | magenta :");
        }
        static void Clear() // method tanımı
        {
            Console.Clear();
        }
        static void RenkDegis() // method tanımı
        {
            Console.Write("Hangir renk? ");
            RenkHelp(); // method çağırılıyor
            string renk = Console.ReadLine(); // kullanıcıdan veri girişi isteniyor, renk değişkenine aktarılıyor
            // swithc komutu ile renk değişkeninin içeriği, her case içerisinde karşılaştırılıyor
            switch (renk)
            {
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                default:
                    Console.WriteLine("Geçerli renk giriniz");
                    RenkDegis();
                    break;
            }
        }

    }
}
