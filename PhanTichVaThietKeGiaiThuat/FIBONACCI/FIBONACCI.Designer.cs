namespace FIBONACCI
{
    partial class FIBONACCI
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
            this.btnQHD = new System.Windows.Forms.Button();
            this.btnTT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQHD
            // 
            this.btnQHD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQHD.Location = new System.Drawing.Point(78, 96);
            this.btnQHD.Name = "btnQHD";
            this.btnQHD.Size = new System.Drawing.Size(115, 55);
            this.btnQHD.TabIndex = 0;
            this.btnQHD.Text = "Qui hoạch động";
            this.btnQHD.UseVisualStyleBackColor = false;
            this.btnQHD.Click += new System.EventHandler(this.btnQHD_Click);
            // 
            // btnTT
            // 
            this.btnTT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTT.Location = new System.Drawing.Point(78, 157);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(115, 56);
            this.btnTT.TabIndex = 1;
            this.btnTT.Text = "Trực tiếp";
            this.btnTT.UseVisualStyleBackColor = false;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập n:";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(93, 54);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 26);
            this.txtN.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tính Fibonacci";
            // 
            // FIBONACCI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTT);
            this.Controls.Add(this.btnQHD);
            this.Name = "FIBONACCI";
            this.Text = "FIBONACCI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQHD;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label2;
    }
}