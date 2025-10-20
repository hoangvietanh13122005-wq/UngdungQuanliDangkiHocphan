namespace UngdungQuanliDangkiHocphan
{
    partial class ucTraCuuHocPhan
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTraCuuMonHoc = new Guna.UI2.WinForms.Guna2Panel();
            this.txtThongTinMonHoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLoaiTraCuu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboLoaiTraCuu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTCMH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.dgvTraCuu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlTraCuuMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTraCuuMonHoc
            // 
            this.pnlTraCuuMonHoc.Controls.Add(this.dgvTraCuu);
            this.pnlTraCuuMonHoc.Controls.Add(this.btnTimKiem);
            this.pnlTraCuuMonHoc.Controls.Add(this.txtThongTinMonHoc);
            this.pnlTraCuuMonHoc.Controls.Add(this.lblLoaiTraCuu);
            this.pnlTraCuuMonHoc.Controls.Add(this.cboLoaiTraCuu);
            this.pnlTraCuuMonHoc.Controls.Add(this.lblTCMH);
            this.pnlTraCuuMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTraCuuMonHoc.FillColor = System.Drawing.Color.White;
            this.pnlTraCuuMonHoc.Location = new System.Drawing.Point(0, 0);
            this.pnlTraCuuMonHoc.Name = "pnlTraCuuMonHoc";
            this.pnlTraCuuMonHoc.Size = new System.Drawing.Size(721, 440);
            this.pnlTraCuuMonHoc.TabIndex = 0;
            // 
            // txtThongTinMonHoc
            // 
            this.txtThongTinMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.txtThongTinMonHoc.BorderColor = System.Drawing.Color.DimGray;
            this.txtThongTinMonHoc.BorderRadius = 15;
            this.txtThongTinMonHoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThongTinMonHoc.DefaultText = "";
            this.txtThongTinMonHoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThongTinMonHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThongTinMonHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThongTinMonHoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThongTinMonHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThongTinMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtThongTinMonHoc.ForeColor = System.Drawing.Color.Black;
            this.txtThongTinMonHoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThongTinMonHoc.Location = new System.Drawing.Point(239, 73);
            this.txtThongTinMonHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThongTinMonHoc.Name = "txtThongTinMonHoc";
            this.txtThongTinMonHoc.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtThongTinMonHoc.PlaceholderText = "Nhập thông tin môn học";
            this.txtThongTinMonHoc.SelectedText = "";
            this.txtThongTinMonHoc.Size = new System.Drawing.Size(319, 45);
            this.txtThongTinMonHoc.TabIndex = 3;
            this.txtThongTinMonHoc.Tag = "";
            // 
            // lblLoaiTraCuu
            // 
            this.lblLoaiTraCuu.AutoSize = false;
            this.lblLoaiTraCuu.BackColor = System.Drawing.Color.Transparent;
            this.lblLoaiTraCuu.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiTraCuu.Location = new System.Drawing.Point(25, 54);
            this.lblLoaiTraCuu.Name = "lblLoaiTraCuu";
            this.lblLoaiTraCuu.Size = new System.Drawing.Size(133, 20);
            this.lblLoaiTraCuu.TabIndex = 2;
            this.lblLoaiTraCuu.Text = "Loại tra cứu";
            // 
            // cboLoaiTraCuu
            // 
            this.cboLoaiTraCuu.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiTraCuu.BorderColor = System.Drawing.Color.DimGray;
            this.cboLoaiTraCuu.BorderRadius = 15;
            this.cboLoaiTraCuu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiTraCuu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiTraCuu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiTraCuu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiTraCuu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoaiTraCuu.ForeColor = System.Drawing.Color.Black;
            this.cboLoaiTraCuu.ItemHeight = 30;
            this.cboLoaiTraCuu.Items.AddRange(new object[] {
            "Mã học phần",
            "Tên học phần"});
            this.cboLoaiTraCuu.Location = new System.Drawing.Point(14, 74);
            this.cboLoaiTraCuu.Name = "cboLoaiTraCuu";
            this.cboLoaiTraCuu.Size = new System.Drawing.Size(220, 36);
            this.cboLoaiTraCuu.TabIndex = 1;
            this.cboLoaiTraCuu.Tag = "";
            this.cboLoaiTraCuu.SelectedIndexChanged += new System.EventHandler(this.cboLoaiTraCuu_SelectedIndexChanged);
            // 
            // lblTCMH
            // 
            this.lblTCMH.AutoSize = false;
            this.lblTCMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(190)))));
            this.lblTCMH.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCMH.ForeColor = System.Drawing.Color.White;
            this.lblTCMH.Location = new System.Drawing.Point(13, 9);
            this.lblTCMH.Name = "lblTCMH";
            this.lblTCMH.Size = new System.Drawing.Size(330, 39);
            this.lblTCMH.TabIndex = 0;
            this.lblTCMH.Text = "TRA CỨU MÔN HỌC";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BorderColor = System.Drawing.Color.DimGray;
            this.btnTimKiem.BorderRadius = 15;
            this.btnTimKiem.BorderThickness = 1;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(190)))));
            this.btnTimKiem.Location = new System.Drawing.Point(564, 69);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(154, 49);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            // 
            // dgvTraCuu
            // 
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            this.dgvTraCuu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvTraCuu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTraCuu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTraCuu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTraCuu.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgvTraCuu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTraCuu.Location = new System.Drawing.Point(13, 128);
            this.dgvTraCuu.Name = "dgvTraCuu";
            this.dgvTraCuu.RowHeadersVisible = false;
            this.dgvTraCuu.RowHeadersWidth = 51;
            this.dgvTraCuu.RowTemplate.Height = 24;
            this.dgvTraCuu.Size = new System.Drawing.Size(699, 312);
            this.dgvTraCuu.TabIndex = 5;
            this.dgvTraCuu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTraCuu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTraCuu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTraCuu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTraCuu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTraCuu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTraCuu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTraCuu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTraCuu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTraCuu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTraCuu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTraCuu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuu.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvTraCuu.ThemeStyle.ReadOnly = false;
            this.dgvTraCuu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTraCuu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTraCuu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTraCuu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTraCuu.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTraCuu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTraCuu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ucTraCuuHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTraCuuMonHoc);
            this.Name = "ucTraCuuHocPhan";
            this.Size = new System.Drawing.Size(721, 440);
            this.pnlTraCuuMonHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTraCuuMonHoc;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTCMH;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiTraCuu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLoaiTraCuu;
        private Guna.UI2.WinForms.Guna2TextBox txtThongTinMonHoc;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTraCuu;
    }
}
