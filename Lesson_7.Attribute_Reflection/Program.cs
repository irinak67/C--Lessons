// See https://aka.ms/new-console-template for more information

using Lesson_7.Attribute_Reflection;

var photo = new Photo("hello.png")
{
    Path = @"C:\hello.png"
};

var type = typeof(Photo);                  //type of class Photo
var attributes = type.GetCustomAttributes(false);
foreach (var attribute in attributes)
{
    Console.WriteLine(attribute);
}

var properties = type.GetProperties();     //type of all properties of class
foreach (var prop in properties)
{
    var attrs = prop.GetCustomAttributes(false);
    if (attrs.Any(a => a.GetType() == typeof(GeoAttribute)))
    {
        Console.WriteLine(prop.PropertyType + " " + prop.Name);
    }

    //foreach (var a in attrs)
    //{
    //    Console.WriteLine(a);
    //}
}
