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


namespace CHECK_BOX_ET_BOUTONS_RADIOS
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Dans la méthode load y mettre les valeurs par defaut par ex :
            groupBox1.Enabled = false;
        }

        private void Radiobtn(object sender, EventArgs e)
        {
            // cast des radiobutton (sert a savoir quel radiobutton est selectionner)
            RadioButton btn = sender as RadioButton;

            if (textBox1.Text.Length != 0)
            {
                textBox1.Text += btn.Text;
            }

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {                                   // backcolor change le fond
                textBox2.BackColor = Color.Red;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.BackColor = Color.Green;
            }
        }

        // radiobouton 
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                textBox2.BackColor = Color.Blue;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {                                   // forecolor change le fond
                textBox2.ForeColor = Color.Red;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {                                   // forecolor change le fond
                textBox2.Text = textBox2.Text.ToUpper();
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {                                   // forecolor change le fond
                textBox2.Text = textBox2.Text.ToLower();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {                                   // forecolor change le fond
                textBox2.ForeColor = Color.White;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {                                   // forecolor change le fond
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            // Affiche le groupe 1 dès le premier caractère rentrer.
            groupBox1.Enabled = (textBox1.Text.Length > 0);

            // Affichage de la une dans la deuxieme.
            textBox2.Text = textBox1.Text;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            // rendre visible le groupe fond quand le radiobouton est check.
            if (checkBox1.Checked == true)
            { groupBox2.Visible = checkBox1.Checked;
            }
            else
            {
                groupBox2.Visible = false;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

            // checkBox2.
            groupBox3.Visible = checkBox2.Checked;
            
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            
            // checkBox3
            groupBox4.Visible = checkBox3.Checked;

        }
        
    }
}

// if (checkBox1.Checked)
// {
//   groupBox2.Focus();
//  }