using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamManager
{
    public partial class EditSubTaskList : DevExpress.XtraEditors.XtraForm
    {
        private List<SubTask> subTasks;
        public EditSubTaskList(List<SubTask> subTasks)
        {
            InitializeComponent();
            this.subTasks = subTasks;
            LoadSubTasks();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SubTask st = new SubTask(txtSubTaskName.Text);
            clbSubTasks.Items.Add(st);
            subTasks.Add(st); //Add to Main SubTasks List
            txtSubTaskName.Text = string.Empty;
        }

        private void LoadSubTasks()
        {
            clbSubTasks.Items.Clear();
            foreach (var item in subTasks)
            {
                clbSubTasks.Items.Add(item);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (SubTask item in clbSubTasks.CheckedItems)
            {
                subTasks.Remove(item);
            }
            LoadSubTasks();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
