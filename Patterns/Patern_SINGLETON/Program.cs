// See https://aka.ms/new-console-template for more information

using Patern_SINGLETON;

var singleton = Singleton.GetInstance("Hello, World!!!");
var singleton2 = Singleton.GetInstance("Hi, Cosmos!!!");
Console.WriteLine(singleton2.Data);
Console.ReadLine();
