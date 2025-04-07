
using System;

class Program {
  public static void Main (string[] args) {
    int wybor;
    double stopnie;
    do {
      Console.WriteLine("Wybierz rodzaj konwersji:");
      Console.WriteLine("[0]Zamknij");
      Console.WriteLine("[1]Ze stopni Celsjusza na Fahrenheita");
      Console.WriteLine("[2]Ze stopni Fahrenheita na Celsjusza");
      
      Console.Write("Wybór: ");
      wybor = int.Parse(Console.ReadLine());
      
      if (wybor == 1) {
        Console.WriteLine("Podaj stopnie Celsjusza:");
        stopnie = double.Parse(Console.ReadLine());
        Console.WriteLine("Stopnie Fahrenheita: " + (stopnie * 1.8 + 32));
      }
      else if (wybor == 2) {
        Console.WriteLine("Podaj stopnie Fahrenheita:");
        stopnie = double.Parse(Console.ReadLine());
        Console.WriteLine("Stopnie Celsjusza: " + ((stopnie - 32) / 1.8));
      }
      else if (wybor != 0) {
        Console.WriteLine("Zły wybór. Spróbuj ponownie.");
      }

      if (wybor != 0) {
        Console.WriteLine("");
        Console.WriteLine("Naciśnij Enter, aby wykonać następną konwersje...");
        Console.ReadLine();
        Console.Clear();
      }
    } while (wybor != 0);
    
    Console.WriteLine("Zamykanie programu...");
  }
}
