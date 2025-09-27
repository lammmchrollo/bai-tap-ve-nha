namespace baitapthuchanh4
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
            radTru = new RadioButton();
            radChia = new RadioButton();
            groupBox1 = new GroupBox();
            radNhan = new RadioButton();
            radCong = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSo1 = new TextBox();
            txtKQ = new TextBox();
            txtSo2 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radTru
            // 
            radTru.AutoSize = true;
            radTru.Location = new Point(139, 63);
            radTru.Name = "radTru";
            radTru.Size = new Size(51, 24);
            radTru.TabIndex = 1;
            radTru.TabStop = true;
            radTru.Text = "Trừ";
            radTru.UseVisualStyleBackColor = true;
            radTru.CheckedChanged += radTru_CheckedChanged;
            // 
            // radChia
            // 
            radChia.AutoSize = true;
            radChia.Location = new Point(435, 63);
            radChia.Name = "radChia";
            radChia.Size = new Size(57, 24);
            radChia.TabIndex = 2;
            radChia.TabStop = true;
            radChia.Text = "chia";
            radChia.UseVisualStyleBackColor = true;
            radChia.CheckedChanged += radChia_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radNhan);
            groupBox1.Controls.Add(radCong);
            groupBox1.Controls.Add(radTru);
            groupBox1.Controls.Add(radChia);
            groupBox1.Location = new Point(115, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(558, 116);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Phép tính";
            // 
            // radNhan
            // 
            radNhan.AutoSize = true;
            radNhan.Location = new Point(278, 63);
            radNhan.Name = "radNhan";
            radNhan.Size = new Size(65, 24);
            radNhan.TabIndex = 4;
            radNhan.TabStop = true;
            radNhan.Text = "Nhân";
            radNhan.UseVisualStyleBackColor = true;
            radNhan.CheckedChanged += radNhan_CheckedChanged;
            // 
            // radCong
            // 
            radCong.AutoSize = true;
            radCong.Location = new Point(16, 63);
            radCong.Name = "radCong";
            radCong.Size = new Size(65, 24);
            radCong.TabIndex = 3;
            radCong.TabStop = true;
            radCong.Text = "Cộng";
            radCong.UseVisualStyleBackColor = true;
            radCong.CheckedChanged += radCong_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 47);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 5;
            label1.Text = "Số 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 109);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 6;
            label2.Text = "Số 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 314);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 7;
            label3.Text = "Kết Quả:";
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(211, 44);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(462, 27);
            txtSo1.TabIndex = 8;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(211, 307);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(462, 27);
            txtKQ.TabIndex = 10;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(211, 109);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(462, 27);
            txtSo2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 391);
            Controls.Add(txtSo2);
            Controls.Add(txtKQ);
            Controls.Add(txtSo1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton radTru;
        private RadioButton radChia;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSo1;
        private TextBox txtKQ;
        private RadioButton radNhan;
        private RadioButton radCong;
        private TextBox txtSo2;
    }
}
