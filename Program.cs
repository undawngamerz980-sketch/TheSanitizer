
namespace ConsoleProgramSanitizer
{
    class Program
    {
            public static void Main(string[] args)
            {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            int smth = 0;
            Console.WriteLine("Program started.");
            int[] result = ProgramDependency.randominitializer(10);
            int[] sanitizedarray = Programdeptwo.Sanitizer(result);

            Console.Write("<| Printing for integrity reveal:");
            foreach (int i in sanitizedarray)
            {
                Console.Write($"/Index{smth}Value{sanitizedarray[i]}");
                smth++;
            }
            Console.Write("IntegrityRevealDone |>");
        }
    }
}