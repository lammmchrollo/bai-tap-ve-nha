namespace baithuchanh1
{
    partial class Formbai1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            chkNho = new CheckBox();
            dangnhap = new Button();
            xoa = new Button();
            dung = new Button();
            bt01 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 102);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 26);
            label1.TabIndex = 0;
            label1.Text = "ten dang nhap";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 170);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 26);
            label2.TabIndex = 1;
            label2.Text = "mat khau";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(429, 95);
            txtUser.Margin = new Padding(4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(186, 33);
            txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(429, 170);
            txtPass.Margin = new Padding(4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(186, 33);
            txtPass.TabIndex = 3;
            // 
            // chkNho
            // 
            chkNho.AutoSize = true;
            chkNho.Location = new Point(238, 222);
            chkNho.Margin = new Padding(4);
            chkNho.Name = "chkNho";
            chkNho.Size = new Size(105, 30);
            chkNho.TabIndex = 4;
            chkNho.Text = "ghi nho";
            chkNho.UseVisualStyleBackColor = true;
            // 
            // dangnhap
            // 
            dangnhap.Location = new Point(298, 305);
            dangnhap.Margin = new Padding(4);
            dangnhap.Name = "dangnhap";
            dangnhap.Size = new Size(141, 36);
            dangnhap.TabIndex = 5;
            dangnhap.Text = "dang nhap";
            dangnhap.UseVisualStyleBackColor = true;
            dangnhap.Click += dangnhap_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(506, 305);
            xoa.Margin = new Padding(4);
            xoa.Name = "xoa";
            xoa.Size = new Size(141, 36);
            xoa.TabIndex = 6;
            xoa.Text = "xoa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // dung
            // 
            dung.Location = new Point(747, 305);
            dung.Margin = new Padding(4);
            dung.Name = "dung";
            dung.Size = new Size(149, 36);
            dung.TabIndex = 7;
            dung.Text = "dung";
            dung.UseVisualStyleBackColor = true;
            dung.Click += dung_Click;
            // 
            // bt01
            // 
            bt01.Location = new Point(1041, 462);
            bt01.Name = "bt01";
            bt01.Size = new Size(147, 39);
            bt01.TabIndex = 8;
            bt01.Text = "thongbao";
            bt01.UseVisualStyleBackColor = true;
            bt01.Click += bt01_Click;
            // 
            // Formbai1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 562);
            Controls.Add(bt01);
            Controls.Add(dung);
            Controls.Add(xoa);
            Controls.Add(dangnhap);
            Controls.Add(chkNho);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Formbai1";
            Text = "tendangnhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPass;
        private CheckBox chkNho;
        private Button dangnhap;
        private Button xoa;
        private Button dung;
        private Button bt01;
    }
}
