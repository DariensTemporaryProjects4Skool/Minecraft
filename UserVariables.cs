using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    public class UserVariables
    {
        public string VarType { get; set; } // This will be the type of variable, INT or CHAR in this case

        public int Value { get; set; } // This will be the value of the variable

        public UserVariables(string varType, int value)
        {
            VarType = varType.ToUpper();
            Value = value;
        }
    }
}
