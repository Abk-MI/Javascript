namespace JAVACsharpPROJECT
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.listedessalariebox = new System.Windows.Forms.GroupBox();
            this.ListeGrid = new System.Windows.Forms.DataGridView();
            this.informationsalarie = new System.Windows.Forms.GroupBox();
            this.Ajoutbutton = new System.Windows.Forms.Button();
            this.ModifierButton = new System.Windows.Forms.Button();
            this.SupprimerButton = new System.Windows.Forms.Button();
            this.QuitterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Codetext = new System.Windows.Forms.TextBox();
            this.Nomtext = new System.Windows.Forms.TextBox();
            this.Prenomtext = new System.Windows.Forms.TextBox();
            this.Adressetext = new System.Windows.Forms.TextBox();
            this.Departementlist = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Teltext = new System.Windows.Forms.TextBox();
            this.Emailtext = new System.Windows.Forms.TextBox();
            this.Fonctionlist = new System.Windows.Forms.ComboBox();
            this.ValiderButton = new System.Windows.Forms.Button();
            this.listedessalariebox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeGrid)).BeginInit();
            this.informationsalarie.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche";
            // 
            // listedessalariebox
            // 
            this.listedessalariebox.Controls.Add(this.ListeGrid);
            this.listedessalariebox.Location = new System.Drawing.Point(12, 51);
            this.listedessalariebox.Name = "listedessalariebox";
            this.listedessalariebox.Size = new System.Drawing.Size(263, 312);
            this.listedessalariebox.TabIndex = 1;
            this.listedessalariebox.TabStop = false;
            this.listedessalariebox.Text = "Liste des salariés";
            // 
            // ListeGrid
            // 
            this.ListeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeGrid.Location = new System.Drawing.Point(6, 19);
            this.ListeGrid.Name = "ListeGrid";
            this.ListeGrid.Size = new System.Drawing.Size(240, 287);
            this.ListeGrid.TabIndex = 0;
            // 
            // informationsalarie
            // 
            this.informationsalarie.Controls.Add(this.Fonctionlist);
            this.informationsalarie.Controls.Add(this.Emailtext);
            this.informationsalarie.Controls.Add(this.Teltext);
            this.informationsalarie.Controls.Add(this.label9);
            this.informationsalarie.Controls.Add(this.label8);
            this.informationsalarie.Controls.Add(this.Departementlist);
            this.informationsalarie.Controls.Add(this.Adressetext);
            this.informationsalarie.Controls.Add(this.Prenomtext);
            this.informationsalarie.Controls.Add(this.Nomtext);
            this.informationsalarie.Controls.Add(this.Codetext);
            this.informationsalarie.Controls.Add(this.label7);
            this.informationsalarie.Controls.Add(this.label6);
            this.informationsalarie.Controls.Add(this.label5);
            this.informationsalarie.Controls.Add(this.label4);
            this.informationsalarie.Controls.Add(this.label3);
            this.informationsalarie.Controls.Add(this.label2);
            this.informationsalarie.Location = new System.Drawing.Point(281, 51);
            this.informationsalarie.Name = "informationsalarie";
            this.informationsalarie.Size = new System.Drawing.Size(462, 312);
            this.informationsalarie.TabIndex = 2;
            this.informationsalarie.TabStop = false;
            this.informationsalarie.Text = "Information salarié";
            // 
            // Ajoutbutton
            // 
            this.Ajoutbutton.Location = new System.Drawing.Point(12, 390);
            this.Ajoutbutton.Name = "Ajoutbutton";
            this.Ajoutbutton.Size = new System.Drawing.Size(75, 23);
            this.Ajoutbutton.TabIndex = 3;
            this.Ajoutbutton.Text = "Ajout";
            this.Ajoutbutton.UseVisualStyleBackColor = true;
            this.Ajoutbutton.Click += new System.EventHandler(this.Ajoutbutton_Click);
            // 
            // ModifierButton
            // 
            this.ModifierButton.Location = new System.Drawing.Point(93, 390);
            this.ModifierButton.Name = "ModifierButton";
            this.ModifierButton.Size = new System.Drawing.Size(75, 23);
            this.ModifierButton.TabIndex = 4;
            this.ModifierButton.Text = "Modifier";
            this.ModifierButton.UseVisualStyleBackColor = true;
            this.ModifierButton.Click += new System.EventHandler(this.ModifierButton_Click);
            // 
            // SupprimerButton
            // 
            this.SupprimerButton.Location = new System.Drawing.Point(174, 390);
            this.SupprimerButton.Name = "SupprimerButton";
            this.SupprimerButton.Size = new System.Drawing.Size(75, 23);
            this.SupprimerButton.TabIndex = 5;
            this.SupprimerButton.Text = "Supprimer";
            this.SupprimerButton.UseVisualStyleBackColor = true;
            this.SupprimerButton.Click += new System.EventHandler(this.SupprimerButton_Click);
            // 
            // QuitterButton
            // 
            this.QuitterButton.Location = new System.Drawing.Point(692, 406);
            this.QuitterButton.Name = "QuitterButton";
            this.QuitterButton.Size = new System.Drawing.Size(75, 23);
            this.QuitterButton.TabIndex = 6;
            this.QuitterButton.Text = "QUITTER";
            this.QuitterButton.UseVisualStyleBackColor = true;
            this.QuitterButton.Click += new System.EventHandler(this.QuitterButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nom:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Prenom:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fonction";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Departement:";
            // 
            // Codetext
            // 
            this.Codetext.Location = new System.Drawing.Point(154, 32);
            this.Codetext.Name = "Codetext";
            this.Codetext.Size = new System.Drawing.Size(100, 20);
            this.Codetext.TabIndex = 6;
            // 
            // Nomtext
            // 
            this.Nomtext.Location = new System.Drawing.Point(154, 60);
            this.Nomtext.Name = "Nomtext";
            this.Nomtext.Size = new System.Drawing.Size(100, 20);
            this.Nomtext.TabIndex = 7;
            // 
            // Prenomtext
            // 
            this.Prenomtext.Location = new System.Drawing.Point(154, 89);
            this.Prenomtext.Name = "Prenomtext";
            this.Prenomtext.Size = new System.Drawing.Size(100, 20);
            this.Prenomtext.TabIndex = 8;
            // 
            // Adressetext
            // 
            this.Adressetext.Location = new System.Drawing.Point(154, 130);
            this.Adressetext.Name = "Adressetext";
            this.Adressetext.Size = new System.Drawing.Size(100, 20);
            this.Adressetext.TabIndex = 11;
            // 
            // Departementlist
            // 
            this.Departementlist.FormattingEnabled = true;
            this.Departementlist.Location = new System.Drawing.Point(154, 198);
            this.Departementlist.Name = "Departementlist";
            this.Departementlist.Size = new System.Drawing.Size(100, 21);
            this.Departementlist.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tel:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Email:";
            // 
            // Teltext
            // 
            this.Teltext.Location = new System.Drawing.Point(154, 234);
            this.Teltext.Name = "Teltext";
            this.Teltext.Size = new System.Drawing.Size(100, 20);
            this.Teltext.TabIndex = 15;
            // 
            // Emailtext
            // 
            this.Emailtext.Location = new System.Drawing.Point(154, 265);
            this.Emailtext.Name = "Emailtext";
            this.Emailtext.Size = new System.Drawing.Size(100, 20);
            this.Emailtext.TabIndex = 16;
            // 
            // Fonctionlist
            // 
            this.Fonctionlist.FormattingEnabled = true;
            this.Fonctionlist.Location = new System.Drawing.Point(154, 161);
            this.Fonctionlist.Name = "Fonctionlist";
            this.Fonctionlist.Size = new System.Drawing.Size(100, 21);
            this.Fonctionlist.TabIndex = 17;
            // 
            // ValiderButton
            // 
            this.ValiderButton.Location = new System.Drawing.Point(611, 406);
            this.ValiderButton.Name = "ValiderButton";
            this.ValiderButton.Size = new System.Drawing.Size(75, 23);
            this.ValiderButton.TabIndex = 7;
            this.ValiderButton.Text = "Valider";
            this.ValiderButton.UseVisualStyleBackColor = true;
            this.ValiderButton.Click += new System.EventHandler(this.ValiderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ValiderButton);
            this.Controls.Add(this.QuitterButton);
            this.Controls.Add(this.SupprimerButton);
            this.Controls.Add(this.ModifierButton);
            this.Controls.Add(this.Ajoutbutton);
            this.Controls.Add(this.informationsalarie);
            this.Controls.Add(this.listedessalariebox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.listedessalariebox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListeGrid)).EndInit();
            this.informationsalarie.ResumeLayout(false);
            this.informationsalarie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox listedessalariebox;
        private System.Windows.Forms.DataGridView ListeGrid;
        private System.Windows.Forms.GroupBox informationsalarie;
        private System.Windows.Forms.ComboBox Fonctionlist;
        private System.Windows.Forms.TextBox Emailtext;
        private System.Windows.Forms.TextBox Teltext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Departementlist;
        private System.Windows.Forms.TextBox Adressetext;
        private System.Windows.Forms.TextBox Prenomtext;
        private System.Windows.Forms.TextBox Nomtext;
        private System.Windows.Forms.TextBox Codetext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Ajoutbutton;
        private System.Windows.Forms.Button ModifierButton;
        private System.Windows.Forms.Button SupprimerButton;
        private System.Windows.Forms.Button QuitterButton;
        private System.Windows.Forms.Button ValiderButton;
    }
}

