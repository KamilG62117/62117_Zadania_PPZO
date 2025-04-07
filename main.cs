
using System;

class Program {
  public static void Main (string[] args) {
    int a;
    int b;
    Console.Write("Podaj liczbe a: ");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    Console.Write("Podaj liczbe b: ");
    b = int.Parse(Console.ReadLine());
    
    Console.WriteLine($"\nSuma liczb {a} i {b} wynosi: {a + b}");
    Console.WriteLine($"Różnica liczb {a} i {b} wynosi: {a - b}");
    Console.WriteLine($"Iloczyn liczb {a} i {b} wynosi: {a * b}");
    
    if (b != 0) {
      Console.WriteLine($"Iloraz liczb {a} i {b} wynosi: {(double)a / b}");
    } else {
      Console.WriteLine("Nie można dzielić przez zero!");
    }
  }
}
