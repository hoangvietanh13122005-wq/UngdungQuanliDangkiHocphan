namespace UngdungQuanliDangkiHocphan
{
    partial class ucDangKyTinChi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDKTC = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDangKyTinChi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblChuongTrinhDaoTao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboCTDT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlDKTC.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDKTC
            // 
            this.pnlDKTC.Controls.Add(this.cboCTDT);
            this.pnlDKTC.Controls.Add(this.lblChuongTrinhDaoTao);
            this.pnlDKTC.Controls.Add(this.lblDangKyTinChi);
            this.pnlDKTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDKTC.Location = new System.Drawing.Point(0, 0);
            this.pnlDKTC.Name = "pnlDKTC";
            this.pnlDKTC.Size = new System.Drawing.Size(721, 440);
            this.pnlDKTC.TabIndex = 0;
            // 
            // lblDangKyTinChi
            // 
            this.lblDangKyTinChi.AutoSize = false;
            this.lblDangKyTinChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(190)))));
            this.lblDangKyTinChi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangKyTinChi.ForeColor = System.Drawing.Color.Transparent;
            this.lblDangKyTinChi.Location = new System.Drawing.Point(13, 9);
            this.lblDangKyTinChi.Name = "lblDangKyTinChi";
            this.lblDangKyTinChi.Size = new System.Drawing.Size(289, 33);
            this.lblDangKyTinChi.TabIndex = 0;
            this.lblDangKyTinChi.Text = "ĐĂNG KÝ TÍN CHỈ";
            // 
            // lblChuongTrinhDaoTao
            // 
            this.lblChuongTrinhDaoTao.AutoSize = false;
            this.lblChuongTrinhDaoTao.BackColor = System.Drawing.Color.Transparent;
            this.lblChuongTrinhDaoTao.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuongTrinhDaoTao.Location = new System.Drawing.Point(25, 54);
            this.lblChuongTrinhDaoTao.Name = "lblChuongTrinhDaoTao";
            this.lblChuongTrinhDaoTao.Size = new System.Drawing.Size(173, 30);
            this.lblChuongTrinhDaoTao.TabIndex = 1;
            this.lblChuongTrinhDaoTao.Text = "Chương trình đào tạo";
            // 
            // cboCTDT
            // 
            this.cboCTDT.BackColor = System.Drawing.Color.Transparent;
            this.cboCTDT.BorderColor = System.Drawing.Color.DimGray;
            this.cboCTDT.BorderRadius = 15;
            this.cboCTDT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCTDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCTDT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCTDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCTDT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCTDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCTDT.ItemHeight = 30;
            this.cboCTDT.Location = new System.Drawing.Point(14, 74);
            this.cboCTDT.Name = "cboCTDT";
            this.cboCTDT.Size = new System.Drawing.Size(259, 36);
            this.cboCTDT.TabIndex = 2;
            // 
            // ucDangKyTinChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDKTC);
            this.Name = "ucDangKyTinChi";
            this.Size = new System.Drawing.Size(721, 440);
            this.pnlDKTC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlDKTC;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDangKyTinChi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblChuongTrinhDaoTao;
        private Guna.UI2.WinForms.Guna2ComboBox cboCTDT;
    }
}
