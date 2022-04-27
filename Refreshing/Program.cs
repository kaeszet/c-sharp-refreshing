using System;

namespace Refreshing
{

  class Program
  {

    public static void CelsiusToFarenheit()
    {
      double cels, far;
      Console.Write("Podaj *C: ");
      cels = double.Parse(Console.ReadLine());
      far = 9d / 5 * cels + 32;

      Console.WriteLine($"*F: {far}");
    }

    public static void Delta()
    {
      double a, b, c, delta;
      Console.Write("Podaj A: ");
      a = double.Parse(Console.ReadLine());
      Console.Write("Podaj B: ");
      b = double.Parse(Console.ReadLine());
      Console.Write("Podaj C: ");
      c = double.Parse(Console.ReadLine());
      delta = Math.Pow(b, 2) - 4 * a * c;

      Console.WriteLine($"Delta: {delta}");

    }

    public static void bmi()
    {
      double m, kg;
      Console.Write("Podaj wzrost: ");
      m = double.Parse(Console.ReadLine());
      Console.Write("Podaj wagę: ");
      kg = double.Parse(Console.ReadLine());

      Console.WriteLine($"m: {kg / (m * m)}");
    }

    public static void isYearLeap()
    {
      int y;
      Console.Write("Podaj rok: ");
      y = int.Parse(Console.ReadLine());
      bool isLeap = (y % 4 == 0 && (y % 100 != 0 || y % 400 == 0));
      Console.WriteLine(isLeap);
    }

    public static void isDivider()
    {
      int x, y;
      Console.Write("Podaj x: ");
      x = int.Parse(Console.ReadLine());
      Console.Write("Podaj y: ");
      y = int.Parse(Console.ReadLine());
      string ans = (x % y == 0) ? $"{y} jest dzielnikiem {x}" : $"{y} NIE jest dzielnikiem {x}";
      Console.WriteLine(ans);
    }

    public static void HigherNum()
    {
      int x, y, z;
      Console.Write("Podaj x: ");
      x = int.Parse(Console.ReadLine());
      Console.Write("Podaj y: ");
      y = int.Parse(Console.ReadLine());
      Console.Write("Podaj z: ");
      z = int.Parse(Console.ReadLine());
      int ans = (x < y) ? (y < z) ? z : y : (x < z) ? z : x;
      Console.WriteLine(ans);
    }

    public static void simpleCalc()
    {
      double x, y;
      char a;
      Console.Write("Podaj x: ");
      x = double.Parse(Console.ReadLine());
      Console.Write("Podaj y: ");
      y = double.Parse(Console.ReadLine());
      Console.Write("Podaj znak: ");
      a = char.Parse(Console.ReadLine());

      switch (a)
      {
        case '+':
          Console.WriteLine(x + y);
          break;
        case '-':
          Console.WriteLine(x - y);
          break;
        case '*':
          Console.WriteLine(x * y);
          break;
        case '/':
          Console.WriteLine(x / y);
          break;
        default:
          Console.WriteLine("Zły znak");
          break;
      }
    }

    public static void howManySquares()
    {
      double a, b, c, delta;
      Console.Write("Podaj A: ");
      a = double.Parse(Console.ReadLine());
      Console.Write("Podaj B: ");
      b = double.Parse(Console.ReadLine());
      Console.Write("Podaj C: ");
      c = double.Parse(Console.ReadLine());
      delta = Math.Pow(b, 2) - 4 * a * c;
      if (delta > 0)
      {
        Console.WriteLine($"Delta: {delta}. Równanie ma 2 pierwistki");
      }
      else if (delta == 0)
      {
        Console.WriteLine($"Delta: {delta}. Równanie ma 1 pierwiastek");
      }
      else
      {
        Console.WriteLine($"Delta: {delta}. Równanie ma nie ma pierwistków");
      }
    }
    public static void bmiextended()
    {
      double m, kg, bmi;
      Console.Write("Podaj wzrost: ");
      m = double.Parse(Console.ReadLine());
      Console.Write("Podaj wagę: ");
      kg = double.Parse(Console.ReadLine());
      bmi = kg / (m * m);

      switch (bmi)
      {
        case < 16.0:
          Console.WriteLine($"bmi: {bmi} - wygłodzenie");
          break;
        case >= 16.0 and < 16.99:
          Console.WriteLine($"bmi: {bmi} - wychudzenie");
          break;
        case >= 17.0 and < 18.49:
          Console.WriteLine($"bmi: {bmi} - niedowaga");
          break;
        case >= 18.5 and < 24.99:
          Console.WriteLine($"bmi: {bmi} - porządana masa ciała");
          break;
        case >= 25.0 and < 29.99:
          Console.WriteLine($"bmi: {bmi} - nadwaga");
          break;
        case >= 30.0 and < 34.99:
          Console.WriteLine($"bmi: {bmi} - otyłość I stopnia");
          break;
        case >= 35.0 and < 39.99:
          Console.WriteLine($"bmi: {bmi} - otyłość II stopnia");
          break;
        case >= 40.0:
          Console.WriteLine($"bmi: {bmi} - otyłość III stopnia");
          break;
        default:
          Console.WriteLine($"Coś poszło nie tak, ale co?");
          break;
      }
    }
    public static void Scholarship()
    {
      double m;
      Console.Write("Podaj średnią: ");
      m = double.Parse(Console.ReadLine());
      switch (m)
      {
        case < 4.0:
          Console.WriteLine($"Średnia: {m} - 0 zł");
          break;
        case >= 4.0 and < 4.8:
          Console.WriteLine($"Średnia: {m} - 350zł");
          break;
        case >= 4.8:
          Console.WriteLine($"Średnia: {m} - 550 zł");
          break;
        default:
          Console.WriteLine($"Coś poszło nie tak, ale co?");
          break;
      }
    }
    public static void FiguresStars()
    {
      string w;
      int x;
      Console.Write("Wariant: ");
      w = Console.ReadLine();
      Console.Write("Ile wierszy? ");
      x = int.Parse(Console.ReadLine());

      switch (w)
      {
        case "a":
          for (int i = 0; i < x; i++)
          {
            for (int j = 0; j <= i; j++)
            {
              Console.Write("*");
            }
            Console.WriteLine();
          }
          break;
        case "b":
          for (int i = 0; i < x; i++)
          {
            for (int j = x - i; j > 0; j--)
            {
              Console.Write("*");
            }
            Console.WriteLine();
          }
          break;
        case "c":
          for (int i = 0; i < x; i++)
          {
            for (int j = 0; j < x; j++)
            {
              if (j + 1 >= x - i) Console.Write("*");
              else Console.Write(" ");
            }
            Console.WriteLine();
          }
          break;
        case "d":
          for (int i = 0; i < x; i++)
          {
            for (int j = 0; j < 4; j++)
            {
              if (i == 0 || i == x - 1) Console.Write("*");
              else
              {
                if (j == 0 || j == 3)
                {
                  Console.Write("*");
                }
                else
                {
                  Console.Write(" ");
                }
              }
            }
            Console.WriteLine();
          }
          break;

        default:
          break;
      }
    }
    public static void Strong()
    {
      int s, ans;
      Console.Write("Podaj liczbę: ");
      s = int.Parse(Console.ReadLine());
      ans = 1;
      for (int i = 1; i <= s; i++)
      {
        ans *= i;
      }
      Console.WriteLine(ans);
    }

    public static void countToHundread()
    {
      int count = 0;
      int ans = 1;

      do
      {
        ans += count + 2;
        count++;

      } while (ans <= 100);

      Console.WriteLine(count);
    }

    public static void addTillZero()
    {
      int x, ans = 0;

      do
      {
        Console.Write("Podaj liczbę: ");
        x = int.Parse(Console.ReadLine());
        ans += x;

      } while (x != 0);

      Console.WriteLine(ans);
    }

    public static void SeriesSum()
    {
      int x, ans = 0;
      Console.Write("Podaj x: ");
      x = int.Parse(Console.ReadLine());
      for (int i = 1; i <= x; i++)
      {
        if (i % 2 != 0) ans += i;
        else ans -= i;
      }

      Console.WriteLine($"W({x})={ans}");
    }

    public static void PerfectNumber()
    {
      long[] PerfNum = { 6, 28, 496, 8128, 33550336, 8589869056, 137438691328, 2305843008139952128 };
      long x;
      Console.Write("Podaj x: ");
      x = long.Parse(Console.ReadLine());
      foreach (var item in PerfNum)
      {
        if (x >= item) Console.WriteLine(item);
        else break;
      }
    }

    public static void Coins()
    {
      int count = 0;
      for (int i = 0; i <= 10; i++)
      {
        for (int j = 0; j <= 5; j++)
        {
          for (int k = 0; k <= 2; k++)
          {
            if (i + j * 2 + k * 5 == 10)
            {
              Console.WriteLine($"1zł x {i}, 2zł x {j}, 5zł x {k}");
              count++;
            }
          }
        }
      }
      Console.WriteLine($"Kombinacji: {count}");
    }

    public static void UsersArray()
    {
      int x;
      Console.Write("Podaj rozmiar tablicy: ");
      x = int.Parse(Console.ReadLine());
      int[] tab = new int[x];
      for (int i = 0; i < tab.Length; i++)
      {
        Console.Write($"Wpisz liczbę nr {i + 1}: ");
        tab[i] = int.Parse(Console.ReadLine());
      }
      foreach (var item in tab)
      {
        Console.Write(item + " ");
      }
    }
    public static void copyPositiveElements()
    {
      int[] tab1 = { 3, 5, 4, 7, 10, -2, -7, 14, 0, -1 };
      int[] tab2 = new int[10];
      for (int i = 0; i < tab1.Length; i++)
      {
        if (tab1[i] >= 0) tab2[i] = tab1[i];
      }
      foreach (var item in tab2)
      {
        Console.Write(item + " ");
      }
    }
    public static void UsersArrayInfo()
    {
      int x, min = 0, max = 0, imin = 0, imax = 0, pos = 0;
      double avg = 0;
      Console.Write("Podaj rozmiar tablicy: ");
      x = int.Parse(Console.ReadLine());
      int[] tab = new int[x];
      for (int i = 0; i < tab.Length; i++)
      {
        Console.Write($"Wpisz liczbę nr {i + 1}: ");
        tab[i] = int.Parse(Console.ReadLine());
        avg += tab[i];
        if (tab[i] > 0) pos++;
        if (i == 0)
        {
          min = tab[i];
          max = tab[i];
        }
        else
        {
          if (tab[i] < min)
          {
            min = tab[i];
            imin = i + 1;
          }
          if (tab[i] > max)
          {
            max = tab[i];
            imax = i + 1;
          }
        }


      }
      System.Console.WriteLine($"Najwyższa wartość to {max} w pozycji {imax}");
      System.Console.WriteLine($"Najniższa wartość to {min} w pozycji {imin}");
      System.Console.WriteLine($"Średnia to {(double)avg / tab.Length}");
      System.Console.WriteLine($"Dodatnich elementów: {pos}");

    }

    public static void PrimeNums()
    {
      int[] tab = new int[100];
      Random r = new Random();
      int count = 0;
      for (int i = 0; i < tab.Length; i++)
      {
        tab[i] = r.Next(1, 10000);
      }

      foreach (int x in tab)
      {
        if (!isDivisible(x))
        {
          count++;
          Console.Write($"{x} ");
        }
      }

    }

    public static bool isDivisible(int x)
    {
      if (x == 0 || x == 1) return false;
      for (int i = 2; i <= x / 2; i++)
      {
        if (x % i == 0)
        {
          return true;
        }
      }
      return false;
    }

    public static void PushedArray()
    {
      int x;
      Random r = new Random();
      Console.Write("Podaj rozmiar tablicy: ");
      x = int.Parse(Console.ReadLine());
      int[] tab = new int[x];
      int[] tab2 = new int[x];
      for (int i = 0; i < tab.Length; i++)
      {
        tab[i] = r.Next(1, 100);
      }
      for (int i = 0; i < tab.Length; i++)
      {
        if (i == tab.Length - 1) tab2[0] = tab[i];
        else tab2[i + 1] = tab[i];
      }

      foreach (var a in tab)
      {
        Console.Write($"{a} ");
      }
      Console.WriteLine();
      foreach (var a in tab2)
      {
        Console.Write($"{a} ");
      }

    }
    public static void TwoDimArrayA()
    {
      int sum = 0;
      int[,] tab = new int[,] { { 1, 4, 8, 12, 7 }, { 7, 8, 19, 1, 11 }, { 13, 21, 31, 61, 14 }, { 8, 12, 21, 15, 15 }, { 21, 1, 61, 16, 14 } };
      for (int i = 0; i < tab.GetLength(0); i++)
      {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
          if (i == j) sum += tab[i, j];
          Console.Write(tab[i, j] + " ");
        }
        Console.WriteLine();
      }
      Console.WriteLine($"Suma = {sum}");
    }
    public static void SumOfMatrix()
    {
      int[,] m1 = new int[2, 3] { { 3, 6, 5 }, { 6, 0, 9 } };
      int[,] m2 = new int[2, 3] { { 1, 9, 2 }, { 0, 7, 8 } };
      int[,] mnew = m1;

      for (int i = 0; i < mnew.GetLength(0); i++)
      {
        for (int j = 0; j < mnew.GetLength(1); j++)
        {
          mnew[i, j] += m2[i, j];
        }
      }

      for (int i = 0; i < mnew.GetLength(0); i++)
      {
        for (int j = 0; j < mnew.GetLength(1); j++)
        {
          Console.Write(mnew[i, j] + " ");
        }
        System.Console.WriteLine();
      }


    }
    public static void DaysOfWeek()
    {
      string[,] dow = new string[7, 3];
      dow[0, 0] = "poniedziałek";
      dow[1, 0] = "wtorek";
      dow[2, 0] = "środa";
      dow[3, 0] = "czwartek";
      dow[4, 0] = "piątek";
      dow[5, 0] = "sobota";
      dow[6, 0] = "niedziela";
      dow[0, 1] = "monday";
      dow[1, 1] = "tuesday";
      dow[2, 1] = "wendesday";
      dow[3, 1] = "thursday";
      dow[4, 1] = "friday";
      dow[5, 1] = "saturday";
      dow[6, 1] = "sunday";
      dow[0, 2] = "montag";
      dow[1, 2] = "dienstag";
      dow[2, 2] = "mittwoch";
      dow[3, 2] = "donnerstag";
      dow[4, 2] = "freitag";
      dow[5, 2] = "samstag";
      dow[6, 2] = "sonntag";

      for (int i = 0; i < dow.GetLength(0); i++)
      {
        for (int j = 0; j < dow.GetLength(1); j++)
        {
          Console.Write(dow[i, j] + " ");
        }
        System.Console.WriteLine();
      }
    }

    public static void HowManyWords()
    {
      string a;
      System.Console.Write("Podaj zdanie: ");
      a = Console.ReadLine();
      string[] atab = a.Split(' ');
      System.Console.WriteLine(atab.Length);
    }

    public static void WhichMounth()
    {
      string a;
      System.Console.Write("Podaj date: ");
      a = Console.ReadLine();
      DateTime d = DateTime.Parse(a);
      switch (d.Month)
      {
        case 1:
          System.Console.WriteLine("styczeń");
          break;
        case 2:
          System.Console.WriteLine("luty");
          break;
        case 3:
          System.Console.WriteLine("marzec");
          break;
        case 4:
          System.Console.WriteLine("kwiecien");
          break;
        case 5:
          System.Console.WriteLine("maj");
          break;
        case 6:
          System.Console.WriteLine("czerwiec");
          break;
        case 7:
          System.Console.WriteLine("lipiec");
          break;
        case 8:
          System.Console.WriteLine("sierpien");
          break;
        case 9:
          System.Console.WriteLine("wrzesien");
          break;
        case 10:
          System.Console.WriteLine("pazdziernik");
          break;
        case 11:
          System.Console.WriteLine("listopad");
          break;
        case 12:
          System.Console.WriteLine("grudzien");
          break;
        default:
          break;
      }

    }
    public static void LetterCount()
    {
      string letters = "aąbcćdeęfghijklłmnńoóprsśtuwyz";
      char[] lettersAsCharArray = letters.ToCharArray();
      string a;
      int count;
      System.Console.Write("Podaj wyraz: ");
      a = Console.ReadLine();
      char[] c = a.ToCharArray();
      for (int i = 0; i < lettersAsCharArray.Length; i++)
      {
        count = 0;
        for (int j = 0; j < c.Length; j++)
        {
          if (c[j] == lettersAsCharArray[i]) count++;
          if (count > 0 && j == c.Length - 1) System.Console.WriteLine($"{lettersAsCharArray[i]} - {count}");

        }

      }
    }
    public static void textStats()
    {

      string text = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
    "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
    "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
    "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
    "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";

      System.Console.WriteLine(text);
      string[] textSplit = text.Trim(' ', ',', '.').Split("\n");

      for (int i = 0; i < textSplit.Length; i++)
      {
        System.Console.WriteLine($"Wiersz {i + 1} ma {textSplit[i].Length} znaków.");
      }
    }

    public static void repeatsCounter()
    {
      int count = 0;
      string text = "Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek";

      string[] textArray = text.Split();
      for (int i = 0; i < textArray.Length; i++)
      {
        for (int j = 0; j < textArray.Length; j++)
        {
          if (textArray[i] == "") break;
          if (textArray[i] == textArray[j]) count++;
          if (textArray[i] == textArray[j] && count > 1) textArray[j] = "";
        }
        if (count > 1) System.Console.WriteLine($"{textArray[i]} - {count} razy");
        count = 0;
      }
    }
    public static void expDate()
    {
      int dt = DateTime.Now.Year;

      string[] tmp = new string[2];
      string[] ids = { "KOMG-2002", "BH-2010", "OWG-1998", "PLN-2013", "WSEI-2017" };
      int[] years = new int[ids.Length];
      for (int i = 0; i < ids.Length; i++)
      {
        tmp = ids[i].Split('-');
        years[i] = int.Parse(tmp[1]);
      }

      foreach (var item in years)
      {
        System.Console.WriteLine(dt - item);
      }
    }
    public static void gaderypoluki()
    {
      string key, word;
      string enc = String.Empty;
      int idx;
      System.Console.Write("Podaj klucz szyfrujący: ");
      key = Console.ReadLine();
      System.Console.Write("Podaj słowo: ");
      word = Console.ReadLine();
      for (int i = 0; i < word.Length; i++)
      {
        idx = key.IndexOf(word[i]);
        if (idx == -1) enc += word[i];
        else if (idx % 2 != 0)
        {
          enc += key[idx - 1];
        }
        else
        {
          enc += key[idx + 1];
        }
      }
      Console.WriteLine(enc);
    }

    public static double FtoC(double f)
    {
      return (f - 32) * 5d / 9;
    }

    public static bool isInRange(int a, int b, int x)
    {
      return (x < b && x > a);
    }

    public static void wekMove(ref int a, ref int b, int wekA, int wekB)
    {
      a += wekA;
      b += wekB;
    }

    public static int[] tabv1(int[] tab, int multi)
    {
      int[] tabnew = new int[tab.Length];
      for (int i = 0; i < tab.Length; i++)
      {
        tabnew[i] = tab[i] * multi;
      }
      return tabnew;
    }

    public static string[] tabv1(string[] tab, int multi)
    {
      string[] tabnew = new string[tab.Length];
      for (int i = 0; i < tab.Length; i++)
      {
        tabnew[i] = tab[i] + tab[i];
      }
      return tabnew;

    }

    public static void tabv2(ref int[] tab, int multi)
    {
      for (int i = 0; i < tab.Length; i++)
      {
        tab[i] *= multi;
      }
    }

    public static void drawRect(int l, int w, char z)
    {
      for (int i = 0; i < w; i++)
      {
        for (int j = 0; j < l; j++)
        {
          Console.Write(z);
        }
        Console.WriteLine();
      }

      for (int i = 0; i < l; i++)
      {
        for (int j = 0; j < w; j++)
        {
          Console.Write(z);
        }
        Console.WriteLine();
      }
    }

    public static int NumSeq(int x, int n)
    {
      int w = 0;
      for (int i = 0; i < n; i++)
      {
        w += (x + i + 1);
      }
      return w;
    }

    public static int sumDigit(int x) {
      int sum = 0;
      char [] a = x.ToString().ToCharArray();
      for (int i = 0; i < a.Length; i++)
      {
        sum += int.Parse(a[i].ToString());
      }
      return sum;

    }

    public static void Fibo (int n) {
      if (n==0 || n==1) {
        Console.WriteLine(n);
        return;
      } 
      int temp;
      int f1 = 0;
      int f2 = 1;
      for (int i = 2; i <= n+1; i++)
      {
        temp = f1 + f2;
        f2 = f1;
        f1 = temp;
      }
      Console.WriteLine(f1);
    }

    public static int FiboReq (int n) {
     if (n==0 || n==1) return n;
     return FiboReq(n-1)+FiboReq(n-2);
    }

    static int Oblicz(int n) 
    { 
       if (n <= 1) return (1); 
       else return (n + Oblicz(n - 1)); 
    } 



    static void Main(string[] args)
    {
      Console.WriteLine("--BEGIN--");

      CelsiusToFarenheit();
      Delta();
      bmi();
      isYearLeap();
      isDivider();
      HigherNum();
      howManySquares();
      bmiextended();
      Scholarship();
      FiguresStars();
      Strong();
      countToHundread();
      addTillZero();
      SeriesSum();
      PerfectNumber();
      Coins();
      UsersArray();
      copyPositiveElements();
      UsersArrayInfo();
      PrimeNums();
      PushedArray();
      TwoDimArrayA();
      SumOfMatrix();
      DaysOfWeek();
      HowManyWords();
      WhichMounth();
      LetterCount();
      textStats();
      repeatsCounter();
      expDate();
      gaderypoluki();

      double temp = 20.0;
      Console.WriteLine(FtoC(temp));

      int a = 4;
      int b = 10;
      int x = 12;
      Console.WriteLine(isInRange(a,b,x));

      int a1, b1;
      Console.Write("Podaj A: ");
      a1 = int.Parse(Console.ReadLine());
      Console.Write("Podaj B: ");
      b1 = int.Parse(Console.ReadLine());
      wekMove(ref a1, ref b1, 3, 2);
      System.Console.WriteLine($"{a1}, {b1}");

      int [] tab = {4, 8, 9, -3, 0};
      int m = 3;
      int [] tab2 = tabv1(tab, m);
      tabv2(ref tab, m);
      for (int i = 0; i < tab.Length; i++)
       {
       Console.WriteLine($"{tab[i]}, {tab2[i]}");
       }

      int x1 = 6;
      int y1 = 3;
      char z1 = '*';
      drawRect(x1,y1,z1);

      string [] tab1 = {"ala", "kot", "dom"};
      int m1 = 2;
      string [] tab21 = tabv1(tab1, m1);
      foreach (var item in tab21)
      {
        Console.WriteLine(item);
      }

      int x2, n;
      Console.Write("Podaj x:");
      x2 = int.Parse(Console.ReadLine());
      Console.Write("Podaj n:");
      n = int.Parse(Console.ReadLine());
      System.Console.WriteLine(NumSeq(x2, n));

      int x3;
      Console.Write("Podaj x:");
      x3 = int.Parse(Console.ReadLine());
      Console.WriteLine(sumDigit(x3));

      Fibo(7);

      System.Console.WriteLine(Oblicz(5));

      Rectangle rectangle1 = new Rectangle(4,3);
      Rectangle rectangle2 = new Rectangle(8,9);
      Rectangle rectangle3 = new Rectangle(8,1);
      Rectangle [] tab3 = new Rectangle[] { rectangle1, rectangle2, rectangle3 };
      Rectangle r = new Rectangle(tab3);
      r.show();
      Rectangle.showBiggest(tab3).show();
      rectangle1.show();

      Energy e = new Energy();
      e.Save(408, 670);
      e.Load();
      e.Count();

      Point p = new Point(3,5);
      p.Move(4,1);
      p.Show();
      Point [] ps = new Point [] { new Point(3,2), new Point(1,7), new Point(-1,-2)};
      p.AddTable(ps);
      Point.AreInLine(ps);

      Segment s = new Segment(new Point(1,7), new Point(3,2));
      s.ShowDistance();

      Cuboid c = new Cuboid(3,4,5);
      c.Show();
      Cuboid [] cs = new Cuboid[2] {new Cuboid(3,2,8), new Cuboid(8,3,1)};
      c.AddTable(cs);
      c.CompareCuboids();

      RectangleStruct rcs = new RectangleStruct(4,3);
      rcs.show();
      rcs = new RectangleStruct(new RectangleStruct [] {new RectangleStruct(3,8), new RectangleStruct(1,4)});
      rcs.show();

      StudyCandidate s1 = new StudyCandidate("Nowak", 50, 70, 90);
      StudyCandidate s2 = new StudyCandidate("Surma", 48, 30, 35);
      StudyCandidate s3 = new StudyCandidate("Wołoch", 60, 85, 40);
      StudyCandidate [] stab = new StudyCandidate[] {s1, s2, s3};
      foreach (var item in stab)
      {
        item.Show();
      }
      
      ProsteMenu.Start();

      Console.WriteLine("--END--");
    }
  }
}
