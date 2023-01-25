using System;

namespace baklavadilimi {
    internal class Program {
    static void Main(string[] args) {
    int n;
    Console.Write("sayi: ");
    n=Convert.ToInt32(Console.ReadLine());
    for(int i = 0; i < n; i++) {
    for(int j = 0; j < (n-i); j++) {
    Console.Write(" "); }
    for(int k = 0; k < 2*i; k++) {
    Console.Write("*"); }
    Console.WriteLine(); }
    for(int i = 0; i < n; i++) {
    for(int j = 0; j < i; j++) {
    Console.Write(" "); }
    for(int k = 0; k < 2*(n-i); k++) {
    Console.Write("*"); }
    Console.WriteLine(); } } } }
