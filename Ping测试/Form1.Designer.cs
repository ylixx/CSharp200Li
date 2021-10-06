
namespace Ping测试
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
            this.bnt_Ping = new System.Windows.Forms.Button();
            this.lst_PingResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bnt_Ping
            // 
            this.bnt_Ping.Location = new System.Drawing.Point(64, 274);
            this.bnt_Ping.Name = "bnt_Ping";
            this.bnt_Ping.Size = new System.Drawing.Size(75, 23);
            this.bnt_Ping.TabIndex = 0;
            this.bnt_Ping.Text = "测试";
            this.bnt_Ping.UseVisualStyleBackColor = true;
            this.bnt_Ping.Click += new System.EventHandler(this.bnt_Ping_Click);
            // 
            // lst_PingResult
            // 
            this.lst_PingResult.FormattingEnabled = true;
            this.lst_PingResult.ItemHeight = 12;
            this.lst_PingResult.Location = new System.Drawing.Point(22, 118);
            this.lst_PingResult.Name = "lst_PingResult";
            this.lst_PingResult.Size = new System.Drawing.Size(175, 136);
            this.lst_PingResult.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "测试IP：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "测试结果：";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(24, 55);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(173, 21);
            this.txt_IP.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 316);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_PingResult);
            this.Controls.Add(this.bnt_Ping);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_Ping;
        private System.Windows.Forms.ListBox lst_PingResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IP;
    }
}

