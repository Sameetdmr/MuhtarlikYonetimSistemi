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
    public partial class NufusBilgi : Form 
    {
        AnaEkran parent; //Ana sayfaya ulaşmak için Nesne oluşturup üzerinde işlemler yapma
        public NufusBilgi(AnaEkran parent)
        {

            this.parent = parent;
            InitializeComponent();
        }

        private void NufusBilgi_Load(object sender, EventArgs e) //Ana ekran yüklendiği zaman olacak şeyler
        {
            Medeni_Txt.SelectedIndex = 0;
            Dini_Txt.SelectedIndex = 0;
            KanGrub_Txt.SelectedIndex=0;
            Nüfus_Listview.FullRowSelect = true;
            Nüfus_Listview.MultiSelect = false;
            ListGuncelle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            parent.Show();
            parent.Visible = true;
            this.Close();
        }
        List<NufusKimlik> Nufus_Verileri = new List<NufusKimlik>();  //DataBase

        private void Nüfus_Listview_SelectedIndexChanged(object sender, EventArgs e) //Listview tıklandığı zaman
        {
            if (Nüfus_Listview.SelectedItems.Count > 0) //doldurma işlemleri
            {
                ListViewItem item = Nüfus_Listview.SelectedItems[0];
                string Tc = item.SubItems[0].Text;
                NufusKimlik nufus = getNufusKimlik(Tc);
                Tc_Txt.Text = nufus.Tc;
                Adi_txt.Text = nufus.Adi;
                Soyadi_Txt.Text = nufus.Soyadi;
                SeriNo_Txt.Text = nufus.Seri_No;
                Seri_Txt.Text = nufus.Seri;
                Baba_Txt.Text = nufus.Baba_Adi;
                Anne_Txt.Text = nufus.Anne_Adi;
                Dogum_Txt.Text = nufus.Dogum_Yeri;
                DogumTrh_datetime.Text = nufus.Dogum_Tarihi;
                Medeni_Txt.Text = nufus.Medeni_Hal;
                Dini_Txt.Text = nufus.Dini;
                İl_Txt.Text = nufus.İl;
                İlce_Txt.Text = nufus.İlce;
                Koy_Txt.Text = nufus.Koy;
                CiltNo_Txt.Text = nufus.Cilt_No;
                AileSıraNo_Txt.Text = nufus.Aile_Sr_No;
                SıraNo_Txt.Text = nufus.Sıra_No;
                Verildigiyer_Txt.Text = nufus.Verildigi_Yer;
                VerilisNdn_Txt.Text = nufus.Verilis_Ndn;
                KayıtNo_Txt.Text = nufus.Kayıt_No;
                VerilisTrh_Txt.Text = nufus.Verilis_Trh;
                KanGrub_Txt.Text = nufus.Kan_Grubu;

            }
        }
        private NufusKimlik getNufusKimlik(string Tc)
        {
            foreach (NufusKimlik item in Nufus_Verileri)
            {
                if (item.Tc.Equals(Tc))
                    return item;
            }
            return null;
        }
        private void ListGuncelle()
        {

            Nüfus_Listview.Items.Clear();
            Nufus_Verileri = new DataBase1().Nufus_Verileri();
            foreach (NufusKimlik item in Nufus_Verileri)
            {
                Nüfus_Listview.Items.Add(new ListViewItem(new String[] { item.Tc ,item.Adi, item.Soyadi, item.Kan_Grubu,item.Dogum_Tarihi}));
            }
        }

        private void button3_Click(object sender, EventArgs e) //Kaydetme işlemi
        {
            NufusKimlik nufus = new NufusKimlik();
            nufus.Tc = Tc_Txt.Text;
            nufus.Adi = Adi_txt.Text;
            nufus.Soyadi = Soyadi_Txt.Text;
            nufus.Seri_No = SeriNo_Txt.Text;
            nufus.Seri = Seri_Txt.Text;
            nufus.Baba_Adi = Baba_Txt.Text;
            nufus.Anne_Adi = Anne_Txt.Text;
            nufus.Dogum_Yeri = Dogum_Txt.Text;
            nufus.Dogum_Tarihi = DogumTrh_datetime.Text;
            nufus.Medeni_Hal = Medeni_Txt.Text;
            nufus.Dini = Dini_Txt.Text;
            nufus.İl = İl_Txt.Text;
            nufus.İlce = İlce_Txt.Text;
            nufus.Koy = Koy_Txt.Text;
            nufus.Cilt_No = CiltNo_Txt.Text;
            nufus.Aile_Sr_No = AileSıraNo_Txt.Text;
            nufus.Sıra_No = SıraNo_Txt.Text;
            nufus.Verildigi_Yer = Verildigiyer_Txt.Text;
            nufus.Verilis_Ndn = VerilisNdn_Txt.Text;
            nufus.Kayıt_No = KayıtNo_Txt.Text;
            nufus.Verilis_Trh = VerilisTrh_Txt.Text;
            nufus.Kan_Grubu = KanGrub_Txt.Text;
            new DataBase1().Kaydet(nufus);
            Tc_Txt.Text = Adi_txt.Text = Soyadi_Txt.Text = SeriNo_Txt.Text = Seri_Txt.Text = Baba_Txt.Text = Anne_Txt.Text = Dogum_Txt.Text = Medeni_Txt.Text = Dini_Txt.Text = İlce_Txt.Text = İl_Txt.Text = Koy_Txt.Text = CiltNo_Txt.Text = AileSıraNo_Txt.Text = SıraNo_Txt.Text = Verildigiyer_Txt.Text = VerilisNdn_Txt.Text = KayıtNo_Txt.Text = KanGrub_Txt.Text = " ";
            ListGuncelle();
        }

        private void Güncelle_Btn_Click(object sender, EventArgs e)
        {
            NufusKimlik nufus = new NufusKimlik();
            nufus.Tc = Tc_Txt.Text;
            nufus.Adi = Adi_txt.Text;
            nufus.Soyadi = Soyadi_Txt.Text;
            nufus.Seri_No = SeriNo_Txt.Text;
            nufus.Seri = Seri_Txt.Text;
            nufus.Baba_Adi = Baba_Txt.Text;
            nufus.Anne_Adi = Anne_Txt.Text;
            nufus.Dogum_Yeri = Dogum_Txt.Text;
            nufus.Dogum_Tarihi = DogumTrh_datetime.Text;
            nufus.Medeni_Hal = Medeni_Txt.Text;
            nufus.Dini = Dini_Txt.Text;
            nufus.İl = İl_Txt.Text;
            nufus.İlce = İlce_Txt.Text;
            nufus.Koy = Koy_Txt.Text;
            nufus.Cilt_No = CiltNo_Txt.Text;
            nufus.Aile_Sr_No = AileSıraNo_Txt.Text;
            nufus.Sıra_No = SıraNo_Txt.Text;
            nufus.Verildigi_Yer = Verildigiyer_Txt.Text;
            nufus.Verilis_Ndn = VerilisNdn_Txt.Text;
            nufus.Kayıt_No = KayıtNo_Txt.Text;
            nufus.Verilis_Trh = VerilisTrh_Txt.Text;
            nufus.Kan_Grubu = KanGrub_Txt.Text;
            new DataBase1().Guncelle(nufus);
            Tc_Txt.Text = Adi_txt.Text = Soyadi_Txt.Text = SeriNo_Txt.Text = Seri_Txt.Text = Baba_Txt.Text = Anne_Txt.Text = Dogum_Txt.Text = Medeni_Txt.Text = Dini_Txt.Text = İlce_Txt.Text = İl_Txt.Text = Koy_Txt.Text = CiltNo_Txt.Text = AileSıraNo_Txt.Text = SıraNo_Txt.Text = Verildigiyer_Txt.Text = VerilisNdn_Txt.Text = KayıtNo_Txt.Text = KanGrub_Txt.Text = " ";
            ListGuncelle();
        }

        private void Tc_Txt_MouseClick(object sender, MouseEventArgs e)
        {
            Tc_Txt.SelectionStart = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Nüfus_Listview.SelectedItems.Count > 0)
            {
                ListViewItem item = Nüfus_Listview.SelectedItems[0];
                string Tc = item.SubItems[0].Text;
                new DataBase1().Kisi_Sil(Tc);
                ListGuncelle();
            }
        }
    }
}
