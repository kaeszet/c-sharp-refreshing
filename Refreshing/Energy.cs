using System;

namespace Refreshing {
  public class Energy {
    private int b { get; set; }
    private int n { get; set; }

    public void Save(int b, int n) {
      this.b = b;
      this.n = n;
    }

    public void Load() {
      System.Console.WriteLine($"Stan p: {b}, stan k: {n}");
    }

    public void Count() {
      System.Console.WriteLine($"Zużycie {n-b}");
    }
  }
}