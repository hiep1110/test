
namespace BTL_2023_c
{
    partial class FormDiemSV
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
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbGt = new System.Windows.Forms.Label();
            this.lbQue = new System.Windows.Forms.Label();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.lbTenSv = new System.Windows.Forms.Label();
            this.dtgDiem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.Location = new System.Drawing.Point(453, 65);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(238, 23);
            this.lbNgaySinh.TabIndex = 5;
            this.lbNgaySinh.Click += new System.EventHandler(this.lbNgaySinh_Click);
            // 
            // lbGt
            // 
            this.lbGt.Location = new System.Drawing.Point(141, 65);
            this.lbGt.Name = "lbGt";
            this.lbGt.Size = new System.Drawing.Size(120, 23);
            this.lbGt.TabIndex = 6;
            // 
            // lbQue
            // 
            this.lbQue.Location = new System.Drawing.Point(130, 104);
            this.lbQue.Name = "lbQue";
            this.lbQue.Size = new System.Drawing.Size(181, 28);
            this.lbQue.TabIndex = 7;
            // 
            // lbMaSV
            // 
            this.lbMaSV.Location = new System.Drawing.Point(453, 104);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(292, 28);
            this.lbMaSV.TabIndex = 8;
            // 
            // lbTenSv
            // 
            this.lbTenSv.Location = new System.Drawing.Point(180, 25);
            this.lbTenSv.Name = "lbTenSv";
            this.lbTenSv.Size = new System.Drawing.Size(393, 26);
            this.lbTenSv.TabIndex = 9;
            // 
            // dtgDiem
            // 
            this.dtgDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDiem.Location = new System.Drawing.Point(0, 179);
            this.dtgDiem.Name = "dtgDiem";
            this.dtgDiem.RowHeadersWidth = 51;
            this.dtgDiem.RowTemplate.Height = 24;
            this.dtgDiem.Size = new System.Drawing.Size(802, 239);
            this.dtgDiem.TabIndex = 10;
            
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ten sinh vien:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Gioi tinh:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(341, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ngay sinh:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(35, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Que quan:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(341, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ma sinh vien:";
            // 
            // FormDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 414);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgDiem);
            this.Controls.Add(this.lbTenSv);
            this.Controls.Add(this.lbMaSV);
            this.Controls.Add(this.lbQue);
            this.Controls.Add(this.lbGt);
            this.Controls.Add(this.lbNgaySinh);
            this.Name = "FormDiemSV";
            this.Text = "FormDiemSV";
            this.Load += new System.EventHandler(this.FormDiemSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbGt;
        private System.Windows.Forms.Label lbQue;
        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.Label lbTenSv;
        private System.Windows.Forms.DataGridView dtgDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}