using System.Collections.Generic;
using System.IO;

namespace Dex
{
    public static class Util
    {
        public static void SaveStringsInOneRow(StreamWriter sw, List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
                sw.Write(list[i] + "^");
            sw.WriteLine();
        }

        public static List<string> LoadStringsInOneRow(StreamReader sr)
        {
            var datas = new List<string>();
            var spl = sr.ReadLine().Split('^');
            for (int k = 0; k < spl.Length - 1; k++)
                datas.Add(spl[k]);
            return datas;
        }
    }
}