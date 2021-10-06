
namespace 例5_ASCII
{
    partial class Frm_Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ToAscii = new System.Windows.Forms.Button();
            this.btn_ToChar = new System.Windows.Forms.Button();
            this.txt_char = new System.Windows.Forms.TextBox();
            this.txt_Ascii2 = new System.Windows.Forms.TextBox();
            this.txt_Ascii = new System.Windows.Forms.TextBox();
            this.txt_Char2 = new System.Windows.Forms.TextBox();
            this.txt_Chinese = new System.Windows.Forms.TextBox();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Char2);
            this.groupBox1.Controls.Add(this.txt_Ascii);
            this.groupBox1.Controls.Add(this.txt_Ascii2);
            this.groupBox1.Controls.Add(this.txt_char);
            this.groupBox1.Controls.Add(this.btn_ToChar);
            this.groupBox1.Controls.Add(this.btn_ToAscii);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "字母与ASCII相互转换";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_Num);
            this.groupBox2.Controls.Add(this.txt_Chinese);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "汉字与区位码的转换";
            // 
            // btn_ToAscii
            // 
            this.btn_ToAscii.Location = new System.Drawing.Point(141, 44);
            this.btn_ToAscii.Name = "btn_ToAscii";
            this.btn_ToAscii.Size = new System.Drawing.Size(106, 23);
            this.btn_ToAscii.TabIndex = 0;
            this.btn_ToAscii.Text = "转换为ASCII码";
            this.btn_ToAscii.UseVisualStyleBackColor = true;
            this.btn_ToAscii.Click += new System.EventHandler(this.btn_ToAscii_Click);
            // 
            // btn_ToChar
            // 
            this.btn_ToChar.Location = new System.Drawing.Point(141, 90);
            this.btn_ToChar.Name = "btn_ToChar";
            this.btn_ToChar.Size = new System.Drawing.Size(106, 23);
            this.btn_ToChar.TabIndex = 1;
            this.btn_ToChar.Text = "转换为字母";
            this.btn_ToChar.UseVisualStyleBackColor = true;
            this.btn_ToChar.Click += new System.EventHandler(this.btn_ToChar_Click);
            // 
            // txt_char
            // 
            this.txt_char.Location = new System.Drawing.Point(25, 44);
            this.txt_char.Name = "txt_char";
            this.txt_char.Size = new System.Drawing.Size(100, 21);
            this.txt_char.TabIndex = 2;
            // 
            // txt_Ascii2
            // 
            this.txt_Ascii2.Location = new System.Drawing.Point(25, 92);
            this.txt_Ascii2.Name = "txt_Ascii2";
            this.txt_Ascii2.Size = new System.Drawing.Size(100, 21);
            this.txt_Ascii2.TabIndex = 3;
            // 
            // txt_Ascii
            // 
            this.txt_Ascii.Location = new System.Drawing.Point(271, 44);
            this.txt_Ascii.Name = "txt_Ascii";
            this.txt_Ascii.Size = new System.Drawing.Size(100, 21);
            this.txt_Ascii.TabIndex = 4;
            // 
            // txt_Char2
            // 
            this.txt_Char2.Location = new System.Drawing.Point(271, 90);
            this.txt_Char2.Name = "txt_Char2";
            this.txt_Char2.Size = new System.Drawing.Size(100, 21);
            this.txt_Char2.TabIndex = 5;
            // 
            // txt_Chinese
            // 
            this.txt_Chinese.Location = new System.Drawing.Point(141, 44);
            this.txt_Chinese.Name = "txt_Chinese";
            this.txt_Chinese.Size = new System.Drawing.Size(206, 21);
            this.txt_Chinese.TabIndex = 0;
            // 
            // txt_Num
            // 
            this.txt_Num.Location = new System.Drawing.Point(141, 98);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(206, 21);
            this.txt_Num.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "输入汉字：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "获取区位码";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 347);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Frm_Main";
            this.Text = "例5 码转换";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Char2;
        private System.Windows.Forms.TextBox txt_Ascii;
        private System.Windows.Forms.TextBox txt_Ascii2;
        private System.Windows.Forms.TextBox txt_char;
        private System.Windows.Forms.Button btn_ToChar;
        private System.Windows.Forms.Button btn_ToAscii;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.TextBox txt_Chinese;
    }
}

