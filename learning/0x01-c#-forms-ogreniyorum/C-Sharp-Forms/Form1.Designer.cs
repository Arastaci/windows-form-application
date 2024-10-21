namespace C_Sharp_Forms
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.City = new System.Windows.Forms.Label();
            this.Select = new System.Windows.Forms.Button();
            this.citySelection = new System.Windows.Forms.GroupBox();
            this.loginPage = new System.Windows.Forms.GroupBox();
            this.Link = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.districtBox = new System.Windows.Forms.ComboBox();
            this.selectDistrict = new System.Windows.Forms.Button();
            this.district = new System.Windows.Forms.Label();
            this.citySelection.SuspendLayout();
            this.loginPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(39, 83);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(316, 30);
            this.Username.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(63, 257);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(120, 66);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Login";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(39, 170);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(316, 30);
            this.Password.TabIndex = 3;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(59, 431);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(70, 24);
            this.result.TabIndex = 5;
            this.result.Text = "Result";
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(108, 48);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(313, 32);
            this.ComboBox.TabIndex = 6;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(104, 179);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(47, 24);
            this.City.TabIndex = 7;
            this.City.Text = "City";
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(108, 104);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(82, 41);
            this.Select.TabIndex = 8;
            this.Select.Text = "Select";
            this.Select.UseVisualStyleBackColor = true;
            // 
            // citySelection
            // 
            this.citySelection.Controls.Add(this.ComboBox);
            this.citySelection.Controls.Add(this.Select);
            this.citySelection.Controls.Add(this.City);
            this.citySelection.Location = new System.Drawing.Point(530, 34);
            this.citySelection.Name = "citySelection";
            this.citySelection.Size = new System.Drawing.Size(487, 239);
            this.citySelection.TabIndex = 9;
            this.citySelection.TabStop = false;
            this.citySelection.Text = "City selection";
            // 
            // loginPage
            // 
            this.loginPage.Controls.Add(this.Link);
            this.loginPage.Controls.Add(this.Username);
            this.loginPage.Controls.Add(this.label1);
            this.loginPage.Controls.Add(this.result);
            this.loginPage.Controls.Add(this.btnGiris);
            this.loginPage.Controls.Add(this.label2);
            this.loginPage.Controls.Add(this.Password);
            this.loginPage.Location = new System.Drawing.Point(16, 12);
            this.loginPage.Name = "loginPage";
            this.loginPage.Size = new System.Drawing.Size(400, 513);
            this.loginPage.TabIndex = 10;
            this.loginPage.TabStop = false;
            this.loginPage.Text = "Login page";
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Location = new System.Drawing.Point(196, 431);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(57, 24);
            this.Link.TabIndex = 12;
            this.Link.TabStop = true;
            this.Link.Text = "Link";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.districtBox);
            this.groupBox1.Controls.Add(this.selectDistrict);
            this.groupBox1.Controls.Add(this.district);
            this.groupBox1.Location = new System.Drawing.Point(530, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 239);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "District selection";
            // 
            // districtBox
            // 
            this.districtBox.FormattingEnabled = true;
            this.districtBox.Location = new System.Drawing.Point(108, 48);
            this.districtBox.Name = "districtBox";
            this.districtBox.Size = new System.Drawing.Size(313, 32);
            this.districtBox.TabIndex = 6;
            // 
            // selectDistrict
            // 
            this.selectDistrict.Location = new System.Drawing.Point(108, 104);
            this.selectDistrict.Name = "selectDistrict";
            this.selectDistrict.Size = new System.Drawing.Size(82, 41);
            this.selectDistrict.TabIndex = 8;
            this.selectDistrict.Text = "Select";
            this.selectDistrict.UseVisualStyleBackColor = true;
            // 
            // district
            // 
            this.district.AutoSize = true;
            this.district.Location = new System.Drawing.Point(104, 179);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(82, 24);
            this.district.TabIndex = 7;
            this.district.Text = "District";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loginPage);
            this.Controls.Add(this.citySelection);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.citySelection.ResumeLayout(false);
            this.citySelection.PerformLayout();
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.GroupBox citySelection;
        private System.Windows.Forms.GroupBox loginPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox districtBox;
        private System.Windows.Forms.Button selectDistrict;
        private System.Windows.Forms.Label district;
        private System.Windows.Forms.LinkLabel Link;
    }
}

