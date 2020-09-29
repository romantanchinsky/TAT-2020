using DEV_2._1_Task.Entitys;

namespace DEV_2._1_Task.Commands
{
    public class CountBrandsCommand : ICommand
    {
        public const string COMMAND_NAME = "Count Types";

        public CountBrandsCommand()
        { }

        public void Execute()
        {
            CarShowroom.GetInstance().CountBrands();
        }

        public override string ToString()
        {
            return COMMAND_NAME;
        }
    }
}
