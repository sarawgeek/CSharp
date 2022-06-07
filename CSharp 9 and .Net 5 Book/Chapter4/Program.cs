using static System.Console;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//RunCalculateTax();

//RunCardinalToOrdinal();

//RunFactorial();

//RunFibImperative();

RunFibFunctional();

static void TimeTable(byte number)
{
    for(int row=1; row<=10; row++)
    {
        WriteLine($"{row} * {number} = {row * number}");
    }
}

static void RunTimeTable()
{
    bool isNumber;
    do{
        WriteLine("Please enter any number between 1 and 255");
        isNumber = byte.TryParse(ReadLine(), out byte number);
        if(isNumber)
        {
            TimeTable(number);
        }
        else
        {
            WriteLine("You did not enter a valid number");
        }
    }
    while(isNumber);
    
    
}

static decimal CalculateTax(decimal amount, string region)
{
    decimal rate = 0.0M;
    switch(region)
    {
        case "sw": rate = 0.08M;
        break;
        case "hu": rate = 0.27M;
        break;
        case "ca": rate = 0.0825M;
        break;        
    }
    return amount * rate;
}

static void RunCalculateTax()
{
    Write("Please provide Refion Code = ");
    string region = ReadLine();
    Write("Please provide Amount = ");
    bool isDecimal = decimal.TryParse(ReadLine(),out decimal amount);
    if(isDecimal)
    {
        WriteLine($"VAT you need to pay is {CalculateTax(amount, region)}");
    }
    else
    {
        WriteLine("amount is not proper");
    }
}

/// <summary>
/// Pass a 32 bit integer and it will be converted to its cardinal equivalent.
/// </summary>
/// <param name="number">Number is cardinal value e.g. 1,2,3 and so on.</param>
/// <returns>Ordinal number as string e.g. 1st, 2nd, 3rd and so on.</returns>
static string CardinalToOrdinal(int number)
{
    // Special Cases
    switch(number)
    {
        case 11:
        case 12:
        case 13: 
        return $"{number}th";
        default:
        int lastDigit = number % 10;

        string suffix = lastDigit switch{
            1 => "st",
            2 => "nd",
            3 => "rd",
            _ => "th"
        };

        return $"{number}{suffix}";
    }
}

static void RunCardinalToOrdinal()
{
    for(int i=1; i<=40; i++)
    {
        Write($"{CardinalToOrdinal(i)} ");
    }
    WriteLine();
}


static int Factorial(int number)
{
    if(number < 1)
    {
        return 0;
    }
    
    if(number == 1)
    {
        return 1;
    }
    checked
    {
        return number * Factorial(number - 1);
    }
    
}

static void RunFactorial()
{
    for(int i=1; i<=14; i++)
    {
        try
        {
            WriteLine($"{i}! = {Factorial(i):N0}");
        }
        catch
        {
            WriteLine($"Factorial of {i} can not be represented by 32 integer");
        }
        
    }
}

static int FibImperative(int term)
{
    if(term==1)
    {
        return 0;
    }
    if(term==2)
    {
        return 1;
    }
    return FibImperative(term -1) + FibImperative (term -2);
}

static void RunFibImperative()
{
    for (int i = 1; i <= 30; i++)
    {
        WriteLine("The {0} term of the Fibonacci sequence is {1:N0}",
        arg0: CardinalToOrdinal(i),
        arg1: FibImperative(term: i));
    }    
}

static int FibFunctional(int term) =>
term switch
{
    1 => 0,
    2 => 1,
    _ => FibFunctional(term-1) + FibFunctional(term-2)
};

static void RunFibFunctional()
{
    for (int i = 1; i <= 30; i++)
    {
        WriteLine("The {0} term of the Fibonacci sequence is {1:N0}",
        arg0: CardinalToOrdinal(i),
        arg1: FibFunctional(term: i));
    }    
}