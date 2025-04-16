using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    public class Commands
    {
        public void ExecuteCommands(List<AssemblyCommand> commands, Registers registers)
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
                        string Number = cmd.Var1;
                        string Location = cmd.Var2;
                        if (int.TryParse(Number, out int value))
                        {
                            Registers.SetRegisterValue(Location, value);
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
}
