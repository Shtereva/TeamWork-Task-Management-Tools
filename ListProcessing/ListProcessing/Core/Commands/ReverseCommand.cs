using System;
using System.Collections.Generic;
using System.Linq;

namespace ListProcessing.Core.Commands
{
    public class ReverseCommand
    {
        public void Execute(List<string> commandParameters, List<string> data)
        {
            if (commandParameters.Count != 0)
            {
                throw new Exception("Error: invalid command parameters");
            }

            data.Reverse();
                
            Console.WriteLine(string.Join(" ", data));
        }
    }
}
