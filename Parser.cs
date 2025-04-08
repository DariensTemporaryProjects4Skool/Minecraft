using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    public class Parser
    {
        public List<AssemblyCommand> ParseUserInput(string input)
        {
            List<AssemblyCommand> commands = new List<AssemblyCommand>();
            string[] lines = input.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length < 1) continue;
                AssemblyCommand command = new AssemblyCommand
                {
                    Command = parts[0],
                    Var1 = parts.Length > 1 ? parts[1] : null,
                    Var2 = parts.Length > 2 ? parts[2] : null,
                    Var3 = parts.Length > 3 ? parts[3] : null
                };
                commands.Add(command);
            }
            return commands;
        }

        public void ExecuteCommands(List<AssemblyCommand> commands)
        {
            foreach (var cmd in commands)
            {
                string target = cmd.Var1;
                string source = cmd.Var2;
                string source2 = cmd.Var3;

                if (string.IsNullOrEmpty(target) || string.IsNullOrEmpty(source))
                {
                    Console.WriteLine("Invalid command");
                    continue;
                }
                if (string.IsNullOrEmpty(cmd.Command))
                {
                    Console.WriteLine("Command is empty");
                    continue;
                }

                switch (cmd.Command.ToUpper())
                {
                    case "LD":
                        if (int.TryParse(source, out int value))
                        {
                            Registers.SetRegisterValue(target, value);
                        }
                        break;
                    case "ADD":
                        {
                            int val1 = Registers.GetRegisterValue(source);
                            int val2 = Registers.GetRegisterValue(source2);
                            Registers.SetRegisterValue(target, val1 + val2);
                        }
                        break;
                    case "SUB":
                        {
                            int val1 = Registers.GetRegisterValue(source);
                            int val2 = Registers.GetRegisterValue(source2);
                            Registers.SetRegisterValue(target, val1 - val2);
                        }
                        break;
                    case "MUL":
                        {
                            int val1 = Registers.GetRegisterValue(source);
                            int val2 = Registers.GetRegisterValue(source2);
                            Registers.SetRegisterValue(target, val1 * val2);
                        }
                        break;
                    case "DIV":
                        {
                            int val1 = Registers.GetRegisterValue(source);
                            int val2 = Registers.GetRegisterValue(source2);
                            int result = val2 != 0 ? val1 / val2 : 0;
                        }
                        break;
                    case "TRP":
                        {
                            Console.WriteLine("Trap command executed");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Unknown command: {cmd.Command}");
                            break;
                        }
                }
            }
        }
    }

    public static class Registers
    {
        public static int R1 = 0;
        public static int R2 = 0;
        public static int R3 = 0;

        public static int GetRegisterValue(string register)
        {
            switch (register.ToUpper())
            {
                case "R1":
                    return R1;
                case "R2":
                    return R2;
                case "R3":
                    return R3;
                default:
                    throw new ArgumentException("Invalid register name");
            }
        }

        public static void SetRegisterValue(string register, int value)
        {
            switch (register.ToUpper())
            {
                case "R1":
                    R1 = value;
                    break;
                case "R2":
                    R2 = value;
                    break;
                case "R3":
                    R3 = value;
                    break;
                default:
                    throw new ArgumentException("Invalid register name");
            }
        }
    }
}
