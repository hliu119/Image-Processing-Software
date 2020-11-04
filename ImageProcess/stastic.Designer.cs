namespace 计算图像
{
    partial class stastic
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sbands = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxmin = new System.Windows.Forms.Label();
            this.minv = new System.Windows.Forms.Label();
            this.maxv = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comp = new System.Windows.Forms.Label();
            this.variance = new System.Windows.Forms.Label();
            this.average = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "显示";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "选择波段：";
            // 
            // sbands
            // 
            this.sbands.FormattingEnabled = true;
            this.sbands.Location = new System.Drawing.Point(88, 12);
            this.sbands.Name = "sbands";
            this.sbands.Size = new System.Drawing.Size(121, 20);
            this.sbands.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxmin);
            this.groupBox1.Controls.Add(this.minv);
            this.groupBox1.Controls.Add(this.maxv);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.d);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comp);
            this.groupBox1.Controls.Add(this.variance);
            this.groupBox1.Controls.Add(this.average);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 114);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "result";
            // 
            // maxmin
            // 
            this.maxmin.AutoSize = true;
            this.maxmin.Location = new System.Drawing.Point(82, 84);
            this.maxmin.Name = "maxmin";
            this.maxmin.Size = new System.Drawing.Size(41, 12);
            this.maxmin.TabIndex = 11;
            this.maxmin.Text = "label7";
            this.maxmin.Visible = false;
            // 
            // minv
            // 
            this.minv.AutoSize = true;
            this.minv.Location = new System.Drawing.Point(206, 55);
            this.minv.Name = "minv";
            this.minv.Size = new System.Drawing.Size(41, 12);
            this.minv.TabIndex = 10;
            this.minv.Text = "label6";
            this.minv.Visible = false;
            // 
            // maxv
            // 
            this.maxv.AutoSize = true;
            this.maxv.Location = new System.Drawing.Point(206, 27);
            this.maxv.Name = "maxv";
            this.maxv.Size = new System.Drawing.Size(41, 12);
            this.maxv.TabIndex = 9;
            this.maxv.Text = "label5";
            this.maxv.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "极差：";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(141, 55);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(53, 12);
            this.d.TabIndex = 7;
            this.d.Text = "最小值：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(141, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "最大值：";
            // 
            // comp
            // 
            this.comp.AutoSize = true;
            this.comp.Location = new System.Drawing.Point(206, 84);
            this.comp.Name = "comp";
            this.comp.Size = new System.Drawing.Size(41, 12);
            this.comp.TabIndex = 5;
            this.comp.Text = "label7";
            this.comp.Visible = false;
            // 
            // variance
            // 
            this.variance.AutoSize = true;
            this.variance.Location = new System.Drawing.Point(82, 55);
            this.variance.Name = "variance";
            this.variance.Size = new System.Drawing.Size(41, 12);
            this.variance.TabIndex = 4;
            this.variance.Text = "label6";
            this.variance.Visible = false;
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.Location = new System.Drawing.Point(82, 27);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(41, 12);
            this.average.TabIndex = 3;
            this.average.Text = "label5";
            this.average.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "对比度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "方差：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "均值：";
            // 
            // stastic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 177);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sbands);
            this.Name = "stastic";
            this.Text = "统计参数";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sbands;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label comp;
        private System.Windows.Forms.Label variance;
        private System.Windows.Forms.Label average;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label maxmin;
        private System.Windows.Forms.Label minv;
        private System.Windows.Forms.Label maxv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label label10;
    }
}