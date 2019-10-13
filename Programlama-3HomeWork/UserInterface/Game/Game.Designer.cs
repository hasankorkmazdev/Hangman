namespace Programlama_3HomeWork.UserInterface.Game
{
    partial class Game
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
            this.btnEntry = new System.Windows.Forms.Button();
            this.lblHealth = new System.Windows.Forms.Label();
            this.txtChar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEntry
            // 
            this.btnEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnEntry.FlatAppearance.BorderSize = 0;
            this.btnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntry.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntry.Location = new System.Drawing.Point(47, 41);
            this.btnEntry.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(77, 28);
            this.btnEntry.TabIndex = 23;
            this.btnEntry.Text = "Dene";
            this.btnEntry.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEntry.UseVisualStyleBackColor = false;
            this.btnEntry.Click += new System.EventHandler(this.BtnEntry_Click);
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHealth.Location = new System.Drawing.Point(3, 13);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(79, 21);
            this.lblHealth.TabIndex = 22;
            this.lblHealth.Text = "Hakkınız :";
            // 
            // txtChar
            // 
            this.txtChar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtChar.Location = new System.Drawing.Point(3, 41);
            this.txtChar.Name = "txtChar";
            this.txtChar.Size = new System.Drawing.Size(39, 27);
            this.txtChar.TabIndex = 21;
            this.txtChar.TextChanged += new System.EventHandler(this.TxtChar_TextChanged);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.txtChar);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(747, 331);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.TextBox txtChar;
    }
}
