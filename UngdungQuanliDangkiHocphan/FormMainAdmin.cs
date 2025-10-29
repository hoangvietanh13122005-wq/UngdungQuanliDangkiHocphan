﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngdungQuanliDangkiHocphan
{
    public partial class FormMainAdmin : Form
    {
        public FormMainAdmin()
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl uc)
        {
            panelmain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelmain.Controls.Add(uc);
        }
        private void FormMainAdmin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            LoadUserControl(new UC_QLHocPhan());
        }
        private void btnlophocphan_Click(object sender, EventArgs e)
        {
            var ucLopHocPhan = new UC_QLLopHocPhan();
            // Gắn event mở UC_XepLopHocPhan
            ucLopHocPhan.MoUCXepLopHocPhan += () =>
            {
                LoadUserControl(new UC_XepLopHocPhan());
            };
            LoadUserControl(ucLopHocPhan);
        }


        private void lblma_Click(object sender, EventArgs e)
        {

        }

        private void btnhocphan_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_QLHocPhan());
        }

        private void btnsinhvien_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_QLSinhVien());
        }

        private void btngiangvien_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_QLGiangVien());
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
         
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblten_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
