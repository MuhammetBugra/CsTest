using System;

namespace indirim
{
    internal class Program {
    static void Main(string[] args) {
    double sayi,sayi1;
    Console.Write("Sayi: ");
    sayi=Convert.ToInt32(Console.ReadLine());
    Console.Write("Sayi 2: ");
    sayi1=Convert.ToInt32(Console.ReadLine());
    if((sayi+sayi1)>200) { 
    Console.WriteLine("sonuc: "+(sayi+(sayi1*0.75)));  }
    else { 
    Console.WriteLine("sonuc: "+(sayi+sayi1)); } } } }
