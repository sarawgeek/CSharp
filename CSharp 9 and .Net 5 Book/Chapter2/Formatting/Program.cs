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

    Console.WriteLine(new String('-',90));
    Console.WriteLine(
        format:"{0,-8} {1,18} {2,30} {3,30}",
        "Type",
        "Byte(s) of Memory",
        "Min",
        "Max"
    );

    Console.WriteLine(new String('-',90));
    Console.WriteLine(
        format:"{0,-8} {1,18} {2,30} {3,30}",
        "sbyte",
        sizeof(sbyte),
        sbyte.MinValue,
        sbyte.MaxValue
    );

    Console.WriteLine(
        format:"{0,-8} {1,18} {2,30} {3,30}",
        "byte",
        sizeof(byte),
        byte.MinValue,
        byte.MaxValue
    );

    Console.WriteLine(
        format:"{0,-8} {1,18} {2,30} {3,30}",
        "short",
        sizeof(short),
        short.MinValue,
        short.MaxValue
    );

    Console.WriteLine(
        format:"{0,-8} {1,18} {2,30} {3,30}",
        "ushort",
        sizeof(ushort),
        ushort.MinValue,
        ushort.MaxValue
    );

    Console.WriteLine(
        format:"{0,-8} {1,18} {2,30} {3,30}",
        "int",
        sizeof(int),
        int.MinValue,
        int.MaxValue
    );

    Console.WriteLine(
        format:"{0,-8} {1,18} {2,30} {3,30}",
        "uint",
        sizeof(uint),
        uint.MinValue,
        uint.MaxValue
    );

    Console.WriteLine(
        format:"{0,-8} {1,18} {2,30} {3,30}",
        "long",
        sizeof(long),
        long.MinValue,
        long.MaxValue
    );

    Console.WriteLine(
        format:"{0,-8} {1,18} {2,30} {3,30}",
        "ulong",
        sizeof(ulong),
        ulong.MinValue,
        ulong.MaxValue
    );

    Console.WriteLine(
        format:"{0,-8} {1,18} {2,30} {3,30}",
        "float",
        sizeof(float),
        float.MinValue,
        float.MaxValue
    );

    Console.WriteLine(
        format:"{0,-8} {1,18} {2,30} {3,30}",
        "double",
        sizeof(double),
        double.MinValue,
        double.MaxValue
    );

    Console.WriteLine(
        format:"{0,-8} {1,18} {2,30} {3,30}",
        "decimal",
        sizeof(decimal),
        decimal.MinValue,
        decimal.MaxValue
    );

    