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
    public partial class CreateCategoryFrm : DevExpress.XtraEditors.XtraForm
    {
        private TeamDetailsFrm teamDetailsFrm;
        public CreateCategoryFrm(TeamDetailsFrm teamDetailsFrm)
        {
            InitializeComponent();
            this.teamDetailsFrm = teamDetailsFrm;
            loadCategory();
        }

        private void loadCategory()
        {
            clbCategoryList.Items.Clear();
            foreach (var item in teamDetailsFrm.SelectedTeam.Categories)
            {
                clbCategoryList.Items.Add(item);
            }
        }

        private void BtnCreateCategory_Click(object sender, EventArgs e)
        {
            if(textBoxNameCategory.Text.Trim() != string.Empty)
                teamDetailsFrm.SelectedTeam.Categories.Add(textBoxNameCategory.Text.Trim());
            textBoxNameCategory.Text = string.Empty;
            loadCategory();
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            GoToPrevPage();
        }
        private void GoToPrevPage()
        {
            //teamDetailsFrm.Show();
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (string item in clbCategoryList.CheckedItems)
            {
                teamDetailsFrm.SelectedTeam.Categories.Remove(item);
            }
            loadCategory();
        }
    }
}
