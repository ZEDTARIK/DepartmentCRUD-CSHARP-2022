using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
namespace DepartmentApss
{
    public partial class FrmPosition : Form
    {
        public FrmPosition()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPosition.Text == "")
            {
                MessageBox.Show("Please fill the input Position !");
            }
            else
            {
                POSITION position = new POSITION();
                position.PositionName = txtPosition.Text;
                position.DepartmentId = 2;
                BLL.PositionBLL.addPosition(position);
                MessageBox.Show("Position add with successfully !");
                txtPosition.Text = "";
                txtDepartmentId.Text = "";
            }





        }
    }
}
