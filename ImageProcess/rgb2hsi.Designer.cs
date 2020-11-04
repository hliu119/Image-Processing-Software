namespace 计算图像
{
    partial class rgb2hsi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sband2 = new System.Windows.Forms.ComboBox();
            this.sband1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sband3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 26);
            this.button1.TabIndex = 25;
            this.button1.Text = "转换";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "波段 G：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "波段 R：";
            // 
            // sband2
            // 
            this.sband2.FormattingEnabled = true;
            this.sband2.Location = new System.Drawing.Point(103, 57);
            this.sband2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sband2.Name = "sband2";
            this.sband2.Size = new System.Drawing.Size(121, 20);
            this.sband2.TabIndex = 22;
            // 
            // sband1
            // 
            this.sband1.FormattingEnabled = true;
            this.sband1.Location = new System.Drawing.Point(103, 23);
            this.sband1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sband1.Name = "sband1";
            this.sband1.Size = new System.Drawing.Size(121, 20);
            this.sband1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "波段 B：";
            // 
            // sband3
            // 
            this.sband3.FormattingEnabled = true;
            this.sband3.Location = new System.Drawing.Point(103, 93);
            this.sband3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sband3.Name = "sband3";
            this.sband3.Size = new System.Drawing.Size(121, 20);
            this.sband3.TabIndex = 27;
            // 
            // rgb2hsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 184);
            this.Controls.Add(this.sband3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sband2);
            this.Controls.Add(this.sband1);
            this.Name = "rgb2hsi";
            this.Text = "RGB转HSI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sband2;
        private System.Windows.Forms.ComboBox sband1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sband3;
    }
}