namespace Programlama_3HomeWork.UserInterface.Words
{
    partial class Words
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLeftBar = new System.Windows.Forms.Panel();
            this.btnWordsEdit = new System.Windows.Forms.Button();
            this.btnWordsADD = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlLeftBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftBar
            // 
            this.pnlLeftBar.Controls.Add(this.btnWordsEdit);
            this.pnlLeftBar.Controls.Add(this.btnWordsADD);
            this.pnlLeftBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftBar.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftBar.Name = "pnlLeftBar";
            this.pnlLeftBar.Size = new System.Drawing.Size(172, 351);
            this.pnlLeftBar.TabIndex = 0;
            // 
            // btnWordsEdit
            // 
            this.btnWordsEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnWordsEdit.FlatAppearance.BorderSize = 0;
            this.btnWordsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWordsEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWordsEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWordsEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWordsEdit.Location = new System.Drawing.Point(4, 51);
            this.btnWordsEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnWordsEdit.Name = "btnWordsEdit";
            this.btnWordsEdit.Size = new System.Drawing.Size(163, 34);
            this.btnWordsEdit.TabIndex = 8;
            this.btnWordsEdit.Text = "Kelime Düzenle";
            this.btnWordsEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWordsEdit.UseVisualStyleBackColor = false;
            this.btnWordsEdit.Click += new System.EventHandler(this.BtnWordsEdit_Click);
            // 
            // btnWordsADD
            // 
            this.btnWordsADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnWordsADD.FlatAppearance.BorderSize = 0;
            this.btnWordsADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWordsADD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWordsADD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWordsADD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWordsADD.Location = new System.Drawing.Point(4, 13);
            this.btnWordsADD.Margin = new System.Windows.Forms.Padding(2);
            this.btnWordsADD.Name = "btnWordsADD";
            this.btnWordsADD.Size = new System.Drawing.Size(163, 34);
            this.btnWordsADD.TabIndex = 7;
            this.btnWordsADD.Text = "Kelime Ekle";
            this.btnWordsADD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWordsADD.UseVisualStyleBackColor = false;
            this.btnWordsADD.Click += new System.EventHandler(this.BtnWordsADD_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(172, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(738, 351);
            this.pnlMain.TabIndex = 1;
            // 
            // Words
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeftBar);
            this.Name = "Words";
            this.Size = new System.Drawing.Size(910, 351);
            this.pnlLeftBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftBar;
        private System.Windows.Forms.Panel pnlMain;
        public System.Windows.Forms.Button btnWordsEdit;
        public System.Windows.Forms.Button btnWordsADD;
    }
}
