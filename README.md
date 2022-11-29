# How-to-use-custom-dictionary-in-winforms-spellchecker
WinForms SpellChecker comes with one predefined dictionary for English language and also supports custom dictionary based on user’s application requirement.

## Dictionary File Formats
* Hunspell
* Ispell
* OpenOffice

# C#
  public partial class Form1 : Form
      {
          SpellChecker spellChecker = new SpellChecker();
          private string BasePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\CustomDictionary\";
          public Form1()
          {
              InitializeComponent();
              spellChecker.CustomDictionaryPath = BasePath + @"\UK Dictionary.dic";

          }

          private void button1_Click(object sender, EventArgs e)
          {
              spellChecker.SpellCheck(new SpellEditorWrapper(this.richTextBox1));
          }
      }

For more details please refer [How to use custom dictionary in winforms SpellChecker](https://www.syncfusion.com/kb/8808/how-to-use-custom-dictionary-in-winforms-spellchecker-spellcheckeradv)
