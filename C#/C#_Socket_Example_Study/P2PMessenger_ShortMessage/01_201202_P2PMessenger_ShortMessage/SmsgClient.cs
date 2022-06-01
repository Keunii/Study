using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace _01_201202_P2PMessenger_ShortMessage
{
    public class SmsgClient
    {
        public static void SendMsg(string other_ip, int other_port, string text)
        {
            try
            {
                byte[] packet = new byte[1024];
                MemoryStream ms = new MemoryStream(packet);
                BinaryWriter bw = new BinaryWriter(ms);
                bw.Write(text);
                bw.Close();
                ms.Close();

                Socket sock = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(other_ip), other_port);
                sock.Connect(ipep);
                sock.Send(packet);
                sock.Close();
            }
            catch { }
        }

        delegate void SendDele(string other_ip, int other_port, string text);
        public static void SendMsgAsync(string other_ip, int other_port, string text)
        {
            SendDele dele = SendMsg;
            dele.BeginInvoke(other_ip, other_port, text, null, null);
        }
    }
}