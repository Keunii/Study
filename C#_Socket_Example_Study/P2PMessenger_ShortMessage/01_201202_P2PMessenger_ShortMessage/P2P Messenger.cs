using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_201202_P2PMessenger_ShortMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_My_Set_Click(object sender, EventArgs e)
        {
            string ip = tBox_My_IP.Text;
            int port = 0;

            if (int.TryParse(tBox_My_Port.Text, out port) == false)
            {
                MessageBox.Show("포트를 잘못 입력하였습니다.");
                return;
            }

            SmsgServer sms = new SmsgServer(ip, port);
            sms.SmsgRecvEventHandler += Sms_SmsgRecvEventHandler;

            if (sms.Start() == false) { MessageBox.Show("숏 메시지 서버 가동 실패!"); }
            else { tBox_My_IP.Enabled = tBox_My_Port.Enabled = btn_My_Set.Enabled = false; }
        }

        private void Sms_SmsgRecvEventHandler(object sender, SmsgRecvEventArgs e)
        {
            AddMessage(string.Format("{0}:{1} → {2}", e.IPstr, e.Port, e.Msg));
        }

        delegate void MyDele(string msg);
        private void AddMessage(string msg)
        {
            if (lBox_Msg.InvokeRequired)
            {
                MyDele dele = AddMessage;
                object[] objs = new object[] { msg };
                lBox_Msg.BeginInvoke(dele, objs);
            }
            else { lBox_Msg.Items.Add(msg); }
        }

        string other_ip;
        int other_port = 10300;
        private void btn_Other_Set_Click(object sender, EventArgs e)
        {
            other_ip = tBox_Other_IP.Text;
            if (int.TryParse(tBox_Other_Port.Text, out other_port) == false)
            {
                MessageBox.Show("포트 번호를 정수로 변환할 수 없습니다.");
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            SmsgClient.SendMsgAsync(other_ip, other_port, tBox_Msg.Text);
            lBox_Msg.Items.Add(string.Format("{0}:{1} ← {2}", other_ip, other_port, tBox_Msg.Text));
            tBox_Msg.Text = "";
        }
    }
}
