using System;
using System.Net;

namespace _02_201201_EcoServerApplication_DefineClass
{
    public delegate void ClosedEventHandler(object sender, ClosedEventArgs e);

    public class ClosedEventArgs:EventArgs
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

        public ClosedEventArgs(IPEndPoint remote_ep)
        {
            RemoteEP = remote_ep;
        }
    }
}
