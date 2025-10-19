using System;
using System.Drawing;
using System.Windows.Forms;

namespace UngdungQuanliDangkiHocphan
{
    public partial class UC_QLSinhVien : UserControl
    {
        private Panel panelTop, panelBottom;
        private TextBox txtTimKiem, txtMaSV, txtTenSV, txtLop, txtKhoa;
        private Button btnThem, btnSua, btnXoa, btnLuu, btnHuy;
        private DataGridView dgvSinhVien;
        private Label lblMaSV, lblTenSV, lblLop, lblKhoa;

        public UC_QLSinhVien()
        {
            InitializeComponent();
            BuildUI();
        }

        private void UC_QLSinhVien_Load(object sender, EventArgs e)
        {
        }

        private void BuildUI()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.WhiteSmoke;

            // ===== Panel Top =====
            panelTop = new Panel()
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.FromArgb(230, 240, 250)
            };

            txtTimKiem = new TextBox() { Width = 250, Left = 20, Top = 15 };
            btnThem = CreateButton("Thêm", 300);
            btnSua = CreateButton("Sửa", 380);
            btnXoa = CreateButton("Xóa", 460);
            btnLuu = CreateButton("Lưu", 540);
            btnHuy = CreateButton("Hủy", 620);

            panelTop.Controls.AddRange(new Control[] { txtTimKiem, btnThem, btnSua, btnXoa, btnLuu, btnHuy });

            // ===== DataGridView =====
            dgvSinhVien = new DataGridView()
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            dgvSinhVien.Columns.Add("MaSV", "Mã sinh viên");
            dgvSinhVien.Columns.Add("TenSV", "Tên sinh viên");
            dgvSinhVien.Columns.Add("Lop", "Lớp");
            dgvSinhVien.Columns.Add("Khoa", "Khoa");

            // ===== Panel Bottom =====
            panelBottom = new Panel()
            {
                Dock = DockStyle.Bottom,
                Height = 140,
                BackColor = Color.FromArgb(240, 245, 255)
            };

            lblMaSV = CreateLabel("Mã sinh viên:", 20, 20);
            lblTenSV = CreateLabel("Tên sinh viên:", 20, 60);
            lblLop = CreateLabel("Lớp:", 400, 20);
            lblKhoa = CreateLabel("Khoa:", 400, 60);

            txtMaSV = CreateTextBox(130, 20);
            txtTenSV = CreateTextBox(130, 60);
            txtLop = CreateTextBox(460, 20);
            txtKhoa = CreateTextBox(460, 60);

            panelBottom.Controls.AddRange(new Control[] {
                lblMaSV, txtMaSV,
                lblTenSV, txtTenSV,
                lblLop, txtLop,
                lblKhoa, txtKhoa
            });

            this.Controls.Add(dgvSinhVien);
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
                Font = new Font("Segoe UI", 10)
            };
        }

        private TextBox CreateTextBox(int left, int top)
        {
            return new TextBox() { Left = left, Top = top, Width = 230 };
        }
    }
}
