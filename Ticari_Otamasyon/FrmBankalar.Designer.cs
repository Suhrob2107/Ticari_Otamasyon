namespace Ticari_Otamasyon
{
    partial class FrmBankalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankalar));
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            labelControl11 = new DevExpress.XtraEditors.LabelControl();
            CmbILCE = new DevExpress.XtraEditors.ComboBoxEdit();
            CmbIL = new DevExpress.XtraEditors.ComboBoxEdit();
            MskTelefon = new System.Windows.Forms.MaskedTextBox();
            TxtIban = new System.Windows.Forms.MaskedTextBox();
            TxtSube = new DevExpress.XtraEditors.TextEdit();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            lookFirma = new DevExpress.XtraEditors.LookUpEdit();
            MskTarih = new System.Windows.Forms.MaskedTextBox();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            labelControl13 = new DevExpress.XtraEditors.LabelControl();
            TxtHesapturu = new DevExpress.XtraEditors.TextEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            TxtHesapNo = new System.Windows.Forms.MaskedTextBox();
            labelControl12 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            TxtYetkili = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            BtnSil = new DevExpress.XtraEditors.SimpleButton();
            BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            TxtBankaAd = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            TxtId = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CmbILCE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CmbIL.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtSube.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lookFirma.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtHesapturu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtYetkili.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtBankaAd.Properties).BeginInit();
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
            // labelControl11
            // 
            labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl11.Appearance.Options.UseFont = true;
            labelControl11.Location = new System.Drawing.Point(5, 324);
            labelControl11.Name = "labelControl11";
            labelControl11.Size = new System.Drawing.Size(38, 18);
            labelControl11.TabIndex = 29;
            labelControl11.Text = "Tarih:";
            // 
            // CmbILCE
            // 
            CmbILCE.Location = new System.Drawing.Point(71, 131);
            CmbILCE.Name = "CmbILCE";
            CmbILCE.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            CmbILCE.Properties.Appearance.Options.UseFont = true;
            CmbILCE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            CmbILCE.Size = new System.Drawing.Size(178, 24);
            CmbILCE.TabIndex = 28;
            // 
            // CmbIL
            // 
            CmbIL.Location = new System.Drawing.Point(71, 101);
            CmbIL.Name = "CmbIL";
            CmbIL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            CmbIL.Properties.Appearance.Options.UseFont = true;
            CmbIL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            CmbIL.Size = new System.Drawing.Size(178, 24);
            CmbIL.TabIndex = 27;
            CmbIL.SelectedIndexChanged += CmbIL_SelectedIndexChanged;
            // 
            // MskTelefon
            // 
            MskTelefon.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MskTelefon.Location = new System.Drawing.Point(71, 289);
            MskTelefon.Mask = "(999) 000-0000";
            MskTelefon.Name = "MskTelefon";
            MskTelefon.Size = new System.Drawing.Size(147, 26);
            MskTelefon.TabIndex = 26;
            // 
            // TxtIban
            // 
            TxtIban.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtIban.Location = new System.Drawing.Point(71, 191);
            TxtIban.Name = "TxtIban";
            TxtIban.Size = new System.Drawing.Size(147, 26);
            TxtIban.TabIndex = 25;
            TxtIban.ValidatingType = typeof(int);
            // 
            // TxtSube
            // 
            TxtSube.Location = new System.Drawing.Point(71, 161);
            TxtSube.Name = "TxtSube";
            TxtSube.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtSube.Properties.Appearance.Options.UseFont = true;
            TxtSube.Size = new System.Drawing.Size(178, 24);
            TxtSube.TabIndex = 24;
            // 
            // labelControl10
            // 
            labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl10.Appearance.Options.UseFont = true;
            labelControl10.Location = new System.Drawing.Point(5, 287);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new System.Drawing.Size(54, 18);
            labelControl10.TabIndex = 22;
            labelControl10.Text = "Telefon:";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(lookFirma);
            groupControl1.Controls.Add(MskTarih);
            groupControl1.Controls.Add(simpleButton1);
            groupControl1.Controls.Add(labelControl13);
            groupControl1.Controls.Add(TxtHesapturu);
            groupControl1.Controls.Add(labelControl7);
            groupControl1.Controls.Add(TxtHesapNo);
            groupControl1.Controls.Add(labelControl12);
            groupControl1.Controls.Add(MskTelefon);
            groupControl1.Controls.Add(labelControl10);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(labelControl11);
            groupControl1.Controls.Add(TxtYetkili);
            groupControl1.Controls.Add(TxtIban);
            groupControl1.Controls.Add(CmbILCE);
            groupControl1.Controls.Add(CmbIL);
            groupControl1.Controls.Add(TxtSube);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(BtnGuncelle);
            groupControl1.Controls.Add(BtnSil);
            groupControl1.Controls.Add(BtnKaydet);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(labelControl6);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(TxtBankaAd);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(TxtId);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Location = new System.Drawing.Point(1472, 12);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(331, 609);
            groupControl1.TabIndex = 5;
            // 
            // lookFirma
            // 
            lookFirma.Location = new System.Drawing.Point(71, 385);
            lookFirma.Name = "lookFirma";
            lookFirma.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lookFirma.Properties.Appearance.Options.UseFont = true;
            lookFirma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookFirma.Properties.NullText = "Bir firma seciniz";
            lookFirma.Size = new System.Drawing.Size(178, 24);
            lookFirma.TabIndex = 39;
            // 
            // MskTarih
            // 
            MskTarih.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MskTarih.Location = new System.Drawing.Point(71, 321);
            MskTarih.Mask = "00/00/0000";
            MskTarih.Name = "MskTarih";
            MskTarih.Size = new System.Drawing.Size(147, 26);
            MskTarih.TabIndex = 38;
            MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new System.Drawing.Point(71, 545);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(147, 36);
            simpleButton1.TabIndex = 37;
            simpleButton1.Text = "Temizle";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // labelControl13
            // 
            labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl13.Appearance.Options.UseFont = true;
            labelControl13.Location = new System.Drawing.Point(5, 384);
            labelControl13.Name = "labelControl13";
            labelControl13.Size = new System.Drawing.Size(41, 18);
            labelControl13.TabIndex = 35;
            labelControl13.Text = "Firma:";
            // 
            // TxtHesapturu
            // 
            TxtHesapturu.Location = new System.Drawing.Point(71, 351);
            TxtHesapturu.Name = "TxtHesapturu";
            TxtHesapturu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtHesapturu.Properties.Appearance.Options.UseFont = true;
            TxtHesapturu.Size = new System.Drawing.Size(178, 24);
            TxtHesapturu.TabIndex = 34;
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new System.Drawing.Point(5, 354);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new System.Drawing.Size(51, 18);
            labelControl7.TabIndex = 33;
            labelControl7.Text = "Hesap :";
            // 
            // TxtHesapNo
            // 
            TxtHesapNo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtHesapNo.Location = new System.Drawing.Point(71, 223);
            TxtHesapNo.Name = "TxtHesapNo";
            TxtHesapNo.Size = new System.Drawing.Size(147, 26);
            TxtHesapNo.TabIndex = 32;
            TxtHesapNo.ValidatingType = typeof(int);
            // 
            // labelControl12
            // 
            labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl12.Appearance.Options.UseFont = true;
            labelControl12.Location = new System.Drawing.Point(5, 223);
            labelControl12.Name = "labelControl12";
            labelControl12.Size = new System.Drawing.Size(67, 18);
            labelControl12.TabIndex = 31;
            labelControl12.Text = "Hesap no:";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new System.Drawing.Point(5, 258);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(41, 18);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "Yetkili:";
            // 
            // TxtYetkili
            // 
            TxtYetkili.Location = new System.Drawing.Point(71, 255);
            TxtYetkili.Name = "TxtYetkili";
            TxtYetkili.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtYetkili.Properties.Appearance.Options.UseFont = true;
            TxtYetkili.Size = new System.Drawing.Size(178, 24);
            TxtYetkili.TabIndex = 6;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new System.Drawing.Point(5, 191);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(35, 18);
            labelControl4.TabIndex = 7;
            labelControl4.Text = "Iban:";
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BtnGuncelle.Appearance.Options.UseFont = true;
            BtnGuncelle.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("BtnGuncelle.ImageOptions.Image");
            BtnGuncelle.Location = new System.Drawing.Point(71, 503);
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
            BtnSil.Location = new System.Drawing.Point(71, 461);
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
            BtnKaydet.Location = new System.Drawing.Point(71, 419);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new System.Drawing.Size(147, 36);
            BtnKaydet.TabIndex = 19;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new System.Drawing.Point(5, 164);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new System.Drawing.Size(37, 18);
            labelControl8.TabIndex = 16;
            labelControl8.Text = "Sube:";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new System.Drawing.Point(5, 134);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(35, 18);
            labelControl6.TabIndex = 12;
            labelControl6.Text = "ILCE:";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new System.Drawing.Point(5, 94);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(18, 18);
            labelControl5.TabIndex = 10;
            labelControl5.Text = "IL:";
            // 
            // TxtBankaAd
            // 
            TxtBankaAd.Location = new System.Drawing.Point(71, 68);
            TxtBankaAd.Name = "TxtBankaAd";
            TxtBankaAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtBankaAd.Properties.Appearance.Options.UseFont = true;
            TxtBankaAd.Size = new System.Drawing.Size(178, 24);
            TxtBankaAd.TabIndex = 4;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new System.Drawing.Point(5, 71);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(66, 18);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "Banka ad:";
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
            // FrmBankalar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1924, 1061);
            Controls.Add(groupControl1);
            Controls.Add(gridControl1);
            Name = "FrmBankalar";
            Text = "Bankalar";
            Load += FrmBankalar_Load;
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CmbILCE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CmbIL.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtSube.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lookFirma.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtHesapturu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtYetkili.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtBankaAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtId.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.ComboBoxEdit CmbILCE;
        private DevExpress.XtraEditors.ComboBoxEdit CmbIL;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.MaskedTextBox TxtIban;
        private DevExpress.XtraEditors.TextEdit TxtSube;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtYetkili;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtBankaAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit TxtHesapturu;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.MaskedTextBox TxtHesapNo;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private DevExpress.XtraEditors.LookUpEdit lookFirma;
    }
}