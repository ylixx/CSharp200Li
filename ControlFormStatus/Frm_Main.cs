using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlFormStatus
{
    public partial class Frm_Main : Form
    {
        private Panel panel_Title;
        private PictureBox pictureBox_Close;
        private PictureBox pictureBox_Max;
        private PictureBox pictureBox_Min;
        private Panel panel_All;

        public Frm_Main()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel_Title = new System.Windows.Forms.Panel();
            this.panel_All = new System.Windows.Forms.Panel();
            this.pictureBox_Min = new System.Windows.Forms.PictureBox();
            this.pictureBox_Max = new System.Windows.Forms.PictureBox();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.pictureBox_Close);
            this.panel_Title.Controls.Add(this.pictureBox_Max);
            this.panel_Title.Controls.Add(this.pictureBox_Min);
            this.panel_Title.Location = new System.Drawing.Point(3, 2);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(298, 37);
            this.panel_Title.TabIndex = 0;
            // 
            // panel_All
            // 
            this.panel_All.Location = new System.Drawing.Point(2, 40);
            this.panel_All.Name = "panel_All";
            this.panel_All.Size = new System.Drawing.Size(298, 160);
            this.panel_All.TabIndex = 0;
            // 
            // pictureBox_Min
            // 
            this.pictureBox_Min.Location = new System.Drawing.Point(204, 7);
            this.pictureBox_Min.Name = "pictureBox_Min";
            this.pictureBox_Min.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Min.TabIndex = 0;
            this.pictureBox_Min.TabStop = false;
            // 
            // pictureBox_Max
            // 
            this.pictureBox_Max.Location = new System.Drawing.Point(233, 7);
            this.pictureBox_Max.Name = "pictureBox_Max";
            this.pictureBox_Max.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Max.TabIndex = 0;
            this.pictureBox_Max.TabStop = false;
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Location = new System.Drawing.Point(263, 7);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Close.TabIndex = 0;
            this.pictureBox_Close.TabStop = false;
            // 
            // Frm_Main
            // 
            this.ClientSize = new System.Drawing.Size(302, 201);
            this.Controls.Add(this.panel_All);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Main";
            this.panel_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);
            
        }
        private void Frm_Main_Load(object sender,EventArgs e)
        {
            this.Width = Properties.Resources.登录界面标题.Width;
            this.Height = Properties.Resources.登录界面标题.Height + Properties.Resources.登录界面下面.Height;
            panel_Title.BackgroundImage = Properties.Resources.登录界面标题;
            panel_All.BackgroundImage = Properties.Resources.登录界面下面;
            pictureBox_Min.Image = null;
            pictureBox_Min.Image = Properties.Resources.最小化按钮;
            pictureBox_Max.Image = null;
            pictureBox_Max.Image= Properties.Resources.最大化按钮;
            pictureBox_Close.Image = null;
            pictureBox_Close.Image = Properties.Resources.关闭按钮;
        }
    }
}
