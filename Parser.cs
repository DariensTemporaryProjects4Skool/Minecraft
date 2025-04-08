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
    }
}
