namespace Bel_Prog
{
    partial class ClavierSouris
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
            this.panel = new System.Windows.Forms.Panel();
            this.clavierListBox = new System.Windows.Forms.ListBox();
            this.interceptionLabel = new System.Windows.Forms.Label();
            this.clicGaucheLabel = new System.Windows.Forms.Label();
            this.clicDroitLabel = new System.Windows.Forms.Label();
            this.positionXLabel = new System.Windows.Forms.Label();
            this.positionYLabel = new System.Windows.Forms.Label();
            this.leftClickTextBox = new System.Windows.Forms.TextBox();
            this.rightClickTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(237, 106);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(466, 321);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // clavierListBox
            // 
            this.clavierListBox.FormattingEnabled = true;
            this.clavierListBox.ItemHeight = 15;
            this.clavierListBox.Location = new System.Drawing.Point(12, 27);
            this.clavierListBox.Name = "clavierListBox";
            this.clavierListBox.Size = new System.Drawing.Size(191, 364);
            this.clavierListBox.TabIndex = 1;
            // 
            // interceptionLabel
            // 
            this.interceptionLabel.AutoSize = true;
            this.interceptionLabel.Location = new System.Drawing.Point(12, 9);
            this.interceptionLabel.Name = "interceptionLabel";
            this.interceptionLabel.Size = new System.Drawing.Size(109, 15);
            this.interceptionLabel.TabIndex = 2;
            this.interceptionLabel.Text = "Interception clavier";
            // 
            // clicGaucheLabel
            // 
            this.clicGaucheLabel.AutoSize = true;
            this.clicGaucheLabel.Location = new System.Drawing.Point(237, 27);
            this.clicGaucheLabel.Name = "clicGaucheLabel";
            this.clicGaucheLabel.Size = new System.Drawing.Size(69, 15);
            this.clicGaucheLabel.TabIndex = 3;
            this.clicGaucheLabel.Text = "Clic gauche";
            // 
            // clicDroitLabel
            // 
            this.clicDroitLabel.AutoSize = true;
            this.clicDroitLabel.Location = new System.Drawing.Point(325, 27);
            this.clicDroitLabel.Name = "clicDroitLabel";
            this.clicDroitLabel.Size = new System.Drawing.Size(56, 15);
            this.clicDroitLabel.TabIndex = 4;
            this.clicDroitLabel.Text = "Clic Droit";
            // 
            // positionXLabel
            // 
            this.positionXLabel.AutoSize = true;
            this.positionXLabel.Location = new System.Drawing.Point(414, 27);
            this.positionXLabel.Name = "positionXLabel";
            this.positionXLabel.Size = new System.Drawing.Size(60, 15);
            this.positionXLabel.TabIndex = 5;
            this.positionXLabel.Text = "Position X";
            // 
            // positionYLabel
            // 
            this.positionYLabel.AutoSize = true;
            this.positionYLabel.Location = new System.Drawing.Point(508, 27);
            this.positionYLabel.Name = "positionYLabel";
            this.positionYLabel.Size = new System.Drawing.Size(60, 15);
            this.positionYLabel.TabIndex = 6;
            this.positionYLabel.Text = "Position Y";
            // 
            // leftClickTextBox
            // 
            this.leftClickTextBox.Location = new System.Drawing.Point(237, 56);
            this.leftClickTextBox.Name = "leftClickTextBox";
            this.leftClickTextBox.ReadOnly = true;
            this.leftClickTextBox.Size = new System.Drawing.Size(69, 23);
            this.leftClickTextBox.TabIndex = 7;
            // 
            // rightClickTextBox
            // 
            this.rightClickTextBox.Location = new System.Drawing.Point(325, 56);
            this.rightClickTextBox.Name = "rightClickTextBox";
            this.rightClickTextBox.ReadOnly = true;
            this.rightClickTextBox.Size = new System.Drawing.Size(69, 23);
            this.rightClickTextBox.TabIndex = 8;
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(414, 56);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.ReadOnly = true;
            this.XTextBox.Size = new System.Drawing.Size(69, 23);
            this.XTextBox.TabIndex = 9;
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(508, 56);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.ReadOnly = true;
            this.YTextBox.Size = new System.Drawing.Size(69, 23);
            this.YTextBox.TabIndex = 10;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(601, 56);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(102, 23);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Remise à zéro";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // ClavierSouris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.rightClickTextBox);
            this.Controls.Add(this.leftClickTextBox);
            this.Controls.Add(this.positionYLabel);
            this.Controls.Add(this.positionXLabel);
            this.Controls.Add(this.clicDroitLabel);
            this.Controls.Add(this.clicGaucheLabel);
            this.Controls.Add(this.interceptionLabel);
            this.Controls.Add(this.clavierListBox);
            this.Controls.Add(this.panel);
            this.Name = "ClavierSouris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClavierSouris_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClavierSouris_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ClavierSouris_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ListBox clavierListBox;
        private System.Windows.Forms.Label interceptionLabel;
        private System.Windows.Forms.Label clicGaucheLabel;
        private System.Windows.Forms.Label clicDroitLabel;
        private System.Windows.Forms.Label positionXLabel;
        private System.Windows.Forms.Label positionYLabel;
        private System.Windows.Forms.TextBox leftClickTextBox;
        private System.Windows.Forms.TextBox rightClickTextBox;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.Button resetButton;
    }
}