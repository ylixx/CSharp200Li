using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
namespace Ping测试
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_Ping_Click(object sender, EventArgs e)
        {
            //清空列表框信息
            this.lst_PingResult.Items.Clear();
            //清空多余字符并赋值ipStr
            string ipStr = txt_IP.Text.ToString().Trim();
            //创建ping实例
            Ping pingSender = new Ping();
            //ping 选项设置
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            int timeout = 120;
            //测试数据
            string data = "xxx";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            //调用send方法发送数据，将返回结果保存至pingReply实例
            PingReply reply = pingSender.Send(ipStr, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                lst_PingResult.Items.Add("答复的主机地址：" + reply.Address.ToString());
                lst_PingResult.Items.Add("往返时间：" + reply.RoundtripTime);
                lst_PingResult.Items.Add("生存时间TTL：" + reply.Options.Ttl);
                lst_PingResult.Items.Add("是否控制数据包的分段：" + reply.Options.DontFragment);
                lst_PingResult.Items.Add("缓冲区大小：" + reply.Buffer.Length);
            }
            else
            {
                lst_PingResult.Items.Add(reply.Status.ToString());
            }
        }
    }
}
