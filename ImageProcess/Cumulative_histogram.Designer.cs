namespace 计算图像
{
    partial class Cumulative_histogram
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
            this.ch_bt = new System.Windows.Forms.Button();
            this.ch_panel = new System.Windows.Forms.Panel();
            this.ch_cB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ch_bt
            // 
            this.ch_bt.Location = new System.Drawing.Point(290, 21);
            this.ch_bt.Name = "ch_bt";
            this.ch_bt.Size = new System.Drawing.Size(100, 23);
            this.ch_bt.TabIndex = 7;
            this.ch_bt.Text = "显示累计直方图";
            this.ch_bt.UseVisualStyleBackColor = true;
            this.ch_bt.Click += new System.EventHandler(this.ch_bt_Click);
            // 
            // ch_panel
            // 
            this.ch_panel.Location = new System.Drawing.Point(16, 63);
            this.ch_panel.Name = "ch_panel";
            this.ch_panel.Size = new System.Drawing.Size(374, 259);
            this.ch_panel.TabIndex = 6;
            this.ch_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.ch_panel_Paint);
            // 
            // ch_cB
            // 
            this.ch_cB.FormattingEnabled = true;
            this.ch_cB.Location = new System.Drawing.Point(129, 22);
            this.ch_cB.Name = "ch_cB";
            this.ch_cB.Size = new System.Drawing.Size(121, 20);
            this.ch_cB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "选择波段：";
            // 
            // Cumulative_histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 340);
            this.Controls.Add(this.ch_bt);
            this.Controls.Add(this.ch_panel);
            this.Controls.Add(this.ch_cB);
            this.Controls.Add(this.label1);
            this.Name = "Cumulative_histogram";
            this.Text = "累计直方图";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ch_bt;
        private System.Windows.Forms.Panel ch_panel;
        private System.Windows.Forms.ComboBox ch_cB;
        private System.Windows.Forms.Label label1;
    }
}