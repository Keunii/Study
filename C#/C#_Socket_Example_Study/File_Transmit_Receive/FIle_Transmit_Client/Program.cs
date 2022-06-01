﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIle_Transmit_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("서버 IP : ");
            string ip = Console.ReadLine();

            int port = 10340;
            Console.Write("포트 번호 : {0}", port);

            FileSendClient fsc = new FileSendClient(ip, port);
            fsc.SendFileDataEventHandler += Fsc_SendFileDataEventHandler;

            Console.Write("전송할 파일명 : ");
            string fname = Console.ReadLine();
            fsc.SendAsync(fname);

            Console.ReadKey();
        }

        private static void Fsc_SendFileDataEventHandler(object sender, SendFileDataEventArgs e)
        {
            Console.WriteLine("{0} 파일 {1}Bytes 남았음.", e.FileName, e.Remain);
        }
    }
}
