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
                    rbNumber.Checked = true;
                    break;
                case ColumnType.String:
                    rbString.Checked = true;
                    break;
                case ColumnType.DataPointer:
                    rbDataPointer.Checked = true;
                    break;
                case ColumnType.Time:
                    rbTime.Checked = true;
                    break;
                case ColumnType.Weekday:
                    rbWeekday.Checked = true;
                    break;
            }

            tbDesc.Text = Value.Desc;

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

        public ColumnAttribute Value;

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbNumber.Checked)
                Value.Type = ColumnType.Number;
            else if (rbString.Checked)
                Value.Type = ColumnType.String;
            else if (rbDataPointer.Checked)
                Value.Type = ColumnType.DataPointer;
            else if (rbTime.Checked)
                Value.Type = ColumnType.Time;
            else
                Value.Type = ColumnType.Weekday;

            Value.Desc = tbDesc.Text;

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

        private void rbNumber_CheckedChanged(object sender, EventArgs e)
        {
            gbNumber.Enabled = true;
            gbString.Enabled = false;
            gbDataPointer.Enabled = false;
        }

        private void rbString_CheckedChanged(object sender, EventArgs e)
        {
            gbNumber.Enabled = false;
            gbString.Enabled = true;
            gbDataPointer.Enabled = false;
        }

        private void rbDataPointer_CheckedChanged(object sender, EventArgs e)
        {
            gbNumber.Enabled = false;
            gbString.Enabled = false;
            gbDataPointer.Enabled = true;
        }

        private void rbTime_CheckedChanged(object sender, EventArgs e)
        {
            gbNumber.Enabled = false;
            gbString.Enabled = false;
            gbDataPointer.Enabled = false;
        }

        private void rbWeekday_CheckedChanged(object sender, EventArgs e)
        {
            gbNumber.Enabled = false;
            gbString.Enabled = false;
            gbDataPointer.Enabled = false;
        }
    }
}