using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_6_2.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int Tax { get; set; }
        public int OtherBenefit { get; set; }
        public int EmployeeId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
    }
}
