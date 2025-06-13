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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void codeButton_Click(object sender, EventArgs e)
        {
            int key = int.Parse(keyTextBox.Text);
            string text = textTextBox.Text;

            string encrypted = "";

            foreach (char c in text)
            {
                if (char.IsLower(c))
                {
                    encrypted += (char)((((c - 'a') + key + 26) % 26) + 'a');
                }
                else if (char.IsUpper(c))
                {
                    encrypted += (char)((((c - 'A') + key + 26) % 26) + 'A');
                }
                else
                {
                    encrypted += c;
                }
            }

            codedLabel.Text = encrypted;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            string textToSave = codedLabel.Text;

            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; // Filtr dla plików tekstowych

            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                System.IO.File.WriteAllText(saveFileDialog.FileName, textToSave);
            }
        }
    }
}
