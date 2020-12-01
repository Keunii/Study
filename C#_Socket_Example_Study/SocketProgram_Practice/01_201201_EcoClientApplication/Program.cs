using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace _01_201201_EcoClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sock = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                ); // 소켓 생성
            // 인터페이스 결합(옵션)

            // 연결
            IPAddress ipad = IPAddress.Parse("192.168.0.7");
            //IPEndPoint ipep = new IPEndPoint(ipad, 10040);
            IPEndPoint ipep = new IPEndPoint(ipad, 10248);
            sock.Connect(ipep);

            string str1;
            string str2;
            byte[] packet1 = new byte[1024];
            byte[] packet2 = new byte[1024];

            while (true)
            {
                Console.Write("전송할 메시지 : ");
                str1 = Console.ReadLine();

                MemoryStream ms = new MemoryStream(packet1);
                BinaryWriter bw = new BinaryWriter(ms);
                bw.Write(str1);
                bw.Close();
                ms.Close();
                sock.Send(packet1);

                if (str1 == "exit")
                {
                    break;
                }

                sock.Receive(packet2);

                MemoryStream ms2 = new MemoryStream(packet2);
                BinaryReader br = new BinaryReader(ms2);
                str2 = br.ReadString();
                Console.WriteLine("수신한 메시지 : {0}", str2);
                br.Close();
                ms2.Close();
            }
            sock.Close(); // 소켓 닫기
        }
    }
}
