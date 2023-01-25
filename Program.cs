using System;

namespace indexofdegeri {
    internal class Program {
    static void Main(string[] args) {
    string metin;
    metin =Console.ReadLine();
    int no=metin.IndexOf(" ");
    Console.WriteLine(metin.Substring(0,no)); } } }
