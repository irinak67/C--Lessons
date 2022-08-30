// See https://aka.ms/new-console-template for more information
using OOP;
using OOP.Interface;

//class and objects
Console.WriteLine("\t***** classes and objects *****");
Car_class myObj1 = new Car_class();
Car_class myObj2 = new Car_class();

Console.WriteLine(myObj1.color);    //blue
Console.WriteLine(myObj2.color);    //blue

//members
Console.WriteLine("\n\t***** members *****");

MyClass_members myObj3 = new MyClass_members(); 

Console.WriteLine(myObj3.color);        //red
Console.WriteLine(myObj3.maxSpeed);     //200

Car Ford = new Car();
Ford.model = "Mustang";
Ford.year = 1969;

Car Opel = new Car();
Opel.model = "Astra";
Opel.year = 2005;

Console.WriteLine(Ford.model);      //Mustang
Console.WriteLine(Opel.model);      //Astra

myObj3.fullThrottle();              //The car is going as fast as it can!

//constructors
Console.WriteLine("\n\t***** constructors *****");

Car_constructors Toyota = new Car_constructors(2020, "White");
Console.WriteLine(Toyota.model + " " + Toyota.color + " " + Toyota.year);    //CH-R White 2020

//accessModifier
Console.WriteLine("\n\t***** access modifier *****");

Car_accessModifier car = new Car_accessModifier();
Console.WriteLine(car.year);          //2021  - public
//Console.WriteLine(car.name);        //'car.name' is inaccessible due to its protection level 
Console.WriteLine(car.model);         // Civic  - internal
//Console.WriteLine(car.color);       //'car.color' is inaccessible due to its protection level

car.GetYear();      //Year is: 2021  - public
//car.GetName();    //'car.name' is inaccessible due to its protection level
car.GetModel();     //Model is: Civic - internal
//car.GetColor();   //'car.color' is inaccessible due to its protection level

//properties
Console.WriteLine("\n\t***** properties *****");

PropertySample myObj = new PropertySample();
myObj.Name = "Mary";
myObj.Age = 15;
Console.WriteLine("My name is " + myObj.Name + " and I'm " + myObj.Age);   //My name is Mary and I'm 15

myObj.Run();      //My name is Tom and I'm 25

//Inheritance
Console.WriteLine("\n\t***** Inheritance *****");
MyDog myAnimal = new MyDog();
myAnimal.GetSound();
myAnimal.GetName();
Console.WriteLine("My animal is a " + myAnimal.animal + " and her name is " + myAnimal.name);

//Polymorphism
Console.WriteLine("\n\t***** Polymorphism *****");
PolySample myAction = new PolySample();
PolySample myMulti = new Multi();

myAction.aaa();
myMulti.aaa();

//TO DO
//Console.WriteLine("\nPolyProperties");
//PolyProperties myAction1 = new PolyProperties();
//PolyProperties myMulti1 = new Operation();

//myAction1.aaa();
//myMulti1.aaa();

//Abstraction
Console.WriteLine("\n\t***** Abstraction *****");
CourseStart course = new CourseStart();
course.GetNameOfCourse();
course.GetStatus();

//interface
Console.WriteLine("\n\t***** Interface *****");
Animals_interfaces myAnimals = new Animals_interfaces();
myAnimals.GetAnimal();
myAnimals.GetSound();
myAnimals.GetFood();