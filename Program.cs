using System;

namespace ikiboyutlu {
    internal class Program {
    static void Main(string[] args) {
    int a,b;
    Console.Write("sayi 1: ");
    a=Convert.ToInt32(Console.ReadLine());
    Console.Write("sayi 1: ");
    b=Convert.ToInt32(Console.ReadLine());
    double[,] dizi = new double[a, b];
    double[,] dizi1 = new double[a, b];
    for(int i = 0; i < a; i++) {
    for(int j = 0; j < b; j++) {
    Console.Write("[{0}] [{1}]: ",i,j);
    dizi[i,j]=Convert.ToInt32(Console.ReadLine()); } }
    Console.WriteLine("dizi 1");
    Console.WriteLine();
    dizioku(dizi);
    for(int i = 0; i < a; i++) {
    for(int j = 0; j < b; j++) {
    Console.Write("[{0}] [{1}]: ",i,j);
    dizi1[i,j]=Convert.ToInt32(Console.ReadLine()); } }
    Console.WriteLine("dizi 2");
    Console.WriteLine();
    dizioku(dizi1);
    dizitopla(dizi,dizi1);    }
    static void dizioku(double[,] dizi) {
    int a = dizi.GetLength(0);
    int b = dizi.GetLength(1);
    for(int i = 0; i < a; i++) {
    for(int j = 0; j < b; j++) {
    Console.Write(dizi[i,j]+" ");  }
    Console.WriteLine(); } }
    static void dizitopla(double[,] dizi,double[,] dizi1) { 
    int a = dizi.GetLength(0);
    int b = dizi.GetLength(1);
    double[,] dizi2 = new double[a,b];
    Console.WriteLine("dizi toplami");
    Console.WriteLine();
    for(int i = 0; i < a; i++) {
    for(int j = 0; j < b; j++) {
    dizi2[i,j]=dizi[i,j]+dizi1[i,j];
    Console.Write(dizi2[i,j]+" "); }
    Console.WriteLine(); } } } }
