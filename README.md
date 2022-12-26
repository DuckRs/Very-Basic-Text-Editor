# Very-Basic-Text-Editor
A very bare-bones text editor.

This code is a C# program that creates a rich text editor using the RichTextBox control from the System.Windows.Forms namespace. The program consists of a single form class, Form1, that contains three Button controls for applying bold, italic, and underline formatting to the selected text in the RichTextBox control.

The Form1 class has a constructor method, which is called when an instance of the form is created. In the constructor, the InitializeComponent method is called to initialize the form and its controls, and then the richTextBox1 control is configured with various properties such as AcceptsTab, Font, HideSelection, Multiline, and WordWrap.

The form also has event handler methods for the Click events of the three Button controls. These event handlers use the SelectionFont property of the RichTextBox control to get the current font of the selected text, and then create a new Font object with the appropriate font style (bold, italic, or underline) applied. The new font is then assigned to the SelectionFont property of the RichTextBox control to apply the formatting to the selected text.

Finally, the form has an empty Form1_Load event handler, which is called when the form is loaded. This event handler currently does nothing, but you could use it to add additional functionality to the form.
