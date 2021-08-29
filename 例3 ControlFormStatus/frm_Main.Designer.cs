
using System;

namespace 例3_ControlFormStatus
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
            this.panel_Title = new System.Windows.Forms.Panel();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.pictureBox_Max = new System.Windows.Forms.PictureBox();
            this.pictureBox_Min = new System.Windows.Forms.PictureBox();
            this.panel_All = new System.Windows.Forms.Panel();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.pictureBox_Close);
            this.panel_Title.Controls.Add(this.pictureBox_Max);
            this.panel_Title.Controls.Add(this.pictureBox_Min);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(306, 37);
            this.panel_Title.TabIndex = 2;
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Close.Location = new System.Drawing.Point(259, 8);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Close.TabIndex = 2;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Tag = "2";
            this.pictureBox_Close.Click += new System.EventHandler(this.PictureBox_Close_Click);
            this.pictureBox_Close.MouseEnter += new System.EventHandler(this.PictureBox_Close_MouseEnter);
            this.pictureBox_Close.MouseLeave += new System.EventHandler(this.PictureBox_Close_MouseLeave);
            // 
            // pictureBox_Max
            // 
            this.pictureBox_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Max.Location = new System.Drawing.Point(218, 8);
            this.pictureBox_Max.Name = "pictureBox_Max";
            this.pictureBox_Max.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Max.TabIndex = 1;
            this.pictureBox_Max.TabStop = false;
            this.pictureBox_Max.Tag = "1";
            this.pictureBox_Max.Click += new System.EventHandler(this.PictureBox_Close_Click);
            this.pictureBox_Max.MouseEnter += new System.EventHandler(this.PictureBox_Close_MouseEnter);
            this.pictureBox_Max.MouseLeave += new System.EventHandler(this.PictureBox_Close_MouseLeave);
            // 
            // pictureBox_Min
            // 
            this.pictureBox_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Min.Location = new System.Drawing.Point(177, 8);
            this.pictureBox_Min.Name = "pictureBox_Min";
            this.pictureBox_Min.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Min.TabIndex = 0;
            this.pictureBox_Min.TabStop = false;
            this.pictureBox_Min.Tag = "0";
            this.pictureBox_Min.Click += new System.EventHandler(this.PictureBox_Close_Click);
            this.pictureBox_Min.MouseEnter += new System.EventHandler(this.PictureBox_Close_MouseEnter);
            this.pictureBox_Min.MouseLeave += new System.EventHandler(this.PictureBox_Close_MouseLeave);
            // 
            // panel_All
            // 
            this.panel_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_All.Location = new System.Drawing.Point(0, 37);
            this.panel_All.Name = "panel_All";
            this.panel_All.Size = new System.Drawing.Size(306, 163);
            this.panel_All.TabIndex = 1;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 200);
            this.Controls.Add(this.panel_All);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加载一个图形的窗体";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.panel_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.PictureBox pictureBox_Max;
        private System.Windows.Forms.PictureBox pictureBox_Min;
        private System.Windows.Forms.Panel panel_All;
    }
}

