using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO; // Ajouté pour Path.GetFileName
using System.Linq; // Ajouté pour .Max()
using System.Runtime.InteropServices;

namespace Bel_Prog
{
    public partial class ManipulationListe : Form
    {
        private string[] _quality = { "Madame", "Mademoiselle", "Monsieur", "Mondamoiseau" };
        private ElementList _list = new ElementList();
        private int _encodingCounter = 1;

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int smLire = 0x0199;
        private const int smEcrire = 0x019A;

        public ManipulationListe()
        {
            InitializeComponent();

            titleDetailsListCombo.Items.AddRange(this._quality);

            this.listBox.Sorted = true;
        }

        private void exitListButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toggleDetails(Boolean enabled)
        {
            this.detailsListGroup.Enabled = enabled;
            this.nameDetailsListTextBox.Enabled = enabled;
            this.titleDetailsListCombo.Enabled = enabled;
            this.cancelDetailsListButton.Enabled = enabled;
            this.confirmDetailsListButton.Enabled = enabled;
        }

        private void addListButton_Click(object sender, EventArgs e)
        {
            this.toggleDetails(true);
            this.titleDetailsListCombo.Text = "";
            this.nameDetailsListTextBox.Text = "";
            this.listBox.ClearSelected();
        }

        private void cancelDetailsListButton_Click(object sender, EventArgs e)
        {
            this.listBox.ClearSelected();
            this.titleDetailsListCombo.Text = "";
            this.nameDetailsListTextBox.Text = "";
            this.toggleDetails(false);
        }

        private void confirmDetailsListButton_Click(object sender, EventArgs e)
        {
            if (this.listBox.SelectedIndex != -1)
            {
                Element selectedElement = (Element)this.listBox.SelectedItem;
                this._list.Modifier(selectedElement.Id, this.titleDetailsListCombo.Text, this.nameDetailsListTextBox.Text);
            }
            else
            {
                this._list.Add(this.titleDetailsListCombo.Text, this.nameDetailsListTextBox.Text, _encodingCounter);

                _encodingCounter++;
            }

            listBox_Update();

            this.titleDetailsListCombo.Text = "";
            this.nameDetailsListTextBox.Text = "";
            this.listBox.ClearSelected();
            this.toggleDetails(false);
        }

        private void listBox_Update()
        {
            this.listBox.Items.Clear();

            foreach (Element element in this._list.GetAll())
            {
                if (element != null)
                {
                    int newIndex = this.listBox.Items.Add(element);

                    SendMessage(this.listBox.Handle, smEcrire, newIndex, element.SecretNumber);
                }
            }
        }

        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox.SelectedIndex;

            if (index != -1)
            {
                Element element = (Element)this.listBox.SelectedItem;

                int numEncodage = SendMessage(this.listBox.Handle, smLire, index, 0);

                string message = $"Données : {element.ToString()}\n" +
                                 $"Index visuel : {index}\n" +
                                 $"Numéro d'encodage (caché API) : {numEncodage}\n";

                MessageBox.Show(message, "Informations Élément");
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isSelected = (this.listBox.SelectedIndex != -1);
            this.deleteListButton.Enabled = isSelected;

            if (isSelected)
            {
                Element selectedElement = (Element)this.listBox.SelectedItem;
                this.titleDetailsListCombo.Text = selectedElement.Title;
                this.nameDetailsListTextBox.Text = selectedElement.Name;
                this.toggleDetails(true);
            }
            else
            {
                this.titleDetailsListCombo.Text = "";
                this.nameDetailsListTextBox.Text = "";
                this.toggleDetails(false);
            }
        }

        private void deleteListButton_Click(object sender, EventArgs e)
        {
            if (this.listBox.SelectedIndex != -1)
            {
                Element elementASupprimer = (Element)this.listBox.SelectedItem;

                DialogResult reponse = MessageBox.Show(
                    $"Voulez-vous vraiment supprimer {elementASupprimer.ToString()} ?",
                    "Confirmation de suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (reponse == DialogResult.Yes)
                {
                    bool succes = this._list.Remove(elementASupprimer.Id);

                    if (succes)
                    {
                        listBox_Update();

                        this.titleDetailsListCombo.Text = "";
                        this.nameDetailsListTextBox.Text = "";
                        this.toggleDetails(false);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.");
            }
        }

        private void saveListButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichier CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Sauvegarder la liste";
            saveFileDialog.FileName = "list.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this._list.Save(saveFileDialog.FileName);
                    this.filenameListLabel.Text = Path.GetFileName(saveFileDialog.FileName);
                    MessageBox.Show("Sauvegarde réussie !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la sauvegarde : " + ex.Message);
                }
            }
        }

        private void openListButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichier CSV (*.csv)|*.csv";
            openFileDialog.Title = "Ouvrir une liste";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this._list.Load(openFileDialog.FileName);

                    listBox_Update();

                    var allElements = this._list.GetAll();
                    if (allElements.Count > 0)
                    {
                        _encodingCounter = allElements.Max(x => x.SecretNumber) + 1;
                    }
                    else
                    {
                        _encodingCounter = 1;
                    }

                    this.filenameListLabel.Text = Path.GetFileName(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ouverture : " + ex.Message);
                }
            }
        }
    }
}