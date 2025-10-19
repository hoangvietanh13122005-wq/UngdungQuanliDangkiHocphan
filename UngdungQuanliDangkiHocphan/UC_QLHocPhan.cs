using System;
using System.Drawing;
using System.Windows.Forms;

namespace UngdungQuanliDangkiHocphan
{
    public partial class UC_QLHocPhan : UserControl
    {
        private Panel panelTop, panelBottom;
        private TextBox txtTimKiem, txtMaHP, txtTenHP, txtSoTinChi, txtDieuKien;
        private Button btnThem, btnSua, btnXoa, btnLuu, btnHuy;
        private DataGridView dgvHocPhan;
        private Label lblMaHP, lblTenHP, lblSoTinChi, lblDieuKien;

        public UC_QLHocPhan()
        {
            InitializeComponent();
            BuildUI();   // Tự tạo giao diện bằng code
        }
        private void UC_QLHocPhan_Load(object sender, EventArgs e)
        {
            // Bạn có thể để trống hoặc viết code khởi tạo ở đây
        }
        private void BuildUI()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.WhiteSmoke;

            // ======= Panel Top =======
            panelTop = new Panel()
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.FromArgb(230, 240, 250)
            };

            txtTimKiem = new TextBox()
            {
                Width = 250,
                Left = 20,
                Top = 15
            };

            btnThem = CreateButton("Thêm", 300);
            btnSua = CreateButton("Sửa", 380);
            btnXoa = CreateButton("Xóa", 460);
            btnLuu = CreateButton("Lưu", 540);
            btnHuy = CreateButton("Hủy", 620);

            panelTop.Controls.AddRange(new Control[] { txtTimKiem, btnThem, btnSua, btnXoa, btnLuu, btnHuy });

            // ======= DataGridView =======
            dgvHocPhan = new DataGridView()
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            dgvHocPhan.Columns.Add("MaHP", "Mã học phần");
            dgvHocPhan.Columns.Add("TenHP", "Tên học phần");
            dgvHocPhan.Columns.Add("SoTinChi", "Số tín chỉ");
            dgvHocPhan.Columns.Add("DieuKien", "Điều kiện tiên quyết");

            // ======= Panel Bottom =======
            panelBottom = new Panel()
            {
                Dock = DockStyle.Bottom,
                Height = 140,
                BackColor = Color.FromArgb(240, 245, 255)
            };

            lblMaHP = CreateLabel("Mã học phần:", 20, 20);
            lblTenHP = CreateLabel("Tên học phần:", 20, 60);
            lblSoTinChi = CreateLabel("Số tín chỉ:", 400, 20);
            lblDieuKien = CreateLabel("Điều kiện tiên quyết:", 400, 60);

            txtMaHP = CreateTextBox(130, 20);
            txtTenHP = CreateTextBox(130, 60);
            txtSoTinChi = CreateTextBox(520, 20);
            txtDieuKien = CreateTextBox(520, 60);

            panelBottom.Controls.AddRange(new Control[] {
                lblMaHP, txtMaHP,
                lblTenHP, txtTenHP,
                lblSoTinChi, txtSoTinChi,
                lblDieuKien, txtDieuKien
            });

            // ======= Add all panels =======
            this.Controls.Add(dgvHocPhan);
            this.Controls.Add(panelBottom);
            this.Controls.Add(panelTop);
        }

        private Button CreateButton(string text, int left)
        {
            return new Button()
            {
                Text = text,
                Width = 70,
                Height = 30,
                Left = left,
                Top = 15,
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
        }

        private Label CreateLabel(string text, int left, int top)
        {
            return new Label()
            {
                Text = text,
                Left = left,
                Top = top + 3,
                Width = 140,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
        }

        private TextBox CreateTextBox(int left, int top)
        {
            return new TextBox()
            {
                Left = left,
                Top = top,
                Width = 230
            };
        }
    }
}
