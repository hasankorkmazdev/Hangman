namespace Programlama_3HomeWork
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLeftcontainer = new System.Windows.Forms.Panel();
            this.btnWords = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.pnlLeftcontainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftcontainer
            // 
            this.pnlLeftcontainer.Controls.Add(this.btnWords);
            this.pnlLeftcontainer.Controls.Add(this.btnStartGame);
            this.pnlLeftcontainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftcontainer.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftcontainer.Name = "pnlLeftcontainer";
            this.pnlLeftcontainer.Size = new System.Drawing.Size(179, 511);
            this.pnlLeftcontainer.TabIndex = 2;
            // 
            // btnWords
            // 
            this.btnWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnWords.FlatAppearance.BorderSize = 0;
            this.btnWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWords.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWords.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWords.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWords.Location = new System.Drawing.Point(11, 49);
            this.btnWords.Margin = new System.Windows.Forms.Padding(2);
            this.btnWords.Name = "btnWords";
            this.btnWords.Size = new System.Drawing.Size(163, 34);
            this.btnWords.TabIndex = 6;
            this.btnWords.Text = "Kelime";
            this.btnWords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWords.UseVisualStyleBackColor = false;
            this.btnWords.Click += new System.EventHandler(this.BtnWords_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnStartGame.FlatAppearance.BorderSize = 0;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStartGame.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartGame.Location = new System.Drawing.Point(11, 11);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(163, 34);
            this.btnStartGame.TabIndex = 5;
            this.btnStartGame.Text = "Oyuna Başla";
            this.btnStartGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(179, 0);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(884, 511);
            this.pnlMainContainer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 511);
            this.Controls.Add(this.pnlMainContainer);
            this.Controls.Add(this.pnlLeftcontainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlLeftcontainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeftcontainer;
        private System.Windows.Forms.Button btnStartGame;
        public System.Windows.Forms.Button btnWords;
        public System.Windows.Forms.Panel pnlMainContainer;
    }
}

