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
            InitializeComponent();
            AssemblyCommand command = new AssemblyCommand();
            Parser parser = new Parser();
            List<AssemblyCommand> commands = new List<AssemblyCommand>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboCommand.Items.AddRange(new string[] {
            "LD", "STR", "JMP", "JMPZ", "JMPN", "JMPP",
            "ADD", "SUB", "MUL", "DIV", "TRP"
        });


            string[] args = { "R1", "R2", "R3", "1", "2", "3", "4", "5"};
            ComboArg1.Items.AddRange(args);
            ComboArg2.Items.AddRange(args);
            ComboArg3.Items.AddRange(args);



            UpdateRegisterDisplay();
        }

        private void UpdateRegisterDisplay()
        {
            LblR1.Text = R1.ToString();
            LblR2.Text = R2.ToString();
            LblR3.Text = R3.ToString();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            R1 = 5;
            R2 = 30;
            R3 = R1 + R2;
            UpdateRegisterDisplay();
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


    }
}
