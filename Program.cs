using System;

namespace enbuyuk {
    internal class Program {
    static void Main(string[] args) {
    int[] n=new int[5]; 
    for(int i = 0; i < 5; i++) {
    Console.Write("sayi: ");
    n[i]=Convert.ToInt32(Console.ReadLine()); }
    int max=n[0];
    for(int i = 0; i < 5; i++) {
    if(n[i]>max) {
    max=n[i]; } }
    Console.WriteLine("max: "+max); } } }
