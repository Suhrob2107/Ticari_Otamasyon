namespace Ticari_Otamasyon
{
    partial class FrmRehber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRehber));
            xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            gridControl2 = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).BeginInit();
            xtraTabControl1.SuspendLayout();
            xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            SuspendLayout();
            // 
            // xtraTabControl1
            // 
            xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            xtraTabControl1.Name = "xtraTabControl1";
            xtraTabControl1.SelectedTabPage = xtraTabPage1;
            xtraTabControl1.Size = new System.Drawing.Size(1924, 1061);
            xtraTabControl1.TabIndex = 0;
            xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(gridControl1);
            xtraTabPage1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("xtraTabPage1.ImageOptions.Image");
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new System.Drawing.Size(1922, 1017);
            xtraTabPage1.Text = "Musteriler";
            // 
            // gridControl1
            // 
            gridControl1.Location = new System.Drawing.Point(3, 3);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1920, 795);
            gridControl1.TabIndex = 5;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(128, 255, 128);
            gridView1.Appearance.Row.Options.UseBackColor = true;
            gridView1.Appearance.Row.Options.UseBorderColor = true;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.DoubleClick += gridView1_DoubleClick;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(gridControl2);
            xtraTabPage2.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("xtraTabPage2.ImageOptions.Image");
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new System.Drawing.Size(1922, 1036);
            xtraTabPage2.Text = "Firmalar";
            // 
            // gridControl2
            // 
            gridControl2.Location = new System.Drawing.Point(-1, 3);
            gridControl2.MainView = gridView2;
            gridControl2.Name = "gridControl2";
            gridControl2.Size = new System.Drawing.Size(1920, 795);
            gridControl2.TabIndex = 6;
            gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            gridView2.Appearance.Row.BorderColor = System.Drawing.Color.Aqua;
            gridView2.Appearance.Row.Options.UseBackColor = true;
            gridView2.Appearance.Row.Options.UseBorderColor = true;
            gridView2.GridControl = gridControl2;
            gridView2.Name = "gridView2";
            gridView2.DoubleClick += gridView2_DoubleClick;
            // 
            // FrmRehber
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1924, 1061);
            Controls.Add(xtraTabControl1);
            Name = "FrmRehber";
            Text = "Rehber";
            Load += FrmRehber_Load;
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).EndInit();
            xtraTabControl1.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}