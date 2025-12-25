namespace Ticari_Otamasyon
{
    partial class FrmNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotlar));
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            MskSaat = new System.Windows.Forms.MaskedTextBox();
            MskTarih = new System.Windows.Forms.MaskedTextBox();
            TxtBaslik = new DevExpress.XtraEditors.TextEdit();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            BtnSil = new DevExpress.XtraEditors.SimpleButton();
            BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            RchDetay = new System.Windows.Forms.RichTextBox();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            TxtHitap = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            TxtOlusturan = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            TxtId = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtBaslik.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtHitap.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtOlusturan.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtId.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridView1
            // 
            gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(128, 128, 255);
            gridView1.Appearance.Row.Options.UseBackColor = true;
            gridView1.Appearance.Row.Options.UseBorderColor = true;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            gridView1.DoubleClick += gridView1_DoubleClick;
            // 
            // gridControl1
            // 
            gridControl1.Location = new System.Drawing.Point(12, 12);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1433, 609);
            gridControl1.TabIndex = 4;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // MskSaat
            // 
            MskSaat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MskSaat.Location = new System.Drawing.Point(71, 98);
            MskSaat.Mask = "00:00";
            MskSaat.Name = "MskSaat";
            MskSaat.Size = new System.Drawing.Size(147, 26);
            MskSaat.TabIndex = 26;
            MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MskTarih
            // 
            MskTarih.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MskTarih.Location = new System.Drawing.Point(71, 68);
            MskTarih.Mask = "00/00/0000";
            MskTarih.Name = "MskTarih";
            MskTarih.Size = new System.Drawing.Size(147, 26);
            MskTarih.TabIndex = 25;
            MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // TxtBaslik
            // 
            TxtBaslik.Location = new System.Drawing.Point(71, 130);
            TxtBaslik.Name = "TxtBaslik";
            TxtBaslik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtBaslik.Properties.Appearance.Options.UseFont = true;
            TxtBaslik.Size = new System.Drawing.Size(178, 24);
            TxtBaslik.TabIndex = 24;
            // 
            // labelControl10
            // 
            labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl10.Appearance.Options.UseFont = true;
            labelControl10.Location = new System.Drawing.Point(5, 231);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new System.Drawing.Size(44, 18);
            labelControl10.TabIndex = 22;
            labelControl10.Text = "Detay:";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(BtnTemizle);
            groupControl1.Controls.Add(MskSaat);
            groupControl1.Controls.Add(MskTarih);
            groupControl1.Controls.Add(TxtBaslik);
            groupControl1.Controls.Add(labelControl10);
            groupControl1.Controls.Add(BtnGuncelle);
            groupControl1.Controls.Add(BtnSil);
            groupControl1.Controls.Add(BtnKaydet);
            groupControl1.Controls.Add(RchDetay);
            groupControl1.Controls.Add(labelControl9);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(TxtHitap);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(TxtOlusturan);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(TxtId);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Location = new System.Drawing.Point(1472, 12);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(331, 609);
            groupControl1.TabIndex = 5;
            // 
            // BtnTemizle
            // 
            BtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BtnTemizle.Appearance.Options.UseFont = true;
            BtnTemizle.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("BtnTemizle.ImageOptions.Image");
            BtnTemizle.Location = new System.Drawing.Point(71, 500);
            BtnTemizle.Name = "BtnTemizle";
            BtnTemizle.Size = new System.Drawing.Size(147, 36);
            BtnTemizle.TabIndex = 27;
            BtnTemizle.Text = "Temizle";
            BtnTemizle.Click += BtnTemizle_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BtnGuncelle.Appearance.Options.UseFont = true;
            BtnGuncelle.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("BtnGuncelle.ImageOptions.Image");
            BtnGuncelle.Location = new System.Drawing.Point(71, 458);
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
            BtnSil.Location = new System.Drawing.Point(71, 416);
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
            BtnKaydet.Location = new System.Drawing.Point(71, 374);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new System.Drawing.Size(147, 36);
            BtnKaydet.TabIndex = 19;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // RchDetay
            // 
            RchDetay.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RchDetay.Location = new System.Drawing.Point(71, 220);
            RchDetay.Name = "RchDetay";
            RchDetay.Size = new System.Drawing.Size(178, 102);
            RchDetay.TabIndex = 18;
            RchDetay.Text = "";
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.Location = new System.Drawing.Point(5, 196);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new System.Drawing.Size(38, 18);
            labelControl9.TabIndex = 17;
            labelControl9.Text = "Hitap:";
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new System.Drawing.Point(5, 166);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new System.Drawing.Size(67, 18);
            labelControl8.TabIndex = 16;
            labelControl8.Text = "Olusturan:";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new System.Drawing.Point(5, 131);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(40, 18);
            labelControl4.TabIndex = 7;
            labelControl4.Text = "Baslik:";
            // 
            // TxtHitap
            // 
            TxtHitap.Location = new System.Drawing.Point(71, 190);
            TxtHitap.Name = "TxtHitap";
            TxtHitap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtHitap.Properties.Appearance.Options.UseFont = true;
            TxtHitap.Size = new System.Drawing.Size(178, 24);
            TxtHitap.TabIndex = 6;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new System.Drawing.Point(5, 101);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(34, 18);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "Saat:";
            // 
            // TxtOlusturan
            // 
            TxtOlusturan.Location = new System.Drawing.Point(71, 160);
            TxtOlusturan.Name = "TxtOlusturan";
            TxtOlusturan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtOlusturan.Properties.Appearance.Options.UseFont = true;
            TxtOlusturan.Size = new System.Drawing.Size(178, 24);
            TxtOlusturan.TabIndex = 4;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new System.Drawing.Point(5, 71);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(38, 18);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "Tarih:";
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
            labelControl1.Location = new System.Drawing.Point(5, 41);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(21, 18);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "ID:";
            // 
            // FrmNotlar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1924, 1061);
            Controls.Add(groupControl1);
            Controls.Add(gridControl1);
            Name = "FrmNotlar";
            Text = "Notlar";
            Load += FrmNotlar_Load;
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtBaslik.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtHitap.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtOlusturan.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtId.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private DevExpress.XtraEditors.TextEdit TxtBaslik;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox RchDetay;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtHitap;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtOlusturan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
    }
}