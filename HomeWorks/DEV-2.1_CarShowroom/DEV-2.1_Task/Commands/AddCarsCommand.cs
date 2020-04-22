using DEV_2._1_Task.Entitys;

namespace DEV_2._1_Task.Commands
{
    class AddCarsCommand : ICommand
    {
        public const string COMMAND_NAME = "Add Cars";

        private string[] _arguments;
        public AddCarsCommand(string[] arguments)
        {
            _arguments = arguments;
        }

        public void Execute()
        {
            CarShowroom.GetInstance().AddCars(_arguments);
        }

        public override string ToString()
        {
            return COMMAND_NAME;
        }
    }
}
