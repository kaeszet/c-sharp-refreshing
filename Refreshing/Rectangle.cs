using System;
using System.Collections.Generic;

namespace Refreshing
{
  public class Rectangle
  {
    private double length { get; set; }
    private double width { get; set; }
    private Rectangle[] rects { get; set; }
    //private List<Rectangle> tabOfRect {get; set;}

    public Rectangle(double length, double width)
    {
      this.length = length;
      this.width = width;
    }

    public Rectangle(Rectangle[] rects)
    {
      this.rects = rects;
    }

    private Rectangle()
    {
      this.length = 0;
      this.width = 0;
    }

    static Rectangle()
    {

    }

    private double area()
    {
      return length * width;
    }

    private double circ()
    {
      return 2 * length + 2 * width;
    }

    public static Rectangle showBiggest(Rectangle[] rects)
    {
      double a = 0;
      Rectangle r = new Rectangle();
      for (int i = 0; i < rects.Length; i++)
      {
        double temp = rects[i].area();
        if (temp > a)
        {
          a = temp;
          r = rects[i];
        }
      }
      return r;
    }

    public void show()
    {
      if (area() != 0 && circ() != 0) System.Console.WriteLine($"Pole: {area()}, obwód: {circ()}");
      if (rects != null)
      {
        showfromTab();
      }

    }

    private void showfromTab()
    {
      for (int i = 0; i < rects.Length; i++)
      {
        length = rects[i].length;
        width = rects[i].width;
        System.Console.WriteLine($"Pole: {area()}, obwód: {circ()}");
      }
    }


    /*public Rectangle [] add (double length, double width) {
      Rectangle rect = new Rectangle(length, width);
      tabOfRect.Add(rect);
    }*/

  }

  struct RectangleStruct
  {
    double length;
    double width;
    RectangleStruct[] rects;

    public RectangleStruct(double l, double w)
    {
      length = l;
      width = w;
      rects = new RectangleStruct[] { };
    }

    public RectangleStruct(RectangleStruct [] rcs) {
      length = 0;
      width = 0;
      rects = rcs;
    }

    private double area()
    {
      return length * width;
    }

    private double circ()
    {
      return 2 * length + 2 * width;
    }

    public void show()
    {
      if (area() != 0 && circ() != 0) System.Console.WriteLine($"Pole: {area()}, obwód: {circ()}");
      if (rects != null)
      {
        if (rects.Length > 0)
        {
          showfromTab();
        }
        
      }

    }

    private void showfromTab()
    {
      for (int i = 0; i < rects.Length; i++)
      {
        length = rects[i].length;
        width = rects[i].width;
        System.Console.WriteLine($"Pole: {area()}, obwód: {circ()}");
      }
    }
  }
}