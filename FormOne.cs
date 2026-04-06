using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TwoWayDataExchange
{
   public partial class FormOne : Form
   {
      [DllImport("kernel32.dll")]
      private static extern bool AllocConsole();

      [DllImport("kernel32.dll")]
      private static extern bool FreeConsole();

      public FormOne()
      {
         InitializeComponent();
      }
   }
}