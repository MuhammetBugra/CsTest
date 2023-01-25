using System;

namespace carpimtablosu {
    internal class Program {
    static void Main(string[] args) {
    int i,j;
    for(i=1;i<10;i++) { 
    for(j=1;j<10;j++) {
    Console.Write("{0}*{1}=",i,j);
    Console.Write((i*j)+" "); }
    Console.WriteLine(); } } } }
