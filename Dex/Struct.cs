using System.Collections.Generic;

namespace Dex
{
    public class ColumnAttribute
    {
        public ColumnType Type;
        public CheckInteger MinInteger = new CheckInteger();
        public CheckInteger MaxInteger = new CheckInteger();
        public CheckInteger MinLength = new CheckInteger();
        public CheckInteger MaxLegnth = new CheckInteger();
        public FormTable LinkTable = null;
    }

    public class CheckInteger
    {
        public bool Enable = false;
        public long Value = 0;
    }

    public class Save
    {
        public List<Table> Tables = new List<Table>();
    }

    public class Table
    {
        public string Name;
        public List<string> ColumnNames = new List<string>();
        public List<ColumnAttribute> Columns = new List<ColumnAttribute>();
        public List<List<string>> Values = new List<List<string>>();
    }
}