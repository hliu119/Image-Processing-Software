namespace 计算图像
{
    partial class GSJZ
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GSJZ_cB2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GSJZ_cB1 = new System.Windows.Forms.ComboBox();
            this.GSJZ_tBy = new System.Windows.Forms.TextBox();
            this.GSJZ_tBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(18, 151);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(402, 206);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // GSJZ_cB2
            // 
            this.GSJZ_cB2.FormattingEnabled = true;
            this.GSJZ_cB2.Location = new System.Drawing.Point(106, 47);
            this.GSJZ_cB2.Name = "GSJZ_cB2";
            this.GSJZ_cB2.Size = new System.Drawing.Size(121, 20);
            this.GSJZ_cB2.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "选择灰度级：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "PS：由于显示方便选择压缩灰度级";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GSJZ_cB1
            // 
            this.GSJZ_cB1.FormattingEnabled = true;
            this.GSJZ_cB1.Location = new System.Drawing.Point(106, 17);
            this.GSJZ_cB1.Name = "GSJZ_cB1";
            this.GSJZ_cB1.Size = new System.Drawing.Size(121, 20);
            this.GSJZ_cB1.TabIndex = 16;
            // 
            // GSJZ_tBy
            // 
            this.GSJZ_tBy.Location = new System.Drawing.Point(320, 79);
            this.GSJZ_tBy.Name = "GSJZ_tBy";
            this.GSJZ_tBy.Size = new System.Drawing.Size(100, 21);
            this.GSJZ_tBy.TabIndex = 15;
            // 
            // GSJZ_tBx
            // 
            this.GSJZ_tBx.Location = new System.Drawing.Point(110, 79);
            this.GSJZ_tBx.Name = "GSJZ_tBx";
            this.GSJZ_tBx.Size = new System.Drawing.Size(100, 21);
            this.GSJZ_tBx.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "选择波段：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "b（y偏移量）：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "a（x偏移量）：";
            // 
            // GSJZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 377);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.GSJZ_cB2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GSJZ_cB1);
            this.Controls.Add(this.GSJZ_tBy);
            this.Controls.Add(this.GSJZ_tBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GSJZ";
            this.Text = "共生矩阵";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox GSJZ_cB2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox GSJZ_cB1;
        private System.Windows.Forms.TextBox GSJZ_tBy;
        private System.Windows.Forms.TextBox GSJZ_tBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}