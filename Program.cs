using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace RastgeleLig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*Rastgele Lig Turnuvamıza Hoşgeldiniz*");
            Console.WriteLine("*C# Dersleri Olarak Başarılar Dileriz*");
            Console.Title = "C# Turnuvası";
            int fb = 0;
            int gs = 0;
            int bjk = 0;
            int ts = 0;
            int sayac = 1;

            //rastgele
            int a1, a2, a3;
            int b1, b2, b3;
            int c1, c2, c3;
            int d1, d2, d3;

            Random rastgele = new Random();

            if (sayac == 1)
            {
                a1 = rastgele.Next(0, 6);
                b1 = rastgele.Next(0, 6);
                c1 = rastgele.Next(0, 6);
                d1 = rastgele.Next(0, 6);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine("****** 1.Hafta Lig Sonuçları ******");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("      Fb: " + a1 + "-" + b1 + " :Gs");
                if (a1 > b1)
                {
                    fb = fb + 3;
                }
                if (b1 > a1)
                {
                    gs = gs + 3;
                }
                if (a1 == b1)
                {
                    fb = fb + 1;
                    gs = gs + 1;
                }
                Console.WriteLine();
                Console.WriteLine("     Bjk: " + c1 + "-" + d1 + " :Ts");
                if (c1 > d1)
                {
                    bjk = bjk + 3;
                }
                if (d1 > c1)
                {
                    ts = ts + 3;
                }
                if (c1 == d1)
                {
                    bjk = bjk + 1;
                    ts = ts + 1;
                }
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
                sayac++;
                Console.ReadLine();
            }
            if (sayac == 2)
            {
                a2 = rastgele.Next(0, 6);
                b2 = rastgele.Next(0, 6);
                c2 = rastgele.Next(0, 6);
                d2 = rastgele.Next(0, 6);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("****** 2.Hafta Lig Sonuçları ******");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("     Ts: " + d2 + "-" + b2 + " :Gs");
                if (d2 > b2)
                {
                    ts = ts + 3;
                }
                if (b2 > d2)
                {
                    gs = gs + 3;
                }
                if (d2 == b2)
                {
                    ts = ts++;
                    gs = gs++;
                }
                Console.WriteLine();
                Console.WriteLine("     Bjk: " + c2 + "-" + a2 + " :Fb");
                if (c2 > a2)
                {
                    bjk = bjk + 3;
                }
                if (a2 > c2)
                {
                    fb = fb + 3;
                }
                if (c2 == a2)
                {
                    bjk++;
                    fb++;
                }
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
                sayac++;
                Console.ReadLine();
            }
            if (sayac == 3)
            {
                a3 = rastgele.Next(0, 6);
                b3 = rastgele.Next(0, 6);
                c3 = rastgele.Next(0, 6);
                d3 = rastgele.Next(0, 6);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("****** 3.Hafta Lig Sonuçları ******");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("    Bjk: " + c3 + "-" + b3 + " :Gs");
                if (c3 > b3)
                {
                    bjk = bjk + 3;
                }
                if (b3 > c3)
                {
                    gs = gs + 3;
                }
                if (c3 == b3)
                {
                    bjk++;
                    gs++;
                }
                Console.WriteLine();
                Console.WriteLine("    Fb: " + a3 + "-" + d3 + " :Ts");
                if (a3 > d3)
                {
                    fb = fb + 3;
                }
                if (d3 > a3)
                {
                    ts = ts + 3;
                }
                if (a3 == d3)
                {
                    fb++;
                    ts++;
                }
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
                sayac++;
                Console.ReadLine();
                if (sayac == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Maçlar Tamamlandı...");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("---Puantaj---");
                    Console.WriteLine("Fb: " + fb);
                    Console.WriteLine("Gs: " + gs);
                    Console.WriteLine("Ts: " + ts);
                    Console.WriteLine("Bjk: " + bjk);
                    Console.WriteLine("-----------------------------------");
                }
                SoundPlayer ses = new SoundPlayer();
                string yol;

                if (fb > gs && fb > ts && fb > bjk)
                {
                    yol = @"C:\Users\legen\Downloads\Kıraç-Fenerbahçe-100.-Yıl-Şarkısı-_Official-Video_.wav";
                    ses.SoundLocation = yol;
                    ses.Play();
                }
                if (gs > fb && gs > ts && gs > bjk)
                {
                    yol = @"C:\Users\legen\Downloads\Şereftir-Seni-Sevmek-_Stüdyo_-Galatasaray-Marşları.wav";
                    ses.SoundLocation = yol;
                    ses.Play();
                }
                if (ts > fb && ts > bjk && ts > gs)
                {
                    yol = @"C:\Users\legen\Downloads\Sen-Hayatımda-Anlam-Stüdyo-versiyon-_Biz-Dar-Sokaklarında_-Vira.wav";
                    ses.SoundLocation = yol;
                    ses.Play();
                }
                if (bjk > fb && bjk > ts && bjk > gs)
                {
                    yol = @"C:\Users\legen\Downloads\Gücüne-Güç-Katmaya-Geldik-Beşiktaş-Official-Video.wav";
                    ses.SoundLocation = yol;
                    ses.Play();



                }
                Console.Read();
            }
        }
    }
}
