namespace Bel_Prog
{
    partial class EcranPrincipal
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
            menuStripTopBar = new MenuStrip();
            controlesStripMenuItem = new ToolStripMenuItem();
            listesStripMenuItem = new ToolStripMenuItem();
            barreDeProgressionStripMenuItem = new ToolStripMenuItem();
            splitStripMenuItem = new ToolStripSeparator();
            quiterStripMenuItem = new ToolStripMenuItem();
            applicationsStripMenuItem = new ToolStripMenuItem();
            editeurStripMenuItem = new ToolStripMenuItem();
            spirographeStripMenuItem = new ToolStripMenuItem();
            horlogeStripMenuItem = new ToolStripMenuItem();
            clavierSourisMenuItem = new ToolStripMenuItem();
            aideStripMenuItem = new ToolStripMenuItem();
            aProposStripMenuItem = new ToolStripMenuItem();
            baseDeDonneeStripMenuItem = new ToolStripMenuItem();
            menuStripTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripTopBar
            // 
            menuStripTopBar.ImageScalingSize = new Size(20, 20);
            menuStripTopBar.Items.AddRange(new ToolStripItem[] { controlesStripMenuItem, applicationsStripMenuItem, aideStripMenuItem });
            menuStripTopBar.Location = new Point(0, 0);
            menuStripTopBar.Name = "menuStripTopBar";
            menuStripTopBar.Padding = new Padding(7, 3, 0, 3);
            menuStripTopBar.Size = new Size(914, 30);
            menuStripTopBar.TabIndex = 0;
            menuStripTopBar.Text = "menuStripTopBar";
            // 
            // controlesStripMenuItem
            // 
            controlesStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listesStripMenuItem, barreDeProgressionStripMenuItem, splitStripMenuItem, quiterStripMenuItem });
            controlesStripMenuItem.Name = "controlesStripMenuItem";
            controlesStripMenuItem.Size = new Size(86, 24);
            controlesStripMenuItem.Text = "Controles";
            // 
            // listesStripMenuItem
            // 
            listesStripMenuItem.Name = "listesStripMenuItem";
            listesStripMenuItem.Size = new Size(230, 26);
            listesStripMenuItem.Text = "Listes";
            listesStripMenuItem.Click += listesStripMenuItem_Click;
            // 
            // barreDeProgressionStripMenuItem
            // 
            barreDeProgressionStripMenuItem.Name = "barreDeProgressionStripMenuItem";
            barreDeProgressionStripMenuItem.Size = new Size(230, 26);
            barreDeProgressionStripMenuItem.Text = "barre de progression";
            barreDeProgressionStripMenuItem.Click += barreDeProgressionStripMenuItem_Click;
            // 
            // splitStripMenuItem
            // 
            splitStripMenuItem.Name = "splitStripMenuItem";
            splitStripMenuItem.Size = new Size(227, 6);
            // 
            // quiterStripMenuItem
            // 
            quiterStripMenuItem.Name = "quiterStripMenuItem";
            quiterStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quiterStripMenuItem.Size = new Size(230, 26);
            quiterStripMenuItem.Text = "Quiter";
            quiterStripMenuItem.Click += quiterStripMenuItem_Click;
            // 
            // applicationsStripMenuItem
            // 
            applicationsStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editeurStripMenuItem, spirographeStripMenuItem, horlogeStripMenuItem, clavierSourisMenuItem, baseDeDonneeStripMenuItem });
            applicationsStripMenuItem.Name = "applicationsStripMenuItem";
            applicationsStripMenuItem.Size = new Size(106, 24);
            applicationsStripMenuItem.Text = "Applications";
            // 
            // editeurStripMenuItem
            // 
            editeurStripMenuItem.Name = "editeurStripMenuItem";
            editeurStripMenuItem.Size = new Size(224, 26);
            editeurStripMenuItem.Text = "Editeur";
            editeurStripMenuItem.Click += editeurStripMenuItem_Click;
            // 
            // spirographeStripMenuItem
            // 
            spirographeStripMenuItem.Name = "spirographeStripMenuItem";
            spirographeStripMenuItem.Size = new Size(224, 26);
            spirographeStripMenuItem.Text = "Spirographe";
            spirographeStripMenuItem.Click += spirographeStripMenuItem_Click;
            // 
            // horlogeStripMenuItem
            // 
            horlogeStripMenuItem.Name = "horlogeStripMenuItem";
            horlogeStripMenuItem.Size = new Size(224, 26);
            horlogeStripMenuItem.Text = "Horloge";
            horlogeStripMenuItem.Click += horlogeStripMenuItem_Click;
            // 
            // clavierSourisMenuItem
            // 
            clavierSourisMenuItem.Name = "clavierSourisMenuItem";
            clavierSourisMenuItem.Size = new Size(224, 26);
            clavierSourisMenuItem.Text = "ClavierSouris";
            clavierSourisMenuItem.Click += clavierSourisMenuItem_Click;
            // 
            // aideStripMenuItem
            // 
            aideStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aProposStripMenuItem });
            aideStripMenuItem.Name = "aideStripMenuItem";
            aideStripMenuItem.Size = new Size(54, 24);
            aideStripMenuItem.Text = "Aide";
            // 
            // aProposStripMenuItem
            // 
            aProposStripMenuItem.Name = "aProposStripMenuItem";
            aProposStripMenuItem.Size = new Size(152, 26);
            aProposStripMenuItem.Text = "A Propos";
            aProposStripMenuItem.Click += aProposStripMenuItem_Click;
            // 
            // baseDeDonneeStripMenuItem
            // 
            baseDeDonneeStripMenuItem.Name = "baseDeDonneeStripMenuItem";
            baseDeDonneeStripMenuItem.Size = new Size(224, 26);
            baseDeDonneeStripMenuItem.Text = "BaseDeDonnee";
            baseDeDonneeStripMenuItem.Click += baseDeDonneeStripMenuItem_Click;
            // 
            // EcranPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStripTopBar);
            MainMenuStrip = menuStripTopBar;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EcranPrincipal";
            Text = "Controls";
            menuStripTopBar.ResumeLayout(false);
            menuStripTopBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripTopBar;
        private ToolStripMenuItem controlesStripMenuItem;
        private ToolStripMenuItem listesStripMenuItem;
        private ToolStripMenuItem barreDeProgressionStripMenuItem;
        private ToolStripSeparator splitStripMenuItem;
        private ToolStripMenuItem quiterStripMenuItem;
        private ToolStripMenuItem applicationsStripMenuItem;
        private ToolStripMenuItem editeurStripMenuItem;
        private ToolStripMenuItem aideStripMenuItem;
        private ToolStripMenuItem aProposStripMenuItem;
        private ToolStripMenuItem spirographeStripMenuItem;
        private ToolStripMenuItem horlogeStripMenuItem;
        private ToolStripMenuItem clavierSourisMenuItem;
        private ToolStripMenuItem baseDeDonneeStripMenuItem;
    }
}