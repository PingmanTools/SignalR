using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using BenchmarkDotNet.Running;

namespace Microsoft.AspNetCore.SignalR.Microbenchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Contains("--debug"))
            {
                args = args.Where(a => a != "--debug").ToArray();
                Console.WriteLine($"Waiting for debugger to attach. Process ID: {Process.GetCurrentProcess().Id} ");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
            }
            BenchmarkSwitcher.FromAssembly(typeof(Program).GetTypeInfo().Assembly).Run(args);

            //var bench = new MessageParserBenchmarks() { ChunkSize = 0, Format = Sockets.MessageFormat.Binary };
            //bench.Setup();
            //bench.SingleTextMessageCopy();
        }
    }
}