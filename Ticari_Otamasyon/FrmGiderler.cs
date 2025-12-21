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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Giderler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            TxtId.Text = "";
            CmbAy.Text = "";
            CmbYil.Text = "";
            TxtElektik.Text = "";
            TxtSu.Text = "";
            TxtDogalgaz.Text = "";
            TxtInternet.Text = "";
            TxtMaas.Text = "";
            TxtExtra.Text = "";
            RchNot.Text = "";
        }
        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Giderler (Ay,Yil,Electric,Su,Dogalgaz,Internet,Maaslar,Ekstra,Notlar) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbAy.Text);
            komut.Parameters.AddWithValue("@p2", CmbYil.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtElektik.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(TxtSu.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtDogalgaz.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtInternet.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtMaas.Text));
            komut.Parameters.AddWithValue("@p8", TxtExtra.Text);
            komut.Parameters.AddWithValue("@p9", RchNot.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Giderler Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                CmbAy.Text = dr["Ay"].ToString();
                CmbYil.Text = dr["Yil"].ToString();
                TxtElektik.Text = dr["Electric"].ToString();
                TxtSu.Text = dr["Su"].ToString();
                TxtDogalgaz.Text = dr["Dogalgaz"].ToString();
                TxtInternet.Text = dr["Internet"].ToString();
                TxtMaas.Text = dr["Maaslar"].ToString();
                TxtExtra.Text = dr["Ekstra"].ToString();
                RchNot.Text = dr["Notlar"].ToString();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Giderler where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Giderler set Ay=@p1,Yil=@p2,Electric=@p3,Su=@p4,Dogalgaz=@p5,Internet=@p6,Maaslar=@p7,Ekstra=@p8,Notlar=@p9 where ID=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbAy.Text);
            komut.Parameters.AddWithValue("@p2", CmbYil.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtElektik.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtSu.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(TxtDogalgaz.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtInternet.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtMaas.Text));
            komut.Parameters.AddWithValue("@p8", TxtExtra.Text);
            komut.Parameters.AddWithValue("@p9", RchNot.Text);
            komut.Parameters.AddWithValue("@p10", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }
    }
}
