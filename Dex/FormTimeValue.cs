using System;
using System.Windows.Forms;

namespace Dex
{
    public partial class FormTimeValue : Form
    {
        public string result;

        public FormTimeValue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = dateTimePicker1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}