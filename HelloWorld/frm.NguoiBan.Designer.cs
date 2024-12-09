namespace HelloWorld
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
            Label label3;
            label1 = new Label();
            label2 = new Label();
            txtMaNB = new TextBox();
            txtTenNB = new TextBox();
            label4 = new Label();
            txtDiaChi = new TextBox();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 166);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 3;
            label3.Text = "Tên Người Bán";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 46);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Bảng người bán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 114);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã Người Bán";
            // 
            // txtMaNB
            // 
            txtMaNB.Location = new Point(202, 107);
            txtMaNB.Name = "txtMaNB";
            txtMaNB.Size = new Size(125, 27);
            txtMaNB.TabIndex = 0;
            // 
            // txtTenNB
            // 
            txtTenNB.Location = new Point(202, 166);
            txtTenNB.Name = "txtTenNB";
            txtTenNB.Size = new Size(225, 27);
            txtTenNB.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 222);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 5;
            label4.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(202, 226);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(375, 27);
            txtDiaChi.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(125, 293);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(340, 293);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 8;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(547, 293);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 360);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 221);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 593);
            Controls.Add(dataGridView1);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(txtDiaChi);
            Controls.Add(label4);
            Controls.Add(txtTenNB);
            Controls.Add(label3);
            Controls.Add(txtMaNB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Người Bán";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMaNB;
        private TextBox txtTenNB;
        private Label label4;
        private TextBox txtDiaChi;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoa;
        private DataGridView dataGridView1;
    }
}
