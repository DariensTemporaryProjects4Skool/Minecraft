using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Darien
//Rebecca Ysbrand
// Rylee 123
namespace Minecraft
{
    public partial class Form1 : Form
    {

        AssemblyCommand command = new AssemblyCommand();
        Parser parser = new Parser();
        List<AssemblyCommand> commands = new List<AssemblyCommand>();
        Commands Command = new Commands();
        Registers registers = new Registers();

        public Form1()
        {
            InitializeComponent();  

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateRegisterDisplay(registers);
        }


        //private void ExecuteCommand()
        //{
        //    List<AssemblyCommand> commands = new List<AssemblyCommand>();
        //    Parser parser = new Parser();
        //    parser.ParseUserInput(richTextBox1.Text, commands);

        //    foreach (AssemblyCommand cmd in commands)
        //    {
        //        string op = cmd.Command.ToUpper();
        //        string v1 = cmd.Var1;
        //        string v2 = cmd.Var2;
        //        string v3 = cmd.Var3;

        //        switch (op)
        //        {
        //            case "LD":
        //                if (v1.StartsWith("#"))
        //                {
        //                    int val = int.Parse(v1.Substring(1));
        //                    SetRegister(v2, val);
        //                }
        //                break;

        //            case "ADD":
        //                SetRegister(v3, GetRegister(v1) + GetRegister(v2));
        //                break;

        //            case "SUB":
        //                SetRegister(v3, GetRegister(v1) - GetRegister(v2));
        //                break;

        //            case "MUL":
        //                SetRegister(v3, GetRegister(v1) * GetRegister(v2));
        //                break;

        //            case "DIV":
        //                SetRegister(v3, GetRegister(v1) / GetRegister(v2));
        //                break;

        //            case "TRP":
        //                if (v1 == "3") Close();
        //                break;
        //        }
        //    }

        //    UpdateRegisterDisplay();
        //}


        public void UpdateRegisterDisplay(Registers registers)
        {
            LblR1.Text = Registers.R1.ToString();
            LblR2.Text = Registers.R2.ToString();
            LblR3.Text = Registers.R3.ToString();
        }


        private void BtnRun_Click(object sender, EventArgs e)
        {
            //ExecuteCommand();
            string UserInput = richTextBox1.Text;

            parser.ParseUserInput(UserInput, commands);

            Command.ExecuteCommands(commands, registers);

            UpdateRegisterDisplay(registers);

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            // This will need new code for resetting the registers

            //UpdateRegisterDisplay();

            richTextBox1.Clear();

        }
    }


}
