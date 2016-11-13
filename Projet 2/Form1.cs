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

namespace Projet_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UI Logic functions [Show/Hide...]
        public void toggleGbNoms()
        {
            foreach(Control ctl in gbNoms.Controls)
            {
                ctl.Enabled = !ctl.Enabled;
            }
        }

        public void toggleGbCrit()
        {
            foreach(Control ctl in gbCrit.Controls)
            {
                ctl.Enabled = !ctl.Enabled;
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            toggleGbCrit();
        }

        #region Browse for files [purely for ease of use]
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

        #region Read files [StreamReader]

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

        public void traiterLignePaysPop(ref StreamReader srFichierPop, ref string strNomPays, ref string strNomLangue, ref long longPop)
        {
            //A chaque ligne lire 25 chars => pays (string)  // 15 chars => Langue (string) // Le reste de la ligne => Population (long)
            strNomPays = "";
            strNomLangue = "";
            longPop = 0;
            char[] t_charNomPays = new char[25];
            char[] t_charNomLangue = new char[15];

            //while(srFichierPop.Peek() != -1)
            //{
                srFichierPop.Read(t_charNomPays, 0, t_charNomPays.Length); //Lire NomPays 25char
                strNomPays = new string(t_charNomPays).Trim().ToUpper();
                srFichierPop.Read(t_charNomLangue, 0, t_charNomLangue.Length); //Lire NomLangue 15char
                strNomLangue = new string(t_charNomLangue).Trim().ToUpper();
                longPop = long.Parse(srFichierPop.ReadLine()); //Lire le reste de la ligne dans longPop
            //}
        }

        public void traiterPaysPop()
        {

        }

        #endregion

        private void btnLecture_Click(object sender, EventArgs e)
        {
            if (tbFichierLangues.Text == "")
            {
                MessageBox.Show("Aucun fichier des langues saisi!");
            }
            else if (File.Exists(tbFichierLangues.Text) == false)
            {
                MessageBox.Show("Le fichier des langues " + tbFichierLangues.Text + " est introuvable!");
            }
            else if (tbFichierPaysPop.Text == "")
            {
                MessageBox.Show("Aucun fichier des pays/population sasi!");
            }
            else if (File.Exists(tbFichierPaysPop.Text) == false)
            {
                MessageBox.Show("Le fichier des pays/population " + tbFichierPaysPop.Text + " est introuvable!");
            }
            else
            {
                //Valide
                toggleGbNoms();
                toggleGbCrit();
                lblResultats.Text = "Chargement complété ..." + Environment.NewLine;
                traiterFichierLangues();
                cbLangue.Checked = true;
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            StreamReader srFichierPaysPop = new StreamReader(tbFichierPaysPop.Text);
            string strNomPays = "";
            string strNomLangue = "";
            long longPop = 0;
            while(srFichierPaysPop.Peek() != -1)
            {
                traiterLignePaysPop(ref srFichierPaysPop, ref strNomPays, ref strNomLangue, ref longPop);
                lblResultats.Text += string.Format(" > {0} {1} {2}" + Environment.NewLine,strNomPays, strNomLangue, longPop.ToString());
            }
            MessageBox.Show(lblResultats.Text);
            srFichierPaysPop.Close();

            if(cbLangue.Checked == true)
            {
                //Recherche selon la langue...
                //if()
            }
            else
            {
                //Recherche selon le pays...

            }
        }

        private void btnEffHist_Click(object sender, EventArgs e)
        {

        }

        private void cbLangue_CheckedChanged(object sender, EventArgs e)
        {

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
            List<Control> lstControles = new List<Control> { cbLangue, lbLangues, cbTotalLangue, cbPaysMoinParle, cbPaysPlusParle };
            cbLangue.Checked = !cbLangue.Checked;
            foreach (Control ctl in lstControles)
            {
                ctl.Enabled = !ctl.Enabled;
            }

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
