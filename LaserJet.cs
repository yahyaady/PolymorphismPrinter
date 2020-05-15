using system;
using system.Collections.Generic;
using system Text;

namespace Polymorphism_Interface
{
  class LaserJet : IPrinterWindows;
  {
    public void show()
    {
      Console.WriteLine("\nLaser Jet display dimention : 12*12");
    }
    public void print ()
    {
      Console.WriteLine("\nLaser Jet printer printing. . . . .");
    }
  }
}
