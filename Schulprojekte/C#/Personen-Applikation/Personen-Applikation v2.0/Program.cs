using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personen_Applikation_v2._0
{
   static class Program
   {
      /// <summary>
      /// Der Haupteinstiegspunkt für die Anwendung.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new Personen_Applikation());

      }
   }
}
