using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Dex
{
    public partial class FormMain : Form
    {
        public static List<FormTable> TableList = new List<FormTable>();
        private Point Loc = new Point();
        private List<string> TableNameList;
        private Random Rn = new Random();

        public FormMain()
        {
            InitializeComponent();
            var array = new string[] { "Dog", "Cat", "Fire", "Korea", "Japan", "Earth", "Mars", "Jupiter",
            "Money", "Game", "Life", "Run", "Walk", "White", "Red", "Blue", "Green", "Yellow", "Orange",
            "Apple", "Google", "Big", "Small", "Computer", "Super", "Coffee", "Food", "Send", "Receive",
            "Name", "Space", "Window", "Brazil", "Spain", "England", "English", "China", "France", "Germany",
            "Bitcoin", "Eos", "Ripple", "Naver", "Kakao", "Seoul", "Busan", "Italy", "USA", "Army", "Ship",
            "Airplain", "Airport", "Air", "Fresh", "Heavy", "Lite", "Left", "Right", "Up", "Down", "Top",
            "Botton", "Chair", "Bed", "Bad", "Good", "Best", "Worst", "Movie", "Russia"};
            TableNameList = array.ToList();
        }

        private void miNewTable_Click(object sender, EventArgs e)
        {
            int idx = Rn.Next() % TableNameList.Count;
            var table = new FormTable(TableNameList[idx]);
            TableList.Add(table);
            table.Show(this);
            TableNameList.RemoveAt(idx);
        }

        private void FormMain_Move(object sender, EventArgs e)
        {
            int mox = Location.X - Loc.X;
            int moy = Location.Y - Loc.Y;
            Loc = Location;

            TableList.ForEach(t =>
            {
                t.Location = new Point(t.Location.X + mox, t.Location.Y + moy);
            });
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Loc = Location;

            if (File.Exists(Define.SaveFileName))
            {
                var load = new TableMgr();
                var sr = new StreamReader(Define.SaveFileName);
                load.Load(sr);
                sr.Close();
                
                load.Tables.ForEach(t =>
                {
                    var formTable = new FormTable(t);
                    formTable.Show(this);
                    TableList.Add(formTable);
                });
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            var save = new TableMgr();
            TableList.ForEach(t =>
            {
                var table = new Table()
                {
                    Name = t.Text
                };
                var lv = t.GetListView();
                for (int i = 0; i < lv.Columns.Count; i++)
                {
                    var ca = (ColumnAttribute)lv.Columns[i].Tag;
                    table.Columns.Add(ca);
                    table.ColumnNames.Add(lv.Columns[i].Text);
                }
                foreach (ListViewItem item in lv.Items)
                {
                    var datas = new List<string>();
                    for (int i = 0; i < lv.Columns.Count; i++)
                    {
                        datas.Add(item.SubItems[i].Text);
                    }
                    table.Values.Add(datas);
                }
                save.Tables.Add(table);
            });

            var sw = new StreamWriter(Define.SaveFileName);
            save.Save(sw);
            sw.Close();

            MessageBox.Show("저장되었습니다.");
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miExport_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Define.ExportFolderName);

            var csSw = new StreamWriter(Path.Combine(Define.ExportFolderName, "DataTable.cs"));
            csSw.WriteLine($"using System;");
            csSw.WriteLine($"using System.Collections.Generic;");
            csSw.WriteLine($"using System.IO;");
            csSw.WriteLine($"using System.Threading.Tasks;");
            csSw.WriteLine($"");
            csSw.WriteLine($"namespace DataTable");
            csSw.WriteLine($"{{");
            csSw.WriteLine($"    public static class Manager");
            csSw.WriteLine($"    {{");
            csSw.WriteLine($"        public static void Init()");
            csSw.WriteLine($"        {{");
            csSw.WriteLine($"            var taskList = new List<Task>();");

            TableList.ForEach(t =>
            {
                csSw.WriteLine($"            taskList.Add(Task.Run(() => {t.Text}DataTable.Load()));");
            });

            csSw.WriteLine($"            Task.WaitAll(taskList.ToArray());");

            TableList.ForEach(t =>
            {
                csSw.WriteLine($"            {t.Text}DataTable.Post();");
            });

            csSw.WriteLine($"        }}");
            csSw.WriteLine($"    }}");
            csSw.WriteLine($"");

            TableList.ForEach(t =>
            {
                csSw.WriteLine($"    public class {t.Text}DataTableRow");
                csSw.WriteLine($"    {{");

                var lv = t.GetListView();
                foreach (ColumnHeader ch in lv.Columns)
                {
                    string typeStr = "";
                    var ca = (ColumnAttribute)ch.Tag;
                    switch (ca.Type)
                    {
                        case ColumnType.Id:
                            typeStr = "int";
                            break;
                        case ColumnType.Number:
                            typeStr = "long";
                            break;
                        case ColumnType.String:
                            typeStr = "string";
                            break;
                        case ColumnType.DataPointer:
                            typeStr = $"{ca.LinkTable.Text}DataTableRow";
                            break;
                        case ColumnType.Time:
                            typeStr = "DateTime";
                            break;
                        case ColumnType.Weekday:
                            typeStr = "DayOfWeek";
                            break;
                    }
                    csSw.WriteLine($"        public {typeStr} {ch.Text};");
                }

                csSw.WriteLine($"    }}");
                csSw.WriteLine($"");
            });

            TableList.ForEach(t =>
            {
                csSw.WriteLine($"    public static class {t.Text}DataTable");
                csSw.WriteLine($"    {{");
                csSw.WriteLine($"        public static Dictionary<int, {t.Text}DataTableRow> Map = new Dictionary<int, {t.Text}DataTableRow>();");
                csSw.WriteLine($"");
                csSw.WriteLine($"        public static void Load()");
                csSw.WriteLine($"        {{");
                csSw.WriteLine($"            var sr = new StreamReader(\"{t.Text}.txt\");");
                csSw.WriteLine($"            sr.ReadLine();");
                csSw.WriteLine($"            while (!sr.EndOfStream)");
                csSw.WriteLine($"            {{");
                csSw.WriteLine($"                var spl = sr.ReadLine().Split('^');");
                csSw.WriteLine($"                var row = new {t.Text}DataTableRow()");
                csSw.WriteLine($"                {{");

                int idx = 0;
                var lv = t.GetListView();
                foreach (ColumnHeader ch in lv.Columns)
                {
                    string rValue = "";
                    var ca = (ColumnAttribute)ch.Tag;
                    switch (ca.Type)
                    {
                        case ColumnType.Id:
                            rValue = $"int.Parse(spl[{idx}])";
                            break;
                        case ColumnType.Number:
                            rValue = $"long.Parse(spl[{idx}])";
                            break;
                        case ColumnType.String:
                            rValue = $"spl[{idx}]";
                            break;
                        case ColumnType.DataPointer:
                            break;
                        case ColumnType.Time:
                            rValue = $"DateTime.Parse(spl[{idx}])";
                            break;
                        case ColumnType.Weekday:
                            rValue = $"(DayOfWeek)Enum.Parse(typeof(DayOfWeek), spl[{idx}])";
                            break;
                    }
                    csSw.WriteLine($"                    {ch.Text} = {rValue},");
                    idx++;
                }

                csSw.WriteLine($"                }};");
                csSw.WriteLine($"                Map.Add(row.Id, row);");
                csSw.WriteLine($"            }}");
                csSw.WriteLine($"            sr.Close();");
                csSw.WriteLine($"        }}");
                csSw.WriteLine($"");
                csSw.WriteLine($"        public static void Post()");
                csSw.WriteLine($"        {{");
                csSw.WriteLine($"        }}");
                csSw.WriteLine($"    }}");
            });

            csSw.WriteLine($"}}");
            csSw.Close();

            TableList.ForEach(t =>
            {
                var lv = t.GetListView();
                int cCount = lv.Columns.Count;

                var sw = new StreamWriter(Path.Combine(Define.ExportFolderName, t.Text + ".txt"));
                foreach (ColumnHeader ch in lv.Columns)
                {
                    sw.Write(ch.Text + "^");
                }
                sw.WriteLine();
                foreach (ListViewItem item in lv.Items)
                {
                    for (int i = 0; i < cCount; i++)
                    {
                        sw.Write(item.SubItems[i].Text + "^");
                    }
                    sw.WriteLine();
                }
                sw.Close();
            });

            csSw.Close();

            MessageBox.Show("익스포팅 성공");
        }
    }
}