using System;

namespace bilgiyarismasi {
    internal class Program {
    static void Main(string[] args) {
    Console.Title ="Bilgi Yarismasi";
    string ad,soyad;
    Console.Write("adiniz: ");
    ad=Convert.ToString(Console.ReadLine());
    Console.Write("soyadiniz: ");
    soyad=Convert.ToString(Console.ReadLine());
    Console.ReadLine();
    int dogru=0,yanlis=0,para=0;
    string s1,c1;
    Console.Write("soru1- cumhuriyet hangi yılda ilan edildi?");
    s1 = Convert.ToString(Console.ReadLine());
    Console.Write("a-1920\nb-1923\nc-1924\nd-1926\ncevabiniz: ");
    c1=Console.ReadLine();
    if(c1=="B") { 
    dogru+=1;
    para+=1000;
    Console.WriteLine("tebrikler"); }
    else { 
    yanlis+=1;
    Console.WriteLine("cevap yanlis"); } } } }
