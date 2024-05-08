
namespace BTL_2023_c
{
    partial class QLSV
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mask_maSV = new System.Windows.Forms.MaskedTextBox();
            this.mask_tenSv = new System.Windows.Forms.MaskedTextBox();
            this.mask_GT = new System.Windows.Forms.MaskedTextBox();
            this.mask_queQuan = new System.Windows.Forms.MaskedTextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.combo_malop = new System.Windows.Forms.ComboBox();
            this.dtGridSV = new System.Windows.Forms.DataGridView();
            this.cbxXem = new System.Windows.Forms.ComboBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_khoitao = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quê quán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã lớp";
            // 
            // mask_maSV
            // 
            this.mask_maSV.Location = new System.Drawing.Point(106, 9);
            this.mask_maSV.Name = "mask_maSV";
            this.mask_maSV.Size = new System.Drawing.Size(197, 22);
            this.mask_maSV.TabIndex = 6;
            // 
            // mask_tenSv
            // 
            this.mask_tenSv.Location = new System.Drawing.Point(106, 53);
            this.mask_tenSv.Name = "mask_tenSv";
            this.mask_tenSv.Size = new System.Drawing.Size(197, 22);
            this.mask_tenSv.TabIndex = 7;
            // 
            // mask_GT
            // 
            this.mask_GT.Location = new System.Drawing.Point(106, 103);
            this.mask_GT.Name = "mask_GT";
            this.mask_GT.Size = new System.Drawing.Size(197, 22);
            this.mask_GT.TabIndex = 8;
            // 
            // mask_queQuan
            // 
            this.mask_queQuan.Location = new System.Drawing.Point(106, 202);
            this.mask_queQuan.Name = "mask_queQuan";
            this.mask_queQuan.Size = new System.Drawing.Size(197, 22);
            this.mask_queQuan.TabIndex = 10;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_them.Location = new System.Drawing.Point(3, 6);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(80, 52);
            this.btn_them.TabIndex = 12;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_sua.Location = new System.Drawing.Point(80, 7);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(80, 52);
            this.btn_sua.TabIndex = 13;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_xoa.Location = new System.Drawing.Point(165, 7);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(80, 52);
            this.btn_xoa.TabIndex = 14;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // combo_malop
            // 
            this.combo_malop.FormattingEnabled = true;
            this.combo_malop.Location = new System.Drawing.Point(106, 254);
            this.combo_malop.Name = "combo_malop";
            this.combo_malop.Size = new System.Drawing.Size(197, 24);
            this.combo_malop.TabIndex = 15;
            // 
            // dtGridSV
            // 
            this.dtGridSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSV.Location = new System.Drawing.Point(333, 14);
            this.dtGridSV.Name = "dtGridSV";
            this.dtGridSV.RowHeadersWidth = 51;
            this.dtGridSV.RowTemplate.Height = 24;
            this.dtGridSV.Size = new System.Drawing.Size(805, 353);
            this.dtGridSV.TabIndex = 16;
            this.dtGridSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridSV_CellClick);
            this.dtGridSV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridSV_CellDoubleClick);
            // 
            // cbxXem
            // 
            this.cbxXem.FormattingEnabled = true;
            this.cbxXem.Location = new System.Drawing.Point(16, 9);
            this.cbxXem.Name = "cbxXem";
            this.cbxXem.Size = new System.Drawing.Size(229, 24);
            this.cbxXem.TabIndex = 19;
            this.cbxXem.Text = "Xem";
            this.cbxXem.SelectedIndexChanged += new System.EventHandler(this.cbxXem_SelectedIndexChanged);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(251, 3);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 39);
            this.btnChon.TabIndex = 20;
            this.btnChon.Text = "Chọn ";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mask_maSV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mask_tenSv);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mask_GT);
            this.panel1.Controls.Add(this.combo_malop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.mask_queQuan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 288);
            this.panel1.TabIndex = 21;
            // 
            // dtTime
            // 
            this.dtTime.CustomFormat = "dd/MM/yyyy";
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTime.Location = new System.Drawing.Point(106, 157);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(200, 22);
            this.dtTime.TabIndex = 17;
            this.dtTime.Value = new System.DateTime(2023, 10, 25, 0, 0, 0, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.bt_khoitao);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Location = new System.Drawing.Point(12, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 58);
            this.panel2.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, -11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bt_khoitao
            // 
            this.bt_khoitao.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt_khoitao.Location = new System.Drawing.Point(246, 7);
            this.bt_khoitao.Name = "bt_khoitao";
            this.bt_khoitao.Size = new System.Drawing.Size(80, 52);
            this.bt_khoitao.TabIndex = 25;
            this.bt_khoitao.Text = "Khởi tạo";
            this.bt_khoitao.UseVisualStyleBackColor = false;
            this.bt_khoitao.Click += new System.EventHandler(this.bt_khoitao_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbxXem);
            this.panel4.Controls.Add(this.btnChon);
            this.panel4.Location = new System.Drawing.Point(12, 373);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(329, 45);
            this.panel4.TabIndex = 24;
            // 
            // QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 435);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtGridSV);
            this.Name = "QLSV";
            this.Text = "QLSV";
            this.Load += new System.EventHandler(this.QLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mask_maSV;
        private System.Windows.Forms.MaskedTextBox mask_tenSv;
        private System.Windows.Forms.MaskedTextBox mask_GT;
        private System.Windows.Forms.MaskedTextBox mask_queQuan;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.ComboBox combo_malop;
        private System.Windows.Forms.DataGridView dtGridSV;
        private System.Windows.Forms.ComboBox cbxXem;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bt_khoitao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtTime;
    }
}