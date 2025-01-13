using System.Windows.Forms;
using CompuMaster.Windows.DigitalRuneTextEditor;


namespace CompuMaster.Windows.SampleEditor
{
  public partial class OptionsDialog : Form
  {
    public OptionsDialog(TextEditorControl textEditorControl)
    {
      InitializeComponent();

      // Show the properties of the TextEditorControl
      propertyGrid.SelectedObject = textEditorControl;
    }
  }
}