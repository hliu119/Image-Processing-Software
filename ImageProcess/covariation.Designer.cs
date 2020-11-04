namespace 计算图像
{
    partial class covariation
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
            this.xiefangcha = new System.Windows.Forms.Label();
            this.rcovarilabel = new System.Windows.Forms.Label();
            this.covaritationLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.covarLabel = new System.Windows.Forms.Label();
            this.sband2 = new System.Windows.Forms.ComboBox();
            this.sband1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.xiangguan = new System.Windows.Forms.Label();
            this.多波段特征 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // xiefangcha
            // 
            this.xiefangcha.AutoSize = true;
            this.xiefangcha.Location = new System.Drawing.Point(107, 101);
            this.xiefangcha.Name = "xiefangcha";
            this.xiefangcha.Size = new System.Drawing.Size(0, 12);
            this.xiefangcha.TabIndex = 18;
            // 
            // rcovarilabel
            // 
            this.rcovarilabel.AutoSize = true;
            this.rcovarilabel.Location = new System.Drawing.Point(43, 128);
            this.rcovarilabel.Name = "rcovarilabel";
            this.rcovarilabel.Size = new System.Drawing.Size(65, 12);
            this.rcovarilabel.TabIndex = 16;
            this.rcovarilabel.Text = "相关系数：";
            // 
            // covaritationLabel
            // 
            this.covaritationLabel.AutoSize = true;
            this.covaritationLabel.Location = new System.Drawing.Point(37, 128);
            this.covaritationLabel.Name = "covaritationLabel";
            this.covaritationLabel.Size = new System.Drawing.Size(0, 12);
            this.covaritationLabel.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "波段2：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "波段1：";
            // 
            // covarLabel
            // 
            this.covarLabel.AutoSize = true;
            this.covarLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.covarLabel.Location = new System.Drawing.Point(54, 101);
            this.covarLabel.Name = "covarLabel";
            this.covarLabel.Size = new System.Drawing.Size(53, 12);
            this.covarLabel.TabIndex = 12;
            this.covarLabel.Text = "协方差：";
            // 
            // sband2
            // 
            this.sband2.FormattingEnabled = true;
            this.sband2.Location = new System.Drawing.Point(83, 49);
            this.sband2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sband2.Name = "sband2";
            this.sband2.Size = new System.Drawing.Size(121, 20);
            this.sband2.TabIndex = 11;
            // 
            // sband1
            // 
            this.sband1.FormattingEnabled = true;
            this.sband1.Location = new System.Drawing.Point(83, 18);
            this.sband1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sband1.Name = "sband1";
            this.sband1.Size = new System.Drawing.Size(121, 20);
            this.sband1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xiangguan
            // 
            this.xiangguan.AutoSize = true;
            this.xiangguan.Location = new System.Drawing.Point(111, 128);
            this.xiangguan.Name = "xiangguan";
            this.xiangguan.Size = new System.Drawing.Size(0, 12);
            this.xiangguan.TabIndex = 21;
            // 
            // 多波段特征
            // 
            this.多波段特征.Location = new System.Drawing.Point(25, 77);
            this.多波段特征.Name = "多波段特征";
            this.多波段特征.Size = new System.Drawing.Size(253, 78);
            this.多波段特征.TabIndex = 22;
            this.多波段特征.TabStop = false;
            // 
            // covariation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 164);
            this.Controls.Add(this.xiangguan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xiefangcha);
            this.Controls.Add(this.rcovarilabel);
            this.Controls.Add(this.covaritationLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.covarLabel);
            this.Controls.Add(this.sband2);
            this.Controls.Add(this.sband1);
            this.Controls.Add(this.多波段特征);
            this.Name = "covariation";
            this.Text = "多波段统计特征";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xiefangcha;
        private System.Windows.Forms.Label rcovarilabel;
        private System.Windows.Forms.Label covaritationLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label covarLabel;
        private System.Windows.Forms.ComboBox sband2;
        private System.Windows.Forms.ComboBox sband1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label xiangguan;
        private System.Windows.Forms.GroupBox 多波段特征;
    }
}