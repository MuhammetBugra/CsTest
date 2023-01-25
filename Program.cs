using System;

namespace asallik{
     internal class Program{
     static void Main(string[] args) {
     int n;
     Console.WriteLine("sayi giriniz: ");
     n=Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("sonuc: "+f(n));
     if(f(n)==true) {
     n=n+1;
     while(f(n)==false) {
     n++;
     f(n); } }
     Console.WriteLine("{0} girdiginiz sayidan sonraki ilk asal sayidir: ",n); }
     static bool f(int n) {
     int i,a=0;
     for(i=2;i<n;i++) {
     if(n%i==0) { 
     a++; } }
     if(a==0) {
     return true; }
     else { 
     return false; } } } }
