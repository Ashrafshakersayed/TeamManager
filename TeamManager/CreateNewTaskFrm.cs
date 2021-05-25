using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace TeamManager
{
    public partial class CreateNewTaskFrm : DevExpress.XtraEditors.XtraForm
    {
        public TeamDetailsFrm previousFrm { get; set; }
        public CreateNewTaskFrm(TeamDetailsFrm previousFrm)
        {
            InitializeComponent();
            this.previousFrm = previousFrm;

            priorityCB.Properties.Items.AddRange(
                new List<TaskPriority> {
                TaskPriority.High,
                TaskPriority.Medium,
                TaskPriority.Low
            });
            priorityCB.SelectedIndex = 0;
            foreach (var item in previousFrm.SelectedTeam.Employees)
            {
                CBemployees.Properties.Items.Add(item);
            }
            loadCategories();

            deadlinePicker.Properties.MinValue =DateTime.Now;
            deadlinePicker.DateTime = DateTime.Now;
            resizeFont();
        }


        private void loadCategories()
        {
            CategoryCB.Properties.Items.Clear();
            CategoryCB.Properties.Items.AddRange(previousFrm.SelectedTeam.Categories);
        }
        private void BTNaddTask_Click(object sender, EventArgs e)
        {
            if (TBnewTaskName.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Task name can not be Empty", "Name error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CategoryCB.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Task Category can not be Empty", "Category error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Task task = new Task();
            task.Name = TBnewTaskName.Text;
            task.Priority = (TaskPriority)priorityCB.SelectedItem;
            task.Deadline = deadlinePicker.DateTime.Date;
            foreach (CheckedListBoxItem item in CBemployees.Properties.Items)
            {

                if (item.CheckState == CheckState.Checked)
                    task.Employees.Add((Employee)item.Value);
            }

            task.Category = CategoryCB.Text;
            foreach (string item in clbFilesList.Items)
            {
                task.Files.Add(item);
            }

            foreach (CheckedListBoxItem item in subtaskCLB.Items)
            {
                SubTask subtask = new SubTask(item.ToString());
                subtask.CheckSubTask = item.CheckState == CheckState.Checked;
                task.SubTasks.Add(subtask);
            }

            task.Comments = new List<string>();

            previousFrm.SelectedTeam.Tasks.Add(task);
            previousFrm.Show();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            subtaskCLB.Items.Add(TBsubtask.Text);
            TBsubtask.Text = string.Empty;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "PDF |*.pdf|doc|*.doc;*.docx|Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                clbFilesList.Items.Add(fileDialog.FileName);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            previousFrm.Show();
            Close();
        }

        private void TBsubtask_EditValueChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = !(TBsubtask.Text.Trim() == string.Empty);
        }
        private void resizeFont()
        {
            float fontSize = (float)0.03 * Height;
            Font font = new Font(styleController1.Appearance.Font.FontFamily, fontSize);
            styleController1.Appearance.Font = font;
        }

        private void AddNewTaskFrm_Resize(object sender, EventArgs e)
        {
            resizeFont();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clbFilesList.Items.Remove(clbFilesList.SelectedItem);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CreateCategoryFrm createCategory = new CreateCategoryFrm(previousFrm);
            createCategory.StartPosition = FormStartPosition.CenterParent;
            createCategory.ShowDialog();
            loadCategories();
        }
    }
}