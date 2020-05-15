using system;
using system.Collections.Generic;
using system.Text;

namespace Polymorphism_Interface
{
  class Epson : IPrinterWindows
  {
    Public void show()
    {
      Console.WriteLine("\nEpson display dimention : 10*11");
    }
    public void print()
    {
      Console.Writeline("\nEpson printer printing . . . . .");
    }
  }
}
