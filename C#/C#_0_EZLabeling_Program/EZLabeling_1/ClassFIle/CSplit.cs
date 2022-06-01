using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZLabeling_1.ClassFIle
{
    public class CSplit
    {
        public static string FilenameSplit(string fileName, bool bPath = true)
        {
            string result = "";
            string[] path = fileName.Split(new string[] { "\\" }, StringSplitOptions.None);
            int pathLength = path[path.Length - 1].Length;

            if (bPath == false) { result = fileName.Substring(0, fileName.Length - pathLength); }
            else { result = fileName.Substring(fileName.Length - pathLength); }
            
            return result;
        }
    }
}
