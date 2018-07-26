using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Demo
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
           
            InitializeComponent();
            axUdpClient1.LocalPort = 8888;
            axUdpClient1.RemoteIp = IPAddress.Broadcast.ToString();
            axUdpClient1.RemotePort = 9999;
            axUdpClient1.Start();
            Control.CheckForIllegalCrossThreadCalls = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //屏幕宽
            int iWidth = Screen.PrimaryScreen.Bounds.Width;
            //屏幕高
            int iHeight = Screen.PrimaryScreen.Bounds.Height;
            //按照屏幕宽高创建位图
            Thread th = new Thread(c =>
            {

                //while (true)
                //{
                Bitmap image = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics imgGraphics = Graphics.FromImage(image);
                //设置截屏区域
                imgGraphics.CopyFromScreen(0, 0, 0, 0, new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));
                axUdpClient1.SendImage(image);
                panel1.BackgroundImage = image;
                //   }
            });
            th.IsBackground = true;
            th.Start();
        }
        
    }
}
