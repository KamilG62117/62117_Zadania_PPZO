
using System;

class Program {
  public static void Main (string[] args) {
    int a;
    int b;
    int wybor;
    Console.Write("Podaj liczbe a: ");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    Console.Write("Podaj liczbe b: ");
    b = int.Parse(Console.ReadLine());

    Console.WriteLine("Co chcesz zrobić?");
    Console.WriteLine("[1]Dodawanie [2]Odejmowanie [3]Mnożenie [4]Dzielenie");
    wybor = int.Parse(Console.ReadLine());
    
    switch (wybor) {
      case 1:
        Console.WriteLine("Wynik dodawania: " + (a + b));
        break;
      case 2:
        Console.WriteLine("Wynik odejmowania: " + (a - b));
        break;
      case 3:
        Console.WriteLine("Wynik mnożenia: " + (a * b));
        break;
      case 4:
        if (b != 0) {
          Console.WriteLine("Wynik dzielenia: " + ((double)a / b));
        } else {
          Console.WriteLine("Nie można dzielić przez zero!");
        }
        break;
      default: 
        Console.WriteLine("Podano zły wybór");
        break;
    }
  }
}
