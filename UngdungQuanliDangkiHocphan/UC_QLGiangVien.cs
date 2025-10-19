using System;
using System.Drawing;
using System.Windows.Forms;

namespace UngdungQuanliDangkiHocphan
{
    public partial class UC_QLGiangVien : UserControl
    {
        private Panel panelTop, panelBottom;
        private TextBox txtTimKiem, txtMaGV, txtTenGV, txtBoMon, txtHocVi;
        private Button btnThem, btnSua, btnXoa, btnLuu, btnHuy;
        private DataGridView dgvGiangVien;
        private Label lblMaGV, lblTenGV, lblBoMon, lblHocVi;

        public UC_QLGiangVien()
        {
            InitializeComponent();
            BuildUI();
        }

        private void UC_QLGiangVien_Load(object sender, EventArgs e)
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
            dgvGiangVien = new DataGridView()
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            dgvGiangVien.Columns.Add("MaGV", "Mã giảng viên");
            dgvGiangVien.Columns.Add("TenGV", "Tên giảng viên");
            dgvGiangVien.Columns.Add("BoMon", "Bộ môn");
            dgvGiangVien.Columns.Add("HocVi", "Học vị");

            // ===== Panel Bottom =====
            panelBottom = new Panel()
            {
                Dock = DockStyle.Bottom,
                Height = 140,
                BackColor = Color.FromArgb(240, 245, 255)
            };

            lblMaGV = CreateLabel("Mã giảng viên:", 20, 20);
            lblTenGV = CreateLabel("Tên giảng viên:", 20, 60);
            lblBoMon = CreateLabel("Bộ môn:", 400, 20);
            lblHocVi = CreateLabel("Học vị:", 400, 60);

            txtMaGV = CreateTextBox(140, 20);
            txtTenGV = CreateTextBox(140, 60);
            txtBoMon = CreateTextBox(480, 20);
            txtHocVi = CreateTextBox(480, 60);

            panelBottom.Controls.AddRange(new Control[] {
                lblMaGV, txtMaGV,
                lblTenGV, txtTenGV,
                lblBoMon, txtBoMon,
                lblHocVi, txtHocVi
            });

            this.Controls.Add(dgvGiangVien);
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
