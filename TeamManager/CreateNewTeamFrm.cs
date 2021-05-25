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
    public partial class CreateNewTeamFrm : DevExpress.XtraEditors.XtraForm
    {
        TeamsListFrm teamsListFrm;
        public CreateNewTeamFrm(TeamsListFrm t)
        {
            InitializeComponent();
            LoadEmployeeInfo();
            teamsListFrm = t;

        }
        private void LoadEmployeeInfo()
        {
            checkedListBoxAllEmployees.Items.Clear();
            foreach (var item in Program.Employees)
            {
                checkedListBoxAllEmployees.Items.Add(item);
            }
        }

        private void BtnCreateTeam_Click(object sender, EventArgs e)
        {
            if (textBoxTeamName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Team Name");
                return;
            }

            var temp = checkedListBoxAllEmployees.CheckedIndices;
            if (temp.Count == 0)
            {
                MessageBox.Show("Please Select at least one Member");
                return;
            }
            List<Employee> tempListEmp = new List<Employee>();
            foreach (var item in temp)
            {
                tempListEmp.Add(Program.Employees[(int)item]);
            }

            Team team = new Team
            {
                Name = textBoxTeamName.Text.Trim(),
                Employees = tempListEmp
            };
            Program.Teams.Add(team);
            GoToPrevPage();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            GoToPrevPage();
        }

        private void GoToPrevPage()
        {
            teamsListFrm.Show();
            this.Close();
        }

        private void addNewEmployeeButton_Click(object sender, EventArgs e)
        {
            AddNewEmployeeFrm addNewEmployeeFrm = new AddNewEmployeeFrm();
            addNewEmployeeFrm.ShowDialog();
            LoadEmployeeInfo();
        }
    }
}
