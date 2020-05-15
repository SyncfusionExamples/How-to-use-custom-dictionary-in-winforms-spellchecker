Imports System.IO
Imports Syncfusion.Text
Imports Syncfusion.WinForms.Controls


Partial Public Class Form1

        Private spellChecker As SpellChecker = New SpellChecker()
        Private BasePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\CustomDictionary\"
        Private Sub Form1_Load(sender As Object, e As EventArgs)
            spellChecker.CustomDictionaryPath = BasePath + "\UK Dictionary.dic"
        End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        spellChecker.SpellCheck(New SpellEditorWrapper(RichTextBox1))
    End Sub
End Class


