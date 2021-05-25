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
    public partial class TeamsListFrm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TeamsListFrm()
        {
            InitializeComponent();

            LoadTeams();
            teamsListBoxControl.Width = this.Width;
        }

        private void LoadTeams()
        {
            teamsListBoxControl.Items.Clear();
            foreach (Team item in Program.Teams)
            {
                teamsListBoxControl.Items.Add(item);
            }
        }

        private void TeamsListFrm_Shown(object sender, EventArgs e)
        {
            teamsListBoxControl.Items.Clear();
            foreach (var item in Program.Teams)
            {
                teamsListBoxControl.Items.Add(item);
            }
        }

        private void createNewTeamBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateNewTeamFrm createNewTeamFrm = new CreateNewTeamFrm(this);
            //this.Hide();
            createNewTeamFrm.ShowDialog();
            LoadTeams();
        }

        private void teamsListBoxControl_DoubleClick(object sender, EventArgs e)
        {
            if (teamsListBoxControl.SelectedItem == null)
            {
                MessageBox.Show("list clicked and value is null");
                return;
            }

            TeamDetailsFrm teamDetailsFrm = new TeamDetailsFrm((Team)teamsListBoxControl.SelectedItem);
            this.Hide();
            teamDetailsFrm.ShowDialog();
            this.Show();
            LoadTeams();
        }

        private void btnEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddNewEmployeeFrm addNewEmployeeFrm = new AddNewEmployeeFrm();
            addNewEmployeeFrm.ShowDialog();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (teamsListBoxControl.Items.Count <= 0)
                return;
            Program.Teams.Remove((Team)teamsListBoxControl.SelectedItem);
            teamsListBoxControl.Items.Remove(teamsListBoxControl.SelectedItem);
        }
    }
}
