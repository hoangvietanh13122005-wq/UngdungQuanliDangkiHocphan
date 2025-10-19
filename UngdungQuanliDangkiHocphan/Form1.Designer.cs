namespace UngdungQuanliDangkiHocphan
{
    partial class FormMainAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainAdmin));
            this.paneMenu = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnQLHocPhan = new System.Windows.Forms.Button();
            this.btnQLLopHocPhan = new System.Windows.Forms.Button();
            this.btnQLSinhVien = new System.Windows.Forms.Button();
            this.btnQLGiangVien = new System.Windows.Forms.Button();
            this.panelheader = new System.Windows.Forms.Panel();
            this.lblchucnang = new System.Windows.Forms.Label();
            this.lblten = new System.Windows.Forms.Label();
            this.lblma = new System.Windows.Forms.Label();
            this.pbava = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltentruong = new System.Windows.Forms.Label();
            this.pblog = new System.Windows.Forms.PictureBox();
            this.contextMenupb = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mãSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paneMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbava)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblog)).BeginInit();
            this.contextMenupb.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneMenu
            // 
            this.paneMenu.Controls.Add(this.lblchucnang);
            this.paneMenu.Controls.Add(this.panelheader);
            this.paneMenu.Controls.Add(this.btnQLGiangVien);
            this.paneMenu.Controls.Add(this.btnQLSinhVien);
            this.paneMenu.Controls.Add(this.btnQLLopHocPhan);
            this.paneMenu.Controls.Add(this.btnQLHocPhan);
            this.paneMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneMenu.Location = new System.Drawing.Point(0, 0);
            this.paneMenu.Name = "paneMenu";
            this.paneMenu.Size = new System.Drawing.Size(200, 450);
            this.paneMenu.TabIndex = 0;
            this.paneMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.paneMenu_Paint);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(600, 450);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // btnQLHocPhan
            // 
            this.btnQLHocPhan.Location = new System.Drawing.Point(0, 224);
            this.btnQLHocPhan.Name = "btnQLHocPhan";
            this.btnQLHocPhan.Size = new System.Drawing.Size(141, 43);
            this.btnQLHocPhan.TabIndex = 0;
            this.btnQLHocPhan.Text = "Quản lí học phần";
            this.btnQLHocPhan.UseVisualStyleBackColor = true;
            this.btnQLHocPhan.Click += new System.EventHandler(this.btnQLHocPhan_Click);
            // 
            // btnQLLopHocPhan
            // 
            this.btnQLLopHocPhan.Location = new System.Drawing.Point(0, 273);
            this.btnQLLopHocPhan.Name = "btnQLLopHocPhan";
            this.btnQLLopHocPhan.Size = new System.Drawing.Size(141, 43);
            this.btnQLLopHocPhan.TabIndex = 1;
            this.btnQLLopHocPhan.Text = "Quản lí lớp học phần";
            this.btnQLLopHocPhan.UseVisualStyleBackColor = true;
            this.btnQLLopHocPhan.Click += new System.EventHandler(this.btnQLLopHocPhan_Click);
            // 
            // btnQLSinhVien
            // 
            this.btnQLSinhVien.Location = new System.Drawing.Point(0, 322);
            this.btnQLSinhVien.Name = "btnQLSinhVien";
            this.btnQLSinhVien.Size = new System.Drawing.Size(141, 43);
            this.btnQLSinhVien.TabIndex = 2;
            this.btnQLSinhVien.Text = "Quản lí sinh viên";
            this.btnQLSinhVien.UseVisualStyleBackColor = true;
            this.btnQLSinhVien.Click += new System.EventHandler(this.btnQLSinhVien_Click);
            // 
            // btnQLGiangVien
            // 
            this.btnQLGiangVien.Location = new System.Drawing.Point(0, 371);
            this.btnQLGiangVien.Name = "btnQLGiangVien";
            this.btnQLGiangVien.Size = new System.Drawing.Size(141, 43);
            this.btnQLGiangVien.TabIndex = 3;
            this.btnQLGiangVien.Text = "Quản lí giảng viên";
            this.btnQLGiangVien.UseVisualStyleBackColor = true;
            this.btnQLGiangVien.Click += new System.EventHandler(this.btnQLGiangVien_Click);
            // 
            // panelheader
            // 
            this.panelheader.Controls.Add(this.pbava);
            this.panelheader.Controls.Add(this.lblma);
            this.panelheader.Controls.Add(this.lblten);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(200, 191);
            this.panelheader.TabIndex = 0;
            this.panelheader.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblchucnang
            // 
            this.lblchucnang.AutoSize = true;
            this.lblchucnang.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchucnang.Location = new System.Drawing.Point(37, 194);
            this.lblchucnang.Name = "lblchucnang";
            this.lblchucnang.Size = new System.Drawing.Size(130, 27);
            this.lblchucnang.TabIndex = 0;
            this.lblchucnang.Text = "CHỨC NĂNG";
            this.lblchucnang.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblten.Location = new System.Drawing.Point(55, 106);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(95, 22);
            this.lblten.TabIndex = 0;
            this.lblten.Text = "Tên sinh viên";
            // 
            // lblma
            // 
            this.lblma.AutoSize = true;
            this.lblma.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblma.Location = new System.Drawing.Point(55, 133);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(91, 22);
            this.lblma.TabIndex = 1;
            this.lblma.Text = "Mã sinh viên";
            // 
            // pbava
            // 
            this.pbava.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbava.ErrorImage")));
            this.pbava.Image = ((System.Drawing.Image)(resources.GetObject("pbava.Image")));
            this.pbava.Location = new System.Drawing.Point(50, 12);
            this.pbava.Name = "pbava";
            this.pbava.Size = new System.Drawing.Size(100, 83);
            this.pbava.TabIndex = 0;
            this.pbava.TabStop = false;
            this.pbava.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pblog);
            this.panel1.Controls.Add(this.lbltentruong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 62);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // lbltentruong
            // 
            this.lbltentruong.AutoSize = true;
            this.lbltentruong.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltentruong.Location = new System.Drawing.Point(6, 9);
            this.lbltentruong.Name = "lbltentruong";
            this.lbltentruong.Size = new System.Drawing.Size(178, 33);
            this.lbltentruong.TabIndex = 0;
            this.lbltentruong.Text = "ĐẠI HỌC EC";
            // 
            // pblog
            // 
            this.pblog.ContextMenuStrip = this.contextMenupb;
            this.pblog.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pblog.ErrorImage")));
            this.pblog.Image = ((System.Drawing.Image)(resources.GetObject("pblog.Image")));
            this.pblog.Location = new System.Drawing.Point(530, 9);
            this.pblog.Name = "pblog";
            this.pblog.Size = new System.Drawing.Size(67, 39);
            this.pblog.TabIndex = 1;
            this.pblog.TabStop = false;
            this.pblog.Click += new System.EventHandler(this.pblog_Click);
            // 
            // contextMenupb
            // 
            this.contextMenupb.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenupb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mãSinhViênToolStripMenuItem,
            this.toolStripSeparator1,
            this.đăngXuấtToolStripMenuItem});
            this.contextMenupb.Name = "contextMenupb";
            this.contextMenupb.Size = new System.Drawing.Size(161, 58);
            // 
            // mãSinhViênToolStripMenuItem
            // 
            this.mãSinhViênToolStripMenuItem.Name = "mãSinhViênToolStripMenuItem";
            this.mãSinhViênToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.mãSinhViênToolStripMenuItem.Text = "Mã sinh viên";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // FormMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.paneMenu);
            this.Name = "FormMainAdmin";
            this.Text = "Quản lí đăng kí học phần";
            this.Load += new System.EventHandler(this.FormMainAdmin_Load);
            this.paneMenu.ResumeLayout(false);
            this.paneMenu.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbava)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblog)).EndInit();
            this.contextMenupb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneMenu;
        private System.Windows.Forms.Button btnQLGiangVien;
        private System.Windows.Forms.Button btnQLSinhVien;
        private System.Windows.Forms.Button btnQLLopHocPhan;
        private System.Windows.Forms.Button btnQLHocPhan;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Label lblchucnang;
        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.PictureBox pbava;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltentruong;
        private System.Windows.Forms.PictureBox pblog;
        private System.Windows.Forms.ContextMenuStrip contextMenupb;
        private System.Windows.Forms.ToolStripMenuItem mãSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}

