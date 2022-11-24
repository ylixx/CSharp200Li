namespace scada
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            PCHMI.STARTGIF startgif1 = new PCHMI.STARTGIF();
            PCHMI.KEYBEEP keybeep1 = new PCHMI.KEYBEEP();
            PCHMI.TLOG tlog1 = new PCHMI.TLOG();
            PCHMI.WINDOW_SIZE windoW_SIZE1 = new PCHMI.WINDOW_SIZE();
            PCHMI.limits limits1 = new PCHMI.limits();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PCHMI.InterLock interLock1 = new PCHMI.InterLock();
            PCHMI.InterLock interLock2 = new PCHMI.InterLock();
            PCHMI.InterLock interLock3 = new PCHMI.InterLock();
            this.config1 = new PCHMI.CONFIG();
            this.数据显示器1 = new PCHMI.数据显示器();
            this.数据显示器2 = new PCHMI.数据显示器();
            this.数据显示器3 = new PCHMI.数据显示器();
            this.SuspendLayout();
            // 
            // config1
            // 
            this.config1.MAIN_HMI_IP = "";
            this.config1.MODBUS服务器配置 = new PCHMI.MODBUS_TCP_SERVER_CONFIG[0];
            this.config1.PC时间保存地址 = null;
            this.config1.允许同时运行多个程序 = false;
            this.config1.功能权限分配 = null;
            startgif1.动画图片 = null;
            startgif1.动画时间 = 1000;
            startgif1.登录界面 = "";
            this.config1.开机界面 = startgif1;
            this.config1.快速登录注销时间 = ((uint)(60u));
            keybeep1.WAV文件路径 = "";
            keybeep1.启用 = true;
            keybeep1.时长 = 120;
            keybeep1.频率 = 2000;
            this.config1.按键音 = keybeep1;
            tlog1.日志保存目录 = "D:\\TextLog";
            this.config1.操作日志 = tlog1;
            this.config1.数据库连接 = null;
            this.config1.数据路径 = "D:\\";
            this.config1.画面 = null;
            this.config1.登录方式 = PCHMI.CONFIG.LOGType.快速登录;
            windoW_SIZE1.软键盘 = PCHMI.WINDOW_SIZE.SIZE.小;
            this.config1.窗口尺寸 = windoW_SIZE1;
            this.config1.等比缩放 = false;
            limits1.PLC = ((uint)(0u));
            limits1.地址 = "";
            limits1.限制类型 = PCHMI.limits.LType.无效;
            this.config1.运行限制 = limits1;
            this.config1.通讯配置 = new string[] {
        resources.GetString("config1.通讯配置")};
            this.config1.通讯配置文件名 = "";
            this.config1.随机数保存地址 = null;
            // 
            // 数据显示器1
            // 
            this.数据显示器1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.数据显示器1.HDADDR = "400000";
            this.数据显示器1.Location = new System.Drawing.Point(247, 82);
            this.数据显示器1.Name = "数据显示器1";
            this.数据显示器1.PLC = ((uint)(0u));
            this.数据显示器1.Size = new System.Drawing.Size(142, 38);
            this.数据显示器1.TabIndex = 0;
            this.数据显示器1.Value = ((ulong)(0ul));
            interLock1.HDADDR = "";
            interLock1.PLC = ((uint)(0u));
            interLock1.互锁启用值 = ((uint)(1u));
            interLock1.互锁地址 = "";
            interLock1.互锁显示图标 = null;
            interLock1.互锁显示文本 = "LOCK";
            interLock1.互锁类型 = PCHMI.InterLock.DatType.BIT;
            this.数据显示器1.互锁 = interLock1;
            this.数据显示器1.值限制 = false;
            this.数据显示器1.回车后触发TAB键 = false;
            this.数据显示器1.字符串长度 = ((uint)(10u));
            this.数据显示器1.安全级别 = ((uint)(0u));
            this.数据显示器1.小数位数 = ((uint)(0u));
            this.数据显示器1.总显示位数 = ((uint)(8u));
            this.数据显示器1.操作记录 = "";
            this.数据显示器1.数值改变事件参数 = "NULL";
            this.数据显示器1.数据类型 = PCHMI.数据显示器.DatType.INT16;
            this.数据显示器1.最大值 = "100";
            this.数据显示器1.最小值 = "0";
            this.数据显示器1.权限提示文本 = "";
            this.数据显示器1.输入方式 = PCHMI.数据显示器.INTYPE.软键盘;
            this.数据显示器1.键盘输入事件参数 = "NULL";
            this.数据显示器1.键盘进入方式 = PCHMI.数据显示器.KeyInMode.单击;
            this.数据显示器1.零抑制 = false;
            this.数据显示器1.零显示 = false;
            // 
            // 数据显示器2
            // 
            this.数据显示器2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.数据显示器2.HDADDR = "400001";
            this.数据显示器2.Location = new System.Drawing.Point(247, 144);
            this.数据显示器2.Name = "数据显示器2";
            this.数据显示器2.PLC = ((uint)(0u));
            this.数据显示器2.Size = new System.Drawing.Size(142, 38);
            this.数据显示器2.TabIndex = 1;
            this.数据显示器2.Value = ((ulong)(0ul));
            interLock2.HDADDR = "";
            interLock2.PLC = ((uint)(0u));
            interLock2.互锁启用值 = ((uint)(1u));
            interLock2.互锁地址 = "";
            interLock2.互锁显示图标 = null;
            interLock2.互锁显示文本 = "LOCK";
            interLock2.互锁类型 = PCHMI.InterLock.DatType.BIT;
            this.数据显示器2.互锁 = interLock2;
            this.数据显示器2.值限制 = false;
            this.数据显示器2.回车后触发TAB键 = false;
            this.数据显示器2.字符串长度 = ((uint)(10u));
            this.数据显示器2.安全级别 = ((uint)(0u));
            this.数据显示器2.小数位数 = ((uint)(0u));
            this.数据显示器2.总显示位数 = ((uint)(8u));
            this.数据显示器2.操作记录 = "";
            this.数据显示器2.数值改变事件参数 = "NULL";
            this.数据显示器2.数据类型 = PCHMI.数据显示器.DatType.INT16;
            this.数据显示器2.最大值 = "100";
            this.数据显示器2.最小值 = "0";
            this.数据显示器2.权限提示文本 = "";
            this.数据显示器2.输入方式 = PCHMI.数据显示器.INTYPE.软键盘;
            this.数据显示器2.键盘输入事件参数 = "NULL";
            this.数据显示器2.键盘进入方式 = PCHMI.数据显示器.KeyInMode.单击;
            this.数据显示器2.零抑制 = false;
            this.数据显示器2.零显示 = false;
            // 
            // 数据显示器3
            // 
            this.数据显示器3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.数据显示器3.HDADDR = "400002";
            this.数据显示器3.Location = new System.Drawing.Point(247, 213);
            this.数据显示器3.Name = "数据显示器3";
            this.数据显示器3.PLC = ((uint)(0u));
            this.数据显示器3.Size = new System.Drawing.Size(142, 38);
            this.数据显示器3.TabIndex = 2;
            this.数据显示器3.Value = ((ulong)(0ul));
            interLock3.HDADDR = "";
            interLock3.PLC = ((uint)(0u));
            interLock3.互锁启用值 = ((uint)(1u));
            interLock3.互锁地址 = "";
            interLock3.互锁显示图标 = null;
            interLock3.互锁显示文本 = "LOCK";
            interLock3.互锁类型 = PCHMI.InterLock.DatType.BIT;
            this.数据显示器3.互锁 = interLock3;
            this.数据显示器3.值限制 = false;
            this.数据显示器3.回车后触发TAB键 = false;
            this.数据显示器3.字符串长度 = ((uint)(10u));
            this.数据显示器3.安全级别 = ((uint)(0u));
            this.数据显示器3.小数位数 = ((uint)(0u));
            this.数据显示器3.总显示位数 = ((uint)(8u));
            this.数据显示器3.操作记录 = "";
            this.数据显示器3.数值改变事件参数 = "NULL";
            this.数据显示器3.数据类型 = PCHMI.数据显示器.DatType.INT16;
            this.数据显示器3.最大值 = "100";
            this.数据显示器3.最小值 = "0";
            this.数据显示器3.权限提示文本 = "";
            this.数据显示器3.输入方式 = PCHMI.数据显示器.INTYPE.软键盘;
            this.数据显示器3.键盘输入事件参数 = "NULL";
            this.数据显示器3.键盘进入方式 = PCHMI.数据显示器.KeyInMode.单击;
            this.数据显示器3.零抑制 = false;
            this.数据显示器3.零显示 = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 448);
            this.Controls.Add(this.数据显示器3);
            this.Controls.Add(this.数据显示器2);
            this.Controls.Add(this.数据显示器1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PCHMI.CONFIG config1;
        private PCHMI.数据显示器 数据显示器1;
        private PCHMI.数据显示器 数据显示器2;
        private PCHMI.数据显示器 数据显示器3;
    }
}

