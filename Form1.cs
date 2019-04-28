using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Keywords.Add("fn");
            Keywords.Add("s32");
            Tokens.Add(";");
            Tokens.Add("{");
            Tokens.Add("}");
        }

        private static List<string> Keywords = new List<string>();
        private static List<string> Tokens = new List<string>();

        private void RichTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                int aux = richTextBox1.SelectionStart;
                int aux2 = aux;
                int aux3 = aux;
                int aux4 = richTextBox1.GetFirstCharIndexOfCurrentLine();
                int aux5 = richTextBox1.Lines[richTextBox1.GetLineFromCharIndex(aux4)].Length;
                while (aux2 > aux4)
                {
                    if (richTextBox1.Text[aux2 - 1] == '\0' || richTextBox1.Text[aux2 - 1] == ' ')
                        break;
                    aux2--;
                }
                while (aux3 < aux5)
                {
                    if (richTextBox1.Text[aux3 - 1] == '\0' || richTextBox1.Text[aux3 - 1] == ' ' || richTextBox1.Text[aux3 - 1] == '\n')
                        break;
                    aux3++;
                }
                string word = richTextBox1.Text.Substring(aux2, aux3 - aux2);
                foreach (string Token in Tokens)
                    word = word.Replace(Token, "");
                //foreach(string Keyword in Keywords)

            }
        }
    }
}