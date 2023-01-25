using System;

namespace faktoriyel {
    internal class Program {
    static void Main(string[] args) {
    int n,fak=1;
    Console.Write("sayi: ");
    n=Convert.ToInt32(Console.ReadLine());
    while(n>1) { 
    fak=fak*n;
    n--; }
    Console.WriteLine("sonuc: "+fak); } } }
