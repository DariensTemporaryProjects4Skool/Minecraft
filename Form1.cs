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
        int R1 = 0;
        int R2 = 0;
        int R3 = 0;

        //run form to activate dancing guy
        string guy1 = "┏(-_-)┛"; 
        string guy2 = "┗(-_- )┓";
        bool isDancing = false;
        Timer danceTimer;


        public Form1()
        {
            danceTimer = new Timer();
            danceTimer.Interval = 496;
            danceTimer.Tick += DanceTimer_Tick;
            danceTimer.Start();


            InitializeComponent();
            AssemblyCommand command = new AssemblyCommand();
            Parser parser = new Parser();
            List<AssemblyCommand> commands = new List<AssemblyCommand>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "LD #10 R1\nADD R1 R2 R3\nSUB R3 R1 R2\n";

            UpdateRegisterDisplay();
        }


        private void ExecuteCommand()
        {
            List<AssemblyCommand> commands = new List<AssemblyCommand>();
            Parser parser = new Parser();
            parser.ParseUserInput(richTextBox1.Text, commands);

            foreach (AssemblyCommand cmd in commands)
            {
                string op = cmd.Command.ToUpper();
                string v1 = cmd.Var1;
                string v2 = cmd.Var2;
                string v3 = cmd.Var3;

                switch (op)
                {
                    case "LD":
                        if (v1.StartsWith("#"))
                        {
                            int val = int.Parse(v1.Substring(1));
                            SetRegister(v2, val);
                        }
                        break;

                    case "ADD":
                        SetRegister(v3, GetRegister(v1) + GetRegister(v2));
                        break;

                    case "SUB":
                        SetRegister(v3, GetRegister(v1) - GetRegister(v2));
                        break;

                    case "MUL":
                        SetRegister(v3, GetRegister(v1) * GetRegister(v2));
                        break;

                    case "DIV":
                        SetRegister(v3, GetRegister(v1) / GetRegister(v2));
                        break;

                    case "TRP":
                        if (v1 == "3") Close();
                        break;
                }
            }

            UpdateRegisterDisplay();
        }


        private void UpdateRegisterDisplay()
        {
            LblR1.Text = R1.ToString();
            LblR2.Text = R2.ToString();
            LblR3.Text = R3.ToString();
        }


        private void BtnRun_Click(object sender, EventArgs e)
        {
            ExecuteCommand();
        }


        private void btnTest_Click(object sender, EventArgs e)
        {
            R1 = 5;
            R2 = 30;
            R3 = R1 + R2;
            UpdateRegisterDisplay();
        }

        private int GetRegister(string name)
        {
            if (name == "R1") return R1;
            if (name == "R2") return R2;
            if (name == "R3") return R3;
            return 0;
        }

        private void SetRegister(string name, int value)
        {
            if (name == "R1") R1 = value;
            if (name == "R2") R2 = value;
            if (name == "R3") R3 = value;
        }


        private void DanceTimer_Tick(object sender, EventArgs e)
        {

            if (isDancing)
            {
                DancingMan.Text = guy1;
            }
            else
            {
                DancingMan.Text = guy2;
            }

            
            isDancing = !isDancing;   
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            R1 = 0;
            R2 = 0;
            R3 = 0;

            UpdateRegisterDisplay();

            richTextBox1.Clear();

            guy1 = "[¬º-°]¬";
            guy2 = "¬[º-°¬]";

        }
    }


}


        // This is all for the purpose of testing and can be replaced with your new GUI buttons and such
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    string UserInput = richTextBox1.Text;


        //    AssemblyCommand command = new AssemblyCommand();
        //    Parser parser = new Parser();
        //    List<AssemblyCommand> commands = new List<AssemblyCommand>();
        //    parser.ParseUserInput(UserInput, commands);
