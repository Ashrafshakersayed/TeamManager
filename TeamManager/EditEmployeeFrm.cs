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
    public partial class EditEmployeeFrm : DevExpress.XtraEditors.XtraForm
    {
        Dictionary<int, Employee> EmployeeDic;
        private List<Employee> CurrentEmployees;
        private List<Employee> AllEmployees;
        private ComeFrom comeFrom;
        private List<Task> tasks;
        public EditEmployeeFrm(List<Employee> CurrentEmployees, List<Employee> AllEmployees, ComeFrom comeFrom, List<Task> tasks = null) //used only in case TeamForm
        {
            InitializeComponent();
            this.AllEmployees = AllEmployees;
            this.CurrentEmployees = CurrentEmployees;
            this.comeFrom = comeFrom;
            if (tasks != null)
                this.tasks = tasks;
            LoadEmployees();
        }

        private void LoadEmployees()
        {

            clbTaskEmployeeList.Items.Clear();
            foreach (var item in CurrentEmployees)
            {
                clbTaskEmployeeList.Items.Add(item);
            }

            EmployeeDic = new Dictionary<int, Employee>();
            int i = 0;
            cmbTeamEmployees.Items.Clear();
            foreach (var item in AllEmployees)
            {
                if (!CurrentEmployees.Contains(item))
                {
                    cmbTeamEmployees.Items.Add(item);
                    EmployeeDic[i++] = item;
                }
                
            }
            if (cmbTeamEmployees.Items.Count > 0)
            {
                cmbTeamEmployees.SelectedIndex = 0;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (cmbTeamEmployees.Items.Count > 0)
                CurrentEmployees.Add(EmployeeDic[cmbTeamEmployees.SelectedIndex]);
            LoadEmployees();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(comeFrom == ComeFrom.TaskForm)
            {
                foreach (Employee item in clbTaskEmployeeList.CheckedItems)
                {
                    CurrentEmployees.Remove(item);
                }
            }
            else if(comeFrom == ComeFrom.TeamForm)
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (Employee employee in clbTaskEmployeeList.CheckedItems)
                {
                    bool CanDelete = true;
                    foreach (var t in tasks)
                    {

                        if (t.Employees.Contains(employee) && t.State == TaskState.NotFinished)
                        {
                            CanDelete = false;
                            stringBuilder.Append(employee + ", ");
                        }
                    }
                    if (CanDelete)
                    {
                        CurrentEmployees.Remove(employee);
                    }
                }
                if(stringBuilder.Length != 0)
                    MessageBox.Show("Can't delete these Employees : " + stringBuilder.Remove(stringBuilder.Length-2, 2));
            }
            
            LoadEmployees();
        }
    }
}
