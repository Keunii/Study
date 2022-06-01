using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace _02_201201_EcoServerApplication_DefineClass
{
    class Program
    {
        static void Main(string[] args) // 서버를 라이브러리 상태로 남겨져 있다면, 서버를 끊거나 연결할 때 유용(?)
        {
            EchoServer es = new EchoServer("192.168.0.7", 10248);
            es.ReceivedMsgEventHandler += Es_ReceivedMsgEventHandler;
            es.AcceptedEventHandler += Es_AcceptedEventHandler;
            es.ClosedEventHandler += Es_ClosedEventHandler;

            if (es.Start() == false)
            {
                Console.WriteLine("서버 가동 실패");
                return;
            }
            Console.ReadKey();
        }

        private static void Es_ClosedEventHandler(object sender, ClosedEventArgs e)
        {
            Console.WriteLine("{0}:{1}에서 연결을 닫음", e.IPStr, e.Prot);
        }

        private static void Es_ReceivedMsgEventHandler(object sender, ReceivedMsgEventArgs e)
        {
            Console.WriteLine("{0}:{1} → {2} ", e.IPStr, e.Prot, e.Msg);
        }

        private static void Es_AcceptedEventHandler(object sender, AcceptedEventArgs e)
        {
            Console.WriteLine("{0}:{1}에서 연결 했음", e.IPStr, e.Prot);
        }
    }
}
