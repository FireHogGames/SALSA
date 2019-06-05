using System;
using System.Collections.Generic;
using System.Text;

namespace SALSA
{
    public enum LogLevel
    {
        info,
        warning,
        error
    }

    //Make logging errors and communicating with the user easier
    class Logging
    {
        
        public void Log(LogLevel level, string message)
        {
            //Zero means info
            if(level == LogLevel.info)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(message);
                Console.ResetColor();
            }
            //One means warning
            if(level == LogLevel.warning)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(message);
                Console.ResetColor();
            }
            //Two means Error
            if(level == LogLevel.error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
                Console.WriteLine("Press any key to close the console...");
                Console.ReadKey();
                return;
            }
        }
    }
}
