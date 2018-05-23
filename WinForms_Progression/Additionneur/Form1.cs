using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Additionneur
{
    public partial class Additionneur : Form
    {

        // Juste pour l'essai avec git.
        protected static bool oijsipsfj;


        // Jamais mettre de code avant ce constructeur.
        public Additionneur()
        {

            InitializeComponent();// Initialise en objet form1.

        }
        

        // Reserve au chargement ,y mettre des lignes de code qui ne concerne pas l'affichage.
        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        // Gestionnaire d'evenements
        private void btn_chiffre_Click(object sender, EventArgs e)
        {
            
           // Cast de sender et button.
           Button btn = sender as Button;

           // Tous les bouton s'affiche grace a btn_chiffre_Click (proprieté l'affichage se passe dans cette methode.

           if(textBox_affichage_Additionneur.Text.Length == 0)
           {
               
               // Ajout a l'affichage du text du bouton concerner.
               textBox_affichage_Additionneur.Text += btn.Text;

           }
           
           else
           {
               
               textBox_affichage_Additionneur.Text += "+" + btn.Text;

           }

        }

        private void btn_chiffre_1_Click(object sender, EventArgs e)
        {

        }

        private void btn_chiffre_2_Click(object sender, EventArgs e)
        {

        }

        private void btn_chiffre_3_Click(object sender, EventArgs e)
        {

        }

        private void btn_chiffre_4_Click(object sender, EventArgs e)
        {

        }

        private void btn_chiffre_5_Click(object sender, EventArgs e)
        {

        }

        private void btn_chiffre_6_Click(object sender, EventArgs e)
        {

        }

        private void btn_chiffre_7_Click(object sender, EventArgs e)
        {

        }

        private void btn_chiffre_8_Click(object sender, EventArgs e)
        {

        }

        private void btn_chiffre_9_Click(object sender, EventArgs e)
        {

        }

        private void btn_Vider_Click(object sender, EventArgs e)
        {
            
            // Vider la totalité en mettant une valeur chaine de caractere vide.
            textBox_affichage_Additionneur.Text = "";

        }

        private void btn_Calculer_Click(object sender, EventArgs e)
        {
            

            // Caracter(s)e a chercher dans le texte du formulair
            char[] plus = new char[] { '+' };


            // Convertion de textBox_affichage_Additionneur.Text chaine vers string tableau.
            string[] words = textBox_affichage_Additionneur.Text.Split(plus, StringSplitOptions.RemoveEmptyEntries);


            // Va contenir le resultat.
            int total = 0;


            // Recherche numero 
            foreach (string numero in words)
            {
                total += Convert.ToInt32(numero);
            }


            // Affichage du formulair par la variable total int converti en string.
            textBox_affichage_Additionneur.Text = total.ToString();


        }

        private void textBox_affichage_Additionneur_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
