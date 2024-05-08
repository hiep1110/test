
namespace BTL_2023_c
{
    partial class Form3
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
            this.cryMonhoc = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbMaMon = new System.Windows.Forms.ComboBox();
            this.btChon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cryMonhoc
            // 
            this.cryMonhoc.ActiveViewIndex = -1;
            this.cryMonhoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryMonhoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryMonhoc.Location = new System.Drawing.Point(2, 105);
            this.cryMonhoc.Name = "cryMonhoc";
            this.cryMonhoc.Size = new System.Drawing.Size(801, 345);
            this.cryMonhoc.TabIndex = 0;
            this.cryMonhoc.Load += new System.EventHandler(this.cryMonhoc_Load);
            // 
            // cbMaMon
            // 
            this.cbMaMon.FormattingEnabled = true;
            this.cbMaMon.Location = new System.Drawing.Point(138, 29);
            this.cbMaMon.Name = "cbMaMon";
            this.cbMaMon.Size = new System.Drawing.Size(121, 24);
            this.cbMaMon.TabIndex = 1;
            // 
            // btChon
            // 
            this.btChon.Location = new System.Drawing.Point(523, 29);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(75, 23);
            this.btChon.TabIndex = 2;
            this.btChon.Text = "Chon";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btChon);
            this.Controls.Add(this.cbMaMon);
            this.Controls.Add(this.cryMonhoc);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryMonhoc;
        private System.Windows.Forms.ComboBox cbMaMon;
        private System.Windows.Forms.Button btChon;
    }
}