using System;

namespace GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            long nen1 = GC.GetTotalMemory(false);
            {
                int[] values = new int[50000];
                values = null;
            }
            long nen2 = GC.GetTotalMemory(false);
            {
                GC.Collect();
            }
            long nen3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(nen1);
                Console.WriteLine(nen2);
                Console.WriteLine(nen3);
            }

            Console.WriteLine("###########");
            long bytes1 = GC.GetTotalMemory(false);
            byte[] memory = new byte[1000 * 1000 * 10];
            memory[0] = 1;
            long bytes2 = GC.GetTotalMemory(false);
            long bytes3 = GC.GetTotalMemory(true);

            Console.WriteLine(bytes1);
            Console.WriteLine(bytes2);
            Console.WriteLine(bytes2- bytes1);
            Console.WriteLine(bytes3);
            Console.WriteLine(bytes3 - bytes2);
            Console.ReadLine();
        }
    }
}
