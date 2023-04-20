using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todolist
{
    public partial class Form1 : Form
    {
        private List<string> tasks = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string task = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(task))
            {
                tasks.Add(task);
                lstTasks.Items.Add(task);
                textBox1.Text = "";
            }
        }

        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex <= 0)
            {
                lstTasks.Items.RemoveAt(lstTasks.SelectedIndex);
                lstTasks.ClearSelected();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex <= 0)
            {
                lstTasks.Items.RemoveAt(lstTasks.SelectedIndex);
                lstTasks.ClearSelected();
            }
        }

        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex >= 0)
            {
                btnMarkComplete.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnMarkComplete.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
    }
}
