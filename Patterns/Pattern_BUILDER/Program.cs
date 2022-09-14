// See https://aka.ms/new-console-template for more information

using Pattern_BUILDER;
using Pattern_BUILDER.Burger;

//EmployeeReport
//List<Employee> employees = new()
//{
//    new Employee {Name = "Jon", Salary = 1000},
//    new Employee {Name = "Jim", Salary = 1030},
//    new Employee {Name = "Mary", Salary = 1150}
//};

//var builder = new EmployeeReportBuilder(employees);
//var director = new EmployeeReportDirector(builder);
//director.Build();

//var report = builder.GetReport();

//Console.WriteLine(report);

//Burger
List<ProductFilling> productFillings = new()
{
    new ProductFilling {Name = "Lettuce", LayersNumber = 1},
    new ProductFilling {Name = "Tomato ", LayersNumber = 2},
    new ProductFilling {Name = "Onion  ", LayersNumber = 1},
    new ProductFilling {Name = "Pickles", LayersNumber = 1},
    new ProductFilling {Name = "Bacon  ", LayersNumber = 1},
    new ProductFilling {Name = "Ketchup", LayersNumber = 2},
    new ProductFilling {Name = "Mustard", LayersNumber = 2},
    new ProductFilling {Name = "Mayonnaise", LayersNumber = 3},
};

var builder1 = new BurgerProductBuilder(productFillings);
var director1 = new BurgerProductDirector(builder1);
director1.Build();

var burger = builder1.GetProduct();

Console.WriteLine(burger);

Console.ReadLine();