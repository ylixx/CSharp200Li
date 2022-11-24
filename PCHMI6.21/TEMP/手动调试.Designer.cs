namespace TEMP
{
    partial class 手动调试
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
            this.components = new System.ComponentModel.Container();
            PCHMI.InterLock interLock2 = new PCHMI.InterLock();
            PCHMI.DrawStyle drawStyle2 = new PCHMI.DrawStyle();
            PCHMI.OPTLOG optlog2 = new PCHMI.OPTLOG();
            PCHMI.ST_SW_IF sT_SW_IF2 = new PCHMI.ST_SW_IF();
            PCHMI.GLINT glint2 = new PCHMI.GLINT();
            this.标签1 = new PCHMI.标签(this.components);
            this.操作记录1 = new PCHMI.操作记录();
            this.SuspendLayout();
            // 
            // 标签1
            // 
            this.标签1.AutoSize = true;
            this.标签1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.标签1.ForeColor = System.Drawing.Color.Black;
            this.标签1.HDADDR = "";
            this.标签1.Image = null;
            this.标签1.Location = new System.Drawing.Point(324, 15);
            this.标签1.Name = "标签1";
            this.标签1.PLC = ((uint)(0u));
            this.标签1.Size = new System.Drawing.Size(133, 38);
            this.标签1.TabIndex = 1;
            this.标签1.Text = "手动调试";
            this.标签1.Value = ((ulong)(0ul));
            interLock2.HDADDR = "";
            interLock2.PLC = ((uint)(0u));
            interLock2.互锁启用值 = ((uint)(1u));
            interLock2.互锁地址 = "";
            interLock2.互锁显示图标 = null;
            interLock2.互锁显示文本 = "LOCK";
            interLock2.互锁类型 = PCHMI.InterLock.DatType.BIT;
            this.标签1.互锁 = interLock2;
            this.标签1.值限制 = false;
            this.标签1.允许输入 = false;
            this.标签1.前缀 = "";
            this.标签1.功能 = PCHMI.标签.TypeEnum.标签;
            this.标签1.后缀 = "";
            this.标签1.图片显示偏移量 = new System.Drawing.Point(0, 0);
            drawStyle2.圆角半径 = 15;
            drawStyle2.填充颜色 = System.Drawing.Color.Empty;
            drawStyle2.按下颜色 = System.Drawing.Color.Empty;
            drawStyle2.样式 = PCHMI.DrawStyle.STYPE.常规;
            drawStyle2.边框颜色 = System.Drawing.Color.LightGray;
            this.标签1.外观样式 = drawStyle2;
            this.标签1.字符串长度 = ((uint)(10u));
            this.标签1.安全级别 = ((uint)(0u));
            this.标签1.小数位数 = ((uint)(0u));
            this.标签1.开关功能.PLC = null;
            this.标签1.开关功能.地址 = null;
            this.标签1.开关功能.开关 = null;
            this.标签1.开关功能.扩展 = null;
            this.标签1.快捷键 = "";
            this.标签1.总显示位数 = ((uint)(8u));
            this.标签1.操作确认 = false;
            this.标签1.操作确认提示 = new string[] {
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
            optlog2.按下 = "";
            optlog2.更改 = "";
            this.标签1.操作记录 = optlog2;
            this.标签1.数据类型 = PCHMI.标签.DatType.BIT;
            this.标签1.日期时间格式化 = "yyyy-MM-dd";
            this.标签1.显示内容.BkImg = null;
            this.标签1.显示内容.状态切换条件 = PCHMI.Employee.STSW.按序号值切换状态;
            sT_SW_IF2.BkColor = System.Drawing.Color.Empty;
            sT_SW_IF2.Img = null;
            sT_SW_IF2.MaxVal = ((ulong)(0ul));
            sT_SW_IF2.MinVal = ((ulong)(0ul));
            sT_SW_IF2.Txt0 = "HELLO WORLD";
            sT_SW_IF2.Txt1 = "HELLO WORLD";
            sT_SW_IF2.Txt2 = "HELLO WORLD";
            sT_SW_IF2.Txt3 = "";
            sT_SW_IF2.Txt4 = "";
            sT_SW_IF2.Txt5 = "";
            sT_SW_IF2.Txt6 = "";
            sT_SW_IF2.Txt7 = "";
            sT_SW_IF2.TxtColor = System.Drawing.Color.Black;
            sT_SW_IF2.TxtNumber = "";
            this.标签1.显示内容.状态文本 = new PCHMI.ST_SW_IF[] {
        sT_SW_IF2};
            this.标签1.显示内容.默认状态文本ID = ((uint)(0u));
            this.标签1.最大值 = "100";
            this.标签1.最小值 = "0";
            this.标签1.权限提示文本 = "";
            this.标签1.空字符显示 = "null";
            this.标签1.语言 = ((uint)(0u));
            glint2.HDADDR = "";
            glint2.PLC = ((uint)(0u));
            glint2.位地址 = "";
            glint2.字体颜色 = System.Drawing.Color.Red;
            glint2.间隔时间 = ((ushort)(1000));
            this.标签1.闪烁 = glint2;
            this.标签1.默认字体颜色 = System.Drawing.Color.Black;
            // 
            // 操作记录1
            // 
            this.操作记录1.BackColor = System.Drawing.Color.White;
            this.操作记录1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.操作记录1.Location = new System.Drawing.Point(15, 56);
            this.操作记录1.Name = "操作记录1";
            this.操作记录1.Size = new System.Drawing.Size(766, 426);
            this.操作记录1.TabIndex = 2;
            this.操作记录1.列标题颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.操作记录1.年份 = new string[] {
        "2022",
        "2023"};
            this.操作记录1.时间列宽度 = 200;
            this.操作记录1.网格颜色 = System.Drawing.SystemColors.ActiveCaption;
            this.操作记录1.背景颜色 = System.Drawing.Color.White;
            this.操作记录1.行标题颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.操作记录1.语言 = ((uint)(0u));
            this.操作记录1.首列宽度 = 60;
            // 
            // 手动调试
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.操作记录1);
            this.Controls.Add(this.标签1);
            this.Name = "手动调试";
            this.Size = new System.Drawing.Size(800, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PCHMI.标签 标签1;
        private PCHMI.操作记录 操作记录1;
    }
}
