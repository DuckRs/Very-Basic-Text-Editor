using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set up the rich text box control
            richTextBox1.AcceptsTab = true;
            richTextBox1.Font = new System.Drawing.Font("Calibri", 12);
            richTextBox1.HideSelection = false;
            richTextBox1.Multiline = true;
            richTextBox1.WordWrap = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Make the selected text bold
            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newFontStyle;

            if (richTextBox1.SelectionFont.Bold)
            {
                newFontStyle = FontStyle.Regular;
            }
            else
            {
                newFontStyle = FontStyle.Bold;
            }

            richTextBox1.SelectionFont = new Font(
                currentFont.FontFamily,
                currentFont.Size,
                newFontStyle
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Make the selected text italic
            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newFontStyle;

            if (richTextBox1.SelectionFont.Italic)
            {
                newFontStyle = FontStyle.Regular;
            }
            else
            {
                newFontStyle = FontStyle.Italic;
            }

            richTextBox1.SelectionFont = new Font(
                currentFont.FontFamily,
                currentFont.Size,
                newFontStyle
            );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Make the selected text underlined
            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newFontStyle;

            if (richTextBox1.SelectionFont.Underline)
            {
                newFontStyle = FontStyle.Regular;
            }
            else
            {
                newFontStyle = FontStyle.Underline;
            }

            richTextBox1.SelectionFont = new Font(
                currentFont.FontFamily,
                currentFont.Size,
                newFontStyle
            );
        }
    }
}
