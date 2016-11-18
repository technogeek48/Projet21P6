namespace Projet_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbNoms = new System.Windows.Forms.GroupBox();
            this.lblNotice = new System.Windows.Forms.Label();
            this.btnBrowsePaysPop = new System.Windows.Forms.Button();
            this.btnBrowseLangues = new System.Windows.Forms.Button();
            this.btnLecture = new System.Windows.Forms.Button();
            this.tbFichierPaysPop = new System.Windows.Forms.TextBox();
            this.tbFichierLangues = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCrit = new System.Windows.Forms.GroupBox();
            this.tbPays = new System.Windows.Forms.TextBox();
            this.picImgLang = new System.Windows.Forms.PictureBox();
            this.rbLesDeux = new System.Windows.Forms.RadioButton();
            this.rbFichier = new System.Windows.Forms.RadioButton();
            this.rbEcran = new System.Windows.Forms.RadioButton();
            this.btnEffHist = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lbLangues = new System.Windows.Forms.ListBox();
            this.cbPays = new System.Windows.Forms.CheckBox();
            this.cbPaysPlusParle = new System.Windows.Forms.CheckBox();
            this.cbPaysMoinParle = new System.Windows.Forms.CheckBox();
            this.cbTotalLangue = new System.Windows.Forms.CheckBox();
            this.cbLangue = new System.Windows.Forms.CheckBox();
            this.gbRes = new System.Windows.Forms.GroupBox();
            this.lblResultats = new System.Windows.Forms.Label();
            this.gbNoms.SuspendLayout();
            this.gbCrit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImgLang)).BeginInit();
            this.gbRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNoms
            // 
            this.gbNoms.BackColor = System.Drawing.Color.Lavender;
            this.gbNoms.Controls.Add(this.lblNotice);
            this.gbNoms.Controls.Add(this.btnBrowsePaysPop);
            this.gbNoms.Controls.Add(this.btnBrowseLangues);
            this.gbNoms.Controls.Add(this.btnLecture);
            this.gbNoms.Controls.Add(this.tbFichierPaysPop);
            this.gbNoms.Controls.Add(this.tbFichierLangues);
            this.gbNoms.Controls.Add(this.label2);
            this.gbNoms.Controls.Add(this.label1);
            this.gbNoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNoms.Location = new System.Drawing.Point(18, 18);
            this.gbNoms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbNoms.Name = "gbNoms";
            this.gbNoms.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbNoms.Size = new System.Drawing.Size(1305, 157);
            this.gbNoms.TabIndex = 0;
            this.gbNoms.TabStop = false;
            this.gbNoms.Text = "1. Noms des fichiers à utiliser";
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.Location = new System.Drawing.Point(190, 128);
            this.lblNotice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(557, 25);
            this.lblNotice.TabIndex = 10;
            this.lblNotice.Text = "Les fichiers doivent être dans le même dossier que l\'executable";
            // 
            // btnBrowsePaysPop
            // 
            this.btnBrowsePaysPop.Location = new System.Drawing.Point(626, 88);
            this.btnBrowsePaysPop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowsePaysPop.Name = "btnBrowsePaysPop";
            this.btnBrowsePaysPop.Size = new System.Drawing.Size(46, 37);
            this.btnBrowsePaysPop.TabIndex = 9;
            this.btnBrowsePaysPop.Text = "...";
            this.btnBrowsePaysPop.UseVisualStyleBackColor = true;
            this.btnBrowsePaysPop.Click += new System.EventHandler(this.btnBrowsePaysPop_Click);
            // 
            // btnBrowseLangues
            // 
            this.btnBrowseLangues.Location = new System.Drawing.Point(626, 35);
            this.btnBrowseLangues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseLangues.Name = "btnBrowseLangues";
            this.btnBrowseLangues.Size = new System.Drawing.Size(46, 37);
            this.btnBrowseLangues.TabIndex = 8;
            this.btnBrowseLangues.Text = "...";
            this.btnBrowseLangues.UseVisualStyleBackColor = true;
            this.btnBrowseLangues.Click += new System.EventHandler(this.btnBrowseLangues_Click);
            // 
            // btnLecture
            // 
            this.btnLecture.Location = new System.Drawing.Point(681, 35);
            this.btnLecture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLecture.Name = "btnLecture";
            this.btnLecture.Size = new System.Drawing.Size(262, 89);
            this.btnLecture.TabIndex = 7;
            this.btnLecture.Text = "Lecture des fichiers";
            this.btnLecture.UseVisualStyleBackColor = true;
            this.btnLecture.Click += new System.EventHandler(this.btnLecture_Click);
            // 
            // tbFichierPaysPop
            // 
            this.tbFichierPaysPop.Location = new System.Drawing.Point(330, 88);
            this.tbFichierPaysPop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFichierPaysPop.Name = "tbFichierPaysPop";
            this.tbFichierPaysPop.Size = new System.Drawing.Size(284, 33);
            this.tbFichierPaysPop.TabIndex = 6;
            this.tbFichierPaysPop.Text = "pays-population.txt";
            // 
            // tbFichierLangues
            // 
            this.tbFichierLangues.Location = new System.Drawing.Point(330, 35);
            this.tbFichierLangues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFichierLangues.Name = "tbFichierLangues";
            this.tbFichierLangues.Size = new System.Drawing.Size(284, 33);
            this.tbFichierLangues.TabIndex = 5;
            this.tbFichierLangues.Text = "langues.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fichier des pays/populations:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fichier des langues:";
            // 
            // gbCrit
            // 
            this.gbCrit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbCrit.Controls.Add(this.tbPays);
            this.gbCrit.Controls.Add(this.picImgLang);
            this.gbCrit.Controls.Add(this.rbLesDeux);
            this.gbCrit.Controls.Add(this.rbFichier);
            this.gbCrit.Controls.Add(this.rbEcran);
            this.gbCrit.Controls.Add(this.btnEffHist);
            this.gbCrit.Controls.Add(this.btnRechercher);
            this.gbCrit.Controls.Add(this.lbLangues);
            this.gbCrit.Controls.Add(this.cbPays);
            this.gbCrit.Controls.Add(this.cbPaysPlusParle);
            this.gbCrit.Controls.Add(this.cbPaysMoinParle);
            this.gbCrit.Controls.Add(this.cbTotalLangue);
            this.gbCrit.Controls.Add(this.cbLangue);
            this.gbCrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrit.Location = new System.Drawing.Point(18, 185);
            this.gbCrit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCrit.Name = "gbCrit";
            this.gbCrit.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCrit.Size = new System.Drawing.Size(1305, 368);
            this.gbCrit.TabIndex = 1;
            this.gbCrit.TabStop = false;
            this.gbCrit.Text = "2. Critères de recherche";
            // 
            // tbPays
            // 
            this.tbPays.Location = new System.Drawing.Point(216, 300);
            this.tbPays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPays.Name = "tbPays";
            this.tbPays.Size = new System.Drawing.Size(262, 33);
            this.tbPays.TabIndex = 16;
            this.tbPays.Visible = false;
            // 
            // picImgLang
            // 
            this.picImgLang.Image = global::Projet_2.Properties.Resources.imgLang;
            this.picImgLang.Location = new System.Drawing.Point(960, 25);
            this.picImgLang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picImgLang.Name = "picImgLang";
            this.picImgLang.Size = new System.Drawing.Size(322, 178);
            this.picImgLang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImgLang.TabIndex = 13;
            this.picImgLang.TabStop = false;
            // 
            // rbLesDeux
            // 
            this.rbLesDeux.AutoSize = true;
            this.rbLesDeux.Location = new System.Drawing.Point(660, 211);
            this.rbLesDeux.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbLesDeux.Name = "rbLesDeux";
            this.rbLesDeux.Size = new System.Drawing.Size(413, 33);
            this.rbLesDeux.TabIndex = 20;
            this.rbLesDeux.Text = "Résultats dans le fichier et à l\'écran";
            this.rbLesDeux.UseVisualStyleBackColor = true;
            // 
            // rbFichier
            // 
            this.rbFichier.AutoSize = true;
            this.rbFichier.Location = new System.Drawing.Point(660, 168);
            this.rbFichier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbFichier.Name = "rbFichier";
            this.rbFichier.Size = new System.Drawing.Size(286, 33);
            this.rbFichier.TabIndex = 19;
            this.rbFichier.Text = "Résulats dans le fichier";
            this.rbFichier.UseVisualStyleBackColor = true;
            // 
            // rbEcran
            // 
            this.rbEcran.AutoSize = true;
            this.rbEcran.Checked = true;
            this.rbEcran.Location = new System.Drawing.Point(660, 125);
            this.rbEcran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbEcran.Name = "rbEcran";
            this.rbEcran.Size = new System.Drawing.Size(226, 33);
            this.rbEcran.TabIndex = 18;
            this.rbEcran.TabStop = true;
            this.rbEcran.Text = "Résulats à l\'écran";
            this.rbEcran.UseVisualStyleBackColor = true;
            // 
            // btnEffHist
            // 
            this.btnEffHist.Location = new System.Drawing.Point(660, 286);
            this.btnEffHist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEffHist.Name = "btnEffHist";
            this.btnEffHist.Size = new System.Drawing.Size(262, 46);
            this.btnEffHist.TabIndex = 21;
            this.btnEffHist.Text = "Effacer l\'historique";
            this.btnEffHist.UseVisualStyleBackColor = true;
            this.btnEffHist.Click += new System.EventHandler(this.btnEffHist_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(660, 35);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(262, 46);
            this.btnRechercher.TabIndex = 17;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lbLangues
            // 
            this.lbLangues.FormattingEnabled = true;
            this.lbLangues.ItemHeight = 29;
            this.lbLangues.Location = new System.Drawing.Point(80, 92);
            this.lbLangues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbLangues.Name = "lbLangues";
            this.lbLangues.Size = new System.Drawing.Size(398, 62);
            this.lbLangues.TabIndex = 11;
            // 
            // cbPays
            // 
            this.cbPays.AutoSize = true;
            this.cbPays.Location = new System.Drawing.Point(33, 298);
            this.cbPays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPays.Name = "cbPays";
            this.cbPays.Size = new System.Drawing.Size(184, 33);
            this.cbPays.TabIndex = 15;
            this.cbPays.Text = "Selon le pays";
            this.cbPays.UseVisualStyleBackColor = true;
            this.cbPays.CheckedChanged += new System.EventHandler(this.cbPays_CheckedChanged);
            // 
            // cbPaysPlusParle
            // 
            this.cbPaysPlusParle.AutoSize = true;
            this.cbPaysPlusParle.Location = new System.Drawing.Point(80, 255);
            this.cbPaysPlusParle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPaysPlusParle.Name = "cbPaysPlusParle";
            this.cbPaysPlusParle.Size = new System.Drawing.Size(561, 33);
            this.cbPaysPlusParle.TabIndex = 14;
            this.cbPaysPlusParle.Text = "Pays où la langue sélectionnée est la plus parlée";
            this.cbPaysPlusParle.UseVisualStyleBackColor = true;
            // 
            // cbPaysMoinParle
            // 
            this.cbPaysMoinParle.AutoSize = true;
            this.cbPaysMoinParle.Location = new System.Drawing.Point(80, 212);
            this.cbPaysMoinParle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPaysMoinParle.Name = "cbPaysMoinParle";
            this.cbPaysMoinParle.Size = new System.Drawing.Size(581, 33);
            this.cbPaysMoinParle.TabIndex = 13;
            this.cbPaysMoinParle.Text = "Pays où la langue sélectionnée est la moins parlée";
            this.cbPaysMoinParle.UseVisualStyleBackColor = true;
            // 
            // cbTotalLangue
            // 
            this.cbTotalLangue.AutoSize = true;
            this.cbTotalLangue.Location = new System.Drawing.Point(80, 169);
            this.cbTotalLangue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTotalLangue.Name = "cbTotalLangue";
            this.cbTotalLangue.Size = new System.Drawing.Size(438, 33);
            this.cbTotalLangue.TabIndex = 12;
            this.cbTotalLangue.Text = "Grand total de la langue séléctionnée";
            this.cbTotalLangue.UseVisualStyleBackColor = true;
            // 
            // cbLangue
            // 
            this.cbLangue.AutoCheck = false;
            this.cbLangue.AutoSize = true;
            this.cbLangue.Location = new System.Drawing.Point(33, 49);
            this.cbLangue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLangue.Name = "cbLangue";
            this.cbLangue.Size = new System.Drawing.Size(206, 33);
            this.cbLangue.TabIndex = 10;
            this.cbLangue.Text = "Selon la langue";
            this.cbLangue.UseVisualStyleBackColor = true;
            this.cbLangue.CheckedChanged += new System.EventHandler(this.cbLangue_CheckedChanged);
            // 
            // gbRes
            // 
            this.gbRes.BackColor = System.Drawing.Color.Lavender;
            this.gbRes.Controls.Add(this.lblResultats);
            this.gbRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRes.Location = new System.Drawing.Point(18, 562);
            this.gbRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbRes.Name = "gbRes";
            this.gbRes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbRes.Size = new System.Drawing.Size(1305, 397);
            this.gbRes.TabIndex = 2;
            this.gbRes.TabStop = false;
            this.gbRes.Text = "3. Résulats";
            // 
            // lblResultats
            // 
            this.lblResultats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultats.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultats.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResultats.Location = new System.Drawing.Point(4, 31);
            this.lblResultats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultats.Name = "lblResultats";
            this.lblResultats.Size = new System.Drawing.Size(1297, 361);
            this.lblResultats.TabIndex = 8;
            this.lblResultats.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 942);
            this.Controls.Add(this.gbRes);
            this.Controls.Add(this.gbCrit);
            this.Controls.Add(this.gbNoms);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1352, 998);
            this.Name = "Form1";
            this.Text = "Langues Parlées (par Michael-John Sakellaropoulos)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbNoms.ResumeLayout(false);
            this.gbNoms.PerformLayout();
            this.gbCrit.ResumeLayout(false);
            this.gbCrit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImgLang)).EndInit();
            this.gbRes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNoms;
        private System.Windows.Forms.Button btnLecture;
        private System.Windows.Forms.TextBox tbFichierPaysPop;
        private System.Windows.Forms.TextBox tbFichierLangues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCrit;
        private System.Windows.Forms.GroupBox gbRes;
        private System.Windows.Forms.CheckBox cbPays;
        private System.Windows.Forms.CheckBox cbPaysPlusParle;
        private System.Windows.Forms.CheckBox cbPaysMoinParle;
        private System.Windows.Forms.CheckBox cbTotalLangue;
        private System.Windows.Forms.CheckBox cbLangue;
        private System.Windows.Forms.ListBox lbLangues;
        private System.Windows.Forms.Button btnEffHist;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label lblResultats;
        private System.Windows.Forms.PictureBox picImgLang;
        private System.Windows.Forms.RadioButton rbLesDeux;
        private System.Windows.Forms.RadioButton rbFichier;
        private System.Windows.Forms.RadioButton rbEcran;
        private System.Windows.Forms.Button btnBrowseLangues;
        private System.Windows.Forms.Button btnBrowsePaysPop;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.TextBox tbPays;
    }
}

