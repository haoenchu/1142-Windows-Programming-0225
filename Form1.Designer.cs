namespace _0225
{
    partial class frmBMI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBMI));
            this.output_BMI = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.caculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // output_BMI
            // 
            this.output_BMI.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.output_BMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.output_BMI.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.output_BMI.ForeColor = System.Drawing.Color.Black;
            this.output_BMI.Location = new System.Drawing.Point(258, 95);
            this.output_BMI.Name = "output_BMI";
            this.output_BMI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.output_BMI.Size = new System.Drawing.Size(222, 29);
            this.output_BMI.TabIndex = 3;
            this.output_BMI.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(252, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "你的BMI : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(59, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "身高(cm)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(61, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "體重(kg)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.White;
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeight.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtWeight.ForeColor = System.Drawing.Color.Gray;
            this.txtWeight.Location = new System.Drawing.Point(68, 209);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(132, 30);
            this.txtWeight.TabIndex = 1;
            this.txtWeight.Text = "請輸入體重";
            this.txtWeight.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtWeight.Enter += new System.EventHandler(this.txtWeight_Entry);
            this.txtWeight.Leave += new System.EventHandler(this.txtWeight_Leave);
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.Color.White;
            this.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeight.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHeight.ForeColor = System.Drawing.Color.Gray;
            this.txtHeight.Location = new System.Drawing.Point(66, 94);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHeight.Size = new System.Drawing.Size(134, 30);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.Text = "請輸入身高";
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            this.txtHeight.Enter += new System.EventHandler(this.txtHeight_Entry);
            this.txtHeight.Leave += new System.EventHandler(this.txtHeight_Leave);
            // 
            // caculate
            // 
            this.caculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.caculate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.caculate.ForeColor = System.Drawing.Color.Black;
            this.caculate.Location = new System.Drawing.Point(66, 299);
            this.caculate.Name = "caculate";
            this.caculate.Size = new System.Drawing.Size(89, 42);
            this.caculate.TabIndex = 2;
            this.caculate.Text = "計算";
            this.caculate.UseVisualStyleBackColor = false;
            this.caculate.Click += new System.EventHandler(this.caculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(252, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "警語:";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(573, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelWarning
            // 
            this.labelWarning.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelWarning.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWarning.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelWarning.ForeColor = System.Drawing.Color.Black;
            this.labelWarning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelWarning.Location = new System.Drawing.Point(258, 210);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(222, 56);
            this.labelWarning.TabIndex = 7;
            this.labelWarning.Text = "                                   ";
            this.labelWarning.Click += new System.EventHandler(this.label5_Click);
            // 
            // frmBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1129, 450);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.output_BMI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.caculate);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "frmBMI";
            this.Text = "BMI計算機";
            this.Load += new System.EventHandler(this.frmBMI_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmBMI_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label output_BMI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button caculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label labelWarning;
    }
}

