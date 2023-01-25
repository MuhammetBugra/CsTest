using System;

namespace foreach1 {
    internal class Program {
    static void Main(string[] args) {
    int[] sayilar = {1,2,3,4,5};
    int toplam=0;
    foreach (int i in sayilar) {
    toplam+=i; }
    Console.Write("sonuc: "+toplam); } } }
