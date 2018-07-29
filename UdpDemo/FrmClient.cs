using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace UdpDemo
{
    public partial class FrmClient : Form
    {
        private UdpClient myUdpClient;

        //显示消息的委托
        private delegate void ShowMsgCallBack(string msg);
        private ShowMsgCallBack msgCallBack;

        public FrmClient()
        {
            InitializeComponent();
        }



        //窗体加载
        private void Form1_Load(object sender, EventArgs e)
        {
            //创建监听(通信对象)的udp客户端   --这一步相当于连接服务器
            myUdpClient = new UdpClient(new IPEndPoint(IPAddress.Any, 12345));
            
            //启动消息接收线程
            Thread thread = new Thread(ReceiveMsg);
            thread.IsBackground = true;
            thread.Start();

            //初始化回调，显示消息
            msgCallBack = new ShowMsgCallBack(ShowMsg);
        }

        //接收消息线程
        private void ReceiveMsg()
        {
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                try
                {
                    byte[] getData = myUdpClient.Receive(ref ipEndPoint);
                    string msg = Encoding.Default.GetString(getData);
                    txtReceive.Invoke(msgCallBack, msg);
                }
                catch (ThreadAbortException)
                {
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        //委托显示消息的方法
        private void ShowMsg(string text)
        {
            txtReceive.AppendText(text + "\r\n");
        }


        //发送消息
        private void btnSend_Click(object sender, EventArgs e)
        {
            //IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Broadcast, 12345);
            //byte[] data = Encoding.Default.GetBytes(txtMsg.Text);
            //myUdpClient.Send(data, data.Length, iPEndPoint);
        }
    }
}
