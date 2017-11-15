using ListProcessing.Core;

namespace ListProcessing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var dispatcher = new CommandDispatcher();
            var engine = new Engine(dispatcher);
            engine.Run();
        }
    }
}
