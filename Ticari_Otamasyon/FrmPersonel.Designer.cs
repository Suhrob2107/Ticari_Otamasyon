namespace Ticari_Otamasyon
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            TxtGorev = new DevExpress.XtraEditors.TextEdit();
            labelControl11 = new DevExpress.XtraEditors.LabelControl();
            CmbILCE = new DevExpress.XtraEditors.ComboBoxEdit();
            CmbIL = new DevExpress.XtraEditors.ComboBoxEdit();
            MskTelefon1 = new System.Windows.Forms.MaskedTextBox();
            TxtMail = new DevExpress.XtraEditors.TextEdit();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            BtnSil = new DevExpress.XtraEditors.SimpleButton();
            BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            RchAddress = new System.Windows.Forms.RichTextBox();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            TxtSoyad = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            TxtAd = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            MskTc = new System.Windows.Forms.MaskedTextBox();
            TxtId = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtGorev.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CmbILCE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CmbIL.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtMail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtSoyad.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtId.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridView1
            // 
            gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(128, 255, 128);
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
            // TxtGorev
            // 
            TxtGorev.Location = new System.Drawing.Point(71, 294);
            TxtGorev.Name = "TxtGorev";
            TxtGorev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtGorev.Properties.Appearance.Options.UseFont = true;
            TxtGorev.Size = new System.Drawing.Size(178, 24);
            TxtGorev.TabIndex = 30;
            // 
            // labelControl11
            // 
            labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl11.Appearance.Options.UseFont = true;
            labelControl11.Location = new System.Drawing.Point(5, 300);
            labelControl11.Name = "labelControl11";
            labelControl11.Size = new System.Drawing.Size(44, 18);
            labelControl11.TabIndex = 29;
            labelControl11.Text = "Gorev:";
            // 
            // CmbILCE
            // 
            CmbILCE.Location = new System.Drawing.Point(71, 264);
            CmbILCE.Name = "CmbILCE";
            CmbILCE.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            CmbILCE.Properties.Appearance.Options.UseFont = true;
            CmbILCE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            CmbILCE.Size = new System.Drawing.Size(178, 24);
            CmbILCE.TabIndex = 28;
            // 
            // CmbIL
            // 
            CmbIL.Location = new System.Drawing.Point(71, 234);
            CmbIL.Name = "CmbIL";
            CmbIL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            CmbIL.Properties.Appearance.Options.UseFont = true;
            CmbIL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            CmbIL.Size = new System.Drawing.Size(178, 24);
            CmbIL.TabIndex = 27;
            CmbIL.SelectedIndexChanged += CmbIL_SelectedIndexChanged;
            // 
            // MskTelefon1
            // 
            MskTelefon1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MskTelefon1.Location = new System.Drawing.Point(71, 131);
            MskTelefon1.Mask = "(999) 000-0000";
            MskTelefon1.Name = "MskTelefon1";
            MskTelefon1.Size = new System.Drawing.Size(147, 26);
            MskTelefon1.TabIndex = 25;
            // 
            // TxtMail
            // 
            TxtMail.Location = new System.Drawing.Point(71, 200);
            TxtMail.Name = "TxtMail";
            TxtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtMail.Properties.Appearance.Options.UseFont = true;
            TxtMail.Size = new System.Drawing.Size(178, 24);
            TxtMail.TabIndex = 24;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(BtnTemizle);
            groupControl1.Controls.Add(TxtGorev);
            groupControl1.Controls.Add(labelControl11);
            groupControl1.Controls.Add(CmbILCE);
            groupControl1.Controls.Add(CmbIL);
            groupControl1.Controls.Add(MskTelefon1);
            groupControl1.Controls.Add(TxtMail);
            groupControl1.Controls.Add(BtnGuncelle);
            groupControl1.Controls.Add(BtnSil);
            groupControl1.Controls.Add(BtnKaydet);
            groupControl1.Controls.Add(RchAddress);
            groupControl1.Controls.Add(labelControl9);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(labelControl7);
            groupControl1.Controls.Add(labelControl6);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(TxtSoyad);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(TxtAd);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(MskTc);
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
            BtnTemizle.Location = new System.Drawing.Point(71, 563);
            BtnTemizle.Name = "BtnTemizle";
            BtnTemizle.Size = new System.Drawing.Size(147, 36);
            BtnTemizle.TabIndex = 31;
            BtnTemizle.Text = "Temizle";
            BtnTemizle.Click += BtnTemizle_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BtnGuncelle.Appearance.Options.UseFont = true;
            BtnGuncelle.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("BtnGuncelle.ImageOptions.Image");
            BtnGuncelle.Location = new System.Drawing.Point(71, 521);
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
            BtnSil.Location = new System.Drawing.Point(71, 479);
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
            BtnKaydet.Location = new System.Drawing.Point(71, 437);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new System.Drawing.Size(147, 36);
            BtnKaydet.TabIndex = 19;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // RchAddress
            // 
            RchAddress.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RchAddress.Location = new System.Drawing.Point(71, 324);
            RchAddress.Name = "RchAddress";
            RchAddress.Size = new System.Drawing.Size(178, 102);
            RchAddress.TabIndex = 18;
            RchAddress.Text = "";
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.Location = new System.Drawing.Point(5, 158);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new System.Drawing.Size(24, 18);
            labelControl9.TabIndex = 17;
            labelControl9.Text = "TC:";
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new System.Drawing.Point(5, 203);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new System.Drawing.Size(29, 18);
            labelControl8.TabIndex = 16;
            labelControl8.Text = "Mail:";
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new System.Drawing.Point(5, 327);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new System.Drawing.Size(57, 18);
            labelControl7.TabIndex = 14;
            labelControl7.Text = "Address:";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new System.Drawing.Point(5, 267);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(35, 18);
            labelControl6.TabIndex = 12;
            labelControl6.Text = "ILCE:";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new System.Drawing.Point(5, 227);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(18, 18);
            labelControl5.TabIndex = 10;
            labelControl5.Text = "IL:";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new System.Drawing.Point(5, 131);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(62, 18);
            labelControl4.TabIndex = 7;
            labelControl4.Text = "Telefon1:";
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new System.Drawing.Point(71, 98);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtSoyad.Properties.Appearance.Options.UseFont = true;
            TxtSoyad.Size = new System.Drawing.Size(178, 24);
            TxtSoyad.TabIndex = 6;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new System.Drawing.Point(5, 101);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(45, 18);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "Soyad:";
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
            labelControl2.Location = new System.Drawing.Point(5, 71);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(24, 18);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "AD:";
            // 
            // MskTc
            // 
            MskTc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MskTc.Location = new System.Drawing.Point(71, 164);
            MskTc.Mask = "00000000000";
            MskTc.Name = "MskTc";
            MskTc.Size = new System.Drawing.Size(147, 26);
            MskTc.TabIndex = 2;
            MskTc.ValidatingType = typeof(int);
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
            // FrmPersonel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1924, 1061);
            Controls.Add(groupControl1);
            Controls.Add(gridControl1);
            Name = "FrmPersonel";
            Text = "Personeller";
            Load += FrmPersonel_Load;
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtGorev.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CmbILCE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CmbIL.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtMail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtSoyad.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtId.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.TextEdit TxtGorev;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.ComboBoxEdit CmbILCE;
        private DevExpress.XtraEditors.ComboBoxEdit CmbIL;
        private System.Windows.Forms.MaskedTextBox MskTelefon1;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox RchAddress;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
    }
}