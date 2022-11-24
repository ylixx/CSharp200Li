using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sunny.UI;

namespace GetShengXiao
{
    public partial class Frm_Main : UIForm
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Globalization.ChineseLunisolarCalendar chinseCaleander = new System.Globalization.ChineseLunisolarCalendar();
            string TreeYeaer = "鼠牛虎兔龙蛇马羊猴鸡狗猪";
            int intYear = chinseCaleander.GetSexagenaryYear(DateTime.Now);
            string Tree = TreeYeaer.Substring(chinseCaleander.GetTerrestrialBranch(intYear)-1, 1);
            MessageBox.Show("今年是十二生肖"+Tree+"年","判断十二生肖",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

        private void sunnyui_Click(object sender, EventArgs e)
        {
            //int tian;
            //int zhou;
            //int yu;
            //tian=Convert.ToInt16(uiTextBox1.Text);
            //zhou = tian / 7;
            //yu = tian % 7;
            //if (yu == 0)
            //{
            //    uiLabel3.Text = "共：" + Convert.ToString(zhou) + "周整";
            //}
            // else
            //{ 
            //    uiLabel3.Text = "共：" + Convert.ToString(zhou) + "周零" + Convert.ToString(yu) + "天";
            //}
            int day;
            int week;
            int mod;
            day = Convert.ToInt16(uiTextBox1.Text);
            week = day / 7;
            mod = day % 7;
            if (mod==0)
            {
                uiLabel3.Text = "共：" + Convert.ToString(week) + "周整";

            }
            else
            {
                uiLabel3.Text = "共：" + Convert.ToString(week) + "周零" + Convert.ToString(mod) + "天";
            }
        }
    }
}
