using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            WSCercle.ServiceCercleClient _objetCommunication = new WSCercle.ServiceCercleClient();
            WSCercle.cercle _cercle = new WSCercle.cercle();
            _cercle._rayon = 2;
            double _resultat = _objetCommunication.calculePerimetre(_cercle);
            MessageBox.Show("le resultzt est :" + _resultat);

        }
    }
}
