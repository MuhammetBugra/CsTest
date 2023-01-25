using System;

namespace basamakayirma {
    internal class Program {
    static void Main(string[] args) {
    int n,birler,onlar,yuzler;
    Console.WriteLine("Sayi Giriniz: ");
    n=Convert.ToInt32(Console.ReadLine());
    birler=n%10;
    onlar=(n/10)%10;
    yuzler=(n/100)%10;
    Console.WriteLine("birler:{0} onlar:{1} yuzler:{2} ",birler,onlar,yuzler); } } }
