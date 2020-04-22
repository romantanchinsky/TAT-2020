using DEV_2._1_Task.Entitys;
using System;

namespace DEV_2._1_Task
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            ConsoleWriter consoleWriter = new ConsoleWriter();
            CarShowroom carShowroom = CarShowroom.GetInstance();
            Invoker invoker = new Invoker();
            carShowroom.MethodExecute += consoleWriter.Write;
            CommandManager commandManager = new CommandManager();

            for (; ; )
            {
                try
                {
                    invoker.SetCommand(commandManager.CreateCommand(Console.ReadLine()));
                    invoker.ExecuteCommand();
                }
                catch(Exception ex)
                {
                    consoleWriter.Write(null, ex.Message);
                }
            }
        }
    }
}
