using System;

namespace fibonacci {
    internal class Program {
    static void Main(string[] args) {
    int a=0,b=1,c,n;
    Console.WriteLine("sayi: ");
    n=Convert.ToInt32(Console.ReadLine());
    Console.Write(a+" "+b);
    for(int i=0;i<n;i++) {
    c=a+b;
    a=b;
    b=c;
    Console.Write(" "+c); } } } }
