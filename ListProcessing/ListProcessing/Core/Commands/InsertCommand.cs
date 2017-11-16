namespace ListProcessing.Core.Commands
{
    using System;
    using System.Collections.Generic;

    public class InsertCommand
    {
        public void Execute(List<string> commandParameters, List<string> data)
        {
            var index = int.Parse(commandParameters[0]);
            if (index < 0 || index > data.Count - 1)
            {
                throw new Exception($"Error: invalid index {index}");
            }
            var stringToInsert = commandParameters[1];
            data.Insert(index, stringToInsert);
            Console.WriteLine(string.Join(" ", data));
        }
    }
}
