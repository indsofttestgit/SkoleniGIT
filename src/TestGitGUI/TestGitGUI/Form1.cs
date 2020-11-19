using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGitGUI
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnHelloWorld_Click(object sender, EventArgs e)
    {
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

      System.Windows.Forms.MessageBox.Show($"TestGitGUI Ver={fvi.FileVersion}{Environment.NewLine}"
                                           + $"{Environment.NewLine}{ClassOne.GetMyVersion()}"
                                           + $"{Environment.NewLine}{ClassTwo.GetMyVersion()}"
                                           + $"{Environment.NewLine}{ClassThree.GetMyVersion()}");
    }
  }
}
