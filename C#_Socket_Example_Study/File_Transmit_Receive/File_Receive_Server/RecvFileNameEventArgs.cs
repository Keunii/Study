using System;
using System.Net;

namespace File_Receive_Server
{
    public delegate void RecvFileNameEventHandler(object sender, RecvFileNameEventArgs e);

    public class RecvFileNameEventArgs:EventArgs
    {
        public IPEndPoint RemoteEndPoint
        {
            get;
            private set;
        }

        public string FileName
        {
            get;
            private set;
        }

        public RecvFileNameEventArgs(string fname, IPEndPoint rep)
        {
            FileName = fname;
            RemoteEndPoint = rep;
        }
    }
}
