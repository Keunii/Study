using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace _02_201201_EcoServerApplication_DefineClass
{
    public class EchoServer
    {
        public event AcceptedEventHandler AcceptedEventHandler = null;
        public event ClosedEventHandler ClosedEventHandler = null;
        public event ReceivedMsgEventHandler ReceivedMsgEventHandler = null;
        public string IPStr
        {
            get;
            private set;
        }
        public int Port
        {
            get;
            private set;
        }

        public EchoServer(string ipstr, int port)
        {

            IPStr = ipstr;
            Port = port;
        }

        Socket sock = null;
        internal bool Start()
        {
             sock = null;
            try
            {
                sock = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                ); // 소켓 생성

                // 인터페이스와 결합
                IPAddress ipad = IPAddress.Parse(IPStr);
                IPEndPoint ipep = new IPEndPoint(ipad, Port);
                sock.Bind(ipep);

                // 백로그 큐 크기 설정
                sock.Listen(5);

                AcceptLoopAsyn(); // 비동기적으로 수행

                return true;
            }
            catch { return false; }
        }

        public void Close()
        {
            if (sock != null)
            {
                try { sock.Close(); }
                catch { }
            }
        }

        delegate void AcceptDele();
        private void AcceptLoopAsyn()
        {
            AcceptDele dele = AcceptLoop;
            dele.BeginInvoke(null, null);
        }
        
        void AcceptLoop()
        {
            Socket dosock = null;
            while (true)
            {
                dosock = sock.Accept();
                DoItAsync(dosock);
            }
        }

        delegate void DoItDele(Socket dosock);
        private void DoItAsync(Socket dosock)
        {
            DoItDele dele = DoIt;
            dele.BeginInvoke(dosock, null, null);
        }

        private void DoIt(Socket dosock)
        {
            IPEndPoint remote_ep = dosock.RemoteEndPoint as IPEndPoint;
            if (AcceptedEventHandler != null)
            {
                AcceptedEventHandler(this, new AcceptedEventArgs(remote_ep));
            }

            try
            {
                byte[] packet = new byte[1024];
                while (true)
                {
                    dosock.Receive(packet);
                    MemoryStream ms = new MemoryStream(packet);
                    BinaryReader br = new BinaryReader(ms);
                    string msg = br.ReadString();
                    br.Close();
                    ms.Close();

                    if (ReceivedMsgEventHandler != null)
                    {
                        ReceivedMsgEventHandler(this, new ReceivedMsgEventArgs(remote_ep, msg));
                    }
                    dosock.Send(packet);
                }
            }
            catch { }
            finally
            {
                dosock.Close();
                if (ClosedEventHandler != null)
                {
                    ClosedEventHandler(this, new ClosedEventArgs(remote_ep));
                }
            }
        }
    }
}