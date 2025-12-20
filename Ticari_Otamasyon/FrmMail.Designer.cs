namespace Ticari_Otamasyon
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            label1 = new System.Windows.Forms.Label();
            TxtMailAddress = new DevExpress.XtraEditors.TextEdit();
            TxtKonu = new DevExpress.XtraEditors.TextEdit();
            label2 = new System.Windows.Forms.Label();
            TxtMesaj = new System.Windows.Forms.RichTextBox();
            label3 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            BtnGonder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)TxtMailAddress.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtKonu.Properties).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(42, 223);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 23);
            label1.TabIndex = 0;
            label1.Text = "Mail addresi:";
            // 
            // TxtMailAddress
            // 
            TxtMailAddress.Location = new System.Drawing.Point(176, 226);
            TxtMailAddress.Name = "TxtMailAddress";
            TxtMailAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtMailAddress.Properties.Appearance.Options.UseFont = true;
            TxtMailAddress.Size = new System.Drawing.Size(235, 26);
            TxtMailAddress.TabIndex = 1;
            // 
            // TxtKonu
            // 
            TxtKonu.Location = new System.Drawing.Point(176, 267);
            TxtKonu.Name = "TxtKonu";
            TxtKonu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtKonu.Properties.Appearance.Options.UseFont = true;
            TxtKonu.Size = new System.Drawing.Size(235, 26);
            TxtKonu.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(42, 264);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 23);
            label2.TabIndex = 2;
            label2.Text = "Konu:";
            // 
            // TxtMesaj
            // 
            TxtMesaj.Location = new System.Drawing.Point(176, 312);
            TxtMesaj.Name = "TxtMesaj";
            TxtMesaj.Size = new System.Drawing.Size(235, 105);
            TxtMesaj.TabIndex = 4;
            TxtMesaj.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(42, 312);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 23);
            label3.TabIndex = 5;
            label3.Text = "Mesaj:";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label4);
            panel1.Controls.Add(BtnGonder);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TxtMailAddress);
            panel1.Controls.Add(TxtMesaj);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtKonu);
            panel1.Location = new System.Drawing.Point(-2, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(467, 676);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label4.Location = new System.Drawing.Point(85, 64);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(307, 33);
            label4.TabIndex = 8;
            label4.Text = "Mail gonderme paneli";
            // 
            // BtnGonder
            // 
            BtnGonder.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BtnGonder.Appearance.Options.UseFont = true;
            BtnGonder.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("BtnGonder.ImageOptions.Image");
            BtnGonder.Location = new System.Drawing.Point(176, 423);
            BtnGonder.Name = "BtnGonder";
            BtnGonder.Size = new System.Drawing.Size(105, 37);
            BtnGonder.TabIndex = 7;
            BtnGonder.Text = "Gonder";
            BtnGonder.Click += BtnGonder_Click;
            // 
            // FrmMail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(461, 687);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "FrmMail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "FrmMail";
            Load += FrmMail_Load;
            ((System.ComponentModel.ISupportInitialize)TxtMailAddress.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtKonu.Properties).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TxtMailAddress;
        private DevExpress.XtraEditors.TextEdit TxtKonu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TxtMesaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton BtnGonder;
        private System.Windows.Forms.Label label4;
    }
}