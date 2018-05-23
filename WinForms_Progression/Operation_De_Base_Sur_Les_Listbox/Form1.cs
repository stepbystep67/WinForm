using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Operation_De_Base_Sur_Les_Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // reverve au chargement
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.Text = listBox1.SelectedIndex.ToString();
        }

        // gere la textbox nouvel element
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.TextLength > 0;
        }

        // gere la textbox index element (affiche le numero index de la liste).
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        // gere le bouton vider liste
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        // methode qui gere la liste 
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // Affiche le texte de la liste dans la textbox "text".
            textBox5.Text = listBox1.SelectedItem.ToString();

            textBox4.Text = listBox1.SelectedIndex.ToString();
            
        }

        // gere le bouton ajouter liste
        private void button1_Click(object sender, EventArgs e)
        {
            if(!listBox1.Items.Contains(textBox1.Text))
            {
                
                // Ajouter textbox a listbox
                listBox1.Items.Add(textBox1.Text);
                
                // Compte les elements dans la list et laffiche dans la textbox items.counts
                textBox3.Text = listBox1.Items.Count.ToString();

                // replace le focus dans la textbox1 .
                textBox1.Focus();

                // vide la chaine de caractere
                textBox1.Text = string.Empty;

            }
            
        }

        // affiche la selection de l'index dans la liste
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        // Gere le bouton selectionner
        private void button2_Click(object sender, EventArgs e)
        {
                
            if (textBox2.Text.Length >= 0)
            {

                //listBox1.Items.Length(textBox2.Text.Length) = textBox2.Text.ToString();
                int indexSelectionne;

                // conversion de string a int 
                if (!Int32.TryParse(textBox2.Text, out indexSelectionne))
                {
                    MessageBox.Show("L'index Sélectionné est invalide");
                    return;
                }
                
                // 
                if (indexSelectionne < listBox1.Items.Count)
                {
                    listBox1.SelectedIndex = indexSelectionne;
                }
                else
                {
                    MessageBox.Show("L'index Sélectionné n'existe pas !");
                    return;
                }
            }

        }

    }
}
