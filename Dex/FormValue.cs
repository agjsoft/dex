using System;
using System.Windows.Forms;

namespace Dex
{
    public partial class FormValue : Form
    {
        public string result = "";
        private ColumnAttribute attribute;

        public FormValue(ColumnAttribute ca, string value)
        {
            InitializeComponent();
            textBox1.Text = value;
            attribute = ca;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            bool success = true;
            if (null != attribute)
            {
                switch (attribute.Type)
                {
                    case ColumnType.Number:
                        {
                            long temp;
                            if (false == long.TryParse(text, out temp))
                            {
                                success = false;
                                break;
                            }
                            if (attribute.MinInteger.Enable && temp < attribute.MinInteger.Value)
                            {
                                success = false;
                                break;
                            }
                            if (attribute.MaxInteger.Enable && attribute.MaxInteger.Value < temp)
                            {
                                success = false;
                                break;
                            }
                        }
                        break;
                    case ColumnType.String:
                        {
                            if (attribute.MinLength.Enable && text.Length < attribute.MinLength.Value)
                            {
                                success = false;
                                break;
                            }
                            if (attribute.MaxLegnth.Enable && attribute.MaxLegnth.Value < text.Length)
                            {
                                success = false;
                                break;
                            }
                        }
                        break;
                    case ColumnType.DataPointer:
                        break;
                    case ColumnType.Time:
                        {
                            DateTime tmp;
                            if (false == DateTime.TryParse(text, out tmp))
                            {
                                success = false;
                                break;
                            }
                        }
                        break;
                    case ColumnType.Weekday:
                        {
                            DayOfWeek tmp;
                            if (false == Enum.TryParse(text, out tmp))
                            {
                                success = false;
                                break;
                            }
                        }
                        break;
                }
            }

            if (success)
            {
                result = text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("입력 데이터 에러");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            button1_Click(null, null);
        }
    }
}