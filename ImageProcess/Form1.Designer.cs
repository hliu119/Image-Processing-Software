namespace 计算图像
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开jpg图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.显示直方图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.均值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联合直方图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.协方差ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.相关系数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.直方图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.直方图ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.累计直方图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.纹理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.极差纹理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.共生矩阵ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.图像显示与拉伸ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.直方图均衡化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.直方图规定化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.线性拉伸ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像变换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.波段运算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.代数运算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.逻辑运算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.植被指数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kT变换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBHSIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像滤波ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.均值滤波ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像分类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kMeansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最大似然法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作ToolStripMenuItem,
            this.操作ToolStripMenuItem1,
            this.图像显示与拉伸ToolStripMenuItem,
            this.图像变换ToolStripMenuItem,
            this.图像滤波ToolStripMenuItem,
            this.图像分类ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开图像ToolStripMenuItem});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.操作ToolStripMenuItem.Text = "文件";
            // 
            // 打开图像ToolStripMenuItem
            // 
            this.打开图像ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开jpg图像ToolStripMenuItem,
            this.打开ToolStripMenuItem});
            this.打开图像ToolStripMenuItem.Name = "打开图像ToolStripMenuItem";
            this.打开图像ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打开图像ToolStripMenuItem.Text = "打开图像";
            // 
            // 打开jpg图像ToolStripMenuItem
            // 
            this.打开jpg图像ToolStripMenuItem.Name = "打开jpg图像ToolStripMenuItem";
            this.打开jpg图像ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.打开jpg图像ToolStripMenuItem.Text = "jpg\\png\\bmp";
            this.打开jpg图像ToolStripMenuItem.Click += new System.EventHandler(this.打开jpg图像ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.打开ToolStripMenuItem.Text = "bsq\\bil\\bip";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 操作ToolStripMenuItem1
            // 
            this.操作ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示直方图ToolStripMenuItem,
            this.联合直方图ToolStripMenuItem,
            this.直方图ToolStripMenuItem,
            this.纹理ToolStripMenuItem});
            this.操作ToolStripMenuItem1.Name = "操作ToolStripMenuItem1";
            this.操作ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.操作ToolStripMenuItem1.Text = "统计特征";
            // 
            // 显示直方图ToolStripMenuItem
            // 
            this.显示直方图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.均值ToolStripMenuItem});
            this.显示直方图ToolStripMenuItem.Name = "显示直方图ToolStripMenuItem";
            this.显示直方图ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.显示直方图ToolStripMenuItem.Text = "单波段";
            // 
            // 均值ToolStripMenuItem
            // 
            this.均值ToolStripMenuItem.Name = "均值ToolStripMenuItem";
            this.均值ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.均值ToolStripMenuItem.Text = "基本统计参数";
            this.均值ToolStripMenuItem.Click += new System.EventHandler(this.均值ToolStripMenuItem_Click);
            // 
            // 联合直方图ToolStripMenuItem
            // 
            this.联合直方图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.协方差ToolStripMenuItem,
            this.相关系数ToolStripMenuItem});
            this.联合直方图ToolStripMenuItem.Name = "联合直方图ToolStripMenuItem";
            this.联合直方图ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.联合直方图ToolStripMenuItem.Text = "多波段";
            // 
            // 协方差ToolStripMenuItem
            // 
            this.协方差ToolStripMenuItem.Name = "协方差ToolStripMenuItem";
            this.协方差ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.协方差ToolStripMenuItem.Text = "协方差";
            this.协方差ToolStripMenuItem.Click += new System.EventHandler(this.协方差ToolStripMenuItem_Click);
            // 
            // 相关系数ToolStripMenuItem
            // 
            this.相关系数ToolStripMenuItem.Name = "相关系数ToolStripMenuItem";
            this.相关系数ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.相关系数ToolStripMenuItem.Text = "相关系数";
            this.相关系数ToolStripMenuItem.Click += new System.EventHandler(this.相关系数ToolStripMenuItem_Click);
            // 
            // 直方图ToolStripMenuItem
            // 
            this.直方图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.直方图ToolStripMenuItem1,
            this.累计直方图ToolStripMenuItem});
            this.直方图ToolStripMenuItem.Name = "直方图ToolStripMenuItem";
            this.直方图ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.直方图ToolStripMenuItem.Text = "直方图";
            // 
            // 直方图ToolStripMenuItem1
            // 
            this.直方图ToolStripMenuItem1.Name = "直方图ToolStripMenuItem1";
            this.直方图ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.直方图ToolStripMenuItem1.Text = "直方图";
            this.直方图ToolStripMenuItem1.Click += new System.EventHandler(this.直方图ToolStripMenuItem1_Click);
            // 
            // 累计直方图ToolStripMenuItem
            // 
            this.累计直方图ToolStripMenuItem.Name = "累计直方图ToolStripMenuItem";
            this.累计直方图ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.累计直方图ToolStripMenuItem.Text = "累计直方图";
            this.累计直方图ToolStripMenuItem.Click += new System.EventHandler(this.累计直方图ToolStripMenuItem_Click);
            // 
            // 纹理ToolStripMenuItem
            // 
            this.纹理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.极差纹理ToolStripMenuItem,
            this.共生矩阵ToolStripMenuItem1});
            this.纹理ToolStripMenuItem.Name = "纹理ToolStripMenuItem";
            this.纹理ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.纹理ToolStripMenuItem.Text = "纹理";
            // 
            // 极差纹理ToolStripMenuItem
            // 
            this.极差纹理ToolStripMenuItem.Name = "极差纹理ToolStripMenuItem";
            this.极差纹理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.极差纹理ToolStripMenuItem.Text = "极差纹理";
            this.极差纹理ToolStripMenuItem.Click += new System.EventHandler(this.极差纹理ToolStripMenuItem_Click);
            // 
            // 共生矩阵ToolStripMenuItem1
            // 
            this.共生矩阵ToolStripMenuItem1.Name = "共生矩阵ToolStripMenuItem1";
            this.共生矩阵ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.共生矩阵ToolStripMenuItem1.Text = "共生矩阵";
            this.共生矩阵ToolStripMenuItem1.Click += new System.EventHandler(this.共生矩阵ToolStripMenuItem1_Click);
            // 
            // 图像显示与拉伸ToolStripMenuItem
            // 
            this.图像显示与拉伸ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.直方图均衡化ToolStripMenuItem,
            this.直方图规定化ToolStripMenuItem,
            this.线性拉伸ToolStripMenuItem,
            this.oIFToolStripMenuItem});
            this.图像显示与拉伸ToolStripMenuItem.Name = "图像显示与拉伸ToolStripMenuItem";
            this.图像显示与拉伸ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图像显示与拉伸ToolStripMenuItem.Text = "图像显示";
            // 
            // 直方图均衡化ToolStripMenuItem
            // 
            this.直方图均衡化ToolStripMenuItem.Name = "直方图均衡化ToolStripMenuItem";
            this.直方图均衡化ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.直方图均衡化ToolStripMenuItem.Text = "直方图均衡化";
            this.直方图均衡化ToolStripMenuItem.Click += new System.EventHandler(this.直方图均衡化ToolStripMenuItem_Click);
            // 
            // 直方图规定化ToolStripMenuItem
            // 
            this.直方图规定化ToolStripMenuItem.Name = "直方图规定化ToolStripMenuItem";
            this.直方图规定化ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.直方图规定化ToolStripMenuItem.Text = "直方图规定化";
            this.直方图规定化ToolStripMenuItem.Click += new System.EventHandler(this.直方图规定化ToolStripMenuItem_Click);
            // 
            // 线性拉伸ToolStripMenuItem
            // 
            this.线性拉伸ToolStripMenuItem.Name = "线性拉伸ToolStripMenuItem";
            this.线性拉伸ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.线性拉伸ToolStripMenuItem.Text = "线性拉伸";
            this.线性拉伸ToolStripMenuItem.Click += new System.EventHandler(this.线性拉伸ToolStripMenuItem_Click);
            // 
            // oIFToolStripMenuItem
            // 
            this.oIFToolStripMenuItem.Name = "oIFToolStripMenuItem";
            this.oIFToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.oIFToolStripMenuItem.Text = "OIF";
            this.oIFToolStripMenuItem.Click += new System.EventHandler(this.oIFToolStripMenuItem_Click);
            // 
            // 图像变换ToolStripMenuItem
            // 
            this.图像变换ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.波段运算ToolStripMenuItem,
            this.kT变换ToolStripMenuItem,
            this.rGBHSIToolStripMenuItem});
            this.图像变换ToolStripMenuItem.Name = "图像变换ToolStripMenuItem";
            this.图像变换ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图像变换ToolStripMenuItem.Text = "图像变换";
            // 
            // 波段运算ToolStripMenuItem
            // 
            this.波段运算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.代数运算ToolStripMenuItem,
            this.逻辑运算ToolStripMenuItem,
            this.植被指数ToolStripMenuItem});
            this.波段运算ToolStripMenuItem.Name = "波段运算ToolStripMenuItem";
            this.波段运算ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.波段运算ToolStripMenuItem.Text = "波段运算";
            // 
            // 代数运算ToolStripMenuItem
            // 
            this.代数运算ToolStripMenuItem.Name = "代数运算ToolStripMenuItem";
            this.代数运算ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.代数运算ToolStripMenuItem.Text = "代数运算";
            this.代数运算ToolStripMenuItem.Click += new System.EventHandler(this.代数运算ToolStripMenuItem_Click);
            // 
            // 逻辑运算ToolStripMenuItem
            // 
            this.逻辑运算ToolStripMenuItem.Name = "逻辑运算ToolStripMenuItem";
            this.逻辑运算ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.逻辑运算ToolStripMenuItem.Text = "逻辑运算";
            this.逻辑运算ToolStripMenuItem.Click += new System.EventHandler(this.逻辑运算ToolStripMenuItem_Click);
            // 
            // 植被指数ToolStripMenuItem
            // 
            this.植被指数ToolStripMenuItem.Name = "植被指数ToolStripMenuItem";
            this.植被指数ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.植被指数ToolStripMenuItem.Text = "遥感指数";
            this.植被指数ToolStripMenuItem.Click += new System.EventHandler(this.植被指数ToolStripMenuItem_Click);
            // 
            // kT变换ToolStripMenuItem
            // 
            this.kT变换ToolStripMenuItem.Name = "kT变换ToolStripMenuItem";
            this.kT变换ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.kT变换ToolStripMenuItem.Text = "KT变换";
            this.kT变换ToolStripMenuItem.Click += new System.EventHandler(this.kT变换ToolStripMenuItem_Click);
            // 
            // rGBHSIToolStripMenuItem
            // 
            this.rGBHSIToolStripMenuItem.Name = "rGBHSIToolStripMenuItem";
            this.rGBHSIToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.rGBHSIToolStripMenuItem.Text = "RGB->HSI";
            this.rGBHSIToolStripMenuItem.Click += new System.EventHandler(this.rGBHSIToolStripMenuItem_Click);
            // 
            // 图像滤波ToolStripMenuItem
            // 
            this.图像滤波ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.均值滤波ToolStripMenuItem});
            this.图像滤波ToolStripMenuItem.Name = "图像滤波ToolStripMenuItem";
            this.图像滤波ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图像滤波ToolStripMenuItem.Text = "图像滤波";
            // 
            // 均值滤波ToolStripMenuItem
            // 
            this.均值滤波ToolStripMenuItem.Name = "均值滤波ToolStripMenuItem";
            this.均值滤波ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.均值滤波ToolStripMenuItem.Text = "平滑滤波";
            this.均值滤波ToolStripMenuItem.Click += new System.EventHandler(this.均值滤波ToolStripMenuItem_Click);
            // 
            // 图像分类ToolStripMenuItem
            // 
            this.图像分类ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kMeansToolStripMenuItem,
            this.最大似然法ToolStripMenuItem});
            this.图像分类ToolStripMenuItem.Name = "图像分类ToolStripMenuItem";
            this.图像分类ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图像分类ToolStripMenuItem.Text = "图像分类";
            // 
            // kMeansToolStripMenuItem
            // 
            this.kMeansToolStripMenuItem.Name = "kMeansToolStripMenuItem";
            this.kMeansToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.kMeansToolStripMenuItem.Text = "K-Means";
            this.kMeansToolStripMenuItem.Click += new System.EventHandler(this.kMeansToolStripMenuItem_Click);
            // 
            // 最大似然法ToolStripMenuItem
            // 
            this.最大似然法ToolStripMenuItem.Name = "最大似然法ToolStripMenuItem";
            this.最大似然法ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.最大似然法ToolStripMenuItem.Text = "最大似然法";
            this.最大似然法ToolStripMenuItem.Click += new System.EventHandler(this.最大似然法ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 27);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开图像ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开jpg图像ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 显示直方图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 均值ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 联合直方图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 相关系数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 协方差ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 直方图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 直方图ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 累计直方图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 纹理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 极差纹理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 共生矩阵ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 图像显示与拉伸ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 直方图均衡化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 直方图规定化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 线性拉伸ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oIFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像变换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kT变换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBHSIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像分类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kMeansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最大似然法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 波段运算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 代数运算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 逻辑运算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 植被指数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像滤波ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 均值滤波ToolStripMenuItem;
    }
}

