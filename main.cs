
using System;

class Program {
  public static void Main (string[] args) {
    int a, b, wybor;
    
    do {
      Console.Write("Podaj liczbe a: ");
      a = int.Parse(Console.ReadLine());
      Console.WriteLine("");
      Console.Write("Podaj liczbe b: ");
      b = int.Parse(Console.ReadLine());
      Console.WriteLine("");
      
      do {
        Console.WriteLine("Co chcesz zrobić?");
        Console.WriteLine("[0]Zamknij [1]Dodawanie [2]Odejmowanie [3]Mnożenie [4]Dzielenie");
        Console.Write("Wybór: ");
        wybor = int.Parse(Console.ReadLine());

        if (wybor != 0 && wybor != 1 && wybor != 2 && wybor != 3 && wybor != 4) {
          Console.WriteLine("Błędny wybór! Spróbuj jeszcze raz.");
        }
      } while (wybor != 0 && wybor != 1 && wybor != 2 && wybor != 3 && wybor != 4);

      if (wybor != 0) {
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
        }
        Console.WriteLine("\nNaciśnij Enter, aby kontynuować...");
        Console.ReadLine();
        Console.Clear();
      }
    } while (wybor != 0);
    
    Console.WriteLine("Dziękuję za skorzystanie z kalkulatora!");
  }
}
