using STTech.BytesIO.Tcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Client
{
    public partial class Form1 : Form
    {
        //创建TCP客户端对象，STTech.BytesIO.Tcp.TcpClient
        private TcpClient tcpClient;
        public Form1()
        {
            InitializeComponent();
            //tcpClient  new一个实体对象
            tcpClient = new TcpClient();
            //将TcpClient类的属性置入propertyGrid1控件
            propertyGrid1.SelectedObject = tcpClient;

            //tcp接收数据时触发的事件
            tcpClient.OnDataReceived += TcpClient_OnDataReceived;
            //tcp连接成功时触发的事件
            tcpClient.OnConnectedSuccessfully += TcpClient_OnConnectedSuccessfully;
            //tcp连接断开时触发的事件
            tcpClient.OnDisconnected += TcpClient_OnDisconnected;

        }

        private void TcpClient_OnDisconnected(object sender, STTech.BytesIO.Core.DisconnectedEventArgs e)
        {
            Print($"已断开{e.ReasonCode}");
        }

        private void TcpClient_OnConnectedSuccessfully(object sender, STTech.BytesIO.Core.ConnectedSuccessfullyEventArgs e)
        {
            Print("连接成功");
        }

        private void TcpClient_OnDataReceived(object sender, STTech.BytesIO.Core.DataReceivedEventArgs e)
        {
            Print($"收到数据：{e.Data.EncodeToString("GBK")}");
        }
        private void btn_send_Click(object sender, EventArgs e)
        {//发送数据给服务端，编码格式为"GBK"：可发送中文；编码格式默认"UTF-8"：发送中文会有问题
            tcpClient.Send(richtbx_send.Text.GetBytes("GBK"));
        }
        private void Print(string msg)
        {
            //线程的修改直接更新到UI主线程是不被允许的，这里通过调用Form的Invoke方法跨线程访问控件
            this.Invoke(new Action(() =>
            {
                richtbx_log.AppendText($"[{DateTime.Now}] {msg}\r\n");
            }));

            //线程的修改直接更新到UI主线程是不被允许的，这里通过调用Form的Invoke方法跨线程访问控件
            this.Invoke(new Action(() =>
            {
                //调用控件做事
            }));
        }

        private void toolStrip_btn_connect_Click(object sender, EventArgs e)
        {//tcp连接
            tcpClient.Connect();
        }

        private void toolStrip_btn_diconnect_Click(object sender, EventArgs e)
        {//tcp断开连接
            tcpClient.Disconnect();
        }

        
    }
}
