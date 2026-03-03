namespace Bel_Prog
{
    partial class Editeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editeur));
            menuStrip = new MenuStrip();
            fichierMenuItem = new ToolStripMenuItem();
            nouveauMenuItem = new ToolStripMenuItem();
            ouvrirMenuItem = new ToolStripMenuItem();
            enregistrerMenuItem = new ToolStripMenuItem();
            quitterMenuItem = new ToolStripMenuItem();
            editerMenuItem = new ToolStripMenuItem();
            copierMenuItem = new ToolStripMenuItem();
            collerMenuItem = new ToolStripMenuItem();
            couperMenuItem = new ToolStripMenuItem();
            formatMenuItem = new ToolStripMenuItem();
            justifierMenuItem = new ToolStripMenuItem();
            gaucheMenuItem = new ToolStripMenuItem();
            centreMenuItem = new ToolStripMenuItem();
            droiteMenuItem = new ToolStripMenuItem();
            policeMenuItem = new ToolStripMenuItem();
            caractereMenuItem = new ToolStripMenuItem();
            grasMenuItem = new ToolStripMenuItem();
            italiqueMenuItem = new ToolStripMenuItem();
            souligneMenuItem = new ToolStripMenuItem();
            barreMenuItem = new ToolStripMenuItem();
            panel = new Panel();
            quitterPicture = new PictureBox();
            ouvrirPicture = new PictureBox();
            enregistrerPicture = new PictureBox();
            nouveauPicture = new PictureBox();
            richText = new RichTextBox();
            menuStrip.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quitterPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ouvrirPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enregistrerPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nouveauPicture).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fichierMenuItem, editerMenuItem, formatMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(334, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuEditeur";
            // 
            // fichierMenuItem
            // 
            fichierMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nouveauMenuItem, ouvrirMenuItem, enregistrerMenuItem, quitterMenuItem });
            fichierMenuItem.Name = "fichierMenuItem";
            fichierMenuItem.Size = new Size(54, 20);
            fichierMenuItem.Text = "Fichier";
            // 
            // nouveauMenuItem
            // 
            nouveauMenuItem.Name = "nouveauMenuItem";
            nouveauMenuItem.Size = new Size(130, 22);
            nouveauMenuItem.Text = "Nouveau";
            nouveauMenuItem.Click += new System.EventHandler(this.nouveau_Click);
            nouveauMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            // 
            // ouvrirMenuItem
            // 
            ouvrirMenuItem.Name = "ouvrirMenuItem";
            ouvrirMenuItem.Size = new Size(130, 22);
            ouvrirMenuItem.Text = "Ouvrir";
            ouvrirMenuItem.Click += new System.EventHandler(this.ouvrir_Click);
            ouvrirMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            // 
            // enregistrerMenuItem
            // 
            enregistrerMenuItem.Name = "enregistrerMenuItem";
            enregistrerMenuItem.Size = new Size(130, 22);
            enregistrerMenuItem.Text = "Enregistrer";
            enregistrerMenuItem.Click += new System.EventHandler(this.enregistrer_Click);
            enregistrerMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            // 
            // quitterMenuItem
            // 
            quitterMenuItem.Name = "quitterMenuItem";
            quitterMenuItem.Size = new Size(130, 22);
            quitterMenuItem.Text = "Quitter";
            quitterMenuItem.Click += new System.EventHandler(this.quitter_Click);
            quitterMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            // 
            // editerMenuItem
            // 
            editerMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copierMenuItem, collerMenuItem, couperMenuItem });
            editerMenuItem.Name = "editerMenuItem";
            editerMenuItem.Size = new Size(49, 20);
            editerMenuItem.Text = "Editer";
            // 
            // copierMenuItem
            // 
            copierMenuItem.Name = "copierMenuItem";
            copierMenuItem.Size = new Size(113, 22);
            copierMenuItem.Text = "Copier";
            copierMenuItem.Click += new System.EventHandler(this.copier_Click);
            copierMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            // 
            // collerMenuItem
            // 
            collerMenuItem.Name = "collerMenuItem";
            collerMenuItem.Size = new Size(113, 22);
            collerMenuItem.Text = "Couper";
            collerMenuItem.Click += new System.EventHandler(this.coller_Click);
            collerMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            // 
            // couperMenuItem
            // 
            couperMenuItem.Name = "couperMenuItem";
            couperMenuItem.Size = new Size(113, 22);
            couperMenuItem.Text = "Coller";
            couperMenuItem.Click += new System.EventHandler(this.couper_Click);
            couperMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            // 
            // formatMenuItem
            // 
            formatMenuItem.DropDownItems.AddRange(new ToolStripItem[] { justifierMenuItem, policeMenuItem, caractereMenuItem });
            formatMenuItem.Name = "formatMenuItem";
            formatMenuItem.Size = new Size(57, 20);
            formatMenuItem.Text = "Format";
            // 
            // justifierMenuItem
            // 
            justifierMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gaucheMenuItem, centreMenuItem, droiteMenuItem });
            justifierMenuItem.Name = "justifierMenuItem";
            justifierMenuItem.Size = new Size(124, 22);
            justifierMenuItem.Text = "Justifier";
            // 
            // gaucheMenuItem
            // 
            gaucheMenuItem.Name = "gaucheMenuItem";
            gaucheMenuItem.Size = new Size(114, 22);
            gaucheMenuItem.Text = "Gauche";
            gaucheMenuItem.Click += new System.EventHandler(this.gauche_Click);
            // 
            // centreMenuItem
            // 
            centreMenuItem.Name = "centreMenuItem";
            centreMenuItem.Size = new Size(114, 22);
            centreMenuItem.Text = "Centre";
            centreMenuItem.Click += new System.EventHandler(this.centre_Click);
            // 
            // droiteMenuItem
            // 
            droiteMenuItem.Name = "droiteMenuItem";
            droiteMenuItem.Size = new Size(114, 22);
            droiteMenuItem.Text = "Droite";
            droiteMenuItem.Click += new System.EventHandler(this.droite_Click);
            // 
            // policeMenuItem
            // 
            policeMenuItem.Name = "policeMenuItem";
            policeMenuItem.Size = new Size(124, 22);
            policeMenuItem.Text = "Police";
            // 
            // caractereMenuItem
            // 
            caractereMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grasMenuItem, italiqueMenuItem, souligneMenuItem, barreMenuItem });
            caractereMenuItem.Name = "caractereMenuItem";
            caractereMenuItem.Size = new Size(124, 22);
            caractereMenuItem.Text = "Caractere";
            // 
            // grasMenuItem
            // 
            grasMenuItem.Name = "grasMenuItem";
            grasMenuItem.Size = new Size(120, 22);
            grasMenuItem.Text = "Gras";
            grasMenuItem.Click += new System.EventHandler(this.gras_Click);
            // 
            // italiqueMenuItem
            // 
            italiqueMenuItem.Name = "italiqueMenuItem";
            italiqueMenuItem.Size = new Size(120, 22);
            italiqueMenuItem.Text = "Italique";
            italiqueMenuItem.Click += new System.EventHandler(this.italique_Click);
            // 
            // souligneMenuItem
            // 
            souligneMenuItem.Name = "souligneMenuItem";
            souligneMenuItem.Size = new Size(120, 22);
            souligneMenuItem.Text = "Souligne";
            souligneMenuItem.Click += new System.EventHandler(this.souligne_Click);
            // 
            // barreMenuItem
            // 
            barreMenuItem.Name = "barreMenuItem";
            barreMenuItem.Size = new Size(120, 22);
            barreMenuItem.Text = "Barre";
            barreMenuItem.Click += new System.EventHandler(this.barre_Click);
            // 
            // panel
            // 
            panel.Controls.Add(richText);
            panel.Controls.Add(quitterPicture);
            panel.Controls.Add(ouvrirPicture);
            panel.Controls.Add(enregistrerPicture);
            panel.Controls.Add(nouveauPicture);
            panel.Location = new Point(12, 27);
            panel.Name = "panel";
            panel.Size = new Size(310, 411);
            panel.TabIndex = 1;
            // 
            // quitterPicture
            // 
            quitterPicture.Image = (Image)resources.GetObject("quitterPicture.Image");
            quitterPicture.Location = new Point(71, 3);
            quitterPicture.Name = "quitterPicture";
            quitterPicture.Size = new Size(16, 16);
            quitterPicture.TabIndex = 5;
            quitterPicture.TabStop = false;
            quitterPicture.Click += new System.EventHandler(this.quitter_Click);
            // 
            // ouvrirPicture
            // 
            ouvrirPicture.Image = (Image)resources.GetObject("ouvrirPicture.Image");
            ouvrirPicture.Location = new Point(27, 3);
            ouvrirPicture.Name = "ouvrirPicture";
            ouvrirPicture.Size = new Size(16, 16);
            ouvrirPicture.TabIndex = 3;
            ouvrirPicture.TabStop = false;
            ouvrirPicture.Click += new System.EventHandler(this.ouvrir_Click);
            // 
            // enregistrerPicture
            // 
            enregistrerPicture.Image = (Image)resources.GetObject("enregistrerPicture.Image");
            enregistrerPicture.Location = new Point(49, 3);
            enregistrerPicture.Name = "enregistrerPicture";
            enregistrerPicture.Size = new Size(16, 16);
            enregistrerPicture.TabIndex = 4;
            enregistrerPicture.TabStop = false;
            enregistrerPicture.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // nouveauPicture
            // 
            nouveauPicture.Image = (Image)resources.GetObject("nouveauPicture.Image");
            nouveauPicture.Location = new Point(5, 3);
            nouveauPicture.Name = "nouveauPicture";
            nouveauPicture.Size = new Size(16, 16);
            nouveauPicture.TabIndex = 2;
            nouveauPicture.TabStop = false;
            nouveauPicture.Click += new System.EventHandler(this.nouveau_Click);
            // 
            // richText
            // 
            richText.Location = new Point(5, 25);
            richText.Name = "richText";
            richText.Size = new Size(302, 383);
            richText.TabIndex = 6;
            richText.Text = "";
            richText.TextChanged += new EventHandler(this.richText_TextChanged);
            // 
            // Editeur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 450);
            Controls.Add(panel);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Editeur";
            Text = "Editeur";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)quitterPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)ouvrirPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)enregistrerPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)nouveauPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fichierMenuItem;
        private ToolStripMenuItem nouveauMenuItem;
        private ToolStripMenuItem ouvrirMenuItem;
        private ToolStripMenuItem enregistrerMenuItem;
        private ToolStripMenuItem quitterMenuItem;
        private ToolStripMenuItem editerMenuItem;
        private ToolStripMenuItem copierMenuItem;
        private ToolStripMenuItem collerMenuItem;
        private ToolStripMenuItem couperMenuItem;
        private ToolStripMenuItem formatMenuItem;
        private ToolStripMenuItem justifierMenuItem;
        private ToolStripMenuItem gaucheMenuItem;
        private ToolStripMenuItem centreMenuItem;
        private ToolStripMenuItem droiteMenuItem;
        private ToolStripMenuItem policeMenuItem;
        private ToolStripMenuItem caractereMenuItem;
        private ToolStripMenuItem grasMenuItem;
        private ToolStripMenuItem italiqueMenuItem;
        private ToolStripMenuItem souligneMenuItem;
        private ToolStripMenuItem barreMenuItem;
        private Panel panel;
        private PictureBox nouveauPicture;
        private PictureBox ouvrirPicture;
        private PictureBox enregistrerPicture;
        private PictureBox quitterPicture;
        private RichTextBox richText;
    }
}