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
using System.IO;

//https://blog.csdn.net/zhujunxxxxx/article/details/18798431
//https://www.cnblogs.com/MRRAOBX/articles/3289235.html

namespace UdpDemo
{
    public partial class FrmServer : Form
    {
        private UdpClient myUdpClient;

        //显示消息的委托
        //private delegate void ShowMsgCallBack(string msg);
        //private ShowMsgCallBack msgCallBack;

        public FrmServer()
        {
            InitializeComponent();
        }


        //窗体加载
        private void Form1_Load(object sender, EventArgs e)
        {
            //实例化udp客户端
            myUdpClient = new UdpClient(new IPEndPoint(GetLocalIP(), 55555));

            //启动消息接收线程
            //Thread thread = new Thread(ReceiveMsg);
            //thread.IsBackground = true;
            //thread.Start();


            //初始化回调
            //msgCallBack = new ShowMsgCallBack(ShowMsg);
        }

        //发送消息
        private void btnSend_Click(object sender, EventArgs e)
        {
            //给广播地址发送消息，由它转发给每个地址
            IPEndPoint broadCast = new IPEndPoint(IPAddress.Broadcast, 12345);
            byte[] data = Encoding.Default.GetBytes(txtMsg.Text);
            myUdpClient.Send(data, data.Length, broadCast);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            FrmClient frmClient = new FrmClient();
            frmClient.Show();
        }


        //消息接收线程
        //private void ReceiveMsg()
        //{
        //    IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, 0);
        //    while (true)
        //    {
        //        try
        //        {
        //            byte[] getData = myUdpClient.Receive(ref ipEndPoint);
        //            string msg = Encoding.Default.GetString(getData);
        //            txtReceive.Invoke(msgCallBack, msg);
        //        }
        //        catch (ThreadAbortException)
        //        {
        //        }
        //        catch (Exception e)
        //        {
        //            MessageBox.Show(e.Message);
        //        }
        //    }
        //}

        ////显示消息委托的方法
        //private void ShowMsg(string text)
        //{
        //    txtReceive.AppendText(text + "\r\n");
        //}


        public static IPAddress GetLocalIP()
        {
            try
            {
                string HostName = Dns.GetHostName(); //得到主机名
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    //从IP地址列表中筛选出IPv4类型的IP地址
                    //AddressFamily.InterNetwork表示此IP为IPv4,
                    //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        return IpEntry.AddressList[i];
                    }
                }
                return IPAddress.Parse("127.0.0.1");
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取本机IP出错:" + ex.Message);
                return IPAddress.Parse("127.0.0.1");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //给广播地址发送消息，由它转发给每个地址
            IPEndPoint broadCast = new IPEndPoint(IPAddress.Broadcast, 12345);
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    byte[] fileBuffer = File.ReadAllBytes(ofd.FileName);
                    {
                        myUdpClient.Send(fileBuffer, fileBuffer.Length, broadCast);
                    }
                }
            }      

        }



    }
}
