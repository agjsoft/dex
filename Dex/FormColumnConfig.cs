using System;
using System.Windows.Forms;

namespace Dex
{
    public partial class FormColumnConfig : Form
    {
        public FormColumnConfig(FormTable parent, ColumnAttribute value)
        {
            InitializeComponent();

            Value = value;
            switch (Value.Type)
            {
                case ColumnType.Number:
                    radioButton1.Checked = true;
                    break;
                case ColumnType.String:
                    radioButton2.Checked = true;
                    break;
                case ColumnType.DataPointer:
                    radioButton3.Checked = true;
                    break;
            }

            cbMinInteger.Checked = Value.MinInteger.Enable;
            tbMinInteger.Text = Value.MinInteger.Value.ToString();
            cbMaxInteger.Checked = Value.MaxInteger.Enable;
            tbMaxInteger.Text = Value.MaxInteger.Value.ToString();

            cbMinLength.Checked = Value.MinLength.Enable;
            tbMinLength.Text = Value.MinLength.Value.ToString();
            cbMaxLength.Checked = Value.MaxLegnth.Enable;
            tbMaxLength.Text = Value.MaxLegnth.Value.ToString();

            int selIndex = 0;
            FormMain.TableList.ForEach(t =>
            {
                if (t != parent)
                {
                    cmbLinkTable.Items.Add(t.Text);
                    if (t == Value.LinkTable)
                    {
                        selIndex = cmbLinkTable.Items.Count - 1;
                    }
                }
            });
            if (1 < FormMain.TableList.Count)
                cmbLinkTable.SelectedIndex = selIndex;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = true;
        }

        public ColumnAttribute Value;

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                Value.Type = ColumnType.Number;
            else if (radioButton2.Checked)
                Value.Type = ColumnType.String;
            else
                Value.Type = ColumnType.DataPointer;

            Value.MinInteger.Enable = cbMinInteger.Checked;
            Value.MinInteger.Value = long.Parse(tbMinInteger.Text);
            Value.MaxInteger.Enable = cbMaxInteger.Checked;
            Value.MaxInteger.Value = long.Parse(tbMaxInteger.Text);

            Value.MinLength.Enable = cbMinLength.Checked;
            Value.MinLength.Value = long.Parse(tbMinLength.Text);
            Value.MaxLegnth.Enable = cbMaxLength.Checked;
            Value.MaxLegnth.Value = long.Parse(tbMaxLength.Text);

            string selTableName = (string)cmbLinkTable.SelectedItem;
            foreach (var table in FormMain.TableList)
            {
                if (table.Text == selTableName)
                {
                    Value.LinkTable = table;
                    break;
                }
            }

            Close();
        }
    }
}