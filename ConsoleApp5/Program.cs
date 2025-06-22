using System;

namespace BuyukOdulYarismasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogruSayisi = 0;

            // 1. Soru
            Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir ?");
            Console.WriteLine("a) Lama  b) Deve");
            Console.Write("Cevabınız (a/b): ");
            string cevap1 = Console.ReadLine().Trim().ToLower();

            if (cevap1 == "a")
            {
                dogruSayisi++;
                Console.WriteLine("Doğru cevap verdiniz.");
            }
            else
            {
                Console.WriteLine("Yanlış cevap verdiniz.");
            }

            // 2. Soru
            Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir ?");
            Console.WriteLine("a) Venüs  b) Mars");
            Console.Write("Cevabınız (a/b): ");
            string cevap2 = Console.ReadLine().Trim().ToLower();

            if (cevap2 == "a")
            {
                dogruSayisi++;
                Console.WriteLine("Doğru cevap verdiniz.");
            }
            else
            {
                Console.WriteLine("Yanlış cevap verdiniz.");
            }

            // İlk 2 soruda 0 doğru varsa, 3. soruyu sormuyoruz
            if (dogruSayisi == 0)
            {
                Console.WriteLine("\nİlk iki sorudan 0 doğru yapıldığı için 3. soru sorulmuyor. 😢");
            }
            else
            {
                // 3. Soru
                Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
                Console.WriteLine("a) 7  b) 12");
                Console.Write("Cevabınız (a/b): ");
                string cevap3 = Console.ReadLine().Trim().ToLower();

                if (cevap3 == "b") // 5*2 + 8/2 - 2 = 10 + 4 - 2 = 12
                {
                    dogruSayisi++;
                    Console.WriteLine("Doğru cevap verdiniz.");
                }
                else
                {
                    Console.WriteLine("Yanlış cevap verdiniz.");
                }
            }

            // Final sonucu
            Console.WriteLine("Toplam doğru cevap sayınız: " + dogruSayisi);

            if (dogruSayisi >= 2)
            {
                Console.WriteLine("Tebrikler! 1 Milyon TL'l büyük ödülü kazandınız! ");
            }
            else
            {
                Console.WriteLine("Üzgünüz, büyük ödülü kazanamadınız. ");
            }

            // Programın hemen kapanmaması için bekleme
            Console.WriteLine("\nÇıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}