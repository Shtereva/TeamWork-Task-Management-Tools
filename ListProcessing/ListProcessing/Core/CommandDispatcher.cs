﻿using ListProcessing.Core.Commands;
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
                case "insert":
                    var insertCommand = new InsertCommand();
                    insertCommand.Execute(commandParameters, data);
                    break;
                case "delete":
                    var deleteCommand = new DeleteCommand();
                    deleteCommand.Execute(commandParameters, data);
                    break;
                case "roll":
                    if (commandParameters[0].ToLower() == "left")
                    {
                        var rollLeftCommand = new RollLeftCommand();
                        rollLeftCommand.Execute(commandParameters, data);
                    }
                    if (commandParameters[0].ToLower() == "right")
                    {
                        var rollRightCommand = new RollRightCommand();
                        rollRightCommand.Execute(commandParameters, data);
                    }
                    break;
     
            }
        }
    }
}
