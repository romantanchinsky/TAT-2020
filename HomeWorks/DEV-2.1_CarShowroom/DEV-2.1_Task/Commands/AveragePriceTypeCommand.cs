using DEV_2._1_Task.Entitys;

namespace DEV_2._1_Task.Commands
{
    public class AveragePriceTypeCommand : ICommand
    {
        public const string COMMAND_NAME = "Average Price Type";

        private string _type;

        public AveragePriceTypeCommand(string type)
        {
            _type = type;
        }

        public void Execute()
        {
            CarShowroom.GetInstance().AveragePriceType(_type);
        }

        public override string ToString()
        {
            return COMMAND_NAME;
        }
    }
}
