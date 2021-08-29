/*
 * 由SharpDevelop创建。
 * 用户： liyan
 * 日期: 2021/10/5
 * 时间: 9:30
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace 图形化导航界面
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        private void button1_Click(object sender, EventArgs e)
        {
			button4.Visible = true;
			button5.Visible = true;
			button6.Visible = true;
		}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
			button7.Visible = true;
			button8.Visible = true;
			button9.Visible = true;
		}

        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 显示按钮ToolStripMenuItem_Click(object sender, EventArgs e)
        {
			button10.Visible = true;
			button11.Visible = true;
			button12.Visible = true;
		}
    }
}
