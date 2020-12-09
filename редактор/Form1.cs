using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace редактор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|Rtf files(*.rtf)|*.rtf|All files(*.*)|*.* ";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|Rtf files(*.rtf)|*.rtf|All files(*.*)|*.* ";

        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                catch
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                toolStripStatusLabel1.Text = openFileDialog1.FileName;
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                toolStripStatusLabel1.Text = saveFileDialog1.FileName;
            }
        }
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            toolStripStatusLabel1.Text = "Без имени";
        }
        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        private void повторитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        private void поЛевомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void поПравомуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }
        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tЭто текстовый редактор","О программе",MessageBoxButtons.OK);
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void полужирныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentfont = richTextBox1.SelectionFont;
            Font newfont;
            if (currentfont.Bold == true)
                newfont = new Font(currentfont, currentfont.Style ^ FontStyle.Bold);
            else
                newfont = new Font(currentfont, currentfont.Style | FontStyle.Bold);
            richTextBox1.SelectionFont = newfont;
        }
        private void курсивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentfont = richTextBox1.SelectionFont;
            Font newfont;
            if (currentfont.Italic == true)
                newfont = new Font(currentfont, currentfont.Style ^ FontStyle.Italic);
            else
                newfont = new Font(currentfont, currentfont.Style | FontStyle.Italic);
            richTextBox1.SelectionFont = newfont;
        }
        private void подчёркнутыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentfont = richTextBox1.SelectionFont;
            Font newfont;
            if (currentfont.Underline == true)
                newfont = new Font(currentfont, currentfont.Style ^ FontStyle.Underline);
            else
                newfont = new Font(currentfont, currentfont.Style | FontStyle.Underline);
            richTextBox1.SelectionFont = newfont;
        }
    }
}
