
namespace BTL_2023_c
{
    partial class QLDiem
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
            this.mask_diemCC = new System.Windows.Forms.MaskedTextBox();
            this.mask_diemGK = new System.Windows.Forms.MaskedTextBox();
            this.mask_diemCK = new System.Windows.Forms.MaskedTextBox();
            this.dataGridDiem = new System.Windows.Forms.DataGridView();
            this.btn_themDiem = new System.Windows.Forms.Button();
            this.btn_suaDiem = new System.Windows.Forms.Button();
            this.btn_xoaDiem = new System.Windows.Forms.Button();
            this.cb_maSv = new System.Windows.Forms.ComboBox();
            this.cb = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_ngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btkhoitao = new System.Windows.Forms.Button();
            this.tk = new System.Windows.Forms.TextBox();
            this.crystal = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiem)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm chuyên cần";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm giữa kì";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm cuối kì";
            // 
            // mask_diemCC
            // 
            this.mask_diemCC.Location = new System.Drawing.Point(163, 140);
            this.mask_diemCC.Name = "mask_diemCC";
            this.mask_diemCC.Size = new System.Drawing.Size(76, 22);
            this.mask_diemCC.TabIndex = 8;
            // 
            // mask_diemGK
            // 
            this.mask_diemGK.Location = new System.Drawing.Point(163, 175);
            this.mask_diemGK.Name = "mask_diemGK";
            this.mask_diemGK.Size = new System.Drawing.Size(76, 22);
            this.mask_diemGK.TabIndex = 9;
            // 
            // mask_diemCK
            // 
            this.mask_diemCK.Location = new System.Drawing.Point(163, 210);
            this.mask_diemCK.Name = "mask_diemCK";
            this.mask_diemCK.Size = new System.Drawing.Size(76, 22);
            this.mask_diemCK.TabIndex = 10;
            // 
            // dataGridDiem
            // 
            this.dataGridDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDiem.Location = new System.Drawing.Point(399, 12);
            this.dataGridDiem.Name = "dataGridDiem";
            this.dataGridDiem.RowHeadersWidth = 51;
            this.dataGridDiem.RowTemplate.Height = 24;
            this.dataGridDiem.Size = new System.Drawing.Size(621, 351);
            this.dataGridDiem.TabIndex = 12;
            this.dataGridDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDiem_CellClick);
            // 
            // btn_themDiem
            // 
            this.btn_themDiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_themDiem.Location = new System.Drawing.Point(0, 3);
            this.btn_themDiem.Name = "btn_themDiem";
            this.btn_themDiem.Size = new System.Drawing.Size(79, 55);
            this.btn_themDiem.TabIndex = 13;
            this.btn_themDiem.Text = "Thêm";
            this.btn_themDiem.UseVisualStyleBackColor = false;
            this.btn_themDiem.Click += new System.EventHandler(this.btn_themDiem_Click);
            // 
            // btn_suaDiem
            // 
            this.btn_suaDiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_suaDiem.Location = new System.Drawing.Point(99, 3);
            this.btn_suaDiem.Name = "btn_suaDiem";
            this.btn_suaDiem.Size = new System.Drawing.Size(79, 55);
            this.btn_suaDiem.TabIndex = 14;
            this.btn_suaDiem.Text = "Sửa";
            this.btn_suaDiem.UseVisualStyleBackColor = false;
            this.btn_suaDiem.Click += new System.EventHandler(this.btn_suaDiem_Click);
            // 
            // btn_xoaDiem
            // 
            this.btn_xoaDiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_xoaDiem.Location = new System.Drawing.Point(196, 3);
            this.btn_xoaDiem.Name = "btn_xoaDiem";
            this.btn_xoaDiem.Size = new System.Drawing.Size(79, 55);
            this.btn_xoaDiem.TabIndex = 15;
            this.btn_xoaDiem.Text = "Xóa";
            this.btn_xoaDiem.UseVisualStyleBackColor = false;
            this.btn_xoaDiem.Click += new System.EventHandler(this.btn_xoaDiem_Click);
            // 
            // cb_maSv
            // 
            this.cb_maSv.FormattingEnabled = true;
            this.cb_maSv.Location = new System.Drawing.Point(163, 17);
            this.cb_maSv.Name = "cb_maSv";
            this.cb_maSv.Size = new System.Drawing.Size(187, 24);
            this.cb_maSv.TabIndex = 16;
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(163, 65);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(187, 24);
            this.cb.TabIndex = 17;
            this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_maMh_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cb_ngaysinh);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_maSv);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mask_diemCC);
            this.panel1.Controls.Add(this.mask_diemGK);
            this.panel1.Controls.Add(this.mask_diemCK);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 245);
            this.panel1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Chon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_ngaysinh
            // 
            this.cb_ngaysinh.Location = new System.Drawing.Point(163, 108);
            this.cb_ngaysinh.Mask = "00/00/0000";
            this.cb_ngaysinh.Name = "cb_ngaysinh";
            this.cb_ngaysinh.Size = new System.Drawing.Size(197, 22);
            this.cb_ngaysinh.TabIndex = 20;
            this.cb_ngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ngày học";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btkhoitao);
            this.panel2.Controls.Add(this.btn_themDiem);
            this.panel2.Controls.Add(this.btn_suaDiem);
            this.panel2.Controls.Add(this.btn_xoaDiem);
            this.panel2.Location = new System.Drawing.Point(12, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 58);
            this.panel2.TabIndex = 21;
            // 
            // btkhoitao
            // 
            this.btkhoitao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btkhoitao.Location = new System.Drawing.Point(293, 3);
            this.btkhoitao.Name = "btkhoitao";
            this.btkhoitao.Size = new System.Drawing.Size(79, 55);
            this.btkhoitao.TabIndex = 16;
            this.btkhoitao.Text = "Khởi tạo";
            this.btkhoitao.UseVisualStyleBackColor = false;
            this.btkhoitao.Click += new System.EventHandler(this.btkhoitao_Click);
            // 
            // tk
            // 
            this.tk.Location = new System.Drawing.Point(53, 340);
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(309, 22);
            this.tk.TabIndex = 22;
            this.tk.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // crystal
            // 
            this.crystal.ActiveViewIndex = -1;
            this.crystal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystal.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystal.Location = new System.Drawing.Point(2, 400);
            this.crystal.Name = "crystal";
            this.crystal.Size = new System.Drawing.Size(1040, 233);
            this.crystal.TabIndex = 23;
            // 
            // QLDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 627);
            this.Controls.Add(this.crystal);
            this.Controls.Add(this.tk);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridDiem);
            this.Name = "QLDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "QLDiem";
            this.Load += new System.EventHandler(this.QLDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mask_diemCC;
        private System.Windows.Forms.MaskedTextBox mask_diemGK;
        private System.Windows.Forms.MaskedTextBox mask_diemCK;
        private System.Windows.Forms.DataGridView dataGridDiem;
        private System.Windows.Forms.Button btn_themDiem;
        private System.Windows.Forms.Button btn_suaDiem;
        private System.Windows.Forms.Button btn_xoaDiem;
        private System.Windows.Forms.ComboBox cb_maSv;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox cb_ngaysinh;
        private System.Windows.Forms.Button btkhoitao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tk;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystal;
    }
}