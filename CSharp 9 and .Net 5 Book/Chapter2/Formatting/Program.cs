// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int numberOFApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine(
    format:"{0} apple costs {1:C}",
    arg0: numberOFApples,
    arg1: numberOFApples*pricePerApple
);

string formatted = string.Format(
    format:"{0} apple costs {1:C}",
    arg0: numberOFApples,
    arg1: numberOFApples*pricePerApple
);

//Console.WriteLine(formatted);

//Console.WriteLine($"{numberOFApples} apples costs {numberOFApples*pricePerApple}");

string appleText = "Apple";
int appleCount = 1234;

string bananaText = "Banana";
int bananaCount = 56789;

Console.WriteLine(
    format: "{0,-8} {1,6:N0}",
    arg0: "Name",
    arg1: "Count");

Console.WriteLine(
    format: "{0,-8} {1,6:N0}",
    arg0: appleText,
    arg1: appleCount);

    Console.WriteLine(
    format: "{0,-8} {1,6:N0}",
    arg0: bananaText,
    arg1: bananaCount);