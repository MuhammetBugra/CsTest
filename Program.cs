using System;
using System.Text.RegularExpressions;

namespace altstring {
    public class RegularExpressionsExample {
    static void Main(string[] args) {
    string pattern=@"\w+";
    Regex rgx = new Regex(pattern);
    string input=Console.ReadLine();
    string[] str1=rgx.Split(input);
    foreach(string s in str1){
    Console.Write(s);
    Console.WriteLine(); }
} } }
