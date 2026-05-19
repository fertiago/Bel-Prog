using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Bel_Prog
{
    public partial class EcranDbDirect : Form
    {
        private string sConnectionString = "";

        public EcranDbDirect()
        {
            InitializeComponent();
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            string _server = urlTextBox.Text;
            if (!string.IsNullOrWhiteSpace(portTextBox.Text))
            {
                _server += "," + portTextBox.Text;
            }

            string _baseDeDonnees = textBox1.Text;
            string _utilisateur = utilisateurTextBox.Text;
            string _motDePasse = motdepasseTextBox.Text;

            sConnectionString = $"Server={_server};Database={_baseDeDonnees};User Id={_utilisateur};Password={_motDePasse};TrustServerCertificate=True;";

            MessageBox.Show("Chaîne de connexion mise à jour !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void consulterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sConnectionString)) {
                MessageBox.Show("Veuillez d'abord initialiser la connexion avec le bouton 'Connection'.");
                return;
            }

            dbListBox.Items.Clear();
            string _query = "SELECT NumCli, Prenom, Nom FROM Client";

            try
            {
                using (SqlConnection _conn = new SqlConnection(sConnectionString))
                {
                    _conn.Open();
                    using (SqlCommand _cmd = new SqlCommand(_query, _conn))
                    using (SqlDataReader _reader = _cmd.ExecuteReader())
                    {
                        while (_reader.Read())
                        {
                            string _numCli = _reader["NumCli"].ToString();
                            string _prenom = _reader["Prenom"].ToString();
                            string _nom = _reader["Nom"].ToString();
                            dbListBox.Items.Add($"{_prenom} {_nom} ({_numCli})");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void denombrerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sConnectionString)) {
                MessageBox.Show("Veuillez d'abord initialiser la connexion avec le bouton 'Connection'.");
                return;
            }

            string _query = "SELECT COUNT(*) FROM Client";

            try
            {
                using (SqlConnection _conn = new SqlConnection(sConnectionString))
                {
                    _conn.Open();
                    using (SqlCommand _cmd = new SqlCommand(_query, _conn))
                    {
                        int _total = (int)_cmd.ExecuteScalar();
                        dbListBox.Items.Add($"Nombre d'enregistrements : {_total}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sConnectionString)) {
                MessageBox.Show("Veuillez d'abord initialiser la connexion avec le bouton 'Connection'.");
                return;
            }

            string _prenom = prenomTextBox.Text.Trim();
            string _nom = nomTextBox.Text.Trim();

            if (string.IsNullOrEmpty(_prenom) || string.IsNullOrEmpty(_nom))
            {
                MessageBox.Show("Veuillez renseigner le nom et le prénom.");
                return;
            }

            string _query = "INSERT INTO Client (Prenom, Nom) VALUES (@prenom, @nom)";

            try
            {
                using (SqlConnection _conn = new SqlConnection(sConnectionString))
                {
                    _conn.Open();
                    using (SqlCommand _cmd = new SqlCommand(_query, _conn))
                    {
                        _cmd.Parameters.AddWithValue("@prenom", _prenom);
                        _cmd.Parameters.AddWithValue("@nom", _nom);

                        int _rowsAffected = _cmd.ExecuteNonQuery();
                        if (_rowsAffected > 0)
                        {
                            prenomTextBox.Clear();
                            nomTextBox.Clear();
                            consulterButton_Click(this, EventArgs.Empty); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
