namespace proiectpaw2023
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnAdaugaCandidat = new System.Windows.Forms.Button();
            this.txtPrenume = new System.Windows.Forms.Label();
            this.txtSpecializare = new System.Windows.Forms.Label();
            this.ListaCandidati = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listViewCandidati = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Specializare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNume
            // 
            this.txtNume.AutoSize = true;
            this.txtNume.Location = new System.Drawing.Point(122, 67);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(35, 13);
            this.txtNume.TabIndex = 0;
            this.txtNume.Text = "Nume";
            this.txtNume.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(195, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 20);
            this.textBox3.TabIndex = 1;
            // 
            // btnAdaugaCandidat
            // 
            this.btnAdaugaCandidat.Location = new System.Drawing.Point(241, 176);
            this.btnAdaugaCandidat.Name = "btnAdaugaCandidat";
            this.btnAdaugaCandidat.Size = new System.Drawing.Size(105, 36);
            this.btnAdaugaCandidat.TabIndex = 2;
            this.btnAdaugaCandidat.Text = "Adauga Candidat";
            this.btnAdaugaCandidat.UseVisualStyleBackColor = true;
            this.btnAdaugaCandidat.Click += new System.EventHandler(this.btnAdaugaCandidat_Click_1);
            // 
            // txtPrenume
            // 
            this.txtPrenume.AutoSize = true;
            this.txtPrenume.Location = new System.Drawing.Point(122, 101);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(49, 13);
            this.txtPrenume.TabIndex = 3;
            this.txtPrenume.Text = "Prenume";
            // 
            // txtSpecializare
            // 
            this.txtSpecializare.AutoSize = true;
            this.txtSpecializare.Location = new System.Drawing.Point(122, 133);
            this.txtSpecializare.Name = "txtSpecializare";
            this.txtSpecializare.Size = new System.Drawing.Size(64, 13);
            this.txtSpecializare.TabIndex = 4;
            this.txtSpecializare.Text = "Specializare";
            // 
            // ListaCandidati
            // 
            this.ListaCandidati.AutoSize = true;
            this.ListaCandidati.Location = new System.Drawing.Point(711, 29);
            this.ListaCandidati.Name = "ListaCandidati";
            this.ListaCandidati.Size = new System.Drawing.Size(76, 13);
            this.ListaCandidati.TabIndex = 6;
            this.ListaCandidati.Text = "Lista Candidati";
            this.ListaCandidati.Click += new System.EventHandler(this.label2_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // listViewCandidati
            // 
            this.listViewCandidati.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Nume,
            this.Prenume,
            this.Specializare});
            this.listViewCandidati.HideSelection = false;
            this.listViewCandidati.Location = new System.Drawing.Point(513, 45);
            this.listViewCandidati.Name = "listViewCandidati";
            this.listViewCandidati.Size = new System.Drawing.Size(458, 361);
            this.listViewCandidati.TabIndex = 7;
            this.listViewCandidati.UseCompatibleStateImageBehavior = false;
            this.listViewCandidati.View = System.Windows.Forms.View.Details;
            this.listViewCandidati.SelectedIndexChanged += new System.EventHandler(this.listViewCandidati_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "Id";
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 84;
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume";
            this.Prenume.Width = 108;
            // 
            // Specializare
            // 
            this.Specializare.Text = "Specilizare";
            this.Specializare.Width = 202;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 530);
            this.Controls.Add(this.listViewCandidati);
            this.Controls.Add(this.ListaCandidati);
            this.Controls.Add(this.txtSpecializare);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.btnAdaugaCandidat);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtNume;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnAdaugaCandidat;
        private System.Windows.Forms.Label txtPrenume;
        private System.Windows.Forms.Label txtSpecializare;
        private System.Windows.Forms.Label ListaCandidati;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView listViewCandidati;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Prenume;
        private System.Windows.Forms.ColumnHeader Specializare;
    }
}

