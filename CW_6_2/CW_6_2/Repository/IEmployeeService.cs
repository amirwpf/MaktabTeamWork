﻿using CW_6_2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_6_2.Repository
{
    public interface IEmployeeService
    {
        List<EmployeeNameViewModel> GetEmployeeName();
        List<EmployeeNameViewModel> GetMenEmpName();
    }
}
