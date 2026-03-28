namespace Bel_Prog
{
    partial class EcranDbDirect
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
            dbListBox = new ListBox();
            consulterButton = new Button();
            denombrerButton = new Button();
            ajouterButton = new Button();
            nomTextBox = new TextBox();
            prenomTextBox = new TextBox();
            nomLabel = new Label();
            prenomLabel = new Label();
            urlLabel = new Label();
            portLabel = new Label();
            utilisateurLabel = new Label();
            motdepasseLabel = new Label();
            urlTextBox = new TextBox();
            portTextBox = new TextBox();
            utilisateurTextBox = new TextBox();
            motdepasseTextBox = new TextBox();
            dbGroupBox = new GroupBox();
            connectionButton = new Button();
            dbGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // dbListBox
            // 
            dbListBox.FormattingEnabled = true;
            dbListBox.Location = new Point(12, 6);
            dbListBox.Name = "dbListBox";
            dbListBox.Size = new Size(288, 424);
            dbListBox.TabIndex = 0;
            // 
            // consulterButton
            // 
            consulterButton.Location = new Point(306, 6);
            consulterButton.Name = "consulterButton";
            consulterButton.Size = new Size(125, 29);
            consulterButton.TabIndex = 1;
            consulterButton.Text = "Consulter";
            consulterButton.UseVisualStyleBackColor = true;
            // 
            // denombrerButton
            // 
            denombrerButton.Location = new Point(306, 41);
            denombrerButton.Name = "denombrerButton";
            denombrerButton.Size = new Size(125, 29);
            denombrerButton.TabIndex = 2;
            denombrerButton.Text = "Denombrer";
            denombrerButton.UseVisualStyleBackColor = true;
            // 
            // ajouterButton
            // 
            ajouterButton.Location = new Point(306, 401);
            ajouterButton.Name = "ajouterButton";
            ajouterButton.Size = new Size(125, 29);
            ajouterButton.TabIndex = 3;
            ajouterButton.Text = "Ajouter";
            ajouterButton.UseVisualStyleBackColor = true;
            // 
            // nomTextBox
            // 
            nomTextBox.Location = new Point(306, 368);
            nomTextBox.Name = "nomTextBox";
            nomTextBox.Size = new Size(125, 27);
            nomTextBox.TabIndex = 4;
            // 
            // prenomTextBox
            // 
            prenomTextBox.Location = new Point(306, 315);
            prenomTextBox.Name = "prenomTextBox";
            prenomTextBox.Size = new Size(125, 27);
            prenomTextBox.TabIndex = 5;
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new Point(306, 345);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new Size(42, 20);
            nomLabel.TabIndex = 6;
            nomLabel.Text = "Nom";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new Point(306, 292);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new Size(60, 20);
            prenomLabel.TabIndex = 7;
            prenomLabel.Text = "Prenom";
            prenomLabel.Click += prenomLabel_Click;
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new Point(6, 26);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new Size(35, 20);
            urlLabel.TabIndex = 8;
            urlLabel.Text = "URL";
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Location = new Point(6, 79);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(35, 20);
            portLabel.TabIndex = 9;
            portLabel.Text = "Port";
            portLabel.Click += portLabel_Click;
            // 
            // utilisateurLabel
            // 
            utilisateurLabel.AutoSize = true;
            utilisateurLabel.Location = new Point(6, 132);
            utilisateurLabel.Name = "utilisateurLabel";
            utilisateurLabel.Size = new Size(76, 20);
            utilisateurLabel.TabIndex = 10;
            utilisateurLabel.Text = "Utilisateur";
            // 
            // motdepasseLabel
            // 
            motdepasseLabel.AutoSize = true;
            motdepasseLabel.Location = new Point(6, 185);
            motdepasseLabel.Name = "motdepasseLabel";
            motdepasseLabel.Size = new Size(98, 20);
            motdepasseLabel.TabIndex = 11;
            motdepasseLabel.Text = "Mot de passe";
            // 
            // urlTextBox
            // 
            urlTextBox.Location = new Point(6, 49);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(125, 27);
            urlTextBox.TabIndex = 12;
            // 
            // portTextBox
            // 
            portTextBox.Location = new Point(6, 102);
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(125, 27);
            portTextBox.TabIndex = 13;
            // 
            // utilisateurTextBox
            // 
            utilisateurTextBox.Location = new Point(6, 155);
            utilisateurTextBox.Name = "utilisateurTextBox";
            utilisateurTextBox.Size = new Size(125, 27);
            utilisateurTextBox.TabIndex = 14;
            // 
            // motdepasseTextBox
            // 
            motdepasseTextBox.Location = new Point(6, 208);
            motdepasseTextBox.Name = "motdepasseTextBox";
            motdepasseTextBox.Size = new Size(125, 27);
            motdepasseTextBox.TabIndex = 15;
            // 
            // dbGroupBox
            // 
            dbGroupBox.Controls.Add(connectionButton);
            dbGroupBox.Controls.Add(utilisateurLabel);
            dbGroupBox.Controls.Add(motdepasseTextBox);
            dbGroupBox.Controls.Add(utilisateurTextBox);
            dbGroupBox.Controls.Add(urlLabel);
            dbGroupBox.Controls.Add(portTextBox);
            dbGroupBox.Controls.Add(portLabel);
            dbGroupBox.Controls.Add(urlTextBox);
            dbGroupBox.Controls.Add(motdepasseLabel);
            dbGroupBox.Location = new Point(469, 6);
            dbGroupBox.Name = "dbGroupBox";
            dbGroupBox.Size = new Size(138, 424);
            dbGroupBox.TabIndex = 16;
            dbGroupBox.TabStop = false;
            dbGroupBox.Text = "Base de Donnee";
            // 
            // connectionButton
            // 
            connectionButton.Location = new Point(6, 389);
            connectionButton.Name = "connectionButton";
            connectionButton.Size = new Size(125, 29);
            connectionButton.TabIndex = 16;
            connectionButton.Text = "Connection";
            connectionButton.UseVisualStyleBackColor = true;
            // 
            // EcranDbDirect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dbGroupBox);
            Controls.Add(nomLabel);
            Controls.Add(prenomTextBox);
            Controls.Add(prenomLabel);
            Controls.Add(nomTextBox);
            Controls.Add(ajouterButton);
            Controls.Add(denombrerButton);
            Controls.Add(consulterButton);
            Controls.Add(dbListBox);
            Name = "EcranDbDirect";
            Text = "EcranDbDirect";
            dbGroupBox.ResumeLayout(false);
            dbGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox dbListBox;
        private Button consulterButton;
        private Button denombrerButton;
        private Button ajouterButton;
        private TextBox nomTextBox;
        private TextBox prenomTextBox;
        private Label nomLabel;
        private Label prenomLabel;
        private Label urlLabel;
        private Label portLabel;
        private Label utilisateurLabel;
        private Label motdepasseLabel;
        private TextBox urlTextBox;
        private TextBox portTextBox;
        private TextBox utilisateurTextBox;
        private TextBox motdepasseTextBox;
        private GroupBox dbGroupBox;
        private Button connectionButton;
    }
}