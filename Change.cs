using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Form1;
using System.Xml.Linq;

namespace WindowsFormsApp1
{

    public partial class Change : Form
    {
        int Cheker = 0;
        int CounterOne = 0;
        int RememberedID = 0;
        public Change()
        {
            InitializeComponent();
        }

        private void redact_Click(object sender, EventArgs e)
        {
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void crest_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
