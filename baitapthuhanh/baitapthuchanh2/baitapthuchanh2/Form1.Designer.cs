namespace baitapthuchanh2
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
            txtHoTen = new TextBox();
            txtHo = new Label();
            rad1 = new RadioButton();
            rad2 = new RadioButton();
            bntXoa = new Button();
            bntKQ = new Button();
            label1 = new Label();
            txtKQ = new TextBox();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(310, 70);
            txtHoTen.Margin = new Padding(4, 3, 4, 3);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(290, 30);
            txtHoTen.TabIndex = 0;
            // 
            // txtHo
            // 
            txtHo.AutoSize = true;
            txtHo.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            txtHo.Location = new Point(61, 70);
            txtHo.Margin = new Padding(4, 0, 4, 0);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(135, 23);
            txtHo.TabIndex = 1;
            txtHo.Text = "Nhập họ và tên";
            // 
            // rad1
            // 
            rad1.AutoSize = true;
            rad1.Location = new Point(146, 198);
            rad1.Margin = new Padding(4, 3, 4, 3);
            rad1.Name = "rad1";
            rad1.Size = new Size(119, 26);
            rad1.TabIndex = 2;
            rad1.TabStop = true;
            rad1.Text = "chữ thường";
            rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            rad2.AutoSize = true;
            rad2.Location = new Point(146, 244);
            rad2.Margin = new Padding(4, 3, 4, 3);
            rad2.Name = "rad2";
            rad2.Size = new Size(146, 26);
            rad2.TabIndex = 3;
            rad2.TabStop = true;
            rad2.Text = "CHỮ IN HOA";
            rad2.UseVisualStyleBackColor = true;
            // 
            // bntXoa
            // 
            bntXoa.Location = new Point(546, 188);
            bntXoa.Margin = new Padding(4, 3, 4, 3);
            bntXoa.Name = "bntXoa";
            bntXoa.Size = new Size(54, 72);
            bntXoa.TabIndex = 4;
            bntXoa.Text = "xoa";
            bntXoa.UseVisualStyleBackColor = true;
            bntXoa.Click += bntXoa_Click;
            // 
            // bntKQ
            // 
            bntKQ.Location = new Point(67, 291);
            bntKQ.Margin = new Padding(4, 3, 4, 3);
            bntKQ.Name = "bntKQ";
            bntKQ.Size = new Size(129, 32);
            bntKQ.TabIndex = 5;
            bntKQ.Text = "Kết quả";
            bntKQ.UseVisualStyleBackColor = true;
            bntKQ.Click += bntQK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 136);
            label1.Name = "label1";
            label1.Size = new Size(132, 22);
            label1.TabIndex = 6;
            label1.Text = "Chọn Kiểu Chữ";
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(310, 293);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(290, 30);
            txtKQ.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 409);
            Controls.Add(txtKQ);
            Controls.Add(label1);
            Controls.Add(bntKQ);
            Controls.Add(bntXoa);
            Controls.Add(rad2);
            Controls.Add(rad1);
            Controls.Add(txtHo);
            Controls.Add(txtHoTen);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "doikieuchu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private Label txtHo;
        private RadioButton rad1;
        private RadioButton rad2;
        private Button bntXoa;
        private Button bntKQ;
        private Label label1;
        private TextBox txtKQ;
    }
}
