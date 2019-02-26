using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirisEkrani
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void Hane_Adres_Click(object sender, EventArgs e)
        {
            Label_Tc fr3 = new Label_Tc();
            fr3.ShowDialog();
        }

        private void Nufus_Click(object sender, EventArgs e)
        {
            Visible = false;
            NufusBilgi fr5 = new NufusBilgi(this);
            fr5.Show();

        }
    }
}
