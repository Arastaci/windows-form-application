namespace CircleCalculatorApp
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
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.circlePicture = new System.Windows.Forms.PictureBox();
            this.lblRadiusValue = new System.Windows.Forms.Label();
            this.lblAreaResult = new System.Windows.Forms.Label();
            this.lblCircumferenceResult = new System.Windows.Forms.Label();
            this.btnCalculateArea = new System.Windows.Forms.Button();
            this.btnCalculateCircumference = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblRadius = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.circlePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(106, 164);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(193, 20);
            this.txtRadius.TabIndex = 0;
            this.txtRadius.TextChanged += new System.EventHandler(this.txtRadius_TextChanged);
            // 
            // circlePicture
            // 
            this.circlePicture.BackgroundImage = global::CircleCalculatorApp.Properties.Resources.circlePicture;
            this.circlePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circlePicture.Location = new System.Drawing.Point(492, 41);
            this.circlePicture.Name = "circlePicture";
            this.circlePicture.Size = new System.Drawing.Size(169, 161);
            this.circlePicture.TabIndex = 1;
            this.circlePicture.TabStop = false;
            // 
            // lblRadiusValue
            // 
            this.lblRadiusValue.AutoSize = true;
            this.lblRadiusValue.Location = new System.Drawing.Point(573, 116);
            this.lblRadiusValue.Name = "lblRadiusValue";
            this.lblRadiusValue.Size = new System.Drawing.Size(10, 13);
            this.lblRadiusValue.TabIndex = 2;
            this.lblRadiusValue.Text = "r";
            // 
            // lblAreaResult
            // 
            this.lblAreaResult.AutoSize = true;
            this.lblAreaResult.Location = new System.Drawing.Point(103, 296);
            this.lblAreaResult.Name = "lblAreaResult";
            this.lblAreaResult.Size = new System.Drawing.Size(35, 13);
            this.lblAreaResult.TabIndex = 3;
            this.lblAreaResult.Text = "Area: ";
            // 
            // lblCircumferenceResult
            // 
            this.lblCircumferenceResult.AutoSize = true;
            this.lblCircumferenceResult.Location = new System.Drawing.Point(317, 296);
            this.lblCircumferenceResult.Name = "lblCircumferenceResult";
            this.lblCircumferenceResult.Size = new System.Drawing.Size(81, 13);
            this.lblCircumferenceResult.TabIndex = 4;
            this.lblCircumferenceResult.Text = "Circumference: ";
            // 
            // btnCalculateArea
            // 
            this.btnCalculateArea.Location = new System.Drawing.Point(106, 237);
            this.btnCalculateArea.Name = "btnCalculateArea";
            this.btnCalculateArea.Size = new System.Drawing.Size(144, 23);
            this.btnCalculateArea.TabIndex = 5;
            this.btnCalculateArea.Text = "Calculate Area";
            this.btnCalculateArea.UseVisualStyleBackColor = true;
            this.btnCalculateArea.Click += new System.EventHandler(this.btnCalculateArea_Click_1);
            // 
            // btnCalculateCircumference
            // 
            this.btnCalculateCircumference.Location = new System.Drawing.Point(320, 237);
            this.btnCalculateCircumference.Name = "btnCalculateCircumference";
            this.btnCalculateCircumference.Size = new System.Drawing.Size(144, 23);
            this.btnCalculateCircumference.TabIndex = 6;
            this.btnCalculateCircumference.Text = "Calculate Circumference";
            this.btnCalculateCircumference.UseVisualStyleBackColor = true;
            this.btnCalculateCircumference.Click += new System.EventHandler(this.btnCalculateCircumference_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(517, 237);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(103, 129);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(83, 13);
            this.lblRadius.TabIndex = 8;
            this.lblRadius.Text = "Enter Radius (r):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateCircumference);
            this.Controls.Add(this.btnCalculateArea);
            this.Controls.Add(this.lblCircumferenceResult);
            this.Controls.Add(this.lblAreaResult);
            this.Controls.Add(this.lblRadiusValue);
            this.Controls.Add(this.circlePicture);
            this.Controls.Add(this.txtRadius);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.circlePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.PictureBox circlePicture;
        private System.Windows.Forms.Label lblRadiusValue;
        private System.Windows.Forms.Label lblAreaResult;
        private System.Windows.Forms.Label lblCircumferenceResult;
        private System.Windows.Forms.Button btnCalculateArea;
        private System.Windows.Forms.Button btnCalculateCircumference;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblRadius;
    }
}

