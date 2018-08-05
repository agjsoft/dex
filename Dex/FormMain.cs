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
        }
    }
}