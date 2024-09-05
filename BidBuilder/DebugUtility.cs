using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BidBuilder
{
  public static class DebugUtility
  {
    public static void DebugMessage(string message)
    {
      MessageBox.Show(message, "Debug message", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
