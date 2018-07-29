using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using NetWorkHelper;

namespace SocketClient
{
    public partial class FrmUdpClient : Form
    {
        public FrmUdpClient()
        {
            InitializeComponent();
            //axUdpClient1.RemotePort = 8888;
            //axUdpClient1.RemoteIp = IPAddress.Any.ToString();
            //axUdpClient1.LocalPort = 9999;
            //axUdpClient1.Start();
        }

        private void axUdpClient1_ReceiveTextMsg(MsgTypeCell msgTypeCell)
        {
            switch (msgTypeCell.Msgtype)
            {
                case MsgType.TxtMsg:
                    MessageBox.Show(Encoding.Default.GetString(msgTypeCell.BufferBytes));
                    break;
                case MsgType.Pic:
                    //if (msgTypeCell.BufferBytes.Length > 0)
                    //{
                    //    MemoryStream ms = new MemoryStream(msgTypeCell.BufferBytes);

                    //    panel1.BackgroundImage = Image.FromStream(ms);
                    //    ms.Close();
                    //    ms.Dispose();
                    //}
                    break;

            }
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            //UdpClient client = new UdpClient(new IPEndPoint(IPAddress.Any, 8888));//端口要与发送端相同
            //Thread thread = new Thread(receiveUdpMsg);//用线程接收，避免UI卡住
            //thread.IsBackground = true;
            //thread.Start(client);
        }
        void receiveUdpMsg(object obj)
        {
            UdpClient client = obj as UdpClient;
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                client.BeginReceive(delegate (IAsyncResult result)
                {
                    Console.WriteLine(result.AsyncState.ToString());//委托接收消息
                }, Encoding.UTF8.GetString(client.Receive(ref endpoint)));
            }
        }
    }
}
