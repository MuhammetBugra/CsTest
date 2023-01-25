using System;

namespace fahrenheit {
    internal class Program {
    static void Main(string[] args) {
    double f,c; int a;
    Console.Write("1-fc -- 2-cf 3-cikis seciniz:");
    a=Convert.ToInt32(Console.ReadLine());
    if(a==1) { Console.WriteLine("fahrenheit: ");
    f=Convert.ToDouble(Console.ReadLine());
    c=(f-32)/1.8;
    Console.Write("f:[{0}] to c[{1}]", f,c); }
    if(a==2) { Console.WriteLine("santigrat: ");
    c=Convert.ToDouble(Console.ReadLine());       
    f=c*1.8+32;
    Console.Write("c:[{0}] to f[{1}]", c,f); }
    if(a==3) {  } } } } 
