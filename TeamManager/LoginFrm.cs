using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamManager
{
    public partial class LoginFrm : DevExpress.XtraEditors.XtraForm
    {
        int SplashScreenTime = 3000;
        public LoginFrm()
        {
            FluentSplashScreenOptions fluent = new FluentSplashScreenOptions();
            fluent.Title = "Task Management App";
            //fluent.Subtitle = "Test Test";
            SplashScreenManager.ShowFluentSplashScreen(fluent , parentForm:this , useFadeIn:true , useFadeOut:true);

            InitializeComponent();

            SplashScreenManager.CloseForm(false, SplashScreenTime, this);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "admin" && textBox2.Text.Trim() == "admin")
            {
                TeamsListFrm teamsListFrm = new TeamsListFrm();
                this.Hide();
                teamsListFrm.ShowDialog();
                this.Close();
            }
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            Thread.Sleep(SplashScreenTime + 1050);
        }
    }
}
