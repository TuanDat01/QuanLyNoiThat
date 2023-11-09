namespace GUI
{
    partial class frmBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fpnChiTietDon = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fpnHang = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 47);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(649, 47);
            this.panel6.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(435, 27);
            this.textBox1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnSuaKH);
            this.panel5.Controls.Add(this.btnThemKhachHang);
            this.panel5.Controls.Add(this.lbKhachHang);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(649, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(423, 47);
            this.panel5.TabIndex = 0;
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSuaKH.BackgroundImage = global::GUI.Properties.Resources.pen;
            this.btnSuaKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSuaKH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSuaKH.FlatAppearance.BorderSize = 0;
            this.btnSuaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaKH.Location = new System.Drawing.Point(357, 3);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(54, 38);
            this.btnSuaKH.TabIndex = 2;
            this.btnSuaKH.UseVisualStyleBackColor = false;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThemKhachHang.BackgroundImage = global::GUI.Properties.Resources.add__2_;
            this.btnThemKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemKhachHang.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThemKhachHang.FlatAppearance.BorderSize = 0;
            this.btnThemKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKhachHang.Location = new System.Drawing.Point(301, 3);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(54, 38);
            this.btnThemKhachHang.TabIndex = 1;
            this.btnThemKhachHang.UseVisualStyleBackColor = false;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.Location = new System.Drawing.Point(20, 16);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(96, 19);
            this.lbKhachHang.TabIndex = 0;
            this.lbKhachHang.Text = "Khách hàng: ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.fpnChiTietDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(649, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 487);
            this.panel2.TabIndex = 1;
            // 
            // fpnChiTietDon
            // 
            this.fpnChiTietDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpnChiTietDon.Location = new System.Drawing.Point(0, 0);
            this.fpnChiTietDon.Name = "fpnChiTietDon";
            this.fpnChiTietDon.Size = new System.Drawing.Size(421, 311);
            this.fpnChiTietDon.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.fpnHang);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(649, 487);
            this.panel3.TabIndex = 2;
            // 
            // fpnHang
            // 
            this.fpnHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpnHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnHang.Location = new System.Drawing.Point(0, 54);
            this.fpnHang.Name = "fpnHang";
            this.fpnHang.Size = new System.Drawing.Size(649, 433);
            this.fpnHang.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(649, 54);
            this.panel4.TabIndex = 0;
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 534);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBanHang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel fpnHang;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.FlowLayoutPanel fpnChiTietDon;
    }
}