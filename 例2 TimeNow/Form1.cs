using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace 例2_TimeNow
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        public long LogYear, LogMonth, LogDay, LogHour, LogMinte, LogSencon;

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            textBox2.Text ="2022/2/4 00:00:00"+" 星期五";
            timer1.Enabled = true;//开启时间控件
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime GetTime = DateTime.Now;
            DateTime StaOnTime = Convert.ToDateTime(Convert.ToDateTime("2022-2-4 00:00:00"));
            txtYear.Text = DateAndTime.DateDiff(
                "yyyy", GetTime, StaOnTime,
                FirstDayOfWeek.Saturday,
                FirstWeekOfYear.FirstFourDays).ToString();
            txtMonth.Text = DateAndTime.DateDiff(
                "m", GetTime, StaOnTime,
                FirstDayOfWeek.Saturday,
                FirstWeekOfYear.FirstFourDays).ToString();
            txtDay.Text = DateAndTime.DateDiff(
                "d", GetTime, StaOnTime,
                FirstDayOfWeek.Saturday,
                FirstWeekOfYear.FirstFourDays).ToString();
            txtHour.Text = DateAndTime.DateDiff(
                "H", GetTime, StaOnTime,
                FirstDayOfWeek.Saturday,
                FirstWeekOfYear.FirstFourDays).ToString();
            txtMintue.Text = DateAndTime.DateDiff(
                "m", GetTime, StaOnTime,
                FirstDayOfWeek.Saturday,
                FirstWeekOfYear.FirstFourDays).ToString();
            txtSecon.Text = DateAndTime.DateDiff(
                "s", GetTime, StaOnTime,
                FirstDayOfWeek.Saturday,
                FirstWeekOfYear.FirstFourDays).ToString();

            textBox1.Text = DateTime.Now.ToString();
        }

    }

}
