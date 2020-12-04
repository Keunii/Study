using System;
using System.Net;

namespace File_Receive_Server
{
    public delegate void FileLengthRecvEventHandler(object sender, FileLengthRecvEventArgs e);

    public class FileLengthRecvEventArgs:EventArgs
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

        public long Length
        {
            get;
            private set;
        }

        public FileLengthRecvEventArgs(string fname, IPEndPoint rep, long length)
        {
            RemoteEndPoint = rep;
            FileName = fname;
            Length = length;
        }
    }
}
