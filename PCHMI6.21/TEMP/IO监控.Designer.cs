namespace TEMP
{
    partial class IO监控
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IO监控));
            PCHMI.InterLock interLock3 = new PCHMI.InterLock();
            PCHMI.DrawStyle drawStyle3 = new PCHMI.DrawStyle();
            PCHMI.OPTLOG optlog3 = new PCHMI.OPTLOG();
            PCHMI.ST_SW_IF sT_SW_IF5 = new PCHMI.ST_SW_IF();
            PCHMI.ST_SW_IF sT_SW_IF6 = new PCHMI.ST_SW_IF();
            PCHMI.GLINT glint3 = new PCHMI.GLINT();
            PCHMI.InterLock interLock4 = new PCHMI.InterLock();
            PCHMI.DrawStyle drawStyle4 = new PCHMI.DrawStyle();
            PCHMI.OPTLOG optlog4 = new PCHMI.OPTLOG();
            PCHMI.ST_SW_IF sT_SW_IF7 = new PCHMI.ST_SW_IF();
            PCHMI.ST_SW_IF sT_SW_IF8 = new PCHMI.ST_SW_IF();
            PCHMI.GLINT glint4 = new PCHMI.GLINT();
            this.iO监控1 = new PCHMI.IO监控();
            this.iO监控2 = new PCHMI.IO监控();
            this.标签1 = new PCHMI.标签(this.components);
            this.标签2 = new PCHMI.标签(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iO监控1
            // 
            this.iO监控1.BackColor = System.Drawing.Color.White;
            this.iO监控1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iO监控1.FieName = "INPUT";
            this.iO监控1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iO监控1.IOTXT = resources.GetString("iO监控1.IOTXT");
            this.iO监控1.Location = new System.Drawing.Point(24, 50);
            this.iO监控1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iO监控1.Name = "iO监控1";
            this.iO监控1.Size = new System.Drawing.Size(357, 445);
            this.iO监控1.TabIndex = 2;
            this.iO监控1.列标题颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.iO监控1.指示列宽度 = 100;
            this.iO监控1.网格颜色 = System.Drawing.SystemColors.ActiveCaption;
            this.iO监控1.背景颜色 = System.Drawing.Color.White;
            this.iO监控1.语言 = ((uint)(0u));
            // 
            // iO监控2
            // 
            this.iO监控2.BackColor = System.Drawing.Color.White;
            this.iO监控2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iO监控2.FieName = "OUTPUT";
            this.iO监控2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iO监控2.IOTXT = resources.GetString("iO监控2.IOTXT");
            this.iO监控2.Location = new System.Drawing.Point(416, 50);
            this.iO监控2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iO监控2.Name = "iO监控2";
            this.iO监控2.Size = new System.Drawing.Size(357, 445);
            this.iO监控2.TabIndex = 3;
            this.iO监控2.列标题颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.iO监控2.指示列宽度 = 100;
            this.iO监控2.网格颜色 = System.Drawing.SystemColors.ActiveCaption;
            this.iO监控2.背景颜色 = System.Drawing.Color.White;
            this.iO监控2.语言 = ((uint)(0u));
            // 
            // 标签1
            // 
            this.标签1.AutoSize = true;
            this.标签1.BackColor = System.Drawing.Color.Transparent;
            this.标签1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.标签1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.标签1.HDADDR = "";
            this.标签1.Image = null;
            this.标签1.Location = new System.Drawing.Point(31, 26);
            this.标签1.Name = "标签1";
            this.标签1.PLC = ((uint)(0u));
            this.标签1.Size = new System.Drawing.Size(60, 21);
            this.标签1.TabIndex = 4;
            this.标签1.Text = "输入IO";
            this.标签1.Value = ((ulong)(0ul));
            interLock3.HDADDR = "";
            interLock3.PLC = ((uint)(0u));
            interLock3.互锁启用值 = ((uint)(1u));
            interLock3.互锁地址 = "";
            interLock3.互锁显示图标 = null;
            interLock3.互锁显示文本 = "LOCK";
            interLock3.互锁类型 = PCHMI.InterLock.DatType.BIT;
            this.标签1.互锁 = interLock3;
            this.标签1.值限制 = false;
            this.标签1.允许输入 = false;
            this.标签1.前缀 = "";
            this.标签1.功能 = PCHMI.标签.TypeEnum.标签;
            this.标签1.后缀 = "";
            this.标签1.图片显示偏移量 = new System.Drawing.Point(0, 0);
            drawStyle3.圆角半径 = 15;
            drawStyle3.填充颜色 = System.Drawing.Color.Empty;
            drawStyle3.按下颜色 = System.Drawing.Color.Empty;
            drawStyle3.样式 = PCHMI.DrawStyle.STYPE.常规;
            drawStyle3.边框颜色 = System.Drawing.Color.LightGray;
            this.标签1.外观样式 = drawStyle3;
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
            optlog3.按下 = "";
            optlog3.更改 = "";
            this.标签1.操作记录 = optlog3;
            this.标签1.数据类型 = PCHMI.标签.DatType.BIT;
            this.标签1.日期时间格式化 = "yyyy-MM-dd";
            this.标签1.显示内容.BkImg = null;
            this.标签1.显示内容.状态切换条件 = PCHMI.Employee.STSW.按序号值切换状态;
            sT_SW_IF5.BkColor = System.Drawing.Color.Transparent;
            sT_SW_IF5.Img = null;
            sT_SW_IF5.MaxVal = ((ulong)(0ul));
            sT_SW_IF5.MinVal = ((ulong)(0ul));
            sT_SW_IF5.Txt0 = "输入IO";
            sT_SW_IF5.Txt1 = "";
            sT_SW_IF5.Txt2 = "";
            sT_SW_IF5.Txt3 = "";
            sT_SW_IF5.Txt4 = "";
            sT_SW_IF5.Txt5 = "";
            sT_SW_IF5.Txt6 = "";
            sT_SW_IF5.Txt7 = "";
            sT_SW_IF5.TxtColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            sT_SW_IF5.TxtNumber = "";
            sT_SW_IF6.BkColor = System.Drawing.Color.Transparent;
            sT_SW_IF6.Img = null;
            sT_SW_IF6.MaxVal = ((ulong)(0ul));
            sT_SW_IF6.MinVal = ((ulong)(0ul));
            sT_SW_IF6.Txt0 = "INPUT IO";
            sT_SW_IF6.Txt1 = "";
            sT_SW_IF6.Txt2 = "";
            sT_SW_IF6.Txt3 = "";
            sT_SW_IF6.Txt4 = "";
            sT_SW_IF6.Txt5 = "";
            sT_SW_IF6.Txt6 = "";
            sT_SW_IF6.Txt7 = "";
            sT_SW_IF6.TxtColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            sT_SW_IF6.TxtNumber = "";
            this.标签1.显示内容.状态文本 = new PCHMI.ST_SW_IF[] {
        sT_SW_IF5,
        sT_SW_IF6};
            this.标签1.显示内容.默认状态文本ID = ((uint)(0u));
            this.标签1.最大值 = "100";
            this.标签1.最小值 = "0";
            this.标签1.权限提示文本 = "";
            this.标签1.空字符显示 = "null";
            this.标签1.语言 = ((uint)(0u));
            glint3.HDADDR = "";
            glint3.PLC = ((uint)(0u));
            glint3.位地址 = "";
            glint3.字体颜色 = System.Drawing.Color.Red;
            glint3.间隔时间 = ((ushort)(1000));
            this.标签1.闪烁 = glint3;
            this.标签1.默认字体颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // 标签2
            // 
            this.标签2.AutoSize = true;
            this.标签2.BackColor = System.Drawing.Color.Transparent;
            this.标签2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.标签2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.标签2.HDADDR = "";
            this.标签2.Image = null;
            this.标签2.Location = new System.Drawing.Point(422, 26);
            this.标签2.Name = "标签2";
            this.标签2.PLC = ((uint)(0u));
            this.标签2.Size = new System.Drawing.Size(60, 21);
            this.标签2.TabIndex = 5;
            this.标签2.Text = "输出IO";
            this.标签2.Value = ((ulong)(0ul));
            interLock4.HDADDR = "";
            interLock4.PLC = ((uint)(0u));
            interLock4.互锁启用值 = ((uint)(1u));
            interLock4.互锁地址 = "";
            interLock4.互锁显示图标 = null;
            interLock4.互锁显示文本 = "LOCK";
            interLock4.互锁类型 = PCHMI.InterLock.DatType.BIT;
            this.标签2.互锁 = interLock4;
            this.标签2.值限制 = false;
            this.标签2.允许输入 = false;
            this.标签2.前缀 = "";
            this.标签2.功能 = PCHMI.标签.TypeEnum.标签;
            this.标签2.后缀 = "";
            this.标签2.图片显示偏移量 = new System.Drawing.Point(0, 0);
            drawStyle4.圆角半径 = 15;
            drawStyle4.填充颜色 = System.Drawing.Color.Empty;
            drawStyle4.按下颜色 = System.Drawing.Color.Empty;
            drawStyle4.样式 = PCHMI.DrawStyle.STYPE.常规;
            drawStyle4.边框颜色 = System.Drawing.Color.LightGray;
            this.标签2.外观样式 = drawStyle4;
            this.标签2.字符串长度 = ((uint)(10u));
            this.标签2.安全级别 = ((uint)(0u));
            this.标签2.小数位数 = ((uint)(0u));
            this.标签2.开关功能.PLC = null;
            this.标签2.开关功能.地址 = null;
            this.标签2.开关功能.开关 = null;
            this.标签2.开关功能.扩展 = null;
            this.标签2.快捷键 = "";
            this.标签2.总显示位数 = ((uint)(8u));
            this.标签2.操作确认 = false;
            this.标签2.操作确认提示 = new string[] {
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
            optlog4.按下 = "";
            optlog4.更改 = "";
            this.标签2.操作记录 = optlog4;
            this.标签2.数据类型 = PCHMI.标签.DatType.BIT;
            this.标签2.日期时间格式化 = "yyyy-MM-dd";
            this.标签2.显示内容.BkImg = null;
            this.标签2.显示内容.状态切换条件 = PCHMI.Employee.STSW.按序号值切换状态;
            sT_SW_IF7.BkColor = System.Drawing.Color.Transparent;
            sT_SW_IF7.Img = null;
            sT_SW_IF7.MaxVal = ((ulong)(0ul));
            sT_SW_IF7.MinVal = ((ulong)(0ul));
            sT_SW_IF7.Txt0 = "输出IO";
            sT_SW_IF7.Txt1 = "";
            sT_SW_IF7.Txt2 = "";
            sT_SW_IF7.Txt3 = "";
            sT_SW_IF7.Txt4 = "";
            sT_SW_IF7.Txt5 = "";
            sT_SW_IF7.Txt6 = "";
            sT_SW_IF7.Txt7 = "";
            sT_SW_IF7.TxtColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            sT_SW_IF7.TxtNumber = "";
            sT_SW_IF8.BkColor = System.Drawing.Color.Transparent;
            sT_SW_IF8.Img = null;
            sT_SW_IF8.MaxVal = ((ulong)(0ul));
            sT_SW_IF8.MinVal = ((ulong)(0ul));
            sT_SW_IF8.Txt0 = "OUTPUT IO";
            sT_SW_IF8.Txt1 = "";
            sT_SW_IF8.Txt2 = "";
            sT_SW_IF8.Txt3 = "";
            sT_SW_IF8.Txt4 = "";
            sT_SW_IF8.Txt5 = "";
            sT_SW_IF8.Txt6 = "";
            sT_SW_IF8.Txt7 = "";
            sT_SW_IF8.TxtColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            sT_SW_IF8.TxtNumber = "";
            this.标签2.显示内容.状态文本 = new PCHMI.ST_SW_IF[] {
        sT_SW_IF7,
        sT_SW_IF8};
            this.标签2.显示内容.默认状态文本ID = ((uint)(0u));
            this.标签2.最大值 = "100";
            this.标签2.最小值 = "0";
            this.标签2.权限提示文本 = "";
            this.标签2.空字符显示 = "null";
            this.标签2.语言 = ((uint)(0u));
            glint4.HDADDR = "";
            glint4.PLC = ((uint)(0u));
            glint4.位地址 = "";
            glint4.字体颜色 = System.Drawing.Color.Red;
            glint4.间隔时间 = ((ushort)(1000));
            this.标签2.闪烁 = glint4;
            this.标签2.默认字体颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(125, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "IO列表使用的是U地址实际使用时请换成对应的PLC地址";
            // 
            // IO监控
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.标签2);
            this.Controls.Add(this.标签1);
            this.Controls.Add(this.iO监控2);
            this.Controls.Add(this.iO监控1);
            this.Name = "IO监控";
            this.Size = new System.Drawing.Size(800, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PCHMI.IO监控 iO监控1;
        private PCHMI.IO监控 iO监控2;
        private PCHMI.标签 标签1;
        private PCHMI.标签 标签2;
        private System.Windows.Forms.Label label1;
    }
}
