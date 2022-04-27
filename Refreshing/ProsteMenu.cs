using System;

namespace Refreshing
{
  static class ProsteMenu
  {
    public static void Start()
    {
      Console.Title = "Menu";

      do
      {
        Console.Clear();
        System.Console.WriteLine("Menu");
        System.Console.WriteLine("1 - Kalkulator BMI");
        System.Console.WriteLine("2 - Fibonacci");
        System.Console.WriteLine("3 - Kalkulator Energii Elektr.");
        System.Console.WriteLine("Esc - Koniec");

        ConsoleKeyInfo key = Console.ReadKey();
        switch (key.Key)
        {
          case ConsoleKey.D1:
            Console.Clear();
            Program.bmiextended();
            Console.ReadKey();
            break;
          case ConsoleKey.D2:
            Console.Clear();
            Console.Write("Króry el. ciągu?: ");
            int x = int.Parse(Console.ReadLine());
            Program.Fibo(x);
            Console.ReadKey();
            break;
          case ConsoleKey.D3:
            Console.Clear();
            Energy e = new Energy();
            Console.Write("Pierwotny odcz.: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Aktualny odcz: ");
            int c = int.Parse(Console.ReadLine());
            e.Save(p, c);
            e.Load();
            e.Count();
            Console.ReadKey();
            break;
          case ConsoleKey.Escape:
            Environment.Exit(0);
            break;
          default:
            break;
        }
      } while (true);
    }
  }
}