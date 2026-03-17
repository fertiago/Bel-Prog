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
            aideStripMenuItem = new ToolStripMenuItem();
            aProposStripMenuItem = new ToolStripMenuItem();
            menuStripTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripTopBar
            // 
            menuStripTopBar.Items.AddRange(new ToolStripItem[] { controlesStripMenuItem, applicationsStripMenuItem, aideStripMenuItem });
            menuStripTopBar.Location = new Point(0, 0);
            menuStripTopBar.Name = "menuStripTopBar";
            menuStripTopBar.Size = new Size(800, 24);
            menuStripTopBar.TabIndex = 0;
            menuStripTopBar.Text = "menuStripTopBar";
            // 
            // controlesStripMenuItem
            // 
            controlesStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listesStripMenuItem, barreDeProgressionStripMenuItem, splitStripMenuItem, quiterStripMenuItem });
            controlesStripMenuItem.Name = "controlesStripMenuItem";
            controlesStripMenuItem.Size = new Size(70, 20);
            controlesStripMenuItem.Text = "Controles";
            // 
            // listesStripMenuItem
            // 
            listesStripMenuItem.Name = "listesStripMenuItem";
            listesStripMenuItem.Size = new Size(182, 22);
            listesStripMenuItem.Text = "Listes";
            listesStripMenuItem.Click += listesStripMenuItem_Click;
            // 
            // barreDeProgressionStripMenuItem
            // 
            barreDeProgressionStripMenuItem.Name = "barreDeProgressionStripMenuItem";
            barreDeProgressionStripMenuItem.Size = new Size(182, 22);
            barreDeProgressionStripMenuItem.Text = "barre de progression";
            barreDeProgressionStripMenuItem.Click += barreDeProgressionStripMenuItem_Click;
            // 
            // splitStripMenuItem
            // 
            splitStripMenuItem.Name = "splitStripMenuItem";
            splitStripMenuItem.Size = new Size(179, 6);
            // 
            // quiterStripMenuItem
            // 
            quiterStripMenuItem.Name = "quiterStripMenuItem";
            quiterStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quiterStripMenuItem.Size = new Size(182, 22);
            quiterStripMenuItem.Text = "Quiter";
            quiterStripMenuItem.Click += quiterStripMenuItem_Click;
            // 
            // applicationsStripMenuItem
            // 
            applicationsStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editeurStripMenuItem, spirographeStripMenuItem, horlogeStripMenuItem });
            applicationsStripMenuItem.Name = "applicationsStripMenuItem";
            applicationsStripMenuItem.Size = new Size(85, 20);
            applicationsStripMenuItem.Text = "Applications";
            // 
            // editeurStripMenuItem
            // 
            editeurStripMenuItem.Name = "editeurStripMenuItem";
            editeurStripMenuItem.Size = new Size(180, 22);
            editeurStripMenuItem.Text = "Editeur";
            editeurStripMenuItem.Click += editeurStripMenuItem_Click;
            // 
            // spirographeStripMenuItem
            // 
            spirographeStripMenuItem.Name = "spirographeStripMenuItem";
            spirographeStripMenuItem.Size = new Size(180, 22);
            spirographeStripMenuItem.Text = "Spirographe";
            spirographeStripMenuItem.Click += spirographeStripMenuItem_Click;
            // 
            // horlogeStripMenuItem
            // 
            horlogeStripMenuItem.Name = "horlogeStripMenuItem";
            horlogeStripMenuItem.Size = new Size(180, 22);
            horlogeStripMenuItem.Text = "Horloge";
            horlogeStripMenuItem.Click += new System.EventHandler(this.horlogeStripMenuItem_Click);
            // 
            // aideStripMenuItem
            // 
            aideStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aProposStripMenuItem });
            aideStripMenuItem.Name = "aideStripMenuItem";
            aideStripMenuItem.Size = new Size(43, 20);
            aideStripMenuItem.Text = "Aide";
            // 
            // aProposStripMenuItem
            // 
            aProposStripMenuItem.Name = "aProposStripMenuItem";
            aProposStripMenuItem.Size = new Size(122, 22);
            aProposStripMenuItem.Text = "A Propos";
            aProposStripMenuItem.Click += aProposStripMenuItem_Click;
            // 
            // EcranPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStripTopBar);
            MainMenuStrip = menuStripTopBar;
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
    }
}