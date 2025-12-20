using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ticari_Otamasyon
{
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void firmalistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR From Tbl_Iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIL.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void carikodaciklamalar()
        {
            SqlCommand komut = new SqlCommand("Select Firmakod1 From Tbl_Kodlar", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                RchKod1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }
        void temizle()
        {
            TxtAd.Text = "";
            TxtGorev.Text = "";
            TxtId.Text = "";
            TxtKod1.Text = "";
            TxtKod2.Text = "";
            TxtKod3.Text = "";
            TxtSektor.Text = "";
            TxtYetkili.Text = "";
            MskTc.Text = "";
            MskTelefon1.Text = "";
            MskTelefon2.Text = "";
            MskTelefon3.Text = "";
            MakFax.Text = "";
            TxtMail.Text = "";
            CmbIL.Text = "";
            CmbILCE.Text = "";
            TxtVergi.Text = "";
            RchAddress.Text = "";
            RchKod1.Text = "";
            RchKod2.Text = "";
            RchKod3.Text = "";
        }
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            sehirlistesi();
            firmalistele();
            carikodaciklamalar();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {

                TxtId.Text = dr["ID"].ToString();
                TxtAd.Text = dr["Ad"].ToString();
                TxtSektor.Text = dr["Sektor"].ToString();
                TxtYetkili.Text = dr["Yetkiliadsoyad"].ToString();
                TxtGorev.Text = dr["Yetkilistatu"].ToString();
                MskTc.Text = dr["YetkiliTc"].ToString();
                MskTelefon1.Text = dr["Telefon1"].ToString();
                MskTelefon2.Text = dr["Telefon2"].ToString();
                MskTelefon3.Text = dr["Telefon3"].ToString();
                MakFax.Text = dr["Fax"].ToString();
                TxtMail.Text = dr["Mail"].ToString();
                CmbIL.Text = dr["IL"].ToString();
                CmbILCE.Text = dr["Ilce"].ToString();
                TxtVergi.Text = dr["Vergidaire"].ToString();
                RchAddress.Text = dr["Address"].ToString();
                TxtKod1.Text = dr["Ozelkod1"].ToString();
                TxtKod2.Text = dr["Ozelkod2"].ToString();
                TxtKod3.Text = dr["Ozelkod3"].ToString();
            }
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Firmalar (Ad,Yetkilistatu,Yetkiliadsoyad,YetkiliTc,Sektor,Telefon1,Telefon2,Telefon3,Mail,Fax,IL,Ilce,Vergidaire,Address,Ozelkod1,Ozelkod2,Ozelkod3) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtGorev.Text);
            komut.Parameters.AddWithValue("@p3", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p4", MskTc.Text);
            komut.Parameters.AddWithValue("@p5", TxtSektor.Text);
            komut.Parameters.AddWithValue("@p6", MskTelefon1.Text);
            komut.Parameters.AddWithValue("@p7", MskTelefon2.Text);
            komut.Parameters.AddWithValue("@p8", MskTelefon3.Text);
            komut.Parameters.AddWithValue("@p9", TxtMail.Text);
            komut.Parameters.AddWithValue("@p10", MakFax.Text);
            komut.Parameters.AddWithValue("@p11", CmbIL.Text);
            komut.Parameters.AddWithValue("@p12", CmbILCE.Text);
            komut.Parameters.AddWithValue("@p13", TxtVergi.Text);
            komut.Parameters.AddWithValue("@p14", RchAddress.Text);
            komut.Parameters.AddWithValue("@p15", RchKod1.Text);
            komut.Parameters.AddWithValue("@p16", RchKod2.Text);
            komut.Parameters.AddWithValue("@p17", RchKod3.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Firma bilgileri Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalistele();
            temizle();
        }

        private void CmbIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbILCE.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select Ilce From Tbl_Ilceler where Sehirid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbIL.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbILCE.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Firmalar where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Firma Sistremden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalistele();
            temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Firmalar set Ad=@p1,Yetkilistatu=@p2,Yetkiliadsoyad=@p3,YetkiliTc=@p4,Sektor=@p5,Telefon1=@p6,Telefon2=@p7,Telefon3=@p8,Mail=@p9,Fax=@p10,IL=@p11,Ilce=@p12,Vergidaire=@p13,Address=@p14,Ozelkod1=@p15,Ozelkod2=@p16,Ozelkod3=@p17 where ID=@p18", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtGorev.Text);
            komut.Parameters.AddWithValue("@p3", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p4", MskTc.Text);
            komut.Parameters.AddWithValue("@p5", TxtSektor.Text);
            komut.Parameters.AddWithValue("@p6", MskTelefon1.Text);
            komut.Parameters.AddWithValue("@p7", MskTelefon2.Text);
            komut.Parameters.AddWithValue("@p8", MskTelefon3.Text);
            komut.Parameters.AddWithValue("@p9", TxtMail.Text);
            komut.Parameters.AddWithValue("@p10", MakFax.Text);
            komut.Parameters.AddWithValue("@p11", CmbIL.Text);
            komut.Parameters.AddWithValue("@p12", CmbILCE.Text);
            komut.Parameters.AddWithValue("@p13", TxtVergi.Text);
            komut.Parameters.AddWithValue("@p14", RchAddress.Text);
            komut.Parameters.AddWithValue("@p15", RchKod1.Text);
            komut.Parameters.AddWithValue("@p16", RchKod2.Text);
            komut.Parameters.AddWithValue("@p17", RchKod3.Text);
            komut.Parameters.AddWithValue("@p18", TxtId.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Firma Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalistele();
            temizle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
