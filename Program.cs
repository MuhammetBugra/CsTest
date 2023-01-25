using System;

namespace dikdortgen {
    internal class Program {
    static void Main(string[] args) {
    int a,b;
    Console.Write("uzun: ");
    a=Convert.ToInt32(Console.ReadLine());
    Console.Write("kisa: ");
    b=Convert.ToInt32(Console.ReadLine());
    for(int i=0;i<a;i++) {
    for(int j=0;j<b;j++) {
    if(i==0 || j==0 || i==(a-1) || j==(b-1)) {
    Console.Write(" *"); }
    else {
    Console.Write("  "); } }
    Console.WriteLine(); } } } } 
