
using CW_6_2.Repository;

Console.WriteLine("please enter employe Id :");
var EmpId = int.Parse(Console.ReadLine());

//Console.WriteLine("please enter employe Years :");
//var EmpYears = int.Parse(Console.ReadLine());

//Console.WriteLine("please enter employe Month :");
//var empMonth = int.Parse(Console.ReadLine());

SalaryService salary = new SalaryService();
//var employeeList = salary.PayslipByIdForOneMonth(EmpId,EmpYears,empMonth);
//foreach (var item in employeeList)
//{
//    Console.WriteLine($"Id : {item.Id}  Name : {item.Name} Tax :{item.Tax} Ncode = {item.NationalCode} Mobile : {item.Mobile} OtherBenefit : {item.OtherBenefit}");
//}

var sumTax = salary.GetSumTotalTaxPaid();
var sumSalary = salary.GetTotalSalaryById(EmpId);
Console.ReadKey();