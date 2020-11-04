namespace 计算图像
{
    partial class Logistic
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonDengyu = new System.Windows.Forms.RadioButton();
            this.radioButtonXiaoyu = new System.Windows.Forms.RadioButton();
            this.radioButtonDayu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 24);
            this.button1.TabIndex = 21;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "波段2：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "波段1：";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(82, 179);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "选择数据：";
            // 
            // radioButtonDengyu
            // 
            this.radioButtonDengyu.AutoSize = true;
            this.radioButtonDengyu.Location = new System.Drawing.Point(166, 56);
            this.radioButtonDengyu.Name = "radioButtonDengyu";
            this.radioButtonDengyu.Size = new System.Drawing.Size(47, 16);
            this.radioButtonDengyu.TabIndex = 14;
            this.radioButtonDengyu.TabStop = true;
            this.radioButtonDengyu.Text = "等于";
            this.radioButtonDengyu.UseVisualStyleBackColor = true;
            this.radioButtonDengyu.CheckedChanged += new System.EventHandler(this.radioButtonDengyu_CheckedChanged);
            // 
            // radioButtonXiaoyu
            // 
            this.radioButtonXiaoyu.AutoSize = true;
            this.radioButtonXiaoyu.Location = new System.Drawing.Point(98, 56);
            this.radioButtonXiaoyu.Name = "radioButtonXiaoyu";
            this.radioButtonXiaoyu.Size = new System.Drawing.Size(47, 16);
            this.radioButtonXiaoyu.TabIndex = 13;
            this.radioButtonXiaoyu.TabStop = true;
            this.radioButtonXiaoyu.Text = "小于";
            this.radioButtonXiaoyu.UseVisualStyleBackColor = true;
            this.radioButtonXiaoyu.CheckedChanged += new System.EventHandler(this.radioButtonXiaoyu_CheckedChanged);
            // 
            // radioButtonDayu
            // 
            this.radioButtonDayu.AutoSize = true;
            this.radioButtonDayu.Location = new System.Drawing.Point(31, 56);
            this.radioButtonDayu.Name = "radioButtonDayu";
            this.radioButtonDayu.Size = new System.Drawing.Size(47, 16);
            this.radioButtonDayu.TabIndex = 12;
            this.radioButtonDayu.TabStop = true;
            this.radioButtonDayu.Text = "大于";
            this.radioButtonDayu.UseVisualStyleBackColor = true;
            this.radioButtonDayu.CheckedChanged += new System.EventHandler(this.radioButtonDayu_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "运算类型：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 22;
            // 
            // Logistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 269);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonDengyu);
            this.Controls.Add(this.radioButtonXiaoyu);
            this.Controls.Add(this.radioButtonDayu);
            this.Controls.Add(this.label1);
            this.Name = "Logistic";
            this.Text = "逻辑运算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonDengyu;
        private System.Windows.Forms.RadioButton radioButtonXiaoyu;
        private System.Windows.Forms.RadioButton radioButtonDayu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}