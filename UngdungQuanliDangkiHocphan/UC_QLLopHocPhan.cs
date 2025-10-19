using System;
using System.Drawing;
using System.Windows.Forms;

namespace UngdungQuanliDangkiHocphan
{
    public partial class UC_QLLopHocPhan : UserControl
    {
        private Panel panelTop, panelBottom;
        private TextBox txtTimKiem, txtMaLopHP, txtMaHP, txtGiangVien, txtSiSo;
        private Button btnThem, btnSua, btnXoa, btnLuu, btnHuy;
        private DataGridView dgvLopHocPhan;
        private Label lblMaLopHP, lblMaHP, lblGiangVien, lblSiSo;

        public UC_QLLopHocPhan()
        {
            InitializeComponent();
            BuildUI();
        }

        private void UC_QLLopHocPhan_Load(object sender, EventArgs e)
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
            dgvLopHocPhan = new DataGridView()
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            dgvLopHocPhan.Columns.Add("MaLopHP", "Mã lớp học phần");
            dgvLopHocPhan.Columns.Add("MaHP", "Mã học phần");
            dgvLopHocPhan.Columns.Add("GiangVien", "Giảng viên phụ trách");
            dgvLopHocPhan.Columns.Add("SiSo", "Sĩ số tối đa");

            // ===== Panel Bottom =====
            panelBottom = new Panel()
            {
                Dock = DockStyle.Bottom,
                Height = 140,
                BackColor = Color.FromArgb(240, 245, 255)
            };

            lblMaLopHP = CreateLabel("Mã lớp học phần:", 20, 20);
            lblMaHP = CreateLabel("Mã học phần:", 20, 60);
            lblGiangVien = CreateLabel("Giảng viên:", 400, 20);
            lblSiSo = CreateLabel("Sĩ số tối đa:", 400, 60);

            txtMaLopHP = CreateTextBox(150, 20);
            txtMaHP = CreateTextBox(150, 60);
            txtGiangVien = CreateTextBox(520, 20);
            txtSiSo = CreateTextBox(520, 60);

            panelBottom.Controls.AddRange(new Control[] {
                lblMaLopHP, txtMaLopHP,
                lblMaHP, txtMaHP,
                lblGiangVien, txtGiangVien,
                lblSiSo, txtSiSo
            });

            this.Controls.Add(dgvLopHocPhan);
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
                Width = 150,
                Font = new Font("Segoe UI", 10)
            };
        }

        private TextBox CreateTextBox(int left, int top)
        {
            return new TextBox() { Left = left, Top = top, Width = 230 };
        }
    }
}
