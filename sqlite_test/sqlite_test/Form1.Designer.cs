namespace sqlite_test
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
            this.components = new System.ComponentModel.Container();
            PCHMI.InterLock interLock3 = new PCHMI.InterLock();
            PCHMI.InterLock interLock4 = new PCHMI.InterLock();
            PCHMI.DrawStyle drawStyle2 = new PCHMI.DrawStyle();
            PCHMI.OPTLOG optlog2 = new PCHMI.OPTLOG();
            PCHMI.GLINT glint2 = new PCHMI.GLINT();
            PCHMI.DBSource dbSource2 = new PCHMI.DBSource();
            PCHMI.XV2ADDR xV2ADDR2 = new PCHMI.XV2ADDR();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.按钮1 = new PCHMI.按钮(this.components);
            this.标签1 = new PCHMI.标签(this.components);
            this.仪表1 = new PCHMI.仪表();
            this.图表1 = new PCHMI.图表();
            this.串口1 = new PCHMI.串口();
            this.ucRollText1 = new HZH_Controls.Controls.UCRollText();
            this.ucTextBoxEx1 = new HZH_Controls.Controls.UCTextBoxEx();
            this.graphicalOverlayComponent1 = new HZH_Controls.Controls.GraphicalOverlayComponent(this.components);
            this.scrollbarComponent1 = new HZH_Controls.Controls.ScrollbarComponent(this.components);
            this.tabControlExt1 = new HZH_Controls.Controls.TabControlExt();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.仪表2 = new PCHMI.仪表();
            this.ucHorizontalList1 = new HZH_Controls.Controls.UCHorizontalList();
            this.uiSignal1 = new Sunny.UI.UISignal();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControlExt1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // 按钮1
            // 
            this.按钮1.HDADDR = "";
            this.按钮1.Location = new System.Drawing.Point(115, 163);
            this.按钮1.LockValue = ((uint)(0u));
            this.按钮1.Name = "按钮1";
            this.按钮1.PLC = ((uint)(0u));
            this.按钮1.Size = new System.Drawing.Size(75, 23);
            this.按钮1.TabIndex = 2;
            this.按钮1.Text = "按钮1";
            this.按钮1.UseVisualStyleBackColor = true;
            this.按钮1.Value = ((ulong)(0ul));
            interLock3.HDADDR = "";
            interLock3.PLC = ((uint)(0u));
            interLock3.互锁启用值 = ((uint)(1u));
            interLock3.互锁地址 = "";
            interLock3.互锁显示图标 = null;
            interLock3.互锁显示文本 = "LOCK";
            interLock3.互锁类型 = PCHMI.InterLock.DatType.BIT;
            this.按钮1.互锁 = interLock3;
            this.按钮1.单击事件参数 = "NULL";
            this.按钮1.安全级别 = ((uint)(0u));
            this.按钮1.开关功能.PLC = null;
            this.按钮1.开关功能.地址 = null;
            this.按钮1.开关功能.开关 = null;
            this.按钮1.开关功能.扩展 = null;
            this.按钮1.快捷键 = "";
            this.按钮1.指示类型 = PCHMI.按钮.DatType.BIT;
            this.按钮1.操作确认 = false;
            this.按钮1.操作确认提示 = new string[] {
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
            this.按钮1.操作记录 = "";
            this.按钮1.数值改变事件参数 = "NULL";
            this.按钮1.显示内容.BkImg = null;
            this.按钮1.显示内容.状态切换条件 = PCHMI.Employee.STSW.按序号值切换状态;
            this.按钮1.显示内容.状态文本 = null;
            this.按钮1.显示内容.默认状态文本ID = ((uint)(0u));
            this.按钮1.权限提示文本 = "";
            this.按钮1.语言 = ((uint)(0u));
            // 
            // 标签1
            // 
            this.标签1.AutoSize = true;
            this.标签1.HDADDR = "";
            this.标签1.Image = null;
            this.标签1.Location = new System.Drawing.Point(251, 168);
            this.标签1.Name = "标签1";
            this.标签1.PLC = ((uint)(0u));
            this.标签1.Size = new System.Drawing.Size(35, 12);
            this.标签1.TabIndex = 3;
            this.标签1.Text = "标签1";
            this.标签1.Value = ((ulong)(0ul));
            interLock4.HDADDR = "";
            interLock4.PLC = ((uint)(0u));
            interLock4.互锁启用值 = ((uint)(1u));
            interLock4.互锁地址 = "";
            interLock4.互锁显示图标 = null;
            interLock4.互锁显示文本 = "LOCK";
            interLock4.互锁类型 = PCHMI.InterLock.DatType.BIT;
            this.标签1.互锁 = interLock4;
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
            this.标签1.显示内容.状态文本 = null;
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
            // 仪表1
            // 
            this.仪表1.BaseArcColor = System.Drawing.Color.Gray;
            this.仪表1.BaseArcRadius = 80;
            this.仪表1.BaseArcStart = 135;
            this.仪表1.BaseArcSweep = 270;
            this.仪表1.BaseArcWidth = 2;
            this.仪表1.Cap_Idx = ((byte)(1));
            this.仪表1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.仪表1.CapPosition = new System.Drawing.Point(10, 10);
            this.仪表1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.仪表1.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.仪表1.CapText = "";
            this.仪表1.Center = new System.Drawing.Point(100, 100);
            this.仪表1.HDADDR = "";
            this.仪表1.Location = new System.Drawing.Point(66, 253);
            this.仪表1.MaxValue = 400F;
            this.仪表1.MinValue = -100F;
            this.仪表1.Name = "仪表1";
            this.仪表1.NeedleColor1 = PCHMI.仪表.NeedleColorEnum.Gray;
            this.仪表1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.仪表1.NeedleRadius = 80;
            this.仪表1.NeedleType = 0;
            this.仪表1.NeedleWidth = 2;
            this.仪表1.PLC = ((uint)(0u));
            this.仪表1.Range_Idx = ((byte)(0));
            this.仪表1.RangeColor = System.Drawing.Color.LightGreen;
            this.仪表1.RangeEnabled = true;
            this.仪表1.RangeEndValue = 300F;
            this.仪表1.RangeInnerRadius = 70;
            this.仪表1.RangeOuterRadius = 80;
            this.仪表1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.仪表1.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.仪表1.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.仪表1.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.仪表1.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.仪表1.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.仪表1.RangeStartValue = -100F;
            this.仪表1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.仪表1.ScaleLinesInterInnerRadius = 73;
            this.仪表1.ScaleLinesInterOuterRadius = 80;
            this.仪表1.ScaleLinesInterWidth = 1;
            this.仪表1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.仪表1.ScaleLinesMajorInnerRadius = 70;
            this.仪表1.ScaleLinesMajorOuterRadius = 80;
            this.仪表1.ScaleLinesMajorStepValue = 50F;
            this.仪表1.ScaleLinesMajorWidth = 2;
            this.仪表1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.仪表1.ScaleLinesMinorInnerRadius = 75;
            this.仪表1.ScaleLinesMinorNumOf = 9;
            this.仪表1.ScaleLinesMinorOuterRadius = 80;
            this.仪表1.ScaleLinesMinorWidth = 1;
            this.仪表1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.仪表1.ScaleNumbersFormat = null;
            this.仪表1.ScaleNumbersRadius = 95;
            this.仪表1.ScaleNumbersRotation = 0;
            this.仪表1.ScaleNumbersStartScaleLine = 0;
            this.仪表1.ScaleNumbersStepScaleLines = 1;
            this.仪表1.Size = new System.Drawing.Size(220, 216);
            this.仪表1.TabIndex = 4;
            this.仪表1.Text = "仪表1";
            this.仪表1.Value = 0F;
            this.仪表1.小数位数 = ((uint)(0u));
            this.仪表1.数据类型 = PCHMI.仪表.DatType.INT16;
            // 
            // 图表1
            // 
            this.图表1.HDADDR = "";
            this.图表1.Location = new System.Drawing.Point(426, 99);
            this.图表1.Name = "图表1";
            this.图表1.PLC = ((uint)(0u));
            this.图表1.Size = new System.Drawing.Size(268, 154);
            this.图表1.TabIndex = 5;
            this.图表1.X轴MaxValue = "0";
            this.图表1.X轴MinValue = "0";
            this.图表1.X轴单元格间隔 = 5D;
            this.图表1.X轴显示格式化 = "";
            this.图表1.X轴最大值 = 0D;
            this.图表1.X轴最小值 = 0D;
            this.图表1.X轴网格线颜色 = System.Drawing.Color.Black;
            this.图表1.X轴间隔偏移量 = 0D;
            this.图表1.X轴间隔类型 = PCHMI.图表.DTIType.Number;
            this.图表1.Y轴单元格间隔 = 200D;
            this.图表1.Y轴显示格式化 = "";
            this.图表1.Y轴最大值 = 1000D;
            this.图表1.Y轴最小值 = 0D;
            this.图表1.Y轴网格线颜色 = System.Drawing.Color.Black;
            this.图表1.图表区背景色 = System.Drawing.Color.Transparent;
            this.图表1.图表数据 = null;
            this.图表1.定时触发间隔 = ((uint)(1000u));
            dbSource2.数据源编号 = "";
            dbSource2.首列为X轴值 = false;
            this.图表1.数据源 = dbSource2;
            this.图表1.数据点标签文本 = "";
            this.图表1.整体背景色 = System.Drawing.Color.Transparent;
            this.图表1.显示说明区 = true;
            xV2ADDR2.HDADDR1 = "";
            xV2ADDR2.HDADDR2 = "";
            xV2ADDR2.PLC = ((uint)(0u));
            xV2ADDR2.TYPE = PCHMI.XV2ADDR.DatType.UINT16;
            xV2ADDR2.最小年份 = ((ushort)(1970));
            this.图表1.监视地址 = xV2ADDR2;
            this.图表1.触发位 = "";
            this.图表1.触发方式 = PCHMI.图表.TRIGGERTYPE.定时触发;
            this.图表1.说明区背景色 = System.Drawing.Color.Transparent;
            this.图表1.饼图区显示内容 = new string[] {
        null};
            // 
            // 串口1
            // 
            this.串口1.COM口配置 = "COM2,115200,0,8,1";
            this.串口1.Name = null;
            this.串口1.PLC = ((uint)(0u));
            this.串口1.R_HDADDR = "";
            this.串口1.RL_HDADDR = "";
            this.串口1.ST_HDADDR = "";
            this.串口1.W_HDADDR = "";
            this.串口1.WL_HDADDR = "";
            this.串口1.拆分值 = null;
            this.串口1.拆分符 = ",";
            this.串口1.结束符 = PCHMI.串口.MyEnum.回车;
            this.串口1.默认发送内容 = null;
            // 
            // ucRollText1
            // 
            this.ucRollText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucRollText1.ISChangeReset = false;
            this.ucRollText1.Location = new System.Drawing.Point(220, 12);
            this.ucRollText1.MoveSleepTime = 100;
            this.ucRollText1.Name = "ucRollText1";
            this.ucRollText1.RollStyle = HZH_Controls.Controls.RollStyle.LeftToRight;
            this.ucRollText1.Size = new System.Drawing.Size(450, 30);
            this.ucRollText1.TabIndex = 6;
            this.ucRollText1.Text = "ucRollText1";
            // 
            // ucTextBoxEx1
            // 
            this.ucTextBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBoxEx1.ConerRadius = 5;
            this.ucTextBoxEx1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTextBoxEx1.DecLength = 2;
            this.ucTextBoxEx1.FillColor = System.Drawing.Color.Empty;
            this.ucTextBoxEx1.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTextBoxEx1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx1.InputText = "";
            this.ucTextBoxEx1.InputType = HZH_Controls.TextInputType.NotControl;
            this.ucTextBoxEx1.IsFocusColor = true;
            this.ucTextBoxEx1.IsFouceShowKey = false;
            this.ucTextBoxEx1.IsRadius = true;
            this.ucTextBoxEx1.IsShowClearBtn = true;
            this.ucTextBoxEx1.IsShowKeyboard = false;
            this.ucTextBoxEx1.IsShowRect = true;
            this.ucTextBoxEx1.IsShowSearchBtn = false;
            this.ucTextBoxEx1.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.ucTextBoxEx1.Location = new System.Drawing.Point(414, 261);
            this.ucTextBoxEx1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxEx1.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ucTextBoxEx1.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.ucTextBoxEx1.Name = "ucTextBoxEx1";
            this.ucTextBoxEx1.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxEx1.PasswordChar = '\0';
            this.ucTextBoxEx1.PromptColor = System.Drawing.Color.Gray;
            this.ucTextBoxEx1.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx1.PromptText = "";
            this.ucTextBoxEx1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucTextBoxEx1.RectWidth = 1;
            this.ucTextBoxEx1.RegexPattern = "";
            this.ucTextBoxEx1.Size = new System.Drawing.Size(322, 122);
            this.ucTextBoxEx1.TabIndex = 7;
            // 
            // graphicalOverlayComponent1
            // 
            this.graphicalOverlayComponent1.Owner = null;
            // 
            // tabControlExt1
            // 
            this.tabControlExt1.CloseBtnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(51)))));
            this.tabControlExt1.Controls.Add(this.tabPage1);
            this.tabControlExt1.Controls.Add(this.tabPage2);
            this.tabControlExt1.IsShowCloseBtn = false;
            this.tabControlExt1.ItemSize = new System.Drawing.Size(0, 50);
            this.tabControlExt1.Location = new System.Drawing.Point(328, 437);
            this.tabControlExt1.Name = "tabControlExt1";
            this.tabControlExt1.SelectedIndex = 0;
            this.tabControlExt1.Size = new System.Drawing.Size(342, 87);
            this.tabControlExt1.TabIndex = 8;
            this.tabControlExt1.UncloseTabIndexs = null;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(334, 29);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(334, 29);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // 仪表2
            // 
            this.仪表2.BaseArcColor = System.Drawing.Color.Gray;
            this.仪表2.BaseArcRadius = 80;
            this.仪表2.BaseArcStart = 135;
            this.仪表2.BaseArcSweep = 270;
            this.仪表2.BaseArcWidth = 2;
            this.仪表2.Cap_Idx = ((byte)(1));
            this.仪表2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.仪表2.CapPosition = new System.Drawing.Point(10, 10);
            this.仪表2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.仪表2.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.仪表2.CapText = "";
            this.仪表2.Center = new System.Drawing.Point(100, 100);
            this.仪表2.HDADDR = "";
            this.仪表2.Location = new System.Drawing.Point(414, 225);
            this.仪表2.MaxValue = 400F;
            this.仪表2.MinValue = -100F;
            this.仪表2.Name = "仪表2";
            this.仪表2.NeedleColor1 = PCHMI.仪表.NeedleColorEnum.Gray;
            this.仪表2.NeedleColor2 = System.Drawing.Color.DarkRed;
            this.仪表2.NeedleRadius = 80;
            this.仪表2.NeedleType = 0;
            this.仪表2.NeedleWidth = 2;
            this.仪表2.PLC = ((uint)(0u));
            this.仪表2.Range_Idx = ((byte)(0));
            this.仪表2.RangeColor = System.Drawing.Color.YellowGreen;
            this.仪表2.RangeEnabled = true;
            this.仪表2.RangeEndValue = 300F;
            this.仪表2.RangeInnerRadius = 70;
            this.仪表2.RangeOuterRadius = 80;
            this.仪表2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.YellowGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.仪表2.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.仪表2.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.仪表2.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.仪表2.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.仪表2.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.仪表2.RangeStartValue = -100F;
            this.仪表2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.仪表2.ScaleLinesInterInnerRadius = 73;
            this.仪表2.ScaleLinesInterOuterRadius = 80;
            this.仪表2.ScaleLinesInterWidth = 1;
            this.仪表2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.仪表2.ScaleLinesMajorInnerRadius = 70;
            this.仪表2.ScaleLinesMajorOuterRadius = 80;
            this.仪表2.ScaleLinesMajorStepValue = 50F;
            this.仪表2.ScaleLinesMajorWidth = 2;
            this.仪表2.ScaleLinesMinorColor = System.Drawing.Color.DarkRed;
            this.仪表2.ScaleLinesMinorInnerRadius = 75;
            this.仪表2.ScaleLinesMinorNumOf = 9;
            this.仪表2.ScaleLinesMinorOuterRadius = 80;
            this.仪表2.ScaleLinesMinorWidth = 1;
            this.仪表2.ScaleNumbersColor = System.Drawing.Color.WhiteSmoke;
            this.仪表2.ScaleNumbersFormat = null;
            this.仪表2.ScaleNumbersRadius = 95;
            this.仪表2.ScaleNumbersRotation = 0;
            this.仪表2.ScaleNumbersStartScaleLine = 0;
            this.仪表2.ScaleNumbersStepScaleLines = 1;
            this.仪表2.Size = new System.Drawing.Size(228, 206);
            this.仪表2.TabIndex = 9;
            this.仪表2.Text = "仪表2";
            this.仪表2.Value = 0F;
            this.仪表2.小数位数 = ((uint)(0u));
            this.仪表2.数据类型 = PCHMI.仪表.DatType.INT16;
            // 
            // ucHorizontalList1
            // 
            this.ucHorizontalList1.DataSource = null;
            this.ucHorizontalList1.IsAutoSelectFirst = true;
            this.ucHorizontalList1.Location = new System.Drawing.Point(215, 196);
            this.ucHorizontalList1.Name = "ucHorizontalList1";
            this.ucHorizontalList1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucHorizontalList1.SelectedItem = null;
            this.ucHorizontalList1.Size = new System.Drawing.Size(514, 143);
            this.ucHorizontalList1.TabIndex = 10;
            // 
            // uiSignal1
            // 
            this.uiSignal1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSignal1.Location = new System.Drawing.Point(42, 139);
            this.uiSignal1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSignal1.Name = "uiSignal1";
            this.uiSignal1.Size = new System.Drawing.Size(35, 35);
            this.uiSignal1.TabIndex = 11;
            this.uiSignal1.Text = "uiSignal1";
            this.uiSignal1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(664, 431);
            this.dataGridView1.TabIndex = 12;
            this.scrollbarComponent1.SetUserCustomScrollbar(this.dataGridView1, true);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 549);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uiSignal1);
            this.Controls.Add(this.ucHorizontalList1);
            this.Controls.Add(this.仪表2);
            this.Controls.Add(this.tabControlExt1);
            this.Controls.Add(this.ucTextBoxEx1);
            this.Controls.Add(this.ucRollText1);
            this.Controls.Add(this.图表1);
            this.Controls.Add(this.仪表1);
            this.Controls.Add(this.标签1);
            this.Controls.Add(this.按钮1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlExt1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private PCHMI.按钮 按钮1;
        private PCHMI.标签 标签1;
        private PCHMI.仪表 仪表1;
        private PCHMI.图表 图表1;
        private PCHMI.串口 串口1;
        private HZH_Controls.Controls.UCRollText ucRollText1;
        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxEx1;
        private HZH_Controls.Controls.GraphicalOverlayComponent graphicalOverlayComponent1;
        private HZH_Controls.Controls.ScrollbarComponent scrollbarComponent1;
        private HZH_Controls.Controls.TabControlExt tabControlExt1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private PCHMI.仪表 仪表2;
        private HZH_Controls.Controls.UCHorizontalList ucHorizontalList1;
        private Sunny.UI.UISignal uiSignal1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

