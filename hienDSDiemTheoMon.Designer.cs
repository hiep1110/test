
namespace BTL_2023_c
{
    partial class hienDSDiemTheoMon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHien = new System.Windows.Forms.Button();
            this.cbxMonHoc = new System.Windows.Forms.ComboBox();
            this.txbDiemB = new System.Windows.Forms.TextBox();
            this.txbDiemA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crtHienDSDiemTheoMon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHien);
            this.panel1.Controls.Add(this.cbxMonHoc);
            this.panel1.Controls.Add(this.txbDiemB);
            this.panel1.Controls.Add(this.txbDiemA);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 89);
            this.panel1.TabIndex = 0;
            // 
            // btnHien
            // 
            this.btnHien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHien.Location = new System.Drawing.Point(338, 12);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(75, 57);
            this.btnHien.TabIndex = 7;
            this.btnHien.Text = "Hiện";
            this.btnHien.UseVisualStyleBackColor = true;
            this.btnHien.Click += new System.EventHandler(this.btnHien_Click);
            // 
            // cbxMonHoc
            // 
            this.cbxMonHoc.FormattingEnabled = true;
            this.cbxMonHoc.Location = new System.Drawing.Point(139, 48);
            this.cbxMonHoc.Name = "cbxMonHoc";
            this.cbxMonHoc.Size = new System.Drawing.Size(163, 24);
            this.cbxMonHoc.TabIndex = 6;
            // 
            // txbDiemB
            // 
            this.txbDiemB.Location = new System.Drawing.Point(243, 12);
            this.txbDiemB.Name = "txbDiemB";
            this.txbDiemB.Size = new System.Drawing.Size(59, 22);
            this.txbDiemB.TabIndex = 5;
            // 
            // txbDiemA
            // 
            this.txbDiemA.Location = new System.Drawing.Point(139, 12);
            this.txbDiemA.Name = "txbDiemA";
            this.txbDiemA.Size = new System.Drawing.Size(59, 22);
            this.txbDiemA.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Từ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên môn học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập điểm:";
            // 
            // crtHienDSDiemTheoMon
            // 
            this.crtHienDSDiemTheoMon.ActiveViewIndex = -1;
            this.crtHienDSDiemTheoMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtHienDSDiemTheoMon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtHienDSDiemTheoMon.Location = new System.Drawing.Point(12, 107);
            this.crtHienDSDiemTheoMon.Name = "crtHienDSDiemTheoMon";
            this.crtHienDSDiemTheoMon.Size = new System.Drawing.Size(1274, 431);
            this.crtHienDSDiemTheoMon.TabIndex = 1;
            this.crtHienDSDiemTheoMon.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crtHienDSDiemTheoMon.Load += new System.EventHandler(this.crtHienDSDiemTheoMon_Load);
            // 
            // hienDSDiemTheoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 550);
            this.Controls.Add(this.crtHienDSDiemTheoMon);
            this.Controls.Add(this.panel1);
            this.Name = "hienDSDiemTheoMon";
            this.Text = "hienDSDiemTheoMon";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHien;
        private System.Windows.Forms.ComboBox cbxMonHoc;
        private System.Windows.Forms.TextBox txbDiemB;
        private System.Windows.Forms.TextBox txbDiemA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crtHienDSDiemTheoMon;
    }
}