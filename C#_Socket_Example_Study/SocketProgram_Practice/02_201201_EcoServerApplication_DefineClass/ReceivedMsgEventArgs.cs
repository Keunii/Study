using System;
using System.Net;

namespace _02_201201_EcoServerApplication_DefineClass
{
    public delegate void ReceivedMsgEventHandler(object sender, ReceivedMsgEventArgs e);

    public class ReceivedMsgEventArgs:EventArgs
    {
        public IPEndPoint RemoteEP
        {
            get;
            private set;
        }

        public string IPStr
        {
            get
            {
                return RemoteEP.Address.ToString();
            }
        }

        public int Prot
        {
            get
            {
                return RemoteEP.Port;
            }
        }

        public string Msg
        {
            get;
            private set;
        }

        public ReceivedMsgEventArgs(IPEndPoint remote_ep, string msg)
        {
            RemoteEP = remote_ep;
            Msg = msg;
        }
    }
}
