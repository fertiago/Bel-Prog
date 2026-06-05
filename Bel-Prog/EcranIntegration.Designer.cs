namespace Bel_Prog
{
    partial class EcranIntegration
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
            this.components = new System.ComponentModel.Container();
            this.labelGauche = new System.Windows.Forms.Label();
            this.textBoxGauche = new System.Windows.Forms.TextBox();
            this.textBoxDroite = new System.Windows.Forms.TextBox();
            this.labelDroite = new System.Windows.Forms.Label();
            this.textBoxNbInt = new System.Windows.Forms.TextBox();
            this.labelNbInt = new System.Windows.Forms.Label();
            this.listBoxResultats = new System.Windows.Forms.ListBox();
            this.buttonPolynome = new System.Windows.Forms.Button();
            this.buttonTrigonometrique = new System.Windows.Forms.Button();
            this.buttonPointeurPolynome = new System.Windows.Forms.Button();
            this.buttonPointeurTrigonometrique = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGauche
            // 
            this.labelGauche.AutoSize = true;
            this.labelGauche.Location = new System.Drawing.Point(12, 9);
            this.labelGauche.Name = "labelGauche";
            this.labelGauche.Size = new System.Drawing.Size(58, 20);
            this.labelGauche.TabIndex = 0;
            this.labelGauche.Text = "Gauche";
            // 
            // textBoxGauche
            // 
            this.textBoxGauche.Location = new System.Drawing.Point(12, 32);
            this.textBoxGauche.Name = "textBoxGauche";
            this.textBoxGauche.Size = new System.Drawing.Size(125, 27);
            this.textBoxGauche.TabIndex = 1;
            // 
            // textBoxDroite
            // 
            this.textBoxDroite.Location = new System.Drawing.Point(143, 32);
            this.textBoxDroite.Name = "textBoxDroite";
            this.textBoxDroite.Size = new System.Drawing.Size(125, 27);
            this.textBoxDroite.TabIndex = 3;
            // 
            // labelDroite
            // 
            this.labelDroite.AutoSize = true;
            this.labelDroite.Location = new System.Drawing.Point(143, 9);
            this.labelDroite.Name = "labelDroite";
            this.labelDroite.Size = new System.Drawing.Size(51, 20);
            this.labelDroite.TabIndex = 2;
            this.labelDroite.Text = "Droite";
            // 
            // textBoxNbInt
            // 
            this.textBoxNbInt.Location = new System.Drawing.Point(274, 32);
            this.textBoxNbInt.Name = "textBoxNbInt";
            this.textBoxNbInt.Size = new System.Drawing.Size(125, 27);
            this.textBoxNbInt.TabIndex = 5;
            // 
            // labelNbInt
            // 
            this.labelNbInt.AutoSize = true;
            this.labelNbInt.Location = new System.Drawing.Point(274, 9);
            this.labelNbInt.Name = "labelNbInt";
            this.labelNbInt.Size = new System.Drawing.Size(147, 20);
            this.labelNbInt.TabIndex = 4;
            this.labelNbInt.Text = "Nombre d'Intervalles";
            // 
            // listBoxResultats
            // 
            this.listBoxResultats.FormattingEnabled = true;
            this.listBoxResultats.Location = new System.Drawing.Point(12, 65);
            this.listBoxResultats.Name = "listBoxResultats";
            this.listBoxResultats.Size = new System.Drawing.Size(387, 224);
            this.listBoxResultats.TabIndex = 6;
            // 
            // buttonPolynome
            // 
            this.buttonPolynome.Location = new System.Drawing.Point(12, 301);
            this.buttonPolynome.Name = "buttonPolynome";
            this.buttonPolynome.Size = new System.Drawing.Size(232, 46);
            this.buttonPolynome.TabIndex = 7;
            this.buttonPolynome.Text = "Polynôme : x*x +2";
            this.buttonPolynome.UseVisualStyleBackColor = true;
            this.buttonPolynome.Click += new System.EventHandler(this.buttonPolynome_Click);
            // 
            // buttonTrigonometrique
            // 
            this.buttonTrigonometrique.Location = new System.Drawing.Point(12, 353);
            this.buttonTrigonometrique.Name = "buttonTrigonometrique";
            this.buttonTrigonometrique.Size = new System.Drawing.Size(232, 42);
            this.buttonTrigonometrique.TabIndex = 8;
            this.buttonTrigonometrique.Text = "Trigonométrique : sin(x)";
            this.buttonTrigonometrique.UseVisualStyleBackColor = true;
            this.buttonTrigonometrique.Click += new System.EventHandler(this.buttonTrigonometrique_Click);
            // 
            // buttonPointeurPolynome
            // 
            this.buttonPointeurPolynome.Location = new System.Drawing.Point(250, 301);
            this.buttonPointeurPolynome.Name = "buttonPointeurPolynome";
            this.buttonPointeurPolynome.Size = new System.Drawing.Size(149, 46);
            this.buttonPointeurPolynome.TabIndex = 9;
            this.buttonPointeurPolynome.Text = "Idem Pointeur";
            this.buttonPointeurPolynome.UseVisualStyleBackColor = true;
            this.buttonPointeurPolynome.Click += new System.EventHandler(this.buttonPointeurPolynome_Click);
            // 
            // buttonPointeurTrigonometrique
            // 
            this.buttonPointeurTrigonometrique.Location = new System.Drawing.Point(250, 353);
            this.buttonPointeurTrigonometrique.Name = "buttonPointeurTrigonometrique";
            this.buttonPointeurTrigonometrique.Size = new System.Drawing.Size(149, 42);
            this.buttonPointeurTrigonometrique.TabIndex = 10;
            this.buttonPointeurTrigonometrique.Text = "Idem Pointeur";
            this.buttonPointeurTrigonometrique.UseVisualStyleBackColor = true;
            this.buttonPointeurTrigonometrique.Click += new System.EventHandler(this.buttonPointeurTrigonometrique_Click);
            // 
            // EcranIntegration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 409);
            this.Controls.Add(this.buttonPointeurTrigonometrique);
            this.Controls.Add(this.buttonPointeurPolynome);
            this.Controls.Add(this.buttonTrigonometrique);
            this.Controls.Add(this.buttonPolynome);
            this.Controls.Add(this.listBoxResultats);
            this.Controls.Add(this.textBoxNbInt);
            this.Controls.Add(this.labelNbInt);
            this.Controls.Add(this.textBoxDroite);
            this.Controls.Add(this.labelDroite);
            this.Controls.Add(this.textBoxGauche);
            this.Controls.Add(this.labelGauche);
            this.Name = "EcranIntegration";
            this.Text = "EcranIntegration";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label labelGauche;
        private System.Windows.Forms.TextBox textBoxGauche;
        private System.Windows.Forms.TextBox textBoxDroite;
        private System.Windows.Forms.Label labelDroite;
        private System.Windows.Forms.TextBox textBoxNbInt;
        private System.Windows.Forms.Label labelNbInt;
        private System.Windows.Forms.ListBox listBoxResultats;
        private System.Windows.Forms.Button buttonPolynome;
        private System.Windows.Forms.Button buttonTrigonometrique;
        private System.Windows.Forms.Button buttonPointeurPolynome;
        private System.Windows.Forms.Button buttonPointeurTrigonometrique;
    }
}