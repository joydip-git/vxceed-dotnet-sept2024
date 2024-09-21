List<int> numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

/*
Func<int, bool> isEven = num => num % 2 == 0;
IEnumerable<int> evenNumbers = numbers.Where(isEven);

List<int> evenNumbersList = evenNumbers.ToList();

Action<int> printNum = num => Console.WriteLine(num);
evenNumbersList.ForEach(printNum);
*/

//LINQ => Language Integrated Query

//1. Method query syntax
numbers
    .Where(x => x % 2 == 0)
    .OrderByDescending(x => x)
    .ToList()
    .ForEach(x => Console.WriteLine(x));

//2. query expression (operator) syntax
//from <range-variable> in <source-of-data>
var query = from x in numbers
            where x % 2 == 0
            orderby x descending
            select x;
query.ToList().ForEach(x => Console.WriteLine(x));

/*
List<int> evenNumbers = new List<int>();
foreach (var number in numbers)
{
    if (number % 2 == 0)
    {
        evenNumbers.Add(number);
    }
}

for (int i = 0; i < evenNumbers.Count; i++)
{
    for (global::System.Int32 j = i + 1; j < evenNumbers.Count; j++)
    {
        if (evenNumbers[i] > evenNumbers[j])
        {
            int temp = evenNumbers[i];
            evenNumbers[i] = evenNumbers[j];
            evenNumbers[j] = temp;
        }
    }
}
foreach (var item in evenNumbers)
{
    Console.WriteLine(item);
}
*/