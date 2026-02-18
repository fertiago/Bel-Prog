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
            exitListButton = new Button();
            detailsListGroup = new GroupBox();
            cancelDetailsListButton = new Button();
            confirmDetailsListButton = new Button();
            nameDetailsListTextBox = new TextBox();
            nameDetailsListLabel = new Label();
            titleDetailsListLabel = new Label();
            titleDetailsListCombo = new ComboBox();
            deleteListButton = new Button();
            menuStrip = new MenuStrip();
            fichierStripMenuItem = new ToolStripMenuItem();
            editionStripMenuItem = new ToolStripMenuItem();
            openStripMenuItem = new ToolStripMenuItem();
            saveStripMenuItem = new ToolStripMenuItem();
            ajouterStripMenuItem = new ToolStripMenuItem();
            supprimerStripMenuItem = new ToolStripMenuItem();
            confirmerStripMenuItem = new ToolStripMenuItem();
            annulerStripMenuItem = new ToolStripMenuItem();
            splitStripSeparator = new ToolStripSeparator();
            exitStripMenuItem = new ToolStripMenuItem();
            detailsListGroup.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // filenameListLabel
            // 
            filenameListLabel.AutoSize = true;
            filenameListLabel.Location = new Point(12, 24);
            filenameListLabel.Name = "filenameListLabel";
            filenameListLabel.Size = new Size(89, 15);
            filenameListLabel.TabIndex = 0;
            filenameListLabel.Text = "Nom du Fichier";
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(12, 42);
            listBox.Name = "listBox";
            listBox.Size = new Size(280, 109);
            listBox.TabIndex = 1;
            listBox.Sorted = true;
            listBox.SelectedIndexChanged += new EventHandler(listBox_SelectedIndexChanged);
            listBox.MouseDoubleClick += new MouseEventHandler(listBox_MouseDoubleClick);
            // 
            // openListButton
            // 
            openListButton.Location = new Point(12, 157);
            openListButton.Name = "openListButton";
            openListButton.Size = new Size(89, 23);
            openListButton.TabIndex = 2;
            openListButton.Text = "Ouvrir";
            openListButton.Click += new System.EventHandler(this.openListButton_Click);
            openListButton.UseVisualStyleBackColor = true;
            // 
            // saveListButton
            // 
            saveListButton.Location = new Point(12, 186);
            saveListButton.Name = "saveListButton";
            saveListButton.Size = new Size(89, 23);
            saveListButton.TabIndex = 3;
            saveListButton.Text = "Enregistrer";
            saveListButton.Click += new System.EventHandler(this.saveListButton_Click);
            saveListButton.UseVisualStyleBackColor = true;
            // 
            // addListButton
            // 
            addListButton.Location = new Point(12, 215);
            addListButton.Name = "addListButton";
            addListButton.Size = new Size(89, 23);
            addListButton.TabIndex = 5;
            addListButton.Text = "Ajouter";
            addListButton.UseVisualStyleBackColor = true;
            addListButton.Click += addListButton_Click;
            // 
            // exitListButton
            // 
            exitListButton.Location = new Point(12, 273);
            exitListButton.Name = "exitListButton";
            exitListButton.Size = new Size(89, 23);
            exitListButton.TabIndex = 6;
            exitListButton.Text = "Quitter";
            exitListButton.UseVisualStyleBackColor = true;
            exitListButton.Click += exitListButton_Click;
            // 
            // detailsListGroup
            // 
            detailsListGroup.Controls.Add(cancelDetailsListButton);
            detailsListGroup.Controls.Add(confirmDetailsListButton);
            detailsListGroup.Controls.Add(nameDetailsListTextBox);
            detailsListGroup.Controls.Add(nameDetailsListLabel);
            detailsListGroup.Controls.Add(titleDetailsListLabel);
            detailsListGroup.Controls.Add(titleDetailsListCombo);
            detailsListGroup.Enabled = false;
            detailsListGroup.Location = new Point(111, 157);
            detailsListGroup.Name = "detailsListGroup";
            detailsListGroup.Size = new Size(185, 141);
            detailsListGroup.TabIndex = 7;
            detailsListGroup.TabStop = false;
            detailsListGroup.Text = "Details";
            // 
            // cancelDetailsListButton
            // 
            cancelDetailsListButton.Enabled = false;
            cancelDetailsListButton.Location = new Point(104, 112);
            cancelDetailsListButton.Name = "cancelDetailsListButton";
            cancelDetailsListButton.Size = new Size(75, 23);
            cancelDetailsListButton.TabIndex = 5;
            cancelDetailsListButton.Text = "Annuler";
            cancelDetailsListButton.UseVisualStyleBackColor = true;
            cancelDetailsListButton.Click += cancelDetailsListButton_Click;
            // 
            // confirmDetailsListButton
            // 
            confirmDetailsListButton.Enabled = false;
            confirmDetailsListButton.Location = new Point(6, 112);
            confirmDetailsListButton.Name = "confirmDetailsListButton";
            confirmDetailsListButton.Size = new Size(75, 23);
            confirmDetailsListButton.TabIndex = 4;
            confirmDetailsListButton.Text = "Confirmer";
            confirmDetailsListButton.UseVisualStyleBackColor = true;
            confirmDetailsListButton.Click += confirmDetailsListButton_Click;
            // 
            // nameDetailsListTextBox
            // 
            nameDetailsListTextBox.Enabled = false;
            nameDetailsListTextBox.Location = new Point(6, 84);
            nameDetailsListTextBox.Name = "nameDetailsListTextBox";
            nameDetailsListTextBox.Size = new Size(173, 23);
            nameDetailsListTextBox.TabIndex = 3;
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
            // titleDetailsListLabel
            // 
            titleDetailsListLabel.AutoSize = true;
            titleDetailsListLabel.Location = new Point(11, 22);
            titleDetailsListLabel.Name = "titleDetailsListLabel";
            titleDetailsListLabel.Size = new Size(45, 15);
            titleDetailsListLabel.TabIndex = 1;
            titleDetailsListLabel.Text = "Qualite";
            // 
            // titleDetailsListCombo
            // 
            titleDetailsListCombo.Enabled = false;
            titleDetailsListCombo.FormattingEnabled = true;
            titleDetailsListCombo.Location = new Point(6, 40);
            titleDetailsListCombo.Name = "titleDetailsListCombo";
            titleDetailsListCombo.Size = new Size(173, 23);
            titleDetailsListCombo.TabIndex = 0;
            // 
            // deleteListButton
            // 
            deleteListButton.Enabled = false;
            deleteListButton.Location = new Point(12, 244);
            deleteListButton.Name = "deleteListButton";
            deleteListButton.Size = new Size(89, 23);
            deleteListButton.TabIndex = 8;
            deleteListButton.Text = "Supprimer";
            deleteListButton.UseVisualStyleBackColor = true;
            deleteListButton.Click += deleteListButton_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fichierStripMenuItem, editionStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(308, 24);
            menuStrip.TabIndex = 9;
            menuStrip.Text = "menuStrip";
            // 
            // fichierStripMenuItem
            // 
            fichierStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openStripMenuItem, saveStripMenuItem, splitStripSeparator, exitStripMenuItem });
            fichierStripMenuItem.Name = "fichierStripMenuItem";
            fichierStripMenuItem.Size = new Size(54, 20);
            fichierStripMenuItem.Text = "Fichier";
            // 
            // editionStripMenuItem
            // 
            editionStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterStripMenuItem, supprimerStripMenuItem, confirmerStripMenuItem, annulerStripMenuItem });
            editionStripMenuItem.Name = "editionStripMenuItem";
            editionStripMenuItem.Size = new Size(56, 20);
            editionStripMenuItem.Text = "Edition";
            // 
            // openStripMenuItem
            // 
            openStripMenuItem.Name = "openStripMenuItem";
            openStripMenuItem.Size = new Size(180, 22);
            openStripMenuItem.Text = "Ouvrir";
            openStripMenuItem.Click += new System.EventHandler(this.openListButton_Click);
            openStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            // 
            // saveStripMenuItem
            // 
            saveStripMenuItem.Name = "saveStripMenuItem";
            saveStripMenuItem.Size = new Size(180, 22);
            saveStripMenuItem.Text = "Enregister";
            saveStripMenuItem.Click += new System.EventHandler(this.saveListButton_Click);
            saveStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            // 
            // ajouterStripMenuItem
            // 
            ajouterStripMenuItem.Name = "ajouterStripMenuItem";
            ajouterStripMenuItem.Size = new Size(180, 22);
            ajouterStripMenuItem.Text = "Ajouter";
            // 
            // supprimerStripMenuItem
            // 
            supprimerStripMenuItem.Name = "supprimerStripMenuItem";
            supprimerStripMenuItem.Size = new Size(180, 22);
            supprimerStripMenuItem.Text = "Supprimer";
            supprimerStripMenuItem.Click += deleteListButton_Click;
            supprimerStripMenuItem.ShortcutKeys = Keys.Control | Keys.Delete;
            // 
            // confirmerStripMenuItem
            // 
            confirmerStripMenuItem.Name = "confirmerStripMenuItem";
            confirmerStripMenuItem.Size = new Size(180, 22);
            confirmerStripMenuItem.Text = "Confirmer";
            confirmerStripMenuItem.Click += confirmDetailsListButton_Click;
            confirmerStripMenuItem.ShortcutKeys = Keys.Control | Keys.Enter;
            // 
            // annulerStripMenuItem
            // 
            annulerStripMenuItem.Name = "annulerStripMenuItem";
            annulerStripMenuItem.Size = new Size(180, 22);
            annulerStripMenuItem.Text = "Annuler";
            annulerStripMenuItem.Click += cancelDetailsListButton_Click;
            annulerStripMenuItem.ShortcutKeys = Keys.Control | Keys.Escape;
            // 
            // splitStripSeparator
            // 
            splitStripSeparator.Name = "splitStripSeparator";
            splitStripSeparator.Size = new Size(179, 6);
            // 
            // exitStripMenuItem
            // 
            exitStripMenuItem.Name = "exitStripMenuItem";
            exitStripMenuItem.Size = new Size(180, 22);
            exitStripMenuItem.Text = "Quitter";
            exitStripMenuItem.Click += exitListButton_Click;
            exitStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            // 
            // ManipulationListe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 310);
            Controls.Add(deleteListButton);
            Controls.Add(detailsListGroup);
            Controls.Add(exitListButton);
            Controls.Add(addListButton);
            Controls.Add(saveListButton);
            Controls.Add(openListButton);
            Controls.Add(listBox);
            Controls.Add(filenameListLabel);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "ManipulationListe";
            Text = "ManipulationListe";
            detailsListGroup.ResumeLayout(false);
            detailsListGroup.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label filenameListLabel;
        private ListBox listBox;
        private Button openListButton;
        private Button saveListButton;
        private Button addListButton;
        private Button exitListButton;
        private GroupBox detailsListGroup;
        private Label titleDetailsListLabel;
        private ComboBox titleDetailsListCombo;
        private TextBox nameDetailsListTextBox;
        private Label nameDetailsListLabel;
        private Button cancelDetailsListButton;
        private Button confirmDetailsListButton;
        private Button deleteListButton;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fichierStripMenuItem;
        private ToolStripMenuItem openStripMenuItem;
        private ToolStripMenuItem saveStripMenuItem;
        private ToolStripMenuItem exitStripMenuItem;
        private ToolStripMenuItem editionStripMenuItem;
        private ToolStripMenuItem ajouterStripMenuItem;
        private ToolStripMenuItem supprimerStripMenuItem;
        private ToolStripMenuItem confirmerStripMenuItem;
        private ToolStripMenuItem annulerStripMenuItem;
        private ToolStripSeparator splitStripSeparator;
    }
}