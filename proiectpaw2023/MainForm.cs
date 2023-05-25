using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proiectpaw2023
{
    public partial class MainForm : Form
    {
        private List<Candidat> candidati;
        public MainForm()
        {
            InitializeComponent();

        }

        private void btnAdaugaCandidat_Click(object sender, EventArgs e)
        {
            // Logica pentru adăugarea unui candidat
        }

        private void btnActualizareCandidat_Click(object sender, EventArgs e)
        {
            // Logica pentru adăugarea unui candidat
        }

        private void btnStergeCandidat_Click(object sender, EventArgs e)
        {
            // Logica pentru ștergerea unui candidat
        }

        private int GenerateCandidatId()
        {
            // Logica pentru generarea unui ID unic pentru candidat

            return 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int GenerateNextId()
        {
            // Verificăm dacă există deja candidați în ListView
            if (listViewCandidati.Items.Count > 0)
            {
                // Obținem id-ul candidatului anterior și adăugăm 1 pentru a genera un nou id
                int lastId = int.Parse(listViewCandidati.Items[listViewCandidati.Items.Count - 1].SubItems[0].Text);
                return lastId + 1;
            }
            else
            {
                // Dacă nu există candidați anteriori, începem de la id-ul 1
                return 1;
            }
        }


        private void btnAdaugaCandidat_Click_1(object sender, EventArgs e)
        {
            // Obțineți informațiile din casetele de text
            string nume = txtNume.Text;
            string prenume = txtPrenume.Text;
            string specializare = txtSpecializare.Text;

            // Verificați dacă toate câmpurile sunt completate
            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(prenume))
            {
                MessageBox.Show("Vă rugăm să completați toate câmpurile.");
                return;
            }

            // Generați un nou id în funcție de numărul de înregistrări existente
            int id = GenerateNextId();

            // Crearea unui element ListView pentru candidatul nou
            ListViewItem item = new ListViewItem(id.ToString());
            item.SubItems.Add(nume);
            item.SubItems.Add(prenume);
            item.SubItems.Add(specializare);

            // Adăugarea elementului în controlul ListView
            listViewCandidati.Items.Add(item);

            // Goliți câmpurile de text după adăugare
            txtNume.Text = "";
            txtPrenume.Text = "";
            txtSpecializare.Text = "";

            MessageBox.Show("Candidatul a fost adăugat în lista candidaților.");
        }

        private bool SaveCandidatToFile(Candidat candidat)
        {
            string filePath = "Candidati.txt"; // Calea și numele fișierului txt

            try
            {
                // Verificăm dacă fișierul există deja
                bool fileExists = File.Exists(filePath);

                // Deschidem fișierul în modul corespunzător
                using (StreamWriter writer = new StreamWriter(filePath, fileExists))
                {
                    // Dacă fișierul există, ne poziționăm la începutul acestuia
                    if (fileExists)
                    {
                        writer.BaseStream.Seek(0, SeekOrigin.End);
                    }

                    // Scriem datele candidatului
                    string line = $"{candidat.Id},{candidat.Nume},{candidat.Prenume},{candidat.Specializare}";
                    writer.WriteLine(line);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"A apărut o eroare la salvarea fișierului: {ex.Message}");
                return false;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            //// Configurare coloane ListView
            //listViewCandidati.Columns.Add("ID");
            //listViewCandidati.Columns.Add("Nume");
            //listViewCandidati.Columns.Add("Prenume");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listViewCandidati.Columns.Add("ID");
            listViewCandidati.Columns.Add("Nume");
            listViewCandidati.Columns.Add("Prenume");
            listViewCandidati.Columns.Add("Specializare");
        }

        private void listViewCandidati_SelectedIndexChanged(object sender, EventArgs e)
        {

        }








        //// Adăugare candidat în listă sau în altă locație de stocare, după necesitate

        //// Afisare mesaj de succes
        //MessageBox.Show("Candidat adăugat cu succes!");

        //// Resetare câmpuri
        //txtNume.Text = string.Empty;
        //txtPrenume.Text = string.Empty;
        //txtSpecializare.Text = string.Empty;
    }
}

