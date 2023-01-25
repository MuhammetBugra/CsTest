using System;

namespace bool1 {
    internal class Program {
    static void Main(string[] args) {
    int sifre;
    Console.Write("sifre:");
    sifre = Convert.ToInt32(Console.ReadLine());
    bool durum=sifre==1234;
    Console.WriteLine("sifre dogru mu: {0}",durum); } } }
