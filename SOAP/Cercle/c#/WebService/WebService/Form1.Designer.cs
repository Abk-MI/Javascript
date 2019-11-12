namespace WebService
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
            this.labelTypeOperation = new System.Windows.Forms.Label();
            this.labelRayon = new System.Windows.Forms.Label();
            this.comboBoxTypeOperation = new System.Windows.Forms.ComboBox();
            this.textBoxRayon = new System.Windows.Forms.TextBox();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTypeOperation
            // 
            this.labelTypeOperation.AutoSize = true;
            this.labelTypeOperation.Location = new System.Drawing.Point(29, 27);
            this.labelTypeOperation.Name = "labelTypeOperation";
            this.labelTypeOperation.Size = new System.Drawing.Size(115, 17);
            this.labelTypeOperation.TabIndex = 0;
            this.labelTypeOperation.Text = "Type Operation :";
            // 
            // labelRayon
            // 
            this.labelRayon.AutoSize = true;
            this.labelRayon.Location = new System.Drawing.Point(32, 81);
            this.labelRayon.Name = "labelRayon";
            this.labelRayon.Size = new System.Drawing.Size(57, 17);
            this.labelRayon.TabIndex = 1;
            this.labelRayon.Text = "Rayon :";
            // 
            // comboBoxTypeOperation
            // 
            this.comboBoxTypeOperation.FormattingEnabled = true;
            this.comboBoxTypeOperation.Items.AddRange(new object[] {
            "Perimétre",
            "Surface"});
            this.comboBoxTypeOperation.Location = new System.Drawing.Point(185, 27);
            this.comboBoxTypeOperation.Name = "comboBoxTypeOperation";
            this.comboBoxTypeOperation.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTypeOperation.TabIndex = 2;
            // 
            // textBoxRayon
            // 
            this.textBoxRayon.Location = new System.Drawing.Point(185, 75);
            this.textBoxRayon.Name = "textBoxRayon";
            this.textBoxRayon.Size = new System.Drawing.Size(121, 22);
            this.textBoxRayon.TabIndex = 3;
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(126, 143);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(88, 55);
            this.btnCalculer.TabIndex = 4;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 253);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.textBoxRayon);
            this.Controls.Add(this.comboBoxTypeOperation);
            this.Controls.Add(this.labelRayon);
            this.Controls.Add(this.labelTypeOperation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTypeOperation;
        private System.Windows.Forms.Label labelRayon;
        private System.Windows.Forms.ComboBox comboBoxTypeOperation;
        private System.Windows.Forms.TextBox textBoxRayon;
        private System.Windows.Forms.Button btnCalculer;
    }
}

