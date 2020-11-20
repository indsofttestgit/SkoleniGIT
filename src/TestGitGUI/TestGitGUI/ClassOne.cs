using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitGUI
{
  class ClassOne
  {
    public static string GetMyVersion()
    {
      string sInfo = "Prvni verze + checkInFrom VS2019";

      sInfo += "Other PC change";

      return "ClassOne version: " + sInfo; 
    }
  }
}
