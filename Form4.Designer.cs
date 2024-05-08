
namespace BTL_2023_c
{
    partial class Form4
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
            this.cryMaSV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbmaSV = new System.Windows.Forms.ComboBox();
            this.btchon = new System.Windows.Forms.Button();
            this.cbTenKhoa = new System.Windows.Forms.ComboBox();
            this.cbTenLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cryMaSV
            // 
            this.cryMaSV.ActiveViewIndex = -1;
            this.cryMaSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryMaSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryMaSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cryMaSV.Location = new System.Drawing.Point(0, 192);
            this.cryMaSV.Name = "cryMaSV";
            this.cryMaSV.Size = new System.Drawing.Size(842, 262);
            this.cryMaSV.TabIndex = 0;
            // 
            // cbmaSV
            // 
            this.cbmaSV.FormattingEnabled = true;
            this.cbmaSV.Location = new System.Drawing.Point(202, 122);
            this.cbmaSV.Name = "cbmaSV";
            this.cbmaSV.Size = new System.Drawing.Size(194, 24);
            this.cbmaSV.TabIndex = 2;
            // 
            // btchon
            // 
            this.btchon.Location = new System.Drawing.Point(338, 159);
            this.btchon.Name = "btchon";
            this.btchon.Size = new System.Drawing.Size(107, 23);
            this.btchon.TabIndex = 3;
            this.btchon.Text = "Chon";
            this.btchon.UseVisualStyleBackColor = true;
            this.btchon.Click += new System.EventHandler(this.btchon_Click);
            // 
            // cbTenKhoa
            // 
            this.cbTenKhoa.FormattingEnabled = true;
            this.cbTenKhoa.Location = new System.Drawing.Point(202, 37);
            this.cbTenKhoa.Name = "cbTenKhoa";
            this.cbTenKhoa.Size = new System.Drawing.Size(243, 24);
            this.cbTenKhoa.TabIndex = 7;
            this.cbTenKhoa.SelectedIndexChanged += new System.EventHandler(this.cbTenKhoa_SelectedIndexChanged);
            // 
            // cbTenLop
            // 
            this.cbTenLop.FormattingEnabled = true;
            this.cbTenLop.Location = new System.Drawing.Point(202, 80);
            this.cbTenLop.Name = "cbTenLop";
            this.cbTenLop.Size = new System.Drawing.Size(140, 24);
            this.cbTenLop.TabIndex = 8;
            this.cbTenLop.SelectedIndexChanged += new System.EventHandler(this.cbTenLop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Khoa: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã sinh viên:";
            this.label3.UseMnemonic = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 454);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTenLop);
            this.Controls.Add(this.cbTenKhoa);
            this.Controls.Add(this.btchon);
            this.Controls.Add(this.cbmaSV);
            this.Controls.Add(this.cryMaSV);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryMaSV;
        private System.Windows.Forms.ComboBox cbmaSV;
        private System.Windows.Forms.Button btchon;
        private System.Windows.Forms.ComboBox cbTenKhoa;
        private System.Windows.Forms.ComboBox cbTenLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}