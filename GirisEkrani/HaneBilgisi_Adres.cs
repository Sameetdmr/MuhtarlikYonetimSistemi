using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GirisEkrani
{
    public partial class Label_Tc : Form
    {
        List<kisi> kisiler = new List<kisi>();
        public Label_Tc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Kaydet_Click(object sender, EventArgs e)
        {
            if (!TC.MaskCompleted)
            {
                MessageBox.Show("TC Boş Olamaz", "Muhtarlık Bilgi Sistemi", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
                return;
            }
            if (Adi.Text == "" || Adi.Text == " ")
            {
                MessageBox.Show("Adı Boş Olamaz", "Muhtarlık Bilgi Sistemi", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
                return;
            }
            kisi kisi = new kisi(); DosyaKaydet();
            kisi.Adi = Adi.Text;
            kisi.Soyadi = Soyadi.Text;
            kisi.Cinsiyet = Cinsiyet.Text;
            kisi.Uyruk = Uyruk.Text;
            kisi.Meslek = Meslek.Text;
            kisi.HaneYakinlik = HaneYakinlik.Text;
            kisi.CepTelefonu = CepTelefonu.Text;
            kisi.OgrenimDurumu = Egitim.Text;
            kisi.Kayit_Tarihi = Tarih.Text;
            kisi.Semt = Mahalle.Text;
            kisi.Cadde = Cadde.Text;
            kisi.Sokak = Sokak.Text;
            kisi.Apt_Adi = ApartmanAdi.Text;
            kisi.B_No = BinaNo.Text;
            kisi.D_No = DaireNo.Text;
            kisi.Ev_Telefon = EvTelefonu.Text;
            kisi.İl = İl.Text;
            kisi.İlce = İlce.Text;
            kisi.Koy = Koy.Text;
            kisi.F_Düzey = F_Derece.Text;
            kisi.K_Tür = k_Tur.Text;
            kisi.ResimYol = ResimYol.Text;
            kisi.Tc = TC.Text;
            new DataBase().Kaydet(kisi);
            Resim.ImageLocation = Adi.Text = Soyadi.Text = Cinsiyet.Text = Uyruk.Text = Meslek.Text = HaneYakinlik.Text = CepTelefonu.Text = Egitim.Text = Tarih.Text = Mahalle.Text = Cadde.Text = Sokak.Text = ApartmanAdi.Text = BinaNo.Text = DaireNo.Text = EvTelefonu.Text = İl.Text = İlce.Text = Koy.Text = F_Derece.Text = k_Tur.Text = ResimYol.Text = TC.Text = "";
            ListGuncelle();

        }
        private void HaneBilgisi_Adres_Veri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HaneBilgisi_Adres_Veri.SelectedItems.Count > 0)
            {
                ListViewItem item = HaneBilgisi_Adres_Veri.SelectedItems[0];
                string Tc = item.SubItems[0].Text;
                kisi Kisi_item = getKisi(Tc);
                TC.Text = Kisi_item.Tc;
                Adi.Text = Kisi_item.Adi;
                Soyadi.Text = Kisi_item.Soyadi;
                Cinsiyet.Text = Kisi_item.Cinsiyet;
                Uyruk.Text = Kisi_item.Uyruk;
                Meslek.Text = Kisi_item.Meslek;
                HaneYakinlik.Text = Kisi_item.HaneYakinlik;
                CepTelefonu.Text = Kisi_item.CepTelefonu;
                Egitim.Text = Kisi_item.OgrenimDurumu;
                Tarih.Text = Kisi_item.Kayit_Tarihi;
                Mahalle.Text = Kisi_item.Semt;
                Cadde.Text = Kisi_item.Cadde;
                Sokak.Text = Kisi_item.Sokak;
                ApartmanAdi.Text = Kisi_item.Apt_Adi;
                BinaNo.Text = Kisi_item.B_No;
                DaireNo.Text = Kisi_item.D_No;
                EvTelefonu.Text = Kisi_item.Ev_Telefon;
                İl.Text = Kisi_item.İl;
                İlce.Text = Kisi_item.İlce;
                Koy.Text = Kisi_item.Koy;
                F_Derece.Text = Kisi_item.F_Düzey;
                k_Tur.Text = Kisi_item.K_Tür;
                Resim.ImageLocation = ResimYol.Text = Kisi_item.ResimYol;
            }
        }
        private void HaneBilgisi_Adres_Load(object sender, EventArgs e)
        {
            Cinsiyet.SelectedIndex = 0;
            Uyruk.SelectedIndex = 0;
            Egitim.SelectedIndex = 0;
            F_Derece.SelectedIndex = 0;
            k_Tur.SelectedIndex = 0;
            HaneYakinlik.SelectedIndex = 0;
            HaneBilgisi_Adres_Veri.FullRowSelect = true;
            HaneBilgisi_Adres_Veri.MultiSelect = false;
            ListGuncelle();
        }
        private void ListGuncelle()
        {

            HaneBilgisi_Adres_Veri.Items.Clear();
            kisiler = new DataBase().getKisiler();
            foreach (kisi item in kisiler)
            {
                HaneBilgisi_Adres_Veri.Items.Add(new ListViewItem(new String[] { item.Tc, item.Adi, item.Soyadi, item.HaneYakinlik, item.Meslek, item.Cinsiyet }));
            }
        }

        private void Resim_Kyd_Click(object sender, EventArgs e) 
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;|  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            ResimYol.Text = dosyayolu;
            Resim.ImageLocation = dosyayolu;
        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            TC.SelectionStart = 0;
            CepTelefonu.SelectionStart = 1;
        }
        private void DosyaKaydet() //Dosyayı oldugu yerden belirtilen yeree kaydetme işlemi
        {
            if (ResimYol.Text == "")
                return;
            else if (File.Exists(@"D:\MuhtarResimler\" + TC.Text + ".jpg"))
                File.Delete(@"D:\MuhtarResimler\" + TC.Text + ".jpg");
            File.Copy(ResimYol.Text, @"D:\MuhtarResimler\" + TC.Text + ".jpg");
            ResimYol.Text = @"D:\MuhtarResimler\" + TC.Text + ".jpg";

        }
        private void Güncelle_Click(object sender, EventArgs e)
        {
            kisi kisi = new kisi();
            DosyaKaydet();
            kisi.Adi = Adi.Text;
            kisi.Soyadi = Soyadi.Text;
            kisi.Cinsiyet = Cinsiyet.Text;
            kisi.Uyruk = Uyruk.Text;
            kisi.Meslek = Meslek.Text;
            kisi.HaneYakinlik = HaneYakinlik.Text;
            kisi.CepTelefonu = CepTelefonu.Text;
            kisi.OgrenimDurumu = Egitim.Text;
            kisi.Kayit_Tarihi = Tarih.Text;
            kisi.Semt = Mahalle.Text;
            kisi.Cadde = Cadde.Text;
            kisi.Sokak = Sokak.Text;
            kisi.Apt_Adi = ApartmanAdi.Text;
            kisi.B_No = BinaNo.Text;
            kisi.D_No = DaireNo.Text;
            kisi.Ev_Telefon = EvTelefonu.Text;
            kisi.İl = İl.Text;
            kisi.İlce = İlce.Text;
            kisi.Koy = Koy.Text;
            kisi.F_Düzey = F_Derece.Text;
            kisi.K_Tür = k_Tur.Text;
            kisi.ResimYol = ResimYol.Text;
            kisi.Tc = TC.Text;
            new DataBase().Guncelle(kisi);
            Resim.ImageLocation = Adi.Text = Soyadi.Text = Cinsiyet.Text = Uyruk.Text = Meslek.Text = HaneYakinlik.Text = CepTelefonu.Text = Egitim.Text = Tarih.Text = Mahalle.Text = Cadde.Text = Sokak.Text = ApartmanAdi.Text = BinaNo.Text = DaireNo.Text = EvTelefonu.Text = İl.Text = İlce.Text = Koy.Text = F_Derece.Text = k_Tur.Text = ResimYol.Text = TC.Text = "";
            ListGuncelle();
        }
        private kisi getKisi(string tc)
        {
            foreach (kisi item in kisiler)
            {
                if (item.Tc.Equals(tc))
                    return item;
            }
            return null;
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (HaneBilgisi_Adres_Veri.SelectedItems.Count > 0)
            {
                ListViewItem item = HaneBilgisi_Adres_Veri.SelectedItems[0];
                string Tc = item.SubItems[0].Text;
                new DataBase().Kisi_Sil(Tc);
                ListGuncelle();
            }
        }
    }
}
