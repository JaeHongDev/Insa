using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjhInsa.Util
{
    public partial class TestForm : Form
    {
        private string Id => id.Text;
        private string Pw => password.Text;
        public TestForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
