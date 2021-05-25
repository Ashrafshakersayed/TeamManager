using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamManager
{
    public partial class TeamDetailsFrm : DevExpress.XtraEditors.XtraForm
    {
        public Team SelectedTeam { get; set; }

        Dictionary<int, Task> tasks;
        public TeamDetailsFrm(Team selectedTeam)
        {
            InitializeComponent();

            gridView.Appearance.Row.Font = new Font("Arial", 12 , FontStyle.Bold);
            gridView.Appearance.HeaderPanel.Font = new Font("Arial", 10, FontStyle.Bold);

            this.WindowState = FormWindowState.Maximized;
            this.Text = selectedTeam.Name;

            SelectedTeam = selectedTeam;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void ShowTasks()
        {
            tasks = new Dictionary<int, Task>();
            foreach (Task task in SelectedTeam.Tasks)
            {
                tasks[task.ID] = task;
            }
            gridControl.DataSource = SelectedTeam.Tasks;
            bsiRecordsCount.Caption = "RECORDS : " + SelectedTeam.Tasks.Count;
            gridControl.RefreshDataSource();
        }

        private void btnNewTask_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateNewTaskFrm createNewTaskFrm = new CreateNewTaskFrm(this);
            //this.Hide();
            createNewTaskFrm.StartPosition = FormStartPosition.CenterParent;
            createNewTaskFrm.ShowDialog();
            ShowTasks();
        }

        private void btnNewCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateCategoryFrm createCategory = new CreateCategoryFrm(this);
            createCategory.StartPosition = FormStartPosition.CenterParent;
            createCategory.ShowDialog();
            //ShowTasks();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.RefreshDataSource();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.GetFocusedRowCellValue("ID") == null)
                return;
            int currentID;
            if (int.TryParse(gridView.GetFocusedRowCellValue("ID").ToString(), out currentID))
            {
                Task task = tasks[currentID];
                TaskDetailsFrm taskDetailsFrm = new TaskDetailsFrm(SelectedTeam, task);
                taskDetailsFrm.StartPosition = FormStartPosition.CenterParent;
                taskDetailsFrm.ShowDialog();
                ShowTasks();
            }
        }

        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            if (gridView.GetFocusedRowCellValue("ID") == null)
                return;
            int currentID;
            if (int.TryParse(gridView.GetFocusedRowCellValue("ID").ToString(), out currentID))
            {
                //MessageBox.Show(gridView.GetSelectedRows().Count().ToString());
                //Task task = SelectedTeam.Tasks[gridView.GetSelectedRows()[0]];
                //MessageBox.Show(gridView.GetFocusedRowCellValue("ID").ToString());
                //Task task = (Task)gridView.GetDataRow(gridView.GetSelectedRows()[0]);
                //Task task = (Task)gridView.Appearance.SelectedRow;
                Task task = tasks[currentID];
                TaskDetailsFrm taskDetailsFrm = new TaskDetailsFrm(SelectedTeam, task);
                taskDetailsFrm.StartPosition = FormStartPosition.CenterParent;
                taskDetailsFrm.ShowDialog();
                ShowTasks();
            }
        }

        private void btnShowEmployees_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditEmployeeFrm editEmployeeFrm = new EditEmployeeFrm(SelectedTeam.Employees, Program.Employees, ComeFrom.TeamForm, SelectedTeam.Tasks);
            editEmployeeFrm.StartPosition = FormStartPosition.CenterParent;
            editEmployeeFrm.ShowDialog();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.GetFocusedRowCellValue("ID") == null)
                return;
            int currentID;
            if (int.TryParse(gridView.GetFocusedRowCellValue("ID").ToString(), out currentID))
            {
                Task task = tasks[currentID];
                SelectedTeam.Tasks.Remove(task);
                ShowTasks();
            }
        }
        private void TeamDetailsFrm_Shown(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormCaption("Loading...");
            splashScreenManager1.SetWaitFormDescription("");
            EnableOrDisableButtons(false);
        }

        private void EnableOrDisableButtons(bool status)
        {
            btnNewTask.Enabled = status;
            btnNewCategory.Enabled = status;
            btnShowEmployees.Enabled = status;
            bbiEdit.Enabled = status;
            bbiDelete.Enabled = status;
            bbiRefresh.Enabled = status;
            bbiPrintPreview.Enabled = status;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            splashScreenManager1.CloseWaitForm();
            timer1.Stop();
            Thread.Sleep(600);
            EnableOrDisableButtons(true);
            ShowTasks();
        }

        private void btnBack_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}