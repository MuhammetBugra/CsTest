using System;

namespace cokbicimlilik {
    class insan { 
    public virtual void selamver() {
    Console.BackgroundColor=ConsoleColor.Blue;
    Console.Title="ornek";
    Console.WriteLine("merhaba"); } }
    class Turk:insan {
    public override void selamver() {
    Console.WriteLine("esenlikler"); } }
    class fransa:insan {
    public override void selamver() {
     Console.BackgroundColor=ConsoleColor.Red;
    Console.WriteLine("bonjour"); } }
    class Program {
    static void Main(string[] args) {
    Turk trk=new Turk();
    trk.selamver();
    fransa fr=new fransa();
    fr.selamver();
} } }
