using System;
namespace ConsoleProgramSanitizer
{
    class Program
    {
            public static void Main(string[] args)
            {
            Console.WriteLine("Program started.");
            int[] result = ProgramDependency.randominitializer(10);
            int[] sanitizedarray = Programdeptwo.Sanitizer(result);

            Console.Write("<| Printing for integrity reveal:");
            for (int i = 0; i < sanitizedarray.Length; i++)
            {
                Console.Write($"/Index{i}Value{sanitizedarray[i]}");
            }
            Console.Write("IntegrityRevealDone |>");
        }
    }
}