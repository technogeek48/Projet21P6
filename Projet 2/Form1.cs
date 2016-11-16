using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Projet_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbCrit.Enabled = !gbCrit.Enabled;
        }

        #region Recherche du plus grand et du plus petit
        public void rechercheDuPlusGrand(ref long longPlusGrand, ref long longComp, ref string strNomGrand, ref string strComp)
        {
            if (longComp > longPlusGrand)
            {
                longPlusGrand = longComp;
                strNomGrand = strComp;
            }
        }

        public void rechercheDuPlusPetit(ref long longPlusPetit, ref long longComp, ref string strNomPetit, ref string strComp)
        {
            if (longComp < longPlusPetit)
            {
                longPlusPetit = longComp;
                strNomPetit = strComp;
            }
        }
        #endregion

        #region Fonctions "Browse" [purement fait pour faciliter la correction]
        public static string browseForFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Choisisez un fichier texte...";
            dlg.InitialDirectory = Environment.CurrentDirectory;
            dlg.Multiselect = false;
            dlg.ShowDialog();
            return dlg.FileName;
        }

        private void btnBrowseLangues_Click(object sender, EventArgs e)
        {
            tbFichierLangues.Text = Path.GetFileName(browseForFile());
        }

        private void btnBrowsePaysPop_Click(object sender, EventArgs e)
        {
            tbFichierPaysPop.Text = Path.GetFileName(browseForFile());
        }
        #endregion

        #region Traiter fichiers [StreamReader]

        public void traiterFichierLangues()
        {
            //Lire chaque ligne et le mettre dans la liste des langues.
            StreamReader srFichierLu = new StreamReader(tbFichierLangues.Text);
            string strLigne = "";
            while(strLigne != null)
            {
                strLigne = srFichierLu.ReadLine();
                if(strLigne != null)
                    lbLangues.Items.Add(strLigne); //Prevents ArgumentNullException if last line is empty
            }
            srFichierLu.Close();
        }

        public void traiterLignePaysPop(ref string strNomPays, ref string strNomLangue, ref long longPop, ref StreamReader srFichierPop)
        {
            //Pour une ligne: lire 25 chars => pays (string)  // 15 chars => Langue (string) // Le reste de la ligne => Population (long)
            strNomPays = "";
            strNomLangue = "";
            longPop = 0;
            char[] t_charNomPays = new char[25];
            char[] t_charNomLangue = new char[15];

            srFichierPop.Read(t_charNomPays, 0, t_charNomPays.Length); //Lire NomPays 25char
            strNomPays = new string(t_charNomPays).Trim().ToUpper();
            srFichierPop.Read(t_charNomLangue, 0, t_charNomLangue.Length); //Lire NomLangue 15char
            strNomLangue = new string(t_charNomLangue).Trim().ToUpper();
            longPop = long.Parse(srFichierPop.ReadLine()); //Lire le reste de la ligne dans longPop
        }
        #endregion

        #region Ecrire dans les fichiers [StreamWriter]
        public void ecrireResultat(string strLigneAEcrire, bool booFichier, bool booEcran, ref StreamWriter swFichierRes)
        {
            if (booFichier)
                swFichierRes.WriteLine(strLigneAEcrire);
            if (booEcran)
                lblResultats.Text += strLigneAEcrire + Environment.NewLine;
        }

        public void ecrireHistorique()
        {
            //if (File.Exists("historique.txt"))
            //    File.Delete("historique.txt");

            StreamWriter swHistorique = new StreamWriter("historique.txt");

            string strDate = DateTime.Now.ToString("", new CultureInfo("fr-CA")); //S'assurer que le format sera respecté n'importe la langue active de l'ordinateur.
            string strOptAffiche = "";
            string strOptRecherche = "";

            //Traiter les boutons radio (Par pays)
            if (rbEcran.Checked)
                strOptAffiche = "Écran Seulement";
            else if (rbFichier.Checked)
                strOptAffiche = "Fichier Seulement";
            else if (rbLesDeux.Checked)
                strOptAffiche = "Écran et Fichier";

            //Traiter les options de recherche (Par langue)
            if (cbTotalLangue.Checked)
                strOptRecherche += "Grand total, ";
            if (cbPaysMoinParle.Checked)
                strOptRecherche += "Moins parlée, ";
            if (cbPaysPlusParle.Checked)
                strOptRecherche += "Plus parlée, ";

            if (!cbPays.Checked)
            {
                swHistorique.WriteLine(String.Format("{0} --- Recherche (Écran Seulement)    pour la langue : {1}       {2}", strDate, (string)lbLangues.SelectedItem, strOptRecherche.Trim().TrimEnd(','))); //Credit pour l'excellente idee .trimEnd() a simon boyer
            }
            else
            {
                swHistorique.WriteLine(String.Format("{0} --- Recherche ({1}) pour le pays   : {2}"), strDate, strOptAffiche, tbPays.Text.ToUpper().Trim()); 
            }
            swHistorique.Close();
        }

        public void ecrireTousLesEcrans()
        {
            StreamWriter swEcrans = new StreamWriter("tous-les-ecrans.txt");
            swEcrans.Close();
        }
        #endregion

        

        private void btnLecture_Click(object sender, EventArgs e)
        {
            if (tbFichierLangues.Text == "")
                MessageBox.Show("Aucun fichier des langues saisi!");
            else if (File.Exists(tbFichierLangues.Text) == false)
                MessageBox.Show("Le fichier des langues " + tbFichierLangues.Text + " est introuvable!");
            else if (tbFichierPaysPop.Text == "")
                MessageBox.Show("Aucun fichier des pays/population sasi!");
            else if (File.Exists(tbFichierPaysPop.Text) == false)
                MessageBox.Show("Le fichier des pays/population " + tbFichierPaysPop.Text + " est introuvable!");
            else
            {   //Valide
                gbNoms.Enabled = !gbNoms.Enabled;
                gbCrit.Enabled = !gbCrit.Enabled;
                lblResultats.Text = "Chargement complété ..." + Environment.NewLine;
                traiterFichierLangues();
                cbLangue.Checked = true;
                lbLangues.SelectedIndex = 0;
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            lblResultats.ResetText();

            StreamReader srFichierPaysPop = new StreamReader(tbFichierPaysPop.Text);
            StreamWriter swFichierResultats = new StreamWriter("resultats.txt");

            long longPopPlusParle = long.MinValue;
            long longPopMoinsParle = long.MaxValue;
            string strNomPaysMoinParle = "";
            string strNomPaysPlusParle = "";

            string strNomPays = "";
            string strNomLangue = "";
            long longPop = 0;

            int intCompteur = 0;
            long longSomme = 0;
            long longMoyenne = 0;

            bool booFichier = false;
            bool booEcran = false;

            //Traiter boutons radios
            if (rbEcran.Checked)
                booEcran = true;
            else if (rbFichier.Checked)
                booFichier = true;
            else if (rbLesDeux.Checked)
            {
                booFichier = true;
                booEcran = true;
            }

            string strSelect = "";

            if (cbLangue.Checked == true)
            {
                //Recherche selon la langue...
                if (lbLangues.SelectedItem != null)
                {
                    strSelect = ((string)lbLangues.SelectedItem).ToUpper();
                }
                else
                {
                    lblResultats.Text = "";
                    MessageBox.Show("Erreur: Aucune langue choisie");
                }

                ecrireResultat("Langue choisie : " + strSelect + Environment.NewLine, booFichier, booEcran, ref swFichierResultats);
                longSomme = 0;
                intCompteur = 0;
                while (srFichierPaysPop.Peek() != -1)
                {
                    traiterLignePaysPop(ref strNomPays, ref strNomLangue, ref longPop, ref srFichierPaysPop);
                    if (strNomLangue == strSelect)
                    {
                        intCompteur++;
                        longSomme += longPop;
                        rechercheDuPlusGrand(ref longPopPlusParle, ref longPop, ref strNomPaysPlusParle, ref strNomPays);
                        rechercheDuPlusPetit(ref longPopMoinsParle, ref longPop, ref strNomPaysMoinParle, ref strNomPays);
                    }
                }

                if(intCompteur != 0)
                    longMoyenne = (longSomme) / (long)intCompteur;

                ecrireResultat("Cette langues est parlée dans " + intCompteur.ToString("n0") + " pays." + Environment.NewLine, booFichier, booEcran, ref swFichierResultats);
                if (cbTotalLangue.Checked)
                {
                    ecrireResultat("Le nombre total de personnes parlant " + strSelect + " est " + longSomme.ToString("n0") + " personnes." + Environment.NewLine, booFichier, booEcran, ref swFichierResultats);
                    ecrireResultat("La moyenne par pays est " + longMoyenne.ToString("n0") + " personnes." + Environment.NewLine, booFichier, booEcran, ref swFichierResultats);
                }
                if (cbPaysMoinParle.Checked)
                {
                    ecrireResultat("Le pays où l'on parle le moins " + strSelect + " est " + strNomPaysMoinParle + " avec " + longPopMoinsParle.ToString("n0") + " personnes." + Environment.NewLine, booFichier, booEcran, ref swFichierResultats);
                }
                if (cbPaysPlusParle.Checked)
                {
                    ecrireResultat("Le pays où l'on parle le plus " + strSelect + " est " + strNomPaysPlusParle + " avec " + longPopPlusParle.ToString("n0") + " personnes." + Environment.NewLine, booFichier, booEcran, ref swFichierResultats);
                }
            }
            else
            {
                //Recherche selon le pays...
                longSomme = 0;
                intCompteur = 0;
                while (srFichierPaysPop.Peek() != -1)
                {
                    traiterLignePaysPop( ref strNomPays, ref strNomLangue, ref longPop, ref srFichierPaysPop);
                    if (strNomPays == tbPays.Text.ToUpper())
                    {
                        intCompteur++;
                        longSomme += longPop;
                        ecrireResultat(string.Format("{0}   :   {1} personnes" + Environment.NewLine, strNomLangue, longPop.ToString("n0")), booFichier, booEcran, ref swFichierResultats);
                    }
                }

                if(intCompteur > 0)
                {
                    ecrireResultat("Données concernant le pays '" + tbPays.Text.ToUpper() + "' :" + Environment.NewLine, booFichier, booEcran, ref swFichierResultats);
                    ecrireResultat("Il y a " + intCompteur.ToString("n0") + " langues pour une population recensée de " + longSomme.ToString("n0") + " personnes.", booFichier, booEcran, ref swFichierResultats);
                }
                else
                {
                    MessageBox.Show(String.Format("Le pays {0} n'a pas été trouvée dans le fichier {1}", tbPays.Text, tbFichierPaysPop.Text));
                }
            }

            ecrireHistorique();
            ecrireTousLesEcrans();

            swFichierResultats.Close();
            srFichierPaysPop.Close();
        }

        private void btnEffHist_Click(object sender, EventArgs e)
        {

        }

        private void cbLangue_CheckedChanged(object sender, EventArgs e)
        {
            cbLangue.Checked = true; //Fires three times for some reason, then, yields?
        }

        private void cbTotalLangue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPaysPlusParle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPaysMoinParle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPays_CheckedChanged(object sender, EventArgs e)
        {
            //Logique pour basculer les controles selon l'état de cbPays
            cbLangue.Checked = !cbLangue.Checked;
            List<Control> lstControles = new List<Control> { cbLangue, lbLangues, cbTotalLangue, cbPaysMoinParle, cbPaysPlusParle };
            foreach (Control ctl in lstControles)
                ctl.Enabled = !ctl.Enabled; //Basculer chaque controle

            if(rbFichier.Checked || rbLesDeux.Checked)
            {
                rbFichier.Checked = false;
                rbLesDeux.Checked = false;
            }

            rbEcran.Checked = true;
            rbFichier.Enabled = !rbFichier.Enabled;
            rbLesDeux.Enabled = !rbLesDeux.Enabled;
            tbPays.Visible = !tbPays.Visible;
        }

        private void rbEcran_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFichier_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbLesDeux_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
