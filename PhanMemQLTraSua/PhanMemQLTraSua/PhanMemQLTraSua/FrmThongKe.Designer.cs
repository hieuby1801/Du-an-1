namespace PhanMemQLTraSua
{
    partial class FrmThongKe
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
            this.DataGR = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Mtb1 = new System.Windows.Forms.MaskedTextBox();
            this.Mtb2 = new System.Windows.Forms.MaskedTextBox();
            this.btThongKe = new System.Windows.Forms.Button();
            this.btEX = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGR)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGR
            // 
            this.DataGR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGR.Location = new System.Drawing.Point(12, 118);
            this.DataGR.Name = "DataGR";
            this.DataGR.RowHeadersWidth = 51;
            this.DataGR.RowTemplate.Height = 24;
            this.DataGR.Size = new System.Drawing.Size(945, 357);
            this.DataGR.TabIndex = 0;
            this.DataGR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGR_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống Kê Doanh Thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tới Ngày";
            // 
            // Mtb1
            // 
            this.Mtb1.Location = new System.Drawing.Point(294, 62);
            this.Mtb1.Mask = "00/00/0000";
            this.Mtb1.Name = "Mtb1";
            this.Mtb1.Size = new System.Drawing.Size(100, 22);
            this.Mtb1.TabIndex = 4;
            this.Mtb1.ValidatingType = typeof(System.DateTime);
            // 
            // Mtb2
            // 
            this.Mtb2.Location = new System.Drawing.Point(553, 65);
            this.Mtb2.Mask = "00/00/0000";
            this.Mtb2.Name = "Mtb2";
            this.Mtb2.Size = new System.Drawing.Size(100, 22);
            this.Mtb2.TabIndex = 5;
            this.Mtb2.ValidatingType = typeof(System.DateTime);
            // 
            // btThongKe
            // 
            this.btThongKe.BackColor = System.Drawing.SystemColors.Highlight;
            this.btThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongKe.Location = new System.Drawing.Point(710, 61);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(114, 29);
            this.btThongKe.TabIndex = 6;
            this.btThongKe.Text = "Thống Kê";
            this.btThongKe.UseVisualStyleBackColor = false;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // btEX
            // 
            this.btEX.BackColor = System.Drawing.SystemColors.Highlight;
            this.btEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEX.Location = new System.Drawing.Point(843, 62);
            this.btEX.Name = "btEX";
            this.btEX.Size = new System.Drawing.Size(114, 29);
            this.btEX.TabIndex = 7;
            this.btEX.Text = "Thoát";
            this.btEX.UseVisualStyleBackColor = false;
            this.btEX.Click += new System.EventHandler(this.btEX_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(969, 487);
            this.Controls.Add(this.btEX);
            this.Controls.Add(this.btThongKe);
            this.Controls.Add(this.Mtb2);
            this.Controls.Add(this.Mtb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGR);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Doanh Thu";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox Mtb1;
        private System.Windows.Forms.MaskedTextBox Mtb2;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.Button btEX;
    }
}