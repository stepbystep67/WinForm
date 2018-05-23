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

namespace la_validation_de_la_saisie
{
    public partial class Les_controles : Form
    {

        public Les_controles()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {

            // Constructeur.
            StringBuilder sb = new StringBuilder();

            // Ajouter les valeur dans le constructeur stringbuilder.(sb) , line a la ligne.
            sb.Append("Nom : ");
            sb.AppendLine(textNom.Text);
            sb.Append("Date : ");
            sb.AppendLine(textDate.Text);
            sb.Append("Montant : ");
            sb.AppendLine(textMontant.Text);
            sb.Append("Code Postal");
            sb.AppendLine(textCP.Text);

            
            // Afficher constructeur + titre fenetre + bouton de fin "ok" + logo i (information)
            MessageBox.Show(sb.ToString(), "Validation effectuée !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 
            MessageBox.Show("Fin de l'application", "FIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


        }

        private void btn_Effacer_Click(object sender, EventArgs e)
        {

            // Vider la totalité en mettant une valeur chaine de caractere vide dans chaque textbox.
            textNom.Text = "";
            textDate.Text = "";
            textMontant.Text = "";
            textCP.Text = "";
            
        }

        private void textNom_TextChanged(object sender, EventArgs e)
        {

            // [a-zA-Z] = seulement des lettres min + maj puis {1,30} = de 1 a 30 caractere
            string pattern = @"^([a-zA-Z]{1,30})$";
            
            if (!Regex.IsMatch(textNom.Text, pattern))
            {
                
                MessageBox.Show("Veuillez entrez a nouveau votre nom ");

            }

        }

        private void textCP_TextChanged(object sender, EventArgs e)
        {

            string pattern = @"^([0-9]{5})$";

            if (!Regex.IsMatch(textCP.Text, pattern))
            {
                
                MessageBox.Show("Code Postal non valide veuillez entrer 5 chiffre");

            }

        }

        private void textMontant_TextChanged(object sender, EventArgs e)
        {

            // + veut dire de 1 a plus.
            // \. indique qu'il peut y a voir un point.
            // ? point d'interrogation signifie 0 ou 1.
            string pattern = @"^([0-9]+)([\.]?)([0-9]{0,2})$";

            if (!Regex.IsMatch(textMontant.Text ,pattern))
            {
                
                MessageBox.Show("Saisie invalide ,veuillez entrez un chiffre ou un nombre");

            }

        }

        private void textDate_TextChanged(object sender, EventArgs e)
        {
            
            DateTime date;

            bool resultat = DateTime.TryParse(textDate.Text, out date);

            string pattern = @"^([0-9]{2})/([0-9]{2})/([0-9]{4})$";

            if (!Regex.IsMatch(textDate.Text,pattern) || !resultat)
            {
                
                MessageBox.Show("Veuillez entrer une date valide");
                return;

            }

            
	     }

        
    }
}
