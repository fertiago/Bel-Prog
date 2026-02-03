namespace Bel_Prog
{
    partial class ControlsForm
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
            Menu = new MenuStrip();
            ControlesStrip = new ToolStripMenuItem();
            ListesStripItem = new ToolStripMenuItem();
            BarresDeProgressionStripItem = new ToolStripMenuItem();
            SeparateurStripItem = new ToolStripMenuItem();
            QuitterStripItem = new ToolStripMenuItem();
            ApplicationsStrip = new ToolStripMenuItem();
            AideStrip = new ToolStripMenuItem();
            EditeurStripItem = new ToolStripMenuItem();
            AProposStripItem = new ToolStripMenuItem();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Items.AddRange(new ToolStripItem[] { ControlesStrip, ApplicationsStrip, AideStrip });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(800, 24);
            Menu.TabIndex = 0;
            Menu.Text = "Menu";
            // 
            // ControlesStrip
            // 
            ControlesStrip.DropDownItems.AddRange(new ToolStripItem[] { ListesStripItem, BarresDeProgressionStripItem, SeparateurStripItem, QuitterStripItem });
            ControlesStrip.Name = "ControlesStrip";
            ControlesStrip.Size = new Size(70, 20);
            ControlesStrip.Text = "Controles";
            // 
            // ListesStripItem
            // 
            ListesStripItem.Name = "ListesStripItem";
            ListesStripItem.Size = new Size(187, 22);
            ListesStripItem.Text = "Listes";
            // 
            // BarresDeProgressionStripItem
            // 
            BarresDeProgressionStripItem.Name = "BarresDeProgressionStripItem";
            BarresDeProgressionStripItem.Size = new Size(187, 22);
            BarresDeProgressionStripItem.Text = "Barres de progression";
            // 
            // SeparateurStripItem
            // 
            SeparateurStripItem.Name = "SeparateurStripItem";
            SeparateurStripItem.Size = new System.Drawing.Size(181, 6);
            // 
            // QuitterStripItem
            // 
            QuitterStripItem.Name = "QuitterStripItem";
            QuitterStripItem.Size = new Size(187, 22);
            QuitterStripItem.Text = "Quitter (CTRL + Q)";
            // 
            // ApplicationsStrip
            // 
            ApplicationsStrip.DropDownItems.AddRange(new ToolStripItem[] { EditeurStripItem });
            ApplicationsStrip.Name = "ApplicationsStrip";
            ApplicationsStrip.Size = new Size(85, 20);
            ApplicationsStrip.Text = "Applications";
            // 
            // AideStrip
            // 
            AideStrip.DropDownItems.AddRange(new ToolStripItem[] { AProposStripItem });
            AideStrip.Name = "AideStrip";
            AideStrip.Size = new Size(43, 20);
            AideStrip.Text = "Aide";
            // 
            // EditeurStripItem
            // 
            EditeurStripItem.Name = "EditeurStripItem";
            EditeurStripItem.Size = new Size(180, 22);
            EditeurStripItem.Text = "Editeur";
            // 
            // AProposStripItem
            // 
            AProposStripItem.Name = "AProposStripItem";
            AProposStripItem.Size = new Size(180, 22);
            AProposStripItem.Text = "A Propos";
            // 
            // ControlsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Menu);
            MainMenuStrip = Menu;
            Name = "ControlsForm";
            Text = "Controls";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem ControlesStrip;
        private ToolStripMenuItem ApplicationsStrip;
        private ToolStripMenuItem AideStrip;
        private ToolStripMenuItem ListesStripItem;
        private ToolStripMenuItem BarresDeProgressionStripItem;
        private ToolStripMenuItem SeparateurStripItem;
        private ToolStripMenuItem QuitterStripItem;
        private ToolStripMenuItem EditeurStripItem;
        private ToolStripMenuItem AProposStripItem;
    }
}