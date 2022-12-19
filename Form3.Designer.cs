namespace tp3
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.valid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.TextBox();
            this.titulaire = new System.Windows.Forms.TextBox();
            this.solde = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // valid
            // 
            this.valid.Location = new System.Drawing.Point(129, 233);
            this.valid.Name = "valid";
            this.valid.Size = new System.Drawing.Size(75, 23);
            this.valid.TabIndex = 0;
            this.valid.Text = "Valider";
            this.valid.UseVisualStyleBackColor = true;
            this.valid.Click += new System.EventHandler(this.valid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titulaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Solde";
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(139, 39);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(100, 20);
            this.numero.TabIndex = 4;
            // 
            // titulaire
            // 
            this.titulaire.Location = new System.Drawing.Point(139, 95);
            this.titulaire.Name = "titulaire";
            this.titulaire.Size = new System.Drawing.Size(100, 20);
            this.titulaire.TabIndex = 5;
            // 
            // solde
            // 
            this.solde.Location = new System.Drawing.Point(139, 152);
            this.solde.Name = "solde";
            this.solde.Size = new System.Drawing.Size(100, 20);
            this.solde.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 286);
            this.Controls.Add(this.solde);
            this.Controls.Add(this.titulaire);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valid);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button valid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.TextBox titulaire;
        private System.Windows.Forms.TextBox solde;
    }
}