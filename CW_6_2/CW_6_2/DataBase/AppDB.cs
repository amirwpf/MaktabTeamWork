﻿using CW_6_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_6_2.DataBase
{
    public class AppDB
    {
        public List<Empolyee> empolyees = new List<Empolyee>()
        {
            new Empolyee{Id=123,FName="hasan",LName="kushkaki",NationalCode="123456789",Gender=1,Mobile = 912345678,Email="hasan@kushkaki.com"},
            new Empolyee{Id=1234,FName="sara",LName="hoseini",NationalCode="125678908",Gender=0,Mobile =912358364,Email="sara@hoseini.com"},

        };
        public List<Salary> salarys = new List<Salary>()
        {
            new Salary{Id=1,Amount=8345,EmployeeId=123,Tax=1123,OtherBenefit=2,Year=1390,Month=1},
            new Salary{Id=2,Amount=7234,EmployeeId=1234,Tax=1234,OtherBenefit=3234,Year=1390, Month=3},
            new Salary{Id=3,Amount=81232,EmployeeId=123,Tax=1234,OtherBenefit=2342,Year=1391,Month=1},
            new Salary{Id=4,Amount=834545,EmployeeId=123,Tax=9887,OtherBenefit=2234,Year=1392,Month=1},
            new Salary{Id=5,Amount=84654,EmployeeId=123,Tax=1977,OtherBenefit=2234,Year=1393,Month=1},
            new Salary{Id=6,Amount=84564,EmployeeId=123,Tax=1234,OtherBenefit=2555,Year=1394,Month=1},

        };

    }
}
