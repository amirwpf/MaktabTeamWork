using CW_6_2.DataBase;
using CW_6_2.Models;
using CW_6_2.Models.ViewModels;

namespace CW_6_2.Repository
{
    public class EmployeeService : IEmployeeService
    {
        AppDB db = new AppDB();
        List<EmployeeNameViewModel> emp = new List<EmployeeNameViewModel>();
        List<EmployeeNameViewModel> empMen = new List<EmployeeNameViewModel>();
        public List<EmployeeNameViewModel> GetEmployeeName()
        {
            emp = db.empolyees.OrderBy(c=>c.Id).Select(c => new EmployeeNameViewModel 
                                      {Id = c.Id, FirstName = c.FName, LastName = c.LName })
                                      .ToList()
                                        ;
            return emp;
        }

        public List<EmployeeNameViewModel> GetMenEmpName()
        {
            empMen = db.empolyees.OrderBy(c => c.Id).Where(a=>a.Gender==1)
                                      .Select(c => new EmployeeNameViewModel
                                       { Id = c.Id, FirstName = c.FName, LastName = c.LName })
                                      .ToList()
                                        ;
            return empMen;
        }
    }
}
