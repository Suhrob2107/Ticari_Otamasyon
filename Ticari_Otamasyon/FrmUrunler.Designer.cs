namespace Ticari_Otamasyon
{
    partial class FrmUrunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            BtnSil = new DevExpress.XtraEditors.SimpleButton();
            BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            RchDetay = new System.Windows.Forms.RichTextBox();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            TxtSatis = new DevExpress.XtraEditors.TextEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            TxtAlis = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            NudAdet = new System.Windows.Forms.NumericUpDown();
            TxtModel = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            TxtMarka = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            TxtAd = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            MskYil = new System.Windows.Forms.MaskedTextBox();
            TxtId = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtSatis.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtAlis.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtModel.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtMarka.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtId.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new System.Drawing.Point(5, 12);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1433, 609);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            gridView1.Appearance.Row.BorderColor = System.Drawing.Color.Lime;
            gridView1.Appearance.Row.Options.UseBackColor = true;
            gridView1.Appearance.Row.Options.UseBorderColor = true;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(BtnGuncelle);
            groupControl1.Controls.Add(BtnSil);
            groupControl1.Controls.Add(BtnKaydet);
            groupControl1.Controls.Add(RchDetay);
            groupControl1.Controls.Add(labelControl9);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(labelControl7);
            groupControl1.Controls.Add(TxtSatis);
            groupControl1.Controls.Add(labelControl6);
            groupControl1.Controls.Add(TxtAlis);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(NudAdet);
            groupControl1.Controls.Add(TxtModel);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(TxtMarka);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(TxtAd);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(MskYil);
            groupControl1.Controls.Add(TxtId);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Location = new System.Drawing.Point(1474, 12);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(331, 609);
            groupControl1.TabIndex = 1;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BtnGuncelle.Appearance.Options.UseFont = true;
            BtnGuncelle.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("BtnGuncelle.ImageOptions.Image");
            BtnGuncelle.Location = new System.Drawing.Point(71, 480);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new System.Drawing.Size(147, 36);
            BtnGuncelle.TabIndex = 21;
            BtnGuncelle.Text = "Guncelle";
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // BtnSil
            // 
            BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BtnSil.Appearance.Options.UseFont = true;
            BtnSil.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("BtnSil.ImageOptions.Image");
            BtnSil.Location = new System.Drawing.Point(71, 438);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new System.Drawing.Size(147, 36);
            BtnSil.TabIndex = 20;
            BtnSil.Text = "Sil";
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnKaydet
            // 
            BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BtnKaydet.Appearance.Options.UseFont = true;
            BtnKaydet.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("BtnKaydet.ImageOptions.Image");
            BtnKaydet.Location = new System.Drawing.Point(71, 396);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new System.Drawing.Size(147, 36);
            BtnKaydet.TabIndex = 19;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // RchDetay
            // 
            RchDetay.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RchDetay.Location = new System.Drawing.Point(71, 288);
            RchDetay.Name = "RchDetay";
            RchDetay.Size = new System.Drawing.Size(178, 102);
            RchDetay.TabIndex = 18;
            RchDetay.Text = "";
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.Location = new System.Drawing.Point(20, 155);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new System.Drawing.Size(19, 18);
            labelControl9.TabIndex = 17;
            labelControl9.Text = "Yil:";
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new System.Drawing.Point(20, 194);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new System.Drawing.Size(35, 18);
            labelControl8.TabIndex = 16;
            labelControl8.Text = "Adet:";
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new System.Drawing.Point(20, 287);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new System.Drawing.Size(44, 18);
            labelControl7.TabIndex = 14;
            labelControl7.Text = "Detay:";
            // 
            // TxtSatis
            // 
            TxtSatis.Location = new System.Drawing.Point(71, 254);
            TxtSatis.Name = "TxtSatis";
            TxtSatis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtSatis.Properties.Appearance.Options.UseFont = true;
            TxtSatis.Size = new System.Drawing.Size(178, 24);
            TxtSatis.TabIndex = 13;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new System.Drawing.Point(20, 257);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(48, 18);
            labelControl6.TabIndex = 12;
            labelControl6.Text = "Satis F:";
            // 
            // TxtAlis
            // 
            TxtAlis.Location = new System.Drawing.Point(71, 224);
            TxtAlis.Name = "TxtAlis";
            TxtAlis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtAlis.Properties.Appearance.Options.UseFont = true;
            TxtAlis.Size = new System.Drawing.Size(178, 24);
            TxtAlis.TabIndex = 11;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new System.Drawing.Point(20, 227);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(38, 18);
            labelControl5.TabIndex = 10;
            labelControl5.Text = "Alis F:";
            // 
            // NudAdet
            // 
            NudAdet.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            NudAdet.Location = new System.Drawing.Point(71, 192);
            NudAdet.Name = "NudAdet";
            NudAdet.Size = new System.Drawing.Size(167, 26);
            NudAdet.TabIndex = 9;
            // 
            // TxtModel
            // 
            TxtModel.Location = new System.Drawing.Point(71, 128);
            TxtModel.Name = "TxtModel";
            TxtModel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtModel.Properties.Appearance.Options.UseFont = true;
            TxtModel.Size = new System.Drawing.Size(178, 24);
            TxtModel.TabIndex = 8;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new System.Drawing.Point(20, 131);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(43, 18);
            labelControl4.TabIndex = 7;
            labelControl4.Text = "Model:";
            // 
            // TxtMarka
            // 
            TxtMarka.Location = new System.Drawing.Point(71, 98);
            TxtMarka.Name = "TxtMarka";
            TxtMarka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtMarka.Properties.Appearance.Options.UseFont = true;
            TxtMarka.Size = new System.Drawing.Size(178, 24);
            TxtMarka.TabIndex = 6;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new System.Drawing.Point(20, 101);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(45, 18);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "Marka:";
            // 
            // TxtAd
            // 
            TxtAd.Location = new System.Drawing.Point(71, 68);
            TxtAd.Name = "TxtAd";
            TxtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtAd.Properties.Appearance.Options.UseFont = true;
            TxtAd.Size = new System.Drawing.Size(178, 24);
            TxtAd.TabIndex = 4;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new System.Drawing.Point(20, 71);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(24, 18);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "AD:";
            // 
            // MskYil
            // 
            MskYil.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MskYil.Location = new System.Drawing.Point(71, 158);
            MskYil.Mask = "0000";
            MskYil.Name = "MskYil";
            MskYil.Size = new System.Drawing.Size(147, 26);
            MskYil.TabIndex = 2;
            MskYil.ValidatingType = typeof(int);
            // 
            // TxtId
            // 
            TxtId.Location = new System.Drawing.Point(71, 38);
            TxtId.Name = "TxtId";
            TxtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtId.Properties.Appearance.Options.UseFont = true;
            TxtId.Size = new System.Drawing.Size(178, 24);
            TxtId.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new System.Drawing.Point(20, 41);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(21, 18);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "ID:";
            // 
            // FrmUrunler
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1924, 1061);
            Controls.Add(groupControl1);
            Controls.Add(gridControl1);
            Name = "FrmUrunler";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "URUNLER";
            Load += FrmUrunler_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtSatis.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtAlis.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtModel.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtMarka.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtId.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtModel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtMarka;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox MskYil;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TxtSatis;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtAlis;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.NumericUpDown NudAdet;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.RichTextBox RchDetay;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
    }
}