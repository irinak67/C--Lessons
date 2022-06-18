// See https://aka.ms/new-console-template for more information

IList<int> numbers = new List<int> { 1, 2, 10, 800, -1100, 250, 0, -20, 7, -1 };
Console.WriteLine("GetMinimalElement: {0}", GetMinimalElement(numbers).ToString());
Console.WriteLine("LINQ Extensions: {0}", numbers.Min());
Console.WriteLine("(LINQ) Max: {0}", numbers.Max());
Console.WriteLine("(LINQ) Count: {0}", numbers.Count());
Console.WriteLine("(LINQ) Positive elements count: {0}", numbers.Where(x => x > 0).Count());
Console.WriteLine("(LINQ) Positive elements count: {0}", numbers.Count(x => x > 0));
Console.WriteLine("(LINQ) Sum of negative element: {0}", numbers.Where(x => x < 0).Sum());

static int GetMinimalElement(IEnumerable<int> list)
{
    int? result = null;

    foreach (var i in list)
    {
        if (!result.HasValue || result > i) result = i;
    }
    return (int)result;
}


IList<string> country = new List<string> { "Israel", "USA", "Kanada", "Germany", "France" };
//Without LINQ:
WriteAllCountryes(country);

//LINQ:
Console.WriteLine(country.Aggregate((a, b) => a + ", " + b));

static void WriteAllCountryes(IEnumerable<string> arr)
{
    string result = string.Empty;

    foreach (var i in arr)
    {
        result += i + ", ";
    }

    result = result.Trim(',',' ');

    Console.WriteLine("\n" + result);
}
