﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProcessing.Core.Commands
{
    class CountCommand
    {
        public void Execute(List<string> commandParameters, List<string> data)
        {
            if (commandParameters.Count != 1)
            {
                throw new Exception("Error: invalid command parameters");
            }

            var counter = 0;
            foreach(var d in data)
            {
                if (d == commandParameters[0]) counter++;
            }
            System.Console.WriteLine(counter);
        }
    }
}
