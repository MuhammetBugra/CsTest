using System;

namespace harfbulma {
    internal class Program {
    static void Main(string[] args) {
    string s= "BM102 Bilgisayar Programlama II Lab Uygulaması";
    Console.WriteLine("harf girin: ");
    s=s.ToLower();
    char c=Convert.ToChar(Console.ReadLine());
    int sayi=0;
    for(int i=0;i<s.Length;i++) {
    if(c==s[i]) {
    sayi ++; } }
    Console.WriteLine(s);
    Console.WriteLine("cumlede "+c+" harfinden "+sayi+" tane var."); } } } 
