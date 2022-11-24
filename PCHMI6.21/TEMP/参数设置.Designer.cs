namespace TEMP
{
    partial class 参数设置
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
            PCHMI.InterLock interLock1 = new PCHMI.InterLock();
            PCHMI.ST_SW_IF sT_SW_IF1 = new PCHMI.ST_SW_IF();
            this.标签1 = new PCHMI.标签(this.components);
            this.SuspendLayout();
            // 
            // 标签1
            // 
            this.标签1.AutoSize = true;
            this.标签1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.标签1.ForeColor = System.Drawing.Color.Black;
            this.标签1.Image = null;
            this.标签1.Location = new System.Drawing.Point(322, 19);
            this.标签1.Name = "标签1";
            this.标签1.PLC = ((uint)(0u));
            this.标签1.Size = new System.Drawing.Size(133, 38);
            this.标签1.TabIndex = 1;
            this.标签1.Text = "参数设置";
            this.标签1.Value = ((ulong)(0ul));
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
            this.标签1.字符串长度 = ((uint)(10u));
            this.标签1.安全级别 = ((uint)(0u));
            this.标签1.小数位数 = ((uint)(0u));
            this.标签1.开关功能.PLC = null;
            this.标签1.开关功能.地址 = null;
            this.标签1.开关功能.开关 = null;
            this.标签1.开关功能.扩展 = null;
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
            this.标签1.数据类型 = PCHMI.标签.DatType.BIT;
            this.标签1.显示内容.BkImg = null;
            this.标签1.显示内容.状态切换条件 = PCHMI.Employee.STSW.按序号值切换状态;
            sT_SW_IF1.BkColor = System.Drawing.Color.Empty;
            sT_SW_IF1.Img = null;
            sT_SW_IF1.MaxVal = ((ulong)(0ul));
            sT_SW_IF1.MinVal = ((ulong)(0ul));
            sT_SW_IF1.Txt0 = "HELLO WORLD";
            sT_SW_IF1.Txt1 = "HELLO WORLD";
            sT_SW_IF1.Txt2 = "HELLO WORLD";
            sT_SW_IF1.Txt3 = "";
            sT_SW_IF1.Txt4 = "";
            sT_SW_IF1.Txt5 = "";
            sT_SW_IF1.Txt6 = "";
            sT_SW_IF1.Txt7 = "";
            sT_SW_IF1.TxtColor = System.Drawing.Color.Black;
            sT_SW_IF1.TxtNumber = "";
            this.标签1.显示内容.状态文本 = new PCHMI.ST_SW_IF[] {
        sT_SW_IF1};
            this.标签1.显示内容.默认状态文本ID = ((uint)(0u));
            this.标签1.最大值 = "100";
            this.标签1.最小值 = "0";
            this.标签1.监控地址 = "";
            this.标签1.空字符显示 = "null";
            this.标签1.语言 = ((uint)(0u));
            // 
            // 参数设置
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.标签1);
            this.Name = "参数设置";
            this.Size = new System.Drawing.Size(800, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PCHMI.标签 标签1;
    }
}
