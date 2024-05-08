
namespace BTL_2023_c
{
    partial class QlyTK
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
            this.btnTHem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.dtgTk = new System.Windows.Forms.DataGridView();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(60, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(63, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại tài khoản:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(63, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // btnTHem
            // 
            this.btnTHem.Location = new System.Drawing.Point(66, 231);
            this.btnTHem.Name = "btnTHem";
            this.btnTHem.Size = new System.Drawing.Size(75, 23);
            this.btnTHem.TabIndex = 3;
            this.btnTHem.Text = "Thêm";
            this.btnTHem.UseVisualStyleBackColor = true;
            this.btnTHem.Click += new System.EventHandler(this.btnTHem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(321, 231);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(193, 231);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 5;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(202, 56);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(299, 22);
            this.txbUserName.TabIndex = 6;
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(202, 119);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(299, 22);
            this.txbPass.TabIndex = 7;
            // 
            // dtgTk
            // 
            this.dtgTk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTk.Location = new System.Drawing.Point(529, 2);
            this.dtgTk.MultiSelect = false;
            this.dtgTk.Name = "dtgTk";
            this.dtgTk.ReadOnly = true;
            this.dtgTk.RowHeadersWidth = 51;
            this.dtgTk.RowTemplate.Height = 24;
            this.dtgTk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgTk.Size = new System.Drawing.Size(449, 310);
            this.dtgTk.TabIndex = 8;
            this.dtgTk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTk_CellClick);
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(202, 173);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(121, 24);
            this.cbLoai.TabIndex = 9;
            // 
            // QlyTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 307);
            this.Controls.Add(this.cbLoai);
            this.Controls.Add(this.dtgTk);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTHem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QlyTK";
            this.Text = "QlyTK";
            this.Load += new System.EventHandler(this.QlyTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTHem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.DataGridView dtgTk;
        private System.Windows.Forms.ComboBox cbLoai;
    }
}