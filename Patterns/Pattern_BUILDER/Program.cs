// See https://aka.ms/new-console-template for more information

using Pattern_BUILDER;

List<Employee> employees = new()
{
    new Employee {Name = "Jon", Salary = 1000},
    new Employee {Name = "Jim", Salary = 1030},
    new Employee {Name = "Mary", Salary = 1150}
};

var builder = new EmployeeReportBuilder(employees);
var director = new EmployeeReportDirector(builder);
director.Build();

var report = builder.GetReport();

Console.WriteLine(report);
Console.ReadLine();