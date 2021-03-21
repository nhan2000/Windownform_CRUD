namespace Demo_CRUD
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSBD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentData = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Controls.Add(this.btCapNhat);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSBD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(61, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 433);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "StudentInformation";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(831, 323);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(109, 64);
            this.btThoat.TabIndex = 14;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(663, 348);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(98, 39);
            this.btXoa.TabIndex = 13;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(478, 348);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(98, 39);
            this.btSua.TabIndex = 12;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(266, 348);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(98, 39);
            this.btCapNhat.TabIndex = 11;
            this.btCapNhat.Text = "Cập Nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(65, 348);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(98, 39);
            this.btThem.TabIndex = 10;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(563, 153);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(154, 34);
            this.txtSDT.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(447, 156);
            this.label5.MaximumSize = new System.Drawing.Size(100, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số Điện Thoại";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(563, 64);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(154, 34);
            this.txtDiaChi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(447, 67);
            this.label4.MaximumSize = new System.Drawing.Size(100, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa Chỉ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSBD
            // 
            this.txtSBD.Location = new System.Drawing.Point(145, 231);
            this.txtSBD.Multiline = true;
            this.txtSBD.Name = "txtSBD";
            this.txtSBD.Size = new System.Drawing.Size(154, 34);
            this.txtSBD.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 234);
            this.label3.MaximumSize = new System.Drawing.Size(100, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Báo Danh";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(145, 153);
            this.txtHo.Multiline = true;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(154, 34);
            this.txtHo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 156);
            this.label2.MaximumSize = new System.Drawing.Size(100, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Sinh Viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(145, 64);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(154, 34);
            this.txtTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 67);
            this.label1.MaximumSize = new System.Drawing.Size(100, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentData
            // 
            this.StudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentData.Location = new System.Drawing.Point(61, 468);
            this.StudentData.Name = "StudentData";
            this.StudentData.RowHeadersWidth = 51;
            this.StudentData.RowTemplate.Height = 24;
            this.StudentData.Size = new System.Drawing.Size(965, 150);
            this.StudentData.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1087, 620);
            this.Controls.Add(this.StudentData);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView StudentData;
    }
}

