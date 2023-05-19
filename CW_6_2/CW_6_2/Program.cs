
using CW_6_2.Repository;

Console.WriteLine("please enter employe Id :");
var EmpId =  int.Parse(Console.ReadLine());

Console.WriteLine("please enter employe Years :");
var EmpYears = int.Parse(Console.ReadLine());

Console.WriteLine("please enter employe Month :");
var empMonth = int.Parse(Console.ReadLine());

SalaryService salary = new SalaryService();
var employeeList = salary.PayslipByIdForOneMonth(EmpId,EmpYears,empMonth);
Console.ReadKey();