using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OdevHesapMakinesi
{
    class Program
    {
        //Zeyt Eymen Karabudak - 20010087 -
        //Araştırma Yaparken Bunun İçin Kullanılabilicek Bir Fonksiyon Buldum Bunu Kullandım
        public static void Islem()
        {
            bool cikis = false;
            Console.Write("Aritmetik İfadeyi Giriniz : ");
            string islem = Console.ReadLine();
            while (cikis  != true)//islem != "CIK"
            {
                try
                {
                    string harfler = "";
                    double sonuc = Convert.ToDouble(new DataTable().Compute(islem, null));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Aritmetik İfade Sonucu =>> " + sonuc);
                    Console.ResetColor();
                    Console.Beep();
                    foreach (char item in islem)
                    {
                        if (item == '+')
                        {
                            harfler += " + ,";
                        }
                        else if (item == '-')
                        {
                            harfler += " - ,";
                        }
                        else if (item == '*')
                        {
                            harfler += " * ,";
                        }
                        else if (item == '/')
                        {
                            harfler += " / ,";
                        }
                    }
                    Console.WriteLine("Kapsanan İfadeler : " + harfler);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Çıkmak İçin CIK yazınız\n\n");
                    Console.ResetColor();
                    Console.Write("Aritmetik İfadeyi Giriniz : ");
                    islem = Console.ReadLine();
                    if (islem == "CIK" || islem == "çık" || islem == "cik" || islem == "çik" || islem == "cık")
                    {
                        cikis = true;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("ÇIKIŞ YAPILIYOR");
                        Console.Beep(); Console.Beep(); Console.Beep();  Console.Beep(); Console.Beep();
                        Environment.Exit(0);
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Yanlış Giriş");
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Write("Aritmetik İfadeyi Giriniz : ");
                    islem = Console.ReadLine();
                }

            }
            
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Eymen Karabudak - 200130087");
            Console.ResetColor();
            Islem();
        }
    }
}
