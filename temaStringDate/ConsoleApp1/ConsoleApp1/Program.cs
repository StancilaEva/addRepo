using System.Globalization;

string strOriginal = "blue,white,black,red,yellow";

string[] strSplit = strOriginal.Split(",");

Console.Write(" Split string = ");

foreach(string str in strSplit)
{
    Console.Write(str + " ");
}

var timespan = new TimeSpan(9, 40, 40);
var nextBreak = DateTime.Now + timespan;
Console.WriteLine("the next break is " + TimeOnly.FromDateTime(nextBreak));
DateTimeOffset dateTimeOffSet = new DateTimeOffset(DateTime.Now);
Console.WriteLine($"The offset is:{dateTimeOffSet}");
string newString =  new DateTime(2021,02,02).ToString(format: "dddd MMMM",
                                   CultureInfo.CreateSpecificCulture("us-US"));
CultureInfo spainCulture = CultureInfo.CreateSpecificCulture("es-ES");
var currency = 1000.ToString("C", spainCulture);
Console.WriteLine($"spain: {currency}");