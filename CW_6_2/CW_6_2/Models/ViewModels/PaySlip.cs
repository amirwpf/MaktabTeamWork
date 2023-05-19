using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_6_2.Models.ViewModels
{
    public class PaySlip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mobile { get; set; }
        public string NationalCode { get; set; }
        public int Amount { get; set; }
        public int Tax { get; set; }
        public int OtherBenefit { get; set; }
    }

}
