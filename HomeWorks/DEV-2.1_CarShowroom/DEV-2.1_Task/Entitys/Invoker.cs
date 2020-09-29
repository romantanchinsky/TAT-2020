using DEV_2._1_Task.Commands;

namespace DEV_2._1_Task.Entitys
{
    public class Invoker
    {
        public ICommand Command { get; set; }

        public Invoker()
        { }

        public void SetCommand(ICommand command)
        {
            Command = command;

        }

        public void ExecuteCommand()
        {
            Command.Execute();
        }
    }
}
