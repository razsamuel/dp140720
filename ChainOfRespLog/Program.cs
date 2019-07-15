using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    class Program
    {
        static void Main(string[] args)
        {
            LogHandlerBase infoHandler = new InfoHandler();
            LogHandlerBase debugHandler = new DebugHandler();
            LogHandlerBase errorHandler = new ErrorHandler();
            LogHandlerBase fatalHandler = new FatalHandler();


            LogHandlerBase chainRoot = infoHandler;
            infoHandler.SetNext(debugHandler);
            debugHandler.SetNext(errorHandler);
            errorHandler.SetNext(fatalHandler);



            Console.WriteLine("Debug");
            chainRoot.log("hey", LOG_LEVEL.DEBUG);
            Console.WriteLine("==================");
            Console.WriteLine("Info");
            chainRoot.log("hey", LOG_LEVEL.INFO);
            Console.WriteLine("==================");
            Console.WriteLine("Fatal");
            chainRoot.log("hey", LOG_LEVEL.FATAL);
            Console.WriteLine("==================");
            Console.WriteLine("Error");
            chainRoot.log("hey", LOG_LEVEL.ERROR);
        }
    }
}
