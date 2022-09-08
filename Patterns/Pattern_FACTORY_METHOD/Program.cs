// See https://aka.ms/new-console-template for more information

using Pattern_FACTORY_METHOD;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

var machines = new List<CashMachine>
{
    new DollarCashMachine(),
    new EuroCashMachine()
};
var money = new List<MoneyBase>();
var rnd = new Random();
foreach (var machine in machines)
{
    var pageCount = rnd.Next(1, 3);
    var newMoney = machine.Create(pageCount);
    money.AddRange(newMoney);
}
foreach (var note in money)
{
    Console.WriteLine(note);
}
Console.ReadLine();