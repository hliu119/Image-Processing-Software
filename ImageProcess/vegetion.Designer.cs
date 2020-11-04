namespace 计算图像
{
    partial class vegetion
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
            this.radioButtonRVI = new System.Windows.Forms.RadioButton();
            this.radioButtonNDVI = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonNDBI = new System.Windows.Forms.RadioButton();
            this.radioButtonNDWI = new System.Windows.Forms.RadioButton();
            this.radioButtonDVI = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 24);
            this.button1.TabIndex = 21;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonRVI
            // 
            this.radioButtonRVI.AutoSize = true;
            this.radioButtonRVI.Location = new System.Drawing.Point(98, 55);
            this.radioButtonRVI.Name = "radioButtonRVI";
            this.radioButtonRVI.Size = new System.Drawing.Size(41, 16);
            this.radioButtonRVI.TabIndex = 14;
            this.radioButtonRVI.TabStop = true;
            this.radioButtonRVI.Text = "RVI";
            this.radioButtonRVI.UseVisualStyleBackColor = true;
            // 
            // radioButtonNDVI
            // 
            this.radioButtonNDVI.AutoSize = true;
            this.radioButtonNDVI.Location = new System.Drawing.Point(30, 55);
            this.radioButtonNDVI.Name = "radioButtonNDVI";
            this.radioButtonNDVI.Size = new System.Drawing.Size(47, 16);
            this.radioButtonNDVI.TabIndex = 12;
            this.radioButtonNDVI.TabStop = true;
            this.radioButtonNDVI.Text = "NDVI";
            this.radioButtonNDVI.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "遥感指数：";
            // 
            // radioButtonNDBI
            // 
            this.radioButtonNDBI.AutoSize = true;
            this.radioButtonNDBI.Location = new System.Drawing.Point(97, 89);
            this.radioButtonNDBI.Name = "radioButtonNDBI";
            this.radioButtonNDBI.Size = new System.Drawing.Size(47, 16);
            this.radioButtonNDBI.TabIndex = 24;
            this.radioButtonNDBI.TabStop = true;
            this.radioButtonNDBI.Text = "NDBI";
            this.radioButtonNDBI.UseVisualStyleBackColor = true;
            // 
            // radioButtonNDWI
            // 
            this.radioButtonNDWI.AutoSize = true;
            this.radioButtonNDWI.Location = new System.Drawing.Point(30, 89);
            this.radioButtonNDWI.Name = "radioButtonNDWI";
            this.radioButtonNDWI.Size = new System.Drawing.Size(47, 16);
            this.radioButtonNDWI.TabIndex = 23;
            this.radioButtonNDWI.TabStop = true;
            this.radioButtonNDWI.Text = "NDWI";
            this.radioButtonNDWI.UseVisualStyleBackColor = true;
            // 
            // radioButtonDVI
            // 
            this.radioButtonDVI.AutoSize = true;
            this.radioButtonDVI.Location = new System.Drawing.Point(166, 55);
            this.radioButtonDVI.Name = "radioButtonDVI";
            this.radioButtonDVI.Size = new System.Drawing.Size(41, 16);
            this.radioButtonDVI.TabIndex = 15;
            this.radioButtonDVI.TabStop = true;
            this.radioButtonDVI.Text = "DVI";
            this.radioButtonDVI.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "* 主要针对 TM 遥感影像";
            // 
            // vegetion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 197);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonNDBI);
            this.Controls.Add(this.radioButtonNDWI);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonDVI);
            this.Controls.Add(this.radioButtonRVI);
            this.Controls.Add(this.radioButtonNDVI);
            this.Controls.Add(this.label1);
            this.Name = "vegetion";
            this.Text = "遥感指数";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonRVI;
        private System.Windows.Forms.RadioButton radioButtonNDVI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonNDBI;
        private System.Windows.Forms.RadioButton radioButtonNDWI;
        private System.Windows.Forms.RadioButton radioButtonDVI;
        private System.Windows.Forms.Label label2;
    }
}