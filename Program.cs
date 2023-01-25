using System;

namespace dizisiralama
{
    internal class Program {
    static void Main(string[] args) {
    int[] dizi=new int[5];
    for(int i=0; i<5; i++) {
    Console.Write("sayi: ");
    dizi[i]=Convert.ToInt32(Console.ReadLine()); }
    Array.Sort(dizi);
    foreach(int i in dizi) {
    Console.Write(i+" "); }
    Console.WriteLine();
    Console.WriteLine("min: "+dizi[0]);
    Console.WriteLine("max: "+dizi[4]);
    Console.WriteLine("boyut: "+dizi.Length);
    Array.Reverse(dizi);
    foreach(int i in dizi) {
    Console.Write(i+" "); }
} } }
