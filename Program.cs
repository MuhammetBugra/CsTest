using System;

namespace dersgecme {
    internal class Program {
    static void Main(string[] args) {
    int n,a=0,b=0; double ort=0,not,toplam=0;
    Console.Write("sayi: ");
    n=Convert.ToInt32(Console.ReadLine());
    int[] ogrvize=new int[n];
    int[] ogrfinal=new int[n];
    for(int i=0; i<n; i++) {
    Console.Write("ogrenci {0} vize notu: ",i+1);
    ogrvize[i]=Convert.ToInt32(Console.ReadLine());
    Console.Write("ogrenci {0} final notu: ",i+1);
    ogrfinal[i]=Convert.ToInt32(Console.ReadLine()); }
    for(int i=0; i<n; i++) {
    Console.Write("ogrenci {0} vize notu: {1} ",i+1,ogrvize[i]);
    Console.Write("ogrenci {0} final notu: {1} ",i+1,ogrfinal[i]);
    not= (ogrvize[i] * 0.4) + (ogrfinal[i] * 0.6);
    Console.Write("basari notu: "+not+" ");
    if((ogrvize[i]*0.4)+(ogrfinal[i]*0.6)<60) {
    Console.WriteLine("Ogrenci kaldi."); a++; }
    else {
    Console.WriteLine("Ogrenci gecti."); b++; }
    toplam+= (ogrvize[i] * 0.4) + (ogrfinal[i] * 0.6); }
    ort=toplam/n;
    Console.WriteLine("sinif ort: "+ort);
    Console.WriteLine("gecen: "+b);
    Console.WriteLine("kalan: "+a); } } }
