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
        public Form1()
        {
            InitializeComponent();
            AssemblyCommand command = new AssemblyCommand();
            Parser parser = new Parser();
            List<AssemblyCommand> commands = new List<AssemblyCommand>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
