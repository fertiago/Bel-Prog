using System.Windows.Forms;

namespace Bel_Prog
{
    partial class APropos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            mainPanel = new Panel();
            logoPictureBox = new PictureBox();
            descriptionLabel = new Label();
            copyrightLabel = new Label();
            versionLabel = new Label();
            titreLabel = new Label();
            confirmerButton = new Button();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BorderStyle = BorderStyle.Fixed3D;
            mainPanel.Controls.Add(logoPictureBox);
            mainPanel.Controls.Add(descriptionLabel);
            mainPanel.Controls.Add(copyrightLabel);
            mainPanel.Controls.Add(versionLabel);
            mainPanel.Controls.Add(titreLabel);
            mainPanel.Location = new Point(14, 16);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(375, 208);
            mainPanel.TabIndex = 0;
            mainPanel.MouseEnter += panel_MouseEnter;
            mainPanel.MouseLeave += panel_MouseLeave;
            // 
            // logoPictureBox
            // 
            logoPictureBox.BackColor = Color.Navy;
            logoPictureBox.Location = new Point(44, 27);
            logoPictureBox.Margin = new Padding(3, 4, 3, 4);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(118, 88);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 4;
            logoPictureBox.TabStop = false;
            // 
            // descriptionLabel
            // 
            descriptionLabel.Font = new Font("Segoe UI", 8.25F);
            descriptionLabel.Location = new Point(44, 164);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(281, 40);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Et l'application se dit qu'un jour, elle\r\ndeviendra aussi grande que .NET";
            descriptionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // copyrightLabel
            // 
            copyrightLabel.AutoSize = true;
            copyrightLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            copyrightLabel.Location = new Point(119, 119);
            copyrightLabel.Name = "copyrightLabel";
            copyrightLabel.Size = new Size(131, 20);
            copyrightLabel.TabIndex = 2;
            copyrightLabel.Text = "CopyRight NADA";
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Font = new Font("Segoe UI", 8.25F);
            versionLabel.Location = new Point(168, 54);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(157, 19);
            versionLabel.TabIndex = 1;
            versionLabel.Text = "Version sous alpha 1.0.0";
            // 
            // titreLabel
            // 
            titreLabel.AutoSize = true;
            titreLabel.Font = new Font("Segoe UI", 9F);
            titreLabel.Location = new Point(168, 34);
            titreLabel.Name = "titreLabel";
            titreLabel.Size = new Size(172, 20);
            titreLabel.TabIndex = 0;
            titreLabel.Text = "Premieres Manipulations";
            // 
            // confirmerButton
            // 
            confirmerButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            confirmerButton.ForeColor = SystemColors.HotTrack;
            confirmerButton.Location = new Point(150, 232);
            confirmerButton.Margin = new Padding(3, 4, 3, 4);
            confirmerButton.Name = "confirmerButton";
            confirmerButton.Size = new Size(103, 37);
            confirmerButton.TabIndex = 1;
            confirmerButton.Text = "Confirmer";
            confirmerButton.UseVisualStyleBackColor = true;
            confirmerButton.Click += confirmerButton_Click;
            confirmerButton.MouseEnter += button_MouseEnter;
            confirmerButton.MouseLeave += button_MouseLeave;
            // 
            // APropos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 300);
            Controls.Add(confirmerButton);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "APropos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FicAPropos";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label titreLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button confirmerButton;
    }
}