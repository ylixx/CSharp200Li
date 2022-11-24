namespace UserImageList
{
    partial class Form_Main
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_PassWord = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Logout = new System.Windows.Forms.Button();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(481, 94);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(72, 120);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(47, 12);
            this.label_UserName.TabIndex = 1;
            this.label_UserName.Text = "用户名:";
            // 
            // label_PassWord
            // 
            this.label_PassWord.AutoSize = true;
            this.label_PassWord.Location = new System.Drawing.Point(72, 152);
            this.label_PassWord.Name = "label_PassWord";
            this.label_PassWord.Size = new System.Drawing.Size(47, 12);
            this.label_PassWord.TabIndex = 2;
            this.label_PassWord.Text = "密  码:";
            this.label_PassWord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(108, 211);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Login.TabIndex = 3;
            this.button_Login.Text = "登录";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Logout
            // 
            this.button_Logout.Location = new System.Drawing.Point(309, 211);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(75, 23);
            this.button_Logout.TabIndex = 4;
            this.button_Logout.Text = "取消";
            this.button_Logout.UseVisualStyleBackColor = true;
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(153, 117);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(231, 21);
            this.textBox_UserName.TabIndex = 5;
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.Location = new System.Drawing.Point(153, 149);
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.Size = new System.Drawing.Size(231, 21);
            this.textBox_PassWord.TabIndex = 6;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 247);
            this.Controls.Add(this.textBox_PassWord);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.label_PassWord);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.listView1);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label_PassWord;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_PassWord;
    }
}

