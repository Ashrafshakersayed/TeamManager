using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace TeamManager
{
    public partial class TaskDetailsFrm : DevExpress.XtraEditors.XtraForm
    {
        private Task task;
        Team SelectedTeam;
        public TaskDetailsFrm(Team SelectedTeam, Task task)
        {
            InitializeComponent();
            this.task = task;
            txtName.Text = task.Name;
            dtpDeadLine.Value = task.Deadline;
            this.SelectedTeam = SelectedTeam;

            cmbPriority.DataSource = new List<TaskPriority> {
                TaskPriority.High,
                TaskPriority.Medium,
                TaskPriority.Low
            };
            cmbPriority.SelectedItem = task.Priority;

            cmbCategory.DataSource = SelectedTeam.Categories;
            cmbCategory.SelectedItem = task.Category;
            LoadLists();

            if (task.State == TaskState.Finished)
            {
                //panelContent.Enabled = false;
                ItemsToDisable();
            }
        }

        private void ItemsToDisable()
        {
            btnEditEmp.Enabled = false;
            btnEditFile.Enabled = false;
            btnEditSubTask.Enabled = false;
            btnUpdateTask.Enabled = false;
            txtName.Enabled = false;
            dtpDeadLine.Enabled = false;
            cmbCategory.Enabled = false;
            cmbPriority.Enabled = false;
        }
        private void LoadLists()
        {
            clbSubTasks.Items.Clear();
            foreach (var item in task.SubTasks)
            {
                clbSubTasks.Items.Add(item, item.CheckSubTask);
            }
            lsbEmployees.Items.Clear();
            foreach (var item in task.Employees)
            {
                lsbEmployees.Items.Add(item);
            }
            lsbFiles.Items.Clear();
            foreach (var item in task.Files)
            {
                lsbFiles.Items.Add(item);
            }
        }



        private void BtnEditFile_Click(object sender, EventArgs e)
        {
            EditFilesFrm editFilesFrm = new EditFilesFrm(task.Files);
            editFilesFrm.StartPosition = FormStartPosition.CenterParent;
            editFilesFrm.ShowDialog();
            LoadLists();
        }

        private void BtnEditEmp_Click(object sender, EventArgs e)
        {
            EditEmployeeFrm editEmployeeFrm = new EditEmployeeFrm(task.Employees, SelectedTeam.Employees, ComeFrom.TaskForm);
            editEmployeeFrm.StartPosition = FormStartPosition.CenterParent;
            editEmployeeFrm.ShowDialog();
            LoadLists();
        }

        private void BtnEditSubTask_Click(object sender, EventArgs e)
        {
            EditSubTaskList editSubTaskList = new EditSubTaskList(task.SubTasks);
            editSubTaskList.StartPosition = FormStartPosition.CenterParent;
            editSubTaskList.ShowDialog();
            LoadLists();
        }


        private void BtnComment_Click(object sender, EventArgs e)
        {
            CommentsFrm comments = new CommentsFrm(this, task);
            comments.StartPosition = FormStartPosition.CenterParent;
            comments.ShowDialog();
        }

        private void BtnUpdateTask_Click(object sender, EventArgs e)
        {
            task.Name = txtName.Text;
            task.Deadline = dtpDeadLine.Value;
            task.Priority = (TaskPriority)cmbPriority.SelectedItem;
            task.Category = cmbCategory.SelectedItem.ToString();

            foreach (SubTask item in clbSubTasks.CheckedItems)
            {
                item.CheckSubTask = true;
            }

            if (clbSubTasks.CheckedItems.Count == clbSubTasks.Items.Count)
            {
                task.State = TaskState.Finished;
            }
            this.Close();
        }

        private void lsbFiles_Click(object sender, EventArgs e)
        {
            if (lsbFiles.SelectedItem != null)
            {
                string path = lsbFiles.SelectedItem.ToString();
                string extension = Path.GetExtension(path).ToLower();
                if (extension == ".pdf")
                {
                    PdfViewerFrm pdfViewerFrm = new PdfViewerFrm(path);
                    pdfViewerFrm.ShowDialog();
                }
                else if (extension == ".docx" || extension == ".doc")
                {
                    WordViewerFrm wordViewerFrm = new WordViewerFrm(path);
                    wordViewerFrm.ShowDialog();
                }
                else if (extension == ".jpg" || extension == ".bmp" || extension == ".gif" || extension == ".png")
                {
                    ImageViewerFrm imageViewerFrm = new ImageViewerFrm(path);
                    imageViewerFrm.ShowDialog();
                }
            }
        }
    }
}