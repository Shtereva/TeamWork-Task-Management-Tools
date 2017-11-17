using System;
using System.Collections.Generic;

namespace ListProcessing.Core.Commands
{
    class PrependCommand
    {
        public void Execute(List<string> commandParameters, List<string> data)
        {
            if (commandParameters.Count != 1)
            {
                throw new Exception("Error: invalid command parameters");
            }

            data.Insert(0, commandParameters[0]);
            System.Console.WriteLine(string.Join(" ", data));
        }
    }
}
