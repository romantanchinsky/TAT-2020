using DEV_2._1_Task.Commands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_2._1_Task.Entitys
{
    public class CommandManager
    {
        private const string COMMAND_NOT_FOUND_ARGUMENT_EXCEPTION_MESSAGE = "Command not found",
                             INCORRECT_COMMAND_FORMAT_EXCEPTION_MESSAGE = "Incorrect command";
        private const char SPACE_SYMBOL = ' ';
        private Dictionary<string, Func<string[], ICommand>> _commands;
        private static string[] _commandNames = new string[]
            {
                AveragePriceCommand.COMMAND_NAME,
                CountAllCommand.COMMAND_NAME,
                CountBrandsCommand.COMMAND_NAME,
                ExitCommand.COMMAND_NAME,
                AddCarsCommand.COMMAND_NAME
            };

        private ICommand CreateAveragePriceCommand(string[] arguments)
        {
            if (arguments.Length == 0)
            {
                return new AveragePriceCommand();
            }
            if (arguments.Length == 1)
            {
                return new AveragePriceTypeCommand(arguments[0]);
            }
            throw new ArgumentException(INCORRECT_COMMAND_FORMAT_EXCEPTION_MESSAGE);

        }

        private ICommand CreateCountAllCommand(string[] arguments)
        {
            return arguments.Length == 0 ? new CountAllCommand() : throw new ArgumentException(INCORRECT_COMMAND_FORMAT_EXCEPTION_MESSAGE);
        }

        private ICommand CreateCountBrandsCommand(string[] arguments)
        {
            return arguments.Length == 0 ? new CountBrandsCommand() : throw new ArgumentException(INCORRECT_COMMAND_FORMAT_EXCEPTION_MESSAGE);
        }

        private ICommand CreateExitCommand(string[] arguments)
        {
            return arguments.Length == 0 ? new ExitCommand() : throw new ArgumentException(INCORRECT_COMMAND_FORMAT_EXCEPTION_MESSAGE);
        }

        private ICommand CreateAddCarsCommand(string[] arguments)
        {
            return arguments.Length == 4 ? new AddCarsCommand(arguments) : throw new ArgumentException(INCORRECT_COMMAND_FORMAT_EXCEPTION_MESSAGE);
        }

        public CommandManager()
        {
            _commands = new Dictionary<string, Func<string[], ICommand>>();
            _commands.Add(AveragePriceCommand.COMMAND_NAME, CreateAveragePriceCommand);
            _commands.Add(CountAllCommand.COMMAND_NAME, CreateCountAllCommand);
            _commands.Add(CountBrandsCommand.COMMAND_NAME, CreateCountBrandsCommand);
            _commands.Add(ExitCommand.COMMAND_NAME, CreateExitCommand);
            _commands.Add(AddCarsCommand.COMMAND_NAME, CreateAddCarsCommand);
        }

        private string GetCommandName(string consoleString)
        {
            foreach (var commandName in _commandNames)
            {
                if (consoleString.IndexOf(commandName) == 0)
                {
                    return commandName;
                }
            }
            throw new ArgumentException(COMMAND_NOT_FOUND_ARGUMENT_EXCEPTION_MESSAGE);
        }

        private string[] GetArguments(string consoleString, string commandName)
        {
            return consoleString.Substring(commandName.Length).Split(SPACE_SYMBOL).Where(argument => argument != String.Empty).ToArray();
        }

        public ICommand CreateCommand(string consoleString)
        {
            string commandName = GetCommandName(consoleString);
            string[] arguments = GetArguments(consoleString, commandName);
            return _commands[commandName](arguments);
        }

    }
}
