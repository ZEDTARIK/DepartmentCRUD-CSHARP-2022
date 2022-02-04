using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DepartmentBLL
    {
        public static void addDepartment(DEPARTEMENT department)
        {
            DAL.DAO.DepartmentDAO.addDepartment(department);
        }
    }
}
