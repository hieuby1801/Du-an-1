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
            this.lbltaikhoang = new System.Windows.Forms.Label();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttaikhoang = new System.Windows.Forms.TextBox();
            this.llbllienhe = new System.Windows.Forms.LinkLabel();
            this.llblhuongdan = new System.Windows.Forms.LinkLabel();
            this.rdohienmatkhau = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltaikhoang
            // 
            this.lbltaikhoang.AutoSize = true;
            this.lbltaikhoang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbltaikhoang.Location = new System.Drawing.Point(525, 112);
            this.lbltaikhoang.Name = "lbltaikhoang";
            this.lbltaikhoang.Size = new System.Drawing.Size(103, 25);
            this.lbltaikhoang.TabIndex = 0;
            this.lbltaikhoang.Text = "Tài Khoản";
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.AutoSize = true;
            this.lblmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblmatkhau.Location = new System.Drawing.Point(525, 189);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(97, 25);
            this.lblmatkhau.TabIndex = 1;
            this.lblmatkhau.Text = "Mật Khẩu";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(659, 187);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(198, 26);
            this.txtmatkhau.TabIndex = 3;
            this.txtmatkhau.UseSystemPasswordChar = true;
            // 
            // txttaikhoang
            // 
            this.txttaikhoang.Location = new System.Drawing.Point(659, 109);
            this.txttaikhoang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttaikhoang.Name = "txttaikhoang";
            this.txttaikhoang.Size = new System.Drawing.Size(198, 26);
            this.txttaikhoang.TabIndex = 2;
            // 
            // llbllienhe
            // 
            this.llbllienhe.AutoSize = true;
            this.llbllienhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llbllienhe.Location = new System.Drawing.Point(526, 384);
            this.llbllienhe.Name = "llbllienhe";
            this.llbllienhe.Size = new System.Drawing.Size(72, 22);
            this.llbllienhe.TabIndex = 4;
            this.llbllienhe.TabStop = true;
            this.llbllienhe.Text = "Liên Hệ";
            // 
            // llblhuongdan
            // 
            this.llblhuongdan.AutoSize = true;
            this.llblhuongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llblhuongdan.Location = new System.Drawing.Point(758, 384);
            this.llblhuongdan.Name = "llblhuongdan";
            this.llblhuongdan.Size = new System.Drawing.Size(101, 22);
            this.llblhuongdan.TabIndex = 5;
            this.llblhuongdan.TabStop = true;
            this.llblhuongdan.Text = "Hướng Dẫn";
            // 
            // rdohienmatkhau
            // 
            this.rdohienmatkhau.AutoSize = true;
            this.rdohienmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdohienmatkhau.Location = new System.Drawing.Point(659, 242);
            this.rdohienmatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdohienmatkhau.Name = "rdohienmatkhau";
            this.rdohienmatkhau.Size = new System.Drawing.Size(164, 24);
            this.rdohienmatkhau.TabIndex = 6;
            this.rdohienmatkhau.TabStop = true;
            this.rdohienmatkhau.Text = "Hiển Thị Mật Khẩu";
            this.rdohienmatkhau.UseVisualStyleBackColor = true;
            this.rdohienmatkhau.CheckedChanged += new System.EventHandler(this.rdohienmatkhau_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhanMemQLTraSua.Properties.Resources.anh_ly_tra_sua_cute_hinh_nen_tra_sua_dep_nhat_03;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 458);
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
            this.pictureBox3.Location = new System.Drawing.Point(494, -3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(379, 458);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndangnhap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndangnhap.Location = new System.Drawing.Point(659, 302);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(115, 48);
            this.btndangnhap.TabIndex = 10;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdohienmatkhau);
            this.Controls.Add(this.llblhuongdan);
            this.Controls.Add(this.llbllienhe);
            this.Controls.Add(this.txttaikhoang);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.lblmatkhau);
            this.Controls.Add(this.lbltaikhoang);
            this.Controls.Add(this.pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label lblmatkhau;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttaikhoang;
        private System.Windows.Forms.LinkLabel llbllienhe;
        private System.Windows.Forms.LinkLabel llblhuongdan;
        private System.Windows.Forms.RadioButton rdohienmatkhau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btndangnhap;
    }
}