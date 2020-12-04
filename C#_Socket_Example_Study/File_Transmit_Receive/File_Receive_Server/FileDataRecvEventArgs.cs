using System;
using System.Net;

namespace File_Receive_Server
{
    public delegate void FileDataRecvEventHandler(object sender, FileDataRecvEventArgs e);

    public class FileDataRecvEventArgs:EventArgs
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

        public long RemainLength
        {
            get;
            private set;
        }
        public byte[] Data
        {
            get;
            private set;
        }

        public FileDataRecvEventArgs(string fname, IPEndPoint rep, long rlength, byte[] data)
        {
            RemoteEndPoint = rep;
            FileName = fname;
            RemainLength = rlength;
            Data = data;
        }
    }
}
