using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Dex
{
    public class ColumnAttribute
    {
        public ColumnType Type;
        public string Desc;
        public CheckInteger MinInteger = new CheckInteger();
        public CheckInteger MaxInteger = new CheckInteger();
        public CheckInteger MinLength = new CheckInteger();
        public CheckInteger MaxLegnth = new CheckInteger();
        public FormTable LinkTable = null;

        public void Save(StreamWriter sw)
        {
            sw.WriteLine(Type);
            sw.WriteLine(Desc);
            MinInteger.Save(sw);
            MaxInteger.Save(sw);
            MinLength.Save(sw);
            MaxLegnth.Save(sw);
            if (null == LinkTable)
                sw.WriteLine("");
            else
                sw.WriteLine(LinkTable.Text);
        }

        public void Load(StreamReader sr)
        {
            Enum.TryParse(sr.ReadLine(), out Type);
            Desc = sr.ReadLine();
            MinInteger.Load(sr);
            MaxInteger.Load(sr);
            MinLength.Load(sr);
            MaxLegnth.Load(sr);
            sr.ReadLine();
        }
    }

    public class CheckInteger
    {
        public bool Enable = false;
        public long Value = 0;

        public void Save(StreamWriter sw)
        {
            sw.WriteLine(Enable + "^" + Value);
        }

        public void Load(StreamReader sr)
        {
            var spl = sr.ReadLine().Split('^');
            Enable = bool.Parse(spl[0]);
            Value = long.Parse(spl[1]);
        }
    }

    public class TableMgr
    {
        public List<Table> Tables = new List<Table>();

        public void Save(StreamWriter sw)
        {
            sw.WriteLine(Tables.Count);
            Tables.ForEach(t => t.Save(sw));
        }

        public void Load(StreamReader sr)
        {
            int count = int.Parse(sr.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Tables.Add(new Table());
                Tables.Last().Load(sr);
            }
        }
    }

    public class Table
    {
        public string Name;
        public List<string> ColumnNames = new List<string>();
        public List<ColumnAttribute> Columns = new List<ColumnAttribute>();
        public List<List<string>> Values = new List<List<string>>();

        public void Save(StreamWriter sw)
        {
            sw.WriteLine(Name);
            sw.WriteLine(ColumnNames.Count);
            Util.SaveStringsInOneRow(sw, ColumnNames);
            Columns.ForEach(n => n.Save(sw));
            sw.WriteLine(Values.Count);
            Values.ForEach(v => Util.SaveStringsInOneRow(sw, v));
        }

        public void Load(StreamReader sr)
        {
            Name = sr.ReadLine();
            int cCount = int.Parse(sr.ReadLine());
            ColumnNames = Util.LoadStringsInOneRow(sr);
            for (int i = 0; i < cCount; i++)
            {
                Columns.Add(new ColumnAttribute());
                Columns.Last().Load(sr);
            }
            int dCount = int.Parse(sr.ReadLine());
            for (int i = 0; i < dCount; i++)
            {
                Values.Add(Util.LoadStringsInOneRow(sr));
            }
        }
    }
}