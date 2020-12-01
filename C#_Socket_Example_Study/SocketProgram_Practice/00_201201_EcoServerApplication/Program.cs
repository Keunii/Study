using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace _00_201201_EcoServerApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sock = null;
            try
            {
                sock = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                ); // 소켓 생성

                // 인터페이스와 결합
                IPAddress ipad = IPAddress.Parse("192.168.0.7");
                IPEndPoint ipep = new IPEndPoint(ipad, 10040);
                sock.Bind(ipep);

                // 백로그 큐 크기 설정
                sock.Listen(5);
                Socket dosock;

                while (true) // AccptLoop
                {
                    dosock = sock.Accept();
                    DoItAsync(dosock); // DoIt
                }
            }
            catch { }
            finally // 예외가 발생하던 안하던 소켓을 닫아라
            {
                sock.Close(); // 소켓 닫기
            }
        }

        delegate void DoItDele(Socket dosock);
        private static void DoItAsync(Socket dosock)
        {
            DoItDele dele = DoIt;
            dele.BeginInvoke(dosock, null, null);
        }

        private static void DoIt(Socket dosock)
        {
            try
            {
                byte[] packet = new byte[1024];
                IPEndPoint ipep = dosock.RemoteEndPoint as IPEndPoint;
                while (true)
                {
                    dosock.Receive(packet);
                    MemoryStream ms = new MemoryStream(packet);
                    BinaryReader br = new BinaryReader(ms);
                    string msg = br.ReadString();
                    br.Close();
                    ms.Close();

                    Console.WriteLine("{0}:{1} → {2}", ipep.Address, ipep.Port, msg);

                    if (msg == "exit")
                    {
                        break;
                    }
                    dosock.Send(packet);
                }
            }
            catch { }
            finally { dosock.Close(); }
        }
    }
}
