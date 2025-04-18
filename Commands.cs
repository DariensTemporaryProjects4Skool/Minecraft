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
        private Dictionary<string, UserVariables> customVariables = new Dictionary<string, UserVariables>();

        //helper method for checking if the location is a valid register - Rebecca
        private bool IsRegister(string Location)
        {
            return !string.IsNullOrEmpty(Location) && Location.StartsWith("R") && int.TryParse(Location.Substring(1), out _);
        }

        //Checks to see if the input is a number - Rebecca
        private bool IsNumber(string input)
        {
            return int.TryParse(input, out _);
        }

        //Checks to see if the input is a user variable - Rebecca 
        private bool IsUserVariable(string input)
        {
            return customVariables.ContainsKey(input);
        }

        //grabs the input from user, and checks if it is a register, number, or declared variable, returns value - Rebecca
        private int ResolveValue(string input, Registers registers)
        {
            if (input.StartsWith("R"))
                return Registers.GetRegisterValue(input);

            else if (IsNumber(input))
                return int.Parse(input);

            else if (IsUserVariable(input))
                return customVariables[input].Value;
            else
                throw new Exception($"'{input}' is not a valid register, number, or declared variable.");
        }


        public void ExecuteCommands(List<AssemblyCommand> commands, Registers registers)
        {

            foreach (var cmd in commands)
            {
                if (cmd.Command != "TRP" && cmd.Command != "HELP")
                {
                    string input1 = cmd.Var1;  //less confusing naming.
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
                        {
                            //If Var2 is a register, load value of Var1 into appropriate register. including user vars, hopefully. - Rebecca
                            if (IsRegister(Var2))
                            {
                                try
                                {
                                    int value = ResolveValue(Var1, registers);
                                    Registers.SetRegisterValue(Var2, value);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Invalid destination register: {Var2}");
                            }
                            break;
                        }

                    case "ADD":
                        {
                            if (IsRegister(Location))
                            {
                                try
                                {
                                    int val1 = ResolveValue(Var1, registers);
                                    int val2 = ResolveValue(Var2, registers);
                                    Registers.SetRegisterValue(Location, val1 + val2);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            break;
                        }

                    case "SUB":
                        {
                            if(IsRegister(Location))
                            {
                                try
                                {
                                    int val1 = ResolveValue(Var1, registers);
                                    int val2 = ResolveValue(Var2, registers);
                                    Registers.SetRegisterValue(Location, val1 - val2);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                        }
                        break;
                        }

                    case "MUL":
                        {
                            if (IsRegister(Location))
                            {
                                try
                                {
                                    int val1 = ResolveValue(Var1, registers);
                                    int val2 = ResolveValue(Var2, registers);
                                    Registers.SetRegisterValue(Location, val1 * val2);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            break;
                        }

                    case "DIV":
                        {
                            int val1;
                            int val2;

                            if (IsRegister(Location))
                            {
                                // Check if Var1 and Var2 are valid registers or numbers
                                val1 = Var1.StartsWith("R") ? Registers.GetRegisterValue(Var1) : Convert.ToInt32(Var1);

                                if (Var2.StartsWith("R"))
                                {
                                    val2 = Registers.GetRegisterValue(Var2);
                                }
                                else
                                {
                                    if (!int.TryParse(Var2, out val2))
                                    {
                                        MessageBox.Show($"Invalid second number '{Var2}' in DIV.");
                                        break;
                                    }
                                }

                                // Division by zero check
                                if (val2 == 0 || val1 == 0)
                                {
                                    MessageBox.Show("Division by zero is not allowed.");
                                    break;
                                }

                                Registers.SetRegisterValue(Location, val1 / val2);
                            }
                            else
                            {
                                MessageBox.Show($"Invalid destination register '{Location}' in DIV.");
                            }

                            break;
                        }


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
                    case "MOV": // Moves value from one register to another (// i forgot to change this one with the helper methods)
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
                    case "CHAR": //gets value of user variables, ignores if same thing declared twice. - Rebecca
                        {
                            if (!customVariables.ContainsKey(cmd.Var1))
                            {
                                if (int.TryParse(cmd.Var2, out int val))
                                {
                                    customVariables[cmd.Var1] = new UserVariables(cmd.Command, val);
                                    MessageBox.Show($"Variable '{cmd.Var1}' declared with value {val}.");
                                }
                                else
                                {
                                    MessageBox.Show($"Invalid value for variable '{cmd.Var1}'.");
                                }
                            }
                            break;
                        }

                    case "HELP": // can be removed once menu strip is in place, or just left in for fun - Rebecca
                        {
                            try
                            {
                                using (About about = new About())
                                {
                                    about.ShowDialog();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error opening About form: {ex.Message}");
                            }
                            break;
                        }
                    default:
                        {
                            MessageBox.Show($"Unknown command: {cmd.Command}");
                            break;
                        }
                }
            }
        }
    }
}
