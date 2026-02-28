 Console.WriteLine("Hello, World!");

string name = "Alice";
Console.WriteLine($"Hello, {name}!"); // Interpolation

name = "Bob";
Console.WriteLine(name); // Reassignment

const string greeting = "Welcome to C# programming!";
Console.WriteLine(greeting); // Constant

var age = 30;
Console.WriteLine($"You are {age} years old."); // Implicitly typed variable

int year = 2024;
Console.WriteLine($"The year is {year}."); // Explicitly typed integer

bool isLearning = true;
Console.WriteLine($"Is learning C#: {isLearning}"); // Explicitly typed boolean

double pi = 3.14159;
Console.WriteLine($"Value of Pi: {pi}"); // Explicitly typed double

char initial = 'C';
Console.WriteLine($"Initial: {initial}"); // Explicitly typed char

string multiLine = @"This is a
multi-line string.";
Console.WriteLine(multiLine); 

string escapedString = "This is a line with a newline character.\nSee?";
Console.WriteLine(escapedString); // Escaped string

var nullableInt = (int?)null;
Console.WriteLine($"Nullable integer: {nullableInt}"); // Nullable type

string? nullableString = null;
Console.WriteLine($"Nullable string: {nullableString}"); // Nullable reference type

DateTime currentDate = DateTime.Now;
Console.WriteLine($"Current date and time: {currentDate}"); // DateTime variable

decimal price = 19.99m;
Console.WriteLine($"Price: {price}"); // Decimal variable

float temperature = 36.6f;
Console.WriteLine($"Temperature: {temperature}°C"); // Float variable

long distanceToMoon = 384400000L;
Console.WriteLine($"Distance to the Moon: {distanceToMoon} meters"); // Long variable

byte smallNumber = 255;
Console.WriteLine($"Small number (byte): {smallNumber}"); // Byte variable

sbyte signedSmallNumber = -100;
Console.WriteLine($"Signed small number (sbyte): {signedSmallNumber}"); // S

short shortNumber = 32000;
Console.WriteLine($"Short number: {shortNumber}"); // Short variable

uint unsignedInt = 4000000000;
Console.WriteLine($"Unsigned integer: {unsignedInt}"); // Unsigned int variable

ulong unsignedLong = 18446744073709551615;
Console.WriteLine($"Unsigned long: {unsignedLong}"); // Unsigned long variable

ushort unsignedShort = 65000;
Console.WriteLine($"Unsigned short: {unsignedShort}"); // Unsigned short variable

object obj = "This is an object";
Console.WriteLine($"Object: {obj}"); // Object variable

dynamic dyn = 42;
Console.WriteLine($"Dynamic variable: {dyn}"); // Dynamic variable

var tuple = (Name: "Charlie", Age: 25);
Console.WriteLine($"Tuple - Name: {tuple.Name}, Age: {tuple.Age}"); // Tuple variable

Guid newGuid = Guid.NewGuid();
Console.WriteLine($"New GUID: {newGuid}"); // GUID variable

TimeSpan timeSpan = TimeSpan.FromHours(1.5);
Console.WriteLine($"TimeSpan: {timeSpan}"); // TimeSpan variable

char[] charArray = { 'H', 'e', 'l', 'l', 'o' };
Console.WriteLine($"Char array: {new string(charArray)}"); // Char array variable

string[] stringArray = { "One", "Two", "Three" };
Console.WriteLine($"String array: {string.Join(", ", stringArray)}"); // String array variable

int[] intArray = { 1, 2, 3, 4, 5 };
Console.WriteLine($"Int array: {string.Join(", ", intArray)}"); // Int array

List<string> stringList = new List<string> { "Apple", "Banana", "Cherry" };
Console.WriteLine($"String list: {string.Join(", ", stringList)}"); // List variable

Dictionary<string, int> ageDictionary = new Dictionary<string, int>
{
    { "Alice", 30 },
    { "Bob", 25 }
};
Console.WriteLine("Age Dictionary:");
foreach (var kvp in ageDictionary)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
} // Dictionary variable

HashSet<int> numberSet = new HashSet<int> { 1, 2, 3, 4, 5 };
Console.WriteLine($"Number set: {string.Join(", ", numberSet)}"); // HashSet

Queue<string> stringQueue = new Queue<string>();
stringQueue.Enqueue("First");
stringQueue.Enqueue("Second");
Console.WriteLine($"String queue: {string.Join(", ", stringQueue)}"); // Queue variable

Stack<int> intStack = new Stack<int>();
intStack.Push(10);
intStack.Push(20);
Console.WriteLine($"Int stack: {string.Join(", ", intStack)}"); // Stack variable

var anonymousObject = new { Name = "Diana", Age = 28 };
Console.WriteLine($"Anonymous Object - Name: {anonymousObject.Name}, Age: {anonymousObject.Age}"); // Anonymous object variable

var nullableDateTime = (DateTime?)null;
Console.WriteLine($"Nullable DateTime: {nullableDateTime}"); // Nullable DateTime variable
