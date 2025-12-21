using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ticari_Otamasyon
{
    public partial class FrmAnaModul : DevExpress.XtraEditors.XtraForm
    {
        public FrmAnaModul()
        {
            InitializeComponent();

        }
        FrmUrunler fr;
        private void BtnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new FrmUrunler();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        FrmMusteriler mus;
        private void BtnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mus == null || mus.IsDisposed)
            {
                mus = new FrmMusteriler();
                mus.MdiParent = this;
                mus.Show();
            }
        }
        FrmFirmalar frm;
        private void BtnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new FrmFirmalar();
                frm.MdiParent = this;
                frm.Show();
            }
        }
        FrmPersonel personel;
        private void BtnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personel == null || personel.IsDisposed)
            {
                personel = new FrmPersonel();
                personel.MdiParent = this;
                personel.Show();
            }
        }
        FrmRehber rehber;
        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rehber == null || rehber.IsDisposed)
            {
                rehber = new FrmRehber();
                rehber.MdiParent = this;
                rehber.Show();
            }
        }
        FrmGiderler giderler;
        private void BtnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(giderler == null || giderler.IsDisposed)
            {
                giderler = new FrmGiderler();
                giderler.MdiParent = this;
                giderler.Show();
            }
        }
    }
}
