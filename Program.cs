using System;

namespace getset {
    internal class Program {
    static void Main(string[] args) {
    ogrenci ogr=new ogrenci();
    ogr.adi="bugra";
    ogr.soyadi="guler";
    ogr.alani="muhendislik";
    ogr.yasi=20;
    Console.WriteLine("adi: "+ogr.adi);
    Console.WriteLine("soyadi: "+ogr.soyadi);
    Console.WriteLine("alani: "+ogr.alani);
    Console.WriteLine("yasi: "+ogr.yasi); } } }
