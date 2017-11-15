using System;
using System.Collections.Generic;
using System.Linq;

namespace ListProcessing.Core
{
    public class Engine
    {
        private readonly CommandDispatcher commandDispatcher;

        public Engine(CommandDispatcher commandDispatcher)
        {
            this.commandDispatcher = commandDispatcher;
        }

        public void Run()
        { 
            List<string> data = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            while (true)
            {
                try
                {
                    List<string> input = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    if (input[0].ToLower() == "end")
                    {
                        Console.WriteLine("Finished");
                        break;
                    }
                    this.commandDispatcher.DispatchCommand(input, data);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
