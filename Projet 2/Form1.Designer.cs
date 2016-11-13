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
            this.gbNoms.Location = new System.Drawing.Point(12, 12);
            this.gbNoms.Name = "gbNoms";
            this.gbNoms.Size = new System.Drawing.Size(870, 102);
            this.gbNoms.TabIndex = 0;
            this.gbNoms.TabStop = false;
            this.gbNoms.Text = "1. Noms des fichiers à utiliser";
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.Location = new System.Drawing.Point(127, 83);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(385, 16);
            this.lblNotice.TabIndex = 10;
            this.lblNotice.Text = "Les fichiers doivent être dans le même dossier que l\'executable";
            // 
            // btnBrowsePaysPop
            // 
            this.btnBrowsePaysPop.Location = new System.Drawing.Point(417, 57);
            this.btnBrowsePaysPop.Name = "btnBrowsePaysPop";
            this.btnBrowsePaysPop.Size = new System.Drawing.Size(31, 24);
            this.btnBrowsePaysPop.TabIndex = 9;
            this.btnBrowsePaysPop.Text = "...";
            this.btnBrowsePaysPop.UseVisualStyleBackColor = true;
            this.btnBrowsePaysPop.Click += new System.EventHandler(this.btnBrowsePaysPop_Click);
            // 
            // btnBrowseLangues
            // 
            this.btnBrowseLangues.Location = new System.Drawing.Point(417, 23);
            this.btnBrowseLangues.Name = "btnBrowseLangues";
            this.btnBrowseLangues.Size = new System.Drawing.Size(31, 24);
            this.btnBrowseLangues.TabIndex = 8;
            this.btnBrowseLangues.Text = "...";
            this.btnBrowseLangues.UseVisualStyleBackColor = true;
            this.btnBrowseLangues.Click += new System.EventHandler(this.btnBrowseLangues_Click);
            // 
            // btnLecture
            // 
            this.btnLecture.Location = new System.Drawing.Point(454, 23);
            this.btnLecture.Name = "btnLecture";
            this.btnLecture.Size = new System.Drawing.Size(175, 58);
            this.btnLecture.TabIndex = 7;
            this.btnLecture.Text = "Lecture des fichiers";
            this.btnLecture.UseVisualStyleBackColor = true;
            this.btnLecture.Click += new System.EventHandler(this.btnLecture_Click);
            // 
            // tbFichierPaysPop
            // 
            this.tbFichierPaysPop.Location = new System.Drawing.Point(220, 57);
            this.tbFichierPaysPop.Name = "tbFichierPaysPop";
            this.tbFichierPaysPop.Size = new System.Drawing.Size(191, 24);
            this.tbFichierPaysPop.TabIndex = 6;
            // 
            // tbFichierLangues
            // 
            this.tbFichierLangues.Location = new System.Drawing.Point(220, 23);
            this.tbFichierLangues.Name = "tbFichierLangues";
            this.tbFichierLangues.Size = new System.Drawing.Size(191, 24);
            this.tbFichierLangues.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fichier des pays/populations:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
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
            this.gbCrit.Location = new System.Drawing.Point(12, 120);
            this.gbCrit.Name = "gbCrit";
            this.gbCrit.Size = new System.Drawing.Size(870, 239);
            this.gbCrit.TabIndex = 1;
            this.gbCrit.TabStop = false;
            this.gbCrit.Text = "2. Critères de recherche";
            // 
            // tbPays
            // 
            this.tbPays.Location = new System.Drawing.Point(144, 195);
            this.tbPays.Name = "tbPays";
            this.tbPays.Size = new System.Drawing.Size(176, 24);
            this.tbPays.TabIndex = 14;
            this.tbPays.Visible = false;
            // 
            // picImgLang
            // 
            this.picImgLang.Image = global::Projet_2.Properties.Resources.imgLang;
            this.picImgLang.Location = new System.Drawing.Point(640, 16);
            this.picImgLang.Name = "picImgLang";
            this.picImgLang.Size = new System.Drawing.Size(215, 116);
            this.picImgLang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImgLang.TabIndex = 13;
            this.picImgLang.TabStop = false;
            // 
            // rbLesDeux
            // 
            this.rbLesDeux.AutoSize = true;
            this.rbLesDeux.Location = new System.Drawing.Point(440, 137);
            this.rbLesDeux.Name = "rbLesDeux";
            this.rbLesDeux.Size = new System.Drawing.Size(257, 22);
            this.rbLesDeux.TabIndex = 12;
            this.rbLesDeux.Text = "Résultats dans le fichier et à l\'écran";
            this.rbLesDeux.UseVisualStyleBackColor = true;
            this.rbLesDeux.CheckedChanged += new System.EventHandler(this.rbLesDeux_CheckedChanged);
            // 
            // rbFichier
            // 
            this.rbFichier.AutoSize = true;
            this.rbFichier.Location = new System.Drawing.Point(440, 109);
            this.rbFichier.Name = "rbFichier";
            this.rbFichier.Size = new System.Drawing.Size(178, 22);
            this.rbFichier.TabIndex = 11;
            this.rbFichier.Text = "Résulats dans le fichier";
            this.rbFichier.UseVisualStyleBackColor = true;
            this.rbFichier.CheckedChanged += new System.EventHandler(this.rbFichier_CheckedChanged);
            // 
            // rbEcran
            // 
            this.rbEcran.AutoSize = true;
            this.rbEcran.Checked = true;
            this.rbEcran.Location = new System.Drawing.Point(440, 81);
            this.rbEcran.Name = "rbEcran";
            this.rbEcran.Size = new System.Drawing.Size(143, 22);
            this.rbEcran.TabIndex = 10;
            this.rbEcran.TabStop = true;
            this.rbEcran.Text = "Résulats à l\'écran";
            this.rbEcran.UseVisualStyleBackColor = true;
            this.rbEcran.CheckedChanged += new System.EventHandler(this.rbEcran_CheckedChanged);
            // 
            // btnEffHist
            // 
            this.btnEffHist.Location = new System.Drawing.Point(440, 186);
            this.btnEffHist.Name = "btnEffHist";
            this.btnEffHist.Size = new System.Drawing.Size(175, 30);
            this.btnEffHist.TabIndex = 9;
            this.btnEffHist.Text = "Effacer l\'historique";
            this.btnEffHist.UseVisualStyleBackColor = true;
            this.btnEffHist.Click += new System.EventHandler(this.btnEffHist_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(440, 23);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(175, 30);
            this.btnRechercher.TabIndex = 8;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lbLangues
            // 
            this.lbLangues.FormattingEnabled = true;
            this.lbLangues.ItemHeight = 18;
            this.lbLangues.Location = new System.Drawing.Point(53, 60);
            this.lbLangues.Name = "lbLangues";
            this.lbLangues.Size = new System.Drawing.Size(267, 40);
            this.lbLangues.TabIndex = 8;
            // 
            // cbPays
            // 
            this.cbPays.AutoSize = true;
            this.cbPays.Location = new System.Drawing.Point(22, 194);
            this.cbPays.Name = "cbPays";
            this.cbPays.Size = new System.Drawing.Size(115, 22);
            this.cbPays.TabIndex = 7;
            this.cbPays.Text = "Selon le pays";
            this.cbPays.UseVisualStyleBackColor = true;
            this.cbPays.CheckedChanged += new System.EventHandler(this.cbPays_CheckedChanged);
            // 
            // cbPaysPlusParle
            // 
            this.cbPaysPlusParle.AutoSize = true;
            this.cbPaysPlusParle.Location = new System.Drawing.Point(53, 166);
            this.cbPaysPlusParle.Name = "cbPaysPlusParle";
            this.cbPaysPlusParle.Size = new System.Drawing.Size(344, 22);
            this.cbPaysPlusParle.TabIndex = 6;
            this.cbPaysPlusParle.Text = "Pays où la langue sélectionnée est la plus parlée";
            this.cbPaysPlusParle.UseVisualStyleBackColor = true;
            this.cbPaysPlusParle.CheckedChanged += new System.EventHandler(this.cbPaysPlusParle_CheckedChanged);
            // 
            // cbPaysMoinParle
            // 
            this.cbPaysMoinParle.AutoSize = true;
            this.cbPaysMoinParle.Location = new System.Drawing.Point(53, 138);
            this.cbPaysMoinParle.Name = "cbPaysMoinParle";
            this.cbPaysMoinParle.Size = new System.Drawing.Size(358, 22);
            this.cbPaysMoinParle.TabIndex = 5;
            this.cbPaysMoinParle.Text = "Pays où la langue sélectionnée est la moins parlée";
            this.cbPaysMoinParle.UseVisualStyleBackColor = true;
            this.cbPaysMoinParle.CheckedChanged += new System.EventHandler(this.cbPaysMoinParle_CheckedChanged);
            // 
            // cbTotalLangue
            // 
            this.cbTotalLangue.AutoSize = true;
            this.cbTotalLangue.Location = new System.Drawing.Point(53, 110);
            this.cbTotalLangue.Name = "cbTotalLangue";
            this.cbTotalLangue.Size = new System.Drawing.Size(269, 22);
            this.cbTotalLangue.TabIndex = 4;
            this.cbTotalLangue.Text = "Grand total de la langue séléctionnée";
            this.cbTotalLangue.UseVisualStyleBackColor = true;
            this.cbTotalLangue.CheckedChanged += new System.EventHandler(this.cbTotalLangue_CheckedChanged);
            // 
            // cbLangue
            // 
            this.cbLangue.AutoSize = true;
            this.cbLangue.Location = new System.Drawing.Point(22, 32);
            this.cbLangue.Name = "cbLangue";
            this.cbLangue.Size = new System.Drawing.Size(127, 22);
            this.cbLangue.TabIndex = 3;
            this.cbLangue.Text = "Selon la langue";
            this.cbLangue.UseVisualStyleBackColor = true;
            this.cbLangue.CheckedChanged += new System.EventHandler(this.cbLangue_CheckedChanged);
            // 
            // gbRes
            // 
            this.gbRes.BackColor = System.Drawing.Color.Lavender;
            this.gbRes.Controls.Add(this.lblResultats);
            this.gbRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRes.Location = new System.Drawing.Point(12, 365);
            this.gbRes.Name = "gbRes";
            this.gbRes.Size = new System.Drawing.Size(870, 258);
            this.gbRes.TabIndex = 2;
            this.gbRes.TabStop = false;
            this.gbRes.Text = "3. Résulats";
            // 
            // lblResultats
            // 
            this.lblResultats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultats.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultats.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResultats.Location = new System.Drawing.Point(3, 20);
            this.lblResultats.Name = "lblResultats";
            this.lblResultats.Size = new System.Drawing.Size(864, 235);
            this.lblResultats.TabIndex = 8;
            this.lblResultats.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 635);
            this.Controls.Add(this.gbRes);
            this.Controls.Add(this.gbCrit);
            this.Controls.Add(this.gbNoms);
            this.MaximumSize = new System.Drawing.Size(911, 674);
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

