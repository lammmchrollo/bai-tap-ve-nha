namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSo.Text, out int so)) // ki?m tra nh?p ?úng s?
            {
                cboSo.Items.Add(so);   // thêm vào Combobox
                txtSo.Clear();         // xóa n?i dung textbox
                txtSo.Focus();         // ??a con tr? v? l?i textbox
            }
            else
            {
                MessageBox.Show("Vui lòng nh?p s? nguyên h?p l?!");
                txtSo.SelectAll();
                txtSo.Focus();
            }
        }

        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTinh.Items.Clear(); // xóa danh sách c?
            int so = int.Parse(cboSo.SelectedItem.ToString());

            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0) // n?u i là ??c s?
                {
                    lstTinh.Items.Add(i);
                }
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < lstTinh.Items.Count; i++)
            {
                tong += int.Parse(lstTinh.Items[i].ToString());
            }
            MessageBox.Show("T?ng các ??c s? = " + tong);
        }

        private void btnNguyenTo_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < lstTinh.Items.Count; i++)
            {
                int x = int.Parse(lstTinh.Items[i].ToString());
                if (x % 2 == 0) dem++;
            }
            MessageBox.Show("S? l??ng ??c s? ch?n = " + dem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < lstTinh.Items.Count; i++)
            {
                int x = int.Parse(lstTinh.Items[i].ToString());
                if (LaSoNguyenTo(x)) dem++;
            }
            MessageBox.Show("S? l??ng ??c s? nguyên t? = " + dem);
        }

        // Hàm ki?m tra s? nguyên t?
        private bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
