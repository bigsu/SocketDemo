using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SocketClient
{
    public partial class FrmTcpClient : Form
    {
        public FrmTcpClient()
        {
            InitializeComponent();
        }

        private void iTcpClient1_OnRecevice(object sender, NetWorkHelper.ICommond.TcpClientReceviceEventArgs e)
        {
            
            if (e.Data.Length > 0)
            {
                //MemoryStream ms = new MemoryStream(iTcpClient1.Client.BufferInfo.ReceivedBuffer);
                //panel1.BackgroundImage = Image.FromStream(ms);
                //ms.Close();
                //ms.Dispose();
                // MessageBox.Show(Encoding.Default.GetString(e.Data));
            }
        }

        private void FrmTcpClient_Load(object sender, EventArgs e)
        {
            iTcpClient1.StartConnect();
        }
    }
}
