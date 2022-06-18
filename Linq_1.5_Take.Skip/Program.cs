// See https://aka.ms/new-console-template for more information


List<string> countries = new List<string>() { "Israel", "USA", "Canada", "France", "German", "Ukrain", "India" };

//IEnumerable<string> result = countries.Take(2);   // first 2 countries only
IEnumerable<string> result = (from country in countries
                             select country).Take(2);

//IEnumerable<string> result = countries.Skip(2);   // All countries start from 3th 
//IEnumerable<string> result = countries.TakeWhile(s => s.Length > 5);   // All countries then Length > 5
//IEnumerable<string> result = countries.SkipWhile(s => s.Length > 5);

foreach (var country in result)
{
    Console.WriteLine(country);
}