// See https://aka.ms/new-console-template for more information
using CollectionsAssignment;

string convertToString(Months? month)
{
    switch (month)
    {
        case Months.january:
            return "january";
            break;
        case Months.february:
            return "february";
            break;
        case Months.march:
            return "march";
            break;
        case Months.april:
            return "april";
            break;
        case Months.may:
            return "may";
            break;
        case Months.june:
            return "june";
            break;
        case Months.july:
            return "july";
            break;
        case Months.september:
            return "september";
            break;
        case Months.october:
            return "october";
            break;
        case Months.november:
            return "november";
            break;
        case Months.december:
            return "december";
            break;
        default:
            return "enum is null";
            break;

    }
    
}

GenericArray<int> genericArray = new GenericArray<int>(new int[9]{4,5,2,5,2,62,3,1,5});

genericArray.swap(0, 1);

for (int i = 0; i < genericArray.Length; i++)
{
    Console.Write($"{genericArray.get(i)} ");
}


Months? s = null;

Console.WriteLine(convertToString(s));

HashSet<int> set = new HashSet<int> { 1, 2, 3 };
set.Add(4);
set.Add(1);
set.Add(6);
foreach(int value in set)
{
    Console.WriteLine(value);
}

Dictionary<int,string > dictionary = new Dictionary<int,string>();
dictionary.Add(1, "val1");
dictionary.Add(2, "val2");
dictionary.Add(3, "val3");
foreach(int key in dictionary.Keys)
{
    Console.WriteLine($" {key} {dictionary[key]}");
}
enum Months
{
    january, february, march, april, may, june, july, august, september, october, november, december
}





