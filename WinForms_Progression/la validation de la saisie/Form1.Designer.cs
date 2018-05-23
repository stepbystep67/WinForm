namespace la_validation_de_la_saisie
{
    partial class Les_controles
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Valider = new System.Windows.Forms.Button();
            this.btn_Effacer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textMontant = new System.Windows.Forms.TextBox();
            this.textCP = new System.Windows.Forms.TextBox();
            this.label_Nom = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Montant = new System.Windows.Forms.Label();
            this.label_Code_Postal = new System.Windows.Forms.Label();
            this.label_format_Date = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(203, 203);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Valider.TabIndex = 0;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            this.btn_Valider.Leave += new System.EventHandler(this.btn_Valider_Click);
            // 
            // btn_Effacer
            // 
            this.btn_Effacer.Location = new System.Drawing.Point(203, 249);
            this.btn_Effacer.Name = "btn_Effacer";
            this.btn_Effacer.Size = new System.Drawing.Size(75, 23);
            this.btn_Effacer.TabIndex = 1;
            this.btn_Effacer.Text = "Effacer";
            this.btn_Effacer.UseVisualStyleBackColor = true;
            this.btn_Effacer.Click += new System.EventHandler(this.btn_Effacer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textMontant
            // 
            this.textMontant.Location = new System.Drawing.Point(93, 125);
            this.textMontant.Name = "textMontant";
            this.textMontant.Size = new System.Drawing.Size(100, 20);
            this.textMontant.TabIndex = 4;
            this.textMontant.Leave += new System.EventHandler(this.textMontant_TextChanged);
            // 
            // textCP
            // 
            this.textCP.Location = new System.Drawing.Point(93, 166);
            this.textCP.Name = "textCP";
            this.textCP.Size = new System.Drawing.Size(100, 20);
            this.textCP.TabIndex = 5;
            this.textCP.Leave += new System.EventHandler(this.textCP_TextChanged);
            // 
            // label_Nom
            // 
            this.label_Nom.AutoSize = true;
            this.label_Nom.Location = new System.Drawing.Point(13, 38);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(29, 13);
            this.label_Nom.TabIndex = 6;
            this.label_Nom.Text = "Nom";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(13, 77);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(30, 13);
            this.label_Date.TabIndex = 7;
            this.label_Date.Text = "Date";
            // 
            // label_Montant
            // 
            this.label_Montant.AutoSize = true;
            this.label_Montant.Location = new System.Drawing.Point(13, 125);
            this.label_Montant.Name = "label_Montant";
            this.label_Montant.Size = new System.Drawing.Size(46, 13);
            this.label_Montant.TabIndex = 8;
            this.label_Montant.Text = "Montant";
            // 
            // label_Code_Postal
            // 
            this.label_Code_Postal.AutoSize = true;
            this.label_Code_Postal.Location = new System.Drawing.Point(13, 166);
            this.label_Code_Postal.Name = "label_Code_Postal";
            this.label_Code_Postal.Size = new System.Drawing.Size(64, 13);
            this.label_Code_Postal.TabIndex = 9;
            this.label_Code_Postal.Text = "Code Postal";
            // 
            // label_format_Date
            // 
            this.label_format_Date.AutoSize = true;
            this.label_format_Date.Location = new System.Drawing.Point(199, 80);
            this.label_format_Date.Name = "label_format_Date";
            this.label_format_Date.Size = new System.Drawing.Size(79, 13);
            this.label_format_Date.TabIndex = 10;
            this.label_format_Date.Text = "(JJ/MM/AAAA)";
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(93, 37);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(184, 20);
            this.textNom.TabIndex = 11;
           
            this.textNom.Leave += new System.EventHandler(this.textNom_TextChanged);
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(93, 76);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(100, 20);
            this.textDate.TabIndex = 12;
            this.textDate.Leave += new System.EventHandler(this.textDate_TextChanged);
            // 
            // Les_controles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 304);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.label_format_Date);
            this.Controls.Add(this.label_Code_Postal);
            this.Controls.Add(this.label_Montant);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Nom);
            this.Controls.Add(this.textCP);
            this.Controls.Add(this.textMontant);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Effacer);
            this.Controls.Add(this.btn_Valider);
            this.Name = "Les_controles";
            this.Text = "Les contrôles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_Effacer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textMontant;
        private System.Windows.Forms.TextBox textCP;
        private System.Windows.Forms.Label label_Nom;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Montant;
        private System.Windows.Forms.Label label_Code_Postal;
        private System.Windows.Forms.Label label_format_Date;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textDate;
    }
}

