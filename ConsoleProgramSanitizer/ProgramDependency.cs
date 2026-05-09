using System;

namespace ConsoleProgramSanitizer
{
    public static class ProgramDependency
    {
        public static int[] randominitializer(int arraylen)
        {
            Random r = new Random();
            Console.Write("<| random.dapi.strting");

            int[] arrayy = new int[arraylen];
            Console.Write($"/Array.len({arrayy.Length})");
            Console.Write($"/output=Index:Value");
            int r3 = r.Next(1, arrayy.Length);
            for (int i = 0; i < r3; i++)
            {
                int ra = r.Next(0, arrayy.Length);
                int rb = r.Next(0, 10000);
                arrayy[ra] = rb;
                Console.Write($"/{ra}:{rb}");
            }
            Console.Write("/returned variables");
            Console.Write("/random.dapi.complt |>");
            return arrayy;
        }
    }
}
