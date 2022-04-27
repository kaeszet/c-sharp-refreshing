using System;

namespace Refreshing
{
  public class Point
  {
    private int x { get; set; }
    private int y { get; set; }
    private Point[] points { get; set; }

    static Point()
    {

    }

    public Point(int x, int y)
    {
      this.x = x;
      this.y = y;
    }
    public static void AreInLine(Point[] tab)
    {
      bool x = false;
      bool y = false;
      for (int i = 1; i < tab.Length; i++)
      {
        if (tab[i].x != tab[i - 1].x) break;
        if (tab[i].x == tab[i - 1].x && tab.Length - 1 == i) x = true;
      }
      for (int i = 1; i < tab.Length; i++)
      {
        if (tab[i].y != tab[i - 1].y) break;
        if (tab[i].y == tab[i - 1].y && tab.Length - 1 == i) y = true;
      }
      System.Console.WriteLine(x || y);
    }
    public void Move(int x, int y)
    {
      this.x += x;
      this.y += y;
    }

    public int GetX()
    {
      return x;
    }

    public int GetY()
    {
      return y;
    }

    public void AddTable(Point[] tab)
    {
      points = tab;
    }
    public void Show()
    {
      System.Console.WriteLine($"x = {x}, y = {y}");
    }
  }

  public class Segment
  {
    public Point First { get; set; }
    public Point Sec { get; set; }

    public Segment(Point First, Point Sec)
    {
      this.First = First;
      this.Sec = Sec;
    }

    private double CalcDistance(Point First, Point Sec)
    {
      return Math.Sqrt(Math.Pow((double)(First.GetX() - Sec.GetX()), 2) + Math.Pow((double)(First.GetY() - Sec.GetY()), 2));
    }

    public void ShowDistance()
    {
      System.Console.WriteLine($"Odl: {CalcDistance(First, Sec)}");
    }
  }

  public class Cuboid {
    private double x { get; set; }
    private double y { get; set; }
    private double h { get; set; }

    private Cuboid [] cs {get; set;}



    public Cuboid(double x, double y, double h) 
    {
      this.x = x;
      this.y = y;
      this.h = h;
    }

    public void AddTable(Cuboid [] cs) {
      this.cs = cs;
    }

    public void Show() {
      System.Console.WriteLine("Objętość: " + CalcCuboid());
    }

    private double CalcCuboid() {
      return x * y * h;
    }

    public void CompareCuboids() {
      double c1 = cs[0].CalcCuboid();
      double c2 = cs[1].CalcCuboid();

      if (c1 < c2) Console.WriteLine($"Pierwszy jest o {c2-c1} mniejszy");
      else if (c1 == c2) Console.WriteLine("Oba równe");
      else Console.WriteLine($"Pierwszy jest o {c1-c2} większy");
    }
  }
}

