using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Interface
{
  public interface IPrinterWindows
  {
    void Show();
    void Print();
  }

  class Canon : IPrinterWindows
  {
    public void Show()
    {
      Console.WriteLine("\nCanon display dimention : 9.5*12");
    }

    public void Print()
    {
      Console.WriteLine("\nCanon printer printing.......");
    }
  }

  class Epson : IPrinterWindows
  {
    public void Show()
    {
      Console.WriteLine("\nEpson display dimention : 10*11");
    }

    public void Print()
    {
      Console.WriteLine("\nEpson printer printing.......");
    }
  }

  class LaserJet : IPrinterWindows
  {
    public void Show()
    {
      Console.WriteLine("\nLaser Jet display dimention : 12*12");
    }

    public void Print()
    {
      Console.WriteLine("\nLaser Jet printer printing.......");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      IPrinterWindows printer;

      Console.WriteLine("Pilih Printer");
      Console.WriteLine("1. Epson");
      Console.WriteLine("2. Canon");
      Console.WriteLine("3. Laser Jet");

      Console.Write("\nNomor Printer [1..3] : ");
      int nomorprinter = Convert.ToInt32(Console.ReadLine());

      if (nomorprinter == 1)
          printer = new Canon();
      else if (nomorprinter == 2)
          printer = new Epson();
      else
          printer = new IPrinterWindows();

      printer.Show();
      printer.Print();


      Console.ReadKey();
    }
  }
