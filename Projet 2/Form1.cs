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

        //Code par Michael-John Sakellaropoulos (c) 2016

        //Note 1: j'utilise des fois String.Format("test {0} string {1} test {2} ... {n}",obj1,obj2,....objN)
        //        ce qui remplace {n} avec objN automatiquement au lieu de faire "" + variable + "" ... 

        //Note 2: J'ai pu/du utiliser des variables de classe a plusieures reprises, 
        //        mais vous avez dits en classe de ne pas en mettre. 

        private void Form1_Load(object sender, EventArgs e)
        {
            //au début de l'éxécution, gbCrit doit être désactivé
            gbCrit.Enabled = !gbCrit.Enabled;
        }

        #region Recherche du plus grand et du plus petit
        /// <summary>
        /// Fonction effectuant l'algorithme fondamental du recherche du plus grand
        /// </summary>
        /// <param name="longPlusGrand">Variable entreposant la plus grande population</param>
        /// <param name="longComp">Variable entreposant la population a comparer</param>
        /// <param name="strNomGrand">Variable entreposant le nom du pays ayant plus grande population</param>
        /// <param name="strComp">Variable entreposant le nom du pays a comparer</param>
        public void rechercheDuPlusGrand(ref long longPlusGrand, ref long longComp, ref string strNomGrand, ref string strComp)
        {
            if (longComp > longPlusGrand)
            {
                longPlusGrand = longComp;
                strNomGrand = strComp;
            }
        }

        /// <summary>
        /// Fonction effectuant l'algorithme fondamental du recherche du plus petit
        /// </summary>
        /// <param name="longPlusPetit">Variable entreposant la plus petite population</param>
        /// <param name="longComp">Variable entreposant la population a comparer</param>
        /// <param name="strNomPetit">Variable entreposant le nom du pays ayant plus petite population</param>
        /// <param name="strComp">Variable entreposant le nom du pays a comparer</param>
        public void rechercheDuPlusPetit(ref long longPlusPetit, ref long longComp, ref string strNomPetit, ref string strComp)
        {
            if (longComp < longPlusPetit)
            {
                longPlusPetit = longComp;
                strNomPetit = strComp;
            }
        }
        #endregion

        #region Fonctions et Evenements "Browse" [purement fait pour faciliter la correction]
        /// <summary>
        /// Fonction permettant de retourner une chaine du chemin complet d'un fichier a partir d'un OpenFileDialog
        /// </summary>
        /// <returns></returns>
        public static string browseFichier()
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
            tbFichierLangues.Text = Path.GetFileName(browseFichier());
        }

        private void btnBrowsePaysPop_Click(object sender, EventArgs e)
        {
            tbFichierPaysPop.Text = Path.GetFileName(browseFichier());
        }
        #endregion

        #region Traiter fichiers [StreamReader]

        /// <summary>
        /// Fonction pour lire le fichier de langues spécifié dans tbFichierLangues et en ajouter chaque ligne dans lbLangues
        /// </summary>
        public void traiterFichierLangues()
        {
            //Lire chaque ligne et le mettre dans la liste des langues.
            StreamReader srFichierLu = new StreamReader(tbFichierLangues.Text);
            string strLigne = "";
            while (strLigne != null)
            {
                strLigne = srFichierLu.ReadLine();
                if (strLigne != null)
                    lbLangues.Items.Add(strLigne); //Prevents ArgumentNullException if last line is empty
            }
            srFichierLu.Close();
        }

        /// <summary>
        /// Fonction permettant de traiter une seule ligne du fichier de pays/population spécifié dans tbFichierPaysPop et d'entreposer les donnée dans des variables (conformémant au format de l'énoncé)
        /// </summary>
        /// <param name="strNomPays">Variable entreposant le nom de pays courant</param>
        /// <param name="strNomLangue">Variable entreposant le nom de la langue courante</param>
        /// <param name="longPop">Variable entreposant la population courante</param>
        /// <param name="srFichierPop">StreamReader du fichier spécifié dans tbFichierPaysPop pasée en référence</param>
        public void traiterLignePaysPop(ref string strNomPays, ref string strNomLangue, ref long longPop, ref StreamReader srFichierPop)
        {
            //Pour une ligne: lire 25 chars => tableauPays (char[])  // 15 chars => tableauLangue (char[]) // Le reste de la ligne => strPopulation (string) => long
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

        /// <summary>
        /// Fonction pour ecrire dans la zone resultats et/ou dans le fichier resultats.txt dependant de l'etat des boutons radios passes en parametre
        /// </summary>
        /// <param name="strLigneAEcrire">Chaine a ecrire, elle sera suivie d'un NewLine</param>
        /// <param name="booFichier">Bool indiquant si on devra ecrire dans resultats.txt</param>
        /// <param name="booEcran">Bool indiquant si on devra ecrire dans lblResulats</param>
        /// <param name="swFichierRes">StreamWriter passée en référence</param>
        public void ecrireResultat(string strLigneAEcrire, bool booFichier, bool booEcran, ref StreamWriter swFichierRes)
        {
            if (booFichier)
                swFichierRes.WriteLine(strLigneAEcrire.Trim().TrimEnd('\n'));
            if (booEcran)
                lblResultats.Text += strLigneAEcrire + Environment.NewLine;
        }

        /// <summary>
        /// Fonction permétant d'écrire le séparateur dans l'endroit approprié UNIQUEMENT quand on doit écrire dans résultats.txt
        /// </summary>
        /// <param name="booFichier">Bool indiquant si on écrit dans résultats.txt</param>
        /// <param name="swFichierRes">StreamWriter passée en référence</param>
        public void ecrireSeparateur(bool booFichier, ref StreamWriter swFichierRes)
        {
            if (booFichier)
                swFichierRes.WriteLine(new String('-', 73).Trim().TrimEnd('\n'));
        }

        /// <summary>
        /// Fonction permetant d'écrire un séparateur et ensuite la date en respectant le format de l'enoncé
        /// </summary>
        /// <param name="booFichier">Bool indiquant si on écrit dans résultats.txt</param>
        /// <param name="swFichierRes">StreamWriter passée en référence</param>
        public void ecrireDate(bool booFichier, ref StreamWriter swFichierRes)
        {
            DateTime dtMaintenant = DateTime.Now;
            CultureInfo ciFrancaisCanada = new CultureInfo("fr-CA"); //Obtenir le CultureInfo pour francais canada
            //Obtenir le DateTimeFormat pour frCA et utiliser la methode GetMonthName pour obtenir le mois ecrit en francais, cela nous sauve de faire un mechant Switch/Case
            string strMoisFrancais = ciFrancaisCanada.DateTimeFormat.GetMonthName(dtMaintenant.Month);

            if (booFichier)
            {
                ecrireSeparateur(booFichier, ref swFichierRes);
                swFichierRes.WriteLine(String.Format("Fin des resultats de la recherche effectuée le {0} {1} de l'année {2}", dtMaintenant.Day, strMoisFrancais, dtMaintenant.Year));
            }
        }

        /// <summary>
        /// Fonction permettant d'écrire l'historique des recherches avec la date et l'heure dans historique.txt (dépendament des checkbox et boutons radios)
        /// </summary>
        public void ecrireHistorique()
        {
            //if (File.Exists("historique.txt"))
            //    File.Delete("historique.txt");

            StreamWriter swHistorique = new StreamWriter("historique.txt",true);

            string strDate = DateTime.Now.ToString("", new CultureInfo("fr-CA")); //S'assurer que le format sera respecté n'importe la langue active de l'ordinateur.
            string strOptAffiche = "";
            string strOptRecherche = "";

            //Traiter les boutons radio (Par pays)
            if (rbEcran.Checked)
                strOptAffiche = "(Écran Seulement)";
            else if (rbFichier.Checked)
                strOptAffiche = "(Fichier Seulement)";
            else if (rbLesDeux.Checked)
                strOptAffiche = "(Écran et Fichier)";

            //Traiter les options de recherche (Par langue)
            if (cbTotalLangue.Checked)
                strOptRecherche += "Grand total, ";
            if (cbPaysMoinParle.Checked)
                strOptRecherche += "Moins parlée, ";
            if (cbPaysPlusParle.Checked)
                strOptRecherche += "Plus parlée, ";

            string strPays = tbPays.Text.ToUpper().Trim();

            if (!cbPays.Checked)
            {
                swHistorique.WriteLine(string.Format("{0} --- Recherche (Écran Seulement)    pour la langue : {1}       {2}", strDate, (string)lbLangues.SelectedItem, strOptRecherche.Trim().TrimEnd(',')));
            }
            else
            {
                swHistorique.WriteLine(string.Format("{0} --- Recherche {1} pour le pays   : {2}", strDate, strOptAffiche, strPays));
            }
            swHistorique.Close();
        }
        #endregion

        private void btnLecture_Click(object sender, EventArgs e)
        {
            if (tbFichierLangues.Text == "")
                MessageBox.Show("Aucun fichier des langues saisi!");
            else if (File.Exists(tbFichierLangues.Text) == false)
                MessageBox.Show("Le fichier des langues " + tbFichierLangues.Text + " est introuvable!");
            else if (tbFichierPaysPop.Text == "")
                MessageBox.Show("Aucun fichier des pays/population saisi!");
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
            //Reset
            lblResultats.ResetText();

            CultureInfo ciFrancaisCanada = new CultureInfo("fr-CA");

            //Définir tous nos variables
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

            string strBufferParPays = "";

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

            if (cbPays.Checked == false)
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
                //Pour chaque ligne, traiter la ligne et traiter ses données
                while (srFichierPaysPop.Peek() != -1)
                {
                    traiterLignePaysPop(ref strNomPays, ref strNomLangue, ref longPop, ref srFichierPaysPop);
                    //Si la langue est celle spécifiée...
                    if (strNomLangue == strSelect)
                    {
                        intCompteur++; //Incr. Compteur
                        longSomme += longPop; //Ajouter a notre somme
                        rechercheDuPlusGrand(ref longPopPlusParle, ref longPop, ref strNomPaysPlusParle, ref strNomPays); //Effectuer la recherche du plus grand
                        rechercheDuPlusPetit(ref longPopMoinsParle, ref longPop, ref strNomPaysMoinParle, ref strNomPays);//        et du plus petit
                    }
                }

                if (intCompteur != 0) //s'assurer qu'on divisera pas par zero
                    longMoyenne = (longSomme) / (long)intCompteur; //Calc. Moyenne

                //Ecrire nos résultats dans le/les endroits approprié(s) demandé par l'utilisateur par moyen des boutons radios
                ecrireResultat("Cette langues est parlée dans " + intCompteur.ToString("n0") + " pays." + Environment.NewLine, booFichier, booEcran, ref swFichierResultats);
                if (!cbTotalLangue.Checked && !cbPaysMoinParle.Checked && !cbPaysPlusParle.Checked) { }
                else
                    ecrireSeparateur(booFichier, ref swFichierResultats);

                if (cbTotalLangue.Checked)
                {
                    ecrireResultat("Le nombre total de personnes parlant " + strSelect + " est " + longSomme.ToString("n0") + " personnes.", booFichier, booEcran, ref swFichierResultats);
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
                //Si on ecrit dans resultats.txt, on termine le fichier avec un séparateur suivi par la date dans le format particulier de l'énoncé
                ecrireDate(booFichier, ref swFichierResultats);
            }
            else
            {
                //Recherche selon le pays...
                longSomme = 0;
                intCompteur = 0;
                //Pour chaque ligne, traiter la ligne et traiter ses données
                if (tbPays.Text.Trim() != "")
                {
                    while (srFichierPaysPop.Peek() != -1)
                    {
                        traiterLignePaysPop(ref strNomPays, ref strNomLangue, ref longPop, ref srFichierPaysPop);
                        if (strNomPays == tbPays.Text.ToUpper())
                        {
                            intCompteur++; //Incr. Compteur
                            longSomme += longPop; //Ajouter a notre somme
                            strBufferParPays += string.Format("{0}:     {1} personnes" + Environment.NewLine, strNomLangue.PadRight(15), longPop.ToString("n0"));//Afficher les résulats a chaque fois qu'on a un résulat de recherche
                        }
                    }

                    //Si on a trouvé des données...
                    if (intCompteur > 0)
                    {
                        ecrireResultat("Données concernant le pays '" + tbPays.Text.ToUpper() + "' :" + Environment.NewLine, booFichier, booEcran, ref swFichierResultats);
                        ecrireResultat(strBufferParPays.TrimEnd('\n'), booFichier, booEcran, ref swFichierResultats);
                        ecrireResultat("Il y a " + intCompteur.ToString("n0") + " langues pour une population recensée de " + longSomme.ToString("n0") + " personnes.", booFichier, booEcran, ref swFichierResultats);
                    }
                    else //sinon, le pays n'est pas dans le fichier
                    {
                        MessageBox.Show(String.Format("Le pays {0} n'a pas été trouvée dans le fichier {1}", tbPays.Text, tbFichierPaysPop.Text));
                    }
                }
                else
                {
                    MessageBox.Show("Aucune langue saisie!");
                }
            }

            //Ecrire le fichier et fermer les streamreader et writer pour terminer
            ecrireHistorique();

            swFichierResultats.Close();
            srFichierPaysPop.Close();
        }

        private void btnEffHist_Click(object sender, EventArgs e)
        {
            if (File.Exists("historique.txt"))
            {
                CultureInfo ciFrancaisCanada = new CultureInfo("fr-CA");
                FileInfo fiHistorique = new FileInfo("historique.txt");
                string strDate = fiHistorique.LastWriteTime.Date.ToString("d", ciFrancaisCanada);
                string strHeure = fiHistorique.LastWriteTime.TimeOfDay.ToString("t", ciFrancaisCanada);
                DialogResult dlgMessage = new DialogResult();
                dlgMessage = MessageBox.Show("Voulez vous vraiment effacer le fichier historique qui a été modifiée pour la dernière fois le " + strDate + " à " + strHeure, "Effacer l'Historique?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgMessage == DialogResult.Yes)
                {
                    File.Delete("historique.txt");
                    lblResultats.Text = "Le fichier historique.txt à été supprimé";
                }
            }
            else
            {
                MessageBox.Show("Le fichier historique n'existe pas!");
            }
        }

        private void cbLangue_CheckedChanged(object sender, EventArgs e)
        {
            cbLangue.Checked = true; //Prévient l'utilisateur de décocher cbLangue
        }

        private void cbPays_CheckedChanged(object sender, EventArgs e)
        {
            //Logique pour basculer les controles selon l'état de cbPays
            cbLangue.Checked = !cbLangue.Checked;
            List<Control> lstControles = new List<Control> { cbLangue, lbLangues, cbTotalLangue, cbPaysMoinParle, cbPaysPlusParle };
            foreach (Control ctl in lstControles)
                ctl.Enabled = !ctl.Enabled; //Basculer chaque controle

            if (rbFichier.Checked || rbLesDeux.Checked)
            {
                rbFichier.Checked = false;
                rbLesDeux.Checked = false;
            }

            rbEcran.Checked = true;
            rbFichier.Enabled = !rbFichier.Enabled;
            rbLesDeux.Enabled = !rbLesDeux.Enabled;
            tbPays.Visible = !tbPays.Visible;
        }
    }
}
