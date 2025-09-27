namespace baitapthuchanh4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        // Hàm ki?m tra d? li?u nh?p có ph?i là s? không
        private bool KiemTraNhap()
        {
            if (!double.TryParse(txtSo1.Text, out _) || !double.TryParse(txtSo2.Text, out _))
            {
                MessageBox.Show("Vui lòng nh?p s? h?p l? vào S? 1 và S? 2!");
                return false;
            }
            return true;
        }

        private void radCong_CheckedChanged(object sender, EventArgs e)
        {
            if (radCong.Checked && KiemTraNhap())
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                txtKQ.Text = (so1 + so2).ToString();
            }
        }

        private void radTru_CheckedChanged(object sender, EventArgs e)
        {
            if (radTru.Checked && KiemTraNhap())
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                txtKQ.Text = (so1 - so2).ToString();
            }
        }

        private void radNhan_CheckedChanged(object sender, EventArgs e)
        {
            if (radNhan.Checked && KiemTraNhap())
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                txtKQ.Text = (so1 * so2).ToString();
            }
        }

        private void radChia_CheckedChanged(object sender, EventArgs e)
        {
            if (radChia.Checked && KiemTraNhap())
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                if (so2 == 0)
                {
                    MessageBox.Show("Không th? chia cho 0!");
                    return;
                }
                txtKQ.Text = (so1 / so2).ToString();
            }
        }
    }
}