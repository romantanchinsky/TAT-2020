using DEV_2._1_Task.Entitys;

namespace DEV_2._1_Task.Commands
{
    public class CountAllCommand : ICommand
    {
        public const string COMMAND_NAME = "Count All";

        public CountAllCommand()
        { }

        public void Execute()
        {
            CarShowroom.GetInstance().CounAll();
        }

        public override string ToString()
        {
            return COMMAND_NAME;
        }
    }
}
