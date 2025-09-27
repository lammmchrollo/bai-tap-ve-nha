namespace baithuchanh1
{
    public partial class Formbai1 : Form
    {
        public Formbai1()
        {
            InitializeComponent();
        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên ??ng nh?p là: ";
            thongbao += this.txtUser.Text;
            thongbao += "\n\rM?t kh?u là: ";
            thongbao += this.txtPass.Text;
            if (this.chkNho.Checked == true)

            { thongbao += "\n\rB?n có ghi nh?."; }
            MessageBox.Show(thongbao, "Thông báo");
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            this.txtUser.Clear(); this.txtPass.Clear(); this.txtUser.Focus();
        }

        private void dung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt01_Click(object sender, EventArgs e)
        {
            MessageBox.Show("thong bao");
        }
    }
}
