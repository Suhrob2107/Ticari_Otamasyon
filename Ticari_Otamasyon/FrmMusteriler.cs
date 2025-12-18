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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        sqlbaglantisi sqlbaglantisi = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Musteriler", sqlbaglantisi.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("select Sehir from Tbl_Iller", sqlbaglantisi.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIL.Properties.Items.Add(dr[0]);
            }
            sqlbaglantisi.baglanti().Close();
        }
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
        }

        private void CmbIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbILCE.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("select Ilce from Tbl_Ilceler where Sehirid=@p1", sqlbaglantisi.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbIL.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbILCE.Properties.Items.Add(dr[0]);
            }
            sqlbaglantisi.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Musteriler (Ad,Soyad,Telefon,Telefon2,TC,Mail,IL,Ilce,Adress,Vergidaire) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", sqlbaglantisi.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon1.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon2.Text);
            komut.Parameters.AddWithValue("@p5", MskTc.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.Parameters.AddWithValue("@p7", CmbIL.Text);
            komut.Parameters.AddWithValue("@p8", CmbILCE.Text);
            komut.Parameters.AddWithValue("@p9", RchAddress.Text);
            komut.Parameters.AddWithValue("@p10", TxtVergi.Text);
            komut.ExecuteNonQuery();
            sqlbaglantisi.baglanti().Close();
            MessageBox.Show("Müşteri Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from Tbl_Musteriler where ID=@p1", sqlbaglantisi.baglanti());
            komutsil.Parameters.AddWithValue("@p1", TxtId.Text);
            komutsil.ExecuteNonQuery();
            sqlbaglantisi.baglanti().Close();
            MessageBox.Show("Müşteri Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("update Tbl_Musteriler set Ad=@p1,Soyad=@p2,Telefon=@p3,Telefon2=@p4,TC=@p5,Mail=@p6,IL=@p7,Ilce=@p8,Adress=@p9,Vergidaire=@p10 where ID=@p11", sqlbaglantisi.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", TxtAd.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@p3", MskTelefon1.Text);
            sqlCommand.Parameters.AddWithValue("@p4", MskTelefon2.Text);
            sqlCommand.Parameters.AddWithValue("@p5", MskTc.Text);
            sqlCommand.Parameters.AddWithValue("@p6", TxtMail.Text);
            sqlCommand.Parameters.AddWithValue("@p7", CmbIL.Text);
            sqlCommand.Parameters.AddWithValue("@p8", CmbILCE.Text);
            sqlCommand.Parameters.AddWithValue("@p9", RchAddress.Text);
            sqlCommand.Parameters.AddWithValue("@p10", TxtVergi.Text);
            sqlCommand.Parameters.AddWithValue("@p11", TxtId.Text);
            sqlCommand.ExecuteNonQuery();
            sqlbaglantisi.baglanti().Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtId.Text = dr["ID"].ToString();
            TxtAd.Text = dr["Ad"].ToString();
            TxtSoyad.Text = dr["Soyad"].ToString();
            MskTelefon1.Text = dr["Telefon"].ToString();
            MskTelefon2.Text = dr["Telefon2"].ToString();
            MskTc.Text = dr["TC"].ToString();
            TxtMail.Text = dr["Mail"].ToString();
            CmbIL.Text = dr["IL"].ToString();
            CmbILCE.Text = dr["Ilce"].ToString();
            RchAddress.Text = dr["Adress"].ToString();
            TxtVergi.Text = dr["Vergidaire"].ToString();
        }
        
    }
}
