using ListProcessing.Core.Commands;
using System.Collections.Generic;
using System.Linq;

namespace ListProcessing.Core
{
    public class CommandDispatcher
    {
        public void DispatchCommand(List<string> commandParameters, List<string> data)
        {
            string command = commandParameters[0];
            commandParameters = commandParameters.Skip(1).ToList();
            switch (command.ToLower())
            {
                case "append":
                    var registerUser = new AppendCommand();
                    registerUser.Execute(commandParameters, data);
                    break;
            }
        }
    }
}
