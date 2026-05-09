using System;
using System.Diagnostics;
using System.Linq;

namespace ConsoleProgramSanitizer
{
    public static class Programdeptwo
    {
        public static int[] Sanitizer(int[] unsanitizedarray)
        {
            int big = 0;
            int corruptedvaluesfound = 0;
            int biggestfoundint = 0;
            int[] sanitizedarray = unsanitizedarray; 
            Stopwatch stopwatch = Stopwatch.StartNew();
            Console.Write(" <| Sanitizer.dapi.strting");
            Console.Write($"/Array.len({unsanitizedarray.Length})");
            for (int i = 0; i < unsanitizedarray.Length; i++)
            {
                if (unsanitizedarray[i] != 0)
                {
                    big += unsanitizedarray[i];
                    corruptedvaluesfound++;
                    Console.Write($"/Sanned:{i},{unsanitizedarray[i]}");
                    if (unsanitizedarray[i] > biggestfoundint)
                    {
                        biggestfoundint = unsanitizedarray[i];
                    }
                    sanitizedarray[i] = 0;
                }
            }
            stopwatch.Stop();
            Console.Write("/returned variables");
            Console.Write("/Sanitizer.dapi.complt |> ");
            Console.Write($"[Info]: ");
            Console.Write($"<| TotalCorruptedValuesSanned:{corruptedvaluesfound}");
            Console.Write($"/BiggestIndexValFound:{biggestfoundint}");
            Console.Write($"/TotalWeightOfCorruptedValuesFound:{big}");
            Console.Write($"/ExecutionDoneIn:{stopwatch.ElapsedTicks}.ticks |>");
            Console.WriteLine(" :[Info]");
            return sanitizedarray;
        }
    }
}