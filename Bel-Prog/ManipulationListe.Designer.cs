namespace Bel_Prog
{
    partial class ManipulationListe
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
            filenameListLabel = new Label();
            listBox = new ListBox();
            openListButton = new Button();
            saveListButton = new Button();
            addListButton = new Button();
            exitListLabel = new Button();
            detailsListGroup = new GroupBox();
            qualityDetailsListCombo = new ComboBox();
            qualityDetailsListLabel = new Label();
            nameDetailsListLabel = new Label();
            nameDetailsListCombo = new ComboBox();
            confirmDetailsListButton = new Button();
            cancelDetailsListButton = new Button();
            detailsListGroup.SuspendLayout();
            SuspendLayout();
            // 
            // filenameListLabel
            // 
            filenameListLabel.AutoSize = true;
            filenameListLabel.Location = new Point(12, 9);
            filenameListLabel.Name = "filenameListLabel";
            filenameListLabel.Size = new Size(89, 15);
            filenameListLabel.TabIndex = 0;
            filenameListLabel.Text = "Nom du Fichier";
            filenameListLabel.Click += label1_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(12, 27);
            listBox.Name = "listBox";
            listBox.Size = new Size(280, 109);
            listBox.TabIndex = 1;
            // 
            // openListButton
            // 
            openListButton.Location = new Point(12, 142);
            openListButton.Name = "openListButton";
            openListButton.Size = new Size(89, 23);
            openListButton.TabIndex = 2;
            openListButton.Text = "Ouvrir";
            openListButton.UseVisualStyleBackColor = true;
            // 
            // saveListButton
            // 
            saveListButton.Location = new Point(12, 171);
            saveListButton.Name = "saveListButton";
            saveListButton.Size = new Size(89, 23);
            saveListButton.TabIndex = 3;
            saveListButton.Text = "Enregistrer";
            saveListButton.UseVisualStyleBackColor = true;
            // 
            // addListButton
            // 
            addListButton.Location = new Point(12, 229);
            addListButton.Name = "addListButton";
            addListButton.Size = new Size(89, 23);
            addListButton.TabIndex = 5;
            addListButton.Text = "Ajouter";
            addListButton.UseVisualStyleBackColor = true;
            // 
            // exitListLabel
            // 
            exitListLabel.Location = new Point(12, 258);
            exitListLabel.Name = "exitListLabel";
            exitListLabel.Size = new Size(89, 23);
            exitListLabel.TabIndex = 6;
            exitListLabel.Text = "Quitter";
            exitListLabel.UseVisualStyleBackColor = true;
            // 
            // detailsListGroup
            // 
            detailsListGroup.Controls.Add(cancelDetailsListButton);
            detailsListGroup.Controls.Add(confirmDetailsListButton);
            detailsListGroup.Controls.Add(nameDetailsListCombo);
            detailsListGroup.Controls.Add(nameDetailsListLabel);
            detailsListGroup.Controls.Add(qualityDetailsListLabel);
            detailsListGroup.Controls.Add(qualityDetailsListCombo);
            detailsListGroup.Location = new Point(107, 142);
            detailsListGroup.Name = "detailsListGroup";
            detailsListGroup.Size = new Size(185, 141);
            detailsListGroup.TabIndex = 7;
            detailsListGroup.TabStop = false;
            detailsListGroup.Text = "Details";
            // 
            // qualityDetailsListCombo
            // 
            qualityDetailsListCombo.FormattingEnabled = true;
            qualityDetailsListCombo.Location = new Point(6, 40);
            qualityDetailsListCombo.Name = "qualityDetailsListCombo";
            qualityDetailsListCombo.Size = new Size(173, 23);
            qualityDetailsListCombo.TabIndex = 0;
            // 
            // qualityDetailsListLabel
            // 
            qualityDetailsListLabel.AutoSize = true;
            qualityDetailsListLabel.Location = new Point(11, 22);
            qualityDetailsListLabel.Name = "qualityDetailsListLabel";
            qualityDetailsListLabel.Size = new Size(45, 15);
            qualityDetailsListLabel.TabIndex = 1;
            qualityDetailsListLabel.Text = "Qualite";
            // 
            // nameDetailsListLabel
            // 
            nameDetailsListLabel.AutoSize = true;
            nameDetailsListLabel.Location = new Point(11, 66);
            nameDetailsListLabel.Name = "nameDetailsListLabel";
            nameDetailsListLabel.Size = new Size(34, 15);
            nameDetailsListLabel.TabIndex = 2;
            nameDetailsListLabel.Text = "Nom";
            // 
            // nameDetailsListCombo
            // 
            nameDetailsListCombo.FormattingEnabled = true;
            nameDetailsListCombo.Location = new Point(6, 84);
            nameDetailsListCombo.Name = "nameDetailsListCombo";
            nameDetailsListCombo.Size = new Size(173, 23);
            nameDetailsListCombo.TabIndex = 3;
            // 
            // confirmDetailsListButton
            // 
            confirmDetailsListButton.Location = new Point(6, 112);
            confirmDetailsListButton.Name = "confirmDetailsListButton";
            confirmDetailsListButton.Size = new Size(75, 23);
            confirmDetailsListButton.TabIndex = 4;
            confirmDetailsListButton.Text = "Confirmer";
            confirmDetailsListButton.UseVisualStyleBackColor = true;
            // 
            // cancelDetailsListButton
            // 
            cancelDetailsListButton.Location = new Point(104, 112);
            cancelDetailsListButton.Name = "cancelDetailsListButton";
            cancelDetailsListButton.Size = new Size(75, 23);
            cancelDetailsListButton.TabIndex = 5;
            cancelDetailsListButton.Text = "Annuler";
            cancelDetailsListButton.UseVisualStyleBackColor = true;
            // 
            // ManipulationListe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 295);
            Controls.Add(detailsListGroup);
            Controls.Add(exitListLabel);
            Controls.Add(addListButton);
            Controls.Add(saveListButton);
            Controls.Add(openListButton);
            Controls.Add(listBox);
            Controls.Add(filenameListLabel);
            Name = "ManipulationListe";
            Text = "ManipulationListe";
            detailsListGroup.ResumeLayout(false);
            detailsListGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label filenameListLabel;
        private ListBox listBox;
        private Button openListButton;
        private Button saveListButton;
        private Button addListButton;
        private Button exitListLabel;
        private GroupBox detailsListGroup;
        private Label qualityDetailsListLabel;
        private ComboBox qualityDetailsListCombo;
        private ComboBox nameDetailsListCombo;
        private Label nameDetailsListLabel;
        private Button cancelDetailsListButton;
        private Button confirmDetailsListButton;
    }
}