using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;
namespace GirisEkrani
{
    public partial class Mos : Form
    {
        public Mos()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        private void K_Giris_Click(object sender, EventArgs e)
        {
            /* string ad = K_adi.Text;
             string sifre = K_Sifre.Text;
             con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\samed.SAMET_DEMIR\Desktop\Mos\Giris.mdb");
             cmd = new OleDbCommand();
             con.Open();
             cmd.Connection = con;
             cmd.CommandText = "SELECT * FROM Kullanici where k_Ad='" + K_adi.Text + "' AND k_sifre='" + K_Sifre.Text + "'";
             dr = cmd.ExecuteReader();
             if (dr.Read())
             {
                 AnaEkran f2 = new AnaEkran();
                 MessageBox.Show("Hoşgeldiniz", "Muhtarlık Bilgi Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 f2.Show();
                 this.Hide();
             }
             else
             {
                 MessageBox.Show("Kullanıcı Adı ya da Şifre Yanlış","Muhtarlık Bilgi Sistemi",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
             }
             con.Close();*/
            this.Hide();
            new AnaEkran().Show();
        }

        private void Mos_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"D:\MuhtarResimler"))
                Directory.CreateDirectory(@"D:\MuhtarResimler");
        }
    }
}
