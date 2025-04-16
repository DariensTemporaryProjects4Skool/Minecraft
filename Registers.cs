using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    public class Registers
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
