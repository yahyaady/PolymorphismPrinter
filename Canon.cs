using system;
using system.Collections.Generic;
using system.Text;

namespace Polymorphism_Interface;
{
  class canon : PrinterWindows
  {
    public void show ()
    {
      Console.Writeline("\nCanon display dimention  : 9.5*12");
    }
    public void print ()
    {
      Console.WriteLine("\nCanon printer printing . . . . .");
    }
  }

}
