using Syncfusion.Text;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellCheckerAdv_dictionary
{
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
}
