namespace 计算图像
{
    partial class OIF
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
            this.label4 = new System.Windows.Forms.Label();
            this.oif_bt = new System.Windows.Forms.Button();
            this.oif_cB3 = new System.Windows.Forms.ComboBox();
            this.oif_cB2 = new System.Windows.Forms.ComboBox();
            this.oif_cB1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oif_tB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "OIF：";
            // 
            // oif_bt
            // 
            this.oif_bt.Location = new System.Drawing.Point(73, 136);
            this.oif_bt.Name = "oif_bt";
            this.oif_bt.Size = new System.Drawing.Size(61, 23);
            this.oif_bt.TabIndex = 15;
            this.oif_bt.Text = "计算";
            this.oif_bt.UseVisualStyleBackColor = true;
            this.oif_bt.Click += new System.EventHandler(this.oif_bt_Click);
            // 
            // oif_cB3
            // 
            this.oif_cB3.FormattingEnabled = true;
            this.oif_cB3.Location = new System.Drawing.Point(94, 95);
            this.oif_cB3.Name = "oif_cB3";
            this.oif_cB3.Size = new System.Drawing.Size(85, 20);
            this.oif_cB3.TabIndex = 14;
            // 
            // oif_cB2
            // 
            this.oif_cB2.FormattingEnabled = true;
            this.oif_cB2.Location = new System.Drawing.Point(94, 58);
            this.oif_cB2.Name = "oif_cB2";
            this.oif_cB2.Size = new System.Drawing.Size(85, 20);
            this.oif_cB2.TabIndex = 13;
            // 
            // oif_cB1
            // 
            this.oif_cB1.FormattingEnabled = true;
            this.oif_cB1.Location = new System.Drawing.Point(94, 25);
            this.oif_cB1.Name = "oif_cB1";
            this.oif_cB1.Size = new System.Drawing.Size(85, 20);
            this.oif_cB1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "第3个波段：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "第2个波段：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "第1个波段：";
            // 
            // oif_tB
            // 
            this.oif_tB.AutoSize = true;
            this.oif_tB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.oif_tB.Location = new System.Drawing.Point(80, 182);
            this.oif_tB.Name = "oif_tB";
            this.oif_tB.Size = new System.Drawing.Size(0, 17);
            this.oif_tB.TabIndex = 17;
            // 
            // OIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 224);
            this.Controls.Add(this.oif_tB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oif_bt);
            this.Controls.Add(this.oif_cB3);
            this.Controls.Add(this.oif_cB2);
            this.Controls.Add(this.oif_cB1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OIF";
            this.Text = "OIF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button oif_bt;
        private System.Windows.Forms.ComboBox oif_cB3;
        private System.Windows.Forms.ComboBox oif_cB2;
        private System.Windows.Forms.ComboBox oif_cB1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label oif_tB;

    }
}