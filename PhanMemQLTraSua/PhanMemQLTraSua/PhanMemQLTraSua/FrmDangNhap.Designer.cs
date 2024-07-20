namespace PhanMemQLTraSua
{
    partial class FrmDangNhap
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
            System.Windows.Forms.Label lblmatkhau;
            this.lbltaikhoang = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttaikhoang = new System.Windows.Forms.TextBox();
            this.llbllienhe = new System.Windows.Forms.LinkLabel();
            this.llblhuongdan = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.Cb_ShowPass = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            lblmatkhau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmatkhau
            // 
            lblmatkhau.AutoSize = true;
            lblmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lblmatkhau.Location = new System.Drawing.Point(458, 152);
            lblmatkhau.Name = "lblmatkhau";
            lblmatkhau.Size = new System.Drawing.Size(80, 20);
            lblmatkhau.TabIndex = 1;
            lblmatkhau.Text = "Mật Khẩu";
            lblmatkhau.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            lblmatkhau.Click += new System.EventHandler(this.lblmatkhau_Click);
            // 
            // lbltaikhoang
            // 
            this.lbltaikhoang.AutoSize = true;
            this.lbltaikhoang.BackColor = System.Drawing.SystemColors.Control;
            this.lbltaikhoang.Cursor = System.Windows.Forms.Cursors.No;
            this.lbltaikhoang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbltaikhoang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbltaikhoang.Location = new System.Drawing.Point(458, 87);
            this.lbltaikhoang.Name = "lbltaikhoang";
            this.lbltaikhoang.Size = new System.Drawing.Size(84, 20);
            this.lbltaikhoang.TabIndex = 0;
            this.lbltaikhoang.Text = "Tài Khoản";
            this.lbltaikhoang.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(567, 150);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(176, 22);
            this.txtmatkhau.TabIndex = 3;
            this.txtmatkhau.UseSystemPasswordChar = true;
            // 
            // txttaikhoang
            // 
            this.txttaikhoang.Location = new System.Drawing.Point(567, 87);
            this.txttaikhoang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttaikhoang.Name = "txttaikhoang";
            this.txttaikhoang.Size = new System.Drawing.Size(176, 22);
            this.txttaikhoang.TabIndex = 2;
            // 
            // llbllienhe
            // 
            this.llbllienhe.AutoSize = true;
            this.llbllienhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llbllienhe.Location = new System.Drawing.Point(459, 321);
            this.llbllienhe.Name = "llbllienhe";
            this.llbllienhe.Size = new System.Drawing.Size(58, 18);
            this.llbllienhe.TabIndex = 4;
            this.llbllienhe.TabStop = true;
            this.llbllienhe.Text = "Liên Hệ";
            // 
            // llblhuongdan
            // 
            this.llblhuongdan.AutoSize = true;
            this.llblhuongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llblhuongdan.Location = new System.Drawing.Point(724, 321);
            this.llblhuongdan.Name = "llblhuongdan";
            this.llblhuongdan.Size = new System.Drawing.Size(83, 18);
            this.llblhuongdan.TabIndex = 5;
            this.llblhuongdan.TabStop = true;
            this.llblhuongdan.Text = "Hướng Dẫn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhanMemQLTraSua.Properties.Resources.anh_ly_tra_sua_cute_hinh_nen_tra_sua_dep_nhat_03;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PhanMemQLTraSua.Properties.Resources.pngtree_milk_tea_shop_poster_background_material_image_150838;
            this.pictureBox3.Location = new System.Drawing.Point(411, -2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(407, 366);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndangnhap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndangnhap.Location = new System.Drawing.Point(524, 227);
            this.btndangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(102, 38);
            this.btndangnhap.TabIndex = 10;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            // 
            // Cb_ShowPass
            // 
            this.Cb_ShowPass.AutoSize = true;
            this.Cb_ShowPass.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_ShowPass.Location = new System.Drawing.Point(579, 190);
            this.Cb_ShowPass.Name = "Cb_ShowPass";
            this.Cb_ShowPass.Size = new System.Drawing.Size(145, 21);
            this.Cb_ShowPass.TabIndex = 11;
            this.Cb_ShowPass.Text = "Hiển Thị Mật Khẩu";
            this.Cb_ShowPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cb_ShowPass.UseVisualStyleBackColor = true;
            this.Cb_ShowPass.CheckedChanged += new System.EventHandler(this.Cb_ShowPass_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.Location = new System.Drawing.Point(641, 227);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 38);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 360);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.Cb_ShowPass);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.llblhuongdan);
            this.Controls.Add(this.llbllienhe);
            this.Controls.Add(this.txttaikhoang);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(lblmatkhau);
            this.Controls.Add(this.lbltaikhoang);
            this.Controls.Add(this.pictureBox3);
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltaikhoang;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttaikhoang;
        private System.Windows.Forms.LinkLabel llbllienhe;
        private System.Windows.Forms.LinkLabel llblhuongdan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.CheckBox Cb_ShowPass;
        private System.Windows.Forms.Button btnThoat;
    }
}