using System;
using System.Net;

namespace _02_201201_EcoServerApplication_DefineClass
{
    public delegate void AcceptedEventHandler(object sender, AcceptedEventArgs e);

    public class AcceptedEventArgs:EventArgs
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

        public AcceptedEventArgs(IPEndPoint remote_ep)
        {
            RemoteEP = remote_ep;
        }
    }
}
