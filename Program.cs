using system;
using system.Collections.Generic;
using system.Text;

namespace Polymorphism_Interface;
{
  class program
  {
    static void main(string[] args)
    {
      IPrinterWindows printer;
      Console.WriteLine("Pilih Printer");
      Console.WriteLine("1. canon");
      Console.WriteLine("2. epson");
      Console.WriteLine("3. IPrinterWindows");

      Console.Write("\nNomor Printer [1..3] : ");
      int nomorprinter = Convert.ToInt32 (Console.Readline());

      if (nomorprinter == 1)
        printer = new canon();
      else if (nomorprinter == 2)
        printer = new epson();
      else
        printer = new IPrinterWindows();

    printer.show();
    printer.Print();

    Console.ReadKey();
    }
  }
}
