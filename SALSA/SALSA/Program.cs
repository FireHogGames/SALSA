using System;

namespace SALSA
{
    class Program
    {
        //Constructor which starts the program
        public Program()
        {
            //Tell the user SALSA is initializing
            Logging logger = new Logging();
            logger.Log(LogLevel.info, "Initializing SALSA...");
            Run();
        }

        static void Main(string[] args)
        {
            new Program();
        }

        private void Run()
        {
            string arg = "";

            while (arg != "C")
            {
                arg = Console.ReadLine();
            }

            return;
        }
    }
}
