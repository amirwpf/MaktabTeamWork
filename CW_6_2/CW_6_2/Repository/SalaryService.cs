using CW_6_2.DataBase;
using CW_6_2.Models.ViewModels;
using CW_6_2.NewFolder;
using System.Linq;

namespace CW_6_2.Repository
{

    public class SalaryService : ISalaryService
    {
        AppDB db = new AppDB();
        List<EmployeeNameViewModel> emp = new List<EmployeeNameViewModel>();
        List<PaySlip> pay = new List<PaySlip>();
        public decimal GetSumTotalTaxPaid()
        {
            var sumTax = db.salarys.Select(c => c.Tax).Sum();
            return sumTax;
        }

        public decimal GetTotalSalaryById(int id)
        {
            var total= db.salarys.Where(c => c.EmployeeId == id).Select(x => x.Amount - x.Tax + x.OtherBenefit);
            return total.Sum();
        }

        public List<PaySlip> PayslipByIdForOneMonth(int id, int year, int month)
        {
            pay = db.salarys.Join(db.empolyees,salary => salary.EmployeeId,emp=>emp.Id
                      ,(salary,emp) => new {salary = salary , emp=emp})
                      .Where(c => c.salary.EmployeeId == id && c.salary.Month == month && c.salary.Year == year)
                      .Select(c=>new PaySlip { Id = c.salary.EmployeeId,Name = c.emp.FName + ' ' + c.emp.LName,
                      Mobile = c.emp.Mobile,NationalCode = c.emp.NationalCode,Amount = c.salary.Amount,
                      Tax = c.salary.Tax,OtherBenefit = c.salary.OtherBenefit
                      }).ToList();
            return pay;
        }
    }
}
