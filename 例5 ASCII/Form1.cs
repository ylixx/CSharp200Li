using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例5_ASCII
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_ToAscii_Click(object sender, EventArgs e)
        {
            if (txt_char.Text!=string.Empty)//如果输入不为空
            {
                if (Encoding.GetEncoding("unicode").GetBytes(new char[] {txt_char.Text[0]})[1]==0)//判断输入的是否非字母
                {
                    //得到字符ASCII的码值
                    txt_Ascii.Text = Encoding.GetEncoding("unicode").GetBytes(txt_char.Text)[0].ToString();
                }
                else
                {
                    txt_Ascii.Text = string.Empty;//输出空字符串
                    MessageBox.Show("请输入字母！","提示！");
                }
            }
            else
            {
                MessageBox.Show("请输入需要转换的字母！","提示！");
            }

        }

        private void btn_ToChar_Click(object sender, EventArgs e)
        {
            if (txt_Ascii2.Text!=string.Empty)
            {
                int intNum;
                if (int.TryParse(txt_Ascii2.Text,out intNum))
                {
                    txt_Char2.Text = ((char)intNum).ToString();
                }
                else
                {
                    MessageBox.Show("请输入正确的ASCII码值","错误！");
                }
            }
            else
            {
                MessageBox.Show("请输入需要转换的数字！", "提示！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Chinese.Text!=string.Empty)
            {
                try
                {
                    txt_Num.Text = getCode(txt_Chinese.Text);
                }
                catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message+"请输入正确的汉字","出错！");
                    throw;
                }

            }
        }
        public string getCode(string Chinese)
        {
            byte[] P_bt_array = Encoding.Default.GetBytes(Chinese);
            int front = (short)(P_bt_array[0] - '\0');
            int back = (short)(P_bt_array[1] - '\0');
            return (front - 160).ToString() + (back - 160).ToString();
        }
    }
}
