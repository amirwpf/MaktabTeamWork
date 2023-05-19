using CW_6_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_6_2.DataBase
{
    public class AppDB
    {
        List<Empolyee> empolyees = new List<Empolyee>()
        {
            new Empolyee{Id=123,FName="hasan",LName="kushkaki",NationalCode=123456789,Gender=1,Mobile = 912345678,Email="hasan@kushkaki.com"},
            new Empolyee{Id=1234,FName="sara",LName="hoseini",NationalCode=125678908,Gender=0,Mobile =912358364,Email="sara@hoseini.com"},

        };
        List<Salary> salarys = new List<Salary>()
        {
            new Salary{Id=1,Amount=8,EmployeeId=123,Tax=1,OtherBenefit=2,Year=1390,Month=1},
            new Salary{Id=2,Amount=7,EmployeeId=1234,Tax=1,OtherBenefit=3,Year=1390, Month=3},
        };

    }
}
