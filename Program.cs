using System;

namespace decimal1 {
    internal class Program {
    static void Main(string[] args) {
    decimal urun1,urun2,toplam;
    int s1,s2;
    urun1 = 14.56m; urun2 = 17.85m;
    Console.Write("urun 1 miktari: ");
    s1=Convert.ToInt16(Console.ReadLine());
    Console.Write("urun 2 miktari: ");
    s2=Convert.ToInt16(Console.ReadLine());
    toplam=urun1*s1 + urun2*s2;
    Console.WriteLine("toplam para: {0:C}",toplam);
    Console.Read(); } } }
