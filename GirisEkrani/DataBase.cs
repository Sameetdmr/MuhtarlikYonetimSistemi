using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace GirisEkrani
{
    class DataBase
    {
        OleDbConnection baglanti;
        OleDbCommand komut;
        public DataBase()
        {
            baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Giris.mdb");
            komut = new OleDbCommand();
            komut.Connection = baglanti;
        }
        public void Guncelle(kisi kisi)
        {
            Kisi_Sil(kisi.Tc);
            Kaydet(kisi);
        }
        public void Kisi_Sil(string tc)
        {
            baglanti.Open();
            komut.CommandText = "Delete from HaneBilgi where Tc='" + tc + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void Kaydet(kisi kisi)
        {
            baglanti.Open();
            komut.CommandText = "insert into HaneBilgi(Tc,Adi,Soyadi,Cinsiyet,Uyruk,Meslek,HaneYakinlik,CepTelefonu,OgrenimDurumu,Kayit_Tarihi,Semt,Cadde,Sokak,Apt_Adi,B_No,D_No,Ev_Telefon,İl,İlce,Koy,F_Düzey,K_Tür,ResimYol) values(@Tc,@Adi,@Soyadi,@Cinsiyet,@Uyruk,@Meslek,@HaneYakinlik,@CepTelefonu,@OgrenimDurumu,@Kayit_Tarihi,@Semt,@Cadde,@Sokak,@Apt_Adi,@B_No,@D_No,@Ev_Telefon,@İl,@İlce,@Koy,@F_Düzey,@K_Tür,@ResimYol)";

            komut.Parameters.AddWithValue("@Tc", kisi.Tc);
            komut.Parameters.AddWithValue("@Adi", kisi.Adi);
            komut.Parameters.AddWithValue("@Soyadi", kisi.Soyadi);
            komut.Parameters.AddWithValue("@Cinsiyet", kisi.Cinsiyet);
            komut.Parameters.AddWithValue("@Uyruk", kisi.Uyruk);
            komut.Parameters.AddWithValue("@Meslek", kisi.Meslek);
            komut.Parameters.AddWithValue("@HaneYakinlik", kisi.HaneYakinlik);
            komut.Parameters.AddWithValue("@CepTelefonu", kisi.CepTelefonu);
            komut.Parameters.AddWithValue("@OgrenimDurumu", kisi.OgrenimDurumu);
            komut.Parameters.AddWithValue("@Kayit_Tarihi", kisi.Kayit_Tarihi);
            komut.Parameters.AddWithValue("@Semt", kisi.Semt);
            komut.Parameters.AddWithValue("@Cadde", kisi.Cadde);
            komut.Parameters.AddWithValue("@Sokak", kisi.Sokak);
            komut.Parameters.AddWithValue("@Apt_Adi", kisi.Apt_Adi);
            komut.Parameters.AddWithValue("@B_No", kisi.B_No);
            komut.Parameters.AddWithValue("@D_No", kisi.D_No);
            komut.Parameters.AddWithValue("@Ev_Telefonu", kisi.Ev_Telefon);
            komut.Parameters.AddWithValue("@İl", kisi.İl);
            komut.Parameters.AddWithValue("@İlce", kisi.İlce);
            komut.Parameters.AddWithValue("@Koy", kisi.Koy);
            komut.Parameters.AddWithValue("@F_Düzey", kisi.F_Düzey);
            komut.Parameters.AddWithValue("@K_Tür", kisi.K_Tür);
            komut.Parameters.AddWithValue("@ResimYol", kisi.ResimYol);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public List<kisi> getKisiler()
        {
            baglanti.Open();
            List<kisi> kisiler = new List<kisi>();
            komut.CommandText = "Select *From HaneBilgi";
            OleDbDataReader rd = komut.ExecuteReader(); //veritabanında verileri okuma
            while (rd.Read())
            {
                kisi item = new kisi();
                item.Tc = rd["Tc"].ToString();
                item.Adi = rd["Adi"].ToString();
                item.Soyadi = rd["Soyadi"].ToString();
                item.Cinsiyet = rd["Cinsiyet"].ToString();
                item.Uyruk = rd["Uyruk"].ToString();
                item.Meslek = rd["Meslek"].ToString();
                item.HaneYakinlik = rd["HaneYakinlik"].ToString();
                item.CepTelefonu = rd["CepTelefonu"].ToString();
                item.OgrenimDurumu = rd["OgrenimDurumu"].ToString();
                item.Kayit_Tarihi = rd["Kayit_Tarihi"].ToString();
                item.Semt = rd["Semt"].ToString();
                item.Cadde = rd["Cadde"].ToString();
                item.Sokak = rd["Sokak"].ToString();
                item.Apt_Adi = rd["Apt_Adi"].ToString();
                item.B_No = rd["B_No"].ToString();
                item.D_No = rd["D_No"].ToString();
                item.Ev_Telefon = rd["Ev_Telefon"].ToString();
                item.İl = rd["İl"].ToString();
                item.İlce = rd["İlce"].ToString();
                item.Koy = rd["Koy"].ToString();
                item.F_Düzey = rd["F_Düzey"].ToString();
                item.K_Tür = rd["K_Tür"].ToString();
                item.ResimYol = rd["ResimYol"].ToString();

                kisiler.Add(item);
            }

            baglanti.Close();
            return kisiler;
        }
    }

    class kisi
    {
        public string Adi;
        public string Soyadi;
        public string Cinsiyet;
        public string Uyruk;
        public string Meslek;
        public string HaneYakinlik;
        public string CepTelefonu;
        public string OgrenimDurumu;
        public string Kayit_Tarihi;
        public string Semt;
        public string Cadde;
        public string Sokak;
        public string Apt_Adi;
        public string B_No;
        public string D_No;
        public string Ev_Telefon;
        public string İl;
        public string İlce;
        public string Koy;
        public string F_Düzey;
        public string K_Tür;
        public string ResimYol;
        public string Tc;


    }
    class NufusKimlik //Nüfüs kimlik elemanlarını public olarak tanımlama yeri 
    {
        public string Tc;
        public string Adi;
        public string Soyadi;
        public string Seri_No;
        public string Seri;
        public string Baba_Adi;
        public string Anne_Adi;
        public string Dogum_Yeri;
        public string Dogum_Tarihi;
        public string Medeni_Hal;
        public string Dini;
        public string İl;
        public string İlce;
        public string Koy;
        public string Cilt_No;
        public string Aile_Sr_No;
        public string Sıra_No;
        public string Verildigi_Yer;
        public string Verilis_Ndn;
        public string Kayıt_No;
        public string Verilis_Trh;
        public string Kan_Grubu;
        public string Resim_Yolu;







    }

    class DataBase1 //Nüfüs kimlik DataBase Tanımlama Bölgesi
    {
        OleDbConnection baglanti1;
        OleDbCommand komut1;
        public DataBase1()
        {
            baglanti1 = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Giris.mdb");
            komut1 = new OleDbCommand();
            komut1.Connection = baglanti1;
        }

        public void Kaydet(NufusKimlik nufusBilgi) //Veri Tabanına Kaydetme Kısmı verileri Teker teker
        {
            baglanti1.Open();
            komut1.CommandText = "insert into NufusBilgi(Tc,Adi,Soyadi,Seri_No,Seri,Baba_Adi,Anne_Adi,Dogum_Yeri,Dogum_Tarihi,Medeni_Hal,Dini,İl,İlce,Koy,Cilt_No,Aile_Sr_No,Sıra_No,Verildigi_Yer,Verilis_Ndn,Kayıt_No,Verilis_Trh,Kan_Grubu) values(@Tc,@Adi,@Soyadi,@Seri_No,@Seri,@Baba_Adi,@Anne_Adi,@Dogum_Yeri,@Dogum_Tarihi,@Medeni_Hal,@Dini,@İl,@İlce,@Koy,@Cilt_No,@Aile_Sr_No,@Sıra_No,@Verildigi_Yer,@Verilis_Ndn,@Kayıt_No,@Verilis_Trh,@Kan_Grubu)";
            komut1.Parameters.AddWithValue("@Tc", nufusBilgi.Tc);
            komut1.Parameters.AddWithValue("@Adi", nufusBilgi.Adi);
            komut1.Parameters.AddWithValue("@Soyadi", nufusBilgi.Soyadi);
            komut1.Parameters.AddWithValue("@Seri_No", nufusBilgi.Seri_No);
            komut1.Parameters.AddWithValue("@Seri", nufusBilgi.Seri);
            komut1.Parameters.AddWithValue("@Baba_Adi", nufusBilgi.Baba_Adi);
            komut1.Parameters.AddWithValue("@Anne_Adi", nufusBilgi.Anne_Adi);
            komut1.Parameters.AddWithValue("@Dogum_Yeri", nufusBilgi.Dogum_Yeri);
            komut1.Parameters.AddWithValue("@Dogum_Tarihi", nufusBilgi.Dogum_Tarihi);
            komut1.Parameters.AddWithValue("@Medeni_Hal", nufusBilgi.Medeni_Hal);
            komut1.Parameters.AddWithValue("@Dini", nufusBilgi.Dini);
            komut1.Parameters.AddWithValue("@İl", nufusBilgi.İl);
            komut1.Parameters.AddWithValue("@İlce", nufusBilgi.İlce);
            komut1.Parameters.AddWithValue("@Koy", nufusBilgi.Koy);
            komut1.Parameters.AddWithValue("@Cilt_No", nufusBilgi.Cilt_No);
            komut1.Parameters.AddWithValue("@Aile_Sr_No", nufusBilgi.Aile_Sr_No);
            komut1.Parameters.AddWithValue("@Sıra_No", nufusBilgi.Sıra_No);
            komut1.Parameters.AddWithValue("@Verildigi_Yer", nufusBilgi.Verildigi_Yer);
            komut1.Parameters.AddWithValue("@Verilis_Ndn", nufusBilgi.Verilis_Ndn);
            komut1.Parameters.AddWithValue("@Kayıt_No", nufusBilgi.Kayıt_No);
            komut1.Parameters.AddWithValue("@Verilis_Trh", nufusBilgi.Verilis_Trh);
            komut1.Parameters.AddWithValue("@Kan_Grubu", nufusBilgi.Kan_Grubu);

            komut1.ExecuteNonQuery();
            baglanti1.Close();
          }
        public List<NufusKimlik> Nufus_Verileri() //
        {
            baglanti1.Open();
            List<NufusKimlik> Nufus_Verileri = new List<NufusKimlik>();
            komut1.CommandText = "Select *From NufusBilgi";
            OleDbDataReader rd = komut1.ExecuteReader();
            while (rd.Read())
            {
                NufusKimlik item = new NufusKimlik();
                item.Tc = rd["Tc"].ToString();
                item.Adi = rd["Adi"].ToString();
                item.Soyadi = rd["Soyadi"].ToString();
                item.Seri_No = rd["Seri_No"].ToString();
                item.Seri = rd["Seri"].ToString();
                item.Baba_Adi = rd["Baba_Adi"].ToString();
                item.Anne_Adi = rd["Anne_Adi"].ToString();
                item.Dogum_Yeri = rd["Dogum_Yeri"].ToString();
                item.Dogum_Tarihi = rd["Dogum_Tarihi"].ToString();
                item.Medeni_Hal = rd["Medeni_Hal"].ToString();
                item.Dini = rd["Dini"].ToString();
                item.İl = rd["İl"].ToString();
                item.İlce = rd["İlce"].ToString();
                item.Koy = rd["Koy"].ToString();
                item.Cilt_No = rd["Cilt_No"].ToString();
                item.Aile_Sr_No = rd["Aile_Sr_No"].ToString();
                item.Sıra_No = rd["Sıra_No"].ToString();
                item.Verildigi_Yer = rd["Verildigi_Yer"].ToString();
                item.Verilis_Ndn = rd["Verilis_Ndn"].ToString();
                item.Kayıt_No = rd["Kayıt_No"].ToString();
                item.Verilis_Trh = rd["Verilis_Trh"].ToString();
                item.Kan_Grubu = rd["Kan_Grubu"].ToString();

                Nufus_Verileri.Add(item);
            }
            baglanti1.Close();
            return Nufus_Verileri;
        }
        public void Guncelle(NufusKimlik nufus)
        {
            Kisi_Sil(nufus.Tc);
            Kaydet(nufus);
        }
        public void Kisi_Sil(string tc)
        {
            baglanti1.Open();
            komut1.CommandText = "Delete from NufusBilgi where Tc='" + tc + "'";
            komut1.ExecuteNonQuery();
            baglanti1.Close();
        }
    }
}
