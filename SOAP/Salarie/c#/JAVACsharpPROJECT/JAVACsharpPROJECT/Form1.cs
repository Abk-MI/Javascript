using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAVACsharpPROJECT
{
    public partial class Form1 : Form
    {
        ServiceReference1.serviceClient _objCom = new ServiceReference1.serviceClient();
        enum _modeconsultation {consultation,ajout,modification,supprission };
        _modeconsultation mode;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mode = _modeconsultation.consultation;
            informationsalarie.Enabled = false;
            ServiceReference1.salarie[] tableausalarie = _objCom.RecupereListeSalarie();
            ListeGrid.DataSource = tableausalarie;
            ValiderButton.Visible = false;
     
        }

        private void Ajoutbutton_Click(object sender, EventArgs e)
        {
            mode = _modeconsultation.ajout;
            informationsalarie.Enabled = true;
            ModifierButton.Enabled = false;
            SupprimerButton.Enabled = false;
            listedessalariebox.Enabled = false;
            Ajoutbutton.Enabled = false;
            ValiderButton.Visible = true;

        }

        private void ModifierButton_Click(object sender, EventArgs e)
        {
            mode = _modeconsultation.modification;
            informationsalarie.Enabled = true;
            SupprimerButton.Enabled = false;
            listedessalariebox.Enabled = true;

            Codetext.Text = ListeGrid.SelectedCells[0].ToString();
            Nomtext.Text = ListeGrid.SelectedCells[1].ToString();
            Prenomtext.Text = ListeGrid.SelectedCells[2].ToString();
            Adressetext.Text = ListeGrid.SelectedCells[3].ToString();
            Fonctionlist.Text = ListeGrid.SelectedCells[4].ToString();
            Departementlist.Text = ListeGrid.SelectedCells[5].ToString();
            Teltext.Text = ListeGrid.SelectedCells[6].ToString();
            Emailtext.Text = ListeGrid.SelectedCells[7].ToString();

            Ajoutbutton.Enabled = false;
            ValiderButton.Visible = true;
        }

        private void SupprimerButton_Click(object sender, EventArgs e)
        {
            mode = _modeconsultation.supprission;
            informationsalarie.Enabled = false;
            Ajoutbutton.Enabled = false;
            ModifierButton.Enabled = false;



        }

        private void ValiderButton_Click(object sender, EventArgs e)
        {
            int _code = Int32.Parse(Codetext.Text);
            String _nom = Nomtext.Text;
            String _prenom = Prenomtext.Text;
            String _adresse = Adressetext.Text;
            String _function = Fonctionlist.SelectedIndex.ToString();
            String _departement = Departementlist.SelectedIndex.ToString();
            int _tel = Int32.Parse(Teltext.Text);
            String _email = Emailtext.Text;


            if (mode==_modeconsultation.ajout)
            {
                ServiceReference1.salarie sal = new ServiceReference1.salarie();
                sal.nom = _nom;
                sal.prenom = _prenom;
                sal.adrs = _adresse;
                sal.code = _code;
                sal.email = _email;
                sal.fonct = _function;
                sal.depts = _departement;
                sal.tel = _tel;

                String rep = _objCom.AjouteSalarie(sal);

            }else if (mode == _modeconsultation.modification)
            {
                ServiceReference1.salarie sal = new ServiceReference1.salarie();
                sal.nom = _nom;
                sal.prenom = _prenom;
                sal.adrs = _adresse;
                sal.code = _code;
                sal.email = _email;
                sal.fonct = _function;
                sal.depts = _departement;
                sal.tel = _tel;

                ServiceReference1.salarie sal2 = new ServiceReference1.salarie();

                sal2.nom = ListeGrid.SelectedCells[1].ToString();
                sal2.prenom = ListeGrid.SelectedCells[2].ToString();
                sal2.adrs = ListeGrid.SelectedCells[3].ToString();
                sal2.email = ListeGrid.SelectedCells[5].ToString();
                sal2.fonct = ListeGrid.SelectedCells[6].ToString();
                sal2.depts = ListeGrid.SelectedCells[4].ToString();

                String rep = _objCom.ModifieSalarie(sal,sal2);

            }

        }

        private void QuitterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
