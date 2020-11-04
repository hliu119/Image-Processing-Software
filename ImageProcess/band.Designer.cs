namespace 计算图像
{
    partial class band
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
            this.label1 = new System.Windows.Forms.Label();
            this.setgray = new System.Windows.Forms.RadioButton();
            this.setrgb = new System.Windows.Forms.RadioButton();
            this.rgb = new System.Windows.Forms.Panel();
            this.bband = new System.Windows.Forms.ComboBox();
            this.gband = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rband = new System.Windows.Forms.ComboBox();
            this.showimg = new System.Windows.Forms.Button();
            this.gray = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.grayband = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rgb.SuspendLayout();
            this.gray.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // setgray
            // 
            this.setgray.AutoSize = true;
            this.setgray.Checked = true;
            this.setgray.Location = new System.Drawing.Point(21, 114);
            this.setgray.Name = "setgray";
            this.setgray.Size = new System.Drawing.Size(71, 16);
            this.setgray.TabIndex = 1;
            this.setgray.TabStop = true;
            this.setgray.Text = "灰度图像";
            this.setgray.UseVisualStyleBackColor = true;
            this.setgray.CheckedChanged += new System.EventHandler(this.setgray_CheckedChanged);
            // 
            // setrgb
            // 
            this.setrgb.AutoSize = true;
            this.setrgb.Location = new System.Drawing.Point(129, 114);
            this.setrgb.Name = "setrgb";
            this.setrgb.Size = new System.Drawing.Size(71, 16);
            this.setrgb.TabIndex = 2;
            this.setrgb.Text = "彩色图像";
            this.setrgb.UseVisualStyleBackColor = true;
            // 
            // rgb
            // 
            this.rgb.Controls.Add(this.bband);
            this.rgb.Controls.Add(this.gband);
            this.rgb.Controls.Add(this.label4);
            this.rgb.Controls.Add(this.label3);
            this.rgb.Controls.Add(this.label2);
            this.rgb.Controls.Add(this.rband);
            this.rgb.Location = new System.Drawing.Point(9, 136);
            this.rgb.Name = "rgb";
            this.rgb.Size = new System.Drawing.Size(191, 140);
            this.rgb.TabIndex = 9;
            this.rgb.Visible = false;
            // 
            // bband
            // 
            this.bband.FormattingEnabled = true;
            this.bband.Location = new System.Drawing.Point(51, 104);
            this.bband.Name = "bband";
            this.bband.Size = new System.Drawing.Size(128, 20);
            this.bband.TabIndex = 14;
            // 
            // gband
            // 
            this.gband.FormattingEnabled = true;
            this.gband.Location = new System.Drawing.Point(51, 66);
            this.gband.Name = "gband";
            this.gband.Size = new System.Drawing.Size(128, 20);
            this.gband.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(20, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(20, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "G";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "R";
            // 
            // rband
            // 
            this.rband.FormattingEnabled = true;
            this.rband.Location = new System.Drawing.Point(51, 26);
            this.rband.Name = "rband";
            this.rband.Size = new System.Drawing.Size(128, 20);
            this.rband.TabIndex = 9;
            // 
            // showimg
            // 
            this.showimg.Location = new System.Drawing.Point(69, 296);
            this.showimg.Name = "showimg";
            this.showimg.Size = new System.Drawing.Size(75, 25);
            this.showimg.TabIndex = 10;
            this.showimg.Text = "显示";
            this.showimg.UseVisualStyleBackColor = true;
            this.showimg.Click += new System.EventHandler(this.showimg_Click);
            // 
            // gray
            // 
            this.gray.Controls.Add(this.label5);
            this.gray.Controls.Add(this.grayband);
            this.gray.Location = new System.Drawing.Point(9, 136);
            this.gray.Name = "gray";
            this.gray.Size = new System.Drawing.Size(200, 140);
            this.gray.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(15, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Band";
            // 
            // grayband
            // 
            this.grayband.FormattingEnabled = true;
            this.grayband.Location = new System.Drawing.Point(60, 52);
            this.grayband.Name = "grayband";
            this.grayband.Size = new System.Drawing.Size(128, 20);
            this.grayband.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 88);
            this.listBox1.TabIndex = 16;
            // 
            // band
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 335);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gray);
            this.Controls.Add(this.showimg);
            this.Controls.Add(this.rgb);
            this.Controls.Add(this.setrgb);
            this.Controls.Add(this.setgray);
            this.Controls.Add(this.label1);
            this.Name = "band";
            this.Text = "波段选择";
            this.rgb.ResumeLayout(false);
            this.rgb.PerformLayout();
            this.gray.ResumeLayout(false);
            this.gray.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton setgray;
        private System.Windows.Forms.RadioButton setrgb;
        private System.Windows.Forms.Panel rgb;
        private System.Windows.Forms.Panel gray;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox grayband;
        private System.Windows.Forms.ComboBox bband;
        private System.Windows.Forms.ComboBox gband;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox rband;
        private System.Windows.Forms.Button showimg;
        private System.Windows.Forms.ListBox listBox1;
    }
}