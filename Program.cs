using System;

namespace diziort{
    internal class Program {
    static void Main(string[] args) {
    int[] dizi=new int[20];
    int toplam=0;
    Random r = new Random();
    for (int i = 0; i < 10; i++) {
    dizi[i] = r.Next(0,10);
    toplam+=dizi[i];
    Console.Write(" "+dizi[i]); }
    int min=dizi[0],max=dizi[0];
    for(int i = 1; i < 10; i++) {
    if(dizi[i] < min) {
    min=dizi[i]; }
    if(dizi[i] > max) {
    max=dizi[i]; } }
    Console.WriteLine("\nart ort: "+(toplam/10));
    Console.WriteLine("min: "+min);
    Console.WriteLine("max: "+max); } } }
