using static System.Console;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace Arguments
{
    class Program
    {
        public static void Main(string[] args)
        {
            WriteLine($"There are {args.Length} arguments");

            ForegroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[0],
                ignoreCase: true
            );

            BackgroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[1],
                ignoreCase:true
            );

            try
            {
                CursorSize = int.Parse(args[2]);
            }
            catch(PlatformNotSupportedException)
            {
                WriteLine("Cursor Size API is not supported in the current platform");
            }

            

            

/*             foreach(var arg in args)
            {
                WriteLine(arg);
            }  */           
        }
    }
}
