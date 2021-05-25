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
    public partial class AddNewEmployeeFrm : DevExpress.XtraEditors.XtraForm
    {
        public AddNewEmployeeFrm()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            HideValidation();
            bool IsValid = true;
            if (textBoxEmployeeName.Text.Trim() == string.Empty)
            {
                labelEmployeeNameCheck.Text = "Please Enter Employee Name";
                labelEmployeeNameCheck.Visible = true;
                IsValid = false;
            }

            if (textBoxEmployeeEmail.Text.Trim() == string.Empty || !textBoxEmployeeEmail.Text.Contains("@"))
            {
                labelEmployeeEmailCheck.Text = "Please Enter a valid Email";
                labelEmployeeEmailCheck.Visible = true;
                IsValid = false;
            }
            int age;
            if (!int.TryParse(textBoxEmployeeAge.Text, out age))
            {
                labelEmployeeAgeCheck.Text = "Please Enter a valid Age";
                labelEmployeeAgeCheck.Visible = true;
                IsValid = false;
            }
            int id;
            if (!int.TryParse(textBoxEmployeeNID.Text, out id))
            {
                labelEmployeeNIDCheck.Text = "Please Enter a valid NID";
                labelEmployeeNIDCheck.Visible = true;
                IsValid = false;
            }
            if (!IsValid)
            {
                return;
            }
            Employee employee = new Employee
            {
                Name = textBoxEmployeeName.Text.Trim(),
                Age = age,
                Email = textBoxEmployeeEmail.Text.Trim(),
                NID = id
            };
            Program.Employees.Add(employee);
            this.Close();
        }

        private void HideValidation()
        {
            labelEmployeeNameCheck.Visible = false;
            labelEmployeeAgeCheck.Visible = false;
            labelEmployeeEmailCheck.Visible = false;
            labelEmployeeNIDCheck.Visible = false;
        }
    }
}
