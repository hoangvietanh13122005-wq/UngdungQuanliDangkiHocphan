using System;
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

        // Hàm dùng để load UserControl vào panelMain
        private void LoadUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();   // Xóa control cũ trong panel
            uc.Dock = DockStyle.Fill;     // Cho UserControl chiếm toàn bộ panel
            panelMain.Controls.Add(uc);   // Thêm vào panelMain
        }

        private void FormMainAdmin_Load(object sender, EventArgs e)
        {
            // Đặt form ở trạng thái toàn màn hình
            this.WindowState = FormWindowState.Maximized;

            // Khi mở form, hiển thị mặc định UserControl đầu tiên (nếu muốn)
            LoadUserControl(new UC_QLHocPhan());
        }

        private void btnQLHocPhan_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_QLHocPhan());
        }

        private void btnQLLopHocPhan_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_QLLopHocPhan());
        }

        private void btnQLSinhVien_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_QLSinhVien());
        }

        private void btnQLGiangVien_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_QLGiangVien());
        }

        // Nếu có sự kiện Paint thì có thể bỏ qua nếu không dùng
        private void panelMain_Paint(object sender, PaintEventArgs e) { }
        private void paneMenu_Paint(object sender, PaintEventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pblog_Click(object sender, EventArgs e)
        {
            contextMenupb.Show(pblog, new Point(0, pblog.Height));
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
