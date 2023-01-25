using System;
namespace getsetclass {
    class exponentor { 
    private int number;
    private int exponent; 
    public int Number { set { number = Number; } get { return number; } }
    public exponentor(int exponent) {
    this.exponent = exponent; }
    public void printexp() { 
    Console.WriteLine(Math.Pow(Number,exponent)); } }
    internal class Program {
    static void Main(string[] args) {
    int a;
    Console.Write("us: ");
    a=Convert.ToInt32(Console.ReadLine());
    exponentor exp=new exponentor(a);
    Console.Write("sayi: ");
    exp.Number = Convert.ToInt32(Console.ReadLine());
    exp.printexp(); } } }
