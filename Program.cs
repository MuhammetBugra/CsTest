using System;

namespace asalrecursive {
    internal class Program {
    static void Main(string[] args) {
    int n; int[] dizi=new int[3];
    n=Convert.ToInt32(Console.ReadLine());
    for(int i = 0; i < 3; i++) {
    dizi[i]=fonksiyon(n);
    Console.WriteLine(dizi[i]+" asaldir."); } }
    static int fonksiyon(int n) {
    int a=0;
    for(int i = 2; i < n; i++) {
    if(n%i== 0) {
    a=1; } }
    if(a==1) {
    return fonksiyon(n + 1); }
    else {
    return n; } } } }
