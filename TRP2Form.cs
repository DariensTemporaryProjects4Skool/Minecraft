using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Minecraft
{
    // If you question this forms purpose c# doesn't have a prompt command like js so I had to make one that functions like it here
    // I had to make it because TRP 2 requires input straight from the user and this was the best way I could think to do it
    public partial class TRP2Form : Form
    {
        public string TextToReturn;

        public TRP2Form()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TextToReturn = txtValue.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
