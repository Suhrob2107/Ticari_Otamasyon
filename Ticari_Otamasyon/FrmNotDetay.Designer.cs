namespace Ticari_Otamasyon
{
    partial class FrmNotDetay
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
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            richTextBox1.Location = new System.Drawing.Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new System.Drawing.Size(800, 450);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // FrmNotDetay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(richTextBox1);
            Name = "FrmNotDetay";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Not detay";
            Load += FrmNotDetay_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}