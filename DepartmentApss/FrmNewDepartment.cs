using System;
using System.Windows.Forms;
using DAL;
namespace DepartmentApss
{
    public partial class FrmNewDepartment : Form
    {
        public FrmNewDepartment()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDepartment.Text == "")
                MessageBox.Show("Please fill the input Value ");
            else
            {
                DEPARTEMENT department = new DEPARTEMENT();
                department.Department = txtDepartment.Text;
                BLL.DepartmentBLL.addDepartment(department);
                MessageBox.Show("New Department Add with SuccessFully");
                txtDepartment.Text = "";
            }

        }
    }
}
