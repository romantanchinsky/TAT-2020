using System;

namespace DEV_2._1_Task.Commands
{
    public class ExitCommand : ICommand
    {
        public const string COMMAND_NAME = "Exit";

        public ExitCommand() 
        { }

        public void Execute()
        {
            Environment.Exit(0);
        }

        public override string ToString()
        {
            return COMMAND_NAME;
        }
    }
}
