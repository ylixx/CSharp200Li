namespace TEMP
{
    partial class 帮助
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
            this.components = new System.ComponentModel.Container();
            PCHMI.InterLock interLock1 = new PCHMI.InterLock();
            PCHMI.DrawStyle drawStyle1 = new PCHMI.DrawStyle();
            PCHMI.OPTLOG optlog1 = new PCHMI.OPTLOG();
            PCHMI.GLINT glint1 = new PCHMI.GLINT();
            this.标签1 = new PCHMI.标签(this.components);
            this.SuspendLayout();
            // 
            // 标签1
            // 
            this.标签1.AutoSize = true;
            this.标签1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.标签1.HDADDR = "";
            this.标签1.Image = null;
            this.标签1.Location = new System.Drawing.Point(152, 81);
            this.标签1.Name = "标签1";
            this.标签1.PLC = ((uint)(0u));
            this.标签1.Size = new System.Drawing.Size(316, 38);
            this.标签1.TabIndex = 0;
            this.标签1.Text = "对不起，暂时没有帮助!";
            this.标签1.Value = ((ulong)(0ul));
            interLock1.HDADDR = "";
            interLock1.PLC = ((uint)(0u));
            interLock1.互锁启用值 = ((uint)(1u));
            interLock1.互锁地址 = "";
            interLock1.互锁显示图标 = null;
            interLock1.互锁显示文本 = "LOCK";
            interLock1.互锁类型 = PCHMI.InterLock.DatType.BIT;
            this.标签1.互锁 = interLock1;
            this.标签1.值限制 = false;
            this.标签1.允许输入 = false;
            this.标签1.前缀 = "";
            this.标签1.功能 = PCHMI.标签.TypeEnum.标签;
            this.标签1.后缀 = "";
            this.标签1.图片显示偏移量 = new System.Drawing.Point(0, 0);
            drawStyle1.圆角半径 = 15;
            drawStyle1.填充颜色 = System.Drawing.Color.Empty;
            drawStyle1.按下颜色 = System.Drawing.Color.Empty;
            drawStyle1.样式 = PCHMI.DrawStyle.STYPE.常规;
            drawStyle1.边框颜色 = System.Drawing.Color.LightGray;
            this.标签1.外观样式 = drawStyle1;
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
            optlog1.按下 = "";
            optlog1.更改 = "";
            this.标签1.操作记录 = optlog1;
            this.标签1.数据类型 = PCHMI.标签.DatType.BIT;
            this.标签1.日期时间格式化 = "yyyy-MM-dd";
            this.标签1.显示内容.BkImg = null;
            this.标签1.显示内容.状态切换条件 = PCHMI.Employee.STSW.按序号值切换状态;
            this.标签1.显示内容.状态文本 = null;
            this.标签1.显示内容.默认状态文本ID = ((uint)(0u));
            this.标签1.最大值 = "100";
            this.标签1.最小值 = "0";
            this.标签1.权限提示文本 = "";
            this.标签1.空字符显示 = "null";
            this.标签1.语言 = ((uint)(0u));
            glint1.HDADDR = "";
            glint1.PLC = ((uint)(0u));
            glint1.位地址 = "";
            glint1.字体颜色 = System.Drawing.Color.Red;
            glint1.间隔时间 = ((ushort)(1000));
            this.标签1.闪烁 = glint1;
            this.标签1.默认字体颜色 = System.Drawing.Color.Black;
            // 
            // 帮助
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 244);
            this.Controls.Add(this.标签1);
            this.Name = "帮助";
            this.Text = "帮助";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PCHMI.标签 标签1;
    }
}