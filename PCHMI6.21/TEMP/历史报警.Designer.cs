namespace TEMP
{
    partial class 历史报警
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.报警记录1 = new PCHMI.报警记录();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(123, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "报警列表使用的是U地址实际使用时请换成对应的PLC地址";
            // 
            // 报警记录1
            // 
            this.报警记录1.BackColor = System.Drawing.Color.White;
            this.报警记录1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.报警记录1.Location = new System.Drawing.Point(4, 4);
            this.报警记录1.Name = "报警记录1";
            this.报警记录1.Size = new System.Drawing.Size(793, 511);
            this.报警记录1.TabIndex = 8;
            this.报警记录1.列标题颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.报警记录1.年份 = new string[] {
        "2022",
        "2023",
        "2024",
        "2025"};
            this.报警记录1.时间列宽度 = 200;
            this.报警记录1.网格颜色 = System.Drawing.SystemColors.ActiveCaption;
            this.报警记录1.背景颜色 = System.Drawing.Color.White;
            this.报警记录1.行标题颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.报警记录1.语言 = ((uint)(0u));
            this.报警记录1.首列宽度 = 60;
            // 
            // 历史报警
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.报警记录1);
            this.Controls.Add(this.label1);
            this.Name = "历史报警";
            this.Size = new System.Drawing.Size(800, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private PCHMI.报警记录 报警记录1;
    }
}
