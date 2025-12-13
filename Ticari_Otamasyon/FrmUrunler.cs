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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Urunler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Urunler (Urunad,Marka,Model,Yil,Adet,Alisfiyat,Satisfiyat,Detay) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@p3", TxtModel.Text);
            komut.Parameters.AddWithValue("@p4", MskYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse(NudAdet.Value.ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtAlis.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtSatis.Text));
            komut.Parameters.AddWithValue("@p8", RchDetay.Text);
            komut.ExecuteNonQuery(); // ExecuteNonQuery komutu ile veritabanında değişiklik yapar.
            bgl.baglanti().Close(); // Bağlantıyı kapatır.
            MessageBox.Show("Ürün Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); // Kullanıcıya bilgi verir.
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from Tbl_Urunler where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", TxtId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtId.Text = dr["ID"].ToString();
            TxtAd.Text = dr["Urunad"].ToString();
            TxtMarka.Text = dr["Marka"].ToString();
            TxtModel.Text = dr["Model"].ToString();
            MskYil.Text = dr["Yil"].ToString();
            NudAdet.Value = decimal.Parse(dr["Adet"].ToString());
            TxtAlis.Text = dr["Alisfiyat"].ToString();
            TxtSatis.Text = dr["Satisfiyat"].ToString();
            RchDetay.Text = dr["Detay"].ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("update Tbl_Urunler set Urunad=@p1,Marka=@p2,Model=@p3,Yil=@p4,Adet=@p5,Alisfiyat=@p6,Satisfiyat=@p7,Detay=@p8 where ID=@p9", bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", TxtAd.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TxtMarka.Text);
            sqlCommand.Parameters.AddWithValue("@p3", TxtModel.Text);
            sqlCommand.Parameters.AddWithValue("@p4", MskYil.Text);
            sqlCommand.Parameters.AddWithValue("@p5", int.Parse(NudAdet.Value.ToString()));
            sqlCommand.Parameters.AddWithValue("@p6", decimal.Parse(TxtAlis.Text));
            sqlCommand.Parameters.AddWithValue("@p7", decimal.Parse(TxtSatis.Text));
            sqlCommand.Parameters.AddWithValue("@p8", RchDetay.Text);
            sqlCommand.Parameters.AddWithValue("@p9", TxtId.Text);
            sqlCommand.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
