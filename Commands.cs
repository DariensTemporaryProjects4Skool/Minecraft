using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft
{
    public class Commands
    {
        private Dictionary<string, UserVariables> userVariables = new Dictionary<string, UserVariables>();

        public void ExecuteCommands(List<AssemblyCommand> commands, Registers registers)
        {

            foreach (var cmd in commands)
            {
                if (cmd.Command != "TRP")
                {
                    string input1 = cmd.Var1;  //better namingish?
                    string input2 = cmd.Var2;

                    if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
                    {
                        //User has to put in all the necessary parts
                        Console.WriteLine("Invalid command");
                        continue;
                    }
                }
                

                string Var1 = cmd.Var1; // Will hold a register or number
                string Var2 = cmd.Var2; // Will hold a register or number
                string Location = cmd.Var3; // Will hold only a register and will be the destination for stored value

                switch (cmd.Command.ToUpper())
                {
                    case "LD":
                        string Number = cmd.Var1;
                        string Destination = cmd.Var2;
                        if (int.TryParse(Number, out int value))
                        {
                            Registers.SetRegisterValue(Destination, value);
                        }
                        break;
                    case "ADD":
                        {
                            int val1;
                            int val2;
                            if (Location.StartsWith("R")) // Location must ALWAYS be register otherwise the command is inputted wrong 
                            {
                                if (Var1.StartsWith("R"))
                                {
                                    val1 = Registers.GetRegisterValue(Var1);
                                }
                                else
                                    val1 = Convert.ToInt32(Var1);

                                if (Var2.StartsWith("R"))
                                {
                                    val2 = Registers.GetRegisterValue(Var2);
                                }
                                else
                                    val2 = Convert.ToInt32(Var2);
                                Registers.SetRegisterValue(Location, val1 + val2);
                            }
                        }
                        break;
                    case "SUB":
                        {
                            int val1;
                            int val2;
                            if (Location.StartsWith("R")) // Location must ALWAYS be register 
                            {
                                if (Var1.StartsWith("R"))
                                {
                                    val1 = Registers.GetRegisterValue(Var1);
                                }
                                else
                                    val1 = Convert.ToInt32(Var1);

                                if (Var2.StartsWith("R"))
                                {
                                    val2 = Registers.GetRegisterValue(Var2);
                                }
                                else
                                    val2 = Convert.ToInt32(Var2);
                                Registers.SetRegisterValue(Location, val1 - val2);
                            }
                        }
                        break;
                    case "MUL":
                        {
                            int val1;
                            int val2;
                            if (Location.StartsWith("R")) // Location must ALWAYS be register 
                            {
                                if (Var1.StartsWith("R"))
                                {
                                    val1 = Registers.GetRegisterValue(Var1);
                                }
                                else
                                    val1 = Convert.ToInt32(Var1);

                                if (Var2.StartsWith("R"))
                                {
                                    val2 = Registers.GetRegisterValue(Var2);
                                }
                                else
                                    val2 = Convert.ToInt32(Var2);
                                Registers.SetRegisterValue(Location, val1 * val2);
                            }
                        }
                        break;
                    case "DIV":
                        {
                            int val1;
                            int val2;
                            if (Location.StartsWith("R")) // Location must ALWAYS be register
                            {
                                if (Var1.StartsWith("R"))
                                {
                                    val1 = Registers.GetRegisterValue(Var1);
                                }
                                else
                                    val1 = Convert.ToInt32(Var1);

                                if (Var2.StartsWith("R"))
                                {
                                    val2 = Registers.GetRegisterValue(Var2);
                                    if (val2 == 0)
                                    {
                                        MessageBox.Show("Cannot divide a number by zero please try again.\n Other Commands before error were executed");
                                        break;
                                    }
                                }
                                else
                                {
                                    val2 = Convert.ToInt32(Var2);
                                    if (val2 == 0)
                                    {
                                        MessageBox.Show("Cannot divide a number by zero please try again.\n Other Commands before error were executed");
                                        break;
                                    }
                                }
                                    
                                Registers.SetRegisterValue(Location, val1 / val2);
                            }
                        }
                        break;
                    case "TRP":
                        {
                            int val1;
                            if (!Var1.StartsWith("R"))
                            {
                                val1 = Convert.ToInt32(Var1);
                                if (val1 == 1)
                                {
                                    // Ends program
                                    Application.Exit();

                                }
                                if (val1 == 2)
                                {
                                    // Input from user and places into R3
                                    using (TRP2Form trp2Form = new TRP2Form())
                                    {
                                        if (trp2Form.ShowDialog() == DialogResult.OK)
                                        {
                                            int number = Convert.ToInt32(trp2Form.TextToReturn); // Grabs input from another form

                                            Registers.SetRegisterValue("R3", number); // Sets value of R3 = Input
                                        }
                                    }


                                }
                                if (val1 == 3)
                                {
                                    // Outputs from R3 to user
                                    MessageBox.Show(Convert.ToString(Registers.GetRegisterValue("R3")));
                                }
                            }
                            break;
                        }
                    case "MOV": // Moves value from one register to another
                        {
                            int val1;

                            if (Var1.StartsWith("R"))
                            {
                                val1 = Registers.GetRegisterValue(Var1);
                            }
                            else
                                break;
                            if (Var2.StartsWith("R"))
                            {
                                Registers.SetRegisterValue(Var2, val1);
                            }
                            else
                                break;

                            break;
                        }
                    case "INT":
                    case "CHAR": //Ysbrand
                        {
                            if (!userVariables.ContainsKey(cmd.Var1))
                            {
                                int val;
                                if (int.TryParse(cmd.Var2, out val))
                                {
                                    val = Convert.ToInt32(cmd.Var2);
                                }
                                else
                                {
                                    MessageBox.Show($"Invalid value for variable '{cmd.Var1}'.");
                                    break;
                                }
                                userVariables[cmd.Var1] = new UserVariables(cmd.Command, val);
                            }
                            else
                            {
                                MessageBox.Show($"Variable '{cmd.Var1}' already declared.");
                            }

                            MessageBox.Show($"Variable '{cmd.Var1}' of type '{cmd.Command}' with value {userVariables[cmd.Var1].Value} declared.");
                            break;
                        }
                    default:
                        {
                            MessageBox.Show($"Unknown command: {cmd.Command}. Other commands before error were executed ");
                            break;
                        }
                }
            }
        }
    }
}
