using System.Diagnostics;
using System.Windows.Forms;


namespace CompuMaster.Windows.SampleEditor
{
  public partial class AboutDialog : Form
  {
    public AboutDialog()
    {
      InitializeComponent();
    }
    
    
    private void linkDigitalRune_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("http://www.digitalrune.com/");
    }
  }
}