using System;
using System.Windows.Forms;

namespace Dex
{
    public partial class FormTable : Form
    {
        public FormTable(string title)
        {
            InitializeComponent();
            Text = title;
            insert5RowToolStripMenuItem_Click(null, null);

            CreateColumn("Id", ColumnType.Id);
            CreateColumn("Value", ColumnType.Number);
            CreateColumn("String", ColumnType.String);
        }

        public FormTable(Table table)
        {
            InitializeComponent();
            Text = table.Name;
            for (int i = 0; i < table.Columns.Count; i++)
            {
                listView1.Columns.Add(table.ColumnNames[i]);
                listView1.Columns[listView1.Columns.Count - 1].Tag = table.Columns[i];
            }
            table.Values.ForEach(v =>
            {
                var item = new ListViewItem(v[0]);
                for (int vi = 1; vi < v.Count; vi++)
                {
                    item.SubItems.Add(v[vi]);
                }
                listView1.Items.Add(item);
            });
        }

        public ListView GetListView() { return listView1; }

        private int idgen = 1000;

        private void insert1RowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = new ListViewItem(idgen.ToString());
            for (int i = 0; i < listView1.Columns.Count - 1; i++)
            {
                item.SubItems.Add("0");
            }
            listView1.Items.Add(item);
            idgen++;
        }

        private void insert5RowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                insert1RowToolStripMenuItem_Click(null, null);
        }

        private void insert10RowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                insert1RowToolStripMenuItem_Click(null, null);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            var hit = listView1.HitTest(e.Location);
            if (null == hit.Item)
                return;

            if (null == hit.SubItem)
                return;

            if (hit.Item.SubItems[0] == hit.SubItem)
                return;

            int colIdx = -1;
            for (int i = 1; i < hit.Item.SubItems.Count; i++)
            {
                if (hit.Item.SubItems[i] == hit.SubItem)
                {
                    colIdx = i;
                    break;
                }
            }

            var ca = (ColumnAttribute)listView1.Columns[colIdx].Tag;
            switch (ca.Type)
            {
                case ColumnType.Time:
                    {
                        var form = new FormTimeValue();
                        if (form.ShowDialog() == DialogResult.OK)
                            hit.SubItem.Text = form.result.ToString();
                    }
                    break;
                default:
                    {
                        var form = new FormValue(ca, hit.SubItem.Text);
                        if (form.ShowDialog() == DialogResult.OK)
                            hit.SubItem.Text = form.result;
                    }
                    break;
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            var hit = listView1.HitTest(e.Location);
            if (null == hit.Item)
                return;

            willBeDeleteRowItem = hit.Item;
            contextMenuStrip1.Show(listView1, e.Location);
        }

        private ListViewItem willBeDeleteRowItem = null;

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(willBeDeleteRowItem);
            willBeDeleteRowItem = null;
        }

        private void createColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateColumn("신컬럼", ColumnType.Number);
        }

        private void CreateColumn(string name, ColumnType type)
        {
            listView1.Columns.Add(name);
            listView1.Columns[listView1.Columns.Count - 1].Tag = new ColumnAttribute()
            {
                Type = type
            };
            foreach (ListViewItem a in listView1.Items)
            {
                a.SubItems.Add("0");
            }
        }

        private ColumnHeader selectedColumn = null;

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (0 == e.Column)
                return;

            selectedColumn = listView1.Columns[e.Column];
            contextMenuStrip2.Show(this, PointToClient(MousePosition));
        }

        private void renameColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormValue(null, selectedColumn.Text);
            if (form.ShowDialog() == DialogResult.OK)
            {
                selectedColumn.Text = form.result;
            }
            selectedColumn = null;
        }

        private void deleteColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Really?", "Column Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                listView1.Columns.Remove(selectedColumn);
            }
            selectedColumn = null;
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormColumnConfig(this, (ColumnAttribute)selectedColumn.Tag);
            form.ShowDialog();

            selectedColumn = null;
        }
    }
}