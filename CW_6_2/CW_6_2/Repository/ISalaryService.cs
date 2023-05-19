using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_6_2.NewFolder
{
    internal interface ISalaryService
    {
        decimal GetTotalSalaryById(int id);
        
        decimal GetSumTotalTaxPaid();
        List<PaySlip> PayslipByIdForOneMonth(int id, int year, int month);

    }
}
