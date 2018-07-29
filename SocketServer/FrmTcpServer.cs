using NetWorkHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Demo
{
    public partial class FrmTcpServer : Form
    {
        public FrmTcpServer()
        {
            InitializeComponent();
            iTcpServer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
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
                for (int i = 0; i < iTcpServer1.ClientSocketList.Count; i++)
                {
                    iTcpServer1.SendData(iTcpServer1.ClientSocketList[i], ImageHelper.ImageToBytes(image));
                }
                panel1.BackgroundImage = image;
                //   }
            });
            th.IsBackground = true;
            th.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < iTcpServer1.ClientSocketList.Count; i++)
            {
                iTcpServer1.SendData(iTcpServer1.ClientSocketList[i],"123");
            }
        }
    }
}
