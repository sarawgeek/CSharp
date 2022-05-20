#nullable enable
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int thisCanNotBeNull = 7;
//thisCanNotBeNull = null;

//Console.WriteLine(thisCanNotBeNull.GetValueOrDefault());

/* int? thisCouldBeNull = null;
Console.WriteLine(thisCouldBeNull);
Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

thisCouldBeNull = 8;

Console.WriteLine(thisCouldBeNull);
Console.WriteLine(thisCouldBeNull.GetValueOrDefault()); */

/* Address add = new();
add.Building = null;
add.Street = null;
add.City = null;
add.Region = null; */


string authorname = null;

int? y = authorname?.Length;
var result = authorname?.Length ?? 3;
Console.WriteLine(result);

return 0;
/* class Address{
    public string? Building;
    public string Street = string.Empty;
    public string City = string.Empty;
    public string Region = string.Empty;
}
 */


