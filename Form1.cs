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
        private Dictionary<string, UserVariables> customVariables = new Dictionary<string, UserVariables>();


        public Form1()
        {
            InitializeComponent();  

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateRegisterDisplay(registers);
        }

        public void UpdateRegisterDisplay(Registers registers)
        {
            LblR1.Text = Registers.R1.ToString();
            LblR2.Text = Registers.R2.ToString();
            LblR3.Text = Registers.R3.ToString();
        }


        private void BtnRun_Click(object sender, EventArgs e)
        {
            string UserInput = richTextBox1.Text;

            parser.ParseUserInput(UserInput, commands);

            Command.ExecuteCommands(commands, registers);

            UpdateRegisterDisplay(registers);

            commands.Clear(); // Found a bug that ALL commands are being kept so this clears to prevent weird issues with boxes appearing twice

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Resets the rich textbox and clears the register values

            Registers.R1 = 0;
            Registers.R2 = 0;
            Registers.R3 = 0;

            UpdateRegisterDisplay(registers);

            richTextBox1.Clear();

        }

        private void btnClearUserVars_Click(object sender, EventArgs e)
        {
            customVariables.Clear();
        }

        private void generalInfoToolStripMenuItem_Click(object sender, EventArgs e)
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
        }
    }


}
