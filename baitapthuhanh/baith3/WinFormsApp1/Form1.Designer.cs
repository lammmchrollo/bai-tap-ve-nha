namespace WinFormsApp1
{
    partial class Form1
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
            txtSo = new TextBox();
            cboSo = new ComboBox();
            lstTinh = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnCapNhat = new Button();
            btnTong = new Button();
            btnNguyenTo = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // txtSo
            // 
            txtSo.Location = new Point(165, 111);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(125, 27);
            txtSo.TabIndex = 0;
            // 
            // cboSo
            // 
            cboSo.FormattingEnabled = true;
            cboSo.Location = new Point(165, 164);
            cboSo.Name = "cboSo";
            cboSo.Size = new Size(192, 28);
            cboSo.TabIndex = 1;
            cboSo.SelectedIndexChanged += cboSo_SelectedIndexChanged;
            // 
            // lstTinh
            // 
            lstTinh.FormattingEnabled = true;
            lstTinh.Location = new Point(429, 100);
            lstTinh.Name = "lstTinh";
            lstTinh.Size = new Size(206, 104);
            lstTinh.TabIndex = 2;
            lstTinh.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 59);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 3;
            label1.Text = "nhapso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(429, 59);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 4;
            label2.Text = "danh sach cac ươc so";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(296, 104);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 40);
            btnCapNhat.TabIndex = 5;
            btnCapNhat.Text = "cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnTong
            // 
            btnTong.Location = new Point(418, 210);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(230, 29);
            btnTong.TabIndex = 6;
            btnTong.Text = "danh sách các ước số";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnNguyenTo
            // 
            btnNguyenTo.Location = new Point(418, 245);
            btnNguyenTo.Name = "btnNguyenTo";
            btnNguyenTo.Size = new Size(230, 29);
            btnNguyenTo.TabIndex = 7;
            btnNguyenTo.Text = "số lượng các ước số chẵn";
            btnNguyenTo.UseVisualStyleBackColor = true;
            btnNguyenTo.Click += btnNguyenTo_Click;
            // 
            // button4
            // 
            button4.Location = new Point(418, 280);
            button4.Name = "button4";
            button4.Size = new Size(230, 29);
            button4.TabIndex = 8;
            button4.Text = "số lượng các ước số nguyên tố";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(296, 279);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 9;
            button5.Text = "thoát";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 433);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnNguyenTo);
            Controls.Add(btnTong);
            Controls.Add(btnCapNhat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstTinh);
            Controls.Add(cboSo);
            Controls.Add(txtSo);
            Name = "Form1";
            Text = "Form1";
            Click += btnCapNhat_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSo;
        private ComboBox cboSo;
        private ListBox lstTinh;
        private Label label1;
        private Label label2;
        private Button btnCapNhat;
        private Button btnTong;
        private Button btnNguyenTo;
        private Button button4;
        private Button button5;
    }
}
