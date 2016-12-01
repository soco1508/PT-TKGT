namespace PhanTichVaThietKeGiaiThuat
{
    partial class SoTrungMauChuoiKyTu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtChuoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.btnSoChuoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuỗi ký tự:";
            // 
            // txtChuoi
            // 
            this.txtChuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuoi.Location = new System.Drawing.Point(114, 33);
            this.txtChuoi.Multiline = true;
            this.txtChuoi.Name = "txtChuoi";
            this.txtChuoi.Size = new System.Drawing.Size(175, 51);
            this.txtChuoi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mẫu:";
            // 
            // txtMau
            // 
            this.txtMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMau.Location = new System.Drawing.Point(114, 98);
            this.txtMau.Multiline = true;
            this.txtMau.Name = "txtMau";
            this.txtMau.Size = new System.Drawing.Size(174, 25);
            this.txtMau.TabIndex = 3;
            // 
            // btnSoChuoi
            // 
            this.btnSoChuoi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSoChuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoChuoi.Location = new System.Drawing.Point(114, 151);
            this.btnSoChuoi.Name = "btnSoChuoi";
            this.btnSoChuoi.Size = new System.Drawing.Size(140, 49);
            this.btnSoChuoi.TabIndex = 4;
            this.btnSoChuoi.Text = "So chuỗi";
            this.btnSoChuoi.UseVisualStyleBackColor = false;
            this.btnSoChuoi.Click += new System.EventHandler(this.btnSoChuoi_Click);
            // 
            // SoTrungMauChuoiKyTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 222);
            this.Controls.Add(this.btnSoChuoi);
            this.Controls.Add(this.txtMau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChuoi);
            this.Controls.Add(this.label1);
            this.Name = "SoTrungMauChuoiKyTu";
            this.Text = "SOTRUNGMAUCHUOIKYTU";
            this.Load += new System.EventHandler(this.SoTrungMauChuoiKyTu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChuoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMau;
        private System.Windows.Forms.Button btnSoChuoi;
    }
}