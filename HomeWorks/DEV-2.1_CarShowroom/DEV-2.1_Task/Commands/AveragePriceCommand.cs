using DEV_2._1_Task.Entitys;
namespace DEV_2._1_Task.Commands
{
    public class AveragePriceCommand : ICommand
    {
        public const string COMMAND_NAME = "Average Price";

        public AveragePriceCommand()
        { }

        public void Execute()
        {
            CarShowroom.GetInstance().AveragePrice();
        }

        public override string ToString()
        {
            return COMMAND_NAME;
        }
    }
}
