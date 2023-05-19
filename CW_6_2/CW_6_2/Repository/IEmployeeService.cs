using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_6_2.Repository
{
    internal interface IEmployeeService
    {
        List<EmployeeNameViewModel> GetEmployeeName();
        List<EmployeeNameViewModel> GetMenEmpName();
    }
}
