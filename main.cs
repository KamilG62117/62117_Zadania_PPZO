
using System;

class Program {
  public static void Main (string[] args) {
    int ilosc;
    int[] tab;  
    double srednia;
    int suma=0;
    
    Console.Write("Podaj ilosc ocen: ");
    ilosc = int.Parse(Console.ReadLine());
    if(ilosc==0){
      Console.WriteLine("Brak ocen do obliczenia średniej");
    }
    else{
      tab = new int[ilosc];  
      Console.WriteLine("");
      Console.WriteLine("Podaj oceny:");
      for(int i=0; i<ilosc; i++){
        while(true){
          Console.Write($"{i+1}. ");  
          tab[i] = int.Parse(Console.ReadLine());
          if(tab[i]>=1 && tab[i]<=6){
            suma += tab[i];
            break;
          }
          else{
            Console.WriteLine("");
            Console.WriteLine("Podano złą ocenę, spróbuj ponownie podać ocenę z zakresu 1-6");
          }
        }
      }
        srednia = (double)suma / ilosc;
        Console.WriteLine("");
        Console.WriteLine($"Średnia ocen: {srednia}");
        Console.WriteLine("");
        if(srednia>=3.0){
          Console.WriteLine("Uczeń zdał, ponieważ średnia ocen wynosi minimum 3.0");
        }
      else{
        Console.WriteLine("Uczeń nie zdał, ponieważ średnia ocen jest mniejsza niż 3.0");
      }
      }
  }
}
