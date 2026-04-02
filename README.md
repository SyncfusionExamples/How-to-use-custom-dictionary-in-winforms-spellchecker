# Custom Dictionaries in Windows Forms SpellChecker (SpellCheckerAdv)
Build rich spell-checking experiences in WinForms by combining built-in and custom dictionaries with Syncfusion's SpellCheckerAdv. This sample shows how to load Hunspell, Ispell, and OpenOffice dictionaries, add a user-maintained custom dictionary, and switch languages at runtime.

## Features
- Built-in English dictionary with suggestions
- Load Hunspell, Ispell, or OpenOffice dictionaries per culture
- Add a user-editable CustomDictionary (no grammar/affix file)
- Support multiple cultures and switch at runtime via Culture
- Per-pane control: use one or many dictionaries simultaneously
- Persist user-added words with “Add to Dictionary”

## Getting Started
1. Create a new Windows Forms app in Visual Studio.
2. Install the Syncfusion Windows Forms SpellChecker package via NuGet.
3. Add using statements in code where needed:
   - using Syncfusion.Windows.Forms.Tools;
   - using System.Globalization;
4. Add a SpellCheckerAdv instance and connect it to your editor control (e.g., RichTextBox).
5. Add one or more dictionaries and set the target Culture.

## Add a Custom Dictionary (user words)
CustomDictionary contains only a word list (no grammar file). Users can add words via UI (e.g., “Add to Dictionary”).

C#
spellChecker.Dictionaries.Add(new CustomDictionary
{
    Culture = enUS,
    DictionaryPath = @"English\Custom_en-US.txt"
});

Note: If only a CustomDictionary is used, any word not in the list is treated as a spelling error.

## Switch Language at Runtime
Load dictionaries for multiple cultures once, then switch active culture.

## Usage Tips
- Embed .aff/.dic files as resources or deploy alongside your app
- Keep one dictionary per culture per format; multiple formats can coexist
- Validate file paths and ensure Culture codes match dictionary files
- Prefer consistent casing and directory names for portability

## About the Sample
This sample wires SpellCheckerAdv to a WinForms editor, demonstrates loading Hunspell/Ispell/OpenOffice dictionaries, adding a CustomDictionary, and switching cultures at runtime. Extend it by binding to your preferred text controls and persisting user dictionaries to match your localization needs.
